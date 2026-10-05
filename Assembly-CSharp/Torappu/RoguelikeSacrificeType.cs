using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011C8 RID: 4552
	[Token(Token = "0x20011C8")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeSacrificeType
	{
		// Token: 0x04006183 RID: 24963
		[Token(Token = "0x4006183")]
		RELIC,
		// Token: 0x04006184 RID: 24964
		[Token(Token = "0x4006184")]
		TOTEM,
		// Token: 0x04006185 RID: 24965
		[Token(Token = "0x4006185")]
		COPPER
	}
}
