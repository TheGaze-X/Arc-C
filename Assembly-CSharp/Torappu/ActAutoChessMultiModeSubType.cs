using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D9D RID: 3485
	[Token(Token = "0x2000D9D")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActAutoChessMultiModeSubType
	{
		// Token: 0x040047D4 RID: 18388
		[Token(Token = "0x40047D4")]
		NONE,
		// Token: 0x040047D5 RID: 18389
		[Token(Token = "0x40047D5")]
		SOLO,
		// Token: 0x040047D6 RID: 18390
		[Token(Token = "0x40047D6")]
		TEAM
	}
}
