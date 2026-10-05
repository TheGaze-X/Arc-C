using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022EE RID: 8942
	[Token(Token = "0x20022EE")]
	public class Act49SidePrintingManager : GlobalEnvSystem.EnvManager, IBuffSource, IHotfixable, IEffectSource
	{
		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x0600E1B8 RID: 57784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C54")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E1B8")]
			[Address(RVA = "0x5578C0", Offset = "0x5564C0", VA = "0x1805578C0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x0600E1B9 RID: 57785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C55")]
		public string campTileTrapKey
		{
			[Token(Token = "0x600E1B9")]
			[Address(RVA = "0x557730", Offset = "0x556330", VA = "0x180557730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x0600E1BA RID: 57786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C56")]
		public string fortuneTileTrapKey
		{
			[Token(Token = "0x600E1BA")]
			[Address(RVA = "0x5579C0", Offset = "0x5565C0", VA = "0x1805579C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x0600E1BB RID: 57787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C57")]
		public string foodTileTrapKey
		{
			[Token(Token = "0x600E1BB")]
			[Address(RVA = "0x557940", Offset = "0x556540", VA = "0x180557940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x0600E1BC RID: 57788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C58")]
		public string highlandTileTrapKey
		{
			[Token(Token = "0x600E1BC")]
			[Address(RVA = "0x557A40", Offset = "0x556640", VA = "0x180557A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x0600E1BD RID: 57789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C59")]
		public string anchorTileTrapKey
		{
			[Token(Token = "0x600E1BD")]
			[Address(RVA = "0x557630", Offset = "0x556230", VA = "0x180557630")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x0600E1BE RID: 57790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C5A")]
		public string triggerTileTrapKey
		{
			[Token(Token = "0x600E1BE")]
			[Address(RVA = "0x557AC0", Offset = "0x5566C0", VA = "0x180557AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x0600E1BF RID: 57791 RVA: 0x00051DE0 File Offset: 0x0004FFE0
		[Token(Token = "0x17001C5B")]
		public bool canChargePrint
		{
			[Token(Token = "0x600E1BF")]
			[Address(RVA = "0x5577B0", Offset = "0x5563B0", VA = "0x1805577B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x0600E1C0 RID: 57792 RVA: 0x00051DF8 File Offset: 0x0004FFF8
		[Token(Token = "0x17001C5C")]
		public float charYinChargeValue
		{
			[Token(Token = "0x600E1C0")]
			[Address(RVA = "0x557840", Offset = "0x556440", VA = "0x180557840")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x0600E1C1 RID: 57793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C5D")]
		public string campTileSummonEnemyKey
		{
			[Token(Token = "0x600E1C1")]
			[Address(RVA = "0x5576B0", Offset = "0x5562B0", VA = "0x1805576B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E1C2 RID: 57794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1C2")]
		[Address(RVA = "0x54CD30", Offset = "0x54B930", VA = "0x18054CD30", Slot = "11")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600E1C3 RID: 57795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1C3")]
		[Address(RVA = "0x54CDC0", Offset = "0x54B9C0", VA = "0x18054CDC0", Slot = "10")]
		public override void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x0600E1C4 RID: 57796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1C4")]
		[Address(RVA = "0x54CF20", Offset = "0x54BB20", VA = "0x18054CF20", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E1C5 RID: 57797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1C5")]
		[Address(RVA = "0x54D6B0", Offset = "0x54C2B0", VA = "0x18054D6B0", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E1C6 RID: 57798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1C6")]
		[Address(RVA = "0x54E5B0", Offset = "0x54D1B0", VA = "0x18054E5B0", Slot = "13")]
		public override void OnEnvDestroy()
		{
		}

		// Token: 0x0600E1C7 RID: 57799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1C7")]
		[Address(RVA = "0x54E770", Offset = "0x54D370", VA = "0x18054E770", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E1C8 RID: 57800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1C8")]
		[Address(RVA = "0x54EF30", Offset = "0x54DB30", VA = "0x18054EF30", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600E1C9 RID: 57801 RVA: 0x00051E10 File Offset: 0x00050010
		[Token(Token = "0x600E1C9")]
		[Address(RVA = "0x54BA30", Offset = "0x54A630", VA = "0x18054BA30")]
		public bool ChargePrintTimer(float value)
		{
			return default(bool);
		}

		// Token: 0x0600E1CA RID: 57802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1CA")]
		[Address(RVA = "0x54F4B0", Offset = "0x54E0B0", VA = "0x18054F4B0")]
		public void ResetTriggerTileTimer()
		{
		}

		// Token: 0x0600E1CB RID: 57803 RVA: 0x00051E28 File Offset: 0x00050028
		[Token(Token = "0x600E1CB")]
		[Address(RVA = "0x54E330", Offset = "0x54CF30", VA = "0x18054E330")]
		public bool IsTriggerTileTimerReady()
		{
			return default(bool);
		}

		// Token: 0x0600E1CC RID: 57804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1CC")]
		[Address(RVA = "0x5507C0", Offset = "0x54F3C0", VA = "0x1805507C0")]
		public void TriggerPrintOnDiscreteTile(GridPosition pos)
		{
		}

		// Token: 0x0600E1CD RID: 57805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1CD")]
		[Address(RVA = "0x54F590", Offset = "0x54E190", VA = "0x18054F590")]
		public void SetCanChargePrintTimer(bool value)
		{
		}

		// Token: 0x0600E1CE RID: 57806 RVA: 0x00051E40 File Offset: 0x00050040
		[Token(Token = "0x600E1CE")]
		[Address(RVA = "0x550C30", Offset = "0x54F830", VA = "0x180550C30")]
		public bool WriteTileOnFarestEmptyTile(Act49SidePrintingManager.Act49SideTileType tileType, GridPosition anchorPos)
		{
			return default(bool);
		}

		// Token: 0x0600E1CF RID: 57807 RVA: 0x00051E58 File Offset: 0x00050058
		[Token(Token = "0x600E1CF")]
		[Address(RVA = "0x54D590", Offset = "0x54C190", VA = "0x18054D590")]
		public Act49SidePrintingManager.Act49SideTileType GetTileFunctionType(GridPosition pos)
		{
			return Act49SidePrintingManager.Act49SideTileType.None;
		}

		// Token: 0x0600E1D0 RID: 57808 RVA: 0x00051E70 File Offset: 0x00050070
		[Token(Token = "0x600E1D0")]
		[Address(RVA = "0x54BB50", Offset = "0x54A750", VA = "0x18054BB50")]
		public bool CheckWordTileBuildable(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E1D1 RID: 57809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E1D1")]
		[Address(RVA = "0x54D0E0", Offset = "0x54BCE0", VA = "0x18054D0E0")]
		public Enemy GetCarpTileEnemy(GridPosition pos)
		{
			return null;
		}

		// Token: 0x0600E1D2 RID: 57810 RVA: 0x00051E88 File Offset: 0x00050088
		[Token(Token = "0x600E1D2")]
		[Address(RVA = "0x54F620", Offset = "0x54E220", VA = "0x18054F620")]
		public bool SetTileFunctionType(GridPosition pos, Act49SidePrintingManager.Act49SideTileType type)
		{
			return default(bool);
		}

		// Token: 0x0600E1D3 RID: 57811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E1D3")]
		[Address(RVA = "0x54EFC0", Offset = "0x54DBC0", VA = "0x18054EFC0")]
		public string ParseTileType(Act49SidePrintingManager.Act49SideTileType tileType)
		{
			return null;
		}

		// Token: 0x0600E1D4 RID: 57812 RVA: 0x00051EA0 File Offset: 0x000500A0
		[Token(Token = "0x600E1D4")]
		[Address(RVA = "0x54D400", Offset = "0x54C000", VA = "0x18054D400")]
		public float GetPrintProgress()
		{
			return 0f;
		}

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1D5")]
		[Address(RVA = "0x54C2C0", Offset = "0x54AEC0", VA = "0x18054C2C0")]
		public void EnemyTjglyTryFindNextCharacterTile(Enemy enemy)
		{
		}

		// Token: 0x0600E1D6 RID: 57814 RVA: 0x00051EB8 File Offset: 0x000500B8
		[Token(Token = "0x600E1D6")]
		[Address(RVA = "0x54CA80", Offset = "0x54B680", VA = "0x18054CA80")]
		public bool EnemyTjglyTryLockWithTile(Enemy enemy, GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E1D7 RID: 57815 RVA: 0x00051ED0 File Offset: 0x000500D0
		[Token(Token = "0x600E1D7")]
		[Address(RVA = "0x54BCC0", Offset = "0x54A8C0", VA = "0x18054BCC0")]
		public bool EnemySsttzTryToSacrificeEnemy(Enemy source)
		{
			return default(bool);
		}

		// Token: 0x0600E1D8 RID: 57816 RVA: 0x00051EE8 File Offset: 0x000500E8
		[Token(Token = "0x600E1D8")]
		[Address(RVA = "0x5508E0", Offset = "0x54F4E0", VA = "0x1805508E0")]
		public GridPosition TryFindNearestTile(GridPosition anchor, Act49SidePrintingManager.Act49SideTileType type)
		{
			return default(GridPosition);
		}

		// Token: 0x0600E1D9 RID: 57817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1D9")]
		[Address(RVA = "0x5505D0", Offset = "0x54F1D0", VA = "0x1805505D0")]
		public void TriggerPartialPrint(GridPosition startPos)
		{
		}

		// Token: 0x0600E1DA RID: 57818 RVA: 0x00051F00 File Offset: 0x00050100
		[Token(Token = "0x600E1DA")]
		[Address(RVA = "0x54D270", Offset = "0x54BE70", VA = "0x18054D270")]
		public int GetCharacterTileMoveCost(GridPosition pos)
		{
			return 0;
		}

		// Token: 0x0600E1DB RID: 57819 RVA: 0x00051F18 File Offset: 0x00050118
		[Token(Token = "0x600E1DB")]
		[Address(RVA = "0x54D4C0", Offset = "0x54C0C0", VA = "0x18054D4C0")]
		public float GetPrintingProgress()
		{
			return 0f;
		}

		// Token: 0x0600E1DC RID: 57820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1DC")]
		[Address(RVA = "0x54F310", Offset = "0x54DF10", VA = "0x18054F310")]
		public void PlaySsttzLockEffect(GridPosition pos)
		{
		}

		// Token: 0x0600E1DD RID: 57821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1DD")]
		[Address(RVA = "0x54CC90", Offset = "0x54B890", VA = "0x18054CC90")]
		public void FinishSsttzLockEffect()
		{
		}

		// Token: 0x0600E1DE RID: 57822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1DE")]
		[Address(RVA = "0x554C20", Offset = "0x553820", VA = "0x180554C20")]
		private void _Print()
		{
		}

		// Token: 0x0600E1DF RID: 57823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1DF")]
		[Address(RVA = "0x553A30", Offset = "0x552630", VA = "0x180553A30")]
		private void _PartialPrint(GridPosition startPos)
		{
		}

		// Token: 0x0600E1E0 RID: 57824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1E0")]
		[Address(RVA = "0x552D30", Offset = "0x551930", VA = "0x180552D30")]
		private void _FinishPrint()
		{
		}

		// Token: 0x0600E1E1 RID: 57825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1E1")]
		[Address(RVA = "0x552C10", Offset = "0x551810", VA = "0x180552C10")]
		private void _FinishPartialPrint()
		{
		}

		// Token: 0x0600E1E2 RID: 57826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1E2")]
		[Address(RVA = "0x554300", Offset = "0x552F00", VA = "0x180554300")]
		private void _PrepareForPrinting()
		{
		}

		// Token: 0x0600E1E3 RID: 57827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1E3")]
		[Address(RVA = "0x553C40", Offset = "0x552840", VA = "0x180553C40")]
		private void _PrepareForPartialPrinting(GridPosition startPos)
		{
		}

		// Token: 0x0600E1E4 RID: 57828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1E4")]
		[Address(RVA = "0x553130", Offset = "0x551D30", VA = "0x180553130")]
		private void _InitValidPartialPrintRegion(GridPosition startPos)
		{
		}

		// Token: 0x0600E1E5 RID: 57829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1E5")]
		[Address(RVA = "0x553BA0", Offset = "0x5527A0", VA = "0x180553BA0")]
		private void _PlayPrintEffect(bool isPartialPrint = false)
		{
		}

		// Token: 0x0600E1E6 RID: 57830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E1E6")]
		[Address(RVA = "0x552B30", Offset = "0x551730", VA = "0x180552B30")]
		private IEnumerator _DoPrint(float delay)
		{
			return null;
		}

		// Token: 0x0600E1E7 RID: 57831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E1E7")]
		[Address(RVA = "0x552A50", Offset = "0x551650", VA = "0x180552A50")]
		private IEnumerator _DoPartialPrint(float delay)
		{
			return null;
		}

		// Token: 0x0600E1E8 RID: 57832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1E8")]
		[Address(RVA = "0x552950", Offset = "0x551550", VA = "0x180552950")]
		private void _DoLatePrint()
		{
		}

		// Token: 0x0600E1E9 RID: 57833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1E9")]
		[Address(RVA = "0x552850", Offset = "0x551450", VA = "0x180552850")]
		private void _DoLatePartialPrint()
		{
		}

		// Token: 0x0600E1EA RID: 57834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1EA")]
		[Address(RVA = "0x551020", Offset = "0x54FC20", VA = "0x180551020")]
		private void _ActiveNewCreatedBaiziTrap()
		{
		}

		// Token: 0x0600E1EB RID: 57835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1EB")]
		[Address(RVA = "0x5513C0", Offset = "0x54FFC0", VA = "0x1805513C0")]
		private void _ApplyPrintDamage(Entity target, bool toCharacter)
		{
		}

		// Token: 0x0600E1EC RID: 57836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1EC")]
		[Address(RVA = "0x555FC0", Offset = "0x554BC0", VA = "0x180555FC0")]
		private void _UpdatePrintStates()
		{
		}

		// Token: 0x0600E1ED RID: 57837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1ED")]
		[Address(RVA = "0x555660", Offset = "0x554260", VA = "0x180555660")]
		private void _UpdatePartialPrintStates()
		{
		}

		// Token: 0x0600E1EE RID: 57838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1EE")]
		[Address(RVA = "0x551860", Offset = "0x550460", VA = "0x180551860")]
		private void _CheckConnection(Tile tile)
		{
		}

		// Token: 0x0600E1EF RID: 57839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1EF")]
		[Address(RVA = "0x554D80", Offset = "0x553980", VA = "0x180554D80")]
		private void _RebuildCharacterOnTile(Character target, Tile targetTile)
		{
		}

		// Token: 0x0600E1F0 RID: 57840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1F0")]
		[Address(RVA = "0x5520F0", Offset = "0x550CF0", VA = "0x1805520F0")]
		private void _DealAnchorTileFunc()
		{
		}

		// Token: 0x0600E1F1 RID: 57841 RVA: 0x00051F30 File Offset: 0x00050130
		[Token(Token = "0x600E1F1")]
		[Address(RVA = "0x551D20", Offset = "0x550920", VA = "0x180551D20")]
		private bool _CheckEnemyTjglyMovableTile(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E1F2 RID: 57842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1F2")]
		[Address(RVA = "0x555400", Offset = "0x554000", VA = "0x180555400")]
		private void _SummonCampTileEnemy(GridPosition startPos)
		{
		}

		// Token: 0x0600E1F3 RID: 57843 RVA: 0x00051F48 File Offset: 0x00050148
		[Token(Token = "0x600E1F3")]
		[Address(RVA = "0x5515D0", Offset = "0x5501D0", VA = "0x1805515D0")]
		private float _CalculateEnemyTjglyTileWeight(GridPosition pos, GridPosition targetPos)
		{
			return 0f;
		}

		// Token: 0x0600E1F4 RID: 57844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1F4")]
		[Address(RVA = "0x551F30", Offset = "0x550B30", VA = "0x180551F30")]
		private void _CreateTjglyMoveEffect(Vector3 mapPos, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600E1F5 RID: 57845 RVA: 0x00051F60 File Offset: 0x00050160
		[Token(Token = "0x600E1F5")]
		[Address(RVA = "0x54E3E0", Offset = "0x54CFE0", VA = "0x18054E3E0")]
		public static bool IsValidPrintDmgTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600E1F6 RID: 57846 RVA: 0x00051F78 File Offset: 0x00050178
		[Token(Token = "0x600E1F6")]
		[Address(RVA = "0x555220", Offset = "0x553E20", VA = "0x180555220")]
		private bool _ShouldTriggerConnectionCheck(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600E1F7 RID: 57847 RVA: 0x00051F90 File Offset: 0x00050190
		[Token(Token = "0x600E1F7")]
		[Address(RVA = "0x555030", Offset = "0x553C30", VA = "0x180555030")]
		private bool _ShouldStopConnectionCheck(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600E1F8 RID: 57848 RVA: 0x00051FA8 File Offset: 0x000501A8
		[Token(Token = "0x600E1F8")]
		[Address(RVA = "0x553720", Offset = "0x552320", VA = "0x180553720")]
		private bool _IsSpecialTrap(Trap trap)
		{
			return default(bool);
		}

		// Token: 0x0600E1F9 RID: 57849 RVA: 0x00051FC0 File Offset: 0x000501C0
		[Token(Token = "0x600E1F9")]
		[Address(RVA = "0x553620", Offset = "0x552220", VA = "0x180553620")]
		private bool _IsSpecialEnemy(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600E1FA RID: 57850 RVA: 0x00051FD8 File Offset: 0x000501D8
		[Token(Token = "0x600E1FA")]
		[Address(RVA = "0x553510", Offset = "0x552110", VA = "0x180553510")]
		private static bool _IsCharacter(Character target)
		{
			return default(bool);
		}

		// Token: 0x0600E1FB RID: 57851 RVA: 0x00051FF0 File Offset: 0x000501F0
		[Token(Token = "0x600E1FB")]
		[Address(RVA = "0x553870", Offset = "0x552470", VA = "0x180553870")]
		private static bool _IsToken(Character target)
		{
			return default(bool);
		}

		// Token: 0x0600E1FC RID: 57852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1FC")]
		[Address(RVA = "0x556960", Offset = "0x555560", VA = "0x180556960")]
		public Act49SidePrintingManager()
		{
		}

		// Token: 0x0600E1FE RID: 57854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E1FE")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E1FF RID: 57855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E1FF")]
		[Address(RVA = "0x550BB0", Offset = "0x54F7B0", VA = "0x180550BB0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0600E200 RID: 57856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E200")]
		[Address(RVA = "0x550BC0", Offset = "0x54F7C0", VA = "0x180550BC0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0600E201 RID: 57857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E201")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600E202 RID: 57858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E202")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E203 RID: 57859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E203")]
		[Address(RVA = "0x550BF0", Offset = "0x54F7F0", VA = "0x180550BF0")]
		private void <>xLuaBaseProxy_OnEnvDestroy()
		{
		}

		// Token: 0x0600E204 RID: 57860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E204")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E205 RID: 57861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E205")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400F731 RID: 63281
		[Token(Token = "0x400F731")]
		[FieldOffset(Offset = "0x28")]
		public readonly List<string> noneBuildableUnitList;

		// Token: 0x0400F732 RID: 63282
		[Token(Token = "0x400F732")]
		[FieldOffset(Offset = "0x30")]
		public readonly List<string> act49sideSpecialTrapList;

		// Token: 0x0400F733 RID: 63283
		[Token(Token = "0x400F733")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string EVENT_SYSTEM_KEY;

		// Token: 0x0400F734 RID: 63284
		[Token(Token = "0x400F734")]
		public const int CHARACTER_TILE_ADJUSTABLE_MOVECOST = 1000;

		// Token: 0x0400F735 RID: 63285
		[Token(Token = "0x400F735")]
		private const float MAX_WEIGHT = 10000000f;

		// Token: 0x0400F736 RID: 63286
		[Token(Token = "0x400F736")]
		private const float DISTANCE_TINT = 1000f;

		// Token: 0x0400F737 RID: 63287
		[Token(Token = "0x400F737")]
		private const float TILE_EMPTY_WEIGHT_OFFSET = 1f;

		// Token: 0x0400F738 RID: 63288
		[Token(Token = "0x400F738")]
		private const float TILE_NONE_WEIGHT_OFFSET = 100f;

		// Token: 0x0400F739 RID: 63289
		[Token(Token = "0x400F739")]
		private const string ENEMY_TJGXB_ID = "enemy_10164_tjgxb";

		// Token: 0x0400F73A RID: 63290
		[Token(Token = "0x400F73A")]
		private const string ENEMY_TJGXB_ID_2 = "enemy_10164_tjgxb_2";

		// Token: 0x0400F73B RID: 63291
		[Token(Token = "0x400F73B")]
		private const string ENEMY_TJGLB_ID = "enemy_3013_tjglb";

		// Token: 0x0400F73C RID: 63292
		[Token(Token = "0x400F73C")]
		private const string ENEMY_TJGCB_ID = "enemy_3012_tjgcb";

		// Token: 0x0400F73D RID: 63293
		[Token(Token = "0x400F73D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _printFuncDelay;

		// Token: 0x0400F73E RID: 63294
		[Token(Token = "0x400F73E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _characterTileKey;

		// Token: 0x0400F73F RID: 63295
		[Token(Token = "0x400F73F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _characterTileTypeKey;

		// Token: 0x0400F740 RID: 63296
		[Token(Token = "0x400F740")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _printDmgToEnemyKey;

		// Token: 0x0400F741 RID: 63297
		[Token(Token = "0x400F741")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _printDmgToAllyKey;

		// Token: 0x0400F742 RID: 63298
		[Token(Token = "0x400F742")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _printSpKey;

		// Token: 0x0400F743 RID: 63299
		[Token(Token = "0x400F743")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _printInitialSpKey;

		// Token: 0x0400F744 RID: 63300
		[Token(Token = "0x400F744")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<string> _enemyAbleToBlockPrintingKeys;

		// Token: 0x0400F745 RID: 63301
		[Token(Token = "0x400F745")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<string> _entityAbleToBlockPrintDmgKeys;

		// Token: 0x0400F746 RID: 63302
		[Token(Token = "0x400F746")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _enemyCampTileRuneKey;

		// Token: 0x0400F747 RID: 63303
		[Token(Token = "0x400F747")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _enemyCampTileKey;

		// Token: 0x0400F748 RID: 63304
		[Token(Token = "0x400F748")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _enemyCampTileSummonCountKey;

		// Token: 0x0400F749 RID: 63305
		[Token(Token = "0x400F749")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private int _enemyCampTileSummonCount;

		// Token: 0x0400F74A RID: 63306
		[Token(Token = "0x400F74A")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _enemyCampTileSummonInterval;

		// Token: 0x0400F74B RID: 63307
		[Token(Token = "0x400F74B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _enemyFoodTileKey;

		// Token: 0x0400F74C RID: 63308
		[Token(Token = "0x400F74C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _enemyFoodTileSummonCountKey;

		// Token: 0x0400F74D RID: 63309
		[Token(Token = "0x400F74D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int _enemyFoodTileSummonCount;

		// Token: 0x0400F74E RID: 63310
		[Token(Token = "0x400F74E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _enemyFortuneTileKey;

		// Token: 0x0400F74F RID: 63311
		[Token(Token = "0x400F74F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _enemyFortuneTileSummonCountKey;

		// Token: 0x0400F750 RID: 63312
		[Token(Token = "0x400F750")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int _enemyFortuneTileSummonCount;

		// Token: 0x0400F751 RID: 63313
		[Token(Token = "0x400F751")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private string _trapHighlandKey;

		// Token: 0x0400F752 RID: 63314
		[Token(Token = "0x400F752")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private string _trapWhiteStoneKey;

		// Token: 0x0400F753 RID: 63315
		[Token(Token = "0x400F753")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private string _charYinInitialSPKey;

		// Token: 0x0400F754 RID: 63316
		[Token(Token = "0x400F754")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _charYinInitialSP;

		// Token: 0x0400F755 RID: 63317
		[Token(Token = "0x400F755")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _charYinSPKey;

		// Token: 0x0400F756 RID: 63318
		[Token(Token = "0x400F756")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private float _charYinSP;

		// Token: 0x0400F757 RID: 63319
		[Token(Token = "0x400F757")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private string _charYinChargeValueKey;

		// Token: 0x0400F758 RID: 63320
		[Token(Token = "0x400F758")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float _charYinChargeValue;

		// Token: 0x0400F759 RID: 63321
		[Token(Token = "0x400F759")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private string _printDmgAtkScaleBuffKey;

		// Token: 0x0400F75A RID: 63322
		[Token(Token = "0x400F75A")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _printDmgAtkScaleBBKey;

		// Token: 0x0400F75B RID: 63323
		[Token(Token = "0x400F75B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private string _printDmgCustomKey;

		// Token: 0x0400F75C RID: 63324
		[Token(Token = "0x400F75C")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private BuffData _enterTileMarkBuff;

		// Token: 0x0400F75D RID: 63325
		[Token(Token = "0x400F75D")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private BuffData _buffToCarpEnemy;

		// Token: 0x0400F75E RID: 63326
		[Token(Token = "0x400F75E")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private BuffData _buffToCarpEnemyShort;

		// Token: 0x0400F75F RID: 63327
		[Token(Token = "0x400F75F")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private List<string> _entityAbleToReceivePrintingSignal;

		// Token: 0x0400F760 RID: 63328
		[Token(Token = "0x400F760")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private BuffData _markBuffOfPrintingStart;

		// Token: 0x0400F761 RID: 63329
		[Token(Token = "0x400F761")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private BuffData _markBuffOfPrintingEnd;

		// Token: 0x0400F762 RID: 63330
		[Token(Token = "0x400F762")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private BuffData _baiziTrapActiveBuff;

		// Token: 0x0400F763 RID: 63331
		[Token(Token = "0x400F763")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("SacrificeBuff")]
		private BuffData _enemyTjgxbScarificeBuff;

		// Token: 0x0400F764 RID: 63332
		[Token(Token = "0x400F764")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("SacrificeBuff")]
		private BuffData _enemyTjglbScarificeBuff;

		// Token: 0x0400F765 RID: 63333
		[Token(Token = "0x400F765")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("SacrificeBuff")]
		private BuffData _enemyTjgcbScarificeBuff;

		// Token: 0x0400F766 RID: 63334
		[Token(Token = "0x400F766")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Effects")]
		private string _effectCampTileKey;

		// Token: 0x0400F767 RID: 63335
		[Token(Token = "0x400F767")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Effects")]
		private string _effectFoodTileKey;

		// Token: 0x0400F768 RID: 63336
		[Token(Token = "0x400F768")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Effects")]
		private string _effectFortuneTileKey;

		// Token: 0x0400F769 RID: 63337
		[Token(Token = "0x400F769")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("Effects")]
		private string _effectHighlandTileKey;

		// Token: 0x0400F76A RID: 63338
		[Token(Token = "0x400F76A")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Effects")]
		private string _effectTriggerTileKeyCoolDown;

		// Token: 0x0400F76B RID: 63339
		[Token(Token = "0x400F76B")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("Effects")]
		private string _effectTriggerTileKeyReady;

		// Token: 0x0400F76C RID: 63340
		[Token(Token = "0x400F76C")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("Effects")]
		private string _effectAnchorTileKey;

		// Token: 0x0400F76D RID: 63341
		[Token(Token = "0x400F76D")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Group("Effects")]
		private string _effectCarpTileKey;

		// Token: 0x0400F76E RID: 63342
		[Token(Token = "0x400F76E")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[Group("Effects")]
		private string _effectEmptyTileKey;

		// Token: 0x0400F76F RID: 63343
		[Token(Token = "0x400F76F")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		[Group("Effects")]
		private string _effectPrintKey;

		// Token: 0x0400F770 RID: 63344
		[Token(Token = "0x400F770")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("Effects")]
		private string _effectPrintKeyInactive;

		// Token: 0x0400F771 RID: 63345
		[Token(Token = "0x400F771")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("Effects")]
		private string _effectTjglyMove;

		// Token: 0x0400F772 RID: 63346
		[Token(Token = "0x400F772")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("Effects")]
		private string _effectSsttzLock;

		// Token: 0x0400F773 RID: 63347
		[Token(Token = "0x400F773")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("audio")]
		private string _tjglyMove;

		// Token: 0x0400F774 RID: 63348
		[Token(Token = "0x400F774")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("audio")]
		private string _printFuncActive;

		// Token: 0x0400F775 RID: 63349
		[Token(Token = "0x400F775")]
		[FieldOffset(Offset = "0x1F0")]
		private Dictionary<GridPosition, Act49SidePrintingManager.Act49SideAddOnTileFunction> m_tileFuncDict;

		// Token: 0x0400F776 RID: 63350
		[Token(Token = "0x400F776")]
		[FieldOffset(Offset = "0x1F8")]
		private HashSet<GridPosition> m_partialPrintTileSet;

		// Token: 0x0400F777 RID: 63351
		[Token(Token = "0x400F777")]
		[FieldOffset(Offset = "0x200")]
		private Dictionary<string, float> m_enemySacrificableWithPriority;

		// Token: 0x0400F778 RID: 63352
		[Token(Token = "0x400F778")]
		[FieldOffset(Offset = "0x208")]
		private PeriodicTimer m_printTimer;

		// Token: 0x0400F779 RID: 63353
		[Token(Token = "0x400F779")]
		[FieldOffset(Offset = "0x210")]
		private PeriodicTimer m_printProgressTimer;

		// Token: 0x0400F77A RID: 63354
		[Token(Token = "0x400F77A")]
		[FieldOffset(Offset = "0x218")]
		private PeriodicTimer m_partialPrintProgressTimer;

		// Token: 0x0400F77B RID: 63355
		[Token(Token = "0x400F77B")]
		[FieldOffset(Offset = "0x220")]
		private PeriodicTimer m_triggerTileTimer;

		// Token: 0x0400F77C RID: 63356
		[Token(Token = "0x400F77C")]
		[FieldOffset(Offset = "0x228")]
		private PeriodicTimer m_summonCampTileEnemyTimer;

		// Token: 0x0400F77D RID: 63357
		[Token(Token = "0x400F77D")]
		[FieldOffset(Offset = "0x230")]
		private FP m_printDmgToEnemy;

		// Token: 0x0400F77E RID: 63358
		[Token(Token = "0x400F77E")]
		[FieldOffset(Offset = "0x238")]
		private FP m_printDmgToAlly;

		// Token: 0x0400F77F RID: 63359
		[Token(Token = "0x400F77F")]
		[FieldOffset(Offset = "0x240")]
		private int m_enemyCampTileSummonCount;

		// Token: 0x0400F780 RID: 63360
		[Token(Token = "0x400F780")]
		[FieldOffset(Offset = "0x244")]
		private int m_enemyFoodTileSummonCount;

		// Token: 0x0400F781 RID: 63361
		[Token(Token = "0x400F781")]
		[FieldOffset(Offset = "0x248")]
		private int m_enemyFortuneTileSummonCount;

		// Token: 0x0400F782 RID: 63362
		[Token(Token = "0x400F782")]
		[FieldOffset(Offset = "0x250")]
		private Queue<GridPosition> m_campTileEnemyStartPos;

		// Token: 0x0400F783 RID: 63363
		[Token(Token = "0x400F783")]
		[FieldOffset(Offset = "0x258")]
		private float m_printSp;

		// Token: 0x0400F784 RID: 63364
		[Token(Token = "0x400F784")]
		[FieldOffset(Offset = "0x25C")]
		private float m_printInitialSp;

		// Token: 0x0400F785 RID: 63365
		[Token(Token = "0x400F785")]
		[FieldOffset(Offset = "0x260")]
		private float m_charYinInitialSP;

		// Token: 0x0400F786 RID: 63366
		[Token(Token = "0x400F786")]
		[FieldOffset(Offset = "0x264")]
		private float m_charYinSP;

		// Token: 0x0400F787 RID: 63367
		[Token(Token = "0x400F787")]
		[FieldOffset(Offset = "0x268")]
		private float m_charYinChargeValue;

		// Token: 0x0400F788 RID: 63368
		[Token(Token = "0x400F788")]
		[FieldOffset(Offset = "0x26C")]
		private float m_printDuration;

		// Token: 0x0400F789 RID: 63369
		[Token(Token = "0x400F789")]
		[FieldOffset(Offset = "0x270")]
		private bool m_exposedPrintChargeFlag;

		// Token: 0x0400F78A RID: 63370
		[Token(Token = "0x400F78A")]
		[FieldOffset(Offset = "0x271")]
		private bool m_isDuringPrinting;

		// Token: 0x0400F78B RID: 63371
		[Token(Token = "0x400F78B")]
		[FieldOffset(Offset = "0x272")]
		private bool m_isDuringPartialPrinting;

		// Token: 0x0400F78C RID: 63372
		[Token(Token = "0x400F78C")]
		[FieldOffset(Offset = "0x273")]
		private bool m_enemyTjglyFindingPath;

		// Token: 0x0400F78D RID: 63373
		[Token(Token = "0x400F78D")]
		[FieldOffset(Offset = "0x278")]
		private List<Act49SidePrintingManager.Act49SideAnchorTileFunction> m_valideAnchorTileFuncForNextPrint;

		// Token: 0x0400F78E RID: 63374
		[Token(Token = "0x400F78E")]
		[FieldOffset(Offset = "0x280")]
		private List<Act49SidePrintingManager.Act49SideAnchorInfo> m_anchorInfos;

		// Token: 0x0400F78F RID: 63375
		[Token(Token = "0x400F78F")]
		[FieldOffset(Offset = "0x288")]
		private string m_campTileSummonEnemyKey;

		// Token: 0x0400F790 RID: 63376
		[Token(Token = "0x400F790")]
		[FieldOffset(Offset = "0x290")]
		private Act49SidePrintingManager.Act49sideBuildableChecker m_buildableChecker;

		// Token: 0x0400F791 RID: 63377
		[Token(Token = "0x400F791")]
		[FieldOffset(Offset = "0x298")]
		private Route.Node[,] m_nextMap;

		// Token: 0x0400F792 RID: 63378
		[Token(Token = "0x400F792")]
		[FieldOffset(Offset = "0x2A0")]
		private SPFA m_enemyTjglyPathFinder;

		// Token: 0x0400F793 RID: 63379
		[Token(Token = "0x400F793")]
		[FieldOffset(Offset = "0x2A8")]
		private Act49SidePrintingManager.PrintEffectManager m_printEffectMgr;

		// Token: 0x0400F794 RID: 63380
		[Token(Token = "0x400F794")]
		[FieldOffset(Offset = "0x2B0")]
		private Effect m_ssttzLockEffect;

		// Token: 0x0400F795 RID: 63381
		[Token(Token = "0x400F795")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F796 RID: 63382
		[Token(Token = "0x400F796")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_campTileTrapKey;

		// Token: 0x0400F797 RID: 63383
		[Token(Token = "0x400F797")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_fortuneTileTrapKey;

		// Token: 0x0400F798 RID: 63384
		[Token(Token = "0x400F798")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_foodTileTrapKey;

		// Token: 0x0400F799 RID: 63385
		[Token(Token = "0x400F799")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_highlandTileTrapKey;

		// Token: 0x0400F79A RID: 63386
		[Token(Token = "0x400F79A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_anchorTileTrapKey;

		// Token: 0x0400F79B RID: 63387
		[Token(Token = "0x400F79B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_triggerTileTrapKey;

		// Token: 0x0400F79C RID: 63388
		[Token(Token = "0x400F79C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_canChargePrint;

		// Token: 0x0400F79D RID: 63389
		[Token(Token = "0x400F79D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_charYinChargeValue;

		// Token: 0x0400F79E RID: 63390
		[Token(Token = "0x400F79E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_campTileSummonEnemyKey;

		// Token: 0x0400F79F RID: 63391
		[Token(Token = "0x400F79F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0400F7A0 RID: 63392
		[Token(Token = "0x400F7A0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400F7A1 RID: 63393
		[Token(Token = "0x400F7A1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F7A2 RID: 63394
		[Token(Token = "0x400F7A2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F7A3 RID: 63395
		[Token(Token = "0x400F7A3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnEnvDestroy;

		// Token: 0x0400F7A4 RID: 63396
		[Token(Token = "0x400F7A4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F7A5 RID: 63397
		[Token(Token = "0x400F7A5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400F7A6 RID: 63398
		[Token(Token = "0x400F7A6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ChargePrintTimer;

		// Token: 0x0400F7A7 RID: 63399
		[Token(Token = "0x400F7A7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ResetTriggerTileTimer;

		// Token: 0x0400F7A8 RID: 63400
		[Token(Token = "0x400F7A8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsTriggerTileTimerReady;

		// Token: 0x0400F7A9 RID: 63401
		[Token(Token = "0x400F7A9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TriggerPrintOnDiscreteTile;

		// Token: 0x0400F7AA RID: 63402
		[Token(Token = "0x400F7AA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetCanChargePrintTimer;

		// Token: 0x0400F7AB RID: 63403
		[Token(Token = "0x400F7AB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_WriteTileOnFarestEmptyTile;

		// Token: 0x0400F7AC RID: 63404
		[Token(Token = "0x400F7AC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetTileFunctionType;

		// Token: 0x0400F7AD RID: 63405
		[Token(Token = "0x400F7AD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CheckWordTileBuildable;

		// Token: 0x0400F7AE RID: 63406
		[Token(Token = "0x400F7AE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetCarpTileEnemy;

		// Token: 0x0400F7AF RID: 63407
		[Token(Token = "0x400F7AF")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SetTileFunctionType;

		// Token: 0x0400F7B0 RID: 63408
		[Token(Token = "0x400F7B0")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ParseTileType;

		// Token: 0x0400F7B1 RID: 63409
		[Token(Token = "0x400F7B1")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetPrintProgress;

		// Token: 0x0400F7B2 RID: 63410
		[Token(Token = "0x400F7B2")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_EnemyTjglyTryFindNextCharacterTile;

		// Token: 0x0400F7B3 RID: 63411
		[Token(Token = "0x400F7B3")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_EnemyTjglyTryLockWithTile;

		// Token: 0x0400F7B4 RID: 63412
		[Token(Token = "0x400F7B4")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_EnemySsttzTryToSacrificeEnemy;

		// Token: 0x0400F7B5 RID: 63413
		[Token(Token = "0x400F7B5")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_TryFindNearestTile;

		// Token: 0x0400F7B6 RID: 63414
		[Token(Token = "0x400F7B6")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_TriggerPartialPrint;

		// Token: 0x0400F7B7 RID: 63415
		[Token(Token = "0x400F7B7")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetCharacterTileMoveCost;

		// Token: 0x0400F7B8 RID: 63416
		[Token(Token = "0x400F7B8")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetPrintingProgress;

		// Token: 0x0400F7B9 RID: 63417
		[Token(Token = "0x400F7B9")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_PlaySsttzLockEffect;

		// Token: 0x0400F7BA RID: 63418
		[Token(Token = "0x400F7BA")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_FinishSsttzLockEffect;

		// Token: 0x0400F7BB RID: 63419
		[Token(Token = "0x400F7BB")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__Print;

		// Token: 0x0400F7BC RID: 63420
		[Token(Token = "0x400F7BC")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__PartialPrint;

		// Token: 0x0400F7BD RID: 63421
		[Token(Token = "0x400F7BD")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__FinishPrint;

		// Token: 0x0400F7BE RID: 63422
		[Token(Token = "0x400F7BE")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__FinishPartialPrint;

		// Token: 0x0400F7BF RID: 63423
		[Token(Token = "0x400F7BF")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__PrepareForPrinting;

		// Token: 0x0400F7C0 RID: 63424
		[Token(Token = "0x400F7C0")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__PrepareForPartialPrinting;

		// Token: 0x0400F7C1 RID: 63425
		[Token(Token = "0x400F7C1")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__InitValidPartialPrintRegion;

		// Token: 0x0400F7C2 RID: 63426
		[Token(Token = "0x400F7C2")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__PlayPrintEffect;

		// Token: 0x0400F7C3 RID: 63427
		[Token(Token = "0x400F7C3")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__DoPrint;

		// Token: 0x0400F7C4 RID: 63428
		[Token(Token = "0x400F7C4")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__DoPartialPrint;

		// Token: 0x0400F7C5 RID: 63429
		[Token(Token = "0x400F7C5")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__DoLatePrint;

		// Token: 0x0400F7C6 RID: 63430
		[Token(Token = "0x400F7C6")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__DoLatePartialPrint;

		// Token: 0x0400F7C7 RID: 63431
		[Token(Token = "0x400F7C7")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__ActiveNewCreatedBaiziTrap;

		// Token: 0x0400F7C8 RID: 63432
		[Token(Token = "0x400F7C8")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__ApplyPrintDamage;

		// Token: 0x0400F7C9 RID: 63433
		[Token(Token = "0x400F7C9")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__UpdatePrintStates;

		// Token: 0x0400F7CA RID: 63434
		[Token(Token = "0x400F7CA")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__UpdatePartialPrintStates;

		// Token: 0x0400F7CB RID: 63435
		[Token(Token = "0x400F7CB")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__CheckConnection;

		// Token: 0x0400F7CC RID: 63436
		[Token(Token = "0x400F7CC")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__RebuildCharacterOnTile;

		// Token: 0x0400F7CD RID: 63437
		[Token(Token = "0x400F7CD")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__DealAnchorTileFunc;

		// Token: 0x0400F7CE RID: 63438
		[Token(Token = "0x400F7CE")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__CheckEnemyTjglyMovableTile;

		// Token: 0x0400F7CF RID: 63439
		[Token(Token = "0x400F7CF")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__SummonCampTileEnemy;

		// Token: 0x0400F7D0 RID: 63440
		[Token(Token = "0x400F7D0")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__CalculateEnemyTjglyTileWeight;

		// Token: 0x0400F7D1 RID: 63441
		[Token(Token = "0x400F7D1")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__CreateTjglyMoveEffect;

		// Token: 0x0400F7D2 RID: 63442
		[Token(Token = "0x400F7D2")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_IsValidPrintDmgTarget;

		// Token: 0x0400F7D3 RID: 63443
		[Token(Token = "0x400F7D3")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__ShouldTriggerConnectionCheck;

		// Token: 0x0400F7D4 RID: 63444
		[Token(Token = "0x400F7D4")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__ShouldStopConnectionCheck;

		// Token: 0x0400F7D5 RID: 63445
		[Token(Token = "0x400F7D5")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__IsSpecialTrap;

		// Token: 0x0400F7D6 RID: 63446
		[Token(Token = "0x400F7D6")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__IsSpecialEnemy;

		// Token: 0x0400F7D7 RID: 63447
		[Token(Token = "0x400F7D7")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__IsCharacter;

		// Token: 0x0400F7D8 RID: 63448
		[Token(Token = "0x400F7D8")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__IsToken;

		// Token: 0x0400F7D9 RID: 63449
		[Token(Token = "0x400F7D9")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022EF RID: 8943
		[Token(Token = "0x20022EF")]
		public enum Act49SideTileType
		{
			// Token: 0x0400F7DB RID: 63451
			[Token(Token = "0x400F7DB")]
			None,
			// Token: 0x0400F7DC RID: 63452
			[Token(Token = "0x400F7DC")]
			Pure,
			// Token: 0x0400F7DD RID: 63453
			[Token(Token = "0x400F7DD")]
			Empty,
			// Token: 0x0400F7DE RID: 63454
			[Token(Token = "0x400F7DE")]
			Fortune,
			// Token: 0x0400F7DF RID: 63455
			[Token(Token = "0x400F7DF")]
			Food,
			// Token: 0x0400F7E0 RID: 63456
			[Token(Token = "0x400F7E0")]
			Camp,
			// Token: 0x0400F7E1 RID: 63457
			[Token(Token = "0x400F7E1")]
			Highland,
			// Token: 0x0400F7E2 RID: 63458
			[Token(Token = "0x400F7E2")]
			Anchor,
			// Token: 0x0400F7E3 RID: 63459
			[Token(Token = "0x400F7E3")]
			Trigger,
			// Token: 0x0400F7E4 RID: 63460
			[Token(Token = "0x400F7E4")]
			Carp
		}

		// Token: 0x020022F0 RID: 8944
		[Token(Token = "0x20022F0")]
		public class Act49SideTileListener : ITileListener
		{
			// Token: 0x0600E206 RID: 57862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E206")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public Act49SideTileListener(Act49SidePrintingManager.Act49SideAddOnTileFunction func)
			{
			}

			// Token: 0x0600E207 RID: 57863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E207")]
			[Address(RVA = "0x557C50", Offset = "0x556850", VA = "0x180557C50", Slot = "7")]
			public virtual void OnEntityEnter(Entity entity)
			{
			}

			// Token: 0x0600E208 RID: 57864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E208")]
			[Address(RVA = "0x557CA0", Offset = "0x5568A0", VA = "0x180557CA0", Slot = "8")]
			public virtual void OnEntityLeave(Entity entity)
			{
			}

			// Token: 0x0600E209 RID: 57865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E209")]
			[Address(RVA = "0x557CF0", Offset = "0x5568F0", VA = "0x180557CF0", Slot = "9")]
			public virtual void OnLocatedCharacterUpdate(Character character)
			{
			}

			// Token: 0x0400F7E5 RID: 63461
			[Token(Token = "0x400F7E5")]
			[FieldOffset(Offset = "0x10")]
			protected Act49SidePrintingManager.Act49SideAddOnTileFunction m_tileFunc;
		}

		// Token: 0x020022F1 RID: 8945
		[Token(Token = "0x20022F1")]
		private struct Act49SideAnchorInfo : IComparable<Act49SidePrintingManager.Act49SideAnchorInfo>
		{
			// Token: 0x0600E20A RID: 57866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E20A")]
			[Address(RVA = "0x54A9A0", Offset = "0x5495A0", VA = "0x18054A9A0")]
			public Act49SideAnchorInfo(float distance, Character character, GridPosition pos)
			{
			}

			// Token: 0x0600E20B RID: 57867 RVA: 0x00052008 File Offset: 0x00050208
			[Token(Token = "0x600E20B")]
			[Address(RVA = "0x54A7A0", Offset = "0x5493A0", VA = "0x18054A7A0", Slot = "4")]
			public int CompareTo(Act49SidePrintingManager.Act49SideAnchorInfo other)
			{
				return 0;
			}

			// Token: 0x0400F7E6 RID: 63462
			[Token(Token = "0x400F7E6")]
			[FieldOffset(Offset = "0x0")]
			public float distance;

			// Token: 0x0400F7E7 RID: 63463
			[Token(Token = "0x400F7E7")]
			[FieldOffset(Offset = "0x8")]
			public Character character;

			// Token: 0x0400F7E8 RID: 63464
			[Token(Token = "0x400F7E8")]
			[FieldOffset(Offset = "0x10")]
			public GridPosition anchorPos;
		}

		// Token: 0x020022F2 RID: 8946
		[Token(Token = "0x20022F2")]
		public class Act49SideAddOnTileFunction
		{
			// Token: 0x0600E20C RID: 57868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E20C")]
			[Address(RVA = "0x54A660", Offset = "0x549260", VA = "0x18054A660")]
			public Act49SideAddOnTileFunction(GridPosition pos, Act49SidePrintingManager manager)
			{
			}

			// Token: 0x0600E20D RID: 57869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E20D")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80", Slot = "4")]
			public virtual void SetActive(bool activeOrNot)
			{
			}

			// Token: 0x0600E20E RID: 57870 RVA: 0x00052020 File Offset: 0x00050220
			[Token(Token = "0x600E20E")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70", Slot = "5")]
			public virtual bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x17001C5E RID: 7262
			// (get) Token: 0x0600E20F RID: 57871 RVA: 0x00052038 File Offset: 0x00050238
			// (set) Token: 0x0600E210 RID: 57872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C5E")]
			public bool showEffect
			{
				[Token(Token = "0x600E20F")]
				[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600E210")]
				[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
				set
				{
				}
			}

			// Token: 0x17001C5F RID: 7263
			// (get) Token: 0x0600E211 RID: 57873 RVA: 0x00052050 File Offset: 0x00050250
			[Token(Token = "0x17001C5F")]
			public virtual Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E211")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E212 RID: 57874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E212")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
			public virtual void Func()
			{
			}

			// Token: 0x0600E213 RID: 57875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E213")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
			public virtual void Tick(FP deltaTime)
			{
			}

			// Token: 0x0600E214 RID: 57876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E214")]
			[Address(RVA = "0x54A4B0", Offset = "0x5490B0", VA = "0x18054A4B0", Slot = "9")]
			public virtual void Detach()
			{
			}

			// Token: 0x0600E215 RID: 57877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E215")]
			[Address(RVA = "0x54A5B0", Offset = "0x5491B0", VA = "0x18054A5B0", Slot = "10")]
			public virtual void OnLocatedCharacterUpdate(Character character)
			{
			}

			// Token: 0x0600E216 RID: 57878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E216")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
			public virtual void OnEntityEnter(Entity entity)
			{
			}

			// Token: 0x0600E217 RID: 57879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E217")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
			public virtual void OnEntityLeave(Entity entity)
			{
			}

			// Token: 0x0600E218 RID: 57880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E218")]
			[Address(RVA = "0x54A530", Offset = "0x549130", VA = "0x18054A530", Slot = "13")]
			public virtual string GetEffectKey()
			{
				return null;
			}

			// Token: 0x0400F7E9 RID: 63465
			[Token(Token = "0x400F7E9")]
			[FieldOffset(Offset = "0x10")]
			protected GridPosition m_position;

			// Token: 0x0400F7EA RID: 63466
			[Token(Token = "0x400F7EA")]
			[FieldOffset(Offset = "0x18")]
			protected bool m_active;

			// Token: 0x0400F7EB RID: 63467
			[Token(Token = "0x400F7EB")]
			[FieldOffset(Offset = "0x19")]
			protected bool m_showEffect;

			// Token: 0x0400F7EC RID: 63468
			[Token(Token = "0x400F7EC")]
			[FieldOffset(Offset = "0x20")]
			protected Tile m_tile;

			// Token: 0x0400F7ED RID: 63469
			[Token(Token = "0x400F7ED")]
			[FieldOffset(Offset = "0x28")]
			protected Act49SidePrintingManager m_manager;

			// Token: 0x0400F7EE RID: 63470
			[Token(Token = "0x400F7EE")]
			[FieldOffset(Offset = "0x30")]
			protected Effect m_effect;

			// Token: 0x0400F7EF RID: 63471
			[Token(Token = "0x400F7EF")]
			[FieldOffset(Offset = "0x38")]
			protected Act49SidePrintingManager.Act49SideTileListener m_listener;
		}

		// Token: 0x020022F3 RID: 8947
		[Token(Token = "0x20022F3")]
		public class Act49SideEmptyTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E219 RID: 57881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E219")]
			[Address(RVA = "0x54AFE0", Offset = "0x549BE0", VA = "0x18054AFE0")]
			public Act49SideEmptyTileFunction(GridPosition pos, Act49SidePrintingManager manager)
			{
			}

			// Token: 0x17001C60 RID: 7264
			// (get) Token: 0x0600E21A RID: 57882 RVA: 0x00052068 File Offset: 0x00050268
			[Token(Token = "0x17001C60")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E21A")]
				[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E21B RID: 57883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E21B")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
			public override void Func()
			{
			}
		}

		// Token: 0x020022F4 RID: 8948
		[Token(Token = "0x20022F4")]
		public class Act49SideFortuneTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E21C RID: 57884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E21C")]
			[Address(RVA = "0x54B6B0", Offset = "0x54A2B0", VA = "0x18054B6B0")]
			public Act49SideFortuneTileFunction(GridPosition pos, Act49SidePrintingManager manager)
			{
			}

			// Token: 0x17001C61 RID: 7265
			// (get) Token: 0x0600E21D RID: 57885 RVA: 0x00052080 File Offset: 0x00050280
			[Token(Token = "0x17001C61")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E21D")]
				[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E21E RID: 57886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E21E")]
			[Address(RVA = "0x54B480", Offset = "0x54A080", VA = "0x18054B480", Slot = "7")]
			public override void Func()
			{
			}

			// Token: 0x0400F7F0 RID: 63472
			[Token(Token = "0x400F7F0")]
			[FieldOffset(Offset = "0x40")]
			private GridPosition m_endPos;

			// Token: 0x0400F7F1 RID: 63473
			[Token(Token = "0x400F7F1")]
			[FieldOffset(Offset = "0x48")]
			private int m_summonCnt;
		}

		// Token: 0x020022F5 RID: 8949
		[Token(Token = "0x20022F5")]
		public class Act49SideFoodTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E21F RID: 57887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E21F")]
			[Address(RVA = "0x54B320", Offset = "0x549F20", VA = "0x18054B320")]
			public Act49SideFoodTileFunction(GridPosition pos, Act49SidePrintingManager manager)
			{
			}

			// Token: 0x17001C62 RID: 7266
			// (get) Token: 0x0600E220 RID: 57888 RVA: 0x00052098 File Offset: 0x00050298
			[Token(Token = "0x17001C62")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E220")]
				[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E221 RID: 57889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E221")]
			[Address(RVA = "0x54B0F0", Offset = "0x549CF0", VA = "0x18054B0F0", Slot = "7")]
			public override void Func()
			{
			}

			// Token: 0x0400F7F2 RID: 63474
			[Token(Token = "0x400F7F2")]
			[FieldOffset(Offset = "0x40")]
			private GridPosition m_endPos;

			// Token: 0x0400F7F3 RID: 63475
			[Token(Token = "0x400F7F3")]
			[FieldOffset(Offset = "0x48")]
			private int m_summonCnt;
		}

		// Token: 0x020022F6 RID: 8950
		[Token(Token = "0x20022F6")]
		public class Act49SideCampTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E222 RID: 57890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E222")]
			[Address(RVA = "0x54ACB0", Offset = "0x5498B0", VA = "0x18054ACB0")]
			public Act49SideCampTileFunction(GridPosition pos, Act49SidePrintingManager manager)
			{
			}

			// Token: 0x17001C63 RID: 7267
			// (get) Token: 0x0600E223 RID: 57891 RVA: 0x000520B0 File Offset: 0x000502B0
			[Token(Token = "0x17001C63")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E223")]
				[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E224 RID: 57892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E224")]
			[Address(RVA = "0x54AC40", Offset = "0x549840", VA = "0x18054AC40", Slot = "7")]
			public override void Func()
			{
			}

			// Token: 0x0400F7F4 RID: 63476
			[Token(Token = "0x400F7F4")]
			[FieldOffset(Offset = "0x40")]
			private GridPosition m_endPos;

			// Token: 0x0400F7F5 RID: 63477
			[Token(Token = "0x400F7F5")]
			[FieldOffset(Offset = "0x48")]
			private int m_summonCnt;
		}

		// Token: 0x020022F7 RID: 8951
		[Token(Token = "0x20022F7")]
		public class Act49SideHighlandTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E225 RID: 57893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E225")]
			[Address(RVA = "0x54B920", Offset = "0x54A520", VA = "0x18054B920")]
			public Act49SideHighlandTileFunction(GridPosition pos, Act49SidePrintingManager manager)
			{
			}

			// Token: 0x17001C64 RID: 7268
			// (get) Token: 0x0600E226 RID: 57894 RVA: 0x000520C8 File Offset: 0x000502C8
			[Token(Token = "0x17001C64")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E226")]
				[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E227 RID: 57895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E227")]
			[Address(RVA = "0x54B810", Offset = "0x54A410", VA = "0x18054B810", Slot = "7")]
			public override void Func()
			{
			}
		}

		// Token: 0x020022F8 RID: 8952
		[Token(Token = "0x20022F8")]
		public class Act49SideAnchorTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E228 RID: 57896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E228")]
			[Address(RVA = "0x54AB30", Offset = "0x549730", VA = "0x18054AB30")]
			public Act49SideAnchorTileFunction(GridPosition pos, Act49SidePrintingManager manager)
			{
			}

			// Token: 0x17001C65 RID: 7269
			// (get) Token: 0x0600E229 RID: 57897 RVA: 0x000520E0 File Offset: 0x000502E0
			[Token(Token = "0x17001C65")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E229")]
				[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E22A RID: 57898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E22A")]
			[Address(RVA = "0x54AA80", Offset = "0x549680", VA = "0x18054AA80", Slot = "7")]
			public override void Func()
			{
			}

			// Token: 0x0600E22B RID: 57899 RVA: 0x000520F8 File Offset: 0x000502F8
			[Token(Token = "0x600E22B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			public GridPosition GetPos()
			{
				return default(GridPosition);
			}

			// Token: 0x0600E22C RID: 57900 RVA: 0x00052110 File Offset: 0x00050310
			[Token(Token = "0x600E22C")]
			[Address(RVA = "0x54A9E0", Offset = "0x5495E0", VA = "0x18054A9E0")]
			public bool CheckBuildable(BattleCharacterData characterData)
			{
				return default(bool);
			}
		}

		// Token: 0x020022F9 RID: 8953
		[Token(Token = "0x20022F9")]
		public class Act49SideTriggerTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E22D RID: 57901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E22D")]
			[Address(RVA = "0x558540", Offset = "0x557140", VA = "0x180558540")]
			public Act49SideTriggerTileFunction(GridPosition pos, Act49SidePrintingManager manager, float initialSP, float SP)
			{
			}

			// Token: 0x17001C66 RID: 7270
			// (get) Token: 0x0600E22E RID: 57902 RVA: 0x00052128 File Offset: 0x00050328
			[Token(Token = "0x17001C66")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E22E")]
				[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E22F RID: 57903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E22F")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
			public override void Func()
			{
			}

			// Token: 0x0600E230 RID: 57904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E230")]
			[Address(RVA = "0x5583C0", Offset = "0x556FC0", VA = "0x1805583C0", Slot = "8")]
			public override void Tick(FP deltaTime)
			{
			}

			// Token: 0x0600E231 RID: 57905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E231")]
			[Address(RVA = "0x558100", Offset = "0x556D00", VA = "0x180558100", Slot = "11")]
			public override void OnEntityEnter(Entity entity)
			{
			}

			// Token: 0x0600E232 RID: 57906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E232")]
			[Address(RVA = "0x557FA0", Offset = "0x556BA0", VA = "0x180557FA0", Slot = "9")]
			public override void Detach()
			{
			}

			// Token: 0x0600E233 RID: 57907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E233")]
			[Address(RVA = "0x557D70", Offset = "0x556970", VA = "0x180557D70")]
			public void ChargePrint()
			{
			}

			// Token: 0x0600E234 RID: 57908 RVA: 0x00052140 File Offset: 0x00050340
			[Token(Token = "0x600E234")]
			[Address(RVA = "0x558050", Offset = "0x556C50", VA = "0x180558050")]
			public bool IsReady()
			{
				return default(bool);
			}

			// Token: 0x0400F7F6 RID: 63478
			[Token(Token = "0x400F7F6")]
			[FieldOffset(Offset = "0x40")]
			private Effect m_effectCoolDown;

			// Token: 0x0400F7F7 RID: 63479
			[Token(Token = "0x400F7F7")]
			[FieldOffset(Offset = "0x48")]
			private Effect m_effectReady;
		}

		// Token: 0x020022FA RID: 8954
		[Token(Token = "0x20022FA")]
		public class Act49SideCarpTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E235 RID: 57909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E235")]
			[Address(RVA = "0x54AED0", Offset = "0x549AD0", VA = "0x18054AED0")]
			public Act49SideCarpTileFunction(GridPosition pos, Act49SidePrintingManager manager)
			{
			}

			// Token: 0x17001C67 RID: 7271
			// (get) Token: 0x0600E236 RID: 57910 RVA: 0x00052158 File Offset: 0x00050358
			[Token(Token = "0x17001C67")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E236")]
				[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E237 RID: 57911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E237")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			public void LockEnemy(Enemy enemy)
			{
			}

			// Token: 0x0600E238 RID: 57912 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E238")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			public Enemy GetBoundEnemy()
			{
				return null;
			}

			// Token: 0x0600E239 RID: 57913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E239")]
			[Address(RVA = "0x54AE10", Offset = "0x549A10", VA = "0x18054AE10", Slot = "7")]
			public override void Func()
			{
			}

			// Token: 0x0400F7F8 RID: 63480
			[Token(Token = "0x400F7F8")]
			[FieldOffset(Offset = "0x40")]
			private Enemy m_enemyHandler;
		}

		// Token: 0x020022FB RID: 8955
		[Token(Token = "0x20022FB")]
		public class Act49SidePureTileFunction : Act49SidePrintingManager.Act49SideAddOnTileFunction
		{
			// Token: 0x0600E23A RID: 57914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E23A")]
			[Address(RVA = "0x557B40", Offset = "0x556740", VA = "0x180557B40")]
			public Act49SidePureTileFunction(GridPosition pos, Act49SidePrintingManager manager, string effectKey)
			{
			}

			// Token: 0x17001C68 RID: 7272
			// (get) Token: 0x0600E23B RID: 57915 RVA: 0x00052170 File Offset: 0x00050370
			[Token(Token = "0x17001C68")]
			public override Act49SidePrintingManager.Act49SideTileType tileType
			{
				[Token(Token = "0x600E23B")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
				get
				{
					return Act49SidePrintingManager.Act49SideTileType.None;
				}
			}

			// Token: 0x0600E23C RID: 57916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E23C")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
			public override void Func()
			{
			}
		}

		// Token: 0x020022FC RID: 8956
		[Token(Token = "0x20022FC")]
		public class PrintingEffectWrapper
		{
			// Token: 0x17001C69 RID: 7273
			// (get) Token: 0x0600E23D RID: 57917 RVA: 0x00052188 File Offset: 0x00050388
			[Token(Token = "0x17001C69")]
			public float elapsedTime
			{
				[Token(Token = "0x600E23D")]
				[Address(RVA = "0x560110", Offset = "0x55ED10", VA = "0x180560110")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17001C6A RID: 7274
			// (get) Token: 0x0600E23E RID: 57918 RVA: 0x000521A0 File Offset: 0x000503A0
			[Token(Token = "0x17001C6A")]
			public GridPosition pos
			{
				[Token(Token = "0x600E23E")]
				[Address(RVA = "0x560130", Offset = "0x55ED30", VA = "0x180560130")]
				get
				{
					return default(GridPosition);
				}
			}

			// Token: 0x0600E23F RID: 57919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E23F")]
			[Address(RVA = "0x5600A0", Offset = "0x55ECA0", VA = "0x1805600A0")]
			public PrintingEffectWrapper(Act49SidePrintingManager manager, Tile tile, float finishTime)
			{
			}

			// Token: 0x0600E240 RID: 57920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E240")]
			[Address(RVA = "0x55FBC0", Offset = "0x55E7C0", VA = "0x18055FBC0")]
			public void Detach()
			{
			}

			// Token: 0x0600E241 RID: 57921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E241")]
			[Address(RVA = "0x55FC60", Offset = "0x55E860", VA = "0x18055FC60")]
			public void Play()
			{
			}

			// Token: 0x0600E242 RID: 57922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E242")]
			[Address(RVA = "0x55FC00", Offset = "0x55E800", VA = "0x18055FC00")]
			public void Finish()
			{
			}

			// Token: 0x0600E243 RID: 57923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E243")]
			[Address(RVA = "0x55FE80", Offset = "0x55EA80", VA = "0x18055FE80")]
			public void Update()
			{
			}

			// Token: 0x0400F7F9 RID: 63481
			[Token(Token = "0x400F7F9")]
			[FieldOffset(Offset = "0x0")]
			private static readonly float s_triggerAudioTime;

			// Token: 0x0400F7FA RID: 63482
			[Token(Token = "0x400F7FA")]
			[FieldOffset(Offset = "0x8")]
			private static readonly string s_hitGroundAudio;

			// Token: 0x0400F7FB RID: 63483
			[Token(Token = "0x400F7FB")]
			[FieldOffset(Offset = "0x10")]
			private Effect m_effectInstance;

			// Token: 0x0400F7FC RID: 63484
			[Token(Token = "0x400F7FC")]
			[FieldOffset(Offset = "0x18")]
			private float m_startTime;

			// Token: 0x0400F7FD RID: 63485
			[Token(Token = "0x400F7FD")]
			[FieldOffset(Offset = "0x1C")]
			private bool m_isPlaying;

			// Token: 0x0400F7FE RID: 63486
			[Token(Token = "0x400F7FE")]
			[FieldOffset(Offset = "0x1D")]
			private bool m_hasTriggeredAudio;

			// Token: 0x0400F7FF RID: 63487
			[Token(Token = "0x400F7FF")]
			[FieldOffset(Offset = "0x20")]
			private Tile m_tile;

			// Token: 0x0400F800 RID: 63488
			[Token(Token = "0x400F800")]
			[FieldOffset(Offset = "0x28")]
			private float m_finishTime;

			// Token: 0x0400F801 RID: 63489
			[Token(Token = "0x400F801")]
			[FieldOffset(Offset = "0x30")]
			private Act49SidePrintingManager m_manager;
		}

		// Token: 0x020022FD RID: 8957
		[Token(Token = "0x20022FD")]
		public class PrintEffectManager
		{
			// Token: 0x0600E245 RID: 57925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E245")]
			[Address(RVA = "0x55F6C0", Offset = "0x55E2C0", VA = "0x18055F6C0")]
			public void OnTick()
			{
			}

			// Token: 0x0600E246 RID: 57926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E246")]
			[Address(RVA = "0x55F400", Offset = "0x55E000", VA = "0x18055F400")]
			public void Init(Act49SidePrintingManager manager)
			{
			}

			// Token: 0x0600E247 RID: 57927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E247")]
			[Address(RVA = "0x55F2A0", Offset = "0x55DEA0", VA = "0x18055F2A0")]
			public void Detach()
			{
			}

			// Token: 0x0600E248 RID: 57928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E248")]
			[Address(RVA = "0x55F780", Offset = "0x55E380", VA = "0x18055F780")]
			public void StartPlay(bool isPartial)
			{
			}

			// Token: 0x0600E249 RID: 57929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E249")]
			[Address(RVA = "0x55F9E0", Offset = "0x55E5E0", VA = "0x18055F9E0")]
			private void _TryPlayEffectsOnTick()
			{
			}

			// Token: 0x0600E24A RID: 57930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E24A")]
			[Address(RVA = "0x55FAA0", Offset = "0x55E6A0", VA = "0x18055FAA0")]
			private void _UpdateEffects()
			{
			}

			// Token: 0x0600E24B RID: 57931 RVA: 0x000521B8 File Offset: 0x000503B8
			[Token(Token = "0x600E24B")]
			[Address(RVA = "0x55F8A0", Offset = "0x55E4A0", VA = "0x18055F8A0")]
			private bool _ShouldShowEffect(int index)
			{
				return default(bool);
			}

			// Token: 0x0600E24C RID: 57932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E24C")]
			[Address(RVA = "0x55FBA0", Offset = "0x55E7A0", VA = "0x18055FBA0")]
			public PrintEffectManager()
			{
			}

			// Token: 0x0400F802 RID: 63490
			[Token(Token = "0x400F802")]
			[FieldOffset(Offset = "0x10")]
			private int m_effectPerFrame;

			// Token: 0x0400F803 RID: 63491
			[Token(Token = "0x400F803")]
			[FieldOffset(Offset = "0x14")]
			private int m_effectCnt;

			// Token: 0x0400F804 RID: 63492
			[Token(Token = "0x400F804")]
			[FieldOffset(Offset = "0x18")]
			private int m_cursor;

			// Token: 0x0400F805 RID: 63493
			[Token(Token = "0x400F805")]
			[FieldOffset(Offset = "0x1C")]
			private float m_finishTime;

			// Token: 0x0400F806 RID: 63494
			[Token(Token = "0x400F806")]
			[FieldOffset(Offset = "0x20")]
			private bool m_isPlaying;

			// Token: 0x0400F807 RID: 63495
			[Token(Token = "0x400F807")]
			[FieldOffset(Offset = "0x21")]
			private bool m_isPartialPrint;

			// Token: 0x0400F808 RID: 63496
			[Token(Token = "0x400F808")]
			[FieldOffset(Offset = "0x28")]
			private List<Act49SidePrintingManager.PrintingEffectWrapper> m_effectWrappers;

			// Token: 0x0400F809 RID: 63497
			[Token(Token = "0x400F809")]
			[FieldOffset(Offset = "0x30")]
			private Act49SidePrintingManager m_manager;
		}

		// Token: 0x020022FE RID: 8958
		[Token(Token = "0x20022FE")]
		private class Act49sideBuildableChecker : ITileBuildableChecker
		{
			// Token: 0x0600E24D RID: 57933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E24D")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public Act49sideBuildableChecker(Act49SidePrintingManager manager)
			{
			}

			// Token: 0x0600E24E RID: 57934 RVA: 0x000521D0 File Offset: 0x000503D0
			[Token(Token = "0x600E24E")]
			[Address(RVA = "0x55B080", Offset = "0x559C80", VA = "0x18055B080", Slot = "4")]
			public bool IsCharacterBuildableOnTile(Tile tile, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x0600E24F RID: 57935 RVA: 0x000521E8 File Offset: 0x000503E8
			[Token(Token = "0x600E24F")]
			[Address(RVA = "0x55B3C0", Offset = "0x559FC0", VA = "0x18055B3C0", Slot = "5")]
			public bool IsTileBuildable(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x0400F80A RID: 63498
			[Token(Token = "0x400F80A")]
			[FieldOffset(Offset = "0x10")]
			private Act49SidePrintingManager m_manager;
		}
	}
}
