using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002DA RID: 730
	[Token(Token = "0x20002DA")]
	public abstract class Gost3410KeyParameters : AsymmetricKeyParameter
	{
		// Token: 0x060018E0 RID: 6368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x52859E0", Offset = "0x52845E0", VA = "0x1852859E0")]
		protected Gost3410KeyParameters(bool isPrivate, Gost3410Parameters parameters)
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x528DFF0", Offset = "0x528CBF0", VA = "0x18528DFF0")]
		protected Gost3410KeyParameters(bool isPrivate, DerObjectIdentifier publicKeyParamSet)
		{
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036C")]
		public Gost3410Parameters Parameters
		{
			[Token(Token = "0x60018E2")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036D")]
		public DerObjectIdentifier PublicKeyParamSet
		{
			[Token(Token = "0x60018E3")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x528DD10", Offset = "0x528C910", VA = "0x18528DD10")]
		private static Gost3410Parameters LookupParameters(DerObjectIdentifier publicKeyParamSet)
		{
			return null;
		}

		// Token: 0x04000D23 RID: 3363
		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0x18")]
		private readonly Gost3410Parameters parameters;

		// Token: 0x04000D24 RID: 3364
		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0x20")]
		private readonly DerObjectIdentifier publicKeyParamSet;
	}
}
