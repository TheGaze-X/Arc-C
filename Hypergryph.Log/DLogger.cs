using System;
using Il2CppDummyDll;

namespace Hypergryph.Log
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public static class DLogger
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4A0A080", Offset = "0x4A08C80", VA = "0x184A0A080")]
		public static void SetLogger(ILogger logger)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4A09F90", Offset = "0x4A08B90", VA = "0x184A09F90")]
		public static void Log(string message)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4A09E90", Offset = "0x4A08A90", VA = "0x184A09E90")]
		public static void Log(string channel, string message)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4A09CA0", Offset = "0x4A088A0", VA = "0x184A09CA0")]
		public static void LogWarning(string message)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4A09D90", Offset = "0x4A08990", VA = "0x184A09D90")]
		public static void LogWarning(string channel, string message)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4A09BC0", Offset = "0x4A087C0", VA = "0x184A09BC0")]
		public static void LogError(string message)
		{
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		private static ILogger s_logger;
	}
}
