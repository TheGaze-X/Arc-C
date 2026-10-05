using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000869 RID: 2153
	[Token(Token = "0x2000869")]
	public class GetSkinGoodListRequest
	{
		// Token: 0x06006504 RID: 25860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006504")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetSkinGoodListRequest()
		{
		}

		// Token: 0x040031B0 RID: 12720
		[Token(Token = "0x40031B0")]
		[FieldOffset(Offset = "0x10")]
		public List<string> charIdList;
	}
}
