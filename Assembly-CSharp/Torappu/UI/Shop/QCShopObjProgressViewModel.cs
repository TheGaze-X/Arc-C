using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B08 RID: 23304
	[Token(Token = "0x2005B08")]
	public class QCShopObjProgressViewModel
	{
		// Token: 0x17004F3A RID: 20282
		// (get) Token: 0x06021DBD RID: 138685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F3A")]
		public QCProgressGoodItem currentObj
		{
			[Token(Token = "0x6021DBD")]
			[Address(RVA = "0x1C5E610", Offset = "0x1C5D210", VA = "0x181C5E610")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021DBE RID: 138686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DBE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCShopObjProgressViewModel()
		{
		}

		// Token: 0x0402E611 RID: 189969
		[Token(Token = "0x402E611")]
		[FieldOffset(Offset = "0x10")]
		public QCObject objData;

		// Token: 0x0402E612 RID: 189970
		[Token(Token = "0x402E612")]
		[FieldOffset(Offset = "0x18")]
		public List<QCProgressGoodItem> progressData;

		// Token: 0x0402E613 RID: 189971
		[Token(Token = "0x402E613")]
		[FieldOffset(Offset = "0x20")]
		public PlayerGoodProgressData playerShop;
	}
}
