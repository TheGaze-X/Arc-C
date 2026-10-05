using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200123F RID: 4671
	[Token(Token = "0x200123F")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameChoiceType
	{
		// Token: 0x040064FE RID: 25854
		[Token(Token = "0x40064FE")]
		NONE,
		// Token: 0x040064FF RID: 25855
		[Token(Token = "0x40064FF")]
		LEAVE,
		// Token: 0x04006500 RID: 25856
		[Token(Token = "0x4006500")]
		NEXT,
		// Token: 0x04006501 RID: 25857
		[Token(Token = "0x4006501")]
		NEXT_PROB,
		// Token: 0x04006502 RID: 25858
		[Token(Token = "0x4006502")]
		TRADE,
		// Token: 0x04006503 RID: 25859
		[Token(Token = "0x4006503")]
		TRADE_PROB,
		// Token: 0x04006504 RID: 25860
		[Token(Token = "0x4006504")]
		SACRIFICE,
		// Token: 0x04006505 RID: 25861
		[Token(Token = "0x4006505")]
		TELEPORT,
		// Token: 0x04006506 RID: 25862
		[Token(Token = "0x4006506")]
		EXPEDITION,
		// Token: 0x04006507 RID: 25863
		[Token(Token = "0x4006507")]
		WISH,
		// Token: 0x04006508 RID: 25864
		[Token(Token = "0x4006508")]
		TRADE_PROB_SHOW,
		// Token: 0x04006509 RID: 25865
		[Token(Token = "0x4006509")]
		SACRIFICE_TOTEM,
		// Token: 0x0400650A RID: 25866
		[Token(Token = "0x400650A")]
		WISH_ALL,
		// Token: 0x0400650B RID: 25867
		[Token(Token = "0x400650B")]
		KILL,
		// Token: 0x0400650C RID: 25868
		[Token(Token = "0x400650C")]
		USE_STASHED_TICKET,
		// Token: 0x0400650D RID: 25869
		[Token(Token = "0x400650D")]
		EXPEDITION_ALL,
		// Token: 0x0400650E RID: 25870
		[Token(Token = "0x400650E")]
		EXPEDITION_RETURN_ALL,
		// Token: 0x0400650F RID: 25871
		[Token(Token = "0x400650F")]
		PACIFY_WRATH,
		// Token: 0x04006510 RID: 25872
		[Token(Token = "0x4006510")]
		GILD_COPPER,
		// Token: 0x04006511 RID: 25873
		[Token(Token = "0x4006511")]
		ITEM_REROLL,
		// Token: 0x04006512 RID: 25874
		[Token(Token = "0x4006512")]
		ITEM_TOP_UP,
		// Token: 0x04006513 RID: 25875
		[Token(Token = "0x4006513")]
		GILD_COPPER_ALL,
		// Token: 0x04006514 RID: 25876
		[Token(Token = "0x4006514")]
		JUMP_PROB,
		// Token: 0x04006515 RID: 25877
		[Token(Token = "0x4006515")]
		JUMP
	}
}
