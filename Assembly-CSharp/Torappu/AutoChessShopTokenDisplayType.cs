using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D96 RID: 3478
	[Token(Token = "0x2000D96")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessShopTokenDisplayType
	{
		// Token: 0x040047A3 RID: 18339
		[Token(Token = "0x40047A3")]
		DEFAULT,
		// Token: 0x040047A4 RID: 18340
		[Token(Token = "0x40047A4")]
		HIDDEN
	}
}
