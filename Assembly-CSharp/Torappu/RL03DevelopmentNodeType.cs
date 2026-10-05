using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001254 RID: 4692
	[Token(Token = "0x2001254")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RL03DevelopmentNodeType
	{
		// Token: 0x0400677E RID: 26494
		[Token(Token = "0x400677E")]
		NONE,
		// Token: 0x0400677F RID: 26495
		[Token(Token = "0x400677F")]
		NORMAL,
		// Token: 0x04006780 RID: 26496
		[Token(Token = "0x4006780")]
		KEY,
		// Token: 0x04006781 RID: 26497
		[Token(Token = "0x4006781")]
		DIFFICULTY
	}
}
