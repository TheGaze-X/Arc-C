using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003DD RID: 989
	[Token(Token = "0x20003DD")]
	public class DHDomainParameters : Asn1Encodable
	{
		// Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x532FE80", Offset = "0x532EA80", VA = "0x18532FE80")]
		public static DHDomainParameters GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212F")]
		[Address(RVA = "0x532FC40", Offset = "0x532E840", VA = "0x18532FC40")]
		public static DHDomainParameters GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x53304B0", Offset = "0x532F0B0", VA = "0x1853304B0")]
		public DHDomainParameters(DerInteger p, DerInteger g, DerInteger q, DerInteger j, DHValidationParms validationParms)
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x5330250", Offset = "0x532EE50", VA = "0x185330250")]
		private DHDomainParameters(Asn1Sequence seq)
		{
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x532FEA0", Offset = "0x532EAA0", VA = "0x18532FEA0")]
		private static Asn1Encodable GetNext(IEnumerator e)
		{
			return null;
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700043E")]
		public DerInteger P
		{
			[Token(Token = "0x6002133")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700043F")]
		public DerInteger G
		{
			[Token(Token = "0x6002134")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000440")]
		public DerInteger Q
		{
			[Token(Token = "0x6002135")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000441")]
		public DerInteger J
		{
			[Token(Token = "0x6002136")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000442")]
		public DHValidationParms ValidationParms
		{
			[Token(Token = "0x6002137")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002138")]
		[Address(RVA = "0x532FFA0", Offset = "0x532EBA0", VA = "0x18532FFA0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerInteger p;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x18")]
		private readonly DerInteger g;

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x20")]
		private readonly DerInteger q;

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x28")]
		private readonly DerInteger j;

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x30")]
		private readonly DHValidationParms validationParms;
	}
}
