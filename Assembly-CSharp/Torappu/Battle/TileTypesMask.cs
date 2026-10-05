using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020D0 RID: 8400
	[Token(Token = "0x20020D0")]
	[Flags]
	public enum TileTypesMask
	{
		// Token: 0x0400DAFD RID: 56061
		[Token(Token = "0x400DAFD")]
		NONE = 0,
		// Token: 0x0400DAFE RID: 56062
		[Token(Token = "0x400DAFE")]
		DEFAULT = 1,
		// Token: 0x0400DAFF RID: 56063
		[Token(Token = "0x400DAFF")]
		HOLE = 2,
		// Token: 0x0400DB00 RID: 56064
		[Token(Token = "0x400DB00")]
		END = 4,
		// Token: 0x0400DB01 RID: 56065
		[Token(Token = "0x400DB01")]
		START = 8,
		// Token: 0x0400DB02 RID: 56066
		[Token(Token = "0x400DB02")]
		FAKE_HIGHLAND = 16
	}
}
