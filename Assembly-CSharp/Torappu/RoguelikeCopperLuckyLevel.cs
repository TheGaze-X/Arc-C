using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011B4 RID: 4532
	[Token(Token = "0x20011B4")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeCopperLuckyLevel
	{
		// Token: 0x04006107 RID: 24839
		[Token(Token = "0x4006107")]
		NONE,
		// Token: 0x04006108 RID: 24840
		[Token(Token = "0x4006108")]
		HIGH,
		// Token: 0x04006109 RID: 24841
		[Token(Token = "0x4006109")]
		MID,
		// Token: 0x0400610A RID: 24842
		[Token(Token = "0x400610A")]
		LOW
	}
}
