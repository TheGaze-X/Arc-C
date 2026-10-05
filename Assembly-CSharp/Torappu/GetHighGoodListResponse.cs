using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000874 RID: 2164
	[Token(Token = "0x2000874")]
	public class GetHighGoodListResponse : PlayerDeltaResponse, IQCShopGetResponse, IShopGetResposne
	{
		// Token: 0x0600650D RID: 25869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650D")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "5")]
		public List<string> GetNewFlag()
		{
			return null;
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetHighGoodListResponse()
		{
		}

		// Token: 0x040031E2 RID: 12770
		[Token(Token = "0x40031E2")]
		[FieldOffset(Offset = "0x28")]
		public List<QCObject> goodList;

		// Token: 0x040031E3 RID: 12771
		[Token(Token = "0x40031E3")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, List<QCProgressGoodItem>> progressGoodList;

		// Token: 0x040031E4 RID: 12772
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x38")]
		public List<string> newFlag;
	}
}
