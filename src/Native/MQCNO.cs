using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
  public struct MQCNO
  {
    [MarshalAs(30, SizeConst = 4)]
    private byte[] strucId;

    private int version;

    private int options;

    private int clientConnOffset;

    private IntPtr clientConnPtr;

    [MarshalAs(30, SizeConst = 128)]
    public byte[] connTag;

    private IntPtr _SSLConfigPtr;

    private int _SSLConfigOffset;

    [MarshalAs(30, SizeConst = 24)]
    public byte[] connectionId;

    private int securityParmsOffset;

    private IntPtr securityParmsPtr;

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

    public int ClientConnOffset
    {
      get
      {
        return this.clientConnOffset;
      }
      set
      {
        this.clientConnOffset = value;
      }
    }

    public IntPtr ClientConnPtr
    {
      get
      {
        return this.clientConnPtr;
      }
      set
      {
        this.clientConnPtr = value;
      }
    }

    public byte[] ConnTag
    {
      get
      {
        return this.connTag;
      }
      set
      {
        this.connTag = value;
      }
    }

    public IntPtr SSLConfigPtr
    {
      get
      {
        return this._SSLConfigPtr;
      }
      set
      {
        this._SSLConfigPtr = value;
      }
    }

    public int SSLConfigOffset
    {
      get
      {
        return this._SSLConfigOffset;
      }
      set
      {
        this._SSLConfigOffset = value;
      }
    }

    public byte[] ConnectionId
    {
      get
      {
        return this.connectionId;
      }
      set
      {
        this.connectionId = value;
      }
    }

    public int SecurityParmsOffset
    {
      get
      {
        return this.securityParmsOffset;
      }
      set
      {
        this.securityParmsOffset = value;
      }
    }

    public IntPtr SecurityParmsPtr
    {
      get
      {
        return this.securityParmsPtr;
      }
      set
      {
        this.securityParmsPtr = value;
      }
    }
  }
}
