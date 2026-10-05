using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	public class Chacha20Poly1305 : TlsCipher
	{
		// Token: 0x0600145A RID: 5210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x5245910", Offset = "0x5244510", VA = "0x185245910")]
		public Chacha20Poly1305(TlsContext context)
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x5245550", Offset = "0x5244150", VA = "0x185245550", Slot = "7")]
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return 0;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x52450F0", Offset = "0x5243CF0", VA = "0x1852450F0", Slot = "8")]
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			return null;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x5244EE0", Offset = "0x5243AE0", VA = "0x185244EE0", Slot = "9")]
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			return null;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x5245560", Offset = "0x5244160", VA = "0x185245560", Slot = "10")]
		protected virtual KeyParameter InitRecord(IStreamCipher cipher, bool forEncryption, long seqNo, byte[] iv)
		{
			return null;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x5244C60", Offset = "0x5243860", VA = "0x185244C60", Slot = "11")]
		protected virtual byte[] CalculateNonce(long seqNo, byte[] iv)
		{
			return null;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x52452B0", Offset = "0x5243EB0", VA = "0x1852452B0", Slot = "12")]
		protected virtual KeyParameter GenerateRecordMacKey(IStreamCipher cipher)
		{
			return null;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x5244D30", Offset = "0x5243930", VA = "0x185244D30", Slot = "13")]
		protected virtual byte[] CalculateRecordMac(KeyParameter macKey, byte[] additionalData, byte[] buf, int off, int len)
		{
			return null;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x5245680", Offset = "0x5244280", VA = "0x185245680", Slot = "14")]
		protected virtual void UpdateRecordMacLength(IMac mac, int len)
		{
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x52457B0", Offset = "0x52443B0", VA = "0x1852457B0", Slot = "15")]
		protected virtual void UpdateRecordMacText(IMac mac, byte[] buf, int off, int len)
		{
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x5245440", Offset = "0x5244040", VA = "0x185245440", Slot = "16")]
		protected virtual byte[] GetAdditionalData(long seqNo, byte type, int len)
		{
			return null;
		}

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] Zeroes;

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		[FieldOffset(Offset = "0x10")]
		protected readonly TlsContext context;

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x18")]
		protected readonly ChaCha7539Engine encryptCipher;

		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x20")]
		protected readonly ChaCha7539Engine decryptCipher;

		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x28")]
		protected readonly byte[] encryptIV;

		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x30")]
		protected readonly byte[] decryptIV;
	}
}
