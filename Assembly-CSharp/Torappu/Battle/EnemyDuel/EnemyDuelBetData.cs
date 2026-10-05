using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026BD RID: 9917
	[Token(Token = "0x20026BD")]
	public class EnemyDuelBetData : EnemyDuelStateDataBasic
	{
		// Token: 0x060102C3 RID: 66243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C3")]
		[Address(RVA = "0x7E6CE0", Offset = "0x7E58E0", VA = "0x1807E6CE0", Slot = "4")]
		public override void UpdateStatusData(EnemyDuelBattleStatus status)
		{
		}

		// Token: 0x060102C4 RID: 66244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C4")]
		[Address(RVA = "0x7E6E00", Offset = "0x7E5A00", VA = "0x1807E6E00")]
		public EnemyDuelBetData()
		{
		}

		// Token: 0x060102C5 RID: 66245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C5")]
		[Address(RVA = "0x7E6C40", Offset = "0x7E5840", VA = "0x1807E6C40")]
		private void <>xLuaBaseProxy_UpdateStatusData(EnemyDuelBattleStatus P0)
		{
		}

		// Token: 0x04012085 RID: 73861
		[Token(Token = "0x4012085")]
		[FieldOffset(Offset = "0x20")]
		public List<EnemyDuelBattleStatus.BetItem> betList;

		// Token: 0x04012086 RID: 73862
		[Token(Token = "0x4012086")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatusData;

		// Token: 0x04012087 RID: 73863
		[Token(Token = "0x4012087")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
