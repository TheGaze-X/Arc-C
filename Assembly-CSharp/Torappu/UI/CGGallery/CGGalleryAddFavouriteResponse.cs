using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FE0 RID: 24544
	[Token(Token = "0x2005FE0")]
	public class CGGalleryAddFavouriteResponse : PlayerDeltaResponse
	{
		// Token: 0x0602379E RID: 145310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602379E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CGGalleryAddFavouriteResponse()
		{
		}

		// Token: 0x0403113D RID: 201021
		[Token(Token = "0x403113D")]
		[FieldOffset(Offset = "0x28")]
		public List<string> cgList;
	}
}
