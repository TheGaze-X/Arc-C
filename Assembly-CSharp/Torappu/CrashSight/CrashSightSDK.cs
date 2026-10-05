using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.CrashSight
{
	// Token: 0x020016FD RID: 5885
	[Token(Token = "0x20016FD")]
	public static class CrashSightSDK
	{
		// Token: 0x060094DE RID: 38110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094DE")]
		[Address(RVA = "0x3103470", Offset = "0x3102070", VA = "0x183103470")]
		public static void Init()
		{
		}

		// Token: 0x060094DF RID: 38111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094DF")]
		[Address(RVA = "0x3103740", Offset = "0x3102340", VA = "0x183103740")]
		public static void UpdateUserIdSafe(string uid)
		{
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x0003A0E0 File Offset: 0x000382E0
		[Token(Token = "0x60094E0")]
		[Address(RVA = "0x31037E0", Offset = "0x31023E0", VA = "0x1831037E0")]
		private static bool _CrashSightLogFilter(string condition, string stackTrace, LogType logType)
		{
			return default(bool);
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094E1")]
		[Address(RVA = "0x3103820", Offset = "0x3102420", VA = "0x183103820")]
		private static void _OnQuitGame()
		{
		}

		// Token: 0x04008AF5 RID: 35573
		[Token(Token = "0x4008AF5")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_isDebugMode;

		// Token: 0x04008AF6 RID: 35574
		[Token(Token = "0x4008AF6")]
		[FieldOffset(Offset = "0x1")]
		private static bool s_isQuitingGame;
	}
}
