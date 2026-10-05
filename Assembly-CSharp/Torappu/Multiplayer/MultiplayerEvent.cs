using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x0200153C RID: 5436
	[Token(Token = "0x200153C")]
	public enum MultiplayerEvent
	{
		// Token: 0x04007CCD RID: 31949
		[Token(Token = "0x4007CCD")]
		TeamChanged,
		// Token: 0x04007CCE RID: 31950
		[Token(Token = "0x4007CCE")]
		RevTeamChat,
		// Token: 0x04007CCF RID: 31951
		[Token(Token = "0x4007CCF")]
		PickCharSuc,
		// Token: 0x04007CD0 RID: 31952
		[Token(Token = "0x4007CD0")]
		SetCharSlotSuc,
		// Token: 0x04007CD1 RID: 31953
		[Token(Token = "0x4007CD1")]
		SaveSquadSuc,
		// Token: 0x04007CD2 RID: 31954
		[Token(Token = "0x4007CD2")]
		BattleStart,
		// Token: 0x04007CD3 RID: 31955
		[Token(Token = "0x4007CD3")]
		BattleStatusChanged,
		// Token: 0x04007CD4 RID: 31956
		[Token(Token = "0x4007CD4")]
		RevPause,
		// Token: 0x04007CD5 RID: 31957
		[Token(Token = "0x4007CD5")]
		RevFastMode,
		// Token: 0x04007CD6 RID: 31958
		[Token(Token = "0x4007CD6")]
		RevCostInteract,
		// Token: 0x04007CD7 RID: 31959
		[Token(Token = "0x4007CD7")]
		RevMark,
		// Token: 0x04007CD8 RID: 31960
		[Token(Token = "0x4007CD8")]
		BattlePlayerStatusChanged,
		// Token: 0x04007CD9 RID: 31961
		[Token(Token = "0x4007CD9")]
		BattleEnd,
		// Token: 0x04007CDA RID: 31962
		[Token(Token = "0x4007CDA")]
		GetNameCardRet
	}
}
