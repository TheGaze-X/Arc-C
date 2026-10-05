using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001241 RID: 4673
	[Token(Token = "0x2001241")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameVariationType
	{
		// Token: 0x0400651D RID: 25885
		[Token(Token = "0x400651D")]
		NONE,
		// Token: 0x0400651E RID: 25886
		[Token(Token = "0x400651E")]
		MAP,
		// Token: 0x0400651F RID: 25887
		[Token(Token = "0x400651F")]
		RES,
		// Token: 0x04006520 RID: 25888
		[Token(Token = "0x4006520")]
		BAT
	}
}
