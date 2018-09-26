using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public interface IMQPubSub : IDisposable
  {
    void Publish(MQMessage message, MQPutMessageOptions pmo);
    void Subscribe();
  }
}
