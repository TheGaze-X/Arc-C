using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001023 RID: 4131
	[Token(Token = "0x2001023")]
	public class ArtMagazineLeafData
	{
		// Token: 0x06006D75 RID: 28021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D75")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineLeafData()
		{
		}

		// Token: 0x040057B6 RID: 22454
		[Token(Token = "0x40057B6")]
		[FieldOffset(Offset = "0x10")]
		public string leafId;

		// Token: 0x040057B7 RID: 22455
		[Token(Token = "0x40057B7")]
		[FieldOffset(Offset = "0x18")]
		public List<ArtMagazineLeafElementData> decorList;

		// Token: 0x040057B8 RID: 22456
		[Token(Token = "0x40057B8")]
		[FieldOffset(Offset = "0x20")]
		public ArtMagazineLeafElementData charSkin;
	}
}
