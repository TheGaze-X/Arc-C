using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005715 RID: 22293
	[Token(Token = "0x2005715")]
	public class RL04ShopFragmentRecycleViewModel : RoguelikeGoodsViewModel
	{
		// Token: 0x06020ADC RID: 133852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ADC")]
		[Address(RVA = "0x1B14EC0", Offset = "0x1B13AC0", VA = "0x181B14EC0")]
		public RL04ShopFragmentRecycleViewModel()
		{
		}

		// Token: 0x0402C59C RID: 181660
		[Token(Token = "0x402C59C")]
		[FieldOffset(Offset = "0x88")]
		public RoguelikeFragmentType fragmentType;

		// Token: 0x0402C59D RID: 181661
		[Token(Token = "0x402C59D")]
		[FieldOffset(Offset = "0x8C")]
		public int sortId;

		// Token: 0x0402C59E RID: 181662
		[Token(Token = "0x402C59E")]
		[FieldOffset(Offset = "0x90")]
		public int weight;

		// Token: 0x0402C59F RID: 181663
		[Token(Token = "0x402C59F")]
		[FieldOffset(Offset = "0x94")]
		public int value;

		// Token: 0x0402C5A0 RID: 181664
		[Token(Token = "0x402C5A0")]
		[FieldOffset(Offset = "0x98")]
		public long ts;

		// Token: 0x0402C5A1 RID: 181665
		[Token(Token = "0x402C5A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
