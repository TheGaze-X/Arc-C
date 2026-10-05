using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007341 RID: 29505
	[Token(Token = "0x2007341")]
	public class Act42D0RewardMilestoneServiceConfig : IMilestoneServiceConfig
	{
		// Token: 0x06029BAF RID: 170927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BAF")]
		[Address(RVA = "0x22FF1A0", Offset = "0x22FDDA0", VA = "0x1822FF1A0")]
		public Act42D0RewardMilestoneServiceConfig(string actId, List<string> milestones, Action<List<RewardItemModel>> onProceed)
		{
		}

		// Token: 0x06029BB0 RID: 170928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BB0")]
		[Address(RVA = "0x25638F0", Offset = "0x25624F0", VA = "0x1825638F0", Slot = "4")]
		public void SendRewardMilestoneRequest()
		{
		}

		// Token: 0x0403BBB3 RID: 244659
		[Token(Token = "0x403BBB3")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403BBB4 RID: 244660
		[Token(Token = "0x403BBB4")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_milestones;

		// Token: 0x0403BBB5 RID: 244661
		[Token(Token = "0x403BBB5")]
		[FieldOffset(Offset = "0x20")]
		private Action<List<RewardItemModel>> m_onProceed;
	}
}
