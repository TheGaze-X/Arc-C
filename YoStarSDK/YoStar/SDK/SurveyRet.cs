using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public class SurveyRet
	{
		// Token: 0x06000247 RID: 583 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SurveyRet()
		{
		}

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;
	}
}
