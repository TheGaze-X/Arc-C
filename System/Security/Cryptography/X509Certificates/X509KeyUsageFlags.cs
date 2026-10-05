using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	[Flags]
	public enum X509KeyUsageFlags
	{
		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		None = 0,
		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		EncipherOnly = 1,
		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		CrlSign = 2,
		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		KeyCertSign = 4,
		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		KeyAgreement = 8,
		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		DataEncipherment = 16,
		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		KeyEncipherment = 32,
		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		NonRepudiation = 64,
		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		DigitalSignature = 128,
		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		DecipherOnly = 32768
	}
}
