using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FB9 RID: 4025
	[Token(Token = "0x2000FB9")]
	public class CrisisV2LongTermShopInfo
	{
		// Token: 0x06006D00 RID: 27904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D00")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2LongTermShopInfo()
		{
		}

		// Token: 0x0400555E RID: 21854
		[Token(Token = "0x400555E")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400555F RID: 21855
		[Token(Token = "0x400555F")]
		[FieldOffset(Offset = "0x18")]
		public string seasonId;

		// Token: 0x04005560 RID: 21856
		[Token(Token = "0x4005560")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle item;

		// Token: 0x04005561 RID: 21857
		[Token(Token = "0x4005561")]
		[FieldOffset(Offset = "0x28")]
		public string progressGoodId;

		// Token: 0x04005562 RID: 21858
		[Token(Token = "0x4005562")]
		[FieldOffset(Offset = "0x30")]
		public string title;

		// Token: 0x04005563 RID: 21859
		[Token(Token = "0x4005563")]
		[FieldOffset(Offset = "0x38")]
		public long itemSupplyTime;

		// Token: 0x04005564 RID: 21860
		[Token(Token = "0x4005564")]
		[FieldOffset(Offset = "0x40")]
		public CrisisV2GoodType goodType;

		// Token: 0x04005565 RID: 21861
		[Token(Token = "0x4005565")]
		[FieldOffset(Offset = "0x44")]
		public int slotId1;

		// Token: 0x04005566 RID: 21862
		[Token(Token = "0x4005566")]
		[FieldOffset(Offset = "0x48")]
		public int slotId2;

		// Token: 0x04005567 RID: 21863
		[Token(Token = "0x4005567")]
		[FieldOffset(Offset = "0x4C")]
		public int price;

		// Token: 0x04005568 RID: 21864
		[Token(Token = "0x4005568")]
		[FieldOffset(Offset = "0x50")]
		public int availCount;
	}
}
