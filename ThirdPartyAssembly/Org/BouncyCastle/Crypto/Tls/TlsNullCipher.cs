using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200029C RID: 668
	[Token(Token = "0x200029C")]
	public class TlsNullCipher : TlsCipher
	{
		// Token: 0x06001674 RID: 5748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x526D210", Offset = "0x526BE10", VA = "0x18526D210")]
		public TlsNullCipher(TlsContext context)
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x526D260", Offset = "0x526BE60", VA = "0x18526D260")]
		public TlsNullCipher(TlsContext context, IDigest clientWriteDigest, IDigest serverWriteDigest)
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x526D1C0", Offset = "0x526BDC0", VA = "0x18526D1C0", Slot = "7")]
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return 0;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x526D0A0", Offset = "0x526BCA0", VA = "0x18526D0A0", Slot = "8")]
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			return null;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x526CEE0", Offset = "0x526BAE0", VA = "0x18526CEE0", Slot = "9")]
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			return null;
		}

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x10")]
		protected readonly TlsContext context;

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x18")]
		protected readonly TlsMac writeMac;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0x20")]
		protected readonly TlsMac readMac;
	}
}
