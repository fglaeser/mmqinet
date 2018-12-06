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
    public string TopicName => "R4/AltaModificacionDeEmpleados";

    public string SubscriptionTopicName => "SUB/TOPIC/TEST";

    public string UnknownValue => "UKNOWN";

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
        var broker = MQQueueManager.Connect(UnknownValue, 0, Channel, ConnectionInfo);
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
        var broker = MQQueueManager.Connect(QueueManagerName, 0, UnknownValue, ConnectionInfo);
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
      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      {
        var q = new MQQueue(broker, QueueName, MQC.MQOO_INPUT_AS_Q_DEF);
        Assert.AreNotEqual(MQC.MQHC_UNUSABLE_HCONN, q.Handle);
        Assert.AreNotEqual(MQC.MQHC_DEF_HCONN, q.Handle);
        q.Close();
      }

    }

    [TestMethod, TestCategory("MQQueue")]
    public void OpenQueue_ThrowsUnknownObjectName() 
    {
      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      {
        try
        {
          var queue = new MQQueue(broker, UnknownValue, MQC.MQOO_INPUT_AS_Q_DEF);
          queue.Close();
        }
        catch (MQException e)
        {
          Assert.AreEqual(MQC.MQRC_UNKNOWN_OBJECT_NAME, e.Reason);
        }
      }
    }

    [TestMethod, TestCategory("MQQueue")]
    public void QueuePutGet_Ok()
    {
      var message = "PutInQueue";
      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      using (var q = new MQQueue(broker, QueueName, MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
      {
        var outgoing = new MQMessage()
        {
          CharacterSet = MQC.CODESET_UTF,
          Encoding = MQC.MQENC_NORMAL
        };
        outgoing.WriteString(message);
        q.Put(outgoing, new MQPutMessageOptions());

        var incoming = new MQMessage();
        q.Get(incoming, new MQGetMessageOptions());
        Assert.AreEqual(message, incoming.ReadAll());
      }
    }

    [TestMethod, TestCategory("MQQueue")]
    public void QueueGet_Ok() { }

    [TestMethod, TestCategory("MQTopic")]
    public void OpenTopic_Ok()
    {
      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      {
        var topic = new MQTopic(broker, TopicName, string.Empty, MQC.MQTOPIC_OPEN_AS_PUBLICATION, MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING);
        Assert.AreNotEqual(MQC.MQHC_UNUSABLE_HCONN, topic.Handle);
        Assert.AreNotEqual(MQC.MQHC_DEF_HCONN, topic.Handle);
        topic.Close();
      }
    }

    [TestMethod, TestCategory("MQTopic")]
    public void TopicPublish_Ok()
    {
      var message = "PublishInTopic";
      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      using (var topic = new MQTopic(broker, TopicName, string.Empty, MQC.MQTOPIC_OPEN_AS_PUBLICATION, MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
      {
        var outgoing = new MQMessage()
        {
          CharacterSet = MQC.CODESET_UTF,
          Encoding = MQC.MQENC_NORMAL
        };
        outgoing.WriteString(message);
        topic.Publish(outgoing, new MQPutMessageOptions());
      }

      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      using (var q = broker.AccessQueue("QL.R4.EMPLEADOSANDREANI.SUBSCRIBER", MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_FAIL_IF_QUIESCING))
      {
        var incoming = new MQMessage();
        MQGetMessageOptions gmo = new MQGetMessageOptions();
        gmo.WaitInterval = (int)TimeSpan.FromSeconds(30).TotalMilliseconds; //MQC.MQWI_UNLIMITED;
        gmo.Options |= MQC.MQGMO_WAIT;
        gmo.Options |= MQC.MQGMO_SYNCPOINT;
        q.Get(incoming, gmo);
        Assert.AreEqual(message, incoming.ReadString(incoming.DataLength));
      }
    }

    [TestMethod, TestCategory("MQSubscription")]
    public void OpenSubscription_OK()
    {

      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      {

        var subs = new MQSubscription(broker);
        subs.Subscribe(
          "MY.SUBS.T1",
          MQC.MQSO_CREATE + MQC.MQSO_RESUME + MQC.MQSO_NON_DURABLE + MQC.MQSO_MANAGED, 
          TopicName);
        Assert.AreEqual(true, subs.IsOpen);
        subs.Close(MQC.MQCO_REMOVE_SUB, closeSubQueue: false, closeSubQueueOptions: MQC.MQCO_NONE);
      }

    }

    [TestMethod, TestCategory("MQSubscription")]
    public void SubscriptionGet_OK()
    {
      var message = "PublishInSubscription";
      using (var broker = MQQueueManager.Connect(QueueManagerName, 0, Channel, ConnectionInfo))
      {

        var subs = new MQSubscription(broker);
        subs.Subscribe(
          "MY.SUBS.T1",
          MQC.MQSO_CREATE + MQC.MQSO_RESUME + MQC.MQSO_NON_DURABLE + MQC.MQSO_MANAGED,
          SubscriptionTopicName);


        using (var topic = new MQTopic(broker, SubscriptionTopicName, string.Empty, MQC.MQTOPIC_OPEN_AS_PUBLICATION, MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
        {
          var outgoing = new MQMessage()
          {
            CharacterSet = MQC.CODESET_UTF,
            Encoding = MQC.MQENC_NORMAL
          };
          outgoing.WriteString(message);
          topic.Publish(outgoing, new MQPutMessageOptions());
        }


        var incoming = new MQMessage();
        MQGetMessageOptions gmo = new MQGetMessageOptions();
        gmo.WaitInterval = (int)TimeSpan.FromSeconds(30).TotalMilliseconds; //MQC.MQWI_UNLIMITED;
        gmo.Options |= MQC.MQGMO_WAIT;
        gmo.Options |= MQC.MQGMO_SYNCPOINT;

        subs.Get(incoming, gmo);
        Assert.AreEqual(message, incoming.ReadAll());

        subs.Close(MQC.MQCO_REMOVE_SUB, closeSubQueue: true, closeSubQueueOptions: MQC.MQCO_NONE);
      }
    }
  }
}
