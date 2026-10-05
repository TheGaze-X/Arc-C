using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CED RID: 27885
	[Token(Token = "0x2006CED")]
	public class TemplateActivityRewardMilestoneServiceConfig : IMilestoneServiceConfig
	{
		// Token: 0x06027C18 RID: 162840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C18")]
		[Address(RVA = "0x22FF1A0", Offset = "0x22FDDA0", VA = "0x1822FF1A0")]
		public TemplateActivityRewardMilestoneServiceConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
		{
		}

		// Token: 0x06027C19 RID: 162841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C19")]
		[Address(RVA = "0x22FEF80", Offset = "0x22FDB80", VA = "0x1822FEF80", Slot = "4")]
		public void SendRewardMilestoneRequest()
		{
		}

		// Token: 0x0403861B RID: 230939
		[Token(Token = "0x403861B")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403861C RID: 230940
		[Token(Token = "0x403861C")]
		[FieldOffset(Offset = "0x18")]
		private string m_milestoneId;

		// Token: 0x0403861D RID: 230941
		[Token(Token = "0x403861D")]
		[FieldOffset(Offset = "0x20")]
		private Action<List<RewardItemModel>> m_onProceed;
	}
}
