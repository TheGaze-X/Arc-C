using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class QueryTextLegalityRet
	{
		// Token: 0x06000255 RID: 597 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QueryTextLegalityRet()
		{
		}

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x20")]
		public string SOURCE_TEXT;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x28")]
		public string CENSORED_TEXT;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x30")]
		public bool LEGALITY;
	}
}
