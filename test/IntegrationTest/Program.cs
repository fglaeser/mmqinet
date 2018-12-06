using Mmqi;
using System;
using System.Collections;

namespace IntegrationTest
{
  class Program
  {
    static void Main(string[] args)
    {
      //Environment.SetEnvironmentVariable("GMQ_MQ_LIB", "mqic.dll");
      //Environment.SetEnvironmentVariable("AMQ_MQS_INI_LOCATION", @"C:\Users\sglaeser\IBM\MQ\data");
      //foreach (DictionaryEntry r in Environment.GetEnvironmentVariables())
      //{
      //  Console.WriteLine("{0}={1}",r.Key, r.Value);
      //}

      //Console.WriteLine("Hello World!");
      //Put1InTopic();
      ConnectWithAuthentication();
      //using (var mqmgr = MQQueueManager.Connect("GA02.AR.T.QM", MQC.MQCO_NONE, "ITG.TO.GA02.TEST", "192.6.6.39(1416)"))
      ////using (var q = mqmgr.AccessQueue("QL.ITG.ALERTRAN.SUBSCRIBER.BOQ", MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
      //using (var q = mqmgr.AccessTopic("R4/AltaModificacionDeEmpleados", string.Empty, MQC.MQTOPIC_OPEN_AS_PUBLICATION, MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
      //{
      //  var message = new MQMessage();
      //  MQGetMessageOptions gmo = new MQGetMessageOptions();
      //  gmo.WaitInterval = MQC.MQWI_UNLIMITED;
      //  gmo.Options |= MQC.MQGMO_WAIT;
      //  gmo.Options |= MQC.MQGMO_SYNCPOINT;


      //  message.CharacterSet = MQC.CODESET_UTF;
      //  message.Encoding = MQC.MQENC_NORMAL;
      //  message.WriteString("Message from MQ NetCore PUT");

      //  //q.Get(message, gmo);
      //  q.Publish(message);
      //  //Console.WriteLine(message.ReadString(message.DataLength));
      //}

    }
      //message.WriteString("Message from MQ NetCore PUT");

      //mqmgr.PutInQueue("QL.ITG.ALERTRAN.SUBSCRIBER.BOQ", message);

      //q.Get(message, gmo);
      //Console.WriteLine(message.ReadString(message.DataLength));

    static void ConnectWithAuthentication()
    {
      // funciona
      Console.WriteLine("Connect to MQ With User & Password");
      var mqmgr = MQQueueManager.Connect("QM.GLA.ITG.TEST.01", MQC.MQCO_NONE, "ITG.SVRCONN", "10.20.7.45(1414)", "User_ITG_TEST", "nyrta1253");
      mqmgr.Disconnect();
    }

    static void Put1InTopic()
    {
      using (var mqmgr = MQQueueManager.Connect("GA02.AR.T.QM", MQC.MQCO_NONE, "ITG.TO.GA02.TEST", "192.6.6.39(1416)"))
      {
        var message = new MQMessage();
        message.CharacterSet = MQC.CODESET_UTF;
        message.Encoding = MQC.MQENC_NORMAL;
        message.WriteString("Message from MQ NetCore PUT1 In Topic WIN");

        mqmgr.Publish("R4/AltaModificacionDeEmpleados", message);
      }

    }

  }
}
