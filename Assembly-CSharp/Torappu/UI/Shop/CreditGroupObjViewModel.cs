using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B7B RID: 23419
	[Token(Token = "0x2005B7B")]
	public class CreditGroupObjViewModel
	{
		// Token: 0x06021FE5 RID: 139237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FE5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CreditGroupObjViewModel()
		{
		}

		// Token: 0x0402E991 RID: 190865
		[Token(Token = "0x402E991")]
		[FieldOffset(Offset = "0x10")]
		public float linePercent;

		// Token: 0x0402E992 RID: 190866
		[Token(Token = "0x402E992")]
		[FieldOffset(Offset = "0x14")]
		public int creditProgress;

		// Token: 0x0402E993 RID: 190867
		[Token(Token = "0x402E993")]
		[FieldOffset(Offset = "0x18")]
		public List<CreditCharObjViewModel> charList;
	}
}
