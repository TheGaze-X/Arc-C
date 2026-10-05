using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	public class TlsECDsaSigner : TlsDsaSigner
	{
		// Token: 0x0600162B RID: 5675 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x526A6C0", Offset = "0x52692C0", VA = "0x18526A6C0", Slot = "23")]
		public override bool IsValidPublicKey(AsymmetricKeyParameter publicKey)
		{
			return default(bool);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x526A4F0", Offset = "0x52690F0", VA = "0x18526A4F0", Slot = "27")]
		protected override IDsa CreateDsaImpl(byte hashAlgorithm)
		{
			return null;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x1700031D")]
		protected override byte SignatureAlgorithm
		{
			[Token(Token = "0x600162D")]
			[Address(RVA = "0x4DFE7B0", Offset = "0x4DFD3B0", VA = "0x184DFE7B0", Slot = "26")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public TlsECDsaSigner()
		{
		}
	}
}
