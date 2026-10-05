using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	public class X931Signer : ISigner
	{
		// Token: 0x06001816 RID: 6166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x529A400", Offset = "0x5299000", VA = "0x18529A400")]
		public X931Signer(IAsymmetricBlockCipher cipher, IDigest digest, bool isImplicit)
		{
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000340")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001817")]
			[Address(RVA = "0x529A650", Offset = "0x5299250", VA = "0x18529A650", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x529A530", Offset = "0x5299130", VA = "0x18529A530")]
		public X931Signer(IAsymmetricBlockCipher cipher, IDigest digest)
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x5299FC0", Offset = "0x5298BC0", VA = "0x185299FC0", Slot = "12")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x5267400", Offset = "0x5266000", VA = "0x185267400")]
		private void ClearBlock(byte[] block)
		{
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x529A200", Offset = "0x5298E00", VA = "0x18529A200", Slot = "13")]
		public virtual void Update(byte b)
		{
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x5299C70", Offset = "0x5298870", VA = "0x185299C70", Slot = "14")]
		public virtual void BlockUpdate(byte[] input, int off, int len)
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x529A1B0", Offset = "0x5298DB0", VA = "0x18529A1B0", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x5299E80", Offset = "0x5298A80", VA = "0x185299E80", Slot = "16")]
		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181F")]
		[Address(RVA = "0x5299CF0", Offset = "0x52988F0", VA = "0x185299CF0")]
		private void CreateSignatureBlock()
		{
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x6001820")]
		[Address(RVA = "0x529A260", Offset = "0x5298E60", VA = "0x18529A260", Slot = "17")]
		public virtual bool VerifySignature(byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000CD7")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_IMPLICIT = 188;

		// Token: 0x04000CD8 RID: 3288
		[Token(Token = "0x4000CD8")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_RIPEMD160 = 12748;

		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_RIPEMD128 = 13004;

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA1 = 13260;

		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA256 = 13516;

		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA512 = 13772;

		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA384 = 14028;

		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_WHIRLPOOL = 14284;

		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA224 = 14540;

		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x10")]
		private IDigest digest;

		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x18")]
		private IAsymmetricBlockCipher cipher;

		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x20")]
		private RsaKeyParameters kParam;

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x28")]
		private int trailer;

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x2C")]
		private int keyBits;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x30")]
		private byte[] block;
	}
}
