using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public enum BattleRenderInvisibleMask
	{
		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		NONE,
		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		SPINE,
		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		NORMAL_HIT_EFFECT,
		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		PROJECTILE_HIT_EFFECT = 4,
		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		SPECIFY_EFFECT = 8,
		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		SHADOW_CONTROLLER = 16,
		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		UNIT_HUD = 32,
		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		ALL = 63
	}
}
