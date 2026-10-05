using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D93 RID: 7571
	[Token(Token = "0x2001D93")]
	public struct MItemInputSlotStruct
	{
		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x0600BAB4 RID: 47796 RVA: 0x00045D98 File Offset: 0x00043F98
		[Token(Token = "0x170016A3")]
		public bool isEmpty
		{
			[Token(Token = "0x600BAB4")]
			[Address(RVA = "0x334C4A0", Offset = "0x334B0A0", VA = "0x18334C4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400BA00 RID: 47616
		[Token(Token = "0x400BA00")]
		[FieldOffset(Offset = "0x0")]
		public static MItemInputSlotStruct EMPTY;

		// Token: 0x0400BA01 RID: 47617
		[Token(Token = "0x400BA01")]
		[FieldOffset(Offset = "0x0")]
		public string itemId;

		// Token: 0x0400BA02 RID: 47618
		[Token(Token = "0x400BA02")]
		[FieldOffset(Offset = "0x8")]
		public ItemType itemType;

		// Token: 0x0400BA03 RID: 47619
		[Token(Token = "0x400BA03")]
		[FieldOffset(Offset = "0xC")]
		public int itemCount;

		// Token: 0x0400BA04 RID: 47620
		[Token(Token = "0x400BA04")]
		[FieldOffset(Offset = "0x10")]
		public int itemCost;

		// Token: 0x0400BA05 RID: 47621
		[Token(Token = "0x400BA05")]
		[FieldOffset(Offset = "0x14")]
		public int itemReserve;
	}
}
