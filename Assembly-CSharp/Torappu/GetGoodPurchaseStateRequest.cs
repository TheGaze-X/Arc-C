using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008A0 RID: 2208
	[Token(Token = "0x20008A0")]
	public class GetGoodPurchaseStateRequest
	{
		// Token: 0x0600653F RID: 25919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetGoodPurchaseStateRequest()
		{
		}

		// Token: 0x04003268 RID: 12904
		[Token(Token = "0x4003268")]
		[FieldOffset(Offset = "0x10")]
		public ShopPurchaseState goodIdMap;
	}
}
