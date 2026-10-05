using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F17 RID: 24343
	[Token(Token = "0x2005F17")]
	public class CharacterLvlupViewModel : IHotfixable
	{
		// Token: 0x17005364 RID: 21348
		// (get) Token: 0x0602343A RID: 144442 RVA: 0x000C0528 File Offset: 0x000BE728
		// (set) Token: 0x0602343B RID: 144443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005364")]
		public CharacterLvlupViewModel.EditMode editMode
		{
			[Token(Token = "0x602343A")]
			[Address(RVA = "0x1DCB7B0", Offset = "0x1DCA3B0", VA = "0x181DCB7B0")]
			[CompilerGenerated]
			get
			{
				return CharacterLvlupViewModel.EditMode.CARD_MODE;
			}
			[Token(Token = "0x602343B")]
			[Address(RVA = "0x1DCB980", Offset = "0x1DCA580", VA = "0x181DCB980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005365 RID: 21349
		// (get) Token: 0x0602343C RID: 144444 RVA: 0x000C0540 File Offset: 0x000BE740
		// (set) Token: 0x0602343D RID: 144445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005365")]
		public bool isCounting
		{
			[Token(Token = "0x602343C")]
			[Address(RVA = "0x1DCB810", Offset = "0x1DCA410", VA = "0x181DCB810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602343D")]
			[Address(RVA = "0x1DCB9F0", Offset = "0x1DCA5F0", VA = "0x181DCB9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005366 RID: 21350
		// (get) Token: 0x0602343E RID: 144446 RVA: 0x000C0558 File Offset: 0x000BE758
		[Token(Token = "0x17005366")]
		public bool isScrollMode
		{
			[Token(Token = "0x602343E")]
			[Address(RVA = "0x1DCB870", Offset = "0x1DCA470", VA = "0x181DCB870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005367 RID: 21351
		// (get) Token: 0x0602343F RID: 144447 RVA: 0x000C0570 File Offset: 0x000BE770
		[Token(Token = "0x17005367")]
		public int wasteExp
		{
			[Token(Token = "0x602343F")]
			[Address(RVA = "0x1DCB920", Offset = "0x1DCA520", VA = "0x181DCB920")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06023440 RID: 144448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023440")]
		[Address(RVA = "0x1DC8DF0", Offset = "0x1DC79F0", VA = "0x181DC8DF0")]
		public void SetEditModeAndCounting(CharacterLvlupViewModel.EditMode mode, bool setCounting = false)
		{
		}

		// Token: 0x06023441 RID: 144449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023441")]
		[Address(RVA = "0x1DC8AB0", Offset = "0x1DC76B0", VA = "0x181DC8AB0")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x06023442 RID: 144450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023442")]
		[Address(RVA = "0x1DC7EA0", Offset = "0x1DC6AA0", VA = "0x181DC7EA0")]
		public void ApplyAdditionalExp(int addExp)
		{
		}

		// Token: 0x06023443 RID: 144451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023443")]
		[Address(RVA = "0x1DC9170", Offset = "0x1DC7D70", VA = "0x181DC9170")]
		public void TryModifyScrollIndex(int index, out bool needNoMoreScroll)
		{
		}

		// Token: 0x06023444 RID: 144452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023444")]
		[Address(RVA = "0x1DC9320", Offset = "0x1DC7F20", VA = "0x181DC9320")]
		public void TryModifyScrollToLevel(int targetLevel, out bool isSameLevel)
		{
		}

		// Token: 0x06023445 RID: 144453 RVA: 0x000C0588 File Offset: 0x000BE788
		[Token(Token = "0x6023445")]
		[Address(RVA = "0x1DC81D0", Offset = "0x1DC6DD0", VA = "0x181DC81D0")]
		public int CalcCurrentAddExp()
		{
			return 0;
		}

		// Token: 0x06023446 RID: 144454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023446")]
		[Address(RVA = "0x1DC7F90", Offset = "0x1DC6B90", VA = "0x181DC7F90")]
		public void CacheExpAndGoldSelectedStatus()
		{
		}

		// Token: 0x06023447 RID: 144455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023447")]
		[Address(RVA = "0x1DC8860", Offset = "0x1DC7460", VA = "0x181DC8860")]
		public void ConsumeCachedStatus()
		{
		}

		// Token: 0x06023448 RID: 144456 RVA: 0x000C05A0 File Offset: 0x000BE7A0
		[Token(Token = "0x6023448")]
		[Address(RVA = "0x1DC8A10", Offset = "0x1DC7610", VA = "0x181DC8A10")]
		public bool IsCurrentMaxLevel()
		{
			return default(bool);
		}

		// Token: 0x06023449 RID: 144457 RVA: 0x000C05B8 File Offset: 0x000BE7B8
		[Token(Token = "0x6023449")]
		[Address(RVA = "0x1DC8990", Offset = "0x1DC7590", VA = "0x181DC8990")]
		public bool IsCurrentMaxEvolve()
		{
			return default(bool);
		}

		// Token: 0x0602344A RID: 144458 RVA: 0x000C05D0 File Offset: 0x000BE7D0
		[Token(Token = "0x602344A")]
		[Address(RVA = "0x1DC8630", Offset = "0x1DC7230", VA = "0x181DC8630")]
		public bool CheckExpValid(out int lackExp)
		{
			return default(bool);
		}

		// Token: 0x0602344B RID: 144459 RVA: 0x000C05E8 File Offset: 0x000BE7E8
		[Token(Token = "0x602344B")]
		[Address(RVA = "0x1DC8790", Offset = "0x1DC7390", VA = "0x181DC8790")]
		public bool CheckGoldValid(out long lackGold)
		{
			return default(bool);
		}

		// Token: 0x0602344C RID: 144460 RVA: 0x000C0600 File Offset: 0x000BE800
		[Token(Token = "0x602344C")]
		[Address(RVA = "0x1DC83A0", Offset = "0x1DC6FA0", VA = "0x181DC83A0")]
		public bool CalcEstimateLackExpCount(int lackExp, out string expName, out int expCount)
		{
			return default(bool);
		}

		// Token: 0x0602344D RID: 144461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602344D")]
		[Address(RVA = "0x1DC9440", Offset = "0x1DC8040", VA = "0x181DC9440")]
		private void _ApplyAdditionWithTargetLevelInfo(CharacterLvlupViewModel.LevelInfo targetLevelInfo)
		{
		}

		// Token: 0x0602344E RID: 144462 RVA: 0x000C0618 File Offset: 0x000BE818
		[Token(Token = "0x602344E")]
		[Address(RVA = "0x1DCAB50", Offset = "0x1DC9750", VA = "0x181DCAB50")]
		private CharacterLvlupViewModel.LevelInfo _CalcTargetLevel(int addExp)
		{
			return default(CharacterLvlupViewModel.LevelInfo);
		}

		// Token: 0x0602344F RID: 144463 RVA: 0x000C0630 File Offset: 0x000BE830
		[Token(Token = "0x602344F")]
		[Address(RVA = "0x1DC9900", Offset = "0x1DC8500", VA = "0x181DC9900")]
		private int _CalcExpsToTargetLevel(int level)
		{
			return 0;
		}

		// Token: 0x06023450 RID: 144464 RVA: 0x000C0648 File Offset: 0x000BE848
		[Token(Token = "0x6023450")]
		[Address(RVA = "0x1DC9A20", Offset = "0x1DC8620", VA = "0x181DC9A20")]
		private int _CalcMaxValidLevel()
		{
			return 0;
		}

		// Token: 0x06023451 RID: 144465 RVA: 0x000C0660 File Offset: 0x000BE860
		[Token(Token = "0x6023451")]
		[Address(RVA = "0x1DCA250", Offset = "0x1DC8E50", VA = "0x181DCA250")]
		private CharacterLvlupViewModel.ExpAndGoldSelectedStatus _CalcStatusToLevel(int level)
		{
			return default(CharacterLvlupViewModel.ExpAndGoldSelectedStatus);
		}

		// Token: 0x06023452 RID: 144466 RVA: 0x000C0678 File Offset: 0x000BE878
		[Token(Token = "0x6023452")]
		[Address(RVA = "0x1DCB0B0", Offset = "0x1DC9CB0", VA = "0x181DCB0B0")]
		private static int _CalcValidCountWithExpItemLimit(CharacterLvlupItemCardViewModel[] expItems, int totalExp, int[] expCountArray)
		{
			return 0;
		}

		// Token: 0x06023453 RID: 144467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023453")]
		[Address(RVA = "0x1DC9780", Offset = "0x1DC8380", VA = "0x181DC9780")]
		private static void _CalcExpCountWithoutLimit(CharacterLvlupItemCardViewModel[] expItems, int leftExp, int[] expCountArray)
		{
		}

		// Token: 0x06023454 RID: 144468 RVA: 0x000C0690 File Offset: 0x000BE890
		[Token(Token = "0x6023454")]
		[Address(RVA = "0x1DCB410", Offset = "0x1DCA010", VA = "0x181DCB410")]
		private static bool _CheckTargetExpReachable(CharacterLvlupItemCardViewModel[] expItems, int targetExp)
		{
			return default(bool);
		}

		// Token: 0x06023455 RID: 144469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023455")]
		[Address(RVA = "0x1DCB580", Offset = "0x1DCA180", VA = "0x181DCB580")]
		public CharacterLvlupViewModel()
		{
		}

		// Token: 0x040309A2 RID: 199074
		[Token(Token = "0x40309A2")]
		[FieldOffset(Offset = "0x10")]
		public EvolvePhase evolvePhase;

		// Token: 0x040309A3 RID: 199075
		[Token(Token = "0x40309A3")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;

		// Token: 0x040309A4 RID: 199076
		[Token(Token = "0x40309A4")]
		[FieldOffset(Offset = "0x20")]
		public int potentialRank;

		// Token: 0x040309A5 RID: 199077
		[Token(Token = "0x40309A5")]
		[FieldOffset(Offset = "0x24")]
		public int mainSkillLvl;

		// Token: 0x040309A6 RID: 199078
		[Token(Token = "0x40309A6")]
		[FieldOffset(Offset = "0x28")]
		public string powerId;

		// Token: 0x040309A7 RID: 199079
		[Token(Token = "0x40309A7")]
		[FieldOffset(Offset = "0x30")]
		public Sprite campLogo;

		// Token: 0x040309A8 RID: 199080
		[Token(Token = "0x40309A8")]
		[FieldOffset(Offset = "0x38")]
		public UplevelAttribute currentAttr;

		// Token: 0x040309A9 RID: 199081
		[Token(Token = "0x40309A9")]
		[FieldOffset(Offset = "0x48")]
		public int currentLevel;

		// Token: 0x040309AA RID: 199082
		[Token(Token = "0x40309AA")]
		[FieldOffset(Offset = "0x4C")]
		public UplevelAttribute targetAttr;

		// Token: 0x040309AB RID: 199083
		[Token(Token = "0x40309AB")]
		[FieldOffset(Offset = "0x5C")]
		public int targetLevel;

		// Token: 0x040309AC RID: 199084
		[Token(Token = "0x40309AC")]
		[FieldOffset(Offset = "0x60")]
		public int targetExp;

		// Token: 0x040309AD RID: 199085
		[Token(Token = "0x40309AD")]
		[FieldOffset(Offset = "0x64")]
		public int maxExp;

		// Token: 0x040309AE RID: 199086
		[Token(Token = "0x40309AE")]
		[FieldOffset(Offset = "0x68")]
		public float currentExpProgress;

		// Token: 0x040309AF RID: 199087
		[Token(Token = "0x40309AF")]
		[FieldOffset(Offset = "0x6C")]
		public float targetExpProgress;

		// Token: 0x040309B0 RID: 199088
		[Token(Token = "0x40309B0")]
		[FieldOffset(Offset = "0x70")]
		public int additionExpValue;

		// Token: 0x040309B1 RID: 199089
		[Token(Token = "0x40309B1")]
		[FieldOffset(Offset = "0x74")]
		public bool isMax;

		// Token: 0x040309B2 RID: 199090
		[Token(Token = "0x40309B2")]
		[FieldOffset(Offset = "0x78")]
		public int maxValidLevel;

		// Token: 0x040309B3 RID: 199091
		[Token(Token = "0x40309B3")]
		[FieldOffset(Offset = "0x80")]
		public CharacterLvlupItemCollectionViewModel itemCollectionViewModel;

		// Token: 0x040309B4 RID: 199092
		[Token(Token = "0x40309B4")]
		[FieldOffset(Offset = "0x88")]
		public CharacterLvlupWheelViewModel wheelViewModel;

		// Token: 0x040309B7 RID: 199095
		[Token(Token = "0x40309B7")]
		[FieldOffset(Offset = "0x98")]
		private PlayerCharacter m_playerChar;

		// Token: 0x040309B8 RID: 199096
		[Token(Token = "0x40309B8")]
		[FieldOffset(Offset = "0xA0")]
		private CharacterData m_charData;

		// Token: 0x040309B9 RID: 199097
		[Token(Token = "0x40309B9")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cachedMaxLevelExp;

		// Token: 0x040309BA RID: 199098
		[Token(Token = "0x40309BA")]
		[FieldOffset(Offset = "0xB0")]
		private CharacterLvlupViewModel.ExpAndGoldSelectedStatus m_cachedStatus;

		// Token: 0x040309BB RID: 199099
		[Token(Token = "0x40309BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_editMode;

		// Token: 0x040309BC RID: 199100
		[Token(Token = "0x40309BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_editMode;

		// Token: 0x040309BD RID: 199101
		[Token(Token = "0x40309BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isCounting;

		// Token: 0x040309BE RID: 199102
		[Token(Token = "0x40309BE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isCounting;

		// Token: 0x040309BF RID: 199103
		[Token(Token = "0x40309BF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isScrollMode;

		// Token: 0x040309C0 RID: 199104
		[Token(Token = "0x40309C0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_wasteExp;

		// Token: 0x040309C1 RID: 199105
		[Token(Token = "0x40309C1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetEditModeAndCounting;

		// Token: 0x040309C2 RID: 199106
		[Token(Token = "0x40309C2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040309C3 RID: 199107
		[Token(Token = "0x40309C3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyAdditionalExp;

		// Token: 0x040309C4 RID: 199108
		[Token(Token = "0x40309C4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryModifyScrollIndex;

		// Token: 0x040309C5 RID: 199109
		[Token(Token = "0x40309C5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryModifyScrollToLevel;

		// Token: 0x040309C6 RID: 199110
		[Token(Token = "0x40309C6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CalcCurrentAddExp;

		// Token: 0x040309C7 RID: 199111
		[Token(Token = "0x40309C7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CacheExpAndGoldSelectedStatus;

		// Token: 0x040309C8 RID: 199112
		[Token(Token = "0x40309C8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ConsumeCachedStatus;

		// Token: 0x040309C9 RID: 199113
		[Token(Token = "0x40309C9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsCurrentMaxLevel;

		// Token: 0x040309CA RID: 199114
		[Token(Token = "0x40309CA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_IsCurrentMaxEvolve;

		// Token: 0x040309CB RID: 199115
		[Token(Token = "0x40309CB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckExpValid;

		// Token: 0x040309CC RID: 199116
		[Token(Token = "0x40309CC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckGoldValid;

		// Token: 0x040309CD RID: 199117
		[Token(Token = "0x40309CD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CalcEstimateLackExpCount;

		// Token: 0x040309CE RID: 199118
		[Token(Token = "0x40309CE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ApplyAdditionWithTargetLevelInfo;

		// Token: 0x040309CF RID: 199119
		[Token(Token = "0x40309CF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CalcTargetLevel;

		// Token: 0x040309D0 RID: 199120
		[Token(Token = "0x40309D0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CalcExpsToTargetLevel;

		// Token: 0x040309D1 RID: 199121
		[Token(Token = "0x40309D1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CalcMaxValidLevel;

		// Token: 0x040309D2 RID: 199122
		[Token(Token = "0x40309D2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CalcStatusToLevel;

		// Token: 0x040309D3 RID: 199123
		[Token(Token = "0x40309D3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CalcValidCountWithExpItemLimit;

		// Token: 0x040309D4 RID: 199124
		[Token(Token = "0x40309D4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CalcExpCountWithoutLimit;

		// Token: 0x040309D5 RID: 199125
		[Token(Token = "0x40309D5")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckTargetExpReachable;

		// Token: 0x040309D6 RID: 199126
		[Token(Token = "0x40309D6")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F18 RID: 24344
		[Token(Token = "0x2005F18")]
		private struct LevelInfo
		{
			// Token: 0x040309D7 RID: 199127
			[Token(Token = "0x40309D7")]
			[FieldOffset(Offset = "0x0")]
			public int level;

			// Token: 0x040309D8 RID: 199128
			[Token(Token = "0x40309D8")]
			[FieldOffset(Offset = "0x4")]
			public int exp;

			// Token: 0x040309D9 RID: 199129
			[Token(Token = "0x40309D9")]
			[FieldOffset(Offset = "0x8")]
			public int maxExp;

			// Token: 0x040309DA RID: 199130
			[Token(Token = "0x40309DA")]
			[FieldOffset(Offset = "0x10")]
			public long requiredGold;

			// Token: 0x040309DB RID: 199131
			[Token(Token = "0x40309DB")]
			[FieldOffset(Offset = "0x18")]
			public int additionExp;
		}

		// Token: 0x02005F19 RID: 24345
		[Token(Token = "0x2005F19")]
		public enum EditMode
		{
			// Token: 0x040309DD RID: 199133
			[Token(Token = "0x40309DD")]
			CARD_MODE,
			// Token: 0x040309DE RID: 199134
			[Token(Token = "0x40309DE")]
			SCROLL_MODE
		}

		// Token: 0x02005F1A RID: 24346
		[Token(Token = "0x2005F1A")]
		private struct ExpAndGoldSelectedStatus
		{
			// Token: 0x040309DF RID: 199135
			[Token(Token = "0x40309DF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CharacterLvlupViewModel.ExpAndGoldSelectedStatus EMPTY;

			// Token: 0x040309E0 RID: 199136
			[Token(Token = "0x40309E0")]
			[FieldOffset(Offset = "0x0")]
			public int[] expCountArray;

			// Token: 0x040309E1 RID: 199137
			[Token(Token = "0x40309E1")]
			[FieldOffset(Offset = "0x8")]
			public CharacterLvlupViewModel.LevelInfo levelInfo;
		}
	}
}
