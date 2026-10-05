using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service.Mode.Multi
{
	// Token: 0x020050A3 RID: 20643
	[Token(Token = "0x20050A3")]
	public interface IEnemyDuelServerClient
	{
		// Token: 0x17004767 RID: 18279
		// (get) Token: 0x0601E91E RID: 125214
		[Token(Token = "0x17004767")]
		EnemyDuelProtocolSuit protocolSuite { [Token(Token = "0x601E91E")] get; }

		// Token: 0x0601E91F RID: 125215
		[Token(Token = "0x601E91F")]
		void RefreshServiceStatus();

		// Token: 0x0601E920 RID: 125216
		[Token(Token = "0x601E920")]
		void StartBattle(BattleJoinEntry entry);

		// Token: 0x0601E921 RID: 125217
		[Token(Token = "0x601E921")]
		void RevStep(EnemyDuelServiceStepData step);

		// Token: 0x0601E922 RID: 125218
		[Token(Token = "0x601E922")]
		void TriggerEvent(EnemyDuelServiceEvent evt, [Optional] object arg);
	}
}
