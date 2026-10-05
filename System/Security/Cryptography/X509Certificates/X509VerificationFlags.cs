using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	[Flags]
	public enum X509VerificationFlags
	{
		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		NoFlag = 0,
		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		IgnoreNotTimeValid = 1,
		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		IgnoreCtlNotTimeValid = 2,
		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		IgnoreNotTimeNested = 4,
		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		IgnoreInvalidBasicConstraints = 8,
		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		AllowUnknownCertificateAuthority = 16,
		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		IgnoreWrongUsage = 32,
		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		IgnoreInvalidName = 64,
		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		IgnoreInvalidPolicy = 128,
		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		IgnoreEndRevocationUnknown = 256,
		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		IgnoreCtlSignerRevocationUnknown = 512,
		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		IgnoreRootRevocationUnknown = 2048,
		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		AllFlags = 4095
	}
}
