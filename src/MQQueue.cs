using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public class MQQueue : IMQQueue
  {
    protected static int defaultMaxMsgSize = 4096;

    private IMQQueueManager _qMgr;
    private string _queueName;
    private int _openOptions;
    private int _handle = -1;

    public int Handle { get { return _handle; } }

    public bool IsOpen
    {
      get
      {
        return _handle != 0 && -1 != _handle;
      }
    }

    public MQQueue(IMQQueueManager queueMgr, string queueName, int openOptions) : this(queueMgr)
    {
      _queueName = queueName;
      _openOptions = openOptions;
      RealOpen();
    }

    public MQQueue(IMQQueueManager queueMgr)
    {
      _qMgr = queueMgr;
    }

    public void Open(string queueName, int openOptions)
    {
      _queueName = queueName;
      _openOptions = openOptions;
      RealOpen();
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

    public void Get(MQMessage message, MQGetMessageOptions gmo)
    {
      int dataLength, compCode, reason;
      if (message == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_MD_ERROR);
      if (gmo == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_GMO_ERROR);
      message.ClearMessage();
      var structMQMD = message.md.StructMQMD;
      var structMQGMO = gmo.StructMQGMO;
      var buffer = new byte[defaultMaxMsgSize];
      Bindings.MQGET(_qMgr.Handle, _handle, ref structMQMD, ref structMQGMO, defaultMaxMsgSize, buffer, out dataLength, out compCode, out reason);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
      if(dataLength > 0)
      {
        message.Write(buffer, 0, (dataLength < defaultMaxMsgSize) ? dataLength : defaultMaxMsgSize);
        message.Seek(0);
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
        _queueName = null;
        _openOptions = MQC.MQCO_NONE;
      }
    }

    private void RealOpen()
    {
      if (string.IsNullOrEmpty(_queueName)) throw new InvalidOperationException("queueName");
      int hobj, compCode, reason;
      var od = new MQObjectDescriptor();
      od.ObjectType = MQC.MQOT_Q;
      od.ObjectName = _queueName;
      MQOD structMQOD = od.StructMQOD;
      Bindings.MQOPEN(_qMgr.Handle, ref structMQOD, _openOptions, out hobj, out compCode, out reason);
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
