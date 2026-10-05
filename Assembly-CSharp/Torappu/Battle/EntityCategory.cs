using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020C3 RID: 8387
	[Token(Token = "0x20020C3")]
	[Flags]
	public enum EntityCategory
	{
		// Token: 0x0400DA6B RID: 55915
		[Token(Token = "0x400DA6B")]
		NONE = 0,
		// Token: 0x0400DA6C RID: 55916
		[Token(Token = "0x400DA6C")]
		DEFAULT = 1,
		// Token: 0x0400DA6D RID: 55917
		[Token(Token = "0x400DA6D")]
		TRAP_OR_ITEM = 2,
		// Token: 0x0400DA6E RID: 55918
		[Token(Token = "0x400DA6E")]
		OBSTACLE = 4
	}
}
