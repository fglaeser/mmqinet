using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public abstract class MQBase
  {

    protected static int s_ExceptionThreshold;

    public struct structMQCHARV
    {
      public IntPtr VSPtr;

      public int VSOffset;

      public int VSBufSize;

      public int VSLength;

      public int VSCCSID;
    }

    public struct structMQCHARV32
    {
      public int VSPtr;

      public int VSOffset;

      public int VSBufSize;

      public int VSLength;

      public int VSCCSID;
    }

    protected void GetBytes(string value, ref byte[] buffer)
    {
      Encoding.ASCII.GetBytes(value.PadRight(buffer.Length, '\0'), 0, buffer.Length, buffer, 0);
    }

    protected void GetBytesRightPad(string value, ref byte[] buffer)
    {
      Encoding.ASCII.GetBytes(value.PadRight(buffer.Length), 0, buffer.Length, buffer, 0);
    }

    protected string GetString(byte[] value)
    {
      string arg_17_0 = Encoding.ASCII.GetString(value, 0, value.Length);
      char[] array = new char[1];
      return arg_17_0.TrimEnd(array);
    }

    protected string GetString(byte[] value, int nBytes)
    {
      string arg_15_0 = Encoding.ASCII.GetString(value, 0, nBytes);
      char[] array = new char[1];
      return arg_15_0.TrimEnd(array);
    }

    protected void BlankPad(byte[] value)
    {
      int num = Array.LastIndexOf<byte>(value, 0);
      while (num > -1 && value[num] == 0)
      {
        value[num--] = 32;
      }
    }

    public virtual byte[] ResizeArrayToCorrectLength(byte[] input, int actualLength)
    {
      if (input == null)
      {
        return input;
      }
      if (input.Length == actualLength)
      {
        return input;
      }
      int num = input.Length;
      if (num < actualLength)
      {
        byte[] array = new byte[num];
        Buffer.BlockCopy(input, 0, array, 0, num);
        input = new byte[actualLength];
        Buffer.BlockCopy(array, 0, input, 0, num);
        int num2 = actualLength - num;
        for (int i = 0; i < num2; i++)
        {
          input[num + i] = 0;
        }
      }
      else
      {
        byte[] array2 = new byte[actualLength];
        Buffer.BlockCopy(input, 0, array2, 0, array2.Length);
        input = array2;
      }
      return input;
    }

    protected void ThrowNewMQException(int cc, int rc)
    {
      if (cc >= MQBase.s_ExceptionThreshold)
      {
        throw new MQException(cc, rc);
      }
    }
  }
}
