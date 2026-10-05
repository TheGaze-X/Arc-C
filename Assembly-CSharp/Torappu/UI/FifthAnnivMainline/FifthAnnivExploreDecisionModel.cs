using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E9E RID: 20126
	[Token(Token = "0x2004E9E")]
	public class FifthAnnivExploreDecisionModel : IHotfixable
	{
		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x0601E05C RID: 122972 RVA: 0x000AD310 File Offset: 0x000AB510
		// (set) Token: 0x0601E05D RID: 122973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004669")]
		public PlayerMainlineExplore.DecisionNodeType decisionType
		{
			[Token(Token = "0x601E05C")]
			[Address(RVA = "0x17B7B60", Offset = "0x17B6760", VA = "0x1817B7B60")]
			[CompilerGenerated]
			get
			{
				return PlayerMainlineExplore.DecisionNodeType.NONE;
			}
			[Token(Token = "0x601E05D")]
			[Address(RVA = "0x17B7E10", Offset = "0x17B6A10", VA = "0x1817B7E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x0601E05E RID: 122974 RVA: 0x000AD328 File Offset: 0x000AB528
		// (set) Token: 0x0601E05F RID: 122975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700466A")]
		public FifthAnnivExploreDecisionModel.DecisionStatus currStatus
		{
			[Token(Token = "0x601E05E")]
			[Address(RVA = "0x17B7B00", Offset = "0x17B6700", VA = "0x1817B7B00")]
			[CompilerGenerated]
			get
			{
				return FifthAnnivExploreDecisionModel.DecisionStatus.NONE;
			}
			[Token(Token = "0x601E05F")]
			[Address(RVA = "0x17B7DA0", Offset = "0x17B69A0", VA = "0x1817B7DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x0601E060 RID: 122976 RVA: 0x000AD340 File Offset: 0x000AB540
		// (set) Token: 0x0601E061 RID: 122977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700466B")]
		public int enterSeqNum
		{
			[Token(Token = "0x601E060")]
			[Address(RVA = "0x17B7BC0", Offset = "0x17B67C0", VA = "0x1817B7BC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601E061")]
			[Address(RVA = "0x17B7E80", Offset = "0x17B6A80", VA = "0x1817B7E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700466C RID: 18028
		// (get) Token: 0x0601E062 RID: 122978 RVA: 0x000AD358 File Offset: 0x000AB558
		// (set) Token: 0x0601E063 RID: 122979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700466C")]
		public int switchPlanSeqNum
		{
			[Token(Token = "0x601E062")]
			[Address(RVA = "0x17B7D40", Offset = "0x17B6940", VA = "0x1817B7D40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601E063")]
			[Address(RVA = "0x17B7F60", Offset = "0x17B6B60", VA = "0x1817B7F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700466D RID: 18029
		// (get) Token: 0x0601E064 RID: 122980 RVA: 0x000AD370 File Offset: 0x000AB570
		// (set) Token: 0x0601E065 RID: 122981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700466D")]
		public bool inExploreDetailState
		{
			[Token(Token = "0x601E064")]
			[Address(RVA = "0x17B7C20", Offset = "0x17B6820", VA = "0x1817B7C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E065")]
			[Address(RVA = "0x17B7EF0", Offset = "0x17B6AF0", VA = "0x1817B7EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700466E RID: 18030
		// (get) Token: 0x0601E066 RID: 122982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700466E")]
		public List<FifthAnnivExplorePlanModel> planList
		{
			[Token(Token = "0x601E066")]
			[Address(RVA = "0x17B7CE0", Offset = "0x17B68E0", VA = "0x1817B7CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700466F RID: 18031
		// (get) Token: 0x0601E067 RID: 122983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700466F")]
		public FifthAnnivExploreLogModel logModel
		{
			[Token(Token = "0x601E067")]
			[Address(RVA = "0x17B7C80", Offset = "0x17B6880", VA = "0x1817B7C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E068 RID: 122984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E068")]
		[Address(RVA = "0x17B6360", Offset = "0x17B4F60", VA = "0x1817B6360")]
		public FifthAnnivExploreEventPlanModel GetPrevEventModel()
		{
			return null;
		}

		// Token: 0x0601E069 RID: 122985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E069")]
		[Address(RVA = "0x17B6AA0", Offset = "0x17B56A0", VA = "0x1817B6AA0")]
		public void JumpToEvtRetStatus(FifthAnnivService.ExploreSelectEventOptionResponse response)
		{
		}

		// Token: 0x0601E06A RID: 122986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E06A")]
		[Address(RVA = "0x17B71D0", Offset = "0x17B5DD0", VA = "0x1817B71D0")]
		public void JumpToPrevEvent()
		{
		}

		// Token: 0x0601E06B RID: 122987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E06B")]
		[Address(RVA = "0x17B6230", Offset = "0x17B4E30", VA = "0x1817B6230")]
		public FifthAnnivExploreEventPlanModel GetNextEventModel()
		{
			return null;
		}

		// Token: 0x0601E06C RID: 122988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E06C")]
		[Address(RVA = "0x17B6F80", Offset = "0x17B5B80", VA = "0x1817B6F80")]
		public void JumpToNextEvent()
		{
		}

		// Token: 0x0601E06D RID: 122989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E06D")]
		[Address(RVA = "0x17B60C0", Offset = "0x17B4CC0", VA = "0x1817B60C0")]
		public FifthAnnivExplorePlanModel GetCurrPlanModel()
		{
			return null;
		}

		// Token: 0x0601E06E RID: 122990 RVA: 0x000AD388 File Offset: 0x000AB588
		[Token(Token = "0x601E06E")]
		[Address(RVA = "0x17B69A0", Offset = "0x17B55A0", VA = "0x1817B69A0")]
		public bool IsInEvtDecision()
		{
			return default(bool);
		}

		// Token: 0x0601E06F RID: 122991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E06F")]
		[Address(RVA = "0x17B6010", Offset = "0x17B4C10", VA = "0x1817B6010")]
		public void BackToEvtInfo()
		{
		}

		// Token: 0x0601E070 RID: 122992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E070")]
		[Address(RVA = "0x17B7100", Offset = "0x17B5D00", VA = "0x1817B7100")]
		public void JumpToPlanStatus(string planId)
		{
		}

		// Token: 0x0601E071 RID: 122993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E071")]
		[Address(RVA = "0x17B7350", Offset = "0x17B5F50", VA = "0x1817B7350")]
		public void SelectOption(string optionId)
		{
		}

		// Token: 0x0601E072 RID: 122994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E072")]
		[Address(RVA = "0x17B7460", Offset = "0x17B6060", VA = "0x1817B7460")]
		public void SetInExploreDetailState(bool inExploreDetailState)
		{
		}

		// Token: 0x0601E073 RID: 122995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E073")]
		[Address(RVA = "0x17B64A0", Offset = "0x17B50A0", VA = "0x1817B64A0")]
		public void InitData()
		{
		}

		// Token: 0x0601E074 RID: 122996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E074")]
		[Address(RVA = "0x17B7670", Offset = "0x17B6270", VA = "0x1817B7670")]
		private void _InitEventPlanList(PlayerMainlineExplore.PlayerExploreGameContextNode playerNode)
		{
		}

		// Token: 0x0601E075 RID: 122997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E075")]
		[Address(RVA = "0x17B7830", Offset = "0x17B6430", VA = "0x1817B7830")]
		private void _InitTargetPlanList(string nextStageId, List<string> playerTarget)
		{
		}

		// Token: 0x0601E076 RID: 122998 RVA: 0x000AD3A0 File Offset: 0x000AB5A0
		[Token(Token = "0x601E076")]
		[Address(RVA = "0x17B7500", Offset = "0x17B6100", VA = "0x1817B7500")]
		private int _GetCurrPlanIdx()
		{
			return 0;
		}

		// Token: 0x0601E077 RID: 122999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E077")]
		[Address(RVA = "0x17B7970", Offset = "0x17B6570", VA = "0x1817B7970")]
		public FifthAnnivExploreDecisionModel()
		{
		}

		// Token: 0x04027EB9 RID: 163513
		[Token(Token = "0x4027EB9")]
		[FieldOffset(Offset = "0x10")]
		private List<FifthAnnivExplorePlanModel> m_planList;

		// Token: 0x04027EBA RID: 163514
		[Token(Token = "0x4027EBA")]
		[FieldOffset(Offset = "0x18")]
		private string m_selectPlanId;

		// Token: 0x04027EBB RID: 163515
		[Token(Token = "0x4027EBB")]
		[FieldOffset(Offset = "0x20")]
		private FifthAnnivExploreLogModel m_logModel;

		// Token: 0x04027EC1 RID: 163521
		[Token(Token = "0x4027EC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_decisionType;

		// Token: 0x04027EC2 RID: 163522
		[Token(Token = "0x4027EC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_decisionType;

		// Token: 0x04027EC3 RID: 163523
		[Token(Token = "0x4027EC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currStatus;

		// Token: 0x04027EC4 RID: 163524
		[Token(Token = "0x4027EC4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_currStatus;

		// Token: 0x04027EC5 RID: 163525
		[Token(Token = "0x4027EC5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enterSeqNum;

		// Token: 0x04027EC6 RID: 163526
		[Token(Token = "0x4027EC6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_enterSeqNum;

		// Token: 0x04027EC7 RID: 163527
		[Token(Token = "0x4027EC7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_switchPlanSeqNum;

		// Token: 0x04027EC8 RID: 163528
		[Token(Token = "0x4027EC8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_switchPlanSeqNum;

		// Token: 0x04027EC9 RID: 163529
		[Token(Token = "0x4027EC9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_inExploreDetailState;

		// Token: 0x04027ECA RID: 163530
		[Token(Token = "0x4027ECA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_inExploreDetailState;

		// Token: 0x04027ECB RID: 163531
		[Token(Token = "0x4027ECB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_planList;

		// Token: 0x04027ECC RID: 163532
		[Token(Token = "0x4027ECC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_logModel;

		// Token: 0x04027ECD RID: 163533
		[Token(Token = "0x4027ECD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetPrevEventModel;

		// Token: 0x04027ECE RID: 163534
		[Token(Token = "0x4027ECE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_JumpToEvtRetStatus;

		// Token: 0x04027ECF RID: 163535
		[Token(Token = "0x4027ECF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_JumpToPrevEvent;

		// Token: 0x04027ED0 RID: 163536
		[Token(Token = "0x4027ED0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetNextEventModel;

		// Token: 0x04027ED1 RID: 163537
		[Token(Token = "0x4027ED1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_JumpToNextEvent;

		// Token: 0x04027ED2 RID: 163538
		[Token(Token = "0x4027ED2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetCurrPlanModel;

		// Token: 0x04027ED3 RID: 163539
		[Token(Token = "0x4027ED3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_IsInEvtDecision;

		// Token: 0x04027ED4 RID: 163540
		[Token(Token = "0x4027ED4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_BackToEvtInfo;

		// Token: 0x04027ED5 RID: 163541
		[Token(Token = "0x4027ED5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_JumpToPlanStatus;

		// Token: 0x04027ED6 RID: 163542
		[Token(Token = "0x4027ED6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SelectOption;

		// Token: 0x04027ED7 RID: 163543
		[Token(Token = "0x4027ED7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetInExploreDetailState;

		// Token: 0x04027ED8 RID: 163544
		[Token(Token = "0x4027ED8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04027ED9 RID: 163545
		[Token(Token = "0x4027ED9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__InitEventPlanList;

		// Token: 0x04027EDA RID: 163546
		[Token(Token = "0x4027EDA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__InitTargetPlanList;

		// Token: 0x04027EDB RID: 163547
		[Token(Token = "0x4027EDB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GetCurrPlanIdx;

		// Token: 0x04027EDC RID: 163548
		[Token(Token = "0x4027EDC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E9F RID: 20127
		[Token(Token = "0x2004E9F")]
		public enum DecisionStatus
		{
			// Token: 0x04027EDE RID: 163550
			[Token(Token = "0x4027EDE")]
			NONE,
			// Token: 0x04027EDF RID: 163551
			[Token(Token = "0x4027EDF")]
			EVT_INFO,
			// Token: 0x04027EE0 RID: 163552
			[Token(Token = "0x4027EE0")]
			PLAN,
			// Token: 0x04027EE1 RID: 163553
			[Token(Token = "0x4027EE1")]
			LOG
		}
	}
}
