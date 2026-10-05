using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Activity;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200457F RID: 17791
	[Token(Token = "0x200457F")]
	public class RoguelikeTopicModeViewModel : IHotfixable
	{
		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x0601B15F RID: 110943 RVA: 0x000A4508 File Offset: 0x000A2708
		// (set) Token: 0x0601B160 RID: 110944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700408E")]
		public bool showDiffDetail
		{
			[Token(Token = "0x601B15F")]
			[Address(RVA = "0x143BD70", Offset = "0x143A970", VA = "0x18143BD70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601B160")]
			[Address(RVA = "0x143BF20", Offset = "0x143AB20", VA = "0x18143BF20")]
			set
			{
			}
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x0601B161 RID: 110945 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B162 RID: 110946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700408F")]
		public RoguelikeTopicDetail topicData
		{
			[Token(Token = "0x601B161")]
			[Address(RVA = "0x143BDD0", Offset = "0x143A9D0", VA = "0x18143BDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B162")]
			[Address(RVA = "0x143BFB0", Offset = "0x143ABB0", VA = "0x18143BFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x0601B163 RID: 110947 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B164 RID: 110948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004090")]
		public PlayerRoguelikeV2.OuterData playerOuterData
		{
			[Token(Token = "0x601B163")]
			[Address(RVA = "0x143BD10", Offset = "0x143A910", VA = "0x18143BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B164")]
			[Address(RVA = "0x143BEA0", Offset = "0x143AAA0", VA = "0x18143BEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x0601B165 RID: 110949 RVA: 0x000A4520 File Offset: 0x000A2720
		// (set) Token: 0x0601B166 RID: 110950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004091")]
		public int modeGrade
		{
			[Token(Token = "0x601B165")]
			[Address(RVA = "0x143BCB0", Offset = "0x143A8B0", VA = "0x18143BCB0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601B166")]
			[Address(RVA = "0x143BE30", Offset = "0x143AA30", VA = "0x18143BE30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B167 RID: 110951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B167")]
		public T GetExtension<T>() where T : RoguelikeTopicModeViewModelExtension
		{
			return null;
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x0601B168 RID: 110952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004092")]
		public List<RoguelikeTopicDifficultyViewModel> difficultyList
		{
			[Token(Token = "0x601B168")]
			[Address(RVA = "0x143BAC0", Offset = "0x143A6C0", VA = "0x18143BAC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x0601B169 RID: 110953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004093")]
		public RoguelikeTopicDifficultyViewModel currentSelectDiffModel
		{
			[Token(Token = "0x601B169")]
			[Address(RVA = "0x143BA60", Offset = "0x143A660", VA = "0x18143BA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x0601B16A RID: 110954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004094")]
		public string hardModeName
		{
			[Token(Token = "0x601B16A")]
			[Address(RVA = "0x143BB20", Offset = "0x143A720", VA = "0x18143BB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B16B RID: 110955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B16B")]
		[Address(RVA = "0x14397C0", Offset = "0x14383C0", VA = "0x1814397C0")]
		public void LoadData(string topicId, RoguelikeTopicModeViewModelExtension extension)
		{
		}

		// Token: 0x0601B16C RID: 110956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B16C")]
		[Address(RVA = "0x143A040", Offset = "0x1438C40", VA = "0x18143A040")]
		public void SetCurrentDifficulty(RoguelikeTopicDifficultyID diffId)
		{
		}

		// Token: 0x0601B16D RID: 110957 RVA: 0x000A4538 File Offset: 0x000A2738
		[Token(Token = "0x601B16D")]
		[Address(RVA = "0x143A770", Offset = "0x1439370", VA = "0x18143A770")]
		private RoguelikeTopicDifficultyID _InitAndLoadLastDifficulty(string topicId)
		{
			return default(RoguelikeTopicDifficultyID);
		}

		// Token: 0x0601B16E RID: 110958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B16E")]
		[Address(RVA = "0x143B1F0", Offset = "0x1439DF0", VA = "0x18143B1F0")]
		private void _UpdateTopicCommonData(string topic)
		{
		}

		// Token: 0x0601B16F RID: 110959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B16F")]
		[Address(RVA = "0x143ADD0", Offset = "0x14399D0", VA = "0x18143ADD0")]
		private void _UpdateDifficultyList(string topicId)
		{
		}

		// Token: 0x0601B170 RID: 110960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B170")]
		[Address(RVA = "0x1439730", Offset = "0x1438330", VA = "0x181439730")]
		public string GetCurrentActiveMonthSquadId()
		{
			return null;
		}

		// Token: 0x0601B171 RID: 110961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B171")]
		[Address(RVA = "0x143A1F0", Offset = "0x1438DF0", VA = "0x18143A1F0")]
		public void SetCurrentMonthSquadId(string monthSquadId)
		{
		}

		// Token: 0x0601B172 RID: 110962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B172")]
		[Address(RVA = "0x143A500", Offset = "0x1439100", VA = "0x18143A500")]
		public void SwitchMonthSquadList(int delta)
		{
		}

		// Token: 0x0601B173 RID: 110963 RVA: 0x000A4550 File Offset: 0x000A2750
		[Token(Token = "0x601B173")]
		[Address(RVA = "0x143A3D0", Offset = "0x1438FD0", VA = "0x18143A3D0")]
		public bool SetSelectedChallenge(string challengeId)
		{
			return default(bool);
		}

		// Token: 0x0601B174 RID: 110964 RVA: 0x000A4568 File Offset: 0x000A2768
		[Token(Token = "0x601B174")]
		[Address(RVA = "0x1439380", Offset = "0x1437F80", VA = "0x181439380")]
		public bool CheckIfOpened(string topicId, RoguelikeTopicModeViewType viewType)
		{
			return default(bool);
		}

		// Token: 0x0601B175 RID: 110965 RVA: 0x000A4580 File Offset: 0x000A2780
		[Token(Token = "0x601B175")]
		[Address(RVA = "0x1439590", Offset = "0x1438190", VA = "0x181439590")]
		public bool CheckIfUnlocked(string topicId, RoguelikeTopicModeViewType viewType)
		{
			return default(bool);
		}

		// Token: 0x0601B176 RID: 110966 RVA: 0x000A4598 File Offset: 0x000A2798
		[Token(Token = "0x601B176")]
		[Address(RVA = "0x14392B0", Offset = "0x1437EB0", VA = "0x1814392B0")]
		public bool CheckIfModeViewTypeSelectable(RoguelikeTopicModeViewType viewType)
		{
			return default(bool);
		}

		// Token: 0x0601B177 RID: 110967 RVA: 0x000A45B0 File Offset: 0x000A27B0
		[Token(Token = "0x601B177")]
		[Address(RVA = "0x143A6D0", Offset = "0x14392D0", VA = "0x18143A6D0")]
		private RoguelikeTopicModeViewType _CheckCurrentShowMode()
		{
			return RoguelikeTopicModeViewType.NONE;
		}

		// Token: 0x0601B178 RID: 110968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B178")]
		[Address(RVA = "0x143A830", Offset = "0x1439430", VA = "0x18143A830")]
		private void _LoadBpInfo(string topicId)
		{
		}

		// Token: 0x0601B179 RID: 110969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B179")]
		[Address(RVA = "0x143AC30", Offset = "0x1439830", VA = "0x18143AC30")]
		private void _LoadSPOperatorInfo(string topicId)
		{
		}

		// Token: 0x0601B17A RID: 110970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B17A")]
		[Address(RVA = "0x143AB10", Offset = "0x1439710", VA = "0x18143AB10")]
		private void _LoadRogueActivityEntryCompModel()
		{
		}

		// Token: 0x0601B17B RID: 110971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B17B")]
		[Address(RVA = "0x1439FC0", Offset = "0x1438BC0", VA = "0x181439FC0")]
		public void PopDiffSubView()
		{
		}

		// Token: 0x0601B17C RID: 110972 RVA: 0x000A45C8 File Offset: 0x000A27C8
		[Token(Token = "0x601B17C")]
		[Address(RVA = "0x1439230", Offset = "0x1437E30", VA = "0x181439230")]
		public bool CheckDiffSubViewVisible(RoguelikeTopicDifficultyViewSub sub)
		{
			return default(bool);
		}

		// Token: 0x0601B17D RID: 110973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B17D")]
		[Address(RVA = "0x143A310", Offset = "0x1438F10", VA = "0x18143A310")]
		public void SetDiffSubViewVisible(RoguelikeTopicDifficultyViewSub sub, bool v)
		{
		}

		// Token: 0x0601B17E RID: 110974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B17E")]
		[Address(RVA = "0x143B7E0", Offset = "0x143A3E0", VA = "0x18143B7E0")]
		public RoguelikeTopicModeViewModel()
		{
		}

		// Token: 0x04022D57 RID: 142679
		[Token(Token = "0x4022D57")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicModeViewType showMode;

		// Token: 0x04022D58 RID: 142680
		[Token(Token = "0x4022D58")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicMonthSquadViewModel monthSquad;

		// Token: 0x04022D59 RID: 142681
		[Token(Token = "0x4022D59")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicChallengeModeViewModel challenge;

		// Token: 0x04022D5A RID: 142682
		[Token(Token = "0x4022D5A")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeTopicActivityEntryCompBaseModel actCompModel;

		// Token: 0x04022D5B RID: 142683
		[Token(Token = "0x4022D5B")]
		[FieldOffset(Offset = "0x30")]
		public bool haveTopicActive;

		// Token: 0x04022D5C RID: 142684
		[Token(Token = "0x4022D5C")]
		[FieldOffset(Offset = "0x38")]
		public long lastTs;

		// Token: 0x04022D5D RID: 142685
		[Token(Token = "0x4022D5D")]
		[FieldOffset(Offset = "0x40")]
		public string cacheTopicId;

		// Token: 0x04022D5E RID: 142686
		[Token(Token = "0x4022D5E")]
		[FieldOffset(Offset = "0x48")]
		public string kvName;

		// Token: 0x04022D5F RID: 142687
		[Token(Token = "0x4022D5F")]
		[FieldOffset(Offset = "0x50")]
		public string outerBuffCompleteText;

		// Token: 0x04022D60 RID: 142688
		[Token(Token = "0x4022D60")]
		[FieldOffset(Offset = "0x58")]
		public int bpPoint;

		// Token: 0x04022D61 RID: 142689
		[Token(Token = "0x4022D61")]
		[FieldOffset(Offset = "0x5C")]
		public int bpLevel;

		// Token: 0x04022D62 RID: 142690
		[Token(Token = "0x4022D62")]
		[FieldOffset(Offset = "0x60")]
		public bool isUpdateBp;

		// Token: 0x04022D63 RID: 142691
		[Token(Token = "0x4022D63")]
		[FieldOffset(Offset = "0x61")]
		public bool isFullStored;

		// Token: 0x04022D64 RID: 142692
		[Token(Token = "0x4022D64")]
		[FieldOffset(Offset = "0x68")]
		public string bpUpdateCountdownStr;

		// Token: 0x04022D65 RID: 142693
		[Token(Token = "0x4022D65")]
		[FieldOffset(Offset = "0x70")]
		public string bpUpdateName;

		// Token: 0x04022D66 RID: 142694
		[Token(Token = "0x4022D66")]
		[FieldOffset(Offset = "0x78")]
		public string spOperatorCharId;

		// Token: 0x04022D67 RID: 142695
		[Token(Token = "0x4022D67")]
		[FieldOffset(Offset = "0x80")]
		public bool spOperatorActive;

		// Token: 0x04022D68 RID: 142696
		[Token(Token = "0x4022D68")]
		[FieldOffset(Offset = "0x81")]
		public bool spOperatorHasUpgrade;

		// Token: 0x04022D69 RID: 142697
		[Token(Token = "0x4022D69")]
		[FieldOffset(Offset = "0x82")]
		public bool spOperatorCanEvolve;

		// Token: 0x04022D6A RID: 142698
		[Token(Token = "0x4022D6A")]
		[FieldOffset(Offset = "0x88")]
		public string spOperatorLockedMessage;

		// Token: 0x04022D6B RID: 142699
		[Token(Token = "0x4022D6B")]
		[FieldOffset(Offset = "0x90")]
		public RoguelikeTopicDifficultyViewSub diffSubViewOnShow;

		// Token: 0x04022D6E RID: 142702
		[Token(Token = "0x4022D6E")]
		[FieldOffset(Offset = "0xA8")]
		private List<RoguelikeTopicDifficultyViewModel> m_difficultyList;

		// Token: 0x04022D6F RID: 142703
		[Token(Token = "0x4022D6F")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeTopicDifficultyViewModel m_selectDiffModel;

		// Token: 0x04022D70 RID: 142704
		[Token(Token = "0x4022D70")]
		[FieldOffset(Offset = "0xB8")]
		public long currentStartTs;

		// Token: 0x04022D71 RID: 142705
		[Token(Token = "0x4022D71")]
		[FieldOffset(Offset = "0xC0")]
		public string zoneName;

		// Token: 0x04022D72 RID: 142706
		[Token(Token = "0x4022D72")]
		[FieldOffset(Offset = "0xC8")]
		public RoguelikeTopicMode mode;

		// Token: 0x04022D74 RID: 142708
		[Token(Token = "0x4022D74")]
		[FieldOffset(Offset = "0xD0")]
		public string predefinedId;

		// Token: 0x04022D75 RID: 142709
		[Token(Token = "0x4022D75")]
		[FieldOffset(Offset = "0xD8")]
		public RoguelikeTopicDifficultyViewModel activeDiffModel;

		// Token: 0x04022D76 RID: 142710
		[Token(Token = "0x4022D76")]
		[FieldOffset(Offset = "0xE0")]
		public long startTime;

		// Token: 0x04022D77 RID: 142711
		[Token(Token = "0x4022D77")]
		[FieldOffset(Offset = "0xE8")]
		public bool showArchiveTrackpoint;

		// Token: 0x04022D78 RID: 142712
		[Token(Token = "0x4022D78")]
		[FieldOffset(Offset = "0xF0")]
		private RoguelikeTopicModeViewModelExtension m_extension;

		// Token: 0x04022D79 RID: 142713
		[Token(Token = "0x4022D79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showDiffDetail;

		// Token: 0x04022D7A RID: 142714
		[Token(Token = "0x4022D7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_showDiffDetail;

		// Token: 0x04022D7B RID: 142715
		[Token(Token = "0x4022D7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topicData;

		// Token: 0x04022D7C RID: 142716
		[Token(Token = "0x4022D7C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_topicData;

		// Token: 0x04022D7D RID: 142717
		[Token(Token = "0x4022D7D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_playerOuterData;

		// Token: 0x04022D7E RID: 142718
		[Token(Token = "0x4022D7E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_playerOuterData;

		// Token: 0x04022D7F RID: 142719
		[Token(Token = "0x4022D7F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_modeGrade;

		// Token: 0x04022D80 RID: 142720
		[Token(Token = "0x4022D80")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_modeGrade;

		// Token: 0x04022D81 RID: 142721
		[Token(Token = "0x4022D81")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetExtension;

		// Token: 0x04022D82 RID: 142722
		[Token(Token = "0x4022D82")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_difficultyList;

		// Token: 0x04022D83 RID: 142723
		[Token(Token = "0x4022D83")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_currentSelectDiffModel;

		// Token: 0x04022D84 RID: 142724
		[Token(Token = "0x4022D84")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_hardModeName;

		// Token: 0x04022D85 RID: 142725
		[Token(Token = "0x4022D85")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022D86 RID: 142726
		[Token(Token = "0x4022D86")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetCurrentDifficulty;

		// Token: 0x04022D87 RID: 142727
		[Token(Token = "0x4022D87")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitAndLoadLastDifficulty;

		// Token: 0x04022D88 RID: 142728
		[Token(Token = "0x4022D88")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateTopicCommonData;

		// Token: 0x04022D89 RID: 142729
		[Token(Token = "0x4022D89")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateDifficultyList;

		// Token: 0x04022D8A RID: 142730
		[Token(Token = "0x4022D8A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetCurrentActiveMonthSquadId;

		// Token: 0x04022D8B RID: 142731
		[Token(Token = "0x4022D8B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetCurrentMonthSquadId;

		// Token: 0x04022D8C RID: 142732
		[Token(Token = "0x4022D8C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SwitchMonthSquadList;

		// Token: 0x04022D8D RID: 142733
		[Token(Token = "0x4022D8D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetSelectedChallenge;

		// Token: 0x04022D8E RID: 142734
		[Token(Token = "0x4022D8E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CheckIfOpened;

		// Token: 0x04022D8F RID: 142735
		[Token(Token = "0x4022D8F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckIfUnlocked;

		// Token: 0x04022D90 RID: 142736
		[Token(Token = "0x4022D90")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckIfModeViewTypeSelectable;

		// Token: 0x04022D91 RID: 142737
		[Token(Token = "0x4022D91")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CheckCurrentShowMode;

		// Token: 0x04022D92 RID: 142738
		[Token(Token = "0x4022D92")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__LoadBpInfo;

		// Token: 0x04022D93 RID: 142739
		[Token(Token = "0x4022D93")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__LoadSPOperatorInfo;

		// Token: 0x04022D94 RID: 142740
		[Token(Token = "0x4022D94")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__LoadRogueActivityEntryCompModel;

		// Token: 0x04022D95 RID: 142741
		[Token(Token = "0x4022D95")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_PopDiffSubView;

		// Token: 0x04022D96 RID: 142742
		[Token(Token = "0x4022D96")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckDiffSubViewVisible;

		// Token: 0x04022D97 RID: 142743
		[Token(Token = "0x4022D97")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SetDiffSubViewVisible;

		// Token: 0x04022D98 RID: 142744
		[Token(Token = "0x4022D98")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
