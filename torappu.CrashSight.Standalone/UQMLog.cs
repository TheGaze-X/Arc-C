using System;
using Il2CppDummyDll;

namespace GCloud.UQM
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	internal class UQMLog
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x55AA280", Offset = "0x55A8E80", VA = "0x1855AA280")]
		public static void SetLevel(UQMLog.Level l)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x55AA1D0", Offset = "0x55A8DD0", VA = "0x1855AA1D0")]
		public static void Log(string message)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x55AA120", Offset = "0x55A8D20", VA = "0x1855AA120")]
		public static void LogWarning(string message)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x55AA070", Offset = "0x55A8C70", VA = "0x1855AA070")]
		public static void LogError(string message)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x55A9F50", Offset = "0x55A8B50", VA = "0x1855A9F50")]
		public static void FullLog(string message)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UQMLog()
		{
		}

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		private static UQMLog.Level level;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		private const string header = "[CrashSightPlugin-Unity]";

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		public enum Level
		{
			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			None,
			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			Log,
			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			Warning,
			// Token: 0x04000035 RID: 53
			[Token(Token = "0x4000035")]
			Error
		}
	}
}
