using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	public class TlsDssSigner : TlsDsaSigner
	{
		// Token: 0x060015EA RID: 5610 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x525A2E0", Offset = "0x5258EE0", VA = "0x18525A2E0", Slot = "23")]
		public override bool IsValidPublicKey(AsymmetricKeyParameter publicKey)
		{
			return default(bool);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x525A220", Offset = "0x5258E20", VA = "0x18525A220", Slot = "27")]
		protected override IDsa CreateDsaImpl(byte hashAlgorithm)
		{
			return null;
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x1700031B")]
		protected override byte SignatureAlgorithm
		{
			[Token(Token = "0x60015EC")]
			[Address(RVA = "0x525A370", Offset = "0x5258F70", VA = "0x18525A370", Slot = "26")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TlsDssSigner()
		{
		}
	}
}
