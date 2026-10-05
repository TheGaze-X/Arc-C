using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001240 RID: 4672
	[Token(Token = "0x2001240")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeChoiceLeftDecoType
	{
		// Token: 0x04006517 RID: 25879
		[Token(Token = "0x4006517")]
		NONE,
		// Token: 0x04006518 RID: 25880
		[Token(Token = "0x4006518")]
		TASK,
		// Token: 0x04006519 RID: 25881
		[Token(Token = "0x4006519")]
		TASK_REWARD,
		// Token: 0x0400651A RID: 25882
		[Token(Token = "0x400651A")]
		DICE,
		// Token: 0x0400651B RID: 25883
		[Token(Token = "0x400651B")]
		VISION
	}
}
