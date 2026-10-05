using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	public enum X509FindType
	{
		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		FindByThumbprint,
		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		FindBySubjectName,
		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		FindBySubjectDistinguishedName,
		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		FindByIssuerName,
		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		FindByIssuerDistinguishedName,
		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		FindBySerialNumber,
		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		FindByTimeValid,
		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		FindByTimeNotYetValid,
		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		FindByTimeExpired,
		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		FindByTemplateName,
		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		FindByApplicationPolicy,
		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		FindByCertificatePolicy,
		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		FindByExtension,
		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		FindByKeyUsage,
		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		FindBySubjectKeyIdentifier
	}
}
