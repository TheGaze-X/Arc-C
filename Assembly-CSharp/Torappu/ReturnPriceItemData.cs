using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001145 RID: 4421
	[Token(Token = "0x2001145")]
	public class ReturnPriceItemData : IComparable
	{
		// Token: 0x06006F22 RID: 28450 RVA: 0x00032538 File Offset: 0x00030738
		[Token(Token = "0x6006F22")]
		[Address(RVA = "0x21100B0", Offset = "0x210ECB0", VA = "0x1821100B0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F23")]
		[Address(RVA = "0x2110190", Offset = "0x210ED90", VA = "0x182110190")]
		public ReturnPriceItemData()
		{
		}

		// Token: 0x04005EBF RID: 24255
		[Token(Token = "0x4005EBF")]
		[FieldOffset(Offset = "0x10")]
		public string contentId;

		// Token: 0x04005EC0 RID: 24256
		[Token(Token = "0x4005EC0")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005EC1 RID: 24257
		[Token(Token = "0x4005EC1")]
		[FieldOffset(Offset = "0x1C")]
		public int pointRequire;

		// Token: 0x04005EC2 RID: 24258
		[Token(Token = "0x4005EC2")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04005EC3 RID: 24259
		[Token(Token = "0x4005EC3")]
		[FieldOffset(Offset = "0x28")]
		public ReturnItemData displayReward;

		// Token: 0x04005EC4 RID: 24260
		[Token(Token = "0x4005EC4")]
		[FieldOffset(Offset = "0x30")]
		public List<ReturnItemData> rewardList;
	}
}
