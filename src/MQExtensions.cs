namespace Mmqi
{
  public static class MQExtensions
  {
    public static IMQQueue AccessQueue(this IMQQueueManager @this, string queueName, int openOptions)
    {
      return new MQQueue(@this, queueName, openOptions);
    }
    public static MQTopic AccessTopic(this IMQQueueManager @this, string topicName, string topicObject, int openAs, int options)
    {
      return new MQTopic(@this, topicName, topicObject, openAs, options);
    }
    public static IMQPubSub AccessTopicForPub(this IMQQueueManager @this, string topicName, string topicObject, int options)
     => AccessTopic(@this, topicName, topicObject, MQC.MQTOPIC_OPEN_AS_PUBLICATION, options);
    public static IMQPubSub AccessTopicForSubs(this IMQQueueManager @this, string topicName, string topicObject, int options)
     => AccessTopic(@this, topicName, topicObject, MQC.MQTOPIC_OPEN_AS_SUBSCRIPTION, options);

    public static void Put(this IMQQueueManager @this, string queueName, MQMessage message)
    {
      @this.Put(queueName, message, new MQPutMessageOptions());
    }
    public static void Put(this IMQQueueManager @this, string queueName, MQMessage message, MQPutMessageOptions pmo)
    {
      var od = new MQObjectDescriptor
      {
        ObjectType = MQC.MQOT_Q,
        ObjectName = queueName
      };
      @this.Put1(od, message, pmo);
    }

    public static void Publish(this IMQQueueManager @this, string topicName, MQMessage message)
    {
      @this.Publish(topicName, message, new MQPutMessageOptions());
    }
    public static void Publish(this IMQQueueManager @this, string topicName, MQMessage message, MQPutMessageOptions pmo)
    {
      var od = new MQObjectDescriptor
      {
        ObjectType = MQC.MQOT_TOPIC,
        ObjectName = string.Empty,
        Version = MQC.MQOD_VERSION_4
      };
      od.ObjectString.VSString = topicName;
      @this.Put1(od, message, pmo);
    }
    public static void Put(this IMQQueue @this, MQMessage message) => @this.Put(message, new MQPutMessageOptions());
    public static void Publish(this IMQPubSub @this, MQMessage message) => @this.Publish(message, new MQPutMessageOptions());

    public static string ReadAll(this MQMessage @this)
    { 
      var message = @this.ReadString(@this.DataLength);
      @this.Seek(0);
      return message;
    }
  }
}
