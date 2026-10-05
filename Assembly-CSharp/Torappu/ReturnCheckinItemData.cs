using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001143 RID: 4419
	[Token(Token = "0x2001143")]
	public class ReturnCheckinItemData : IComparable
	{
		// Token: 0x06006F1F RID: 28447 RVA: 0x00032520 File Offset: 0x00030720
		[Token(Token = "0x6006F1F")]
		[Address(RVA = "0x210F7A0", Offset = "0x210E3A0", VA = "0x18210F7A0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F20")]
		[Address(RVA = "0x210F850", Offset = "0x210E450", VA = "0x18210F850")]
		public ReturnCheckinItemData()
		{
		}

		// Token: 0x04005EBA RID: 24250
		[Token(Token = "0x4005EBA")]
		[FieldOffset(Offset = "0x10")]
		public int order;

		// Token: 0x04005EBB RID: 24251
		[Token(Token = "0x4005EBB")]
		[FieldOffset(Offset = "0x14")]
		public bool isKeyItem;

		// Token: 0x04005EBC RID: 24252
		[Token(Token = "0x4005EBC")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemBundle> rewardList;
	}
}
