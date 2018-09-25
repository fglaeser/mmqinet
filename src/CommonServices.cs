using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Text;

namespace Mmqi
{
  public class CommonServices
  {
    [ThreadStatic]
    private static CommonServicesInterface cs;

    private static Type csClassRef;

    private static void ByteSwapShort(ref byte[] buffer, int length)
    {
      for (int i = 0; i < length; i += 2)
      {
        byte b = buffer[i];
        buffer[i] = buffer[i + 1];
        buffer[i + 1] = b;
      }
    }

    public static uint ConvertString(string objectId, int fromCCSID, int toCCSID, byte[] inString, int inLength, out byte[] outString, ref int outLength, int options, out uint bytesConverted)
    {
      uint num = 545284184u;
      if (outLength == 0)
      {
        outLength = inLength * 4;
      }
      outString = new byte[outLength];
      bytesConverted = 0u;
      if (fromCCSID == 1200 && inLength >= 2)
      {
        if (inString[0] == 254 && inString[1] == 255)
        {
          options &= -241;
          if (toCCSID == fromCCSID && (options & 256) == 256)
          {
            options &= -3841;
          }
          else
          {
            options |= 16;
          }
        }
        else if (inString[0] == 255 && inString[1] == 255)
        {
          options &= -241;
          if (toCCSID == fromCCSID && (options & 512) == 512)
          {
            options &= -3841;
          }
          else
          {
            options |= 32;
          }
        }
      }
      if (fromCCSID == 1200 && fromCCSID == toCCSID)
      {
        unchecked
        {
          outLength = (int)((long)Math.Min(inLength, outLength) & (long)((ulong)-2));
        }
        Buffer.BlockCopy(inString, 0, outString, 0, outLength);
        bytesConverted = (uint)outLength;
        if ((options & 528) == 528 || (options & 288) == 288)
        {
          CommonServices.ByteSwapShort(ref outString, outLength);
        }
        num = 0u;
      }
      else
      {
        int options2 = options & -268439537;
        inLength = Math.Min(inLength, outLength * 4);
        if (fromCCSID == 1200 && (options & 16) == 16)
        {
          CommonServices.ByteSwapShort(ref inString, inLength);
        }
        //if (CommonServices.cs != null || CommonServices.CreateCommonServices())
        //{
        //  num = CommonServices.cs.ConvertString(objectId, fromCCSID, toCCSID, inString, inLength, ref outString, ref outLength, options2, ref bytesConverted);
        //}


        if (fromCCSID == 1200 && (options & 268435456) != 268435456 && (options & 16) == 16)
        {
          CommonServices.ByteSwapShort(ref inString, inLength);
        }
        if (num == 0u && toCCSID == 1200 && (options & 256) == 256)
        {
          CommonServices.ByteSwapShort(ref outString, outLength);
        }

        num = new  ConvertStringHelper().ConvertString(objectId, fromCCSID, toCCSID, inString, inLength, ref outString, ref outLength, options2, ref bytesConverted);
      }
      return num;
    }
    public static uint ConvertString(int fromCCSID, int toCCSID, byte[] inString, int inLength, out byte[] outString, ref int outLength, int options, out uint bytesConverted)
    {
      return CommonServices.ConvertString(string.Empty, fromCCSID, toCCSID, inString, inLength, out outString, ref outLength, options, out bytesConverted);
    }

    public static string GetPropertyValue(string propertyName)
    {
      return CommonServices.GetPropertyValue(propertyName, true);
    }

    public static string GetPropertyValue(string propertyName, bool tryEnvironment)
    {
      string text = null;
      try
      {
        NameValueCollection appSettings = null; //ConfigurationManager.AppSettings;
        if (appSettings != null)
        {
          string[] values = appSettings.GetValues(propertyName);
          if (values != null)
          {
            text = values[0];
          }
        }
      }
      catch (Exception)
      {
      }
      try
      {
        NameValueCollection appSettings2 = null; //WebConfigurationManager.AppSettings;
        if (appSettings2 != null)
        {
          string[] values2 = appSettings2.GetValues(propertyName);
          if (values2 != null)
          {
            text = values2[0];
          }
        }
      }
      catch (Exception)
      {
      }
      if (tryEnvironment && text == null)
      {
        if (CommonServices.cs != null)
        {
          text = CommonServices.cs.GetEnvironmentValue(propertyName);
        }
        else
        {
          text = Environment.GetEnvironmentVariable(propertyName);
        }
      }
      return text;
    }

  }

  public abstract class CommonServicesInterface
  {
    internal abstract uint ConvertString(string objectId, int fromCCSID, int toCCSID, byte[] inString, int inLength, ref byte[] outString, ref int outLength, int options, ref uint bytesConverted);
    internal abstract string GetEnvironmentValue(string name);
  }

  public class ConvertStringHelper
  {

