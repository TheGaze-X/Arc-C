using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001255 RID: 4693
	[Token(Token = "0x2001255")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RL03DevelopmentEffectType
	{
		// Token: 0x04006783 RID: 26499
		[Token(Token = "0x4006783")]
		BUFF,
		// Token: 0x04006784 RID: 26500
		[Token(Token = "0x4006784")]
		RAW_TEXT_EFFECT,
		// Token: 0x04006785 RID: 26501
		[Token(Token = "0x4006785")]
		RAW_TEXT_BAND
	}
}
