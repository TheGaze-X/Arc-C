using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[Preserve]
	public enum JsonToken
	{
		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		None,
		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		StartObject,
		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		StartArray,
		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		StartConstructor,
		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		PropertyName,
		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		Comment,
		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		Raw,
		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		Integer,
		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		Float,
		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		String,
		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		Boolean,
		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		Null,
		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		Undefined,
		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		EndObject,
		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		EndArray,
		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		EndConstructor,
		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		Date,
		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		Bytes
	}
}
