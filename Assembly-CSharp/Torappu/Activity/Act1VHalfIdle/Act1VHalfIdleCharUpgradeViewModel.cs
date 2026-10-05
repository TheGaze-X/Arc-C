using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007725 RID: 30501
	[Token(Token = "0x2007725")]
	public class Act1VHalfIdleCharUpgradeViewModel : IHotfixable
	{
		// Token: 0x17006485 RID: 25733
		// (get) Token: 0x0602ADAE RID: 175534 RVA: 0x000DA370 File Offset: 0x000D8570
		[Token(Token = "0x17006485")]
		private bool useUpgradeLevelDiscount
		{
			[Token(Token = "0x602ADAE")]
			[Address(RVA = "0x26A2630", Offset = "0x26A1230", VA = "0x1826A2630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006486 RID: 25734
		// (get) Token: 0x0602ADAF RID: 175535 RVA: 0x000DA388 File Offset: 0x000D8588
		[Token(Token = "0x17006486")]
		private bool useUpgradeEliteDiscount
		{
			[Token(Token = "0x602ADAF")]
			[Address(RVA = "0x26A25D0", Offset = "0x26A11D0", VA = "0x1826A25D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006487 RID: 25735
		// (get) Token: 0x0602ADB0 RID: 175536 RVA: 0x000DA3A0 File Offset: 0x000D85A0
		[Token(Token = "0x17006487")]
		public int selectedSkillRank
		{
			[Token(Token = "0x602ADB0")]
			[Address(RVA = "0x26A24A0", Offset = "0x26A10A0", VA = "0x1826A24A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006488 RID: 25736
		// (get) Token: 0x0602ADB1 RID: 175537 RVA: 0x000DA3B8 File Offset: 0x000D85B8
		[Token(Token = "0x17006488")]
		public int discountSkillRank
		{
			[Token(Token = "0x602ADB1")]
			[Address(RVA = "0x26A2320", Offset = "0x26A0F20", VA = "0x1826A2320")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006489 RID: 25737
		// (get) Token: 0x0602ADB2 RID: 175538 RVA: 0x000DA3D0 File Offset: 0x000D85D0
		[Token(Token = "0x17006489")]
		public Act1VHalfIdleCharUpgradeViewModel.CharUpgradeItemShowParam levelUpgradeItemShowParam
		{
			[Token(Token = "0x602ADB2")]
			[Address(RVA = "0x26A2380", Offset = "0x26A0F80", VA = "0x1826A2380")]
			get
			{
				return default(Act1VHalfIdleCharUpgradeViewModel.CharUpgradeItemShowParam);
			}
		}

		// Token: 0x1700648A RID: 25738
		// (get) Token: 0x0602ADB3 RID: 175539 RVA: 0x000DA3E8 File Offset: 0x000D85E8
		[Token(Token = "0x1700648A")]
		public Act1VHalfIdleCharUpgradeViewModel.CharUpgradeItemShowParam skillUpgradeItemShowParam
		{
			[Token(Token = "0x602ADB3")]
			[Address(RVA = "0x26A2500", Offset = "0x26A1100", VA = "0x1826A2500")]
			get
			{
				return default(Act1VHalfIdleCharUpgradeViewModel.CharUpgradeItemShowParam);
			}
		}

		// Token: 0x0602ADB4 RID: 175540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADB4")]
		[Address(RVA = "0x26A0640", Offset = "0x269F240", VA = "0x1826A0640")]
		public void LoadData(string actId, string charInstId)
		{
		}

		// Token: 0x0602ADB5 RID: 175541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADB5")]
		[Address(RVA = "0x26A1BC0", Offset = "0x26A07C0", VA = "0x1826A1BC0")]
		private void _LoadCultivateData(Act1VHalfIdleData actData, RarityRank rarityRank, EvolvePhase currEvolvePhase)
		{
		}

		// Token: 0x0602ADB6 RID: 175542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADB6")]
		[Address(RVA = "0x26A1DA0", Offset = "0x26A09A0", VA = "0x1826A1DA0")]
		private void _LoadEvolveData(Act1VHalfIdleData actData)
		{
		}

		// Token: 0x0602ADB7 RID: 175543 RVA: 0x000DA400 File Offset: 0x000D8600
		[Token(Token = "0x602ADB7")]
		[Address(RVA = "0x26A1930", Offset = "0x26A0530", VA = "0x1826A1930")]
		private int _GetNormalizedSkillRank(int skillRank)
		{
			return 0;
		}

		// Token: 0x0602ADB8 RID: 175544 RVA: 0x000DA418 File Offset: 0x000D8618
		[Token(Token = "0x602ADB8")]
		[Address(RVA = "0x26A1AF0", Offset = "0x26A06F0", VA = "0x1826A1AF0")]
		private int _GetSkillRankByNormalizedSkillRank(int normalizedSkillRank)
		{
			return 0;
		}

		// Token: 0x0602ADB9 RID: 175545 RVA: 0x000DA430 File Offset: 0x000D8630
		[Token(Token = "0x602ADB9")]
		[Address(RVA = "0x26A1740", Offset = "0x26A0340", VA = "0x1826A1740")]
		private bool _GetAccumulatedExpToSkillRank(int targetNormalizedSkillRank, out int accumulatedCost)
		{
			return default(bool);
		}

		// Token: 0x0602ADBA RID: 175546 RVA: 0x000DA448 File Offset: 0x000D8648
		[Token(Token = "0x602ADBA")]
		[Address(RVA = "0x26A19D0", Offset = "0x26A05D0", VA = "0x1826A19D0")]
		private bool _GetSkillExpToSkillRank(int targetNormalizedSkillRank, out int skillExp, out int discountSkillExp)
		{
			return default(bool);
		}

		// Token: 0x0602ADBB RID: 175547 RVA: 0x000DA460 File Offset: 0x000D8660
		[Token(Token = "0x602ADBB")]
		[Address(RVA = "0x26A1580", Offset = "0x26A0180", VA = "0x1826A1580")]
		public bool SetSelectedNormalizedSkillRank(int targetNormalizedSkillRank)
		{
			return default(bool);
		}

		// Token: 0x0602ADBC RID: 175548 RVA: 0x000DA478 File Offset: 0x000D8678
		[Token(Token = "0x602ADBC")]
		[Address(RVA = "0x26A1360", Offset = "0x269FF60", VA = "0x1826A1360")]
		public bool SetSelectedNormalizedSkillRankToMax()
		{
			return default(bool);
		}

		// Token: 0x0602ADBD RID: 175549 RVA: 0x000DA490 File Offset: 0x000D8690
		[Token(Token = "0x602ADBD")]
		[Address(RVA = "0x26A1650", Offset = "0x26A0250", VA = "0x1826A1650")]
		private bool _GetAccumulatedExpToLevel(int targetLevel, out int accumulatedExp)
		{
			return default(bool);
		}

		// Token: 0x0602ADBE RID: 175550 RVA: 0x000DA4A8 File Offset: 0x000D86A8
		[Token(Token = "0x602ADBE")]
		[Address(RVA = "0x26A1850", Offset = "0x26A0450", VA = "0x1826A1850")]
		private bool _GetExpToLevel(int targetLevel, out int exp)
		{
			return default(bool);
		}

		// Token: 0x0602ADBF RID: 175551 RVA: 0x000DA4C0 File Offset: 0x000D86C0
		[Token(Token = "0x602ADBF")]
		[Address(RVA = "0x26A1270", Offset = "0x269FE70", VA = "0x1826A1270")]
		public bool SetSelectedLevel(int targetLevel)
		{
			return default(bool);
		}

		// Token: 0x0602ADC0 RID: 175552 RVA: 0x000DA4D8 File Offset: 0x000D86D8
		[Token(Token = "0x602ADC0")]
		[Address(RVA = "0x26A1120", Offset = "0x269FD20", VA = "0x1826A1120")]
		public bool SetSelectedLevelToMax()
		{
			return default(bool);
		}

		// Token: 0x0602ADC1 RID: 175553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADC1")]
		[Address(RVA = "0x26A2260", Offset = "0x26A0E60", VA = "0x1826A2260")]
		public Act1VHalfIdleCharUpgradeViewModel()
		{
		}

		// Token: 0x0403DC53 RID: 253011
		[Token(Token = "0x403DC53")]
		public const int GLOBAL_MAX_SKILL_RANK = 10;

		// Token: 0x0403DC54 RID: 253012
		[Token(Token = "0x403DC54")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403DC55 RID: 253013
		[Token(Token = "0x403DC55")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x0403DC56 RID: 253014
		[Token(Token = "0x403DC56")]
		[FieldOffset(Offset = "0x20")]
		public string tmplId;

		// Token: 0x0403DC57 RID: 253015
		[Token(Token = "0x403DC57")]
		[FieldOffset(Offset = "0x28")]
		public string charInstId;

		// Token: 0x0403DC58 RID: 253016
		[Token(Token = "0x403DC58")]
		[FieldOffset(Offset = "0x30")]
		public Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType;

		// Token: 0x0403DC59 RID: 253017
		[Token(Token = "0x403DC59")]
		[FieldOffset(Offset = "0x34")]
		public int potentialRank;

		// Token: 0x0403DC5A RID: 253018
		[Token(Token = "0x403DC5A")]
		[FieldOffset(Offset = "0x38")]
		public RarityRank rarityRank;

		// Token: 0x0403DC5B RID: 253019
		[Token(Token = "0x403DC5B")]
		[FieldOffset(Offset = "0x3C")]
		public ProfessionCategory profession;

		// Token: 0x0403DC5C RID: 253020
		[Token(Token = "0x403DC5C")]
		[FieldOffset(Offset = "0x40")]
		public string charName;

		// Token: 0x0403DC5D RID: 253021
		[Token(Token = "0x403DC5D")]
		[FieldOffset(Offset = "0x48")]
		public CharUISkinStruct skinStruct;

		// Token: 0x0403DC5E RID: 253022
		[Token(Token = "0x403DC5E")]
		[FieldOffset(Offset = "0x60")]
		public List<Act1VHalfIdleCharUpgradeRewardViewModel> upgradeRewardViewModelList;

		// Token: 0x0403DC5F RID: 253023
		[Token(Token = "0x403DC5F")]
		[FieldOffset(Offset = "0x68")]
		public EvolvePhase currEvolvePhase;

		// Token: 0x0403DC60 RID: 253024
		[Token(Token = "0x403DC60")]
		[FieldOffset(Offset = "0x6C")]
		public EvolvePhase maxEvolvePhase;

		// Token: 0x0403DC61 RID: 253025
		[Token(Token = "0x403DC61")]
		[FieldOffset(Offset = "0x70")]
		public bool hasSkill;

		// Token: 0x0403DC62 RID: 253026
		[Token(Token = "0x403DC62")]
		[FieldOffset(Offset = "0x74")]
		public int currSkillRank;

		// Token: 0x0403DC63 RID: 253027
		[Token(Token = "0x403DC63")]
		[FieldOffset(Offset = "0x78")]
		public int currNormalizedSkillRank;

		// Token: 0x0403DC64 RID: 253028
		[Token(Token = "0x403DC64")]
		[FieldOffset(Offset = "0x7C")]
		public int maxSkillRank;

		// Token: 0x0403DC65 RID: 253029
		[Token(Token = "0x403DC65")]
		[FieldOffset(Offset = "0x80")]
		public int maxNormalizedSkillRank;

		// Token: 0x0403DC66 RID: 253030
		[Token(Token = "0x403DC66")]
		[FieldOffset(Offset = "0x84")]
		public int globalMaxNormalizedSkillRank;

		// Token: 0x0403DC67 RID: 253031
		[Token(Token = "0x403DC67")]
		[FieldOffset(Offset = "0x88")]
		public int currLevel;

		// Token: 0x0403DC68 RID: 253032
		[Token(Token = "0x403DC68")]
		[FieldOffset(Offset = "0x8C")]
		public int maxLevel;

		// Token: 0x0403DC69 RID: 253033
		[Token(Token = "0x403DC69")]
		[FieldOffset(Offset = "0x90")]
		public Act1VHalfIdleCharRankData charRankData;

		// Token: 0x0403DC6A RID: 253034
		[Token(Token = "0x403DC6A")]
		[FieldOffset(Offset = "0x98")]
		public Act1VHalfIdleCharEvolveData.EvolveData charEvolveData;

		// Token: 0x0403DC6B RID: 253035
		[Token(Token = "0x403DC6B")]
		[FieldOffset(Offset = "0xA0")]
		public Act1VHalfIdleCharSkillRankData charSkillRankData;

		// Token: 0x0403DC6C RID: 253036
		[Token(Token = "0x403DC6C")]
		[FieldOffset(Offset = "0xA8")]
		public List<int> validSkillRanks;

		// Token: 0x0403DC6D RID: 253037
		[Token(Token = "0x403DC6D")]
		[FieldOffset(Offset = "0xB0")]
		public int[] normalizedSkillRankMap;

		// Token: 0x0403DC6E RID: 253038
		[Token(Token = "0x403DC6E")]
		[FieldOffset(Offset = "0xB8")]
		public int discountEvolvePhase;

		// Token: 0x0403DC6F RID: 253039
		[Token(Token = "0x403DC6F")]
		[FieldOffset(Offset = "0xBC")]
		public int discountNormalizedSkillRank;

		// Token: 0x0403DC70 RID: 253040
		[Token(Token = "0x403DC70")]
		[FieldOffset(Offset = "0xC0")]
		public string levelExpItemId;

		// Token: 0x0403DC71 RID: 253041
		[Token(Token = "0x403DC71")]
		[FieldOffset(Offset = "0xC8")]
		public int currLevelExpItemCount;

		// Token: 0x0403DC72 RID: 253042
		[Token(Token = "0x403DC72")]
		[FieldOffset(Offset = "0xD0")]
		public string skillExpItemId;

		// Token: 0x0403DC73 RID: 253043
		[Token(Token = "0x403DC73")]
		[FieldOffset(Offset = "0xD8")]
		public int currSkillExpItemCount;

		// Token: 0x0403DC74 RID: 253044
		[Token(Token = "0x403DC74")]
		[FieldOffset(Offset = "0xE0")]
		public string evolveItemId;

		// Token: 0x0403DC75 RID: 253045
		[Token(Token = "0x403DC75")]
		[FieldOffset(Offset = "0xE8")]
		public int evolveItemCost;

		// Token: 0x0403DC76 RID: 253046
		[Token(Token = "0x403DC76")]
		[FieldOffset(Offset = "0xEC")]
		public int evolveItemCostDiscount;

		// Token: 0x0403DC77 RID: 253047
		[Token(Token = "0x403DC77")]
		[FieldOffset(Offset = "0xF0")]
		public int currEvolveItemCount;

		// Token: 0x0403DC78 RID: 253048
		[Token(Token = "0x403DC78")]
		[FieldOffset(Offset = "0xF4")]
		public int initSeqNum;

		// Token: 0x0403DC79 RID: 253049
		[Token(Token = "0x403DC79")]
		[FieldOffset(Offset = "0xF8")]
		public int upgradeLevelSeqNum;

		// Token: 0x0403DC7A RID: 253050
		[Token(Token = "0x403DC7A")]
		[FieldOffset(Offset = "0xFC")]
		public int upgradeSkillSeqNum;

		// Token: 0x0403DC7B RID: 253051
		[Token(Token = "0x403DC7B")]
		[FieldOffset(Offset = "0x100")]
		public int switchCharSeqNum;

		// Token: 0x0403DC7C RID: 253052
		[Token(Token = "0x403DC7C")]
		[FieldOffset(Offset = "0x104")]
		public int selectedLevel;

		// Token: 0x0403DC7D RID: 253053
		[Token(Token = "0x403DC7D")]
		[FieldOffset(Offset = "0x108")]
		public int selectedLevelItemCost;

		// Token: 0x0403DC7E RID: 253054
		[Token(Token = "0x403DC7E")]
		[FieldOffset(Offset = "0x10C")]
		public int selectedLevelItemCostDiscount;

		// Token: 0x0403DC7F RID: 253055
		[Token(Token = "0x403DC7F")]
		[FieldOffset(Offset = "0x110")]
		public int selectedNormalizedSkillRank;

		// Token: 0x0403DC80 RID: 253056
		[Token(Token = "0x403DC80")]
		[FieldOffset(Offset = "0x114")]
		public int selectedSkillItemCost;

		// Token: 0x0403DC81 RID: 253057
		[Token(Token = "0x403DC81")]
		[FieldOffset(Offset = "0x118")]
		public int selectedSkillItemCostDiscount;

		// Token: 0x0403DC82 RID: 253058
		[Token(Token = "0x403DC82")]
		[FieldOffset(Offset = "0x11C")]
		public int currCharIndex;

		// Token: 0x0403DC83 RID: 253059
		[Token(Token = "0x403DC83")]
		[FieldOffset(Offset = "0x120")]
		public int totalCharCount;

		// Token: 0x0403DC84 RID: 253060
		[Token(Token = "0x403DC84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useUpgradeLevelDiscount;

		// Token: 0x0403DC85 RID: 253061
		[Token(Token = "0x403DC85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_useUpgradeEliteDiscount;

		// Token: 0x0403DC86 RID: 253062
		[Token(Token = "0x403DC86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedSkillRank;

		// Token: 0x0403DC87 RID: 253063
		[Token(Token = "0x403DC87")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_discountSkillRank;

		// Token: 0x0403DC88 RID: 253064
		[Token(Token = "0x403DC88")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_levelUpgradeItemShowParam;

		// Token: 0x0403DC89 RID: 253065
		[Token(Token = "0x403DC89")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_skillUpgradeItemShowParam;

		// Token: 0x0403DC8A RID: 253066
		[Token(Token = "0x403DC8A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403DC8B RID: 253067
		[Token(Token = "0x403DC8B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadCultivateData;

		// Token: 0x0403DC8C RID: 253068
		[Token(Token = "0x403DC8C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadEvolveData;

		// Token: 0x0403DC8D RID: 253069
		[Token(Token = "0x403DC8D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetNormalizedSkillRank;

		// Token: 0x0403DC8E RID: 253070
		[Token(Token = "0x403DC8E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetSkillRankByNormalizedSkillRank;

		// Token: 0x0403DC8F RID: 253071
		[Token(Token = "0x403DC8F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetAccumulatedExpToSkillRank;

		// Token: 0x0403DC90 RID: 253072
		[Token(Token = "0x403DC90")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetSkillExpToSkillRank;

		// Token: 0x0403DC91 RID: 253073
		[Token(Token = "0x403DC91")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetSelectedNormalizedSkillRank;

		// Token: 0x0403DC92 RID: 253074
		[Token(Token = "0x403DC92")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetSelectedNormalizedSkillRankToMax;

		// Token: 0x0403DC93 RID: 253075
		[Token(Token = "0x403DC93")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetAccumulatedExpToLevel;

		// Token: 0x0403DC94 RID: 253076
		[Token(Token = "0x403DC94")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetExpToLevel;

		// Token: 0x0403DC95 RID: 253077
		[Token(Token = "0x403DC95")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SetSelectedLevel;

		// Token: 0x0403DC96 RID: 253078
		[Token(Token = "0x403DC96")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetSelectedLevelToMax;

		// Token: 0x0403DC97 RID: 253079
		[Token(Token = "0x403DC97")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007726 RID: 30502
		[Token(Token = "0x2007726")]
		public struct CharUpgradeItemShowParam
		{
			// Token: 0x0403DC98 RID: 253080
			[Token(Token = "0x403DC98")]
			[FieldOffset(Offset = "0x0")]
			public string itemId;

			// Token: 0x0403DC99 RID: 253081
			[Token(Token = "0x403DC99")]
			[FieldOffset(Offset = "0x8")]
			public int currCount;

			// Token: 0x0403DC9A RID: 253082
			[Token(Token = "0x403DC9A")]
			[FieldOffset(Offset = "0xC")]
			public int origCount;

			// Token: 0x0403DC9B RID: 253083
			[Token(Token = "0x403DC9B")]
			[FieldOffset(Offset = "0x10")]
			public int discountCount;

			// Token: 0x0403DC9C RID: 253084
			[Token(Token = "0x403DC9C")]
			[FieldOffset(Offset = "0x14")]
			public bool useDiscount;
		}
	}
}
