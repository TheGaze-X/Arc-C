using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011B6 RID: 4534
	[Token(Token = "0x20011B6")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeCopperDivineType
	{
		// Token: 0x04006110 RID: 24848
		[Token(Token = "0x4006110")]
		NONE,
		// Token: 0x04006111 RID: 24849
		[Token(Token = "0x4006111")]
		DIVINE,
		// Token: 0x04006112 RID: 24850
		[Token(Token = "0x4006112")]
		EVENT
	}
}
