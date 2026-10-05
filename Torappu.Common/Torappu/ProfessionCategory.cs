using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[Flags]
	public enum ProfessionCategory
	{
		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		NONE = 0,
		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		WARRIOR = 1,
		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		SNIPER = 2,
		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		TANK = 4,
		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		MEDIC = 8,
		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		SUPPORT = 16,
		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		CASTER = 32,
		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		SPECIAL = 64,
		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		TOKEN = 128,
		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		TRAP = 256,
		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		PIONEER = 512
	}
}
