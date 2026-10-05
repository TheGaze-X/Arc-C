using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006460 RID: 25696
	[Token(Token = "0x2006460")]
	public enum AutoChessPlayerState
	{
		// Token: 0x04033B0D RID: 211725
		[Token(Token = "0x4033B0D")]
		TEAM_BUILDING_NOT_READY,
		// Token: 0x04033B0E RID: 211726
		[Token(Token = "0x4033B0E")]
		TEAM_BUILDING_READY,
		// Token: 0x04033B0F RID: 211727
		[Token(Token = "0x4033B0F")]
		MATCHING,
		// Token: 0x04033B10 RID: 211728
		[Token(Token = "0x4033B10")]
		MATCH_FAILED,
		// Token: 0x04033B11 RID: 211729
		[Token(Token = "0x4033B11")]
		ENTER,
		// Token: 0x04033B12 RID: 211730
		[Token(Token = "0x4033B12")]
		INFO_NOT_CONFIRM,
		// Token: 0x04033B13 RID: 211731
		[Token(Token = "0x4033B13")]
		INFO_CONFIRM,
		// Token: 0x04033B14 RID: 211732
		[Token(Token = "0x4033B14")]
		STRATEGY_NOT_CHOOSE,
		// Token: 0x04033B15 RID: 211733
		[Token(Token = "0x4033B15")]
		STRATEGY_CHOSEN,
		// Token: 0x04033B16 RID: 211734
		[Token(Token = "0x4033B16")]
		IN_BATTLE,
		// Token: 0x04033B17 RID: 211735
		[Token(Token = "0x4033B17")]
		IN_SETTLE_RESULT
	}
}
