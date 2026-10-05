using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020C5 RID: 8389
	[Token(Token = "0x20020C5")]
	public enum DamageTypeMask
	{
		// Token: 0x0400DA78 RID: 55928
		[Token(Token = "0x400DA78")]
		NONE,
		// Token: 0x0400DA79 RID: 55929
		[Token(Token = "0x400DA79")]
		PHYSICAL = 2,
		// Token: 0x0400DA7A RID: 55930
		[Token(Token = "0x400DA7A")]
		MAGICAL = 4,
		// Token: 0x0400DA7B RID: 55931
		[Token(Token = "0x400DA7B")]
		PURE = 8,
		// Token: 0x0400DA7C RID: 55932
		[Token(Token = "0x400DA7C")]
		HEAL = 16,
		// Token: 0x0400DA7D RID: 55933
		[Token(Token = "0x400DA7D")]
		ELEMENT = 32,
		// Token: 0x0400DA7E RID: 55934
		[Token(Token = "0x400DA7E")]
		ANY_ATTACK = 46,
		// Token: 0x0400DA7F RID: 55935
		[Token(Token = "0x400DA7F")]
		ANY_HEAL = 16,
		// Token: 0x0400DA80 RID: 55936
		[Token(Token = "0x400DA80")]
		PHYSICAL_AND_MAGICAL = 6,
		// Token: 0x0400DA81 RID: 55937
		[Token(Token = "0x400DA81")]
		ANY_ATTACK_EXCEPT_ELEMENT = 14
	}
}
