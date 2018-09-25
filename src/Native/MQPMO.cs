using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
  public struct MQPMO
  {
    [MarshalAs(30, SizeConst = 4)]
    private byte[] strucId;

    private int version;

    private int options;

    private int timeout;

    private int context;

    private int knownDestCount;

    private int unknownDestCount;

    private int invalidDestCount;

    [MarshalAs(30, SizeConst = 48)]
    private byte[] resolvedQName;

    [MarshalAs(30, SizeConst = 48)]
    private byte[] resolvedQMgrName;

    private int recsPresent;

    private int putMsgRecFields;

    private int putMsgRecOffset;

    private int responseRecOffset;

    private IntPtr putMsgRecPtr;

    private IntPtr responseRecPtr;

    private long originalMsgHandle;

    private long newMsgHandle;

    private int action;

    private int pubLevel;

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

    public int Timeout
    {
      get
      {
        return this.timeout;
      }
      set
      {
        this.timeout = value;
      }
    }

    public int Context
    {
      get
      {
        return this.context;
      }
      set
      {
        this.context = value;
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

    public int PutMsgRecFields
    {
      get
      {
        return this.putMsgRecFields;
      }
      set
      {
        this.putMsgRecFields = value;
      }
    }

    public int PutMsgRecOffset
    {
      get
      {
        return this.putMsgRecOffset;
      }
      set
      {
        this.putMsgRecOffset = value;
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

    public IntPtr PutMsgRecPtr
    {
      get
      {
        return this.putMsgRecPtr;
      }
      set
      {
        this.putMsgRecPtr = value;
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

    public long OriginalMsgHandle
    {
      get
      {
        return this.originalMsgHandle;
      }
      set
      {
        this.originalMsgHandle = value;
      }
    }

    public long NewMsgHandle
    {
      get
      {
        return this.newMsgHandle;
      }
      set
      {
        this.newMsgHandle = value;
      }
    }

    public int Action
    {
      get
      {
        return this.action;
      }
      set
      {
        this.action = value;
      }
    }

    public int PubLevel
    {
      get
      {
        return this.pubLevel;
      }
      set
      {
        this.pubLevel = value;
      }
    }
  }
}
