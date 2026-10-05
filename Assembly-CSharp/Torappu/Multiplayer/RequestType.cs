using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x02001540 RID: 5440
	[Token(Token = "0x2001540")]
	public enum RequestType
	{
		// Token: 0x04007CE6 RID: 31974
		[Token(Token = "0x4007CE6")]
		None,
		// Token: 0x04007CE7 RID: 31975
		[Token(Token = "0x4007CE7")]
		ChooseStage,
		// Token: 0x04007CE8 RID: 31976
		[Token(Token = "0x4007CE8")]
		ChoosePos,
		// Token: 0x04007CE9 RID: 31977
		[Token(Token = "0x4007CE9")]
		ReadyInRoom,
		// Token: 0x04007CEA RID: 31978
		[Token(Token = "0x4007CEA")]
		TeamEntranceReady,
		// Token: 0x04007CEB RID: 31979
		[Token(Token = "0x4007CEB")]
		TeamTurnPick,
		// Token: 0x04007CEC RID: 31980
		[Token(Token = "0x4007CEC")]
		TeamTurnSkip,
		// Token: 0x04007CED RID: 31981
		[Token(Token = "0x4007CED")]
		TeamSaveSquad,
		// Token: 0x04007CEE RID: 31982
		[Token(Token = "0x4007CEE")]
		TeamSetSquadReady,
		// Token: 0x04007CEF RID: 31983
		[Token(Token = "0x4007CEF")]
		TeamSetCharSlot,
		// Token: 0x04007CF0 RID: 31984
		[Token(Token = "0x4007CF0")]
		TeamReady,
		// Token: 0x04007CF1 RID: 31985
		[Token(Token = "0x4007CF1")]
		TeamTask,
		// Token: 0x04007CF2 RID: 31986
		[Token(Token = "0x4007CF2")]
		GameStart,
		// Token: 0x04007CF3 RID: 31987
		[Token(Token = "0x4007CF3")]
		TeamSquad,
		// Token: 0x04007CF4 RID: 31988
		[Token(Token = "0x4007CF4")]
		TeamPick,
		// Token: 0x04007CF5 RID: 31989
		[Token(Token = "0x4007CF5")]
		TeamKick,
		// Token: 0x04007CF6 RID: 31990
		[Token(Token = "0x4007CF6")]
		TeamChat,
		// Token: 0x04007CF7 RID: 31991
		[Token(Token = "0x4007CF7")]
		LeaveTeam,
		// Token: 0x04007CF8 RID: 31992
		[Token(Token = "0x4007CF8")]
		TeamSetFlipMode,
		// Token: 0x04007CF9 RID: 31993
		[Token(Token = "0x4007CF9")]
		SettleLike,
		// Token: 0x04007CFA RID: 31994
		[Token(Token = "0x4007CFA")]
		BattleContinue,
		// Token: 0x04007CFB RID: 31995
		[Token(Token = "0x4007CFB")]
		GameReady,
		// Token: 0x04007CFC RID: 31996
		[Token(Token = "0x4007CFC")]
		GameAction,
		// Token: 0x04007CFD RID: 31997
		[Token(Token = "0x4007CFD")]
		GameCheck,
		// Token: 0x04007CFE RID: 31998
		[Token(Token = "0x4007CFE")]
		GamePause,
		// Token: 0x04007CFF RID: 31999
		[Token(Token = "0x4007CFF")]
		GameMark,
		// Token: 0x04007D00 RID: 32000
		[Token(Token = "0x4007D00")]
		GameSettle,
		// Token: 0x04007D01 RID: 32001
		[Token(Token = "0x4007D01")]
		GameGiveUp,
		// Token: 0x04007D02 RID: 32002
		[Token(Token = "0x4007D02")]
		Chat,
		// Token: 0x04007D03 RID: 32003
		[Token(Token = "0x4007D03")]
		GameFastMode,
		// Token: 0x04007D04 RID: 32004
		[Token(Token = "0x4007D04")]
		Cost,
		// Token: 0x04007D05 RID: 32005
		[Token(Token = "0x4007D05")]
		GetNameCard,
		// Token: 0x04007D06 RID: 32006
		[Token(Token = "0x4007D06")]
		MAX_COUNT
	}
}
