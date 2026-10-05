using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	[AddComponentMenu("CRIWARE/Error Handler")]
	public class CriWareErrorHandler : CriMonoBehaviour
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009C")]
		public static string errorMessage
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x3705800", Offset = "0x3704400", VA = "0x183705800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x3705A80", Offset = "0x3704680", VA = "0x183705A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600078D RID: 1933 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600078E RID: 1934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000017")]
		private static event CriWareErrorHandler.Callback _onCallback
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x3705700", Offset = "0x3704300", VA = "0x183705700")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x3705980", Offset = "0x3704580", VA = "0x183705980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600078F RID: 1935 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000790 RID: 1936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000018")]
		public static event CriWareErrorHandler.Callback OnCallback
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x3705580", Offset = "0x3704180", VA = "0x183705580")]
			add
			{
			}
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x3705850", Offset = "0x3704450", VA = "0x183705850")]
			remove
			{
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x3704A50", Offset = "0x3703650", VA = "0x183704A50")]
		public void Initialize()
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x3704F60", Offset = "0x3703B60", VA = "0x183704F60", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x3704E30", Offset = "0x3703A30", VA = "0x183704E30", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x3704640", Offset = "0x3703240", VA = "0x183704640", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x3704CB0", Offset = "0x37038B0", VA = "0x183704CB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x3704C00", Offset = "0x3703800", VA = "0x183704C00")]
		private static bool IsEnableNativePrintMessageFunc()
		{
			return default(bool);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x3705260", Offset = "0x3703E60", VA = "0x183705260")]
		private static void RegisterErrorCallback()
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x3704640", Offset = "0x3703240", VA = "0x183704640")]
		private void DequeueErrorMessages()
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x37047D0", Offset = "0x37033D0", VA = "0x1837047D0")]
		private void HandleMessage(string errmsg)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x37050A0", Offset = "0x3703CA0", VA = "0x1837050A0")]
		private static void OutputDefaultLog(string errmsg)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x37054E0", Offset = "0x37040E0", VA = "0x1837054E0")]
		public CriWareErrorHandler()
		{
		}

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool enableDebugPrintOnTerminal;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool enableForceCrashOnError;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool dontDestroyOnLoad;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string logPrefix;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Obsolete("CriWareErrorHandler.callback is deprecated. Use CriWareErrorHandler.OnCallback event", false)]
		public static CriWareErrorHandler.Callback callback;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint messageBufferCounts;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ConcurrentQueue<string> unThreadSafeMessages;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _enableDebugPrintOnTerminal;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static int initializationCount;

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x0600079F RID: 1951
		[Token(Token = "0x20000E3")]
		public delegate void Callback(string message);

		// Token: 0x020000E4 RID: 228
		[Token(Token = "0x20000E4")]
		private static class NativeMethod
		{
			// Token: 0x060007A2 RID: 1954
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x3707B00", Offset = "0x3706700", VA = "0x183707B00")]
			[PreserveSig]
			internal static extern IntPtr CRIWARE9B3928F9();
		}
	}
}
