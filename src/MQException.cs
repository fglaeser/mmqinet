using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public class MQException : Exception
  {
    public int Reason { get; set; }

    public int CompletionCode { get; set; }

    public MQException(int compCode, int reason)
    {
      Reason = reason;
      CompletionCode = compCode;
    }

    public override string ToString()
    {
      return "CompCode: " + CompletionCode.ToString() + ", Reason: " + Reason.ToString();
    }
  }

}
