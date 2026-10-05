using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CEE RID: 27886
	[Token(Token = "0x2006CEE")]
	public class TemplateActivityRewardAllMilestoneServiceConfig : IMilestoneServiceConfig
	{
		// Token: 0x06027C1B RID: 162843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C1B")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public TemplateActivityRewardAllMilestoneServiceConfig(string actId, Action<List<RewardItemModel>> onProceed)
		{
		}

		// Token: 0x06027C1C RID: 162844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C1C")]
		[Address(RVA = "0x22FED70", Offset = "0x22FD970", VA = "0x1822FED70", Slot = "4")]
		public void SendRewardMilestoneRequest()
		{
		}

		// Token: 0x0403861E RID: 230942
		[Token(Token = "0x403861E")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403861F RID: 230943
		[Token(Token = "0x403861F")]
		[FieldOffset(Offset = "0x18")]
		private Action<List<RewardItemModel>> m_onProceed;
	}
}
