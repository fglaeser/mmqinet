using Mmqi.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
    public class MQConnectOptions : MQBase
    {
      private MQCNO mqCNO;

      private MQConnectionSecurityParameters securityParms;

      internal MQChannelDefinition cd;

      private MQSSLConfigOptions mqSCO;

      public int Options
      {
        get
        {
          return this.mqCNO.Options;
        }
        set
        {
          this.mqCNO.Options = value;
        }
      }

      public int Version
      {
        get
        {
          return this.mqCNO.Version;
        }
        set
        {
          this.mqCNO.Version = value;
        }
      }

      public IntPtr ClientConnPtr
      {
        get
        {
          return this.mqCNO.ClientConnPtr;
        }
        set
        {
          this.Version = ((this.Version < 2) ? 2 : this.Version);
          if (this.mqCNO.ClientConnPtr != IntPtr.Zero)
          {
            Marshal.FreeCoTaskMem(this.mqCNO.ClientConnPtr);
            this.mqCNO.ClientConnPtr = IntPtr.Zero;
          }
          this.mqCNO.ClientConnPtr = value;
        }
      }

      public int ClientConnOffset
      {
        get
        {
          return this.mqCNO.ClientConnOffset;
        }
        set
        {
          this.Version = ((this.Version < 2) ? 2 : this.Version);
          this.mqCNO.ClientConnOffset = value;
        }
      }

      public byte[] ConnTag
      {
        get
        {
          return (byte[])this.mqCNO.ConnTag.Clone();
        }
        set
        {
          this.Version = ((this.Version < 3) ? 3 : this.Version);
          value.CopyTo(this.mqCNO.ConnTag, 0);
        }
      }

      public IntPtr SSLConfigPtr
      {
        get
        {
          return this.mqCNO.SSLConfigPtr;
        }
        set
        {
          this.Version = ((this.Version < 4) ? 4 : this.Version);
          this.mqCNO.SSLConfigPtr = value;
        }
      }

      public MQSSLConfigOptions SslConfigOptions
      {
        get
        {
          return this.mqSCO;
        }
        set
        {
          this.mqSCO = value;
        }
      }

      public int SSLConfigOffset
      {
        get
        {
          return this.mqCNO.SSLConfigOffset;
        }
        set
        {
          this.Version = ((this.Version < 4) ? 4 : this.Version);
          this.mqCNO.SSLConfigOffset = value;
        }
      }

      public IntPtr SecurityParmsPtr
      {
        get
        {
          return this.mqCNO.SecurityParmsPtr;
        }
        set
        {
          this.Version = ((this.Version < 5) ? 5 : this.Version);
          this.mqCNO.SecurityParmsPtr = value;
        }
      }

      public int SecurityParmsOffset
      {
        get
        {
          return this.mqCNO.SecurityParmsOffset;
        }
        set
        {
          this.Version = ((this.Version < 5) ? 5 : this.Version);
          this.mqCNO.SecurityParmsOffset = value;
        }
      }

      public MQConnectionSecurityParameters SecurityParms
      {
        get
        {
          return this.securityParms;
        }
        set
        {
          this.Version = ((this.Version < 5) ? 5 : this.Version);
          this.securityParms = value;
        }
      }

      public byte[] ConnectionId
      {
        get
        {
          return (byte[])this.mqCNO.ConnectionId.Clone();
        }
        set
        {
          this.Version = ((this.Version < 5) ? 5 : this.Version);
          value.CopyTo(this.mqCNO.ConnectionId, 0);
        }
      }

      public MQCNO StructMQCNO
      {
        get
        {
          return this.mqCNO;
        }
        set
        {
          this.mqCNO = value;
        }
      }

      public MQChannelDefinition ClientConn
      {
        get
        {
          return this.cd;
        }
        set
        {
          this.cd = value;
          if (this.cd == null)
          {
            this.ClientConnPtr = IntPtr.Zero;
            return;
          }
          IntPtr intPtr = IntPtr.Zero;
          intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(this.cd.StructMQCD));
          Marshal.StructureToPtr(this.cd.StructMQCD, intPtr, false);
          this.ClientConnPtr = intPtr;
        }
      }

      public MQConnectOptions()
      {
        this.mqCNO.StrucId = new byte[4];
        this.mqCNO.StrucId[0] = 67;
        this.mqCNO.StrucId[1] = 78;
        this.mqCNO.StrucId[2] = 79;
        this.mqCNO.StrucId[3] = 32;
        this.mqCNO.Version = 1;
        this.mqCNO.Options = 0;
        this.mqCNO.ClientConnOffset = 0;
        this.mqCNO.ClientConnPtr = IntPtr.Zero;
        this.mqCNO.ConnTag = new byte[128];
        this.mqCNO.SSLConfigPtr = IntPtr.Zero;
        this.mqCNO.SSLConfigOffset = 0;
        this.mqCNO.SecurityParmsPtr = IntPtr.Zero;
        this.mqCNO.SecurityParmsOffset = 0;
        this.mqCNO.ConnectionId = new byte[24];
      }

      internal void CheckValidity(ref int compCode, ref int reason)
      {
        compCode = 0;
        reason = 0;
        if (compCode == 0)
        {
          int num = this.mqCNO.Options & 769;
          if ((num & num - 1) != 0)
          {
            compCode = 2;
            reason = 2046;
          }
        }
        if (compCode == 0)
        {
          int num = this.mqCNO.Options & 224;
          if ((num & num - 1) != 0)
          {
            compCode = 2;
            reason = 2046;
          }
        }
        if (compCode == 0)
        {
          int num = this.mqCNO.Options & 30;
          if (num != 0 && (this.mqCNO.Version < 3 || (num & num - 1) != 0))
          {
            compCode = 2;
            reason = 2046;
          }
        }
        if (compCode == 0)
        {
          int num = this.mqCNO.Options & 327680;
          if ((num & num - 1) != 0)
          {
            compCode = 2;
            reason = 2046;
          }
        }
        if (compCode == 0 && (this.mqCNO.Options & 524288) != 0 && (this.mqCNO.Options & 1048576) != 0)
        {
          compCode = 2;
          reason = 2046;
        }
        if (compCode == 0 && ((this.mqCNO.Options & 524288) != 0 || (this.mqCNO.Options & 1048576) != 0) && this.mqCNO.ClientConnPtr.Equals(IntPtr.Zero))
        {
          compCode = 2;
          reason = 2277;
        }
      }
    }
  }