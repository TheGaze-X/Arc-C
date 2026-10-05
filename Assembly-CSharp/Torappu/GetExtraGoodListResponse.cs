using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000878 RID: 2168
	[Token(Token = "0x2000878")]
	public class GetExtraGoodListResponse : PlayerDeltaResponse, IQCShopGetResponse, IShopGetResposne
	{
		// Token: 0x06006513 RID: 25875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006513")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "5")]
		public List<string> GetNewFlag()
		{
			return null;
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006514")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetExtraGoodListResponse()
		{
		}

		// Token: 0x040031E8 RID: 12776
		[Token(Token = "0x40031E8")]
		[FieldOffset(Offset = "0x28")]
		public List<ExtraQCObject> goodList;

		// Token: 0x040031E9 RID: 12777
		[Token(Token = "0x40031E9")]
		[FieldOffset(Offset = "0x30")]
		public long lastClick;

		// Token: 0x040031EA RID: 12778
		[Token(Token = "0x40031EA")]
		[FieldOffset(Offset = "0x38")]
		public List<string> newFlag;
	}
}
