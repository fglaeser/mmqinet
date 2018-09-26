using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public class MQTopic : IDisposable
  {
    private IMQQueueManager _qMgr;
    private string _topicName;
    private string _topicObject;
    private int _options;
    private int _handle = -1;

    public bool IsOpen
    {
      get
      {
        return _handle != MQC.MQHO_NONE && MQC.MQHO_UNUSABLE_HOBJ != _handle;
      }
    }

    public MQTopic(IMQQueueManager queueMgr)
    {
      _qMgr = queueMgr;
    }

    public MQTopic(IMQQueueManager queueMgr, string topicName, string topicObject, int openAs, int options) : this(queueMgr)
    {
      _topicName = topicName;
      _topicObject = topicObject;
      _options = options;
      if(openAs == MQC.MQTOPIC_OPEN_AS_SUBSCRIPTION)
      {
        OpenForSubscription();
      }
      else
      {
        OpenForPublication();
      }

    }

    public void Close(int options = MQC.MQCO_NONE)
    {
      int compCode, reason;
      if (_qMgr != null && _qMgr.IsConnected && IsOpen)
      {
        Bindings.MQCLOSE(_qMgr.Handle, ref _handle, options, out compCode, out reason);
        if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
        _handle = MQC.MQHO_UNUSABLE_HOBJ;
        _topicName = _topicObject = null;
        _options = MQC.MQCO_NONE;
      }
    }

    public void Put(MQMessage message, MQPutMessageOptions pmo)
    {
      int compCode, reason;
      if (message == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_MD_ERROR);
      if (pmo == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_PMO_ERROR);
      pmo.ValidateOptions();
      byte[] buffer = message.GetBuffer();
      var structMQMD = message.md.StructMQMD;
      var structMQPMO = pmo.StructMQPMO;
      Bindings.MQPUT(_qMgr.Handle, _handle, ref structMQMD, ref structMQPMO, buffer.Length, buffer, out compCode, out reason);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
    }

    public void Put(MQMessage message)
    {
      Put(message, new MQPutMessageOptions());
    }

    private void OpenForSubscription()
    {
      throw new NotImplementedException();
    }

    private void OpenForPublication()
    {
      int hobj, compCode, reason;
      var od = new MQObjectDescriptor
      {
        ObjectType = MQC.MQOT_TOPIC,
        ObjectName = _topicObject,
        Version = MQC.MQOD_VERSION_4
      };
      od.ObjectString.VSString = _topicName;
      od.CopyCHARVIntoOD();
      byte[] array = new byte[od.GetRequiredBufferSize()];
      od.WriteStruct(array, 0);
      IntPtr intPtr = Marshal.AllocCoTaskMem(array.Length);
      Marshal.Copy(array, 0, intPtr, array.Length);
      Bindings.MQOPEN(_qMgr.Handle, intPtr, _options, out hobj, out compCode, out reason);
      Marshal.FreeCoTaskMem(intPtr);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
      _handle = hobj;
    }

    public void Dispose()
    {
      if (IsOpen)
      {
        Close();
      }
    }
  }
}
