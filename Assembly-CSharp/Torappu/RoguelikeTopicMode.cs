using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200120A RID: 4618
	[Token(Token = "0x200120A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTopicMode
	{
		// Token: 0x0400635D RID: 25437
		[Token(Token = "0x400635D")]
		NONE,
		// Token: 0x0400635E RID: 25438
		[Token(Token = "0x400635E")]
		EASY,
		// Token: 0x0400635F RID: 25439
		[Token(Token = "0x400635F")]
		NORMAL,
		// Token: 0x04006360 RID: 25440
		[Token(Token = "0x4006360")]
		HARD,
		// Token: 0x04006361 RID: 25441
		[Token(Token = "0x4006361")]
		NORML_END,
		// Token: 0x04006362 RID: 25442
		[Token(Token = "0x4006362")]
		MONTH_TEAM,
		// Token: 0x04006363 RID: 25443
		[Token(Token = "0x4006363")]
		CHALLENGE
	}
}
