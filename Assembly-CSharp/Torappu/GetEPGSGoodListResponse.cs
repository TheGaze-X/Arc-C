using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000881 RID: 2177
	[Token(Token = "0x2000881")]
	public class GetEPGSGoodListResponse : PlayerDeltaResponse, IQCShopGetResponse, IShopGetResposne
	{
		// Token: 0x0600651F RID: 25887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651F")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public List<string> GetNewFlag()
		{
			return null;
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006520")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetEPGSGoodListResponse()
		{
		}

		// Token: 0x04003203 RID: 12803
		[Token(Token = "0x4003203")]
		[FieldOffset(Offset = "0x28")]
		public List<EPGSGood> goodList;

		// Token: 0x04003204 RID: 12804
		[Token(Token = "0x4003204")]
		[FieldOffset(Offset = "0x30")]
		public List<string> newFlag;
	}
}
