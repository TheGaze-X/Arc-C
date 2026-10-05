using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B07 RID: 23303
	[Token(Token = "0x2005B07")]
	public class QCShopObjViewModel
	{
		// Token: 0x06021DBC RID: 138684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DBC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCShopObjViewModel()
		{
		}

		// Token: 0x0402E60F RID: 189967
		[Token(Token = "0x402E60F")]
		[FieldOffset(Offset = "0x10")]
		public QCObject objData;

		// Token: 0x0402E610 RID: 189968
		[Token(Token = "0x402E610")]
		[FieldOffset(Offset = "0x18")]
		public PlayerGoodItemData playerShop;
	}
}
