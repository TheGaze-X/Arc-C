using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FE4 RID: 24548
	[Token(Token = "0x2005FE4")]
	public class CGGalleryGetFavouriteResponse : PlayerDeltaResponse
	{
		// Token: 0x060237A2 RID: 145314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237A2")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CGGalleryGetFavouriteResponse()
		{
		}

		// Token: 0x04031142 RID: 201026
		[Token(Token = "0x4031142")]
		[FieldOffset(Offset = "0x28")]
		public List<string> cgList;
	}
}
