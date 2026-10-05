using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D32 RID: 27954
	[Token(Token = "0x2006D32")]
	public class ActivityGetShopListResponse
	{
		// Token: 0x06027D9D RID: 163229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D9D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityGetShopListResponse()
		{
		}

		// Token: 0x040387CD RID: 231373
		[Token(Token = "0x40387CD")]
		[FieldOffset(Offset = "0x10")]
		public List<ActivityShopData> shopList;
	}
}
