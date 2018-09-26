using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public interface IMQQueue : IDisposable
  {
    void Put(MQMessage message, MQPutMessageOptions pmo);
    void Get(MQMessage message, MQGetMessageOptions gmo);
  }
}
