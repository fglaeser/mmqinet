using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Mmqi
{
  public class MQMessage : MQBase
  {

    private const int S390_MANTISSA = 16777215;

    private const int S390_NEGATIVE = 128;

    private const int S390_POSITIVE = 0;

    private const int IEEE_SIGN_BIT = 128;

    private const int S390_EXP_BITS = 127;

    private const int S390_EXP_BIAS = 64;

    private const int BOOLEAN_SIZEOF = 1;

    private const int BYTE_SIZEOF = 1;

    private const int CHAR_SIZEOF = 2;

    private const int SHORT_SIZEOF = 2;

    private const int UTF_SIZEOF = 2;

    private const int UNBYTE_SIZEOF = 2;

    private const int INT_SIZEOF = 4;

    private const int UNSHORT_SIZEOF = 4;

    private const int LONG_SIZEOF = 8;

    private const int FLOAT_SIZEOF = 4;

    private const int DOUBLE_SIZEOF = 8;

    private const int EXPAND_SIZE = 1024;

    internal const string RFH2_USR_FOLDER = "usr";

    internal const string RFH2_MQ_FOLDER = "mq";

    internal const string RFH2_JMS_FOLDER = "jms";

    internal const string RFH2_MCD_FOLDER = "mcd";

    internal const string RFH2_JMS_PROPERTY_PREFIX = "JMS";

    internal const char RFH2_FOLDER_SEPARATOR = '.';

    internal const string PROPERTY_WILDCARD = "%";

    internal const string FORWARD_SLASH = "/";

    private const string MQ_JMS_CORRELATION_ID = "JMSCorrelationID";

    private const string MQ_JMS_DELIVERY_MODE = "JMSDeliveryMode";

    private const string MQ_JMS_DESTINATION = "JMSDestination";

    private const string MQ_JMS_EXPIRATION = "JMSExpiration";

    private const string MQ_JMS_MESSAGE_ID = "JMSMessageID";

    private const string MQ_JMS_PRIORITY = "JMSPriority";

    private const string MQ_JMS_REDELIVERED = "JMSRedelivered";

    private const string MQ_JMS_REPLY_TO = "JMSReplyTo";

    private const string MQ_JMS_TIME_STAMP = "JMSTimestamp";

    private const string MQ_JMS_TYPE = "JMSType";

    private const string MQ_JMSX_APP_ID = "JMSXAppID";

    private const string MQ_JMSX_DELIVERY_COUNT = "JMSXDeliveryCount";

    private const string MQ_JMSX_GROUP_ID = "JMSXGroupID";

    private const string MQ_JMSX_GROUP_SEQ = "JMSXGroupSeq";

    private const string MQ_JMSX_USER_ID = "JMSXUserID";

    private const string MQ_JMS_MSG_CLASS_BYTES = "jms_bytes";

    private const string MQ_JMS_MSG_CLASS_TEXT = "jms_text";

    private const string MSGPROPS_MQMD_SYNTAX = "Root.MQMD.";

    private const string RFH2_JMS_CORREL_ID = "jms.Cid";

    private const string RFH2_JMS_DELIVERY_MODE = "jms.Dlv";

    private const string RFH2_JMS_DESTINATION = "jms.Dst";

    private const string RFH2_JMS_EXPIRATION = "jms.Exp";

    private const string RFH2_JMS_PRIORITY = "jms.Pri";

    private const string RFH2_JMS_REPLY_TO = "jms.Rto";

    private const string RFH2_JMS_TIME_STAMP = "jms.Tms";

    private const string RFH2_JMS_MCD_TYPE = "mcd.Type";

    private const string RFH2_JMSX_GROUP_SEQ = "jms.Seq";

    private const string RFH2_JMS_MCD_MSD = "mcd.Msd";

    private const string RFH2_JMS_MCD_FMT = "mcd.Fmt";

    private const string RFH2_JMS_MCD_SET = "mcd.Set";

    private const string RFH2_JMS_GROUP_ID = "jms.Gid";

    private const string MQMD_PROPERTY_FORMAT = "format";

    internal const string MQ_PD_COPY_ALL = "All";

    internal const string MQ_PD_COPY_DEFAULT = "default";

    internal const string MQ_PD_COPY_NONE = "none";

    internal const string MQ_PD_COPY_PUBLISH = "publish";

    internal const string MQ_PD_COPY_FORWARD = "forward";

    internal const string MQ_PD_COPY_REPORT = "report";

    internal const string MQ_PD_COPY_REPLY = "reply";

    internal const string MQ_PD_COPY = "copy";

    internal const string MQ_PD_CONTEXT = "context";

    internal const string MQ_PD_SUPPORT = "support";

    internal const string MQ_PD_CONTEXT_USER = "user";

    internal const string MQ_PD_CONTEXT_NONE = "none";

    internal MemoryStream memoryStream;

    internal BinaryReader binaryReader;

    internal BinaryWriter binaryWriter;

    internal MQMessageDescriptor md = new MQMessageDescriptor();

    private static Hashtable mqPropertyNames_;

    internal Hashtable properties;

    internal Hashtable propertiesPDTable = new Hashtable(10);

    private static Hashtable namedProperties;

    internal static ArrayList PROPERTIES_FOLDER_NAMES;

    private static string[] RESERVED_HIERARCHY_PROPERTY_NAME_PREFIXES;

    private static ArrayList ALLOWED_HIERARCHY_PROPERTY_NAMES;

    internal static ArrayList RESTRICTED_HIERARCHY_FOLDER_NAMES;

    private static string[] reservedKeys;

    private static string replyToURI;

    private static string mcdURI;

    private static char[] BIN2HEX;

    protected int propertyValidation;

    internal int totalMessageLength;

    internal bool spiInherited;

    internal ulong spiQTime;

    private static CultureInfo dateTimeCulture;

    public string AccountingToken
    {
      get
      {
        return base.GetString(this.md.AccountingToken);
      }
      set
      {
        byte[] accountingToken = this.md.AccountingToken;
        base.GetBytes(value, ref accountingToken);
        this.md.AccountingToken = accountingToken;
      }
    }

    public string ApplicationIdData
    {
      get
      {
        return base.GetString(this.md.ApplIdentityData);
      }
      set
      {
        byte[] applIdentityData = this.md.ApplIdentityData;
        base.GetBytes(value, ref applIdentityData);
        this.md.ApplIdentityData = applIdentityData;
      }
    }

    public string ApplicationOriginData
    {
      get
      {
        return base.GetString(this.md.ApplOriginData);
      }
      set
      {
        byte[] applOriginData = this.md.ApplOriginData;
        base.GetBytes(value, ref applOriginData);
        this.md.ApplOriginData = applOriginData;
      }
    }

    public int BackoutCount
    {
      get
      {
        return this.md.BackoutCount;
      }
    }

    public int CharacterSet
    {
      get
      {
        return this.md.CodedCharacterSetId;
      }
      set
      {
        this.md.CodedCharacterSetId = value;
      }
    }

    public byte[] CorrelationId
    {
      get
      {
        return (byte[])this.md.CorrelId.Clone();
      }
      set
      {
        value.CopyTo(this.md.CorrelId, 0);
      }
    }

    public int Encoding
    {
      get
      {
        return this.md.Encoding;
      }
      set
      {
        this.md.Encoding = value;
      }
    }

    public int Expiry
    {
      get
      {
        return this.md.Expiry;
      }
      set
      {
        this.md.Expiry = value;
      }
    }

    public int Feedback
    {
      get
      {
        return this.md.Feedback;
      }
      set
      {
        this.md.Feedback = value;
      }
    }

    public string Format
    {
      get
      {
        return base.GetString(this.md.Format);
      }
      set
      {
        byte[] format = this.md.Format;
        base.GetBytes(value, ref format);
        this.md.Format = format;
      }
    }

    public byte[] GroupId
    {
      get
      {
        return (byte[])this.md.GroupID.Clone();
      }
      set
      {
        value.CopyTo(this.md.GroupID, 0);
        this.md.Version = 2;
      }
    }

    public int MessageFlags
    {
      get
      {
        return this.md.MsgFlags;
      }
      set
      {
        this.md.MsgFlags = value;
        this.md.Version = 2;
      }
    }

    public byte[] MessageId
    {
      get
      {
        return (byte[])this.md.MsgId.Clone();
      }
      set
      {
        value.CopyTo(this.md.MsgId, 0);
      }
    }

    public int MessageSequenceNumber
    {
      get
      {
        return this.md.MsgSequenceNumber;
      }
      set
      {
        this.md.MsgSequenceNumber = value;
        this.md.Version = 2;
      }
    }

    public int MessageType
    {
      get
      {
        return this.md.MsgType;
      }
      set
      {
        this.md.MsgType = value;
      }
    }

    public int Offset
    {
      get
      {
        return this.md.Offset;
      }
      set
      {
        this.md.Offset = value;
        this.md.Version = 2;
      }
    }

    public int OriginalLength
    {
      get
      {
        return this.md.OriginalLength;
      }
      set
      {
        this.md.OriginalLength = value;
        this.md.Version = 2;
      }
    }

    public int Persistence
    {
      get
      {
        return this.md.Persistence;
      }
      set
      {
        this.md.Persistence = value;
      }
    }

    public int Priority
    {
      get
      {
        return this.md.Priority;
      }
      set
      {
        this.md.Priority = value;
      }
    }

    public string PutApplicationName
    {
      get
      {
        return base.GetString(this.md.PutApplName);
      }
      set
      {
        byte[] putApplName = this.md.PutApplName;
        base.GetBytes(value, ref putApplName);
        this.md.PutApplName = putApplName;
      }
    }

    public int PutApplicationType
    {
      get
      {
        return this.md.PutApplType;
      }
      set
      {
        this.md.PutApplType = value;
      }
    }

    public DateTime PutDateTime
    {
      get
      {
        string @string = base.GetString(this.md.PutDate);
        string string2 = base.GetString(this.md.PutTime);
        DateTime result;
        if (@string.Trim().Length == 0 || string2.Trim().Length == 0)
        {
          result = default(DateTime);
        }
        else
        {
          result = DateTime.ParseExact(@string + string2, "yyyyMMddHHmmssff", MQMessage.dateTimeCulture);
        }
        return result;
      }
      set
      {
        string text = value.ToString("yyyyMMdd", MQMessage.dateTimeCulture);
        int num = (text.Length < 12) ? text.Length : 12;
        System.Text.Encoding.ASCII.GetBytes(text, 0, num, this.md.PutDate, 0);
        string text2 = value.ToString("HHmmssff", MQMessage.dateTimeCulture);
        num = ((text2.Length < 8) ? text2.Length : 8);
        System.Text.Encoding.ASCII.GetBytes(text2, 0, num, this.md.PutTime, 0);
      }
    }

    public string ReplyToQueueManagerName
    {
      get
      {
        return base.GetString(this.md.ReplyToQueueMgr);
      }
      set
      {
        byte[] replyToQueueMgr = this.md.ReplyToQueueMgr;
        base.GetBytes(value, ref replyToQueueMgr);
        this.md.ReplyToQueueMgr = replyToQueueMgr;
      }
    }

    public string ReplyToQueueName
    {
      get
      {
        return base.GetString(this.md.ReplyToQueue);
      }
      set
      {
        byte[] replyToQueue = this.md.ReplyToQueue;
        base.GetBytes(value, ref replyToQueue);
        this.md.ReplyToQueue = replyToQueue;
      }
    }

    public int Report
    {
      get
      {
        return this.md.Report;
      }
      set
      {
        this.md.Report = value;
      }
    }

    public string UserId
    {
      get
      {
        return base.GetString(this.md.UserID);
      }
      set
      {
        byte[] userID = this.md.UserID;
        base.GetBytes(value, ref userID);
        this.md.UserID = userID;
      }
    }

    public int DataLength
    {
      get
      {
        return this.MessageLength - Convert.ToInt32(this.memoryStream.Position);
      }
    }

    public int DataOffset
    {
      get
      {
        return Convert.ToInt32(this.memoryStream.Position);
      }
      set
      {
        this.memoryStream.Position = (long)value;
      }
    }

    public int MessageLength
    {
      get
      {
        return (int)this.memoryStream.Length;
      }
    }

    public int TotalMessageLength
    {
      get
      {
        return this.totalMessageLength;
      }
    }

    public int Version
    {
      get
      {
        return this.md.Version;
      }
      set
      {
        if (value > 2 || value < 1)
        {
          base.ThrowNewMQException(2, 2026);
        }
        this.md.Version = value;
      }
    }

    public MQMessageDescriptor MQMD
    {
      get
      {
        return this.md;
      }
      set
      {
        this.md = value;
      }
    }

    protected bool SPIInherited
    {
      get
      {
        return this.spiInherited;
      }
    }

    protected ulong SPIQTime
    {
      get
      {
        return this.spiQTime;
      }
    }

    public int PropertyValidation
    {
      get
      {
        return this.propertyValidation;
      }
      set
      {
        this.propertyValidation = value;
      }
    }

    public MQMessage()
    {
      this.ClearMessage();
      this.md = new MQMessageDescriptor();
      this.properties = new Hashtable(40);
    }

    protected MQMessage(MQMessage msg)
    {
      this.ClearMessage();
      this.md = new MQMessageDescriptor(msg.md);
    }

    static MQMessage()
    {
      MQMessage.namedProperties = null;
      MQMessage.PROPERTIES_FOLDER_NAMES = new ArrayList(new string[]
      {
        "mq",
        "mq_usr",
        "mqext",
        "jms",
        "mcd",
        "usr",
        "sib",
        "sib_usr",
        "sib_context",
        "mqema",
        "mqps"
      });
      MQMessage.RESERVED_HIERARCHY_PROPERTY_NAME_PREFIXES = new string[]
      {
        "Body" + '.',
        "Root" + '.'
      };
      MQMessage.ALLOWED_HIERARCHY_PROPERTY_NAMES = new ArrayList(new string[]
      {
        "Root" + '.' + "MQMD"
      });
      MQMessage.RESTRICTED_HIERARCHY_FOLDER_NAMES = new ArrayList(new string[]
      {
        "mq",
        "jms",
        "mcd",
        "usr",
        "sib"
      });
      MQMessage.reservedKeys = new string[]
      {
        "NULL",
        "TRUE",
        "FALSE",
        "NOT",
        "AND",
        "OR",
        "BETWEEN",
        "LIKE",
        "IN",
        "IS",
        "ESCAPE"
      };
      MQMessage.replyToURI = "queue://";
      MQMessage.mcdURI = "mcd://";
      MQMessage.BIN2HEX = new char[]
      {
        '0',
        '1',
        '2',
        '3',
        '4',
        '5',
        '6',
        '7',
        '8',
        '9',
        'a',
        'b',
        'c',
        'd',
        'e',
        'f'
      };
      MQMessage.dateTimeCulture = new CultureInfo("en-US");
      MQMessage.mqPropertyNames_ = new Hashtable();
      MQMessage.mqPropertyNames_["Root.MQMD.Report"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.MessageType"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.Expiry"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.Feedback"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.Encoding"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.CharacterSet"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.Format"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.Priority"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.Persistence"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.MessageId"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.CorrelationId"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.BackoutCount"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.ReplyToQueueName"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.ReplyToQueueManagerName"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.UserId"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.AccountingToken"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.ApplicationIdData"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.PutApplicationType"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.PutApplicationName"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.PutDateTime"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.ApplicationOriginData"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.GroupId"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.MessageSequenceNumber"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.OriginalLength"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.DataOffset"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.MessageFlags"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.MessageLength"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.Offset"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.TotalMessageLength"] = true;
      MQMessage.mqPropertyNames_["Root.MQMD.DataLength"] = true;
      MQMessage.mqPropertyNames_["JMSCorrelationID"] = true;
      MQMessage.mqPropertyNames_["JMSDeliveryMode"] = true;
      MQMessage.mqPropertyNames_["JMSDestination"] = true;
      MQMessage.mqPropertyNames_["JMSExpiration"] = true;
      MQMessage.mqPropertyNames_["JMSMessageID"] = true;
      MQMessage.mqPropertyNames_["JMSPriority"] = true;
      MQMessage.mqPropertyNames_["JMSReplyTo"] = true;
      MQMessage.mqPropertyNames_["JMSTimestamp"] = true;
      MQMessage.mqPropertyNames_["JMSType"] = true;
      MQMessage.mqPropertyNames_["JMSXAppID"] = true;
      MQMessage.mqPropertyNames_["JMSXDeliveryCount"] = true;
      MQMessage.mqPropertyNames_["JMSXGroupID"] = true;
      MQMessage.mqPropertyNames_["JMSXGroupSeq"] = true;
      MQMessage.mqPropertyNames_["JMSXUserID"] = true;
      if (MQMessage.namedProperties == null)
      {
        MQMessage.namedProperties = new Hashtable();
        MQMessage.namedProperties.Add("jms.Cid", "JMSCorrelationID");
        MQMessage.namedProperties.Add("jms.Dlv", "JMSDeliveryMode");
        MQMessage.namedProperties.Add("jms.Dst", "JMSDestination");
        MQMessage.namedProperties.Add("jms.Exp", "JMSExpiration");
        MQMessage.namedProperties.Add("jms.Pri", "JMSPriority");
        MQMessage.namedProperties.Add("jms.Rto", "JMSReplyTo");
        MQMessage.namedProperties.Add("jms.Tms", "JMSTimestamp");
        MQMessage.namedProperties.Add("mcd.Type", "JMSType");
        MQMessage.namedProperties.Add("mcd.Set", "JMSType");
        MQMessage.namedProperties.Add("mcd.Fmt", "JMSType");
      }
    }

    internal byte[] GetBuffer()
    {
      byte[] result;
      byte[] array = this.memoryStream.ToArray();
      result = array;
      return result;
    }

    public void ClearMessage()
    {
      this.memoryStream = new MemoryStream();
      this.memoryStream.SetLength(0L);
      this.totalMessageLength = 0;
      this.spiInherited = false;
      this.spiQTime = 0uL;
      this.binaryReader = new BinaryReader(this.memoryStream);
      this.binaryWriter = new BinaryWriter(this.memoryStream);
    }

    public string ReadString(int length)
    {
      string result = "";

      if (this.DataLength == 0)
      {
        this.binaryReader.ReadString();
      }
      int num = length * 2;
      if (num != 0)
      {
        int options = 0;
        long position = this.memoryStream.Position;
        int dataLength = this.DataLength;
        byte[] inString = this.binaryReader.ReadBytes(dataLength);
        this.Seek((int)position);
        if (this.CharacterSet == 1200 && (this.Encoding & 15) == 1)
        {
          options = 268435984;
        }
        byte[] array;
        uint num3;
        uint num2 = CommonServices.ConvertString(this.CharacterSet, 1200, inString, dataLength, out array, ref num, options, out num3);
        if (num2 != 0u && 276848725u != num2)
        {
          base.ThrowNewMQException(2, 2195);
        }
        this.Seek((int)position + (int)num3);
        result = System.Text.Encoding.Unicode.GetString(array, 0, num);
      }

      return result;
    }

    public void Seek(int offset)
    {
      if ((long)offset > this.memoryStream.Length)
      {
        throw new EndOfStreamException();
      }
      this.memoryStream.Seek((long)offset, 0);
    }

    public void Write(byte[] b, int off, int len)
    {
      this.binaryWriter.Write(b, off, len);
    }

    public void WriteByte(int value)
    {
      this.binaryWriter.Write(Convert.ToByte(value));
    }

    public void WriteChar(int v)
    {
      this.binaryWriter.Write(Convert.ToInt16(v));
    }

    public void WriteChars(string s)
    {
      this.binaryWriter.Write(System.Text.Encoding.Unicode.GetBytes(s.ToCharArray()));
    }

    public void WriteBytes(string s)
    {
      byte[] bytes = System.Text.Encoding.Unicode.GetBytes(s);
      for (int i = 0; i < bytes.Length; i += 2)
      {
        this.binaryWriter.Write(bytes[i]);
      }
    }

    private void WriteString(string s, bool bWriteUTF)
    {
      int options = 0;
      int characterSet = this.CharacterSet;
      if (characterSet != 0)
      {
        if (characterSet != 1200)
        {
          goto IL_6B;
        }
      }
      else
      {
        this.CharacterSet = 1200;
      }
      if ((this.Encoding & 15) != 1)
      {
        this.WriteChars(s);
        goto IL_12A;
      }
      options = 268435744;
      IL_6B:
      int byteCount = System.Text.Encoding.Unicode.GetByteCount(s);
      byte[] array = new byte[byteCount];
      System.Text.Encoding.Unicode.GetBytes(s, 0, s.Length, array, 0);
      int num = 0;
      byte[] array2;
      uint num3;
      uint num2 = CommonServices.ConvertString(1200, this.CharacterSet, array, byteCount, out array2, ref num, options, out num3);
      if (num2 != 0u)
      {
        base.ThrowNewMQException(2, 2195);
      }
      if (bWriteUTF)
      {
        if (num > 65535)
        {
          base.ThrowNewMQException(2, 2190);
        }
        else
        {
          ushort num4 = (ushort)num;
          byte[] bytes = BitConverter.GetBytes(num4);
          Array.Reverse(bytes);
          this.binaryWriter.Write(bytes);
        }
      }
      this.binaryWriter.Write(array2, 0, num);
      IL_12A:;

    }

    public void WriteString(string s)
    {
        this.WriteString(s, false);
    }

  }
}
