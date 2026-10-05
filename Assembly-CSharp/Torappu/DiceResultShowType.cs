using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001188 RID: 4488
	[Token(Token = "0x2001188")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiceResultShowType
	{
		// Token: 0x0400602A RID: 24618
		[Token(Token = "0x400602A")]
		RAW_TEXT,
		// Token: 0x0400602B RID: 24619
		[Token(Token = "0x400602B")]
		MUTATION,
		// Token: 0x0400602C RID: 24620
		[Token(Token = "0x400602C")]
		VIRTUE
	}
}
