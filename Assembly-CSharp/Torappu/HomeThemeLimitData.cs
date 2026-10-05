using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FF6 RID: 4086
	[Token(Token = "0x2000FF6")]
	public class HomeThemeLimitData
	{
		// Token: 0x06006D51 RID: 27985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D51")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeLimitData()
		{
		}

		// Token: 0x040056B8 RID: 22200
		[Token(Token = "0x40056B8")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040056B9 RID: 22201
		[Token(Token = "0x40056B9")]
		[FieldOffset(Offset = "0x18")]
		public List<HomeThemeLimitInfoData> limitInfos;
	}
}
