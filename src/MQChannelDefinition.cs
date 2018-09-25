using Mmqi.Native;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi
{
  public sealed class MQChannelDefinition : MQBase, IDisposable
  {

    private MQCD mqCD = default(MQCD);

    internal byte SEG_SEPARATOR = 1;

    internal byte SEC_SEPARATOR = 2;

    internal byte[] sslPeerName;

    private string[] messageExits = new string[0];

    private string[] messageUserDatas = new string[0];

    private string[] sendExits = new string[0];

    private string[] sendUserDatas = new string[0];

    private string[] receiveExits = new string[0];

    private string[] receiveUserDatas = new string[0];

    public string LongSecurityExit;

    public string LongSendExit;

    public string LongReceiveExit;

    public MQCD StructMQCD
    {
      get
      {
        return this.mqCD;
      }
      set
      {
        this.mqCD = value;
      }
    }

    public int Version
    {
      get
      {
        return this.mqCD.Version;
      }
      set
      {
        this.mqCD.Version = value;
      }
    }

    public string ChannelName
    {
      get
      {
        return base.GetString(this.mqCD.ChannelName).TrimEnd(new char[0]);
      }
      set
      {
        byte[] channelName = this.mqCD.ChannelName;
        base.GetBytes(value, ref channelName);
        this.mqCD.ChannelName = channelName;
      }
    }

    public int ChannelType
    {
      get
      {
        return this.mqCD.ChannelType;
      }
      set
      {
        this.mqCD.ChannelType = value;
      }
    }

    public string ConnectionName
    {
      get
      {
        return base.GetString(this.mqCD.ConnectionName).TrimEnd(new char[0]);
      }
      set
      {
        this.Version = ((this.Version < 2) ? 2 : this.Version);
        byte[] connectionName = this.mqCD.ConnectionName;
        base.GetBytes(value, ref connectionName);
        this.mqCD.ConnectionName = connectionName;
      }
    }

    public int MaxMessageLength
    {
      get
      {
        return this.mqCD.MaxMsgLength;
      }
      set
      {
        this.mqCD.MaxMsgLength = value;
      }
    }

    public string SSLCipherSpec
    {
      get
      {
        return base.GetString(this.mqCD.SSLCipherSpec).TrimEnd(new char[0]);
      }
      set
      {
        this.Version = ((this.Version < 7) ? 7 : this.Version);
        byte[] sSLCipherSpec = this.mqCD.SSLCipherSpec;
        base.GetBytes(value, ref sSLCipherSpec);
        this.mqCD.SSLCipherSpec = sSLCipherSpec;
      }
    }

    public string SSLPeerName
    {
      get
      {
        if (this.sslPeerName != null)
        {
          return base.GetString(this.sslPeerName);
        }
        return string.Empty;
      }
      set
      {
        if (value != null && value.Length > 0)
        {
          this.Version = ((this.Version < 7) ? 7 : this.Version);
          this.sslPeerName = new byte[1024];
          base.GetBytes(value, ref this.sslPeerName);
          this.mqCD.SSLPeerNameLength = value.Length;
          this.mqCD.SSLPeerNamePtr = Marshal.AllocCoTaskMem(1024);
          Marshal.Copy(this.sslPeerName, 0, this.mqCD.SSLPeerNamePtr, 1024);
        }
      }
    }

    public IntPtr SSLPeerNamePtr
    {
      get
      {
        return this.mqCD.SSLPeerNamePtr;
      }
      set
      {
        this.mqCD.SSLPeerNamePtr = value;
      }
    }

    internal int SSLPeerNameLength
    {
      get
      {
        return this.mqCD.SSLPeerNameLength;
      }
      set
      {
        this.mqCD.SSLPeerNameLength = value;
      }
    }

    public string LocalAddress
    {
      get
      {
        return base.GetString(this.mqCD.LocalAddress).TrimEnd(new char[0]);
      }
      set
      {
        this.Version = ((this.Version < 7) ? 7 : this.Version);
        byte[] localAddress = this.mqCD.LocalAddress;
        base.GetBytes(value, ref localAddress);
        this.mqCD.LocalAddress = localAddress;
      }
    }

    public string SecurityExit
    {
      get
      {
        if (this.LongSecurityExit != null)
        {
          return this.LongSecurityExit;
        }
        return base.GetString(this.mqCD.SecurityExit).TrimEnd(new char[0]);
      }
      set
      {
        if (value.Length > 128)
        {
          this.LongSecurityExit = value;
        }
        byte[] securityExit = this.mqCD.SecurityExit;
        base.GetBytes(value, ref securityExit);
        this.mqCD.SecurityExit = securityExit;
      }
    }

    public string SecurityUserData
    {
      get
      {
        return base.GetString(this.mqCD.SecurityUserData).TrimEnd(new char[0]);
      }
      set
      {
        byte[] securityUserData = this.mqCD.SecurityUserData;
        base.GetBytes(value, ref securityUserData);
        this.mqCD.SecurityUserData = securityUserData;
      }
    }

    public string SendExit
    {
      get
      {
        if (this.LongSendExit != null)
        {
          return this.LongSendExit;
        }
        return base.GetString(this.mqCD.SendExit).TrimEnd(new char[0]);
      }
      set
      {
        if (value.Length > 128)
        {
          this.LongSendExit = value;
        }
        if (value != "")
        {
          this.SendExits = new string[]
          {
            value
          };
        }
        byte[] sendExit = this.mqCD.SendExit;
        base.GetBytes(value, ref sendExit);
        this.mqCD.SendExit = sendExit;
      }
    }

    public string[] SendExits
    {
      get
      {
        return this.sendExits;
      }
      set
      {
        this.sendExits = value;
      }
    }

    internal string SendUserData
    {
      get
      {
        return base.GetString(this.mqCD.SendUserData).TrimEnd(new char[0]);
      }
      set
      {
        this.SendUserDatas = new string[]
        {
          value
        };
        byte[] sendUserData = this.mqCD.SendUserData;
        base.GetBytes(value, ref sendUserData);
        this.mqCD.SendUserData = sendUserData;
      }
    }

    public string[] SendUserDatas
    {
      get
      {
        return this.sendUserDatas;
      }
      set
      {
        this.sendUserDatas = value;
      }
    }

    public string ReceiveExit
    {
      get
      {
        if (this.LongReceiveExit != null)
        {
          return this.LongReceiveExit;
        }
        return base.GetString(this.mqCD.ReceiveExit).TrimEnd(new char[0]);
      }
      set
      {
        if (value.Length > 128)
        {
          this.LongReceiveExit = value;
        }
        if (value != "")
        {
          this.ReceiveExits = new string[]
          {
            value
          };
        }
        byte[] receiveExit = this.mqCD.ReceiveExit;
        base.GetBytes(value, ref receiveExit);
        this.mqCD.ReceiveExit = receiveExit;
      }
    }

    public string[] ReceiveExits
    {
      get
      {
        return this.receiveExits;
      }
      set
      {
        this.receiveExits = value;
      }
    }

    internal string ReceiveUserData
    {
      get
      {
        return base.GetString(this.mqCD.ReceiveUserData).TrimEnd(new char[0]);
      }
      set
      {
        this.ReceiveUserDatas = new string[]
        {
          value
        };
        byte[] receiveUserData = this.mqCD.ReceiveUserData;
        base.GetBytes(value, ref receiveUserData);
        this.mqCD.ReceiveUserData = receiveUserData;
      }
    }

    public string[] ReceiveUserDatas
    {
      get
      {
        return this.receiveUserDatas;
      }
      set
      {
        this.receiveUserDatas = value;
      }
    }

    public ArrayList HdrCompList
    {
      get
      {
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < this.mqCD.HdrCompList.Length; i++)
        {
          arrayList.Add(this.mqCD.HdrCompList[i]);
        }
        return arrayList;
      }
      set
      {
        this.Version = ((this.Version < 8) ? 8 : this.Version);
        for (int i = 0; i < 2; i++)
        {
          if (i < value.Count && (int)value[i] == 8)
          {
            this.mqCD.HdrCompList[i] = (int)value[i];
          }
          else
          {
            this.mqCD.HdrCompList[i] = 0;
          }
        }
      }
    }

    public ArrayList MsgCompList
    {
      get
      {
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < this.mqCD.MsgCompList.Length; i++)
        {
          arrayList.Add(this.mqCD.MsgCompList[i]);
        }
        return arrayList;
      }
      set
      {
        this.Version = ((this.Version < 8) ? 8 : this.Version);
        for (int i = 0; i < 16; i++)
        {
          if (i < value.Count && ((int)value[i] == 1 || (int)value[i] == 2 || (int)value[i] == 4))
          {
            this.mqCD.MsgCompList[i] = (int)value[i];
          }
          else
          {
            this.mqCD.MsgCompList[i] = 0;
          }
        }
      }
    }

    public int SharingConversations
    {
      get
      {
        return this.mqCD.SharingConversations;
      }
      set
      {
        this.mqCD.SharingConversations = value;
      }
    }

    public int PropertyControl
    {
      get
      {
        return this.mqCD.PropertyControl;
      }
      set
      {
        this.Version = ((this.Version < 9) ? 9 : this.Version);
        this.mqCD.PropertyControl = value;
      }
    }

    public int MaxInstances
    {
      get
      {
        return this.mqCD.MaxInstances;
      }
      set
      {
        this.Version = ((this.Version < 9) ? 9 : this.Version);
        this.mqCD.MaxInstances = value;
      }
    }

    public int MaxInstancesPerClient
    {
      get
      {
        return this.mqCD.MaxInstancesPerClient;
      }
      set
      {
        this.Version = ((this.Version < 9) ? 9 : this.Version);
        this.mqCD.MaxInstancesPerClient = value;
      }
    }

    public int ClientChannelWeight
    {
      get
      {
        return this.mqCD.ClientChannelWeight;
      }
      set
      {
        this.Version = ((this.Version < 9) ? 9 : this.Version);
        this.mqCD.ClientChannelWeight = value;
      }
    }

    public int ConnectionAffinity
    {
      get
      {
        return this.mqCD.ConnectionAffinity;
      }
      set
      {
        this.Version = ((this.Version < 9) ? 9 : this.Version);
        this.mqCD.ConnectionAffinity = value;
      }
    }

    public int TransportType
    {
      get
      {
        return this.mqCD.TransportType;
      }
      set
      {
        this.mqCD.TransportType = value;
      }
    }

    public byte[] Description
    {
      get
      {
        return this.mqCD.Desc;
      }
      set
      {
        this.mqCD.Desc = value;
      }
    }

    public byte[] QMgrName
    {
      get
      {
        return this.mqCD.QMgrName;
      }
      set
      {
        this.mqCD.QMgrName = value;
      }
    }

    public byte[] XmitQName
    {
      get
      {
        return this.mqCD.XmitQName;
      }
      set
      {
        this.mqCD.XmitQName = value;
      }
    }

    public byte[] MCAName
    {
      get
      {
        return this.mqCD.MCAName;
      }
      set
      {
        this.mqCD.MCAName = value;
      }
    }

    public byte[] ModeName
    {
      get
      {
        return this.mqCD.ModeName;
      }
      set
      {
        this.mqCD.ModeName = value;
      }
    }

    public byte[] TPName
    {
      get
      {
        return this.mqCD.TpName;
      }
      set
      {
        this.mqCD.TpName = value;
      }
    }

    public int BatchSize
    {
      get
      {
        return this.mqCD.BatchSize;
      }
      set
      {
        this.mqCD.BatchSize = value;
      }
    }

    public int DiscInterval
    {
      get
      {
        return this.mqCD.DiscInterval;
      }
      set
      {
        this.mqCD.DiscInterval = value;
      }
    }

    public int ShortRetryCount
    {
      get
      {
        return this.mqCD.ShortRetryCount;
      }
      set
      {
        this.mqCD.ShortRetryCount = value;
      }
    }

    public int ShortRetryInterval
    {
      get
      {
        return this.mqCD.ShortRetryInterval;
      }
      set
      {
        this.mqCD.ShortRetryInterval = value;
      }
    }

    public int LongRetryCount
    {
      get
      {
        return this.mqCD.LongRetryCount;
      }
      set
      {
        this.mqCD.LongRetryCount = value;
      }
    }

    public int LongRetryInterval
    {
      get
      {
        return this.mqCD.LongRetryInterval;
      }
      set
      {
        this.mqCD.LongRetryInterval = value;
      }
    }

    public int SeqNumberWrap
    {
      get
      {
        return this.mqCD.SeqNumberWrap;
      }
      set
      {
        this.mqCD.SeqNumberWrap = value;
      }
    }

    public int PutAuthority
    {
      get
      {
        return this.mqCD.PutAuthority;
      }
      set
      {
        this.mqCD.PutAuthority = value;
      }
    }

    public int DataConversion
    {
      get
      {
        return this.mqCD.DataConversion;
      }
      set
      {
        this.mqCD.DataConversion = value;
      }
    }

    public byte[] UserIdentifier
    {
      get
      {
        return this.mqCD.UserIdentifier;
      }
      set
      {
        this.Version = ((this.Version < 2) ? 2 : this.Version);
        this.mqCD.UserIdentifier = value;
      }
    }

    public byte[] MCAUserIdentifier
    {
      get
      {
        return this.mqCD.MCAUserIdentifier;
      }
      set
      {
        this.Version = ((this.Version < 2) ? 2 : this.Version);
        this.mqCD.MCAUserIdentifier = value;
      }
    }

    public int MCAType
    {
      get
      {
        return this.mqCD.McaType;
      }
      set
      {
        this.Version = ((this.Version < 2) ? 2 : this.Version);
        this.mqCD.McaType = value;
      }
    }

    public byte[] RemoteUserIdentifier
    {
      get
      {
        return this.mqCD.RemoteUserIdentifier;
      }
      set
      {
        this.Version = ((this.Version < 2) ? 2 : this.Version);
        this.mqCD.RemoteUserIdentifier = value;
      }
    }

    public byte[] Password
    {
      get
      {
        return this.mqCD.Password;
      }
      set
      {
        this.Version = ((this.Version < 2) ? 2 : this.Version);
        this.mqCD.Password = value;
      }
    }

    public byte[] RemotePassword
    {
      get
      {
        return this.mqCD.RemotePassword;
      }
      set
      {
        this.Version = ((this.Version < 2) ? 2 : this.Version);
        this.mqCD.RemotePassword = value;
      }
    }

    public byte[] MsgRetryExit
    {
      get
      {
        return this.mqCD.MsgRetryExit;
      }
      set
      {
        this.Version = ((this.Version < 3) ? 3 : this.Version);
        this.mqCD.MsgRetryExit = value;
      }
    }

    public byte[] MsgRetryUserData
    {
      get
      {
        return this.mqCD.MsgRetryUserData;
      }
      set
      {
        this.Version = ((this.Version < 3) ? 3 : this.Version);
        this.mqCD.MsgRetryUserData = value;
      }
    }

    public int MsgRetryCount
    {
      get
      {
        return this.mqCD.MsgRetryCount;
      }
      set
      {
        this.Version = ((this.Version < 3) ? 3 : this.Version);
        this.mqCD.MsgRetryCount = value;
      }
    }

    public int MsgRetryInterval
    {
      get
      {
        return this.mqCD.MsgRetryInterval;
      }
      set
      {
        this.Version = ((this.Version < 3) ? 3 : this.Version);
        this.mqCD.MsgRetryInterval = value;
      }
    }

    public int HeartBeatInterval
    {
      get
      {
        return this.mqCD.HeartBeatInterval;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.HeartBeatInterval = value;
      }
    }

    public int BatchInterval
    {
      get
      {
        return this.mqCD.BatchInterval;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.BatchInterval = value;
      }
    }

    public int NonPersistentMsgSpeed
    {
      get
      {
        return this.mqCD.NonPersistentMsgSpeed;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.NonPersistentMsgSpeed = value;
      }
    }

    public int StrucLength
    {
      get
      {
        return this.mqCD.StrucLength;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.StrucLength = value;
      }
    }

    public int ExitNameLength
    {
      get
      {
        return this.mqCD.ExitNameLength;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.ExitNameLength = value;
      }
    }

    public int ExitDataLength
    {
      get
      {
        return this.mqCD.ExitDataLength;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.ExitDataLength = value;
      }
    }

    public int SendExitsDefined
    {
      get
      {
        return this.mqCD.SendExitsDefined;
      }
      set
      {
        this.mqCD.SendExitsDefined = value;
      }
    }

    public int ReceiveExitsDefined
    {
      get
      {
        return this.mqCD.ReceiveExitsDefined;
      }
      set
      {
        this.mqCD.ReceiveExitsDefined = value;
      }
    }

    public IntPtr SendExitPtr
    {
      get
      {
        return this.mqCD.SendExitPtr;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.SendExitPtr = value;
      }
    }

    public IntPtr SendUserDataPtr
    {
      get
      {
        return this.mqCD.SendUserDataPtr;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.SendUserDataPtr = value;
      }
    }

    public IntPtr ReceiveExitPtr
    {
      get
      {
        return this.mqCD.ReceiveExitPtr;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.ReceiveExitPtr = value;
      }
    }

    public IntPtr ReceiveUserDataPtr
    {
      get
      {
        return this.mqCD.ReceiveUserDataPtr;
      }
      set
      {
        this.Version = ((this.Version < 4) ? 4 : this.Version);
        this.mqCD.ReceiveUserDataPtr = value;
      }
    }

    public IntPtr ClusterPtr
    {
      get
      {
        return this.mqCD.ClusterPtr;
      }
      set
      {
        this.Version = ((this.Version < 5) ? 5 : this.Version);
        this.mqCD.ClusterPtr = value;
      }
    }

    public int ClustersDefined
    {
      get
      {
        return this.mqCD.ClustersDefined;
      }
    }

    public int NetworkPriority
    {
      get
      {
        return this.mqCD.NetworkPriority;
      }
      set
      {
        this.Version = ((this.Version < 5) ? 5 : this.Version);
        this.mqCD.NetworkPriority = value;
      }
    }

    public int LongMCAUserIdLength
    {
      get
      {
        return this.mqCD.LongMCAUserIdLength;
      }
      set
      {
        this.Version = ((this.Version < 6) ? 6 : this.Version);
        this.mqCD.LongMCAUserIdLength = value;
      }
    }

    public IntPtr LongMCAUserIdPtr
    {
      get
      {
        return this.mqCD.LongMCAUserIdPtr;
      }
      set
      {
        this.Version = ((this.Version < 6) ? 6 : this.Version);
        this.mqCD.LongMCAUserIdPtr = value;
      }
    }

    public int LongRemoteUserIdLength
    {
      get
      {
        return this.mqCD.LongRemoteUserIdLength;
      }
      set
      {
        this.Version = ((this.Version < 6) ? 6 : this.Version);
        this.mqCD.LongRemoteUserIdLength = value;
      }
    }

    public IntPtr LongRemoteUserIdPtr
    {
      get
      {
        return this.mqCD.LongRemoteUserIdPtr;
      }
      set
      {
        this.Version = ((this.Version < 6) ? 6 : this.Version);
        this.mqCD.LongRemoteUserIdPtr = value;
      }
    }

    public byte[] MCASecurityID
    {
      get
      {
        return this.mqCD.MCASecurityId;
      }
      set
      {
        this.Version = ((this.Version < 6) ? 6 : this.Version);
        this.mqCD.MCASecurityId = value;
      }
    }

    public byte[] RemoteSecurityID
    {
      get
      {
        return this.mqCD.RemoteSecurityId;
      }
      set
      {
        this.Version = ((this.Version < 6) ? 6 : this.Version);
        this.mqCD.RemoteSecurityId = value;
      }
    }

    public int SSLClientAuth
    {
      get
      {
        return this.mqCD.SSLClientAuth;
      }
      set
      {
        this.Version = ((this.Version < 7) ? 7 : this.Version);
        this.mqCD.SSLClientAuth = value;
      }
    }

    public int KeepAliveInterval
    {
      get
      {
        return this.mqCD.KeepAliveInterval;
      }
      set
      {
        this.Version = ((this.Version < 7) ? 7 : this.Version);
        this.mqCD.KeepAliveInterval = value;
      }
    }

    public int BatchHeartbeat
    {
      get
      {
        return this.mqCD.BatchHeartbeat;
      }
      set
      {
        this.Version = ((this.Version < 7) ? 7 : this.Version);
        this.mqCD.BatchHeartbeat = value;
      }
    }

    public int CLWLChannelRank
    {
      get
      {
        return this.mqCD.CLWLChannelRank;
      }
      set
      {
        this.Version = ((this.Version < 8) ? 8 : this.Version);
        this.mqCD.CLWLChannelRank = value;
      }
    }

    public int CLWLChannelPriority
    {
      get
      {
        return this.mqCD.CLWLChannelPriority;
      }
      set
      {
        this.Version = ((this.Version < 8) ? 8 : this.Version);
        this.mqCD.CLWLChannelPriority = value;
      }
    }

    public int CLWLChannelWeight
    {
      get
      {
        return this.mqCD.CLWLChannelWeight;
      }
      set
      {
        this.Version = ((this.Version < 8) ? 8 : this.Version);
        this.mqCD.CLWLChannelWeight = value;
      }
    }

    public int ChannelMonitoring
    {
      get
      {
        return this.mqCD.ChannelMonitoring;
      }
      set
      {
        this.Version = ((this.Version < 8) ? 8 : this.Version);
        this.mqCD.ChannelMonitoring = value;
      }
    }

    public int ChannelStatistics
    {
      get
      {
        return this.mqCD.ChannelStatistics;
      }
      set
      {
        this.Version = ((this.Version < 8) ? 8 : this.Version);
        this.mqCD.ChannelStatistics = value;
      }
    }

    public int BatchDataLimit
    {
      get
      {
        return this.mqCD.BatchDataLimit;
      }
      set
      {
        this.Version = ((this.Version < 10) ? 10 : this.Version);
        this.mqCD.BatchDataLimit = value;
      }
    }

    public int UseDLQ
    {
      get
      {
        return this.mqCD.UseDLQ;
      }
      set
      {
        this.Version = ((this.Version < 10) ? 10 : this.Version);
        this.mqCD.UseDLQ = value;
      }
    }

    public int DefaultReconnect
    {
      get
      {
        return this.mqCD.DefReconnect;
      }
      set
      {
        this.Version = ((this.Version < 10) ? 10 : this.Version);
        this.mqCD.DefReconnect = value;
      }
    }

    public byte[] CertificateLabel
    {
      get
      {
        return this.mqCD.CertificateLabel;
      }
      set
      {
        this.Version = ((this.Version < 11) ? 11 : this.Version);
        this.mqCD.CertificateLabel = value;
      }
    }

    private void SetDefaultDefinition()
    {
      this.mqCD.ChannelName = new byte[20];
      this.mqCD.Version = 1;
      this.mqCD.ChannelType = 6;
      this.mqCD.TransportType = 2;
      this.mqCD.Desc = new byte[64];
      this.mqCD.QMgrName = new byte[48];
      this.mqCD.XmitQName = new byte[48];
      this.mqCD.MCAName = new byte[20];
      this.mqCD.ModeName = new byte[8];
      this.mqCD.TpName = new byte[64];
      this.mqCD.BatchSize = 50;
      this.mqCD.DiscInterval = 6000;
      this.mqCD.ShortRetryCount = 10;
      this.mqCD.ShortRetryInterval = 60;
      this.mqCD.LongRetryCount = 999999999;
      this.mqCD.LongRetryInterval = 1200;
      this.mqCD.SecurityExit = new byte[128];
      this.mqCD.MsgExit = new byte[128];
      this.mqCD.SendExit = new byte[128];
      this.mqCD.ReceiveExit = new byte[128];
      this.mqCD.SeqNumberWrap = 999999999;
      this.mqCD.MaxMsgLength = 4194304;
      this.mqCD.PutAuthority = 1;
      this.mqCD.DataConversion = 0;
      this.mqCD.SecurityUserData = new byte[32];
      this.mqCD.MsgUserData = new byte[32];
      this.mqCD.SendUserData = new byte[32];
      this.mqCD.ReceiveUserData = new byte[32];
      this.mqCD.UserIdentifier = new byte[12];
      this.mqCD.Password = new byte[12];
      this.mqCD.MCAUserIdentifier = new byte[12];
      this.mqCD.McaType = 1;
      this.mqCD.ConnectionName = new byte[264];
      this.mqCD.RemoteUserIdentifier = new byte[12];
      this.mqCD.RemotePassword = new byte[12];
      this.mqCD.MsgRetryExit = new byte[128];
      this.mqCD.MsgRetryUserData = new byte[32];
      this.mqCD.MsgRetryCount = 10;
      this.mqCD.MsgRetryInterval = 1000;
      this.mqCD.HeartBeatInterval = 300;
      this.mqCD.BatchInterval = 0;
      this.mqCD.NonPersistentMsgSpeed = 2;
      this.mqCD.StrucLength = 1940;
      this.mqCD.ExitNameLength = 128;
      this.mqCD.ExitDataLength = 32;
      this.mqCD.MsgExitsDefined = 0;
      this.mqCD.SendExitsDefined = 0;
      this.mqCD.ReceiveExitsDefined = 0;
      this.mqCD.MsgExitPtr = IntPtr.Zero;
      this.mqCD.MsgUserDataPtr = IntPtr.Zero;
      this.mqCD.SendExitPtr = IntPtr.Zero;
      this.mqCD.SendUserDataPtr = IntPtr.Zero;
      this.mqCD.ReceiveExitPtr = IntPtr.Zero;
      this.mqCD.ReceiveUserDataPtr = IntPtr.Zero;
      this.mqCD.ClusterPtr = IntPtr.Zero;
      this.mqCD.ClustersDefined = 0;
      this.mqCD.NetworkPriority = 0;
      this.mqCD.LongMCAUserIdLength = 0;
      this.mqCD.LongRemoteUserIdLength = 0;
      this.mqCD.LongMCAUserIdPtr = IntPtr.Zero;
      this.mqCD.LongRemoteUserIdPtr = IntPtr.Zero;
      this.mqCD.MCASecurityId = new byte[40];
      this.mqCD.RemoteSecurityId = new byte[40];
      this.mqCD.SSLCipherSpec = new byte[32];
      this.mqCD.SSLPeerNamePtr = IntPtr.Zero;
      this.mqCD.SSLPeerNameLength = 0;
      this.mqCD.SSLClientAuth = 0;
      this.mqCD.KeepAliveInterval = -1;
      this.mqCD.LocalAddress = new byte[48];
      this.mqCD.BatchHeartbeat = 0;
      this.mqCD.HdrCompList = new int[2];
      this.mqCD.MsgCompList = new int[16];
      this.mqCD.CLWLChannelRank = 0;
      this.mqCD.CLWLChannelPriority = 0;
      this.mqCD.CLWLChannelWeight = 50;
      this.mqCD.ChannelMonitoring = 0;
      this.mqCD.ChannelStatistics = 0;
      this.mqCD.SharingConversations = 10;
      this.mqCD.PropertyControl = 0;
      this.mqCD.MaxInstances = 999999999;
      this.mqCD.MaxInstancesPerClient = 999999999;
      this.mqCD.ClientChannelWeight = 0;
      this.mqCD.ConnectionAffinity = 1;
      this.mqCD.BatchDataLimit = 0;
      this.mqCD.UseDLQ = 2;
      this.mqCD.DefReconnect = 0;
      this.mqCD.CertificateLabel = new byte[64];
    }


    public MQChannelDefinition()
    {
      this.SetDefaultDefinition();
    }

    private int FindByte(byte[] b, int offset, int end, byte fbyte)
    {
      int num = -1;
      if (offset >= 0)
      {
        while (offset <= end)
        {
          if (b[offset] == fbyte)
          {
            num = offset;
            break;
          }
          offset++;
        }
      }
      return num;
    }

    public void Dispose()
    {
      try
      {
        if (this.mqCD.SSLPeerNamePtr != IntPtr.Zero)
        {
          Marshal.FreeCoTaskMem(this.mqCD.SSLPeerNamePtr);
        }
        if (this.mqCD.SendExitPtr != IntPtr.Zero)
        {
          Marshal.FreeCoTaskMem(this.mqCD.SendExitPtr);
        }
        if (this.mqCD.SendUserDataPtr != IntPtr.Zero)
        {
          Marshal.FreeCoTaskMem(this.mqCD.SendUserDataPtr);
        }
        if (this.mqCD.ReceiveExitPtr != IntPtr.Zero)
        {
          Marshal.FreeCoTaskMem(this.mqCD.ReceiveExitPtr);
        }
        if (this.mqCD.ReceiveUserDataPtr != IntPtr.Zero)
        {
          Marshal.FreeCoTaskMem(this.mqCD.ReceiveUserDataPtr);
        }
      }
      catch (Exception ex)
      {
        //base.TrText("MQChannelDefinition::Dispose - Error Freeing memory - [Exception thrown] " + ex.get_Message());
      }
    }
  }
}
