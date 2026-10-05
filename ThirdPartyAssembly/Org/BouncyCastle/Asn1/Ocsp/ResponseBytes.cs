using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x02000460 RID: 1120
	[Token(Token = "0x2000460")]
	public class ResponseBytes : Asn1Encodable
	{
		// Token: 0x060023DF RID: 9183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x5372DF0", Offset = "0x53719F0", VA = "0x185372DF0")]
		public static ResponseBytes GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x5372A50", Offset = "0x5371650", VA = "0x185372A50")]
		public static ResponseBytes GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x53730D0", Offset = "0x5371CD0", VA = "0x1853730D0")]
		public ResponseBytes(DerObjectIdentifier responseType, Asn1OctetString response)
		{
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x5372F40", Offset = "0x5371B40", VA = "0x185372F40")]
		private ResponseBytes(Asn1Sequence seq)
		{
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BA")]
		public DerObjectIdentifier ResponseType
		{
			[Token(Token = "0x60023E3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BB")]
		public Asn1OctetString Response
		{
			[Token(Token = "0x60023E4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x5372E10", Offset = "0x5371A10", VA = "0x185372E10", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040013FA RID: 5114
		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerObjectIdentifier responseType;

		// Token: 0x040013FB RID: 5115
		[Token(Token = "0x40013FB")]
		[FieldOffset(Offset = "0x18")]
		private readonly Asn1OctetString response;
	}
}
