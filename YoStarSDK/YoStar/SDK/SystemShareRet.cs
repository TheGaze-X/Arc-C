using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public class SystemShareRet
	{
		// Token: 0x06000242 RID: 578 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SystemShareRet()
		{
		}

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;
	}
}
