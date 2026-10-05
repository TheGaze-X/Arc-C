using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public class SetBirthdayRet
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetBirthdayRet()
		{
		}

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x20")]
		public string BIRTH;
	}
}
