using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C6F RID: 19567
	[Token(Token = "0x2004C6F")]
	public class HomeThemeData
	{
		// Token: 0x0601D59A RID: 120218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D59A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeData()
		{
		}

		// Token: 0x040269CB RID: 158155
		[Token(Token = "0x40269CB")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x040269CC RID: 158156
		[Token(Token = "0x40269CC")]
		[FieldOffset(Offset = "0x18")]
		public List<HomeThemeElemData> elements;
	}
}
