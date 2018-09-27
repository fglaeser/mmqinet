using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public class MQQueueManager : IMQQueueManager
  {
    internal int objectHandle;
    public int Handle { get { return objectHandle; } }
    public int ObjectType { protected set; get; }
    public string ObjectName { protected set; get; }

    public bool IsConnected
    {
      get
      {
        return IsHandleValid;
      }
    }

    internal bool IsHandleValid
    {
      get
      {
        return objectHandle != MQC.MQHO_NONE && MQC.MQHO_UNUSABLE_HOBJ != objectHandle;
      }
    }

    public static IMQQueueManager Connect(string queueMgrName, int options, string channel = null, string connectionInfo = null, string user = null, string password = null)
    {
      if (!string.IsNullOrEmpty(channel) && !string.IsNullOrEmpty(connectionInfo))
      {
        var qmgr = new MQQueueManager();
        qmgr.ConnectTcpClient(queueMgrName, options, channel, connectionInfo, user, password);
        return qmgr;
      }
      else if (!string.IsNullOrEmpty(queueMgrName))
      {
        return new MQQueueManager(queueMgrName);
      }
      else
      {
        throw new ArgumentNullException(nameof(queueMgrName));
      }

    }

    public MQQueueManager(string queueMgrName = "")
    {
      if (!string.IsNullOrEmpty(queueMgrName))
        Connect(queueMgrName);
    }

    public void Connect(string queueMgrName)
    {
      int hconn, compCode, reason;
      ObjectName = queueMgrName;
      ObjectType = MQC.MQOT_Q_MGR;
      Bindings.MQCONN(queueMgrName, out hconn, out compCode, out reason);

      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);

      objectHandle = hconn;
    }

    public void ConnectTcpClient(string queueMgrName, int options, string channel, string connectionInfo, string user, string password)
    {
      var cd = new MQChannelDefinition();
      cd.ChannelName = channel;
      cd.ConnectionName = connectionInfo;
      cd.ChannelType = MQC.MQCHT_CLNTCONN;
      cd.TransportType = MQC.MQXPT_TCP;
      cd.MaxMessageLength = 104857600;
      ConnectWithOptions(queueMgrName, options, cd, user, password);
    }

    public void ConnectWithOptions(string queueMgrName, int options, MQChannelDefinition cd, string user, string password)
    {
      int hconn, compCode, reason;
      IntPtr intPtrCd = IntPtr.Zero, intPtrUsr = IntPtr.Zero, intPtrPwd = IntPtr.Zero, intPtrCsp = IntPtr.Zero;
      try
      {
        var cno = new MQConnectOptions();
        cno.Version = MQC.MQCNO_VERSION_5;
        if (user != null || password != null)
        {
          var csp = new MQConnectionSecurityParameters();
          csp.AuthenticationType = MQC.MQCSP_AUTH_USER_ID_AND_PWD;
          if (user != null)
          {
            intPtrUsr = Marshal.StringToCoTaskMemAnsi(user);
            csp.CSPUserIdPtr = intPtrUsr;
            csp.CSPUserIdLength = user.Length;
          }
          if (password != null)
          {
            intPtrPwd = Marshal.StringToCoTaskMemAnsi(password);
            csp.CSPPasswordPtr = intPtrPwd;
            csp.CSPPasswordLength = password.Length;
          }
          intPtrCsp = Marshal.AllocCoTaskMem(Marshal.SizeOf(csp.StructMQCSP));
          Marshal.StructureToPtr(csp.StructMQCSP, intPtrCsp, false);
          cno.SecurityParmsPtr = intPtrCsp;
        }

        cno.Options = options;
        intPtrCd = Marshal.AllocCoTaskMem(Marshal.SizeOf(cd.StructMQCD));
        Marshal.StructureToPtr(cd.StructMQCD, intPtrCd, false);
        cno.ClientConnPtr = intPtrCd;

        ObjectName = queueMgrName;
        ObjectType = MQC.MQOT_Q_MGR;

        MQCNO structMQCNO = cno.StructMQCNO;
        Bindings.MQCONNX(queueMgrName, ref structMQCNO, out hconn, out compCode, out reason);

        if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
        objectHandle = hconn;
      }
      finally
      {
        if (intPtrCd != IntPtr.Zero) Marshal.FreeCoTaskMem(intPtrCd);
        if (intPtrUsr != IntPtr.Zero) Marshal.FreeCoTaskMem(intPtrUsr);
        if (intPtrPwd != IntPtr.Zero) Marshal.FreeCoTaskMem(intPtrPwd);
        if (intPtrCsp != IntPtr.Zero) Marshal.FreeCoTaskMem(intPtrCsp);
      }
    }

    public void Disconnect()
    {
      if (!IsHandleValid) throw new InvalidOperationException("Not connected.");
      int compCode, reason;
      Bindings.MQDISC(out objectHandle, out compCode, out reason);

      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);

      objectHandle = MQC.MQHC_UNUSABLE_HCONN;
    }

    public void Commit()
    {
      int compCode, reason;
      Bindings.MQCMIT(objectHandle, out compCode, out reason);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
    }

    public void Backout()
    {
      int compCode, reason;
      Bindings.MQBACK(objectHandle, out compCode, out reason);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
    }

    public void Put1(MQObjectDescriptor od, MQMessage message, MQPutMessageOptions pmo)
    {
      int compCode, reason;
      if (message == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_MD_ERROR);
      if (pmo == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_PMO_ERROR);

      od.CopyCHARVIntoOD();
      pmo.ValidateOptions();
      byte[] buffer = message.GetBuffer();
      var structMQMD = message.md.StructMQMD;
      var structMQPMO = pmo.StructMQPMO;
      if (od.Version == MQC.MQOD_VERSION_1 || od.Version == MQC.MQOD_VERSION_2)
      {
        var structMQOD = od.StructMQOD;
        Bindings.MQPUT1(objectHandle, ref structMQOD, ref structMQMD, ref structMQPMO, buffer.Length, buffer, out compCode, out reason);
      }
      else
      {
        byte[] array = new byte[od.GetRequiredBufferSize()];
        od.WriteStruct(array, 0);
        IntPtr intPtr = Marshal.AllocCoTaskMem(array.Length);
        try
        {
          Marshal.Copy(array, 0, intPtr, array.Length);
          Bindings.MQPUT1(objectHandle, intPtr, ref structMQMD, ref structMQPMO, buffer.Length, buffer, out compCode, out reason);
        }
        finally
        {
          if (intPtr != IntPtr.Zero) Marshal.FreeCoTaskMem(intPtr);
        }
      }
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
    }

    public void Dispose()
    {
      if (IsConnected)
      {
        Disconnect();
      }
    }
  }

}
