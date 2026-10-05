using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022DB RID: 8923
	[Token(Token = "0x20022DB")]
	public class Act47SideBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x0600E108 RID: 57608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C3B")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E108")]
			[Address(RVA = "0x3687980", Offset = "0x3686580", VA = "0x183687980", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E109 RID: 57609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E109")]
		[Address(RVA = "0x3684830", Offset = "0x3683430", VA = "0x183684830")]
		private void OnGameStart(object arg)
		{
		}

		// Token: 0x0600E10A RID: 57610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E10A")]
		[Address(RVA = "0x36853B0", Offset = "0x3683FB0", VA = "0x1836853B0")]
		private void OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E10B RID: 57611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E10B")]
		[Address(RVA = "0x36851A0", Offset = "0x3683DA0", VA = "0x1836851A0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E10C RID: 57612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E10C")]
		[Address(RVA = "0x36842F0", Offset = "0x3682EF0", VA = "0x1836842F0")]
		public void AddAreaForce(Tile tile, bool isUpForce, int forceValue, Character entity)
		{
		}

		// Token: 0x0600E10D RID: 57613 RVA: 0x00051AB0 File Offset: 0x0004FCB0
		[Token(Token = "0x600E10D")]
		[Address(RVA = "0x3684620", Offset = "0x3683220", VA = "0x183684620")]
		public bool IsCharacterDeathByMove(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E10E RID: 57614 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		[Token(Token = "0x600E10E")]
		[Address(RVA = "0x3684710", Offset = "0x3683310", VA = "0x183684710")]
		public bool IsTileFloating(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E10F RID: 57615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E10F")]
		[Address(RVA = "0x3685600", Offset = "0x3684200", VA = "0x183685600")]
		public void SwitchToBanGroundMode()
		{
		}

		// Token: 0x0600E110 RID: 57616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E110")]
		[Address(RVA = "0x3686410", Offset = "0x3685010", VA = "0x183686410")]
		private void _ProcessGroundNotValidMode()
		{
		}

		// Token: 0x0600E111 RID: 57617 RVA: 0x00051AE0 File Offset: 0x0004FCE0
		[Token(Token = "0x600E111")]
		[Address(RVA = "0x36858C0", Offset = "0x36844C0", VA = "0x1836858C0")]
		private bool _IsTileNeedBanByGroundNotValid(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E112 RID: 57618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E112")]
		[Address(RVA = "0x3687160", Offset = "0x3685D60", VA = "0x183687160")]
		private void _TriggerFloat(int areaIndex)
		{
		}

		// Token: 0x0600E113 RID: 57619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E113")]
		[Address(RVA = "0x3686F50", Offset = "0x3685B50", VA = "0x183686F50")]
		private void _TriggerDrop(int areaIndex)
		{
		}

		// Token: 0x0600E114 RID: 57620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E114")]
		[Address(RVA = "0x36857E0", Offset = "0x36843E0", VA = "0x1836857E0")]
		private IEnumerator _FloatCoroutine(int areaIndex, bool isFloating = true)
		{
			return null;
		}

		// Token: 0x0600E115 RID: 57621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E115")]
		[Address(RVA = "0x36859F0", Offset = "0x36845F0", VA = "0x1836859F0")]
		private void _PrepareBuild(int areaIndex, bool isFloating, List<GridPosition> area, Map map, Act47SideBattleManager.FloatAreaHolder areaHolder, BattleController controller, ref List<Tile> tiles)
		{
		}

		// Token: 0x0600E116 RID: 57622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E116")]
		[Address(RVA = "0x3685670", Offset = "0x3684270", VA = "0x183685670")]
		private void _CreateRebuildCardBuff(Deck.Card card)
		{
		}

		// Token: 0x0600E117 RID: 57623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E117")]
		[Address(RVA = "0x3686720", Offset = "0x3685320", VA = "0x183686720")]
		private void _RebuildArea(Act47SideBattleManager.FloatAreaHolder areaHolder, Map map, BattleController controller)
		{
		}

		// Token: 0x0600E118 RID: 57624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E118")]
		[Address(RVA = "0x3686AC0", Offset = "0x36856C0", VA = "0x183686AC0")]
		private void _RebuildCard(Deck.Card card, Deck deck, Act47SideBattleManager.BuildInfo buildCache, Tile tile)
		{
		}

		// Token: 0x0600E119 RID: 57625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E119")]
		[Address(RVA = "0x3687350", Offset = "0x3685F50", VA = "0x183687350")]
		private void _UpdateBuildModifier(Act47SideBattleManager.BuildInfo info, Entity source)
		{
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E11A")]
		[Address(RVA = "0x3687600", Offset = "0x3686200", VA = "0x183687600")]
		public Act47SideBattleManager()
		{
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E11B")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E11C RID: 57628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E11C")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F5A8 RID: 62888
		[Token(Token = "0x400F5A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> _balloonTileKeys;

		// Token: 0x0400F5A9 RID: 62889
		[Token(Token = "0x400F5A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _floatingHeight;

		// Token: 0x0400F5AA RID: 62890
		[Token(Token = "0x400F5AA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _floatTwest;

		// Token: 0x0400F5AB RID: 62891
		[Token(Token = "0x400F5AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _floatTime;

		// Token: 0x0400F5AC RID: 62892
		[Token(Token = "0x400F5AC")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Ease _floatEase;

		// Token: 0x0400F5AD RID: 62893
		[Token(Token = "0x400F5AD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _tileFloatHeightKey;

		// Token: 0x0400F5AE RID: 62894
		[Token(Token = "0x400F5AE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _appendStatus;

		// Token: 0x0400F5AF RID: 62895
		[Token(Token = "0x400F5AF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _removeStatus;

		// Token: 0x0400F5B0 RID: 62896
		[Token(Token = "0x400F5B0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _dropOutStatus;

		// Token: 0x0400F5B1 RID: 62897
		[Token(Token = "0x400F5B1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _dropOutAllStatus;

		// Token: 0x0400F5B2 RID: 62898
		[Token(Token = "0x400F5B2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _floatAllowDropProtectionTime;

		// Token: 0x0400F5B3 RID: 62899
		[Token(Token = "0x400F5B3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _markAsInBalloonAreaStatus;

		// Token: 0x0400F5B4 RID: 62900
		[Token(Token = "0x400F5B4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _tileCenterFloatStatus;

		// Token: 0x0400F5B5 RID: 62901
		[Token(Token = "0x400F5B5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _tileCenterDropStatus;

		// Token: 0x0400F5B6 RID: 62902
		[Token(Token = "0x400F5B6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _logFormat;

		// Token: 0x0400F5B7 RID: 62903
		[Token(Token = "0x400F5B7")]
		[FieldOffset(Offset = "0x90")]
		private List<List<GridPosition>> m_areas;

		// Token: 0x0400F5B8 RID: 62904
		[Token(Token = "0x400F5B8")]
		[FieldOffset(Offset = "0x98")]
		private ListDict<Tile, int> m_tileAreaReverseDic;

		// Token: 0x0400F5B9 RID: 62905
		[Token(Token = "0x400F5B9")]
		[FieldOffset(Offset = "0xA0")]
		private List<Act47SideBattleManager.FloatAreaHolder> m_areasHolder;

		// Token: 0x0400F5BA RID: 62906
		[Token(Token = "0x400F5BA")]
		[FieldOffset(Offset = "0xA8")]
		private List<float> m_areaFloatHeights;

		// Token: 0x0400F5BB RID: 62907
		[Token(Token = "0x400F5BB")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInGroundNotValidMode;

		// Token: 0x0400F5BC RID: 62908
		[Token(Token = "0x400F5BC")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_isInGroundNotValidProceeded;

		// Token: 0x0400F5BD RID: 62909
		[Token(Token = "0x400F5BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F5BE RID: 62910
		[Token(Token = "0x400F5BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0400F5BF RID: 62911
		[Token(Token = "0x400F5BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUnitBorn;

		// Token: 0x0400F5C0 RID: 62912
		[Token(Token = "0x400F5C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F5C1 RID: 62913
		[Token(Token = "0x400F5C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddAreaForce;

		// Token: 0x0400F5C2 RID: 62914
		[Token(Token = "0x400F5C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsCharacterDeathByMove;

		// Token: 0x0400F5C3 RID: 62915
		[Token(Token = "0x400F5C3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsTileFloating;

		// Token: 0x0400F5C4 RID: 62916
		[Token(Token = "0x400F5C4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SwitchToBanGroundMode;

		// Token: 0x0400F5C5 RID: 62917
		[Token(Token = "0x400F5C5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ProcessGroundNotValidMode;

		// Token: 0x0400F5C6 RID: 62918
		[Token(Token = "0x400F5C6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__IsTileNeedBanByGroundNotValid;

		// Token: 0x0400F5C7 RID: 62919
		[Token(Token = "0x400F5C7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TriggerFloat;

		// Token: 0x0400F5C8 RID: 62920
		[Token(Token = "0x400F5C8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TriggerDrop;

		// Token: 0x0400F5C9 RID: 62921
		[Token(Token = "0x400F5C9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FloatCoroutine;

		// Token: 0x0400F5CA RID: 62922
		[Token(Token = "0x400F5CA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PrepareBuild;

		// Token: 0x0400F5CB RID: 62923
		[Token(Token = "0x400F5CB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateRebuildCardBuff;

		// Token: 0x0400F5CC RID: 62924
		[Token(Token = "0x400F5CC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RebuildArea;

		// Token: 0x0400F5CD RID: 62925
		[Token(Token = "0x400F5CD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RebuildCard;

		// Token: 0x0400F5CE RID: 62926
		[Token(Token = "0x400F5CE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateBuildModifier;

		// Token: 0x0400F5CF RID: 62927
		[Token(Token = "0x400F5CF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022DC RID: 8924
		[Token(Token = "0x20022DC")]
		private class BuildInfo
		{
			// Token: 0x0600E11D RID: 57629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E11D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuildInfo()
			{
			}

			// Token: 0x0400F5D0 RID: 62928
			[Token(Token = "0x400F5D0")]
			[FieldOffset(Offset = "0x10")]
			public SharedConsts.Direction dir;

			// Token: 0x0400F5D1 RID: 62929
			[Token(Token = "0x400F5D1")]
			[FieldOffset(Offset = "0x14")]
			public GridPosition position;

			// Token: 0x0400F5D2 RID: 62930
			[Token(Token = "0x400F5D2")]
			[FieldOffset(Offset = "0x1C")]
			public uint cardUid;

			// Token: 0x0400F5D3 RID: 62931
			[Token(Token = "0x400F5D3")]
			[FieldOffset(Offset = "0x20")]
			public PlayerSide side;

			// Token: 0x0400F5D4 RID: 62932
			[Token(Token = "0x400F5D4")]
			[FieldOffset(Offset = "0x28")]
			public FP spRatio;

			// Token: 0x0400F5D5 RID: 62933
			[Token(Token = "0x400F5D5")]
			[FieldOffset(Offset = "0x30")]
			public FP hpRatio;

			// Token: 0x0400F5D6 RID: 62934
			[Token(Token = "0x400F5D6")]
			[FieldOffset(Offset = "0x38")]
			public bool isPredifined;
		}

		// Token: 0x020022DD RID: 8925
		[Token(Token = "0x20022DD")]
		private class FloatAreaHolder
		{
			// Token: 0x0600E11E RID: 57630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E11E")]
			[Address(RVA = "0x36966C0", Offset = "0x36952C0", VA = "0x1836966C0")]
			public FloatAreaHolder()
			{
			}

			// Token: 0x0400F5D7 RID: 62935
			[Token(Token = "0x400F5D7")]
			[FieldOffset(Offset = "0x10")]
			public List<Act47SideBattleManager.BuildInfo> buildCaches;

			// Token: 0x0400F5D8 RID: 62936
			[Token(Token = "0x400F5D8")]
			[FieldOffset(Offset = "0x18")]
			public List<Act47SideBattleManager.BuildInfo> lastBuildInfos;

			// Token: 0x0400F5D9 RID: 62937
			[Token(Token = "0x400F5D9")]
			[FieldOffset(Offset = "0x20")]
			public int upForce;

			// Token: 0x0400F5DA RID: 62938
			[Token(Token = "0x400F5DA")]
			[FieldOffset(Offset = "0x24")]
			public int downForce;

			// Token: 0x0400F5DB RID: 62939
			[Token(Token = "0x400F5DB")]
			[FieldOffset(Offset = "0x28")]
			public bool isFloating;

			// Token: 0x0400F5DC RID: 62940
			[Token(Token = "0x400F5DC")]
			[FieldOffset(Offset = "0x2C")]
			public GridPosition centerTilePos;

			// Token: 0x0400F5DD RID: 62941
			[Token(Token = "0x400F5DD")]
			[FieldOffset(Offset = "0x38")]
			public CoroutineId floatCoroutine;

			// Token: 0x0400F5DE RID: 62942
			[Token(Token = "0x400F5DE")]
			[FieldOffset(Offset = "0x48")]
			public CoroutineId dropCoroutine;
		}
	}
}
