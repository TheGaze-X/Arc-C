using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020CF RID: 8399
	[Token(Token = "0x20020CF")]
	[Flags]
	public enum AdvancedBuildableMask
	{
		// Token: 0x0400DAF0 RID: 56048
		[Token(Token = "0x400DAF0")]
		NONE = 0,
		// Token: 0x0400DAF1 RID: 56049
		[Token(Token = "0x400DAF1")]
		DEFAULT = 1,
		// Token: 0x0400DAF2 RID: 56050
		[Token(Token = "0x400DAF2")]
		DEEP_SEA = 2,
		// Token: 0x0400DAF3 RID: 56051
		[Token(Token = "0x400DAF3")]
		TIDE_SEA = 4,
		// Token: 0x0400DAF4 RID: 56052
		[Token(Token = "0x400DAF4")]
		NIGHT = 8,
		// Token: 0x0400DAF5 RID: 56053
		[Token(Token = "0x400DAF5")]
		HIDE = 16,
		// Token: 0x0400DAF6 RID: 56054
		[Token(Token = "0x400DAF6")]
		WOODRD_HOLE = 32,
		// Token: 0x0400DAF7 RID: 56055
		[Token(Token = "0x400DAF7")]
		RIDGE_FIELD = 64,
		// Token: 0x0400DAF8 RID: 56056
		[Token(Token = "0x400DAF8")]
		ENEMY_FTPRG = 128,
		// Token: 0x0400DAF9 RID: 56057
		[Token(Token = "0x400DAF9")]
		RED_FOG = 256,
		// Token: 0x0400DAFA RID: 56058
		[Token(Token = "0x400DAFA")]
		ACT47SIDE_DURING_BALLOON_FLOAT = 512,
		// Token: 0x0400DAFB RID: 56059
		[Token(Token = "0x400DAFB")]
		ACT47SIDE_BANNED = 1024
	}
}
