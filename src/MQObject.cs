using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public abstract class MQObject
  {
    protected static int defaultMaxMsgSize = 4096;

    protected IMQQueueManager qMgr;

    internal int objectHandle;
    public int Handle { get { return objectHandle; } }
    public int ObjectType { protected set; get; }
    public string ObjectName { protected set; get; }
    public int OpenOptions { get; set; }
    public int CloseOptions { get; set; }
    public bool IsOpen
    {
      get
      {
        return objectHandle != MQC.MQHO_NONE && MQC.MQHO_UNUSABLE_HOBJ != objectHandle;
      }
    }

    protected void Open(MQObjectDescriptor od)
    {
      int hobj, compCode, reason;
      od.CopyCHARVIntoOD();

      if (od.Version == MQC.MQOD_VERSION_1 || od.Version == MQC.MQOD_VERSION_2)
      {
        MQOD structMQOD = od.StructMQOD;
        Bindings.MQOPEN(qMgr.Handle, ref structMQOD, OpenOptions, out hobj, out compCode, out reason);
      }
      else
      {
        byte[] array = new byte[od.GetRequiredBufferSize()];
        od.WriteStruct(array, 0);
        IntPtr intPtr = Marshal.AllocCoTaskMem(array.Length);
        try
        {
          Marshal.Copy(array, 0, intPtr, array.Length);
          Bindings.MQOPEN(qMgr.Handle, intPtr, OpenOptions, out hobj, out compCode, out reason);
        }
        finally
        {
          if (intPtr != IntPtr.Zero) Marshal.FreeCoTaskMem(intPtr);
        }
      }

      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
      objectHandle = hobj;
      ObjectName = od.ObjectName;
      ObjectType = od.ObjectType;
    }

    public virtual void Close()
    {
      int compCode, reason;
      if (qMgr != null && qMgr.IsConnected && IsOpen)
      {
        Bindings.MQCLOSE(qMgr.Handle, ref objectHandle, CloseOptions, out compCode, out reason);
        if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
        objectHandle = MQC.MQHO_UNUSABLE_HOBJ;
        ObjectName = null;
        OpenOptions = CloseOptions = MQC.MQCO_NONE;
      }
    }
  }

}
