using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000B61 RID: 2913
	[Token(Token = "0x2000B61")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TowerGameStrategy
	{
		// Token: 0x04003C9F RID: 15519
		[Token(Token = "0x4003C9F")]
		NONE,
		// Token: 0x04003CA0 RID: 15520
		[Token(Token = "0x4003CA0")]
		OPTIMIZE
	}
}
