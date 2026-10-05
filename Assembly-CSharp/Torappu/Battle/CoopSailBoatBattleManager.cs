using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002317 RID: 8983
	[Token(Token = "0x2002317")]
	public class CoopSailBoatBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x0600E2DE RID: 58078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C77")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E2DE")]
			[Address(RVA = "0x56A430", Offset = "0x569030", VA = "0x18056A430", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E2DF RID: 58079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2DF")]
		[Address(RVA = "0x567CD0", Offset = "0x5668D0", VA = "0x180567CD0", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600E2E0 RID: 58080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E0")]
		[Address(RVA = "0x568570", Offset = "0x567170", VA = "0x180568570", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E2E1 RID: 58081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E1")]
		[Address(RVA = "0x5688E0", Offset = "0x5674E0", VA = "0x1805688E0")]
		private void _InitCachedBuildableTile()
		{
		}

		// Token: 0x0600E2E2 RID: 58082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E2")]
		[Address(RVA = "0x569E80", Offset = "0x568A80", VA = "0x180569E80")]
		private void _UpdateNextFlowData()
		{
		}

		// Token: 0x0600E2E3 RID: 58083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E3")]
		[Address(RVA = "0x568E60", Offset = "0x567A60", VA = "0x180568E60")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E2E4 RID: 58084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E4")]
		[Address(RVA = "0x5692E0", Offset = "0x567EE0", VA = "0x1805692E0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E2E5 RID: 58085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E5")]
		[Address(RVA = "0x568D00", Offset = "0x567900", VA = "0x180568D00")]
		private void _OnTrapFinish(object arg)
		{
		}

		// Token: 0x0600E2E6 RID: 58086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E6")]
		[Address(RVA = "0x569930", Offset = "0x568530", VA = "0x180569930")]
		private void _RefreshTileBlackboard(Trap trap)
		{
		}

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E7")]
		[Address(RVA = "0x569DA0", Offset = "0x5689A0", VA = "0x180569DA0")]
		private void _SetMarkUiEvent(int type, bool isAttach, Transform transform)
		{
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E8")]
		[Address(RVA = "0x569590", Offset = "0x568190", VA = "0x180569590")]
		private void _RefreshBuildableTraps()
		{
		}

		// Token: 0x0600E2E9 RID: 58089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2E9")]
		[Address(RVA = "0x5686A0", Offset = "0x5672A0", VA = "0x1805686A0")]
		private void _CheckHasBuildableFilterTrap(Tile tile)
		{
		}

		// Token: 0x0600E2EA RID: 58090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2EA")]
		[Address(RVA = "0x568C00", Offset = "0x567800", VA = "0x180568C00")]
		private void _LogBuildDeckTrap(Trap trap)
		{
		}

		// Token: 0x0600E2EB RID: 58091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2EB")]
		[Address(RVA = "0x56A0C0", Offset = "0x568CC0", VA = "0x18056A0C0")]
		public CoopSailBoatBattleManager()
		{
		}

		// Token: 0x0600E2EC RID: 58092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E2EC")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E2ED RID: 58093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2ED")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E2EE RID: 58094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2EE")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F8D4 RID: 63700
		[Token(Token = "0x400F8D4")]
		[FieldOffset(Offset = "0x28")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x0400F8D5 RID: 63701
		[Token(Token = "0x400F8D5")]
		[FieldOffset(Offset = "0x30")]
		private FP m_nextFlowDataTime;

		// Token: 0x0400F8D6 RID: 63702
		[Token(Token = "0x400F8D6")]
		[FieldOffset(Offset = "0x38")]
		private List<CoopSailBoatBattleManager.WaterFlowData> m_waterFlowData;

		// Token: 0x0400F8D7 RID: 63703
		[Token(Token = "0x400F8D7")]
		[FieldOffset(Offset = "0x40")]
		private List<Tile> m_cachedTiles;

		// Token: 0x0400F8D8 RID: 63704
		[Token(Token = "0x400F8D8")]
		[FieldOffset(Offset = "0x48")]
		private List<Tile> m_boatTiles;

		// Token: 0x0400F8D9 RID: 63705
		[Token(Token = "0x400F8D9")]
		[FieldOffset(Offset = "0x50")]
		private List<Tile> m_cachedBuildableTiles;

		// Token: 0x0400F8DA RID: 63706
		[Token(Token = "0x400F8DA")]
		[FieldOffset(Offset = "0x58")]
		private List<ObjectPtr<Trap>> m_trapOnTiles;

		// Token: 0x0400F8DB RID: 63707
		[Token(Token = "0x400F8DB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isCheckTraps;

		// Token: 0x0400F8DC RID: 63708
		[Token(Token = "0x400F8DC")]
		[FieldOffset(Offset = "0x68")]
		private List<string> m_markItemsId;

		// Token: 0x0400F8DD RID: 63709
		[Token(Token = "0x400F8DD")]
		[FieldOffset(Offset = "0x70")]
		private List<string> m_markEnemyId;

		// Token: 0x0400F8DE RID: 63710
		[Token(Token = "0x400F8DE")]
		[FieldOffset(Offset = "0x78")]
		private readonly Vector2Int[] m_dirs;

		// Token: 0x0400F8DF RID: 63711
		[Token(Token = "0x400F8DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F8E0 RID: 63712
		[Token(Token = "0x400F8E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F8E1 RID: 63713
		[Token(Token = "0x400F8E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F8E2 RID: 63714
		[Token(Token = "0x400F8E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitCachedBuildableTile;

		// Token: 0x0400F8E3 RID: 63715
		[Token(Token = "0x400F8E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateNextFlowData;

		// Token: 0x0400F8E4 RID: 63716
		[Token(Token = "0x400F8E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F8E5 RID: 63717
		[Token(Token = "0x400F8E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400F8E6 RID: 63718
		[Token(Token = "0x400F8E6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnTrapFinish;

		// Token: 0x0400F8E7 RID: 63719
		[Token(Token = "0x400F8E7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshTileBlackboard;

		// Token: 0x0400F8E8 RID: 63720
		[Token(Token = "0x400F8E8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetMarkUiEvent;

		// Token: 0x0400F8E9 RID: 63721
		[Token(Token = "0x400F8E9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshBuildableTraps;

		// Token: 0x0400F8EA RID: 63722
		[Token(Token = "0x400F8EA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckHasBuildableFilterTrap;

		// Token: 0x0400F8EB RID: 63723
		[Token(Token = "0x400F8EB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LogBuildDeckTrap;

		// Token: 0x0400F8EC RID: 63724
		[Token(Token = "0x400F8EC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002318 RID: 8984
		[Token(Token = "0x2002318")]
		private struct WaterFlowData
		{
			// Token: 0x0400F8ED RID: 63725
			[Token(Token = "0x400F8ED")]
			[FieldOffset(Offset = "0x0")]
			public int startTime;

			// Token: 0x0400F8EE RID: 63726
			[Token(Token = "0x400F8EE")]
			[FieldOffset(Offset = "0x4")]
			public int force;
		}
	}
}
