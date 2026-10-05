using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001302 RID: 4866
	[Token(Token = "0x2001302")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShopCurrencyUnit
	{
		// Token: 0x04006BCC RID: 27596
		[Token(Token = "0x4006BCC")]
		CASH,
		// Token: 0x04006BCD RID: 27597
		[Token(Token = "0x4006BCD")]
		DIAMOND,
		// Token: 0x04006BCE RID: 27598
		[Token(Token = "0x4006BCE")]
		TICKET,
		// Token: 0x04006BCF RID: 27599
		[Token(Token = "0x4006BCF")]
		DIAMOND_SHD
	}
}
