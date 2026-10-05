using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026BC RID: 9916
	[Token(Token = "0x20026BC")]
	public class EnemyDuelEntryData : EnemyDuelStateDataBasic
	{
		// Token: 0x060102C0 RID: 66240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C0")]
		[Address(RVA = "0x7E7000", Offset = "0x7E5C00", VA = "0x1807E7000", Slot = "4")]
		public override void UpdateStatusData(EnemyDuelBattleStatus status)
		{
		}

		// Token: 0x060102C1 RID: 66241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C1")]
		[Address(RVA = "0x7E7130", Offset = "0x7E5D30", VA = "0x1807E7130")]
		public EnemyDuelEntryData()
		{
		}

		// Token: 0x060102C2 RID: 66242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C2")]
		[Address(RVA = "0x7E6C40", Offset = "0x7E5840", VA = "0x1807E6C40")]
		private void <>xLuaBaseProxy_UpdateStatusData(EnemyDuelBattleStatus P0)
		{
		}

		// Token: 0x04012080 RID: 73856
		[Token(Token = "0x4012080")]
		[FieldOffset(Offset = "0x20")]
		public int seed;

		// Token: 0x04012081 RID: 73857
		[Token(Token = "0x4012081")]
		[FieldOffset(Offset = "0x28")]
		public List<int> seedHistory;

		// Token: 0x04012082 RID: 73858
		[Token(Token = "0x4012082")]
		[FieldOffset(Offset = "0x30")]
		public List<EnemyDuelChoiceSide> sideHistory;

		// Token: 0x04012083 RID: 73859
		[Token(Token = "0x4012083")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatusData;

		// Token: 0x04012084 RID: 73860
		[Token(Token = "0x4012084")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
