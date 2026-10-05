using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200572A RID: 22314
	[Token(Token = "0x200572A")]
	public class RL02TopicChallengePluginContext : RoguelikeTopicChallengePluginContext
	{
		// Token: 0x17004CB0 RID: 19632
		// (get) Token: 0x06020B4B RID: 133963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CB0")]
		public override RoguelikeTopicChallengeToggleGroup topicChallengeToggleGroupPrefab
		{
			[Token(Token = "0x6020B4B")]
			[Address(RVA = "0x1B0CC60", Offset = "0x1B0B860", VA = "0x181B0CC60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004CB1 RID: 19633
		// (get) Token: 0x06020B4C RID: 133964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CB1")]
		public override RoguelikeTopicChallengeGroup topicChallengeGroupPrefab
		{
			[Token(Token = "0x6020B4C")]
			[Address(RVA = "0x1B0CC00", Offset = "0x1B0B800", VA = "0x181B0CC00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020B4D RID: 133965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B4D")]
		[Address(RVA = "0x1B0C900", Offset = "0x1B0B500", VA = "0x181B0C900", Slot = "6")]
		public override void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x06020B4E RID: 133966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B4E")]
		[Address(RVA = "0x1B0C980", Offset = "0x1B0B580", VA = "0x181B0C980", Slot = "7")]
		public override void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x17004CB2 RID: 19634
		// (get) Token: 0x06020B4F RID: 133967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CB2")]
		public override ListDict<int, int> challengeGroupCountListDic
		{
			[Token(Token = "0x6020B4F")]
			[Address(RVA = "0x1B0CB90", Offset = "0x1B0B790", VA = "0x181B0CB90", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020B50 RID: 133968 RVA: 0x000B6DF0 File Offset: 0x000B4FF0
		[Token(Token = "0x6020B50")]
		[Address(RVA = "0x1B0C880", Offset = "0x1B0B480", VA = "0x181B0C880", Slot = "10")]
		public override int GetSwitchPageCountByCurPageIndex(int curPageIndex)
		{
			return 0;
		}

		// Token: 0x06020B51 RID: 133969 RVA: 0x000B6E08 File Offset: 0x000B5008
		[Token(Token = "0x6020B51")]
		[Address(RVA = "0x1B0C770", Offset = "0x1B0B370", VA = "0x181B0C770", Slot = "9")]
		public override int GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel modeViewModel)
		{
			return 0;
		}

		// Token: 0x06020B52 RID: 133970 RVA: 0x000B6E20 File Offset: 0x000B5020
		[Token(Token = "0x6020B52")]
		[Address(RVA = "0x1B0C700", Offset = "0x1B0B300", VA = "0x181B0C700", Slot = "11")]
		public override bool CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x06020B53 RID: 133971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B53")]
		[Address(RVA = "0x1B0CA00", Offset = "0x1B0B600", VA = "0x181B0CA00")]
		public RL02TopicChallengePluginContext()
		{
		}

		// Token: 0x06020B54 RID: 133972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B54")]
		[Address(RVA = "0x1A37750", Offset = "0x1A36350", VA = "0x181A37750")]
		private RoguelikeTopicChallengeGroup <>xLuaBaseProxy_get_topicChallengeGroupPrefab()
		{
			return null;
		}

		// Token: 0x06020B55 RID: 133973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B55")]
		[Address(RVA = "0x1A37720", Offset = "0x1A36320", VA = "0x181A37720")]
		private void <>xLuaBaseProxy_LoadData(RoguelikeTopicChallengeModeViewModel P0)
		{
		}

		// Token: 0x06020B56 RID: 133974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B56")]
		[Address(RVA = "0x1A37730", Offset = "0x1A36330", VA = "0x181A37730")]
		private void <>xLuaBaseProxy_UpdateData(RoguelikeTopicChallengeModeViewModel P0)
		{
		}

		// Token: 0x06020B57 RID: 133975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B57")]
		[Address(RVA = "0x1A37740", Offset = "0x1A36340", VA = "0x181A37740")]
		private ListDict<int, int> <>xLuaBaseProxy_get_challengeGroupCountListDic()
		{
			return null;
		}

		// Token: 0x06020B58 RID: 133976 RVA: 0x000B6E38 File Offset: 0x000B5038
		[Token(Token = "0x6020B58")]
		[Address(RVA = "0x1A37710", Offset = "0x1A36310", VA = "0x181A37710")]
		private int <>xLuaBaseProxy_GetSwitchPageCountByCurPageIndex(int P0)
		{
			return 0;
		}

		// Token: 0x06020B59 RID: 133977 RVA: 0x000B6E50 File Offset: 0x000B5050
		[Token(Token = "0x6020B59")]
		[Address(RVA = "0x1A37700", Offset = "0x1A36300", VA = "0x181A37700")]
		private int <>xLuaBaseProxy_GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel P0)
		{
			return 0;
		}

		// Token: 0x06020B5A RID: 133978 RVA: 0x000B6E68 File Offset: 0x000B5068
		[Token(Token = "0x6020B5A")]
		[Address(RVA = "0x1A376F0", Offset = "0x1A362F0", VA = "0x181A376F0")]
		private bool <>xLuaBaseProxy_CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x0402C64D RID: 181837
		[Token(Token = "0x402C64D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL02TopicChallengeToggleGroup _topicChallengeTogglePrefab;

		// Token: 0x0402C64E RID: 181838
		[Token(Token = "0x402C64E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL02TopicChallengeGroup _topicChallengeGroupPrefab;

		// Token: 0x0402C64F RID: 181839
		[Token(Token = "0x402C64F")]
		[FieldOffset(Offset = "0x28")]
		private RL02TopicChallengePluginContext.RL02TopicChallengePluginModel m_viewModel;

		// Token: 0x0402C650 RID: 181840
		[Token(Token = "0x402C650")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicChallengeToggleGroupPrefab;

		// Token: 0x0402C651 RID: 181841
		[Token(Token = "0x402C651")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicChallengeGroupPrefab;

		// Token: 0x0402C652 RID: 181842
		[Token(Token = "0x402C652")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C653 RID: 181843
		[Token(Token = "0x402C653")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0402C654 RID: 181844
		[Token(Token = "0x402C654")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_challengeGroupCountListDic;

		// Token: 0x0402C655 RID: 181845
		[Token(Token = "0x402C655")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

		// Token: 0x0402C656 RID: 181846
		[Token(Token = "0x402C656")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCurrChallengeGroupId;

		// Token: 0x0402C657 RID: 181847
		[Token(Token = "0x402C657")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfNeedRefreshAllCard;

		// Token: 0x0402C658 RID: 181848
		[Token(Token = "0x402C658")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200572B RID: 22315
		[Token(Token = "0x200572B")]
		private class RL02TopicChallengeStatusInfo : IHotfixable
		{
			// Token: 0x17004CB3 RID: 19635
			// (get) Token: 0x06020B5B RID: 133979 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020B5C RID: 133980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004CB3")]
			public string challengeId
			{
				[Token(Token = "0x6020B5B")]
				[Address(RVA = "0x1B0DF50", Offset = "0x1B0CB50", VA = "0x181B0DF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6020B5C")]
				[Address(RVA = "0x1B0E070", Offset = "0x1B0CC70", VA = "0x181B0E070")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004CB4 RID: 19636
			// (get) Token: 0x06020B5D RID: 133981 RVA: 0x000B6E80 File Offset: 0x000B5080
			// (set) Token: 0x06020B5E RID: 133982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004CB4")]
			public int sortId
			{
				[Token(Token = "0x6020B5D")]
				[Address(RVA = "0x1B0DFB0", Offset = "0x1B0CBB0", VA = "0x181B0DFB0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6020B5E")]
				[Address(RVA = "0x1B0E0F0", Offset = "0x1B0CCF0", VA = "0x181B0E0F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004CB5 RID: 19637
			// (get) Token: 0x06020B5F RID: 133983 RVA: 0x000B6E98 File Offset: 0x000B5098
			// (set) Token: 0x06020B60 RID: 133984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004CB5")]
			public PlayerRoguelikeChallengeStatus status
			{
				[Token(Token = "0x6020B5F")]
				[Address(RVA = "0x1B0E010", Offset = "0x1B0CC10", VA = "0x181B0E010")]
				[CompilerGenerated]
				get
				{
					return PlayerRoguelikeChallengeStatus.LOCKED;
				}
				[Token(Token = "0x6020B60")]
				[Address(RVA = "0x1B0E160", Offset = "0x1B0CD60", VA = "0x181B0E160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06020B61 RID: 133985 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020B61")]
			[Address(RVA = "0x1B0DC60", Offset = "0x1B0C860", VA = "0x181B0DC60")]
			public static RL02TopicChallengePluginContext.RL02TopicChallengeStatusInfo CreateStatusInfo(string challengeId, int sortId)
			{
				return null;
			}

			// Token: 0x06020B62 RID: 133986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B62")]
			[Address(RVA = "0x1B0DE50", Offset = "0x1B0CA50", VA = "0x181B0DE50")]
			public void RefreshStatus(PlayerRoguelikeChallengeStatus status)
			{
			}

			// Token: 0x06020B63 RID: 133987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B63")]
			[Address(RVA = "0x1B0DEF0", Offset = "0x1B0CAF0", VA = "0x181B0DEF0")]
			public RL02TopicChallengeStatusInfo()
			{
			}

			// Token: 0x0402C65C RID: 181852
			[Token(Token = "0x402C65C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_challengeId;

			// Token: 0x0402C65D RID: 181853
			[Token(Token = "0x402C65D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_challengeId;

			// Token: 0x0402C65E RID: 181854
			[Token(Token = "0x402C65E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x0402C65F RID: 181855
			[Token(Token = "0x402C65F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_sortId;

			// Token: 0x0402C660 RID: 181856
			[Token(Token = "0x402C660")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_status;

			// Token: 0x0402C661 RID: 181857
			[Token(Token = "0x402C661")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_status;

			// Token: 0x0402C662 RID: 181858
			[Token(Token = "0x402C662")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CreateStatusInfo;

			// Token: 0x0402C663 RID: 181859
			[Token(Token = "0x402C663")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RefreshStatus;

			// Token: 0x0402C664 RID: 181860
			[Token(Token = "0x402C664")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200572C RID: 22316
		[Token(Token = "0x200572C")]
		private class RL02TopicChallengeGroupInfo : IHotfixable
		{
			// Token: 0x06020B64 RID: 133988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B64")]
			[Address(RVA = "0x1B0C230", Offset = "0x1B0AE30", VA = "0x181B0C230")]
			public RL02TopicChallengeGroupInfo()
			{
			}

			// Token: 0x0402C665 RID: 181861
			[Token(Token = "0x402C665")]
			[FieldOffset(Offset = "0x10")]
			public int groupId;

			// Token: 0x0402C666 RID: 181862
			[Token(Token = "0x402C666")]
			[FieldOffset(Offset = "0x14")]
			public int challengeCount;

			// Token: 0x0402C667 RID: 181863
			[Token(Token = "0x402C667")]
			[FieldOffset(Offset = "0x18")]
			public bool isGroupAllComplete;

			// Token: 0x0402C668 RID: 181864
			[Token(Token = "0x402C668")]
			[FieldOffset(Offset = "0x1C")]
			public int lastUnCompleteIndex;

			// Token: 0x0402C669 RID: 181865
			[Token(Token = "0x402C669")]
			[FieldOffset(Offset = "0x20")]
			public List<RL02TopicChallengePluginContext.RL02TopicChallengeStatusInfo> challengeStatus;

			// Token: 0x0402C66A RID: 181866
			[Token(Token = "0x402C66A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200572D RID: 22317
		[Token(Token = "0x200572D")]
		private class RL02TopicChallengePluginModel : IHotfixable
		{
			// Token: 0x06020B65 RID: 133989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B65")]
			[Address(RVA = "0x1B0D200", Offset = "0x1B0BE00", VA = "0x181B0D200")]
			public void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
			{
			}

			// Token: 0x06020B66 RID: 133990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B66")]
			[Address(RVA = "0x1B0D8A0", Offset = "0x1B0C4A0", VA = "0x181B0D8A0")]
			public void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
			{
			}

			// Token: 0x06020B67 RID: 133991 RVA: 0x000B6EB0 File Offset: 0x000B50B0
			[Token(Token = "0x6020B67")]
			[Address(RVA = "0x1B0CCC0", Offset = "0x1B0B8C0", VA = "0x181B0CCC0")]
			public bool CheckIfNeedRefrushAllCard()
			{
				return default(bool);
			}

			// Token: 0x06020B68 RID: 133992 RVA: 0x000B6EC8 File Offset: 0x000B50C8
			[Token(Token = "0x6020B68")]
			[Address(RVA = "0x1B0CFC0", Offset = "0x1B0BBC0", VA = "0x181B0CFC0")]
			public int GetSwitchPageCountByCurPageIndex(int curChallengeIndex)
			{
				return 0;
			}

			// Token: 0x06020B69 RID: 133993 RVA: 0x000B6EE0 File Offset: 0x000B50E0
			[Token(Token = "0x6020B69")]
			[Address(RVA = "0x1B0DAA0", Offset = "0x1B0C6A0", VA = "0x181B0DAA0")]
			private int _GetGroupFocusChallengeIndex(int groupId)
			{
				return 0;
			}

			// Token: 0x06020B6A RID: 133994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B6A")]
			[Address(RVA = "0x1B0DB60", Offset = "0x1B0C760", VA = "0x181B0DB60")]
			public RL02TopicChallengePluginModel()
			{
			}

			// Token: 0x0402C66B RID: 181867
			[Token(Token = "0x402C66B")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<int, RL02TopicChallengePluginContext.RL02TopicChallengeGroupInfo> challengeGroupInfoListDic;

			// Token: 0x0402C66C RID: 181868
			[Token(Token = "0x402C66C")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, int> challengeGroupCountListDic;

			// Token: 0x0402C66D RID: 181869
			[Token(Token = "0x402C66D")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, PlayerRoguelikeChallengeStatus> m_cachedChallengeStatus;

			// Token: 0x0402C66E RID: 181870
			[Token(Token = "0x402C66E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402C66F RID: 181871
			[Token(Token = "0x402C66F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x0402C670 RID: 181872
			[Token(Token = "0x402C670")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckIfNeedRefrushAllCard;

			// Token: 0x0402C671 RID: 181873
			[Token(Token = "0x402C671")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

			// Token: 0x0402C672 RID: 181874
			[Token(Token = "0x402C672")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetGroupFocusChallengeIndex;

			// Token: 0x0402C673 RID: 181875
			[Token(Token = "0x402C673")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
