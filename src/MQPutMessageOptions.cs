using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public class MQPutMessageOptions : MQBase
  {
    internal MQPMO mqPMO = default(MQPMO);

    private MQQueue queueContextReference;

    public MQQueue ContextReference
    {
      get
      {
        return this.queueContextReference;
      }
      set
      {
        this.queueContextReference = value;
        if (this.queueContextReference != null)
        {
          this.mqPMO.Context = this.queueContextReference.Handle;
          return;
        }
        this.mqPMO.Context = 0;
      }
    }

    public int InvalidDestCount
    {
      get
      {
        return this.mqPMO.InvalidDestCount;
      }
    }

    public int KnownDestCount
    {
      get
      {
        return this.mqPMO.KnownDestCount;
      }
    }

    public int Options
    {
      get
      {
        return this.mqPMO.Options;
      }
      set
      {
        this.mqPMO.Options = value;
      }
    }

    public int RecordFields
    {
      get
      {
        return this.mqPMO.PutMsgRecFields;
      }
      set
      {
        this.mqPMO.PutMsgRecFields = value;
      }
    }

    public int ResponseRecordOffset
    {
      get
      {
        return this.mqPMO.ResponseRecOffset;
      }
      set
      {
        this.mqPMO.ResponseRecOffset = value;
      }
    }

    public int RecordsPresent
    {
      get
      {
        return this.mqPMO.RecsPresent;
      }
      set
      {
        this.mqPMO.RecsPresent = value;
      }
    }

    public IntPtr PutMsgRecPtr
    {
      get
      {
        return this.mqPMO.PutMsgRecPtr;
      }
      set
      {
        this.mqPMO.PutMsgRecPtr = value;
      }
    }

    public string ResolvedQueueManagerName
    {
      get
      {
        return base.GetString(this.mqPMO.ResolvedQMgrName);
      }
    }

    public string ResolvedQueueName
    {
      get
      {
        return base.GetString(this.mqPMO.ResolvedQName);
      }
    }

    public int UnknownDestCount
    {
      get
      {
        return this.mqPMO.UnknownDestCount;
      }
    }

    public int Version
    {
      get
      {
        return this.mqPMO.Version;
      }
      set
      {
        this.mqPMO.Version = value;
      }
    }

    public int Timeout
    {
      get
      {
        return this.mqPMO.Timeout;
      }
      set
      {
        this.mqPMO.Timeout = value;
      }
    }

    public int Context
    {
      get
      {
        return this.mqPMO.Context;
      }
      set
      {
        this.mqPMO.Context = value;
      }
    }

    public int PutMsgRecOffset
    {
      get
      {
        return this.mqPMO.PutMsgRecOffset;
      }
      set
      {
        this.mqPMO.PutMsgRecOffset = value;
      }
    }

    public IntPtr ResponseRecordPtr
    {
      get
      {
        return this.mqPMO.ResponseRecPtr;
      }
      set
      {
        this.mqPMO.ResponseRecPtr = value;
      }
    }

    public MQPMO StructMQPMO
    {
      get
      {
        return this.mqPMO;
      }
      set
      {
        this.mqPMO = value;
      }
    }

    public long OriginalMsgHandle
    {
      get
      {
        return this.mqPMO.OriginalMsgHandle;
      }
      set
      {
        this.mqPMO.OriginalMsgHandle = value;
      }
    }

    public long NewMsgHandle
    {
      get
      {
        return this.mqPMO.NewMsgHandle;
      }
      set
      {
        this.mqPMO.NewMsgHandle = value;
      }
    }

    public int Action
    {
      get
      {
        return this.mqPMO.Action;
      }
      set
      {
        this.mqPMO.Action = value;
      }
    }

    public int PubLevel
    {
      get
      {
        return this.mqPMO.PubLevel;
      }
      set
      {
        this.mqPMO.PubLevel = value;
      }
    }

    public MQPutMessageOptions()
    {
      this.ClearInvalidFields(0);
    }

    private void ClearInvalidFields(int Version)
    {
      switch (Version)
      {
        case 0:
          this.mqPMO.StrucId = new byte[4];
          this.mqPMO.StrucId[0] = 80;
          this.mqPMO.StrucId[1] = 77;
          this.mqPMO.StrucId[2] = 79;
          this.mqPMO.StrucId[3] = 32;
          this.mqPMO.Options = 0;
          this.mqPMO.Timeout = -1;
          this.mqPMO.Context = 0;
          this.mqPMO.KnownDestCount = 0;
          this.mqPMO.UnknownDestCount = 0;
          this.mqPMO.InvalidDestCount = 0;
          this.mqPMO.ResolvedQName = new byte[48];
          this.mqPMO.ResolvedQMgrName = new byte[48];
          break;
        case 1:
          break;
        case 2:
          goto IL_147;
        default:
          goto IL_17A;
      }
      this.mqPMO.RecsPresent = 0;
      this.mqPMO.PutMsgRecFields = 0;
      this.mqPMO.PutMsgRecOffset = 0;
      this.mqPMO.ResponseRecOffset = 0;
      this.mqPMO.PutMsgRecPtr = IntPtr.Zero;
      this.mqPMO.ResponseRecPtr = IntPtr.Zero;
      this.queueContextReference = null;
      IL_147:
      this.mqPMO.OriginalMsgHandle = 0L;
      this.mqPMO.NewMsgHandle = 0L;
      this.mqPMO.Action = 0;
      this.mqPMO.PubLevel = 9;
      IL_17A:
      if (Version == 0)
      {
        this.mqPMO.Version = 1;
      }
    }

    internal int GetLength()
    {
      return Marshal.SizeOf(this.mqPMO);
    }

    internal int GetVersionLength()
    {
      switch (this.mqPMO.Version)
      {
        case 1:
          return 128;
        case 2:
          return 152;
        case 3:
          return 176;
        default:
          return 0;
      }
    }

    internal int WriteStruct(byte[] b, int Offset)
    {
      int versionLength = this.GetVersionLength();
      IntPtr intPtr = Marshal.AllocCoTaskMem(this.GetLength());
      Marshal.StructureToPtr(this.mqPMO, intPtr, false);
      Marshal.Copy(intPtr, b, Offset, versionLength);
      Marshal.FreeCoTaskMem(intPtr);
      return versionLength;
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
      this.mqPMO = (MQPMO)Marshal.PtrToStructure(intPtr, typeof(MQPMO));
      this.ClearInvalidFields(this.mqPMO.Version);
      Marshal.FreeCoTaskMem(intPtr);
      num2 = Offset + this.GetVersionLength();
      return num2;
    }

    internal void ValidateOptions()
    {
      int num = this.Options & 196608;
      if ((num & num - 1) != 0)
      {
        int cc = 2;
        int rc = 2046;
        base.ThrowNewMQException(cc, rc);
      }
      num = (this.Options & 16416);
      if ((num & num - 1) != 0)
      {
        int cc = 2;
        int rc = 2046;
        base.ThrowNewMQException(cc, rc);
      }
    }
  }
}
