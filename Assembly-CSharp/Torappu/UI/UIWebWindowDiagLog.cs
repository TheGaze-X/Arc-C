using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020038B5 RID: 14517
	[Token(Token = "0x20038B5")]
	internal static class UIWebWindowDiagLog
	{
		// Token: 0x06016F62 RID: 94050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F62")]
		[Address(RVA = "0xF69790", Offset = "0xF68390", VA = "0x180F69790")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("UNITY_STANDALONE_WIN")]
		public static void Write(string tag, string message)
		{
		}

		// Token: 0x06016F63 RID: 94051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F63")]
		[Address(RVA = "0xF69D10", Offset = "0xF68910", VA = "0x180F69D10")]
		private static void _EnsureLogPath()
		{
		}

		// Token: 0x0401BB84 RID: 113540
		[Token(Token = "0x401BB84")]
		[FieldOffset(Offset = "0x0")]
		private static string s_logPath;

		// Token: 0x0401BB85 RID: 113541
		[Token(Token = "0x401BB85")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_pathLogged;
	}
}
