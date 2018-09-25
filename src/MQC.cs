using System;
using System.Collections.Generic;
using System.Text;

namespace Mmqi
{
  public struct MQC
  {
    public const string CCSID_PROPERTY = "CCSID";

    public const string CHANNEL_PROPERTY = "channel";

    public const string CONNECT_OPTIONS_PROPERTY = "connectOptions";

    public const string CONNTAG_PROPERTY = "ConnTag Property";

    public const string HOST_NAME_PROPERTY = "hostname";

    public const string ORB_PROPERTY = "ORB";

    public const string PASSWORD_PROPERTY = "password";

    public const string PORT_PROPERTY = "port";

    public const string CHANNEL_RECEIVE_EXIT_PROPERTY = "channelReceiveExit";

    public const string CHANNEL_RECEIVE_EXIT_USER_DATA_PROPERTY = "channelReceiveExitUserData";

    public const string CHANNEL_SECURITY_EXIT_PROPERTY = "channelSecurityExit";

    public const string CHANNEL_SECURITY_EXIT_USER_DATA_PROPERTY = "channelSecurityExitUserData";

    public const string EXIT_CLASSPATH_PROPERTY = "exitClasspath";

    public const string CHANNEL_SEND_EXIT_PROPERTY = "channelSendExit";

    public const string CHANNEL_SEND_EXIT_USER_DATA_PROPERTY = "channelSendExitUserData";

    public const string RECEIVE_EXIT_PROPERTY = "receiveExit";

    public const string RECEIVE_EXIT_USER_DATA_PROPERTY = "receiveExitUserData";

    public const string SECURITY_EXIT_PROPERTY = "securityExit";

    public const string SECURITY_EXIT_USER_DATA_PROPERTY = "securityExitUserData";

    public const string SEND_EXIT_PROPERTY = "sendExit";

    public const string SEND_EXIT_USER_DATA_PROPERTY = "sendExitUserData";

    public const string MSG_EXIT_PROPERTY = "msgExit";

    public const string APPNAME_PROPERTY = "APPNAME";

    public const string TRANSPORT_PROPERTY = "transport";

    public const string TRANSPORT_MQSERIES = "MQSeries";

    public const string TRANSPORT_MQSERIES_CLIENT = "MQSeries Client";

    public const string TRANSPORT_MQSERIES_BINDINGS = "MQSeries Bindings";

    public const string TRANSPORT_MQJD = "MQJD";

    public const string USER_ID_PROPERTY = "userID";

    public const string THREAD_ACCESS = "Thread access";

    public const string MULTI_THREAD = "MULTI_THREAD";

    public const string SINGLE_THREAD = "SINGLE_THREAD";

    public const string THREAD_AFFINITY_PROPERTY = "Thread affinity";

    public const string THREAD_AFFINITY = "Thread affinity";

    public const string GROUP_PROPERTY = "Group";

    public const string XA_REQ_PROPERTY = "XAReq";

    public const string USE_QM_CCSID_PROPERTY = "Use QM CCSID";

    public const string USE_MQCSP_AUTHENTICATION_PROPERTY = "Use MQCSP authentication";

    public const string SSL_RESET_COUNT_PROPERTY = "KeyResetCount";

    public const string SSL_FIPS_REQUIRED_PROPERTY = "SSL Fips Required";

    public const string SPI_PROPERTY = "SPI";

    public const string SPI_ENABLE = "SPI_ENABLE";

    public const string SPI_DISABLE = "SPI_DISABLE";

    public const string BATCHING_ENABLED_PROPERTY = "Batching enabled";

    public const string BATCH_SIZE_FLOOR_PROPERTY = "Batch size floor";

    public const string BATCH_SIZE_CEILING_PROPERTY = "Batch size ceiling";

    public const string BATCHING_THRESHOLD_PROPERTY = "Batching threshold";

    public const string BATCH_INTERVAL_PROPERTY = "Batch interval";

    public const string SSL_CIPHER_SUITE_PROPERTY = "SSL Cipher Suite";

    public const string SSL_PEER_NAME_PROPERTY = "SSL Peer Name";

    public const string SSL_CERT_STORE_PROPERTY = "SSL CertStores";

    public const string SSL_CRYPTO_HARDWARE_PROPERTY = "SSL CryptoHardware";

    public const string SSL_SOCKET_FACTORY_PROPERTY = "SSL Socket Factory";

    public const string MQAIR_ARRAY = "mqairArray";

    public const string KEY_RESET_COUNT = "keyResetCount";

    public const string FIPS_REQUIRED = "fipsRequired";

    public const string ENCRYPTION_POLICY_SUITE_B = "encryptionPolicySuiteB";

    public const string CERTIFICATE_VALIDATION_POLICY = "certificateValPolicy";

    public const string HDR_CMP_LIST = "hdrCmpList";

    public const string MSG_CMP_LIST = "msgCmpList";

    public const string LOCAL_ADDRESS_PROPERTY = "Local Address Property";

    public const string LOCAL_ADDRESS_MARKER = "LastUsed Port Marker";

    public const string BINDINGS_AUTHENTICATE = "Bindings Authentication";

    public const string MQSUB_PROP_ALTERNATE_SECURITY_ID = "AlternateSecurityId";

    public const string MQSUB_PROP_SUBSCRIPTION_EXPIRY = "SubscriptionExpiry";

    public const string MQSUB_PROP_SUBSCRIPTION_USER_DATA = "SubscriptionUserData";

    public const string MQSUB_PROP_SUBSCRIPTION_CORRELATION_ID = "SubscriptionCorrelationId";

    public const string MQSUB_PROP_PUBLICATION_PRIORITY = "PublicationPriority";

    public const string MQSUB_PROP_PUBLICATION_ACCOUNTING_TOKEN = "PublicationAccountingToken";

    public const string MQSUB_PROP_PUBLICATION_APPLICATIONID_DATA = "PublicationApplicationIdData";

    public const string WMQ_MQMD_MESSAGE_CONTEXT = "mdMessageContext";

    public const int WMQ_MDCTX_DEFAULT = 0;

    public const int WMQ_MDCTX_SET_IDENTITY_CONTEXT = 1;

    public const int WMQ_MDCTX_SET_ALL_CONTEXT = 2;

    public const string WMQ_MQMD_WRITE_ENABLED = "mdWriteEnabled";

    public const string WMQ_MQMD_READ_ENABLED = "mdReadEnabled";

    public const string WMQ_MESSAGE_BODY = "messageBody";

    public const int WMQ_MESSAGE_BODY_JMS = 0;

    public const int WMQ_MESSAGE_BODY_MQ = 1;

    public const int WMQ_MESSAGE_BODY_UNSPECIFIED = 2;

    public const int MQTOPIC_OPEN_AS_SUBSCRIPTION = 1;

    public const int MQTOPIC_OPEN_AS_PUBLICATION = 2;

    public const string CONNECTION_NAME_PROPERTY = "connectionName";

    public const string SSL_CIPHER_SPEC_PROPERTY = "SSL Cipher Spec";

    public const string SECURITY_USERDATA_PROPERTY = "securityUserData";

    public const string SEND_USERDATA_PROPERTY = "sendUserData";

    public const string SHARING_CONVERSATIONS_PROPERTY = "sharingConversations";

    public const string RECEIVE_USERDATA_PROPERTY = "receiveUserData";

    public const string TRANSPORT_MQSERIES_XACLIENT = "MQSeries XA Client";

    public const string TRANSPORT_MQSERIES_MANAGED = "MQSeries Managed Client";

    public const string MQAIR_STRUC_ID = "AIR ";

    public const int MQAIR_VERSION_1 = 1;

    public const int MQAIR_VERSION_2 = 2;

    public const int MQAIR_CURRENT_VERSION = 2;

    public const int MQAIR_LENGTH_1 = 320;

    public const int MQAIR_LENGTH_2 = 576;

    public const int MQAIR_CURRENT_LENGTH = 576;

    public const int MQAIT_ALL = 0;

    public const int MQAIT_CRL_LDAP = 1;

    public const int MQAIT_OCSP = 2;

    public const int MQAIT_IDPW_OS = 3;

    public const int MQAIT_IDPW_LDAP = 4;

    public const string MQBMHO_STRUC_ID = "BMHO";

    public const int MQBMHO_VERSION_1 = 1;

    public const int MQBMHO_CURRENT_VERSION = 1;

    public const int MQBMHO_LENGTH_1 = 12;

    public const int MQBMHO_CURRENT_LENGTH = 12;

    public const int MQBMHO_NONE = 0;

    public const int MQBMHO_DELETE_PROPERTIES = 1;

    public const string MQBO_STRUC_ID = "BO  ";

    public const int MQBO_VERSION_1 = 1;

    public const int MQBO_CURRENT_VERSION = 1;

    public const int MQBO_LENGTH_1 = 12;

    public const int MQBO_CURRENT_LENGTH = 12;

    public const int MQBO_NONE = 0;

    public const string MQCBC_STRUC_ID = "CBC ";

    public const int MQCBC_VERSION_1 = 1;

    public const int MQCBC_VERSION_2 = 2;

    public const int MQCBC_CURRENT_VERSION = 2;

    public const int MQCBC_LENGTH_1 = 48;

    public const int MQCBC_LENGTH_2 = 52;

    public const int MQCBC_CURRENT_LENGTH = 52;

    public const int MQCBCF_NONE = 0;

    public const int MQCBCF_READA_BUFFER_EMPTY = 1;

    public const int MQCBCT_START_CALL = 1;

    public const int MQCBCT_STOP_CALL = 2;

    public const int MQCBCT_REGISTER_CALL = 3;

    public const int MQCBCT_DEREGISTER_CALL = 4;

    public const int MQCBCT_EVENT_CALL = 5;

    public const int MQCBCT_MSG_REMOVED = 6;

    public const int MQCBCT_MSG_NOT_REMOVED = 7;

    public const int MQCBCT_MC_EVENT_CALL = 8;

    public const int MQCS_NONE = 0;

    public const int MQCS_SUSPENDED_TEMPORARY = 1;

    public const int MQCS_SUSPENDED_USER_ACTION = 2;

    public const int MQCS_SUSPENDED = 3;

    public const int MQCS_STOPPED = 4;

    public const int MQRD_NO_RECONNECT = -1;

    public const int MQRD_NO_DELAY = 0;

    public const string MQCBD_STRUC_ID = "CBD ";

    public const int MQCBD_VERSION_1 = 1;

    public const int MQCBD_CURRENT_VERSION = 1;

    public const int MQCBD_LENGTH_1 = 156;

    public const int MQCBD_CURRENT_LENGTH = 156;

    public const int MQCBDO_NONE = 0;

    public const int MQCBDO_START_CALL = 1;

    public const int MQCBDO_STOP_CALL = 4;

    public const int MQCBDO_REGISTER_CALL = 256;

    public const int MQCBDO_DEREGISTER_CALL = 512;

    public const int MQCBDO_FAIL_IF_QUIESCING = 8192;

    public const int MQCBDO_EVENT_CALL = 16384;

    public const int MQCBDO_MC_EVENT_CALL = 32768;

    public const int MQCBT_MESSAGE_CONSUMER = 1;

    public const int MQCBT_EVENT_HANDLER = 2;

    public const int MQCBD_FULL_MSG_LENGTH = -1;

    public const int MQVS_NULL_TERMINATED = -1;

    public const string MQCIH_STRUC_ID = "CIH ";

    public const int MQCIH_VERSION_1 = 1;

    public const int MQCIH_VERSION_2 = 2;

    public const int MQCIH_CURRENT_VERSION = 2;

    public const int MQCIH_LENGTH_1 = 164;

    public const int MQCIH_LENGTH_2 = 180;

    public const int MQCIH_CURRENT_LENGTH = 180;

    public const int MQCIH_NONE = 0;

    public const int MQCIH_PASS_EXPIRATION = 1;

    public const int MQCIH_UNLIMITED_EXPIRATION = 0;

    public const int MQCIH_REPLY_WITHOUT_NULLS = 2;

    public const int MQCIH_REPLY_WITH_NULLS = 0;

    public const int MQCIH_SYNC_ON_RETURN = 4;

    public const int MQCIH_NO_SYNC_ON_RETURN = 0;

    public const int MQCRC_OK = 0;

    public const int MQCRC_CICS_EXEC_ERROR = 1;

    public const int MQCRC_MQ_API_ERROR = 2;

    public const int MQCRC_BRIDGE_ERROR = 3;

    public const int MQCRC_BRIDGE_ABEND = 4;

    public const int MQCRC_APPLICATION_ABEND = 5;

    public const int MQCRC_SECURITY_ERROR = 6;

    public const int MQCRC_PROGRAM_NOT_AVAILABLE = 7;

    public const int MQCRC_BRIDGE_TIMEOUT = 8;

    public const int MQCRC_TRANSID_NOT_AVAILABLE = 9;

    public const int MQCUOWC_ONLY = 273;

    public const int MQCUOWC_CONTINUE = 65536;

    public const int MQCUOWC_FIRST = 17;

    public const int MQCUOWC_MIDDLE = 16;

    public const int MQCUOWC_LAST = 272;

    public const int MQCUOWC_COMMIT = 256;

    public const int MQCUOWC_BACKOUT = 4352;

    public const int MQCGWI_DEFAULT = -2;

    public const int MQCLT_PROGRAM = 1;

    public const int MQCLT_TRANSACTION = 2;

    public const int MQCODL_AS_INPUT = -1;

    public const int MQCADSD_NONE = 0;

    public const int MQCADSD_SEND = 1;

    public const int MQCADSD_RECV = 16;

    public const int MQCADSD_MSGFORMAT = 256;

    public const int MQCCT_YES = 1;

    public const int MQCCT_NO = 0;

    public const int MQCTES_NOSYNC = 0;

    public const int MQCTES_COMMIT = 256;

    public const int MQCTES_BACKOUT = 4352;

    public const int MQCTES_ENDTASK = 65536;

    public const string MQCFUNC_MQCONN = "CONN";

    public const string MQCFUNC_MQGET = "GET ";

    public const string MQCFUNC_MQINQ = "INQ ";

    public const string MQCFUNC_MQOPEN = "OPEN";

    public const string MQCFUNC_MQPUT = "PUT ";

    public const string MQCFUNC_MQPUT1 = "PUT1";

    public const string MQCFUNC_NONE = "    ";

    public const string MQCSC_START = "S   ";

    public const string MQCSC_STARTDATA = "SD  ";

    public const string MQCSC_TERMINPUT = "TD  ";

    public const string MQCSC_NONE = "    ";

    public const string MQCMHO_STRUC_ID = "CMHO";

    public const int MQCMHO_VERSION_1 = 1;

    public const int MQCMHO_CURRENT_VERSION = 1;

    public const int MQCMHO_LENGTH_1 = 12;

    public const int MQCMHO_CURRENT_LENGTH = 12;

    public const int MQCMHO_DEFAULT_VALIDATION = 0;

    public const int MQCMHO_NO_VALIDATION = 1;

    public const int MQCMHO_VALIDATE = 2;

    public const int MQCMHO_NONE = 0;

    public const string MQCTLO_STRUC_ID = "CTLO";

    public const int MQCTLO_VERSION_1 = 1;

    public const int MQCTLO_CURRENT_VERSION = 1;

    public const int MQCTLO_LENGTH_1 = 20;

    public const int MQCTLO_CURRENT_LENGTH = 20;

    public const int MQCTLO_NONE = 0;

    public const int MQCTLO_THREAD_AFFINITY = 1;

    public const int MQCTLO_FAIL_IF_QUIESCING = 8192;

    public const string MQSCO_STRUC_ID = "SCO ";

    public const int MQSCO_VERSION_1 = 1;

    public const int MQSCO_VERSION_2 = 2;

    public const int MQSCO_VERSION_3 = 3;

    public const int MQSCO_VERSION_4 = 4;

    public const int MQSCO_VERSION_5 = 5;

    public const int MQSCO_CURRENT_VERSION = 5;

    public const int MQSCO_LENGTH_1 = 532;

    public const int MQSCO_LENGTH_2 = 540;

    public const int MQSCO_LENGTH_3 = 556;

    public const int MQSCO_LENGTH_4 = 560;

    public const int MQSCO_LENGTH_5 = 624;

    public const int MQSCO_CURRENT_LENGTH = 624;

    public const int MQ_SUITE_B_NOT_AVAILABLE = 0;

    public const int MQ_SUITE_B_NONE = 1;

    public const int MQ_SUITE_B_128_BIT = 2;

    public const int MQ_SUITE_B_192_BIT = 4;

    public const int MQSCO_RESET_COUNT_DEFAULT = 0;

    public const int MQ_CERT_VAL_POLICY_DEFAULT = 0;

    public const int MQ_CERT_VAL_POLICY_ANY = 0;

    public const int MQ_CERT_VAL_POLICY_RFC5280 = 1;

    public const string MQCSP_STRUC_ID = "CSP ";

    public const int MQCSP_VERSION_1 = 1;

    public const int MQCSP_CURRENT_VERSION = 1;

    public const int MQCSP_LENGTH_1 = 48;

    public const int MQCSP_CURRENT_LENGTH = 48;

    public const int MQCSP_AUTH_NONE = 0;

    public const int MQCSP_AUTH_USER_ID_AND_PWD = 1;

    public const string MQCNO_STRUC_ID = "CNO ";

    public const int MQCNO_VERSION_1 = 1;

    public const int MQCNO_VERSION_2 = 2;

    public const int MQCNO_VERSION_3 = 3;

    public const int MQCNO_VERSION_4 = 4;

    public const int MQCNO_VERSION_5 = 5;

    public const int MQCNO_CURRENT_VERSION = 5;

    public const int MQCNO_LENGTH_1 = 12;

    public const int MQCNO_LENGTH_2 = 20;

    public const int MQCNO_LENGTH_3 = 148;

    public const int MQCNO_LENGTH_4 = 156;

    public const int MQCNO_LENGTH_5 = 188;

    public const int MQCNO_CURRENT_LENGTH = 188;

    public const int MQCNO_STANDARD_BINDING = 0;

    public const int MQCNO_FASTPATH_BINDING = 1;

    public const int MQCNO_SERIALIZE_CONN_TAG_Q_MGR = 2;

    public const int MQCNO_SERIALIZE_CONN_TAG_QSG = 4;

    public const int MQCNO_RESTRICT_CONN_TAG_Q_MGR = 8;

    public const int MQCNO_RESTRICT_CONN_TAG_QSG = 16;

    public const int MQCNO_HANDLE_SHARE_NONE = 32;

    public const int MQCNO_HANDLE_SHARE_BLOCK = 64;

    public const int MQCNO_HANDLE_SHARE_NO_BLOCK = 128;

    public const int MQCNO_SHARED_BINDING = 256;

    public const int MQCNO_ISOLATED_BINDING = 512;

    public const int MQCNO_ACCOUNTING_MQI_ENABLED = 4096;

    public const int MQCNO_ACCOUNTING_MQI_DISABLED = 8192;

    public const int MQCNO_ACCOUNTING_Q_ENABLED = 16384;

    public const int MQCNO_ACCOUNTING_Q_DISABLED = 32768;

    public const int MQCNO_NO_CONV_SHARING = 65536;

    public const int MQCNO_ALL_CONVS_SHARE = 262144;

    public const int MQCNO_CD_FOR_OUTPUT_ONLY = 524288;

    public const int MQCNO_USE_CD_SELECTION = 1048576;

    public const int MQCNO_RECONNECT_AS_DEF = 0;

    public const int MQCNO_RECONNECT = 16777216;

    public const int MQCNO_RECONNECT_DISABLED = 33554432;

    public const int MQCNO_RECONNECT_Q_MGR = 67108864;

    public const int MQCNO_ACTIVITY_TRACE_ENABLED = 134217728;

    public const int MQCNO_ACTIVITY_TRACE_DISABLED = 268435456;

    public const int MQCNO_NONE = 0;

    public const string MQDH_STRUC_ID = "DH  ";

    public const int MQDH_VERSION_1 = 1;

    public const int MQDH_CURRENT_VERSION = 1;

    public const int MQDH_LENGTH_1 = 48;

    public const int MQDH_CURRENT_LENGTH = 48;

    public const int MQDHF_NEW_MSG_IDS = 1;

    public const int MQDHF_NONE = 0;

    public const string MQDLH_STRUC_ID = "DLH ";

    public const int MQDLH_VERSION_1 = 1;

    public const int MQDLH_CURRENT_VERSION = 1;

    public const int MQDLH_LENGTH_1 = 172;

    public const int MQDLH_CURRENT_LENGTH = 172;

    public const string MQDMHO_STRUC_ID = "DMHO";

    public const int MQDMHO_VERSION_1 = 1;

    public const int MQDMHO_CURRENT_VERSION = 1;

    public const int MQDMHO_LENGTH_1 = 12;

    public const int MQDMHO_CURRENT_LENGTH = 12;

    public const int MQDMHO_NONE = 0;

    public const string MQDMPO_STRUC_ID = "DMPO";

    public const int MQDMPO_VERSION_1 = 1;

    public const int MQDMPO_CURRENT_VERSION = 1;

    public const int MQDMPO_LENGTH_1 = 12;

    public const int MQDMPO_CURRENT_LENGTH = 12;

    public const int MQDMPO_DEL_FIRST = 0;

    public const int MQDMPO_DEL_PROP_UNDER_CURSOR = 1;

    public const int MQDMPO_NONE = 0;

    public const string MQGMO_STRUC_ID = "GMO ";

    public const int MQGMO_VERSION_1 = 1;

    public const int MQGMO_VERSION_2 = 2;

    public const int MQGMO_VERSION_3 = 3;

    public const int MQGMO_VERSION_4 = 4;

    public const int MQGMO_CURRENT_VERSION = 4;

    public const int MQGMO_LENGTH_1 = 72;

    public const int MQGMO_LENGTH_2 = 80;

    public const int MQGMO_LENGTH_3 = 100;

    public const int MQGMO_LENGTH_4 = 112;

    public const int MQGMO_CURRENT_LENGTH = 112;

    public const int MQGMO_WAIT = 1;

    public const int MQGMO_NO_WAIT = 0;

    public const int MQGMO_SET_SIGNAL = 8;

    public const int MQGMO_FAIL_IF_QUIESCING = 8192;

    public const int MQGMO_SYNCPOINT = 2;

    public const int MQGMO_SYNCPOINT_IF_PERSISTENT = 4096;

    public const int MQGMO_NO_SYNCPOINT = 4;

    public const int MQGMO_MARK_SKIP_BACKOUT = 128;

    public const int MQGMO_BROWSE_FIRST = 16;

    public const int MQGMO_BROWSE_NEXT = 32;

    public const int MQGMO_BROWSE_MSG_UNDER_CURSOR = 2048;

    public const int MQGMO_MSG_UNDER_CURSOR = 256;

    public const int MQGMO_LOCK = 512;

    public const int MQGMO_UNLOCK = 1024;

    public const int MQGMO_ACCEPT_TRUNCATED_MSG = 64;

    public const int MQGMO_CONVERT = 16384;

    public const int MQGMO_LOGICAL_ORDER = 32768;

    public const int MQGMO_COMPLETE_MSG = 65536;

    public const int MQGMO_ALL_MSGS_AVAILABLE = 131072;

    public const int MQGMO_ALL_SEGMENTS_AVAILABLE = 262144;

    public const int MQGMO_MARK_BROWSE_HANDLE = 1048576;

    public const int MQGMO_MARK_BROWSE_CO_OP = 2097152;

    public const int MQGMO_UNMARK_BROWSE_CO_OP = 4194304;

    public const int MQGMO_UNMARK_BROWSE_HANDLE = 8388608;

    public const int MQGMO_UNMARKED_BROWSE_MSG = 16777216;

    public const int MQGMO_PROPERTIES_FORCE_MQRFH2 = 33554432;

    public const int MQGMO_NO_PROPERTIES = 67108864;

    public const int MQGMO_PROPERTIES_IN_HANDLE = 134217728;

    public const int MQGMO_PROPERTIES_COMPATIBILITY = 268435456;

    public const int MQGMO_PROPERTIES_AS_Q_DEF = 0;

    public const int MQGMO_NONE = 0;

    public const int MQGMO_BROWSE_HANDLE = 17825808;

    public const int MQGMO_BROWSE_CO_OP = 18874384;

    public const int MQWI_UNLIMITED = -1;

    public const int MQEC_MSG_ARRIVED = 2;

    public const int MQEC_WAIT_INTERVAL_EXPIRED = 3;

    public const int MQEC_WAIT_CANCELED = 4;

    public const int MQEC_Q_MGR_QUIESCING = 5;

    public const int MQEC_CONNECTION_QUIESCING = 6;

    public const int MQMO_MATCH_MSG_ID = 1;

    public const int MQMO_MATCH_CORREL_ID = 2;

    public const int MQMO_MATCH_GROUP_ID = 4;

    public const int MQMO_MATCH_MSG_SEQ_NUMBER = 8;

    public const int MQMO_MATCH_OFFSET = 16;

    public const int MQMO_MATCH_MSG_TOKEN = 32;

    public const int MQMO_NONE = 0;

    public const byte MQGS_NOT_IN_GROUP = 32;

    public const byte MQGS_MSG_IN_GROUP = 71;

    public const byte MQGS_LAST_MSG_IN_GROUP = 76;

    public const byte MQSS_NOT_A_SEGMENT = 32;

    public const byte MQSS_SEGMENT = 83;

    public const byte MQSS_LAST_SEGMENT = 76;

    public const byte MQSEG_INHIBITED = 32;

    public const byte MQSEG_ALLOWED = 65;

    public const int MQRL_UNDEFINED = -1;

    public const string MQIIH_STRUC_ID = "IIH ";

    public const int MQIIH_VERSION_1 = 1;

    public const int MQIIH_CURRENT_VERSION = 1;

    public const int MQIIH_LENGTH_1 = 84;

    public const int MQIIH_CURRENT_LENGTH = 84;

    public const int MQIIH_NONE = 0;

    public const int MQIIH_PASS_EXPIRATION = 1;

    public const int MQIIH_UNLIMITED_EXPIRATION = 0;

    public const int MQIIH_REPLY_FORMAT_NONE = 8;

    public const int MQIIH_IGNORE_PURG = 16;

    public const int MQIIH_CM0_REQUEST_RESPONSE = 32;

    public const string MQIAUT_NONE = "        ";

    public const byte MQITS_IN_CONVERSATION = 67;

    public const byte MQITS_NOT_IN_CONVERSATION = 32;

    public const byte MQITS_ARCHITECTED = 65;

    public const byte MQICM_COMMIT_THEN_SEND = 48;

    public const byte MQICM_SEND_THEN_COMMIT = 49;

    public const byte MQISS_CHECK = 67;

    public const byte MQISS_FULL = 70;

    public const string MQIMPO_STRUC_ID = "IMPO";

    public const int MQIMPO_VERSION_1 = 1;

    public const int MQIMPO_CURRENT_VERSION = 1;

    public const int MQIMPO_LENGTH_1 = 60;

    public const int MQIMPO_CURRENT_LENGTH = 60;

    public const int MQIMPO_CONVERT_TYPE = 2;

    public const int MQIMPO_QUERY_LENGTH = 4;

    public const int MQIMPO_INQ_FIRST = 0;

    public const int MQIMPO_INQ_NEXT = 8;

    public const int MQIMPO_INQ_PROP_UNDER_CURSOR = 16;

    public const int MQIMPO_CONVERT_VALUE = 32;

    public const int MQIMPO_NONE = 0;

    public const string MQMD_STRUC_ID = "MD  ";

    public const int MQMD_VERSION_1 = 1;

    public const int MQMD_VERSION_2 = 2;

    public const int MQMD_CURRENT_VERSION = 2;

    public const int MQMD_LENGTH_1 = 324;

    public const int MQMD_LENGTH_2 = 364;

    public const int MQMD_CURRENT_LENGTH = 364;

    public const int MQRO_EXCEPTION = 16777216;

    public const int MQRO_EXCEPTION_WITH_DATA = 50331648;

    public const int MQRO_EXCEPTION_WITH_FULL_DATA = 117440512;

    public const int MQRO_EXPIRATION = 2097152;

    public const int MQRO_EXPIRATION_WITH_DATA = 6291456;

    public const int MQRO_EXPIRATION_WITH_FULL_DATA = 14680064;

    public const int MQRO_COA = 256;

    public const int MQRO_COA_WITH_DATA = 768;

    public const int MQRO_COA_WITH_FULL_DATA = 1792;

    public const int MQRO_COD = 2048;

    public const int MQRO_COD_WITH_DATA = 6144;

    public const int MQRO_COD_WITH_FULL_DATA = 14336;

    public const int MQRO_PAN = 1;

    public const int MQRO_NAN = 2;

    public const int MQRO_ACTIVITY = 4;

    public const int MQRO_NEW_MSG_ID = 0;

    public const int MQRO_PASS_MSG_ID = 128;

    public const int MQRO_COPY_MSG_ID_TO_CORREL_ID = 0;

    public const int MQRO_PASS_CORREL_ID = 64;

    public const int MQRO_DEAD_LETTER_Q = 0;

    public const int MQRO_DISCARD_MSG = 134217728;

    public const int MQRO_PASS_DISCARD_AND_EXPIRY = 16384;

    public const int MQRO_NONE = 0;

    public const int MQRO_REJECT_UNSUP_MASK = 270270464;

    public const uint MQRO_ACCEPT_UNSUP_MASK = 4024434943u;

    public const int MQRO_ACCEPT_UNSUP_IF_XMIT_MASK = 261888;

    public const int MQMT_SYSTEM_FIRST = 1;

    public const int MQMT_REQUEST = 1;

    public const int MQMT_REPLY = 2;

    public const int MQMT_DATAGRAM = 8;

    public const int MQMT_REPORT = 4;

    public const int MQMT_MQE_FIELDS_FROM_MQE = 112;

    public const int MQMT_MQE_FIELDS = 113;

    public const int MQMT_SYSTEM_LAST = 65535;

    public const int MQMT_APPL_FIRST = 65536;

    public const int MQMT_APPL_LAST = 999999999;

    public const int MQEI_UNLIMITED = -1;

    public const int MQFB_NONE = 0;

    public const int MQFB_SYSTEM_FIRST = 1;

    public const int MQFB_QUIT = 256;

    public const int MQFB_EXPIRATION = 258;

    public const int MQFB_COA = 259;

    public const int MQFB_COD = 260;

    public const int MQFB_CHANNEL_COMPLETED = 262;

    public const int MQFB_CHANNEL_FAIL_RETRY = 263;

    public const int MQFB_CHANNEL_FAIL = 264;

    public const int MQFB_APPL_CANNOT_BE_STARTED = 265;

    public const int MQFB_TM_ERROR = 266;

    public const int MQFB_APPL_TYPE_ERROR = 267;

    public const int MQFB_STOPPED_BY_MSG_EXIT = 268;

    public const int MQFB_ACTIVITY = 269;

    public const int MQFB_XMIT_Q_MSG_ERROR = 271;

    public const int MQFB_PAN = 275;

    public const int MQFB_NAN = 276;

    public const int MQFB_STOPPED_BY_CHAD_EXIT = 277;

    public const int MQFB_STOPPED_BY_PUBSUB_EXIT = 279;

    public const int MQFB_NOT_A_REPOSITORY_MSG = 280;

    public const int MQFB_BIND_OPEN_CLUSRCVR_DEL = 281;

    public const int MQFB_MAX_ACTIVITIES = 282;

    public const int MQFB_NOT_FORWARDED = 283;

    public const int MQFB_NOT_DELIVERED = 284;

    public const int MQFB_UNSUPPORTED_FORWARDING = 285;

    public const int MQFB_UNSUPPORTED_DELIVERY = 286;

    public const int MQFB_DATA_LENGTH_ZERO = 291;

    public const int MQFB_DATA_LENGTH_NEGATIVE = 292;

    public const int MQFB_DATA_LENGTH_TOO_BIG = 293;

    public const int MQFB_BUFFER_OVERFLOW = 294;

    public const int MQFB_LENGTH_OFF_BY_ONE = 295;

    public const int MQFB_IIH_ERROR = 296;

    public const int MQFB_NOT_AUTHORIZED_FOR_IMS = 298;

    public const int MQFB_IMS_ERROR = 300;

    public const int MQFB_IMS_FIRST = 301;

    public const int MQFB_IMS_LAST = 399;

    public const int MQFB_CICS_INTERNAL_ERROR = 401;

    public const int MQFB_CICS_NOT_AUTHORIZED = 402;

    public const int MQFB_CICS_BRIDGE_FAILURE = 403;

    public const int MQFB_CICS_CORREL_ID_ERROR = 404;

    public const int MQFB_CICS_CCSID_ERROR = 405;

    public const int MQFB_CICS_ENCODING_ERROR = 406;

    public const int MQFB_CICS_CIH_ERROR = 407;

    public const int MQFB_CICS_UOW_ERROR = 408;

    public const int MQFB_CICS_COMMAREA_ERROR = 409;

    public const int MQFB_CICS_APPL_NOT_STARTED = 410;

    public const int MQFB_CICS_APPL_ABENDED = 411;

    public const int MQFB_CICS_DLQ_ERROR = 412;

    public const int MQFB_CICS_UOW_BACKED_OUT = 413;

    public const int MQFB_PUBLICATIONS_ON_REQUEST = 501;

    public const int MQFB_SUBSCRIBER_IS_PUBLISHER = 502;

    public const int MQFB_MSG_SCOPE_MISMATCH = 503;

    public const int MQFB_SELECTOR_MISMATCH = 504;

    public const int MQFB_NOT_A_GROUPUR_MSG = 505;

    public const int MQFB_IMS_NACK_1A_REASON_FIRST = 600;

    public const int MQFB_IMS_NACK_1A_REASON_LAST = 855;

    public const int MQFB_SYSTEM_LAST = 65535;

    public const int MQFB_APPL_FIRST = 65536;

    public const int MQFB_APPL_LAST = 999999999;

    public const int MQENC_NATIVE = 546;

    public const int MQENC_INTEGER_MASK = 15;

    public const int MQENC_DECIMAL_MASK = 240;

    public const int MQENC_FLOAT_MASK = 3840;

    public const uint MQENC_RESERVED_MASK = 4294963200u;

    public const int MQENC_INTEGER_UNDEFINED = 0;

    public const int MQENC_INTEGER_NORMAL = 1;

    public const int MQENC_INTEGER_REVERSED = 2;

    public const int MQENC_DECIMAL_UNDEFINED = 0;

    public const int MQENC_DECIMAL_NORMAL = 16;

    public const int MQENC_DECIMAL_REVERSED = 32;

    public const int MQENC_FLOAT_UNDEFINED = 0;

    public const int MQENC_FLOAT_IEEE_NORMAL = 256;

    public const int MQENC_FLOAT_IEEE_REVERSED = 512;

    public const int MQENC_FLOAT_S390 = 768;

    public const int MQENC_FLOAT_TNS = 1024;

    public const int MQENC_NORMAL = 273;

    public const int MQENC_REVERSED = 546;

    public const int MQENC_S390 = 785;

    public const int MQENC_TNS = 1041;

    public const int MQENC_AS_PUBLISHED = -1;

    public const int MQCCSI_UNDEFINED = 0;

    public const int MQCCSI_DEFAULT = 0;

    public const int MQCCSI_Q_MGR = 0;

    public const int MQCCSI_INHERIT = -2;

    public const int MQCCSI_EMBEDDED = -1;

    public const int MQCCSI_APPL = -3;

    public const int CODESET_UTF = 1208;

    public const int CODESET_UCS = 1200;

    public const int CODESET_819 = 819;

    public const int CODESET_850 = 850;

    public const int CODESET_37 = 37;

    public const int MQCCSI_AS_PUBLISHED = -4;

    public const string MQFMT_NONE = "        ";

    public const string MQFMT_ADMIN = "MQADMIN ";

    public const string MQFMT_AMQP = "MQAMQP  ";

    public const string MQFMT_CHANNEL_COMPLETED = "MQCHCOM ";

    public const string MQFMT_CICS = "MQCICS  ";

    public const string MQFMT_COMMAND_1 = "MQCMD1  ";

    public const string MQFMT_COMMAND_2 = "MQCMD2  ";

    public const string MQFMT_DEAD_LETTER_HEADER = "MQDEAD  ";

    public const string MQFMT_DIST_HEADER = "MQHDIST ";

    public const string MQFMT_EMBEDDED_PCF = "MQHEPCF ";

    public const string MQFMT_EVENT = "MQEVENT ";

    public const string MQFMT_IMS = "MQIMS   ";

    public const string MQFMT_IMS_VAR_STRING = "MQIMSVS ";

    public const string MQFMT_MD_EXTENSION = "MQHMDE  ";

    public const string MQFMT_PCF = "MQPCF   ";

    public const string MQFMT_REF_MSG_HEADER = "MQHREF  ";

    public const string MQFMT_RF_HEADER = "MQHRF   ";

    public const string MQFMT_RF_HEADER_1 = "MQHRF   ";

    public const string MQFMT_RF_HEADER_2 = "MQHRF2  ";

    public const string MQFMT_STRING = "MQSTR   ";

    public const string MQFMT_TRIGGER = "MQTRIG  ";

    public const string MQFMT_WORK_INFO_HEADER = "MQHWIH  ";

    public const string MQFMT_XMIT_Q_HEADER = "MQXMIT  ";

    public const int MQPRI_PRIORITY_AS_Q_DEF = -1;

    public const int MQPRI_PRIORITY_AS_PARENT = -2;

    public const int MQPRI_PRIORITY_AS_PUBLISHED = -3;

    public const int MQPRI_PRIORITY_AS_TOPIC_DEF = -1;

    public const int MQPER_PERSISTENCE_AS_PARENT = -1;

    public const int MQPER_NOT_PERSISTENT = 0;

    public const int MQPER_PERSISTENT = 1;

    public const int MQPER_PERSISTENCE_AS_Q_DEF = 2;

    public const int MQPER_PERSISTENCE_AS_TOPIC_DEF = 2;

    public const int MQPRT_RESPONSE_AS_PARENT = 0;

    public const int MQPRT_SYNC_RESPONSE = 1;

    public const int MQPRT_ASYNC_RESPONSE = 2;

    public const byte MQACTT_UNKNOWN = 0;

    public const byte MQACTT_CICS_LUOW_ID = 1;

    public const byte MQACTT_OS2_DEFAULT = 4;

    public const byte MQACTT_DOS_DEFAULT = 5;

    public const byte MQACTT_UNIX_NUMERIC_ID = 6;

    public const byte MQACTT_OS400_ACCOUNT_TOKEN = 8;

    public const byte MQACTT_WINDOWS_DEFAULT = 9;

    public const byte MQACTT_NT_SECURITY_ID = 11;

    public const byte MQACTT_USER = 25;

    public const int MQAT_UNKNOWN = -1;

    public const int MQAT_NO_CONTEXT = 0;

    public const int MQAT_CICS = 1;

    public const int MQAT_MVS = 2;

    public const int MQAT_OS390 = 2;

    public const int MQAT_ZOS = 2;

    public const int MQAT_IMS = 3;

    public const int MQAT_OS2 = 4;

    public const int MQAT_DOS = 5;

    public const int MQAT_AIX = 6;

    public const int MQAT_UNIX = 6;

    public const int MQAT_QMGR = 7;

    public const int MQAT_OS400 = 8;

    public const int MQAT_WINDOWS = 9;

    public const int MQAT_CICS_VSE = 10;

    public const int MQAT_WINDOWS_NT = 11;

    public const int MQAT_VMS = 12;

    public const int MQAT_GUARDIAN = 13;

    public const int MQAT_NSK = 13;

    public const int MQAT_VOS = 14;

    public const int MQAT_OPEN_TP1 = 15;

    public const int MQAT_VM = 18;

    public const int MQAT_IMS_BRIDGE = 19;

    public const int MQAT_XCF = 20;

    public const int MQAT_CICS_BRIDGE = 21;

    public const int MQAT_NOTES_AGENT = 22;

    public const int MQAT_TPF = 23;

    public const int MQAT_USER = 25;

    public const int MQAT_BROKER = 26;

    public const int MQAT_QMGR_PUBLISH = 26;

    public const int MQAT_JAVA = 28;

    public const int MQAT_DQM = 29;

    public const int MQAT_CHANNEL_INITIATOR = 30;

    public const int MQAT_WLM = 31;

    public const int MQAT_BATCH = 32;

    public const int MQAT_RRS_BATCH = 33;

    public const int MQAT_SIB = 34;

    public const int MQAT_SYSTEM_EXTENSION = 35;

    public const int MQAT_MCAST_PUBLISH = 36;

    public const int MQAT_AMQP = 37;

    public const int MQAT_DEFAULT = 11;

    public const int MQAT_USER_FIRST = 65536;

    public const int MQAT_USER_LAST = 999999999;

    public const int MQMF_SEGMENTATION_INHIBITED = 0;

    public const int MQMF_SEGMENTATION_ALLOWED = 1;

    public const int MQMF_MSG_IN_GROUP = 8;

    public const int MQMF_LAST_MSG_IN_GROUP = 16;

    public const int MQMF_SEGMENT = 2;

    public const int MQMF_LAST_SEGMENT = 4;

    public const int MQMF_NONE = 0;

    public const int MQMF_REJECT_UNSUP_MASK = 4095;

    public const uint MQMF_ACCEPT_UNSUP_MASK = 4293918720u;

    public const int MQMF_ACCEPT_UNSUP_IF_XMIT_MASK = 1044480;

    public const int MQOL_UNDEFINED = -1;

    public const string MQMDE_STRUC_ID = "MDE ";

    public const int MQMDE_VERSION_2 = 2;

    public const int MQMDE_CURRENT_VERSION = 2;

    public const int MQMDE_LENGTH_2 = 72;

    public const int MQMDE_CURRENT_LENGTH = 72;

    public const int MQMDEF_NONE = 0;

    public const int MQMD1_LENGTH_1 = 324;

    public const int MQMD1_CURRENT_LENGTH = 324;

    public const int MQMD2_LENGTH_1 = 324;

    public const int MQMD2_LENGTH_2 = 364;

    public const int MQMD2_CURRENT_LENGTH = 364;

    public const string MQMHBO_STRUC_ID = "MHBO";

    public const int MQMHBO_VERSION_1 = 1;

    public const int MQMHBO_CURRENT_VERSION = 1;

    public const int MQMHBO_LENGTH_1 = 12;

    public const int MQMHBO_CURRENT_LENGTH = 12;

    public const int MQMHBO_PROPERTIES_IN_MQRFH2 = 1;

    public const int MQMHBO_DELETE_PROPERTIES = 2;

    public const int MQMHBO_NONE = 0;

    public const string MQOD_STRUC_ID = "OD  ";

    public const int MQOD_VERSION_1 = 1;

    public const int MQOD_VERSION_2 = 2;

    public const int MQOD_VERSION_3 = 3;

    public const int MQOD_VERSION_4 = 4;

    public const int MQOD_CURRENT_VERSION = 4;

    public const int MQOD_LENGTH_1 = 168;

    public const int MQOD_LENGTH_2 = 200;

    public const int MQOD_LENGTH_3 = 336;

    public const int MQOD_LENGTH_4 = 400;

    public const int MQOD_CURRENT_LENGTH = 400;

    public const int MQOM_NO = 0;

    public const int MQOM_YES = 1;

    public const int MQOT_NONE = 0;

    public const int MQOT_Q = 1;

    public const int MQOT_NAMELIST = 2;

    public const int MQOT_PROCESS = 3;

    public const int MQOT_STORAGE_CLASS = 4;

    public const int MQOT_Q_MGR = 5;

    public const int MQOT_CHANNEL = 6;

    public const int MQOT_AUTH_INFO = 7;

    public const int MQOT_TOPIC = 8;

    public const int MQOT_COMM_INFO = 9;

    public const int MQOT_CF_STRUC = 10;

    public const int MQOT_LISTENER = 11;

    public const int MQOT_SERVICE = 12;

    public const int MQOT_RESERVED_1 = 999;

    public const int MQOT_ALL = 1001;

    public const int MQOT_ALIAS_Q = 1002;

    public const int MQOT_MODEL_Q = 1003;

    public const int MQOT_LOCAL_Q = 1004;

    public const int MQOT_REMOTE_Q = 1005;

    public const int MQOT_SENDER_CHANNEL = 1007;

    public const int MQOT_SERVER_CHANNEL = 1008;

    public const int MQOT_REQUESTER_CHANNEL = 1009;

    public const int MQOT_RECEIVER_CHANNEL = 1010;

    public const int MQOT_CURRENT_CHANNEL = 1011;

    public const int MQOT_SAVED_CHANNEL = 1012;

    public const int MQOT_SVRCONN_CHANNEL = 1013;

    public const int MQOT_CLNTCONN_CHANNEL = 1014;

    public const int MQOT_SHORT_CHANNEL = 1015;

    public const int MQOT_CHLAUTH = 1016;

    public const int MQOT_REMOTE_Q_MGR_NAME = 1017;

    public const int MQOT_PROT_POLICY = 1019;

    public const int MQOT_TT_CHANNEL = 1020;

    public const int MQOT_AMQP_CHANNEL = 1021;

    public const string MQPD_STRUC_ID = "PD  ";

    public const int MQPD_VERSION_1 = 1;

    public const int MQPD_CURRENT_VERSION = 1;

    public const int MQPD_LENGTH_1 = 24;

    public const int MQPD_CURRENT_LENGTH = 24;

    public const int MQPD_NONE = 0;

    public const int MQPD_SUPPORT_OPTIONAL = 1;

    public const int MQPD_SUPPORT_REQUIRED = 1048576;

    public const int MQPD_SUPPORT_REQUIRED_IF_LOCAL = 1024;

    public const uint MQPD_REJECT_UNSUP_MASK = 4293918720u;

    public const int MQPD_ACCEPT_UNSUP_IF_XMIT_MASK = 1047552;

    public const int MQPD_ACCEPT_UNSUP_MASK = 1023;

    public const int MQPD_NO_CONTEXT = 0;

    public const int MQPD_USER_CONTEXT = 1;

    public const int MQCOPY_NONE = 0;

    public const int MQCOPY_ALL = 1;

    public const int MQCOPY_FORWARD = 2;

    public const int MQCOPY_PUBLISH = 4;

    public const int MQCOPY_REPLY = 8;

    public const int MQCOPY_REPORT = 16;

    public const int MQCOPY_DEFAULT = 22;

    public const string MQPMO_STRUC_ID = "PMO ";

    public const int MQPMO_VERSION_1 = 1;

    public const int MQPMO_VERSION_2 = 2;

    public const int MQPMO_VERSION_3 = 3;

    public const int MQPMO_CURRENT_VERSION = 3;

    public const int MQPMO_LENGTH_1 = 128;

    public const int MQPMO_LENGTH_2 = 152;

    public const int MQPMO_LENGTH_3 = 176;

    public const int MQPMO_CURRENT_LENGTH = 176;

    public const int MQPMO_SYNCPOINT = 2;

    public const int MQPMO_NO_SYNCPOINT = 4;

    public const int MQPMO_DEFAULT_CONTEXT = 32;

    public const int MQPMO_NEW_MSG_ID = 64;

    public const int MQPMO_NEW_CORREL_ID = 128;

    public const int MQPMO_PASS_IDENTITY_CONTEXT = 256;

    public const int MQPMO_PASS_ALL_CONTEXT = 512;

    public const int MQPMO_SET_IDENTITY_CONTEXT = 1024;

    public const int MQPMO_SET_ALL_CONTEXT = 2048;

    public const int MQPMO_ALTERNATE_USER_AUTHORITY = 4096;

    public const int MQPMO_FAIL_IF_QUIESCING = 8192;

    public const int MQPMO_NO_CONTEXT = 16384;

    public const int MQPMO_LOGICAL_ORDER = 32768;

    public const int MQPMO_ASYNC_RESPONSE = 65536;

    public const int MQPMO_SYNC_RESPONSE = 131072;

    public const int MQPMO_RESOLVE_LOCAL_Q = 262144;

    public const int MQPMO_WARN_IF_NO_SUBS_MATCHED = 524288;

    public const int MQPMO_RETAIN = 2097152;

    public const int MQPMO_MD_FOR_OUTPUT_ONLY = 8388608;

    public const int MQPMO_SCOPE_QMGR = 67108864;

    public const int MQPMO_SUPPRESS_REPLYTO = 134217728;

    public const int MQPMO_NOT_OWN_SUBS = 268435456;

    public const int MQPMO_RESPONSE_AS_Q_DEF = 0;

    public const int MQPMO_RESPONSE_AS_TOPIC_DEF = 0;

    public const int MQPMO_NONE = 0;

    public const int MQPMO_PUB_OPTIONS_MASK = 2097152;

    public const int MQPMRF_MSG_ID = 1;

    public const int MQPMRF_CORREL_ID = 2;

    public const int MQPMRF_GROUP_ID = 4;

    public const int MQPMRF_FEEDBACK = 8;

    public const int MQPMRF_ACCOUNTING_TOKEN = 16;

    public const int MQPMRF_NONE = 0;

    public const int MQACTP_NEW = 0;

    public const int MQACTP_FORWARD = 1;

    public const int MQACTP_REPLY = 2;

    public const int MQACTP_REPORT = 3;

    public const string MQRFH_STRUC_ID = "RFH ";

    public const int MQRFH_VERSION_1 = 1;

    public const int MQRFH_VERSION_2 = 2;

    public const int MQRFH_STRUC_LENGTH_FIXED = 32;

    public const int MQRFH_STRUC_LENGTH_FIXED_2 = 36;

    public const int MQRFH_LENGTH_1 = 32;

    public const int MQRFH_CURRENT_LENGTH = 32;

    public const int MQRFH_NONE = 0;

    public const int MQRFH_NO_FLAGS = 0;

    public const uint MQRFH_FLAGS_RESTRICTED_MASK = 4294901760u;

    public const string MQNVS_APPL_TYPE = "OPT_APP_GRP ";

    public const string MQNVS_MSG_TYPE = "OPT_MSG_TYPE ";

    public const int MQRFH2_LENGTH_2 = 36;

    public const int MQRFH2_CURRENT_LENGTH = 36;

    public const string MQRMH_STRUC_ID = "RMH ";

    public const int MQRMH_VERSION_1 = 1;

    public const int MQRMH_CURRENT_VERSION = 1;

    public const int MQRMH_LENGTH_1 = 108;

    public const int MQRMH_CURRENT_LENGTH = 108;

    public const int MQRMHF_LAST = 1;

    public const int MQRMHF_NOT_LAST = 0;

    public const string MQSD_STRUC_ID = "SD  ";

    public const int MQSD_VERSION_1 = 1;

    public const int MQSD_CURRENT_VERSION = 1;

    public const int MQSD_LENGTH_1 = 312;

    public const int MQSD_CURRENT_LENGTH = 312;

    public const byte MQSIDT_NONE = 0;

    public const byte MQSIDT_NT_SECURITY_ID = 1;

    public const byte MQSIDT_WAS_SECURITY_ID = 2;

    public const string MQSMPO_STRUC_ID = "SMPO";

    public const int MQSMPO_VERSION_1 = 1;

    public const int MQSMPO_CURRENT_VERSION = 1;

    public const int MQSMPO_LENGTH_1 = 20;

    public const int MQSMPO_CURRENT_LENGTH = 20;

    public const int MQSMPO_SET_FIRST = 0;

    public const int MQSMPO_SET_PROP_UNDER_CURSOR = 1;

    public const int MQSMPO_SET_PROP_AFTER_CURSOR = 2;

    public const int MQSMPO_APPEND_PROPERTY = 4;

    public const int MQSMPO_SET_PROP_BEFORE_CURSOR = 8;

    public const int MQSMPO_NONE = 0;

    public const string MQSRO_STRUC_ID = "SRO ";

    public const int MQSRO_VERSION_1 = 1;

    public const int MQSRO_CURRENT_VERSION = 1;

    public const int MQSRO_LENGTH_1 = 16;

    public const int MQSRO_CURRENT_LENGTH = 16;

    public const int MQSRO_NONE = 0;

    public const int MQSRO_FAIL_IF_QUIESCING = 8192;

    public const string MQSTS_STRUC_ID = "STAT";

    public const int MQSTS_VERSION_1 = 1;

    public const int MQSTS_VERSION_2 = 2;

    public const int MQSTS_CURRENT_VERSION = 2;

    public const int MQSTS_LENGTH_1 = 224;

    public const int MQSTS_LENGTH_2 = 272;

    public const int MQSTS_CURRENT_LENGTH = 272;

    public const string MQTM_STRUC_ID = "TM  ";

    public const int MQTM_VERSION_1 = 1;

    public const int MQTM_CURRENT_VERSION = 1;

    public const int MQTM_LENGTH_1 = 684;

    public const int MQTM_CURRENT_LENGTH = 684;

    public const int MQTMC_LENGTH_1 = 684;

    public const int MQTMC_CURRENT_LENGTH = 684;

    public const string MQTMC_STRUC_ID = "TMC ";

    public const int MQTMC2_LENGTH_1 = 684;

    public const int MQTMC2_LENGTH_2 = 732;

    public const int MQTMC2_CURRENT_LENGTH = 732;

    public const string MQTMC_VERSION_1 = "   1";

    public const string MQTMC_VERSION_2 = "   2";

    public const string MQTMC_CURRENT_VERSION = "   2";

    public const string MQWIH_STRUC_ID = "WIH ";

    public const int MQWIH_VERSION_1 = 1;

    public const int MQWIH_CURRENT_VERSION = 1;

    public const int MQWIH_LENGTH_1 = 120;

    public const int MQWIH_CURRENT_LENGTH = 120;

    public const int MQWIH_NONE = 0;

    public const string MQXQH_STRUC_ID = "XQH ";

    public const int MQXQH_VERSION_1 = 1;

    public const int MQXQH_CURRENT_VERSION = 1;

    public const int MQXQH_LENGTH_1 = 428;

    public const int MQXQH_CURRENT_LENGTH = 428;

    public const int MQHC_DEF_HCONN = 0;

    public const int MQHC_UNUSABLE_HCONN = -1;

    public const int MQHC_UNASSOCIATED_HCONN = -3;

    public const int MQ_OPERATOR_MESSAGE_LENGTH = 4;

    public const int MQ_ABEND_CODE_LENGTH = 4;

    public const int MQ_ACCOUNTING_TOKEN_LENGTH = 32;

    public const int MQ_APPL_DESC_LENGTH = 64;

    public const int MQ_APPL_IDENTITY_DATA_LENGTH = 32;

    public const int MQ_APPL_NAME_LENGTH = 28;

    public const int MQ_APPL_ORIGIN_DATA_LENGTH = 4;

    public const int MQ_APPL_TAG_LENGTH = 28;

    public const int MQ_ARM_SUFFIX_LENGTH = 2;

    public const int MQ_ATTENTION_ID_LENGTH = 4;

    public const int MQ_AUTH_INFO_CONN_NAME_LENGTH = 264;

    public const int MQ_AUTH_INFO_DESC_LENGTH = 64;

    public const int MQ_AUTH_INFO_NAME_LENGTH = 48;

    public const int MQ_AUTH_INFO_OCSP_URL_LENGTH = 256;

    public const int MQ_AUTHENTICATOR_LENGTH = 8;

    public const int MQ_AUTO_REORG_CATALOG_LENGTH = 44;

    public const int MQ_AUTO_REORG_TIME_LENGTH = 4;

    public const int MQ_BATCH_INTERFACE_ID_LENGTH = 8;

    public const int MQ_BRIDGE_NAME_LENGTH = 24;

    public const int MQ_CANCEL_CODE_LENGTH = 4;

    public const int MQ_CF_STRUC_DESC_LENGTH = 64;

    public const int MQ_CF_STRUC_NAME_LENGTH = 12;

    public const int MQ_CHANNEL_DATE_LENGTH = 12;

    public const int MQ_CHANNEL_DESC_LENGTH = 64;

    public const int MQ_CHANNEL_NAME_LENGTH = 20;

    public const int MQ_CHANNEL_TIME_LENGTH = 8;

    public const int MQ_CHINIT_SERVICE_PARM_LENGTH = 32;

    public const int MQ_CICS_FILE_NAME_LENGTH = 8;

    public const int MQ_AMQP_CLIENT_ID_LENGTH = 256;

    public const int MQ_CLIENT_ID_LENGTH = 23;

    public const int MQ_CLIENT_USER_ID_LENGTH = 1024;

    public const int MQ_CLUSTER_NAME_LENGTH = 48;

    public const int MQ_COMM_INFO_DESC_LENGTH = 64;

    public const int MQ_COMM_INFO_NAME_LENGTH = 48;

    public const int MQ_CONN_NAME_LENGTH = 264;

    public const int MQ_CONN_TAG_LENGTH = 128;

    public const int MQ_CONNECTION_ID_LENGTH = 24;

    public const int MQ_CORREL_ID_LENGTH = 24;

    public const int MQ_CREATION_DATE_LENGTH = 12;

    public const int MQ_CREATION_TIME_LENGTH = 8;

    public const int MQ_CSP_PASSWORD_LENGTH = 256;

    public const int MQ_DATE_LENGTH = 12;

    public const int MQ_DISTINGUISHED_NAME_LENGTH = 1024;

    public const int MQ_DNS_GROUP_NAME_LENGTH = 18;

    public const int MQ_EXIT_DATA_LENGTH = 32;

    public const int MQ_EXIT_INFO_NAME_LENGTH = 48;

    public const int MQ_EXIT_NAME_LENGTH = 128;

    public const int MQ_EXIT_PD_AREA_LENGTH = 48;

    public const int MQ_EXIT_USER_AREA_LENGTH = 16;

    public const int MQ_FACILITY_LENGTH = 8;

    public const int MQ_FACILITY_LIKE_LENGTH = 4;

    public const int MQ_FORMAT_LENGTH = 8;

    public const int MQ_FUNCTION_LENGTH = 4;

    public const int MQ_GROUP_ID_LENGTH = 24;

    public const int MQ_APPL_FUNCTION_NAME_LENGTH = 10;

    public const int MQ_INSTALLATION_DESC_LENGTH = 64;

    public const int MQ_INSTALLATION_NAME_LENGTH = 16;

    public const int MQ_INSTALLATION_PATH_LENGTH = 256;

    public const int MQ_JAAS_CONFIG_LENGTH = 1024;

    public const int MQ_LDAP_PASSWORD_LENGTH = 32;

    public const int MQ_LDAP_BASE_DN_LENGTH = 1024;

    public const int MQ_LDAP_FIELD_LENGTH = 128;

    public const int MQ_LDAP_CLASS_LENGTH = 128;

    public const int MQ_LISTENER_NAME_LENGTH = 48;

    public const int MQ_LISTENER_DESC_LENGTH = 64;

    public const int MQ_LOCAL_ADDRESS_LENGTH = 48;

    public const int MQ_LTERM_OVERRIDE_LENGTH = 8;

    public const int MQ_LU_NAME_LENGTH = 8;

    public const int MQ_LUWID_LENGTH = 16;

    public const int MQ_MAX_EXIT_NAME_LENGTH = 128;

    public const int MQ_MAX_MCA_USER_ID_LENGTH = 64;

    public const int MQ_MAX_LDAP_MCA_USER_ID_LENGTH = 1024;

    public const int MQ_MAX_PROPERTY_NAME_LENGTH = 4095;

    public const int MQ_MAX_USER_ID_LENGTH = 64;

    public const int MQ_MCA_JOB_NAME_LENGTH = 28;

    public const int MQ_MCA_NAME_LENGTH = 20;

    public const int MQ_MCA_USER_DATA_LENGTH = 32;

    public const int MQ_MCA_USER_ID_LENGTH = 64;

    public const int MQ_LDAP_MCA_USER_ID_LENGTH = 1024;

    public const int MQ_MFS_MAP_NAME_LENGTH = 8;

    public const int MQ_MODE_NAME_LENGTH = 8;

    public const int MQ_MSG_HEADER_LENGTH = 4000;

    public const int MQ_MSG_ID_LENGTH = 24;

    public const int MQ_MSG_TOKEN_LENGTH = 16;

    public const int MQ_NAMELIST_DESC_LENGTH = 64;

    public const int MQ_NAMELIST_NAME_LENGTH = 48;

    public const int MQ_OBJECT_INSTANCE_ID_LENGTH = 24;

    public const int MQ_OBJECT_NAME_LENGTH = 48;

    public const int MQ_PASS_TICKET_APPL_LENGTH = 8;

    public const int MQ_PASSWORD_LENGTH = 12;

    public const int MQ_PROCESS_APPL_ID_LENGTH = 256;

    public const int MQ_PROCESS_DESC_LENGTH = 64;

    public const int MQ_PROCESS_ENV_DATA_LENGTH = 128;

    public const int MQ_PROCESS_NAME_LENGTH = 48;

    public const int MQ_PROCESS_USER_DATA_LENGTH = 128;

    public const int MQ_PROGRAM_NAME_LENGTH = 20;

    public const int MQ_PUT_APPL_NAME_LENGTH = 28;

    public const int MQ_PUT_DATE_LENGTH = 8;

    public const int MQ_PUT_TIME_LENGTH = 8;

    public const int MQ_Q_DESC_LENGTH = 64;

    public const int MQ_Q_MGR_DESC_LENGTH = 64;

    public const int MQ_Q_MGR_IDENTIFIER_LENGTH = 48;

    public const int MQ_Q_MGR_NAME_LENGTH = 48;

    public const int MQ_Q_NAME_LENGTH = 48;

    public const int MQ_QSG_NAME_LENGTH = 4;

    public const int MQ_REMOTE_SYS_ID_LENGTH = 4;

    public const int MQ_SECURITY_ID_LENGTH = 40;

    public const int MQ_SELECTOR_LENGTH = 10240;

    public const int MQ_SERVICE_ARGS_LENGTH = 255;

    public const int MQ_SERVICE_COMMAND_LENGTH = 255;

    public const int MQ_SERVICE_DESC_LENGTH = 64;

    public const int MQ_SERVICE_NAME_LENGTH = 32;

    public const int MQ_SERVICE_PATH_LENGTH = 255;

    public const int MQ_SERVICE_STEP_LENGTH = 8;

    public const int MQ_SHORT_CONN_NAME_LENGTH = 20;

    public const int MQ_SHORT_DNAME_LENGTH = 256;

    public const int MQ_SSL_CIPHER_SPEC_LENGTH = 32;

    public const int MQ_SSL_CIPHER_SUITE_LENGTH = 32;

    public const int MQ_SSL_CRYPTO_HARDWARE_LENGTH = 256;

    public const int MQ_SSL_HANDSHAKE_STAGE_LENGTH = 32;

    public const int MQ_SSL_KEY_LIBRARY_LENGTH = 44;

    public const int MQ_SSL_KEY_MEMBER_LENGTH = 8;

    public const int MQ_SSL_KEY_REPOSITORY_LENGTH = 256;

    public const int MQ_SSL_PEER_NAME_LENGTH = 1024;

    public const int MQ_SSL_SHORT_PEER_NAME_LENGTH = 256;

    public const int MQ_START_CODE_LENGTH = 4;

    public const int MQ_STORAGE_CLASS_DESC_LENGTH = 64;

    public const int MQ_STORAGE_CLASS_LENGTH = 8;

    public const int MQ_SUB_IDENTITY_LENGTH = 128;

    public const int MQ_SUB_POINT_LENGTH = 128;

    public const int MQ_TCP_NAME_LENGTH = 8;

    public const int MQ_TIME_LENGTH = 8;

    public const int MQ_TOPIC_DESC_LENGTH = 64;

    public const int MQ_TOPIC_NAME_LENGTH = 48;

    public const int MQ_TOPIC_STR_LENGTH = 10240;

    public const int MQ_TOTAL_EXIT_DATA_LENGTH = 999;

    public const int MQ_TOTAL_EXIT_NAME_LENGTH = 999;

    public const int MQ_TP_NAME_LENGTH = 64;

    public const int MQ_TPIPE_NAME_LENGTH = 8;

    public const int MQ_TRAN_INSTANCE_ID_LENGTH = 16;

    public const int MQ_TRANSACTION_ID_LENGTH = 4;

    public const int MQ_TRIGGER_DATA_LENGTH = 64;

    public const int MQ_TRIGGER_PROGRAM_NAME_LENGTH = 8;

    public const int MQ_TRIGGER_TERM_ID_LENGTH = 4;

    public const int MQ_TRIGGER_TRANS_ID_LENGTH = 4;

    public const int MQ_USER_ID_LENGTH = 12;

    public const int MQ_VERSION_LENGTH = 8;

    public const int MQ_XCF_GROUP_NAME_LENGTH = 8;

    public const int MQ_XCF_MEMBER_NAME_LENGTH = 16;

    public const int MQ_SMDS_NAME_LENGTH = 4;

    public const int MQ_CHLAUTH_DESC_LENGTH = 64;

    public const int MQ_CUSTOM_LENGTH = 128;

    public const int MQ_SUITE_B_SIZE = 4;

    public const int MQ_CERT_LABEL_LENGTH = 64;

    public const int MQCC_OK = 0;

    public const int MQCC_WARNING = 1;

    public const int MQCC_FAILED = 2;

    public const int MQCC_UNKNOWN = -1;

    public const int OK = 0;

    public const int MQRC_NONE = 0;

    public const int MQRC_APPL_FIRST = 900;

    public const int MQRC_APPL_LAST = 999;

    public const int MQRC_ALIAS_BASE_Q_TYPE_ERROR = 2001;

    public const int MQRC_ALREADY_CONNECTED = 2002;

    public const int MQRC_BACKED_OUT = 2003;

    public const int MQRC_BUFFER_ERROR = 2004;

    public const int MQRC_BUFFER_LENGTH_ERROR = 2005;

    public const int MQRC_CHAR_ATTR_LENGTH_ERROR = 2006;

    public const int MQRC_CHAR_ATTRS_ERROR = 2007;

    public const int MQRC_CHAR_ATTRS_TOO_SHORT = 2008;

    public const int MQRC_CONNECTION_BROKEN = 2009;

    public const int MQRC_DATA_LENGTH_ERROR = 2010;

    public const int MQRC_DYNAMIC_Q_NAME_ERROR = 2011;

    public const int MQRC_ENVIRONMENT_ERROR = 2012;

    public const int MQRC_EXPIRY_ERROR = 2013;

    public const int MQRC_FEEDBACK_ERROR = 2014;

    public const int MQRC_GET_INHIBITED = 2016;

    public const int MQRC_HANDLE_NOT_AVAILABLE = 2017;

    public const int MQRC_HCONN_ERROR = 2018;

    public const int MQRC_HOBJ_ERROR = 2019;

    public const int MQRC_INHIBIT_VALUE_ERROR = 2020;

    public const int MQRC_INT_ATTR_COUNT_ERROR = 2021;

    public const int MQRC_INT_ATTR_COUNT_TOO_SMALL = 2022;

    public const int MQRC_INT_ATTRS_ARRAY_ERROR = 2023;

    public const int MQRC_SYNCPOINT_LIMIT_REACHED = 2024;

    public const int MQRC_MAX_CONNS_LIMIT_REACHED = 2025;

    public const int MQRC_MD_ERROR = 2026;

    public const int MQRC_MISSING_REPLY_TO_Q = 2027;

    public const int MQRC_MSG_TYPE_ERROR = 2029;

    public const int MQRC_MSG_TOO_BIG_FOR_Q = 2030;

    public const int MQRC_MSG_TOO_BIG_FOR_Q_MGR = 2031;

    public const int MQRC_NO_MSG_AVAILABLE = 2033;

    public const int MQRC_NO_MSG_UNDER_CURSOR = 2034;

    public const int MQRC_NOT_AUTHORIZED = 2035;

    public const int MQRC_NOT_OPEN_FOR_BROWSE = 2036;

    public const int MQRC_NOT_OPEN_FOR_INPUT = 2037;

    public const int MQRC_NOT_OPEN_FOR_INQUIRE = 2038;

    public const int MQRC_NOT_OPEN_FOR_OUTPUT = 2039;

    public const int MQRC_NOT_OPEN_FOR_SET = 2040;

    public const int MQRC_OBJECT_CHANGED = 2041;

    public const int MQRC_OBJECT_IN_USE = 2042;

    public const int MQRC_OBJECT_TYPE_ERROR = 2043;

    public const int MQRC_OD_ERROR = 2044;

    public const int MQRC_OPTION_NOT_VALID_FOR_TYPE = 2045;

    public const int MQRC_OPTIONS_ERROR = 2046;

    public const int MQRC_PERSISTENCE_ERROR = 2047;

    public const int MQRC_PERSISTENT_NOT_ALLOWED = 2048;

    public const int MQRC_PRIORITY_EXCEEDS_MAXIMUM = 2049;

    public const int MQRC_PRIORITY_ERROR = 2050;

    public const int MQRC_PUT_INHIBITED = 2051;

    public const int MQRC_Q_DELETED = 2052;

    public const int MQRC_Q_FULL = 2053;

    public const int MQRC_Q_NOT_EMPTY = 2055;

    public const int MQRC_Q_SPACE_NOT_AVAILABLE = 2056;

    public const int MQRC_Q_TYPE_ERROR = 2057;

    public const int MQRC_Q_MGR_NAME_ERROR = 2058;

    public const int MQRC_Q_MGR_NOT_AVAILABLE = 2059;

    public const int MQRC_REPORT_OPTIONS_ERROR = 2061;

    public const int MQRC_SECOND_MARK_NOT_ALLOWED = 2062;

    public const int MQRC_SECURITY_ERROR = 2063;

    public const int MQRC_SELECTOR_COUNT_ERROR = 2065;

    public const int MQRC_SELECTOR_LIMIT_EXCEEDED = 2066;

    public const int MQRC_SELECTOR_ERROR = 2067;

    public const int MQRC_SELECTOR_NOT_FOR_TYPE = 2068;

    public const int MQRC_SIGNAL_OUTSTANDING = 2069;

    public const int MQRC_SIGNAL_REQUEST_ACCEPTED = 2070;

    public const int MQRC_STORAGE_NOT_AVAILABLE = 2071;

    public const int MQRC_SYNCPOINT_NOT_AVAILABLE = 2072;

    public const int MQRC_TRIGGER_CONTROL_ERROR = 2075;

    public const int MQRC_TRIGGER_DEPTH_ERROR = 2076;

    public const int MQRC_TRIGGER_MSG_PRIORITY_ERR = 2077;

    public const int MQRC_TRIGGER_TYPE_ERROR = 2078;

    public const int MQRC_TRUNCATED_MSG_ACCEPTED = 2079;

    public const int MQRC_TRUNCATED_MSG_FAILED = 2080;

    public const int MQRC_UNKNOWN_ALIAS_BASE_Q = 2082;

    public const int MQRC_UNKNOWN_OBJECT_NAME = 2085;

    public const int MQRC_UNKNOWN_OBJECT_Q_MGR = 2086;

    public const int MQRC_UNKNOWN_REMOTE_Q_MGR = 2087;

    public const int MQRC_WAIT_INTERVAL_ERROR = 2090;

    public const int MQRC_XMIT_Q_TYPE_ERROR = 2091;

    public const int MQRC_XMIT_Q_USAGE_ERROR = 2092;

    public const int MQRC_NOT_OPEN_FOR_PASS_ALL = 2093;

    public const int MQRC_NOT_OPEN_FOR_PASS_IDENT = 2094;

    public const int MQRC_NOT_OPEN_FOR_SET_ALL = 2095;

    public const int MQRC_NOT_OPEN_FOR_SET_IDENT = 2096;

    public const int MQRC_CONTEXT_HANDLE_ERROR = 2097;

    public const int MQRC_CONTEXT_NOT_AVAILABLE = 2098;

    public const int MQRC_SIGNAL1_ERROR = 2099;

    public const int MQRC_OBJECT_ALREADY_EXISTS = 2100;

    public const int MQRC_OBJECT_DAMAGED = 2101;

    public const int MQRC_RESOURCE_PROBLEM = 2102;

    public const int MQRC_ANOTHER_Q_MGR_CONNECTED = 2103;

    public const int MQRC_UNKNOWN_REPORT_OPTION = 2104;

    public const int MQRC_STORAGE_CLASS_ERROR = 2105;

    public const int MQRC_COD_NOT_VALID_FOR_XCF_Q = 2106;

    public const int MQRC_XWAIT_CANCELED = 2107;

    public const int MQRC_XWAIT_ERROR = 2108;

    public const int MQRC_SUPPRESSED_BY_EXIT = 2109;

    public const int MQRC_FORMAT_ERROR = 2110;

    public const int MQRC_SOURCE_CCSID_ERROR = 2111;

    public const int MQRC_SOURCE_INTEGER_ENC_ERROR = 2112;

    public const int MQRC_SOURCE_DECIMAL_ENC_ERROR = 2113;

    public const int MQRC_SOURCE_FLOAT_ENC_ERROR = 2114;

    public const int MQRC_TARGET_CCSID_ERROR = 2115;

    public const int MQRC_TARGET_INTEGER_ENC_ERROR = 2116;

    public const int MQRC_TARGET_DECIMAL_ENC_ERROR = 2117;

    public const int MQRC_TARGET_FLOAT_ENC_ERROR = 2118;

    public const int MQRC_NOT_CONVERTED = 2119;

    public const int MQRC_CONVERTED_MSG_TOO_BIG = 2120;

    public const int MQRC_TRUNCATED = 2120;

    public const int MQRC_NO_EXTERNAL_PARTICIPANTS = 2121;

    public const int MQRC_PARTICIPANT_NOT_AVAILABLE = 2122;

    public const int MQRC_OUTCOME_MIXED = 2123;

    public const int MQRC_OUTCOME_PENDING = 2124;

    public const int MQRC_BRIDGE_STARTED = 2125;

    public const int MQRC_BRIDGE_STOPPED = 2126;

    public const int MQRC_ADAPTER_STORAGE_SHORTAGE = 2127;

    public const int MQRC_UOW_IN_PROGRESS = 2128;

    public const int MQRC_ADAPTER_CONN_LOAD_ERROR = 2129;

    public const int MQRC_ADAPTER_SERV_LOAD_ERROR = 2130;

    public const int MQRC_ADAPTER_DEFS_ERROR = 2131;

    public const int MQRC_ADAPTER_DEFS_LOAD_ERROR = 2132;

    public const int MQRC_ADAPTER_CONV_LOAD_ERROR = 2133;

    public const int MQRC_BO_ERROR = 2134;

    public const int MQRC_DH_ERROR = 2135;

    public const int MQRC_MULTIPLE_REASONS = 2136;

    public const int MQRC_OPEN_FAILED = 2137;

    public const int MQRC_ADAPTER_DISC_LOAD_ERROR = 2138;

    public const int MQRC_CNO_ERROR = 2139;

    public const int MQRC_CICS_WAIT_FAILED = 2140;

    public const int MQRC_DLH_ERROR = 2141;

    public const int MQRC_HEADER_ERROR = 2142;

    public const int MQRC_SOURCE_LENGTH_ERROR = 2143;

    public const int MQRC_TARGET_LENGTH_ERROR = 2144;

    public const int MQRC_SOURCE_BUFFER_ERROR = 2145;

    public const int MQRC_TARGET_BUFFER_ERROR = 2146;

    public const int MQRC_IIH_ERROR = 2148;

    public const int MQRC_PCF_ERROR = 2149;

    public const int MQRC_DBCS_ERROR = 2150;

    public const int MQRC_OBJECT_NAME_ERROR = 2152;

    public const int MQRC_OBJECT_Q_MGR_NAME_ERROR = 2153;

    public const int MQRC_RECS_PRESENT_ERROR = 2154;

    public const int MQRC_OBJECT_RECORDS_ERROR = 2155;

    public const int MQRC_RESPONSE_RECORDS_ERROR = 2156;

    public const int MQRC_ASID_MISMATCH = 2157;

    public const int MQRC_PMO_RECORD_FLAGS_ERROR = 2158;

    public const int MQRC_PUT_MSG_RECORDS_ERROR = 2159;

    public const int MQRC_CONN_ID_IN_USE = 2160;

    public const int MQRC_Q_MGR_QUIESCING = 2161;

    public const int MQRC_Q_MGR_STOPPING = 2162;

    public const int MQRC_DUPLICATE_RECOV_COORD = 2163;

    public const int MQRC_PMO_ERROR = 2173;

    public const int MQRC_API_EXIT_NOT_FOUND = 2182;

    public const int MQRC_API_EXIT_LOAD_ERROR = 2183;

    public const int MQRC_REMOTE_Q_NAME_ERROR = 2184;

    public const int MQRC_INCONSISTENT_PERSISTENCE = 2185;

    public const int MQRC_GMO_ERROR = 2186;

    public const int MQRC_CICS_BRIDGE_RESTRICTION = 2187;

    public const int MQRC_STOPPED_BY_CLUSTER_EXIT = 2188;

    public const int MQRC_CLUSTER_RESOLUTION_ERROR = 2189;

    public const int MQRC_CONVERTED_STRING_TOO_BIG = 2190;

    public const int MQRC_TMC_ERROR = 2191;

    public const int MQRC_PAGESET_FULL = 2192;

    public const int MQRC_STORAGE_MEDIUM_FULL = 2192;

    public const int MQRC_PAGESET_ERROR = 2193;

    public const int MQRC_NAME_NOT_VALID_FOR_TYPE = 2194;

    public const int MQRC_UNEXPECTED_ERROR = 2195;

    public const int MQRC_UNKNOWN_XMIT_Q = 2196;

    public const int MQRC_UNKNOWN_DEF_XMIT_Q = 2197;

    public const int MQRC_DEF_XMIT_Q_TYPE_ERROR = 2198;

    public const int MQRC_DEF_XMIT_Q_USAGE_ERROR = 2199;

    public const int MQRC_MSG_MARKED_BROWSE_CO_OP = 2200;

    public const int MQRC_NAME_IN_USE = 2201;

    public const int MQRC_CONNECTION_QUIESCING = 2202;

    public const int MQRC_CONNECTION_STOPPING = 2203;

    public const int MQRC_ADAPTER_NOT_AVAILABLE = 2204;

    public const int MQRC_MSG_ID_ERROR = 2206;

    public const int MQRC_CORREL_ID_ERROR = 2207;

    public const int MQRC_FILE_SYSTEM_ERROR = 2208;

    public const int MQRC_NO_MSG_LOCKED = 2209;

    public const int MQRC_SOAP_DOTNET_ERROR = 2210;

    public const int MQRC_SOAP_AXIS_ERROR = 2211;

    public const int MQRC_SOAP_URL_ERROR = 2212;

    public const int MQRC_FILE_NOT_AUDITED = 2216;

    public const int MQRC_CONNECTION_NOT_AUTHORIZED = 2217;

    public const int MQRC_MSG_TOO_BIG_FOR_CHANNEL = 2218;

    public const int MQRC_CALL_IN_PROGRESS = 2219;

    public const int MQRC_RMH_ERROR = 2220;

    public const int MQRC_Q_MGR_ACTIVE = 2222;

    public const int MQRC_Q_MGR_NOT_ACTIVE = 2223;

    public const int MQRC_Q_DEPTH_HIGH = 2224;

    public const int MQRC_Q_DEPTH_LOW = 2225;

    public const int MQRC_Q_SERVICE_INTERVAL_HIGH = 2226;

    public const int MQRC_Q_SERVICE_INTERVAL_OK = 2227;

    public const int MQRC_RFH_HEADER_FIELD_ERROR = 2228;

    public const int MQRC_RAS_PROPERTY_ERROR = 2229;

    public const int MQRC_UNIT_OF_WORK_NOT_STARTED = 2232;

    public const int MQRC_CHANNEL_AUTO_DEF_OK = 2233;

    public const int MQRC_CHANNEL_AUTO_DEF_ERROR = 2234;

    public const int MQRC_CFH_ERROR = 2235;

    public const int MQRC_CFIL_ERROR = 2236;

    public const int MQRC_CFIN_ERROR = 2237;

    public const int MQRC_CFSL_ERROR = 2238;

    public const int MQRC_CFST_ERROR = 2239;

    public const int MQRC_INCOMPLETE_GROUP = 2241;

    public const int MQRC_INCOMPLETE_MSG = 2242;

    public const int MQRC_INCONSISTENT_CCSIDS = 2243;

    public const int MQRC_INCONSISTENT_ENCODINGS = 2244;

    public const int MQRC_INCONSISTENT_UOW = 2245;

    public const int MQRC_INVALID_MSG_UNDER_CURSOR = 2246;

    public const int MQRC_MATCH_OPTIONS_ERROR = 2247;

    public const int MQRC_MDE_ERROR = 2248;

    public const int MQRC_MSG_FLAGS_ERROR = 2249;

    public const int MQRC_MSG_SEQ_NUMBER_ERROR = 2250;

    public const int MQRC_OFFSET_ERROR = 2251;

    public const int MQRC_ORIGINAL_LENGTH_ERROR = 2252;

    public const int MQRC_SEGMENT_LENGTH_ZERO = 2253;

    public const int MQRC_UOW_NOT_AVAILABLE = 2255;

    public const int MQRC_WRONG_GMO_VERSION = 2256;

    public const int MQRC_WRONG_MD_VERSION = 2257;

    public const int MQRC_GROUP_ID_ERROR = 2258;

    public const int MQRC_INCONSISTENT_BROWSE = 2259;

    public const int MQRC_XQH_ERROR = 2260;

    public const int MQRC_SRC_ENV_ERROR = 2261;

    public const int MQRC_SRC_NAME_ERROR = 2262;

    public const int MQRC_DEST_ENV_ERROR = 2263;

    public const int MQRC_DEST_NAME_ERROR = 2264;

    public const int MQRC_TM_ERROR = 2265;

    public const int MQRC_CLUSTER_EXIT_ERROR = 2266;

    public const int MQRC_CLUSTER_EXIT_LOAD_ERROR = 2267;

    public const int MQRC_CLUSTER_PUT_INHIBITED = 2268;

    public const int MQRC_CLUSTER_RESOURCE_ERROR = 2269;

    public const int MQRC_NO_DESTINATIONS_AVAILABLE = 2270;

    public const int MQRC_CONN_TAG_IN_USE = 2271;

    public const int MQRC_PARTIALLY_CONVERTED = 2272;

    public const int MQRC_CONNECTION_ERROR = 2273;

    public const int MQRC_OPTION_ENVIRONMENT_ERROR = 2274;

    public const int MQRC_CD_ERROR = 2277;

    public const int MQRC_CLIENT_CONN_ERROR = 2278;

    public const int MQRC_CHANNEL_STOPPED_BY_USER = 2279;

    public const int MQRC_HCONFIG_ERROR = 2280;

    public const int MQRC_FUNCTION_ERROR = 2281;

    public const int MQRC_CHANNEL_STARTED = 2282;

    public const int MQRC_CHANNEL_STOPPED = 2283;

    public const int MQRC_CHANNEL_CONV_ERROR = 2284;

    public const int MQRC_SERVICE_NOT_AVAILABLE = 2285;

    public const int MQRC_INITIALIZATION_FAILED = 2286;

    public const int MQRC_TERMINATION_FAILED = 2287;

    public const int MQRC_UNKNOWN_Q_NAME = 2288;

    public const int MQRC_SERVICE_ERROR = 2289;

    public const int MQRC_Q_ALREADY_EXISTS = 2290;

    public const int MQRC_USER_ID_NOT_AVAILABLE = 2291;

    public const int MQRC_UNKNOWN_ENTITY = 2292;

    public const int MQRC_UNKNOWN_AUTH_ENTITY = 2293;

    public const int MQRC_UNKNOWN_REF_OBJECT = 2294;

    public const int MQRC_CHANNEL_ACTIVATED = 2295;

    public const int MQRC_CHANNEL_NOT_ACTIVATED = 2296;

    public const int MQRC_UOW_CANCELED = 2297;

    public const int MQRC_FUNCTION_NOT_SUPPORTED = 2298;

    public const int MQRC_SELECTOR_TYPE_ERROR = 2299;

    public const int MQRC_COMMAND_TYPE_ERROR = 2300;

    public const int MQRC_MULTIPLE_INSTANCE_ERROR = 2301;

    public const int MQRC_SYSTEM_ITEM_NOT_ALTERABLE = 2302;

    public const int MQRC_BAG_CONVERSION_ERROR = 2303;

    public const int MQRC_SELECTOR_OUT_OF_RANGE = 2304;

    public const int MQRC_SELECTOR_NOT_UNIQUE = 2305;

    public const int MQRC_INDEX_NOT_PRESENT = 2306;

    public const int MQRC_STRING_ERROR = 2307;

    public const int MQRC_ENCODING_NOT_SUPPORTED = 2308;

    public const int MQRC_SELECTOR_NOT_PRESENT = 2309;

    public const int MQRC_OUT_SELECTOR_ERROR = 2310;

    public const int MQRC_STRING_TRUNCATED = 2311;

    public const int MQRC_SELECTOR_WRONG_TYPE = 2312;

    public const int MQRC_INCONSISTENT_ITEM_TYPE = 2313;

    public const int MQRC_INDEX_ERROR = 2314;

    public const int MQRC_SYSTEM_BAG_NOT_ALTERABLE = 2315;

    public const int MQRC_ITEM_COUNT_ERROR = 2316;

    public const int MQRC_FORMAT_NOT_SUPPORTED = 2317;

    public const int MQRC_SELECTOR_NOT_SUPPORTED = 2318;

    public const int MQRC_ITEM_VALUE_ERROR = 2319;

    public const int MQRC_HBAG_ERROR = 2320;

    public const int MQRC_PARAMETER_MISSING = 2321;

    public const int MQRC_CMD_SERVER_NOT_AVAILABLE = 2322;

    public const int MQRC_STRING_LENGTH_ERROR = 2323;

    public const int MQRC_INQUIRY_COMMAND_ERROR = 2324;

    public const int MQRC_NESTED_BAG_NOT_SUPPORTED = 2325;

    public const int MQRC_BAG_WRONG_TYPE = 2326;

    public const int MQRC_ITEM_TYPE_ERROR = 2327;

    public const int MQRC_SYSTEM_BAG_NOT_DELETABLE = 2328;

    public const int MQRC_SYSTEM_ITEM_NOT_DELETABLE = 2329;

    public const int MQRC_CODED_CHAR_SET_ID_ERROR = 2330;

    public const int MQRC_MSG_TOKEN_ERROR = 2331;

    public const int MQRC_MISSING_WIH = 2332;

    public const int MQRC_WIH_ERROR = 2333;

    public const int MQRC_RFH_ERROR = 2334;

    public const int MQRC_RFH_STRING_ERROR = 2335;

    public const int MQRC_RFH_COMMAND_ERROR = 2336;

    public const int MQRC_RFH_PARM_ERROR = 2337;

    public const int MQRC_RFH_DUPLICATE_PARM = 2338;

    public const int MQRC_RFH_PARM_MISSING = 2339;

    public const int MQRC_CHAR_CONVERSION_ERROR = 2340;

    public const int MQRC_UCS2_CONVERSION_ERROR = 2341;

    public const int MQRC_DB2_NOT_AVAILABLE = 2342;

    public const int MQRC_OBJECT_NOT_UNIQUE = 2343;

    public const int MQRC_CONN_TAG_NOT_RELEASED = 2344;

    public const int MQRC_CF_NOT_AVAILABLE = 2345;

    public const int MQRC_CF_STRUC_IN_USE = 2346;

    public const int MQRC_CF_STRUC_LIST_HDR_IN_USE = 2347;

    public const int MQRC_CF_STRUC_AUTH_FAILED = 2348;

    public const int MQRC_CF_STRUC_ERROR = 2349;

    public const int MQRC_CONN_TAG_NOT_USABLE = 2350;

    public const int MQRC_GLOBAL_UOW_CONFLICT = 2351;

    public const int MQRC_LOCAL_UOW_CONFLICT = 2352;

    public const int MQRC_HANDLE_IN_USE_FOR_UOW = 2353;

    public const int MQRC_UOW_ENLISTMENT_ERROR = 2354;

    public const int MQRC_UOW_MIX_NOT_SUPPORTED = 2355;

    public const int MQRC_WXP_ERROR = 2356;

    public const int MQRC_CURRENT_RECORD_ERROR = 2357;

    public const int MQRC_NEXT_OFFSET_ERROR = 2358;

    public const int MQRC_NO_RECORD_AVAILABLE = 2359;

    public const int MQRC_OBJECT_LEVEL_INCOMPATIBLE = 2360;

    public const int MQRC_NEXT_RECORD_ERROR = 2361;

    public const int MQRC_BACKOUT_THRESHOLD_REACHED = 2362;

    public const int MQRC_MSG_NOT_MATCHED = 2363;

    public const int MQRC_JMS_FORMAT_ERROR = 2364;

    public const int MQRC_SEGMENTS_NOT_SUPPORTED = 2365;

    public const int MQRC_WRONG_CF_LEVEL = 2366;

    public const int MQRC_CONFIG_CREATE_OBJECT = 2367;

    public const int MQRC_CONFIG_CHANGE_OBJECT = 2368;

    public const int MQRC_CONFIG_DELETE_OBJECT = 2369;

    public const int MQRC_CONFIG_REFRESH_OBJECT = 2370;

    public const int MQRC_CHANNEL_SSL_ERROR = 2371;

    public const int MQRC_PARTICIPANT_NOT_DEFINED = 2372;

    public const int MQRC_CF_STRUC_FAILED = 2373;

    public const int MQRC_API_EXIT_ERROR = 2374;

    public const int MQRC_API_EXIT_INIT_ERROR = 2375;

    public const int MQRC_API_EXIT_TERM_ERROR = 2376;

    public const int MQRC_EXIT_REASON_ERROR = 2377;

    public const int MQRC_RESERVED_VALUE_ERROR = 2378;

    public const int MQRC_NO_DATA_AVAILABLE = 2379;

    public const int MQRC_SCO_ERROR = 2380;

    public const int MQRC_KEY_REPOSITORY_ERROR = 2381;

    public const int MQRC_CRYPTO_HARDWARE_ERROR = 2382;

    public const int MQRC_AUTH_INFO_REC_COUNT_ERROR = 2383;

    public const int MQRC_AUTH_INFO_REC_ERROR = 2384;

    public const int MQRC_AIR_ERROR = 2385;

    public const int MQRC_AUTH_INFO_TYPE_ERROR = 2386;

    public const int MQRC_AUTH_INFO_CONN_NAME_ERROR = 2387;

    public const int MQRC_LDAP_USER_NAME_ERROR = 2388;

    public const int MQRC_LDAP_USER_NAME_LENGTH_ERR = 2389;

    public const int MQRC_LDAP_PASSWORD_ERROR = 2390;

    public const int MQRC_SSL_ALREADY_INITIALIZED = 2391;

    public const int MQRC_SSL_CONFIG_ERROR = 2392;

    public const int MQRC_SSL_INITIALIZATION_ERROR = 2393;

    public const int MQRC_Q_INDEX_TYPE_ERROR = 2394;

    public const int MQRC_CFBS_ERROR = 2395;

    public const int MQRC_SSL_NOT_ALLOWED = 2396;

    public const int MQRC_JSSE_ERROR = 2397;

    public const int MQRC_SSL_PEER_NAME_MISMATCH = 2398;

    public const int MQRC_SSL_PEER_NAME_ERROR = 2399;

    public const int MQRC_UNSUPPORTED_CIPHER_SUITE = 2400;

    public const int MQRC_SSL_CERTIFICATE_REVOKED = 2401;

    public const int MQRC_SSL_CERT_STORE_ERROR = 2402;

    public const int MQRC_CLIENT_EXIT_LOAD_ERROR = 2406;

    public const int MQRC_CLIENT_EXIT_ERROR = 2407;

    public const int MQRC_UOW_COMMITTED = 2408;

    public const int MQRC_SSL_KEY_RESET_ERROR = 2409;

    public const int MQRC_UNKNOWN_COMPONENT_NAME = 2410;

    public const int MQRC_LOGGER_STATUS = 2411;

    public const int MQRC_COMMAND_MQSC = 2412;

    public const int MQRC_COMMAND_PCF = 2413;

    public const int MQRC_CFIF_ERROR = 2414;

    public const int MQRC_CFSF_ERROR = 2415;

    public const int MQRC_CFGR_ERROR = 2416;

    public const int MQRC_MSG_NOT_ALLOWED_IN_GROUP = 2417;

    public const int MQRC_FILTER_OPERATOR_ERROR = 2418;

    public const int MQRC_NESTED_SELECTOR_ERROR = 2419;

    public const int MQRC_EPH_ERROR = 2420;

    public const int MQRC_RFH_FORMAT_ERROR = 2421;

    public const int MQRC_CFBF_ERROR = 2422;

    public const int MQRC_CLIENT_CHANNEL_CONFLICT = 2423;

    public const int MQRC_SD_ERROR = 2424;

    public const int MQRC_TOPIC_STRING_ERROR = 2425;

    public const int MQRC_STS_ERROR = 2426;

    public const int MQRC_NO_SUBSCRIPTION = 2428;

    public const int MQRC_SUBSCRIPTION_IN_USE = 2429;

    public const int MQRC_STAT_TYPE_ERROR = 2430;

    public const int MQRC_SUB_USER_DATA_ERROR = 2431;

    public const int MQRC_SUB_ALREADY_EXISTS = 2432;

    public const int MQRC_IDENTITY_MISMATCH = 2434;

    public const int MQRC_ALTER_SUB_ERROR = 2435;

    public const int MQRC_DURABILITY_NOT_ALLOWED = 2436;

    public const int MQRC_NO_RETAINED_MSG = 2437;

    public const int MQRC_SRO_ERROR = 2438;

    public const int MQRC_SUB_NAME_ERROR = 2440;

    public const int MQRC_OBJECT_STRING_ERROR = 2441;

    public const int MQRC_PROPERTY_NAME_ERROR = 2442;

    public const int MQRC_SEGMENTATION_NOT_ALLOWED = 2443;

    public const int MQRC_CBD_ERROR = 2444;

    public const int MQRC_CTLO_ERROR = 2445;

    public const int MQRC_NO_CALLBACKS_ACTIVE = 2446;

    public const int MQRC_CALLBACK_NOT_REGISTERED = 2448;

    public const int MQRC_OPTIONS_CHANGED = 2457;

    public const int MQRC_READ_AHEAD_MSGS = 2458;

    public const int MQRC_SELECTOR_SYNTAX_ERROR = 2459;

    public const int MQRC_HMSG_ERROR = 2460;

    public const int MQRC_CMHO_ERROR = 2461;

    public const int MQRC_DMHO_ERROR = 2462;

    public const int MQRC_SMPO_ERROR = 2463;

    public const int MQRC_IMPO_ERROR = 2464;

    public const int MQRC_PROPERTY_NAME_TOO_BIG = 2465;

    public const int MQRC_PROP_VALUE_NOT_CONVERTED = 2466;

    public const int MQRC_PROP_TYPE_NOT_SUPPORTED = 2467;

    public const int MQRC_PROPERTY_VALUE_TOO_BIG = 2469;

    public const int MQRC_PROP_CONV_NOT_SUPPORTED = 2470;

    public const int MQRC_PROPERTY_NOT_AVAILABLE = 2471;

    public const int MQRC_PROP_NUMBER_FORMAT_ERROR = 2472;

    public const int MQRC_PROPERTY_TYPE_ERROR = 2473;

    public const int MQRC_PROPERTIES_TOO_BIG = 2478;

    public const int MQRC_PUT_NOT_RETAINED = 2479;

    public const int MQRC_ALIAS_TARGTYPE_CHANGED = 2480;

    public const int MQRC_DMPO_ERROR = 2481;

    public const int MQRC_PD_ERROR = 2482;

    public const int MQRC_CALLBACK_TYPE_ERROR = 2483;

    public const int MQRC_CBD_OPTIONS_ERROR = 2484;

    public const int MQRC_MAX_MSG_LENGTH_ERROR = 2485;

    public const int MQRC_CALLBACK_ROUTINE_ERROR = 2486;

    public const int MQRC_CALLBACK_LINK_ERROR = 2487;

    public const int MQRC_OPERATION_ERROR = 2488;

    public const int MQRC_BMHO_ERROR = 2489;

    public const int MQRC_UNSUPPORTED_PROPERTY = 2490;

    public const int MQRC_PROP_NAME_NOT_CONVERTED = 2492;

    public const int MQRC_GET_ENABLED = 2494;

    public const int MQRC_MODULE_NOT_FOUND = 2495;

    public const int MQRC_MODULE_INVALID = 2496;

    public const int MQRC_MODULE_ENTRY_NOT_FOUND = 2497;

    public const int MQRC_MIXED_CONTENT_NOT_ALLOWED = 2498;

    public const int MQRC_MSG_HANDLE_IN_USE = 2499;

    public const int MQRC_HCONN_ASYNC_ACTIVE = 2500;

    public const int MQRC_MHBO_ERROR = 2501;

    public const int MQRC_PUBLICATION_FAILURE = 2502;

    public const int MQRC_SUB_INHIBITED = 2503;

    public const int MQRC_SELECTOR_ALWAYS_FALSE = 2504;

    public const int MQRC_XEPO_ERROR = 2507;

    public const int MQRC_DURABILITY_NOT_ALTERABLE = 2509;

    public const int MQRC_TOPIC_NOT_ALTERABLE = 2510;

    public const int MQRC_SUBLEVEL_NOT_ALTERABLE = 2512;

    public const int MQRC_PROPERTY_NAME_LENGTH_ERR = 2513;

    public const int MQRC_DUPLICATE_GROUP_SUB = 2514;

    public const int MQRC_GROUPING_NOT_ALTERABLE = 2515;

    public const int MQRC_SELECTOR_INVALID_FOR_TYPE = 2516;

    public const int MQRC_HOBJ_QUIESCED = 2517;

    public const int MQRC_HOBJ_QUIESCED_NO_MSGS = 2518;

    public const int MQRC_SELECTION_STRING_ERROR = 2519;

    public const int MQRC_RES_OBJECT_STRING_ERROR = 2520;

    public const int MQRC_CONNECTION_SUSPENDED = 2521;

    public const int MQRC_INVALID_DESTINATION = 2522;

    public const int MQRC_INVALID_SUBSCRIPTION = 2523;

    public const int MQRC_SELECTOR_NOT_ALTERABLE = 2524;

    public const int MQRC_RETAINED_MSG_Q_ERROR = 2525;

    public const int MQRC_RETAINED_NOT_DELIVERED = 2526;

    public const int MQRC_RFH_RESTRICTED_FORMAT_ERR = 2527;

    public const int MQRC_CONNECTION_STOPPED = 2528;

    public const int MQRC_ASYNC_UOW_CONFLICT = 2529;

    public const int MQRC_ASYNC_XA_CONFLICT = 2530;

    public const int MQRC_PUBSUB_INHIBITED = 2531;

    public const int MQRC_MSG_HANDLE_COPY_FAILURE = 2532;

    public const int MQRC_DEST_CLASS_NOT_ALTERABLE = 2533;

    public const int MQRC_OPERATION_NOT_ALLOWED = 2534;

    public const int MQRC_ACTION_ERROR = 2535;

    public const int MQRC_CHANNEL_NOT_AVAILABLE = 2537;

    public const int MQRC_HOST_NOT_AVAILABLE = 2538;

    public const int MQRC_CHANNEL_CONFIG_ERROR = 2539;

    public const int MQRC_UNKNOWN_CHANNEL_NAME = 2540;

    public const int MQRC_LOOPING_PUBLICATION = 2541;

    public const int MQRC_ALREADY_JOINED = 2542;

    public const int MQRC_STANDBY_Q_MGR = 2543;

    public const int MQRC_RECONNECTING = 2544;

    public const int MQRC_RECONNECTED = 2545;

    public const int MQRC_RECONNECT_QMID_MISMATCH = 2546;

    public const int MQRC_RECONNECT_INCOMPATIBLE = 2547;

    public const int MQRC_RECONNECT_FAILED = 2548;

    public const int MQRC_CALL_INTERRUPTED = 2549;

    public const int MQRC_NO_SUBS_MATCHED = 2550;

    public const int MQRC_SELECTION_NOT_AVAILABLE = 2551;

    public const int MQRC_CHANNEL_SSL_WARNING = 2552;

    public const int MQRC_OCSP_URL_ERROR = 2553;

    public const int MQRC_CONTENT_ERROR = 2554;

    public const int MQRC_RECONNECT_Q_MGR_REQD = 2555;

    public const int MQRC_RECONNECT_TIMED_OUT = 2556;

    public const int MQRC_PUBLISH_EXIT_ERROR = 2557;

    public const int MQRC_COMMINFO_ERROR = 2558;

    public const int MQRC_DEF_SYNCPOINT_INHIBITED = 2559;

    public const int MQRC_MULTICAST_ONLY = 2560;

    public const int MQRC_DATA_SET_NOT_AVAILABLE = 2561;

    public const int MQRC_GROUPING_NOT_ALLOWED = 2562;

    public const int MQRC_GROUP_ADDRESS_ERROR = 2563;

    public const int MQRC_MULTICAST_CONFIG_ERROR = 2564;

    public const int MQRC_MULTICAST_INTERFACE_ERROR = 2565;

    public const int MQRC_MULTICAST_SEND_ERROR = 2566;

    public const int MQRC_MULTICAST_INTERNAL_ERROR = 2567;

    public const int MQRC_CONNECTION_NOT_AVAILABLE = 2568;

    public const int MQRC_SYNCPOINT_NOT_ALLOWED = 2569;

    public const int MQRC_SSL_ALT_PROVIDER_REQUIRED = 2570;

    public const int MQRC_MCAST_PUB_STATUS = 2571;

    public const int MQRC_MCAST_SUB_STATUS = 2572;

    public const int MQRC_PRECONN_EXIT_LOAD_ERROR = 2573;

    public const int MQRC_PRECONN_EXIT_NOT_FOUND = 2574;

    public const int MQRC_PRECONN_EXIT_ERROR = 2575;

    public const int MQRC_CD_ARRAY_ERROR = 2576;

    public const int MQRC_CHANNEL_BLOCKED = 2577;

    public const int MQRC_CHANNEL_BLOCKED_WARNING = 2578;

    public const int MQRC_SUBSCRIPTION_CREATE = 2579;

    public const int MQRC_SUBSCRIPTION_DELETE = 2580;

    public const int MQRC_SUBSCRIPTION_CHANGE = 2581;

    public const int MQRC_SUBSCRIPTION_REFRESH = 2582;

    public const int MQRC_INSTALLATION_MISMATCH = 2583;

    public const int MQRC_NOT_PRIVILEGED = 2584;

    public const int MQRC_PROPERTIES_DISABLED = 2586;

    public const int MQRC_HMSG_NOT_AVAILABLE = 2587;

    public const int MQRC_EXIT_PROPS_NOT_SUPPORTED = 2588;

    public const int MQRC_INSTALLATION_MISSING = 2589;

    public const int MQRC_FASTPATH_NOT_AVAILABLE = 2590;

    public const int MQRC_CIPHER_SPEC_NOT_SUITE_B = 2591;

    public const int MQRC_SUITE_B_ERROR = 2592;

    public const int MQRC_CERT_VAL_POLICY_ERROR = 2593;

    public const int MQRC_PASSWORD_PROTECTION_ERROR = 2594;

    public const int MQRC_CSP_ERROR = 2595;

    public const int MQRC_CERT_LABEL_NOT_ALLOWED = 2596;

    public const int MQRC_ADMIN_TOPIC_STRING_ERROR = 2598;

    public const int MQRC_AMQP_NOT_AVAILABLE = 2599;

    public const int MQRC_LIBRARY_LOAD_ERROR = 6000;

    public const int MQRC_CLASS_LIBRARY_ERROR = 6001;

    public const int MQRC_STRING_LENGTH_TOO_BIG = 6002;

    public const int MQRC_WRITE_VALUE_ERROR = 6003;

    public const int MQRC_PACKED_DECIMAL_ERROR = 6004;

    public const int MQRC_FLOAT_CONVERSION_ERROR = 6005;

    public const int MQRC_REOPEN_EXCL_INPUT_ERROR = 6100;

    public const int MQRC_REOPEN_INQUIRE_ERROR = 6101;

    public const int MQRC_REOPEN_SAVED_CONTEXT_ERR = 6102;

    public const int MQRC_REOPEN_TEMPORARY_Q_ERROR = 6103;

    public const int MQRC_ATTRIBUTE_LOCKED = 6104;

    public const int MQRC_CURSOR_NOT_VALID = 6105;

    public const int MQRC_ENCODING_ERROR = 6106;

    public const int MQRC_STRUC_ID_ERROR = 6107;

    public const int MQRC_NULL_POINTER = 6108;

    public const int MQRC_NO_CONNECTION_REFERENCE = 6109;

    public const int MQRC_NO_BUFFER = 6110;

    public const int MQRC_BINARY_DATA_LENGTH_ERROR = 6111;

    public const int MQRC_BUFFER_NOT_AUTOMATIC = 6112;

    public const int MQRC_INSUFFICIENT_BUFFER = 6113;

    public const int MQRC_INSUFFICIENT_DATA = 6114;

    public const int MQRC_DATA_TRUNCATED = 6115;

    public const int MQRC_ZERO_LENGTH = 6116;

    public const int MQRC_NEGATIVE_LENGTH = 6117;

    public const int MQRC_NEGATIVE_OFFSET = 6118;

    public const int MQRC_INCONSISTENT_FORMAT = 6119;

    public const int MQRC_INCONSISTENT_OBJECT_STATE = 6120;

    public const int MQRC_CONTEXT_OBJECT_NOT_VALID = 6121;

    public const int MQRC_CONTEXT_OPEN_ERROR = 6122;

    public const int MQRC_STRUC_LENGTH_ERROR = 6123;

    public const int MQRC_NOT_CONNECTED = 6124;

    public const int MQRC_NOT_OPEN = 6125;

    public const int MQRC_DISTRIBUTION_LIST_EMPTY = 6126;

    public const int MQRC_INCONSISTENT_OPEN_OPTIONS = 6127;

    public const int MQRC_WRONG_VERSION = 6128;

    public const int MQRC_REFERENCE_ERROR = 6129;

    public const int MQRC_XR_NOT_AVAILABLE = 6130;

    public const int MQQT_LOCAL = 1;

    public const int MQQT_MODEL = 2;

    public const int MQQT_ALIAS = 3;

    public const int MQQT_REMOTE = 6;

    public const int MQQT_CLUSTER = 7;

    public const int MQCQT_LOCAL_Q = 1;

    public const int MQCQT_ALIAS_Q = 2;

    public const int MQCQT_REMOTE_Q = 3;

    public const int MQCQT_Q_MGR_ALIAS = 4;

    public const int MQQT_ALL = 1001;

    public const int MQQDT_PREDEFINED = 1;

    public const int MQQDT_PERMANENT_DYNAMIC = 2;

    public const int MQQDT_TEMPORARY_DYNAMIC = 3;

    public const int MQQDT_SHARED_DYNAMIC = 4;

    public const int MQQA_GET_INHIBITED = 1;

    public const int MQQA_GET_ALLOWED = 0;

    public const int MQQA_PUT_INHIBITED = 1;

    public const int MQQA_PUT_ALLOWED = 0;

    public const int MQQA_SHAREABLE = 1;

    public const int MQQA_NOT_SHAREABLE = 0;

    public const int MQQA_BACKOUT_HARDENED = 1;

    public const int MQQA_BACKOUT_NOT_HARDENED = 0;

    public const int MQMDS_PRIORITY = 0;

    public const int MQMDS_FIFO = 1;

    public const int MQNPM_CLASS_NORMAL = 0;

    public const int MQNPM_CLASS_HIGH = 10;

    public const int MQTC_OFF = 0;

    public const int MQTC_ON = 1;

    public const int MQTT_NONE = 0;

    public const int MQTT_FIRST = 1;

    public const int MQTT_EVERY = 2;

    public const int MQTT_DEPTH = 3;

    public const int MQTRIGGER_RESTART_NO = 0;

    public const int MQTRIGGER_RESTART_YES = 1;

    public const int MQUS_NORMAL = 0;

    public const int MQUS_TRANSMISSION = 1;

    public const int MQDL_SUPPORTED = 1;

    public const int MQDL_NOT_SUPPORTED = 0;

    public const int MQIT_NONE = 0;

    public const int MQIT_MSG_ID = 1;

    public const int MQIT_CORREL_ID = 2;

    public const int MQIT_MSG_TOKEN = 4;

    public const int MQIT_GROUP_ID = 5;

    public const int MQBND_BIND_ON_OPEN = 0;

    public const int MQBND_BIND_NOT_FIXED = 1;

    public const int MQBND_BIND_ON_GROUP = 2;

    public const int MQQSGD_ALL = -1;

    public const int MQQSGD_Q_MGR = 0;

    public const int MQQSGD_COPY = 1;

    public const int MQQSGD_SHARED = 2;

    public const int MQQSGD_GROUP = 3;

    public const int MQQSGD_PRIVATE = 4;

    public const int MQQSGD_LIVE = 6;

    public const int MQREORG_DISABLED = 0;

    public const int MQREORG_ENABLED = 1;

    public const int MQREADA_NO = 0;

    public const int MQREADA_YES = 1;

    public const int MQREADA_DISABLED = 2;

    public const int MQREADA_INHIBITED = 3;

    public const int MQREADA_BACKLOG = 4;

    public const int MQPROP_COMPATIBILITY = 0;

    public const int MQPROP_NONE = 1;

    public const int MQPROP_ALL = 2;

    public const int MQPROP_FORCE_MQRFH2 = 3;

    public const int MQPROP_V6COMPAT = 4;

    public const int MQNC_MAX_NAMELIST_NAME_COUNT = 256;

    public const int MQNT_NONE = 0;

    public const int MQNT_Q = 1;

    public const int MQNT_CLUSTER = 2;

    public const int MQNT_AUTH_INFO = 4;

    public const int MQNT_ALL = 1001;

    public const int MQCFR_YES = 1;

    public const int MQCFR_NO = 0;

    public const int MQRECAUTO_NO = 0;

    public const int MQRECAUTO_YES = 1;

    public const int MQCFCONLOS_TERMINATE = 0;

    public const int MQCFCONLOS_TOLERATE = 1;

    public const int MQCFCONLOS_ASQMGR = 2;

    public const int MQSVC_TYPE_COMMAND = 0;

    public const int MQSVC_TYPE_SERVER = 1;

    public const int MQADOPT_CHECK_NONE = 0;

    public const int MQADOPT_CHECK_ALL = 1;

    public const int MQADOPT_CHECK_Q_MGR_NAME = 2;

    public const int MQADOPT_CHECK_NET_ADDR = 4;

    public const int MQADOPT_TYPE_NO = 0;

    public const int MQADOPT_TYPE_ALL = 1;

    public const int MQADOPT_TYPE_SVR = 2;

    public const int MQADOPT_TYPE_SDR = 4;

    public const int MQADOPT_TYPE_RCVR = 8;

    public const int MQADOPT_TYPE_CLUSRCVR = 16;

    public const int MQAUTO_START_NO = 0;

    public const int MQAUTO_START_YES = 1;

    public const int MQCHAD_DISABLED = 0;

    public const int MQCHAD_ENABLED = 1;

    public const int MQCLWL_USEQ_LOCAL = 0;

    public const int MQCLWL_USEQ_ANY = 1;

    public const int MQCLWL_USEQ_AS_Q_MGR = -3;

    public const int MQCMDL_LEVEL_1 = 100;

    public const int MQCMDL_LEVEL_101 = 101;

    public const int MQCMDL_LEVEL_110 = 110;

    public const int MQCMDL_LEVEL_114 = 114;

    public const int MQCMDL_LEVEL_120 = 120;

    public const int MQCMDL_LEVEL_200 = 200;

    public const int MQCMDL_LEVEL_201 = 201;

    public const int MQCMDL_LEVEL_210 = 210;

    public const int MQCMDL_LEVEL_211 = 211;

    public const int MQCMDL_LEVEL_220 = 220;

    public const int MQCMDL_LEVEL_221 = 221;

    public const int MQCMDL_LEVEL_230 = 230;

    public const int MQCMDL_LEVEL_320 = 320;

    public const int MQCMDL_LEVEL_420 = 420;

    public const int MQCMDL_LEVEL_500 = 500;

    public const int MQCMDL_LEVEL_510 = 510;

    public const int MQCMDL_LEVEL_520 = 520;

    public const int MQCMDL_LEVEL_530 = 530;

    public const int MQCMDL_LEVEL_531 = 531;

    public const int MQCMDL_LEVEL_600 = 600;

    public const int MQCMDL_LEVEL_700 = 700;

    public const int MQCMDL_LEVEL_701 = 701;

    public const int MQCMDL_LEVEL_710 = 710;

    public const int MQCMDL_LEVEL_711 = 711;

    public const int MQCMDL_LEVEL_750 = 750;

    public const int MQCMDL_LEVEL_800 = 800;

    public const int MQCMDL_LEVEL_801 = 801;

    public const int MQCMDL_LEVEL_802 = 802;

    public const int MQCMDL_CURRENT_LEVEL = 802;

    public const int MQCSRV_CONVERT_NO = 0;

    public const int MQCSRV_CONVERT_YES = 1;

    public const int MQCSRV_DLQ_NO = 0;

    public const int MQCSRV_DLQ_YES = 1;

    public const int MQDNSWLM_NO = 0;

    public const int MQDNSWLM_YES = 1;

    public const int MQEXPI_OFF = 0;

    public const int MQIGQ_DISABLED = 0;

    public const int MQIGQ_ENABLED = 1;

    public const int MQIGQPA_DEFAULT = 1;

    public const int MQIGQPA_CONTEXT = 2;

    public const int MQIGQPA_ONLY_IGQ = 3;

    public const int MQIGQPA_ALTERNATE_OR_IGQ = 4;

    public const int MQIPADDR_IPV4 = 0;

    public const int MQIPADDR_IPV6 = 1;

    public const int MQMMBI_UNLIMITED = -1;

    public const int MQMON_NOT_AVAILABLE = -1;

    public const int MQMON_NONE = -1;

    public const int MQMON_Q_MGR = -3;

    public const int MQMON_OFF = 0;

    public const int MQMON_ON = 1;

    public const int MQMON_DISABLED = 0;

    public const int MQMON_ENABLED = 1;

    public const int MQMON_LOW = 17;

    public const int MQMON_MEDIUM = 33;

    public const int MQMON_HIGH = 65;

    public const int MQFUN_TYPE_UNKNOWN = 0;

    public const int MQFUN_TYPE_JVM = 1;

    public const int MQFUN_TYPE_PROGRAM = 2;

    public const int MQFUN_TYPE_PROCEDURE = 3;

    public const int MQFUN_TYPE_USERDEF = 4;

    public const int MQFUN_TYPE_COMMAND = 5;

    public const int MQACTV_DETAIL_LOW = 1;

    public const int MQACTV_DETAIL_MEDIUM = 2;

    public const int MQACTV_DETAIL_HIGH = 3;

    public const int MQPL_MVS = 1;

    public const int MQPL_OS390 = 1;

    public const int MQPL_ZOS = 1;

    public const int MQPL_OS2 = 2;

    public const int MQPL_AIX = 3;

    public const int MQPL_UNIX = 3;

    public const int MQPL_OS400 = 4;

    public const int MQPL_WINDOWS = 5;

    public const int MQPL_WINDOWS_NT = 11;

    public const int MQPL_VMS = 12;

    public const int MQPL_NSK = 13;

    public const int MQPL_NSS = 13;

    public const int MQPL_OPEN_TP1 = 15;

    public const int MQPL_VM = 18;

    public const int MQPL_TPF = 23;

    public const int MQPL_VSE = 27;

    public const int MQPL_APPLIANCE = 28;

    public const int MQPROP_UNRESTRICTED_LENGTH = -1;

    public const int MQPSM_DISABLED = 0;

    public const int MQPSM_COMPAT = 1;

    public const int MQPSM_ENABLED = 2;

    public const int MQPSCLUS_DISABLED = 0;

    public const int MQPSCLUS_ENABLED = 1;

    public const int MQQMOPT_DISABLED = 0;

    public const int MQQMOPT_ENABLED = 1;

    public const int MQQMOPT_REPLY = 2;

    public const int MQRCVTIME_MULTIPLY = 0;

    public const int MQRCVTIME_ADD = 1;

    public const int MQRCVTIME_EQUAL = 2;

    public const int MQRECORDING_DISABLED = 0;

    public const int MQRECORDING_Q = 1;

    public const int MQRECORDING_MSG = 2;

    public const int MQSCYC_UPPER = 0;

    public const int MQSCYC_MIXED = 1;

    public const int MQSQQM_USE = 0;

    public const int MQSQQM_IGNORE = 1;

    public const int MQSSL_FIPS_NO = 0;

    public const int MQSSL_FIPS_YES = 1;

    public const int MQSP_AVAILABLE = 1;

    public const int MQSP_NOT_AVAILABLE = 0;

    public const int MQSVC_CONTROL_Q_MGR = 0;

    public const int MQSVC_CONTROL_Q_MGR_START = 1;

    public const int MQSVC_CONTROL_MANUAL = 2;

    public const int MQSVC_STATUS_STOPPED = 0;

    public const int MQSVC_STATUS_STARTING = 1;

    public const int MQSVC_STATUS_RUNNING = 2;

    public const int MQSVC_STATUS_STOPPING = 3;

    public const int MQSVC_STATUS_RETRYING = 4;

    public const int MQTCPKEEP_NO = 0;

    public const int MQTCPKEEP_YES = 1;

    public const int MQTCPSTACK_SINGLE = 0;

    public const int MQTCPSTACK_MULTIPLE = 1;

    public const int MQTRAXSTR_NO = 0;

    public const int MQTRAXSTR_YES = 1;

    public const int MQCAP_NOT_SUPPORTED = 0;

    public const int MQCAP_SUPPORTED = 1;

    public const int MQCAP_EXPIRED = 2;

    public const int MQDLV_AS_PARENT = 0;

    public const int MQDLV_ALL = 1;

    public const int MQDLV_ALL_DUR = 2;

    public const int MQDLV_ALL_AVAIL = 3;

    public const int MQMASTER_NO = 0;

    public const int MQMASTER_YES = 1;

    public const int MQSCOPE_ALL = 0;

    public const int MQSCOPE_AS_PARENT = 1;

    public const int MQSCOPE_QMGR = 4;

    public const int MQSUB_DURABLE_AS_PARENT = 0;

    public const int MQSUB_DURABLE_ALLOWED = 1;

    public const int MQSUB_DURABLE_INHIBITED = 2;

    public const int MQTA_BLOCK = 1;

    public const int MQTA_PASSTHRU = 2;

    public const int MQTA_SUB_AS_PARENT = 0;

    public const int MQTA_SUB_INHIBITED = 1;

    public const int MQTA_SUB_ALLOWED = 2;

    public const int MQTA_PROXY_SUB_FORCE = 1;

    public const int MQTA_PROXY_SUB_FIRSTUSE = 2;

    public const int MQTA_PUB_AS_PARENT = 0;

    public const int MQTA_PUB_INHIBITED = 1;

    public const int MQTA_PUB_ALLOWED = 2;

    public const int MQTOPT_LOCAL = 0;

    public const int MQTOPT_CLUSTER = 1;

    public const int MQTOPT_ALL = 2;

    public const int MQMC_AS_PARENT = 0;

    public const int MQMC_ENABLED = 1;

    public const int MQMC_DISABLED = 2;

    public const int MQMC_ONLY = 3;

    public const int MQCIT_MULTICAST = 1;

    public const int MQDC_MANAGED = 1;

    public const int MQDC_PROVIDED = 2;

    public const int MQPSPROP_NONE = 0;

    public const int MQPSPROP_COMPAT = 1;

    public const int MQPSPROP_RFH2 = 2;

    public const int MQPSPROP_MSGPROP = 3;

    public const int MQRU_PUBLISH_ON_REQUEST = 1;

    public const int MQRU_PUBLISH_ALL = 2;

    public const int MQSUB_DURABLE_ALL = -1;

    public const int MQSUB_DURABLE_YES = 1;

    public const int MQSUB_DURABLE_NO = 2;

    public const int MQTSCOPE_QMGR = 1;

    public const int MQTSCOPE_ALL = 2;

    public const int MQVU_FIXED_USER = 1;

    public const int MQVU_ANY_USER = 2;

    public const int MQWS_DEFAULT = 0;

    public const int MQWS_CHAR = 1;

    public const int MQWS_TOPIC = 2;

    public const int MQUSRC_MAP = 0;

    public const int MQUSRC_NOACCESS = 1;

    public const int MQUSRC_CHANNEL = 2;

    public const int MQWARN_YES = 1;

    public const int MQWARN_NO = 0;

    public const int MQDSB_DEFAULT = 0;

    public const int MQDSB_8K = 1;

    public const int MQDSB_16K = 2;

    public const int MQDSB_32K = 3;

    public const int MQDSB_64K = 4;

    public const int MQDSB_128K = 5;

    public const int MQDSB_256K = 6;

    public const int MQDSB_512K = 7;

    public const int MQDSB_1024K = 8;

    public const int MQDSB_1M = 8;

    public const int MQDSE_DEFAULT = 0;

    public const int MQDSE_YES = 1;

    public const int MQDSE_NO = 2;

    public const int MQCFOFFLD_NONE = 0;

    public const int MQCFOFFLD_SMDS = 1;

    public const int MQCFOFFLD_DB2 = 2;

    public const int MQCFOFFLD_BOTH = 3;

    public const int MQUSEDLQ_AS_PARENT = 0;

    public const int MQUSEDLQ_NO = 1;

    public const int MQUSEDLQ_YES = 2;

    public const int MQHO_UNUSABLE_HOBJ = -1;

    public const int MQHO_NONE = 0;

    public const int MQCO_IMMEDIATE = 0;

    public const int MQCO_NONE = 0;

    public const int MQCO_DELETE = 1;

    public const int MQCO_DELETE_PURGE = 2;

    public const int MQCO_KEEP_SUB = 4;

    public const int MQCO_REMOVE_SUB = 8;

    public const int MQCO_QUIESCE = 32;

    public const int MQOP_START = 1;

    public const int MQOP_START_WAIT = 2;

    public const int MQOP_STOP = 4;

    public const int MQOP_REGISTER = 256;

    public const int MQOP_DEREGISTER = 512;

    public const int MQOP_SUSPEND = 65536;

    public const int MQOP_RESUME = 131072;

    public const long MQHM_UNUSABLE_HMSG = -1L;

    public const long MQHM_NONE = 0L;

    public const int MQBA_FIRST = 6001;

    public const int MQBA_LAST = 8000;

    public const int MQCA_ADMIN_TOPIC_NAME = 2105;

    public const int MQCA_ALTERATION_DATE = 2027;

    public const int MQCA_ALTERATION_TIME = 2028;

    public const int MQCA_AMQP_SSL_CIPHER_SUITES = 2137;

    public const int MQCA_AMQP_VERSION = 2136;

    public const int MQCA_APPL_ID = 2001;

    public const int MQCA_AUTH_INFO_CONN_NAME = 2053;

    public const int MQCA_AUTH_INFO_DESC = 2046;

    public const int MQCA_AUTH_INFO_NAME = 2045;

    public const int MQCA_AUTH_INFO_OCSP_URL = 2109;

    public const int MQCA_AUTO_REORG_CATALOG = 2091;

    public const int MQCA_AUTO_REORG_START_TIME = 2090;

    public const int MQCA_BACKOUT_REQ_Q_NAME = 2019;

    public const int MQCA_BASE_OBJECT_NAME = 2002;

    public const int MQCA_BASE_Q_NAME = 2002;

    public const int MQCA_BATCH_INTERFACE_ID = 2068;

    public const int MQCA_CERT_LABEL = 2121;

    public const int MQCA_CF_STRUC_DESC = 2052;

    public const int MQCA_CF_STRUC_NAME = 2039;

    public const int MQCA_CHANNEL_AUTO_DEF_EXIT = 2026;

    public const int MQCA_CHILD = 2101;

    public const int MQCA_CHINIT_SERVICE_PARM = 2076;

    public const int MQCA_CHLAUTH_DESC = 2118;

    public const int MQCA_CICS_FILE_NAME = 2060;

    public const int MQCA_CLUSTER_DATE = 2037;

    public const int MQCA_CLUSTER_NAME = 2029;

    public const int MQCA_CLUSTER_NAMELIST = 2030;

    public const int MQCA_CLUSTER_Q_MGR_NAME = 2031;

    public const int MQCA_CLUSTER_TIME = 2038;

    public const int MQCA_CLUSTER_WORKLOAD_DATA = 2034;

    public const int MQCA_CLUSTER_WORKLOAD_EXIT = 2033;

    public const int MQCA_CLUS_CHL_NAME = 2124;

    public const int MQCA_COMMAND_INPUT_Q_NAME = 2003;

    public const int MQCA_COMMAND_REPLY_Q_NAME = 2067;

    public const int MQCA_COMM_INFO_DESC = 2111;

    public const int MQCA_COMM_INFO_NAME = 2110;

    public const int MQCA_CONN_AUTH = 2125;

    public const int MQCA_CREATION_DATE = 2004;

    public const int MQCA_CREATION_TIME = 2005;

    public const int MQCA_CUSTOM = 2119;

    public const int MQCA_DEAD_LETTER_Q_NAME = 2006;

    public const int MQCA_DEF_XMIT_Q_NAME = 2025;

    public const int MQCA_DNS_GROUP = 2071;

    public const int MQCA_ENV_DATA = 2007;

    public const int MQCA_FIRST = 2001;

    public const int MQCA_IGQ_USER_ID = 2041;

    public const int MQCA_INITIATION_Q_NAME = 2008;

    public const int MQCA_INSTALLATION_DESC = 2115;

    public const int MQCA_INSTALLATION_NAME = 2116;

    public const int MQCA_INSTALLATION_PATH = 2117;

    public const int MQCA_LAST = 4000;

    public const int MQCA_LAST_USED = 2137;

    public const int MQCA_LDAP_BASE_DN_GROUPS = 2132;

    public const int MQCA_LDAP_BASE_DN_USERS = 2126;

    public const int MQCA_LDAP_FIND_GROUP_FIELD = 2135;

    public const int MQCA_LDAP_GROUP_ATTR_FIELD = 2134;

    public const int MQCA_LDAP_GROUP_OBJECT_CLASS = 2133;

    public const int MQCA_LDAP_PASSWORD = 2048;

    public const int MQCA_LDAP_SHORT_USER_FIELD = 2127;

    public const int MQCA_LDAP_USER_ATTR_FIELD = 2129;

    public const int MQCA_LDAP_USER_NAME = 2047;

    public const int MQCA_LDAP_USER_OBJECT_CLASS = 2128;

    public const int MQCA_LU62_ARM_SUFFIX = 2074;

    public const int MQCA_LU_GROUP_NAME = 2072;

    public const int MQCA_LU_NAME = 2073;

    public const int MQCA_MODEL_DURABLE_Q = 2096;

    public const int MQCA_MODEL_NON_DURABLE_Q = 2097;

    public const int MQCA_MONITOR_Q_NAME = 2066;

    public const int MQCA_NAMELIST_DESC = 2009;

    public const int MQCA_NAMELIST_NAME = 2010;

    public const int MQCA_NAMES = 2020;

    public const int MQCA_PARENT = 2102;

    public const int MQCA_PASS_TICKET_APPL = 2086;

    public const int MQCA_POLICY_NAME = 2112;

    public const int MQCA_PROCESS_DESC = 2011;

    public const int MQCA_PROCESS_NAME = 2012;

    public const int MQCA_QSG_CERT_LABEL = 2131;

    public const int MQCA_QSG_NAME = 2040;

    public const int MQCA_Q_DESC = 2013;

    public const int MQCA_Q_MGR_DESC = 2014;

    public const int MQCA_Q_MGR_IDENTIFIER = 2032;

    public const int MQCA_Q_MGR_NAME = 2015;

    public const int MQCA_Q_NAME = 2016;

    public const int MQCA_RECIPIENT_DN = 2114;

    public const int MQCA_REMOTE_Q_MGR_NAME = 2017;

    public const int MQCA_REMOTE_Q_NAME = 2018;

    public const int MQCA_REPOSITORY_NAME = 2035;

    public const int MQCA_REPOSITORY_NAMELIST = 2036;

    public const int MQCA_RESUME_DATE = 2098;

    public const int MQCA_RESUME_TIME = 2099;

    public const int MQCA_SERVICE_DESC = 2078;

    public const int MQCA_SERVICE_NAME = 2077;

    public const int MQCA_SERVICE_START_ARGS = 2080;

    public const int MQCA_SERVICE_START_COMMAND = 2079;

    public const int MQCA_SERVICE_STOP_ARGS = 2082;

    public const int MQCA_SERVICE_STOP_COMMAND = 2081;

    public const int MQCA_SIGNER_DN = 2113;

    public const int MQCA_SSL_CERT_ISSUER_NAME = 2130;

    public const int MQCA_SSL_CRL_NAMELIST = 2050;

    public const int MQCA_SSL_CRYPTO_HARDWARE = 2051;

    public const int MQCA_SSL_KEY_LIBRARY = 2069;

    public const int MQCA_SSL_KEY_MEMBER = 2070;

    public const int MQCA_SSL_KEY_REPOSITORY = 2049;

    public const int MQCA_STDERR_DESTINATION = 2084;

    public const int MQCA_STDOUT_DESTINATION = 2083;

    public const int MQCA_STORAGE_CLASS = 2022;

    public const int MQCA_STORAGE_CLASS_DESC = 2042;

    public const int MQCA_SYSTEM_LOG_Q_NAME = 2065;

    public const int MQCA_TCP_NAME = 2075;

    public const int MQCA_TOPIC_DESC = 2093;

    public const int MQCA_TOPIC_NAME = 2092;

    public const int MQCA_TOPIC_STRING = 2094;

    public const int MQCA_TOPIC_STRING_FILTER = 2108;

    public const int MQCA_TPIPE_NAME = 2085;

    public const int MQCA_TRIGGER_CHANNEL_NAME = 2064;

    public const int MQCA_TRIGGER_DATA = 2023;

    public const int MQCA_TRIGGER_PROGRAM_NAME = 2062;

    public const int MQCA_TRIGGER_TERM_ID = 2063;

    public const int MQCA_TRIGGER_TRANS_ID = 2061;

    public const int MQCA_USER_DATA = 2021;

    public const int MQCA_USER_LIST = 4000;

    public const int MQCA_VERSION = 2120;

    public const int MQCA_XCF_GROUP_NAME = 2043;

    public const int MQCA_XCF_MEMBER_NAME = 2044;

    public const int MQCA_XMIT_Q_NAME = 2024;

    public const int MQCA_XR_SSL_CIPHER_SUITES = 2123;

    public const int MQCA_XR_VERSION = 2122;

    public const int MQIA_ACCOUNTING_CONN_OVERRIDE = 136;

    public const int MQIA_ACCOUNTING_INTERVAL = 135;

    public const int MQIA_ACCOUNTING_MQI = 133;

    public const int MQIA_ACCOUNTING_Q = 134;

    public const int MQIA_ACTIVE_CHANNELS = 100;

    public const int MQIA_ACTIVITY_CONN_OVERRIDE = 239;

    public const int MQIA_ACTIVITY_RECORDING = 138;

    public const int MQIA_ACTIVITY_TRACE = 240;

    public const int MQIA_ADOPTNEWMCA_CHECK = 102;

    public const int MQIA_ADOPTNEWMCA_INTERVAL = 104;

    public const int MQIA_ADOPTNEWMCA_TYPE = 103;

    public const int MQIA_ADOPT_CONTEXT = 260;

    public const int MQIA_AMQP_CAPABILITY = 265;

    public const int MQIA_APPL_TYPE = 1;

    public const int MQIA_ARCHIVE = 60;

    public const int MQIA_AUTHENTICATION_FAIL_DELAY = 259;

    public const int MQIA_AUTHENTICATION_METHOD = 266;

    public const int MQIA_AUTHORITY_EVENT = 47;

    public const int MQIA_AUTH_INFO_TYPE = 66;

    public const int MQIA_AUTO_REORGANIZATION = 173;

    public const int MQIA_AUTO_REORG_INTERVAL = 174;

    public const int MQIA_BACKOUT_THRESHOLD = 22;

    public const int MQIA_BASE_TYPE = 193;

    public const int MQIA_BATCH_INTERFACE_AUTO = 86;

    public const int MQIA_BRIDGE_EVENT = 74;

    public const int MQIA_CERT_VAL_POLICY = 252;

    public const int MQIA_CF_CFCONLOS = 246;

    public const int MQIA_CF_LEVEL = 70;

    public const int MQIA_CF_OFFLDUSE = 229;

    public const int MQIA_CF_OFFLOAD = 224;

    public const int MQIA_CF_OFFLOAD_THRESHOLD1 = 225;

    public const int MQIA_CF_OFFLOAD_THRESHOLD2 = 226;

    public const int MQIA_CF_OFFLOAD_THRESHOLD3 = 227;

    public const int MQIA_CF_RECAUTO = 244;

    public const int MQIA_CF_RECOVER = 71;

    public const int MQIA_CF_SMDS_BUFFERS = 228;

    public const int MQIA_CHANNEL_AUTO_DEF = 55;

    public const int MQIA_CHANNEL_AUTO_DEF_EVENT = 56;

    public const int MQIA_CHANNEL_EVENT = 73;

    public const int MQIA_CHECK_CLIENT_BINDING = 258;

    public const int MQIA_CHECK_LOCAL_BINDING = 257;

    public const int MQIA_CHINIT_ADAPTERS = 101;

    public const int MQIA_CHINIT_CONTROL = 119;

    public const int MQIA_CHINIT_DISPATCHERS = 105;

    public const int MQIA_CHINIT_TRACE_AUTO_START = 117;

    public const int MQIA_CHINIT_TRACE_TABLE_SIZE = 118;

    public const int MQIA_CHLAUTH_RECORDS = 248;

    public const int MQIA_CLUSTER_OBJECT_STATE = 256;

    public const int MQIA_CLUSTER_PUB_ROUTE = 255;

    public const int MQIA_CLUSTER_Q_TYPE = 59;

    public const int MQIA_CLUSTER_WORKLOAD_LENGTH = 58;

    public const int MQIA_CLWL_MRU_CHANNELS = 97;

    public const int MQIA_CLWL_Q_PRIORITY = 96;

    public const int MQIA_CLWL_Q_RANK = 95;

    public const int MQIA_CLWL_USEQ = 98;

    public const int MQIA_CMD_SERVER_AUTO = 87;

    public const int MQIA_CMD_SERVER_CONTROL = 120;

    public const int MQIA_CMD_SERVER_CONVERT_MSG = 88;

    public const int MQIA_CMD_SERVER_DLQ_MSG = 89;

    public const int MQIA_CODED_CHAR_SET_ID = 2;

    public const int MQIA_COMMAND_EVENT = 99;

    public const int MQIA_COMMAND_LEVEL = 31;

    public const int MQIA_COMM_EVENT = 232;

    public const int MQIA_COMM_INFO_TYPE = 223;

    public const int MQIA_CONFIGURATION_EVENT = 51;

    public const int MQIA_CPI_LEVEL = 27;

    public const int MQIA_CURRENT_Q_DEPTH = 3;

    public const int MQIA_DEFINITION_TYPE = 7;

    public const int MQIA_DEF_BIND = 61;

    public const int MQIA_DEF_CLUSTER_XMIT_Q_TYPE = 250;

    public const int MQIA_DEF_INPUT_OPEN_OPTION = 4;

    public const int MQIA_DEF_PERSISTENCE = 5;

    public const int MQIA_DEF_PRIORITY = 6;

    public const int MQIA_DEF_PUT_RESPONSE_TYPE = 184;

    public const int MQIA_DEF_READ_AHEAD = 188;

    public const int MQIA_DISPLAY_TYPE = 262;

    public const int MQIA_DIST_LISTS = 34;

    public const int MQIA_DNS_WLM = 106;

    public const int MQIA_DURABLE_SUB = 175;

    public const int MQIA_ENCRYPTION_ALGORITHM = 237;

    public const int MQIA_EXPIRY_INTERVAL = 39;

    public const int MQIA_FIRST = 1;

    public const int MQIA_GROUP_UR = 221;

    public const int MQIA_HARDEN_GET_BACKOUT = 8;

    public const int MQIA_HIGH_Q_DEPTH = 36;

    public const int MQIA_IGQ_PUT_AUTHORITY = 65;

    public const int MQIA_INDEX_TYPE = 57;

    public const int MQIA_INHIBIT_EVENT = 48;

    public const int MQIA_INHIBIT_GET = 9;

    public const int MQIA_INHIBIT_PUB = 181;

    public const int MQIA_INHIBIT_PUT = 10;

    public const int MQIA_INHIBIT_SUB = 182;

    public const int MQIA_INTRA_GROUP_QUEUING = 64;

    public const int MQIA_IP_ADDRESS_VERSION = 93;

    public const int MQIA_LAST = 2000;

    public const int MQIA_LAST_USED = 266;

    public const int MQIA_LDAP_AUTHORMD = 263;

    public const int MQIA_LDAP_NESTGRP = 264;

    public const int MQIA_LDAP_SECURE_COMM = 261;

    public const int MQIA_LISTENER_PORT_NUMBER = 85;

    public const int MQIA_LISTENER_TIMER = 107;

    public const int MQIA_LOCAL_EVENT = 49;

    public const int MQIA_LOGGER_EVENT = 94;

    public const int MQIA_LU62_CHANNELS = 108;

    public const int MQIA_MASTER_ADMIN = 186;

    public const int MQIA_MAX_CHANNELS = 109;

    public const int MQIA_MAX_CLIENTS = 172;

    public const int MQIA_MAX_GLOBAL_LOCKS = 83;

    public const int MQIA_MAX_HANDLES = 11;

    public const int MQIA_MAX_LOCAL_LOCKS = 84;

    public const int MQIA_MAX_MSG_LENGTH = 13;

    public const int MQIA_MAX_OPEN_Q = 80;

    public const int MQIA_MAX_PRIORITY = 14;

    public const int MQIA_MAX_PROPERTIES_LENGTH = 192;

    public const int MQIA_MAX_Q_DEPTH = 15;

    public const int MQIA_MAX_Q_TRIGGERS = 90;

    public const int MQIA_MAX_RECOVERY_TASKS = 171;

    public const int MQIA_MAX_RESPONSES = 230;

    public const int MQIA_MAX_UNCOMMITTED_MSGS = 33;

    public const int MQIA_MCAST_BRIDGE = 233;

    public const int MQIA_MONITORING_AUTO_CLUSSDR = 124;

    public const int MQIA_MONITORING_CHANNEL = 122;

    public const int MQIA_MONITORING_Q = 123;

    public const int MQIA_MONITOR_INTERVAL = 81;

    public const int MQIA_MSG_DELIVERY_SEQUENCE = 16;

    public const int MQIA_MSG_DEQ_COUNT = 38;

    public const int MQIA_MSG_ENQ_COUNT = 37;

    public const int MQIA_MSG_MARK_BROWSE_INTERVAL = 68;

    public const int MQIA_MULTICAST = 176;

    public const int MQIA_NAMELIST_TYPE = 72;

    public const int MQIA_NAME_COUNT = 19;

    public const int MQIA_NPM_CLASS = 78;

    public const int MQIA_NPM_DELIVERY = 196;

    public const int MQIA_OPEN_INPUT_COUNT = 17;

    public const int MQIA_OPEN_OUTPUT_COUNT = 18;

    public const int MQIA_OUTBOUND_PORT_MAX = 140;

    public const int MQIA_OUTBOUND_PORT_MIN = 110;

    public const int MQIA_PAGESET_ID = 62;

    public const int MQIA_PERFORMANCE_EVENT = 53;

    public const int MQIA_PLATFORM = 32;

    public const int MQIA_PM_DELIVERY = 195;

    public const int MQIA_POLICY_VERSION = 238;

    public const int MQIA_PROPERTY_CONTROL = 190;

    public const int MQIA_PROT_POLICY_CAPABILITY = 251;

    public const int MQIA_PROXY_SUB = 199;

    public const int MQIA_PUBSUB_CLUSTER = 249;

    public const int MQIA_PUBSUB_MAXMSG_RETRY_COUNT = 206;

    public const int MQIA_PUBSUB_MODE = 187;

    public const int MQIA_PUBSUB_NP_MSG = 203;

    public const int MQIA_PUBSUB_NP_RESP = 205;

    public const int MQIA_PUBSUB_SYNC_PT = 207;

    public const int MQIA_PUB_COUNT = 215;

    public const int MQIA_PUB_SCOPE = 219;

    public const int MQIA_QMGR_CFCONLOS = 245;

    public const int MQIA_QMOPT_CONS_COMMS_MSGS = 155;

    public const int MQIA_QMOPT_CONS_CRITICAL_MSGS = 154;

    public const int MQIA_QMOPT_CONS_ERROR_MSGS = 153;

    public const int MQIA_QMOPT_CONS_INFO_MSGS = 151;

    public const int MQIA_QMOPT_CONS_REORG_MSGS = 156;

    public const int MQIA_QMOPT_CONS_SYSTEM_MSGS = 157;

    public const int MQIA_QMOPT_CONS_WARNING_MSGS = 152;

    public const int MQIA_QMOPT_CSMT_ON_ERROR = 150;

    public const int MQIA_QMOPT_INTERNAL_DUMP = 170;

    public const int MQIA_QMOPT_LOG_COMMS_MSGS = 162;

    public const int MQIA_QMOPT_LOG_CRITICAL_MSGS = 161;

    public const int MQIA_QMOPT_LOG_ERROR_MSGS = 160;

    public const int MQIA_QMOPT_LOG_INFO_MSGS = 158;

    public const int MQIA_QMOPT_LOG_REORG_MSGS = 163;

    public const int MQIA_QMOPT_LOG_SYSTEM_MSGS = 164;

    public const int MQIA_QMOPT_LOG_WARNING_MSGS = 159;

    public const int MQIA_QMOPT_TRACE_COMMS = 166;

    public const int MQIA_QMOPT_TRACE_CONVERSION = 168;

    public const int MQIA_QMOPT_TRACE_MQI_CALLS = 165;

    public const int MQIA_QMOPT_TRACE_REORG = 167;

    public const int MQIA_QMOPT_TRACE_SYSTEM = 169;

    public const int MQIA_QSG_DISP = 63;

    public const int MQIA_Q_DEPTH_HIGH_EVENT = 43;

    public const int MQIA_Q_DEPTH_HIGH_LIMIT = 40;

    public const int MQIA_Q_DEPTH_LOW_EVENT = 44;

    public const int MQIA_Q_DEPTH_LOW_LIMIT = 41;

    public const int MQIA_Q_DEPTH_MAX_EVENT = 42;

    public const int MQIA_Q_SERVICE_INTERVAL = 54;

    public const int MQIA_Q_SERVICE_INTERVAL_EVENT = 46;

    public const int MQIA_Q_TYPE = 20;

    public const int MQIA_Q_USERS = 82;

    public const int MQIA_READ_AHEAD = 189;

    public const int MQIA_RECEIVE_TIMEOUT = 111;

    public const int MQIA_RECEIVE_TIMEOUT_MIN = 113;

    public const int MQIA_RECEIVE_TIMEOUT_TYPE = 112;

    public const int MQIA_REMOTE_EVENT = 50;

    public const int MQIA_RESPONSE_RESTART_POINT = 231;

    public const int MQIA_RETENTION_INTERVAL = 21;

    public const int MQIA_REVERSE_DNS_LOOKUP = 254;

    public const int MQIA_SCOPE = 45;

    public const int MQIA_SECURITY_CASE = 141;

    public const int MQIA_SERVICE_CONTROL = 139;

    public const int MQIA_SERVICE_TYPE = 121;

    public const int MQIA_SHAREABILITY = 23;

    public const int MQIA_SHARED_Q_Q_MGR_NAME = 77;

    public const int MQIA_SIGNATURE_ALGORITHM = 236;

    public const int MQIA_SSL_EVENT = 75;

    public const int MQIA_SSL_FIPS_REQUIRED = 92;

    public const int MQIA_SSL_RESET_COUNT = 76;

    public const int MQIA_SSL_TASKS = 69;

    public const int MQIA_START_STOP_EVENT = 52;

    public const int MQIA_STATISTICS_AUTO_CLUSSDR = 130;

    public const int MQIA_STATISTICS_CHANNEL = 129;

    public const int MQIA_STATISTICS_INTERVAL = 131;

    public const int MQIA_STATISTICS_MQI = 127;

    public const int MQIA_STATISTICS_Q = 128;

    public const int MQIA_SUB_CONFIGURATION_EVENT = 242;

    public const int MQIA_SUB_COUNT = 204;

    public const int MQIA_SUB_SCOPE = 218;

    public const int MQIA_SUITE_B_STRENGTH = 247;

    public const int MQIA_SYNCPOINT = 30;

    public const int MQIA_TCP_CHANNELS = 114;

    public const int MQIA_TCP_KEEP_ALIVE = 115;

    public const int MQIA_TCP_STACK_TYPE = 116;

    public const int MQIA_TIME_SINCE_RESET = 35;

    public const int MQIA_TOLERATE_UNPROTECTED = 235;

    public const int MQIA_TOPIC_DEF_PERSISTENCE = 185;

    public const int MQIA_TOPIC_NODE_COUNT = 253;

    public const int MQIA_TOPIC_TYPE = 208;

    public const int MQIA_TRACE_ROUTE_RECORDING = 137;

    public const int MQIA_TREE_LIFE_TIME = 183;

    public const int MQIA_TRIGGER_CONTROL = 24;

    public const int MQIA_TRIGGER_DEPTH = 29;

    public const int MQIA_TRIGGER_INTERVAL = 25;

    public const int MQIA_TRIGGER_MSG_PRIORITY = 26;

    public const int MQIA_TRIGGER_RESTART = 91;

    public const int MQIA_TRIGGER_TYPE = 28;

    public const int MQIA_UR_DISP = 222;

    public const int MQIA_USAGE = 12;

    public const int MQIA_USER_LIST = 2000;

    public const int MQIA_USE_DEAD_LETTER_Q = 234;

    public const int MQIA_WILDCARD_OPERATION = 216;

    public const int MQIA_XR_CAPABILITY = 243;

    public const int MQIAV_NOT_APPLICABLE = -1;

    public const int MQIAV_UNDEFINED = -2;

    public const int MQMCB_DISABLED = 0;

    public const int MQMCB_ENABLED = 1;

    public const int MQGA_FIRST = 8001;

    public const int MQGA_LAST = 9000;

    public const int MQOO_BIND_AS_Q_DEF = 0;

    public const int MQOO_READ_AHEAD_AS_Q_DEF = 0;

    public const int MQOO_INPUT_AS_Q_DEF = 1;

    public const int MQOO_INPUT_SHARED = 2;

    public const int MQOO_INPUT_EXCLUSIVE = 4;

    public const int MQOO_BROWSE = 8;

    public const int MQOO_OUTPUT = 16;

    public const int MQOO_INQUIRE = 32;

    public const int MQOO_SET = 64;

    public const int MQOO_SAVE_ALL_CONTEXT = 128;

    public const int MQOO_PASS_IDENTITY_CONTEXT = 256;

    public const int MQOO_PASS_ALL_CONTEXT = 512;

    public const int MQOO_SET_IDENTITY_CONTEXT = 1024;

    public const int MQOO_SET_ALL_CONTEXT = 2048;

    public const int MQOO_ALTERNATE_USER_AUTHORITY = 4096;

    public const int MQOO_FAIL_IF_QUIESCING = 8192;

    public const int MQOO_BIND_ON_OPEN = 16384;

    public const int MQOO_BIND_ON_GROUP = 4194304;

    public const int MQOO_BIND_NOT_FIXED = 32768;

    public const int MQOO_CO_OP = 131072;

    public const int MQOO_NO_READ_AHEAD = 524288;

    public const int MQOO_READ_AHEAD = 1048576;

    public const int MQOO_NO_MULTICAST = 2097152;

    public const int MQOO_RESOLVE_LOCAL_Q = 262144;

    public const int MQOO_RESOLVE_LOCAL_TOPIC = 262144;

    public const int MQOO_RESOLVE_NAMES = 65536;

    public const int MQTYPE_AS_SET = 0;

    public const int MQTYPE_NULL = 2;

    public const int MQTYPE_BOOLEAN = 4;

    public const int MQTYPE_BYTE_STRING = 8;

    public const int MQTYPE_INT8 = 16;

    public const int MQTYPE_INT16 = 32;

    public const int MQTYPE_INT32 = 64;

    public const int MQTYPE_LONG = 64;

    public const int MQTYPE_INT64 = 128;

    public const int MQTYPE_FLOAT32 = 256;

    public const int MQTYPE_FLOAT64 = 512;

    public const int MQTYPE_STRING = 1024;

    public const int MQVL_NULL_TERMINATED = -1;

    public const int MQVL_EMPTY_STRING = 0;

    public const int MQSTAT_TYPE_ASYNC_ERROR = 0;

    public const int MQSTAT_TYPE_RECONNECTION = 1;

    public const int MQSTAT_TYPE_RECONNECTION_ERROR = 2;

    public const int MQSO_NONE = 0;

    public const int MQSO_NON_DURABLE = 0;

    public const int MQSO_READ_AHEAD_AS_Q_DEF = 0;

    public const int MQSO_ALTER = 1;

    public const int MQSO_CREATE = 2;

    public const int MQSO_RESUME = 4;

    public const int MQSO_DURABLE = 8;

    public const int MQSO_GROUP_SUB = 16;

    public const int MQSO_MANAGED = 32;

    public const int MQSO_SET_IDENTITY_CONTEXT = 64;

    public const int MQSO_NO_MULTICAST = 128;

    public const int MQSO_FIXED_USERID = 256;

    public const int MQSO_ANY_USERID = 512;

    public const int MQSO_PUBLICATIONS_ON_REQUEST = 2048;

    public const int MQSO_NEW_PUBLICATIONS_ONLY = 4096;

    public const int MQSO_FAIL_IF_QUIESCING = 8192;

    public const int MQSO_ALTERNATE_USER_AUTHORITY = 262144;

    public const int MQSO_WILDCARD_CHAR = 1048576;

    public const int MQSO_WILDCARD_TOPIC = 2097152;

    public const int MQSO_SET_CORREL_ID = 4194304;

    public const int MQSO_SCOPE_QMGR = 67108864;

    public const int MQSO_NO_READ_AHEAD = 134217728;

    public const int MQSO_READ_AHEAD = 268435456;

    public const int MQSR_ACTION_PUBLICATION = 1;

    public const int MQ_MQTT_MAX_KEEP_ALIVE = 65536;

    public const int MQ_SSL_KEY_PASSPHRASE_LENGTH = 1024;

    public const int MQCD_VERSION_1 = 1;

    public const int MQCD_VERSION_2 = 2;

    public const int MQCD_VERSION_3 = 3;

    public const int MQCD_VERSION_4 = 4;

    public const int MQCD_VERSION_5 = 5;

    public const int MQCD_VERSION_6 = 6;

    public const int MQCD_VERSION_7 = 7;

    public const int MQCD_VERSION_8 = 8;

    public const int MQCD_VERSION_9 = 9;

    public const int MQCD_VERSION_10 = 10;

    public const int MQCD_VERSION_11 = 11;

    public const int MQCD_CURRENT_VERSION = 11;

    public const int MQCD_LENGTH_1 = 984;

    public const int MQCD_LENGTH_2 = 1312;

    public const int MQCD_LENGTH_3 = 1480;

    public const int MQCD_LENGTH_4 = 1540;

    public const int MQCD_LENGTH_5 = 1552;

    public const int MQCD_LENGTH_6 = 1648;

    public const int MQCD_LENGTH_7 = 1748;

    public const int MQCD_LENGTH_8 = 1840;

    public const int MQCD_LENGTH_9 = 1864;

    public const int MQCD_LENGTH_10 = 1876;

    public const int MQCD_LENGTH_11 = 1940;

    public const int MQCD_CURRENT_LENGTH = 1940;

    public const int MQCHT_SENDER = 1;

    public const int MQCHT_SERVER = 2;

    public const int MQCHT_RECEIVER = 3;

    public const int MQCHT_REQUESTER = 4;

    public const int MQCHT_ALL = 5;

    public const int MQCHT_CLNTCONN = 6;

    public const int MQCHT_SVRCONN = 7;

    public const int MQCHT_CLUSRCVR = 8;

    public const int MQCHT_CLUSSDR = 9;

    public const int MQCHT_MQTT = 10;

    public const int MQCHT_AMQP = 11;

    public const int MQCOMPRESS_NOT_AVAILABLE = -1;

    public const int MQCOMPRESS_NONE = 0;

    public const int MQCOMPRESS_RLE = 1;

    public const int MQCOMPRESS_ZLIBFAST = 2;

    public const int MQCOMPRESS_ZLIBHIGH = 4;

    public const int MQCOMPRESS_SYSTEM = 8;

    public const int MQCOMPRESS_ANY = 268435455;

    public const int MQXPT_ALL = -1;

    public const int MQXPT_LOCAL = 0;

    public const int MQXPT_LU62 = 1;

    public const int MQXPT_TCP = 2;

    public const int MQXPT_NETBIOS = 3;

    public const int MQXPT_SPX = 4;

    public const int MQXPT_DECNET = 5;

    public const int MQXPT_UDP = 6;

    public const int MQPA_DEFAULT = 1;

    public const int MQPA_CONTEXT = 2;

    public const int MQPA_ONLY_MCA = 3;

    public const int MQPA_ALTERNATE_OR_MCA = 4;

    public const int MQCDC_SENDER_CONVERSION = 1;

    public const int MQCDC_NO_SENDER_CONVERSION = 0;

    public const int MQMCAT_PROCESS = 1;

    public const int MQMCAT_THREAD = 2;

    public const int MQNPMS_NORMAL = 1;

    public const int MQNPMS_FAST = 2;

    public const int MQSCA_REQUIRED = 0;

    public const int MQSCA_OPTIONAL = 1;

    public const int MQSCA_NEVER_REQUIRED = 2;

    public const int MQKAI_AUTO = -1;

    public const int MQCAFTY_NONE = 0;

    public const int MQCAFTY_PREFERRED = 1;

    public const int MQRCN_NO = 0;

    public const int MQRCN_YES = 1;

    public const int MQRCN_Q_MGR = 2;

    public const int MQRCN_DISABLED = 3;

    public const int MQPROTO_MQTTV3 = 1;

    public const int MQPROTO_HTTP = 2;

    public const int MQPROTO_AMQP = 3;

    public const int MQPROTO_MQTTV311 = 4;

    public const int MQSECPROT_NONE = 0;

    public const int MQSECPROT_SSLV30 = 1;

    public const int MQSECPROT_TLSV10 = 2;

    public const int MQSECPROT_TLSV12 = 4;

    public const string MQACH_STRUC_ID = "ACH ";

    public const int MQACH_VERSION_1 = 1;

    public const int MQACH_CURRENT_VERSION = 1;

    public const int MQACH_LENGTH_1 = 68;

    public const int MQACH_CURRENT_LENGTH = 68;

    public const string MQAXC_STRUC_ID = "AXC ";

    public const int MQAXC_VERSION_1 = 1;

    public const int MQAXC_VERSION_2 = 2;

    public const int MQAXC_CURRENT_VERSION = 2;

    public const int MQAXC_LENGTH_1 = 384;

    public const int MQAXC_LENGTH_2 = 412;

    public const int MQAXC_CURRENT_LENGTH = 412;

    public const int MQXE_OTHER = 0;

    public const int MQXE_MCA = 1;

    public const int MQXE_MCA_SVRCONN = 2;

    public const int MQXE_COMMAND_SERVER = 3;

    public const int MQXE_MQSC = 4;

    public const int MQXE_MCA_CLNTCONN = 5;

    public const string MQAXP_STRUC_ID = "AXP ";

    public const int MQAXP_VERSION_1 = 1;

    public const int MQAXP_VERSION_2 = 2;

    public const int MQAXP_CURRENT_VERSION = 2;

    public const int MQAXP_LENGTH_1 = 244;

    public const int MQAXP_CURRENT_LENGTH = 244;

    public const int MQXACT_EXTERNAL = 1;

    public const int MQXACT_INTERNAL = 2;

    public const int MQXF_INIT = 1;

    public const int MQXF_TERM = 2;

    public const int MQXF_CONN = 3;

    public const int MQXF_CONNX = 4;

    public const int MQXF_DISC = 5;

    public const int MQXF_OPEN = 6;

    public const int MQXF_CLOSE = 7;

    public const int MQXF_PUT1 = 8;

    public const int MQXF_PUT = 9;

    public const int MQXF_GET = 10;

    public const int MQXF_DATA_CONV_ON_GET = 11;

    public const int MQXF_INQ = 12;

    public const int MQXF_SET = 13;

    public const int MQXF_BEGIN = 14;

    public const int MQXF_CMIT = 15;

    public const int MQXF_BACK = 16;

    public const int MQXF_STAT = 18;

    public const int MQXF_CB = 19;

    public const int MQXF_CTL = 20;

    public const int MQXF_CALLBACK = 21;

    public const int MQXF_SUB = 22;

    public const int MQXF_SUBRQ = 23;

    public const int MQXF_XACLOSE = 24;

    public const int MQXF_XACOMMIT = 25;

    public const int MQXF_XACOMPLETE = 26;

    public const int MQXF_XAEND = 27;

    public const int MQXF_XAFORGET = 28;

    public const int MQXF_XAOPEN = 29;

    public const int MQXF_XAPREPARE = 30;

    public const int MQXF_XARECOVER = 31;

    public const int MQXF_XAROLLBACK = 32;

    public const int MQXF_XASTART = 33;

    public const int MQXF_AXREG = 34;

    public const int MQXF_AXUNREG = 35;

    public const string MQCXP_STRUC_ID = "CXP ";

    public const int MQCXP_VERSION_1 = 1;

    public const int MQCXP_VERSION_2 = 2;

    public const int MQCXP_VERSION_3 = 3;

    public const int MQCXP_VERSION_4 = 4;

    public const int MQCXP_VERSION_5 = 5;

    public const int MQCXP_VERSION_6 = 6;

    public const int MQCXP_VERSION_7 = 7;

    public const int MQCXP_VERSION_8 = 8;

    public const int MQCXP_VERSION_9 = 9;

    public const int MQCXP_CURRENT_VERSION = 9;

    public const int MQCXP_LENGTH_3 = 156;

    public const int MQCXP_LENGTH_4 = 156;

    public const int MQCXP_LENGTH_5 = 160;

    public const int MQCXP_LENGTH_6 = 192;

    public const int MQCXP_LENGTH_7 = 200;

    public const int MQCXP_LENGTH_8 = 208;

    public const int MQCXP_LENGTH_9 = 220;

    public const int MQCXP_CURRENT_LENGTH = 220;

    public const int MQXR2_PUT_WITH_DEF_ACTION = 0;

    public const int MQXR2_PUT_WITH_DEF_USERID = 1;

    public const int MQXR2_PUT_WITH_MSG_USERID = 2;

    public const int MQXR2_USE_AGENT_BUFFER = 0;

    public const int MQXR2_USE_EXIT_BUFFER = 4;

    public const int MQXR2_DEFAULT_CONTINUATION = 0;

    public const int MQXR2_CONTINUE_CHAIN = 8;

    public const int MQXR2_SUPPRESS_CHAIN = 16;

    public const int MQXR2_STATIC_CACHE = 0;

    public const int MQXR2_DYNAMIC_CACHE = 32;

    public const int MQCF_NONE = 0;

    public const int MQCF_DIST_LISTS = 1;

    public const string MQDXP_STRUC_ID = "DXP ";

    public const int MQDXP_VERSION_1 = 1;

    public const int MQDXP_VERSION_2 = 2;

    public const int MQDXP_CURRENT_VERSION = 2;

    public const int MQDXP_LENGTH_1 = 44;

    public const int MQDXP_LENGTH_2 = 48;

    public const int MQDXP_CURRENT_LENGTH = 48;

    public const int MQXDR_OK = 0;

    public const int MQXDR_CONVERSION_FAILED = 1;

    public const string MQPBC_STRUC_ID = "PBC ";

    public const int MQPBC_VERSION_1 = 1;

    public const int MQPBC_VERSION_2 = 2;

    public const int MQPBC_CURRENT_VERSION = 2;

    public const int MQPBC_LENGTH_1 = 28;

    public const int MQPBC_LENGTH_2 = 32;

    public const int MQPBC_CURRENT_LENGTH = 32;

    public const string MQPSXP_STRUC_ID = "PSXP";

    public const int MQPSXP_VERSION_1 = 1;

    public const int MQPSXP_VERSION_2 = 2;

    public const int MQPSXP_CURRENT_VERSION = 2;

    public const int MQPSXP_LENGTH_1 = 156;

    public const int MQPSXP_LENGTH_2 = 160;

    public const int MQPSXP_CURRENT_LENGTH = 160;

    public const string MQSBC_STRUC_ID = "SBC ";

    public const int MQSBC_VERSION_1 = 1;

    public const int MQSBC_CURRENT_VERSION = 1;

    public const int MQSBC_LENGTH_1 = 272;

    public const int MQSBC_CURRENT_LENGTH = 272;

    public const int MQWQR3_LENGTH_1 = 200;

    public const int MQWQR3_LENGTH_2 = 208;

    public const int MQWQR3_LENGTH_3 = 212;

    public const int MQWQR3_CURRENT_LENGTH = 212;

    public const string MQXEPO_STRUC_ID = "XEPO";

    public const int MQXEPO_VERSION_1 = 1;

    public const int MQXEPO_CURRENT_VERSION = 1;

    public const int MQXEPO_LENGTH_1 = 32;

    public const int MQXEPO_CURRENT_LENGTH = 32;

    public const int MQXEPO_NONE = 0;

    public const int MQXT_API_CROSSING_EXIT = 1;

    public const int MQXT_API_EXIT = 2;

    public const int MQXT_CHANNEL_SEC_EXIT = 11;

    public const int MQXT_CHANNEL_MSG_EXIT = 12;

    public const int MQXT_CHANNEL_SEND_EXIT = 13;

    public const int MQXT_CHANNEL_RCV_EXIT = 14;

    public const int MQXT_CHANNEL_MSG_RETRY_EXIT = 15;

    public const int MQXT_CHANNEL_AUTO_DEF_EXIT = 16;

    public const int MQXT_CLUSTER_WORKLOAD_EXIT = 20;

    public const int MQXT_PUBSUB_ROUTING_EXIT = 21;

    public const int MQXT_PUBLISH_EXIT = 22;

    public const int MQXT_PRECONNECT_EXIT = 23;

    public const int MQXR_BEFORE = 1;

    public const int MQXR_AFTER = 2;

    public const int MQXR_CONNECTION = 3;

    public const int MQXR_BEFORE_CONVERT = 4;

    public const int MQXR_INIT = 11;

    public const int MQXR_TERM = 12;

    public const int MQXR_MSG = 13;

    public const int MQXR_XMIT = 14;

    public const int MQXR_SEC_MSG = 15;

    public const int MQXR_INIT_SEC = 16;

    public const int MQXR_RETRY = 17;

    public const int MQXR_AUTO_CLUSSDR = 18;

    public const int MQXR_AUTO_RECEIVER = 19;

    public const int MQXR_CLWL_OPEN = 20;

    public const int MQXR_CLWL_PUT = 21;

    public const int MQXR_CLWL_MOVE = 22;

    public const int MQXR_CLWL_REPOS = 23;

    public const int MQXR_CLWL_REPOS_MOVE = 24;

    public const int MQXR_END_BATCH = 25;

    public const int MQXR_ACK_RECEIVED = 26;

    public const int MQXR_AUTO_SVRCONN = 27;

    public const int MQXR_AUTO_CLUSRCVR = 28;

    public const int MQXR_SEC_PARMS = 29;

    public const int MQXR_PUBLICATION = 30;

    public const int MQXR_PRECONNECT = 31;

    public const int MQXCC_OK = 0;

    public const int MQXCC_SUPPRESS_FUNCTION = -1;

    public const int MQXCC_SKIP_FUNCTION = -2;

    public const int MQXCC_SEND_AND_REQUEST_SEC_MSG = -3;

    public const int MQXCC_SEND_SEC_MSG = -4;

    public const int MQXCC_SUPPRESS_EXIT = -5;

    public const int MQXCC_CLOSE_CHANNEL = -6;

    public const int MQXCC_REQUEST_ACK = -7;

    public const int MQXCC_FAILED = -8;

    public const int MQCLCT_STATIC = 0;

    public const int MQCLCT_DYNAMIC = 1;

    public const int MQMCEV_PACKET_LOSS = 1;

    public const int MQMCEV_HEARTBEAT_TIMEOUT = 2;

    public const int MQMCEV_VERSION_CONFLICT = 3;

    public const int MQMCEV_RELIABILITY = 4;

    public const int MQMCEV_CLOSED_TRANS = 5;

    public const int MQMCEV_STREAM_ERROR = 6;

    public const int MQMCEV_NEW_SOURCE = 10;

    public const int MQMCEV_RECEIVE_QUEUE_TRIMMED = 11;

    public const int MQMCEV_PACKET_LOSS_NACK_EXPIRE = 12;

    public const int MQMCEV_ACK_RETRIES_EXCEEDED = 13;

    public const int MQMCEV_STREAM_SUSPEND_NACK = 14;

    public const int MQMCEV_STREAM_RESUME_NACK = 15;

    public const int MQMCEV_STREAM_EXPELLED = 16;

    public const int MQMCEV_FIRST_MESSAGE = 20;

    public const int MQMCEV_LATE_JOIN_FAILURE = 21;

    public const int MQMCEV_MESSAGE_LOSS = 22;

    public const int MQMCEV_SEND_PACKET_FAILURE = 23;

    public const int MQMCEV_REPAIR_DELAY = 24;

    public const int MQMCEV_MEMORY_ALERT_ON = 25;

    public const int MQMCEV_MEMORY_ALERT_OFF = 26;

    public const int MQMCEV_NACK_ALERT_ON = 27;

    public const int MQMCEV_NACK_ALERT_OFF = 28;

    public const int MQMCEV_REPAIR_ALERT_ON = 29;

    public const int MQMCEV_REPAIR_ALERT_OFF = 30;

    public const int MQMCEV_RELIABILITY_CHANGED = 31;

    public const int MQMCEV_SHM_DEST_UNUSABLE = 80;

    public const int MQMCEV_SHM_PORT_UNUSABLE = 81;

    public const int MQMCEV_CCT_GETTIME_FAILED = 110;

    public const int MQMCEV_DEST_INTERFACE_FAILURE = 120;

    public const int MQMCEV_DEST_INTERFACE_FAILOVER = 121;

    public const int MQMCEV_PORT_INTERFACE_FAILURE = 122;

    public const int MQMCEV_PORT_INTERFACE_FAILOVER = 123;

    public const string MQTRANSPORTEXIT = "MQ_TRANSPORT_EXIT";

    public const int MQDCC_DEFAULT_CONVERSION = 1;

    public const int MQDCC_FILL_TARGET_BUFFER = 2;

    public const int MQDCC_INT_DEFAULT_CONVERSION = 4;

    public const int MQDCC_SOURCE_ENC_NATIVE = 32;

    public const int MQDCC_SOURCE_ENC_NORMAL = 16;

    public const int MQDCC_SOURCE_ENC_REVERSED = 32;

    public const int MQDCC_SOURCE_ENC_UNDEFINED = 0;

    public const int MQDCC_TARGET_ENC_NATIVE = 512;

    public const int MQDCC_TARGET_ENC_NORMAL = 256;

    public const int MQDCC_TARGET_ENC_REVERSED = 512;

    public const int MQDCC_TARGET_ENC_UNDEFINED = 0;

    public const int MQDCC_NONE = 0;

    public const int MQDCC_SOURCE_ENC_MASK = 240;

    public const int MQDCC_TARGET_ENC_MASK = 3840;

    public const int MQDCC_SOURCE_ENC_FACTOR = 16;

    public const int MQDCC_TARGET_ENC_FACTOR = 256;

    public const int MQCFH_STRUC_LENGTH = 36;

    public const int MQCFH_VERSION_1 = 1;

    public const int MQCFH_VERSION_2 = 2;

    public const int MQCFH_VERSION_3 = 3;

    public const int MQCFH_CURRENT_VERSION = 3;

    public const int MQCMD_NONE = 0;

    public const int MQCMD_CHANGE_Q_MGR = 1;

    public const int MQCMD_INQUIRE_Q_MGR = 2;

    public const int MQCMD_CHANGE_PROCESS = 3;

    public const int MQCMD_COPY_PROCESS = 4;

    public const int MQCMD_CREATE_PROCESS = 5;

    public const int MQCMD_DELETE_PROCESS = 6;

    public const int MQCMD_INQUIRE_PROCESS = 7;

    public const int MQCMD_CHANGE_Q = 8;

    public const int MQCMD_CLEAR_Q = 9;

    public const int MQCMD_COPY_Q = 10;

    public const int MQCMD_CREATE_Q = 11;

    public const int MQCMD_DELETE_Q = 12;

    public const int MQCMD_INQUIRE_Q = 13;

    public const int MQCMD_REFRESH_Q_MGR = 16;

    public const int MQCMD_RESET_Q_STATS = 17;

    public const int MQCMD_INQUIRE_Q_NAMES = 18;

    public const int MQCMD_INQUIRE_PROCESS_NAMES = 19;

    public const int MQCMD_INQUIRE_CHANNEL_NAMES = 20;

    public const int MQCMD_CHANGE_CHANNEL = 21;

    public const int MQCMD_COPY_CHANNEL = 22;

    public const int MQCMD_CREATE_CHANNEL = 23;

    public const int MQCMD_DELETE_CHANNEL = 24;

    public const int MQCMD_INQUIRE_CHANNEL = 25;

    public const int MQCMD_PING_CHANNEL = 26;

    public const int MQCMD_RESET_CHANNEL = 27;

    public const int MQCMD_START_CHANNEL = 28;

    public const int MQCMD_STOP_CHANNEL = 29;

    public const int MQCMD_START_CHANNEL_INIT = 30;

    public const int MQCMD_START_CHANNEL_LISTENER = 31;

    public const int MQCMD_CHANGE_NAMELIST = 32;

    public const int MQCMD_COPY_NAMELIST = 33;

    public const int MQCMD_CREATE_NAMELIST = 34;

    public const int MQCMD_DELETE_NAMELIST = 35;

    public const int MQCMD_INQUIRE_NAMELIST = 36;

    public const int MQCMD_INQUIRE_NAMELIST_NAMES = 37;

    public const int MQCMD_ESCAPE = 38;

    public const int MQCMD_RESOLVE_CHANNEL = 39;

    public const int MQCMD_PING_Q_MGR = 40;

    public const int MQCMD_INQUIRE_Q_STATUS = 41;

    public const int MQCMD_INQUIRE_CHANNEL_STATUS = 42;

    public const int MQCMD_CONFIG_EVENT = 43;

    public const int MQCMD_Q_MGR_EVENT = 44;

    public const int MQCMD_PERFM_EVENT = 45;

    public const int MQCMD_CHANNEL_EVENT = 46;

    public const int MQCMD_DELETE_PUBLICATION = 60;

    public const int MQCMD_DEREGISTER_PUBLISHER = 61;

    public const int MQCMD_DEREGISTER_SUBSCRIBER = 62;

    public const int MQCMD_PUBLISH = 63;

    public const int MQCMD_REGISTER_PUBLISHER = 64;

    public const int MQCMD_REGISTER_SUBSCRIBER = 65;

    public const int MQCMD_REQUEST_UPDATE = 66;

    public const int MQCMD_BROKER_INTERNAL = 67;

    public const int MQCMD_ACTIVITY_MSG = 69;

    public const int MQCMD_INQUIRE_CLUSTER_Q_MGR = 70;

    public const int MQCMD_RESUME_Q_MGR_CLUSTER = 71;

    public const int MQCMD_SUSPEND_Q_MGR_CLUSTER = 72;

    public const int MQCMD_REFRESH_CLUSTER = 73;

    public const int MQCMD_RESET_CLUSTER = 74;

    public const int MQCMD_TRACE_ROUTE = 75;

    public const int MQCMD_REFRESH_SECURITY = 78;

    public const int MQCMD_CHANGE_AUTH_INFO = 79;

    public const int MQCMD_COPY_AUTH_INFO = 80;

    public const int MQCMD_CREATE_AUTH_INFO = 81;

    public const int MQCMD_DELETE_AUTH_INFO = 82;

    public const int MQCMD_INQUIRE_AUTH_INFO = 83;

    public const int MQCMD_INQUIRE_AUTH_INFO_NAMES = 84;

    public const int MQCMD_INQUIRE_CONNECTION = 85;

    public const int MQCMD_STOP_CONNECTION = 86;

    public const int MQCMD_INQUIRE_AUTH_RECS = 87;

    public const int MQCMD_INQUIRE_ENTITY_AUTH = 88;

    public const int MQCMD_DELETE_AUTH_REC = 89;

    public const int MQCMD_SET_AUTH_REC = 90;

    public const int MQCMD_LOGGER_EVENT = 91;

    public const int MQCMD_RESET_Q_MGR = 92;

    public const int MQCMD_CHANGE_LISTENER = 93;

    public const int MQCMD_COPY_LISTENER = 94;

    public const int MQCMD_CREATE_LISTENER = 95;

    public const int MQCMD_DELETE_LISTENER = 96;

    public const int MQCMD_INQUIRE_LISTENER = 97;

    public const int MQCMD_INQUIRE_LISTENER_STATUS = 98;

    public const int MQCMD_COMMAND_EVENT = 99;

    public const int MQCMD_CHANGE_SECURITY = 100;

    public const int MQCMD_CHANGE_CF_STRUC = 101;

    public const int MQCMD_CHANGE_STG_CLASS = 102;

    public const int MQCMD_CHANGE_TRACE = 103;

    public const int MQCMD_ARCHIVE_LOG = 104;

    public const int MQCMD_BACKUP_CF_STRUC = 105;

    public const int MQCMD_CREATE_BUFFER_POOL = 106;

    public const int MQCMD_CREATE_PAGE_SET = 107;

    public const int MQCMD_CREATE_CF_STRUC = 108;

    public const int MQCMD_CREATE_STG_CLASS = 109;

    public const int MQCMD_COPY_CF_STRUC = 110;

    public const int MQCMD_COPY_STG_CLASS = 111;

    public const int MQCMD_DELETE_CF_STRUC = 112;

    public const int MQCMD_DELETE_STG_CLASS = 113;

    public const int MQCMD_INQUIRE_ARCHIVE = 114;

    public const int MQCMD_INQUIRE_CF_STRUC = 115;

    public const int MQCMD_INQUIRE_CF_STRUC_STATUS = 116;

    public const int MQCMD_INQUIRE_CMD_SERVER = 117;

    public const int MQCMD_INQUIRE_CHANNEL_INIT = 118;

    public const int MQCMD_INQUIRE_QSG = 119;

    public const int MQCMD_INQUIRE_LOG = 120;

    public const int MQCMD_INQUIRE_SECURITY = 121;

    public const int MQCMD_INQUIRE_STG_CLASS = 122;

    public const int MQCMD_INQUIRE_SYSTEM = 123;

    public const int MQCMD_INQUIRE_THREAD = 124;

    public const int MQCMD_INQUIRE_TRACE = 125;

    public const int MQCMD_INQUIRE_USAGE = 126;

    public const int MQCMD_MOVE_Q = 127;

    public const int MQCMD_RECOVER_BSDS = 128;

    public const int MQCMD_RECOVER_CF_STRUC = 129;

    public const int MQCMD_RESET_TPIPE = 130;

    public const int MQCMD_RESOLVE_INDOUBT = 131;

    public const int MQCMD_RESUME_Q_MGR = 132;

    public const int MQCMD_REVERIFY_SECURITY = 133;

    public const int MQCMD_SET_ARCHIVE = 134;

    public const int MQCMD_SET_LOG = 136;

    public const int MQCMD_SET_SYSTEM = 137;

    public const int MQCMD_START_CMD_SERVER = 138;

    public const int MQCMD_START_Q_MGR = 139;

    public const int MQCMD_START_TRACE = 140;

    public const int MQCMD_STOP_CHANNEL_INIT = 141;

    public const int MQCMD_STOP_CHANNEL_LISTENER = 142;

    public const int MQCMD_STOP_CMD_SERVER = 143;

    public const int MQCMD_STOP_Q_MGR = 144;

    public const int MQCMD_STOP_TRACE = 145;

    public const int MQCMD_SUSPEND_Q_MGR = 146;

    public const int MQCMD_INQUIRE_CF_STRUC_NAMES = 147;

    public const int MQCMD_INQUIRE_STG_CLASS_NAMES = 148;

    public const int MQCMD_CHANGE_SERVICE = 149;

    public const int MQCMD_COPY_SERVICE = 150;

    public const int MQCMD_CREATE_SERVICE = 151;

    public const int MQCMD_DELETE_SERVICE = 152;

    public const int MQCMD_INQUIRE_SERVICE = 153;

    public const int MQCMD_INQUIRE_SERVICE_STATUS = 154;

    public const int MQCMD_START_SERVICE = 155;

    public const int MQCMD_STOP_SERVICE = 156;

    public const int MQCMD_DELETE_BUFFER_POOL = 157;

    public const int MQCMD_DELETE_PAGE_SET = 158;

    public const int MQCMD_CHANGE_BUFFER_POOL = 159;

    public const int MQCMD_CHANGE_PAGE_SET = 160;

    public const int MQCMD_INQUIRE_Q_MGR_STATUS = 161;

    public const int MQCMD_CREATE_LOG = 162;

    public const int MQCMD_STATISTICS_MQI = 164;

    public const int MQCMD_STATISTICS_Q = 165;

    public const int MQCMD_STATISTICS_CHANNEL = 166;

    public const int MQCMD_ACCOUNTING_MQI = 167;

    public const int MQCMD_ACCOUNTING_Q = 168;

    public const int MQCMD_INQUIRE_AUTH_SERVICE = 169;

    public const int MQCMD_CHANGE_TOPIC = 170;

    public const int MQCMD_COPY_TOPIC = 171;

    public const int MQCMD_CREATE_TOPIC = 172;

    public const int MQCMD_DELETE_TOPIC = 173;

    public const int MQCMD_INQUIRE_TOPIC = 174;

    public const int MQCMD_INQUIRE_TOPIC_NAMES = 175;

    public const int MQCMD_INQUIRE_SUBSCRIPTION = 176;

    public const int MQCMD_CREATE_SUBSCRIPTION = 177;

    public const int MQCMD_CHANGE_SUBSCRIPTION = 178;

    public const int MQCMD_DELETE_SUBSCRIPTION = 179;

    public const int MQCMD_COPY_SUBSCRIPTION = 181;

    public const int MQCMD_INQUIRE_SUB_STATUS = 182;

    public const int MQCMD_INQUIRE_TOPIC_STATUS = 183;

    public const int MQCMD_CLEAR_TOPIC_STRING = 184;

    public const int MQCMD_INQUIRE_PUBSUB_STATUS = 185;

    public const int MQCMD_INQUIRE_SMDS = 186;

    public const int MQCMD_CHANGE_SMDS = 187;

    public const int MQCMD_RESET_SMDS = 188;

    public const int MQCMD_CREATE_COMM_INFO = 190;

    public const int MQCMD_INQUIRE_COMM_INFO = 191;

    public const int MQCMD_CHANGE_COMM_INFO = 192;

    public const int MQCMD_COPY_COMM_INFO = 193;

    public const int MQCMD_DELETE_COMM_INFO = 194;

    public const int MQCMD_PURGE_CHANNEL = 195;

    public const int MQCMD_MQXR_DIAGNOSTICS = 196;

    public const int MQCMD_START_SMDSCONN = 197;

    public const int MQCMD_STOP_SMDSCONN = 198;

    public const int MQCMD_INQUIRE_SMDSCONN = 199;

    public const int MQCMD_INQUIRE_MQXR_STATUS = 200;

    public const int MQCMD_START_CLIENT_TRACE = 201;

    public const int MQCMD_STOP_CLIENT_TRACE = 202;

    public const int MQCMD_SET_CHLAUTH_REC = 203;

    public const int MQCMD_INQUIRE_CHLAUTH_RECS = 204;

    public const int MQCMD_INQUIRE_PROT_POLICY = 205;

    public const int MQCMD_CREATE_PROT_POLICY = 206;

    public const int MQCMD_DELETE_PROT_POLICY = 207;

    public const int MQCMD_CHANGE_PROT_POLICY = 208;

    public const int MQCMD_SET_PROT_POLICY = 208;

    public const int MQCMD_ACTIVITY_TRACE = 209;

    public const int MQCMD_INSERT_CLIENTQMGRITEM = 210;

    public const int MQCMD_DELETE_CLIENTQMGRITEM = 211;

    public const int MQCMD_INQUIRE_CLIENTQMGRITEM = 212;

    public const int MQCMD_RESET_CF_STRUC = 213;

    public const int MQCMD_INQUIRE_XR_CAPABILITY = 214;

    public const int MQCMD_INQUIRE_AMQP_CAPABILITY = 216;

    public const int MQCMD_AMQP_DIAGNOSTICS = 217;

    public const int MQCFC_LAST = 1;

    public const int MQCFC_NOT_LAST = 0;

    public const int MQRCCF_CFH_TYPE_ERROR = 3001;

    public const int MQRCCF_CFH_LENGTH_ERROR = 3002;

    public const int MQRCCF_CFH_VERSION_ERROR = 3003;

    public const int MQRCCF_CFH_MSG_SEQ_NUMBER_ERR = 3004;

    public const int MQRCCF_CFH_CONTROL_ERROR = 3005;

    public const int MQRCCF_CFH_PARM_COUNT_ERROR = 3006;

    public const int MQRCCF_CFH_COMMAND_ERROR = 3007;

    public const int MQRCCF_COMMAND_FAILED = 3008;

    public const int MQRCCF_CFIN_LENGTH_ERROR = 3009;

    public const int MQRCCF_CFST_LENGTH_ERROR = 3010;

    public const int MQRCCF_CFST_STRING_LENGTH_ERR = 3011;

    public const int MQRCCF_FORCE_VALUE_ERROR = 3012;

    public const int MQRCCF_STRUCTURE_TYPE_ERROR = 3013;

    public const int MQRCCF_CFIN_PARM_ID_ERROR = 3014;

    public const int MQRCCF_CFST_PARM_ID_ERROR = 3015;

    public const int MQRCCF_MSG_LENGTH_ERROR = 3016;

    public const int MQRCCF_CFIN_DUPLICATE_PARM = 3017;

    public const int MQRCCF_CFST_DUPLICATE_PARM = 3018;

    public const int MQRCCF_PARM_COUNT_TOO_SMALL = 3019;

    public const int MQRCCF_PARM_COUNT_TOO_BIG = 3020;

    public const int MQRCCF_Q_ALREADY_IN_CELL = 3021;

    public const int MQRCCF_Q_TYPE_ERROR = 3022;

    public const int MQRCCF_MD_FORMAT_ERROR = 3023;

    public const int MQRCCF_CFSL_LENGTH_ERROR = 3024;

    public const int MQRCCF_REPLACE_VALUE_ERROR = 3025;

    public const int MQRCCF_CFIL_DUPLICATE_VALUE = 3026;

    public const int MQRCCF_CFIL_COUNT_ERROR = 3027;

    public const int MQRCCF_CFIL_LENGTH_ERROR = 3028;

    public const int MQRCCF_QUIESCE_VALUE_ERROR = 3029;

    public const int MQRCCF_MODE_VALUE_ERROR = 3029;

    public const int MQRCCF_MSG_SEQ_NUMBER_ERROR = 3030;

    public const int MQRCCF_PING_DATA_COUNT_ERROR = 3031;

    public const int MQRCCF_PING_DATA_COMPARE_ERROR = 3032;

    public const int MQRCCF_CFSL_PARM_ID_ERROR = 3033;

    public const int MQRCCF_CHANNEL_TYPE_ERROR = 3034;

    public const int MQRCCF_PARM_SEQUENCE_ERROR = 3035;

    public const int MQRCCF_XMIT_PROTOCOL_TYPE_ERR = 3036;

    public const int MQRCCF_BATCH_SIZE_ERROR = 3037;

    public const int MQRCCF_DISC_INT_ERROR = 3038;

    public const int MQRCCF_SHORT_RETRY_ERROR = 3039;

    public const int MQRCCF_SHORT_TIMER_ERROR = 3040;

    public const int MQRCCF_LONG_RETRY_ERROR = 3041;

    public const int MQRCCF_LONG_TIMER_ERROR = 3042;

    public const int MQRCCF_SEQ_NUMBER_WRAP_ERROR = 3043;

    public const int MQRCCF_MAX_MSG_LENGTH_ERROR = 3044;

    public const int MQRCCF_PUT_AUTH_ERROR = 3045;

    public const int MQRCCF_PURGE_VALUE_ERROR = 3046;

    public const int MQRCCF_CFIL_PARM_ID_ERROR = 3047;

    public const int MQRCCF_MSG_TRUNCATED = 3048;

    public const int MQRCCF_CCSID_ERROR = 3049;

    public const int MQRCCF_ENCODING_ERROR = 3050;

    public const int MQRCCF_QUEUES_VALUE_ERROR = 3051;

    public const int MQRCCF_DATA_CONV_VALUE_ERROR = 3052;

    public const int MQRCCF_INDOUBT_VALUE_ERROR = 3053;

    public const int MQRCCF_ESCAPE_TYPE_ERROR = 3054;

    public const int MQRCCF_REPOS_VALUE_ERROR = 3055;

    public const int MQRCCF_CHANNEL_TABLE_ERROR = 3062;

    public const int MQRCCF_MCA_TYPE_ERROR = 3063;

    public const int MQRCCF_CHL_INST_TYPE_ERROR = 3064;

    public const int MQRCCF_CHL_STATUS_NOT_FOUND = 3065;

    public const int MQRCCF_CFSL_DUPLICATE_PARM = 3066;

    public const int MQRCCF_CFSL_TOTAL_LENGTH_ERROR = 3067;

    public const int MQRCCF_CFSL_COUNT_ERROR = 3068;

    public const int MQRCCF_CFSL_STRING_LENGTH_ERR = 3069;

    public const int MQRCCF_BROKER_DELETED = 3070;

    public const int MQRCCF_STREAM_ERROR = 3071;

    public const int MQRCCF_TOPIC_ERROR = 3072;

    public const int MQRCCF_NOT_REGISTERED = 3073;

    public const int MQRCCF_Q_MGR_NAME_ERROR = 3074;

    public const int MQRCCF_INCORRECT_STREAM = 3075;

    public const int MQRCCF_Q_NAME_ERROR = 3076;

    public const int MQRCCF_NO_RETAINED_MSG = 3077;

    public const int MQRCCF_DUPLICATE_IDENTITY = 3078;

    public const int MQRCCF_INCORRECT_Q = 3079;

    public const int MQRCCF_CORREL_ID_ERROR = 3080;

    public const int MQRCCF_NOT_AUTHORIZED = 3081;

    public const int MQRCCF_UNKNOWN_STREAM = 3082;

    public const int MQRCCF_REG_OPTIONS_ERROR = 3083;

    public const int MQRCCF_PUB_OPTIONS_ERROR = 3084;

    public const int MQRCCF_UNKNOWN_BROKER = 3085;

    public const int MQRCCF_Q_MGR_CCSID_ERROR = 3086;

    public const int MQRCCF_DEL_OPTIONS_ERROR = 3087;

    public const int MQRCCF_CLUSTER_NAME_CONFLICT = 3088;

    public const int MQRCCF_REPOS_NAME_CONFLICT = 3089;

    public const int MQRCCF_CLUSTER_Q_USAGE_ERROR = 3090;

    public const int MQRCCF_ACTION_VALUE_ERROR = 3091;

    public const int MQRCCF_COMMS_LIBRARY_ERROR = 3092;

    public const int MQRCCF_NETBIOS_NAME_ERROR = 3093;

    public const int MQRCCF_BROKER_COMMAND_FAILED = 3094;

    public const int MQRCCF_CFST_CONFLICTING_PARM = 3095;

    public const int MQRCCF_PATH_NOT_VALID = 3096;

    public const int MQRCCF_PARM_SYNTAX_ERROR = 3097;

    public const int MQRCCF_PWD_LENGTH_ERROR = 3098;

    public const int MQRCCF_FILTER_ERROR = 3150;

    public const int MQRCCF_WRONG_USER = 3151;

    public const int MQRCCF_DUPLICATE_SUBSCRIPTION = 3152;

    public const int MQRCCF_SUB_NAME_ERROR = 3153;

    public const int MQRCCF_SUB_IDENTITY_ERROR = 3154;

    public const int MQRCCF_SUBSCRIPTION_IN_USE = 3155;

    public const int MQRCCF_SUBSCRIPTION_LOCKED = 3156;

    public const int MQRCCF_ALREADY_JOINED = 3157;

    public const int MQRCCF_OBJECT_IN_USE = 3160;

    public const int MQRCCF_UNKNOWN_FILE_NAME = 3161;

    public const int MQRCCF_FILE_NOT_AVAILABLE = 3162;

    public const int MQRCCF_DISC_RETRY_ERROR = 3163;

    public const int MQRCCF_ALLOC_RETRY_ERROR = 3164;

    public const int MQRCCF_ALLOC_SLOW_TIMER_ERROR = 3165;

    public const int MQRCCF_ALLOC_FAST_TIMER_ERROR = 3166;

    public const int MQRCCF_PORT_NUMBER_ERROR = 3167;

    public const int MQRCCF_CHL_SYSTEM_NOT_ACTIVE = 3168;

    public const int MQRCCF_ENTITY_NAME_MISSING = 3169;

    public const int MQRCCF_PROFILE_NAME_ERROR = 3170;

    public const int MQRCCF_AUTH_VALUE_ERROR = 3171;

    public const int MQRCCF_AUTH_VALUE_MISSING = 3172;

    public const int MQRCCF_OBJECT_TYPE_MISSING = 3173;

    public const int MQRCCF_CONNECTION_ID_ERROR = 3174;

    public const int MQRCCF_LOG_TYPE_ERROR = 3175;

    public const int MQRCCF_PROGRAM_NOT_AVAILABLE = 3176;

    public const int MQRCCF_PROGRAM_AUTH_FAILED = 3177;

    public const int MQRCCF_NONE_FOUND = 3200;

    public const int MQRCCF_SECURITY_SWITCH_OFF = 3201;

    public const int MQRCCF_SECURITY_REFRESH_FAILED = 3202;

    public const int MQRCCF_PARM_CONFLICT = 3203;

    public const int MQRCCF_COMMAND_INHIBITED = 3204;

    public const int MQRCCF_OBJECT_BEING_DELETED = 3205;

    public const int MQRCCF_STORAGE_CLASS_IN_USE = 3207;

    public const int MQRCCF_OBJECT_NAME_RESTRICTED = 3208;

    public const int MQRCCF_OBJECT_LIMIT_EXCEEDED = 3209;

    public const int MQRCCF_OBJECT_OPEN_FORCE = 3210;

    public const int MQRCCF_DISPOSITION_CONFLICT = 3211;

    public const int MQRCCF_Q_MGR_NOT_IN_QSG = 3212;

    public const int MQRCCF_ATTR_VALUE_FIXED = 3213;

    public const int MQRCCF_NAMELIST_ERROR = 3215;

    public const int MQRCCF_NO_CHANNEL_INITIATOR = 3217;

    public const int MQRCCF_CHANNEL_INITIATOR_ERROR = 3218;

    public const int MQRCCF_COMMAND_LEVEL_CONFLICT = 3222;

    public const int MQRCCF_Q_ATTR_CONFLICT = 3223;

    public const int MQRCCF_EVENTS_DISABLED = 3224;

    public const int MQRCCF_COMMAND_SCOPE_ERROR = 3225;

    public const int MQRCCF_COMMAND_REPLY_ERROR = 3226;

    public const int MQRCCF_FUNCTION_RESTRICTED = 3227;

    public const int MQRCCF_PARM_MISSING = 3228;

    public const int MQRCCF_PARM_VALUE_ERROR = 3229;

    public const int MQRCCF_COMMAND_LENGTH_ERROR = 3230;

    public const int MQRCCF_COMMAND_ORIGIN_ERROR = 3231;

    public const int MQRCCF_LISTENER_CONFLICT = 3232;

    public const int MQRCCF_LISTENER_STARTED = 3233;

    public const int MQRCCF_LISTENER_STOPPED = 3234;

    public const int MQRCCF_CHANNEL_ERROR = 3235;

    public const int MQRCCF_CF_STRUC_ERROR = 3236;

    public const int MQRCCF_UNKNOWN_USER_ID = 3237;

    public const int MQRCCF_UNEXPECTED_ERROR = 3238;

    public const int MQRCCF_NO_XCF_PARTNER = 3239;

    public const int MQRCCF_CFGR_PARM_ID_ERROR = 3240;

    public const int MQRCCF_CFIF_LENGTH_ERROR = 3241;

    public const int MQRCCF_CFIF_OPERATOR_ERROR = 3242;

    public const int MQRCCF_CFIF_PARM_ID_ERROR = 3243;

    public const int MQRCCF_CFSF_FILTER_VAL_LEN_ERR = 3244;

    public const int MQRCCF_CFSF_LENGTH_ERROR = 3245;

    public const int MQRCCF_CFSF_OPERATOR_ERROR = 3246;

    public const int MQRCCF_CFSF_PARM_ID_ERROR = 3247;

    public const int MQRCCF_TOO_MANY_FILTERS = 3248;

    public const int MQRCCF_LISTENER_RUNNING = 3249;

    public const int MQRCCF_LSTR_STATUS_NOT_FOUND = 3250;

    public const int MQRCCF_SERVICE_RUNNING = 3251;

    public const int MQRCCF_SERV_STATUS_NOT_FOUND = 3252;

    public const int MQRCCF_SERVICE_STOPPED = 3253;

    public const int MQRCCF_CFBS_DUPLICATE_PARM = 3254;

    public const int MQRCCF_CFBS_LENGTH_ERROR = 3255;

    public const int MQRCCF_CFBS_PARM_ID_ERROR = 3256;

    public const int MQRCCF_CFBS_STRING_LENGTH_ERR = 3257;

    public const int MQRCCF_CFGR_LENGTH_ERROR = 3258;

    public const int MQRCCF_CFGR_PARM_COUNT_ERROR = 3259;

    public const int MQRCCF_CONN_NOT_STOPPED = 3260;

    public const int MQRCCF_SERVICE_REQUEST_PENDING = 3261;

    public const int MQRCCF_NO_START_CMD = 3262;

    public const int MQRCCF_NO_STOP_CMD = 3263;

    public const int MQRCCF_CFBF_LENGTH_ERROR = 3264;

    public const int MQRCCF_CFBF_PARM_ID_ERROR = 3265;

    public const int MQRCCF_CFBF_OPERATOR_ERROR = 3266;

    public const int MQRCCF_CFBF_FILTER_VAL_LEN_ERR = 3267;

    public const int MQRCCF_LISTENER_STILL_ACTIVE = 3268;

    public const int MQRCCF_DEF_XMIT_Q_CLUS_ERROR = 3269;

    public const int MQRCCF_TOPICSTR_ALREADY_EXISTS = 3300;

    public const int MQRCCF_SHARING_CONVS_ERROR = 3301;

    public const int MQRCCF_SHARING_CONVS_TYPE = 3302;

    public const int MQRCCF_SECURITY_CASE_CONFLICT = 3303;

    public const int MQRCCF_TOPIC_TYPE_ERROR = 3305;

    public const int MQRCCF_MAX_INSTANCES_ERROR = 3306;

    public const int MQRCCF_MAX_INSTS_PER_CLNT_ERR = 3307;

    public const int MQRCCF_TOPIC_STRING_NOT_FOUND = 3308;

    public const int MQRCCF_SUBSCRIPTION_POINT_ERR = 3309;

    public const int MQRCCF_SUB_ALREADY_EXISTS = 3311;

    public const int MQRCCF_UNKNOWN_OBJECT_NAME = 3312;

    public const int MQRCCF_REMOTE_Q_NAME_ERROR = 3313;

    public const int MQRCCF_DURABILITY_NOT_ALLOWED = 3314;

    public const int MQRCCF_HOBJ_ERROR = 3315;

    public const int MQRCCF_DEST_NAME_ERROR = 3316;

    public const int MQRCCF_INVALID_DESTINATION = 3317;

    public const int MQRCCF_PUBSUB_INHIBITED = 3318;

    public const int MQRCCF_GROUPUR_CHECKS_FAILED = 3319;

    public const int MQRCCF_COMM_INFO_TYPE_ERROR = 3320;

    public const int MQRCCF_USE_CLIENT_ID_ERROR = 3321;

    public const int MQRCCF_CLIENT_ID_NOT_FOUND = 3322;

    public const int MQRCCF_CLIENT_ID_ERROR = 3323;

    public const int MQRCCF_PORT_IN_USE = 3324;

    public const int MQRCCF_SSL_ALT_PROVIDER_REQD = 3325;

    public const int MQRCCF_CHLAUTH_TYPE_ERROR = 3326;

    public const int MQRCCF_CHLAUTH_ACTION_ERROR = 3327;

    public const int MQRCCF_POLICY_NOT_FOUND = 3328;

    public const int MQRCCF_ENCRYPTION_ALG_ERROR = 3329;

    public const int MQRCCF_SIGNATURE_ALG_ERROR = 3330;

    public const int MQRCCF_TOLERATION_POL_ERROR = 3331;

    public const int MQRCCF_POLICY_VERSION_ERROR = 3332;

    public const int MQRCCF_RECIPIENT_DN_MISSING = 3333;

    public const int MQRCCF_POLICY_NAME_MISSING = 3334;

    public const int MQRCCF_CHLAUTH_USERSRC_ERROR = 3335;

    public const int MQRCCF_WRONG_CHLAUTH_TYPE = 3336;

    public const int MQRCCF_CHLAUTH_ALREADY_EXISTS = 3337;

    public const int MQRCCF_CHLAUTH_NOT_FOUND = 3338;

    public const int MQRCCF_WRONG_CHLAUTH_ACTION = 3339;

    public const int MQRCCF_WRONG_CHLAUTH_USERSRC = 3340;

    public const int MQRCCF_CHLAUTH_WARN_ERROR = 3341;

    public const int MQRCCF_WRONG_CHLAUTH_MATCH = 3342;

    public const int MQRCCF_IPADDR_RANGE_CONFLICT = 3343;

    public const int MQRCCF_CHLAUTH_MAX_EXCEEDED = 3344;

    public const int MQRCCF_IPADDR_ERROR = 3345;

    public const int MQRCCF_ADDRESS_ERROR = 3345;

    public const int MQRCCF_IPADDR_RANGE_ERROR = 3346;

    public const int MQRCCF_PROFILE_NAME_MISSING = 3347;

    public const int MQRCCF_CHLAUTH_CLNTUSER_ERROR = 3348;

    public const int MQRCCF_CHLAUTH_NAME_ERROR = 3349;

    public const int MQRCCF_CHLAUTH_RUNCHECK_ERROR = 3350;

    public const int MQRCCF_CF_STRUC_ALREADY_FAILED = 3351;

    public const int MQRCCF_CFCONLOS_CHECKS_FAILED = 3352;

    public const int MQRCCF_SUITE_B_ERROR = 3353;

    public const int MQRCCF_CHANNEL_NOT_STARTED = 3354;

    public const int MQRCCF_CUSTOM_ERROR = 3355;

    public const int MQRCCF_BACKLOG_OUT_OF_RANGE = 3356;

    public const int MQRCCF_CHLAUTH_DISABLED = 3357;

    public const int MQRCCF_SMDS_REQUIRES_DSGROUP = 3358;

    public const int MQRCCF_PSCLUS_DISABLED_TOPDEF = 3359;

    public const int MQRCCF_PSCLUS_TOPIC_EXISTS = 3360;

    public const int MQRCCF_SSL_CIPHER_SUITE_ERROR = 3361;

    public const int MQRCCF_SOCKET_ERROR = 3362;

    public const int MQRCCF_CLUS_XMIT_Q_USAGE_ERROR = 3363;

    public const int MQRCCF_CERT_VAL_POLICY_ERROR = 3364;

    public const int MQRCCF_INVALID_PROTOCOL = 3365;

    public const int MQRCCF_REVDNS_DISABLED = 3366;

    public const int MQRCCF_CLROUTE_NOT_ALTERABLE = 3367;

    public const int MQRCCF_CLUSTER_TOPIC_CONFLICT = 3368;

    public const int MQRCCF_DEFCLXQ_MODEL_Q_ERROR = 3369;

    public const int MQRCCF_CHLAUTH_CHKCLI_ERROR = 3370;

    public const int MQRCCF_CERT_LABEL_NOT_ALLOWED = 3371;

    public const int MQRCCF_Q_MGR_ATTR_CONFLICT = 3372;

    public const int MQRCCF_ENTITY_TYPE_MISSING = 3373;

    public const int MQRCCF_CLWL_EXIT_NAME_ERROR = 3374;

    public const int MQRCCF_SERVICE_NAME_ERROR = 3375;

    public const int MQRCCF_REMOTE_CHL_TYPE_ERROR = 3376;

    public const int MQRCCF_TOPIC_RESTRICTED = 3377;

    public const int MQRCCF_OBJECT_ALREADY_EXISTS = 4001;

    public const int MQRCCF_OBJECT_WRONG_TYPE = 4002;

    public const int MQRCCF_LIKE_OBJECT_WRONG_TYPE = 4003;

    public const int MQRCCF_OBJECT_OPEN = 4004;

    public const int MQRCCF_ATTR_VALUE_ERROR = 4005;

    public const int MQRCCF_UNKNOWN_Q_MGR = 4006;

    public const int MQRCCF_Q_WRONG_TYPE = 4007;

    public const int MQRCCF_OBJECT_NAME_ERROR = 4008;

    public const int MQRCCF_ALLOCATE_FAILED = 4009;

    public const int MQRCCF_HOST_NOT_AVAILABLE = 4010;

    public const int MQRCCF_CONFIGURATION_ERROR = 4011;

    public const int MQRCCF_CONNECTION_REFUSED = 4012;

    public const int MQRCCF_ENTRY_ERROR = 4013;

    public const int MQRCCF_SEND_FAILED = 4014;

    public const int MQRCCF_RECEIVED_DATA_ERROR = 4015;

    public const int MQRCCF_RECEIVE_FAILED = 4016;

    public const int MQRCCF_CONNECTION_CLOSED = 4017;

    public const int MQRCCF_NO_STORAGE = 4018;

    public const int MQRCCF_NO_COMMS_MANAGER = 4019;

    public const int MQRCCF_LISTENER_NOT_STARTED = 4020;

    public const int MQRCCF_BIND_FAILED = 4024;

    public const int MQRCCF_CHANNEL_INDOUBT = 4025;

    public const int MQRCCF_MQCONN_FAILED = 4026;

    public const int MQRCCF_MQOPEN_FAILED = 4027;

    public const int MQRCCF_MQGET_FAILED = 4028;

    public const int MQRCCF_MQPUT_FAILED = 4029;

    public const int MQRCCF_PING_ERROR = 4030;

    public const int MQRCCF_CHANNEL_IN_USE = 4031;

    public const int MQRCCF_CHANNEL_NOT_FOUND = 4032;

    public const int MQRCCF_UNKNOWN_REMOTE_CHANNEL = 4033;

    public const int MQRCCF_REMOTE_QM_UNAVAILABLE = 4034;

    public const int MQRCCF_REMOTE_QM_TERMINATING = 4035;

    public const int MQRCCF_MQINQ_FAILED = 4036;

    public const int MQRCCF_NOT_XMIT_Q = 4037;

    public const int MQRCCF_CHANNEL_DISABLED = 4038;

    public const int MQRCCF_USER_EXIT_NOT_AVAILABLE = 4039;

    public const int MQRCCF_COMMIT_FAILED = 4040;

    public const int MQRCCF_WRONG_CHANNEL_TYPE = 4041;

    public const int MQRCCF_CHANNEL_ALREADY_EXISTS = 4042;

    public const int MQRCCF_DATA_TOO_LARGE = 4043;

    public const int MQRCCF_CHANNEL_NAME_ERROR = 4044;

    public const int MQRCCF_XMIT_Q_NAME_ERROR = 4045;

    public const int MQRCCF_MCA_NAME_ERROR = 4047;

    public const int MQRCCF_SEND_EXIT_NAME_ERROR = 4048;

    public const int MQRCCF_SEC_EXIT_NAME_ERROR = 4049;

    public const int MQRCCF_MSG_EXIT_NAME_ERROR = 4050;

    public const int MQRCCF_RCV_EXIT_NAME_ERROR = 4051;

    public const int MQRCCF_XMIT_Q_NAME_WRONG_TYPE = 4052;

    public const int MQRCCF_MCA_NAME_WRONG_TYPE = 4053;

    public const int MQRCCF_DISC_INT_WRONG_TYPE = 4054;

    public const int MQRCCF_SHORT_RETRY_WRONG_TYPE = 4055;

    public const int MQRCCF_SHORT_TIMER_WRONG_TYPE = 4056;

    public const int MQRCCF_LONG_RETRY_WRONG_TYPE = 4057;

    public const int MQRCCF_LONG_TIMER_WRONG_TYPE = 4058;

    public const int MQRCCF_PUT_AUTH_WRONG_TYPE = 4059;

    public const int MQRCCF_KEEP_ALIVE_INT_ERROR = 4060;

    public const int MQRCCF_MISSING_CONN_NAME = 4061;

    public const int MQRCCF_CONN_NAME_ERROR = 4062;

    public const int MQRCCF_MQSET_FAILED = 4063;

    public const int MQRCCF_CHANNEL_NOT_ACTIVE = 4064;

    public const int MQRCCF_TERMINATED_BY_SEC_EXIT = 4065;

    public const int MQRCCF_DYNAMIC_Q_SCOPE_ERROR = 4067;

    public const int MQRCCF_CELL_DIR_NOT_AVAILABLE = 4068;

    public const int MQRCCF_MR_COUNT_ERROR = 4069;

    public const int MQRCCF_MR_COUNT_WRONG_TYPE = 4070;

    public const int MQRCCF_MR_EXIT_NAME_ERROR = 4071;

    public const int MQRCCF_MR_EXIT_NAME_WRONG_TYPE = 4072;

    public const int MQRCCF_MR_INTERVAL_ERROR = 4073;

    public const int MQRCCF_MR_INTERVAL_WRONG_TYPE = 4074;

    public const int MQRCCF_NPM_SPEED_ERROR = 4075;

    public const int MQRCCF_NPM_SPEED_WRONG_TYPE = 4076;

    public const int MQRCCF_HB_INTERVAL_ERROR = 4077;

    public const int MQRCCF_HB_INTERVAL_WRONG_TYPE = 4078;

    public const int MQRCCF_CHAD_ERROR = 4079;

    public const int MQRCCF_CHAD_WRONG_TYPE = 4080;

    public const int MQRCCF_CHAD_EVENT_ERROR = 4081;

    public const int MQRCCF_CHAD_EVENT_WRONG_TYPE = 4082;

    public const int MQRCCF_CHAD_EXIT_ERROR = 4083;

    public const int MQRCCF_CHAD_EXIT_WRONG_TYPE = 4084;

    public const int MQRCCF_SUPPRESSED_BY_EXIT = 4085;

    public const int MQRCCF_BATCH_INT_ERROR = 4086;

    public const int MQRCCF_BATCH_INT_WRONG_TYPE = 4087;

    public const int MQRCCF_NET_PRIORITY_ERROR = 4088;

    public const int MQRCCF_NET_PRIORITY_WRONG_TYPE = 4089;

    public const int MQRCCF_CHANNEL_CLOSED = 4090;

    public const int MQRCCF_Q_STATUS_NOT_FOUND = 4091;

    public const int MQRCCF_SSL_CIPHER_SPEC_ERROR = 4092;

    public const int MQRCCF_SSL_PEER_NAME_ERROR = 4093;

    public const int MQRCCF_SSL_CLIENT_AUTH_ERROR = 4094;

    public const int MQRCCF_RETAINED_NOT_SUPPORTED = 4095;

    public const int MQCFBF_STRUC_LENGTH_FIXED = 20;

    public const int MQCFBS_STRUC_LENGTH_FIXED = 16;

    public const int MQCFGR_STRUC_LENGTH = 16;

    public const int MQCFIF_STRUC_LENGTH = 20;

    public const int MQCFIL_STRUC_LENGTH_FIXED = 16;

    public const int MQCFIL64_STRUC_LENGTH_FIXED = 16;

    public const int MQCFIN_STRUC_LENGTH = 16;

    public const int MQCFIN64_STRUC_LENGTH = 24;

    public const int MQCFSF_STRUC_LENGTH_FIXED = 24;

    public const int MQCFSL_STRUC_LENGTH_FIXED = 24;

    public const int MQCFST_STRUC_LENGTH_FIXED = 20;

    public const string MQEPH_STRUC_ID = "EPH ";

    public const int MQEPH_STRUC_LENGTH_FIXED = 68;

    public const int MQEPH_VERSION_1 = 1;

    public const int MQEPH_CURRENT_VERSION = 1;

    public const int MQEPH_LENGTH_1 = 68;

    public const int MQEPH_CURRENT_LENGTH = 68;

    public const int MQEPH_NONE = 0;

    public const int MQEPH_CCSID_EMBEDDED = 1;

    public const int MQ_ARCHIVE_PFX_LENGTH = 36;

    public const int MQ_ARCHIVE_UNIT_LENGTH = 8;

    public const int MQ_ASID_LENGTH = 4;

    public const int MQ_AUTH_PROFILE_NAME_LENGTH = 48;

    public const int MQ_CF_LEID_LENGTH = 12;

    public const int MQ_COMMAND_MQSC_LENGTH = 32768;

    public const int MQ_DATA_SET_NAME_LENGTH = 44;

    public const int MQ_DB2_NAME_LENGTH = 4;

    public const int MQ_DSG_NAME_LENGTH = 8;

    public const int MQ_ENTITY_NAME_LENGTH = 1024;

    public const int MQ_ENV_INFO_LENGTH = 96;

    public const int MQ_GROUP_ADDRESS_LENGTH = 264;

    public const int MQ_IP_ADDRESS_LENGTH = 48;

    public const int MQ_LOG_CORREL_ID_LENGTH = 8;

    public const int MQ_LOG_EXTENT_NAME_LENGTH = 24;

    public const int MQ_LOG_PATH_LENGTH = 1024;

    public const int MQ_LRSN_LENGTH = 12;

    public const int MQ_ORIGIN_NAME_LENGTH = 8;

    public const int MQ_PSB_NAME_LENGTH = 8;

    public const int MQ_PST_ID_LENGTH = 8;

    public const int MQ_Q_MGR_CPF_LENGTH = 4;

    public const int MQ_RESPONSE_ID_LENGTH = 24;

    public const int MQ_RBA_LENGTH = 16;

    public const int MQ_SECURITY_PROFILE_LENGTH = 40;

    public const int MQ_SERVICE_COMPONENT_LENGTH = 48;

    public const int MQ_SUB_NAME_LENGTH = 10240;

    public const int MQ_SYSP_SERVICE_LENGTH = 32;

    public const int MQ_SYSTEM_NAME_LENGTH = 8;

    public const int MQ_TASK_NUMBER_LENGTH = 8;

    public const int MQ_TPIPE_PFX_LENGTH = 4;

    public const int MQ_UOW_ID_LENGTH = 256;

    public const int MQ_USER_DATA_LENGTH = 10240;

    public const int MQ_VOLSER_LENGTH = 6;

    public const int MQ_REMOTE_PRODUCT_LENGTH = 4;

    public const int MQ_REMOTE_VERSION_LENGTH = 8;

    public const int MQCFOP_LESS = 1;

    public const int MQCFOP_EQUAL = 2;

    public const int MQCFOP_GREATER = 4;

    public const int MQCFOP_NOT_LESS = 6;

    public const int MQCFOP_NOT_EQUAL = 5;

    public const int MQCFOP_NOT_GREATER = 3;

    public const int MQCFOP_LIKE = 18;

    public const int MQCFOP_NOT_LIKE = 21;

    public const int MQCFOP_CONTAINS = 10;

    public const int MQCFOP_EXCLUDES = 13;

    public const int MQCFOP_CONTAINS_GEN = 26;

    public const int MQCFOP_EXCLUDES_GEN = 29;

    public const int MQCFT_NONE = 0;

    public const int MQCFT_COMMAND = 1;

    public const int MQCFT_RESPONSE = 2;

    public const int MQCFT_INTEGER = 3;

    public const int MQCFT_STRING = 4;

    public const int MQCFT_INTEGER_LIST = 5;

    public const int MQCFT_STRING_LIST = 6;

    public const int MQCFT_EVENT = 7;

    public const int MQCFT_USER = 8;

    public const int MQCFT_BYTE_STRING = 9;

    public const int MQCFT_TRACE_ROUTE = 10;

    public const int MQCFT_REPORT = 12;

    public const int MQCFT_INTEGER_FILTER = 13;

    public const int MQCFT_STRING_FILTER = 14;

    public const int MQCFT_BYTE_STRING_FILTER = 15;

    public const int MQCFT_COMMAND_XR = 16;

    public const int MQCFT_XR_MSG = 17;

    public const int MQCFT_XR_ITEM = 18;

    public const int MQCFT_XR_SUMMARY = 19;

    public const int MQCFT_GROUP = 20;

    public const int MQCFT_STATISTICS = 21;

    public const int MQCFT_ACCOUNTING = 22;

    public const int MQCFT_INTEGER64 = 23;

    public const int MQCFT_INTEGER64_LIST = 25;

    public const int MQCFT_APP_ACTIVITY = 26;

    public const int MQOPMODE_COMPAT = 0;

    public const int MQOPMODE_NEW_FUNCTION = 1;

    public const int MQBACF_FIRST = 7001;

    public const int MQBACF_EVENT_ACCOUNTING_TOKEN = 7001;

    public const int MQBACF_EVENT_SECURITY_ID = 7002;

    public const int MQBACF_RESPONSE_SET = 7003;

    public const int MQBACF_RESPONSE_ID = 7004;

    public const int MQBACF_EXTERNAL_UOW_ID = 7005;

    public const int MQBACF_CONNECTION_ID = 7006;

    public const int MQBACF_GENERIC_CONNECTION_ID = 7007;

    public const int MQBACF_ORIGIN_UOW_ID = 7008;

    public const int MQBACF_Q_MGR_UOW_ID = 7009;

    public const int MQBACF_ACCOUNTING_TOKEN = 7010;

    public const int MQBACF_CORREL_ID = 7011;

    public const int MQBACF_GROUP_ID = 7012;

    public const int MQBACF_MSG_ID = 7013;

    public const int MQBACF_CF_LEID = 7014;

    public const int MQBACF_DESTINATION_CORREL_ID = 7015;

    public const int MQBACF_SUB_ID = 7016;

    public const int MQBACF_ALTERNATE_SECURITYID = 7019;

    public const int MQBACF_MESSAGE_DATA = 7020;

    public const int MQBACF_MQBO_STRUCT = 7021;

    public const int MQBACF_MQCB_FUNCTION = 7022;

    public const int MQBACF_MQCBC_STRUCT = 7023;

    public const int MQBACF_MQCBD_STRUCT = 7024;

    public const int MQBACF_MQCD_STRUCT = 7025;

    public const int MQBACF_MQCNO_STRUCT = 7026;

    public const int MQBACF_MQGMO_STRUCT = 7027;

    public const int MQBACF_MQMD_STRUCT = 7028;

    public const int MQBACF_MQPMO_STRUCT = 7029;

    public const int MQBACF_MQSD_STRUCT = 7030;

    public const int MQBACF_MQSTS_STRUCT = 7031;

    public const int MQBACF_SUB_CORREL_ID = 7032;

    public const int MQBACF_XA_XID = 7033;

    public const int MQBACF_XQH_CORREL_ID = 7034;

    public const int MQBACF_XQH_MSG_ID = 7035;

    public const int MQBACF_LAST_USED = 7035;

    public const int MQIAMO_FIRST = 701;

    public const int MQIAMO_AVG_BATCH_SIZE = 702;

    public const int MQIAMO_AVG_Q_TIME = 703;

    public const int MQIAMO64_AVG_Q_TIME = 703;

    public const int MQIAMO_BACKOUTS = 704;

    public const int MQIAMO_BROWSES = 705;

    public const int MQIAMO_BROWSE_MAX_BYTES = 706;

    public const int MQIAMO_BROWSE_MIN_BYTES = 707;

    public const int MQIAMO_BROWSES_FAILED = 708;

    public const int MQIAMO_CLOSES = 709;

    public const int MQIAMO_COMMITS = 710;

    public const int MQIAMO_COMMITS_FAILED = 711;

    public const int MQIAMO_CONNS = 712;

    public const int MQIAMO_CONNS_MAX = 713;

    public const int MQIAMO_DISCS = 714;

    public const int MQIAMO_DISCS_IMPLICIT = 715;

    public const int MQIAMO_DISC_TYPE = 716;

    public const int MQIAMO_EXIT_TIME_AVG = 717;

    public const int MQIAMO_EXIT_TIME_MAX = 718;

    public const int MQIAMO_EXIT_TIME_MIN = 719;

    public const int MQIAMO_FULL_BATCHES = 720;

    public const int MQIAMO_GENERATED_MSGS = 721;

    public const int MQIAMO_GETS = 722;

    public const int MQIAMO_GET_MAX_BYTES = 723;

    public const int MQIAMO_GET_MIN_BYTES = 724;

    public const int MQIAMO_GETS_FAILED = 725;

    public const int MQIAMO_INCOMPLETE_BATCHES = 726;

    public const int MQIAMO_INQS = 727;

    public const int MQIAMO_MSGS = 728;

    public const int MQIAMO_NET_TIME_AVG = 729;

    public const int MQIAMO_NET_TIME_MAX = 730;

    public const int MQIAMO_NET_TIME_MIN = 731;

    public const int MQIAMO_OBJECT_COUNT = 732;

    public const int MQIAMO_OPENS = 733;

    public const int MQIAMO_PUT1S = 734;

    public const int MQIAMO_PUTS = 735;

    public const int MQIAMO_PUT_MAX_BYTES = 736;

    public const int MQIAMO_PUT_MIN_BYTES = 737;

    public const int MQIAMO_PUT_RETRIES = 738;

    public const int MQIAMO_Q_MAX_DEPTH = 739;

    public const int MQIAMO_Q_MIN_DEPTH = 740;

    public const int MQIAMO_Q_TIME_AVG = 741;

    public const int MQIAMO64_Q_TIME_AVG = 741;

    public const int MQIAMO_Q_TIME_MAX = 742;

    public const int MQIAMO64_Q_TIME_MAX = 742;

    public const int MQIAMO_Q_TIME_MIN = 743;

    public const int MQIAMO64_Q_TIME_MIN = 743;

    public const int MQIAMO_SETS = 744;

    public const int MQIAMO64_BROWSE_BYTES = 745;

    public const int MQIAMO64_BYTES = 746;

    public const int MQIAMO64_GET_BYTES = 747;

    public const int MQIAMO64_PUT_BYTES = 748;

    public const int MQIAMO_CONNS_FAILED = 749;

    public const int MQIAMO_OPENS_FAILED = 751;

    public const int MQIAMO_INQS_FAILED = 752;

    public const int MQIAMO_SETS_FAILED = 753;

    public const int MQIAMO_PUTS_FAILED = 754;

    public const int MQIAMO_PUT1S_FAILED = 755;

    public const int MQIAMO_CLOSES_FAILED = 757;

    public const int MQIAMO_MSGS_EXPIRED = 758;

    public const int MQIAMO_MSGS_NOT_QUEUED = 759;

    public const int MQIAMO_MSGS_PURGED = 760;

    public const int MQIAMO_SUBS_DUR = 764;

    public const int MQIAMO_SUBS_NDUR = 765;

    public const int MQIAMO_SUBS_FAILED = 766;

    public const int MQIAMO_SUBRQS = 767;

    public const int MQIAMO_SUBRQS_FAILED = 768;

    public const int MQIAMO_CBS = 769;

    public const int MQIAMO_CBS_FAILED = 770;

    public const int MQIAMO_CTLS = 771;

    public const int MQIAMO_CTLS_FAILED = 772;

    public const int MQIAMO_STATS = 773;

    public const int MQIAMO_STATS_FAILED = 774;

    public const int MQIAMO_SUB_DUR_HIGHWATER = 775;

    public const int MQIAMO_SUB_DUR_LOWWATER = 776;

    public const int MQIAMO_SUB_NDUR_HIGHWATER = 777;

    public const int MQIAMO_SUB_NDUR_LOWWATER = 778;

    public const int MQIAMO_TOPIC_PUTS = 779;

    public const int MQIAMO_TOPIC_PUTS_FAILED = 780;

    public const int MQIAMO_TOPIC_PUT1S = 781;

    public const int MQIAMO_TOPIC_PUT1S_FAILED = 782;

    public const int MQIAMO64_TOPIC_PUT_BYTES = 783;

    public const int MQIAMO_PUBLISH_MSG_COUNT = 784;

    public const int MQIAMO64_PUBLISH_MSG_BYTES = 785;

    public const int MQIAMO_UNSUBS_DUR = 786;

    public const int MQIAMO_UNSUBS_NDUR = 787;

    public const int MQIAMO_UNSUBS_FAILED = 788;

    public const int MQIAMO_INTERVAL = 789;

    public const int MQIAMO_MSGS_SENT = 790;

    public const int MQIAMO_BYTES_SENT = 791;

    public const int MQIAMO_REPAIR_BYTES = 792;

    public const int MQIAMO_FEEDBACK_MODE = 793;

    public const int MQIAMO_RELIABILITY_TYPE = 794;

    public const int MQIAMO_LATE_JOIN_MARK = 795;

    public const int MQIAMO_NACKS_RCVD = 796;

    public const int MQIAMO_REPAIR_PKTS = 797;

    public const int MQIAMO_HISTORY_PKTS = 798;

    public const int MQIAMO_PENDING_PKTS = 799;

    public const int MQIAMO_PKT_RATE = 800;

    public const int MQIAMO_MCAST_XMIT_RATE = 801;

    public const int MQIAMO_MCAST_BATCH_TIME = 802;

    public const int MQIAMO_MCAST_HEARTBEAT = 803;

    public const int MQIAMO_DEST_DATA_PORT = 804;

    public const int MQIAMO_DEST_REPAIR_PORT = 805;

    public const int MQIAMO_ACKS_RCVD = 806;

    public const int MQIAMO_ACTIVE_ACKERS = 807;

    public const int MQIAMO_PKTS_SENT = 808;

    public const int MQIAMO_TOTAL_REPAIR_PKTS = 809;

    public const int MQIAMO_TOTAL_PKTS_SENT = 810;

    public const int MQIAMO_TOTAL_MSGS_SENT = 811;

    public const int MQIAMO_TOTAL_BYTES_SENT = 812;

    public const int MQIAMO_NUM_STREAMS = 813;

    public const int MQIAMO_ACK_FEEDBACK = 814;

    public const int MQIAMO_NACK_FEEDBACK = 815;

    public const int MQIAMO_PKTS_LOST = 816;

    public const int MQIAMO_MSGS_RCVD = 817;

    public const int MQIAMO_MSG_BYTES_RCVD = 818;

    public const int MQIAMO_MSGS_DELIVERED = 819;

    public const int MQIAMO_PKTS_PROCESSED = 820;

    public const int MQIAMO_PKTS_DELIVERED = 821;

    public const int MQIAMO_PKTS_DROPPED = 822;

    public const int MQIAMO_PKTS_DUPLICATED = 823;

    public const int MQIAMO_NACKS_CREATED = 824;

    public const int MQIAMO_NACK_PKTS_SENT = 825;

    public const int MQIAMO_REPAIR_PKTS_RQSTD = 826;

    public const int MQIAMO_REPAIR_PKTS_RCVD = 827;

    public const int MQIAMO_PKTS_REPAIRED = 828;

    public const int MQIAMO_TOTAL_MSGS_RCVD = 829;

    public const int MQIAMO_TOTAL_MSG_BYTES_RCVD = 830;

    public const int MQIAMO_TOTAL_REPAIR_PKTS_RCVD = 831;

    public const int MQIAMO_TOTAL_REPAIR_PKTS_RQSTD = 832;

    public const int MQIAMO_TOTAL_MSGS_PROCESSED = 833;

    public const int MQIAMO_TOTAL_MSGS_SELECTED = 834;

    public const int MQIAMO_TOTAL_MSGS_EXPIRED = 835;

    public const int MQIAMO_TOTAL_MSGS_DELIVERED = 836;

    public const int MQIAMO_TOTAL_MSGS_RETURNED = 837;

    public const int MQIAMO64_HIGHRES_TIME = 838;

    public const int MQIAMO_MONITOR_CLASS = 839;

    public const int MQIAMO_MONITOR_TYPE = 840;

    public const int MQIAMO_MONITOR_ELEMENT = 841;

    public const int MQIAMO_MONITOR_DATATYPE = 842;

    public const int MQIAMO_MONITOR_FLAGS = 843;

    public const int MQIAMO64_QMGR_OP_DURATION = 844;

    public const int MQIAMO64_MONITOR_INTERVAL = 845;

    public const int MQIAMO_LAST_USED = 845;

    public const int MQIAMO_MONITOR_FLAGS_NONE = 0;

    public const int MQIAMO_MONITOR_FLAGS_OBJNAME = 1;

    public const int MQIAMO_MONITOR_UNIT = 1;

    public const int MQIAMO_MONITOR_DELTA = 2;

    public const int MQIAMO_MONITOR_HUNDREDTHS = 100;

    public const int MQIAMO_MONITOR_KB = 1024;

    public const int MQIAMO_MONITOR_PERCENT = 10000;

    public const int MQIAMO_MONITOR_MICROSEC = 1000000;

    public const int MQIAMO_MONITOR_MB = 1048576;

    public const int MQIAMO_MONITOR_GB = 100000000;

    public const int MQIACF_FIRST = 1001;

    public const int MQIACF_Q_MGR_ATTRS = 1001;

    public const int MQIACF_Q_ATTRS = 1002;

    public const int MQIACF_PROCESS_ATTRS = 1003;

    public const int MQIACF_NAMELIST_ATTRS = 1004;

    public const int MQIACF_FORCE = 1005;

    public const int MQIACF_REPLACE = 1006;

    public const int MQIACF_PURGE = 1007;

    public const int MQIACF_QUIESCE = 1008;

    public const int MQIACF_MODE = 1008;

    public const int MQIACF_ALL = 1009;

    public const int MQIACF_EVENT_APPL_TYPE = 1010;

    public const int MQIACF_EVENT_ORIGIN = 1011;

    public const int MQIACF_PARAMETER_ID = 1012;

    public const int MQIACF_ERROR_ID = 1013;

    public const int MQIACF_ERROR_IDENTIFIER = 1013;

    public const int MQIACF_SELECTOR = 1014;

    public const int MQIACF_CHANNEL_ATTRS = 1015;

    public const int MQIACF_OBJECT_TYPE = 1016;

    public const int MQIACF_ESCAPE_TYPE = 1017;

    public const int MQIACF_ERROR_OFFSET = 1018;

    public const int MQIACF_AUTH_INFO_ATTRS = 1019;

    public const int MQIACF_REASON_QUALIFIER = 1020;

    public const int MQIACF_COMMAND = 1021;

    public const int MQIACF_OPEN_OPTIONS = 1022;

    public const int MQIACF_OPEN_TYPE = 1023;

    public const int MQIACF_PROCESS_ID = 1024;

    public const int MQIACF_THREAD_ID = 1025;

    public const int MQIACF_Q_STATUS_ATTRS = 1026;

    public const int MQIACF_UNCOMMITTED_MSGS = 1027;

    public const int MQIACF_HANDLE_STATE = 1028;

    public const int MQIACF_AUX_ERROR_DATA_INT_1 = 1070;

    public const int MQIACF_AUX_ERROR_DATA_INT_2 = 1071;

    public const int MQIACF_CONV_REASON_CODE = 1072;

    public const int MQIACF_BRIDGE_TYPE = 1073;

    public const int MQIACF_INQUIRY = 1074;

    public const int MQIACF_WAIT_INTERVAL = 1075;

    public const int MQIACF_OPTIONS = 1076;

    public const int MQIACF_BROKER_OPTIONS = 1077;

    public const int MQIACF_REFRESH_TYPE = 1078;

    public const int MQIACF_SEQUENCE_NUMBER = 1079;

    public const int MQIACF_INTEGER_DATA = 1080;

    public const int MQIACF_REGISTRATION_OPTIONS = 1081;

    public const int MQIACF_PUBLICATION_OPTIONS = 1082;

    public const int MQIACF_CLUSTER_INFO = 1083;

    public const int MQIACF_Q_MGR_DEFINITION_TYPE = 1084;

    public const int MQIACF_Q_MGR_TYPE = 1085;

    public const int MQIACF_ACTION = 1086;

    public const int MQIACF_SUSPEND = 1087;

    public const int MQIACF_BROKER_COUNT = 1088;

    public const int MQIACF_APPL_COUNT = 1089;

    public const int MQIACF_ANONYMOUS_COUNT = 1090;

    public const int MQIACF_REG_REG_OPTIONS = 1091;

    public const int MQIACF_DELETE_OPTIONS = 1092;

    public const int MQIACF_CLUSTER_Q_MGR_ATTRS = 1093;

    public const int MQIACF_REFRESH_INTERVAL = 1094;

    public const int MQIACF_REFRESH_REPOSITORY = 1095;

    public const int MQIACF_REMOVE_QUEUES = 1096;

    public const int MQIACF_OPEN_INPUT_TYPE = 1098;

    public const int MQIACF_OPEN_OUTPUT = 1099;

    public const int MQIACF_OPEN_SET = 1100;

    public const int MQIACF_OPEN_INQUIRE = 1101;

    public const int MQIACF_OPEN_BROWSE = 1102;

    public const int MQIACF_Q_STATUS_TYPE = 1103;

    public const int MQIACF_Q_HANDLE = 1104;

    public const int MQIACF_Q_STATUS = 1105;

    public const int MQIACF_SECURITY_TYPE = 1106;

    public const int MQIACF_CONNECTION_ATTRS = 1107;

    public const int MQIACF_CONNECT_OPTIONS = 1108;

    public const int MQIACF_CONN_INFO_TYPE = 1110;

    public const int MQIACF_CONN_INFO_CONN = 1111;

    public const int MQIACF_CONN_INFO_HANDLE = 1112;

    public const int MQIACF_CONN_INFO_ALL = 1113;

    public const int MQIACF_AUTH_PROFILE_ATTRS = 1114;

    public const int MQIACF_AUTHORIZATION_LIST = 1115;

    public const int MQIACF_AUTH_ADD_AUTHS = 1116;

    public const int MQIACF_AUTH_REMOVE_AUTHS = 1117;

    public const int MQIACF_ENTITY_TYPE = 1118;

    public const int MQIACF_COMMAND_INFO = 1120;

    public const int MQIACF_CMDSCOPE_Q_MGR_COUNT = 1121;

    public const int MQIACF_Q_MGR_SYSTEM = 1122;

    public const int MQIACF_Q_MGR_EVENT = 1123;

    public const int MQIACF_Q_MGR_DQM = 1124;

    public const int MQIACF_Q_MGR_CLUSTER = 1125;

    public const int MQIACF_QSG_DISPS = 1126;

    public const int MQIACF_UOW_STATE = 1128;

    public const int MQIACF_SECURITY_ITEM = 1129;

    public const int MQIACF_CF_STRUC_STATUS = 1130;

    public const int MQIACF_UOW_TYPE = 1132;

    public const int MQIACF_CF_STRUC_ATTRS = 1133;

    public const int MQIACF_EXCLUDE_INTERVAL = 1134;

    public const int MQIACF_CF_STATUS_TYPE = 1135;

    public const int MQIACF_CF_STATUS_SUMMARY = 1136;

    public const int MQIACF_CF_STATUS_CONNECT = 1137;

    public const int MQIACF_CF_STATUS_BACKUP = 1138;

    public const int MQIACF_CF_STRUC_TYPE = 1139;

    public const int MQIACF_CF_STRUC_SIZE_MAX = 1140;

    public const int MQIACF_CF_STRUC_SIZE_USED = 1141;

    public const int MQIACF_CF_STRUC_ENTRIES_MAX = 1142;

    public const int MQIACF_CF_STRUC_ENTRIES_USED = 1143;

    public const int MQIACF_CF_STRUC_BACKUP_SIZE = 1144;

    public const int MQIACF_MOVE_TYPE = 1145;

    public const int MQIACF_MOVE_TYPE_MOVE = 1146;

    public const int MQIACF_MOVE_TYPE_ADD = 1147;

    public const int MQIACF_Q_MGR_NUMBER = 1148;

    public const int MQIACF_Q_MGR_STATUS = 1149;

    public const int MQIACF_DB2_CONN_STATUS = 1150;

    public const int MQIACF_SECURITY_ATTRS = 1151;

    public const int MQIACF_SECURITY_TIMEOUT = 1152;

    public const int MQIACF_SECURITY_INTERVAL = 1153;

    public const int MQIACF_SECURITY_SWITCH = 1154;

    public const int MQIACF_SECURITY_SETTING = 1155;

    public const int MQIACF_STORAGE_CLASS_ATTRS = 1156;

    public const int MQIACF_USAGE_TYPE = 1157;

    public const int MQIACF_BUFFER_POOL_ID = 1158;

    public const int MQIACF_USAGE_TOTAL_PAGES = 1159;

    public const int MQIACF_USAGE_UNUSED_PAGES = 1160;

    public const int MQIACF_USAGE_PERSIST_PAGES = 1161;

    public const int MQIACF_USAGE_NONPERSIST_PAGES = 1162;

    public const int MQIACF_USAGE_RESTART_EXTENTS = 1163;

    public const int MQIACF_USAGE_EXPAND_COUNT = 1164;

    public const int MQIACF_PAGESET_STATUS = 1165;

    public const int MQIACF_USAGE_TOTAL_BUFFERS = 1166;

    public const int MQIACF_USAGE_DATA_SET_TYPE = 1167;

    public const int MQIACF_USAGE_PAGESET = 1168;

    public const int MQIACF_USAGE_DATA_SET = 1169;

    public const int MQIACF_USAGE_BUFFER_POOL = 1170;

    public const int MQIACF_MOVE_COUNT = 1171;

    public const int MQIACF_EXPIRY_Q_COUNT = 1172;

    public const int MQIACF_CONFIGURATION_OBJECTS = 1173;

    public const int MQIACF_CONFIGURATION_EVENTS = 1174;

    public const int MQIACF_SYSP_TYPE = 1175;

    public const int MQIACF_SYSP_DEALLOC_INTERVAL = 1176;

    public const int MQIACF_SYSP_MAX_ARCHIVE = 1177;

    public const int MQIACF_SYSP_MAX_READ_TAPES = 1178;

    public const int MQIACF_SYSP_IN_BUFFER_SIZE = 1179;

    public const int MQIACF_SYSP_OUT_BUFFER_SIZE = 1180;

    public const int MQIACF_SYSP_OUT_BUFFER_COUNT = 1181;

    public const int MQIACF_SYSP_ARCHIVE = 1182;

    public const int MQIACF_SYSP_DUAL_ACTIVE = 1183;

    public const int MQIACF_SYSP_DUAL_ARCHIVE = 1184;

    public const int MQIACF_SYSP_DUAL_BSDS = 1185;

    public const int MQIACF_SYSP_MAX_CONNS = 1186;

    public const int MQIACF_SYSP_MAX_CONNS_FORE = 1187;

    public const int MQIACF_SYSP_MAX_CONNS_BACK = 1188;

    public const int MQIACF_SYSP_EXIT_INTERVAL = 1189;

    public const int MQIACF_SYSP_EXIT_TASKS = 1190;

    public const int MQIACF_SYSP_CHKPOINT_COUNT = 1191;

    public const int MQIACF_SYSP_OTMA_INTERVAL = 1192;

    public const int MQIACF_SYSP_Q_INDEX_DEFER = 1193;

    public const int MQIACF_SYSP_DB2_TASKS = 1194;

    public const int MQIACF_SYSP_RESLEVEL_AUDIT = 1195;

    public const int MQIACF_SYSP_ROUTING_CODE = 1196;

    public const int MQIACF_SYSP_SMF_ACCOUNTING = 1197;

    public const int MQIACF_SYSP_SMF_STATS = 1198;

    public const int MQIACF_SYSP_SMF_INTERVAL = 1199;

    public const int MQIACF_SYSP_TRACE_CLASS = 1200;

    public const int MQIACF_SYSP_TRACE_SIZE = 1201;

    public const int MQIACF_SYSP_WLM_INTERVAL = 1202;

    public const int MQIACF_SYSP_ALLOC_UNIT = 1203;

    public const int MQIACF_SYSP_ARCHIVE_RETAIN = 1204;

    public const int MQIACF_SYSP_ARCHIVE_WTOR = 1205;

    public const int MQIACF_SYSP_BLOCK_SIZE = 1206;

    public const int MQIACF_SYSP_CATALOG = 1207;

    public const int MQIACF_SYSP_COMPACT = 1208;

    public const int MQIACF_SYSP_ALLOC_PRIMARY = 1209;

    public const int MQIACF_SYSP_ALLOC_SECONDARY = 1210;

    public const int MQIACF_SYSP_PROTECT = 1211;

    public const int MQIACF_SYSP_QUIESCE_INTERVAL = 1212;

    public const int MQIACF_SYSP_TIMESTAMP = 1213;

    public const int MQIACF_SYSP_UNIT_ADDRESS = 1214;

    public const int MQIACF_SYSP_UNIT_STATUS = 1215;

    public const int MQIACF_SYSP_LOG_COPY = 1216;

    public const int MQIACF_SYSP_LOG_USED = 1217;

    public const int MQIACF_SYSP_LOG_SUSPEND = 1218;

    public const int MQIACF_SYSP_OFFLOAD_STATUS = 1219;

    public const int MQIACF_SYSP_TOTAL_LOGS = 1220;

    public const int MQIACF_SYSP_FULL_LOGS = 1221;

    public const int MQIACF_LISTENER_ATTRS = 1222;

    public const int MQIACF_LISTENER_STATUS_ATTRS = 1223;

    public const int MQIACF_SERVICE_ATTRS = 1224;

    public const int MQIACF_SERVICE_STATUS_ATTRS = 1225;

    public const int MQIACF_Q_TIME_INDICATOR = 1226;

    public const int MQIACF_OLDEST_MSG_AGE = 1227;

    public const int MQIACF_AUTH_OPTIONS = 1228;

    public const int MQIACF_Q_MGR_STATUS_ATTRS = 1229;

    public const int MQIACF_CONNECTION_COUNT = 1230;

    public const int MQIACF_Q_MGR_FACILITY = 1231;

    public const int MQIACF_CHINIT_STATUS = 1232;

    public const int MQIACF_CMD_SERVER_STATUS = 1233;

    public const int MQIACF_ROUTE_DETAIL = 1234;

    public const int MQIACF_RECORDED_ACTIVITIES = 1235;

    public const int MQIACF_MAX_ACTIVITIES = 1236;

    public const int MQIACF_DISCONTINUITY_COUNT = 1237;

    public const int MQIACF_ROUTE_ACCUMULATION = 1238;

    public const int MQIACF_ROUTE_DELIVERY = 1239;

    public const int MQIACF_OPERATION_TYPE = 1240;

    public const int MQIACF_BACKOUT_COUNT = 1241;

    public const int MQIACF_COMP_CODE = 1242;

    public const int MQIACF_ENCODING = 1243;

    public const int MQIACF_EXPIRY = 1244;

    public const int MQIACF_FEEDBACK = 1245;

    public const int MQIACF_MSG_FLAGS = 1247;

    public const int MQIACF_MSG_LENGTH = 1248;

    public const int MQIACF_MSG_TYPE = 1249;

    public const int MQIACF_OFFSET = 1250;

    public const int MQIACF_ORIGINAL_LENGTH = 1251;

    public const int MQIACF_PERSISTENCE = 1252;

    public const int MQIACF_PRIORITY = 1253;

    public const int MQIACF_REASON_CODE = 1254;

    public const int MQIACF_REPORT = 1255;

    public const int MQIACF_VERSION = 1256;

    public const int MQIACF_UNRECORDED_ACTIVITIES = 1257;

    public const int MQIACF_MONITORING = 1258;

    public const int MQIACF_ROUTE_FORWARDING = 1259;

    public const int MQIACF_SERVICE_STATUS = 1260;

    public const int MQIACF_Q_TYPES = 1261;

    public const int MQIACF_USER_ID_SUPPORT = 1262;

    public const int MQIACF_INTERFACE_VERSION = 1263;

    public const int MQIACF_AUTH_SERVICE_ATTRS = 1264;

    public const int MQIACF_USAGE_EXPAND_TYPE = 1265;

    public const int MQIACF_SYSP_CLUSTER_CACHE = 1266;

    public const int MQIACF_SYSP_DB2_BLOB_TASKS = 1267;

    public const int MQIACF_SYSP_WLM_INT_UNITS = 1268;

    public const int MQIACF_TOPIC_ATTRS = 1269;

    public const int MQIACF_PUBSUB_PROPERTIES = 1271;

    public const int MQIACF_DESTINATION_CLASS = 1273;

    public const int MQIACF_DURABLE_SUBSCRIPTION = 1274;

    public const int MQIACF_SUBSCRIPTION_SCOPE = 1275;

    public const int MQIACF_VARIABLE_USER_ID = 1277;

    public const int MQIACF_REQUEST_ONLY = 1280;

    public const int MQIACF_PUB_PRIORITY = 1283;

    public const int MQIACF_SUB_ATTRS = 1287;

    public const int MQIACF_WILDCARD_SCHEMA = 1288;

    public const int MQIACF_SUB_TYPE = 1289;

    public const int MQIACF_MESSAGE_COUNT = 1290;

    public const int MQIACF_Q_MGR_PUBSUB = 1291;

    public const int MQIACF_Q_MGR_VERSION = 1292;

    public const int MQIACF_SUB_STATUS_ATTRS = 1294;

    public const int MQIACF_TOPIC_STATUS = 1295;

    public const int MQIACF_TOPIC_SUB = 1296;

    public const int MQIACF_TOPIC_PUB = 1297;

    public const int MQIACF_RETAINED_PUBLICATION = 1300;

    public const int MQIACF_TOPIC_STATUS_ATTRS = 1301;

    public const int MQIACF_TOPIC_STATUS_TYPE = 1302;

    public const int MQIACF_SUB_OPTIONS = 1303;

    public const int MQIACF_PUBLISH_COUNT = 1304;

    public const int MQIACF_CLEAR_TYPE = 1305;

    public const int MQIACF_CLEAR_SCOPE = 1306;

    public const int MQIACF_SUB_LEVEL = 1307;

    public const int MQIACF_ASYNC_STATE = 1308;

    public const int MQIACF_SUB_SUMMARY = 1309;

    public const int MQIACF_OBSOLETE_MSGS = 1310;

    public const int MQIACF_PUBSUB_STATUS = 1311;

    public const int MQIACF_PS_STATUS_TYPE = 1314;

    public const int MQIACF_PUBSUB_STATUS_ATTRS = 1318;

    public const int MQIACF_SELECTOR_TYPE = 1321;

    public const int MQIACF_LOG_COMPRESSION = 1322;

    public const int MQIACF_GROUPUR_CHECK_ID = 1323;

    public const int MQIACF_MULC_CAPTURE = 1324;

    public const int MQIACF_PERMIT_STANDBY = 1325;

    public const int MQIACF_OPERATION_MODE = 1326;

    public const int MQIACF_COMM_INFO_ATTRS = 1327;

    public const int MQIACF_CF_SMDS_BLOCK_SIZE = 1328;

    public const int MQIACF_CF_SMDS_EXPAND = 1329;

    public const int MQIACF_USAGE_FREE_BUFF = 1330;

    public const int MQIACF_USAGE_FREE_BUFF_PERC = 1331;

    public const int MQIACF_CF_STRUC_ACCESS = 1332;

    public const int MQIACF_CF_STATUS_SMDS = 1333;

    public const int MQIACF_SMDS_ATTRS = 1334;

    public const int MQIACF_USAGE_SMDS = 1335;

    public const int MQIACF_USAGE_BLOCK_SIZE = 1336;

    public const int MQIACF_USAGE_DATA_BLOCKS = 1337;

    public const int MQIACF_USAGE_EMPTY_BUFFERS = 1338;

    public const int MQIACF_USAGE_INUSE_BUFFERS = 1339;

    public const int MQIACF_USAGE_LOWEST_FREE = 1340;

    public const int MQIACF_USAGE_OFFLOAD_MSGS = 1341;

    public const int MQIACF_USAGE_READS_SAVED = 1342;

    public const int MQIACF_USAGE_SAVED_BUFFERS = 1343;

    public const int MQIACF_USAGE_TOTAL_BLOCKS = 1344;

    public const int MQIACF_USAGE_USED_BLOCKS = 1345;

    public const int MQIACF_USAGE_USED_RATE = 1346;

    public const int MQIACF_USAGE_WAIT_RATE = 1347;

    public const int MQIACF_SMDS_OPENMODE = 1348;

    public const int MQIACF_SMDS_STATUS = 1349;

    public const int MQIACF_SMDS_AVAIL = 1350;

    public const int MQIACF_MCAST_REL_INDICATOR = 1351;

    public const int MQIACF_CHLAUTH_TYPE = 1352;

    public const int MQIACF_MQXR_DIAGNOSTICS_TYPE = 1354;

    public const int MQIACF_CHLAUTH_ATTRS = 1355;

    public const int MQIACF_OPERATION_ID = 1356;

    public const int MQIACF_API_CALLER_TYPE = 1357;

    public const int MQIACF_API_ENVIRONMENT = 1358;

    public const int MQIACF_TRACE_DETAIL = 1359;

    public const int MQIACF_HOBJ = 1360;

    public const int MQIACF_CALL_TYPE = 1361;

    public const int MQIACF_MQCB_OPERATION = 1362;

    public const int MQIACF_MQCB_TYPE = 1363;

    public const int MQIACF_MQCB_OPTIONS = 1364;

    public const int MQIACF_CLOSE_OPTIONS = 1365;

    public const int MQIACF_CTL_OPERATION = 1366;

    public const int MQIACF_GET_OPTIONS = 1367;

    public const int MQIACF_RECS_PRESENT = 1368;

    public const int MQIACF_KNOWN_DEST_COUNT = 1369;

    public const int MQIACF_UNKNOWN_DEST_COUNT = 1370;

    public const int MQIACF_INVALID_DEST_COUNT = 1371;

    public const int MQIACF_RESOLVED_TYPE = 1372;

    public const int MQIACF_PUT_OPTIONS = 1373;

    public const int MQIACF_BUFFER_LENGTH = 1374;

    public const int MQIACF_TRACE_DATA_LENGTH = 1375;

    public const int MQIACF_SMDS_EXPANDST = 1376;

    public const int MQIACF_STRUC_LENGTH = 1377;

    public const int MQIACF_ITEM_COUNT = 1378;

    public const int MQIACF_EXPIRY_TIME = 1379;

    public const int MQIACF_CONNECT_TIME = 1380;

    public const int MQIACF_DISCONNECT_TIME = 1381;

    public const int MQIACF_HSUB = 1382;

    public const int MQIACF_SUBRQ_OPTIONS = 1383;

    public const int MQIACF_XA_RMID = 1384;

    public const int MQIACF_XA_FLAGS = 1385;

    public const int MQIACF_XA_RETCODE = 1386;

    public const int MQIACF_XA_HANDLE = 1387;

    public const int MQIACF_XA_RETVAL = 1388;

    public const int MQIACF_STATUS_TYPE = 1389;

    public const int MQIACF_XA_COUNT = 1390;

    public const int MQIACF_SELECTOR_COUNT = 1391;

    public const int MQIACF_SELECTORS = 1392;

    public const int MQIACF_INTATTR_COUNT = 1393;

    public const int MQIACF_INT_ATTRS = 1394;

    public const int MQIACF_SUBRQ_ACTION = 1395;

    public const int MQIACF_NUM_PUBS = 1396;

    public const int MQIACF_POINTER_SIZE = 1397;

    public const int MQIACF_REMOVE_AUTHREC = 1398;

    public const int MQIACF_XR_ATTRS = 1399;

    public const int MQIACF_APPL_FUNCTION_TYPE = 1400;

    public const int MQIACF_AMQP_ATTRS = 1401;

    public const int MQIACF_EXPORT_TYPE = 1402;

    public const int MQIACF_EXPORT_ATTRS = 1403;

    public const int MQIACF_SYSTEM_OBJECTS = 1404;

    public const int MQIACF_CONNECTION_SWAP = 1405;

    public const int MQIACF_AMQP_DIAGNOSTICS_TYPE = 1406;

    public const int MQIACF_BUFFER_POOL_LOCATION = 1408;

    public const int MQIACF_LDAP_CONNECTION_STATUS = 1409;

    public const int MQIACF_SYSP_MAX_ACE_POOL = 1410;

    public const int MQIACF_PAGECLAS = 1411;

    public const int MQIACF_LAST_USED = 1411;

    public const int MQCFACCESS_ENABLED = 0;

    public const int MQCFACCESS_SUSPENDED = 1;

    public const int MQCFACCESS_DISABLED = 2;

    public const int MQS_OPENMODE_NONE = 0;

    public const int MQS_OPENMODE_READONLY = 1;

    public const int MQS_OPENMODE_UPDATE = 2;

    public const int MQS_OPENMODE_RECOVERY = 3;

    public const int MQS_STATUS_CLOSED = 0;

    public const int MQS_STATUS_CLOSING = 1;

    public const int MQS_STATUS_OPENING = 2;

    public const int MQS_STATUS_OPEN = 3;

    public const int MQS_STATUS_NOTENABLED = 4;

    public const int MQS_STATUS_ALLOCFAIL = 5;

    public const int MQS_STATUS_OPENFAIL = 6;

    public const int MQS_STATUS_STGFAIL = 7;

    public const int MQS_STATUS_DATAFAIL = 8;

    public const int MQS_AVAIL_NORMAL = 0;

    public const int MQS_AVAIL_ERROR = 1;

    public const int MQS_AVAIL_STOPPED = 2;

    public const int MQBPLOCATION_BELOW = 0;

    public const int MQBPLOCATION_ABOVE = 1;

    public const int MQBPLOCATION_SWITCHING_ABOVE = 2;

    public const int MQBPLOCATION_SWITCHING_BELOW = 3;

    public const int MQPAGECLAS_4KB = 0;

    public const int MQPAGECLAS_FIXED4KB = 1;

    public const int MQS_EXPANDST_NORMAL = 0;

    public const int MQS_EXPANDST_FAILED = 1;

    public const int MQS_EXPANDST_MAXIMUM = 2;

    public const int MQUSAGE_SMDS_AVAILABLE = 0;

    public const int MQUSAGE_SMDS_NO_DATA = 1;

    public const int MQIACH_FIRST = 1501;

    public const int MQIACH_XMIT_PROTOCOL_TYPE = 1501;

    public const int MQIACH_BATCH_SIZE = 1502;

    public const int MQIACH_DISC_INTERVAL = 1503;

    public const int MQIACH_SHORT_TIMER = 1504;

    public const int MQIACH_SHORT_RETRY = 1505;

    public const int MQIACH_LONG_TIMER = 1506;

    public const int MQIACH_LONG_RETRY = 1507;

    public const int MQIACH_PUT_AUTHORITY = 1508;

    public const int MQIACH_SEQUENCE_NUMBER_WRAP = 1509;

    public const int MQIACH_MAX_MSG_LENGTH = 1510;

    public const int MQIACH_CHANNEL_TYPE = 1511;

    public const int MQIACH_DATA_COUNT = 1512;

    public const int MQIACH_NAME_COUNT = 1513;

    public const int MQIACH_MSG_SEQUENCE_NUMBER = 1514;

    public const int MQIACH_DATA_CONVERSION = 1515;

    public const int MQIACH_IN_DOUBT = 1516;

    public const int MQIACH_MCA_TYPE = 1517;

    public const int MQIACH_SESSION_COUNT = 1518;

    public const int MQIACH_ADAPTER = 1519;

    public const int MQIACH_COMMAND_COUNT = 1520;

    public const int MQIACH_SOCKET = 1521;

    public const int MQIACH_PORT = 1522;

    public const int MQIACH_CHANNEL_INSTANCE_TYPE = 1523;

    public const int MQIACH_CHANNEL_INSTANCE_ATTRS = 1524;

    public const int MQIACH_CHANNEL_ERROR_DATA = 1525;

    public const int MQIACH_CHANNEL_TABLE = 1526;

    public const int MQIACH_CHANNEL_STATUS = 1527;

    public const int MQIACH_INDOUBT_STATUS = 1528;

    public const int MQIACH_LAST_SEQ_NUMBER = 1529;

    public const int MQIACH_LAST_SEQUENCE_NUMBER = 1529;

    public const int MQIACH_CURRENT_MSGS = 1531;

    public const int MQIACH_CURRENT_SEQ_NUMBER = 1532;

    public const int MQIACH_CURRENT_SEQUENCE_NUMBER = 1532;

    public const int MQIACH_SSL_RETURN_CODE = 1533;

    public const int MQIACH_MSGS = 1534;

    public const int MQIACH_BYTES_SENT = 1535;

    public const int MQIACH_BYTES_RCVD = 1536;

    public const int MQIACH_BYTES_RECEIVED = 1536;

    public const int MQIACH_BATCHES = 1537;

    public const int MQIACH_BUFFERS_SENT = 1538;

    public const int MQIACH_BUFFERS_RCVD = 1539;

    public const int MQIACH_BUFFERS_RECEIVED = 1539;

    public const int MQIACH_LONG_RETRIES_LEFT = 1540;

    public const int MQIACH_SHORT_RETRIES_LEFT = 1541;

    public const int MQIACH_MCA_STATUS = 1542;

    public const int MQIACH_STOP_REQUESTED = 1543;

    public const int MQIACH_MR_COUNT = 1544;

    public const int MQIACH_MR_INTERVAL = 1545;

    public const int MQIACH_NPM_SPEED = 1562;

    public const int MQIACH_HB_INTERVAL = 1563;

    public const int MQIACH_BATCH_INTERVAL = 1564;

    public const int MQIACH_NETWORK_PRIORITY = 1565;

    public const int MQIACH_KEEP_ALIVE_INTERVAL = 1566;

    public const int MQIACH_BATCH_HB = 1567;

    public const int MQIACH_SSL_CLIENT_AUTH = 1568;

    public const int MQIACH_ALLOC_RETRY = 1570;

    public const int MQIACH_ALLOC_FAST_TIMER = 1571;

    public const int MQIACH_ALLOC_SLOW_TIMER = 1572;

    public const int MQIACH_DISC_RETRY = 1573;

    public const int MQIACH_PORT_NUMBER = 1574;

    public const int MQIACH_HDR_COMPRESSION = 1575;

    public const int MQIACH_MSG_COMPRESSION = 1576;

    public const int MQIACH_CLWL_CHANNEL_RANK = 1577;

    public const int MQIACH_CLWL_CHANNEL_PRIORITY = 1578;

    public const int MQIACH_CLWL_CHANNEL_WEIGHT = 1579;

    public const int MQIACH_CHANNEL_DISP = 1580;

    public const int MQIACH_INBOUND_DISP = 1581;

    public const int MQIACH_CHANNEL_TYPES = 1582;

    public const int MQIACH_ADAPS_STARTED = 1583;

    public const int MQIACH_ADAPS_MAX = 1584;

    public const int MQIACH_DISPS_STARTED = 1585;

    public const int MQIACH_DISPS_MAX = 1586;

    public const int MQIACH_SSLTASKS_STARTED = 1587;

    public const int MQIACH_SSLTASKS_MAX = 1588;

    public const int MQIACH_CURRENT_CHL = 1589;

    public const int MQIACH_CURRENT_CHL_MAX = 1590;

    public const int MQIACH_CURRENT_CHL_TCP = 1591;

    public const int MQIACH_CURRENT_CHL_LU62 = 1592;

    public const int MQIACH_ACTIVE_CHL = 1593;

    public const int MQIACH_ACTIVE_CHL_MAX = 1594;

    public const int MQIACH_ACTIVE_CHL_PAUSED = 1595;

    public const int MQIACH_ACTIVE_CHL_STARTED = 1596;

    public const int MQIACH_ACTIVE_CHL_STOPPED = 1597;

    public const int MQIACH_ACTIVE_CHL_RETRY = 1598;

    public const int MQIACH_LISTENER_STATUS = 1599;

    public const int MQIACH_SHARED_CHL_RESTART = 1600;

    public const int MQIACH_LISTENER_CONTROL = 1601;

    public const int MQIACH_BACKLOG = 1602;

    public const int MQIACH_XMITQ_TIME_INDICATOR = 1604;

    public const int MQIACH_NETWORK_TIME_INDICATOR = 1605;

    public const int MQIACH_EXIT_TIME_INDICATOR = 1606;

    public const int MQIACH_BATCH_SIZE_INDICATOR = 1607;

    public const int MQIACH_XMITQ_MSGS_AVAILABLE = 1608;

    public const int MQIACH_CHANNEL_SUBSTATE = 1609;

    public const int MQIACH_SSL_KEY_RESETS = 1610;

    public const int MQIACH_COMPRESSION_RATE = 1611;

    public const int MQIACH_COMPRESSION_TIME = 1612;

    public const int MQIACH_MAX_XMIT_SIZE = 1613;

    public const int MQIACH_DEF_CHANNEL_DISP = 1614;

    public const int MQIACH_SHARING_CONVERSATIONS = 1615;

    public const int MQIACH_MAX_SHARING_CONVS = 1616;

    public const int MQIACH_CURRENT_SHARING_CONVS = 1617;

    public const int MQIACH_MAX_INSTANCES = 1618;

    public const int MQIACH_MAX_INSTS_PER_CLIENT = 1619;

    public const int MQIACH_CLIENT_CHANNEL_WEIGHT = 1620;

    public const int MQIACH_CONNECTION_AFFINITY = 1621;

    public const int MQIACH_RESET_REQUESTED = 1623;

    public const int MQIACH_BATCH_DATA_LIMIT = 1624;

    public const int MQIACH_MSG_HISTORY = 1625;

    public const int MQIACH_MULTICAST_PROPERTIES = 1626;

    public const int MQIACH_NEW_SUBSCRIBER_HISTORY = 1627;

    public const int MQIACH_MC_HB_INTERVAL = 1628;

    public const int MQIACH_USE_CLIENT_ID = 1629;

    public const int MQIACH_MQTT_KEEP_ALIVE = 1630;

    public const int MQIACH_IN_DOUBT_IN = 1631;

    public const int MQIACH_IN_DOUBT_OUT = 1632;

    public const int MQIACH_MSGS_SENT = 1633;

    public const int MQIACH_MSGS_RECEIVED = 1634;

    public const int MQIACH_MSGS_RCVD = 1634;

    public const int MQIACH_PENDING_OUT = 1635;

    public const int MQIACH_AVAILABLE_CIPHERSPECS = 1636;

    public const int MQIACH_MATCH = 1637;

    public const int MQIACH_USER_SOURCE = 1638;

    public const int MQIACH_WARNING = 1639;

    public const int MQIACH_DEF_RECONNECT = 1640;

    public const int MQIACH_CHANNEL_SUMMARY_ATTRS = 1642;

    public const int MQIACH_PROTOCOL = 1643;

    public const int MQIACH_AMQP_KEEP_ALIVE = 1644;

    public const int MQIACH_SECURITY_PROTOCOL = 1645;

    public const int MQIACH_LAST_USED = 1645;

    public const int MQCAMO_FIRST = 2701;

    public const int MQCAMO_CLOSE_DATE = 2701;

    public const int MQCAMO_CLOSE_TIME = 2702;

    public const int MQCAMO_CONN_DATE = 2703;

    public const int MQCAMO_CONN_TIME = 2704;

    public const int MQCAMO_DISC_DATE = 2705;

    public const int MQCAMO_DISC_TIME = 2706;

    public const int MQCAMO_END_DATE = 2707;

    public const int MQCAMO_END_TIME = 2708;

    public const int MQCAMO_OPEN_DATE = 2709;

    public const int MQCAMO_OPEN_TIME = 2710;

    public const int MQCAMO_START_DATE = 2711;

    public const int MQCAMO_START_TIME = 2712;

    public const int MQCAMO_MONITOR_CLASS = 2713;

    public const int MQCAMO_MONITOR_TYPE = 2714;

    public const int MQCAMO_MONITOR_DESC = 2715;

    public const int MQCAMO_LAST_USED = 2715;

    public const int MQCACF_FIRST = 3001;

    public const int MQCACF_FROM_Q_NAME = 3001;

    public const int MQCACF_TO_Q_NAME = 3002;

    public const int MQCACF_FROM_PROCESS_NAME = 3003;

    public const int MQCACF_TO_PROCESS_NAME = 3004;

    public const int MQCACF_FROM_NAMELIST_NAME = 3005;

    public const int MQCACF_TO_NAMELIST_NAME = 3006;

    public const int MQCACF_FROM_CHANNEL_NAME = 3007;

    public const int MQCACF_TO_CHANNEL_NAME = 3008;

    public const int MQCACF_FROM_AUTH_INFO_NAME = 3009;

    public const int MQCACF_TO_AUTH_INFO_NAME = 3010;

    public const int MQCACF_Q_NAMES = 3011;

    public const int MQCACF_PROCESS_NAMES = 3012;

    public const int MQCACF_NAMELIST_NAMES = 3013;

    public const int MQCACF_ESCAPE_TEXT = 3014;

    public const int MQCACF_LOCAL_Q_NAMES = 3015;

    public const int MQCACF_MODEL_Q_NAMES = 3016;

    public const int MQCACF_ALIAS_Q_NAMES = 3017;

    public const int MQCACF_REMOTE_Q_NAMES = 3018;

    public const int MQCACF_SENDER_CHANNEL_NAMES = 3019;

    public const int MQCACF_SERVER_CHANNEL_NAMES = 3020;

    public const int MQCACF_REQUESTER_CHANNEL_NAMES = 3021;

    public const int MQCACF_RECEIVER_CHANNEL_NAMES = 3022;

    public const int MQCACF_OBJECT_Q_MGR_NAME = 3023;

    public const int MQCACF_APPL_NAME = 3024;

    public const int MQCACF_USER_IDENTIFIER = 3025;

    public const int MQCACF_AUX_ERROR_DATA_STR_1 = 3026;

    public const int MQCACF_AUX_ERROR_DATA_STR_2 = 3027;

    public const int MQCACF_AUX_ERROR_DATA_STR_3 = 3028;

    public const int MQCACF_BRIDGE_NAME = 3029;

    public const int MQCACF_STREAM_NAME = 3030;

    public const int MQCACF_TOPIC = 3031;

    public const int MQCACF_PARENT_Q_MGR_NAME = 3032;

    public const int MQCACF_CORREL_ID = 3033;

    public const int MQCACF_PUBLISH_TIMESTAMP = 3034;

    public const int MQCACF_STRING_DATA = 3035;

    public const int MQCACF_SUPPORTED_STREAM_NAME = 3036;

    public const int MQCACF_REG_TOPIC = 3037;

    public const int MQCACF_REG_TIME = 3038;

    public const int MQCACF_REG_USER_ID = 3039;

    public const int MQCACF_CHILD_Q_MGR_NAME = 3040;

    public const int MQCACF_REG_STREAM_NAME = 3041;

    public const int MQCACF_REG_Q_MGR_NAME = 3042;

    public const int MQCACF_REG_Q_NAME = 3043;

    public const int MQCACF_REG_CORREL_ID = 3044;

    public const int MQCACF_EVENT_USER_ID = 3045;

    public const int MQCACF_OBJECT_NAME = 3046;

    public const int MQCACF_EVENT_Q_MGR = 3047;

    public const int MQCACF_AUTH_INFO_NAMES = 3048;

    public const int MQCACF_EVENT_APPL_IDENTITY = 3049;

    public const int MQCACF_EVENT_APPL_NAME = 3050;

    public const int MQCACF_EVENT_APPL_ORIGIN = 3051;

    public const int MQCACF_SUBSCRIPTION_NAME = 3052;

    public const int MQCACF_REG_SUB_NAME = 3053;

    public const int MQCACF_SUBSCRIPTION_IDENTITY = 3054;

    public const int MQCACF_REG_SUB_IDENTITY = 3055;

    public const int MQCACF_SUBSCRIPTION_USER_DATA = 3056;

    public const int MQCACF_REG_SUB_USER_DATA = 3057;

    public const int MQCACF_APPL_TAG = 3058;

    public const int MQCACF_DATA_SET_NAME = 3059;

    public const int MQCACF_UOW_START_DATE = 3060;

    public const int MQCACF_UOW_START_TIME = 3061;

    public const int MQCACF_UOW_LOG_START_DATE = 3062;

    public const int MQCACF_UOW_LOG_START_TIME = 3063;

    public const int MQCACF_UOW_LOG_EXTENT_NAME = 3064;

    public const int MQCACF_PRINCIPAL_ENTITY_NAMES = 3065;

    public const int MQCACF_GROUP_ENTITY_NAMES = 3066;

    public const int MQCACF_AUTH_PROFILE_NAME = 3067;

    public const int MQCACF_ENTITY_NAME = 3068;

    public const int MQCACF_SERVICE_COMPONENT = 3069;

    public const int MQCACF_RESPONSE_Q_MGR_NAME = 3070;

    public const int MQCACF_CURRENT_LOG_EXTENT_NAME = 3071;

    public const int MQCACF_RESTART_LOG_EXTENT_NAME = 3072;

    public const int MQCACF_MEDIA_LOG_EXTENT_NAME = 3073;

    public const int MQCACF_LOG_PATH = 3074;

    public const int MQCACF_COMMAND_MQSC = 3075;

    public const int MQCACF_Q_MGR_CPF = 3076;

    public const int MQCACF_USAGE_LOG_RBA = 3078;

    public const int MQCACF_USAGE_LOG_LRSN = 3079;

    public const int MQCACF_COMMAND_SCOPE = 3080;

    public const int MQCACF_ASID = 3081;

    public const int MQCACF_PSB_NAME = 3082;

    public const int MQCACF_PST_ID = 3083;

    public const int MQCACF_TASK_NUMBER = 3084;

    public const int MQCACF_TRANSACTION_ID = 3085;

    public const int MQCACF_Q_MGR_UOW_ID = 3086;

    public const int MQCACF_ORIGIN_NAME = 3088;

    public const int MQCACF_ENV_INFO = 3089;

    public const int MQCACF_SECURITY_PROFILE = 3090;

    public const int MQCACF_CONFIGURATION_DATE = 3091;

    public const int MQCACF_CONFIGURATION_TIME = 3092;

    public const int MQCACF_FROM_CF_STRUC_NAME = 3093;

    public const int MQCACF_TO_CF_STRUC_NAME = 3094;

    public const int MQCACF_CF_STRUC_NAMES = 3095;

    public const int MQCACF_FAIL_DATE = 3096;

    public const int MQCACF_FAIL_TIME = 3097;

    public const int MQCACF_BACKUP_DATE = 3098;

    public const int MQCACF_BACKUP_TIME = 3099;

    public const int MQCACF_SYSTEM_NAME = 3100;

    public const int MQCACF_CF_STRUC_BACKUP_START = 3101;

    public const int MQCACF_CF_STRUC_BACKUP_END = 3102;

    public const int MQCACF_CF_STRUC_LOG_Q_MGRS = 3103;

    public const int MQCACF_FROM_STORAGE_CLASS = 3104;

    public const int MQCACF_TO_STORAGE_CLASS = 3105;

    public const int MQCACF_STORAGE_CLASS_NAMES = 3106;

    public const int MQCACF_DSG_NAME = 3108;

    public const int MQCACF_DB2_NAME = 3109;

    public const int MQCACF_SYSP_CMD_USER_ID = 3110;

    public const int MQCACF_SYSP_OTMA_GROUP = 3111;

    public const int MQCACF_SYSP_OTMA_MEMBER = 3112;

    public const int MQCACF_SYSP_OTMA_DRU_EXIT = 3113;

    public const int MQCACF_SYSP_OTMA_TPIPE_PFX = 3114;

    public const int MQCACF_SYSP_ARCHIVE_PFX1 = 3115;

    public const int MQCACF_SYSP_ARCHIVE_UNIT1 = 3116;

    public const int MQCACF_SYSP_LOG_CORREL_ID = 3117;

    public const int MQCACF_SYSP_UNIT_VOLSER = 3118;

    public const int MQCACF_SYSP_Q_MGR_TIME = 3119;

    public const int MQCACF_SYSP_Q_MGR_DATE = 3120;

    public const int MQCACF_SYSP_Q_MGR_RBA = 3121;

    public const int MQCACF_SYSP_LOG_RBA = 3122;

    public const int MQCACF_SYSP_SERVICE = 3123;

    public const int MQCACF_FROM_LISTENER_NAME = 3124;

    public const int MQCACF_TO_LISTENER_NAME = 3125;

    public const int MQCACF_FROM_SERVICE_NAME = 3126;

    public const int MQCACF_TO_SERVICE_NAME = 3127;

    public const int MQCACF_LAST_PUT_DATE = 3128;

    public const int MQCACF_LAST_PUT_TIME = 3129;

    public const int MQCACF_LAST_GET_DATE = 3130;

    public const int MQCACF_LAST_GET_TIME = 3131;

    public const int MQCACF_OPERATION_DATE = 3132;

    public const int MQCACF_OPERATION_TIME = 3133;

    public const int MQCACF_ACTIVITY_DESC = 3134;

    public const int MQCACF_APPL_IDENTITY_DATA = 3135;

    public const int MQCACF_APPL_ORIGIN_DATA = 3136;

    public const int MQCACF_PUT_DATE = 3137;

    public const int MQCACF_PUT_TIME = 3138;

    public const int MQCACF_REPLY_TO_Q = 3139;

    public const int MQCACF_REPLY_TO_Q_MGR = 3140;

    public const int MQCACF_RESOLVED_Q_NAME = 3141;

    public const int MQCACF_STRUC_ID = 3142;

    public const int MQCACF_VALUE_NAME = 3143;

    public const int MQCACF_SERVICE_START_DATE = 3144;

    public const int MQCACF_SERVICE_START_TIME = 3145;

    public const int MQCACF_SYSP_OFFLINE_RBA = 3146;

    public const int MQCACF_SYSP_ARCHIVE_PFX2 = 3147;

    public const int MQCACF_SYSP_ARCHIVE_UNIT2 = 3148;

    public const int MQCACF_TO_TOPIC_NAME = 3149;

    public const int MQCACF_FROM_TOPIC_NAME = 3150;

    public const int MQCACF_TOPIC_NAMES = 3151;

    public const int MQCACF_SUB_NAME = 3152;

    public const int MQCACF_DESTINATION_Q_MGR = 3153;

    public const int MQCACF_DESTINATION = 3154;

    public const int MQCACF_SUB_USER_ID = 3156;

    public const int MQCACF_SUB_USER_DATA = 3159;

    public const int MQCACF_SUB_SELECTOR = 3160;

    public const int MQCACF_LAST_PUB_DATE = 3161;

    public const int MQCACF_LAST_PUB_TIME = 3162;

    public const int MQCACF_FROM_SUB_NAME = 3163;

    public const int MQCACF_TO_SUB_NAME = 3164;

    public const int MQCACF_LAST_MSG_TIME = 3167;

    public const int MQCACF_LAST_MSG_DATE = 3168;

    public const int MQCACF_SUBSCRIPTION_POINT = 3169;

    public const int MQCACF_FILTER = 3170;

    public const int MQCACF_NONE = 3171;

    public const int MQCACF_ADMIN_TOPIC_NAMES = 3172;

    public const int MQCACF_ROUTING_FINGER_PRINT = 3173;

    public const int MQCACF_APPL_DESC = 3174;

    public const int MQCACF_Q_MGR_START_DATE = 3175;

    public const int MQCACF_Q_MGR_START_TIME = 3176;

    public const int MQCACF_FROM_COMM_INFO_NAME = 3177;

    public const int MQCACF_TO_COMM_INFO_NAME = 3178;

    public const int MQCACF_CF_OFFLOAD_SIZE1 = 3179;

    public const int MQCACF_CF_OFFLOAD_SIZE2 = 3180;

    public const int MQCACF_CF_OFFLOAD_SIZE3 = 3181;

    public const int MQCACF_CF_SMDS_GENERIC_NAME = 3182;

    public const int MQCACF_CF_SMDS = 3183;

    public const int MQCACF_RECOVERY_DATE = 3184;

    public const int MQCACF_RECOVERY_TIME = 3185;

    public const int MQCACF_CF_SMDSCONN = 3186;

    public const int MQCACF_CF_STRUC_NAME = 3187;

    public const int MQCACF_ALTERNATE_USERID = 3188;

    public const int MQCACF_CHAR_ATTRS = 3189;

    public const int MQCACF_DYNAMIC_Q_NAME = 3190;

    public const int MQCACF_HOST_NAME = 3191;

    public const int MQCACF_MQCB_NAME = 3192;

    public const int MQCACF_OBJECT_STRING = 3193;

    public const int MQCACF_RESOLVED_LOCAL_Q_MGR = 3194;

    public const int MQCACF_RESOLVED_LOCAL_Q_NAME = 3195;

    public const int MQCACF_RESOLVED_OBJECT_STRING = 3196;

    public const int MQCACF_RESOLVED_Q_MGR = 3197;

    public const int MQCACF_SELECTION_STRING = 3198;

    public const int MQCACF_XA_INFO = 3199;

    public const int MQCACF_APPL_FUNCTION = 3200;

    public const int MQCACF_XQH_REMOTE_Q_NAME = 3201;

    public const int MQCACF_XQH_REMOTE_Q_MGR = 3202;

    public const int MQCACF_XQH_PUT_TIME = 3203;

    public const int MQCACF_XQH_PUT_DATE = 3204;

    public const int MQCACF_EXCL_OPERATOR_MESSAGES = 3205;

    public const int MQCACF_CSP_USER_IDENTIFIER = 3206;

    public const int MQCACF_AMQP_CLIENT_ID = 3207;

    public const int MQCACF_LAST_USED = 3207;

    public const int MQCACH_FIRST = 3501;

    public const int MQCACH_CHANNEL_NAME = 3501;

    public const int MQCACH_DESC = 3502;

    public const int MQCACH_MODE_NAME = 3503;

    public const int MQCACH_TP_NAME = 3504;

    public const int MQCACH_XMIT_Q_NAME = 3505;

    public const int MQCACH_CONNECTION_NAME = 3506;

    public const int MQCACH_MCA_NAME = 3507;

    public const int MQCACH_SEC_EXIT_NAME = 3508;

    public const int MQCACH_MSG_EXIT_NAME = 3509;

    public const int MQCACH_SEND_EXIT_NAME = 3510;

    public const int MQCACH_RCV_EXIT_NAME = 3511;

    public const int MQCACH_CHANNEL_NAMES = 3512;

    public const int MQCACH_SEC_EXIT_USER_DATA = 3513;

    public const int MQCACH_MSG_EXIT_USER_DATA = 3514;

    public const int MQCACH_SEND_EXIT_USER_DATA = 3515;

    public const int MQCACH_RCV_EXIT_USER_DATA = 3516;

    public const int MQCACH_USER_ID = 3517;

    public const int MQCACH_PASSWORD = 3518;

    public const int MQCACH_LOCAL_ADDRESS = 3520;

    public const int MQCACH_LOCAL_NAME = 3521;

    public const int MQCACH_LAST_MSG_TIME = 3524;

    public const int MQCACH_LAST_MSG_DATE = 3525;

    public const int MQCACH_MCA_USER_ID = 3527;

    public const int MQCACH_CHANNEL_START_TIME = 3528;

    public const int MQCACH_CHANNEL_START_DATE = 3529;

    public const int MQCACH_MCA_JOB_NAME = 3530;

    public const int MQCACH_LAST_LUWID = 3531;

    public const int MQCACH_CURRENT_LUWID = 3532;

    public const int MQCACH_FORMAT_NAME = 3533;

    public const int MQCACH_MR_EXIT_NAME = 3534;

    public const int MQCACH_MR_EXIT_USER_DATA = 3535;

    public const int MQCACH_SSL_CIPHER_SPEC = 3544;

    public const int MQCACH_SSL_PEER_NAME = 3545;

    public const int MQCACH_SSL_HANDSHAKE_STAGE = 3546;

    public const int MQCACH_SSL_SHORT_PEER_NAME = 3547;

    public const int MQCACH_REMOTE_APPL_TAG = 3548;

    public const int MQCACH_SSL_CERT_USER_ID = 3549;

    public const int MQCACH_SSL_CERT_ISSUER_NAME = 3550;

    public const int MQCACH_LU_NAME = 3551;

    public const int MQCACH_IP_ADDRESS = 3552;

    public const int MQCACH_TCP_NAME = 3553;

    public const int MQCACH_LISTENER_NAME = 3554;

    public const int MQCACH_LISTENER_DESC = 3555;

    public const int MQCACH_LISTENER_START_DATE = 3556;

    public const int MQCACH_LISTENER_START_TIME = 3557;

    public const int MQCACH_SSL_KEY_RESET_DATE = 3558;

    public const int MQCACH_SSL_KEY_RESET_TIME = 3559;

    public const int MQCACH_REMOTE_VERSION = 3560;

    public const int MQCACH_REMOTE_PRODUCT = 3561;

    public const int MQCACH_GROUP_ADDRESS = 3562;

    public const int MQCACH_JAAS_CONFIG = 3563;

    public const int MQCACH_CLIENT_ID = 3564;

    public const int MQCACH_SSL_KEY_PASSPHRASE = 3565;

    public const int MQCACH_CONNECTION_NAME_LIST = 3566;

    public const int MQCACH_CLIENT_USER_ID = 3567;

    public const int MQCACH_MCA_USER_ID_LIST = 3568;

    public const int MQCACH_SSL_CIPHER_SUITE = 3569;

    public const int MQCACH_WEBCONTENT_PATH = 3570;

    public const int MQCACH_LAST_USED = 3570;

    public const int MQGACF_FIRST = 8001;

    public const int MQGACF_COMMAND_CONTEXT = 8001;

    public const int MQGACF_COMMAND_DATA = 8002;

    public const int MQGACF_TRACE_ROUTE = 8003;

    public const int MQGACF_OPERATION = 8004;

    public const int MQGACF_ACTIVITY = 8005;

    public const int MQGACF_EMBEDDED_MQMD = 8006;

    public const int MQGACF_MESSAGE = 8007;

    public const int MQGACF_MQMD = 8008;

    public const int MQGACF_VALUE_NAMING = 8009;

    public const int MQGACF_Q_ACCOUNTING_DATA = 8010;

    public const int MQGACF_Q_STATISTICS_DATA = 8011;

    public const int MQGACF_CHL_STATISTICS_DATA = 8012;

    public const int MQGACF_ACTIVITY_TRACE = 8013;

    public const int MQGACF_APP_DIST_LIST = 8014;

    public const int MQGACF_MONITOR_CLASS = 8015;

    public const int MQGACF_MONITOR_TYPE = 8016;

    public const int MQGACF_MONITOR_ELEMENT = 8017;

    public const int MQGACF_LAST_USED = 8017;

    public const int MQACT_FORCE_REMOVE = 1;

    public const int MQACT_ADVANCE_LOG = 2;

    public const int MQACT_COLLECT_STATISTICS = 3;

    public const int MQACT_PUBSUB = 4;

    public const int MQACT_ADD = 5;

    public const int MQACT_REPLACE = 6;

    public const int MQACT_REMOVE = 7;

    public const int MQACT_REMOVEALL = 8;

    public const int MQACT_FAIL = 9;

    public const int MQAS_NONE = 0;

    public const int MQAS_STARTED = 1;

    public const int MQAS_START_WAIT = 2;

    public const int MQAS_STOPPED = 3;

    public const int MQAS_SUSPENDED = 4;

    public const int MQAS_SUSPENDED_TEMPORARY = 5;

    public const int MQAS_ACTIVE = 6;

    public const int MQAS_INACTIVE = 7;

    public const int MQAUTH_NONE = 0;

    public const int MQAUTH_ALT_USER_AUTHORITY = 1;

    public const int MQAUTH_BROWSE = 2;

    public const int MQAUTH_CHANGE = 3;

    public const int MQAUTH_CLEAR = 4;

    public const int MQAUTH_CONNECT = 5;

    public const int MQAUTH_CREATE = 6;

    public const int MQAUTH_DELETE = 7;

    public const int MQAUTH_DISPLAY = 8;

    public const int MQAUTH_INPUT = 9;

    public const int MQAUTH_INQUIRE = 10;

    public const int MQAUTH_OUTPUT = 11;

    public const int MQAUTH_PASS_ALL_CONTEXT = 12;

    public const int MQAUTH_PASS_IDENTITY_CONTEXT = 13;

    public const int MQAUTH_SET = 14;

    public const int MQAUTH_SET_ALL_CONTEXT = 15;

    public const int MQAUTH_SET_IDENTITY_CONTEXT = 16;

    public const int MQAUTH_CONTROL = 17;

    public const int MQAUTH_CONTROL_EXTENDED = 18;

    public const int MQAUTH_PUBLISH = 19;

    public const int MQAUTH_SUBSCRIBE = 20;

    public const int MQAUTH_RESUME = 21;

    public const int MQAUTH_SYSTEM = 22;

    public const int MQAUTH_ALL = -1;

    public const int MQAUTH_ALL_ADMIN = -2;

    public const int MQAUTH_ALL_MQI = -3;

    public const int MQAUTHOPT_ENTITY_EXPLICIT = 1;

    public const int MQAUTHOPT_ENTITY_SET = 2;

    public const int MQAUTHOPT_NAME_EXPLICIT = 16;

    public const int MQAUTHOPT_NAME_ALL_MATCHING = 32;

    public const int MQAUTHOPT_NAME_AS_WILDCARD = 64;

    public const int MQAUTHOPT_CUMULATIVE = 256;

    public const int MQAUTHOPT_EXCLUDE_TEMP = 512;

    public const int MQBT_OTMA = 1;

    public const int MQCFO_REFRESH_REPOSITORY_YES = 1;

    public const int MQCFO_REFRESH_REPOSITORY_NO = 0;

    public const int MQCFO_REMOVE_QUEUES_YES = 1;

    public const int MQCFO_REMOVE_QUEUES_NO = 0;

    public const int MQCAUT_ALL = 0;

    public const int MQCAUT_BLOCKUSER = 1;

    public const int MQCAUT_BLOCKADDR = 2;

    public const int MQCAUT_SSLPEERMAP = 3;

    public const int MQCAUT_ADDRESSMAP = 4;

    public const int MQCAUT_USERMAP = 5;

    public const int MQCAUT_QMGRMAP = 6;

    public const int MQCFSTATUS_NOT_FOUND = 0;

    public const int MQCFSTATUS_ACTIVE = 1;

    public const int MQCFSTATUS_IN_RECOVER = 2;

    public const int MQCFSTATUS_IN_BACKUP = 3;

    public const int MQCFSTATUS_FAILED = 4;

    public const int MQCFSTATUS_NONE = 5;

    public const int MQCFSTATUS_UNKNOWN = 6;

    public const int MQCFSTATUS_RECOVERED = 7;

    public const int MQCFSTATUS_EMPTY = 8;

    public const int MQCFSTATUS_NEW = 9;

    public const int MQCFSTATUS_ADMIN_INCOMPLETE = 20;

    public const int MQCFSTATUS_NEVER_USED = 21;

    public const int MQCFSTATUS_NO_BACKUP = 22;

    public const int MQCFSTATUS_NOT_FAILED = 23;

    public const int MQCFSTATUS_NOT_RECOVERABLE = 24;

    public const int MQCFSTATUS_XES_ERROR = 25;

    public const int MQCFTYPE_APPL = 0;

    public const int MQCFTYPE_ADMIN = 1;

    public const int MQCHIDS_NOT_INDOUBT = 0;

    public const int MQCHIDS_INDOUBT = 1;

    public const int MQCHLD_ALL = -1;

    public const int MQCHLD_DEFAULT = 1;

    public const int MQCHLD_SHARED = 2;

    public const int MQCHLD_PRIVATE = 4;

    public const int MQCHLD_FIXSHARED = 5;

    public const int MQUCI_YES = 1;

    public const int MQUCI_NO = 0;

    public const int MQCHS_INACTIVE = 0;

    public const int MQCHS_BINDING = 1;

    public const int MQCHS_STARTING = 2;

    public const int MQCHS_RUNNING = 3;

    public const int MQCHS_STOPPING = 4;

    public const int MQCHS_RETRYING = 5;

    public const int MQCHS_STOPPED = 6;

    public const int MQCHS_REQUESTING = 7;

    public const int MQCHS_PAUSED = 8;

    public const int MQCHS_DISCONNECTED = 9;

    public const int MQCHS_INITIALIZING = 13;

    public const int MQCHS_SWITCHING = 14;

    public const int MQCHSSTATE_OTHER = 0;

    public const int MQCHSSTATE_END_OF_BATCH = 100;

    public const int MQCHSSTATE_SENDING = 200;

    public const int MQCHSSTATE_RECEIVING = 300;

    public const int MQCHSSTATE_SERIALIZING = 400;

    public const int MQCHSSTATE_RESYNCHING = 500;

    public const int MQCHSSTATE_HEARTBEATING = 600;

    public const int MQCHSSTATE_IN_SCYEXIT = 700;

    public const int MQCHSSTATE_IN_RCVEXIT = 800;

    public const int MQCHSSTATE_IN_SENDEXIT = 900;

    public const int MQCHSSTATE_IN_MSGEXIT = 1000;

    public const int MQCHSSTATE_IN_MREXIT = 1100;

    public const int MQCHSSTATE_IN_CHADEXIT = 1200;

    public const int MQCHSSTATE_NET_CONNECTING = 1250;

    public const int MQCHSSTATE_SSL_HANDSHAKING = 1300;

    public const int MQCHSSTATE_NAME_SERVER = 1400;

    public const int MQCHSSTATE_IN_MQPUT = 1500;

    public const int MQCHSSTATE_IN_MQGET = 1600;

    public const int MQCHSSTATE_IN_MQI_CALL = 1700;

    public const int MQCHSSTATE_COMPRESSING = 1800;

    public const int MQCHSH_RESTART_NO = 0;

    public const int MQCHSH_RESTART_YES = 1;

    public const int MQCHSR_STOP_NOT_REQUESTED = 0;

    public const int MQCHSR_STOP_REQUESTED = 1;

    public const int MQCHRR_RESET_NOT_REQUESTED = 0;

    public const int MQCHTAB_Q_MGR = 1;

    public const int MQCHTAB_CLNTCONN = 2;

    public const int MQCLRS_LOCAL = 1;

    public const int MQCLRS_GLOBAL = 2;

    public const int MQCLRT_RETAINED = 1;

    public const int MQCMDI_CMDSCOPE_ACCEPTED = 1;

    public const int MQCMDI_CMDSCOPE_GENERATED = 2;

    public const int MQCMDI_CMDSCOPE_COMPLETED = 3;

    public const int MQCMDI_QSG_DISP_COMPLETED = 4;

    public const int MQCMDI_COMMAND_ACCEPTED = 5;

    public const int MQCMDI_CLUSTER_REQUEST_QUEUED = 6;

    public const int MQCMDI_CHANNEL_INIT_STARTED = 7;

    public const int MQCMDI_RECOVER_STARTED = 11;

    public const int MQCMDI_BACKUP_STARTED = 12;

    public const int MQCMDI_RECOVER_COMPLETED = 13;

    public const int MQCMDI_SEC_TIMER_ZERO = 14;

    public const int MQCMDI_REFRESH_CONFIGURATION = 16;

    public const int MQCMDI_SEC_SIGNOFF_ERROR = 17;

    public const int MQCMDI_IMS_BRIDGE_SUSPENDED = 18;

    public const int MQCMDI_DB2_SUSPENDED = 19;

    public const int MQCMDI_DB2_OBSOLETE_MSGS = 20;

    public const int MQCMDI_SEC_UPPERCASE = 21;

    public const int MQCMDI_SEC_MIXEDCASE = 22;

    public const int MQDISCONNECT_NORMAL = 0;

    public const int MQDISCONNECT_IMPLICIT = 1;

    public const int MQDISCONNECT_Q_MGR = 2;

    public const int MQET_MQSC = 1;

    public const int MQEVO_OTHER = 0;

    public const int MQEVO_CONSOLE = 1;

    public const int MQEVO_INIT = 2;

    public const int MQEVO_MSG = 3;

    public const int MQEVO_MQSET = 4;

    public const int MQEVO_INTERNAL = 5;

    public const int MQEVO_MQSUB = 6;

    public const int MQEVO_CTLMSG = 7;

    public const int MQEVR_DISABLED = 0;

    public const int MQEVR_ENABLED = 1;

    public const int MQEVR_EXCEPTION = 2;

    public const int MQEVR_NO_DISPLAY = 3;

    public const int MQEVR_API_ONLY = 4;

    public const int MQEVR_ADMIN_ONLY = 5;

    public const int MQEVR_USER_ONLY = 6;

    public const int MQFC_YES = 1;

    public const int MQFC_NO = 0;

    public const int MQHSTATE_INACTIVE = 0;

    public const int MQHSTATE_ACTIVE = 1;

    public const int MQINBD_Q_MGR = 0;

    public const int MQINBD_GROUP = 3;

    public const int MQIDO_COMMIT = 1;

    public const int MQIDO_BACKOUT = 2;

    public const int MQMATCH_GENERIC = 0;

    public const int MQMATCH_RUNCHECK = 1;

    public const int MQMATCH_EXACT = 2;

    public const int MQMATCH_ALL = 3;

    public const int MQMCAS_STOPPED = 0;

    public const int MQMCAS_RUNNING = 3;

    public const int MQMODE_FORCE = 0;

    public const int MQMODE_QUIESCE = 1;

    public const int MQMODE_TERMINATE = 2;

    public const int MQMLP_TOLERATE_UNPROTECTED_NO = 0;

    public const int MQMLP_TOLERATE_UNPROTECTED_YES = 1;

    public const int MQMLP_ENCRYPTION_ALG_NONE = 0;

    public const int MQMLP_ENCRYPTION_ALG_RC2 = 1;

    public const int MQMLP_ENCRYPTION_ALG_DES = 2;

    public const int MQMLP_ENCRYPTION_ALG_3DES = 3;

    public const int MQMLP_ENCRYPTION_ALG_AES128 = 4;

    public const int MQMLP_ENCRYPTION_ALG_AES256 = 5;

    public const int MQMLP_SIGN_ALG_NONE = 0;

    public const int MQMLP_SIGN_ALG_MD5 = 1;

    public const int MQMLP_SIGN_ALG_SHA1 = 2;

    public const int MQMLP_SIGN_ALG_SHA224 = 3;

    public const int MQMLP_SIGN_ALG_SHA256 = 4;

    public const int MQMLP_SIGN_ALG_SHA384 = 5;

    public const int MQMLP_SIGN_ALG_SHA512 = 6;

    public const int MQPO_YES = 1;

    public const int MQPO_NO = 0;

    public const int MQPSCT_NONE = -1;

    public const int MQPSST_ALL = 0;

    public const int MQPSST_LOCAL = 1;

    public const int MQPSST_PARENT = 2;

    public const int MQPSST_CHILD = 3;

    public const int MQPS_STATUS_INACTIVE = 0;

    public const int MQPS_STATUS_STARTING = 1;

    public const int MQPS_STATUS_STOPPING = 2;

    public const int MQPS_STATUS_ACTIVE = 3;

    public const int MQPS_STATUS_COMPAT = 4;

    public const int MQPS_STATUS_ERROR = 5;

    public const int MQPS_STATUS_REFUSED = 6;

    public const int MQQMDT_EXPLICIT_CLUSTER_SENDER = 1;

    public const int MQQMDT_AUTO_CLUSTER_SENDER = 2;

    public const int MQQMDT_AUTO_EXP_CLUSTER_SENDER = 4;

    public const int MQQMDT_CLUSTER_RECEIVER = 3;

    public const int MQQMFAC_IMS_BRIDGE = 1;

    public const int MQQMFAC_DB2 = 2;

    public const int MQQMSTA_STARTING = 1;

    public const int MQQMSTA_RUNNING = 2;

    public const int MQQMSTA_QUIESCING = 3;

    public const int MQQMSTA_STANDBY = 4;

    public const int MQQMT_NORMAL = 0;

    public const int MQQMT_REPOSITORY = 1;

    public const int MQQO_YES = 1;

    public const int MQQO_NO = 0;

    public const int MQQSIE_NONE = 0;

    public const int MQQSIE_HIGH = 1;

    public const int MQQSIE_OK = 2;

    public const int MQQSOT_ALL = 1;

    public const int MQQSOT_INPUT = 2;

    public const int MQQSOT_OUTPUT = 3;

    public const int MQQSGS_UNKNOWN = 0;

    public const int MQQSGS_CREATED = 1;

    public const int MQQSGS_ACTIVE = 2;

    public const int MQQSGS_INACTIVE = 3;

    public const int MQQSGS_FAILED = 4;

    public const int MQQSGS_PENDING = 5;

    public const int MQQSO_NO = 0;

    public const int MQQSO_YES = 1;

    public const int MQQSO_SHARED = 1;

    public const int MQQSO_EXCLUSIVE = 2;

    public const int MQQSUM_YES = 1;

    public const int MQQSUM_NO = 0;

    public const int MQRAR_YES = 1;

    public const int MQRAR_NO = 0;

    public const int MQRP_YES = 1;

    public const int MQRP_NO = 0;

    public const int MQRQ_CONN_NOT_AUTHORIZED = 1;

    public const int MQRQ_OPEN_NOT_AUTHORIZED = 2;

    public const int MQRQ_CLOSE_NOT_AUTHORIZED = 3;

    public const int MQRQ_CMD_NOT_AUTHORIZED = 4;

    public const int MQRQ_Q_MGR_STOPPING = 5;

    public const int MQRQ_Q_MGR_QUIESCING = 6;

    public const int MQRQ_CHANNEL_STOPPED_OK = 7;

    public const int MQRQ_CHANNEL_STOPPED_ERROR = 8;

    public const int MQRQ_CHANNEL_STOPPED_RETRY = 9;

    public const int MQRQ_CHANNEL_STOPPED_DISABLED = 10;

    public const int MQRQ_BRIDGE_STOPPED_OK = 11;

    public const int MQRQ_BRIDGE_STOPPED_ERROR = 12;

    public const int MQRQ_SSL_HANDSHAKE_ERROR = 13;

    public const int MQRQ_SSL_CIPHER_SPEC_ERROR = 14;

    public const int MQRQ_SSL_CLIENT_AUTH_ERROR = 15;

    public const int MQRQ_SSL_PEER_NAME_ERROR = 16;

    public const int MQRQ_SUB_NOT_AUTHORIZED = 17;

    public const int MQRQ_SUB_DEST_NOT_AUTHORIZED = 18;

    public const int MQRQ_SSL_UNKNOWN_REVOCATION = 19;

    public const int MQRQ_SYS_CONN_NOT_AUTHORIZED = 20;

    public const int MQRQ_CHANNEL_BLOCKED_ADDRESS = 21;

    public const int MQRQ_CHANNEL_BLOCKED_USERID = 22;

    public const int MQRQ_CHANNEL_BLOCKED_NOACCESS = 23;

    public const int MQRQ_MAX_ACTIVE_CHANNELS = 24;

    public const int MQRQ_MAX_CHANNELS = 25;

    public const int MQRQ_SVRCONN_INST_LIMIT = 26;

    public const int MQRQ_CLIENT_INST_LIMIT = 27;

    public const int MQRQ_CAF_NOT_INSTALLED = 28;

    public const int MQRQ_CSP_NOT_AUTHORIZED = 29;

    public const int MQRQ_FAILOVER_PERMITTED = 30;

    public const int MQRQ_FAILOVER_NOT_PERMITTED = 31;

    public const int MQRQ_STANDBY_ACTIVATED = 32;

    public const int MQRT_CONFIGURATION = 1;

    public const int MQRT_EXPIRY = 2;

    public const int MQRT_NSPROC = 3;

    public const int MQRT_PROXYSUB = 4;

    public const int MQRT_SUB_CONFIGURATION = 5;

    public const int MQSCO_Q_MGR = 1;

    public const int MQSCO_CELL = 2;

    public const int MQSECITEM_ALL = 0;

    public const int MQSECITEM_MQADMIN = 1;

    public const int MQSECITEM_MQNLIST = 2;

    public const int MQSECITEM_MQPROC = 3;

    public const int MQSECITEM_MQQUEUE = 4;

    public const int MQSECITEM_MQCONN = 5;

    public const int MQSECITEM_MQCMDS = 6;

    public const int MQSECITEM_MXADMIN = 7;

    public const int MQSECITEM_MXNLIST = 8;

    public const int MQSECITEM_MXPROC = 9;

    public const int MQSECITEM_MXQUEUE = 10;

    public const int MQSECITEM_MXTOPIC = 11;

    public const int MQSECSW_PROCESS = 1;

    public const int MQSECSW_NAMELIST = 2;

    public const int MQSECSW_Q = 3;

    public const int MQSECSW_TOPIC = 4;

    public const int MQSECSW_CONTEXT = 6;

    public const int MQSECSW_ALTERNATE_USER = 7;

    public const int MQSECSW_COMMAND = 8;

    public const int MQSECSW_CONNECTION = 9;

    public const int MQSECSW_SUBSYSTEM = 10;

    public const int MQSECSW_COMMAND_RESOURCES = 11;

    public const int MQSECSW_Q_MGR = 15;

    public const int MQSECSW_QSG = 16;

    public const int MQSECSW_OFF_FOUND = 21;

    public const int MQSECSW_ON_FOUND = 22;

    public const int MQSECSW_OFF_NOT_FOUND = 23;

    public const int MQSECSW_ON_NOT_FOUND = 24;

    public const int MQSECSW_OFF_ERROR = 25;

    public const int MQSECSW_ON_OVERRIDDEN = 26;

    public const int MQSECTYPE_AUTHSERV = 1;

    public const int MQSECTYPE_SSL = 2;

    public const int MQSECTYPE_CLASSES = 3;

    public const int MQSECTYPE_CONNAUTH = 4;

    public const int MQCHK_OPTIONAL = 0;

    public const int MQCHK_NONE = 1;

    public const int MQCHK_REQUIRED_ADMIN = 2;

    public const int MQCHK_REQUIRED = 3;

    public const int MQCHK_AS_Q_MGR = 4;

    public const int MQADPCTX_NO = 0;

    public const int MQADPCTX_YES = 1;

    public const int MQSECCOMM_NO = 0;

    public const int MQSECCOMM_YES = 1;

    public const int MQSECCOMM_ANON = 2;

    public const int MQLDAP_AUTHORMD_OS = 0;

    public const int MQLDAP_AUTHORMD_SEARCHGRP = 1;

    public const int MQLDAP_AUTHORMD_SEARCHUSR = 2;

    public const int MQLDAP_NESTGRP_NO = 0;

    public const int MQLDAP_NESTGRP_YES = 1;

    public const int MQAUTHENTICATE_OS = 0;

    public const int MQAUTHENTICATE_PAM = 1;

    public const int MQLDAPC_INACTIVE = 0;

    public const int MQLDAPC_CONNECTED = 1;

    public const int MQLDAPC_ERROR = 2;

    public const int MQSELTYPE_NONE = 0;

    public const int MQSELTYPE_STANDARD = 1;

    public const int MQSELTYPE_EXTENDED = 2;

    public const int MQCHLA_DISABLED = 0;

    public const int MQCHLA_ENABLED = 1;

    public const int MQRDNS_ENABLED = 0;

    public const int MQRDNS_DISABLED = 1;

    public const int MQCLROUTE_DIRECT = 0;

    public const int MQCLROUTE_TOPIC_HOST = 1;

    public const int MQCLROUTE_NONE = 2;

    public const int MQCLST_ACTIVE = 0;

    public const int MQCLST_PENDING = 1;

    public const int MQCLST_INVALID = 2;

    public const int MQCLST_ERROR = 3;

    public const int MQCLXQ_SCTQ = 0;

    public const int MQCLXQ_CHANNEL = 1;

    public const int MQSUS_YES = 1;

    public const int MQSUS_NO = 0;

    public const int MQSYNCPOINT_YES = 0;

    public const int MQSYNCPOINT_IFPER = 1;

    public const int MQSYSP_NO = 0;

    public const int MQSYSP_YES = 1;

    public const int MQSYSP_EXTENDED = 2;

    public const int MQSYSP_TYPE_INITIAL = 10;

    public const int MQSYSP_TYPE_SET = 11;

    public const int MQSYSP_TYPE_LOG_COPY = 12;

    public const int MQSYSP_TYPE_LOG_STATUS = 13;

    public const int MQSYSP_TYPE_ARCHIVE_TAPE = 14;

    public const int MQSYSP_ALLOC_BLK = 20;

    public const int MQSYSP_ALLOC_TRK = 21;

    public const int MQSYSP_ALLOC_CYL = 22;

    public const int MQSYSP_STATUS_BUSY = 30;

    public const int MQSYSP_STATUS_PREMOUNT = 31;

    public const int MQSYSP_STATUS_AVAILABLE = 32;

    public const int MQSYSP_STATUS_UNKNOWN = 33;

    public const int MQSYSP_STATUS_ALLOC_ARCHIVE = 34;

    public const int MQSYSP_STATUS_COPYING_BSDS = 35;

    public const int MQSYSP_STATUS_COPYING_LOG = 36;

    public const int MQEXT_ALL = 0;

    public const int MQEXT_OBJECT = 1;

    public const int MQEXT_AUTHORITY = 2;

    public const int MQEXTATTRS_ALL = 0;

    public const int MQEXTATTRS_NONDEF = 1;

    public const int MQSYSOBJ_YES = 0;

    public const int MQSYSOBJ_NO = 1;

    public const int MQSUBTYPE_API = 1;

    public const int MQSUBTYPE_ADMIN = 2;

    public const int MQSUBTYPE_PROXY = 3;

    public const int MQSUBTYPE_ALL = -1;

    public const int MQSUBTYPE_USER = -2;

    public const int MQDOPT_RESOLVED = 0;

    public const int MQDOPT_DEFINED = 1;

    public const int MQTIME_UNIT_MINS = 0;

    public const int MQTIME_UNIT_SECS = 1;

    public const int MQUIDSUPP_NO = 0;

    public const int MQUIDSUPP_YES = 1;

    public const int MQUNDELIVERED_NORMAL = 0;

    public const int MQUNDELIVERED_SAFE = 1;

    public const int MQUNDELIVERED_DISCARD = 2;

    public const int MQUNDELIVERED_KEEP = 3;

    public const int MQUOWST_NONE = 0;

    public const int MQUOWST_ACTIVE = 1;

    public const int MQUOWST_PREPARED = 2;

    public const int MQUOWST_UNRESOLVED = 3;

    public const int MQUOWT_Q_MGR = 0;

    public const int MQUOWT_CICS = 1;

    public const int MQUOWT_RRS = 2;

    public const int MQUOWT_IMS = 3;

    public const int MQUOWT_XA = 4;

    public const int MQUSAGE_PS_AVAILABLE = 0;

    public const int MQUSAGE_PS_DEFINED = 1;

    public const int MQUSAGE_PS_OFFLINE = 2;

    public const int MQUSAGE_PS_NOT_DEFINED = 3;

    public const int MQUSAGE_PS_SUSPENDED = 4;

    public const int MQUSAGE_EXPAND_USER = 1;

    public const int MQUSAGE_EXPAND_SYSTEM = 2;

    public const int MQUSAGE_EXPAND_NONE = 3;

    public const int MQUSAGE_DS_OLDEST_ACTIVE_UOW = 10;

    public const int MQUSAGE_DS_OLDEST_PS_RECOVERY = 11;

    public const int MQUSAGE_DS_OLDEST_CF_RECOVERY = 12;

    public const int MQMCP_REPLY = 2;

    public const int MQMCP_USER = 1;

    public const int MQMCP_NONE = 0;

    public const int MQMCP_ALL = -1;

    public const int MQMCP_COMPAT = -2;

    public const int MQNSH_NONE = 0;

    public const int MQNSH_ALL = -1;

    public const int MQOPER_SYSTEM_FIRST = 0;

    public const int MQOPER_UNKNOWN = 0;

    public const int MQOPER_BROWSE = 1;

    public const int MQOPER_DISCARD = 2;

    public const int MQOPER_GET = 3;

    public const int MQOPER_PUT = 4;

    public const int MQOPER_PUT_REPLY = 5;

    public const int MQOPER_PUT_REPORT = 6;

    public const int MQOPER_RECEIVE = 7;

    public const int MQOPER_SEND = 8;

    public const int MQOPER_TRANSFORM = 9;

    public const int MQOPER_PUBLISH = 10;

    public const int MQOPER_EXCLUDED_PUBLISH = 11;

    public const int MQOPER_DISCARDED_PUBLISH = 12;

    public const int MQOPER_SYSTEM_LAST = 65535;

    public const int MQOPER_APPL_FIRST = 65536;

    public const int MQOPER_APPL_LAST = 999999999;

    public const int MQROUTE_UNLIMITED_ACTIVITIES = 0;

    public const int MQROUTE_DETAIL_LOW = 2;

    public const int MQROUTE_DETAIL_MEDIUM = 8;

    public const int MQROUTE_DETAIL_HIGH = 32;

    public const int MQROUTE_FORWARD_ALL = 256;

    public const int MQROUTE_FORWARD_IF_SUPPORTED = 512;

    public const uint MQROUTE_FORWARD_REJ_UNSUP_MASK = 4294901760u;

    public const int MQROUTE_DELIVER_YES = 4096;

    public const int MQROUTE_DELIVER_NO = 8192;

    public const uint MQROUTE_DELIVER_REJ_UNSUP_MASK = 4294901760u;

    public const int MQROUTE_ACCUMULATE_NONE = 65539;

    public const int MQROUTE_ACCUMULATE_IN_MSG = 65540;

    public const int MQROUTE_ACCUMULATE_AND_REPLY = 65541;

    public const int MQDELO_NONE = 0;

    public const int MQDELO_LOCAL = 4;

    public const int MQPUBO_NONE = 0;

    public const int MQPUBO_CORREL_ID_AS_IDENTITY = 1;

    public const int MQPUBO_RETAIN_PUBLICATION = 2;

    public const int MQPUBO_OTHER_SUBSCRIBERS_ONLY = 4;

    public const int MQPUBO_NO_REGISTRATION = 8;

    public const int MQPUBO_IS_RETAINED_PUBLICATION = 16;

    public const int MQREGO_NONE = 0;

    public const int MQREGO_CORREL_ID_AS_IDENTITY = 1;

    public const int MQREGO_ANONYMOUS = 2;

    public const int MQREGO_LOCAL = 4;

    public const int MQREGO_DIRECT_REQUESTS = 8;

    public const int MQREGO_NEW_PUBLICATIONS_ONLY = 16;

    public const int MQREGO_PUBLISH_ON_REQUEST_ONLY = 32;

    public const int MQREGO_DEREGISTER_ALL = 64;

    public const int MQREGO_INCLUDE_STREAM_NAME = 128;

    public const int MQREGO_INFORM_IF_RETAINED = 256;

    public const int MQREGO_DUPLICATES_OK = 512;

    public const int MQREGO_NON_PERSISTENT = 1024;

    public const int MQREGO_PERSISTENT = 2048;

    public const int MQREGO_PERSISTENT_AS_PUBLISH = 4096;

    public const int MQREGO_PERSISTENT_AS_Q = 8192;

    public const int MQREGO_ADD_NAME = 16384;

    public const int MQREGO_NO_ALTERATION = 32768;

    public const int MQREGO_FULL_RESPONSE = 65536;

    public const int MQREGO_JOIN_SHARED = 131072;

    public const int MQREGO_JOIN_EXCLUSIVE = 262144;

    public const int MQREGO_LEAVE_ONLY = 524288;

    public const int MQREGO_VARIABLE_USER_ID = 1048576;

    public const int MQREGO_LOCKED = 2097152;

    public const int MQUA_FIRST = 65536;

    public const int MQUA_LAST = 999999999;

    public const int MQGUR_DISABLED = 0;

    public const int MQGUR_ENABLED = 1;

    public const int MQMULC_STANDARD = 0;

    public const int MQMULC_REFINED = 1;

    public const int MQSTDBY_NOT_PERMITTED = 0;

    public const int MQSTDBY_PERMITTED = 1;

    public const string MQPS_COMMAND = "MQPSCommand";

    public const string MQPS_COMP_CODE = "MQPSCompCode";

    public const string MQPS_CORREL_ID = "MQPSCorrelId";

    public const string MQPS_DELETE_OPTIONS = "MQPSDelOpts";

    public const string MQPS_ERROR_ID = "MQPSErrorId";

    public const string MQPS_ERROR_POS = "MQPSErrorPos";

    public const string MQPS_INTEGER_DATA = "MQPSIntData";

    public const string MQPS_PARAMETER_ID = "MQPSParmId";

    public const string MQPS_PUBLICATION_OPTIONS = "MQPSPubOpts";

    public const string MQPS_PUBLISH_TIMESTAMP = "MQPSPubTime";

    public const string MQPS_Q_MGR_NAME = "MQPSQMgrName";

    public const string MQPS_Q_NAME = "MQPSQName";

    public const string MQPS_REASON = "MQPSReason";

    public const string MQPS_REASON_TEXT = "MQPSReasonText";

    public const string MQPS_REGISTRATION_OPTIONS = "MQPSRegOpts";

    public const string MQPS_SEQUENCE_NUMBER = "MQPSSeqNum";

    public const string MQPS_STREAM_NAME = "MQPSStreamName";

    public const string MQPS_STRING_DATA = "MQPSStringData";

    public const string MQPS_SUBSCRIPTION_IDENTITY = "MQPSSubIdentity";

    public const string MQPS_SUBSCRIPTION_NAME = "MQPSSubName";

    public const string MQPS_SUBSCRIPTION_USER_DATA = "MQPSSubUserData";

    public const string MQPS_TOPIC = "MQPSTopic";

    public const string MQPS_USER_ID = "MQPSUserId";

    public const string MQPS_COMMAND_B = " MQPSCommand ";

    public const string MQPS_COMP_CODE_B = " MQPSCompCode ";

    public const string MQPS_CORREL_ID_B = " MQPSCorrelId ";

    public const string MQPS_DELETE_OPTIONS_B = " MQPSDelOpts ";

    public const string MQPS_ERROR_ID_B = " MQPSErrorId ";

    public const string MQPS_ERROR_POS_B = " MQPSErrorPos ";

    public const string MQPS_INTEGER_DATA_B = " MQPSIntData ";

    public const string MQPS_PARAMETER_ID_B = " MQPSParmId ";

    public const string MQPS_PUBLICATION_OPTIONS_B = " MQPSPubOpts ";

    public const string MQPS_PUBLISH_TIMESTAMP_B = " MQPSPubTime ";

    public const string MQPS_Q_MGR_NAME_B = " MQPSQMgrName ";

    public const string MQPS_Q_NAME_B = " MQPSQName ";

    public const string MQPS_REASON_B = " MQPSReason ";

    public const string MQPS_REASON_TEXT_B = " MQPSReasonText ";

    public const string MQPS_REGISTRATION_OPTIONS_B = " MQPSRegOpts ";

    public const string MQPS_SEQUENCE_NUMBER_B = " MQPSSeqNum ";

    public const string MQPS_STREAM_NAME_B = " MQPSStreamName ";

    public const string MQPS_STRING_DATA_B = " MQPSStringData ";

    public const string MQPS_SUBSCRIPTION_IDENTITY_B = " MQPSSubIdentity ";

    public const string MQPS_SUBSCRIPTION_NAME_B = " MQPSSubName ";

    public const string MQPS_SUBSCRIPTION_USER_DATA_B = " MQPSSubUserData ";

    public const string MQPS_TOPIC_B = " MQPSTopic ";

    public const string MQPS_USER_ID_B = " MQPSUserId ";

    public const string MQPS_DELETE_PUBLICATION = "DeletePub";

    public const string MQPS_DEREGISTER_PUBLISHER = "DeregPub";

    public const string MQPS_DEREGISTER_SUBSCRIBER = "DeregSub";

    public const string MQPS_PUBLISH = "Publish";

    public const string MQPS_REGISTER_PUBLISHER = "RegPub";

    public const string MQPS_REGISTER_SUBSCRIBER = "RegSub";

    public const string MQPS_REQUEST_UPDATE = "ReqUpdate";

    public const string MQPS_DELETE_PUBLICATION_B = " DeletePub ";

    public const string MQPS_DEREGISTER_PUBLISHER_B = " DeregPub ";

    public const string MQPS_DEREGISTER_SUBSCRIBER_B = " DeregSub ";

    public const string MQPS_PUBLISH_B = " Publish ";

    public const string MQPS_REGISTER_PUBLISHER_B = " RegPub ";

    public const string MQPS_REGISTER_SUBSCRIBER_B = " RegSub ";

    public const string MQPS_REQUEST_UPDATE_B = " ReqUpdate ";

    public const string MQPS_ADD_NAME = "AddName";

    public const string MQPS_ANONYMOUS = "Anon";

    public const string MQPS_CORREL_ID_AS_IDENTITY = "CorrelAsId";

    public const string MQPS_DEREGISTER_ALL = "DeregAll";

    public const string MQPS_DIRECT_REQUESTS = "DirectReq";

    public const string MQPS_DUPLICATES_OK = "DupsOK";

    public const string MQPS_FULL_RESPONSE = "FullResp";

    public const string MQPS_INCLUDE_STREAM_NAME = "InclStreamName";

    public const string MQPS_INFORM_IF_RETAINED = "InformIfRet";

    public const string MQPS_IS_RETAINED_PUBLICATION = "IsRetainedPub";

    public const string MQPS_JOIN_EXCLUSIVE = "JoinExcl";

    public const string MQPS_JOIN_SHARED = "JoinShared";

    public const string MQPS_LEAVE_ONLY = "LeaveOnly";

    public const string MQPS_LOCAL = "Local";

    public const string MQPS_LOCKED = "Locked";

    public const string MQPS_NEW_PUBLICATIONS_ONLY = "NewPubsOnly";

    public const string MQPS_NO_ALTERATION = "NoAlter";

    public const string MQPS_NO_REGISTRATION = "NoReg";

    public const string MQPS_NON_PERSISTENT = "NonPers";

    public const string MQPS_NONE = "None";

    public const string MQPS_OTHER_SUBSCRIBERS_ONLY = "OtherSubsOnly";

    public const string MQPS_PERSISTENT = "Pers";

    public const string MQPS_PERSISTENT_AS_PUBLISH = "PersAsPub";

    public const string MQPS_PERSISTENT_AS_Q = "PersAsQueue";

    public const string MQPS_PUBLISH_ON_REQUEST_ONLY = "PubOnReqOnly";

    public const string MQPS_RETAIN_PUBLICATION = "RetainPub";

    public const string MQPS_VARIABLE_USER_ID = "VariableUserId";

    public const string MQPS_ADD_NAME_B = " AddName ";

    public const string MQPS_ANONYMOUS_B = " Anon ";

    public const string MQPS_CORREL_ID_AS_IDENTITY_B = " CorrelAsId ";

    public const string MQPS_DEREGISTER_ALL_B = " DeregAll ";

    public const string MQPS_DIRECT_REQUESTS_B = " DirectReq ";

    public const string MQPS_DUPLICATES_OK_B = " DupsOK ";

    public const string MQPS_FULL_RESPONSE_B = " FullResp ";

    public const string MQPS_INCLUDE_STREAM_NAME_B = " InclStreamName ";

    public const string MQPS_INFORM_IF_RETAINED_B = " InformIfRet ";

    public const string MQPS_IS_RETAINED_PUBLICATION_B = " IsRetainedPub ";

    public const string MQPS_JOIN_EXCLUSIVE_B = " JoinExcl ";

    public const string MQPS_JOIN_SHARED_B = " JoinShared ";

    public const string MQPS_LEAVE_ONLY_B = " LeaveOnly ";

    public const string MQPS_LOCAL_B = " Local ";

    public const string MQPS_LOCKED_B = " Locked ";

    public const string MQPS_NEW_PUBLICATIONS_ONLY_B = " NewPubsOnly ";

    public const string MQPS_NO_ALTERATION_B = " NoAlter ";

    public const string MQPS_NO_REGISTRATION_B = " NoReg ";

    public const string MQPS_NON_PERSISTENT_B = " NonPers ";

    public const string MQPS_NONE_B = " None ";

    public const string MQPS_OTHER_SUBSCRIBERS_ONLY_B = " OtherSubsOnly ";

    public const string MQPS_PERSISTENT_B = " Pers ";

    public const string MQPS_PERSISTENT_AS_PUBLISH_B = " PersAsPub ";

    public const string MQPS_PERSISTENT_AS_Q_B = " PersAsQueue ";

    public const string MQPS_PUBLISH_ON_REQUEST_ONLY_B = " PubOnReqOnly ";

    public const string MQPS_RETAIN_PUBLICATION_B = " RetainPub ";

    public const string MQPS_VARIABLE_USER_ID_B = " VariableUserId ";

    public const string MQRFH2_PUBSUB_CMD_FOLDER = "psc";

    public const string MQRFH2_PUBSUB_RESP_FOLDER = "pscr";

    public const string MQRFH2_MSG_CONTENT_FOLDER = "mcd";

    public const string MQRFH2_USER_FOLDER = "usr";

    public const string MQMCD_MSG_DOMAIN = "Msd";

    public const string MQMCD_MSG_SET = "Set";

    public const string MQMCD_MSG_TYPE = "Type";

    public const string MQMCD_MSG_FORMAT = "Fmt";

    public const string MQMCD_MSG_DOMAIN_B = "<Msd>";

    public const string MQMCD_MSG_DOMAIN_E = "</Msd>";

    public const string MQMCD_MSG_SET_B = "<Set>";

    public const string MQMCD_MSG_SET_E = "</Set>";

    public const string MQMCD_MSG_TYPE_B = "<Type>";

    public const string MQMCD_MSG_TYPE_E = "</Type>";

    public const string MQMCD_MSG_FORMAT_B = "<Fmt>";

    public const string MQMCD_MSG_FORMAT_E = "</Fmt>";

    public const string MQMCD_DOMAIN_NONE = "none";

    public const string MQMCD_DOMAIN_NEON = "neon";

    public const string MQMCD_DOMAIN_MRM = "mrm";

    public const string MQMCD_DOMAIN_JMS_NONE = "jms_none";

    public const string MQMCD_DOMAIN_JMS_TEXT = "jms_text";

    public const string MQMCD_DOMAIN_JMS_OBJECT = "jms_object";

    public const string MQMCD_DOMAIN_JMS_MAP = "jms_map";

    public const string MQMCD_DOMAIN_JMS_STREAM = "jms_stream";

    public const string MQMCD_DOMAIN_JMS_BYTES = "jms_bytes";

    public const string MQPSC_COMMAND = "Command";

    public const string MQPSC_REGISTRATION_OPTION = "RegOpt";

    public const string MQPSC_PUBLICATION_OPTION = "PubOpt";

    public const string MQPSC_DELETE_OPTION = "DelOpt";

    public const string MQPSC_TOPIC = "Topic";

    public const string MQPSC_SUBSCRIPTION_POINT = "SubPoint";

    public const string MQPSC_FILTER = "Filter";

    public const string MQPSC_Q_MGR_NAME = "QMgrName";

    public const string MQPSC_Q_NAME = "QName";

    public const string MQPSC_PUBLISH_TIMESTAMP = "PubTime";

    public const string MQPSC_SEQUENCE_NUMBER = "SeqNum";

    public const string MQPSC_SUBSCRIPTION_NAME = "SubName";

    public const string MQPSC_SUBSCRIPTION_IDENTITY = "SubIdentity";

    public const string MQPSC_SUBSCRIPTION_USER_DATA = "SubUserData";

    public const string MQPSC_CORREL_ID = "CorrelId";

    public const string MQPSC_COMMAND_B = "<Command>";

    public const string MQPSC_COMMAND_E = "</Command>";

    public const string MQPSC_REGISTRATION_OPTION_B = "<RegOpt>";

    public const string MQPSC_REGISTRATION_OPTION_E = "</RegOpt>";

    public const string MQPSC_PUBLICATION_OPTION_B = "<PubOpt>";

    public const string MQPSC_PUBLICATION_OPTION_E = "</PubOpt>";

    public const string MQPSC_DELETE_OPTION_B = "<DelOpt>";

    public const string MQPSC_DELETE_OPTION_E = "</DelOpt>";

    public const string MQPSC_TOPIC_B = "<Topic>";

    public const string MQPSC_TOPIC_E = "</Topic>";

    public const string MQPSC_SUBSCRIPTION_POINT_B = "<SubPoint>";

    public const string MQPSC_SUBSCRIPTION_POINT_E = "</SubPoint>";

    public const string MQPSC_FILTER_B = "<Filter>";

    public const string MQPSC_FILTER_E = "</Filter>";

    public const string MQPSC_Q_MGR_NAME_B = "<QMgrName>";

    public const string MQPSC_Q_MGR_NAME_E = "</QMgrName>";

    public const string MQPSC_Q_NAME_B = "<QName>";

    public const string MQPSC_Q_NAME_E = "</QName>";

    public const string MQPSC_PUBLISH_TIMESTAMP_B = "<PubTime>";

    public const string MQPSC_PUBLISH_TIMESTAMP_E = "</PubTime>";

    public const string MQPSC_SEQUENCE_NUMBER_B = "<SeqNum>";

    public const string MQPSC_SEQUENCE_NUMBER_E = "</SeqNum>";

    public const string MQPSC_SUBSCRIPTION_NAME_B = "<SubName>";

    public const string MQPSC_SUBSCRIPTION_NAME_E = "</SubName>";

    public const string MQPSC_SUBSCRIPTION_IDENTITY_B = "<SubIdentity>";

    public const string MQPSC_SUBSCRIPTION_IDENTITY_E = "</SubIdentity>";

    public const string MQPSC_SUBSCRIPTION_USER_DATA_B = "<SubUserData>";

    public const string MQPSC_SUBSCRIPTION_USER_DATA_E = "</SubUserData>";

    public const string MQPSC_CORREL_ID_B = "<CorrelId>";

    public const string MQPSC_CORREL_ID_E = "</CorrelId>";

    public const string MQPSC_DELETE_PUBLICATION = "DeletePub";

    public const string MQPSC_DEREGISTER_SUBSCRIBER = "DeregSub";

    public const string MQPSC_PUBLISH = "Publish";

    public const string MQPSC_REGISTER_SUBSCRIBER = "RegSub";

    public const string MQPSC_REQUEST_UPDATE = "ReqUpdate";

    public const string MQPSC_ADD_NAME = "AddName";

    public const string MQPSC_CORREL_ID_AS_IDENTITY = "CorrelAsId";

    public const string MQPSC_DEREGISTER_ALL = "DeregAll";

    public const string MQPSC_DUPLICATES_OK = "DupsOK";

    public const string MQPSC_FULL_RESPONSE = "FullResp";

    public const string MQPSC_INFORM_IF_RETAINED = "InformIfRet";

    public const string MQPSC_IS_RETAINED_PUB = "IsRetainedPub";

    public const string MQPSC_JOIN_SHARED = "JoinShared";

    public const string MQPSC_JOIN_EXCLUSIVE = "JoinExcl";

    public const string MQPSC_LEAVE_ONLY = "LeaveOnly";

    public const string MQPSC_LOCAL = "Local";

    public const string MQPSC_LOCKED = "Locked";

    public const string MQPSC_NEW_PUBS_ONLY = "NewPubsOnly";

    public const string MQPSC_NO_ALTERATION = "NoAlter";

    public const string MQPSC_NON_PERSISTENT = "NonPers";

    public const string MQPSC_OTHER_SUBS_ONLY = "OtherSubsOnly";

    public const string MQPSC_PERSISTENT = "Pers";

    public const string MQPSC_PERSISTENT_AS_PUBLISH = "PersAsPub";

    public const string MQPSC_PERSISTENT_AS_Q = "PersAsQueue";

    public const string MQPSC_NONE = "None";

    public const string MQPSC_PUB_ON_REQUEST_ONLY = "PubOnReqOnly";

    public const string MQPSC_RETAIN_PUB = "RetainPub";

    public const string MQPSC_VARIABLE_USER_ID = "VariableUserId";

    public const string MQPSCR_COMPLETION = "Completion";

    public const string MQPSCR_RESPONSE = "Response";

    public const string MQPSCR_REASON = "Reason";

    public const string MQPSCR_COMPLETION_B = "<Completion>";

    public const string MQPSCR_COMPLETION_E = "</Completion>";

    public const string MQPSCR_RESPONSE_B = "<Response>";

    public const string MQPSCR_RESPONSE_E = "</Response>";

    public const string MQPSCR_REASON_B = "<Reason>";

    public const string MQPSCR_REASON_E = "</Reason>";

    public const string MQPSCR_OK = "ok";

    public const string MQPSCR_WARNING = "warning";

    public const string MQPSCR_ERROR = "error";

    public const string MQZED_STRUC_ID = "ZED ";

    public const int MQZED_VERSION_1 = 1;

    public const int MQZED_VERSION_2 = 2;

    public const int MQZED_CURRENT_VERSION = 2;

    public const int MQZED_LENGTH_1 = 56;

    public const int MQZED_LENGTH_2 = 60;

    public const int MQZED_CURRENT_LENGTH = 60;

    public const string MQZAC_STRUC_ID = "ZAC ";

    public const int MQZAC_VERSION_1 = 1;

    public const int MQZAC_CURRENT_VERSION = 1;

    public const int MQZAC_LENGTH_1 = 84;

    public const int MQZAC_CURRENT_LENGTH = 84;

    public const int MQZAT_INITIAL_CONTEXT = 0;

    public const int MQZAT_CHANGE_CONTEXT = 1;

    public const string MQZAD_STRUC_ID = "ZAD ";

    public const int MQZAD_VERSION_1 = 1;

    public const int MQZAD_VERSION_2 = 2;

    public const int MQZAD_CURRENT_VERSION = 2;

    public const int MQZAD_LENGTH_1 = 72;

    public const int MQZAD_LENGTH_2 = 76;

    public const int MQZAD_CURRENT_LENGTH = 76;

    public const string MQZFP_STRUC_ID = "ZFP ";

    public const int MQZFP_VERSION_1 = 1;

    public const int MQZFP_CURRENT_VERSION = 1;

    public const int MQZFP_LENGTH_1 = 20;

    public const int MQZFP_CURRENT_LENGTH = 20;

    public const string MQZIC_STRUC_ID = "ZIC ";

    public const int MQZIC_VERSION_1 = 1;

    public const int MQZIC_CURRENT_VERSION = 1;

    public const int MQZIC_LENGTH_1 = 84;

    public const int MQZIC_CURRENT_LENGTH = 84;

    public const int MQZIO_PRIMARY = 0;

    public const int MQZIO_SECONDARY = 1;

    public const int MQZTO_PRIMARY = 0;

    public const int MQZTO_SECONDARY = 1;

    public const int MQZCI_DEFAULT = 0;

    public const int MQZCI_CONTINUE = 0;

    public const int MQZCI_STOP = 1;

    public const int MQZAS_VERSION_1 = 1;

    public const int MQZAS_VERSION_2 = 2;

    public const int MQZAS_VERSION_3 = 3;

    public const int MQZAS_VERSION_4 = 4;

    public const int MQZAS_VERSION_5 = 5;

    public const int MQZAS_VERSION_6 = 6;

    public const int MQZAO_CONNECT = 1;

    public const int MQZAO_BROWSE = 2;

    public const int MQZAO_INPUT = 4;

    public const int MQZAO_OUTPUT = 8;

    public const int MQZAO_INQUIRE = 16;

    public const int MQZAO_SET = 32;

    public const int MQZAO_PASS_IDENTITY_CONTEXT = 64;

    public const int MQZAO_PASS_ALL_CONTEXT = 128;

    public const int MQZAO_SET_IDENTITY_CONTEXT = 256;

    public const int MQZAO_SET_ALL_CONTEXT = 512;

    public const int MQZAO_ALTERNATE_USER_AUTHORITY = 1024;

    public const int MQZAO_PUBLISH = 2048;

    public const int MQZAO_SUBSCRIBE = 4096;

    public const int MQZAO_RESUME = 8192;

    public const int MQZAO_ALL_MQI = 16383;

    public const int MQZAO_CREATE = 65536;

    public const int MQZAO_DELETE = 131072;

    public const int MQZAO_DISPLAY = 262144;

    public const int MQZAO_CHANGE = 524288;

    public const int MQZAO_CLEAR = 1048576;

    public const int MQZAO_CONTROL = 2097152;

    public const int MQZAO_CONTROL_EXTENDED = 4194304;

    public const int MQZAO_AUTHORIZE = 8388608;

    public const int MQZAO_ALL_ADMIN = 16646144;

    public const int MQZAO_SYSTEM = 33554432;

    public const int MQZAO_ALL = 50216959;

    public const int MQZAO_REMOVE = 16777216;

    public const int MQZAO_NONE = 0;

    public const int MQZAO_CREATE_ONLY = 67108864;

    public const int MQZAET_NONE = 0;

    public const int MQZAET_PRINCIPAL = 1;

    public const int MQZAET_GROUP = 2;

    public const int MQZAET_UNKNOWN = 3;

    public const int MQZSE_START = 1;

    public const int MQZSE_CONTINUE = 0;

    public const int MQZSL_NOT_RETURNED = 0;

    public const int MQZSL_RETURNED = 1;

    public const int MQZNS_VERSION_1 = 1;

    public const int MQZUS_VERSION_1 = 1;

    public const int MQZID_INIT = 0;

    public const int MQZID_TERM = 1;

    public const int MQZID_INIT_AUTHORITY = 0;

    public const int MQZID_TERM_AUTHORITY = 1;

    public const int MQZID_CHECK_AUTHORITY = 2;

    public const int MQZID_COPY_ALL_AUTHORITY = 3;

    public const int MQZID_DELETE_AUTHORITY = 4;

    public const int MQZID_SET_AUTHORITY = 5;

    public const int MQZID_GET_AUTHORITY = 6;

    public const int MQZID_GET_EXPLICIT_AUTHORITY = 7;

    public const int MQZID_REFRESH_CACHE = 8;

    public const int MQZID_ENUMERATE_AUTHORITY_DATA = 9;

    public const int MQZID_AUTHENTICATE_USER = 10;

    public const int MQZID_FREE_USER = 11;

    public const int MQZID_INQUIRE = 12;

    public const int MQZID_CHECK_PRIVILEGED = 13;

    public const int MQZID_INIT_NAME = 0;

    public const int MQZID_TERM_NAME = 1;

    public const int MQZID_LOOKUP_NAME = 2;

    public const int MQZID_INSERT_NAME = 3;

    public const int MQZID_DELETE_NAME = 4;

    public const int MQZID_INIT_USERID = 0;

    public const int MQZID_TERM_USERID = 1;

    public const int MQZID_FIND_USERID = 2;

    public const int MQCBO_NONE = 0;

    public const int MQCBO_USER_BAG = 0;

    public const int MQCBO_ADMIN_BAG = 1;

    public const int MQCBO_COMMAND_BAG = 16;

    public const int MQCBO_SYSTEM_BAG = 32;

    public const int MQCBO_GROUP_BAG = 64;

    public const int MQCBO_LIST_FORM_ALLOWED = 2;

    public const int MQCBO_LIST_FORM_INHIBITED = 0;

    public const int MQCBO_REORDER_AS_REQUIRED = 4;

    public const int MQCBO_DO_NOT_REORDER = 0;

    public const int MQCBO_CHECK_SELECTORS = 8;

    public const int MQCBO_DO_NOT_CHECK_SELECTORS = 0;

    public const int MQBL_NULL_TERMINATED = -1;

    public const int MQITEM_INTEGER = 1;

    public const int MQITEM_STRING = 2;

    public const int MQITEM_BAG = 3;

    public const int MQITEM_BYTE_STRING = 4;

    public const int MQITEM_INTEGER_FILTER = 5;

    public const int MQITEM_STRING_FILTER = 6;

    public const int MQITEM_INTEGER64 = 7;

    public const int MQITEM_BYTE_STRING_FILTER = 8;

    public const int MQIT_INTEGER = 1;

    public const int MQIT_STRING = 2;

    public const int MQIT_BAG = 3;

    public const int MQHA_FIRST = 4001;

    public const int MQHA_BAG_HANDLE = 4001;

    public const int MQHA_LAST_USED = 4001;

    public const int MQHA_LAST = 6000;

    public const int MQOA_FIRST = 1;

    public const int MQOA_LAST = 9000;

    public const int MQIASY_FIRST = -1;

    public const int MQIASY_CODED_CHAR_SET_ID = -1;

    public const int MQIASY_TYPE = -2;

    public const int MQIASY_COMMAND = -3;

    public const int MQIASY_MSG_SEQ_NUMBER = -4;

    public const int MQIASY_CONTROL = -5;

    public const int MQIASY_COMP_CODE = -6;

    public const int MQIASY_REASON = -7;

    public const int MQIASY_BAG_OPTIONS = -8;

    public const int MQIASY_VERSION = -9;

    public const int MQIASY_LAST_USED = -9;

    public const int MQIASY_LAST = -2000;

    public const int MQSEL_ANY_SELECTOR = -30001;

    public const int MQSEL_ANY_USER_SELECTOR = -30002;

    public const int MQSEL_ANY_SYSTEM_SELECTOR = -30003;

    public const int MQSEL_ALL_SELECTORS = -30001;

    public const int MQSEL_ALL_USER_SELECTORS = -30002;

    public const int MQSEL_ALL_SYSTEM_SELECTORS = -30003;

    public const int MQIND_NONE = -1;

    public const int MQIND_ALL = -2;

    public const int MQHB_UNUSABLE_HBAG = -1;

    public const int MQHB_NONE = -2;

    public const string MQIEP_STRUC_ID = "IEP ";

    public const int MQIEP_VERSION_1 = 1;

    public const int MQIEP_CURRENT_VERSION = 1;

    public const int MQIEP_LENGTH_1 = 140;

    public const int MQIEP_CURRENT_LENGTH = 140;

    public const int MQIEPF_NONE = 0;

    public const int MQIEPF_NON_THREADED_LIBRARY = 0;

    public const int MQIEPF_THREADED_LIBRARY = 1;

    public const int MQIEPF_CLIENT_LIBRARY = 0;

    public const int MQIEPF_LOCAL_LIBRARY = 2;

    public static readonly byte[] MQCFAC_NONE;

    public static readonly byte[] MQCT_NONE;

    public static readonly byte[] MQCONNID_NONE;

    public static readonly byte[] MQMTOK_NONE;

    public static readonly byte[] MQITII_NONE;

    public static readonly byte[] MQMI_NONE;

    public static readonly byte[] MQCI_NONE;

    public static readonly byte[] MQCI_NEW_SESSION;

    public static readonly byte[] MQACT_NONE;

    public static readonly byte[] MQGI_NONE;

    public static readonly byte[] MQOII_NONE;

    public static readonly byte[] MQSID_NONE;

    public static readonly byte[] MQXPDA_NONE;

    public static readonly byte[] MQXUA_NONE;

    static MQC()
    {
      // Note: this type is marked as 'beforefieldinit'.
      byte[] mQCFAC_NONE = new byte[8];
      MQC.MQCFAC_NONE = mQCFAC_NONE;
      byte[] mQCT_NONE = new byte[128];
      MQC.MQCT_NONE = mQCT_NONE;
      byte[] mQCONNID_NONE = new byte[24];
      MQC.MQCONNID_NONE = mQCONNID_NONE;
      byte[] mQMTOK_NONE = new byte[16];
      MQC.MQMTOK_NONE = mQMTOK_NONE;
      byte[] mQITII_NONE = new byte[16];
      MQC.MQITII_NONE = mQITII_NONE;
      byte[] mQMI_NONE = new byte[24];
      MQC.MQMI_NONE = mQMI_NONE;
      byte[] mQCI_NONE = new byte[24];
      MQC.MQCI_NONE = mQCI_NONE;
      MQC.MQCI_NEW_SESSION = new byte[]
      {
        65,
        77,
        81,
        33,
        78,
        69,
        87,
        95,
        83,
        69,
        83,
        83,
        73,
        79,
        78,
        95,
        67,
        79,
        82,
        82,
        69,
        76,
        73,
        68
      };
      byte[] mQACT_NONE = new byte[32];
      MQC.MQACT_NONE = mQACT_NONE;
      byte[] mQGI_NONE = new byte[24];
      MQC.MQGI_NONE = mQGI_NONE;
      byte[] mQOII_NONE = new byte[24];
      MQC.MQOII_NONE = mQOII_NONE;
      byte[] mQSID_NONE = new byte[40];
      MQC.MQSID_NONE = mQSID_NONE;
      byte[] mQXPDA_NONE = new byte[48];
      MQC.MQXPDA_NONE = mQXPDA_NONE;
      byte[] mQXUA_NONE = new byte[16];
      MQC.MQXUA_NONE = mQXUA_NONE;
    }
  }
}
