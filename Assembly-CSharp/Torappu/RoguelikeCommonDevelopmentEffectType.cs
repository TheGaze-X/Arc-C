using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200125B RID: 4699
	[Token(Token = "0x200125B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeCommonDevelopmentEffectType
	{
		// Token: 0x040067A3 RID: 26531
		[Token(Token = "0x40067A3")]
		BUFF,
		// Token: 0x040067A4 RID: 26532
		[Token(Token = "0x40067A4")]
		RAW_TEXT_EFFECT,
		// Token: 0x040067A5 RID: 26533
		[Token(Token = "0x40067A5")]
		RAW_TEXT_BAND
	}
}
