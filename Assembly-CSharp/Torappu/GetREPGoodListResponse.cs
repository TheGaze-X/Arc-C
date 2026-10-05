using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000884 RID: 2180
	[Token(Token = "0x2000884")]
	public class GetREPGoodListResponse : PlayerDeltaResponse, IQCShopGetResponse, IShopGetResposne
	{
		// Token: 0x06006523 RID: 25891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006523")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public List<string> GetNewFlag()
		{
			return null;
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006524")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetREPGoodListResponse()
		{
		}

		// Token: 0x0400320C RID: 12812
		[Token(Token = "0x400320C")]
		[FieldOffset(Offset = "0x28")]
		public List<REPGood> goodList;

		// Token: 0x0400320D RID: 12813
		[Token(Token = "0x400320D")]
		[FieldOffset(Offset = "0x30")]
		public List<string> newFlag;
	}
}
