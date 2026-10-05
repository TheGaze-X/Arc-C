using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001306 RID: 4870
	[Token(Token = "0x2001306")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShopRouteTarget
	{
		// Token: 0x04006BE1 RID: 27617
		[Token(Token = "0x4006BE1")]
		RECOMMENDSHOP,
		// Token: 0x04006BE2 RID: 27618
		[Token(Token = "0x4006BE2")]
		CASHSHOP,
		// Token: 0x04006BE3 RID: 27619
		[Token(Token = "0x4006BE3")]
		GIFTPACKAGE,
		// Token: 0x04006BE4 RID: 27620
		[Token(Token = "0x4006BE4")]
		SKINSHOP,
		// Token: 0x04006BE5 RID: 27621
		[Token(Token = "0x4006BE5")]
		HQCSHOP,
		// Token: 0x04006BE6 RID: 27622
		[Token(Token = "0x4006BE6")]
		LQCSHOP,
		// Token: 0x04006BE7 RID: 27623
		[Token(Token = "0x4006BE7")]
		EXQCSHOP,
		// Token: 0x04006BE8 RID: 27624
		[Token(Token = "0x4006BE8")]
		SOCAILSHOP,
		// Token: 0x04006BE9 RID: 27625
		[Token(Token = "0x4006BE9")]
		FURNSHOP,
		// Token: 0x04006BEA RID: 27626
		[Token(Token = "0x4006BEA")]
		REPSHOP,
		// Token: 0x04006BEB RID: 27627
		[Token(Token = "0x4006BEB")]
		LMGTSSHOP,
		// Token: 0x04006BEC RID: 27628
		[Token(Token = "0x4006BEC")]
		EPGSSHOP,
		// Token: 0x04006BED RID: 27629
		[Token(Token = "0x4006BED")]
		CLASSICSHOP,
		// Token: 0x04006BEE RID: 27630
		[Token(Token = "0x4006BEE")]
		NONE
	}
}
