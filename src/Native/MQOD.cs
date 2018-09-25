using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
  public struct MQOD
  {
    [MarshalAs(30, SizeConst = 4)]
    private byte[] strucId;

    private int version;

    private int objectType;

    [MarshalAs(30, SizeConst = 48)]
    private byte[] objectName;

    [MarshalAs(30, SizeConst = 48)]
    private byte[] objectQMgrName;

    [MarshalAs(30, SizeConst = 48)]
    private byte[] dynamicQName;

    [MarshalAs(30, SizeConst = 12)]
    private byte[] alternateUserId;

    private int recsPresent;

    private int knownDestCount;

    private int unknownDestCount;

    private int invalidDestCount;

    private int objectRecOffset;

    private int responseRecOffset;

    private IntPtr objectRecPtr;

    private IntPtr responseRecPtr;

    [MarshalAs(30, SizeConst = 40)]
    public byte[] alternateSecurityId;

    [MarshalAs(30, SizeConst = 48)]
    public byte[] resolvedQName;

    [MarshalAs(30, SizeConst = 48)]
    public byte[] resolvedQMgrName;

    private MQBase.structMQCHARV objectString;

    private MQBase.structMQCHARV selectionString;

    private MQBase.structMQCHARV resolvedObjectString;

    private int resolvedType;

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

    public int ObjectType
    {
      get
      {
        return this.objectType;
      }
      set
      {
        this.objectType = value;
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

    public byte[] ObjectQMgrName
    {
      get
      {
        return this.objectQMgrName;
      }
      set
      {
        this.objectQMgrName = value;
      }
    }

    public byte[] DynamicQName
    {
      get
      {
        return this.dynamicQName;
      }
      set
      {
        this.dynamicQName = value;
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

    public int RecsPresent
    {
      get
      {
        return this.recsPresent;
      }
      set
      {
        this.recsPresent = value;
      }
    }

    public int KnownDestCount
    {
      get
      {
        return this.knownDestCount;
      }
      set
      {
        this.knownDestCount = value;
      }
    }

    public int UnknownDestCount
    {
      get
      {
        return this.unknownDestCount;
      }
      set
      {
        this.unknownDestCount = value;
      }
    }

    public int InvalidDestCount
    {
      get
      {
        return this.invalidDestCount;
      }
      set
      {
        this.invalidDestCount = value;
      }
    }

    public int ObjectRecOffset
    {
      get
      {
        return this.objectRecOffset;
      }
      set
      {
        this.objectRecOffset = value;
      }
    }

    public int ResponseRecOffset
    {
      get
      {
        return this.responseRecOffset;
      }
      set
      {
        this.responseRecOffset = value;
      }
    }

    public IntPtr ObjectRecPtr
    {
      get
      {
        return this.objectRecPtr;
      }
      set
      {
        this.objectRecPtr = value;
      }
    }

    public IntPtr ResponseRecPtr
    {
      get
      {
        return this.responseRecPtr;
      }
      set
      {
        this.responseRecPtr = value;
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

    public byte[] ResolvedQName
    {
      get
      {
        return this.resolvedQName;
      }
      set
      {
        this.resolvedQName = value;
      }
    }

    public byte[] ResolvedQMgrName
    {
      get
      {
        return this.resolvedQMgrName;
      }
      set
      {
        this.resolvedQMgrName = value;
      }
    }

    public MQBase.structMQCHARV ObjectString
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

    public MQBase.structMQCHARV SelectionString
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

    public MQBase.structMQCHARV ResolvedObjectString
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

    public int ResolvedType
    {
      get
      {
        return this.resolvedType;
      }
      set
      {
        this.resolvedType = value;
      }
    }
  }
}
