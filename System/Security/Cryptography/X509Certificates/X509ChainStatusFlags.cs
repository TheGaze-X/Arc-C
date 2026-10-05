using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	[Flags]
	public enum X509ChainStatusFlags
	{
		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		NoError = 0,
		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		NotTimeValid = 1,
		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		NotTimeNested = 2,
		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		Revoked = 4,
		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		NotSignatureValid = 8,
		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		NotValidForUsage = 16,
		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		UntrustedRoot = 32,
		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		RevocationStatusUnknown = 64,
		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		Cyclic = 128,
		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		InvalidExtension = 256,
		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		InvalidPolicyConstraints = 512,
		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		InvalidBasicConstraints = 1024,
		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		InvalidNameConstraints = 2048,
		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		HasNotSupportedNameConstraint = 4096,
		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		HasNotDefinedNameConstraint = 8192,
		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		HasNotPermittedNameConstraint = 16384,
		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		HasExcludedNameConstraint = 32768,
		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		PartialChain = 65536,
		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		CtlNotTimeValid = 131072,
		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		CtlNotSignatureValid = 262144,
		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		CtlNotValidForUsage = 524288,
		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		OfflineRevocation = 16777216,
		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		NoIssuanceChainPolicy = 33554432,
		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		ExplicitDistrust = 67108864,
		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		HasNotSupportedCriticalExtension = 134217728,
		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		HasWeakSignature = 1048576
	}
}