    public uint ConvertString(string objectId, int fromCCSID, int toCCSID, byte[] inString, int inLength, ref byte[] outString, ref int outLength, int options, ref uint bytesConverted)
    {
      uint method = 781u;
      uint num = 0u;

      Encoding encoding = this.GetEncoding(fromCCSID);
      Encoding encoding2 = this.GetEncoding(toCCSID);
      byte[] array = Encoding.Convert(encoding, encoding2, inString, 0, inLength);
      if (outLength < array.Length)
      {
        outLength = encoding2.GetByteCount(encoding2.GetChars(array, 0, outLength));
        byte[] array2 = Encoding.Convert(encoding2, encoding, array, 0, outLength);
        bytesConverted = (uint)array2.Length;
        num = 276848725u;
      }
      else
      {
        outLength = array.Length;
        bytesConverted = (uint)inLength;
      }
      outString = array;
      return num;
    }

    private Encoding GetEncoding(int ccsid)
    {
      int num = ccsid;
      if (num > 943)
      {
        if (num > 1234)
        {
          if (num <= 2022)
          {
            switch (num)
            {
              case 1381:
              case 1383:
                break;
              case 1382:
                goto IL_325;
              default:
                if (num != 1386)
                {
                  if (num != 2022)
                  {
                    goto IL_325;
                  }
                  ccsid = 50220;
                  goto IL_325;
                }
                break;
            }
          }
          else if (num <= 5488)
          {
            if (num == 5050)
            {
              goto IL_2DF;
            }
            if (num != 5488)
            {
              goto IL_325;
            }
          }
          else
          {
            if (num == 5601)
            {
              ccsid = 949;
              goto IL_325;
            }
            if (num != 33722)
            {
              goto IL_325;
            }
            goto IL_2DF;
          }
          ccsid = 54936;
          goto IL_325;
        }
        if (num <= 1025)
        {
          if (num != 954)
          {
            if (num == 970)
            {
              ccsid = 51949;
              goto IL_325;
            }
            if (num != 1025)
            {
              goto IL_325;
            }
            goto IL_24A;
          }
        }
        else if (num <= 1202)
        {
          if (num == 1089)
          {
            ccsid = 28596;
            goto IL_325;
          }
          if (num != 1202)
          {
            goto IL_325;
          }
          ccsid = 1200;
          goto IL_325;
        }
        else
        {
          if (num == 1208)
          {
            ccsid = 65001;
            goto IL_325;
          }
          switch (num)
          {
            case 1232:
              ccsid = 65006;
              goto IL_325;
            case 1233:
              goto IL_325;
            case 1234:
              ccsid = 65005;
              goto IL_325;
            default:
              goto IL_325;
          }
        }
        IL_2DF:
        ccsid = 51932;
        goto IL_325;
      }
      if (num <= 813)
      {
        if (num <= 290)
        {
          if (num != 273)
          {
            switch (num)
            {
              case 277:
              case 278:
              case 280:
              case 284:
              case 285:
                break;
              case 279:
              case 281:
              case 282:
              case 283:
                goto IL_325;
              default:
                if (num != 290)
                {
                  goto IL_325;
                }
                break;
            }
          }
        }
        else if (num != 297)
        {
          switch (num)
          {
            case 420:
            case 423:
            case 424:
              break;
            case 421:
            case 422:
              goto IL_325;
            default:
              if (num != 813)
              {
                goto IL_325;
              }
              ccsid = 28597;
              goto IL_325;
          }
        }
      }
      else if (num <= 871)
      {
        if (num == 819)
        {
          ccsid = 28591;
          goto IL_325;
        }
        if (num != 838 && num != 871)
        {
          goto IL_325;
        }
      }
      else if (num <= 905)
      {
        switch (num)
        {
          case 878:
            ccsid = 20866;
            goto IL_325;
          case 879:
            goto IL_325;
          case 880:
            break;
          default:
            if (num != 905)
            {
              goto IL_325;
            }
            break;
        }
      }
      else
      {
        switch (num)
        {
          case 912:
            ccsid = 28592;
            goto IL_325;
          case 913:
            ccsid = 28593;
            goto IL_325;
          case 914:
          case 917:
          case 918:
          case 919:
          case 922:
            goto IL_325;
          case 915:
            ccsid = 28595;
            goto IL_325;
          case 916:
            ccsid = 28598;
            goto IL_325;
          case 920:
            ccsid = 28599;
            goto IL_325;
          case 921:
            ccsid = 28603;
            goto IL_325;
          case 923:
            ccsid = 28605;
            goto IL_325;
          default:
            if (num != 943)
            {
              goto IL_325;
            }
            ccsid = 932;
            goto IL_325;
        }
      }
      IL_24A:
      ccsid += 20000;
      IL_325:
      return Encoding.GetEncoding(ccsid);
    }

  }
}
