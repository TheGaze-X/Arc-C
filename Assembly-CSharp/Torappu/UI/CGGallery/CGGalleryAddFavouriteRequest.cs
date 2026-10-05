using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FDF RID: 24543
	[Token(Token = "0x2005FDF")]
	public class CGGalleryAddFavouriteRequest : IHotfixable
	{
		// Token: 0x0602379D RID: 145309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602379D")]
		[Address(RVA = "0x1E14240", Offset = "0x1E12E40", VA = "0x181E14240")]
		public CGGalleryAddFavouriteRequest()
		{
		}

		// Token: 0x0403113B RID: 201019
		[Token(Token = "0x403113B")]
		[FieldOffset(Offset = "0x10")]
		public string cgId;

		// Token: 0x0403113C RID: 201020
		[Token(Token = "0x403113C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
