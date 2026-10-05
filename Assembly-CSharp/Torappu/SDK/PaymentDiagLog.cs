using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.SDK
{
	// Token: 0x020014D6 RID: 5334
	[Token(Token = "0x20014D6")]
	internal static class PaymentDiagLog
	{
		// Token: 0x06007B14 RID: 31508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B14")]
		[Address(RVA = "0x273E4D0", Offset = "0x273D0D0", VA = "0x18273E4D0")]
		public static void Write(string tag, string message)
		{
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B15")]
		[Address(RVA = "0x273E410", Offset = "0x273D010", VA = "0x18273E410")]
		public static void WriteException(string tag, Exception ex)
		{
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B16")]
		[Address(RVA = "0x273E370", Offset = "0x273CF70", VA = "0x18273E370")]
		public static void Separator(string title)
		{
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B17")]
		[Address(RVA = "0x273E290", Offset = "0x273CE90", VA = "0x18273E290")]
		public static void EnsureSDKLogHook()
		{
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B18")]
		[Address(RVA = "0x273ED90", Offset = "0x273D990", VA = "0x18273ED90")]
		private static void _OnUnityLogMessage(string condition, string stackTrace, LogType type)
		{
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B19")]
		[Address(RVA = "0x273E8D0", Offset = "0x273D4D0", VA = "0x18273E8D0")]
		private static void _EnsureLogPath()
		{
		}

		// Token: 0x04007950 RID: 31056
		[Token(Token = "0x4007950")]
		[FieldOffset(Offset = "0x0")]
		private static string s_logPath;

		// Token: 0x04007951 RID: 31057
		[Token(Token = "0x4007951")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_pathAnnounced;

		// Token: 0x04007952 RID: 31058
		[Token(Token = "0x4007952")]
		[FieldOffset(Offset = "0x9")]
		private static bool s_sdkLogHooked;

		// Token: 0x04007953 RID: 31059
		[Token(Token = "0x4007953")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object s_lock;
	}
}
