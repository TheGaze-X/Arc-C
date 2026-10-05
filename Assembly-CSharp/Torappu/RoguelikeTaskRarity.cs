using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001243 RID: 4675
	[Token(Token = "0x2001243")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTaskRarity
	{
		// Token: 0x04006527 RID: 25895
		[Token(Token = "0x4006527")]
		NORMAL,
		// Token: 0x04006528 RID: 25896
		[Token(Token = "0x4006528")]
		RARE,
		// Token: 0x04006529 RID: 25897
		[Token(Token = "0x4006529")]
		SUPER_RARE
	}
}
