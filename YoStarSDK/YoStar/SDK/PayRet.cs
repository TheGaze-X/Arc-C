using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public class PayRet
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PayRet()
		{
		}

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x20")]
		public string EXTRA_DATA;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x28")]
		public string ORDER_ID;
	}
}
