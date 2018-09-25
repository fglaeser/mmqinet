using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public class MQGetMessageOptions : MQBase
  {
    private MQGMO mqGMO = default(MQGMO);

    public byte GroupStatus
    {
      get
      {
        return this.mqGMO.GroupStatus;
      }
      set
      {
        this.mqGMO.GroupStatus = value;
      }
    }

    public int MatchOptions
    {
      get
      {
        return this.mqGMO.MatchOptions;
      }
      set
      {
        this.mqGMO.Version = ((this.mqGMO.Version == 3) ? 3 : 2);
        this.mqGMO.MatchOptions = value;
      }
    }

    public int Options
    {
      get
      {
        return this.mqGMO.Options;
      }
      set
      {
        this.mqGMO.Options = value;
      }
    }

    public string ResolvedQueueName
    {
      get
      {
        return base.GetString(this.mqGMO.ResolvedQName, this.mqGMO.ResolvedQName.Length);
      }
      set
      {
        if (value == null)
        {
          this.mqGMO.ResolvedQName = null;
          return;
        }
        byte[] resolvedQName = new byte[48];
        base.GetBytes(value, ref resolvedQName);
        this.mqGMO.ResolvedQName = resolvedQName;
      }
    }

    public byte Segmentation
    {
      get
      {
        return this.mqGMO.Segmentation;
      }
      set
      {
        this.mqGMO.Segmentation = value;
      }
    }

    public byte SegmentStatus
    {
      get
      {
        return this.mqGMO.SegmentStatus;
      }
      set
      {
        this.mqGMO.SegmentStatus = value;
      }
    }

    public int WaitInterval
    {
      get
      {
        return this.mqGMO.WaitInterval;
      }
      set
      {
        this.mqGMO.WaitInterval = value;
      }
    }

    public int Version
    {
      get
      {
        return this.mqGMO.Version;
      }
      set
      {
        this.mqGMO.Version = value;
      }
    }

    public byte[] MsgToken
    {
      get
      {
        return this.mqGMO.MsgToken;
      }
      set
      {
        this.mqGMO.MsgToken = value;
      }
    }

    public MQGMO StructMQGMO
    {
      get
      {
        this.CheckArrayLength();
        return this.mqGMO;
      }
      set
      {
        this.mqGMO = value;
      }
    }

    public int Signal1
    {
      get
      {
        return this.mqGMO.Signal1;
      }
      set
      {
        this.mqGMO.Signal1 = value;
      }
    }

    public int Signal2
    {
      get
      {
        return this.mqGMO.Signal2;
      }
      set
      {
        this.mqGMO.Signal2 = value;
      }
    }

    public int ReturnedLength
    {
      get
      {
        return this.mqGMO.ReturnedLength;
      }
      set
      {
        this.mqGMO.ReturnedLength = value;
      }
    }

    public MQGetMessageOptions()
    {
      this.ClearInvalidFields(0);
    }

    private void ClearInvalidFields(int Version)
    {
      switch (Version)
      {
        case 0:
          this.mqGMO.StrucId = new byte[4];
          this.mqGMO.StrucId[0] = 71;
          this.mqGMO.StrucId[1] = 77;
          this.mqGMO.StrucId[2] = 79;
          this.mqGMO.StrucId[3] = 32;
          this.mqGMO.Options = 0;
          this.mqGMO.WaitInterval = 0;
          this.mqGMO.Signal1 = 0;
          this.mqGMO.Signal2 = 0;
          this.mqGMO.ResolvedQName = new byte[48];
          break;
        case 1:
          break;
        case 2:
          goto IL_106;
        default:
          goto IL_124;
      }
      this.mqGMO.MatchOptions = 3;
      this.mqGMO.GroupStatus = 32;
      this.mqGMO.SegmentStatus = 32;
      this.mqGMO.Segmentation = 32;
      this.mqGMO.Reserved1 = 32;
      IL_106:
      this.mqGMO.MsgToken = new byte[16];
      this.mqGMO.ReturnedLength = -1;
      IL_124:
      if (Version == 0)
      {
        this.mqGMO.Version = 1;
      }
    }

    public MQGetMessageOptions(MQGetMessageOptions mqgmo)
    {
      this.mqGMO.StrucId = (byte[])mqgmo.mqGMO.StrucId.Clone();
      this.mqGMO.Version = mqgmo.mqGMO.Version;
      this.mqGMO.Options = mqgmo.mqGMO.Options;
      this.mqGMO.WaitInterval = mqgmo.mqGMO.WaitInterval;
      this.mqGMO.Signal1 = mqgmo.mqGMO.Signal1;
      this.mqGMO.Signal2 = mqgmo.mqGMO.Signal2;
      this.mqGMO.ResolvedQName = new byte[48];
      Buffer.BlockCopy(mqgmo.mqGMO.ResolvedQName, 0, this.mqGMO.ResolvedQName, 0, mqgmo.mqGMO.ResolvedQName.Length);
      this.mqGMO.MatchOptions = mqgmo.mqGMO.MatchOptions;
      this.mqGMO.GroupStatus = mqgmo.mqGMO.GroupStatus;
      this.mqGMO.SegmentStatus = mqgmo.mqGMO.SegmentStatus;
      this.mqGMO.Segmentation = mqgmo.mqGMO.Segmentation;
      this.mqGMO.Reserved1 = mqgmo.mqGMO.Reserved1;
      this.mqGMO.MsgToken = new byte[16];
      Buffer.BlockCopy(mqgmo.mqGMO.MsgToken, 0, this.mqGMO.MsgToken, 0, mqgmo.mqGMO.MsgToken.Length);
      this.mqGMO.ReturnedLength = mqgmo.mqGMO.ReturnedLength;
    }

    public int GetLength()
    {
      return Marshal.SizeOf(this.mqGMO);
    }

    public int GetVersionLength()
    {
      switch (this.mqGMO.Version)
      {
        case 1:
          return 72;
        case 2:
          return 80;
        case 3:
          return 100;
        default:
          return 0;
      }
    }

    public int WriteStruct(byte[] b, int Offset)
    {
      IntPtr intPtr = IntPtr.Zero;
      int versionLength = this.GetVersionLength();
      this.CheckArrayLength();
      intPtr = Marshal.AllocCoTaskMem(this.GetLength());
      Marshal.StructureToPtr(this.mqGMO, intPtr, false);
      Marshal.Copy(intPtr, b, Offset, versionLength);
      Marshal.FreeCoTaskMem(intPtr);
      return versionLength;
    }

    private void CheckArrayLength()
    {
      if (this.mqGMO.msgToken != null && this.mqGMO.msgToken.Length != 16)
      {
        this.mqGMO.msgToken = this.ResizeArrayToCorrectLength(this.mqGMO.msgToken, 16);
      }
    }

    internal int ReadStruct(byte[] b, int Offset)
    {
      IntPtr intPtr = IntPtr.Zero;
      int num = this.GetLength();
      int num2 = 0;

      intPtr = Marshal.AllocCoTaskMem(num);
      if (num > b.Length - Offset)
      {
        num = b.Length - Offset;
      }
      Marshal.Copy(b, Offset, intPtr, num);
      this.mqGMO = (MQGMO)Marshal.PtrToStructure(intPtr, typeof(MQGMO));
      this.ClearInvalidFields(this.mqGMO.Version);
      Marshal.FreeCoTaskMem(intPtr);
      num2 = Offset + this.GetVersionLength();
      return num2;
    }
  }
}
