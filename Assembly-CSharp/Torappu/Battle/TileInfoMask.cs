using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020D1 RID: 8401
	[Token(Token = "0x20020D1")]
	[Flags]
	public enum TileInfoMask
	{
		// Token: 0x0400DB04 RID: 56068
		[Token(Token = "0x400DB04")]
		DEFAULT = 1,
		// Token: 0x0400DB05 RID: 56069
		[Token(Token = "0x400DB05")]
		PROJECTILE_TRAP_VALID = 2,
		// Token: 0x0400DB06 RID: 56070
		[Token(Token = "0x400DB06")]
		FIRST_REVEALED = 4,
		// Token: 0x0400DB07 RID: 56071
		[Token(Token = "0x400DB07")]
		KEEP_REVEALED = 8
	}
}
