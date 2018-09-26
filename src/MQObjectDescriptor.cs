using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public class MQObjectDescriptor : MQBase
  {
      private int mqODSize;

      private MQOD mqOD = default(MQOD);

      private MQOD32 mqOD32 = default(MQOD32);

      private int OBJSTRING_OFFSET;

      private int SELSTRING_OFFSET;

      private int ROBJSTRING_OFFSET;

      private MQCHARV objectString;

      private MQCHARV selectionString;

      private MQCHARV resolvedObjectString;

      private bool useNativePtrSz;

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

      public MQCHARV ResolvedObjectString
      {
        get
        {
          return this.resolvedObjectString;
        }
        set
        {
          this.resolvedObjectString = value;
        }
      }

      public byte[] StrucId
      {
        get
        {
          return this.mqOD.StrucId;
        }
        set
        {
          this.mqOD.StrucId = value;
          this.mqOD32.StrucId = value;
        }
      }

      public int ObjectType
      {
        get
        {
          return this.mqOD.ObjectType;
        }
        set
        {
          this.mqOD.ObjectType = value;
          this.mqOD32.ObjectType = value;
        }
      }

      public string ObjectName
      {
        get
        {
          return base.GetString(this.mqOD.ObjectName);
        }
        set
        {
          byte[] objectName = new byte[48];
          base.GetBytes(value, ref objectName);
          this.mqOD.ObjectName = objectName;
          this.mqOD32.ObjectName = objectName;
        }
      }

      public string ObjectQMgrName
      {
        get
        {
          return base.GetString(this.mqOD.ObjectQMgrName);
        }
        set
        {
          byte[] objectQMgrName = new byte[48];
          base.GetBytes(value, ref objectQMgrName);
          this.mqOD.ObjectQMgrName = objectQMgrName;
          this.mqOD32.ObjectQMgrName = objectQMgrName;
        }
      }

      public string DynamicQName
      {
        get
        {
          return base.GetString(this.mqOD.DynamicQName);
        }
        set
        {
          byte[] dynamicQName = new byte[48];
          base.GetBytesRightPad(value, ref dynamicQName);
          this.mqOD.DynamicQName = dynamicQName;
          this.mqOD32.DynamicQName = dynamicQName;
        }
      }

      public string AlternateUserId
      {
        get
        {
          return base.GetString(this.mqOD.AlternateUserId);
        }
        set
        {
          byte[] alternateUserId = new byte[12];
          base.GetBytes(value, ref alternateUserId);
          this.mqOD.AlternateUserId = alternateUserId;
          this.mqOD32.AlternateUserId = alternateUserId;
        }
      }

      public int Version
      {
        get
        {
          return this.mqOD.Version;
        }
        set
        {
          this.mqOD.Version = value;
          this.mqOD32.Version = value;
        }
      }

      public int RecordsPresent
      {
        get
        {
          return this.mqOD.RecsPresent;
        }
        set
        {
          this.mqOD.RecsPresent = value;
          this.mqOD32.RecsPresent = value;
        }
      }

      public int KnownDestCount
      {
        get
        {
          return this.mqOD.KnownDestCount;
        }
        set
        {
          this.mqOD.KnownDestCount = value;
          this.mqOD32.KnownDestCount = value;
        }
      }

      public int UnknownDestCount
      {
        get
        {
          return this.mqOD.UnknownDestCount;
        }
        set
        {
          this.mqOD.UnknownDestCount = value;
          this.mqOD32.UnknownDestCount = value;
        }
      }

      public int InvalidDestCount
      {
        get
        {
          return this.mqOD.InvalidDestCount;
        }
        set
        {
          this.mqOD.InvalidDestCount = value;
          this.mqOD32.InvalidDestCount = value;
        }
      }

      public int ObjectRecordOffset
      {
        get
        {
          return this.mqOD.ObjectRecOffset;
        }
        set
        {
          this.mqOD.ObjectRecOffset = value;
          this.mqOD32.ObjectRecOffset = value;
        }
      }

      public int ResponseRecordOffset
      {
        get
        {
          return this.mqOD.ResponseRecOffset;
        }
        set
        {
          this.mqOD.ResponseRecOffset = value;
          this.mqOD32.ResponseRecOffset = value;
        }
      }

      public IntPtr ObjectRecordPtr
      {
        get
        {
          return this.mqOD.ObjectRecPtr;
        }
        set
        {
          this.mqOD.ObjectRecPtr = value;
        }
      }

      public int ObjectRecordPtr32
      {
        get
        {
          return this.mqOD32.ObjectRecPtr;
        }
        set
        {
          this.mqOD32.ObjectRecPtr = value;
        }
      }

      public IntPtr ResponseRecordPtr
      {
        get
        {
          return this.mqOD.ResponseRecPtr;
        }
        set
        {
          this.mqOD.ResponseRecPtr = value;
        }
      }

      public int ResponseRecordPtr32
      {
        get
        {
          return this.mqOD32.ResponseRecPtr;
        }
        set
        {
          this.mqOD32.ResponseRecPtr = value;
        }
      }

      public byte[] AlternateSecurityId
      {
        get
        {
          return this.mqOD.AlternateSecurityId;
        }
        set
        {
          this.Version = ((this.Version < 2) ? 2 : this.Version);
          this.mqOD.AlternateSecurityId = value;
          this.mqOD32.AlternateSecurityId = value;
        }
      }

      public byte[] ResolvedQueueName
      {
        get
        {
          return this.mqOD.ResolvedQName;
        }
        set
        {
          this.Version = ((this.Version < 2) ? 2 : this.Version);
          this.mqOD.ResolvedQName = value;
          this.mqOD32.ResolvedQName = value;
        }
      }

      public byte[] ResolvedQueueManagerName
      {
        get
        {
          return this.mqOD.ResolvedQMgrName;
        }
        set
        {
          this.Version = ((this.Version < 2) ? 2 : this.Version);
          this.mqOD.ResolvedQMgrName = value;
          this.mqOD32.ResolvedQMgrName = value;
        }
      }

      public int ResolvedType
      {
        get
        {
          return this.mqOD.ResolvedType;
        }
        set
        {
          this.Version = ((this.Version < 3) ? 3 : this.Version);
          this.mqOD.ResolvedType = value;
        }
      }

      public MQOD StructMQOD
      {
        get
        {
          this.CheckArrayLength();
          return this.mqOD;
        }
        set
        {
          this.mqOD = value;
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
          this.selectionString.UseNativePtrSz = value;
          this.resolvedObjectString.UseNativePtrSz = value;
          this.calculateOffsets();
        }
      }

      public MQObjectDescriptor()
      {
        this.objectString = new MQCHARV(true, false);
        this.selectionString = new MQCHARV(true, false);
        this.resolvedObjectString = new MQCHARV(false, true);
        this.ClearInvalidFields(0);
        this.useNativePtrSz = true;
      }

      private void ClearInvalidFields(int ver)
      {
        switch (ver)
        {
          case 0:
            this.StrucId = new byte[4];
            this.StrucId[0] = 79;
            this.StrucId[1] = 68;
            this.StrucId[2] = 32;
            this.StrucId[3] = 32;
            this.ObjectType = 1;
            this.ObjectName = "";
            this.ObjectQMgrName = "";
            this.DynamicQName = "AMQ.*";
            this.AlternateUserId = "";
            break;
          case 1:
            break;
          case 2:
            goto IL_F5;
          case 3:
            goto IL_11C;
          default:
            goto IL_282;
        }
        this.RecordsPresent = 0;
        this.KnownDestCount = 0;
        this.UnknownDestCount = 0;
        this.InvalidDestCount = 0;
        this.ObjectRecordOffset = 0;
        this.ResponseRecordOffset = 0;
        this.ObjectRecordPtr = IntPtr.Zero;
        this.ResponseRecordPtr = IntPtr.Zero;
        this.ObjectRecordPtr32 = 0;
        this.ResponseRecordPtr32 = 0;
        IL_F5:
        this.AlternateSecurityId = new byte[40];
        this.ResolvedQueueName = new byte[48];
        this.ResolvedQueueManagerName = new byte[48];
        IL_11C:
        this.ResolvedType = 0;
        this.mqOD.ObjectString = new MQBase.structMQCHARV
        {
          VSPtr = IntPtr.Zero,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqOD.SelectionString = new MQBase.structMQCHARV
        {
          VSPtr = IntPtr.Zero,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqOD.ResolvedObjectString = new MQBase.structMQCHARV
        {
          VSPtr = IntPtr.Zero,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqOD32.ObjectString = new MQBase.structMQCHARV32
        {
          VSPtr = 0,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqOD32.SelectionString = new MQBase.structMQCHARV32
        {
          VSPtr = 0,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        this.mqOD32.ResolvedObjectString = new MQBase.structMQCHARV32
        {
          VSPtr = 0,
          VSOffset = 0,
          VSLength = 0,
          VSCCSID = 1208
        };
        IL_282:
        if (ver == 0)
        {
          this.Version = 1;
        }
        this.calculateOffsets();
      }

      public int GetLength()
      {
        if (this.useNativePtrSz)
        {
          int num = Marshal.SizeOf(this.mqOD);
          return num;
        }
        int num2 = Marshal.SizeOf(this.mqOD32);
        return num2;
      }

      internal int GetVersionLength()
      {
        return this.GetVersionLength(this.Version);
      }

      internal int GetVersionLength(int ver)
      {
        uint method = 501u;
        int num = 0;
        int num2 = 4;
        int num3 = 0;
        int num4;
        if (this.useNativePtrSz)
        {
          num4 = IntPtr.Size;
        }
        else
        {
          num4 = 4;
        }
        if (num4 == 8)
        {
          num3 = 4;
        }
        num += 4 + num2 + num2 + 48 + 48 + 48 + 12;
        if (ver == 1)
        {
          return num;
        }
        num += num2 + num2 + num2 + num2 + num2 + num2 + num4 + num4;
        if (ver == 2)
        {
          return num;
        }
        num += 136;
        if (ver == 3)
        {
          return num;
        }
        num += this.objectString.GetLength() + this.selectionString.GetLength() + this.resolvedObjectString.GetLength() + num2 + num3;
        return num;
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
        if (this.mqOD.Version >= 4)
        {
          num += this.GetPaddedLength(this.objectString.VSString);
          num += this.GetPaddedLength(this.selectionString.VSString);
          num += this.GetPaddedLength(this.resolvedObjectString.VSBufSize);
        }
        return num;
      }

      public int WriteStruct(byte[] b, int Offset)
      {
        int versionLength = this.GetVersionLength();
        int length = this.GetLength();
        int requiredBufferSize = this.GetRequiredBufferSize();
        IntPtr intPtr = IntPtr.Zero;
        try
        {
          this.CheckArrayLength();
          if (intPtr == IntPtr.Zero)
          {
            intPtr = Marshal.AllocCoTaskMem(length);
            this.mqODSize = length;
          }
          if (this.useNativePtrSz)
          {
            Marshal.StructureToPtr(this.mqOD, intPtr, false);
          }
          else
          {
            Marshal.StructureToPtr(this.mqOD32, intPtr, false);
          }
          Marshal.Copy(intPtr, b, Offset, versionLength);
          int stringPos = Offset + length;
          if (this.mqOD.Version >= 4)
          {
            this.calculateOffsets();
            if (Offset + this.OBJSTRING_OFFSET > 0)
            {
              stringPos = this.objectString.WriteStruct(b, Offset, Offset + this.OBJSTRING_OFFSET, stringPos);
            }
            if (Offset + this.SELSTRING_OFFSET > 0)
            {
              stringPos = this.selectionString.WriteStruct(b, Offset, Offset + this.SELSTRING_OFFSET, stringPos);
            }
            if (Offset + this.ROBJSTRING_OFFSET > 0)
            {
              stringPos = this.resolvedObjectString.WriteStruct(b, Offset, Offset + this.ROBJSTRING_OFFSET, stringPos);
            }
          }
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
        if (this.mqOD.alternateSecurityId != null && this.mqOD.alternateSecurityId.Length != 40)
        {
          this.mqOD.alternateSecurityId = this.ResizeArrayToCorrectLength(this.mqOD.alternateSecurityId, 40);
        }
        if (this.mqOD.AlternateUserId != null && this.mqOD.AlternateUserId.Length != 12)
        {
          this.mqOD.AlternateUserId = this.ResizeArrayToCorrectLength(this.mqOD.AlternateUserId, 12);
        }
        if (this.mqOD.DynamicQName != null && this.mqOD.DynamicQName.Length != 48)
        {
          this.mqOD.DynamicQName = this.ResizeArrayToCorrectLength(this.mqOD.DynamicQName, 48);
        }
        if (this.mqOD.ObjectName != null && this.mqOD.ObjectName.Length != 48)
        {
          this.mqOD.ObjectName = this.ResizeArrayToCorrectLength(this.mqOD.ObjectName, 48);
        }
        if (this.mqOD.ObjectQMgrName != null && this.mqOD.ObjectQMgrName.Length != 48)
        {
          this.mqOD.ObjectQMgrName = this.ResizeArrayToCorrectLength(this.mqOD.ObjectQMgrName, 48);
        }
      }

      public int ReadStruct(byte[] b, int Offset, int Length)
      {
        int versionLength = this.GetVersionLength();
        int result = Offset;
        int length = this.GetLength();
        int requiredBufferSize = this.GetRequiredBufferSize();
        IntPtr intPtr = IntPtr.Zero;
        try
        {
          if (intPtr == IntPtr.Zero)
          {
            intPtr = Marshal.AllocCoTaskMem(length);
            this.mqODSize = versionLength;
          }
          Marshal.Copy(b, Offset, intPtr, versionLength);
          if (this.useNativePtrSz)
          {
            this.mqOD = (MQOD)Marshal.PtrToStructure(intPtr, typeof(MQOD));
            this.copyToMQOD32();
          }
          else
          {
            this.mqOD32 = (MQOD32)Marshal.PtrToStructure(intPtr, typeof(MQOD32));
            this.copyToMQOD();
          }
          result = Offset + requiredBufferSize;
          if (this.mqOD.Version >= 4)
          {
            this.objectString.ReadStruct(b, Offset, Offset + this.OBJSTRING_OFFSET);
            this.objectString.GetEndPosAligned(Offset);
            this.selectionString.ReadStruct(b, Offset, Offset + this.SELSTRING_OFFSET);
            this.selectionString.GetEndPosAligned(Offset);
            this.resolvedObjectString.ReadStruct(b, Offset, Offset + this.ROBJSTRING_OFFSET);
            this.resolvedObjectString.GetEndPosAligned(Offset);
          }
          this.ClearInvalidFields(this.mqOD.Version);
        }
        finally
        {
          if (intPtr != IntPtr.Zero)
          {
            Marshal.FreeCoTaskMem(intPtr);
            intPtr = IntPtr.Zero;
          }
        }
        return result;
      }

      private void calculateOffsets()
      {
        this.OBJSTRING_OFFSET = this.GetVersionLength(3);
        this.SELSTRING_OFFSET = this.OBJSTRING_OFFSET + this.objectString.GetLength();
        this.ROBJSTRING_OFFSET = this.SELSTRING_OFFSET + this.selectionString.GetLength();
      }

      private void copyToMQOD32()
      {
        this.mqOD32.AlternateSecurityId = this.mqOD.AlternateSecurityId;
        this.mqOD32.AlternateUserId = this.mqOD.AlternateUserId;
        this.mqOD32.DynamicQName = this.mqOD.DynamicQName;
        this.mqOD32.InvalidDestCount = this.mqOD.InvalidDestCount;
        this.mqOD32.KnownDestCount = this.mqOD.KnownDestCount;
        this.mqOD32.ObjectName = this.mqOD.ObjectName;
        this.mqOD32.ObjectQMgrName = this.mqOD.ObjectQMgrName;
        this.mqOD32.ObjectRecOffset = this.mqOD.ObjectRecOffset;
        this.mqOD32.ObjectType = this.mqOD.ObjectType;
        this.mqOD32.RecsPresent = this.mqOD.RecsPresent;
        this.mqOD32.ResolvedQMgrName = this.mqOD.ResolvedQMgrName;
        this.mqOD32.ResolvedQName = this.mqOD.ResolvedQName;
        this.mqOD32.ResolvedType = this.mqOD.ResolvedType;
        this.mqOD32.ResponseRecOffset = this.mqOD.ResponseRecOffset;
        this.mqOD32.UnknownDestCount = this.mqOD.UnknownDestCount;
        this.mqOD32.Version = this.mqOD.Version;
      }

      private void copyToMQOD()
      {
        this.mqOD.AlternateSecurityId = this.mqOD32.AlternateSecurityId;
        this.mqOD.AlternateUserId = this.mqOD32.AlternateUserId;
        this.mqOD.DynamicQName = this.mqOD32.DynamicQName;
        this.mqOD.InvalidDestCount = this.mqOD32.InvalidDestCount;
        this.mqOD.KnownDestCount = this.mqOD32.KnownDestCount;
        this.mqOD.ObjectName = this.mqOD32.ObjectName;
        this.mqOD.ObjectQMgrName = this.mqOD32.ObjectQMgrName;
        this.mqOD.ObjectRecOffset = this.mqOD32.ObjectRecOffset;
        this.mqOD.ObjectType = this.mqOD32.ObjectType;
        this.mqOD.RecsPresent = this.mqOD32.RecsPresent;
        this.mqOD.ResolvedQMgrName = this.mqOD32.ResolvedQMgrName;
        this.mqOD.ResolvedQName = this.mqOD32.ResolvedQName;
        this.mqOD.ResolvedType = this.mqOD32.ResolvedType;
        this.mqOD.ResponseRecOffset = this.mqOD32.ResponseRecOffset;
        this.mqOD.UnknownDestCount = this.mqOD32.UnknownDestCount;
        this.mqOD.Version = this.mqOD32.Version;
      }

    internal void CopyCHARVIntoOD()
    {
      this.mqOD.ObjectString = this.objectString.mqcharv;
      this.mqOD.SelectionString = this.selectionString.mqcharv;
      if (this.mqOD.ObjectString.VSPtr != IntPtr.Zero && this.objectString.VSString != null)
      {
        base.ThrowNewMQException(2, 2425);
      }
      if (this.mqOD.SelectionString.VSPtr != IntPtr.Zero && this.selectionString.VSString != null)
      {
        base.ThrowNewMQException(2, 2425);
      }
    }
  }
}
