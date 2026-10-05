using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005567 RID: 21863
	[Token(Token = "0x2005567")]
	public class RL05TopicChallengePluginContext : RoguelikeTopicChallengePluginContext
	{
		// Token: 0x17004B6A RID: 19306
		// (get) Token: 0x0602022B RID: 131627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B6A")]
		public override RoguelikeTopicChallengeToggleGroup topicChallengeToggleGroupPrefab
		{
			[Token(Token = "0x602022B")]
			[Address(RVA = "0x1A37A40", Offset = "0x1A36640", VA = "0x181A37A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B6B RID: 19307
		// (get) Token: 0x0602022C RID: 131628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B6B")]
		public override RoguelikeTopicChallengeGroup topicChallengeGroupPrefab
		{
			[Token(Token = "0x602022C")]
			[Address(RVA = "0x1A379E0", Offset = "0x1A365E0", VA = "0x181A379E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602022D RID: 131629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602022D")]
		[Address(RVA = "0x1A37670", Offset = "0x1A36270", VA = "0x181A37670", Slot = "6")]
		public override void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x0602022E RID: 131630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602022E")]
		[Address(RVA = "0x1A37760", Offset = "0x1A36360", VA = "0x181A37760", Slot = "7")]
		public override void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x17004B6C RID: 19308
		// (get) Token: 0x0602022F RID: 131631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B6C")]
		public override ListDict<int, int> challengeGroupCountListDic
		{
			[Token(Token = "0x602022F")]
			[Address(RVA = "0x1A37970", Offset = "0x1A36570", VA = "0x181A37970", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020230 RID: 131632 RVA: 0x000B4BE8 File Offset: 0x000B2DE8
		[Token(Token = "0x6020230")]
		[Address(RVA = "0x1A375F0", Offset = "0x1A361F0", VA = "0x181A375F0", Slot = "10")]
		public override int GetSwitchPageCountByCurPageIndex(int curPageIndex)
		{
			return 0;
		}

		// Token: 0x06020231 RID: 131633 RVA: 0x000B4C00 File Offset: 0x000B2E00
		[Token(Token = "0x6020231")]
		[Address(RVA = "0x1A374E0", Offset = "0x1A360E0", VA = "0x181A374E0", Slot = "9")]
		public override int GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel modeViewModel)
		{
			return 0;
		}

		// Token: 0x06020232 RID: 131634 RVA: 0x000B4C18 File Offset: 0x000B2E18
		[Token(Token = "0x6020232")]
		[Address(RVA = "0x1A37470", Offset = "0x1A36070", VA = "0x181A37470", Slot = "11")]
		public override bool CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x06020233 RID: 131635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020233")]
		[Address(RVA = "0x1A377E0", Offset = "0x1A363E0", VA = "0x181A377E0")]
		public RL05TopicChallengePluginContext()
		{
		}

		// Token: 0x06020234 RID: 131636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020234")]
		[Address(RVA = "0x1A37750", Offset = "0x1A36350", VA = "0x181A37750")]
		private RoguelikeTopicChallengeGroup <>xLuaBaseProxy_get_topicChallengeGroupPrefab()
		{
			return null;
		}

		// Token: 0x06020235 RID: 131637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020235")]
		[Address(RVA = "0x1A37720", Offset = "0x1A36320", VA = "0x181A37720")]
		private void <>xLuaBaseProxy_LoadData(RoguelikeTopicChallengeModeViewModel P0)
		{
		}

		// Token: 0x06020236 RID: 131638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020236")]
		[Address(RVA = "0x1A37730", Offset = "0x1A36330", VA = "0x181A37730")]
		private void <>xLuaBaseProxy_UpdateData(RoguelikeTopicChallengeModeViewModel P0)
		{
		}

		// Token: 0x06020237 RID: 131639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020237")]
		[Address(RVA = "0x1A37740", Offset = "0x1A36340", VA = "0x181A37740")]
		private ListDict<int, int> <>xLuaBaseProxy_get_challengeGroupCountListDic()
		{
			return null;
		}

		// Token: 0x06020238 RID: 131640 RVA: 0x000B4C30 File Offset: 0x000B2E30
		[Token(Token = "0x6020238")]
		[Address(RVA = "0x1A37710", Offset = "0x1A36310", VA = "0x181A37710")]
		private int <>xLuaBaseProxy_GetSwitchPageCountByCurPageIndex(int P0)
		{
			return 0;
		}

		// Token: 0x06020239 RID: 131641 RVA: 0x000B4C48 File Offset: 0x000B2E48
		[Token(Token = "0x6020239")]
		[Address(RVA = "0x1A37700", Offset = "0x1A36300", VA = "0x181A37700")]
		private int <>xLuaBaseProxy_GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel P0)
		{
			return 0;
		}

		// Token: 0x0602023A RID: 131642 RVA: 0x000B4C60 File Offset: 0x000B2E60
		[Token(Token = "0x602023A")]
		[Address(RVA = "0x1A376F0", Offset = "0x1A362F0", VA = "0x181A376F0")]
		private bool <>xLuaBaseProxy_CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x0402B68F RID: 177807
		[Token(Token = "0x402B68F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL05TopicChallengeToggleGroup _topicChallengeTogglePrefab;

		// Token: 0x0402B690 RID: 177808
		[Token(Token = "0x402B690")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL05TopicChallengeGroup _topicChallengeGroupPrefab;

		// Token: 0x0402B691 RID: 177809
		[Token(Token = "0x402B691")]
		[FieldOffset(Offset = "0x28")]
		private RL05TopicChallengePluginContext.RL05TopicChallengePluginModel m_viewModel;

		// Token: 0x0402B692 RID: 177810
		[Token(Token = "0x402B692")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicChallengeToggleGroupPrefab;

		// Token: 0x0402B693 RID: 177811
		[Token(Token = "0x402B693")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicChallengeGroupPrefab;

		// Token: 0x0402B694 RID: 177812
		[Token(Token = "0x402B694")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B695 RID: 177813
		[Token(Token = "0x402B695")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0402B696 RID: 177814
		[Token(Token = "0x402B696")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_challengeGroupCountListDic;

		// Token: 0x0402B697 RID: 177815
		[Token(Token = "0x402B697")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

		// Token: 0x0402B698 RID: 177816
		[Token(Token = "0x402B698")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCurrChallengeGroupId;

		// Token: 0x0402B699 RID: 177817
		[Token(Token = "0x402B699")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfNeedRefreshAllCard;

		// Token: 0x0402B69A RID: 177818
		[Token(Token = "0x402B69A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005568 RID: 21864
		[Token(Token = "0x2005568")]
		private class RL05TopicChallengeStatusInfo : IHotfixable
		{
			// Token: 0x17004B6D RID: 19309
			// (get) Token: 0x0602023B RID: 131643 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602023C RID: 131644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B6D")]
			public string challengeId
			{
				[Token(Token = "0x602023B")]
				[Address(RVA = "0x1A38D30", Offset = "0x1A37930", VA = "0x181A38D30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602023C")]
				[Address(RVA = "0x1A38E50", Offset = "0x1A37A50", VA = "0x181A38E50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B6E RID: 19310
			// (get) Token: 0x0602023D RID: 131645 RVA: 0x000B4C78 File Offset: 0x000B2E78
			// (set) Token: 0x0602023E RID: 131646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B6E")]
			public int sortId
			{
				[Token(Token = "0x602023D")]
				[Address(RVA = "0x1A38D90", Offset = "0x1A37990", VA = "0x181A38D90")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x602023E")]
				[Address(RVA = "0x1A38ED0", Offset = "0x1A37AD0", VA = "0x181A38ED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B6F RID: 19311
			// (get) Token: 0x0602023F RID: 131647 RVA: 0x000B4C90 File Offset: 0x000B2E90
			// (set) Token: 0x06020240 RID: 131648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B6F")]
			public PlayerRoguelikeChallengeStatus status
			{
				[Token(Token = "0x602023F")]
				[Address(RVA = "0x1A38DF0", Offset = "0x1A379F0", VA = "0x181A38DF0")]
				[CompilerGenerated]
				get
				{
					return PlayerRoguelikeChallengeStatus.LOCKED;
				}
				[Token(Token = "0x6020240")]
				[Address(RVA = "0x1A38F40", Offset = "0x1A37B40", VA = "0x181A38F40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06020241 RID: 131649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020241")]
			[Address(RVA = "0x1A38A40", Offset = "0x1A37640", VA = "0x181A38A40")]
			public static RL05TopicChallengePluginContext.RL05TopicChallengeStatusInfo CreateStatusInfo(string challengeId, int sortId)
			{
				return null;
			}

			// Token: 0x06020242 RID: 131650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020242")]
			[Address(RVA = "0x1A38C30", Offset = "0x1A37830", VA = "0x181A38C30")]
			public void RefreshStatus(PlayerRoguelikeChallengeStatus status)
			{
			}

			// Token: 0x06020243 RID: 131651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020243")]
			[Address(RVA = "0x1A38CD0", Offset = "0x1A378D0", VA = "0x181A38CD0")]
			public RL05TopicChallengeStatusInfo()
			{
			}

			// Token: 0x0402B69E RID: 177822
			[Token(Token = "0x402B69E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_challengeId;

			// Token: 0x0402B69F RID: 177823
			[Token(Token = "0x402B69F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_challengeId;

			// Token: 0x0402B6A0 RID: 177824
			[Token(Token = "0x402B6A0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x0402B6A1 RID: 177825
			[Token(Token = "0x402B6A1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_sortId;

			// Token: 0x0402B6A2 RID: 177826
			[Token(Token = "0x402B6A2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_status;

			// Token: 0x0402B6A3 RID: 177827
			[Token(Token = "0x402B6A3")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_status;

			// Token: 0x0402B6A4 RID: 177828
			[Token(Token = "0x402B6A4")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CreateStatusInfo;

			// Token: 0x0402B6A5 RID: 177829
			[Token(Token = "0x402B6A5")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RefreshStatus;

			// Token: 0x0402B6A6 RID: 177830
			[Token(Token = "0x402B6A6")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005569 RID: 21865
		[Token(Token = "0x2005569")]
		private class RL05TopicChallengeGroupInfo : IHotfixable
		{
			// Token: 0x06020244 RID: 131652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020244")]
			[Address(RVA = "0x1A36F80", Offset = "0x1A35B80", VA = "0x181A36F80")]
			public RL05TopicChallengeGroupInfo()
			{
			}

			// Token: 0x0402B6A7 RID: 177831
			[Token(Token = "0x402B6A7")]
			[FieldOffset(Offset = "0x10")]
			public int groupId;

			// Token: 0x0402B6A8 RID: 177832
			[Token(Token = "0x402B6A8")]
			[FieldOffset(Offset = "0x14")]
			public int challengeCount;

			// Token: 0x0402B6A9 RID: 177833
			[Token(Token = "0x402B6A9")]
			[FieldOffset(Offset = "0x18")]
			public bool isGroupAllComplete;

			// Token: 0x0402B6AA RID: 177834
			[Token(Token = "0x402B6AA")]
			[FieldOffset(Offset = "0x1C")]
			public int lastUnCompleteIndex;

			// Token: 0x0402B6AB RID: 177835
			[Token(Token = "0x402B6AB")]
			[FieldOffset(Offset = "0x20")]
			public List<RL05TopicChallengePluginContext.RL05TopicChallengeStatusInfo> challengeStatus;

			// Token: 0x0402B6AC RID: 177836
			[Token(Token = "0x402B6AC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200556A RID: 21866
		[Token(Token = "0x200556A")]
		private class RL05TopicChallengePluginModel : IHotfixable
		{
			// Token: 0x06020245 RID: 131653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020245")]
			[Address(RVA = "0x1A37FE0", Offset = "0x1A36BE0", VA = "0x181A37FE0")]
			public void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
			{
			}

			// Token: 0x06020246 RID: 131654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020246")]
			[Address(RVA = "0x1A38680", Offset = "0x1A37280", VA = "0x181A38680")]
			public void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
			{
			}

			// Token: 0x06020247 RID: 131655 RVA: 0x000B4CA8 File Offset: 0x000B2EA8
			[Token(Token = "0x6020247")]
			[Address(RVA = "0x1A37AA0", Offset = "0x1A366A0", VA = "0x181A37AA0")]
			public bool CheckIfNeedRefrushAllCard()
			{
				return default(bool);
			}

			// Token: 0x06020248 RID: 131656 RVA: 0x000B4CC0 File Offset: 0x000B2EC0
			[Token(Token = "0x6020248")]
			[Address(RVA = "0x1A37DA0", Offset = "0x1A369A0", VA = "0x181A37DA0")]
			public int GetSwitchPageCountByCurPageIndex(int curChallengeIndex)
			{
				return 0;
			}

			// Token: 0x06020249 RID: 131657 RVA: 0x000B4CD8 File Offset: 0x000B2ED8
			[Token(Token = "0x6020249")]
			[Address(RVA = "0x1A38880", Offset = "0x1A37480", VA = "0x181A38880")]
			private int _GetGroupFocusChallengeIndex(int groupId)
			{
				return 0;
			}

			// Token: 0x0602024A RID: 131658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602024A")]
			[Address(RVA = "0x1A38940", Offset = "0x1A37540", VA = "0x181A38940")]
			public RL05TopicChallengePluginModel()
			{
			}

			// Token: 0x0402B6AD RID: 177837
			[Token(Token = "0x402B6AD")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<int, RL05TopicChallengePluginContext.RL05TopicChallengeGroupInfo> challengeGroupInfoListDic;

			// Token: 0x0402B6AE RID: 177838
			[Token(Token = "0x402B6AE")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, int> challengeGroupCountListDic;

			// Token: 0x0402B6AF RID: 177839
			[Token(Token = "0x402B6AF")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, PlayerRoguelikeChallengeStatus> m_cachedChallengeStatus;

			// Token: 0x0402B6B0 RID: 177840
			[Token(Token = "0x402B6B0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402B6B1 RID: 177841
			[Token(Token = "0x402B6B1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x0402B6B2 RID: 177842
			[Token(Token = "0x402B6B2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckIfNeedRefrushAllCard;

			// Token: 0x0402B6B3 RID: 177843
			[Token(Token = "0x402B6B3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

			// Token: 0x0402B6B4 RID: 177844
			[Token(Token = "0x402B6B4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetGroupFocusChallengeIndex;

			// Token: 0x0402B6B5 RID: 177845
			[Token(Token = "0x402B6B5")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
