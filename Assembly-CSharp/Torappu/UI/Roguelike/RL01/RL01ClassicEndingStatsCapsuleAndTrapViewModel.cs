using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057B4 RID: 22452
	[Token(Token = "0x20057B4")]
	public class RL01ClassicEndingStatsCapsuleAndTrapViewModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x06020D5D RID: 134493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D5D")]
		[Address(RVA = "0x1B1AA40", Offset = "0x1B19640", VA = "0x181B1AA40", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x06020D5E RID: 134494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D5E")]
		[Address(RVA = "0x1B1AB50", Offset = "0x1B19750", VA = "0x181B1AB50")]
		private void _LoadData(string topicId, PlayerRoguelikePendingEvent.EndingRecord endingRecord)
		{
		}

		// Token: 0x06020D5F RID: 134495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D5F")]
		[Address(RVA = "0x1B1ADE0", Offset = "0x1B199E0", VA = "0x181B1ADE0")]
		public RL01ClassicEndingStatsCapsuleAndTrapViewModel()
		{
		}

		// Token: 0x0402C9E1 RID: 182753
		[Token(Token = "0x402C9E1")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeTrapViewModel> trapViewModels;

		// Token: 0x0402C9E2 RID: 182754
		[Token(Token = "0x402C9E2")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeCapsuleViewModel> capsuleViewModels;

		// Token: 0x0402C9E3 RID: 182755
		[Token(Token = "0x402C9E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C9E4 RID: 182756
		[Token(Token = "0x402C9E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0402C9E5 RID: 182757
		[Token(Token = "0x402C9E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
