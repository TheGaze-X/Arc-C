using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000787 RID: 1927
	[Token(Token = "0x2000787")]
	public class ItemVoucherViewModel
	{
		// Token: 0x06006403 RID: 25603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006403")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemVoucherViewModel()
		{
		}

		// Token: 0x04003042 RID: 12354
		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x10")]
		public List<ItemVoucherPool> itemList;

		// Token: 0x04003043 RID: 12355
		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;
	}
}
