using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056C5 RID: 22213
	[Token(Token = "0x20056C5")]
	public class RL04FragmentDetailWeightViewModel : IHotfixable
	{
		// Token: 0x0602094E RID: 133454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602094E")]
		[Address(RVA = "0x1AAF320", Offset = "0x1AADF20", VA = "0x181AAF320")]
		public void RefreshStatus(RL04FragmentItemViewModel selectItem)
		{
		}

		// Token: 0x0602094F RID: 133455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602094F")]
		[Address(RVA = "0x1AAF430", Offset = "0x1AAE030", VA = "0x181AAF430")]
		public RL04FragmentDetailWeightViewModel()
		{
		}

		// Token: 0x0402C275 RID: 180853
		[Token(Token = "0x402C275")]
		[FieldOffset(Offset = "0x10")]
		public FragmentBagStatus status;

		// Token: 0x0402C276 RID: 180854
		[Token(Token = "0x402C276")]
		[FieldOffset(Offset = "0x14")]
		public int totalWeight;

		// Token: 0x0402C277 RID: 180855
		[Token(Token = "0x402C277")]
		[FieldOffset(Offset = "0x18")]
		public int limitWeight;

		// Token: 0x0402C278 RID: 180856
		[Token(Token = "0x402C278")]
		[FieldOffset(Offset = "0x1C")]
		public int overWeight;

		// Token: 0x0402C279 RID: 180857
		[Token(Token = "0x402C279")]
		[FieldOffset(Offset = "0x20")]
		public float weightProgress;

		// Token: 0x0402C27A RID: 180858
		[Token(Token = "0x402C27A")]
		[FieldOffset(Offset = "0x24")]
		public int weightWithoutFragment;

		// Token: 0x0402C27B RID: 180859
		[Token(Token = "0x402C27B")]
		[FieldOffset(Offset = "0x28")]
		public float weightProgressWithoutFragment;

		// Token: 0x0402C27C RID: 180860
		[Token(Token = "0x402C27C")]
		[FieldOffset(Offset = "0x2C")]
		public float limitWeightScale;

		// Token: 0x0402C27D RID: 180861
		[Token(Token = "0x402C27D")]
		[FieldOffset(Offset = "0x30")]
		public float overWeightScale;

		// Token: 0x0402C27E RID: 180862
		[Token(Token = "0x402C27E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshStatus;

		// Token: 0x0402C27F RID: 180863
		[Token(Token = "0x402C27F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
