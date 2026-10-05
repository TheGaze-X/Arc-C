using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006EE RID: 1774
	[Token(Token = "0x20006EE")]
	public class FifthAnnivService
	{
		// Token: 0x06006344 RID: 25412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006344")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FifthAnnivService()
		{
		}

		// Token: 0x04002F0E RID: 12046
		[Token(Token = "0x4002F0E")]
		public const string MISSION_ARCHIVE_CLAIM_ENTRY_REWARD = "/mainline/enterCharVoiceRecord";

		// Token: 0x04002F0F RID: 12047
		[Token(Token = "0x4002F0F")]
		public const string MISSION_ARCHIVE_CLAIM_NODE_REWARD = "/mainline/confirmCharVoiceRecordReward";

		// Token: 0x04002F10 RID: 12048
		[Token(Token = "0x4002F10")]
		public const string EXPLORE_MISSION_CLAIM_SINGLE = "/explore/confirmMission";

		// Token: 0x04002F11 RID: 12049
		[Token(Token = "0x4002F11")]
		public const string EXPLORE_MISSION_CLAIM_ALL = "/explore/confirmMissionList";

		// Token: 0x04002F12 RID: 12050
		[Token(Token = "0x4002F12")]
		public const string EXPLORE_SELECT_INIT_GROUP = "/explore/selectInitGroup";

		// Token: 0x04002F13 RID: 12051
		[Token(Token = "0x4002F13")]
		public const string EXPLORE_CONFIRM_PASS_TARGET = "/explore/confirmPassTarget";

		// Token: 0x04002F14 RID: 12052
		[Token(Token = "0x4002F14")]
		public const string EXPLORE_SETTLE_GAME = "/explore/settleGame";

		// Token: 0x04002F15 RID: 12053
		[Token(Token = "0x4002F15")]
		public const string EXPLORE_SELECT_EVT_OPT = "/explore/selectEventChoice";

		// Token: 0x04002F16 RID: 12054
		[Token(Token = "0x4002F16")]
		public const string EXPLORE_SELECT_TARGET_OPT = "/explore/selectTargetChoice";

		// Token: 0x04002F17 RID: 12055
		[Token(Token = "0x4002F17")]
		public const string EXPLORE_GIVE_UP_GAME = "/explore/giveUpGame";

		// Token: 0x020006EF RID: 1775
		[Token(Token = "0x20006EF")]
		public class MissionArchiveClaimEntryRewardRequest
		{
			// Token: 0x06006345 RID: 25413 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006345")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionArchiveClaimEntryRewardRequest()
			{
			}

			// Token: 0x04002F18 RID: 12056
			[Token(Token = "0x4002F18")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}

		// Token: 0x020006F0 RID: 1776
		[Token(Token = "0x20006F0")]
		public class MissionArchiveClaimEntryRewardResponse : PlayerDeltaResponse, MissionArchiveService.IMissionArchiveClaimEntryRewardResponse
		{
			// Token: 0x06006346 RID: 25414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006346")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
			public List<ItemGet> GetReward()
			{
				return null;
			}

			// Token: 0x06006347 RID: 25415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006347")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public MissionArchiveClaimEntryRewardResponse()
			{
			}

			// Token: 0x04002F19 RID: 12057
			[Token(Token = "0x4002F19")]
			[FieldOffset(Offset = "0x28")]
			public List<ItemGet> reward;
		}

		// Token: 0x020006F1 RID: 1777
		[Token(Token = "0x20006F1")]
		public class MissionArchiveClaimNodeRewardRequest
		{
			// Token: 0x06006348 RID: 25416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006348")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionArchiveClaimNodeRewardRequest()
			{
			}

			// Token: 0x04002F1A RID: 12058
			[Token(Token = "0x4002F1A")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04002F1B RID: 12059
			[Token(Token = "0x4002F1B")]
			[FieldOffset(Offset = "0x18")]
			public string nodeId;
		}

		// Token: 0x020006F2 RID: 1778
		[Token(Token = "0x20006F2")]
		public class MissionArchiveClaimNodeRewardResponse : PlayerDeltaResponse, MissionArchiveService.IMissionArchiveClaimNodeRewardResponse
		{
			// Token: 0x06006349 RID: 25417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006349")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
			public List<ItemGet> GetReward()
			{
				return null;
			}

			// Token: 0x0600634A RID: 25418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600634A")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public MissionArchiveClaimNodeRewardResponse()
			{
			}

			// Token: 0x04002F1C RID: 12060
			[Token(Token = "0x4002F1C")]
			[FieldOffset(Offset = "0x28")]
			public List<ItemGet> reward;
		}

		// Token: 0x020006F3 RID: 1779
		[Token(Token = "0x20006F3")]
		public class ExploreClaimSingleMissionRequest
		{
			// Token: 0x0600634B RID: 25419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600634B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExploreClaimSingleMissionRequest()
			{
			}

			// Token: 0x04002F1D RID: 12061
			[Token(Token = "0x4002F1D")]
			[FieldOffset(Offset = "0x10")]
			public string id;
		}

		// Token: 0x020006F4 RID: 1780
		[Token(Token = "0x20006F4")]
		public class ExploreClaimSingleMissionResponse : PlayerDeltaResponse
		{
			// Token: 0x0600634C RID: 25420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600634C")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public ExploreClaimSingleMissionResponse()
			{
			}

			// Token: 0x04002F1E RID: 12062
			[Token(Token = "0x4002F1E")]
			[FieldOffset(Offset = "0x28")]
			public List<RewardItemModel> reward;
		}

		// Token: 0x020006F5 RID: 1781
		[Token(Token = "0x20006F5")]
		public class ExploreClaimAllMissionRequest
		{
			// Token: 0x0600634D RID: 25421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600634D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExploreClaimAllMissionRequest()
			{
			}

			// Token: 0x04002F1F RID: 12063
			[Token(Token = "0x4002F1F")]
			[FieldOffset(Offset = "0x10")]
			public List<string> idList;
		}

		// Token: 0x020006F6 RID: 1782
		[Token(Token = "0x20006F6")]
		public class ExploreClaimAllMissionListResponse : PlayerDeltaResponse
		{
			// Token: 0x0600634E RID: 25422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600634E")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public ExploreClaimAllMissionListResponse()
			{
			}

			// Token: 0x04002F20 RID: 12064
			[Token(Token = "0x4002F20")]
			[FieldOffset(Offset = "0x28")]
			public List<RewardItemModel> reward;
		}

		// Token: 0x020006F7 RID: 1783
		[Token(Token = "0x20006F7")]
		public class ExploreSelectEventOptionRequest
		{
			// Token: 0x0600634F RID: 25423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600634F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExploreSelectEventOptionRequest()
			{
			}

			// Token: 0x04002F21 RID: 12065
			[Token(Token = "0x4002F21")]
			[FieldOffset(Offset = "0x10")]
			public int index;
		}

		// Token: 0x020006F8 RID: 1784
		[Token(Token = "0x20006F8")]
		public class ExploreSelectEventOptionResponse : PlayerDeltaResponse
		{
			// Token: 0x06006350 RID: 25424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006350")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public ExploreSelectEventOptionResponse()
			{
			}

			// Token: 0x04002F22 RID: 12066
			[Token(Token = "0x4002F22")]
			[FieldOffset(Offset = "0x28")]
			public bool success;

			// Token: 0x04002F23 RID: 12067
			[Token(Token = "0x4002F23")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, int> abilitiesDelta;

			// Token: 0x04002F24 RID: 12068
			[Token(Token = "0x4002F24")]
			[FieldOffset(Offset = "0x38")]
			public string choiceChose;
		}

		// Token: 0x020006F9 RID: 1785
		[Token(Token = "0x20006F9")]
		public class ExploreSelectTargetOptionRequest
		{
			// Token: 0x06006351 RID: 25425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006351")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExploreSelectTargetOptionRequest()
			{
			}

			// Token: 0x04002F25 RID: 12069
			[Token(Token = "0x4002F25")]
			[FieldOffset(Offset = "0x10")]
			public int index;
		}

		// Token: 0x020006FA RID: 1786
		[Token(Token = "0x20006FA")]
		public class ExploreSelectTargetOptionResponse : PlayerDeltaResponse
		{
			// Token: 0x06006352 RID: 25426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006352")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public ExploreSelectTargetOptionResponse()
			{
			}
		}

		// Token: 0x020006FB RID: 1787
		[Token(Token = "0x20006FB")]
		public class ExploreSelectInitGroupRequest
		{
			// Token: 0x06006353 RID: 25427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006353")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExploreSelectInitGroupRequest()
			{
			}

			// Token: 0x04002F26 RID: 12070
			[Token(Token = "0x4002F26")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04002F27 RID: 12071
			[Token(Token = "0x4002F27")]
			[FieldOffset(Offset = "0x18")]
			public bool heritage;
		}

		// Token: 0x020006FC RID: 1788
		[Token(Token = "0x20006FC")]
		public class ExploreSelectInitGroupResponse : PlayerDeltaResponse
		{
			// Token: 0x06006354 RID: 25428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006354")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public ExploreSelectInitGroupResponse()
			{
			}
		}

		// Token: 0x020006FD RID: 1789
		[Token(Token = "0x20006FD")]
		public class ExploreConfirmPassTargetRequest
		{
			// Token: 0x06006355 RID: 25429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006355")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExploreConfirmPassTargetRequest()
			{
			}
		}

		// Token: 0x020006FE RID: 1790
		[Token(Token = "0x20006FE")]
		public class ExploreConfirmPassTargetResponse : PlayerDeltaResponse
		{
			// Token: 0x06006356 RID: 25430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006356")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public ExploreConfirmPassTargetResponse()
			{
			}
		}

		// Token: 0x020006FF RID: 1791
		[Token(Token = "0x20006FF")]
		public class ExploreSettleGameRequest
		{
			// Token: 0x06006357 RID: 25431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006357")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExploreSettleGameRequest()
			{
			}
		}

		// Token: 0x02000700 RID: 1792
		[Token(Token = "0x2000700")]
		public class ExploreSettleGameResponse : PlayerDeltaResponse
		{
			// Token: 0x06006358 RID: 25432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006358")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public ExploreSettleGameResponse()
			{
			}
		}

		// Token: 0x02000701 RID: 1793
		[Token(Token = "0x2000701")]
		public class ExploreGiveUpGameRequest
		{
			// Token: 0x06006359 RID: 25433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006359")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExploreGiveUpGameRequest()
			{
			}
		}

		// Token: 0x02000702 RID: 1794
		[Token(Token = "0x2000702")]
		public class ExploreGiveUpGameResponse : PlayerDeltaResponse
		{
			// Token: 0x0600635A RID: 25434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600635A")]
			[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
			public ExploreGiveUpGameResponse()
			{
			}
		}
	}
}
