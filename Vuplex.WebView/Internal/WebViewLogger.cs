using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	public static class WebViewLogger
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x5BD6070", Offset = "0x5BD4C70", VA = "0x185BD6070")]
		public static void Log(string message, bool enableFormatting = true)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x5BD5E40", Offset = "0x5BD4A40", VA = "0x185BD5E40")]
		public static void LogError(string message, bool enableFormatting = true)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x5BD5DD0", Offset = "0x5BD49D0", VA = "0x185BD5DD0")]
		public static void LogErrorWithoutFormatting(string message)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x5BD5ED0", Offset = "0x5BD4AD0", VA = "0x185BD5ED0")]
		public static void LogTip(string message)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x5BD5FE0", Offset = "0x5BD4BE0", VA = "0x185BD5FE0")]
		public static void LogWarning(string message, bool enableFormatting = true)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x5BD5F70", Offset = "0x5BD4B70", VA = "0x185BD5F70")]
		public static void LogWarningWithoutFormatting(string message)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x5BD6100", Offset = "0x5BD4D00", VA = "0x185BD6100")]
		private static string _format(string originalMessage)
		{
			return null;
		}

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		private const string PREFIX = "[3D WebView] ";

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		private const string EM_OPENING_REPLACEMENT = "";

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		private const string EM_CLOSING_REPLACEMENT = "";
	}
}
