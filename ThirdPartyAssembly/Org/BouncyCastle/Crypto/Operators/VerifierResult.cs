using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	internal class VerifierResult : IVerifier
	{
		// Token: 0x06001992 RID: 6546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal VerifierResult(ISigner sig)
		{
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x6001993")]
		[Address(RVA = "0x5297510", Offset = "0x5296110", VA = "0x185297510", Slot = "4")]
		public bool IsVerified(byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x6001994")]
		[Address(RVA = "0x5297450", Offset = "0x5296050", VA = "0x185297450", Slot = "5")]
		public bool IsVerified(byte[] signature, int off, int length)
		{
			return default(bool);
		}

		// Token: 0x04000D65 RID: 3429
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x10")]
		private readonly ISigner sig;
	}
}
