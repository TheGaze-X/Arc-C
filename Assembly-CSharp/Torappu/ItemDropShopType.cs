using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020010A9 RID: 4265
	[Token(Token = "0x20010A9")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ItemDropShopType
	{
		// Token: 0x04005B56 RID: 23382
		[Token(Token = "0x4005B56")]
		HGGSHD_SHOP,
		// Token: 0x04005B57 RID: 23383
		[Token(Token = "0x4005B57")]
		LGGSHD_SHOP,
		// Token: 0x04005B58 RID: 23384
		[Token(Token = "0x4005B58")]
		XSHD_SHOP,
		// Token: 0x04005B59 RID: 23385
		[Token(Token = "0x4005B59")]
		EPGS_SHOP,
		// Token: 0x04005B5A RID: 23386
		[Token(Token = "0x4005B5A")]
		REP_SHOP,
		// Token: 0x04005B5B RID: 23387
		[Token(Token = "0x4005B5B")]
		CLASSIC_SHOP
	}
}
