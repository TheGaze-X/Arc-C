using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200573B RID: 22331
	[Token(Token = "0x200573B")]
	public class RL02ClassicEndingStatsMutationAndVirtueViewModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x06020B99 RID: 134041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B99")]
		[Address(RVA = "0x1B061D0", Offset = "0x1B04DD0", VA = "0x181B061D0", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x06020B9A RID: 134042 RVA: 0x000B6FB8 File Offset: 0x000B51B8
		[Token(Token = "0x6020B9A")]
		[Address(RVA = "0x1B060D0", Offset = "0x1B04CD0", VA = "0x181B060D0")]
		public int GetTotalCount()
		{
			return 0;
		}

		// Token: 0x06020B9B RID: 134043 RVA: 0x000B6FD0 File Offset: 0x000B51D0
		[Token(Token = "0x6020B9B")]
		[Address(RVA = "0x1B06160", Offset = "0x1B04D60", VA = "0x181B06160")]
		public bool HasMutation()
		{
			return default(bool);
		}

		// Token: 0x06020B9C RID: 134044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B9C")]
		[Address(RVA = "0x1B06480", Offset = "0x1B05080", VA = "0x181B06480")]
		public RL02ClassicEndingStatsMutationAndVirtueViewModel()
		{
		}

		// Token: 0x0402C6C9 RID: 181961
		[Token(Token = "0x402C6C9")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402C6CA RID: 181962
		[Token(Token = "0x402C6CA")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeCharBuffModel mutation;

		// Token: 0x0402C6CB RID: 181963
		[Token(Token = "0x402C6CB")]
		[FieldOffset(Offset = "0x50")]
		public List<RoguelikeSquadBuffModel> virtueList;

		// Token: 0x0402C6CC RID: 181964
		[Token(Token = "0x402C6CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C6CD RID: 181965
		[Token(Token = "0x402C6CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTotalCount;

		// Token: 0x0402C6CE RID: 181966
		[Token(Token = "0x402C6CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HasMutation;

		// Token: 0x0402C6CF RID: 181967
		[Token(Token = "0x402C6CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
