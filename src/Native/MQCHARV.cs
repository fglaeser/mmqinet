using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mmqi.Native
{
    public class MQCHARV : MQBase
    {

      internal MQBase.structMQCHARV mqcharv;

      internal MQBase.structMQCHARV32 mqcharv32;

      private string vsString;

      private bool isInputCapable;

      private bool isOutputCapable;

      private bool useNativePtrSz;

      public string VSString
      {
        get
        {
          return this.vsString;
        }
        set
        {
          this.vsString = value;
        }
      }

      public IntPtr VSPtr
      {
        get
        {
          return this.mqcharv.VSPtr;
        }
        set
        {
          this.mqcharv.VSPtr = value;
        }
      }

      public int VSPtr32
      {
        get
        {
          return this.mqcharv32.VSPtr;
        }
        set
        {
          this.mqcharv32.VSPtr = value;
        }
      }

      public int VSOffset
      {
        get
        {
          return this.mqcharv.VSOffset;
        }
        set
        {
          this.mqcharv.VSOffset = value;
          this.mqcharv32.VSOffset = value;
        }
      }

      public int VSLength
      {
        get
        {
          return this.mqcharv.VSLength;
        }
        set
        {
          this.mqcharv.VSLength = value;
          this.mqcharv32.VSLength = value;
        }
      }

      public int VSCCSID
      {
        get
        {
          return this.mqcharv.VSCCSID;
        }
        set
        {
          this.mqcharv.VSCCSID = value;
          this.mqcharv32.VSCCSID = value;
        }
      }

      public int VSBufSize
      {
        get
        {
          return this.mqcharv.VSBufSize;
        }
        set
        {
          this.mqcharv.VSBufSize = value;
          this.mqcharv32.VSBufSize = value;
        }
      }

      public bool UseNativePtrSz
      {
        get
        {
          return this.useNativePtrSz;
        }
        set
        {
          this.useNativePtrSz = value;
        }
      }

      internal MQCHARV(bool input, bool output)
      {
        this.isInputCapable = input;
        this.isOutputCapable = output;
        this.useNativePtrSz = true;
        this.mqcharv = default(MQBase.structMQCHARV);
        this.mqcharv32 = default(MQBase.structMQCHARV32);
        this.vsString = "";
        this.VSCCSID = 1208;
        this.VSLength = 0;
        this.VSBufSize = 0;
        this.VSOffset = 0;
        this.VSPtr = IntPtr.Zero;
        this.VSPtr32 = 0;
      }

      public int GetLength()
      {
        if (this.useNativePtrSz)
        {
          int num = Marshal.SizeOf(this.mqcharv);
          return num;
        }
        int num2 = Marshal.SizeOf(this.mqcharv32);
        return num2;
      }

      internal int WriteStruct(byte[] b, int structPos, int offset, int stringPos)
      {
        int num = 0;
        IntPtr intPtr = IntPtr.Zero;
        int num2;
        if (this.isInputCapable && this.vsString != null)
        {
          Encoding.ASCII.GetBytes(this.vsString, 0, this.vsString.Length, b, stringPos);
          num2 = (4 - (this.vsString.Length & 3) & 3);
          for (int i = 0; i < num2; i++)
          {
            b[stringPos + this.vsString.Length + i] = 0;
          }
          this.VSLength = this.vsString.Length;
        }
        else
        {
          this.VSLength = 0;
          num2 = 0;
        }
        num = Math.Max(this.VSLength + num2, this.VSBufSize + 3 & -4);
        this.mqcharv.VSPtr = IntPtr.Zero;
        this.mqcharv32.VSPtr = 0;
        this.VSOffset = stringPos - structPos;
        int length = this.GetLength();
        try
        {
          if (intPtr == IntPtr.Zero)
          {
            intPtr = Marshal.AllocCoTaskMem(length);
          }
          if (this.useNativePtrSz)
          {
            Marshal.StructureToPtr(this.mqcharv, intPtr, false);
          }
          else
          {
            Marshal.StructureToPtr(this.mqcharv32, intPtr, false);
          }
          Marshal.Copy(intPtr, b, offset, length);
        }
        finally
        {
          if (intPtr != IntPtr.Zero)
          {
            Marshal.FreeCoTaskMem(intPtr);
            intPtr = IntPtr.Zero;
          }
        }
        return stringPos + num;
      }

      internal int ReadStruct(byte[] b, int structPos, int offset)
      {
        int length = this.GetLength();
        IntPtr intPtr = IntPtr.Zero;
        try
        {
          if (intPtr == IntPtr.Zero)
          {
            intPtr = Marshal.AllocCoTaskMem(length);
          }
          Marshal.Copy(b, offset, intPtr, length);
          if (this.useNativePtrSz)
          {
            this.mqcharv = (MQBase.structMQCHARV)Marshal.PtrToStructure(intPtr, typeof(MQBase.structMQCHARV));
          }
          else
          {
            this.mqcharv32 = (MQBase.structMQCHARV32)Marshal.PtrToStructure(intPtr, typeof(MQBase.structMQCHARV32));
          }
          if (this.VSLength != 0)
          {
            int num = structPos + this.VSOffset;
            if (this.VSLength == -1)
            {
              this.VSLength = 0;
              int num2 = num;
              while (b[num2] != 0)
              {
                num2++;
                this.VSLength++;
              }
            }
            if (this.isOutputCapable)
            {
              int num3 = Math.Min(this.VSLength, this.VSBufSize);
              if (num3 != 0)
              {
                this.vsString = Encoding.ASCII.GetString(b, num, num3);
              }
              else
              {
                this.vsString = null;
              }
            }
          }
          else
          {
            this.VSOffset = 0;
          }
        }
        finally
        {
          if (intPtr != IntPtr.Zero)
          {
            Marshal.FreeCoTaskMem(intPtr);
            intPtr = IntPtr.Zero;
          }
        }
        return length;
      }

      internal int GetEndPosAligned(int structPos)
      {
        int num = structPos + this.VSOffset + Math.Min(this.VSLength, this.VSBufSize);
        num += (4 - (num & 3) & 3);
        return num;
      }
    }
  }

