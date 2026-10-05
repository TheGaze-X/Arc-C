using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001185 RID: 4485
	[Token(Token = "0x2001185")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SanEffectRank
	{
		// Token: 0x04006018 RID: 24600
		[Token(Token = "0x4006018")]
		SAN_EFFECT_0,
		// Token: 0x04006019 RID: 24601
		[Token(Token = "0x4006019")]
		SAN_EFFECT_1,
		// Token: 0x0400601A RID: 24602
		[Token(Token = "0x400601A")]
		SAN_EFFECT_2,
		// Token: 0x0400601B RID: 24603
		[Token(Token = "0x400601B")]
		SAN_EFFECT_3
	}
}
