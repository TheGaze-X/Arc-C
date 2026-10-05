using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200051F RID: 1311
	[Token(Token = "0x200051F")]
	[System.Flags]
	public enum TypeAttributes
	{
		// Token: 0x0400154F RID: 5455
		[Token(Token = "0x400154F")]
		VisibilityMask = 7,
		// Token: 0x04001550 RID: 5456
		[Token(Token = "0x4001550")]
		NotPublic = 0,
		// Token: 0x04001551 RID: 5457
		[Token(Token = "0x4001551")]
		Public = 1,
		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		NestedPublic = 2,
		// Token: 0x04001553 RID: 5459
		[Token(Token = "0x4001553")]
		NestedPrivate = 3,
		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		NestedFamily = 4,
		// Token: 0x04001555 RID: 5461
		[Token(Token = "0x4001555")]
		NestedAssembly = 5,
		// Token: 0x04001556 RID: 5462
		[Token(Token = "0x4001556")]
		NestedFamANDAssem = 6,
		// Token: 0x04001557 RID: 5463
		[Token(Token = "0x4001557")]
		NestedFamORAssem = 7,
		// Token: 0x04001558 RID: 5464
		[Token(Token = "0x4001558")]
		LayoutMask = 24,
		// Token: 0x04001559 RID: 5465
		[Token(Token = "0x4001559")]
		AutoLayout = 0,
		// Token: 0x0400155A RID: 5466
		[Token(Token = "0x400155A")]
		SequentialLayout = 8,
		// Token: 0x0400155B RID: 5467
		[Token(Token = "0x400155B")]
		ExplicitLayout = 16,
		// Token: 0x0400155C RID: 5468
		[Token(Token = "0x400155C")]
		ClassSemanticsMask = 32,
		// Token: 0x0400155D RID: 5469
		[Token(Token = "0x400155D")]
		Class = 0,
		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		Interface = 32,
		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		Abstract = 128,
		// Token: 0x04001560 RID: 5472
		[Token(Token = "0x4001560")]
		Sealed = 256,
		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		SpecialName = 1024,
		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		Import = 4096,
		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		Serializable = 8192,
		// Token: 0x04001564 RID: 5476
		[Token(Token = "0x4001564")]
		WindowsRuntime = 16384,
		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		StringFormatMask = 196608,
		// Token: 0x04001566 RID: 5478
		[Token(Token = "0x4001566")]
		AnsiClass = 0,
		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		UnicodeClass = 65536,
		// Token: 0x04001568 RID: 5480
		[Token(Token = "0x4001568")]
		AutoClass = 131072,
		// Token: 0x04001569 RID: 5481
		[Token(Token = "0x4001569")]
		CustomFormatClass = 196608,
		// Token: 0x0400156A RID: 5482
		[Token(Token = "0x400156A")]
		CustomFormatMask = 12582912,
		// Token: 0x0400156B RID: 5483
		[Token(Token = "0x400156B")]
		BeforeFieldInit = 1048576,
		// Token: 0x0400156C RID: 5484
		[Token(Token = "0x400156C")]
		RTSpecialName = 2048,
		// Token: 0x0400156D RID: 5485
		[Token(Token = "0x400156D")]
		HasSecurity = 262144,
		// Token: 0x0400156E RID: 5486
		[Token(Token = "0x400156E")]
		ReservedMask = 264192
	}
}
