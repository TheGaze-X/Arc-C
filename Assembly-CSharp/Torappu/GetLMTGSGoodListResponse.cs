using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200087E RID: 2174
	[Token(Token = "0x200087E")]
	public class GetLMTGSGoodListResponse : PlayerDeltaResponse, IQCShopGetResponse, IShopGetResposne
	{
		// Token: 0x0600651B RID: 25883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651B")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public List<string> GetNewFlag()
		{
			return null;
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetLMTGSGoodListResponse()
		{
		}

		// Token: 0x040031FA RID: 12794
		[Token(Token = "0x40031FA")]
		[FieldOffset(Offset = "0x28")]
		public List<LMTGSGood> goodList;

		// Token: 0x040031FB RID: 12795
		[Token(Token = "0x40031FB")]
		[FieldOffset(Offset = "0x30")]
		public List<string> newFlag;
	}
}
