using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000290 RID: 656
	[Token(Token = "0x2000290")]
	public abstract class TlsDsaSigner : AbstractTlsSigner
	{
		// Token: 0x060015E1 RID: 5601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x5259CF0", Offset = "0x52588F0", VA = "0x185259CF0", Slot = "16")]
		public override byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter privateKey, byte[] hash)
		{
			return null;
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x525A120", Offset = "0x5258D20", VA = "0x18525A120", Slot = "18")]
		public override bool VerifyRawSignature(SignatureAndHashAlgorithm algorithm, byte[] sigBytes, AsymmetricKeyParameter publicKey, byte[] hash)
		{
			return default(bool);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x5259C10", Offset = "0x5258810", VA = "0x185259C10", Slot = "20")]
		public override ISigner CreateSigner(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter privateKey)
		{
			return null;
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x5259C80", Offset = "0x5258880", VA = "0x185259C80", Slot = "22")]
		public override ISigner CreateVerifyer(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter publicKey)
		{
			return null;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x2832290", Offset = "0x2830E90", VA = "0x182832290", Slot = "24")]
		protected virtual ICipherParameters MakeInitParameters(bool forSigning, ICipherParameters cp)
		{
			return null;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x5259E50", Offset = "0x5258A50", VA = "0x185259E50", Slot = "25")]
		protected virtual ISigner MakeSigner(SignatureAndHashAlgorithm algorithm, bool raw, bool forSigning, ICipherParameters cp)
		{
			return null;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060015E7 RID: 5607
		[Token(Token = "0x1700031A")]
		protected abstract byte SignatureAlgorithm { [Token(Token = "0x60015E7")] get; }

		// Token: 0x060015E8 RID: 5608
		[Token(Token = "0x60015E8")]
		protected abstract IDsa CreateDsaImpl(byte hashAlgorithm);

		// Token: 0x060015E9 RID: 5609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TlsDsaSigner()
		{
		}
	}
}
