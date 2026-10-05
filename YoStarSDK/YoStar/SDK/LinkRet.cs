using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class LinkRet
	{
		// Token: 0x0600023F RID: 575 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LinkRet()
		{
		}

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x20")]
		public LinkPlatform LINK_PLATFORM;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x28")]
		public string SOCAIL_NAME;
	}
}
