using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mmqi;
using System;

namespace Test.Mmqi
{
  [TestClass]
  public class QueueManagerUnitTest
  {
    public string QueueManagerName => "GA02.AR.T.QM";
    public string Channel => "ITG.TO.GA02.TEST";
    public string ConnectionInfo => "192.6.6.39(1416)";
    public string QueueName => "QL.ITG.ALERTRAN.SUBSCRIBER.BOQ";

    [TestMethod, TestCategory("MQQueueManager")]
    public void ConnectToMQServer_Ok()
    {
      var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo);
      broker.Disconnect();
    }

    [TestMethod, TestCategory("MQQueueManager")]
    public void ConnectToMQServer_ThrowsQMgrNameError()
    {
      try
      {
        var broker = MQQueueManager.Connect(QueueManagerName + "qq", 0, Channel, ConnectionInfo);
        broker.Disconnect();
      }
      catch (MQException e)
      {
        Assert.AreEqual(MQC.MQRC_Q_MGR_NAME_ERROR, e.Reason);
      }
    }

    [TestMethod, TestCategory("MQQueueManager")]
    public void ConnectToMQServer_ThrowsUnknownChannelName()
    {
      try
      {
        var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel + "cc", ConnectionInfo);
        broker.Disconnect();
      }
      catch (MQException e)
      {
        Assert.AreEqual(MQC.MQRC_UNKNOWN_CHANNEL_NAME, e.Reason);
      }
    }

    [TestMethod, TestCategory("MQQueueManager")]
    public void ConnectToMQServer_ThrowsHostNotAvailable()
    {
      try
      {
        var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, "192.6.6.38(1416)");
        broker.Disconnect();
      }
      catch (MQException e)
      {
        Assert.AreEqual(MQC.MQRC_HOST_NOT_AVAILABLE, e.Reason);
      }
    }

    [TestMethod, TestCategory("MQQueueManager")]
    public void Put1InQueue_Ok()
    {
      string message = "Put1InQueue";
      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
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
          ObjectName = QueueName
        };
        broker.Put1(od, outgoing, new MQPutMessageOptions());

        using (var q = broker.AccessQueue(QueueName, MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
        {
          var incoming = new MQMessage();
          MQGetMessageOptions gmo = new MQGetMessageOptions();
          gmo.WaitInterval = (int) TimeSpan.FromSeconds(30).TotalMilliseconds; //MQC.MQWI_UNLIMITED;
          gmo.Options |= MQC.MQGMO_WAIT;
          gmo.Options |= MQC.MQGMO_SYNCPOINT;
          q.Get(incoming, gmo);
          Assert.AreEqual(message, incoming.ReadString(incoming.DataLength));
        }
      }
    }

    [TestMethod, TestCategory("MQQueueManager")]
    public void Backout()
    {

    }

    [TestMethod, TestCategory("MQQueueManager")]
    public void Commit()
    {

    }

    [TestMethod, TestCategory("MQQueue")]
    public void OpenQueue_Ok()
    {

    }

    [TestMethod, TestCategory("MQQueue")]
    public void OpenQueue_ThrowsObjectNameError() 
    {

    }

    [TestMethod, TestCategory("MQQueue")]
    public void QueuePut_Ok() { }

    [TestMethod, TestCategory("MQQueue")]
    public void QueueGet_Ok() { }

    [TestMethod, TestCategory("MQTopic")]
    public void OpenTopic_Ok()
    {

    }

    [TestMethod, TestCategory("MQTopic")]
    public void OpenTopic_ThrowsObjectNameError()
    {

    }

    [TestMethod, TestCategory("MQTopic")]
    public void TopicPublish_Ok() { }

  }
}
