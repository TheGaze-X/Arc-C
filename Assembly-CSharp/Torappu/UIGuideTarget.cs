using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200100E RID: 4110
	[Token(Token = "0x200100E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UIGuideTarget
	{
		// Token: 0x04005724 RID: 22308
		[Token(Token = "0x4005724")]
		NONE,
		// Token: 0x04005725 RID: 22309
		[Token(Token = "0x4005725")]
		BUILDING_CONTROL,
		// Token: 0x04005726 RID: 22310
		[Token(Token = "0x4005726")]
		BUILDING_DORM,
		// Token: 0x04005727 RID: 22311
		[Token(Token = "0x4005727")]
		BUILDING_HIRE,
		// Token: 0x04005728 RID: 22312
		[Token(Token = "0x4005728")]
		BUILDING_MANUFACT,
		// Token: 0x04005729 RID: 22313
		[Token(Token = "0x4005729")]
		BUILDING_MEETING,
		// Token: 0x0400572A RID: 22314
		[Token(Token = "0x400572A")]
		BUILDING_TRADING,
		// Token: 0x0400572B RID: 22315
		[Token(Token = "0x400572B")]
		CHAR_INFO,
		// Token: 0x0400572C RID: 22316
		[Token(Token = "0x400572C")]
		FRIEND,
		// Token: 0x0400572D RID: 22317
		[Token(Token = "0x400572D")]
		RECRUIT,
		// Token: 0x0400572E RID: 22318
		[Token(Token = "0x400572E")]
		SHOP,
		// Token: 0x0400572F RID: 22319
		[Token(Token = "0x400572F")]
		SQUAD_NORMAL,
		// Token: 0x04005730 RID: 22320
		[Token(Token = "0x4005730")]
		SQUAD_BATTLE,
		// Token: 0x04005731 RID: 22321
		[Token(Token = "0x4005731")]
		STAGE_MAINLINE,
		// Token: 0x04005732 RID: 22322
		[Token(Token = "0x4005732")]
		BUILDING_POWER,
		// Token: 0x04005733 RID: 22323
		[Token(Token = "0x4005733")]
		MISSION,
		// Token: 0x04005734 RID: 22324
		[Token(Token = "0x4005734")]
		CHAR_SKILL_SELECT,
		// Token: 0x04005735 RID: 22325
		[Token(Token = "0x4005735")]
		BUILDING_WORKSHOP,
		// Token: 0x04005736 RID: 22326
		[Token(Token = "0x4005736")]
		STAGE_CAMPAIGN,
		// Token: 0x04005737 RID: 22327
		[Token(Token = "0x4005737")]
		CHAR_EVOLVE,
		// Token: 0x04005738 RID: 22328
		[Token(Token = "0x4005738")]
		HANDBOOK,
		// Token: 0x04005739 RID: 22329
		[Token(Token = "0x4005739")]
		BUILDING_FURN_SHOP,
		// Token: 0x0400573A RID: 22330
		[Token(Token = "0x400573A")]
		BUILDING_TRAINING,
		// Token: 0x0400573B RID: 22331
		[Token(Token = "0x400573B")]
		STAGE_ACTIVITY,
		// Token: 0x0400573C RID: 22332
		[Token(Token = "0x400573C")]
		CRISIS_STAGE,
		// Token: 0x0400573D RID: 22333
		[Token(Token = "0x400573D")]
		ROGUELIKE_CHARSELECT,
		// Token: 0x0400573E RID: 22334
		[Token(Token = "0x400573E")]
		ROGUELIKE_BP,
		// Token: 0x0400573F RID: 22335
		[Token(Token = "0x400573F")]
		CLIMB_TOWER_ENTRY,
		// Token: 0x04005740 RID: 22336
		[Token(Token = "0x4005740")]
		CLIMB_TOWER_LAYER,
		// Token: 0x04005741 RID: 22337
		[Token(Token = "0x4005741")]
		ROGUELIKE_DUNGEON = 31,
		// Token: 0x04005742 RID: 22338
		[Token(Token = "0x4005742")]
		RL03_TOTEM,
		// Token: 0x04005743 RID: 22339
		[Token(Token = "0x4005743")]
		GROCERY,
		// Token: 0x04005744 RID: 22340
		[Token(Token = "0x4005744")]
		TUNING,
		// Token: 0x04005745 RID: 22341
		[Token(Token = "0x4005745")]
		CRISIS_V2,
		// Token: 0x04005746 RID: 22342
		[Token(Token = "0x4005746")]
		MISSION_ARCHIVE,
		// Token: 0x04005747 RID: 22343
		[Token(Token = "0x4005747")]
		FIFTH_ANNIV_EXPLORE,
		// Token: 0x04005748 RID: 22344
		[Token(Token = "0x4005748")]
		CARVING,
		// Token: 0x04005749 RID: 22345
		[Token(Token = "0x4005749")]
		VEC_BREAK,
		// Token: 0x0400574A RID: 22346
		[Token(Token = "0x400574A")]
		FIREWORK,
		// Token: 0x0400574B RID: 22347
		[Token(Token = "0x400574B")]
		BUILDING_STATION_MANAGE,
		// Token: 0x0400574C RID: 22348
		[Token(Token = "0x400574C")]
		ACT_MULTI_V3,
		// Token: 0x0400574D RID: 22349
		[Token(Token = "0x400574D")]
		ENEMY_DUEL,
		// Token: 0x0400574E RID: 22350
		[Token(Token = "0x400574E")]
		VEC_BREAK_V2,
		// Token: 0x0400574F RID: 22351
		[Token(Token = "0x400574F")]
		GUN_TASK,
		// Token: 0x04005750 RID: 22352
		[Token(Token = "0x4005750")]
		SPECIAL_OPERATOR,
		// Token: 0x04005751 RID: 22353
		[Token(Token = "0x4005751")]
		INFORMANT,
		// Token: 0x04005752 RID: 22354
		[Token(Token = "0x4005752")]
		ACT1VHALFIDLE,
		// Token: 0x04005753 RID: 22355
		[Token(Token = "0x4005753")]
		MONOPOLY,
		// Token: 0x04005754 RID: 22356
		[Token(Token = "0x4005754")]
		AUTO_CHESS,
		// Token: 0x04005755 RID: 22357
		[Token(Token = "0x4005755")]
		ART_GALLERY,
		// Token: 0x04005756 RID: 22358
		[Token(Token = "0x4005756")]
		ART_MAGAZINE
	}
}
