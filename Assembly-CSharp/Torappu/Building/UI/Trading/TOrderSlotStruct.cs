using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C2D RID: 7213
	[Token(Token = "0x2001C2D")]
	public struct TOrderSlotStruct
	{
		// Token: 0x0400AF04 RID: 44804
		[Token(Token = "0x400AF04")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TOrderSlotStruct EMPTY;

		// Token: 0x0400AF05 RID: 44805
		[Token(Token = "0x400AF05")]
		[FieldOffset(Offset = "0x0")]
		public OrderStatus status;

		// Token: 0x0400AF06 RID: 44806
		[Token(Token = "0x400AF06")]
		[FieldOffset(Offset = "0x8")]
		public long orderId;

		// Token: 0x0400AF07 RID: 44807
		[Token(Token = "0x400AF07")]
		[FieldOffset(Offset = "0x10")]
		public int slotIndex;
	}
}
