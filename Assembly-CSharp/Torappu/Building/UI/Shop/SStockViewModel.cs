using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CEA RID: 7402
	[Token(Token = "0x2001CEA")]
	public class SStockViewModel
	{
		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x0600B6ED RID: 46829 RVA: 0x00045108 File Offset: 0x00043308
		// (set) Token: 0x0600B6EE RID: 46830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015F2")]
		public bool isEditing
		{
			[Token(Token = "0x600B6ED")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B6EE")]
			[Address(RVA = "0x3350AA0", Offset = "0x334F6A0", VA = "0x183350AA0")]
			set
			{
			}
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6EF")]
		[Address(RVA = "0x33509B0", Offset = "0x334F5B0", VA = "0x1833509B0")]
		public SStockViewModel()
		{
		}

		// Token: 0x0400B4BB RID: 46267
		[Token(Token = "0x400B4BB")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isEditing;

		// Token: 0x0400B4BC RID: 46268
		[Token(Token = "0x400B4BC")]
		[FieldOffset(Offset = "0x18")]
		public ShopStockInfoViewModel info;

		// Token: 0x0400B4BD RID: 46269
		[Token(Token = "0x400B4BD")]
		[FieldOffset(Offset = "0x20")]
		public SRoomEditStruct initEditInfo;

		// Token: 0x0400B4BE RID: 46270
		[Token(Token = "0x400B4BE")]
		[FieldOffset(Offset = "0x38")]
		public SRoomEditStruct editInfo;
	}
}
