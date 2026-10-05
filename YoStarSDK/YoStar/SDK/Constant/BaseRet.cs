using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Constant
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	public class BaseRet
	{
		// Token: 0x06000E6F RID: 3695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BaseRet()
		{
		}

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x20")]
		public object R_DATA;
	}
}
