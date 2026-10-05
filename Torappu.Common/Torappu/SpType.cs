using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	public enum SpType
	{
		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		NONE,
		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		INCREASE_WITH_TIME,
		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		INCREASE_WHEN_ATTACK,
		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		INCREASE_WHEN_TAKEN_DAMAGE = 4,
		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		ATTACK_OR_DAMAGE = 6,
		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		ALL
	}
}
