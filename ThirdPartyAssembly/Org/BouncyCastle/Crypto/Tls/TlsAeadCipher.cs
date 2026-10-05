using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Modes;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	public class TlsAeadCipher : TlsCipher
	{
		// Token: 0x06001569 RID: 5481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x5251DE0", Offset = "0x52509E0", VA = "0x185251DE0")]
		public TlsAeadCipher(TlsContext context, IAeadBlockCipher clientWriteCipher, IAeadBlockCipher serverWriteCipher, int cipherKeySize, int macSize)
		{
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x5251940", Offset = "0x5250540", VA = "0x185251940")]
		internal TlsAeadCipher(TlsContext context, IAeadBlockCipher clientWriteCipher, IAeadBlockCipher serverWriteCipher, int cipherKeySize, int macSize, int nonceMode)
		{
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0000B070 File Offset: 0x00009270
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x5251930", Offset = "0x5250530", VA = "0x185251930", Slot = "7")]
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return 0;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x52513F0", Offset = "0x524FFF0", VA = "0x1852513F0", Slot = "8")]
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			return null;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x5250F60", Offset = "0x524FB60", VA = "0x185250F60", Slot = "9")]
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			return null;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x5251820", Offset = "0x5250420", VA = "0x185251820", Slot = "10")]
		protected virtual byte[] GetAdditionalData(long seqNo, byte type, int len)
		{
			return null;
		}

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		public const int NONCE_RFC5288 = 1;

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		internal const int NONCE_DRAFT_CHACHA20_POLY1305 = 2;

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x10")]
		protected readonly TlsContext context;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x18")]
		protected readonly int macSize;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x1C")]
		protected readonly int record_iv_length;

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x20")]
		protected readonly IAeadBlockCipher encryptCipher;

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x28")]
		protected readonly IAeadBlockCipher decryptCipher;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x30")]
		protected readonly byte[] encryptImplicitNonce;

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x38")]
		protected readonly byte[] decryptImplicitNonce;

		// Token: 0x04000C05 RID: 3077
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x40")]
		protected readonly int nonceMode;
	}
}
