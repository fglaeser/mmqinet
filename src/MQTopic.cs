using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public class MQTopic : MQObject, IMQPubSub
  {
    private readonly string _topicName;

    private MQTopic(IMQQueueManager queueMgr)
    {
      qMgr = queueMgr;
    }

    public MQTopic(IMQQueueManager queueMgr, string topicName, string topicObject, int openAs, int options) : this(queueMgr)
    {
      _topicName = topicName;
      ObjectName = topicObject;
      OpenOptions = options;
      if(openAs == MQC.MQTOPIC_OPEN_AS_SUBSCRIPTION)
      {
        OpenForSubscription();
      }
      else
      {
        OpenForPublication();
      }
    }

    public void Publish(MQMessage message, MQPutMessageOptions pmo)
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

    public void Subscribe() { throw new NotSupportedException(); }

    private void OpenForSubscription()
    {
      throw new NotImplementedException();
    }

    private void OpenForPublication()
    {
      var od = new MQObjectDescriptor
      {
        ObjectType = MQC.MQOT_TOPIC,
        ObjectName = ObjectName,
        Version = MQC.MQOD_VERSION_4
      };
      od.ObjectString.VSString = _topicName;
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
