using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000410 RID: 1040
	[Token(Token = "0x2000410")]
	public class ReasonFlags : DerBitString
	{
		// Token: 0x0600224F RID: 8783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600224F")]
		[Address(RVA = "0x53423F0", Offset = "0x5340FF0", VA = "0x1853423F0")]
		public ReasonFlags(int reasons)
		{
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002250")]
		[Address(RVA = "0x5342320", Offset = "0x5340F20", VA = "0x185342320")]
		public ReasonFlags(DerBitString reasons)
		{
		}

		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		public const int Unused = 128;

		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		public const int KeyCompromise = 64;

		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400120C")]
		public const int CACompromise = 32;

		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400120D")]
		public const int AffiliationChanged = 16;

		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400120E")]
		public const int Superseded = 8;

		// Token: 0x0400120F RID: 4623
		[Token(Token = "0x400120F")]
		public const int CessationOfOperation = 4;

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		public const int CertificateHold = 2;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		public const int PrivilegeWithdrawn = 1;

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		public const int AACompromise = 32768;
	}
}
