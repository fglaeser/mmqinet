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
### Geting message from queue.
```csharp
using (var qmgr = MQQueueManager.Connect(queueManagerName, MQC.MQCO_NONE, channel, connectionInfo))
using (var q = qmgr.AccessQueue("QL.QUEUE1", MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_FAIL_IF_QUIESCING))
{
      var incoming = new MQMessage();
      MQGetMessageOptions gmo = new MQGetMessageOptions();
      gmo.WaitInterval = (int) TimeSpan.FromSeconds(30).TotalMilliseconds; // or MQC.MQWI_UNLIMITED;
      gmo.Options |= MQC.MQGMO_WAIT;
      gmo.Options |= MQC.MQGMO_SYNCPOINT;
      q.Get(incoming, gmo);
      Console.WriteLine(incoming.ReadString(incoming.DataLength));
}
```
