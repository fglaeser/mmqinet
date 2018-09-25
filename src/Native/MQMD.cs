using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{

  public struct MQMD
  {
    [MarshalAs(30, SizeConst = 4)]
    private byte[] strucId;

    private int version;

    private int report;

    private int msgType;

    private int expiry;

    private int feedback;

    private int encoding;

    private int codedCharacterSetId;

    [MarshalAs(30, SizeConst = 8)]
    private byte[] format;

    private int priority;

    private int persistence;

    [MarshalAs(30, SizeConst = 24)]
    public byte[] msgId;

    [MarshalAs(30, SizeConst = 24)]
    public byte[] correlId;

    private int backoutCount;

    [MarshalAs(30, SizeConst = 48)]
    public byte[] replyToQ;

    [MarshalAs(30, SizeConst = 48)]
    public byte[] replyToQMgr;

    [MarshalAs(30, SizeConst = 12)]
    public byte[] userId;

    [MarshalAs(30, SizeConst = 32)]
    public byte[] accountingToken;

    [MarshalAs(30, SizeConst = 32)]
    public byte[] applIdentityData;

    private int putApplType;

    [MarshalAs(30, SizeConst = 28)]
    public byte[] putApplName;

    [MarshalAs(30, SizeConst = 8)]
    public byte[] putDate;

    [MarshalAs(30, SizeConst = 8)]
    public byte[] putTime;

    [MarshalAs(30, SizeConst = 4)]
    public byte[] applOriginData;

    [MarshalAs(30, SizeConst = 24)]
    public byte[] groupId;

    private int msgSequenceNumber;

    private int offset;

    private int msgFlags;

    private int originalLength;

    public byte[] StrucId
    {
      get
      {
        return this.strucId;
      }
      set
      {
        this.strucId = value;
      }
    }

    public int Version
    {
      get
      {
        return this.version;
      }
      set
      {
        this.version = value;
      }
    }

    public int Report
    {
      get
      {
        return this.report;
      }
      set
      {
        this.report = value;
      }
    }

    public int MsgType
    {
      get
      {
        return this.msgType;
      }
      set
      {
        this.msgType = value;
      }
    }

    public int Expiry
    {
      get
      {
        return this.expiry;
      }
      set
      {
        this.expiry = value;
      }
    }

    public int Feedback
    {
      get
      {
        return this.feedback;
      }
      set
      {
        this.feedback = value;
      }
    }

    public int Encoding
    {
      get
      {
        return this.encoding;
      }
      set
      {
        this.encoding = value;
      }
    }

    public int CodedCharacterSetId
    {
      get
      {
        return this.codedCharacterSetId;
      }
      set
      {
        this.codedCharacterSetId = value;
      }
    }

    public byte[] Format
    {
      get
      {
        return this.format;
      }
      set
      {
        this.format = value;
      }
    }

    public int Priority
    {
      get
      {
        return this.priority;
      }
      set
      {
        this.priority = value;
      }
    }

    public int Persistence
    {
      get
      {
        return this.persistence;
      }
      set
      {
        this.persistence = value;
      }
    }

    public byte[] MsgId
    {
      get
      {
        return this.msgId;
      }
      set
      {
        this.msgId = value;
      }
    }

    public byte[] CorrelId
    {
      get
      {
        return this.correlId;
      }
      set
      {
        this.correlId = value;
      }
    }

    public int BackoutCount
    {
      get
      {
        return this.backoutCount;
      }
      set
      {
        this.backoutCount = value;
      }
    }

    public byte[] ReplyToQ
    {
      get
      {
        return this.replyToQ;
      }
      set
      {
        this.replyToQ = value;
      }
    }

    public byte[] ReplyToQMgr
    {
      get
      {
        return this.replyToQMgr;
      }
      set
      {
        this.replyToQMgr = value;
      }
    }

    public byte[] UserId
    {
      get
      {
        return this.userId;
      }
      set
      {
        this.userId = value;
      }
    }

    public byte[] AccountingToken
    {
      get
      {
        return this.accountingToken;
      }
      set
      {
        this.accountingToken = value;
      }
    }

    public byte[] ApplIdentityData
    {
      get
      {
        return this.applIdentityData;
      }
      set
      {
        this.applIdentityData = value;
      }
    }

    public int PutApplType
    {
      get
      {
        return this.putApplType;
      }
      set
      {
        this.putApplType = value;
      }
    }

    public byte[] PutApplName
    {
      get
      {
        return this.putApplName;
      }
      set
      {
        this.putApplName = value;
      }
    }

    public byte[] PutDate
    {
      get
      {
        return this.putDate;
      }
      set
      {
        this.putDate = value;
      }
    }

    public byte[] PutTime
    {
      get
      {
        return this.putTime;
      }
      set
      {
        this.putTime = value;
      }
    }

    public byte[] ApplOriginData
    {
      get
      {
        return this.applOriginData;
      }
      set
      {
        this.applOriginData = value;
      }
    }

    public byte[] GroupId
    {
      get
      {
        return this.groupId;
      }
      set
      {
        this.groupId = value;
      }
    }

    public int MsgSequenceNumber
    {
      get
      {
        return this.msgSequenceNumber;
      }
      set
      {
        this.msgSequenceNumber = value;
      }
    }

    public int Offset
    {
      get
      {
        return this.offset;
      }
      set
      {
        this.offset = value;
      }
    }

    public int MsgFlags
    {
      get
      {
        return this.msgFlags;
      }
      set
      {
        this.msgFlags = value;
      }
    }

    public int OriginalLength
    {
      get
      {
        return this.originalLength;
      }
      set
      {
        this.originalLength = value;
      }
    }
  }
}
