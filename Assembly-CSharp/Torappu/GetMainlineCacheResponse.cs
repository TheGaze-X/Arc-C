using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008E4 RID: 2276
	[Token(Token = "0x20008E4")]
	public class GetMainlineCacheResponse : PlayerDeltaResponse
	{
		// Token: 0x06006599 RID: 26009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006599")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetMainlineCacheResponse()
		{
		}

		// Token: 0x040032F6 RID: 13046
		[Token(Token = "0x40032F6")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> items;
	}
}
