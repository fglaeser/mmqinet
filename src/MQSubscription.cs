using Mmqi.Native;
using System;
using System.Runtime.InteropServices;

namespace Mmqi
{
  public class MQSubscription
  {
    protected IMQQueueManager qMgr;
    internal int objectHandle;
    internal int subscriptionHandle;
    protected MQQueue _subQueue;

    public bool IsOpen
    {
      get
      {
        return subscriptionHandle != MQC.MQHO_NONE && MQC.MQHO_UNUSABLE_HOBJ != subscriptionHandle;
      }
    }

    public int SubQueueHandle { get { return objectHandle; } }

    public int SubscriptionHandle { get { return subscriptionHandle; } }

    public MQSubscription(IMQQueueManager queueMgr)
    {
      qMgr = queueMgr;
    }

    public void Subscribe(MQSubscriptionDescriptor subscriptionDescriptor, int subqueueHandle = MQC.MQHO_NONE)
    {
      int compCode, reason;
      byte[] array = new byte[subscriptionDescriptor.GetRequiredBufferSize()];
      subscriptionDescriptor.WriteStruct(array, 0);
      objectHandle = subqueueHandle;
      IntPtr intPtr = Marshal.AllocCoTaskMem(array.Length);
      try
      {
        Marshal.Copy(array, 0, intPtr, array.Length);
        Bindings.MQSUB(qMgr.Handle, intPtr, ref objectHandle, out subscriptionHandle, out compCode, out reason);
      }
      finally
      {
        if (intPtr != IntPtr.Zero) Marshal.FreeCoTaskMem(intPtr);
      }
      if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);
      _subQueue = new MQQueue(qMgr);
      _subQueue.objectHandle = objectHandle;
    }

    public void Subscribe(string subscriptionName, int subscriptionOptions, string topicName, string topicObject = "", string alternateUserId = null, int subqueueHandle = MQC.MQHO_NONE)
    {
      var descriptor = new MQSubscriptionDescriptor();
      if (!string.IsNullOrEmpty(alternateUserId))
        descriptor.AlternateUserId = alternateUserId;

      descriptor.ObjectName = topicObject;
      descriptor.ObjectString.VSString = topicName;
      descriptor.SubName.VSString = subscriptionName;
      descriptor.Options = subscriptionOptions;
      Subscribe(descriptor, subqueueHandle);
    }

    public void Close(int options = MQC.MQCO_NONE, bool closeSubQueue = true, int closeSubQueueOptions = MQC.MQCO_NONE)
    {
      int compCode, reason;
      if (qMgr != null && qMgr.IsConnected && IsOpen)
      {
        Bindings.MQCLOSE(qMgr.Handle, ref subscriptionHandle, options, out compCode, out reason);
        if (compCode != MQC.MQCC_OK) throw new MQException(compCode, reason);

        subscriptionHandle = MQC.MQHO_UNUSABLE_HOBJ;

        if (closeSubQueue)
        {
          _subQueue.CloseOptions = closeSubQueueOptions;
          _subQueue.Close();
        }
      }
    }

    public void Get(MQMessage message, MQGetMessageOptions gmo) => _subQueue.Get(message, gmo);

  }
}
