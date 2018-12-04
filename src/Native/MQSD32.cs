using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
  public struct MQSD32
  {
    [MarshalAs(30, SizeConst = 4)]
    private byte[] strucId;

    private int version;

    private int options;

    [MarshalAs(30, SizeConst = 48)]
    private byte[] objectName;

    [MarshalAs(30, SizeConst = 12)]
    private byte[] alternateUserId;

    [MarshalAs(30, SizeConst = 40)]
    private byte[] alternateSecurityId;

    private int subExpiry;

    private MQBase.structMQCHARV32 objectString;

    private MQBase.structMQCHARV32 subName;

    private MQBase.structMQCHARV32 subUserData;

    [MarshalAs(30, SizeConst = 24)]
    private byte[] subCorrelId;

    private int pubPriority;

    [MarshalAs(30, SizeConst = 32)]
    private byte[] pubAccountingToken;

    [MarshalAs(30, SizeConst = 32)]
    private byte[] pubApplIdentityData;

    private MQBase.structMQCHARV32 selectionString;

    private int subLevel;

    private MQBase.structMQCHARV32 resObjectString;

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

    public int Options
    {
      get
      {
        return this.options;
      }
      set
      {
        this.options = value;
      }
    }

    public byte[] ObjectName
    {
      get
      {
        return this.objectName;
      }
      set
      {
        this.objectName = value;
      }
    }

    public byte[] AlternateUserId
    {
      get
      {
        return this.alternateUserId;
      }
      set
      {
        this.alternateUserId = value;
      }
    }

    public byte[] AlternateSecurityId
    {
      get
      {
        return this.alternateSecurityId;
      }
      set
      {
        this.alternateSecurityId = value;
      }
    }

    public int SubExpiry
    {
      get
      {
        return this.subExpiry;
      }
      set
      {
        this.subExpiry = value;
      }
    }

    public MQBase.structMQCHARV32 ObjectString
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

    public MQBase.structMQCHARV32 SubName
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

    public MQBase.structMQCHARV32 SubUserData
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

    public byte[] SubCorrelId
    {
      get
      {
        return this.subCorrelId;
      }
      set
      {
        this.subCorrelId = value;
      }
    }

    public int PubPriority
    {
      get
      {
        return this.pubPriority;
      }
      set
      {
        this.pubPriority = value;
      }
    }

    public byte[] PubAccountingToken
    {
      get
      {
        return this.pubAccountingToken;
      }
      set
      {
        this.pubAccountingToken = value;
      }
    }

    public byte[] PubApplIdentityData
    {
      get
      {
        return this.pubApplIdentityData;
      }
      set
      {
        this.pubApplIdentityData = value;
      }
    }

    public MQBase.structMQCHARV32 SelectionString
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

    public int SubLevel
    {
      get
      {
        return this.subLevel;
      }
      set
      {
        this.subLevel = value;
      }
    }

    public MQBase.structMQCHARV32 ResObjectString
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
  }
}
