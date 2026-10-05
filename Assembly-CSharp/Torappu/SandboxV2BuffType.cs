using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001283 RID: 4739
	[Token(Token = "0x2001283")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2BuffType
	{
		// Token: 0x0400688C RID: 26764
		[Token(Token = "0x400688C")]
		NORMAL,
		// Token: 0x0400688D RID: 26765
		[Token(Token = "0x400688D")]
		CHARACTER_RUNE,
		// Token: 0x0400688E RID: 26766
		[Token(Token = "0x400688E")]
		LEVEL_RUNE,
		// Token: 0x0400688F RID: 26767
		[Token(Token = "0x400688F")]
		COMPOUND
	}
}
