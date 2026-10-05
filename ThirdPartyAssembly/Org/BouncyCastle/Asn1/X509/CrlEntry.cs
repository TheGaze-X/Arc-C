using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000414 RID: 1044
	[Token(Token = "0x2000414")]
	public class CrlEntry : Asn1Encodable
	{
		// Token: 0x06002271 RID: 8817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002271")]
		[Address(RVA = "0x532F170", Offset = "0x532DD70", VA = "0x18532F170")]
		public CrlEntry(Asn1Sequence seq)
		{
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000486")]
		public DerInteger UserCertificate
		{
			[Token(Token = "0x6002272")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000487")]
		public Time RevocationDate
		{
			[Token(Token = "0x6002273")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000488")]
		public X509Extensions Extensions
		{
			[Token(Token = "0x6002274")]
			[Address(RVA = "0x532F330", Offset = "0x532DF30", VA = "0x18532F330")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002275")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001223 RID: 4643
		[Token(Token = "0x4001223")]
		[FieldOffset(Offset = "0x10")]
		internal Asn1Sequence seq;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[FieldOffset(Offset = "0x18")]
		internal DerInteger userCertificate;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0x20")]
		internal Time revocationDate;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x28")]
		internal X509Extensions crlEntryExtensions;
	}
}
