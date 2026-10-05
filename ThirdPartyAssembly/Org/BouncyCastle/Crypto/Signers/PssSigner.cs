using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	public class PssSigner : ISigner
	{
		// Token: 0x060017F1 RID: 6129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x5268ED0", Offset = "0x5267AD0", VA = "0x185268ED0")]
		public static PssSigner CreateRawSigner(IAsymmetricBlockCipher cipher, IDigest digest)
		{
			return null;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x5268FD0", Offset = "0x5267BD0", VA = "0x185268FD0")]
		public static PssSigner CreateRawSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest, IDigest mgfDigest, int saltLen, byte trailer)
		{
			return null;
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x526A1B0", Offset = "0x5268DB0", VA = "0x18526A1B0")]
		public PssSigner(IAsymmetricBlockCipher cipher, IDigest digest)
		{
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F4")]
		[Address(RVA = "0x526A140", Offset = "0x5268D40", VA = "0x18526A140")]
		public PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, int saltLen)
		{
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x526A170", Offset = "0x5268D70", VA = "0x18526A170")]
		public PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, byte[] salt)
		{
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x526A440", Offset = "0x5269040", VA = "0x18526A440")]
		public PssSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest, IDigest mgfDigest, int saltLen)
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x526A3B0", Offset = "0x5268FB0", VA = "0x18526A3B0")]
		public PssSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest, IDigest mgfDigest, byte[] salt)
		{
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x526A140", Offset = "0x5268D40", VA = "0x18526A140")]
		public PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, int saltLen, byte trailer)
		{
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x526A400", Offset = "0x5269000", VA = "0x18526A400")]
		public PssSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest, IDigest mgfDigest, int saltLen, byte trailer)
		{
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x526A240", Offset = "0x5268E40", VA = "0x18526A240")]
		private PssSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest1, IDigest contentDigest2, IDigest mgfDigest, int saltLen, byte[] salt, byte trailer)
		{
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033D")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0x526A480", Offset = "0x5269080", VA = "0x18526A480", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FC")]
		[Address(RVA = "0x52693D0", Offset = "0x5267FD0", VA = "0x1852693D0", Slot = "12")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FD")]
		[Address(RVA = "0x5267400", Offset = "0x5266000", VA = "0x185267400")]
		private void ClearBlock(byte[] block)
		{
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x5269D10", Offset = "0x5268910", VA = "0x185269D10", Slot = "13")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x5268E50", Offset = "0x5267A50", VA = "0x185268E50", Slot = "14")]
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001800")]
		[Address(RVA = "0x5269CC0", Offset = "0x52688C0", VA = "0x185269CC0", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x52690B0", Offset = "0x5267CB0", VA = "0x1852690B0", Slot = "16")]
		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x5269D70", Offset = "0x5268970", VA = "0x185269D70", Slot = "17")]
		public virtual bool VerifySignature(byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x52697D0", Offset = "0x52683D0", VA = "0x1852697D0")]
		private void ItoOSP(int i, byte[] sp)
		{
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001804")]
		[Address(RVA = "0x5269830", Offset = "0x5268430", VA = "0x185269830")]
		private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
		{
			return null;
		}

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		public const byte TrailerImplicit = 188;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDigest contentDigest1;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDigest contentDigest2;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x20")]
		private readonly IDigest mgfDigest;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x28")]
		private readonly IAsymmetricBlockCipher cipher;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x30")]
		private SecureRandom random;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x38")]
		private int hLen;

		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x3C")]
		private int mgfhLen;

		// Token: 0x04000CC9 RID: 3273
		[Token(Token = "0x4000CC9")]
		[FieldOffset(Offset = "0x40")]
		private int sLen;

		// Token: 0x04000CCA RID: 3274
		[Token(Token = "0x4000CCA")]
		[FieldOffset(Offset = "0x44")]
		private bool sSet;

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x48")]
		private int emBits;

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x50")]
		private byte[] salt;

		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		[FieldOffset(Offset = "0x58")]
		private byte[] mDash;

		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		[FieldOffset(Offset = "0x60")]
		private byte[] block;

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x68")]
		private byte trailer;
	}
}
