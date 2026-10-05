using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006DC RID: 1756
	[Token(Token = "0x20006DC")]
	public class CrisisProgressShopItemViewModel
	{
		// Token: 0x0600632B RID: 25387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisProgressShopItemViewModel()
		{
		}

		// Token: 0x04002EE7 RID: 12007
		[Token(Token = "0x4002EE7")]
		[FieldOffset(Offset = "0x10")]
		public ItemBundle item;

		// Token: 0x04002EE8 RID: 12008
		[Token(Token = "0x4002EE8")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x04002EE9 RID: 12009
		[Token(Token = "0x4002EE9")]
		[FieldOffset(Offset = "0x20")]
		public int order;

		// Token: 0x04002EEA RID: 12010
		[Token(Token = "0x4002EEA")]
		[FieldOffset(Offset = "0x24")]
		public int price;
	}
}
