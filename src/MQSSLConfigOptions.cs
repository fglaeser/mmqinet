using Mmqi.Native;
using System;
using System.Collections;

namespace Mmqi
{
    public class MQSSLConfigOptions : MQBase
    {
      private MQSCO mqSCO;

      private bool certRevocCheck;

      public MQSCO StructMQSCO
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

      public int Version
      {
        get
        {
          return this.mqSCO.Version;
        }
        set
        {
          this.mqSCO.Version = value;
        }
      }

      public string KeyRepository
      {
        get
        {
          return base.GetString(this.mqSCO.KeyRepository);
        }
        set
        {
          byte[] keyRepository = this.mqSCO.KeyRepository;
          base.GetBytes(value, ref keyRepository);
          this.mqSCO.KeyRepository = keyRepository;
        }
      }

      public string CryptoHardware
      {
        get
        {
          return base.GetString(this.mqSCO.CryptoHardware);
        }
        set
        {
          byte[] cryptoHardware = this.mqSCO.CryptoHardware;
          base.GetBytes(value, ref cryptoHardware);
          this.mqSCO.CryptoHardware = cryptoHardware;
        }
      }

      public int AuthInfoRecCount
      {
        get
        {
          return this.mqSCO.AuthInfoRecCount;
        }
        set
        {
          this.mqSCO.AuthInfoRecCount = value;
        }
      }

      public int AuthInfoRecOffset
      {
        get
        {
          return this.mqSCO.AuthInfoRecOffset;
        }
        set
        {
          this.mqSCO.AuthInfoRecOffset = value;
        }
      }

      public IntPtr AuthInfoRecPtr
      {
        get
        {
          return this.mqSCO.AuthInfoRecPtr;
        }
        set
        {
          this.mqSCO.AuthInfoRecPtr = value;
        }
      }

      public int KeyResetCount
      {
        get
        {
          return this.mqSCO.KeyResetCount;
        }
        set
        {
          this.Version = ((this.Version < 2) ? 2 : this.Version);
          this.mqSCO.KeyResetCount = value;
        }
      }

      public int FipsRequired
      {
        get
        {
          return this.mqSCO.FipsRequired;
        }
        set
        {
          this.Version = ((this.Version < 2) ? 2 : this.Version);
          this.mqSCO.FipsRequired = value;
        }
      }

      public ArrayList EncryptionPolicySuiteB
      {
        get
        {
          ArrayList arrayList = new ArrayList();
          for (int i = 0; i < this.mqSCO.EncryptionPolicySuiteB.Length; i++)
          {
            arrayList.Add(this.mqSCO.EncryptionPolicySuiteB[i]);
          }
          return arrayList;
        }
        set
        {
          this.Version = ((this.Version < 3) ? 3 : this.Version);
          for (int i = 0; i < 4; i++)
          {
            if (i < value.Count)
            {
              this.mqSCO.EncryptionPolicySuiteB[i] = (int)value[i];
            }
            else
            {
              this.mqSCO.EncryptionPolicySuiteB[i] = 0;
            }
          }
        }
      }

      public int CertificateValPolicy
      {
        get
        {
          return this.mqSCO.CertificateValPolicy;
        }
        set
        {
          this.Version = ((this.Version < 4) ? 4 : this.Version);
          this.mqSCO.CertificateValPolicy = value;
        }
      }

      public byte[] CertificateLabel
      {
        get
        {
          return this.mqSCO.CertificateLabel;
        }
        set
        {
          this.mqSCO.CertificateLabel = value;
        }
      }

      public byte[] CerfificateLabel
      {
        get
        {
          return this.mqSCO.CertificateLabel;
        }
        set
        {
          this.mqSCO.CertificateLabel = value;
        }
      }

      internal bool CertRevocationCheck
      {
        get
        {
          return this.certRevocCheck;
        }
        set
        {
          this.certRevocCheck = value;
        }
      }

      public MQSSLConfigOptions()
      {
        this.mqSCO.StrucId = new byte[4];
        this.mqSCO.StrucId[0] = 83;
        this.mqSCO.StrucId[1] = 67;
        this.mqSCO.StrucId[2] = 79;
        this.mqSCO.StrucId[3] = 32;
        this.mqSCO.Version = 1;
        this.mqSCO.KeyRepository = new byte[256];
        this.mqSCO.CryptoHardware = new byte[256];
        this.mqSCO.AuthInfoRecCount = 0;
        this.mqSCO.AuthInfoRecOffset = 0;
        this.mqSCO.AuthInfoRecPtr = IntPtr.Zero;
        this.mqSCO.KeyResetCount = 0;
        this.mqSCO.FipsRequired = 0;
        this.mqSCO.EncryptionPolicySuiteB = new int[4];
        this.mqSCO.CertificateValPolicy = 0;
        this.mqSCO.CertificateLabel = new byte[64];
      }

      public bool Equals(MQSSLConfigOptions obj)
      {
        bool flag = true;
        if (obj == null)
        {
          flag = false;
        }
        else
        {
          flag = (flag && this.StructMQSCO.AuthInfoRecCount == obj.StructMQSCO.AuthInfoRecCount);
          flag = (flag && this.StructMQSCO.AuthInfoRecOffset == obj.StructMQSCO.AuthInfoRecOffset);
          flag = (flag && this.StructMQSCO.AuthInfoRecPtr == obj.StructMQSCO.AuthInfoRecPtr);
          flag = (flag && this.StructMQSCO.CertificateValPolicy == obj.StructMQSCO.CertificateValPolicy);
          flag = (flag && this.StructMQSCO.FipsRequired == obj.StructMQSCO.FipsRequired);
          flag = (flag && this.StructMQSCO.KeyResetCount == obj.StructMQSCO.KeyResetCount);
          flag = (flag && this.StructMQSCO.Version == obj.StructMQSCO.Version);
          flag = (flag && MQSSLConfigOptions.Compare(this.StructMQSCO.CertificateLabel, obj.StructMQSCO.CertificateLabel));
          flag = (flag && MQSSLConfigOptions.Compare(this.StructMQSCO.CryptoHardware, obj.StructMQSCO.CryptoHardware));
          flag = (flag && MQSSLConfigOptions.Compare(this.StructMQSCO.EncryptionPolicySuiteB, obj.StructMQSCO.EncryptionPolicySuiteB));
          flag = (flag && MQSSLConfigOptions.Compare(this.StructMQSCO.KeyRepository, obj.StructMQSCO.KeyRepository));
          flag = (flag && this.CertRevocationCheck == obj.CertRevocationCheck);
        }
        return flag;
      }

      internal static bool Compare(byte[] item1, byte[] item2)
      {
        bool result = true;
        if (item1.Length != item2.Length)
        {
          result = false;
        }
        else
        {
          for (int i = 0; i < item1.Length; i++)
          {
            if (item1[i] != item2[i])
            {
              result = false;
              break;
            }
          }
        }
        return result;
      }

      internal static bool Compare(int[] item1, int[] item2)
      {
        bool result = true;
        if (item1.Length != item2.Length)
        {
          result = false;
        }
        else
        {
          for (int i = 0; i < item1.Length; i++)
          {
            if (item1[i] != item2[i])
            {
              result = false;
              break;
            }
          }
        }
        return result;
      }
    }
  }
