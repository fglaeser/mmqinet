using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public class MQSubscriptionDescriptor : MQBase
  {
    private int mqSDSize;

    private MQSD mqSD = default(MQSD);

    private MQSD32 mqSD32 = default(MQSD32);

    private int OBJSTRING_OFFSET;

    private int SUBNAME_OFFSET;

    private int SUBUSERDATA_OFFSET;

    private int SELSTRING_OFFSET;

    private int ROBJSTRING_OFFSET;

    private MQCHARV objectString;

    private MQCHARV subName;

    private MQCHARV subUserData;

    private MQCHARV selectionString;

    private MQCHARV resObjectString;

    private bool useNativePtrSz;

    public byte[] StrucId
    {
      get
      {
        return this.mqSD.StrucId;
      }
      set
      {
        this.mqSD.StrucId = value;
        this.mqSD32.StrucId = value;
      }
    }

    public int Options
    {
      get
      {
        return this.mqSD.Options;
      }
      set
      {
        this.mqSD.Options = value;
        this.mqSD32.Options = value;
      }
    }

    public MQCHARV ObjectString
    {
      get
      {
        return this.objectString;
      }
      set
      {
        this.objectString = value;
      }
    }

    public MQCHARV SubName
    {
      get
      {
        return this.subName;
      }
      set
      {
        this.subName = value;
      }
    }

    public MQCHARV SubUserData
    {
      get
      {
        return this.subUserData;
      }
      set
      {
        this.subUserData = value;
      }
    }

    public MQCHARV SelectionString
    {
      get
      {
        return this.selectionString;
      }
      set
      {
        this.selectionString = value;
      }
    }

    public MQCHARV ResObjectString
    {
      get
      {
        return this.resObjectString;
      }
      set
      {
        this.resObjectString = value;
      }
    }

    public string ObjectName
    {
      get
      {
        return base.GetString(this.mqSD.ObjectName);
      }
      set
      {
        byte[] objectName = new byte[48];
        base.GetBytes(value, ref objectName);
        this.mqSD.ObjectName = objectName;
        this.mqSD32.ObjectName = objectName;
      }
    }

    public string AlternateUserId
    {
      get
      {
        return base.GetString(this.mqSD.AlternateUserId);
      }
      set
      {
        byte[] alternateUserId = new byte[12];
        base.GetBytes(value, ref alternateUserId);
        this.mqSD.AlternateUserId = alternateUserId;
        this.mqSD32.AlternateUserId = alternateUserId;
      }
    }

    public string AlternateSecurityId
    {
      get
      {
        return base.GetString(this.mqSD.AlternateSecurityId);
      }
      set
      {
        byte[] alternateSecurityId = new byte[40];
        base.GetBytes(value, ref alternateSecurityId);
        this.mqSD.AlternateSecurityId = alternateSecurityId;
        this.mqSD32.AlternateSecurityId = alternateSecurityId;
      }
    }

    public string SubCorrelId
    {
      get
      {
        return base.GetString(this.mqSD.SubCorrelId);
      }
      set
      {
        byte[] subCorrelId = new byte[24];
        base.GetBytes(value, ref subCorrelId);
        this.mqSD.SubCorrelId = subCorrelId;
        this.mqSD32.SubCorrelId = subCorrelId;
      }
    }

    public string PubAccountingToken
    {
      get
      {
        return base.GetString(this.mqSD.PubAccountingToken);
      }
      set
      {
        byte[] pubAccountingToken = new byte[32];
        base.GetBytes(value, ref pubAccountingToken);
        this.mqSD.PubAccountingToken = pubAccountingToken;
        this.mqSD32.PubAccountingToken = pubAccountingToken;
      }
    }

    public string PubApplIdentityData
    {
      get
      {
        return base.GetString(this.mqSD.PubApplIdentityData);
      }
      set
      {
        byte[] pubApplIdentityData = new byte[32];
        base.GetBytes(value, ref pubApplIdentityData);
        this.mqSD.PubApplIdentityData = pubApplIdentityData;
        this.mqSD32.PubApplIdentityData = pubApplIdentityData;
      }
    }

    public int Version
    {
      get
      {
        return this.mqSD.Version;
      }
      set
      {
        this.mqSD.Version = value;
        this.mqSD32.Version = value;
      }
    }

    public int SubExpiry
    {
      get
      {
        return this.mqSD.SubExpiry;
      }
      set
      {
        this.mqSD.SubExpiry = value;
        this.mqSD32.SubExpiry = value;
      }
    }

    public int PubPriority
    {
      get
      {
        return this.mqSD.PubPriority;
      }
      set
      {
        this.mqSD.PubPriority = value;
        this.mqSD32.PubPriority = value;
      }
    }

    public int SubLevel
    {
      get
      {
        return this.mqSD.SubLevel;
      }
      set
      {
        this.mqSD.SubLevel = value;
        this.mqSD32.SubLevel = value;
      }
    }

    public bool UseNativePtrSz
    {
      get
      {
        return this.useNativePtrSz;
      }
      set
      {
        this.useNativePtrSz = value;
        this.objectString.UseNativePtrSz = value;
        this.subName.UseNativePtrSz = value;
        this.subUserData.UseNativePtrSz = value;
        this.selectionString.UseNativePtrSz = value;
        this.resObjectString.UseNativePtrSz = value;
        this.calculateOffsets();
      }
    }

    public MQSubscriptionDescriptor()
    {
      this.objectString = new MQCHARV(true, false);
      this.subName = new MQCHARV(true, false);
      this.subUserData = new MQCHARV(true, false);
      this.selectionString = new MQCHARV(true, false);
      this.resObjectString = new MQCHARV(false, true);
      this.ClearInvalidFields(0);
      this.useNativePtrSz = true;
      this.calculateOffsets();
    }

    private void ClearInvalidFields(int ver)
    {
      if (ver == 0)
      {
        this.StrucId = new byte[4];
        this.StrucId[0] = 83;
        this.StrucId[1] = 68;
        this.StrucId[2] = 32;
        this.StrucId[3] = 32;
        this.ObjectName = "";
        this.AlternateUserId = "";
        this.AlternateSecurityId = "";
        this.SubExpiry = -1;
        this.SubCorrelId = "";
        this.PubPriority = -3;
        this.PubAccountingToken = "";
        this.PubApplIdentityData = "";
        this.mqSD.ObjectString = new MQBase.structMQCHARV
        {
          VSPtr = IntPtr.Zero,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqSD.SubName = new MQBase.structMQCHARV
        {
          VSPtr = IntPtr.Zero,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqSD.SubUserData = new MQBase.structMQCHARV
        {
          VSPtr = IntPtr.Zero,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqSD.SelectionString = new MQBase.structMQCHARV
        {
          VSPtr = IntPtr.Zero,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.SubLevel = 1;
        this.mqSD.ResObjectString = new MQBase.structMQCHARV
        {
          VSPtr = IntPtr.Zero,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqSD32.ObjectString = new MQBase.structMQCHARV32
        {
          VSPtr = 0,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqSD32.SubName = new MQBase.structMQCHARV32
        {
          VSPtr = 0,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqSD32.SubUserData = new MQBase.structMQCHARV32
        {
          VSPtr = 0,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqSD32.SelectionString = new MQBase.structMQCHARV32
        {
          VSPtr = 0,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqSD32.ResObjectString = new MQBase.structMQCHARV32
        {
          VSPtr = 0,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
      }
      if (ver == 0)
      {
        this.Version = 1;
      }
    }

    internal int GetLength()
    {
      if (this.useNativePtrSz)
      {
        int num = Marshal.SizeOf(this.mqSD);
        return num;
      }
      int num2 = Marshal.SizeOf(this.mqSD32);
      return num2;
    }

    internal int GetVersionLength()
    {
      int version = this.mqSD.Version;
      if (version == 1)
      {
        int length = this.GetLength();
        return length;
      }
      return 0;
    }

    private int GetPaddedLength(int len)
    {
      int num = 4 - (len & 3) & 3;
      int num2 = len + num;
      return num2;
    }

    private int GetPaddedLength(string str)
    {
      int num;
      if (str != null)
      {
        int length = str.Length;
        num = this.GetPaddedLength(length);
      }
      else
      {
        num = 0;
      }
      int num2 = num;
      return num2;
    }

    public int GetRequiredBufferSize()
    {
      int num = this.GetVersionLength();
      num += this.GetPaddedLength(this.objectString.VSString);
      num += this.GetPaddedLength(this.subName.VSString);
      num += this.GetPaddedLength(this.subUserData.VSString);
      num += this.GetPaddedLength(this.selectionString.VSString);
      num += this.GetPaddedLength(this.resObjectString.VSBufSize);
      return num;
    }

    public int GetRequiredBufferSizeWOResObj()
    {
      int num = this.GetVersionLength();
      num += this.GetPaddedLength(this.objectString.VSString);
      num += this.GetPaddedLength(this.subName.VSString);
      num += this.GetPaddedLength(this.subUserData.VSString);
      num += this.GetPaddedLength(this.selectionString.VSString);
      return num;
    }

    internal void CopyCHARVIntoSD()
    {
      this.mqSD.ObjectString = this.objectString.mqcharv;
      this.mqSD32.ObjectString = this.objectString.mqcharv32;
      this.mqSD.SubName = this.subName.mqcharv;
      this.mqSD32.SubName = this.subName.mqcharv32;
      this.mqSD.SubUserData = this.subUserData.mqcharv;
      this.mqSD32.SubUserData = this.subUserData.mqcharv32;
      this.mqSD.SelectionString = this.selectionString.mqcharv;
      this.mqSD32.SelectionString = this.selectionString.mqcharv32;
      if ((this.mqSD.ObjectString.VSPtr != IntPtr.Zero && this.objectString.VSString != null) || (this.mqSD32.ObjectString.VSPtr != 0 && this.objectString.VSString != null))
      {
        int cc = 2;
        int rc = 2425;
        base.ThrowNewMQException(cc, rc);
      }
      if ((this.mqSD.SelectionString.VSPtr != IntPtr.Zero && this.selectionString.VSString != null) || (this.mqSD32.SelectionString.VSPtr != 0 && this.selectionString.VSString != null))
      {
        int cc = 2;
        int rc = 2067;
        base.ThrowNewMQException(cc, rc);
      }
      if ((this.mqSD.SubName.VSPtr != IntPtr.Zero && this.subName.VSString != null) || (this.mqSD32.SubName.VSPtr != 0 && this.subName.VSString != null))
      {
        int cc = 2;
        int rc = 2440;
        base.ThrowNewMQException(cc, rc);
      }
      if ((this.mqSD.SubUserData.VSPtr != IntPtr.Zero && this.subUserData.VSString != null) || (this.mqSD32.SubUserData.VSPtr != 0 && this.subUserData.VSString != null))
      {
        int cc = 2;
        int rc = 2440;
        base.ThrowNewMQException(cc, rc);
      }
    }

    public int WriteStruct(byte[] b, int Offset)
    {
      int requiredBufferSize = this.GetRequiredBufferSize();
      int length = this.GetLength();
      IntPtr intPtr = IntPtr.Zero;
      try
      {
        this.CheckArrayLength();
        if (intPtr == IntPtr.Zero)
        {
          intPtr = Marshal.AllocCoTaskMem(length);
          this.mqSDSize = length;
        }
        if (this.useNativePtrSz)
        {
          Marshal.StructureToPtr(this.mqSD, intPtr, false);
        }
        else
        {
          Marshal.StructureToPtr(this.mqSD32, intPtr, false);
        }
        Marshal.Copy(intPtr, b, Offset, length);
        int stringPos = Offset + length;
        stringPos = this.objectString.WriteStruct(b, Offset, Offset + this.OBJSTRING_OFFSET, stringPos);
        stringPos = this.subName.WriteStruct(b, Offset, Offset + this.SUBNAME_OFFSET, stringPos);
        stringPos = this.subUserData.WriteStruct(b, Offset, Offset + this.SUBUSERDATA_OFFSET, stringPos);
        stringPos = this.selectionString.WriteStruct(b, Offset, Offset + this.SELSTRING_OFFSET, stringPos);
        stringPos = this.resObjectString.WriteStruct(b, Offset, Offset + this.ROBJSTRING_OFFSET, stringPos);
      }
      finally
      {
        if (intPtr != IntPtr.Zero)
        {
          Marshal.FreeCoTaskMem(intPtr);
          intPtr = IntPtr.Zero;
        }
      }
      return requiredBufferSize;
    }

    private void CheckArrayLength()
    {
      if (this.mqSD.AlternateSecurityId != null && this.mqSD.AlternateSecurityId.Length != 40)
      {
        this.mqSD.AlternateSecurityId = this.ResizeArrayToCorrectLength(this.mqSD.AlternateSecurityId, 40);
      }
      if (this.mqSD.AlternateUserId != null && this.mqSD.AlternateUserId.Length != 40)
      {
        this.mqSD.AlternateUserId = this.ResizeArrayToCorrectLength(this.mqSD.AlternateUserId, 40);
      }
      if (this.mqSD.ObjectName != null && this.mqSD.ObjectName.Length != 48)
      {
        this.mqSD.ObjectName = this.ResizeArrayToCorrectLength(this.mqSD.ObjectName, 48);
      }
      if (this.mqSD.PubAccountingToken != null && this.mqSD.PubAccountingToken.Length != 32)
      {
        this.mqSD.PubAccountingToken = this.ResizeArrayToCorrectLength(this.mqSD.PubAccountingToken, 32);
      }
      if (this.mqSD.PubApplIdentityData != null && this.mqSD.PubApplIdentityData.Length != 32)
      {
        this.mqSD.PubApplIdentityData = this.ResizeArrayToCorrectLength(this.mqSD.PubApplIdentityData, 32);
      }
      if (this.mqSD.SubCorrelId != null && this.mqSD.SubCorrelId.Length != 24)
      {
        this.mqSD.SubCorrelId = this.ResizeArrayToCorrectLength(this.mqSD.SubCorrelId, 24);
      }
    }

    public int ReadStruct(byte[] b, int Offset, int Length)
    {
      int length = this.GetLength();
      IntPtr intPtr = IntPtr.Zero;
      try
      {
        if (intPtr == IntPtr.Zero)
        {
          intPtr = Marshal.AllocCoTaskMem(length);
          this.mqSDSize = length;
        }
        Marshal.Copy(b, Offset, intPtr, length);
        if (this.useNativePtrSz)
        {
          this.mqSD = (MQSD)Marshal.PtrToStructure(intPtr, typeof(MQSD));
          this.copyToMQSD32();
        }
        else
        {
          this.mqSD32 = (MQSD32)Marshal.PtrToStructure(intPtr, typeof(MQSD32));
          this.copyToMQSD();
        }
        this.objectString.ReadStruct(b, Offset, Offset + this.OBJSTRING_OFFSET);
        this.objectString.GetEndPosAligned(Offset);
        this.subName.ReadStruct(b, Offset, Offset + this.SUBNAME_OFFSET);
        this.subName.GetEndPosAligned(Offset);
        this.subUserData.ReadStruct(b, Offset, Offset + this.SUBUSERDATA_OFFSET);
        this.subUserData.GetEndPosAligned(Offset);
        this.selectionString.ReadStruct(b, Offset, Offset + this.SELSTRING_OFFSET);
        this.selectionString.GetEndPosAligned(Offset);
        this.resObjectString.ReadStruct(b, Offset, Offset + this.ROBJSTRING_OFFSET);
        this.resObjectString.GetEndPosAligned(Offset);
        this.ClearInvalidFields(this.Version);
      }
      finally
      {
        if (intPtr != IntPtr.Zero)
        {
          Marshal.FreeCoTaskMem(intPtr);
          intPtr = IntPtr.Zero;
        }
      }
      return Offset + this.GetVersionLength() + this.objectString.VSLength + this.subName.VSLength + this.subUserData.VSLength + this.selectionString.VSLength + this.resObjectString.VSLength;
    }

    private void calculateOffsets()
    {
      int num;
      if (this.useNativePtrSz && IntPtr.Size == 8)
      {
        num = 4;
      }
      else
      {
        num = 0;
      }
      this.OBJSTRING_OFFSET = 116 + num;
      this.SUBNAME_OFFSET = this.OBJSTRING_OFFSET + this.objectString.GetLength();
      this.SUBUSERDATA_OFFSET = this.SUBNAME_OFFSET + this.subName.GetLength();
      this.SELSTRING_OFFSET = this.SUBUSERDATA_OFFSET + this.subUserData.GetLength() + 24 + 4 + 32 + 32 + num;
      this.ROBJSTRING_OFFSET = this.SELSTRING_OFFSET + this.selectionString.GetLength() + 4 + num;
    }

    private void copyToMQSD32()
    {
      this.mqSD32.AlternateSecurityId = this.mqSD.AlternateSecurityId;
      this.mqSD32.AlternateUserId = this.mqSD.AlternateUserId;
      this.mqSD32.ObjectName = this.mqSD.ObjectName;
      this.mqSD32.Options = this.mqSD.Options;
      this.mqSD32.PubAccountingToken = this.mqSD.PubAccountingToken;
      this.mqSD32.PubApplIdentityData = this.mqSD.PubApplIdentityData;
      this.mqSD32.PubPriority = this.mqSD.PubPriority;
      this.mqSD32.SubCorrelId = this.mqSD.SubCorrelId;
      this.mqSD32.SubExpiry = this.mqSD.SubExpiry;
      this.mqSD32.SubLevel = this.mqSD.SubLevel;
      this.mqSD32.Version = this.mqSD.Version;
    }

    private void copyToMQSD()
    {
      this.mqSD.AlternateSecurityId = this.mqSD32.AlternateSecurityId;
      this.mqSD.AlternateUserId = this.mqSD32.AlternateUserId;
      this.mqSD.ObjectName = this.mqSD32.ObjectName;
      this.mqSD.Options = this.mqSD32.Options;
      this.mqSD.PubAccountingToken = this.mqSD32.PubAccountingToken;
      this.mqSD.PubApplIdentityData = this.mqSD32.PubApplIdentityData;
      this.mqSD.PubPriority = this.mqSD32.PubPriority;
      this.mqSD.SubCorrelId = this.mqSD32.SubCorrelId;
      this.mqSD.SubExpiry = this.mqSD32.SubExpiry;
      this.mqSD.SubLevel = this.mqSD32.SubLevel;
      this.mqSD.Version = this.mqSD32.Version;
    }
  }
}
