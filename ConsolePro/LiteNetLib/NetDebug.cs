using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public static class NetDebug
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x369F090", Offset = "0x369DC90", VA = "0x18369F090")]
		private static void WriteLogic(NetLogLevel logLevel, string str, params object[] args)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x369F340", Offset = "0x369DF40", VA = "0x18369F340")]
		[Conditional("DEBUG_MESSAGES")]
		internal static void Write(string str, params object[] args)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x369F2D0", Offset = "0x369DED0", VA = "0x18369F2D0")]
		[Conditional("DEBUG_MESSAGES")]
		internal static void Write(NetLogLevel level, string str, params object[] args)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x369F030", Offset = "0x369DC30", VA = "0x18369F030")]
		[Conditional("DEBUG_MESSAGES")]
		[Conditional("DEBUG")]
		internal static void WriteForce(string str, params object[] args)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x369EFC0", Offset = "0x369DBC0", VA = "0x18369EFC0")]
		[Conditional("DEBUG_MESSAGES")]
		[Conditional("DEBUG")]
		internal static void WriteForce(NetLogLevel level, string str, params object[] args)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x369EF60", Offset = "0x369DB60", VA = "0x18369EF60")]
		internal static void WriteError(string str, params object[] args)
		{
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x0")]
		public static INetLogger Logger;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object DebugLogLock;
	}
}
