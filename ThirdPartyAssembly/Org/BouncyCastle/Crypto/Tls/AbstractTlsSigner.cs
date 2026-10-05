using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	public abstract class AbstractTlsSigner : TlsSigner
	{
		// Token: 0x06001408 RID: 5128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "14")]
		public virtual void Init(TlsContext context)
		{
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x5241030", Offset = "0x523FC30", VA = "0x185241030", Slot = "15")]
		public virtual byte[] GenerateRawSignature(AsymmetricKeyParameter privateKey, byte[] md5AndSha1)
		{
			return null;
		}

		// Token: 0x0600140A RID: 5130
		[Token(Token = "0x600140A")]
		public abstract byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter privateKey, byte[] hash);

		// Token: 0x0600140B RID: 5131 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x5241090", Offset = "0x523FC90", VA = "0x185241090", Slot = "17")]
		public virtual bool VerifyRawSignature(byte[] sigBytes, AsymmetricKeyParameter publicKey, byte[] md5AndSha1)
		{
			return default(bool);
		}

		// Token: 0x0600140C RID: 5132
		[Token(Token = "0x600140C")]
		public abstract bool VerifyRawSignature(SignatureAndHashAlgorithm algorithm, byte[] sigBytes, AsymmetricKeyParameter publicKey, byte[] hash);

		// Token: 0x0600140D RID: 5133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x5240F90", Offset = "0x523FB90", VA = "0x185240F90", Slot = "19")]
		public virtual ISigner CreateSigner(AsymmetricKeyParameter privateKey)
		{
			return null;
		}

		// Token: 0x0600140E RID: 5134
		[Token(Token = "0x600140E")]
		public abstract ISigner CreateSigner(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter privateKey);

		// Token: 0x0600140F RID: 5135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x5240FE0", Offset = "0x523FBE0", VA = "0x185240FE0", Slot = "21")]
		public virtual ISigner CreateVerifyer(AsymmetricKeyParameter publicKey)
		{
			return null;
		}

		// Token: 0x06001410 RID: 5136
		[Token(Token = "0x6001410")]
		public abstract ISigner CreateVerifyer(SignatureAndHashAlgorithm algorithm, AsymmetricKeyParameter publicKey);

		// Token: 0x06001411 RID: 5137
		[Token(Token = "0x6001411")]
		public abstract bool IsValidPublicKey(AsymmetricKeyParameter publicKey);

		// Token: 0x06001412 RID: 5138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001412")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractTlsSigner()
		{
		}

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x10")]
		protected TlsContext mContext;
	}
}
