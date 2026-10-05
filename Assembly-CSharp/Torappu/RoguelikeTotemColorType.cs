using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001195 RID: 4501
	[Token(Token = "0x2001195")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTotemColorType
	{
		// Token: 0x04006068 RID: 24680
		[Token(Token = "0x4006068")]
		NONE,
		// Token: 0x04006069 RID: 24681
		[Token(Token = "0x4006069")]
		RED,
		// Token: 0x0400606A RID: 24682
		[Token(Token = "0x400606A")]
		GREEN,
		// Token: 0x0400606B RID: 24683
		[Token(Token = "0x400606B")]
		BLUE,
		// Token: 0x0400606C RID: 24684
		[Token(Token = "0x400606C")]
		ALL
	}
}
