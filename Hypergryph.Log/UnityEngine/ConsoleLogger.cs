using System;
using Hypergryph.Log;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public class ConsoleLogger : ILogger
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public ConsoleLogger(LogBuilder logBuilder)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4A09A40", Offset = "0x4A08640", VA = "0x184A09A40", Slot = "4")]
		public void Log(ref LogMessage msg)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4A09930", Offset = "0x4A08530", VA = "0x184A09930")]
		private static void LogToUnity(LogLevel level, string msg, Exception exception, Object context)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private LogBuilder m_logBuilder;
	}
}
