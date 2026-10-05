using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DA0 RID: 3488
	[Token(Token = "0x2000DA0")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessItemType
	{
		// Token: 0x040047E5 RID: 18405
		[Token(Token = "0x40047E5")]
		CHAR,
		// Token: 0x040047E6 RID: 18406
		[Token(Token = "0x40047E6")]
		EQUIP,
		// Token: 0x040047E7 RID: 18407
		[Token(Token = "0x40047E7")]
		MAGIC,
		// Token: 0x040047E8 RID: 18408
		[Token(Token = "0x40047E8")]
		TOKEN
	}
}
