using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CE9 RID: 7401
	[Token(Token = "0x2001CE9")]
	public struct SRoomEditStruct
	{
		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x0600B6EB RID: 46827 RVA: 0x000450F0 File Offset: 0x000432F0
		[Token(Token = "0x170015F1")]
		public bool isEmpty
		{
			[Token(Token = "0x600B6EB")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400B4B7 RID: 46263
		[Token(Token = "0x400B4B7")]
		[FieldOffset(Offset = "0x0")]
		public static SRoomEditStruct EMPTY;

		// Token: 0x0400B4B8 RID: 46264
		[Token(Token = "0x400B4B8")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isEmpty;

		// Token: 0x0400B4B9 RID: 46265
		[Token(Token = "0x400B4B9")]
		[FieldOffset(Offset = "0x8")]
		public BuildingData.ShopFormula formula;

		// Token: 0x0400B4BA RID: 46266
		[Token(Token = "0x400B4BA")]
		[FieldOffset(Offset = "0x10")]
		public int itemCount;
	}
}
