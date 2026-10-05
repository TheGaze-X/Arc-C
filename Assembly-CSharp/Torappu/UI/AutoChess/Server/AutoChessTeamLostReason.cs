using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006462 RID: 25698
	[Token(Token = "0x2006462")]
	public enum AutoChessTeamLostReason
	{
		// Token: 0x04033B1D RID: 211741
		[Token(Token = "0x4033B1D")]
		NONE = -1,
		// Token: 0x04033B1E RID: 211742
		[Token(Token = "0x4033B1E")]
		NET_EXCEPTION,
		// Token: 0x04033B1F RID: 211743
		[Token(Token = "0x4033B1F")]
		KICK_DISBAND,
		// Token: 0x04033B20 RID: 211744
		[Token(Token = "0x4033B20")]
		KICK_DISLIKE,
		// Token: 0x04033B21 RID: 211745
		[Token(Token = "0x4033B21")]
		KICK_TIMEOUT,
		// Token: 0x04033B22 RID: 211746
		[Token(Token = "0x4033B22")]
		KICK_MATE_FAIL,
		// Token: 0x04033B23 RID: 211747
		[Token(Token = "0x4033B23")]
		KICK_SCENE_START_FAIL,
		// Token: 0x04033B24 RID: 211748
		[Token(Token = "0x4033B24")]
		KICK_UNKNOWN,
		// Token: 0x04033B25 RID: 211749
		[Token(Token = "0x4033B25")]
		PLAYER_LEAVE = 101
	}
}
