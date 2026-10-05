using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005808 RID: 22536
	[Token(Token = "0x2005808")]
	public class RL03TopicChallengePluginContext : RoguelikeTopicChallengePluginContext
	{
		// Token: 0x17004D54 RID: 19796
		// (get) Token: 0x06020F01 RID: 134913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D54")]
		public override RoguelikeTopicChallengeToggleGroup topicChallengeToggleGroupPrefab
		{
			[Token(Token = "0x6020F01")]
			[Address(RVA = "0x1B33910", Offset = "0x1B32510", VA = "0x181B33910", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D55 RID: 19797
		// (get) Token: 0x06020F02 RID: 134914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D55")]
		public override RoguelikeTopicChallengeGroup topicChallengeGroupPrefab
		{
			[Token(Token = "0x6020F02")]
			[Address(RVA = "0x1B338B0", Offset = "0x1B324B0", VA = "0x181B338B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020F03 RID: 134915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F03")]
		[Address(RVA = "0x1B336A0", Offset = "0x1B322A0", VA = "0x181B336A0", Slot = "6")]
		public override void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x06020F04 RID: 134916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F04")]
		[Address(RVA = "0x1B33720", Offset = "0x1B32320", VA = "0x181B33720", Slot = "7")]
		public override void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x17004D56 RID: 19798
		// (get) Token: 0x06020F05 RID: 134917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D56")]
		public override ListDict<int, int> challengeGroupCountListDic
		{
			[Token(Token = "0x6020F05")]
			[Address(RVA = "0x1B33840", Offset = "0x1B32440", VA = "0x181B33840", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020F06 RID: 134918 RVA: 0x000B7DE0 File Offset: 0x000B5FE0
		[Token(Token = "0x6020F06")]
		[Address(RVA = "0x1B33620", Offset = "0x1B32220", VA = "0x181B33620", Slot = "10")]
		public override int GetSwitchPageCountByCurPageIndex(int curPageIndex)
		{
			return 0;
		}

		// Token: 0x06020F07 RID: 134919 RVA: 0x000B7DF8 File Offset: 0x000B5FF8
		[Token(Token = "0x6020F07")]
		[Address(RVA = "0x1B33510", Offset = "0x1B32110", VA = "0x181B33510", Slot = "9")]
		public override int GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel modeViewModel)
		{
			return 0;
		}

		// Token: 0x06020F08 RID: 134920 RVA: 0x000B7E10 File Offset: 0x000B6010
		[Token(Token = "0x6020F08")]
		[Address(RVA = "0x1B334A0", Offset = "0x1B320A0", VA = "0x181B334A0", Slot = "11")]
		public override bool CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x06020F09 RID: 134921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F09")]
		[Address(RVA = "0x1B337A0", Offset = "0x1B323A0", VA = "0x181B337A0")]
		public RL03TopicChallengePluginContext()
		{
		}

		// Token: 0x06020F0A RID: 134922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F0A")]
		[Address(RVA = "0x1A37750", Offset = "0x1A36350", VA = "0x181A37750")]
		private RoguelikeTopicChallengeGroup <>xLuaBaseProxy_get_topicChallengeGroupPrefab()
		{
			return null;
		}

		// Token: 0x06020F0B RID: 134923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F0B")]
		[Address(RVA = "0x1A37720", Offset = "0x1A36320", VA = "0x181A37720")]
		private void <>xLuaBaseProxy_LoadData(RoguelikeTopicChallengeModeViewModel P0)
		{
		}

		// Token: 0x06020F0C RID: 134924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F0C")]
		[Address(RVA = "0x1A37730", Offset = "0x1A36330", VA = "0x181A37730")]
		private void <>xLuaBaseProxy_UpdateData(RoguelikeTopicChallengeModeViewModel P0)
		{
		}

		// Token: 0x06020F0D RID: 134925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F0D")]
		[Address(RVA = "0x1A37740", Offset = "0x1A36340", VA = "0x181A37740")]
		private ListDict<int, int> <>xLuaBaseProxy_get_challengeGroupCountListDic()
		{
			return null;
		}

		// Token: 0x06020F0E RID: 134926 RVA: 0x000B7E28 File Offset: 0x000B6028
		[Token(Token = "0x6020F0E")]
		[Address(RVA = "0x1A37710", Offset = "0x1A36310", VA = "0x181A37710")]
		private int <>xLuaBaseProxy_GetSwitchPageCountByCurPageIndex(int P0)
		{
			return 0;
		}

		// Token: 0x06020F0F RID: 134927 RVA: 0x000B7E40 File Offset: 0x000B6040
		[Token(Token = "0x6020F0F")]
		[Address(RVA = "0x1A37700", Offset = "0x1A36300", VA = "0x181A37700")]
		private int <>xLuaBaseProxy_GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel P0)
		{
			return 0;
		}

		// Token: 0x06020F10 RID: 134928 RVA: 0x000B7E58 File Offset: 0x000B6058
		[Token(Token = "0x6020F10")]
		[Address(RVA = "0x1A376F0", Offset = "0x1A362F0", VA = "0x181A376F0")]
		private bool <>xLuaBaseProxy_CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x0402CC96 RID: 183446
		[Token(Token = "0x402CC96")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL03TopicChallengeToggleGroup _topicChallengeTogglePrefab;

		// Token: 0x0402CC97 RID: 183447
		[Token(Token = "0x402CC97")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL03TopicChallengeGroup _topicChallengeGroupPrefab;

		// Token: 0x0402CC98 RID: 183448
		[Token(Token = "0x402CC98")]
		[FieldOffset(Offset = "0x28")]
		private RL03TopicChallengePluginContext.RL03TopicChallengePluginModel m_viewModel;

		// Token: 0x0402CC99 RID: 183449
		[Token(Token = "0x402CC99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicChallengeToggleGroupPrefab;

		// Token: 0x0402CC9A RID: 183450
		[Token(Token = "0x402CC9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicChallengeGroupPrefab;

		// Token: 0x0402CC9B RID: 183451
		[Token(Token = "0x402CC9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CC9C RID: 183452
		[Token(Token = "0x402CC9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0402CC9D RID: 183453
		[Token(Token = "0x402CC9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_challengeGroupCountListDic;

		// Token: 0x0402CC9E RID: 183454
		[Token(Token = "0x402CC9E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

		// Token: 0x0402CC9F RID: 183455
		[Token(Token = "0x402CC9F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCurrChallengeGroupId;

		// Token: 0x0402CCA0 RID: 183456
		[Token(Token = "0x402CCA0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfNeedRefreshAllCard;

		// Token: 0x0402CCA1 RID: 183457
		[Token(Token = "0x402CCA1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005809 RID: 22537
		[Token(Token = "0x2005809")]
		private class RL03TopicChallengeStatusInfo : IHotfixable
		{
			// Token: 0x17004D57 RID: 19799
			// (get) Token: 0x06020F11 RID: 134929 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020F12 RID: 134930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004D57")]
			public string challengeId
			{
				[Token(Token = "0x6020F11")]
				[Address(RVA = "0x1B53960", Offset = "0x1B52560", VA = "0x181B53960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6020F12")]
				[Address(RVA = "0x1B53A80", Offset = "0x1B52680", VA = "0x181B53A80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004D58 RID: 19800
			// (get) Token: 0x06020F13 RID: 134931 RVA: 0x000B7E70 File Offset: 0x000B6070
			// (set) Token: 0x06020F14 RID: 134932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004D58")]
			public int sortId
			{
				[Token(Token = "0x6020F13")]
				[Address(RVA = "0x1B539C0", Offset = "0x1B525C0", VA = "0x181B539C0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6020F14")]
				[Address(RVA = "0x1B53B00", Offset = "0x1B52700", VA = "0x181B53B00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004D59 RID: 19801
			// (get) Token: 0x06020F15 RID: 134933 RVA: 0x000B7E88 File Offset: 0x000B6088
			// (set) Token: 0x06020F16 RID: 134934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004D59")]
			public PlayerRoguelikeChallengeStatus status
			{
				[Token(Token = "0x6020F15")]
				[Address(RVA = "0x1B53A20", Offset = "0x1B52620", VA = "0x181B53A20")]
				[CompilerGenerated]
				get
				{
					return PlayerRoguelikeChallengeStatus.LOCKED;
				}
				[Token(Token = "0x6020F16")]
				[Address(RVA = "0x1B53B70", Offset = "0x1B52770", VA = "0x181B53B70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06020F17 RID: 134935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020F17")]
			[Address(RVA = "0x1B53670", Offset = "0x1B52270", VA = "0x181B53670")]
			public static RL03TopicChallengePluginContext.RL03TopicChallengeStatusInfo CreateStatusInfo(string challengeId, int sortId)
			{
				return null;
			}

			// Token: 0x06020F18 RID: 134936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F18")]
			[Address(RVA = "0x1B53860", Offset = "0x1B52460", VA = "0x181B53860")]
			public void RefreshStatus(PlayerRoguelikeChallengeStatus status)
			{
			}

			// Token: 0x06020F19 RID: 134937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F19")]
			[Address(RVA = "0x1B53900", Offset = "0x1B52500", VA = "0x181B53900")]
			public RL03TopicChallengeStatusInfo()
			{
			}

			// Token: 0x0402CCA5 RID: 183461
			[Token(Token = "0x402CCA5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_challengeId;

			// Token: 0x0402CCA6 RID: 183462
			[Token(Token = "0x402CCA6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_challengeId;

			// Token: 0x0402CCA7 RID: 183463
			[Token(Token = "0x402CCA7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x0402CCA8 RID: 183464
			[Token(Token = "0x402CCA8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_sortId;

			// Token: 0x0402CCA9 RID: 183465
			[Token(Token = "0x402CCA9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_status;

			// Token: 0x0402CCAA RID: 183466
			[Token(Token = "0x402CCAA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_status;

			// Token: 0x0402CCAB RID: 183467
			[Token(Token = "0x402CCAB")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CreateStatusInfo;

			// Token: 0x0402CCAC RID: 183468
			[Token(Token = "0x402CCAC")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RefreshStatus;

			// Token: 0x0402CCAD RID: 183469
			[Token(Token = "0x402CCAD")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200580A RID: 22538
		[Token(Token = "0x200580A")]
		private class RL03TopicChallengeGroupInfo : IHotfixable
		{
			// Token: 0x06020F1A RID: 134938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F1A")]
			[Address(RVA = "0x1B52680", Offset = "0x1B51280", VA = "0x181B52680")]
			public RL03TopicChallengeGroupInfo()
			{
			}

			// Token: 0x0402CCAE RID: 183470
			[Token(Token = "0x402CCAE")]
			[FieldOffset(Offset = "0x10")]
			public int groupId;

			// Token: 0x0402CCAF RID: 183471
			[Token(Token = "0x402CCAF")]
			[FieldOffset(Offset = "0x14")]
			public int challengeCount;

			// Token: 0x0402CCB0 RID: 183472
			[Token(Token = "0x402CCB0")]
			[FieldOffset(Offset = "0x18")]
			public bool isGroupAllComplete;

			// Token: 0x0402CCB1 RID: 183473
			[Token(Token = "0x402CCB1")]
			[FieldOffset(Offset = "0x1C")]
			public int firstUnCompleteIndex;

			// Token: 0x0402CCB2 RID: 183474
			[Token(Token = "0x402CCB2")]
			[FieldOffset(Offset = "0x20")]
			public List<RL03TopicChallengePluginContext.RL03TopicChallengeStatusInfo> challengeStatus;

			// Token: 0x0402CCB3 RID: 183475
			[Token(Token = "0x402CCB3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200580B RID: 22539
		[Token(Token = "0x200580B")]
		private class RL03TopicChallengePluginModel : IHotfixable
		{
			// Token: 0x06020F1B RID: 134939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F1B")]
			[Address(RVA = "0x1B52C20", Offset = "0x1B51820", VA = "0x181B52C20")]
			public void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
			{
			}

			// Token: 0x06020F1C RID: 134940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F1C")]
			[Address(RVA = "0x1B532C0", Offset = "0x1B51EC0", VA = "0x181B532C0")]
			public void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
			{
			}

			// Token: 0x06020F1D RID: 134941 RVA: 0x000B7EA0 File Offset: 0x000B60A0
			[Token(Token = "0x6020F1D")]
			[Address(RVA = "0x1B526E0", Offset = "0x1B512E0", VA = "0x181B526E0")]
			public bool CheckIfNeedRefreshAllCard()
			{
				return default(bool);
			}

			// Token: 0x06020F1E RID: 134942 RVA: 0x000B7EB8 File Offset: 0x000B60B8
			[Token(Token = "0x6020F1E")]
			[Address(RVA = "0x1B529E0", Offset = "0x1B515E0", VA = "0x181B529E0")]
			public int GetSwitchPageCountByCurPageIndex(int curChallengeIndex)
			{
				return 0;
			}

			// Token: 0x06020F1F RID: 134943 RVA: 0x000B7ED0 File Offset: 0x000B60D0
			[Token(Token = "0x6020F1F")]
			[Address(RVA = "0x1B534B0", Offset = "0x1B520B0", VA = "0x181B534B0")]
			private int _GetGroupFocusChallengeIndex(int groupId)
			{
				return 0;
			}

			// Token: 0x06020F20 RID: 134944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F20")]
			[Address(RVA = "0x1B53570", Offset = "0x1B52170", VA = "0x181B53570")]
			public RL03TopicChallengePluginModel()
			{
			}

			// Token: 0x0402CCB4 RID: 183476
			[Token(Token = "0x402CCB4")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<int, RL03TopicChallengePluginContext.RL03TopicChallengeGroupInfo> challengeGroupInfoListDic;

			// Token: 0x0402CCB5 RID: 183477
			[Token(Token = "0x402CCB5")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, int> challengeGroupCountListDic;

			// Token: 0x0402CCB6 RID: 183478
			[Token(Token = "0x402CCB6")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, PlayerRoguelikeChallengeStatus> m_cachedChallengeStatus;

			// Token: 0x0402CCB7 RID: 183479
			[Token(Token = "0x402CCB7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402CCB8 RID: 183480
			[Token(Token = "0x402CCB8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x0402CCB9 RID: 183481
			[Token(Token = "0x402CCB9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckIfNeedRefreshAllCard;

			// Token: 0x0402CCBA RID: 183482
			[Token(Token = "0x402CCBA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

			// Token: 0x0402CCBB RID: 183483
			[Token(Token = "0x402CCBB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetGroupFocusChallengeIndex;

			// Token: 0x0402CCBC RID: 183484
			[Token(Token = "0x402CCBC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
