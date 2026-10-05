using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D9C RID: 3484
	[Token(Token = "0x2000D9C")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActAutoChessModeType
	{
		// Token: 0x040047CF RID: 18383
		[Token(Token = "0x40047CF")]
		NONE = -1,
		// Token: 0x040047D0 RID: 18384
		[Token(Token = "0x40047D0")]
		LOCAL,
		// Token: 0x040047D1 RID: 18385
		[Token(Token = "0x40047D1")]
		SINGLE,
		// Token: 0x040047D2 RID: 18386
		[Token(Token = "0x40047D2")]
		MULTI
	}
}
