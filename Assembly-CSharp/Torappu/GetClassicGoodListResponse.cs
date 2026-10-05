using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000876 RID: 2166
	[Token(Token = "0x2000876")]
	public class GetClassicGoodListResponse : PlayerDeltaResponse, IQCShopGetResponse, IShopGetResposne
	{
		// Token: 0x06006510 RID: 25872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006510")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "5")]
		public List<string> GetNewFlag()
		{
			return null;
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006511")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetClassicGoodListResponse()
		{
		}

		// Token: 0x040031E5 RID: 12773
		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x28")]
		public List<QCObject> goodList;

		// Token: 0x040031E6 RID: 12774
		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, List<QCProgressGoodItem>> progressGoodList;

		// Token: 0x040031E7 RID: 12775
		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x38")]
		public List<string> newFlag;
	}
}
