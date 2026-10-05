using System;
using Il2CppDummyDll;

namespace Sirenix.Serialization
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public class CustomLogger : ILogger
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4E1C7F0", Offset = "0x4E1B3F0", VA = "0x184E1C7F0")]
		public CustomLogger(Action<string> logWarningDelegate, Action<string> logErrorDelegate, Action<Exception> logExceptionDelegate)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x170CCC0", Offset = "0x170B8C0", VA = "0x18170CCC0", Slot = "4")]
		public void LogWarning(string warning)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x32279A0", Offset = "0x32265A0", VA = "0x1832279A0", Slot = "5")]
		public void LogError(string error)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4E1C7C0", Offset = "0x4E1B3C0", VA = "0x184E1C7C0", Slot = "6")]
		public void LogException(Exception exception)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private Action<string> logWarningDelegate;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private Action<string> logErrorDelegate;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		private Action<Exception> logExceptionDelegate;
	}
}
