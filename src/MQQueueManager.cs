using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public class MQQueueManager : IMQQueueManager
  {
    private string _queueMgrName;
    private int _handle = -1;

    public int Handle { get { return _handle; } }

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
        return _handle != 0 && -1 != _handle;
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
      Bindings.MQCONN(queueMgrName, out hconn, out compCode, out reason);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);

      _handle = hconn;
      _queueMgrName = queueMgrName;
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

      var cno = new MQConnectOptions();
      cno.Version = MQC.MQCNO_VERSION_5;

      var csp = new MQConnectionSecurityParameters();
      csp.AuthenticationType = MQC.MQCSP_AUTH_USER_ID_AND_PWD;
      csp.UserId = user;
      csp.Password = password;

      cno.SecurityParms = csp;
      cno.Options = options;

      IntPtr intPtrCd = Marshal.AllocCoTaskMem(Marshal.SizeOf(cd.StructMQCD));
      Marshal.StructureToPtr(cd.StructMQCD, intPtrCd, false);
      cno.ClientConnPtr = intPtrCd;
      MQCNO structMQCNO = cno.StructMQCNO;
      Bindings.MQCONNX(queueMgrName, ref structMQCNO, out hconn, out compCode, out reason);

      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);

      _handle = hconn;
      _queueMgrName = queueMgrName;
    }

    public void Disconnect()
    {
      if (!IsHandleValid) throw new InvalidOperationException("Not connected.");
      int compCode, reason;
      Bindings.MQDISC(out _handle, out compCode, out reason);
      _handle = MQC.MQHC_UNUSABLE_HCONN;
    }

    public void Commit()
    {
      int compCode, reason;
      Bindings.MQCMIT(_handle, out compCode, out reason);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
    }

    public void Backout()
    {
      int compCode, reason;
      Bindings.MQBACK(_handle, out compCode, out reason);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
    }

    public void Put1(MQObjectDescriptor od, MQMessage message, MQPutMessageOptions pmo)
    {
      int compCode, reason;
      if (message == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_MD_ERROR);
      if (pmo == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_PMO_ERROR);
      pmo.ValidateOptions();
      byte[] buffer = message.GetBuffer();
      var structMQOD = od.StructMQOD;
      var structMQMD = message.md.StructMQMD;
      var structMQPMO = pmo.StructMQPMO;
      Bindings.MQPUT1(_handle, ref structMQOD, ref structMQMD, ref structMQPMO, buffer.Length, buffer, out compCode, out reason);
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
