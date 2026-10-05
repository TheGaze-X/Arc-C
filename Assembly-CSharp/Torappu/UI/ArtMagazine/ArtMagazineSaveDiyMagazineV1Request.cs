using System;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006510 RID: 25872
	[Token(Token = "0x2006510")]
	public class ArtMagazineSaveDiyMagazineV1Request
	{
		// Token: 0x060252F0 RID: 152304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252F0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineSaveDiyMagazineV1Request()
		{
		}

		// Token: 0x04034275 RID: 213621
		[Token(Token = "0x4034275")]
		[FieldOffset(Offset = "0x10")]
		public ArtMagazineLeafData magazine;

		// Token: 0x04034276 RID: 213622
		[Token(Token = "0x4034276")]
		[FieldOffset(Offset = "0x18")]
		public string thumbnail;
	}
}
