using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mmqi;

namespace Test.Mmqi
{
  [TestClass]
  public class QueueManagerUnitTest
  {
    public string QueueManagerName => "GA02.AR.T.QM";
    public string Channel => "ITG.TO.GA02.TEST";
    public string ConnectionInfo => "192.6.6.39(1416)";
    public string QueueName => "QL.ITG.ALERTRAN.SUBSCRIBER.BOQ";

    [TestMethod]
    public void ConnectToMQServer_Ok()
    {
      var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo);
      broker.Disconnect();
    }

    [TestMethod]
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

    [TestMethod]
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

    [TestMethod]
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


    [TestMethod]
    public void Put1InQueue_Ok()
    {
      using(var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      {
        var message = new MQMessage()
        {
          CharacterSet = MQC.CODESET_UTF,
          Encoding = MQC.MQENC_NORMAL
        };
        message.WriteString("Put1InQueue");


        var od = new MQObjectDescriptor
        {
          ObjectType = MQC.MQOT_Q,
          ObjectName = QueueName
        };
        broker.Put1(od, message, new MQPutMessageOptions());

        using (var q = broker.AccessQueue(QueueName, MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
        {
          q.Get()
        }

      }
    }

  }
}
