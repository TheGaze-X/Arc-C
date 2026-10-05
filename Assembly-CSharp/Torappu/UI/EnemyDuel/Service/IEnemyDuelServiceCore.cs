using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005065 RID: 20581
	[Token(Token = "0x2005065")]
	public interface IEnemyDuelServiceCore
	{
		// Token: 0x0601E838 RID: 124984
		[Token(Token = "0x601E838")]
		void TriggerEvent(EnemyDuelServiceEvent evt, [Optional] object arg);

		// Token: 0x0601E839 RID: 124985
		[Token(Token = "0x601E839")]
		void RefreshStatus();

		// Token: 0x0601E83A RID: 124986
		[Token(Token = "0x601E83A")]
		void RevStep(EnemyDuelServiceStepData step);
	}
}
