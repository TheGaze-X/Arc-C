using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001239 RID: 4665
	[Token(Token = "0x2001239")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameItemType
	{
		// Token: 0x040064A3 RID: 25763
		[Token(Token = "0x40064A3")]
		NONE,
		// Token: 0x040064A4 RID: 25764
		[Token(Token = "0x40064A4")]
		HP,
		// Token: 0x040064A5 RID: 25765
		[Token(Token = "0x40064A5")]
		HPMAX,
		// Token: 0x040064A6 RID: 25766
		[Token(Token = "0x40064A6")]
		GOLD,
		// Token: 0x040064A7 RID: 25767
		[Token(Token = "0x40064A7")]
		POPULATION,
		// Token: 0x040064A8 RID: 25768
		[Token(Token = "0x40064A8")]
		EXP,
		// Token: 0x040064A9 RID: 25769
		[Token(Token = "0x40064A9")]
		SQUAD_CAPACITY,
		// Token: 0x040064AA RID: 25770
		[Token(Token = "0x40064AA")]
		RECRUIT_TICKET,
		// Token: 0x040064AB RID: 25771
		[Token(Token = "0x40064AB")]
		UPGRADE_TICKET,
		// Token: 0x040064AC RID: 25772
		[Token(Token = "0x40064AC")]
		RELIC,
		// Token: 0x040064AD RID: 25773
		[Token(Token = "0x40064AD")]
		BP_POINT,
		// Token: 0x040064AE RID: 25774
		[Token(Token = "0x40064AE")]
		GROW_POINT,
		// Token: 0x040064AF RID: 25775
		[Token(Token = "0x40064AF")]
		BAND,
		// Token: 0x040064B0 RID: 25776
		[Token(Token = "0x40064B0")]
		ACTIVE_TOOL,
		// Token: 0x040064B1 RID: 25777
		[Token(Token = "0x40064B1")]
		CAPSULE,
		// Token: 0x040064B2 RID: 25778
		[Token(Token = "0x40064B2")]
		POOL,
		// Token: 0x040064B3 RID: 25779
		[Token(Token = "0x40064B3")]
		RL_BP,
		// Token: 0x040064B4 RID: 25780
		[Token(Token = "0x40064B4")]
		RL_GP,
		// Token: 0x040064B5 RID: 25781
		[Token(Token = "0x40064B5")]
		KEY_POINT,
		// Token: 0x040064B6 RID: 25782
		[Token(Token = "0x40064B6")]
		SAN_POINT,
		// Token: 0x040064B7 RID: 25783
		[Token(Token = "0x40064B7")]
		DICE_POINT,
		// Token: 0x040064B8 RID: 25784
		[Token(Token = "0x40064B8")]
		DICE_TYPE,
		// Token: 0x040064B9 RID: 25785
		[Token(Token = "0x40064B9")]
		SHIELD,
		// Token: 0x040064BA RID: 25786
		[Token(Token = "0x40064BA")]
		LOCKED_TREASURE,
		// Token: 0x040064BB RID: 25787
		[Token(Token = "0x40064BB")]
		CUSTOM_TICKET,
		// Token: 0x040064BC RID: 25788
		[Token(Token = "0x40064BC")]
		TOTEM,
		// Token: 0x040064BD RID: 25789
		[Token(Token = "0x40064BD")]
		TOTEM_EFFECT,
		// Token: 0x040064BE RID: 25790
		[Token(Token = "0x40064BE")]
		FEATURE,
		// Token: 0x040064BF RID: 25791
		[Token(Token = "0x40064BF")]
		VISION,
		// Token: 0x040064C0 RID: 25792
		[Token(Token = "0x40064C0")]
		CHAOS,
		// Token: 0x040064C1 RID: 25793
		[Token(Token = "0x40064C1")]
		CHAOS_PURIFY,
		// Token: 0x040064C2 RID: 25794
		[Token(Token = "0x40064C2")]
		CHAOS_LEVEL,
		// Token: 0x040064C3 RID: 25795
		[Token(Token = "0x40064C3")]
		EXPLORE_TOOL,
		// Token: 0x040064C4 RID: 25796
		[Token(Token = "0x40064C4")]
		FRAGMENT,
		// Token: 0x040064C5 RID: 25797
		[Token(Token = "0x40064C5")]
		MAX_WEIGHT,
		// Token: 0x040064C6 RID: 25798
		[Token(Token = "0x40064C6")]
		DISASTER,
		// Token: 0x040064C7 RID: 25799
		[Token(Token = "0x40064C7")]
		DISASTER_TYPE,
		// Token: 0x040064C8 RID: 25800
		[Token(Token = "0x40064C8")]
		ABSTRACT_DISASTER,
		// Token: 0x040064C9 RID: 25801
		[Token(Token = "0x40064C9")]
		PILL,
		// Token: 0x040064CA RID: 25802
		[Token(Token = "0x40064CA")]
		BIGPILL,
		// Token: 0x040064CB RID: 25803
		[Token(Token = "0x40064CB")]
		COPPER,
		// Token: 0x040064CC RID: 25804
		[Token(Token = "0x40064CC")]
		COPPER_BUFF,
		// Token: 0x040064CD RID: 25805
		[Token(Token = "0x40064CD")]
		DIVINATION_KIT,
		// Token: 0x040064CE RID: 25806
		[Token(Token = "0x40064CE")]
		WRATH,
		// Token: 0x040064CF RID: 25807
		[Token(Token = "0x40064CF")]
		SPECIAL_ZONE_AP,
		// Token: 0x040064D0 RID: 25808
		[Token(Token = "0x40064D0")]
		COPPER_DRAW_NUM,
		// Token: 0x040064D1 RID: 25809
		[Token(Token = "0x40064D1")]
		STASH_RECRUIT_LIMIT
	}
}
