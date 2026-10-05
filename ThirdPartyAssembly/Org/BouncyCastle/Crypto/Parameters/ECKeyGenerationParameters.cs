using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	public class ECKeyGenerationParameters : KeyGenerationParameters
	{
		// Token: 0x060018A6 RID: 6310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x52873D0", Offset = "0x5285FD0", VA = "0x1852873D0")]
		public ECKeyGenerationParameters(ECDomainParameters domainParameters, SecureRandom random)
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x5287440", Offset = "0x5286040", VA = "0x185287440")]
		public ECKeyGenerationParameters(DerObjectIdentifier publicKeyParamSet, SecureRandom random)
		{
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035E")]
		public ECDomainParameters DomainParameters
		{
			[Token(Token = "0x60018A8")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035F")]
		public DerObjectIdentifier PublicKeyParamSet
		{
			[Token(Token = "0x60018A9")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x20")]
		private readonly ECDomainParameters domainParams;

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x28")]
		private readonly DerObjectIdentifier publicKeyParamSet;
	}
}
