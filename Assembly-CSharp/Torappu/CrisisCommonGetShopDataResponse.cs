using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006DD RID: 1757
	[Token(Token = "0x20006DD")]
	public class CrisisCommonGetShopDataResponse : PlayerDeltaResponse
	{
		// Token: 0x0600632C RID: 25388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632C")]
		[Address(RVA = "0x1EE82C0", Offset = "0x1EE6EC0", VA = "0x181EE82C0")]
		public CrisisCommonGetShopDataResponse()
		{
		}

		// Token: 0x04002EEB RID: 12011
		[Token(Token = "0x4002EEB")]
		[FieldOffset(Offset = "0x28")]
		public List<CrisisLongTermShopItemData> permanent;

		// Token: 0x04002EEC RID: 12012
		[Token(Token = "0x4002EEC")]
		[FieldOffset(Offset = "0x30")]
		public List<CrisisSeasonShopItemData> season;

		// Token: 0x04002EED RID: 12013
		[Token(Token = "0x4002EED")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, List<CrisisProgressShopItemViewModel>> progressGoodList;
	}
}
