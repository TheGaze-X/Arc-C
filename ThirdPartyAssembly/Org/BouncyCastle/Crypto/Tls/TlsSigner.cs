using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	public interface TlsSigner
	{
		// Token: 0x060016F6 RID: 5878
		[Token(Token = "0x60016F6")]
		void Init(TlsContext context);

		// Token: 0x060016F7 RID: 5879
		[Token(Token = "0x60016F7")]
		byte[] GenerateRawSignature(AsymmetricKeyParameter privateKey, byte[] md5AndSha1);

		// Token: 0x060016F8 RID: 5880
		[Token(Token = "0x60016F8")]
		byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter privateKey, byte[] hash);

		// Token: 0x060016F9 RID: 5881
		[Token(Token = "0x60016F9")]
		bool VerifyRawSignature(byte[] sigBytes, AsymmetricKeyParameter publicKey, byte[] md5AndSha1);

		// Token: 0x060016FA RID: 5882
		[Token(Token = "0x60016FA")]
		bool VerifyRawSignature(SignatureAndHashAlgorithm algorithm, byte[] sigBytes, AsymmetricKeyParameter publicKey, byte[] hash);

		// Token: 0x060016FB RID: 5883
		[Token(Token = "0x60016FB")]
		ISigner CreateSigner(AsymmetricKeyParameter privateKey);

		// Token: 0x060016FC RID: 5884
		[Token(Token = "0x60016FC")]
		ISigner CreateSigner(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter privateKey);

		// Token: 0x060016FD RID: 5885
		[Token(Token = "0x60016FD")]
		ISigner CreateVerifyer(AsymmetricKeyParameter publicKey);

		// Token: 0x060016FE RID: 5886
		[Token(Token = "0x60016FE")]
		ISigner CreateVerifyer(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter publicKey);

		// Token: 0x060016FF RID: 5887
		[Token(Token = "0x60016FF")]
		bool IsValidPublicKey(AsymmetricKeyParameter publicKey);
	}
}
