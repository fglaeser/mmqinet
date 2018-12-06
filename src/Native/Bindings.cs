using System;
using System.Runtime.InteropServices;

namespace Mmqi.Native
{
  internal static class Bindings
  {
    const string DLLNAME = "mqic";

    #region MQ Manager

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl)]
    public static extern void MQCONN(string qMgrName, out int pHconn, out int pCompCode, out int pReason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQDISC(out int hConn, out int compCode, out int reason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl)]
    public static extern void MQCONNX(string qMgrName, ref MQCNO mqcno, out int pHconn, out int pCompCode, out int pReason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQPUT1(int hConn, IntPtr mqodPtr, ref MQMD mqmd, ref MQPMO mqpmo, int length, [In] byte[] buffer, out int compCode, out int reason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQPUT1(int hConn, ref MQOD mqod, ref MQMD mqmd, ref MQPMO mqpmo, int length, [In] byte[] buffer, out int compCode, out int reason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQCMIT(int hconn, out int pCompCode, out int pReason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQBACK(int hconn, out int pCompCode, out int pReason);

    #endregion

    #region MQ Queue & Topic

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQOPEN(int hConn, ref MQOD mqod, int options, out int hObj, out int compCode, out int reason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQOPEN(int hConn, IntPtr odPtr, int options, out int hObj, out int compCode, out int reason);
    
    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQCLOSE(int hConn, ref int hObj, int options, out int compCode, out int reason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQPUT(int hConn, int hObj, ref MQMD mqmd, ref MQPMO mqpmo, int length, [In] byte[] buffer, out int compCode, out int reason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQGET(int hConn, int hObj, ref MQMD mqmd, ref MQGMO mqgmo, int bufferLength, [Out] byte[] buffer, out int dataLength, out int compCode, out int reason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQSUB(int hConn, ref MQSD mqsd, ref int hObj, out int hSub, out int compCode, out int reason);

    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void MQSUB(int hConn, IntPtr sdPtr, ref int hObj, out int hSub, out int compCode, out int reason);



    #endregion

  }
}
