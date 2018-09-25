using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public static class MQQueueManagerExtensions
  {
    public static void PutInQueue(this IMQQueueManager @this, string queueName, MQMessage message)
    {
      @this.PutInQueue(queueName, message, new MQPutMessageOptions());
    }
    public static void PutInQueue(this IMQQueueManager @this, string queueName, MQMessage message, MQPutMessageOptions pmo)
    {
      var od = new MQObjectDescriptor
      {
        ObjectType = MQC.MQOT_Q,
        ObjectName = queueName
      };
      @this.Put1(od, message, pmo);
    }
    public static void PutInTopic(this IMQQueueManager @this, string topicName, MQMessage message)
    {
      @this.PutInTopic(topicName, message, new MQPutMessageOptions());
    }
    public static void PutInTopic(this IMQQueueManager @this, string topicName, MQMessage message, MQPutMessageOptions pmo)
    {
      var od = new MQObjectDescriptor
      {
        ObjectType = MQC.MQOT_TOPIC,
        ObjectName = topicName
      };
      @this.Put1(od, message, pmo);
    }

  }
}
