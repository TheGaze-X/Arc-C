using System;
using System.Collections.Generic;
using Hypergryph.Log;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public static class LogDefine
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x54E47B0", Offset = "0x54E33B0", VA = "0x1854E47B0")]
		public static string EditorLogBuilder(LogMessage msg)
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x54E4E30", Offset = "0x54E3A30", VA = "0x1854E4E30")]
		public static string RuntimeLogBuilder(LogMessage msg)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x54E4710", Offset = "0x54E3310", VA = "0x1854E4710")]
		public static ConsoleLogger CreateConsoleLogger()
		{
			return null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x54E4550", Offset = "0x54E3150", VA = "0x1854E4550")]
		public static string ConvertColorTagToName(LogColorTag colorTag)
		{
			return null;
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		public const bool USE_VERBOSE_MODE = false;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		public const string VERBOSE_LOG_DEFINE = "TEST";

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		public const string EDITOR_LOG_DEFINE = "UNITY_EDITOR";

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<string, string> CHANNEL_NAMES;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x8")]
		public static readonly LogChannel[] DEFAULT_CHANNELS;
	}
}
