using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006514 RID: 25876
	[Token(Token = "0x2006514")]
	public class ArtMagazineGetThumbnailUrlRequest
	{
		// Token: 0x060252F4 RID: 152308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineGetThumbnailUrlRequest()
		{
		}

		// Token: 0x04034278 RID: 213624
		[Token(Token = "0x4034278")]
		[FieldOffset(Offset = "0x10")]
		public List<string> idList;
	}
}
