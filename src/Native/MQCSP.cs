using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
  public struct MQCSP
  {
    [MarshalAs(30, SizeConst = 4)]
    private byte[] strucId;

    private int version;

    private int authenticationType;

    [MarshalAs(30, SizeConst = 4)]
    public byte[] reserved1;

    private IntPtr _CSPUserIdPtr;

    private int _CSPUserIdOffset;

    private int _CSPUserIdLength;

    [MarshalAs(30, SizeConst = 8)]
    public byte[] reserved2;

    private IntPtr _CSPPasswordPtr;

    private int _CSPPasswordOffset;

    private int _CSPPasswordLength;

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

    public int AuthenticationType
    {
      get
      {
        return this.authenticationType;
      }
      set
      {
        this.authenticationType = value;
      }
    }

    public byte[] Reserved1
    {
      get
      {
        return this.reserved1;
      }
      set
      {
        this.reserved1 = value;
      }
    }

    public IntPtr CSPUserIdPtr
    {
      get
      {
        return this._CSPUserIdPtr;
      }
      set
      {
        this._CSPUserIdPtr = value;
      }
    }

    public int CSPUserIdOffset
    {
      get
      {
        return this._CSPUserIdOffset;
      }
      set
      {
        this._CSPUserIdOffset = value;
      }
    }

    public int CSPUserIdLength
    {
      get
      {
        return this._CSPUserIdLength;
      }
      set
      {
        this._CSPUserIdLength = value;
      }
    }

    public byte[] Reserved2
    {
      get
      {
        return this.reserved2;
      }
      set
      {
        this.reserved2 = value;
      }
    }

    public IntPtr CSPPasswordPtr
    {
      get
      {
        return this._CSPPasswordPtr;
      }
      set
      {
        this._CSPPasswordPtr = value;
      }
    }

    public int CSPPasswordOffset
    {
      get
      {
        return this._CSPPasswordOffset;
      }
      set
      {
        this._CSPPasswordOffset = value;
      }
    }

    public int CSPPasswordLength
    {
      get
      {
        return this._CSPPasswordLength;
      }
      set
      {
        this._CSPPasswordLength = value;
      }
    }
  }
}
