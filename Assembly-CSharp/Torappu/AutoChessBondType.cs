using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D95 RID: 3477
	[Token(Token = "0x2000D95")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessBondType
	{
		// Token: 0x0400479F RID: 18335
		[Token(Token = "0x400479F")]
		NONE,
		// Token: 0x040047A0 RID: 18336
		[Token(Token = "0x40047A0")]
		REGULAR,
		// Token: 0x040047A1 RID: 18337
		[Token(Token = "0x40047A1")]
		SEASON
	}
}
