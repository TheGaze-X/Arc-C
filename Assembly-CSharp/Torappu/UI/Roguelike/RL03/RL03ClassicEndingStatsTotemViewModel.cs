using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200581D RID: 22557
	[Token(Token = "0x200581D")]
	public class RL03ClassicEndingStatsTotemViewModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x06020F5E RID: 135006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F5E")]
		[Address(RVA = "0x1B468D0", Offset = "0x1B454D0", VA = "0x181B468D0", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x06020F5F RID: 135007 RVA: 0x000B7F90 File Offset: 0x000B6190
		[Token(Token = "0x6020F5F")]
		[Address(RVA = "0x1B46860", Offset = "0x1B45460", VA = "0x181B46860")]
		public int GetTotalCount()
		{
			return 0;
		}

		// Token: 0x06020F60 RID: 135008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F60")]
		[Address(RVA = "0x1B46A50", Offset = "0x1B45650", VA = "0x181B46A50")]
		public RL03ClassicEndingStatsTotemViewModel()
		{
		}

		// Token: 0x0402CD19 RID: 183577
		[Token(Token = "0x402CD19")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402CD1A RID: 183578
		[Token(Token = "0x402CD1A")]
		[FieldOffset(Offset = "0x18")]
		public List<RL03TotemViewModel> totemList;

		// Token: 0x0402CD1B RID: 183579
		[Token(Token = "0x402CD1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CD1C RID: 183580
		[Token(Token = "0x402CD1C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTotalCount;

		// Token: 0x0402CD1D RID: 183581
		[Token(Token = "0x402CD1D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
