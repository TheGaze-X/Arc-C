using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200125A RID: 4698
	[Token(Token = "0x200125A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeCommonDevelopmentNodeType
	{
		// Token: 0x0400679E RID: 26526
		[Token(Token = "0x400679E")]
		NONE,
		// Token: 0x0400679F RID: 26527
		[Token(Token = "0x400679F")]
		NORMAL,
		// Token: 0x040067A0 RID: 26528
		[Token(Token = "0x40067A0")]
		KEY,
		// Token: 0x040067A1 RID: 26529
		[Token(Token = "0x40067A1")]
		DIFFICULTY
	}
}
