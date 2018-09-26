﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public interface IMQQueue : IDisposable
  {
    void Open(string queueName, int openOptions);
    void Put(MQMessage message);
    void Put(MQMessage message, MQPutMessageOptions pmo);
    void Get(MQMessage message, MQGetMessageOptions gmo);
    void Close();
  }
}
