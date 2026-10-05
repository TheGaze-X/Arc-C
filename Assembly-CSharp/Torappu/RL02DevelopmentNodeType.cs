using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011F1 RID: 4593
	[Token(Token = "0x20011F1")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RL02DevelopmentNodeType
	{
		// Token: 0x040062B9 RID: 25273
		[Token(Token = "0x40062B9")]
		NONE,
		// Token: 0x040062BA RID: 25274
		[Token(Token = "0x40062BA")]
		SMALL,
		// Token: 0x040062BB RID: 25275
		[Token(Token = "0x40062BB")]
		NORMAL,
		// Token: 0x040062BC RID: 25276
		[Token(Token = "0x40062BC")]
		LARGE_RHODES,
		// Token: 0x040062BD RID: 25277
		[Token(Token = "0x40062BD")]
		LARGE_ABYSSAL,
		// Token: 0x040062BE RID: 25278
		[Token(Token = "0x40062BE")]
		LARGE_IBERIA
	}
}
