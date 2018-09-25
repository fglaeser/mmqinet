using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
  public struct MQSCO
  {
    [MarshalAs(30, SizeConst = 4)]
    private byte[] strucId;

    private int version;

    [MarshalAs(30, SizeConst = 256)]
    private byte[] keyRepository;

    [MarshalAs(30, SizeConst = 256)]
    private byte[] cryptoHardware;

    private int authInfoRecCount;

    private int authInfoRecOffset;

    private IntPtr authInfoRecPtr;

    private int keyResetCount;

    private int fipsRequired;

    [MarshalAs(30, SizeConst = 4)]
    public int[] encryptionPolicySuiteB;

    private int certificateValPolicy;

    [MarshalAs(30, SizeConst = 64)]
    private byte[] certificateLabel;

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

    public byte[] KeyRepository
    {
      get
      {
        return this.keyRepository;
      }
      set
      {
        this.keyRepository = value;
      }
    }

    public byte[] CryptoHardware
    {
      get
      {
        return this.cryptoHardware;
      }
      set
      {
        this.cryptoHardware = value;
      }
    }

    public int AuthInfoRecCount
    {
      get
      {
        return this.authInfoRecCount;
      }
      set
      {
        this.authInfoRecCount = value;
      }
    }

    public int AuthInfoRecOffset
    {
      get
      {
        return this.authInfoRecOffset;
      }
      set
      {
        this.authInfoRecOffset = value;
      }
    }

    public IntPtr AuthInfoRecPtr
    {
      get
      {
        return this.authInfoRecPtr;
      }
      set
      {
        this.authInfoRecPtr = value;
      }
    }

    public int KeyResetCount
    {
      get
      {
        return this.keyResetCount;
      }
      set
      {
        this.keyResetCount = value;
      }
    }

    public int FipsRequired
    {
      get
      {
        return this.fipsRequired;
      }
      set
      {
        this.fipsRequired = value;
      }
    }

    public int[] EncryptionPolicySuiteB
    {
      get
      {
        return this.encryptionPolicySuiteB;
      }
      set
      {
        this.encryptionPolicySuiteB = value;
      }
    }

    public int CertificateValPolicy
    {
      get
      {
        return this.certificateValPolicy;
      }
      set
      {
        this.certificateValPolicy = value;
      }
    }

    public byte[] CertificateLabel
    {
      get
      {
        return this.certificateLabel;
      }
      set
      {
        this.certificateLabel = value;
      }
    }
  }
}
