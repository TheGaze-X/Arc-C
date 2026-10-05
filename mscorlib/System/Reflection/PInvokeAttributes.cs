using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000528 RID: 1320
	[Token(Token = "0x2000528")]
	[System.Flags]
	[System.Serializable]
	internal enum PInvokeAttributes
	{
		// Token: 0x040015C2 RID: 5570
		[Token(Token = "0x40015C2")]
		NoMangle = 1,
		// Token: 0x040015C3 RID: 5571
		[Token(Token = "0x40015C3")]
		CharSetMask = 6,
		// Token: 0x040015C4 RID: 5572
		[Token(Token = "0x40015C4")]
		CharSetNotSpec = 0,
		// Token: 0x040015C5 RID: 5573
		[Token(Token = "0x40015C5")]
		CharSetAnsi = 2,
		// Token: 0x040015C6 RID: 5574
		[Token(Token = "0x40015C6")]
		CharSetUnicode = 4,
		// Token: 0x040015C7 RID: 5575
		[Token(Token = "0x40015C7")]
		CharSetAuto = 6,
		// Token: 0x040015C8 RID: 5576
		[Token(Token = "0x40015C8")]
		BestFitUseAssem = 0,
		// Token: 0x040015C9 RID: 5577
		[Token(Token = "0x40015C9")]
		BestFitEnabled = 16,
		// Token: 0x040015CA RID: 5578
		[Token(Token = "0x40015CA")]
		BestFitDisabled = 32,
		// Token: 0x040015CB RID: 5579
		[Token(Token = "0x40015CB")]
		BestFitMask = 48,
		// Token: 0x040015CC RID: 5580
		[Token(Token = "0x40015CC")]
		ThrowOnUnmappableCharUseAssem = 0,
		// Token: 0x040015CD RID: 5581
		[Token(Token = "0x40015CD")]
		ThrowOnUnmappableCharEnabled = 4096,
		// Token: 0x040015CE RID: 5582
		[Token(Token = "0x40015CE")]
		ThrowOnUnmappableCharDisabled = 8192,
		// Token: 0x040015CF RID: 5583
		[Token(Token = "0x40015CF")]
		ThrowOnUnmappableCharMask = 12288,
		// Token: 0x040015D0 RID: 5584
		[Token(Token = "0x40015D0")]
		SupportsLastError = 64,
		// Token: 0x040015D1 RID: 5585
		[Token(Token = "0x40015D1")]
		CallConvMask = 1792,
		// Token: 0x040015D2 RID: 5586
		[Token(Token = "0x40015D2")]
		CallConvWinapi = 256,
		// Token: 0x040015D3 RID: 5587
		[Token(Token = "0x40015D3")]
		CallConvCdecl = 512,
		// Token: 0x040015D4 RID: 5588
		[Token(Token = "0x40015D4")]
		CallConvStdcall = 768,
		// Token: 0x040015D5 RID: 5589
		[Token(Token = "0x40015D5")]
		CallConvThiscall = 1024,
		// Token: 0x040015D6 RID: 5590
		[Token(Token = "0x40015D6")]
		CallConvFastcall = 1280,
		// Token: 0x040015D7 RID: 5591
		[Token(Token = "0x40015D7")]
		MaxValue = 65535
	}
}
