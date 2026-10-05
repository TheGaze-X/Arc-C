using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	internal enum ParserToken
	{
		// Token: 0x04001521 RID: 5409
		[Token(Token = "0x4001521")]
		None = 65536,
		// Token: 0x04001522 RID: 5410
		[Token(Token = "0x4001522")]
		Number,
		// Token: 0x04001523 RID: 5411
		[Token(Token = "0x4001523")]
		True,
		// Token: 0x04001524 RID: 5412
		[Token(Token = "0x4001524")]
		False,
		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x4001525")]
		Null,
		// Token: 0x04001526 RID: 5414
		[Token(Token = "0x4001526")]
		CharSeq,
		// Token: 0x04001527 RID: 5415
		[Token(Token = "0x4001527")]
		Char,
		// Token: 0x04001528 RID: 5416
		[Token(Token = "0x4001528")]
		Text,
		// Token: 0x04001529 RID: 5417
		[Token(Token = "0x4001529")]
		Object,
		// Token: 0x0400152A RID: 5418
		[Token(Token = "0x400152A")]
		ObjectPrime,
		// Token: 0x0400152B RID: 5419
		[Token(Token = "0x400152B")]
		Pair,
		// Token: 0x0400152C RID: 5420
		[Token(Token = "0x400152C")]
		PairRest,
		// Token: 0x0400152D RID: 5421
		[Token(Token = "0x400152D")]
		Array,
		// Token: 0x0400152E RID: 5422
		[Token(Token = "0x400152E")]
		ArrayPrime,
		// Token: 0x0400152F RID: 5423
		[Token(Token = "0x400152F")]
		Value,
		// Token: 0x04001530 RID: 5424
		[Token(Token = "0x4001530")]
		ValueRest,
		// Token: 0x04001531 RID: 5425
		[Token(Token = "0x4001531")]
		String,
		// Token: 0x04001532 RID: 5426
		[Token(Token = "0x4001532")]
		End,
		// Token: 0x04001533 RID: 5427
		[Token(Token = "0x4001533")]
		Epsilon
	}
}
