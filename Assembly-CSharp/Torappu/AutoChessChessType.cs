using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DA4 RID: 3492
	[Token(Token = "0x2000DA4")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessChessType
	{
		// Token: 0x040047FB RID: 18427
		[Token(Token = "0x40047FB")]
		NORMAL,
		// Token: 0x040047FC RID: 18428
		[Token(Token = "0x40047FC")]
		DIY,
		// Token: 0x040047FD RID: 18429
		[Token(Token = "0x40047FD")]
		PRESET
	}
}
