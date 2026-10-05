using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public static class CriErrorNotifier
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060007A3 RID: 1955 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060007A4 RID: 1956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000019")]
		private static event CriErrorNotifier.Callback _onCallbackThreadUnsafe
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x36F3BA0", Offset = "0x36F27A0", VA = "0x1836F3BA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x36F3F00", Offset = "0x36F2B00", VA = "0x1836F3F00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060007A5 RID: 1957 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060007A6 RID: 1958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400001A")]
		public static event CriErrorNotifier.Callback OnCallbackThreadUnsafe
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x36F38D0", Offset = "0x36F24D0", VA = "0x1836F38D0")]
			add
			{
			}
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x36F3C90", Offset = "0x36F2890", VA = "0x1836F3C90")]
			remove
			{
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x36F35D0", Offset = "0x36F21D0", VA = "0x1836F35D0")]
		public static bool IsRegistered(CriErrorNotifier.Callback target)
		{
			return default(bool);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x36F3340", Offset = "0x36F1F40", VA = "0x1836F3340")]
		public static void CallEvent(string message)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x36F37A0", Offset = "0x36F23A0", VA = "0x1836F37A0")]
		public static void SetCallbackNative(IntPtr errorCallback)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x36F3710", Offset = "0x36F2310", VA = "0x1836F3710")]
		internal static void SetCallbackNative(CriErrorNotifier.ErrorCallbackFunc errorCallback)
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x36F3560", Offset = "0x36F2160", VA = "0x1836F3560")]
		internal static CriErrorNotifier.ErrorCallbackFunc GetManagedPluginFunc()
		{
			return null;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x36F33E0", Offset = "0x36F1FE0", VA = "0x1836F33E0")]
		[MonoPInvokeCallback(typeof(CriErrorNotifier.ErrorCallbackFunc))]
		private static void ErrorCallbackFromNative(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray)
		{
		}

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object objectLock;

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x060007AF RID: 1967
		[Token(Token = "0x20000E6")]
		public delegate void Callback(string message);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060007B3 RID: 1971
		[Token(Token = "0x20000E7")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void ErrorCallbackFunc(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray);

		// Token: 0x020000E8 RID: 232
		[Token(Token = "0x20000E8")]
		private static class NativeMethod
		{
			// Token: 0x060007B6 RID: 1974
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x36F3710", Offset = "0x36F2310", VA = "0x1836F3710")]
			[PreserveSig]
			internal static extern void criErr_SetCallback(CriErrorNotifier.ErrorCallbackFunc callback);

			// Token: 0x060007B7 RID: 1975
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x36F37A0", Offset = "0x36F23A0", VA = "0x1836F37A0")]
			[PreserveSig]
			internal static extern void criErr_SetCallback(IntPtr callback);

			// Token: 0x060007B8 RID: 1976
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x3707B70", Offset = "0x3706770", VA = "0x183707B70")]
			[PreserveSig]
			internal static extern IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2);
		}
	}
}
