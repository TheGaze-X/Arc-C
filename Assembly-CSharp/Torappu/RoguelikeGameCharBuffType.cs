using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001221 RID: 4641
	[Token(Token = "0x2001221")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameCharBuffType
	{
		// Token: 0x04006438 RID: 25656
		[Token(Token = "0x4006438")]
		NONE,
		// Token: 0x04006439 RID: 25657
		[Token(Token = "0x4006439")]
		MUTATION,
		// Token: 0x0400643A RID: 25658
		[Token(Token = "0x400643A")]
		EVOLUTION
	}
}
