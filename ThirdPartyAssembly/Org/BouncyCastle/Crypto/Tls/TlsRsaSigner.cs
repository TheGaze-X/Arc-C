using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	public class TlsRsaSigner : AbstractTlsSigner
	{
		// Token: 0x060016CE RID: 5838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x5273510", Offset = "0x5272110", VA = "0x185273510", Slot = "16")]
		public override byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter privateKey, byte[] hash)
		{
			return null;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x5273BF0", Offset = "0x52727F0", VA = "0x185273BF0", Slot = "18")]
		public override bool VerifyRawSignature(SignatureAndHashAlgorithm algorithm, byte[] sigBytes, AsymmetricKeyParameter publicKey, byte[] hash)
		{
			return default(bool);
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x52733B0", Offset = "0x5271FB0", VA = "0x1852733B0", Slot = "20")]
		public override ISigner CreateSigner(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter privateKey)
		{
			return null;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x52734A0", Offset = "0x52720A0", VA = "0x1852734A0", Slot = "22")]
		public override ISigner CreateVerifyer(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter publicKey)
		{
			return null;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x5273660", Offset = "0x5272260", VA = "0x185273660", Slot = "23")]
		public override bool IsValidPublicKey(AsymmetricKeyParameter publicKey)
		{
			return default(bool);
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x52736F0", Offset = "0x52722F0", VA = "0x1852736F0", Slot = "24")]
		protected virtual ISigner MakeSigner(SignatureAndHashAlgorithm algorithm, bool raw, bool forSigning, ICipherParameters cp)
		{
			return null;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x5273320", Offset = "0x5271F20", VA = "0x185273320", Slot = "25")]
		protected virtual IAsymmetricBlockCipher CreateRsaImpl()
		{
			return null;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public TlsRsaSigner()
		{
		}
	}
}
