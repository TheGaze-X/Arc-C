using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200118E RID: 4494
	[Token(Token = "0x200118E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChaosEffectRank
	{
		// Token: 0x04006049 RID: 24649
		[Token(Token = "0x4006049")]
		CHAOS_EFFECT_0,
		// Token: 0x0400604A RID: 24650
		[Token(Token = "0x400604A")]
		CHAOS_EFFECT_1,
		// Token: 0x0400604B RID: 24651
		[Token(Token = "0x400604B")]
		CHAOS_EFFECT_2
	}
}
