using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011FF RID: 4607
	[Token(Token = "0x20011FF")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTopicDifficultyWarningType
	{
		// Token: 0x04006327 RID: 25383
		[Token(Token = "0x4006327")]
		NONE,
		// Token: 0x04006328 RID: 25384
		[Token(Token = "0x4006328")]
		NORMAL,
		// Token: 0x04006329 RID: 25385
		[Token(Token = "0x4006329")]
		HARD
	}
}
