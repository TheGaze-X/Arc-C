using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public enum EncryptionAlgorithm
	{
		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		None,
		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		PkzipClassic,
		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		Des = 26113,
		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		RC2,
		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		TripleDes168,
		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		TripleDes112 = 26121,
		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		Aes128 = 26126,
		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		Aes192,
		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		Aes256,
		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		RC2Corrected = 26370,
		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		Blowfish = 26400,
		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		Twofish,
		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		RC4 = 26625,
		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		Unknown = 65535
	}
}
