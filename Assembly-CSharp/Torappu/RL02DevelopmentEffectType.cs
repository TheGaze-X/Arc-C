using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011F2 RID: 4594
	[Token(Token = "0x20011F2")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RL02DevelopmentEffectType
	{
		// Token: 0x040062C0 RID: 25280
		[Token(Token = "0x40062C0")]
		BUFF,
		// Token: 0x040062C1 RID: 25281
		[Token(Token = "0x40062C1")]
		RAW_TEXT_EFFECT,
		// Token: 0x040062C2 RID: 25282
		[Token(Token = "0x40062C2")]
		RAW_TEXT_BAND,
		// Token: 0x040062C3 RID: 25283
		[Token(Token = "0x40062C3")]
		NONE = 10
	}
}
