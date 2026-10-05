using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork.SvrCom;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200646E RID: 25710
	[Token(Token = "0x200646E")]
	public interface IAutoChessServerClient
	{
		// Token: 0x17005726 RID: 22310
		// (get) Token: 0x06024F4F RID: 151375
		[Token(Token = "0x17005726")]
		AutoChessProtocolSuit protocolSuite { [Token(Token = "0x6024F4F")] get; }

		// Token: 0x06024F50 RID: 151376
		[Token(Token = "0x6024F50")]
		void StartBattle(CommonJoinEntry entry);

		// Token: 0x06024F51 RID: 151377
		[Token(Token = "0x6024F51")]
		void TriggerEvent(AutoChessServiceEvent evt, [Optional] object arg);

		// Token: 0x06024F52 RID: 151378
		[Token(Token = "0x6024F52")]
		void OnTeamStatusChanged();

		// Token: 0x06024F53 RID: 151379
		[Token(Token = "0x6024F53")]
		void OnTeamMatchResult(AutoChessServiceMatchResult result);

		// Token: 0x06024F54 RID: 151380
		[Token(Token = "0x6024F54")]
		void OnTeamLost(AutoChessTeamServer team, AutoChessTeamLostReason reason);

		// Token: 0x06024F55 RID: 151381
		[Token(Token = "0x6024F55")]
		AutoChessServiceTeamInfo GetTeamStatus();

		// Token: 0x17005727 RID: 22311
		// (get) Token: 0x06024F56 RID: 151382
		[Token(Token = "0x17005727")]
		IAutoChessServiceStepReceiver stepReceiver { [Token(Token = "0x6024F56")] get; }

		// Token: 0x06024F57 RID: 151383
		[Token(Token = "0x6024F57")]
		void OnBattleStatusChanged();
	}
}
