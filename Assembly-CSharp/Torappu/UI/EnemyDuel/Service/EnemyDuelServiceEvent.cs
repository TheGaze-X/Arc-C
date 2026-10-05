using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005081 RID: 20609
	[Token(Token = "0x2005081")]
	public enum EnemyDuelServiceEvent
	{
		// Token: 0x04028E43 RID: 167491
		[Token(Token = "0x4028E43")]
		TEAM_CHANGED,
		// Token: 0x04028E44 RID: 167492
		[Token(Token = "0x4028E44")]
		TEAM_GET_NAME_CARD,
		// Token: 0x04028E45 RID: 167493
		[Token(Token = "0x4028E45")]
		TEAM_DISCONNECT_EXCEPTION,
		// Token: 0x04028E46 RID: 167494
		[Token(Token = "0x4028E46")]
		TEAM_LEAVE,
		// Token: 0x04028E47 RID: 167495
		[Token(Token = "0x4028E47")]
		BATTLE_START,
		// Token: 0x04028E48 RID: 167496
		[Token(Token = "0x4028E48")]
		BATTLE_NET_CHANGED,
		// Token: 0x04028E49 RID: 167497
		[Token(Token = "0x4028E49")]
		BATTLE_CHANGED,
		// Token: 0x04028E4A RID: 167498
		[Token(Token = "0x4028E4A")]
		BATTLE_ROUND_CHANGED,
		// Token: 0x04028E4B RID: 167499
		[Token(Token = "0x4028E4B")]
		BATTLE_END,
		// Token: 0x04028E4C RID: 167500
		[Token(Token = "0x4028E4C")]
		BATTLE_EMOJI,
		// Token: 0x04028E4D RID: 167501
		[Token(Token = "0x4028E4D")]
		BATTLE_QUIT
	}
}
