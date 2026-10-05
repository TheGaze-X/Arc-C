using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using Torappu.Battle.Runes;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002775 RID: 10101
	[Token(Token = "0x2002775")]
	public class AutoChessBattleDataModel : AutoChessDataCenter.AutoChessDataModelBase
	{
		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x06010798 RID: 67480 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010799 RID: 67481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023F0")]
		public LevelData levelData
		{
			[Token(Token = "0x6010798")]
			[Address(RVA = "0x848D50", Offset = "0x847950", VA = "0x180848D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010799")]
			[Address(RVA = "0x848E30", Offset = "0x847A30", VA = "0x180848E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0601079A RID: 67482 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601079B RID: 67483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023F1")]
		public LevelData enemyDataLevel
		{
			[Token(Token = "0x601079A")]
			[Address(RVA = "0x848CF0", Offset = "0x8478F0", VA = "0x180848CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601079B")]
			[Address(RVA = "0x848DB0", Offset = "0x8479B0", VA = "0x180848DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0601079C RID: 67484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170023F2")]
		private AutoChessDataCenter center
		{
			[Token(Token = "0x601079C")]
			[Address(RVA = "0x848C90", Offset = "0x847890", VA = "0x180848C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601079D RID: 67485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601079D")]
		[Address(RVA = "0x8431D0", Offset = "0x841DD0", VA = "0x1808431D0")]
		public void Init()
		{
		}

		// Token: 0x0601079E RID: 67486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601079E")]
		[Address(RVA = "0x843F20", Offset = "0x842B20", VA = "0x180843F20")]
		public void UpdateData(PlayerBattleData data)
		{
		}

		// Token: 0x0601079F RID: 67487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601079F")]
		[Address(RVA = "0x843AC0", Offset = "0x8426C0", VA = "0x180843AC0")]
		public void PrepareForPrepareState()
		{
		}

		// Token: 0x060107A0 RID: 67488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A0")]
		[Address(RVA = "0x847B30", Offset = "0x846730", VA = "0x180847B30")]
		private void _PrepareForBattleState()
		{
		}

		// Token: 0x060107A1 RID: 67489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A1")]
		[Address(RVA = "0x848230", Offset = "0x846E30", VA = "0x180848230")]
		private void _ResetPredefines()
		{
		}

		// Token: 0x060107A2 RID: 67490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A2")]
		[Address(RVA = "0x847DF0", Offset = "0x8469F0", VA = "0x180847DF0")]
		private void _ReloadPredefines(bool isBattle)
		{
		}

		// Token: 0x060107A3 RID: 67491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A3")]
		[Address(RVA = "0x843D50", Offset = "0x842950", VA = "0x180843D50")]
		public void PrepareForSelfBattleState(int round)
		{
		}

		// Token: 0x060107A4 RID: 67492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A4")]
		[Address(RVA = "0x8438B0", Offset = "0x8424B0", VA = "0x1808438B0")]
		public void PrepareForHelpBattleState()
		{
		}

		// Token: 0x060107A5 RID: 67493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A5")]
		[Address(RVA = "0x8436E0", Offset = "0x8422E0", VA = "0x1808436E0")]
		public void PrepareForBossBattleState(int round)
		{
		}

		// Token: 0x060107A6 RID: 67494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A6")]
		[Address(RVA = "0x846C00", Offset = "0x845800", VA = "0x180846C00")]
		private void _LoadBattleChessInsts()
		{
		}

		// Token: 0x060107A7 RID: 67495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A7")]
		[Address(RVA = "0x846E90", Offset = "0x845A90", VA = "0x180846E90")]
		private void _LoadBattlePlayerData()
		{
		}

		// Token: 0x060107A8 RID: 67496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A8")]
		[Address(RVA = "0x842CA0", Offset = "0x8418A0", VA = "0x180842CA0")]
		public void ApplyGlobalStateSpecialEffects()
		{
		}

		// Token: 0x060107A9 RID: 67497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107A9")]
		[Address(RVA = "0x845800", Offset = "0x844400", VA = "0x180845800")]
		private void _ApplyChangeMapEffect(string effectId, int playerIndex)
		{
		}

		// Token: 0x060107AA RID: 67498 RVA: 0x00064620 File Offset: 0x00062820
		[Token(Token = "0x60107AA")]
		[Address(RVA = "0x847460", Offset = "0x846060", VA = "0x180847460")]
		private bool _ParseCommonConditions(Blackboard blackboard, int playerIndex)
		{
			return default(bool);
		}

		// Token: 0x060107AB RID: 67499 RVA: 0x00064638 File Offset: 0x00062838
		[Token(Token = "0x60107AB")]
		[Address(RVA = "0x845FD0", Offset = "0x844BD0", VA = "0x180845FD0")]
		private int _GetBattleGoldenChessCnt(int playerIndex)
		{
			return 0;
		}

		// Token: 0x060107AC RID: 67500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107AC")]
		[Address(RVA = "0x845A80", Offset = "0x844680", VA = "0x180845A80")]
		private void _ApplyChangeMapEffect(ActAutoChessData.ActAutoChessBuffInfoData effectBuff)
		{
		}

		// Token: 0x060107AD RID: 67501 RVA: 0x00064650 File Offset: 0x00062850
		[Token(Token = "0x60107AD")]
		[Address(RVA = "0x847CD0", Offset = "0x8468D0", VA = "0x180847CD0")]
		private bool _RefreshPredefineShown(string alias, Blackboard blackboard, bool isMulti, out bool shown)
		{
			return default(bool);
		}

		// Token: 0x060107AE RID: 67502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107AE")]
		[Address(RVA = "0x847260", Offset = "0x845E60", VA = "0x180847260")]
		private void _LoadBattleRunes()
		{
		}

		// Token: 0x060107AF RID: 67503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107AF")]
		[Address(RVA = "0x8444F0", Offset = "0x8430F0", VA = "0x1808444F0")]
		private void _AppendBattlePlayerRunes()
		{
		}

		// Token: 0x060107B0 RID: 67504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107B0")]
		[Address(RVA = "0x8450D0", Offset = "0x843CD0", VA = "0x1808450D0")]
		private void _AppendEquipRunes(int targetInst, PlayerSide side, int playerIndex)
		{
		}

		// Token: 0x060107B1 RID: 67505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107B1")]
		[Address(RVA = "0x844CF0", Offset = "0x8438F0", VA = "0x180844CF0")]
		private void _AppendCharCultivateRunes(ChessInst chessInst)
		{
		}

		// Token: 0x060107B2 RID: 67506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107B2")]
		[Address(RVA = "0x845290", Offset = "0x843E90", VA = "0x180845290")]
		private void _AppendGarrisonRunes(ChessInst chessInst)
		{
		}

		// Token: 0x060107B3 RID: 67507 RVA: 0x00064668 File Offset: 0x00062868
		[Token(Token = "0x60107B3")]
		[Address(RVA = "0x847600", Offset = "0x846200", VA = "0x180847600")]
		private bool _ParseGrantGarrison(ActAutoChessData.ActAutoChessGarrisonData garrisonData, ChessInst chessInst)
		{
			return default(bool);
		}

		// Token: 0x060107B4 RID: 67508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107B4")]
		[Address(RVA = "0x846970", Offset = "0x845570", VA = "0x180846970")]
		private void _GrantGarrisonToInst(ActAutoChessData.ActAutoChessGarrisonData garrisonData, ChessInst targetInst, string newGarrisonId)
		{
		}

		// Token: 0x060107B5 RID: 67509 RVA: 0x00064680 File Offset: 0x00062880
		[Token(Token = "0x60107B5")]
		[Address(RVA = "0x848450", Offset = "0x847050", VA = "0x180848450")]
		private bool _TryGetFrontInst(ChessInst inst, out ChessInst targetInst)
		{
			return default(bool);
		}

		// Token: 0x060107B6 RID: 67510 RVA: 0x00064698 File Offset: 0x00062898
		[Token(Token = "0x60107B6")]
		[Address(RVA = "0x848330", Offset = "0x846F30", VA = "0x180848330")]
		private bool _TryGetBackInst(ChessInst inst, out ChessInst targetInst)
		{
			return default(bool);
		}

		// Token: 0x060107B7 RID: 67511 RVA: 0x000646B0 File Offset: 0x000628B0
		[Token(Token = "0x60107B7")]
		[Address(RVA = "0x848570", Offset = "0x847170", VA = "0x180848570")]
		private bool _TryGetMostRightInst(ChessInst inst, out ChessInst targetInst)
		{
			return default(bool);
		}

		// Token: 0x060107B8 RID: 67512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60107B8")]
		[Address(RVA = "0x8465E0", Offset = "0x8451E0", VA = "0x1808465E0")]
		private RuneTable.PackedRuneData _GetPackedRuneData(string effectId)
		{
			return null;
		}

		// Token: 0x060107B9 RID: 67513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60107B9")]
		[Address(RVA = "0x846180", Offset = "0x844D80", VA = "0x180846180")]
		private RuneTable.PackedRuneData _GetEquipmentPackedRuneData(int equipInstId, int equipTargetInstId)
		{
			return null;
		}

		// Token: 0x060107BA RID: 67514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60107BA")]
		[Address(RVA = "0x8455E0", Offset = "0x8441E0", VA = "0x1808455E0")]
		private RuneTable.PackedRuneData _AppendPackedGarrisonRuneData(ActAutoChessData.ActAutoChessGarrisonData garrisonData, int ownerInstId, string garrisonId)
		{
			return null;
		}

		// Token: 0x060107BB RID: 67515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107BB")]
		[Address(RVA = "0x8440A0", Offset = "0x842CA0", VA = "0x1808440A0")]
		private void _AddPackedRuneData(RuneTable.PackedRuneData packedRuneData, PlayerSide playerSide, int playerIndex)
		{
		}

		// Token: 0x060107BC RID: 67516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107BC")]
		[Address(RVA = "0x848760", Offset = "0x847360", VA = "0x180848760")]
		public AutoChessBattleDataModel()
		{
		}

		// Token: 0x04012762 RID: 75618
		[Token(Token = "0x4012762")]
		[FieldOffset(Offset = "0x18")]
		public ChessMapInfo chessMapInfo;

		// Token: 0x04012763 RID: 75619
		[Token(Token = "0x4012763")]
		[FieldOffset(Offset = "0x20")]
		public List<ChessInst> battleChessInsts;

		// Token: 0x04012764 RID: 75620
		[Token(Token = "0x4012764")]
		[FieldOffset(Offset = "0x28")]
		public AdvancedRuneHolder runeHolder;

		// Token: 0x04012765 RID: 75621
		[Token(Token = "0x4012765")]
		[FieldOffset(Offset = "0x30")]
		public List<BattlePlayerData> battlePlayerData;

		// Token: 0x04012766 RID: 75622
		[Token(Token = "0x4012766")]
		[FieldOffset(Offset = "0x38")]
		public LevelData.PredefinedData levelPredefineData;

		// Token: 0x04012767 RID: 75623
		[Token(Token = "0x4012767")]
		[FieldOffset(Offset = "0x40")]
		public List<LegacyInLevelRuneData> originLevelRunes;

		// Token: 0x0401276A RID: 75626
		[Token(Token = "0x401276A")]
		[FieldOffset(Offset = "0x58")]
		private List<LevelData.PredefinedData.PredefinedCharacter> m_originPredefinedTokens;

		// Token: 0x0401276B RID: 75627
		[Token(Token = "0x401276B")]
		[FieldOffset(Offset = "0x60")]
		private List<LevelData.PredefinedData.PredefinedCharacter> m_predefinedTokens;

		// Token: 0x0401276C RID: 75628
		[Token(Token = "0x401276C")]
		[FieldOffset(Offset = "0x68")]
		private List<LevelData.PredefinedData.PredefinedCharacter> m_originPredefinedChars;

		// Token: 0x0401276D RID: 75629
		[Token(Token = "0x401276D")]
		[FieldOffset(Offset = "0x70")]
		private List<LevelData.PredefinedData.PredefinedCharacter> m_predefinedChars;

		// Token: 0x0401276E RID: 75630
		[Token(Token = "0x401276E")]
		[FieldOffset(Offset = "0x78")]
		private List<AdvancedCharacterInst> m_battleInstsA;

		// Token: 0x0401276F RID: 75631
		[Token(Token = "0x401276F")]
		[FieldOffset(Offset = "0x80")]
		private List<AdvancedCharacterInst> m_battleInstsB;

		// Token: 0x04012770 RID: 75632
		[Token(Token = "0x4012770")]
		[FieldOffset(Offset = "0x88")]
		private BattlePlayerData m_commonEmptyPlayerData;

		// Token: 0x04012771 RID: 75633
		[Token(Token = "0x4012771")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_levelData;

		// Token: 0x04012772 RID: 75634
		[Token(Token = "0x4012772")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_levelData;

		// Token: 0x04012773 RID: 75635
		[Token(Token = "0x4012773")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enemyDataLevel;

		// Token: 0x04012774 RID: 75636
		[Token(Token = "0x4012774")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_enemyDataLevel;

		// Token: 0x04012775 RID: 75637
		[Token(Token = "0x4012775")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_center;

		// Token: 0x04012776 RID: 75638
		[Token(Token = "0x4012776")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04012777 RID: 75639
		[Token(Token = "0x4012777")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04012778 RID: 75640
		[Token(Token = "0x4012778")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PrepareForPrepareState;

		// Token: 0x04012779 RID: 75641
		[Token(Token = "0x4012779")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PrepareForBattleState;

		// Token: 0x0401277A RID: 75642
		[Token(Token = "0x401277A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetPredefines;

		// Token: 0x0401277B RID: 75643
		[Token(Token = "0x401277B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ReloadPredefines;

		// Token: 0x0401277C RID: 75644
		[Token(Token = "0x401277C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_PrepareForSelfBattleState;

		// Token: 0x0401277D RID: 75645
		[Token(Token = "0x401277D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_PrepareForHelpBattleState;

		// Token: 0x0401277E RID: 75646
		[Token(Token = "0x401277E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_PrepareForBossBattleState;

		// Token: 0x0401277F RID: 75647
		[Token(Token = "0x401277F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadBattleChessInsts;

		// Token: 0x04012780 RID: 75648
		[Token(Token = "0x4012780")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LoadBattlePlayerData;

		// Token: 0x04012781 RID: 75649
		[Token(Token = "0x4012781")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ApplyGlobalStateSpecialEffects;

		// Token: 0x04012782 RID: 75650
		[Token(Token = "0x4012782")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ApplyChangeMapEffect;

		// Token: 0x04012783 RID: 75651
		[Token(Token = "0x4012783")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ParseCommonConditions;

		// Token: 0x04012784 RID: 75652
		[Token(Token = "0x4012784")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetBattleGoldenChessCnt;

		// Token: 0x04012785 RID: 75653
		[Token(Token = "0x4012785")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1__ApplyChangeMapEffect;

		// Token: 0x04012786 RID: 75654
		[Token(Token = "0x4012786")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RefreshPredefineShown;

		// Token: 0x04012787 RID: 75655
		[Token(Token = "0x4012787")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__LoadBattleRunes;

		// Token: 0x04012788 RID: 75656
		[Token(Token = "0x4012788")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__AppendBattlePlayerRunes;

		// Token: 0x04012789 RID: 75657
		[Token(Token = "0x4012789")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__AppendEquipRunes;

		// Token: 0x0401278A RID: 75658
		[Token(Token = "0x401278A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__AppendCharCultivateRunes;

		// Token: 0x0401278B RID: 75659
		[Token(Token = "0x401278B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__AppendGarrisonRunes;

		// Token: 0x0401278C RID: 75660
		[Token(Token = "0x401278C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ParseGrantGarrison;

		// Token: 0x0401278D RID: 75661
		[Token(Token = "0x401278D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__GrantGarrisonToInst;

		// Token: 0x0401278E RID: 75662
		[Token(Token = "0x401278E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TryGetFrontInst;

		// Token: 0x0401278F RID: 75663
		[Token(Token = "0x401278F")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TryGetBackInst;

		// Token: 0x04012790 RID: 75664
		[Token(Token = "0x4012790")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__TryGetMostRightInst;

		// Token: 0x04012791 RID: 75665
		[Token(Token = "0x4012791")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetPackedRuneData;

		// Token: 0x04012792 RID: 75666
		[Token(Token = "0x4012792")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetEquipmentPackedRuneData;

		// Token: 0x04012793 RID: 75667
		[Token(Token = "0x4012793")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__AppendPackedGarrisonRuneData;

		// Token: 0x04012794 RID: 75668
		[Token(Token = "0x4012794")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__AddPackedRuneData;

		// Token: 0x04012795 RID: 75669
		[Token(Token = "0x4012795")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
