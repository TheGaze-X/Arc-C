using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FF7 RID: 4087
	[Token(Token = "0x2000FF7")]
	public class HomeThemeLimitInfoData
	{
		// Token: 0x06006D52 RID: 27986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D52")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeLimitInfoData()
		{
		}

		// Token: 0x040056BA RID: 22202
		[Token(Token = "0x40056BA")]
		[FieldOffset(Offset = "0x10")]
		public long startTime;

		// Token: 0x040056BB RID: 22203
		[Token(Token = "0x40056BB")]
		[FieldOffset(Offset = "0x18")]
		public long endTime;

		// Token: 0x040056BC RID: 22204
		[Token(Token = "0x40056BC")]
		[FieldOffset(Offset = "0x20")]
		public string invalidObtainDesc;
	}
}
