using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006515 RID: 25877
	[Token(Token = "0x2006515")]
	public class ArtMagazineGetThumbnailUrlResponse : PlayerDeltaResponse
	{
		// Token: 0x060252F5 RID: 152309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252F5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ArtMagazineGetThumbnailUrlResponse()
		{
		}

		// Token: 0x04034279 RID: 213625
		[Token(Token = "0x4034279")]
		[FieldOffset(Offset = "0x28")]
		public List<string> url;
	}
}
