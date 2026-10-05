using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FE2 RID: 24546
	[Token(Token = "0x2005FE2")]
	public class CGGalleryRemoveFavouriteResponse : PlayerDeltaResponse
	{
		// Token: 0x060237A0 RID: 145312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60237A0")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CGGalleryRemoveFavouriteResponse()
		{
		}

		// Token: 0x04031140 RID: 201024
		[Token(Token = "0x4031140")]
		[FieldOffset(Offset = "0x28")]
		public List<string> cgList;
	}
}
