using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FC4 RID: 8132
	[Token(Token = "0x2001FC4")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AudioFadeType
	{
		// Token: 0x0400D27A RID: 53882
		[Token(Token = "0x400D27A")]
		LINEAR,
		// Token: 0x0400D27B RID: 53883
		[Token(Token = "0x400D27B")]
		CONCAVE
	}
}
