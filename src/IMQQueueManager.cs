using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public interface IMQQueueManager : IDisposable
  {
    int Handle { get; }

    bool IsConnected { get; }

    void Connect(string queueMgrName);

    void Disconnect();

    void Commit();

    void Backout();

    void Put1(MQObjectDescriptor od, MQMessage message, MQPutMessageOptions pmo);
  }
}
