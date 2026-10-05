using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	public struct SteamItemDetails_t
	{
		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x0")]
		public SteamItemInstanceID_t m_itemId;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x8")]
		public SteamItemDef_t m_iDefinition;

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0xC")]
		public ushort m_unQuantity;

		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0xE")]
		public ushort m_unFlags;
	}
}
