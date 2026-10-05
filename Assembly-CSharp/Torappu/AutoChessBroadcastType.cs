using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DA3 RID: 3491
	[Token(Token = "0x2000DA3")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessBroadcastType
	{
		// Token: 0x040047F3 RID: 18419
		[Token(Token = "0x40047F3")]
		NONE,
		// Token: 0x040047F4 RID: 18420
		[Token(Token = "0x40047F4")]
		GOLDEN_CHAR,
		// Token: 0x040047F5 RID: 18421
		[Token(Token = "0x40047F5")]
		SHOP_LEVEL,
		// Token: 0x040047F6 RID: 18422
		[Token(Token = "0x40047F6")]
		BOSS_HIT,
		// Token: 0x040047F7 RID: 18423
		[Token(Token = "0x40047F7")]
		CHAR_DAMAGE,
		// Token: 0x040047F8 RID: 18424
		[Token(Token = "0x40047F8")]
		CHAR_GIFT,
		// Token: 0x040047F9 RID: 18425
		[Token(Token = "0x40047F9")]
		BOND_EFFECT
	}
}
