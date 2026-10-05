using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001214 RID: 4628
	[Token(Token = "0x2001214")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeChoiceHintType
	{
		// Token: 0x040063EA RID: 25578
		[Token(Token = "0x40063EA")]
		NONE,
		// Token: 0x040063EB RID: 25579
		[Token(Token = "0x40063EB")]
		ITEM,
		// Token: 0x040063EC RID: 25580
		[Token(Token = "0x40063EC")]
		CANDLED_CHAR,
		// Token: 0x040063ED RID: 25581
		[Token(Token = "0x40063ED")]
		GUIDED_CHAR,
		// Token: 0x040063EE RID: 25582
		[Token(Token = "0x40063EE")]
		SACRIFICE,
		// Token: 0x040063EF RID: 25583
		[Token(Token = "0x40063EF")]
		SACRIFICE_TOTEM,
		// Token: 0x040063F0 RID: 25584
		[Token(Token = "0x40063F0")]
		EXPEDITION,
		// Token: 0x040063F1 RID: 25585
		[Token(Token = "0x40063F1")]
		CANDLE,
		// Token: 0x040063F2 RID: 25586
		[Token(Token = "0x40063F2")]
		GUIDED,
		// Token: 0x040063F3 RID: 25587
		[Token(Token = "0x40063F3")]
		HP,
		// Token: 0x040063F4 RID: 25588
		[Token(Token = "0x40063F4")]
		VISION,
		// Token: 0x040063F5 RID: 25589
		[Token(Token = "0x40063F5")]
		STASHED_RECRUIT,
		// Token: 0x040063F6 RID: 25590
		[Token(Token = "0x40063F6")]
		CHAOS,
		// Token: 0x040063F7 RID: 25591
		[Token(Token = "0x40063F7")]
		FRAGMENT,
		// Token: 0x040063F8 RID: 25592
		[Token(Token = "0x40063F8")]
		SP_ZONE_AP,
		// Token: 0x040063F9 RID: 25593
		[Token(Token = "0x40063F9")]
		COPPER_LUCK
	}
}
