using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B0E RID: 23310
	[Token(Token = "0x2005B0E")]
	public class LMTGSViewModel
	{
		// Token: 0x06021DCE RID: 138702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DCE")]
		[Address(RVA = "0x1C58650", Offset = "0x1C57250", VA = "0x181C58650")]
		public void LoadData(LMTGSGood goodData)
		{
		}

		// Token: 0x06021DCF RID: 138703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DCF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LMTGSViewModel()
		{
		}

		// Token: 0x0402E63A RID: 190010
		[Token(Token = "0x402E63A")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0402E63B RID: 190011
		[Token(Token = "0x402E63B")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle priceItem;

		// Token: 0x0402E63C RID: 190012
		[Token(Token = "0x402E63C")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x0402E63D RID: 190013
		[Token(Token = "0x402E63D")]
		[FieldOffset(Offset = "0x28")]
		public int availCount;

		// Token: 0x0402E63E RID: 190014
		[Token(Token = "0x402E63E")]
		[FieldOffset(Offset = "0x2C")]
		public int buyCount;

		// Token: 0x0402E63F RID: 190015
		[Token(Token = "0x402E63F")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x0402E640 RID: 190016
		[Token(Token = "0x402E640")]
		[FieldOffset(Offset = "0x38")]
		public ItemBundle item;
	}
}
