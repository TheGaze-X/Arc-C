using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Modes;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	public class DefaultTlsCipherFactory : AbstractTlsCipherFactory
	{
		// Token: 0x06001484 RID: 5252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x5247120", Offset = "0x5245D20", VA = "0x185247120", Slot = "5")]
		public override TlsCipher CreateCipher(TlsContext context, int encryptionAlgorithm, int macAlgorithm)
		{
			return null;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x52465C0", Offset = "0x52451C0", VA = "0x1852465C0", Slot = "6")]
		protected virtual TlsBlockCipher CreateAESCipher(TlsContext context, int cipherKeySize, int macAlgorithm)
		{
			return null;
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x5246B10", Offset = "0x5245710", VA = "0x185246B10", Slot = "7")]
		protected virtual TlsBlockCipher CreateCamelliaCipher(TlsContext context, int cipherKeySize, int macAlgorithm)
		{
			return null;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x5246CC0", Offset = "0x52458C0", VA = "0x185246CC0", Slot = "8")]
		protected virtual TlsCipher CreateChaCha20Poly1305(TlsContext context)
		{
			return null;
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x5246D20", Offset = "0x5245920", VA = "0x185246D20", Slot = "9")]
		protected virtual TlsAeadCipher CreateCipher_Aes_Ccm(TlsContext context, int cipherKeySize, int macSize)
		{
			return null;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x5246E20", Offset = "0x5245A20", VA = "0x185246E20", Slot = "10")]
		protected virtual TlsAeadCipher CreateCipher_Aes_Gcm(TlsContext context, int cipherKeySize, int macSize)
		{
			return null;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x5246F20", Offset = "0x5245B20", VA = "0x185246F20", Slot = "11")]
		protected virtual TlsAeadCipher CreateCipher_Aes_Ocb(TlsContext context, int cipherKeySize, int macSize)
		{
			return null;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x5247020", Offset = "0x5245C20", VA = "0x185247020", Slot = "12")]
		protected virtual TlsAeadCipher CreateCipher_Camellia_Gcm(TlsContext context, int cipherKeySize, int macSize)
		{
			return null;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x52474D0", Offset = "0x52460D0", VA = "0x1852474D0", Slot = "13")]
		protected virtual TlsBlockCipher CreateDesEdeCipher(TlsContext context, int macAlgorithm)
		{
			return null;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x5247780", Offset = "0x5246380", VA = "0x185247780", Slot = "14")]
		protected virtual TlsNullCipher CreateNullCipher(TlsContext context, int macAlgorithm)
		{
			return null;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x5247860", Offset = "0x5246460", VA = "0x185247860", Slot = "15")]
		protected virtual TlsStreamCipher CreateRC4Cipher(TlsContext context, int cipherKeySize, int macAlgorithm)
		{
			return null;
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x5247AA0", Offset = "0x52466A0", VA = "0x185247AA0", Slot = "16")]
		protected virtual TlsBlockCipher CreateSeedCipher(TlsContext context, int macAlgorithm)
		{
			return null;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x5246A30", Offset = "0x5245630", VA = "0x185246A30", Slot = "17")]
		protected virtual IBlockCipher CreateAesEngine()
		{
			return null;
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x5246C70", Offset = "0x5245870", VA = "0x185246C70", Slot = "18")]
		protected virtual IBlockCipher CreateCamelliaEngine()
		{
			return null;
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x52469A0", Offset = "0x52455A0", VA = "0x1852469A0", Slot = "19")]
		protected virtual IBlockCipher CreateAesBlockCipher()
		{
			return null;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x5246720", Offset = "0x5245320", VA = "0x185246720", Slot = "20")]
		protected virtual IAeadBlockCipher CreateAeadBlockCipher_Aes_Ccm()
		{
			return null;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x52467B0", Offset = "0x52453B0", VA = "0x1852467B0", Slot = "21")]
		protected virtual IAeadBlockCipher CreateAeadBlockCipher_Aes_Gcm()
		{
			return null;
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x5246840", Offset = "0x5245440", VA = "0x185246840", Slot = "22")]
		protected virtual IAeadBlockCipher CreateAeadBlockCipher_Aes_Ocb()
		{
			return null;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x5246910", Offset = "0x5245510", VA = "0x185246910", Slot = "23")]
		protected virtual IAeadBlockCipher CreateAeadBlockCipher_Camellia_Gcm()
		{
			return null;
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x5246A80", Offset = "0x5245680", VA = "0x185246A80", Slot = "24")]
		protected virtual IBlockCipher CreateCamelliaBlockCipher()
		{
			return null;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x5247440", Offset = "0x5246040", VA = "0x185247440", Slot = "25")]
		protected virtual IBlockCipher CreateDesEdeBlockCipher()
		{
			return null;
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x52479C0", Offset = "0x52465C0", VA = "0x1852479C0", Slot = "26")]
		protected virtual IStreamCipher CreateRC4StreamCipher()
		{
			return null;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x5247A10", Offset = "0x5246610", VA = "0x185247A10", Slot = "27")]
		protected virtual IBlockCipher CreateSeedBlockCipher()
		{
			return null;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x5247620", Offset = "0x5246220", VA = "0x185247620", Slot = "28")]
		protected virtual IDigest CreateHMacDigest(int macAlgorithm)
		{
			return null;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultTlsCipherFactory()
		{
		}
	}
}
