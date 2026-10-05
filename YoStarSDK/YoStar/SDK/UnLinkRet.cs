using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public class UnLinkRet
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UnLinkRet()
		{
		}

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x20")]
		public LinkPlatform LINK_PLATFORM;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x28")]
		public string SOCAIL_NAME;
	}
}
