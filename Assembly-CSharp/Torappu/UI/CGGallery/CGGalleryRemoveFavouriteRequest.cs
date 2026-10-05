using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FE1 RID: 24545
	[Token(Token = "0x2005FE1")]
	public class CGGalleryRemoveFavouriteRequest : IHotfixable
	{
		// Token: 0x0602379F RID: 145311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602379F")]
		[Address(RVA = "0x1E19F20", Offset = "0x1E18B20", VA = "0x181E19F20")]
		public CGGalleryRemoveFavouriteRequest()
		{
		}

		// Token: 0x0403113E RID: 201022
		[Token(Token = "0x403113E")]
		[FieldOffset(Offset = "0x10")]
		public string cgId;

		// Token: 0x0403113F RID: 201023
		[Token(Token = "0x403113F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
