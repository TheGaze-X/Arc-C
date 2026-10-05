using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CF2 RID: 27890
	[Token(Token = "0x2006CF2")]
	public interface ITemplateActivityMilestonePlugin
	{
		// Token: 0x06027C2E RID: 162862
		[Token(Token = "0x6027C2E")]
		void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList);

		// Token: 0x06027C2F RID: 162863
		[Token(Token = "0x6027C2F")]
		void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList);

		// Token: 0x06027C30 RID: 162864
		[Token(Token = "0x6027C30")]
		int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2);

		// Token: 0x06027C31 RID: 162865
		[Token(Token = "0x6027C31")]
		bool IsItemShow(TemplateActivityMileStoneItemModel itemModel);

		// Token: 0x06027C32 RID: 162866
		[Token(Token = "0x6027C32")]
		string GetMilestoneId(string actId);

		// Token: 0x06027C33 RID: 162867
		[Token(Token = "0x6027C33")]
		int UpdateMilestoneCount(string actId);

		// Token: 0x06027C34 RID: 162868
		[Token(Token = "0x6027C34")]
		bool NeedFocusToIdx();

		// Token: 0x06027C35 RID: 162869
		[Token(Token = "0x6027C35")]
		IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed);

		// Token: 0x06027C36 RID: 162870
		[Token(Token = "0x6027C36")]
		IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed);

		// Token: 0x06027C37 RID: 162871
		[Token(Token = "0x6027C37")]
		bool IsMilestoneUnlock(string actId);

		// Token: 0x06027C38 RID: 162872
		[Token(Token = "0x6027C38")]
		string GetMilestoneLockedToastDesc(string actId);

		// Token: 0x06027C39 RID: 162873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C39")]
		[Address(RVA = "0x22F8E10", Offset = "0x22F7A10", VA = "0x1822F8E10", Slot = "11")]
		string GetMilestoneExpandTrackGroup(string actId)
		{
			return null;
		}
	}
}
