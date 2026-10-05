using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001187 RID: 4487
	[Token(Token = "0x2001187")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiceResultClass
	{
		// Token: 0x04006023 RID: 24611
		[Token(Token = "0x4006023")]
		VERYBAD,
		// Token: 0x04006024 RID: 24612
		[Token(Token = "0x4006024")]
		BAD,
		// Token: 0x04006025 RID: 24613
		[Token(Token = "0x4006025")]
		NORMAL,
		// Token: 0x04006026 RID: 24614
		[Token(Token = "0x4006026")]
		GOOD,
		// Token: 0x04006027 RID: 24615
		[Token(Token = "0x4006027")]
		GREAT,
		// Token: 0x04006028 RID: 24616
		[Token(Token = "0x4006028")]
		BEST = 4
	}
}
