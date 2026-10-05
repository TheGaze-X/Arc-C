using System;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	internal enum ParserToken
	{
		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		None = 65536,
		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		Number,
		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		True,
		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		False,
		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		Null,
		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		CharSeq,
		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		Char,
		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		Text,
		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		Object,
		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		ObjectPrime,
		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		Pair,
		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		PairRest,
		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		Array,
		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		ArrayPrime,
		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		Value,
		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		ValueRest,
		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		String,
		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		End,
		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		Epsilon
	}
}
