using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B09 RID: 23305
	[Token(Token = "0x2005B09")]
	public class QCCommonObj
	{
		// Token: 0x06021DBF RID: 138687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DBF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCCommonObj()
		{
		}

		// Token: 0x0402E614 RID: 189972
		[Token(Token = "0x402E614")]
		[FieldOffset(Offset = "0x10")]
		public int priority;

		// Token: 0x0402E615 RID: 189973
		[Token(Token = "0x402E615")]
		[FieldOffset(Offset = "0x14")]
		public int number;

		// Token: 0x0402E616 RID: 189974
		[Token(Token = "0x402E616")]
		[FieldOffset(Offset = "0x18")]
		public ShopQCGoodType goodType;

		// Token: 0x0402E617 RID: 189975
		[Token(Token = "0x402E617")]
		[FieldOffset(Offset = "0x20")]
		public QCShopObjViewModel commonObj;

		// Token: 0x0402E618 RID: 189976
		[Token(Token = "0x402E618")]
		[FieldOffset(Offset = "0x28")]
		public QCShopObjProgressViewModel progressObj;
	}
}
