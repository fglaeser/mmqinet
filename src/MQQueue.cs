using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public class MQQueue : MQObject, IMQQueue
  {
    public MQQueue(IMQQueueManager queueMgr, string queueName, int openOptions) : this(queueMgr)
    {
      ObjectName = queueName;
      OpenOptions = openOptions;
      RealOpen();
    }

    public MQQueue(IMQQueueManager queueMgr)
    {
      qMgr = queueMgr;
    }

    public void Open(string queueName, int openOptions)
    {
      ObjectName = queueName;
      OpenOptions = openOptions;
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
      Bindings.MQPUT(qMgr.Handle, objectHandle, ref structMQMD, ref structMQPMO, buffer.Length, buffer, out compCode, out reason);
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
    }

    public void Get(MQMessage message, MQGetMessageOptions gmo)
    {
      int dataLength, compCode, reason;
      if (message == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_MD_ERROR);
      if (gmo == null) throw new MQException(MQC.MQCC_FAILED, MQC.MQRC_GMO_ERROR);
      message.ClearMessage();
      var maxMsgSize = defaultMaxMsgSize;
      var structMQMD = message.md.StructMQMD;
      var structMQGMO = gmo.StructMQGMO;
      var buffer = new byte[maxMsgSize];
      Bindings.MQGET(qMgr.Handle, objectHandle, ref structMQMD, ref structMQGMO, maxMsgSize, buffer, out dataLength, out compCode, out reason);
      message.md.StructMQMD = structMQMD;
      while (compCode != MQC.MQCC_OK && reason == MQC.MQRC_TRUNCATED_MSG_FAILED)
      {
        maxMsgSize = dataLength;
        buffer = new byte[maxMsgSize];
        Bindings.MQGET(qMgr.Handle, objectHandle, ref structMQMD, ref structMQGMO, maxMsgSize, buffer, out dataLength, out compCode, out reason);
        message.md.StructMQMD = structMQMD;
      }
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
      if(dataLength > 0)
      {
        message.Write(buffer, 0, (dataLength < maxMsgSize) ? dataLength : maxMsgSize);
        message.Seek(0);
      }
    }

    private void RealOpen()
    {
      var od = new MQObjectDescriptor();
      od.ObjectType = MQC.MQOT_Q;
      od.ObjectName = ObjectName;
      base.Open(od);
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
