using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005516 RID: 21782
	[Token(Token = "0x2005516")]
	public interface IRoguelikeGameShopVisibility
	{
		// Token: 0x060200A7 RID: 131239
		[Token(Token = "0x60200A7")]
		float SetShow(bool isShow, bool fastMode, RoguelikeGameShopStatusEnum current);

		// Token: 0x060200A8 RID: 131240
		[Token(Token = "0x60200A8")]
		RoguelikeGameShopStatusEnum GetShopStatus();

		// Token: 0x060200A9 RID: 131241
		[Token(Token = "0x60200A9")]
		RoguelikeGameShopStatusEnum GetRivalStatus();
	}
}
