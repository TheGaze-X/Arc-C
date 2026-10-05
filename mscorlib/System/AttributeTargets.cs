using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	[System.Flags]
	public enum AttributeTargets
	{
		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		Assembly = 1,
		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		Module = 2,
		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		Class = 4,
		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		Struct = 8,
		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		Enum = 16,
		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		Constructor = 32,
		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		Method = 64,
		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		Property = 128,
		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		Field = 256,
		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		Event = 512,
		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		Interface = 1024,
		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		Parameter = 2048,
		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		Delegate = 4096,
		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		ReturnValue = 8192,
		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		GenericParameter = 16384,
		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		All = 32767
	}
}
