using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C84 RID: 3204
	[Token(Token = "0x2000C84")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act1VHalfIdleItemType
	{
		// Token: 0x04004166 RID: 16742
		[Token(Token = "0x4004166")]
		NONE,
		// Token: 0x04004167 RID: 16743
		[Token(Token = "0x4004167")]
		LEVEL_EXP,
		// Token: 0x04004168 RID: 16744
		[Token(Token = "0x4004168")]
		SKILL_EXP,
		// Token: 0x04004169 RID: 16745
		[Token(Token = "0x4004169")]
		STRATEGY_POINT,
		// Token: 0x0400416A RID: 16746
		[Token(Token = "0x400416A")]
		ASC,
		// Token: 0x0400416B RID: 16747
		[Token(Token = "0x400416B")]
		GACHA,
		// Token: 0x0400416C RID: 16748
		[Token(Token = "0x400416C")]
		MODEL,
		// Token: 0x0400416D RID: 16749
		[Token(Token = "0x400416D")]
		ACTIVITY_ITEM
	}
}
