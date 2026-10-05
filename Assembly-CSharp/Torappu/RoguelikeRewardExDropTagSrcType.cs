using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011CB RID: 4555
	[Token(Token = "0x20011CB")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeRewardExDropTagSrcType
	{
		// Token: 0x04006199 RID: 24985
		[Token(Token = "0x4006199")]
		NONE,
		// Token: 0x0400619A RID: 24986
		[Token(Token = "0x400619A")]
		TREASURE,
		// Token: 0x0400619B RID: 24987
		[Token(Token = "0x400619B")]
		TOTEM,
		// Token: 0x0400619C RID: 24988
		[Token(Token = "0x400619C")]
		EXPLORE_TOOL,
		// Token: 0x0400619D RID: 24989
		[Token(Token = "0x400619D")]
		COPPER,
		// Token: 0x0400619E RID: 24990
		[Token(Token = "0x400619E")]
		EVIL_TEMPLE
	}
}
