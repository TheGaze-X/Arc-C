using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001244 RID: 4676
	[Token(Token = "0x2001244")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeStageDuelResultType
	{
		// Token: 0x0400652B RID: 25899
		[Token(Token = "0x400652B")]
		LOSE = 1,
		// Token: 0x0400652C RID: 25900
		[Token(Token = "0x400652C")]
		DRAW,
		// Token: 0x0400652D RID: 25901
		[Token(Token = "0x400652D")]
		WIN
	}
}
