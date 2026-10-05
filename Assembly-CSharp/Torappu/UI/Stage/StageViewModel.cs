using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068C7 RID: 26823
	[Token(Token = "0x20068C7")]
	public class StageViewModel : IHotfixable
	{
		// Token: 0x17005ABC RID: 23228
		// (set) Token: 0x060266FC RID: 157436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005ABC")]
		public StageViewModel.LocalCache localCache
		{
			[Token(Token = "0x60266FC")]
			[Address(RVA = "0x218CAE0", Offset = "0x218B6E0", VA = "0x18218CAE0")]
			set
			{
			}
		}

		// Token: 0x17005ABD RID: 23229
		// (get) Token: 0x060266FD RID: 157437 RVA: 0x000CB0D0 File Offset: 0x000C92D0
		[Token(Token = "0x17005ABD")]
		public int apCostGroup
		{
			[Token(Token = "0x60266FD")]
			[Address(RVA = "0x218C3A0", Offset = "0x218AFA0", VA = "0x18218C3A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005ABE RID: 23230
		// (get) Token: 0x060266FE RID: 157438 RVA: 0x000CB0E8 File Offset: 0x000C92E8
		[Token(Token = "0x17005ABE")]
		public bool canAutoBattle
		{
			[Token(Token = "0x60266FE")]
			[Address(RVA = "0x218C4C0", Offset = "0x218B0C0", VA = "0x18218C4C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005ABF RID: 23231
		// (get) Token: 0x060266FF RID: 157439 RVA: 0x000CB100 File Offset: 0x000C9300
		// (set) Token: 0x06026700 RID: 157440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005ABF")]
		public int multipleBattleTimes
		{
			[Token(Token = "0x60266FF")]
			[Address(RVA = "0x218C710", Offset = "0x218B310", VA = "0x18218C710")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6026700")]
			[Address(RVA = "0x218CB70", Offset = "0x218B770", VA = "0x18218CB70")]
			set
			{
			}
		}

		// Token: 0x17005AC0 RID: 23232
		// (get) Token: 0x06026701 RID: 157441 RVA: 0x000CB118 File Offset: 0x000C9318
		[Token(Token = "0x17005AC0")]
		public bool shouldAutoBattleHidden
		{
			[Token(Token = "0x6026701")]
			[Address(RVA = "0x218C8B0", Offset = "0x218B4B0", VA = "0x18218C8B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005AC1 RID: 23233
		// (get) Token: 0x06026702 RID: 157442 RVA: 0x000CB130 File Offset: 0x000C9330
		[Token(Token = "0x17005AC1")]
		public bool canPractice
		{
			[Token(Token = "0x6026702")]
			[Address(RVA = "0x218C570", Offset = "0x218B170", VA = "0x18218C570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005AC2 RID: 23234
		// (get) Token: 0x06026703 RID: 157443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AC2")]
		public string overrideBuffId
		{
			[Token(Token = "0x6026703")]
			[Address(RVA = "0x218C7B0", Offset = "0x218B3B0", VA = "0x18218C7B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC3 RID: 23235
		// (get) Token: 0x06026704 RID: 157444 RVA: 0x000CB148 File Offset: 0x000C9348
		[Token(Token = "0x17005AC3")]
		public int styleCost
		{
			[Token(Token = "0x6026704")]
			[Address(RVA = "0x218CA70", Offset = "0x218B670", VA = "0x18218CA70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005AC4 RID: 23236
		// (get) Token: 0x06026705 RID: 157445 RVA: 0x000CB160 File Offset: 0x000C9360
		[Token(Token = "0x17005AC4")]
		public bool isLastTimeAutoBattle
		{
			[Token(Token = "0x6026705")]
			[Address(RVA = "0x218C6A0", Offset = "0x218B2A0", VA = "0x18218C6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005AC5 RID: 23237
		// (get) Token: 0x06026706 RID: 157446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AC5")]
		public string startBattleStyle
		{
			[Token(Token = "0x6026706")]
			[Address(RVA = "0x218C9D0", Offset = "0x218B5D0", VA = "0x18218C9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC6 RID: 23238
		// (get) Token: 0x06026707 RID: 157447 RVA: 0x000CB178 File Offset: 0x000C9378
		[Token(Token = "0x17005AC6")]
		public bool hasHardToShow
		{
			[Token(Token = "0x6026707")]
			[Address(RVA = "0x218C640", Offset = "0x218B240", VA = "0x18218C640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005AC7 RID: 23239
		// (get) Token: 0x06026708 RID: 157448 RVA: 0x000CB190 File Offset: 0x000C9390
		[Token(Token = "0x17005AC7")]
		public StageButtonOnMap.RankViewType StageRankViewType
		{
			[Token(Token = "0x6026708")]
			[Address(RVA = "0x218C330", Offset = "0x218AF30", VA = "0x18218C330")]
			get
			{
				return StageButtonOnMap.RankViewType.COMMON;
			}
		}

		// Token: 0x17005AC8 RID: 23240
		// (get) Token: 0x06026709 RID: 157449 RVA: 0x000CB1A8 File Offset: 0x000C93A8
		// (set) Token: 0x0602670A RID: 157450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005AC8")]
		public StageButtonInFogRenderType stageButtonInFogRenderType
		{
			[Token(Token = "0x6026709")]
			[Address(RVA = "0x218C910", Offset = "0x218B510", VA = "0x18218C910")]
			[CompilerGenerated]
			get
			{
				return StageButtonInFogRenderType.HIDE;
			}
			[Token(Token = "0x602670A")]
			[Address(RVA = "0x218CBE0", Offset = "0x218B7E0", VA = "0x18218CBE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602670B RID: 157451 RVA: 0x000CB1C0 File Offset: 0x000C93C0
		[Token(Token = "0x602670B")]
		[Address(RVA = "0x218B080", Offset = "0x2189C80", VA = "0x18218B080")]
		public bool GetSpecialStageToShow(SpecialStageType specialStageType)
		{
			return default(bool);
		}

		// Token: 0x0602670C RID: 157452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602670C")]
		public T GetSpecialStageInfo<T>(SpecialStageType specialStageType) where T : class, StageViewModel.ISpecialStageInfo
		{
			return null;
		}

		// Token: 0x17005AC9 RID: 23241
		// (get) Token: 0x0602670D RID: 157453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AC9")]
		public string stageDesc
		{
			[Token(Token = "0x602670D")]
			[Address(RVA = "0x218C970", Offset = "0x218B570", VA = "0x18218C970")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005ACA RID: 23242
		// (get) Token: 0x0602670E RID: 157454 RVA: 0x000CB1D8 File Offset: 0x000C93D8
		[Token(Token = "0x17005ACA")]
		public bool canReplayStory
		{
			[Token(Token = "0x602670E")]
			[Address(RVA = "0x218C5D0", Offset = "0x218B1D0", VA = "0x18218C5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005ACB RID: 23243
		// (get) Token: 0x0602670F RID: 157455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005ACB")]
		public List<StoryData> replayStoryData
		{
			[Token(Token = "0x602670F")]
			[Address(RVA = "0x218C840", Offset = "0x218B440", VA = "0x18218C840")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026710 RID: 157456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026710")]
		[Address(RVA = "0x218B280", Offset = "0x2189E80", VA = "0x18218B280", Slot = "4")]
		public virtual void SetGameData(StageData stageData, StageViewModel.TimelyDropOptions timelyOptions, [Optional] StageDiffGroupTable diffPart)
		{
		}

		// Token: 0x06026711 RID: 157457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026711")]
		[Address(RVA = "0x218BD10", Offset = "0x218A910", VA = "0x18218BD10")]
		public void SetPlayerData(PlayerStage playerData)
		{
		}

		// Token: 0x06026712 RID: 157458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026712")]
		[Address(RVA = "0x218B1E0", Offset = "0x2189DE0", VA = "0x18218B1E0")]
		public void RefreshData(PlayerStage playerData)
		{
		}

		// Token: 0x06026713 RID: 157459 RVA: 0x000CB1F0 File Offset: 0x000C93F0
		[Token(Token = "0x6026713")]
		[Address(RVA = "0x218BF10", Offset = "0x218AB10", VA = "0x18218BF10")]
		private StageViewModel.LazyReplayStoryInfo _LazyGetReplayStoryInfo()
		{
			return default(StageViewModel.LazyReplayStoryInfo);
		}

		// Token: 0x06026714 RID: 157460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026714")]
		[Address(RVA = "0x218C240", Offset = "0x218AE40", VA = "0x18218C240")]
		public StageViewModel()
		{
		}

		// Token: 0x04036241 RID: 221761
		[Token(Token = "0x4036241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private StageViewModel.LocalCache m_localCache;

		// Token: 0x04036242 RID: 221762
		[Token(Token = "0x4036242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x04036243 RID: 221763
		[Token(Token = "0x4036243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string levelId;

		// Token: 0x04036244 RID: 221764
		[Token(Token = "0x4036244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string zoneId;

		// Token: 0x04036245 RID: 221765
		[Token(Token = "0x4036245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string stageCode;

		// Token: 0x04036246 RID: 221766
		[Token(Token = "0x4036246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string stageName;

		// Token: 0x04036247 RID: 221767
		[Token(Token = "0x4036247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LazyRichTextFromData stageDescRichText;

		// Token: 0x04036248 RID: 221768
		[Token(Token = "0x4036248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string hardStageId;

		// Token: 0x04036249 RID: 221769
		[Token(Token = "0x4036249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string sixStarStageId;

		// Token: 0x0403624A RID: 221770
		[Token(Token = "0x403624A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<StageRewardViewModel> displayRewards;

		// Token: 0x0403624B RID: 221771
		[Token(Token = "0x403624B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string dangerDesc;

		// Token: 0x0403624C RID: 221772
		[Token(Token = "0x403624C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public StageType stageType;

		// Token: 0x0403624D RID: 221773
		[Token(Token = "0x403624D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public StageDiffGroup stageDiffGroup;

		// Token: 0x0403624E RID: 221774
		[Token(Token = "0x403624E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public StageDiffGroupTable diffGroupTable;

		// Token: 0x0403624F RID: 221775
		[Token(Token = "0x403624F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string normalDiffGroupStageId;

		// Token: 0x04036250 RID: 221776
		[Token(Token = "0x4036250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool isActivity;

		// Token: 0x04036251 RID: 221777
		[Token(Token = "0x4036251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool isCampaign;

		// Token: 0x04036252 RID: 221778
		[Token(Token = "0x4036252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool isMainProgress;

		// Token: 0x04036253 RID: 221779
		[Token(Token = "0x4036253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string mainRewardItem;

		// Token: 0x04036254 RID: 221780
		[Token(Token = "0x4036254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string rewardCharId;

		// Token: 0x04036255 RID: 221781
		[Token(Token = "0x4036255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool hasBoss;

		// Token: 0x04036256 RID: 221782
		[Token(Token = "0x4036256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isHilighted;

		// Token: 0x04036257 RID: 221783
		[Token(Token = "0x4036257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isCharacterPredefined;

		// Token: 0x04036258 RID: 221784
		[Token(Token = "0x4036258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool isHardStageCharacterPredefined;

		// Token: 0x04036259 RID: 221785
		[Token(Token = "0x4036259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isStoryOnly;

		// Token: 0x0403625A RID: 221786
		[Token(Token = "0x403625A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isTraining;

		// Token: 0x0403625B RID: 221787
		[Token(Token = "0x403625B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AppearanceStyle appearanceStyle;

		// Token: 0x0403625C RID: 221788
		[Token(Token = "0x403625C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string timelyDropActiveFlag;

		// Token: 0x0403625D RID: 221789
		[Token(Token = "0x403625D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool showApProtect;

		// Token: 0x0403625E RID: 221790
		[Token(Token = "0x403625E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		public bool canMulitpleBattle;

		// Token: 0x0403625F RID: 221791
		[Token(Token = "0x403625F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public int apCost;

		// Token: 0x04036260 RID: 221792
		[Token(Token = "0x4036260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int etCost;

		// Token: 0x04036261 RID: 221793
		[Token(Token = "0x4036261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string etItemId;

		// Token: 0x04036262 RID: 221794
		[Token(Token = "0x4036262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool isUsingEt;

		// Token: 0x04036263 RID: 221795
		[Token(Token = "0x4036263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string etStartBattleStyle;

		// Token: 0x04036264 RID: 221796
		[Token(Token = "0x4036264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public StageBattleDiffGroupInfo battleDiffGroupInfo;

		// Token: 0x04036265 RID: 221797
		[Token(Token = "0x4036265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public OverrideDropInfo overrideDropInfo;

		// Token: 0x04036266 RID: 221798
		[Token(Token = "0x4036266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool isUnlocked;

		// Token: 0x04036267 RID: 221799
		[Token(Token = "0x4036267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public PlayerStageState stageState;

		// Token: 0x04036268 RID: 221800
		[Token(Token = "0x4036268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public LevelData.Difficulty stageDifficulty;

		// Token: 0x04036269 RID: 221801
		[Token(Token = "0x4036269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private StageViewModel.SpecialStageHandler m_specialStageHandler;

		// Token: 0x0403626A RID: 221802
		[Token(Token = "0x403626A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool m_canPractice;

		// Token: 0x0403626B RID: 221803
		[Token(Token = "0x403626B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool m_hasAutoBattleLog;

		// Token: 0x0403626C RID: 221804
		[Token(Token = "0x403626C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		private bool m_canBattleReplay;

		// Token: 0x0403626D RID: 221805
		[Token(Token = "0x403626D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private int m_multipleBattleTimes;

		// Token: 0x0403626E RID: 221806
		[Token(Token = "0x403626E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool isRecentAutoBattle;

		// Token: 0x0403626F RID: 221807
		[Token(Token = "0x403626F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public int slProgress;

		// Token: 0x04036270 RID: 221808
		[Token(Token = "0x4036270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool isSkillSelectablePredefined;

		// Token: 0x04036271 RID: 221809
		[Token(Token = "0x4036271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		public bool hasZoneRecordMission;

		// Token: 0x04036272 RID: 221810
		[Token(Token = "0x4036272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
		public bool isZoneRecordMissionComplete;

		// Token: 0x04036273 RID: 221811
		[Token(Token = "0x4036273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string zoneRecordMissionDesc;

		// Token: 0x04036274 RID: 221812
		[Token(Token = "0x4036274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private StageViewModel.LazyReplayStoryInfo m_lazyReplayStoryInfo;

		// Token: 0x04036275 RID: 221813
		[Token(Token = "0x4036275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public List<ItemBundle> sixStarGroupDisplayReward;

		// Token: 0x04036276 RID: 221814
		[Token(Token = "0x4036276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool isStagePatch;

		// Token: 0x04036278 RID: 221816
		[Token(Token = "0x4036278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_localCache;

		// Token: 0x04036279 RID: 221817
		[Token(Token = "0x4036279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_apCostGroup;

		// Token: 0x0403627A RID: 221818
		[Token(Token = "0x403627A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_canAutoBattle;

		// Token: 0x0403627B RID: 221819
		[Token(Token = "0x403627B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_multipleBattleTimes;

		// Token: 0x0403627C RID: 221820
		[Token(Token = "0x403627C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_multipleBattleTimes;

		// Token: 0x0403627D RID: 221821
		[Token(Token = "0x403627D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_shouldAutoBattleHidden;

		// Token: 0x0403627E RID: 221822
		[Token(Token = "0x403627E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_canPractice;

		// Token: 0x0403627F RID: 221823
		[Token(Token = "0x403627F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_overrideBuffId;

		// Token: 0x04036280 RID: 221824
		[Token(Token = "0x4036280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_styleCost;

		// Token: 0x04036281 RID: 221825
		[Token(Token = "0x4036281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isLastTimeAutoBattle;

		// Token: 0x04036282 RID: 221826
		[Token(Token = "0x4036282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_startBattleStyle;

		// Token: 0x04036283 RID: 221827
		[Token(Token = "0x4036283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_hasHardToShow;

		// Token: 0x04036284 RID: 221828
		[Token(Token = "0x4036284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_StageRankViewType;

		// Token: 0x04036285 RID: 221829
		[Token(Token = "0x4036285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_stageButtonInFogRenderType;

		// Token: 0x04036286 RID: 221830
		[Token(Token = "0x4036286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_stageButtonInFogRenderType;

		// Token: 0x04036287 RID: 221831
		[Token(Token = "0x4036287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetSpecialStageToShow;

		// Token: 0x04036288 RID: 221832
		[Token(Token = "0x4036288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetSpecialStageInfo;

		// Token: 0x04036289 RID: 221833
		[Token(Token = "0x4036289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_stageDesc;

		// Token: 0x0403628A RID: 221834
		[Token(Token = "0x403628A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_canReplayStory;

		// Token: 0x0403628B RID: 221835
		[Token(Token = "0x403628B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_replayStoryData;

		// Token: 0x0403628C RID: 221836
		[Token(Token = "0x403628C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetGameData;

		// Token: 0x0403628D RID: 221837
		[Token(Token = "0x403628D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetPlayerData;

		// Token: 0x0403628E RID: 221838
		[Token(Token = "0x403628E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403628F RID: 221839
		[Token(Token = "0x403628F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LazyGetReplayStoryInfo;

		// Token: 0x04036290 RID: 221840
		[Token(Token = "0x4036290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020068C8 RID: 26824
		[Token(Token = "0x20068C8")]
		public struct LocalCache
		{
			// Token: 0x06026715 RID: 157461 RVA: 0x000CB208 File Offset: 0x000C9408
			[Token(Token = "0x6026715")]
			[Address(RVA = "0x217A7B0", Offset = "0x21793B0", VA = "0x18217A7B0")]
			public bool ShouldSerializeisAutoBattle()
			{
				return default(bool);
			}

			// Token: 0x06026716 RID: 157462 RVA: 0x000CB220 File Offset: 0x000C9420
			[Token(Token = "0x6026716")]
			[Address(RVA = "0x217A7C0", Offset = "0x21793C0", VA = "0x18217A7C0")]
			public bool ShouldSerializeisFastBattle()
			{
				return default(bool);
			}

			// Token: 0x04036291 RID: 221841
			[Token(Token = "0x4036291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly StageViewModel.LocalCache DEFAULT;

			// Token: 0x04036292 RID: 221842
			[Token(Token = "0x4036292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isEmpty;

			// Token: 0x04036293 RID: 221843
			[Token(Token = "0x4036293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool isAutoBattle;

			// Token: 0x04036294 RID: 221844
			[Token(Token = "0x4036294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool isFastBattle;
		}

		// Token: 0x020068C9 RID: 26825
		[Token(Token = "0x20068C9")]
		public struct StageTimelyDropMeta
		{
			// Token: 0x06026718 RID: 157464 RVA: 0x000CB238 File Offset: 0x000C9438
			[Token(Token = "0x6026718")]
			[Address(RVA = "0x218B070", Offset = "0x2189C70", VA = "0x18218B070")]
			public bool IsReplaceDrop()
			{
				return default(bool);
			}

			// Token: 0x06026719 RID: 157465 RVA: 0x000CB250 File Offset: 0x000C9450
			[Token(Token = "0x6026719")]
			[Address(RVA = "0x19233C0", Offset = "0x1921FC0", VA = "0x1819233C0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04036295 RID: 221845
			[Token(Token = "0x4036295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static StageViewModel.StageTimelyDropMeta EMPTY;

			// Token: 0x04036296 RID: 221846
			[Token(Token = "0x4036296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TimelyDropTimeInfo timeInfo;

			// Token: 0x04036297 RID: 221847
			[Token(Token = "0x4036297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public StageData.StageDropInfo dropInfo;

			// Token: 0x04036298 RID: 221848
			[Token(Token = "0x4036298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string timelyGroupId;
		}

		// Token: 0x020068CA RID: 26826
		[Token(Token = "0x20068CA")]
		public struct TimelyDropOptions
		{
			// Token: 0x0602671B RID: 157467 RVA: 0x000CB268 File Offset: 0x000C9468
			[Token(Token = "0x602671B")]
			[Address(RVA = "0x218D4E0", Offset = "0x218C0E0", VA = "0x18218D4E0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0602671C RID: 157468 RVA: 0x000CB280 File Offset: 0x000C9480
			[Token(Token = "0x602671C")]
			[Address(RVA = "0x218D3A0", Offset = "0x218BFA0", VA = "0x18218D3A0")]
			public StageViewModel.StageTimelyDropMeta GetStageMeta(string stageId)
			{
				return default(StageViewModel.StageTimelyDropMeta);
			}

			// Token: 0x04036299 RID: 221849
			[Token(Token = "0x4036299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly StageViewModel.TimelyDropOptions EMPTY;

			// Token: 0x0403629A RID: 221850
			[Token(Token = "0x403629A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string groupId;

			// Token: 0x0403629B RID: 221851
			[Token(Token = "0x403629B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public TimelyDropTimeInfo timeInfo;

			// Token: 0x0403629C RID: 221852
			[Token(Token = "0x403629C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TimelyDropInfo dropInfo;
		}

		// Token: 0x020068CB RID: 26827
		[Token(Token = "0x20068CB")]
		public interface ISpecialStageInfo : IHotfixable
		{
			// Token: 0x17005ACC RID: 23244
			// (get) Token: 0x0602671E RID: 157470
			// (set) Token: 0x0602671F RID: 157471
			[Token(Token = "0x17005ACC")]
			string stageId { [Token(Token = "0x602671E")] get; [Token(Token = "0x602671F")] set; }

			// Token: 0x06026720 RID: 157472
			[Token(Token = "0x6026720")]
			void LoadGameData(StageData stageData);

			// Token: 0x06026721 RID: 157473
			[Token(Token = "0x6026721")]
			void UpdatePlayerData(PlayerStage playerStage);
		}

		// Token: 0x020068CC RID: 26828
		[Token(Token = "0x20068CC")]
		private class SpecialStageHandler : IHotfixable
		{
			// Token: 0x17005ACD RID: 23245
			// (get) Token: 0x06026722 RID: 157474 RVA: 0x000CB298 File Offset: 0x000C9498
			// (set) Token: 0x06026723 RID: 157475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005ACD")]
			private bool hasHardToShow
			{
				[Token(Token = "0x6026722")]
				[Address(RVA = "0x217DC40", Offset = "0x217C840", VA = "0x18217DC40")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6026723")]
				[Address(RVA = "0x217DD00", Offset = "0x217C900", VA = "0x18217DD00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005ACE RID: 23246
			// (get) Token: 0x06026724 RID: 157476 RVA: 0x000CB2B0 File Offset: 0x000C94B0
			// (set) Token: 0x06026725 RID: 157477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005ACE")]
			private bool hasSixStarToShow
			{
				[Token(Token = "0x6026724")]
				[Address(RVA = "0x217DCA0", Offset = "0x217C8A0", VA = "0x18217DCA0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6026725")]
				[Address(RVA = "0x217DD70", Offset = "0x217C970", VA = "0x18217DD70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06026726 RID: 157478 RVA: 0x000CB2C8 File Offset: 0x000C94C8
			[Token(Token = "0x6026726")]
			[Address(RVA = "0x217D320", Offset = "0x217BF20", VA = "0x18217D320")]
			public bool GetHasSpecialStageToShow(SpecialStageType specialStageType)
			{
				return default(bool);
			}

			// Token: 0x06026727 RID: 157479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026727")]
			public T GetSpecialStageInfo<T>(SpecialStageType specialStageType) where T : class, StageViewModel.ISpecialStageInfo
			{
				return null;
			}

			// Token: 0x06026728 RID: 157480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026728")]
			[Address(RVA = "0x217D430", Offset = "0x217C030", VA = "0x18217D430")]
			public void RegisterSpecialStageInfo(SpecialStageType specialStageType, StageData stageData)
			{
			}

			// Token: 0x06026729 RID: 157481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026729")]
			[Address(RVA = "0x217D7F0", Offset = "0x217C3F0", VA = "0x18217D7F0")]
			public void UpdateHandler(StageViewModel stageViewModel)
			{
			}

			// Token: 0x0602672A RID: 157482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602672A")]
			[Address(RVA = "0x217D950", Offset = "0x217C550", VA = "0x18217D950")]
			public void UpdatePlayerData(PlayerStage playerStage, StageViewModel stageViewModel)
			{
			}

			// Token: 0x0602672B RID: 157483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602672B")]
			[Address(RVA = "0x217DB90", Offset = "0x217C790", VA = "0x18217DB90")]
			public SpecialStageHandler()
			{
			}

			// Token: 0x0403629D RID: 221853
			[Token(Token = "0x403629D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private EnumIntDictionary<SpecialStageType, StageViewModel.ISpecialStageInfo> m_specialStageInfoDict;

			// Token: 0x040362A0 RID: 221856
			[Token(Token = "0x40362A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hasHardToShow;

			// Token: 0x040362A1 RID: 221857
			[Token(Token = "0x40362A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_hasHardToShow;

			// Token: 0x040362A2 RID: 221858
			[Token(Token = "0x40362A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_hasSixStarToShow;

			// Token: 0x040362A3 RID: 221859
			[Token(Token = "0x40362A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_hasSixStarToShow;

			// Token: 0x040362A4 RID: 221860
			[Token(Token = "0x40362A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetHasSpecialStageToShow;

			// Token: 0x040362A5 RID: 221861
			[Token(Token = "0x40362A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetSpecialStageInfo;

			// Token: 0x040362A6 RID: 221862
			[Token(Token = "0x40362A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RegisterSpecialStageInfo;

			// Token: 0x040362A7 RID: 221863
			[Token(Token = "0x40362A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_UpdateHandler;

			// Token: 0x040362A8 RID: 221864
			[Token(Token = "0x40362A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_UpdatePlayerData;

			// Token: 0x040362A9 RID: 221865
			[Token(Token = "0x40362A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020068CD RID: 26829
		[Token(Token = "0x20068CD")]
		public class StageSixStarInfo : StageViewModel.ISpecialStageInfo, IHotfixable
		{
			// Token: 0x17005ACF RID: 23247
			// (get) Token: 0x0602672C RID: 157484 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602672D RID: 157485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005ACF")]
			public string stageId
			{
				[Token(Token = "0x602672C")]
				[Address(RVA = "0x2186B30", Offset = "0x2185730", VA = "0x182186B30", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602672D")]
				[Address(RVA = "0x2186B90", Offset = "0x2185790", VA = "0x182186B90", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0602672E RID: 157486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602672E")]
			[Address(RVA = "0x21867B0", Offset = "0x21853B0", VA = "0x1821867B0", Slot = "6")]
			public void LoadGameData(StageData stageData)
			{
			}

			// Token: 0x0602672F RID: 157487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602672F")]
			[Address(RVA = "0x2186860", Offset = "0x2185460", VA = "0x182186860", Slot = "7")]
			public void UpdatePlayerData(PlayerStage playerStage)
			{
			}

			// Token: 0x06026730 RID: 157488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026730")]
			[Address(RVA = "0x2186560", Offset = "0x2185160", VA = "0x182186560")]
			public List<string> GetSelectedRuneKeys()
			{
				return null;
			}

			// Token: 0x06026731 RID: 157489 RVA: 0x000CB2E0 File Offset: 0x000C94E0
			[Token(Token = "0x6026731")]
			[Address(RVA = "0x2186450", Offset = "0x2185050", VA = "0x182186450")]
			public bool CheckIfNeedSelectedRunes()
			{
				return default(bool);
			}

			// Token: 0x06026732 RID: 157490 RVA: 0x000CB2F8 File Offset: 0x000C94F8
			[Token(Token = "0x6026732")]
			[Address(RVA = "0x21864E0", Offset = "0x21850E0", VA = "0x1821864E0")]
			public int GetApCost(int oriApCost)
			{
				return 0;
			}

			// Token: 0x06026733 RID: 157491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026733")]
			[Address(RVA = "0x2186A40", Offset = "0x2185640", VA = "0x182186A40")]
			public StageSixStarInfo()
			{
			}

			// Token: 0x040362AA RID: 221866
			[Token(Token = "0x40362AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sixStarStageDesc;

			// Token: 0x040362AB RID: 221867
			[Token(Token = "0x40362AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<string> advancedRuneIdList1;

			// Token: 0x040362AC RID: 221868
			[Token(Token = "0x40362AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<string> advancedRuneIdList2;

			// Token: 0x040362AD RID: 221869
			[Token(Token = "0x40362AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int linkedStageApCost;

			// Token: 0x040362AE RID: 221870
			[Token(Token = "0x40362AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool needShowCompatible;

			// Token: 0x040362AF RID: 221871
			[Token(Token = "0x40362AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlayerSixStarTagFinishState tagFinishState;

			// Token: 0x040362B0 RID: 221872
			[Token(Token = "0x40362B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<string> selectedRunes;

			// Token: 0x040362B1 RID: 221873
			[Token(Token = "0x40362B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public SixStarStagePreviewView.StageSixStarRuneStatus curStageSixStarRuneStatus;

			// Token: 0x040362B3 RID: 221875
			[Token(Token = "0x40362B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_stageId;

			// Token: 0x040362B4 RID: 221876
			[Token(Token = "0x40362B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_stageId;

			// Token: 0x040362B5 RID: 221877
			[Token(Token = "0x40362B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LoadGameData;

			// Token: 0x040362B6 RID: 221878
			[Token(Token = "0x40362B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdatePlayerData;

			// Token: 0x040362B7 RID: 221879
			[Token(Token = "0x40362B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetSelectedRuneKeys;

			// Token: 0x040362B8 RID: 221880
			[Token(Token = "0x40362B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CheckIfNeedSelectedRunes;

			// Token: 0x040362B9 RID: 221881
			[Token(Token = "0x40362B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetApCost;

			// Token: 0x040362BA RID: 221882
			[Token(Token = "0x40362BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020068CE RID: 26830
		[Token(Token = "0x20068CE")]
		private struct LazyReplayStoryInfo
		{
			// Token: 0x17005AD0 RID: 23248
			// (get) Token: 0x06026734 RID: 157492 RVA: 0x000CB310 File Offset: 0x000C9510
			// (set) Token: 0x06026735 RID: 157493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005AD0")]
			public bool isEmpty
			{
				[Token(Token = "0x6026734")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x6026735")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x040362BB RID: 221883
			[Token(Token = "0x40362BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly StageViewModel.LazyReplayStoryInfo EMPTY;

			// Token: 0x040362BD RID: 221885
			[Token(Token = "0x40362BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool canReplay;

			// Token: 0x040362BE RID: 221886
			[Token(Token = "0x40362BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<StoryData> replayStories;
		}
	}
}
