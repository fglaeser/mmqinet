using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public static class MQQueueManagerExtensions
  {
    public static IMQQueue AccessQueue(this IMQQueueManager @this, string queueName, int openOptions)
    {
      return new MQQueue(@this, queueName, openOptions);
    }
    public static MQTopic AccessTopic(this IMQQueueManager @this, string topicName, string topicObject, int openAs, int options)
    {
      return new MQTopic(@this, topicName, topicObject, openAs, options);
    }
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
