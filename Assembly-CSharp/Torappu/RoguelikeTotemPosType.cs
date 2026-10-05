using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001196 RID: 4502
	[Token(Token = "0x2001196")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTotemPosType
	{
		// Token: 0x0400606E RID: 24686
		[Token(Token = "0x400606E")]
		LOCATION,
		// Token: 0x0400606F RID: 24687
		[Token(Token = "0x400606F")]
		EFFECT
	}
}
