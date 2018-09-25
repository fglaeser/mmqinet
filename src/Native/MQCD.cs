using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
  public struct MQCD
  {
    [MarshalAs(30, SizeConst = 20)]
    private byte[] channelName;

    private int version;

    private int channelType;

    private int transportType;

    [MarshalAs(30, SizeConst = 64)]
    public byte[] desc;

    [MarshalAs(30, SizeConst = 48)]
    public byte[] qMgrName;

    [MarshalAs(30, SizeConst = 48)]
    public byte[] xmitQName;

    [MarshalAs(30, SizeConst = 20)]
    public byte[] shortConnectionName;

    [MarshalAs(30, SizeConst = 20)]
    private byte[] _MCAName;

    [MarshalAs(30, SizeConst = 8)]
    private byte[] modeName;

    [MarshalAs(30, SizeConst = 64)]
    private byte[] tpName;

    private int batchSize;

    private int discInterval;

    private int shortRetryCount;

    private int shortRetryInterval;

    private int longRetryCount;

    private int longRetryInterval;

    [MarshalAs(30, SizeConst = 128)]
    private byte[] securityExit;

    [MarshalAs(30, SizeConst = 128)]
    private byte[] msgExit;

    [MarshalAs(30, SizeConst = 128)]
    private byte[] sendExit;

    [MarshalAs(30, SizeConst = 128)]
    private byte[] receiveExit;

    private int seqNumberWrap;

    private int maxMsgLength;

    private int putAuthority;

    private int dataConversion;

    [MarshalAs(30, SizeConst = 32)]
    private byte[] securityUserData;

    [MarshalAs(30, SizeConst = 32)]
    private byte[] msgUserData;

    [MarshalAs(30, SizeConst = 32)]
    private byte[] sendUserData;

    [MarshalAs(30, SizeConst = 32)]
    private byte[] receiveUserData;

    [MarshalAs(30, SizeConst = 12)]
    public byte[] userIdentifier;

    [MarshalAs(30, SizeConst = 12)]
    public byte[] password;

    [MarshalAs(30, SizeConst = 12)]
    public byte[] _MCAUserIdentifier;

    private int mcaType;

    [MarshalAs(30, SizeConst = 264)]
    private byte[] connectionName;

    [MarshalAs(30, SizeConst = 12)]
    public byte[] remoteUserIdentifier;

    [MarshalAs(30, SizeConst = 12)]
    public byte[] remotePassword;

    [MarshalAs(30, SizeConst = 128)]
    public byte[] msgRetryExit;

    [MarshalAs(30, SizeConst = 32)]
    public byte[] msgRetryUserData;

    private int msgRetryCount;

    private int msgRetryInterval;

    private int heartBeatInterval;

    private int batchInterval;

    private int nonPersistentMsgSpeed;

    private int strucLength;

    private int exitNameLength;

    private int exitDataLength;

    private int msgExitsDefined;

    private int sendExitsDefined;

    private int receiveExitsDefined;

    private IntPtr msgExitPtr;

    private IntPtr msgUserDataPtr;

    private IntPtr sendExitPtr;

    private IntPtr sendUserDataPtr;

    private IntPtr receiveExitPtr;

    private IntPtr receiveUserDataPtr;

    private IntPtr clusterPtr;

    private int clustersDefined;

    private int networkPriority;

    private int longMCAUserIdLength;

    private int longRemoteUserIdLength;

    private IntPtr longMCAUserIdPtr;

    private IntPtr longRemoteUserIdPtr;

    [MarshalAs(30, SizeConst = 40)]
    public byte[] _MCASecurityId;

    [MarshalAs(30, SizeConst = 40)]
    public byte[] remoteSecurityId;

    [MarshalAs(30, SizeConst = 32)]
    public byte[] _SSLCipherSpec;

    private IntPtr _SSLPeerNamePtr;

    private int _SSLPeerNameLength;

    private int _SSLClientAuth;

    private int keepAliveInterval;

    [MarshalAs(30, SizeConst = 48)]
    private byte[] localAddress;

    private int batchHeartbeat;

    [MarshalAs(30, SizeConst = 2)]
    public int[] hdrCompList;

    [MarshalAs(30, SizeConst = 16)]
    public int[] msgCompList;

    private int _CLWLChannelRank;

    private int _CLWLChannelPriority;

    private int _CLWLChannelWeight;

    private int channelMonitoring;

    private int channelStatistics;

    private int sharingConversations;

    private int propertyControl;

    private int maxInstances;

    private int maxInstancesPerClient;

    private int clientChannelWeight;

    private int connectionAffinity;

    private int batchDataLimit;

    private int useDLQ;

    private int defReconnect;

    [MarshalAs(30, SizeConst = 64)]
    private byte[] certificateLabel;

    public byte[] ChannelName
    {
      get
      {
        return this.channelName;
      }
      set
      {
        this.channelName = value;
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

    public int ChannelType
    {
      get
      {
        return this.channelType;
      }
      set
      {
        this.channelType = value;
      }
    }

    public int TransportType
    {
      get
      {
        return this.transportType;
      }
      set
      {
        this.transportType = value;
      }
    }

    public byte[] Desc
    {
      get
      {
        return this.desc;
      }
      set
      {
        this.desc = value;
      }
    }

    public byte[] QMgrName
    {
      get
      {
        return this.qMgrName;
      }
      set
      {
        this.qMgrName = value;
      }
    }

    public byte[] XmitQName
    {
      get
      {
        return this.xmitQName;
      }
      set
      {
        this.xmitQName = value;
      }
    }

    public byte[] ShortConnectionName
    {
      get
      {
        return this.shortConnectionName;
      }
      set
      {
        this.shortConnectionName = value;
      }
    }

    public byte[] MCAName
    {
      get
      {
        return this._MCAName;
      }
      set
      {
        this._MCAName = value;
      }
    }

    public byte[] ModeName
    {
      get
      {
        return this.modeName;
      }
      set
      {
        this.modeName = value;
      }
    }

    public byte[] TpName
    {
      get
      {
        return this.tpName;
      }
      set
      {
        this.tpName = value;
      }
    }

    public int BatchSize
    {
      get
      {
        return this.batchSize;
      }
      set
      {
        this.batchSize = value;
      }
    }

    public int DiscInterval
    {
      get
      {
        return this.discInterval;
      }
      set
      {
        this.discInterval = value;
      }
    }

    public int ShortRetryCount
    {
      get
      {
        return this.shortRetryCount;
      }
      set
      {
        this.shortRetryCount = value;
      }
    }

    public int ShortRetryInterval
    {
      get
      {
        return this.shortRetryInterval;
      }
      set
      {
        this.shortRetryInterval = value;
      }
    }

    public int LongRetryCount
    {
      get
      {
        return this.longRetryCount;
      }
      set
      {
        this.longRetryCount = value;
      }
    }

    public int LongRetryInterval
    {
      get
      {
        return this.longRetryInterval;
      }
      set
      {
        this.longRetryInterval = value;
      }
    }

    public byte[] SecurityExit
    {
      get
      {
        return this.securityExit;
      }
      set
      {
        this.securityExit = value;
      }
    }

    public byte[] MsgExit
    {
      get
      {
        return this.msgExit;
      }
      set
      {
        this.msgExit = value;
      }
    }

    public byte[] SendExit
    {
      get
      {
        return this.sendExit;
      }
      set
      {
        this.sendExit = value;
      }
    }

    public byte[] ReceiveExit
    {
      get
      {
        return this.receiveExit;
      }
      set
      {
        this.receiveExit = value;
      }
    }

    public int SeqNumberWrap
    {
      get
      {
        return this.seqNumberWrap;
      }
      set
      {
        this.seqNumberWrap = value;
      }
    }

    public int MaxMsgLength
    {
      get
      {
        return this.maxMsgLength;
      }
      set
      {
        this.maxMsgLength = value;
      }
    }

    public int PutAuthority
    {
      get
      {
        return this.putAuthority;
      }
      set
      {
        this.putAuthority = value;
      }
    }

    public int DataConversion
    {
      get
      {
        return this.dataConversion;
      }
      set
      {
        this.dataConversion = value;
      }
    }

    public byte[] SecurityUserData
    {
      get
      {
        return this.securityUserData;
      }
      set
      {
        this.securityUserData = value;
      }
    }

    public byte[] MsgUserData
    {
      get
      {
        return this.msgUserData;
      }
      set
      {
        this.msgUserData = value;
      }
    }

    public byte[] SendUserData
    {
      get
      {
        return this.sendUserData;
      }
      set
      {
        this.sendUserData = value;
      }
    }

    public byte[] ReceiveUserData
    {
      get
      {
        return this.receiveUserData;
      }
      set
      {
        this.receiveUserData = value;
      }
    }

    public byte[] UserIdentifier
    {
      get
      {
        return this.userIdentifier;
      }
      set
      {
        this.userIdentifier = value;
      }
    }

    public byte[] Password
    {
      get
      {
        return this.password;
      }
      set
      {
        this.password = value;
      }
    }

    public byte[] MCAUserIdentifier
    {
      get
      {
        return this._MCAUserIdentifier;
      }
      set
      {
        this._MCAUserIdentifier = value;
      }
    }

    public int McaType
    {
      get
      {
        return this.mcaType;
      }
      set
      {
        this.mcaType = value;
      }
    }

    public byte[] ConnectionName
    {
      get
      {
        return this.connectionName;
      }
      set
      {
        this.connectionName = value;
      }
    }

    public byte[] RemoteUserIdentifier
    {
      get
      {
        return this.remoteUserIdentifier;
      }
      set
      {
        this.remoteUserIdentifier = value;
      }
    }

    public byte[] RemotePassword
    {
      get
      {
        return this.remotePassword;
      }
      set
      {
        this.remotePassword = value;
      }
    }

    public byte[] MsgRetryExit
    {
      get
      {
        return this.msgRetryExit;
      }
      set
      {
        this.msgRetryExit = value;
      }
    }

    public byte[] MsgRetryUserData
    {
      get
      {
        return this.msgRetryUserData;
      }
      set
      {
        this.msgRetryUserData = value;
      }
    }

    public int MsgRetryCount
    {
      get
      {
        return this.msgRetryCount;
      }
      set
      {
        this.msgRetryCount = value;
      }
    }

    public int MsgRetryInterval
    {
      get
      {
        return this.msgRetryInterval;
      }
      set
      {
        this.msgRetryInterval = value;
      }
    }

    public int HeartBeatInterval
    {
      get
      {
        return this.heartBeatInterval;
      }
      set
      {
        this.heartBeatInterval = value;
      }
    }

    public int BatchInterval
    {
      get
      {
        return this.batchInterval;
      }
      set
      {
        this.batchInterval = value;
      }
    }

    public int NonPersistentMsgSpeed
    {
      get
      {
        return this.nonPersistentMsgSpeed;
      }
      set
      {
        this.nonPersistentMsgSpeed = value;
      }
    }

    public int StrucLength
    {
      get
      {
        return this.strucLength;
      }
      set
      {
        this.strucLength = value;
      }
    }

    public int ExitNameLength
    {
      get
      {
        return this.exitNameLength;
      }
      set
      {
        this.exitNameLength = value;
      }
    }

    public int ExitDataLength
    {
      get
      {
        return this.exitDataLength;
      }
      set
      {
        this.exitDataLength = value;
      }
    }

    public int MsgExitsDefined
    {
      get
      {
        return this.msgExitsDefined;
      }
      set
      {
        this.msgExitsDefined = value;
      }
    }

    public int SendExitsDefined
    {
      get
      {
        return this.sendExitsDefined;
      }
      set
      {
        this.sendExitsDefined = value;
      }
    }

    public int ReceiveExitsDefined
    {
      get
      {
        return this.receiveExitsDefined;
      }
      set
      {
        this.receiveExitsDefined = value;
      }
    }

    public IntPtr MsgExitPtr
    {
      get
      {
        return this.msgExitPtr;
      }
      set
      {
        this.msgExitPtr = value;
      }
    }

    public IntPtr MsgUserDataPtr
    {
      get
      {
        return this.msgUserDataPtr;
      }
      set
      {
        this.msgUserDataPtr = value;
      }
    }

    public IntPtr SendExitPtr
    {
      get
      {
        return this.sendExitPtr;
      }
      set
      {
        this.sendExitPtr = value;
      }
    }

    public IntPtr SendUserDataPtr
    {
      get
      {
        return this.sendUserDataPtr;
      }
      set
      {
        this.sendUserDataPtr = value;
      }
    }

    public IntPtr ReceiveExitPtr
    {
      get
      {
        return this.receiveExitPtr;
      }
      set
      {
        this.receiveExitPtr = value;
      }
    }

    public IntPtr ReceiveUserDataPtr
    {
      get
      {
        return this.receiveUserDataPtr;
      }
      set
      {
        this.receiveUserDataPtr = value;
      }
    }

    public IntPtr ClusterPtr
    {
      get
      {
        return this.clusterPtr;
      }
      set
      {
        this.clusterPtr = value;
      }
    }

    public int ClustersDefined
    {
      get
      {
        return this.clustersDefined;
      }
      set
      {
        this.clustersDefined = value;
      }
    }

    public int NetworkPriority
    {
      get
      {
        return this.networkPriority;
      }
      set
      {
        this.networkPriority = value;
      }
    }

    public int LongMCAUserIdLength
    {
      get
      {
        return this.longMCAUserIdLength;
      }
      set
      {
        this.longMCAUserIdLength = value;
      }
    }

    public int LongRemoteUserIdLength
    {
      get
      {
        return this.longRemoteUserIdLength;
      }
      set
      {
        this.longRemoteUserIdLength = value;
      }
    }

    public IntPtr LongMCAUserIdPtr
    {
      get
      {
        return this.longMCAUserIdPtr;
      }
      set
      {
        this.longMCAUserIdPtr = value;
      }
    }

    public IntPtr LongRemoteUserIdPtr
    {
      get
      {
        return this.longRemoteUserIdPtr;
      }
      set
      {
        this.longRemoteUserIdPtr = value;
      }
    }

    public byte[] MCASecurityId
    {
      get
      {
        return this._MCASecurityId;
      }
      set
      {
        this._MCASecurityId = value;
      }
    }

    public byte[] RemoteSecurityId
    {
      get
      {
        return this.remoteSecurityId;
      }
      set
      {
        this.remoteSecurityId = value;
      }
    }

    public byte[] SSLCipherSpec
    {
      get
      {
        return this._SSLCipherSpec;
      }
      set
      {
        this._SSLCipherSpec = value;
      }
    }

    public IntPtr SSLPeerNamePtr
    {
      get
      {
        return this._SSLPeerNamePtr;
      }
      set
      {
        this._SSLPeerNamePtr = value;
      }
    }

    public int SSLPeerNameLength
    {
      get
      {
        return this._SSLPeerNameLength;
      }
      set
      {
        this._SSLPeerNameLength = value;
      }
    }

    public int SSLClientAuth
    {
      get
      {
        return this._SSLClientAuth;
      }
      set
      {
        this._SSLClientAuth = value;
      }
    }

    public int KeepAliveInterval
    {
      get
      {
        return this.keepAliveInterval;
      }
      set
      {
        this.keepAliveInterval = value;
      }
    }

    public byte[] LocalAddress
    {
      get
      {
        return this.localAddress;
      }
      set
      {
        this.localAddress = value;
      }
    }

    public int BatchHeartbeat
    {
      get
      {
        return this.batchHeartbeat;
      }
      set
      {
        this.batchHeartbeat = value;
      }
    }

    public int[] HdrCompList
    {
      get
      {
        return this.hdrCompList;
      }
      set
      {
        this.hdrCompList = value;
      }
    }

    public int[] MsgCompList
    {
      get
      {
        return this.msgCompList;
      }
      set
      {
        this.msgCompList = value;
      }
    }

    public int CLWLChannelRank
    {
      get
      {
        return this._CLWLChannelRank;
      }
      set
      {
        this._CLWLChannelRank = value;
      }
    }

    public int CLWLChannelPriority
    {
      get
      {
        return this._CLWLChannelPriority;
      }
      set
      {
        this._CLWLChannelPriority = value;
      }
    }

    public int CLWLChannelWeight
    {
      get
      {
        return this._CLWLChannelWeight;
      }
      set
      {
        this._CLWLChannelWeight = value;
      }
    }

    public int ChannelMonitoring
    {
      get
      {
        return this.channelMonitoring;
      }
      set
      {
        this.channelMonitoring = value;
      }
    }

    public int ChannelStatistics
    {
      get
      {
        return this.channelStatistics;
      }
      set
      {
        this.channelStatistics = value;
      }
    }

    public int SharingConversations
    {
      get
      {
        return this.sharingConversations;
      }
      set
      {
        this.sharingConversations = value;
      }
    }

    public int PropertyControl
    {
      get
      {
        return this.propertyControl;
      }
      set
      {
        this.propertyControl = value;
      }
    }

    public int MaxInstances
    {
      get
      {
        return this.maxInstances;
      }
      set
      {
        this.maxInstances = value;
      }
    }

    public int MaxInstancesPerClient
    {
      get
      {
        return this.maxInstancesPerClient;
      }
      set
      {
        this.maxInstancesPerClient = value;
      }
    }

    public int ClientChannelWeight
    {
      get
      {
        return this.clientChannelWeight;
      }
      set
      {
        this.clientChannelWeight = value;
      }
    }

    public int ConnectionAffinity
    {
      get
      {
        return this.connectionAffinity;
      }
      set
      {
        this.connectionAffinity = value;
      }
    }

    public int BatchDataLimit
    {
      get
      {
        return this.batchDataLimit;
      }
      set
      {
        this.batchDataLimit = value;
      }
    }

    public int UseDLQ
    {
      get
      {
        return this.useDLQ;
      }
      set
      {
        this.useDLQ = value;
      }
    }

    public int DefReconnect
    {
      get
      {
        return this.defReconnect;
      }
      set
      {
        this.defReconnect = value;
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
