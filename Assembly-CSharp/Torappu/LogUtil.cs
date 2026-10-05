using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020005A0 RID: 1440
	[Token(Token = "0x20005A0")]
	public static class LogUtil
	{
		// Token: 0x06005C92 RID: 23698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void LogF(string message, params object[] args)
		{
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0x1CF7680", Offset = "0x1CF6280", VA = "0x181CF7680")]
		public static void LogErrorF(string message, params object[] args)
		{
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C94")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void LogWarningF(string message, params object[] args)
		{
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C95")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void LogM(string module, string message)
		{
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C96")]
		[Address(RVA = "0x1CF76F0", Offset = "0x1CF62F0", VA = "0x181CF76F0")]
		public static void LogErrorM(string module, string message)
		{
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C97")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void LogWarningM(string module, string message)
		{
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C98")]
		public static void Log<T>(string message)
		{
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C99")]
		public static void LogError<T>(string message)
		{
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9A")]
		public static void LogWarning<T>(string message)
		{
		}
	}
}
