using System;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002FD RID: 765
	[Token(Token = "0x20002FD")]
	internal enum ParserToken
	{
		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		None = 65536,
		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000E60")]
		Number,
		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		True,
		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		False,
		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		Null,
		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		CharSeq,
		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		Char,
		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		Text,
		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		Object,
		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		ObjectPrime,
		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		Pair,
		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		PairRest,
		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		Array,
		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		ArrayPrime,
		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		Value,
		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		ValueRest,
		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		String,
		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		End,
		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000E71")]
		Epsilon
	}
}
