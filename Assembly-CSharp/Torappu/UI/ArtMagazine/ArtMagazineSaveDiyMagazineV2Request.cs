using System;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200650F RID: 25871
	[Token(Token = "0x200650F")]
	public class ArtMagazineSaveDiyMagazineV2Request
	{
		// Token: 0x060252EF RID: 152303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252EF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineSaveDiyMagazineV2Request()
		{
		}

		// Token: 0x04034272 RID: 213618
		[Token(Token = "0x4034272")]
		[FieldOffset(Offset = "0x10")]
		public ArtMagazineLeafData magazine;

		// Token: 0x04034273 RID: 213619
		[Token(Token = "0x4034273")]
		public const string THUMBNAIL_PARAM = "thumbnail";

		// Token: 0x04034274 RID: 213620
		[Token(Token = "0x4034274")]
		public const string THUMBNAIL_JPEG_PARAM = "thumbnail.jpg";
	}
}
