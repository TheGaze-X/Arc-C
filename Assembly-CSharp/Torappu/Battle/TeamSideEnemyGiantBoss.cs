using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002612 RID: 9746
	[Token(Token = "0x2002612")]
	public class TeamSideEnemyGiantBoss : EnemyGiantBoss, IUseTeamSide, IPtrObject
	{
		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x0600FE14 RID: 65044 RVA: 0x00060390 File Offset: 0x0005E590
		[Token(Token = "0x17002243")]
		public SideTypeIndex teamSide
		{
			[Token(Token = "0x600FE14")]
			[Address(RVA = "0x7608A0", Offset = "0x75F4A0", VA = "0x1807608A0", Slot = "252")]
			get
			{
				return SideTypeIndex.ALLY;
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x0600FE15 RID: 65045 RVA: 0x000603A8 File Offset: 0x0005E5A8
		[Token(Token = "0x17002244")]
		public bool hasSummoneeAfterDeath
		{
			[Token(Token = "0x600FE15")]
			[Address(RVA = "0x7607E0", Offset = "0x75F3E0", VA = "0x1807607E0", Slot = "253")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x0600FE16 RID: 65046 RVA: 0x000603C0 File Offset: 0x0005E5C0
		[Token(Token = "0x17002245")]
		protected override SideTypeIndex sideTypeIndex
		{
			[Token(Token = "0x600FE16")]
			[Address(RVA = "0x760840", Offset = "0x75F440", VA = "0x180760840", Slot = "201")]
			get
			{
				return SideTypeIndex.ALLY;
			}
		}

		// Token: 0x0600FE17 RID: 65047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE17")]
		[Address(RVA = "0x760420", Offset = "0x75F020", VA = "0x180760420", Slot = "216")]
		protected override void Init(LevelData.EnemyData enemyData, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route)
		{
		}

		// Token: 0x0600FE18 RID: 65048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE18")]
		[Address(RVA = "0x760650", Offset = "0x75F250", VA = "0x180760650")]
		private void _SetSideData()
		{
		}

		// Token: 0x0600FE19 RID: 65049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE19")]
		[Address(RVA = "0x760770", Offset = "0x75F370", VA = "0x180760770")]
		public TeamSideEnemyGiantBoss()
		{
		}

		// Token: 0x0600FE1A RID: 65050 RVA: 0x000603D8 File Offset: 0x0005E5D8
		[Token(Token = "0x600FE1A")]
		[Address(RVA = "0x760640", Offset = "0x75F240", VA = "0x180760640")]
		private SideTypeIndex <>xLuaBaseProxy_get_sideTypeIndex()
		{
			return SideTypeIndex.ALLY;
		}

		// Token: 0x0600FE1B RID: 65051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE1B")]
		[Address(RVA = "0x7536A0", Offset = "0x7522A0", VA = "0x1807536A0")]
		private void <>xLuaBaseProxy_Init(LevelData.EnemyData P0, EnemyHandBookData P1, Scheduler.SchedulerSnapshot P2, Route P3)
		{
		}

		// Token: 0x04011A5A RID: 72282
		[Token(Token = "0x4011A5A")]
		[FieldOffset(Offset = "0x598")]
		[SerializeField]
		private bool _hasSummonee;

		// Token: 0x04011A5B RID: 72283
		[Token(Token = "0x4011A5B")]
		[FieldOffset(Offset = "0x59C")]
		private SideTypeIndex m_teamSide;

		// Token: 0x04011A5C RID: 72284
		[Token(Token = "0x4011A5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_teamSide;

		// Token: 0x04011A5D RID: 72285
		[Token(Token = "0x4011A5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasSummoneeAfterDeath;

		// Token: 0x04011A5E RID: 72286
		[Token(Token = "0x4011A5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sideTypeIndex;

		// Token: 0x04011A5F RID: 72287
		[Token(Token = "0x4011A5F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04011A60 RID: 72288
		[Token(Token = "0x4011A60")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetSideData;

		// Token: 0x04011A61 RID: 72289
		[Token(Token = "0x4011A61")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
