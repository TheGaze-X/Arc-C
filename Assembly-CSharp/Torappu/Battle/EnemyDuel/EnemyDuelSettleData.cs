using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026BE RID: 9918
	[Token(Token = "0x20026BE")]
	public class EnemyDuelSettleData : EnemyDuelStateDataBasic
	{
		// Token: 0x060102C6 RID: 66246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C6")]
		[Address(RVA = "0x7E8800", Offset = "0x7E7400", VA = "0x1807E8800", Slot = "4")]
		public override void UpdateStatusData(EnemyDuelBattleStatus status)
		{
		}

		// Token: 0x060102C7 RID: 66247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C7")]
		[Address(RVA = "0x7E8940", Offset = "0x7E7540", VA = "0x1807E8940")]
		public EnemyDuelSettleData()
		{
		}

		// Token: 0x060102C8 RID: 66248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C8")]
		[Address(RVA = "0x7E6C40", Offset = "0x7E5840", VA = "0x1807E6C40")]
		private void <>xLuaBaseProxy_UpdateStatusData(EnemyDuelBattleStatus P0)
		{
		}

		// Token: 0x04012088 RID: 73864
		[Token(Token = "0x4012088")]
		[FieldOffset(Offset = "0x20")]
		public List<EnemyDuelBattleStatus.RoundLeaderBoard> leaderBoard;

		// Token: 0x04012089 RID: 73865
		[Token(Token = "0x4012089")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatusData;

		// Token: 0x0401208A RID: 73866
		[Token(Token = "0x401208A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
