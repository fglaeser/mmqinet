# Minimalist MQI.Net
Our own .Net Core interface for IBM MQ (WebSphere MQ, MQSeries) with Blackjack and Hookers.

## Examples
### Open queue manager and put message in a queue.
```csharp
      string message = "Put1InQueue";
      var queueManagerName = "QM01";
      var channel = "SVRCONN.1";
      var connectionInfo = "192.168.99.100(1414)";
      using (var qmgr = MQQueueManager.Connect(queueManagerName, MQC.MQCO_NONE, channel, connectionInfo))
      {
        var outgoing = new MQMessage()
        {
          CharacterSet = MQC.CODESET_UTF,
          Encoding = MQC.MQENC_NORMAL
        };
        outgoing.WriteString(message);

        var od = new MQObjectDescriptor
        {
          ObjectType = MQC.MQOT_Q,
          ObjectName = "QL.QUEUE1"
        };
        qmgr.Put1(od, outgoing, new MQPutMessageOptions());
      }
```
### Alternatively, use the Put extension method to make the code cleaner.
```csharp
      using (var qmgr = MQQueueManager.Connect(queueManagerName, MQC.MQCO_NONE, channel, connectionInfo))
      {
        var outgoing = new MQMessage()
        {
          CharacterSet = MQC.CODESET_UTF,
          Encoding = MQC.MQENC_NORMAL
        };
        outgoing.WriteString(message);

        qmgr.Put("QL.QUEUE1", outgoing);
      }
```
### Use the Publish extension method to publish message in a topic.
```csharp
      using (var qmgr = MQQueueManager.Connect(queueManagerName, MQC.MQCO_NONE, channel, connectionInfo))
      {
        var outgoing = new MQMessage()
        {
          CharacterSet = MQC.CODESET_UTF,
          Encoding = MQC.MQENC_NORMAL
        };
        outgoing.WriteString(message);

        qmgr.Publish("Some/Topic", outgoing);
      }
```

