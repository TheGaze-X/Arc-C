using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CE4 RID: 7396
	[Token(Token = "0x2001CE4")]
	public struct FormulaCostStruct
	{
		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x00045048 File Offset: 0x00043248
		[Token(Token = "0x170015ED")]
		public bool isEmpty
		{
			[Token(Token = "0x600B6D1")]
			[Address(RVA = "0x334C4A0", Offset = "0x334B0A0", VA = "0x18334C4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400B493 RID: 46227
		[Token(Token = "0x400B493")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FormulaCostStruct EMPTY;

		// Token: 0x0400B494 RID: 46228
		[Token(Token = "0x400B494")]
		[FieldOffset(Offset = "0x0")]
		public string itemId;

		// Token: 0x0400B495 RID: 46229
		[Token(Token = "0x400B495")]
		[FieldOffset(Offset = "0x8")]
		public ItemType itemType;

		// Token: 0x0400B496 RID: 46230
		[Token(Token = "0x400B496")]
		[FieldOffset(Offset = "0xC")]
		public int costCount;

		// Token: 0x0400B497 RID: 46231
		[Token(Token = "0x400B497")]
		[FieldOffset(Offset = "0x10")]
		public int reserveCount;
	}
}
