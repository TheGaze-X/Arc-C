using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	public class TlsStreamCipher : TlsCipher
	{
		// Token: 0x06001711 RID: 5905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001711")]
		[Address(RVA = "0x5274DB0", Offset = "0x52739B0", VA = "0x185274DB0")]
		public TlsStreamCipher(TlsContext context, IStreamCipher clientWriteCipher, IStreamCipher serverWriteCipher, IDigest clientWriteDigest, IDigest serverWriteDigest, int cipherKeySize, bool usesNonce)
		{
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x6001712")]
		[Address(RVA = "0x5274C50", Offset = "0x5273850", VA = "0x185274C50", Slot = "7")]
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return 0;
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001713")]
		[Address(RVA = "0x5274AA0", Offset = "0x52736A0", VA = "0x185274AA0", Slot = "8")]
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			return null;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001714")]
		[Address(RVA = "0x52748B0", Offset = "0x52734B0", VA = "0x1852748B0", Slot = "9")]
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			return null;
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001715")]
		[Address(RVA = "0x52747C0", Offset = "0x52733C0", VA = "0x1852747C0", Slot = "10")]
		protected virtual void CheckMac(long seqNo, byte type, byte[] recBuf, int recStart, int recEnd, byte[] calcBuf, int calcOff, int calcLen)
		{
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x5274CB0", Offset = "0x52738B0", VA = "0x185274CB0", Slot = "11")]
		protected virtual void UpdateIV(IStreamCipher cipher, bool forEncryption, long seqNo)
		{
		}

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x10")]
		protected readonly TlsContext context;

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x18")]
		protected readonly IStreamCipher encryptCipher;

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x20")]
		protected readonly IStreamCipher decryptCipher;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x28")]
		protected readonly TlsMac writeMac;

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		[FieldOffset(Offset = "0x30")]
		protected readonly TlsMac readMac;

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		[FieldOffset(Offset = "0x38")]
		protected readonly bool usesNonce;
	}
}
