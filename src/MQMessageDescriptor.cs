using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
    public class MQMessageDescriptor : MQBase
    {
      private MQMD mqmd = default(MQMD);

      private static readonly byte[] MQMD_STRUC_ID = new byte[]
      {
      77,
      68,
      32,
      32
      };

      public MQMD StructMQMD
      {
        get
        {
          this.CheckArrayLength();
          return this.mqmd;
        }
        set
        {
          this.mqmd = value;
        }
      }

      public int Version
      {
        get
        {
          return this.mqmd.Version;
        }
        set
        {
          this.mqmd.Version = value;
        }
      }

      public int Encoding
      {
        get
        {
          return this.mqmd.Encoding;
        }
        set
        {
          this.mqmd.Encoding = value;
        }
      }

      public int BackoutCount
      {
        get
        {
          return this.mqmd.BackoutCount;
        }
        set
        {
          this.mqmd.BackoutCount = value;
        }
      }

      public int Ccsid
      {
        get
        {
          return this.mqmd.CodedCharacterSetId;
        }
        set
        {
          this.mqmd.CodedCharacterSetId = value;
        }
      }

      public byte[] MsgId
      {
        get
        {
          return this.mqmd.MsgId;
        }
        set
        {
          this.mqmd.MsgId = value;
        }
      }

      public byte[] CorrelId
      {
        get
        {
          return this.mqmd.CorrelId;
        }
        set
        {
          this.mqmd.CorrelId = value;
        }
      }

      public int Report
      {
        get
        {
          return this.mqmd.Report;
        }
        set
        {
          this.mqmd.Report = value;
        }
      }

      public int MsgType
      {
        get
        {
          return this.mqmd.MsgType;
        }
        set
        {
          this.mqmd.MsgType = value;
        }
      }

      public int Expiry
      {
        get
        {
          return this.mqmd.Expiry;
        }
        set
        {
          this.mqmd.Expiry = value;
        }
      }

      public int Feedback
      {
        get
        {
          return this.mqmd.Feedback;
        }
        set
        {
          this.mqmd.Feedback = value;
        }
      }

      public int CodedCharacterSetId
      {
        get
        {
          return this.mqmd.CodedCharacterSetId;
        }
        set
        {
          this.mqmd.CodedCharacterSetId = value;
        }
      }

      public byte[] Format
      {
        get
        {
          return this.mqmd.Format;
        }
        set
        {
          this.mqmd.Format = value;
        }
      }

      public int Priority
      {
        get
        {
          return this.mqmd.Priority;
        }
        set
        {
          this.mqmd.Priority = value;
        }
      }

      public int Persistence
      {
        get
        {
          return this.mqmd.Persistence;
        }
        set
        {
          this.mqmd.Persistence = value;
        }
      }

      public byte[] ReplyToQueue
      {
        get
        {
          return this.mqmd.ReplyToQ;
        }
        set
        {
          this.mqmd.ReplyToQ = value;
        }
      }

      public byte[] ReplyToQueueMgr
      {
        get
        {
          return this.mqmd.ReplyToQMgr;
        }
        set
        {
          this.mqmd.ReplyToQMgr = value;
        }
      }

      public byte[] UserID
      {
        get
        {
          return this.mqmd.UserId;
        }
        set
        {
          this.mqmd.UserId = value;
        }
      }

      public byte[] AccountingToken
      {
        get
        {
          return this.mqmd.AccountingToken;
        }
        set
        {
          this.mqmd.AccountingToken = value;
        }
      }

      public byte[] ApplIdentityData
      {
        get
        {
          return this.mqmd.ApplIdentityData;
        }
        set
        {
          this.mqmd.ApplIdentityData = value;
        }
      }

      public int PutApplType
      {
        get
        {
          return this.mqmd.PutApplType;
        }
        set
        {
          this.mqmd.PutApplType = value;
        }
      }

      public byte[] PutApplName
      {
        get
        {
          return this.mqmd.PutApplName;
        }
        set
        {
          this.mqmd.PutApplName = value;
        }
      }

      public byte[] PutDate
      {
        get
        {
          return this.mqmd.PutDate;
        }
        set
        {
          this.mqmd.PutDate = value;
        }
      }

      public byte[] PutTime
      {
        get
        {
          return this.mqmd.PutTime;
        }
        set
        {
          this.mqmd.PutTime = value;
        }
      }

      public byte[] ApplOriginData
      {
        get
        {
          return this.mqmd.ApplOriginData;
        }
        set
        {
          this.mqmd.ApplOriginData = value;
        }
      }

      public byte[] GroupID
      {
        get
        {
          return this.mqmd.GroupId;
        }
        set
        {
          this.mqmd.GroupId = value;
        }
      }

      public int MsgSequenceNumber
      {
        get
        {
          return this.mqmd.MsgSequenceNumber;
        }
        set
        {
          this.mqmd.MsgSequenceNumber = value;
        }
      }

      public int Offset
      {
        get
        {
          return this.mqmd.Offset;
        }
        set
        {
          this.mqmd.Offset = value;
        }
      }

      public int MsgFlags
      {
        get
        {
          return this.mqmd.MsgFlags;
        }
        set
        {
          this.mqmd.MsgFlags = value;
        }
      }

      public int OriginalLength
      {
        get
        {
          return this.mqmd.OriginalLength;
        }
        set
        {
          this.mqmd.OriginalLength = value;
        }
      }

      public MQMessageDescriptor()
      {
        this.ClearInvalidFields(0);
      }

      private void ClearInvalidFields(int Version)
      {
        switch (Version)
        {
          case 0:
            {
              this.mqmd.StrucId = MQMessageDescriptor.MQMD_STRUC_ID;
              this.mqmd.Report = 0;
              this.mqmd.MsgType = 8;
              this.mqmd.Expiry = -1;
              this.mqmd.Feedback = 0;
              this.mqmd.Encoding = 546;
              this.mqmd.CodedCharacterSetId = 0;
              byte[] format = new byte[8];
              base.GetBytes("        ", ref format);
              this.mqmd.Format = format;
              this.mqmd.Priority = -1;
              this.mqmd.Persistence = 2;
              this.mqmd.MsgId = new byte[24];
              this.mqmd.CorrelId = new byte[24];
              this.mqmd.BackoutCount = 0;
              this.mqmd.ReplyToQ = new byte[48];
              this.mqmd.ReplyToQMgr = new byte[48];
              this.mqmd.UserId = new byte[12];
              this.mqmd.AccountingToken = new byte[32];
              this.mqmd.ApplIdentityData = new byte[32];
              this.mqmd.PutApplType = 0;
              this.mqmd.PutApplName = new byte[28];
              this.mqmd.PutDate = new byte[8];
              this.mqmd.PutTime = new byte[8];
              this.mqmd.ApplOriginData = new byte[4];
              break;
            }
          case 1:
            break;
          default:
            goto IL_1E4;
        }
        this.mqmd.GroupId = new byte[24];
        this.mqmd.MsgSequenceNumber = 1;
        this.mqmd.Offset = 0;
        this.mqmd.MsgFlags = 0;
        this.mqmd.OriginalLength = -1;
        IL_1E4:
        if (Version == 0)
        {
          this.mqmd.Version = 1;
        }
      }

      internal MQMessageDescriptor(MQMessageDescriptor md)
      {
        MQMD mQMD = md.mqmd;
        this.mqmd.StrucId = (byte[])this.mqmd.StrucId.Clone();
        this.mqmd.Version = mQMD.Version;
        this.mqmd.Report = mQMD.Report;
        this.mqmd.MsgType = mQMD.MsgType;
        this.mqmd.Expiry = mQMD.Expiry;
        this.mqmd.Feedback = mQMD.Feedback;
        this.mqmd.Encoding = mQMD.Encoding;
        this.mqmd.CodedCharacterSetId = mQMD.CodedCharacterSetId;
        this.mqmd.Format = (byte[])mQMD.Format.Clone();
        this.mqmd.Priority = mQMD.Priority;
        this.mqmd.Persistence = mQMD.Persistence;
        this.mqmd.MsgId = (byte[])mQMD.MsgId.Clone();
        this.mqmd.CorrelId = (byte[])mQMD.CorrelId.Clone();
        this.mqmd.BackoutCount = mQMD.BackoutCount;
        this.mqmd.ReplyToQ = (byte[])mQMD.ReplyToQ.Clone();
        this.mqmd.ReplyToQMgr = (byte[])mQMD.ReplyToQMgr.Clone();
        this.mqmd.UserId = (byte[])mQMD.UserId.Clone();
        this.mqmd.AccountingToken = (byte[])mQMD.AccountingToken.Clone();
        this.mqmd.ApplIdentityData = (byte[])mQMD.ApplIdentityData.Clone();
        this.mqmd.PutApplType = mQMD.PutApplType;
        this.mqmd.PutApplName = (byte[])mQMD.PutApplName.Clone();
        this.mqmd.PutDate = (byte[])mQMD.PutDate.Clone();
        this.mqmd.PutTime = (byte[])mQMD.PutTime.Clone();
        this.mqmd.ApplOriginData = (byte[])mQMD.ApplOriginData.Clone();
        this.mqmd.GroupId = (byte[])mQMD.GroupId.Clone();
        this.mqmd.MsgSequenceNumber = mQMD.MsgSequenceNumber;
        this.mqmd.Offset = mQMD.Offset;
        this.mqmd.MsgFlags = mQMD.MsgFlags;
        this.mqmd.OriginalLength = mQMD.OriginalLength;
      }

      public int GetLength()
      {
        return Marshal.SizeOf(this.mqmd);
      }

      public int GetVersionLength()
      {
        switch (this.mqmd.Version)
        {
          case 1:
            return 324;
          case 2:
            return 364;
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
          Marshal.StructureToPtr(this.mqmd, intPtr, false);
          Marshal.Copy(intPtr, b, Offset, versionLength);
          Marshal.FreeCoTaskMem(intPtr);
        return versionLength;
      }

      private void CheckArrayLength()
      {
        if (this.mqmd.accountingToken != null && this.mqmd.accountingToken.Length != 32)
        {
          this.mqmd.accountingToken = this.ResizeArrayToCorrectLength(this.mqmd.accountingToken, 32);
        }
        if (this.mqmd.applIdentityData != null && this.mqmd.applIdentityData.Length != 32)
        {
          this.mqmd.applIdentityData = this.ResizeArrayToCorrectLength(this.mqmd.applIdentityData, 32);
        }
        if (this.mqmd.applOriginData != null && this.mqmd.applOriginData.Length != 4)
        {
          this.mqmd.applOriginData = this.ResizeArrayToCorrectLength(this.mqmd.applOriginData, 4);
        }
        if (this.mqmd.correlId != null && this.mqmd.correlId.Length != 24)
        {
          this.mqmd.correlId = this.ResizeArrayToCorrectLength(this.mqmd.correlId, 24);
        }
        if (this.mqmd.Format != null && this.mqmd.Format.Length != 8)
        {
          this.mqmd.Format = this.ResizeArrayToCorrectLength(this.mqmd.Format, 8);
        }
        if (this.mqmd.groupId != null && this.mqmd.groupId.Length != 24)
        {
          this.mqmd.groupId = this.ResizeArrayToCorrectLength(this.mqmd.groupId, 24);
        }
        if (this.mqmd.msgId != null && this.mqmd.msgId.Length != 24)
        {
          this.mqmd.msgId = this.ResizeArrayToCorrectLength(this.mqmd.msgId, 24);
        }
        if (this.mqmd.putApplName != null && this.mqmd.putApplName.Length != 28)
        {
          this.mqmd.putApplName = this.ResizeArrayToCorrectLength(this.mqmd.putApplName, 28);
        }
        if (this.mqmd.putDate != null && this.mqmd.putDate.Length != 8)
        {
          this.mqmd.putDate = this.ResizeArrayToCorrectLength(this.mqmd.putDate, 8);
        }
        if (this.mqmd.putTime != null && this.mqmd.putTime.Length != 8)
        {
          this.mqmd.putTime = this.ResizeArrayToCorrectLength(this.mqmd.putTime, 8);
        }
        if (this.mqmd.replyToQ != null && this.mqmd.replyToQ.Length != 48)
        {
          this.mqmd.replyToQ = this.ResizeArrayToCorrectLength(this.mqmd.replyToQ, 48);
        }
        if (this.mqmd.replyToQMgr != null && this.mqmd.replyToQMgr.Length != 48)
        {
          this.mqmd.replyToQMgr = this.ResizeArrayToCorrectLength(this.mqmd.replyToQMgr, 48);
        }
        if (this.mqmd.userId != null && this.mqmd.userId.Length != 12)
        {
          this.mqmd.userId = this.ResizeArrayToCorrectLength(this.mqmd.userId, 12);
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
        this.mqmd = (MQMD)Marshal.PtrToStructure(intPtr, typeof(MQMD));
        this.ClearInvalidFields(this.mqmd.Version);
        Marshal.FreeCoTaskMem(intPtr);
        num2 = Offset + this.GetVersionLength();
        return num2;
      }
    }
  }
