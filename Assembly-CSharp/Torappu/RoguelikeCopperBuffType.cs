using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011B5 RID: 4533
	[Token(Token = "0x20011B5")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeCopperBuffType
	{
		// Token: 0x0400610C RID: 24844
		[Token(Token = "0x400610C")]
		NONE,
		// Token: 0x0400610D RID: 24845
		[Token(Token = "0x400610D")]
		REFRESH,
		// Token: 0x0400610E RID: 24846
		[Token(Token = "0x400610E")]
		MOVE
	}
}
