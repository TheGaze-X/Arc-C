using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000511 RID: 1297
	[Token(Token = "0x2000511")]
	[System.Flags]
	public enum PropertyAttributes
	{
		// Token: 0x0400153B RID: 5435
		[Token(Token = "0x400153B")]
		None = 0,
		// Token: 0x0400153C RID: 5436
		[Token(Token = "0x400153C")]
		SpecialName = 512,
		// Token: 0x0400153D RID: 5437
		[Token(Token = "0x400153D")]
		RTSpecialName = 1024,
		// Token: 0x0400153E RID: 5438
		[Token(Token = "0x400153E")]
		HasDefault = 4096,
		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		Reserved2 = 8192,
		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		Reserved3 = 16384,
		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		Reserved4 = 32768,
		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		ReservedMask = 62464
	}
}
