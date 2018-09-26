using Mmqi;
using System;

namespace IntegrationTest
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      ConnectWithAuthentication();
      using (var mqmgr = MQQueueManager.Connect("GA02.AR.T.QM", MQC.MQCO_NONE, "ITG.TO.GA02.TEST", "192.6.6.39(1416)"))
      //using (var q = mqmgr.AccessQueue("QL.ITG.ALERTRAN.SUBSCRIBER.BOQ", MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
      using (var q = mqmgr.AccessTopic("R4/AltaModificacionDeEmpleados", string.Empty, MQC.MQTOPIC_OPEN_AS_PUBLICATION, MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING))
      {
        var message = new MQMessage();
        MQGetMessageOptions gmo = new MQGetMessageOptions();
        gmo.WaitInterval = MQC.MQWI_UNLIMITED;
        gmo.Options |= MQC.MQGMO_WAIT;
        gmo.Options |= MQC.MQGMO_SYNCPOINT;


        message.CharacterSet = MQC.CODESET_UTF;
        message.Encoding = MQC.MQENC_NORMAL;
        message.WriteString("Message from MQ NetCore PUT");

        //q.Get(message, gmo);
        q.Put(message);
        //Console.WriteLine(message.ReadString(message.DataLength));
      }

    }
      //message.WriteString("Message from MQ NetCore PUT");

      //mqmgr.PutInQueue("QL.ITG.ALERTRAN.SUBSCRIBER.BOQ", message);

      //q.Get(message, gmo);
      //Console.WriteLine(message.ReadString(message.DataLength));

      static void ConnectWithAuthentication()
      {
       
        Console.WriteLine("Connect to MQ With User & Password");
        var mqmgr = MQQueueManager.Connect("QM.GLA.ITG.TEST.01", MQC.MQCO_NONE, "ITG.DEV.SVRCONN", "10.20.7.45(1414)", "mq_ITG_test", "nwvq4368!");
        mqmgr.Disconnect();
      }
    }
}
