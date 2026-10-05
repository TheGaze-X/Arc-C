using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200232C RID: 9004
	[Token(Token = "0x200232C")]
	public class LhshipRouteManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x0600E374 RID: 58228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C87")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E374")]
			[Address(RVA = "0x57B4B0", Offset = "0x57A0B0", VA = "0x18057B4B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E375 RID: 58229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E375")]
		[Address(RVA = "0x579080", Offset = "0x577C80", VA = "0x180579080", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E376 RID: 58230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E376")]
		[Address(RVA = "0x579160", Offset = "0x577D60", VA = "0x180579160", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E377 RID: 58231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E377")]
		[Address(RVA = "0x578D40", Offset = "0x577940", VA = "0x180578D40", Slot = "10")]
		public override void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x0600E378 RID: 58232 RVA: 0x00052590 File Offset: 0x00050790
		[Token(Token = "0x600E378")]
		[Address(RVA = "0x578DE0", Offset = "0x5779E0", VA = "0x180578DE0")]
		public bool HalfIdleAbleToSummonShip(Entity portTrap)
		{
			return default(bool);
		}

		// Token: 0x0600E379 RID: 58233 RVA: 0x000525A8 File Offset: 0x000507A8
		[Token(Token = "0x600E379")]
		[Address(RVA = "0x578F30", Offset = "0x577B30", VA = "0x180578F30")]
		public bool HalfIdleTrySummonShip(Entity portTrap)
		{
			return default(bool);
		}

		// Token: 0x0600E37A RID: 58234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E37A")]
		[Address(RVA = "0x579F30", Offset = "0x578B30", VA = "0x180579F30")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E37B RID: 58235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E37B")]
		[Address(RVA = "0x57A1D0", Offset = "0x578DD0", VA = "0x18057A1D0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E37C RID: 58236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E37C")]
		[Address(RVA = "0x57ADE0", Offset = "0x5799E0", VA = "0x18057ADE0")]
		private void _UpdateLhshipRoutes()
		{
		}

		// Token: 0x0600E37D RID: 58237 RVA: 0x000525C0 File Offset: 0x000507C0
		[Token(Token = "0x600E37D")]
		[Address(RVA = "0x579210", Offset = "0x577E10", VA = "0x180579210")]
		private bool _CheckPortReachable(GridPosition startPos, GridPosition portPos)
		{
			return default(bool);
		}

		// Token: 0x0600E37E RID: 58238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E37E")]
		[Address(RVA = "0x57A620", Offset = "0x579220", VA = "0x18057A620")]
		private void _SpawnLhship(Entity host, GridPosition startPos, GridPosition endPos)
		{
		}

		// Token: 0x0600E37F RID: 58239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E37F")]
		[Address(RVA = "0x579A60", Offset = "0x578660", VA = "0x180579A60")]
		private void _GetValidRoute(GridPosition startPos, GridPosition endPos, out Route route)
		{
		}

		// Token: 0x0600E380 RID: 58240 RVA: 0x000525D8 File Offset: 0x000507D8
		[Token(Token = "0x600E380")]
		[Address(RVA = "0x57AB90", Offset = "0x579790", VA = "0x18057AB90")]
		private bool _TryFindFarthestConnectedLhport(GridPosition startPort, GridPosition curPos, out GridPosition endPort)
		{
			return default(bool);
		}

		// Token: 0x0600E381 RID: 58241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E381")]
		[Address(RVA = "0x579380", Offset = "0x577F80", VA = "0x180579380")]
		private void _FindConnectedLhkawa()
		{
		}

		// Token: 0x0600E382 RID: 58242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E382")]
		[Address(RVA = "0x57B380", Offset = "0x579F80", VA = "0x18057B380")]
		public LhshipRouteManager()
		{
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E383")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E384")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E385 RID: 58245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E385")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E386 RID: 58246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E386")]
		[Address(RVA = "0x550BC0", Offset = "0x54F7C0", VA = "0x180550BC0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0400F9E8 RID: 63976
		[Token(Token = "0x400F9E8")]
		private const MotionMode LHSHIP_MOTION_MODE = MotionMode.FLY;

		// Token: 0x0400F9E9 RID: 63977
		[Token(Token = "0x400F9E9")]
		[FieldOffset(Offset = "0x28")]
		private LhshipSPFA m_pathFinding;

		// Token: 0x0400F9EA RID: 63978
		[Token(Token = "0x400F9EA")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isMapDirty;

		// Token: 0x0400F9EB RID: 63979
		[Token(Token = "0x400F9EB")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isLhportDirty;

		// Token: 0x0400F9EC RID: 63980
		[Token(Token = "0x400F9EC")]
		[FieldOffset(Offset = "0x38")]
		private List<LhshipRouteManager.LhkawaConnectedMap> m_lhkawaConnectedMaps;

		// Token: 0x0400F9ED RID: 63981
		[Token(Token = "0x400F9ED")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<Route, List<ObjectPtr<Enemy>>> m_lhshipRoutes;

		// Token: 0x0400F9EE RID: 63982
		[Token(Token = "0x400F9EE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuffData[] _lhshipBuffs;

		// Token: 0x0400F9EF RID: 63983
		[Token(Token = "0x400F9EF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _enemyLhshipId;

		// Token: 0x0400F9F0 RID: 63984
		[Token(Token = "0x400F9F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F9F1 RID: 63985
		[Token(Token = "0x400F9F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F9F2 RID: 63986
		[Token(Token = "0x400F9F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F9F3 RID: 63987
		[Token(Token = "0x400F9F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400F9F4 RID: 63988
		[Token(Token = "0x400F9F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HalfIdleAbleToSummonShip;

		// Token: 0x0400F9F5 RID: 63989
		[Token(Token = "0x400F9F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HalfIdleTrySummonShip;

		// Token: 0x0400F9F6 RID: 63990
		[Token(Token = "0x400F9F6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F9F7 RID: 63991
		[Token(Token = "0x400F9F7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400F9F8 RID: 63992
		[Token(Token = "0x400F9F8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateLhshipRoutes;

		// Token: 0x0400F9F9 RID: 63993
		[Token(Token = "0x400F9F9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckPortReachable;

		// Token: 0x0400F9FA RID: 63994
		[Token(Token = "0x400F9FA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SpawnLhship;

		// Token: 0x0400F9FB RID: 63995
		[Token(Token = "0x400F9FB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetValidRoute;

		// Token: 0x0400F9FC RID: 63996
		[Token(Token = "0x400F9FC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryFindFarthestConnectedLhport;

		// Token: 0x0400F9FD RID: 63997
		[Token(Token = "0x400F9FD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FindConnectedLhkawa;

		// Token: 0x0400F9FE RID: 63998
		[Token(Token = "0x400F9FE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200232D RID: 9005
		[Token(Token = "0x200232D")]
		private class LhkawaConnectedMap : IHotfixable
		{
			// Token: 0x0600E387 RID: 58247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E387")]
			[Address(RVA = "0x57F630", Offset = "0x57E230", VA = "0x18057F630")]
			public LhkawaConnectedMap(HashSet<GridPosition> lhkawaPositions, List<GridPosition> lhportPositions)
			{
			}

			// Token: 0x0400F9FF RID: 63999
			[Token(Token = "0x400F9FF")]
			[FieldOffset(Offset = "0x10")]
			public HashSet<GridPosition> lhkawaPositions;

			// Token: 0x0400FA00 RID: 64000
			[Token(Token = "0x400FA00")]
			[FieldOffset(Offset = "0x18")]
			public List<GridPosition> lhportPositions;

			// Token: 0x0400FA01 RID: 64001
			[Token(Token = "0x400FA01")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
