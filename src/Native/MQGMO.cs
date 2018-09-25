using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
  public struct MQGMO
  {
    [MarshalAs(30, SizeConst = 4)]
    private byte[] strucId;

    private int version;

    private int options;

    private int waitInterval;

    private int signal1;

    private int signal2;

    [MarshalAs(30, SizeConst = 48)]
    private byte[] resolvedQName;

    private int matchOptions;

    private byte groupStatus;

    private byte segmentStatus;

    private byte segmentation;

    private byte reserved1;

    [MarshalAs(30, SizeConst = 16)]
    public byte[] msgToken;

    private int returnedLength;

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

    public int WaitInterval
    {
      get
      {
        return this.waitInterval;
      }
      set
      {
        this.waitInterval = value;
      }
    }

    public int Signal1
    {
      get
      {
        return this.signal1;
      }
      set
      {
        this.signal1 = value;
      }
    }

    public int Signal2
    {
      get
      {
        return this.signal2;
      }
      set
      {
        this.signal2 = value;
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

    public int MatchOptions
    {
      get
      {
        return this.matchOptions;
      }
      set
      {
        this.matchOptions = value;
      }
    }

    public byte GroupStatus
    {
      get
      {
        return this.groupStatus;
      }
      set
      {
        this.groupStatus = value;
      }
    }

    public byte SegmentStatus
    {
      get
      {
        return this.segmentStatus;
      }
      set
      {
        this.segmentStatus = value;
      }
    }

    public byte Segmentation
    {
      get
      {
        return this.segmentation;
      }
      set
      {
        this.segmentation = value;
      }
    }

    public byte Reserved1
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

    public byte[] MsgToken
    {
      get
      {
        return this.msgToken;
      }
      set
      {
        this.msgToken = value;
      }
    }

    public int ReturnedLength
    {
      get
      {
        return this.returnedLength;
      }
      set
      {
        this.returnedLength = value;
      }
    }
  }
}
