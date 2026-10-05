using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063D0 RID: 25552
	[Token(Token = "0x20063D0")]
	public enum AutoChessServiceEvent
	{
		// Token: 0x0403382B RID: 210987
		[Token(Token = "0x403382B")]
		TEAM_CHANGED,
		// Token: 0x0403382C RID: 210988
		[Token(Token = "0x403382C")]
		TEAM_LEAVE,
		// Token: 0x0403382D RID: 210989
		[Token(Token = "0x403382D")]
		TEAM_LOST,
		// Token: 0x0403382E RID: 210990
		[Token(Token = "0x403382E")]
		TEAM_CHAT,
		// Token: 0x0403382F RID: 210991
		[Token(Token = "0x403382F")]
		TEAM_MATCH_RESULT,
		// Token: 0x04033830 RID: 210992
		[Token(Token = "0x4033830")]
		SCENE_START,
		// Token: 0x04033831 RID: 210993
		[Token(Token = "0x4033831")]
		SCENE_START_SUC,
		// Token: 0x04033832 RID: 210994
		[Token(Token = "0x4033832")]
		SCENE_CHANGED,
		// Token: 0x04033833 RID: 210995
		[Token(Token = "0x4033833")]
		SCENE_CHAT,
		// Token: 0x04033834 RID: 210996
		[Token(Token = "0x4033834")]
		SCENE_BROADCAST,
		// Token: 0x04033835 RID: 210997
		[Token(Token = "0x4033835")]
		SCENE_LOST,
		// Token: 0x04033836 RID: 210998
		[Token(Token = "0x4033836")]
		SCENE_SETTLE_LIKE
	}
}
