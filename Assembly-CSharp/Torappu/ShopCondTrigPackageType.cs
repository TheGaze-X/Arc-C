using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001307 RID: 4871
	[Token(Token = "0x2001307")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShopCondTrigPackageType
	{
		// Token: 0x04006BF0 RID: 27632
		[Token(Token = "0x4006BF0")]
		NONE,
		// Token: 0x04006BF1 RID: 27633
		[Token(Token = "0x4006BF1")]
		RETURN_PROGRESS,
		// Token: 0x04006BF2 RID: 27634
		[Token(Token = "0x4006BF2")]
		RETURN_ONCE,
		// Token: 0x04006BF3 RID: 27635
		[Token(Token = "0x4006BF3")]
		NEW_PROGRESS,
		// Token: 0x04006BF4 RID: 27636
		[Token(Token = "0x4006BF4")]
		CHOOSE_REGISTER_TIME,
		// Token: 0x04006BF5 RID: 27637
		[Token(Token = "0x4006BF5")]
		CHOOSE_NEWBIE
	}
}
