using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020AA RID: 8362
	[Token(Token = "0x20020AA")]
	public struct FastBattleInfo
	{
		// Token: 0x0600CD9C RID: 52636 RVA: 0x0004A280 File Offset: 0x00048480
		[Token(Token = "0x600CD9C")]
		[Address(RVA = "0x34FEA80", Offset = "0x34FD680", VA = "0x1834FEA80")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0400D926 RID: 55590
		[Token(Token = "0x400D926")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FastBattleInfo EMPTY;

		// Token: 0x0400D927 RID: 55591
		[Token(Token = "0x400D927")]
		[FieldOffset(Offset = "0x0")]
		public CommonFinishBattleResponse response;

		// Token: 0x0400D928 RID: 55592
		[Token(Token = "0x400D928")]
		[FieldOffset(Offset = "0x8")]
		public bool isFastBattle;

		// Token: 0x0400D929 RID: 55593
		[Token(Token = "0x400D929")]
		[FieldOffset(Offset = "0x10")]
		public string battleFinishBkgPath;

		// Token: 0x0400D92A RID: 55594
		[Token(Token = "0x400D92A")]
		[FieldOffset(Offset = "0x18")]
		public PlayerStatus statusBeforeStartBattle;
	}
}
