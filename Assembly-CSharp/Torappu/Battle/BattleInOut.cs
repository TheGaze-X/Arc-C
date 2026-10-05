using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.ObjectPool;
using Torappu.UI.BattleFinish;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020B3 RID: 8371
	[Token(Token = "0x20020B3")]
	public class BattleInOut : Singleton<BattleInOut>
	{
		// Token: 0x0600CDA3 RID: 52643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDA3")]
		[Address(RVA = "0x34F8DF0", Offset = "0x34F79F0", VA = "0x1834F8DF0")]
		private BattleInOut()
		{
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x0600CDA4 RID: 52644 RVA: 0x0004A2C8 File Offset: 0x000484C8
		// (set) Token: 0x0600CDA5 RID: 52645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001848")]
		public BattleInOut.InParams input
		{
			[Token(Token = "0x600CDA4")]
			[Address(RVA = "0x34F8F70", Offset = "0x34F7B70", VA = "0x1834F8F70")]
			[CompilerGenerated]
			get
			{
				return default(BattleInOut.InParams);
			}
			[Token(Token = "0x600CDA5")]
			[Address(RVA = "0x34F9290", Offset = "0x34F7E90", VA = "0x1834F9290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x0600CDA6 RID: 52646 RVA: 0x0004A2E0 File Offset: 0x000484E0
		[Token(Token = "0x17001849")]
		public bool hasInput
		{
			[Token(Token = "0x600CDA6")]
			[Address(RVA = "0x34F8E60", Offset = "0x34F7A60", VA = "0x1834F8E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CDA7 RID: 52647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDA7")]
		[Address(RVA = "0x34F8B40", Offset = "0x34F7740", VA = "0x1834F8B40")]
		public void SetInParams(BattleInOut.InParams inParams)
		{
		}

		// Token: 0x0600CDA8 RID: 52648 RVA: 0x0004A2F8 File Offset: 0x000484F8
		[Token(Token = "0x600CDA8")]
		[Address(RVA = "0x34F8890", Offset = "0x34F7490", VA = "0x1834F8890")]
		public GameTagMeta PrepareGameTag(string gameTag)
		{
			return default(GameTagMeta);
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x0600CDA9 RID: 52649 RVA: 0x0004A310 File Offset: 0x00048510
		// (set) Token: 0x0600CDAA RID: 52650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700184A")]
		public BattleInOut.OutParams output
		{
			[Token(Token = "0x600CDA9")]
			[Address(RVA = "0x34F9110", Offset = "0x34F7D10", VA = "0x1834F9110")]
			[CompilerGenerated]
			get
			{
				return default(BattleInOut.OutParams);
			}
			[Token(Token = "0x600CDAA")]
			[Address(RVA = "0x34F9440", Offset = "0x34F8040", VA = "0x1834F9440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600CDAB RID: 52651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDAB")]
		[Address(RVA = "0x34F8D00", Offset = "0x34F7900", VA = "0x1834F8D00")]
		public void SetOutParams(BattleInOut.OutParams outParams)
		{
		}

		// Token: 0x0600CDAC RID: 52652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDAC")]
		[Address(RVA = "0x34F8720", Offset = "0x34F7320", VA = "0x1834F8720")]
		public void Clear()
		{
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x0600CDAD RID: 52653 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDAE RID: 52654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700184B")]
		public string sceneAssetPath
		{
			[Token(Token = "0x600CDAD")]
			[Address(RVA = "0x34F9230", Offset = "0x34F7E30", VA = "0x1834F9230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600CDAE")]
			[Address(RVA = "0x34F9580", Offset = "0x34F8180", VA = "0x1834F9580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0400D97C RID: 55676
		[Token(Token = "0x400D97C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400D97D RID: 55677
		[Token(Token = "0x400D97D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_input;

		// Token: 0x0400D97E RID: 55678
		[Token(Token = "0x400D97E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_input;

		// Token: 0x0400D97F RID: 55679
		[Token(Token = "0x400D97F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasInput;

		// Token: 0x0400D980 RID: 55680
		[Token(Token = "0x400D980")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetInParams;

		// Token: 0x0400D981 RID: 55681
		[Token(Token = "0x400D981")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PrepareGameTag;

		// Token: 0x0400D982 RID: 55682
		[Token(Token = "0x400D982")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_output;

		// Token: 0x0400D983 RID: 55683
		[Token(Token = "0x400D983")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_output;

		// Token: 0x0400D984 RID: 55684
		[Token(Token = "0x400D984")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetOutParams;

		// Token: 0x0400D985 RID: 55685
		[Token(Token = "0x400D985")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400D986 RID: 55686
		[Token(Token = "0x400D986")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_sceneAssetPath;

		// Token: 0x0400D987 RID: 55687
		[Token(Token = "0x400D987")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_sceneAssetPath;

		// Token: 0x020020B4 RID: 8372
		[Token(Token = "0x20020B4")]
		public struct InParams : IHotfixable
		{
			// Token: 0x0600CDAF RID: 52655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CDAF")]
			[Address(RVA = "0x3502D40", Offset = "0x3501940", VA = "0x183502D40")]
			public CampaignData GetCampaignDataOrNull()
			{
				return null;
			}

			// Token: 0x0600CDB0 RID: 52656 RVA: 0x0004A328 File Offset: 0x00048528
			[Token(Token = "0x600CDB0")]
			[Address(RVA = "0x3503000", Offset = "0x3501C00", VA = "0x183503000")]
			public bool IsCampaign()
			{
				return default(bool);
			}

			// Token: 0x0600CDB1 RID: 52657 RVA: 0x0004A340 File Offset: 0x00048540
			[Token(Token = "0x600CDB1")]
			[Address(RVA = "0x3503340", Offset = "0x3501F40", VA = "0x183503340")]
			public bool UseCampaignBattleLogSaving()
			{
				return default(bool);
			}

			// Token: 0x0600CDB2 RID: 52658 RVA: 0x0004A358 File Offset: 0x00048558
			[Token(Token = "0x600CDB2")]
			[Address(RVA = "0x3503120", Offset = "0x3501D20", VA = "0x183503120")]
			public bool IsPredefine()
			{
				return default(bool);
			}

			// Token: 0x0600CDB3 RID: 52659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CDB3")]
			[Address(RVA = "0x3503220", Offset = "0x3501E20", VA = "0x183503220")]
			public void RefreshMultipleBattleData(string newBattleId, int newApFailReturn)
			{
			}

			// Token: 0x0600CDB4 RID: 52660 RVA: 0x0004A370 File Offset: 0x00048570
			[Token(Token = "0x600CDB4")]
			[Address(RVA = "0x3502EB0", Offset = "0x3501AB0", VA = "0x183502EB0")]
			public LevelData.Difficulty GetFinalDifficulty()
			{
				return LevelData.Difficulty.NONE;
			}

			// Token: 0x0400D988 RID: 55688
			[Token(Token = "0x400D988")]
			[FieldOffset(Offset = "0x0")]
			public string battleId;

			// Token: 0x0400D989 RID: 55689
			[Token(Token = "0x400D989")]
			[FieldOffset(Offset = "0x8")]
			public LevelData levelData;

			// Token: 0x0400D98A RID: 55690
			[Token(Token = "0x400D98A")]
			[FieldOffset(Offset = "0x10")]
			public List<BattlePlayerData> playerDataList;

			// Token: 0x0400D98B RID: 55691
			[Token(Token = "0x400D98B")]
			[FieldOffset(Offset = "0x18")]
			public BattleStageInfo stageInfo;

			// Token: 0x0400D98C RID: 55692
			[Token(Token = "0x400D98C")]
			[FieldOffset(Offset = "0x88")]
			public bool isPractise;

			// Token: 0x0400D98D RID: 55693
			[Token(Token = "0x400D98D")]
			[FieldOffset(Offset = "0x89")]
			public bool isAutoBattle;

			// Token: 0x0400D98E RID: 55694
			[Token(Token = "0x400D98E")]
			[FieldOffset(Offset = "0x8A")]
			public bool isFastBattle;

			// Token: 0x0400D98F RID: 55695
			[Token(Token = "0x400D98F")]
			[FieldOffset(Offset = "0x90")]
			public BattleLogger.Journal autoBattleJournal;

			// Token: 0x0400D990 RID: 55696
			[Token(Token = "0x400D990")]
			[FieldOffset(Offset = "0xE8")]
			public SquadItemStruct[] squadLocalData;

			// Token: 0x0400D991 RID: 55697
			[Token(Token = "0x400D991")]
			[FieldOffset(Offset = "0xF0")]
			public SquadFriendData friendData;

			// Token: 0x0400D992 RID: 55698
			[Token(Token = "0x400D992")]
			[FieldOffset(Offset = "0xF8")]
			public bool assistIsFriend;

			// Token: 0x0400D993 RID: 55699
			[Token(Token = "0x400D993")]
			[FieldOffset(Offset = "0xF9")]
			public bool assistIsPredefined;

			// Token: 0x0400D994 RID: 55700
			[Token(Token = "0x400D994")]
			[FieldOffset(Offset = "0x100")]
			public BattleFinishIllust finishIllust;

			// Token: 0x0400D995 RID: 55701
			[Token(Token = "0x400D995")]
			[FieldOffset(Offset = "0x128")]
			public bool isPredefinedSquad;

			// Token: 0x0400D996 RID: 55702
			[Token(Token = "0x400D996")]
			[FieldOffset(Offset = "0x12C")]
			public LevelData.Difficulty difficulty;

			// Token: 0x0400D997 RID: 55703
			[Token(Token = "0x400D997")]
			[FieldOffset(Offset = "0x130")]
			public StageDiffGroup diffGroup;

			// Token: 0x0400D998 RID: 55704
			[Token(Token = "0x400D998")]
			[FieldOffset(Offset = "0x134")]
			public bool isApProtect;

			// Token: 0x0400D999 RID: 55705
			[Token(Token = "0x400D999")]
			[FieldOffset(Offset = "0x135")]
			public bool inApProtectPeriod;

			// Token: 0x0400D99A RID: 55706
			[Token(Token = "0x400D99A")]
			[FieldOffset(Offset = "0x138")]
			public int apCost;

			// Token: 0x0400D99B RID: 55707
			[Token(Token = "0x400D99B")]
			[FieldOffset(Offset = "0x140")]
			public string overrideBuffItemId;

			// Token: 0x0400D99C RID: 55708
			[Token(Token = "0x400D99C")]
			[FieldOffset(Offset = "0x148")]
			public int apFailReturn;

			// Token: 0x0400D99D RID: 55709
			[Token(Token = "0x400D99D")]
			[FieldOffset(Offset = "0x14C")]
			public bool notifyPowerScoreNotEnoughIfFailed;

			// Token: 0x0400D99E RID: 55710
			[Token(Token = "0x400D99E")]
			[FieldOffset(Offset = "0x150")]
			public long startTs;

			// Token: 0x0400D99F RID: 55711
			[Token(Token = "0x400D99F")]
			[FieldOffset(Offset = "0x158")]
			public bool isMultipleBattle;

			// Token: 0x0400D9A0 RID: 55712
			[Token(Token = "0x400D9A0")]
			[FieldOffset(Offset = "0x15C")]
			public int multipleBattleTimes;

			// Token: 0x0400D9A1 RID: 55713
			[Token(Token = "0x400D9A1")]
			[FieldOffset(Offset = "0x160")]
			public IRuneDataHolder runeInput;

			// Token: 0x0400D9A2 RID: 55714
			[Token(Token = "0x400D9A2")]
			[FieldOffset(Offset = "0x168")]
			public DisplayMeta displayMeta;

			// Token: 0x0400D9A3 RID: 55715
			[Token(Token = "0x400D9A3")]
			[FieldOffset(Offset = "0x170")]
			public bool isOverrideBGM;

			// Token: 0x0400D9A4 RID: 55716
			[Token(Token = "0x400D9A4")]
			[FieldOffset(Offset = "0x178")]
			public IFinishBattleServiceConfig finishBattleServiceConfig;

			// Token: 0x0400D9A5 RID: 55717
			[Token(Token = "0x400D9A5")]
			[FieldOffset(Offset = "0x180")]
			public BattleFinishIndexState.IPlugin battleFinishIndexPlugin;

			// Token: 0x0400D9A6 RID: 55718
			[Token(Token = "0x400D9A6")]
			[FieldOffset(Offset = "0x188")]
			public bool skipBattleFinishWhenFailed;

			// Token: 0x0400D9A7 RID: 55719
			[Token(Token = "0x400D9A7")]
			[FieldOffset(Offset = "0x18C")]
			public BattleSysMenuStyle sysMenuStyle;

			// Token: 0x0400D9A8 RID: 55720
			[Token(Token = "0x400D9A8")]
			[FieldOffset(Offset = "0x190")]
			public DataBundle bundleToJumpBack;

			// Token: 0x0400D9A9 RID: 55721
			[Token(Token = "0x400D9A9")]
			[FieldOffset(Offset = "0x198")]
			public bool uploadBattleLog;

			// Token: 0x0400D9AA RID: 55722
			[Token(Token = "0x400D9AA")]
			[FieldOffset(Offset = "0x1A0")]
			public string overrideBgmEvent;

			// Token: 0x0400D9AB RID: 55723
			[Token(Token = "0x400D9AB")]
			[FieldOffset(Offset = "0x1A8")]
			private CampaignData m_campaignData;

			// Token: 0x0400D9AC RID: 55724
			[Token(Token = "0x400D9AC")]
			[FieldOffset(Offset = "0x1B0")]
			public List<PoolManager.ObjectConfig> runtimeLoadConfig;

			// Token: 0x0400D9AD RID: 55725
			[Token(Token = "0x400D9AD")]
			[FieldOffset(Offset = "0x1B8")]
			public BattleActivityMeta actMeta;

			// Token: 0x0400D9AE RID: 55726
			[Token(Token = "0x400D9AE")]
			[FieldOffset(Offset = "0x1D8")]
			public BattleRoguelikeMeta roguelikeMeta;

			// Token: 0x0400D9AF RID: 55727
			[Token(Token = "0x400D9AF")]
			[FieldOffset(Offset = "0x270")]
			public BattleStageMeta stageMeta;

			// Token: 0x0400D9B0 RID: 55728
			[Token(Token = "0x400D9B0")]
			[FieldOffset(Offset = "0x278")]
			public GameModeMeta? gameModeMeta;

			// Token: 0x0400D9B1 RID: 55729
			[Token(Token = "0x400D9B1")]
			[FieldOffset(Offset = "0x290")]
			public BattleCharmMeta charmMeta;

			// Token: 0x0400D9B2 RID: 55730
			[Token(Token = "0x400D9B2")]
			[FieldOffset(Offset = "0x298")]
			public BattleTechMeta techMeta;

			// Token: 0x0400D9B3 RID: 55731
			[Token(Token = "0x400D9B3")]
			[FieldOffset(Offset = "0x2A0")]
			public BattleCartMeta cartMeta;

			// Token: 0x0400D9B4 RID: 55732
			[Token(Token = "0x400D9B4")]
			[FieldOffset(Offset = "0x2A8")]
			public BattleTrapToolMeta trapToolMeta;

			// Token: 0x0400D9B5 RID: 55733
			[Token(Token = "0x400D9B5")]
			[FieldOffset(Offset = "0x2B0")]
			public BattleTemplateTrapMeta templateTrapMeta;

			// Token: 0x0400D9B6 RID: 55734
			[Token(Token = "0x400D9B6")]
			[FieldOffset(Offset = "0x2B8")]
			public BattlePerformanceMeta battlePerformanceMeta;

			// Token: 0x0400D9B7 RID: 55735
			[Token(Token = "0x400D9B7")]
			[FieldOffset(Offset = "0x2C0")]
			public BattleFireworkMeta battleFireworkMeta;

			// Token: 0x0400D9B8 RID: 55736
			[Token(Token = "0x400D9B8")]
			[FieldOffset(Offset = "0x2D0")]
			public GameTagMeta gameTagMeta;

			// Token: 0x0400D9B9 RID: 55737
			[Token(Token = "0x400D9B9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetCampaignDataOrNull;

			// Token: 0x0400D9BA RID: 55738
			[Token(Token = "0x400D9BA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsCampaign;

			// Token: 0x0400D9BB RID: 55739
			[Token(Token = "0x400D9BB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UseCampaignBattleLogSaving;

			// Token: 0x0400D9BC RID: 55740
			[Token(Token = "0x400D9BC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsPredefine;

			// Token: 0x0400D9BD RID: 55741
			[Token(Token = "0x400D9BD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RefreshMultipleBattleData;

			// Token: 0x0400D9BE RID: 55742
			[Token(Token = "0x400D9BE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetFinalDifficulty;
		}

		// Token: 0x020020B5 RID: 8373
		[Token(Token = "0x20020B5")]
		public struct OutParams : IHotfixable
		{
			// Token: 0x0400D9BF RID: 55743
			[Token(Token = "0x400D9BF")]
			[FieldOffset(Offset = "0x0")]
			public bool isServiceSucceed;

			// Token: 0x0400D9C0 RID: 55744
			[Token(Token = "0x400D9C0")]
			[FieldOffset(Offset = "0x1")]
			public bool isGiveUp;

			// Token: 0x0400D9C1 RID: 55745
			[Token(Token = "0x400D9C1")]
			[FieldOffset(Offset = "0x8")]
			public CommonFinishBattleResponse finishResponse;

			// Token: 0x0400D9C2 RID: 55746
			[Token(Token = "0x400D9C2")]
			[FieldOffset(Offset = "0x10")]
			public PlayerBattleRank battleRank;

			// Token: 0x0400D9C3 RID: 55747
			[Token(Token = "0x400D9C3")]
			[FieldOffset(Offset = "0x14")]
			public LevelData.Difficulty difficulty;

			// Token: 0x0400D9C4 RID: 55748
			[Token(Token = "0x400D9C4")]
			[FieldOffset(Offset = "0x18")]
			public BattleFinishBkg bkg;

			// Token: 0x0400D9C5 RID: 55749
			[Token(Token = "0x400D9C5")]
			[FieldOffset(Offset = "0x28")]
			public BattleLogger.Journal journal;

			// Token: 0x0400D9C6 RID: 55750
			[Token(Token = "0x400D9C6")]
			[FieldOffset(Offset = "0x80")]
			public int leftHp;

			// Token: 0x0400D9C7 RID: 55751
			[Token(Token = "0x400D9C7")]
			[FieldOffset(Offset = "0x84")]
			public bool isAutoBattle;

			// Token: 0x0400D9C8 RID: 55752
			[Token(Token = "0x400D9C8")]
			[FieldOffset(Offset = "0x88")]
			public object actMeta;
		}
	}
}
