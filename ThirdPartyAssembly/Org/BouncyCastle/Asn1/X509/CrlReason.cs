using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000407 RID: 1031
	[Token(Token = "0x2000407")]
	public class CrlReason : DerEnumerated
	{
		// Token: 0x060021FF RID: 8703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021FF")]
		[Address(RVA = "0x532FB60", Offset = "0x532E760", VA = "0x18532FB60")]
		public CrlReason(int reason)
		{
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002200")]
		[Address(RVA = "0x532FBC0", Offset = "0x532E7C0", VA = "0x18532FBC0")]
		public CrlReason(DerEnumerated reason)
		{
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002201")]
		[Address(RVA = "0x532F5F0", Offset = "0x532E1F0", VA = "0x18532F5F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		public const int Unspecified = 0;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		public const int KeyCompromise = 1;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		public const int CACompromise = 2;

		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x40011DA")]
		public const int AffiliationChanged = 3;

		// Token: 0x040011DB RID: 4571
		[Token(Token = "0x40011DB")]
		public const int Superseded = 4;

		// Token: 0x040011DC RID: 4572
		[Token(Token = "0x40011DC")]
		public const int CessationOfOperation = 5;

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		public const int CertificateHold = 6;

		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x40011DE")]
		public const int RemoveFromCrl = 8;

		// Token: 0x040011DF RID: 4575
		[Token(Token = "0x40011DF")]
		public const int PrivilegeWithdrawn = 9;

		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x40011E0")]
		public const int AACompromise = 10;

		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x40011E1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] ReasonString;
	}
}
