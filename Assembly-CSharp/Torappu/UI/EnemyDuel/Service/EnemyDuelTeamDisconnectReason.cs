using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005083 RID: 20611
	[Token(Token = "0x2005083")]
	public enum EnemyDuelTeamDisconnectReason
	{
		// Token: 0x04028E55 RID: 167509
		[Token(Token = "0x4028E55")]
		NET_EXCEPTION,
		// Token: 0x04028E56 RID: 167510
		[Token(Token = "0x4028E56")]
		KICK_DISBAND,
		// Token: 0x04028E57 RID: 167511
		[Token(Token = "0x4028E57")]
		KICK_DISLIKE,
		// Token: 0x04028E58 RID: 167512
		[Token(Token = "0x4028E58")]
		KICK_TIMEOUT,
		// Token: 0x04028E59 RID: 167513
		[Token(Token = "0x4028E59")]
		KICK_BATTLE_FINISH_TIMEOUT
	}
}
