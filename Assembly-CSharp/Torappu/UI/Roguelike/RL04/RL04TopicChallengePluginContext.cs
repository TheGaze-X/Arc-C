using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005687 RID: 22151
	[Token(Token = "0x2005687")]
	public class RL04TopicChallengePluginContext : RoguelikeTopicChallengePluginContext
	{
		// Token: 0x17004C26 RID: 19494
		// (get) Token: 0x060207F5 RID: 133109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C26")]
		public override RoguelikeTopicChallengeToggleGroup topicChallengeToggleGroupPrefab
		{
			[Token(Token = "0x60207F5")]
			[Address(RVA = "0x1AA14A0", Offset = "0x1AA00A0", VA = "0x181AA14A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C27 RID: 19495
		// (get) Token: 0x060207F6 RID: 133110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C27")]
		public override RoguelikeTopicChallengeGroup topicChallengeGroupPrefab
		{
			[Token(Token = "0x60207F6")]
			[Address(RVA = "0x1AA1440", Offset = "0x1AA0040", VA = "0x181AA1440", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060207F7 RID: 133111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207F7")]
		[Address(RVA = "0x1AA1230", Offset = "0x1A9FE30", VA = "0x181AA1230", Slot = "6")]
		public override void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x060207F8 RID: 133112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207F8")]
		[Address(RVA = "0x1AA12B0", Offset = "0x1A9FEB0", VA = "0x181AA12B0", Slot = "7")]
		public override void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x17004C28 RID: 19496
		// (get) Token: 0x060207F9 RID: 133113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C28")]
		public override ListDict<int, int> challengeGroupCountListDic
		{
			[Token(Token = "0x60207F9")]
			[Address(RVA = "0x1AA13D0", Offset = "0x1A9FFD0", VA = "0x181AA13D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060207FA RID: 133114 RVA: 0x000B6280 File Offset: 0x000B4480
		[Token(Token = "0x60207FA")]
		[Address(RVA = "0x1AA11B0", Offset = "0x1A9FDB0", VA = "0x181AA11B0", Slot = "10")]
		public override int GetSwitchPageCountByCurPageIndex(int curPageIndex)
		{
			return 0;
		}

		// Token: 0x060207FB RID: 133115 RVA: 0x000B6298 File Offset: 0x000B4498
		[Token(Token = "0x60207FB")]
		[Address(RVA = "0x1AA10A0", Offset = "0x1A9FCA0", VA = "0x181AA10A0", Slot = "9")]
		public override int GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel modeViewModel)
		{
			return 0;
		}

		// Token: 0x060207FC RID: 133116 RVA: 0x000B62B0 File Offset: 0x000B44B0
		[Token(Token = "0x60207FC")]
		[Address(RVA = "0x1AA1030", Offset = "0x1A9FC30", VA = "0x181AA1030", Slot = "11")]
		public override bool CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x060207FD RID: 133117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207FD")]
		[Address(RVA = "0x1AA1330", Offset = "0x1A9FF30", VA = "0x181AA1330")]
		public RL04TopicChallengePluginContext()
		{
		}

		// Token: 0x060207FE RID: 133118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60207FE")]
		[Address(RVA = "0x1A37750", Offset = "0x1A36350", VA = "0x181A37750")]
		private RoguelikeTopicChallengeGroup <>xLuaBaseProxy_get_topicChallengeGroupPrefab()
		{
			return null;
		}

		// Token: 0x060207FF RID: 133119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207FF")]
		[Address(RVA = "0x1A37720", Offset = "0x1A36320", VA = "0x181A37720")]
		private void <>xLuaBaseProxy_LoadData(RoguelikeTopicChallengeModeViewModel P0)
		{
		}

		// Token: 0x06020800 RID: 133120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020800")]
		[Address(RVA = "0x1A37730", Offset = "0x1A36330", VA = "0x181A37730")]
		private void <>xLuaBaseProxy_UpdateData(RoguelikeTopicChallengeModeViewModel P0)
		{
		}

		// Token: 0x06020801 RID: 133121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020801")]
		[Address(RVA = "0x1A37740", Offset = "0x1A36340", VA = "0x181A37740")]
		private ListDict<int, int> <>xLuaBaseProxy_get_challengeGroupCountListDic()
		{
			return null;
		}

		// Token: 0x06020802 RID: 133122 RVA: 0x000B62C8 File Offset: 0x000B44C8
		[Token(Token = "0x6020802")]
		[Address(RVA = "0x1A37710", Offset = "0x1A36310", VA = "0x181A37710")]
		private int <>xLuaBaseProxy_GetSwitchPageCountByCurPageIndex(int P0)
		{
			return 0;
		}

		// Token: 0x06020803 RID: 133123 RVA: 0x000B62E0 File Offset: 0x000B44E0
		[Token(Token = "0x6020803")]
		[Address(RVA = "0x1A37700", Offset = "0x1A36300", VA = "0x181A37700")]
		private int <>xLuaBaseProxy_GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel P0)
		{
			return 0;
		}

		// Token: 0x06020804 RID: 133124 RVA: 0x000B62F8 File Offset: 0x000B44F8
		[Token(Token = "0x6020804")]
		[Address(RVA = "0x1A376F0", Offset = "0x1A362F0", VA = "0x181A376F0")]
		private bool <>xLuaBaseProxy_CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x0402C0A2 RID: 180386
		[Token(Token = "0x402C0A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL04TopicChallengeToggleGroup _topicChallengeTogglePrefab;

		// Token: 0x0402C0A3 RID: 180387
		[Token(Token = "0x402C0A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL04TopicChallengeGroup _topicChallengeGroupPrefab;

		// Token: 0x0402C0A4 RID: 180388
		[Token(Token = "0x402C0A4")]
		[FieldOffset(Offset = "0x28")]
		private RL04TopicChallengePluginContext.RL04TopicChallengePluginModel m_viewModel;

		// Token: 0x0402C0A5 RID: 180389
		[Token(Token = "0x402C0A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicChallengeToggleGroupPrefab;

		// Token: 0x0402C0A6 RID: 180390
		[Token(Token = "0x402C0A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicChallengeGroupPrefab;

		// Token: 0x0402C0A7 RID: 180391
		[Token(Token = "0x402C0A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C0A8 RID: 180392
		[Token(Token = "0x402C0A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0402C0A9 RID: 180393
		[Token(Token = "0x402C0A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_challengeGroupCountListDic;

		// Token: 0x0402C0AA RID: 180394
		[Token(Token = "0x402C0AA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

		// Token: 0x0402C0AB RID: 180395
		[Token(Token = "0x402C0AB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCurrChallengeGroupId;

		// Token: 0x0402C0AC RID: 180396
		[Token(Token = "0x402C0AC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfNeedRefreshAllCard;

		// Token: 0x0402C0AD RID: 180397
		[Token(Token = "0x402C0AD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005688 RID: 22152
		[Token(Token = "0x2005688")]
		private class RL04TopicChallengeStatusInfo : IHotfixable
		{
			// Token: 0x17004C29 RID: 19497
			// (get) Token: 0x06020805 RID: 133125 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020806 RID: 133126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004C29")]
			public string challengeId
			{
				[Token(Token = "0x6020805")]
				[Address(RVA = "0x1AA17F0", Offset = "0x1AA03F0", VA = "0x181AA17F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6020806")]
				[Address(RVA = "0x1AA1910", Offset = "0x1AA0510", VA = "0x181AA1910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004C2A RID: 19498
			// (get) Token: 0x06020807 RID: 133127 RVA: 0x000B6310 File Offset: 0x000B4510
			// (set) Token: 0x06020808 RID: 133128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004C2A")]
			public int sortId
			{
				[Token(Token = "0x6020807")]
				[Address(RVA = "0x1AA1850", Offset = "0x1AA0450", VA = "0x181AA1850")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6020808")]
				[Address(RVA = "0x1AA1990", Offset = "0x1AA0590", VA = "0x181AA1990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004C2B RID: 19499
			// (get) Token: 0x06020809 RID: 133129 RVA: 0x000B6328 File Offset: 0x000B4528
			// (set) Token: 0x0602080A RID: 133130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004C2B")]
			public PlayerRoguelikeChallengeStatus status
			{
				[Token(Token = "0x6020809")]
				[Address(RVA = "0x1AA18B0", Offset = "0x1AA04B0", VA = "0x181AA18B0")]
				[CompilerGenerated]
				get
				{
					return PlayerRoguelikeChallengeStatus.LOCKED;
				}
				[Token(Token = "0x602080A")]
				[Address(RVA = "0x1AA1A00", Offset = "0x1AA0600", VA = "0x181AA1A00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602080B RID: 133131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602080B")]
			[Address(RVA = "0x1AA1500", Offset = "0x1AA0100", VA = "0x181AA1500")]
			public static RL04TopicChallengePluginContext.RL04TopicChallengeStatusInfo CreateStatusInfo(string challengeId, int sortId)
			{
				return null;
			}

			// Token: 0x0602080C RID: 133132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602080C")]
			[Address(RVA = "0x1AA16F0", Offset = "0x1AA02F0", VA = "0x181AA16F0")]
			public void RefreshStatus(PlayerRoguelikeChallengeStatus status)
			{
			}

			// Token: 0x0602080D RID: 133133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602080D")]
			[Address(RVA = "0x1AA1790", Offset = "0x1AA0390", VA = "0x181AA1790")]
			public RL04TopicChallengeStatusInfo()
			{
			}

			// Token: 0x0402C0B1 RID: 180401
			[Token(Token = "0x402C0B1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_challengeId;

			// Token: 0x0402C0B2 RID: 180402
			[Token(Token = "0x402C0B2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_challengeId;

			// Token: 0x0402C0B3 RID: 180403
			[Token(Token = "0x402C0B3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x0402C0B4 RID: 180404
			[Token(Token = "0x402C0B4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_sortId;

			// Token: 0x0402C0B5 RID: 180405
			[Token(Token = "0x402C0B5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_status;

			// Token: 0x0402C0B6 RID: 180406
			[Token(Token = "0x402C0B6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_status;

			// Token: 0x0402C0B7 RID: 180407
			[Token(Token = "0x402C0B7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CreateStatusInfo;

			// Token: 0x0402C0B8 RID: 180408
			[Token(Token = "0x402C0B8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RefreshStatus;

			// Token: 0x0402C0B9 RID: 180409
			[Token(Token = "0x402C0B9")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005689 RID: 22153
		[Token(Token = "0x2005689")]
		private class RL04TopicChallengeGroupInfo : IHotfixable
		{
			// Token: 0x0602080E RID: 133134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602080E")]
			[Address(RVA = "0x1AB5180", Offset = "0x1AB3D80", VA = "0x181AB5180")]
			public RL04TopicChallengeGroupInfo()
			{
			}

			// Token: 0x0402C0BA RID: 180410
			[Token(Token = "0x402C0BA")]
			[FieldOffset(Offset = "0x10")]
			public int groupId;

			// Token: 0x0402C0BB RID: 180411
			[Token(Token = "0x402C0BB")]
			[FieldOffset(Offset = "0x14")]
			public int challengeCount;

			// Token: 0x0402C0BC RID: 180412
			[Token(Token = "0x402C0BC")]
			[FieldOffset(Offset = "0x18")]
			public bool isGroupAllComplete;

			// Token: 0x0402C0BD RID: 180413
			[Token(Token = "0x402C0BD")]
			[FieldOffset(Offset = "0x1C")]
			public int lastUnCompleteIndex;

			// Token: 0x0402C0BE RID: 180414
			[Token(Token = "0x402C0BE")]
			[FieldOffset(Offset = "0x20")]
			public List<RL04TopicChallengePluginContext.RL04TopicChallengeStatusInfo> challengeStatus;

			// Token: 0x0402C0BF RID: 180415
			[Token(Token = "0x402C0BF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200568A RID: 22154
		[Token(Token = "0x200568A")]
		private class RL04TopicChallengePluginModel : IHotfixable
		{
			// Token: 0x0602080F RID: 133135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602080F")]
			[Address(RVA = "0x1AB5720", Offset = "0x1AB4320", VA = "0x181AB5720")]
			public void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
			{
			}

			// Token: 0x06020810 RID: 133136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020810")]
			[Address(RVA = "0x1AB5DC0", Offset = "0x1AB49C0", VA = "0x181AB5DC0")]
			public void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
			{
			}

			// Token: 0x06020811 RID: 133137 RVA: 0x000B6340 File Offset: 0x000B4540
			[Token(Token = "0x6020811")]
			[Address(RVA = "0x1AB51E0", Offset = "0x1AB3DE0", VA = "0x181AB51E0")]
			public bool CheckIfNeedRefrushAllCard()
			{
				return default(bool);
			}

			// Token: 0x06020812 RID: 133138 RVA: 0x000B6358 File Offset: 0x000B4558
			[Token(Token = "0x6020812")]
			[Address(RVA = "0x1AB54E0", Offset = "0x1AB40E0", VA = "0x181AB54E0")]
			public int GetSwitchPageCountByCurPageIndex(int curChallengeIndex)
			{
				return 0;
			}

			// Token: 0x06020813 RID: 133139 RVA: 0x000B6370 File Offset: 0x000B4570
			[Token(Token = "0x6020813")]
			[Address(RVA = "0x1AB5FC0", Offset = "0x1AB4BC0", VA = "0x181AB5FC0")]
			private int _GetGroupFocusChallengeIndex(int groupId)
			{
				return 0;
			}

			// Token: 0x06020814 RID: 133140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020814")]
			[Address(RVA = "0x1AB6080", Offset = "0x1AB4C80", VA = "0x181AB6080")]
			public RL04TopicChallengePluginModel()
			{
			}

			// Token: 0x0402C0C0 RID: 180416
			[Token(Token = "0x402C0C0")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<int, RL04TopicChallengePluginContext.RL04TopicChallengeGroupInfo> challengeGroupInfoListDic;

			// Token: 0x0402C0C1 RID: 180417
			[Token(Token = "0x402C0C1")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, int> challengeGroupCountListDic;

			// Token: 0x0402C0C2 RID: 180418
			[Token(Token = "0x402C0C2")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, PlayerRoguelikeChallengeStatus> m_cachedChallengeStatus;

			// Token: 0x0402C0C3 RID: 180419
			[Token(Token = "0x402C0C3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402C0C4 RID: 180420
			[Token(Token = "0x402C0C4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x0402C0C5 RID: 180421
			[Token(Token = "0x402C0C5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckIfNeedRefrushAllCard;

			// Token: 0x0402C0C6 RID: 180422
			[Token(Token = "0x402C0C6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

			// Token: 0x0402C0C7 RID: 180423
			[Token(Token = "0x402C0C7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetGroupFocusChallengeIndex;

			// Token: 0x0402C0C8 RID: 180424
			[Token(Token = "0x402C0C8")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
