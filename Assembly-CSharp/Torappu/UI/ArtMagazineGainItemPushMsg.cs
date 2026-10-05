using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200348E RID: 13454
	[Token(Token = "0x200348E")]
	public class ArtMagazineGainItemPushMsg
	{
		// Token: 0x06015749 RID: 87881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015749")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineGainItemPushMsg()
		{
		}

		// Token: 0x04019AF5 RID: 105205
		[Token(Token = "0x4019AF5")]
		[FieldOffset(Offset = "0x10")]
		public List<string> leafList;

		// Token: 0x04019AF6 RID: 105206
		[Token(Token = "0x4019AF6")]
		[FieldOffset(Offset = "0x18")]
		public List<string> stickerList;
	}
}
