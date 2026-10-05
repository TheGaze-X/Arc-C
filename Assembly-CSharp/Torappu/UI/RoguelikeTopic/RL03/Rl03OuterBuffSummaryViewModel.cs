using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045E7 RID: 17895
	[Token(Token = "0x20045E7")]
	public class Rl03OuterBuffSummaryViewModel : IHotfixable
	{
		// Token: 0x0601B344 RID: 111428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B344")]
		[Address(RVA = "0x146A2C0", Offset = "0x1468EC0", VA = "0x18146A2C0")]
		public void LoadData(string topic)
		{
		}

		// Token: 0x0601B345 RID: 111429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B345")]
		[Address(RVA = "0x146B0D0", Offset = "0x1469CD0", VA = "0x18146B0D0")]
		public Rl03OuterBuffSummaryViewModel()
		{
		}

		// Token: 0x04023119 RID: 143641
		[Token(Token = "0x4023119")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402311A RID: 143642
		[Token(Token = "0x402311A")]
		[FieldOffset(Offset = "0x18")]
		public List<Rl03OuterBuffSummaryMergedItemModel> mergedItems;

		// Token: 0x0402311B RID: 143643
		[Token(Token = "0x402311B")]
		[FieldOffset(Offset = "0x20")]
		public List<Rl03OuterBuffSummaryRawTextGroupItemModel> rawTextGroup;

		// Token: 0x0402311C RID: 143644
		[Token(Token = "0x402311C")]
		[FieldOffset(Offset = "0x28")]
		public List<Rl03OuterBuffSummaryDifficultyItemModel> difficultyItems;

		// Token: 0x0402311D RID: 143645
		[Token(Token = "0x402311D")]
		[FieldOffset(Offset = "0x30")]
		public int buffCount;

		// Token: 0x0402311E RID: 143646
		[Token(Token = "0x402311E")]
		[FieldOffset(Offset = "0x34")]
		public int unlockCount;

		// Token: 0x0402311F RID: 143647
		[Token(Token = "0x402311F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04023120 RID: 143648
		[Token(Token = "0x4023120")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
