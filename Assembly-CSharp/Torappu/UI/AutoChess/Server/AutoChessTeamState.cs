using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200645E RID: 25694
	[Token(Token = "0x200645E")]
	public enum AutoChessTeamState
	{
		// Token: 0x04033AFF RID: 211711
		[Token(Token = "0x4033AFF")]
		NONE,
		// Token: 0x04033B00 RID: 211712
		[Token(Token = "0x4033B00")]
		TEAM_BUILDING,
		// Token: 0x04033B01 RID: 211713
		[Token(Token = "0x4033B01")]
		TEAM_MATCHING,
		// Token: 0x04033B02 RID: 211714
		[Token(Token = "0x4033B02")]
		TEAM_MATCH_SUC,
		// Token: 0x04033B03 RID: 211715
		[Token(Token = "0x4033B03")]
		ENTER,
		// Token: 0x04033B04 RID: 211716
		[Token(Token = "0x4033B04")]
		INFO_SHOW,
		// Token: 0x04033B05 RID: 211717
		[Token(Token = "0x4033B05")]
		STRATEGY_CHOOSE,
		// Token: 0x04033B06 RID: 211718
		[Token(Token = "0x4033B06")]
		ENTER_BATTLE_COUNT_DOWN,
		// Token: 0x04033B07 RID: 211719
		[Token(Token = "0x4033B07")]
		IN_BATTLE,
		// Token: 0x04033B08 RID: 211720
		[Token(Token = "0x4033B08")]
		END
	}
}
