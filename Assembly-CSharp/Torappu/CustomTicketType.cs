using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200122B RID: 4651
	[Token(Token = "0x200122B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CustomTicketType
	{
		// Token: 0x04006475 RID: 25717
		[Token(Token = "0x4006475")]
		NONE,
		// Token: 0x04006476 RID: 25718
		[Token(Token = "0x4006476")]
		PURIFY,
		// Token: 0x04006477 RID: 25719
		[Token(Token = "0x4006477")]
		GET_CANDLE
	}
}
