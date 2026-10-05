using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001284 RID: 4740
	[Token(Token = "0x2001284")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2CoinType
	{
		// Token: 0x04006891 RID: 26769
		[Token(Token = "0x4006891")]
		DIMENSION_COIN,
		// Token: 0x04006892 RID: 26770
		[Token(Token = "0x4006892")]
		GOLD
	}
}
