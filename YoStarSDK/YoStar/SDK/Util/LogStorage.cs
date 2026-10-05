using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	public class LogStorage
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x5C0B3E0", Offset = "0x5C09FE0", VA = "0x185C0B3E0")]
		public static void ApplyServerWriteEnabled(bool enabled)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x5C0B6F0", Offset = "0x5C0A2F0", VA = "0x185C0B6F0")]
		private static void DeleteLog(bool writeEnable)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x5C0C440", Offset = "0x5C0B040", VA = "0x185C0C440")]
		public static void SaveCrashLogsReport(string content)
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x5C0C7F0", Offset = "0x5C0B3F0", VA = "0x185C0C7F0")]
		public static void SaveSDKLogsReport(string content)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x5C0C4A0", Offset = "0x5C0B0A0", VA = "0x185C0C4A0")]
		private static void SaveLogsReport(string content, string path)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x5C0BCC0", Offset = "0x5C0A8C0", VA = "0x185C0BCC0")]
		private static void DrainWriteQueue()
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x5C0BEE0", Offset = "0x5C0AAE0", VA = "0x185C0BEE0")]
		private static string GetLogsPath(string path)
		{
			return null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x5C0C850", Offset = "0x5C0B450", VA = "0x185C0C850")]
		private static void WriteLog(string content, string logsPath)
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x5C0BE50", Offset = "0x5C0AA50", VA = "0x185C0BE50")]
		private static void EnsureDirectory(string path)
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x5C0C050", Offset = "0x5C0AC50", VA = "0x185C0C050")]
		private static string MaskSensitiveData(string content)
		{
			return null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x5C0C3B0", Offset = "0x5C0AFB0", VA = "0x185C0C3B0")]
		private static string MaskToken(string val)
		{
			return null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x5C0B690", Offset = "0x5C0A290", VA = "0x185C0B690")]
		private static void DeleteAllSDKLogs()
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x5C0B4C0", Offset = "0x5C0A0C0", VA = "0x185C0B4C0")]
		private static void DeleteAllCrashLogs()
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x5C0B520", Offset = "0x5C0A120", VA = "0x185C0B520")]
		private static void DeleteAllLogs(string path)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x5C0BC10", Offset = "0x5C0A810", VA = "0x185C0BC10")]
		private static void DeleteOldSDKLogs(int keepDays = 3)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x5C0B910", Offset = "0x5C0A510", VA = "0x185C0B910")]
		private static void DeleteOldCrashLogs(int keepDays = 3)
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x5C0B9C0", Offset = "0x5C0A5C0", VA = "0x185C0B9C0")]
		private static void DeleteOldLogDirs(string parentPath, int keepDays = 3)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LogStorage()
		{
		}

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string persistentDataPath;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x8")]
		private static bool _writeEnabled;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		private const string TechSdkLogsRoot = "TechSDKLogs";

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		private const string TechCrashLogsRoot = "TechCrashLogs";

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x10")]
		[TupleElementNames(new string[]
		{
			"content",
			"logsPath"
		})]
		private static readonly ConcurrentQueue<ValueTuple<string, string>> WriteQueue;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x18")]
		private static int _isWriting;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Regex RegexToken;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Regex RegexUrlToken;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Regex RegexEmail;
	}
}
