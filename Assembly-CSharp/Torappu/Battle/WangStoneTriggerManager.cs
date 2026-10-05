using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200230A RID: 8970
	[Token(Token = "0x200230A")]
	public class WangStoneTriggerManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E28F RID: 57999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E28F")]
		[Address(RVA = "0x562300", Offset = "0x560F00", VA = "0x180562300", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x0600E290 RID: 58000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C73")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E290")]
			[Address(RVA = "0x565FE0", Offset = "0x564BE0", VA = "0x180565FE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E291 RID: 58001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E291")]
		[Address(RVA = "0x562430", Offset = "0x561030", VA = "0x180562430", Slot = "13")]
		public override void OnEnvDestroy()
		{
		}

		// Token: 0x0600E292 RID: 58002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E292")]
		[Address(RVA = "0x562C60", Offset = "0x561860", VA = "0x180562C60", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600E293 RID: 58003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E293")]
		[Address(RVA = "0x5625A0", Offset = "0x5611A0", VA = "0x1805625A0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E294 RID: 58004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E294")]
		[Address(RVA = "0x5636B0", Offset = "0x5622B0", VA = "0x1805636B0")]
		private void _ClearTmpData()
		{
		}

		// Token: 0x0600E295 RID: 58005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E295")]
		[Address(RVA = "0x5644D0", Offset = "0x5630D0", VA = "0x1805644D0")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E296 RID: 58006 RVA: 0x00052320 File Offset: 0x00050520
		[Token(Token = "0x600E296")]
		[Address(RVA = "0x563610", Offset = "0x562210", VA = "0x180563610")]
		private bool _CheckIsValidStone(string id)
		{
			return default(bool);
		}

		// Token: 0x0600E297 RID: 58007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E297")]
		[Address(RVA = "0x565060", Offset = "0x563C60", VA = "0x180565060")]
		private void _TryTriggerStones(WangStoneTriggerManager.StoneInfo newStone, WangStoneTriggerManager.StoneTriggerMap stoneMap)
		{
		}

		// Token: 0x0600E298 RID: 58008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E298")]
		[Address(RVA = "0x5649D0", Offset = "0x5635D0", VA = "0x1805649D0")]
		private void _PlayTriggeredLineEffect(WangStoneTriggerManager.StoneInfo oriStone, List<WangStoneTriggerManager.StoneInfo> tmpExplodedStone)
		{
		}

		// Token: 0x0600E299 RID: 58009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E299")]
		[Address(RVA = "0x565670", Offset = "0x564270", VA = "0x180565670")]
		private void _UpdateStoneTriggeredData(WangStoneTriggerManager.StoneType type, GridPosition oriPos, List<WangStoneTriggerManager.StoneInfo> tmpExplodedStone, int triggeredCnt, bool isRow, WangStoneTriggerManager.StoneTriggerMap stoneMap)
		{
		}

		// Token: 0x0600E29A RID: 58010 RVA: 0x00052338 File Offset: 0x00050538
		[Token(Token = "0x600E29A")]
		[Address(RVA = "0x563F20", Offset = "0x562B20", VA = "0x180563F20")]
		private bool _DoStoneExplode(WangStoneTriggerManager.StoneInfo stoneInfo)
		{
			return default(bool);
		}

		// Token: 0x0600E29B RID: 58011 RVA: 0x00052350 File Offset: 0x00050550
		[Token(Token = "0x600E29B")]
		[Address(RVA = "0x5637D0", Offset = "0x5623D0", VA = "0x1805637D0")]
		private bool _CollectTmpTiles(WangStoneTriggerManager.StoneInfo oriStone, WangStoneTriggerManager.StoneTriggerMap stoneMap)
		{
			return default(bool);
		}

		// Token: 0x0600E29C RID: 58012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E29C")]
		[Address(RVA = "0x5641F0", Offset = "0x562DF0", VA = "0x1805641F0")]
		private void _FilterContinuousCharacters(List<GridPosition> candidates, GridPosition oriPos, bool isRow)
		{
		}

		// Token: 0x0600E29D RID: 58013 RVA: 0x00052368 File Offset: 0x00050568
		[Token(Token = "0x600E29D")]
		[Address(RVA = "0x563B50", Offset = "0x562750", VA = "0x180563B50")]
		private bool _CollectTriggeredStones(GridPosition oriPos, List<GridPosition> candidates, bool isRow, WangStoneTriggerManager.StoneTriggerMap stoneMap)
		{
			return default(bool);
		}

		// Token: 0x0600E29E RID: 58014 RVA: 0x00052380 File Offset: 0x00050580
		[Token(Token = "0x600E29E")]
		[Address(RVA = "0x563D10", Offset = "0x562910", VA = "0x180563D10")]
		private bool _CollectTriggeredStones(GridPosition oriPos, GridPosition candidate, bool isRow, WangStoneTriggerManager.StoneTriggerMap stoneMap)
		{
			return default(bool);
		}

		// Token: 0x0600E29F RID: 58015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E29F")]
		[Address(RVA = "0x564840", Offset = "0x563440", VA = "0x180564840")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E2A0 RID: 58016 RVA: 0x00052398 File Offset: 0x00050598
		[Token(Token = "0x600E2A0")]
		[Address(RVA = "0x564F10", Offset = "0x563B10", VA = "0x180564F10")]
		private bool _TryGetStoneMap(WangStoneTriggerManager.StoneType stoneType, out WangStoneTriggerManager.StoneTriggerMap stoneMap)
		{
			return default(bool);
		}

		// Token: 0x0600E2A1 RID: 58017 RVA: 0x000523B0 File Offset: 0x000505B0
		[Token(Token = "0x600E2A1")]
		[Address(RVA = "0x562000", Offset = "0x560C00", VA = "0x180562000")]
		public bool CheckStoneMarkable(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E2A2 RID: 58018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2A2")]
		[Address(RVA = "0x561A80", Offset = "0x560680", VA = "0x180561A80")]
		public void AddBuildStoneSequence(WangStoneTriggerManager.StoneType stoneType, GridPosition centerPos, WangVisualStoneCtrlAbility ctrlAbility, int extraBuildCnt = 0)
		{
		}

		// Token: 0x0600E2A3 RID: 58019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2A3")]
		[Address(RVA = "0x5631E0", Offset = "0x561DE0", VA = "0x1805631E0")]
		public void RemoveBuildStoneSequence(WangStoneTriggerManager.StoneType stoneType, WangVisualStoneCtrlAbility ctrlAbility)
		{
		}

		// Token: 0x0600E2A4 RID: 58020 RVA: 0x000523C8 File Offset: 0x000505C8
		[Token(Token = "0x600E2A4")]
		[Address(RVA = "0x563390", Offset = "0x561F90", VA = "0x180563390")]
		public bool TryMarkVisualStone(WangStoneTriggerManager.StoneType stoneType, GridPosition pos, WangVisualStoneMarkAbility holderAbility)
		{
			return default(bool);
		}

		// Token: 0x0600E2A5 RID: 58021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2A5")]
		[Address(RVA = "0x561DA0", Offset = "0x5609A0", VA = "0x180561DA0")]
		public void AddMarkProjectile(WangStoneTriggerManager.StoneType stoneType, GridPosition pos, Projectile projectile, Projectile fakeProjectile)
		{
		}

		// Token: 0x0600E2A6 RID: 58022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2A6")]
		[Address(RVA = "0x5621A0", Offset = "0x560DA0", VA = "0x1805621A0")]
		public void ClearMark(WangStoneTriggerManager.StoneType stoneType, GridPosition pos)
		{
		}

		// Token: 0x0600E2A7 RID: 58023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2A7")]
		[Address(RVA = "0x562260", Offset = "0x560E60", VA = "0x180562260", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E2A8 RID: 58024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2A8")]
		[Address(RVA = "0x565D60", Offset = "0x564960", VA = "0x180565D60")]
		public WangStoneTriggerManager()
		{
		}

		// Token: 0x0600E2A9 RID: 58025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2A9")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E2AA RID: 58026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E2AA")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E2AB RID: 58027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2AB")]
		[Address(RVA = "0x550BF0", Offset = "0x54F7F0", VA = "0x180550BF0")]
		private void <>xLuaBaseProxy_OnEnvDestroy()
		{
		}

		// Token: 0x0600E2AC RID: 58028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2AC")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0600E2AD RID: 58029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2AD")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E2AE RID: 58030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E2AE")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0400F864 RID: 63588
		[Token(Token = "0x400F864")]
		private const string IS_ROW_BB = "is_row";

		// Token: 0x0400F865 RID: 63589
		[Token(Token = "0x400F865")]
		private const string IS_COL_BB = "is_col";

		// Token: 0x0400F866 RID: 63590
		[Token(Token = "0x400F866")]
		private const string EXPLODE_SKILL_2 = "skill_2_explode";

		// Token: 0x0400F867 RID: 63591
		[Token(Token = "0x400F867")]
		private const string EXPLODE_SKILL_3 = "skill_3_explode";

		// Token: 0x0400F868 RID: 63592
		[Token(Token = "0x400F868")]
		private const string EXPLODE_SKILL_1 = "skill_1_explode";

		// Token: 0x0400F869 RID: 63593
		[Token(Token = "0x400F869")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _triggeredStatus;

		// Token: 0x0400F86A RID: 63594
		[Token(Token = "0x400F86A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _triggeredEffectShowStatus;

		// Token: 0x0400F86B RID: 63595
		[Token(Token = "0x400F86B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private uint _stoneBuildDelay;

		// Token: 0x0400F86C RID: 63596
		[Token(Token = "0x400F86C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private uint _tokenStoneExplodeDelay;

		// Token: 0x0400F86D RID: 63597
		[Token(Token = "0x400F86D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private uint _projectileStoneExplodeDelay;

		// Token: 0x0400F86E RID: 63598
		[Token(Token = "0x400F86E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _validStoneId;

		// Token: 0x0400F86F RID: 63599
		[Token(Token = "0x400F86F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _triggeredLineEffectKey;

		// Token: 0x0400F870 RID: 63600
		[Token(Token = "0x400F870")]
		[FieldOffset(Offset = "0x58")]
		private List<GridPosition> m_rowCandidates;

		// Token: 0x0400F871 RID: 63601
		[Token(Token = "0x400F871")]
		[FieldOffset(Offset = "0x60")]
		private List<GridPosition> m_colCandidates;

		// Token: 0x0400F872 RID: 63602
		[Token(Token = "0x400F872")]
		[FieldOffset(Offset = "0x68")]
		private List<WangStoneTriggerManager.StoneInfo> m_tmpTriggeredStone;

		// Token: 0x0400F873 RID: 63603
		[Token(Token = "0x400F873")]
		[FieldOffset(Offset = "0x70")]
		private List<WangStoneTriggerManager.StoneInfo> m_tmpRowTriggeredStone;

		// Token: 0x0400F874 RID: 63604
		[Token(Token = "0x400F874")]
		[FieldOffset(Offset = "0x78")]
		private List<WangStoneTriggerManager.StoneInfo> m_tmpColTriggeredStone;

		// Token: 0x0400F875 RID: 63605
		[Token(Token = "0x400F875")]
		[FieldOffset(Offset = "0x80")]
		private List<WangStoneTriggerManager.StoneTriggerMap> m_stoneTriggerMaps;

		// Token: 0x0400F876 RID: 63606
		[Token(Token = "0x400F876")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F877 RID: 63607
		[Token(Token = "0x400F877")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F878 RID: 63608
		[Token(Token = "0x400F878")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnvDestroy;

		// Token: 0x0400F879 RID: 63609
		[Token(Token = "0x400F879")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400F87A RID: 63610
		[Token(Token = "0x400F87A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F87B RID: 63611
		[Token(Token = "0x400F87B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClearTmpData;

		// Token: 0x0400F87C RID: 63612
		[Token(Token = "0x400F87C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F87D RID: 63613
		[Token(Token = "0x400F87D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIsValidStone;

		// Token: 0x0400F87E RID: 63614
		[Token(Token = "0x400F87E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryTriggerStones;

		// Token: 0x0400F87F RID: 63615
		[Token(Token = "0x400F87F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayTriggeredLineEffect;

		// Token: 0x0400F880 RID: 63616
		[Token(Token = "0x400F880")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateStoneTriggeredData;

		// Token: 0x0400F881 RID: 63617
		[Token(Token = "0x400F881")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoStoneExplode;

		// Token: 0x0400F882 RID: 63618
		[Token(Token = "0x400F882")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CollectTmpTiles;

		// Token: 0x0400F883 RID: 63619
		[Token(Token = "0x400F883")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FilterContinuousCharacters;

		// Token: 0x0400F884 RID: 63620
		[Token(Token = "0x400F884")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CollectTriggeredStones;

		// Token: 0x0400F885 RID: 63621
		[Token(Token = "0x400F885")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1__CollectTriggeredStones;

		// Token: 0x0400F886 RID: 63622
		[Token(Token = "0x400F886")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400F887 RID: 63623
		[Token(Token = "0x400F887")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TryGetStoneMap;

		// Token: 0x0400F888 RID: 63624
		[Token(Token = "0x400F888")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckStoneMarkable;

		// Token: 0x0400F889 RID: 63625
		[Token(Token = "0x400F889")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_AddBuildStoneSequence;

		// Token: 0x0400F88A RID: 63626
		[Token(Token = "0x400F88A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RemoveBuildStoneSequence;

		// Token: 0x0400F88B RID: 63627
		[Token(Token = "0x400F88B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryMarkVisualStone;

		// Token: 0x0400F88C RID: 63628
		[Token(Token = "0x400F88C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_AddMarkProjectile;

		// Token: 0x0400F88D RID: 63629
		[Token(Token = "0x400F88D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ClearMark;

		// Token: 0x0400F88E RID: 63630
		[Token(Token = "0x400F88E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F88F RID: 63631
		[Token(Token = "0x400F88F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200230B RID: 8971
		[Token(Token = "0x200230B")]
		public class StoneInfo
		{
			// Token: 0x0600E2AF RID: 58031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2AF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StoneInfo()
			{
			}

			// Token: 0x0400F890 RID: 63632
			[Token(Token = "0x400F890")]
			[FieldOffset(Offset = "0x10")]
			public bool isTriggered;

			// Token: 0x0400F891 RID: 63633
			[Token(Token = "0x400F891")]
			[FieldOffset(Offset = "0x14")]
			public GridPosition pos;

			// Token: 0x0400F892 RID: 63634
			[Token(Token = "0x400F892")]
			[FieldOffset(Offset = "0x1C")]
			public bool isToken;

			// Token: 0x0400F893 RID: 63635
			[Token(Token = "0x400F893")]
			[FieldOffset(Offset = "0x20")]
			public ObjectPtr<Character> token;

			// Token: 0x0400F894 RID: 63636
			[Token(Token = "0x400F894")]
			[FieldOffset(Offset = "0x30")]
			public ObjectPtr<WangVisualStoneMarkAbility> holderAbility;

			// Token: 0x0400F895 RID: 63637
			[Token(Token = "0x400F895")]
			[FieldOffset(Offset = "0x40")]
			public List<ObjectPtr<Projectile>> projectiles;
		}

		// Token: 0x0200230C RID: 8972
		[Token(Token = "0x200230C")]
		public class ExplodedStoneInfo
		{
			// Token: 0x0600E2B0 RID: 58032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExplodedStoneInfo()
			{
			}

			// Token: 0x0400F896 RID: 63638
			[Token(Token = "0x400F896")]
			[FieldOffset(Offset = "0x10")]
			public WangStoneTriggerManager.StoneInfo stoneInfo;

			// Token: 0x0400F897 RID: 63639
			[Token(Token = "0x400F897")]
			[FieldOffset(Offset = "0x18")]
			public FP finishFrame;
		}

		// Token: 0x0200230D RID: 8973
		[Token(Token = "0x200230D")]
		public class BuildStoneRequest
		{
			// Token: 0x0600E2B1 RID: 58033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuildStoneRequest()
			{
			}

			// Token: 0x0400F898 RID: 63640
			[Token(Token = "0x400F898")]
			[FieldOffset(Offset = "0x10")]
			public GridPosition centerPos;

			// Token: 0x0400F899 RID: 63641
			[Token(Token = "0x400F899")]
			[FieldOffset(Offset = "0x18")]
			public FP buildFrame;

			// Token: 0x0400F89A RID: 63642
			[Token(Token = "0x400F89A")]
			[FieldOffset(Offset = "0x20")]
			public ObjectPtr<WangVisualStoneCtrlAbility> ctrlAbility;

			// Token: 0x0400F89B RID: 63643
			[Token(Token = "0x400F89B")]
			[FieldOffset(Offset = "0x30")]
			public int extraBuildCnt;

			// Token: 0x0400F89C RID: 63644
			[Token(Token = "0x400F89C")]
			[FieldOffset(Offset = "0x34")]
			public bool isFreeBuild;
		}

		// Token: 0x0200230E RID: 8974
		[Token(Token = "0x200230E")]
		public enum StoneType
		{
			// Token: 0x0400F89E RID: 63646
			[Token(Token = "0x400F89E")]
			SKILL_1,
			// Token: 0x0400F89F RID: 63647
			[Token(Token = "0x400F89F")]
			SKILL_2,
			// Token: 0x0400F8A0 RID: 63648
			[Token(Token = "0x400F8A0")]
			SKILL_3,
			// Token: 0x0400F8A1 RID: 63649
			[Token(Token = "0x400F8A1")]
			NUM
		}

		// Token: 0x0200230F RID: 8975
		[Token(Token = "0x200230F")]
		public class StoneTriggerMap : IHotfixable
		{
			// Token: 0x0600E2B2 RID: 58034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B2")]
			[Address(RVA = "0x57BD90", Offset = "0x57A990", VA = "0x18057BD90")]
			public void OnDestroy()
			{
			}

			// Token: 0x0600E2B3 RID: 58035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B3")]
			[Address(RVA = "0x57BB00", Offset = "0x57A700", VA = "0x18057BB00")]
			public void Init()
			{
			}

			// Token: 0x0600E2B4 RID: 58036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B4")]
			[Address(RVA = "0x57B820", Offset = "0x57A420", VA = "0x18057B820")]
			public void ClearExplodedStones(GridPosition pos)
			{
			}

			// Token: 0x0600E2B5 RID: 58037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B5")]
			[Address(RVA = "0x57C410", Offset = "0x57B010", VA = "0x18057C410")]
			public void UpdateStoneTriggerCnt(GridPosition pos, int stackCnt, int rowCnt, int colCnt)
			{
			}

			// Token: 0x0600E2B6 RID: 58038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B6")]
			[Address(RVA = "0x57C050", Offset = "0x57AC50", VA = "0x18057C050")]
			public void UpdateStoneMap(Character character, bool isStone, WangStoneTriggerManager.StoneType type)
			{
			}

			// Token: 0x0600E2B7 RID: 58039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B7")]
			[Address(RVA = "0x57BEF0", Offset = "0x57AAF0", VA = "0x18057BEF0")]
			public void UpdateStoneMap(WangStoneTriggerManager.StoneInfo stoneInfo)
			{
			}

			// Token: 0x0600E2B8 RID: 58040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B8")]
			[Address(RVA = "0x57C720", Offset = "0x57B320", VA = "0x18057C720")]
			private void _HandleVirtualStoneOverlap(Character character, WangStoneTriggerManager.StoneInfo stoneInfo)
			{
			}

			// Token: 0x0600E2B9 RID: 58041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E2B9")]
			[Address(RVA = "0x57C880", Offset = "0x57B480", VA = "0x18057C880")]
			public StoneTriggerMap()
			{
			}

			// Token: 0x0400F8A2 RID: 63650
			[Token(Token = "0x400F8A2")]
			[FieldOffset(Offset = "0x10")]
			public WangStoneTriggerManager.StoneType stoneType;

			// Token: 0x0400F8A3 RID: 63651
			[Token(Token = "0x400F8A3")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<GridPosition, WangStoneTriggerManager.StoneInfo> stoneDict;

			// Token: 0x0400F8A4 RID: 63652
			[Token(Token = "0x400F8A4")]
			[FieldOffset(Offset = "0x20")]
			public List<List<int>> stoneStackCntMap;

			// Token: 0x0400F8A5 RID: 63653
			[Token(Token = "0x400F8A5")]
			[FieldOffset(Offset = "0x28")]
			public List<List<KeyValuePair<int, int>>> stoneTriggerDirectionMap;

			// Token: 0x0400F8A6 RID: 63654
			[Token(Token = "0x400F8A6")]
			[FieldOffset(Offset = "0x30")]
			public List<WangStoneTriggerManager.ExplodedStoneInfo> explodedStoneCache;

			// Token: 0x0400F8A7 RID: 63655
			[Token(Token = "0x400F8A7")]
			[FieldOffset(Offset = "0x38")]
			public List<WangStoneTriggerManager.BuildStoneRequest> buildStoneRequests;

			// Token: 0x0400F8A8 RID: 63656
			[Token(Token = "0x400F8A8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x0400F8A9 RID: 63657
			[Token(Token = "0x400F8A9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400F8AA RID: 63658
			[Token(Token = "0x400F8AA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ClearExplodedStones;

			// Token: 0x0400F8AB RID: 63659
			[Token(Token = "0x400F8AB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateStoneTriggerCnt;

			// Token: 0x0400F8AC RID: 63660
			[Token(Token = "0x400F8AC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateStoneMap;

			// Token: 0x0400F8AD RID: 63661
			[Token(Token = "0x400F8AD")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix1_UpdateStoneMap;

			// Token: 0x0400F8AE RID: 63662
			[Token(Token = "0x400F8AE")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__HandleVirtualStoneOverlap;

			// Token: 0x0400F8AF RID: 63663
			[Token(Token = "0x400F8AF")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
