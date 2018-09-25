using Mmqi;
using System;

namespace IntegrationTest
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
      var mqmgr = MQQueueManager.Connect("GA02.AR.T.QM", MQC.MQCO_NONE, "ITG.TO.GA02.TEST", "192.6.6.39(1416)");
      var q = new MQQueue(mqmgr, "QL.ITG.ALERTRAN.SUBSCRIBER.BOQ", MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_FAIL_IF_QUIESCING);

      var message = new MQMessage();

      MQGetMessageOptions gmo = new MQGetMessageOptions();
      gmo.WaitInterval = MQC.MQWI_UNLIMITED;
      gmo.Options |= MQC.MQGMO_WAIT;
      gmo.Options |= MQC.MQGMO_SYNCPOINT;


      message.CharacterSet = MQC.CODESET_UTF;
      message.Encoding = MQC.MQENC_NORMAL;
      message.WriteString("Message from MQ NetCore PUT");

      mqmgr.PutInQueue("QL.ITG.ALERTRAN.SUBSCRIBER.BOQ", message);

      //q.Get(message, gmo);
      //Console.WriteLine(message.ReadString(message.DataLength));
      mqmgr.Commit();
      q.Close();
      mqmgr.Disconnect();
    }
  }
}
