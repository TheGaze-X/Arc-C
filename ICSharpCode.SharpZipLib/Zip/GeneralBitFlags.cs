using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[Flags]
	public enum GeneralBitFlags
	{
		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		Encrypted = 1,
		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		Method = 6,
		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		Descriptor = 8,
		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		ReservedPKware4 = 16,
		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		Patched = 32,
		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		StrongEncryption = 64,
		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		Unused7 = 128,
		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		Unused8 = 256,
		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		Unused9 = 512,
		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		Unused10 = 1024,
		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		UnicodeText = 2048,
		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		EnhancedCompress = 4096,
		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		HeaderMasked = 8192,
		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		ReservedPkware14 = 16384,
		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		ReservedPkware15 = 32768
	}
}
