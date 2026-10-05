using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FB0 RID: 8112
	[Token(Token = "0x2001FB0")]
	[LuaCallCSharp(GenFlag.No)]
	public static class Consts
	{
		// Token: 0x0400D04D RID: 53325
		[Token(Token = "0x400D04D")]
		public const string DEFAULT_BTN_CLICK = "ON_DEFAULT_BTN_CLICK";

		// Token: 0x0400D04E RID: 53326
		[Token(Token = "0x400D04E")]
		public const string SCENE_LOADED = "ON_SCENE_LOADED";

		// Token: 0x0400D04F RID: 53327
		[Token(Token = "0x400D04F")]
		public const string BATTLE_FINISH = "ON_BATTLE_FINISH";

		// Token: 0x0400D050 RID: 53328
		[Token(Token = "0x400D050")]
		public const string FORBIDDEN_OPERATION = "ON_FORBIDDEN_OPERATION";

		// Token: 0x0400D051 RID: 53329
		[Token(Token = "0x400D051")]
		public const string PAGE_EXISTED = "ON_PAGE_EXISTED";

		// Token: 0x0400D052 RID: 53330
		[Token(Token = "0x400D052")]
		public const string ACTIVITY_LOADED = "ON_ACTIVITY_LOADED";

		// Token: 0x0400D053 RID: 53331
		[Token(Token = "0x400D053")]
		public const string RETRO_LOADED = "ON_RETRO_LOADED";

		// Token: 0x0400D054 RID: 53332
		[Token(Token = "0x400D054")]
		public const string ACT_CAMP_SELECT = "ON_ACT_CAMP_SELECT";

		// Token: 0x0400D055 RID: 53333
		[Token(Token = "0x400D055")]
		public const string CRISIS_NO_SEASON_LOADED = "ON_CRISIS_NO_SEASON_LOADED";

		// Token: 0x0400D056 RID: 53334
		[Token(Token = "0x400D056")]
		public const string CRISIS_SEASON_LOADED = "ON_CRISIS_SEASON_LOADED";

		// Token: 0x0400D057 RID: 53335
		[Token(Token = "0x400D057")]
		public const string CRISIS_V2_SEASON_LOADED = "ON_CRISIS_V2_SEASON_LOADED";

		// Token: 0x0400D058 RID: 53336
		[Token(Token = "0x400D058")]
		public const string ROGUELIKE_NUMBER_UP = "ON_NUMBER_TICK";

		// Token: 0x0400D059 RID: 53337
		[Token(Token = "0x400D059")]
		public const string MEDAL_NUMBER_TICK = "ON_NUMBER_TICK_2";

		// Token: 0x0400D05A RID: 53338
		[Token(Token = "0x400D05A")]
		public const string BGM_CLEAR = "BGM_CLEAR";

		// Token: 0x0400D05B RID: 53339
		[Token(Token = "0x400D05B")]
		public const string ACTIVITY_ACTIVE_TRACKS = "ACTIVITY_ACTIVE_TRACKS";

		// Token: 0x0400D05C RID: 53340
		[Token(Token = "0x400D05C")]
		public const string MISSION_ARCHIVE_LOADED = "ON_MISSION_ARCHIVE_LOADED";

		// Token: 0x0400D05D RID: 53341
		[Token(Token = "0x400D05D")]
		public const string SANDBOX_PERM_ENTRY_LOADED = "ON_SANDBOX_ENTRY";

		// Token: 0x0400D05E RID: 53342
		[Token(Token = "0x400D05E")]
		public const string SANDBOX_V2_DUNGEON_LOADED = "ON_SANDBOX_MAP";

		// Token: 0x0400D05F RID: 53343
		[Token(Token = "0x400D05F")]
		public const string SANDBOX_V2_DUNGEON_CONSTRUCT = "ON_SANDBOX_CONSTRUCT";

		// Token: 0x0400D060 RID: 53344
		[Token(Token = "0x400D060")]
		public const string SANDBOX_V2_DUNGEON_LOADED_BOSS_RUSH = "ON_SANDBOX_MAPRUSH";

		// Token: 0x0400D061 RID: 53345
		[Token(Token = "0x400D061")]
		public const string SANDBOX_V2_DUNGEON_LOADED_RIFT = "ON_SANDBOX_DUNGEONMAP";

		// Token: 0x0400D062 RID: 53346
		[Token(Token = "0x400D062")]
		public const string SANDBOX_V2_DUNGEON_LOADED_CHALLENGE = "ON_SANDBOX_CHALLENGEMAP";

		// Token: 0x0400D063 RID: 53347
		[Token(Token = "0x400D063")]
		public const string GACHA_PHASE_0 = "ON_GACHA_PHASE_0";

		// Token: 0x0400D064 RID: 53348
		[Token(Token = "0x400D064")]
		public const string GACHA_PHASE_1 = "ON_GACHA_PHASE_1";

		// Token: 0x0400D065 RID: 53349
		[Token(Token = "0x400D065")]
		public const string GACHA_TEN_RESULT_PANEL_SHOWN = "ON_TEN_GACHA_RESULT_PANEL_SHOWN";

		// Token: 0x0400D066 RID: 53350
		[Token(Token = "0x400D066")]
		public const string MIX_STORY_OVERALL_ENTRY = "ON_MIXSTORY_LINETRANSITION";

		// Token: 0x0400D067 RID: 53351
		[Token(Token = "0x400D067")]
		public const string GACHA_STAR = "ON_GACHA_STAR";

		// Token: 0x0400D068 RID: 53352
		[Token(Token = "0x400D068")]
		public const string GACHA_1GACHA_RELEASE = "ON_CARD_1CARD_RELEASE";

		// Token: 0x0400D069 RID: 53353
		[Token(Token = "0x400D069")]
		public const string GACHA_10GACHA_RELEASE = "ON_CARD_10CARD_RELEASE";

		// Token: 0x0400D06A RID: 53354
		[Token(Token = "0x400D06A")]
		public const string GACHA_CHECKOUT = "ON_CARD_CHECKOUT";

		// Token: 0x0400D06B RID: 53355
		[Token(Token = "0x400D06B")]
		public const string GACHA_PACKAGE_ZIPPER = "ON_CARD_PACKAGE_ZIPPER";

		// Token: 0x0400D06C RID: 53356
		[Token(Token = "0x400D06C")]
		public const string GACHA_PACKAGE_DROP = "ON_CARD_PACKAGE_DROP";

		// Token: 0x0400D06D RID: 53357
		[Token(Token = "0x400D06D")]
		public const string GACHA_BOX_DRAW = "ON_GACHA_BOX_DRAW";

		// Token: 0x0400D06E RID: 53358
		[Token(Token = "0x400D06E")]
		public const string GACHA_STOP_SUBSIGNAL = "OFF";

		// Token: 0x0400D06F RID: 53359
		[Token(Token = "0x400D06F")]
		public const string BATTLE_END_STAR_POPUP = "ON_BATTLE_END_STAR_POPUP";

		// Token: 0x0400D070 RID: 53360
		[Token(Token = "0x400D070")]
		public const string BATTLE_END_ITEM_POPUP = "ON_BATTLE_END_ITEM_POPUP";

		// Token: 0x0400D071 RID: 53361
		[Token(Token = "0x400D071")]
		public const string ITEM_PANEL_POPUP = "ON_HOME_REWARD_LARGEINTERFACE";

		// Token: 0x0400D072 RID: 53362
		[Token(Token = "0x400D072")]
		public const string ITEM_PANEL_SHOW_EACH_ITEM = "ON_HOME_REWARD_EACH";

		// Token: 0x0400D073 RID: 53363
		[Token(Token = "0x400D073")]
		public const string DETAIL_PANEL_POPUP = "ON_HOME_DETAIL_CHECK";

		// Token: 0x0400D074 RID: 53364
		[Token(Token = "0x400D074")]
		public const string SKIN_SLIDE = "ON_SKIN_SLIDE";

		// Token: 0x0400D075 RID: 53365
		[Token(Token = "0x400D075")]
		public const string LINE_FLOW = "ON_LINE_FLOW";

		// Token: 0x0400D076 RID: 53366
		[Token(Token = "0x400D076")]
		public const string STAMP_SEAL = "ON_HOME_REWORD_SEAL";

		// Token: 0x0400D077 RID: 53367
		[Token(Token = "0x400D077")]
		public const string HOME_MONTH_SIGNIN = "ON_HOME_MONTH_SIGNIN";

		// Token: 0x0400D078 RID: 53368
		[Token(Token = "0x400D078")]
		public const string PLAYER_LEVEL_EXP_EXPAND_START = "ON_PLAYER_LEVELUP_START";

		// Token: 0x0400D079 RID: 53369
		[Token(Token = "0x400D079")]
		public const string PLAYER_LEVEL_EXP_EXPAND_STOP = "ON_PLAYER_LEVELUP_START.OFF";

		// Token: 0x0400D07A RID: 53370
		[Token(Token = "0x400D07A")]
		public const string PLAYER_LEVELUP = "ON_PLAYER_LEVELUP_FINISH";

		// Token: 0x0400D07B RID: 53371
		[Token(Token = "0x400D07B")]
		public const string ON_BANNER_SLIDE = "ON_BANNER_SLIDE";

		// Token: 0x0400D07C RID: 53372
		[Token(Token = "0x400D07C")]
		public const string ON_ROGUELIKE_INVESTMENT = "ON_ROGUELIKE_INVESTMENT";

		// Token: 0x0400D07D RID: 53373
		[Token(Token = "0x400D07D")]
		public const string ON_ROGUELIKE_DISTORT = "ON_ROGUELIKE_DISTORT";

		// Token: 0x0400D07E RID: 53374
		[Token(Token = "0x400D07E")]
		public const string ON_ROGUELIKE_DISTORT2 = "ON_ROGUELIKE_DISTORT2";

		// Token: 0x0400D07F RID: 53375
		[Token(Token = "0x400D07F")]
		public const string ON_ROGUELIKE_BELLENTER1 = "ON_ROGUELIKE_BELLENTER1";

		// Token: 0x0400D080 RID: 53376
		[Token(Token = "0x400D080")]
		public const string ON_ROGUELIKE_BELLENTER2 = "ON_ROGUELIKE_BELLENTER2";

		// Token: 0x0400D081 RID: 53377
		[Token(Token = "0x400D081")]
		public const string BUILDING_INDUST_START = "ON_BUILDING_INDUST_START";

		// Token: 0x0400D082 RID: 53378
		[Token(Token = "0x400D082")]
		public const string BUILDING_INDUST_FINISH_SINGLE = "ON_BUILDING_INDUST_FIN_SINGLE";

		// Token: 0x0400D083 RID: 53379
		[Token(Token = "0x400D083")]
		public const string BUILDING_INDUST_FINISH_MANY = "ON_BUILDING_INDUST_FIN_MANY";

		// Token: 0x0400D084 RID: 53380
		[Token(Token = "0x400D084")]
		public const string BUILDING_ELEVATOR_START = "ON_BUILDING_ELEVATOR";

		// Token: 0x0400D085 RID: 53381
		[Token(Token = "0x400D085")]
		public const string BUILDING_EMOJI_POP = "ON_BUILDING_EMOJIDIALOGUE";

		// Token: 0x0400D086 RID: 53382
		[Token(Token = "0x400D086")]
		public const string BUILDING_CHAR_CTRL_ENTER = "ON_BUILDING_SWITCHMODE";

		// Token: 0x0400D087 RID: 53383
		[Token(Token = "0x400D087")]
		public const string BUILDING_NEWVISITOR = "ON_BUILDING_NEWVISITOR";

		// Token: 0x0400D088 RID: 53384
		[Token(Token = "0x400D088")]
		public const string BUILDING_EMOJIDIALOGUE = "ON_BUILDING_EMOJIDIALOGUE";

		// Token: 0x0400D089 RID: 53385
		[Token(Token = "0x400D089")]
		public const string BUILDING_LOADMESSAGEBOARD = "ON_BUILDING_LOADMESSAGEBOARD";

		// Token: 0x0400D08A RID: 53386
		[Token(Token = "0x400D08A")]
		public const string HANDBOOK_CHAR_SELECT = "ON_INFORMATION_CLICK";

		// Token: 0x0400D08B RID: 53387
		[Token(Token = "0x400D08B")]
		public const string HANDBOOK_CONNECT_LINE = "ON_INFORMATION_LINE";

		// Token: 0x0400D08C RID: 53388
		[Token(Token = "0x400D08C")]
		public const string HANDBOOK_CHAR_MOVE_1 = "ON_INFORMATION_MOVE_1";

		// Token: 0x0400D08D RID: 53389
		[Token(Token = "0x400D08D")]
		public const string HANDBOOK_CHAR_MOVE_2 = "ON_INFORMATION_MOVE_2";

		// Token: 0x0400D08E RID: 53390
		[Token(Token = "0x400D08E")]
		public const string MEDAL_DIY_PLACED = "ON_MEDAL_DIY_PLACED";

		// Token: 0x0400D08F RID: 53391
		[Token(Token = "0x400D08F")]
		public const string ROGUELIKE_STATE_CHANGED = "ON_ROGUELIKE_STATE_CHANGED";

		// Token: 0x0400D090 RID: 53392
		[Token(Token = "0x400D090")]
		public const string ROGUELIKE_MAGIC_CARD = "ON_ROGUELIKE_MAGICCARD";

		// Token: 0x0400D091 RID: 53393
		[Token(Token = "0x400D091")]
		public const string ROGUELIKE_TALENT_UNLOCK = "ON_ROGUELIKE_RLTALENTUNLOCK";

		// Token: 0x0400D092 RID: 53394
		[Token(Token = "0x400D092")]
		public const string ROGUELIKE_LOADED = "ON_ROGUELIKE_LOADED";

		// Token: 0x0400D093 RID: 53395
		[Token(Token = "0x400D093")]
		public const string ROGUELIKE_MAP = "ON_ROGUELIKE_MAP";

		// Token: 0x0400D094 RID: 53396
		[Token(Token = "0x400D094")]
		public const string ROGUELIKE_VARIATION = "ON_ROGUELIKE_VARIATION";

		// Token: 0x0400D095 RID: 53397
		[Token(Token = "0x400D095")]
		public const string ROGUELIKE_VARIATIONHIGH = "ON_ROGUELIKE_VARIATIONHIGH";

		// Token: 0x0400D096 RID: 53398
		[Token(Token = "0x400D096")]
		public const string ROGUELIKE_VARIATIONLOW = "ON_ROGUELIKE_VARIATIONLOW";

		// Token: 0x0400D097 RID: 53399
		[Token(Token = "0x400D097")]
		public const string ROGUELIKE_SECRET_MAP = "ON_ROGUELIKE_SECRET_MAP";

		// Token: 0x0400D098 RID: 53400
		[Token(Token = "0x400D098")]
		public const string ROGUELIKE_MAPHIGH = "ON_ROGUELIKE_MAPHIGH";

		// Token: 0x0400D099 RID: 53401
		[Token(Token = "0x400D099")]
		public const string ROGUELIKE_MAPLOW = "ON_ROGUELIKE_MAPLOW";

		// Token: 0x0400D09A RID: 53402
		[Token(Token = "0x400D09A")]
		public const string ROGUELIKE_DEEPMAPHIGH = "ON_ROGUELIKE_DEEPMAPHIGH";

		// Token: 0x0400D09B RID: 53403
		[Token(Token = "0x400D09B")]
		public const string ROGUELIKE_DEEPMAPLOW = "ON_ROGUELIKE_DEEPMAPLOW";

		// Token: 0x0400D09C RID: 53404
		[Token(Token = "0x400D09C")]
		public const string ROGUELIKE_SECRET_EVENT = "ON_ROGUELIKE_SECRET_EVENT";

		// Token: 0x0400D09D RID: 53405
		[Token(Token = "0x400D09D")]
		public const string ROGUELIKE_SHOP = "ON_ROGUELIKE_SHOP";

		// Token: 0x0400D09E RID: 53406
		[Token(Token = "0x400D09E")]
		public const string ROGUELIKE_SETTLE = "ON_ROGUELIKE_SETTLE";

		// Token: 0x0400D09F RID: 53407
		[Token(Token = "0x400D09F")]
		public const string ROGUELIKE_EVENT = "ON_ROGUELIKE_EVENT";

		// Token: 0x0400D0A0 RID: 53408
		[Token(Token = "0x400D0A0")]
		public const string ROGUELIKE_MAPBOSS = "ON_ROGUELIKE_MAPBOSS";

		// Token: 0x0400D0A1 RID: 53409
		[Token(Token = "0x400D0A1")]
		public const string ROGUELIKE_MAPSECRET = "ON_ROGUELIKE_MAPSECRET";

		// Token: 0x0400D0A2 RID: 53410
		[Token(Token = "0x400D0A2")]
		public const string ROGUELIKE_ITEM = "ON_ROGUELIKE_ITEM";

		// Token: 0x0400D0A3 RID: 53411
		[Token(Token = "0x400D0A3")]
		public const string ROGUELIKE_COLLECTION = "ON_ROGUELIKE_COLLECTION";

		// Token: 0x0400D0A4 RID: 53412
		[Token(Token = "0x400D0A4")]
		public const string RL03_SAMECOLOUR = "ON_ROGUELIKE_SAMECOLOUR";

		// Token: 0x0400D0A5 RID: 53413
		[Token(Token = "0x400D0A5")]
		public const string RL03_GENERALTOTEM = "ON_ROGUELIKE_GENERALTOTEM";

		// Token: 0x0400D0A6 RID: 53414
		[Token(Token = "0x400D0A6")]
		public const string RL03_SAMETOTEM = "ON_ROGUELIKE_SAMETOTEM";

		// Token: 0x0400D0A7 RID: 53415
		[Token(Token = "0x400D0A7")]
		public const string RL03_EVILMSG = "ON_ROGUELIKE_EVILMSG";

		// Token: 0x0400D0A8 RID: 53416
		[Token(Token = "0x400D0A8")]
		public const string RL03_PREDICT_TOTEM = "ON_ROGUELIKE_ANGELTOTEM";

		// Token: 0x0400D0A9 RID: 53417
		[Token(Token = "0x400D0A9")]
		public const string RL03_PREDICT_CHAOS = "ON_ROGUELIKE_EVILTOTEM";

		// Token: 0x0400D0AA RID: 53418
		[Token(Token = "0x400D0AA")]
		public const string RL03_CHAOS_COLLAPSE_UP = "ON_ROGUELIKE_COLLAPSEUPONCE";

		// Token: 0x0400D0AB RID: 53419
		[Token(Token = "0x400D0AB")]
		public const string RL03_CHAOS_COLLAPSE_UP_RANK = "ON_ROGUELIKE_COLLAPSEUP";

		// Token: 0x0400D0AC RID: 53420
		[Token(Token = "0x400D0AC")]
		public const string RL04_UPGRADE_NODE = "ON_ROGUELIKE_IMPRESTRENGTH";

		// Token: 0x0400D0AD RID: 53421
		[Token(Token = "0x400D0AD")]
		public const string RL04_TEMP_UPGRADE_NODE = "ON_ROGUELIKE_IMPRESDEEPEN";

		// Token: 0x0400D0AE RID: 53422
		[Token(Token = "0x400D0AE")]
		public const string RL04_USE_INSPIRATION = "ON_ROGUELIKE_FOODTAKEIN";

		// Token: 0x0400D0AF RID: 53423
		[Token(Token = "0x400D0AF")]
		public const string RL04_DISASTER_GAIN = "ON_ROGUELIKE_DISASTER";

		// Token: 0x0400D0B0 RID: 53424
		[Token(Token = "0x400D0B0")]
		public const string RL04_DISASTER_CLEAR = "ON_ROGUELIKE_DISASTERCLEAR";

		// Token: 0x0400D0B1 RID: 53425
		[Token(Token = "0x400D0B1")]
		public const string RL04_FRAGMENT_OVERWEIGHT = "ON_ROGUELIKE_OVERWEIGHT";

		// Token: 0x0400D0B2 RID: 53426
		[Token(Token = "0x400D0B2")]
		public const string RL04_ALCHEMY_FORECAST_RANDOM = "ON_ROGUELIKE_GAFORE_UNCERTAIN";

		// Token: 0x0400D0B3 RID: 53427
		[Token(Token = "0x400D0B3")]
		public const string RL04_ALCHEMY_FORECAST_CERTAIN = "ON_ROGUELIKE_GAFORE_CERTAIN";

		// Token: 0x0400D0B4 RID: 53428
		[Token(Token = "0x400D0B4")]
		public const string RL04_ALCHEMY_RESULT_SSR = "ON_ROGUELIKE_GAPROCESS_AWARD";

		// Token: 0x0400D0B5 RID: 53429
		[Token(Token = "0x400D0B5")]
		public const string RL04_ALCHEMY_RESULT_NORMAL = "ON_ROGUELIKE_GAPROCESS_NORMAL";

		// Token: 0x0400D0B6 RID: 53430
		[Token(Token = "0x400D0B6")]
		public const string RL04_ALCHEMY_RESULT_FAILED = "ON_ROGUELIKE_GAPROCESS_FAILED";

		// Token: 0x0400D0B7 RID: 53431
		[Token(Token = "0x400D0B7")]
		public const string RL04_TRANSITION = "ON_ROGUELIKE_CROSTAGE";

		// Token: 0x0400D0B8 RID: 53432
		[Token(Token = "0x400D0B8")]
		public const string RL05_REDRAW_SLOTS_GOOD = "ON_ROGUELIKE_DRAWLOTS_GOOD";

		// Token: 0x0400D0B9 RID: 53433
		[Token(Token = "0x400D0B9")]
		public const string RL05_REDRAW_SLOTS_NORMAL = "ON_ROGUELIKE_DRAWLOTS_NORMAL";

		// Token: 0x0400D0BA RID: 53434
		[Token(Token = "0x400D0BA")]
		public const string RL05_REDRAW_SLOTS_BAD = "ON_ROGUELIKE_DRAWLOTS_BAD";

		// Token: 0x0400D0BB RID: 53435
		[Token(Token = "0x400D0BB")]
		public const string RL05_EVENT_DRAW_SLOTS_GOOD = "ON_ROGUELIKE_DRAWLOTS_SUCCESS";

		// Token: 0x0400D0BC RID: 53436
		[Token(Token = "0x400D0BC")]
		public const string RL05_EVENT_DRAW_SLOTS_NORMAL = "ON_ROGUELIKE_DRAWLOTS_UNKNOWN";

		// Token: 0x0400D0BD RID: 53437
		[Token(Token = "0x400D0BD")]
		public const string RL05_EVENT_DRAW_SLOTS_BAD = "ON_ROGUELIKE_DRAWLOTS_FAILURE";

		// Token: 0x0400D0BE RID: 53438
		[Token(Token = "0x400D0BE")]
		public const string RL05_SWAP_COPPER = "ON_ROGUELIKE_DRAWLOTS_CHANGE";

		// Token: 0x0400D0BF RID: 53439
		[Token(Token = "0x400D0BF")]
		public const string RL05_REDUCE_STEP_NUM = "ON_ROGUELIKE_CANDLE_REDUCE";

		// Token: 0x0400D0C0 RID: 53440
		[Token(Token = "0x400D0C0")]
		public const string RL05_TRANSITION_WRATH = "ON_ROGUELIKE_SKYCROSTAGE_DEBUFF";

		// Token: 0x0400D0C1 RID: 53441
		[Token(Token = "0x400D0C1")]
		public const string RL05_TRANSITION = "ON_ROGUELIKE_SKYCROSTAGE";

		// Token: 0x0400D0C2 RID: 53442
		[Token(Token = "0x400D0C2")]
		public const string RL05_SKY_STEP_OVER = "ON_ROGUELIKE_SKYPOPUP";

		// Token: 0x0400D0C3 RID: 53443
		[Token(Token = "0x400D0C3")]
		public const string RL05_GET_WRATH_VARIATION = "RL05_GET_WRATH_VARIATION";

		// Token: 0x0400D0C4 RID: 53444
		[Token(Token = "0x400D0C4")]
		public const string CLIMB_TOWER_LOADED = "ON_CLIMB_TOWER_LOADED";

		// Token: 0x0400D0C5 RID: 53445
		[Token(Token = "0x400D0C5")]
		public const string ON_POTENTIAL_MAX = "ON_POTENTIALMAX";

		// Token: 0x0400D0C6 RID: 53446
		[Token(Token = "0x400D0C6")]
		public const string ON_GAIN_SKIN_PART1 = "ON_GAIN_SKIN_PART1";

		// Token: 0x0400D0C7 RID: 53447
		[Token(Token = "0x400D0C7")]
		public const string ON_GAIN_SKIN_PART2 = "ON_GAIN_SKIN_PART2";

		// Token: 0x0400D0C8 RID: 53448
		[Token(Token = "0x400D0C8")]
		public const string ACT17SIDE_CLOCK = "ON_ACT17SIDE_CLOCK";

		// Token: 0x0400D0C9 RID: 53449
		[Token(Token = "0x400D0C9")]
		public const string ACT17SIDE_ENTER = "ON_ACT17SIDE_ENTER";

		// Token: 0x0400D0CA RID: 53450
		[Token(Token = "0x400D0CA")]
		public const string FILE_UNLOCKED = "ON_FILEUNLOCK";

		// Token: 0x0400D0CB RID: 53451
		[Token(Token = "0x400D0CB")]
		public const string FILE_UNSEAL = "ON_FILEUNSEAL";

		// Token: 0x0400D0CC RID: 53452
		[Token(Token = "0x400D0CC")]
		public const string ON_GEARLOCK = "ON_GEARLOCK";

		// Token: 0x0400D0CD RID: 53453
		[Token(Token = "0x400D0CD")]
		public const string ON_GEAR = "ON_GEAR";

		// Token: 0x0400D0CE RID: 53454
		[Token(Token = "0x400D0CE")]
		public const string ACT21SIDE_CHARENTRY = "ON_ACT21SIDE_CHARENTRY";

		// Token: 0x0400D0CF RID: 53455
		[Token(Token = "0x400D0CF")]
		public const string DYN_ENTRANCE_START = "ON_DYNENTRANCE_START";

		// Token: 0x0400D0D0 RID: 53456
		[Token(Token = "0x400D0D0")]
		public const string ACT24SIDE_ON_EAT_ENTRY_MEOW = "ON_ACT24SIDE_MEOW";

		// Token: 0x0400D0D1 RID: 53457
		[Token(Token = "0x400D0D1")]
		public const string ACT24SIDE_ON_EAT_BOWL_DROP = "ON_ACT24SIDE_BOWLDROP";

		// Token: 0x0400D0D2 RID: 53458
		[Token(Token = "0x400D0D2")]
		public const string ACT24SIDE_ALCHEMY = "ON_ACT24SIDE_ALCHEMY";

		// Token: 0x0400D0D3 RID: 53459
		[Token(Token = "0x400D0D3")]
		public const string ACT24SIDE_ALCHEMY_CONFIRM = "ON_ACT24SIDE_CONFIRM";

		// Token: 0x0400D0D4 RID: 53460
		[Token(Token = "0x400D0D4")]
		public const string ACT24SIDE_ALCHEMY_TOTEM_SHOW = "ON_ACT24SIDE_TOTEM";

		// Token: 0x0400D0D5 RID: 53461
		[Token(Token = "0x400D0D5")]
		public const string ACT24SIDE_BOX_OPEN = "ON_ACT24SIDE_BOXOPEN";

		// Token: 0x0400D0D6 RID: 53462
		[Token(Token = "0x400D0D6")]
		public const string ACT24SIDE_TOOL_SELECT = "ON_ACT24SIDE_TOOLSELECT";

		// Token: 0x0400D0D7 RID: 53463
		[Token(Token = "0x400D0D7")]
		public const string ACT24SIDE_TOOL_UNSELECT = "ON_ACT24SIDE_TOOLUNSELECT";

		// Token: 0x0400D0D8 RID: 53464
		[Token(Token = "0x400D0D8")]
		public const string ACT24SIDE_PAPERFLIP = "ON_ACT24SIDE_PAPERFLIP";

		// Token: 0x0400D0D9 RID: 53465
		[Token(Token = "0x400D0D9")]
		public const string ACT25SIDE_RESEARCH_AREA_SWITCH = "ON_ACT25SIDE_TABSWITCHRH";

		// Token: 0x0400D0DA RID: 53466
		[Token(Token = "0x400D0DA")]
		public const string CRISIS_V2_ON_SETTLEMENT_START = "ON_CRISISV2_RESULT";

		// Token: 0x0400D0DB RID: 53467
		[Token(Token = "0x400D0DB")]
		public const string CRISIS_V2_ON_SETTLEMENT_NORMAL_ANIM = "ON_CRISISV2_SETTLEMENT";

		// Token: 0x0400D0DC RID: 53468
		[Token(Token = "0x400D0DC")]
		public const string CRISIS_V2_ON_SETTLEMENT_NEW_RECORD = "ON_CRISISV2_NEWRECORD";

		// Token: 0x0400D0DD RID: 53469
		[Token(Token = "0x400D0DD")]
		public const string ACT42D0_ON_GNRTING = "ON_ACT42DO_GNRTING";

		// Token: 0x0400D0DE RID: 53470
		[Token(Token = "0x400D0DE")]
		public const string ACT42D0_ON_TESTDT = "ON_ACT42DO_TESTDT";

		// Token: 0x0400D0DF RID: 53471
		[Token(Token = "0x400D0DF")]
		public const string ACT42D0_ON_SIMUL_1 = "ON_ACT42DO_SIMULTRLTY";

		// Token: 0x0400D0E0 RID: 53472
		[Token(Token = "0x400D0E0")]
		public const string ACT42D0_ON_SIMUL_2 = "ON_ACT42DO_SIMULTRLTYH";

		// Token: 0x0400D0E1 RID: 53473
		[Token(Token = "0x400D0E1")]
		public const string ACT42D0_ON_SIMUL_3 = "ON_ACT42DO_SIMULTRLTYHUP";

		// Token: 0x0400D0E2 RID: 53474
		[Token(Token = "0x400D0E2")]
		public const string ACT42D0_ON_DPBGRESULT = "ON_ACT42DO_DPBGRESULT";

		// Token: 0x0400D0E3 RID: 53475
		[Token(Token = "0x400D0E3")]
		public const string ACT27SIDE_ON_STOCK_INTERFACE = "ON_ACT27SIDE_STOCKINTERFACE";

		// Token: 0x0400D0E4 RID: 53476
		[Token(Token = "0x400D0E4")]
		public const string ACT27SIDE_ON_ASK_INFORMATION = "ON_ACT27SIDE_ASKINFORMATION";

		// Token: 0x0400D0E5 RID: 53477
		[Token(Token = "0x400D0E5")]
		public const string ACT27SIDE_ON_PURCHS_RESULT = "ON_ACT27SIDE_PURCHSRESULT";

		// Token: 0x0400D0E6 RID: 53478
		[Token(Token = "0x400D0E6")]
		public const string ACT27SIDE_ON_PRGRSS_BR_UP = "ON_ACT27SIDE_PRGRSSBRUP";

		// Token: 0x0400D0E7 RID: 53479
		[Token(Token = "0x400D0E7")]
		public const string ACT27SIDE_ON_NEGATIV_EXPENSE = "ON_ACT27SIDE_NEGATIVEXPENSE";

		// Token: 0x0400D0E8 RID: 53480
		[Token(Token = "0x400D0E8")]
		public const string ACT27SIDE_ON_SALE_INTERFACE = "ON_ACT27SIDE_SALEINTERFACE";

		// Token: 0x0400D0E9 RID: 53481
		[Token(Token = "0x400D0E9")]
		public const string ACT27SIDE_ON_SALE_INTERFACE_NEXT = "ON_ACT27SIDE_SALEINTERFACENEXT";

		// Token: 0x0400D0EA RID: 53482
		[Token(Token = "0x400D0EA")]
		public const string ACT27SIDE_ON_ASK_PPL_INFORMATION = "ON_ACT27SIDE_ASKPPLINFORMATION";

		// Token: 0x0400D0EB RID: 53483
		[Token(Token = "0x400D0EB")]
		public const string ACT27SIDE_ON_PRGRSS_BR_LIQUID = "ON_ACT27SIDE_PRGRSSBRLIQUID";

		// Token: 0x0400D0EC RID: 53484
		[Token(Token = "0x400D0EC")]
		public const string ACT27SIDE_ON_POSITIVE_INCOME = "ON_ACT27SIDE_POSITIVEINCOME";

		// Token: 0x0400D0ED RID: 53485
		[Token(Token = "0x400D0ED")]
		public const string ACT27SIDE_ON_NETINCOME = "ON_ACT27SIDE_NETINCOME";

		// Token: 0x0400D0EE RID: 53486
		[Token(Token = "0x400D0EE")]
		public const string ACT29SIDE_ACT_ENTRY = "ON_ACT29SIDE_LOADLT";

		// Token: 0x0400D0EF RID: 53487
		[Token(Token = "0x400D0EF")]
		public const string ACT29SIDE_ON_HOME_ENTER = "ON_ACT29SIDE_SUBFDN";

		// Token: 0x0400D0F0 RID: 53488
		[Token(Token = "0x400D0F0")]
		public const string ACT29SIDE_ON_MAJOR_UNLOCK = "ON_ACT29SIDE_IMPRTNVSTG";

		// Token: 0x0400D0F1 RID: 53489
		[Token(Token = "0x400D0F1")]
		public const string ACT29SIDE_ON_ENTER_PRODUCT = "ON_ACT29SIDE_INTRFCPPR";

		// Token: 0x0400D0F2 RID: 53490
		[Token(Token = "0x400D0F2")]
		public const string ACT29SIDE_ON_SELECT_ENOUGH_FRAG = "ON_ACT29SIDE_MNDLCKPPR";

		// Token: 0x0400D0F3 RID: 53491
		[Token(Token = "0x400D0F3")]
		public const string ACT29SIDE_ON_CLEAR_FRAG = "ON_ACT29SIDE_SGNLRCYCL";

		// Token: 0x0400D0F4 RID: 53492
		[Token(Token = "0x400D0F4")]
		public const string ACT29SIDE_ON_TRANS_TO_SELECT_ORCHE = "ON_ACT29SIDE_MNDBND";

		// Token: 0x0400D0F5 RID: 53493
		[Token(Token = "0x400D0F5")]
		public const string ACT29SIDE_ON_SELECT_ORCHE = "ON_ACT29SIDE_DSRSWTCH";

		// Token: 0x0400D0F6 RID: 53494
		[Token(Token = "0x400D0F6")]
		public const string ACT29SIDE_ON_PRODUCT_MUSIC = "ON_ACT29SIDE_DSRINSGHT";

		// Token: 0x0400D0F7 RID: 53495
		[Token(Token = "0x400D0F7")]
		public const string ACT29SIDE_ON_PRODUCT_CONFIRM_ENTER = "ON_ACT29SIDE_SYNTHCPRDCT";

		// Token: 0x0400D0F8 RID: 53496
		[Token(Token = "0x400D0F8")]
		public const string ACT29SIDE_ON_OPEN_ORCHE = "ON_ACT29SIDE_OPNRCHSTRT";

		// Token: 0x0400D0F9 RID: 53497
		[Token(Token = "0x400D0F9")]
		public const string ACT29SIDE_ON_CLOSE_ORCHE = "ON_ACT29SIDE_CLSORCHSTRT";

		// Token: 0x0400D0FA RID: 53498
		[Token(Token = "0x400D0FA")]
		public const string ACT29SIDE_ON_CHAT_SUCC = "ON_ACT29SIDE_EMTNLMCH";

		// Token: 0x0400D0FB RID: 53499
		[Token(Token = "0x400D0FB")]
		public const string ACT29SIDE_ON_CHAT_FAIL = "ON_ACT29SIDE_EMTNLDSMCH";

		// Token: 0x0400D0FC RID: 53500
		[Token(Token = "0x400D0FC")]
		public const string ACT29SIDE_ON_CHAT_RARE = "ON_ACT29SIDE_EMTNLSPCL";

		// Token: 0x0400D0FD RID: 53501
		[Token(Token = "0x400D0FD")]
		public const string ACT29SIDE_ON_CHAT_TIP = "ON_ACT29SIDE_EMTNLCLU";

		// Token: 0x0400D0FE RID: 53502
		[Token(Token = "0x400D0FE")]
		public const string ACT29SIDE_ON_SELECT_FRAG = "ON_ACT29SIDE_INSTSGN";

		// Token: 0x0400D0FF RID: 53503
		[Token(Token = "0x400D0FF")]
		public const string CROSS_APP_SHARE_SHRPHOTO = "ON_SHARE_SHRPHOTO";

		// Token: 0x0400D100 RID: 53504
		[Token(Token = "0x400D100")]
		public const string SANDBOX_V2_RIFT_GENERATE_PARAM = "ON_SANDBOX_V2_MISTYGENERATE";

		// Token: 0x0400D101 RID: 53505
		[Token(Token = "0x400D101")]
		public const string SANDBOX_V2_RIFT_SETTLE = "ON_SANDBOX_V2_MISTYFINISH";

		// Token: 0x0400D102 RID: 53506
		[Token(Token = "0x400D102")]
		public const string SANDBOX_V2_FOCUS_NODE = "ON_SANDBOX_FOCUSPUSH";

		// Token: 0x0400D103 RID: 53507
		[Token(Token = "0x400D103")]
		public const string SANDBOX_V2_BATTLE_COLLECT = "SANDBOX_V2_BATTLE_COLLECT";

		// Token: 0x0400D104 RID: 53508
		[Token(Token = "0x400D104")]
		public const string SANDBOX_V2_BATTLE_GIVEUP = "SANDBOX_V2_BATTLE_GIVEUP";

		// Token: 0x0400D105 RID: 53509
		[Token(Token = "0x400D105")]
		public const string SANDBOX_V2_BATTLE_GACHA = "SANDBOX_V2_BATTLE_GACHA";

		// Token: 0x0400D106 RID: 53510
		[Token(Token = "0x400D106")]
		public const string SANDBOX_V2_BATTLE_HOME_DESTORYED = "ON_SANDBOX_V2_GRISNDAMAGE";

		// Token: 0x0400D107 RID: 53511
		[Token(Token = "0x400D107")]
		public const string SANDBOX_V2_CONSTRUCT_REPAIR = "ON_SANDBOX_V2_BUILDINGREPAIR";

		// Token: 0x0400D108 RID: 53512
		[Token(Token = "0x400D108")]
		public const string SANDBOX_V2_CONSTRUCT_WITHDRAW = "ON_SANDBOX_V2_BUILDINGCANCEL";

		// Token: 0x0400D109 RID: 53513
		[Token(Token = "0x400D109")]
		public const string SANDBOX_V2_BUILDMDLOAD = "ON_SANDBOX_V2_BUILDMDLOAD";

		// Token: 0x0400D10A RID: 53514
		[Token(Token = "0x400D10A")]
		public const string SANDBOX_V2_DRINK_BOTTLE_CHANGE = "ON_SANDBOX_V2_CHANGEBOTTLE";

		// Token: 0x0400D10B RID: 53515
		[Token(Token = "0x400D10B")]
		public const string SANDBOX_V2_COOK_DISH_MIX_NORMAL = "ON_SANDBOX_V2_DISHMIXNORMAL";

		// Token: 0x0400D10C RID: 53516
		[Token(Token = "0x400D10C")]
		public const string SANDBOX_V2_COOK_DISH_MIX_SPECIAL = "ON_SANDBOX_V2_DISHMIXSPECIAL";

		// Token: 0x0400D10D RID: 53517
		[Token(Token = "0x400D10D")]
		public const string SANDBOX_V2_RECIPE_MASTERY = "ON_SANDBOX_V2_FINDNEWRECIPE";

		// Token: 0x0400D10E RID: 53518
		[Token(Token = "0x400D10E")]
		public const string SANDBOX_V2_ON_SANDBOX_MAP = "ON_SANDBOX_MAP";

		// Token: 0x0400D10F RID: 53519
		[Token(Token = "0x400D10F")]
		public const string SANDBOX_V2_ON_ARCHIVE_GRADE = "ON_SANDBOX_V2_ARCHIVEGRADE";

		// Token: 0x0400D110 RID: 53520
		[Token(Token = "0x400D110")]
		public const string SANDBOX_V2_ON_ARCHIVE_CONFIRM = "ON_SANDBOX_V2_ARCHIVECONFIRM";

		// Token: 0x0400D111 RID: 53521
		[Token(Token = "0x400D111")]
		public const string SANDBOX_V2_ON_ARCHIVE_READ = "ON_SANDBOX_V2_ARCHIVEREAD";

		// Token: 0x0400D112 RID: 53522
		[Token(Token = "0x400D112")]
		public const string SANDBOX_V2_ON_GEAR = "ON_SANDBOX_GEAR";

		// Token: 0x0400D113 RID: 53523
		[Token(Token = "0x400D113")]
		public const string SANDBOX_V2_HOME_ANIM_START = "ON_SANDBOX_V2_HOMEPAGENTER";

		// Token: 0x0400D114 RID: 53524
		[Token(Token = "0x400D114")]
		public const string SANDBOX_V2_MAPUNFOLD = "ON_SANDBOX_MAPUNFOLD";

		// Token: 0x0400D115 RID: 53525
		[Token(Token = "0x400D115")]
		public const string SANDBOX_V2_GRISNUPGRADE = "ON_SANDBOX_V2_GRISNUPGRADE";

		// Token: 0x0400D116 RID: 53526
		[Token(Token = "0x400D116")]
		public const string SANDBOX_V2_SUPPLY_BEAN_FILL = "ON_SANDBOX_V2_ENERGYBLOCKFILL";

		// Token: 0x0400D117 RID: 53527
		[Token(Token = "0x400D117")]
		public const string SANDBOX_V2_ON_BASEMENT_SHOW_NORMAL = "ON_SANDBOX_V2_STATIONENTER";

		// Token: 0x0400D118 RID: 53528
		[Token(Token = "0x400D118")]
		public const string SANDBOX_V2_ON_BASEMENT_SHOW_ENEMYRUSH = "ON_SANDBOX_V2_STATIONENTERBAD";

		// Token: 0x0400D119 RID: 53529
		[Token(Token = "0x400D119")]
		public const string SANDBOX_V2_ON_NODE_UNLOCK = "ON_SANDBOX_V2_POINTUNLOCK";

		// Token: 0x0400D11A RID: 53530
		[Token(Token = "0x400D11A")]
		public const string SANDBOX_V2_DUNGEON_FORCE_PUSH = "ON_SANDBOX_FOCUSPUSH";

		// Token: 0x0400D11B RID: 53531
		[Token(Token = "0x400D11B")]
		public const string SANDBOX_V2_DUNGEON_SEASON_DRY = "ON_SANDBOX_V2_DRYSEASONENTER";

		// Token: 0x0400D11C RID: 53532
		[Token(Token = "0x400D11C")]
		public const string SANDBOX_V2_DUNGEON_SEASON_RAINY = "ON_SANDBOX_V2_RAINSEASONENTER";

		// Token: 0x0400D11D RID: 53533
		[Token(Token = "0x400D11D")]
		public const string SANDBOX_V2_MAP_UNLOCK_BANNER = "ON_SANDBOX_V2_MAPUNLOCK";

		// Token: 0x0400D11E RID: 53534
		[Token(Token = "0x400D11E")]
		public const string SANDBOX_V2_MISSION_FINISH_BANNER = "ON_SANDBOX_V2_MISSIONFINISH";

		// Token: 0x0400D11F RID: 53535
		[Token(Token = "0x400D11F")]
		public const string SANDBOX_V2_MISSION_FAIL_BANNER = "ON_SANDBOX_V2_MISSIONFAIL";

		// Token: 0x0400D120 RID: 53536
		[Token(Token = "0x400D120")]
		public const string SANDBOX_V2_MISSION_START_BANNER = "ON_SANDBOX_V2_MISSIONSTART";

		// Token: 0x0400D121 RID: 53537
		[Token(Token = "0x400D121")]
		public const string FIFTH_ANNIV_MAINLINE_LOG_BUBBLE = "ON_MAINLINE_EXPLORE_POPUP";

		// Token: 0x0400D122 RID: 53538
		[Token(Token = "0x400D122")]
		public const string FIFTH_ANNIV_MAINLINE_LOG_SUCCESS = "ON_MAINLINE_EXPLORE_MISSIONSUCCESS";

		// Token: 0x0400D123 RID: 53539
		[Token(Token = "0x400D123")]
		public const string FIFTH_ANNIV_MAINLINE_LOG_FAIL = "ON_MAINLINE_EXPLORE_MISSIONFAIL";

		// Token: 0x0400D124 RID: 53540
		[Token(Token = "0x400D124")]
		public const string FIFTH_ANNIV_SELECT_SQUAD = "ON_MAINLINE_EXPLORE_SELECTSQUAD";

		// Token: 0x0400D125 RID: 53541
		[Token(Token = "0x400D125")]
		public const string FIFTH_ANNIV_PASS_NORMAL_CHECKPOINT = "ON_MAINLINE_EXPLORE_SHOWSQUAD";

		// Token: 0x0400D126 RID: 53542
		[Token(Token = "0x400D126")]
		public const string FIFTH_ANNIV_FAIL_CHECKPOINT = "ON_MAINLINE_EXPLORE_LOSECONTACT";

		// Token: 0x0400D127 RID: 53543
		[Token(Token = "0x400D127")]
		public const string FIFTH_ANNIV_WIN_ENDING = "ON_MAINLINE_EXPLORE_FINALPOINT";

		// Token: 0x0400D128 RID: 53544
		[Token(Token = "0x400D128")]
		public const string FIFTH_ANNIV_WIN_ENDING_EXPAND = "ON_MAINLINE_EXPLORE_ENDING";

		// Token: 0x0400D129 RID: 53545
		[Token(Token = "0x400D129")]
		public const string FIFTH_ANNIV_MAINLINE_MAPIN = "ON_MAINLINE_EXPLORE_MAPIN";

		// Token: 0x0400D12A RID: 53546
		[Token(Token = "0x400D12A")]
		public const string FIFTH_ANNIV_MAINLINE_ROUTE_UPDATE = "ON_MAINLINE_EXPLORE_ROUTEUPDATE";

		// Token: 0x0400D12B RID: 53547
		[Token(Token = "0x400D12B")]
		public const string CARVING_SPECIAL_DIALOGUE_POPUP = "ON_ACT35SIDE_SPECIALPOPUP";

		// Token: 0x0400D12C RID: 53548
		[Token(Token = "0x400D12C")]
		public const string CARVING_SP_MISSION = "ON_ACT35SIDE_SPMISSION";

		// Token: 0x0400D12D RID: 53549
		[Token(Token = "0x400D12D")]
		public const string CARVING_SP_MISSION_FINISH = "ON_ACT35SIDE_SPMSIONFINISH";

		// Token: 0x0400D12E RID: 53550
		[Token(Token = "0x400D12E")]
		public const string CARVING_SP_MISSION_PROGRESS_CHANGE = "ON_ACT35SIDE_PROGRESSCHANGE";

		// Token: 0x0400D12F RID: 53551
		[Token(Token = "0x400D12F")]
		public const string CARVING_ROUND_SUCCESS = "ON_ACT35SIDE_ROUNDSUCCESS";

		// Token: 0x0400D130 RID: 53552
		[Token(Token = "0x400D130")]
		public const string CARVING_ROUND_FAIL = "ON_ACT35SIDE_ROUNDFAIL";

		// Token: 0x0400D131 RID: 53553
		[Token(Token = "0x400D131")]
		public const string CARVING_ROUND_LEVEL_CLEAR = "ON_ACT35SIDE_LEVELCLEAR";

		// Token: 0x0400D132 RID: 53554
		[Token(Token = "0x400D132")]
		public const string CARVING_SETTLE_RESULT = "ON_ACT35SIDE_FINALRESULT";

		// Token: 0x0400D133 RID: 53555
		[Token(Token = "0x400D133")]
		public const string CARVING_TOAST = "ON_ACT35SIDE_TOAST";

		// Token: 0x0400D134 RID: 53556
		[Token(Token = "0x400D134")]
		public const string CARVING_MODULESWITCH = "ON_ACT35SIDE_MODULESWITCH";

		// Token: 0x0400D135 RID: 53557
		[Token(Token = "0x400D135")]
		public const string CARVING_CARDIN = "ON_ACT35SIDE_CARDIN";

		// Token: 0x0400D136 RID: 53558
		[Token(Token = "0x400D136")]
		public const string CARVING_PURCHASE = "ON_ACT35SIDE_PURCHASE";

		// Token: 0x0400D137 RID: 53559
		[Token(Token = "0x400D137")]
		public const string CARVING_PURCHASESLOT = "ON_ACT35SIDE_PURCHASESLOT";

		// Token: 0x0400D138 RID: 53560
		[Token(Token = "0x400D138")]
		public const string CARVING_REFRESH = "ON_ACT35SIDE_REFRESH";

		// Token: 0x0400D139 RID: 53561
		[Token(Token = "0x400D139")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<string> CARVING_CARDBOUNCE_LIST;

		// Token: 0x0400D13A RID: 53562
		[Token(Token = "0x400D13A")]
		public const string CARVING_HOME_ENTER = "ON_ACT35SIDE_PAGEIN";

		// Token: 0x0400D13B RID: 53563
		[Token(Token = "0x400D13B")]
		public const string ON_CARVING_LOADED = "ON_CARVING_LOADED";

		// Token: 0x0400D13C RID: 53564
		[Token(Token = "0x400D13C")]
		public const string ACT36SIDE_HANDBOOK = "ON_ACT36SIDE_SKETCHBOOK";

		// Token: 0x0400D13D RID: 53565
		[Token(Token = "0x400D13D")]
		public const string ACT36SIDE_HANDBOOK_COMPLETE = "ON_ACT36SIDE_SKETCHBOOKDONE";

		// Token: 0x0400D13E RID: 53566
		[Token(Token = "0x400D13E")]
		public const string ACT36SIDE_ZONE_NORMAL_GEAR_LOCK = "ON_ACT36SIDE_MAPSWITCH";

		// Token: 0x0400D13F RID: 53567
		[Token(Token = "0x400D13F")]
		public const string FIREWORK_PUZZLE_COMPLETE = "ON_ACT38SIDE_ACCOMPLISH";

		// Token: 0x0400D140 RID: 53568
		[Token(Token = "0x400D140")]
		public const string FIREWORK_PUZZLE_HINT = "ON_ACT38SIDE_DAGGER";

		// Token: 0x0400D141 RID: 53569
		[Token(Token = "0x400D141")]
		public const string FIREWORK_PUZZLE_LIGHT = "ON_ACT38SIDE_CORRECT";

		// Token: 0x0400D142 RID: 53570
		[Token(Token = "0x400D142")]
		public const string FIREWORK_SELECT_ANIMAL_SHOW = "ON_FIREWORK_SWITCHOPTION";

		// Token: 0x0400D143 RID: 53571
		[Token(Token = "0x400D143")]
		public const string FIREWORK_CRAFT_ANIMAL_ICON_SWITCH = "ON_FIREWORK_SWITCHTYPE";

		// Token: 0x0400D144 RID: 53572
		[Token(Token = "0x400D144")]
		public const string FIREWORK_SELECT_ANIMAL_EQUIPED = "ON_FIREWORK_SWITCHBUFF";

		// Token: 0x0400D145 RID: 53573
		[Token(Token = "0x400D145")]
		public const string ON_ACT1AUTOCHESS_START = "ON_ACT1AUTOCHESS_START";

		// Token: 0x0400D146 RID: 53574
		[Token(Token = "0x400D146")]
		public const string ON_ACT1AUTOCHESS_SETTLEMENT_TEAM = "ON_ACT1AUTOCHESS_SETTLEMENT_TEAM";

		// Token: 0x0400D147 RID: 53575
		[Token(Token = "0x400D147")]
		public const string ON_ACT1AUTOCHESS_GOODEVALUATION = "ON_ACT1AUTOCHESS_GOODEVALUATION";

		// Token: 0x0400D148 RID: 53576
		[Token(Token = "0x400D148")]
		public const string ON_ACT1AUTOCHESS_MATCH_SUCCEED = "ON_ACT1AUTOCHESS_MATCH_SUCCEED";

		// Token: 0x0400D149 RID: 53577
		[Token(Token = "0x400D149")]
		public const string ON_ACT1AUTOCHESS_MATCH_FAIL = "ON_ACT1AUTOCHESS_MATCH_FAIL";

		// Token: 0x0400D14A RID: 53578
		[Token(Token = "0x400D14A")]
		public const string ON_ACT1AUTOCHESS_PLAYER_JOINROOM = "ON_ACT1AUTOCHESS_PLAYER_JOINROOM";

		// Token: 0x0400D14B RID: 53579
		[Token(Token = "0x400D14B")]
		public const string ON_ACT1AUTOCHESS_PLAYER_READY = "ON_ACT1AUTOCHESS_PLAYER_READY";

		// Token: 0x0400D14C RID: 53580
		[Token(Token = "0x400D14C")]
		public const string ON_ACT1AUTOCHESS_STRATEGY = "ON_ACT1AUTOCHESS_STRATEGY";

		// Token: 0x0400D14D RID: 53581
		[Token(Token = "0x400D14D")]
		public const string ON_ACT1AUTOCHESS_COUNTDOWN = "ON_ACT1AUTOCHESS_COUNTDOWN";

		// Token: 0x0400D14E RID: 53582
		[Token(Token = "0x400D14E")]
		public const string ON_ACT1AUTOCHESS_SETTLEMENT_FAIL = "ON_ACT1AUTOCHESS_SETTLEMENT_FAIL";

		// Token: 0x0400D14F RID: 53583
		[Token(Token = "0x400D14F")]
		public const string ON_ACT1AUTOCHESS_SETTLEMENT_SUCCEED = "ON_ACT1AUTOCHESS_SETTLEMENT_SUCCEED";

		// Token: 0x0400D150 RID: 53584
		[Token(Token = "0x400D150")]
		public const string ON_ACT1AUTOCHESS_SETTLEMENT_BOSSSIGN = "ON_ACT1AUTOCHESS_SETTLEMENT_BOSSSIGN";

		// Token: 0x0400D151 RID: 53585
		[Token(Token = "0x400D151")]
		public const string ON_ACT1AUTOCHESS_SHOP_UPGRADE = "ON_ACT1AUTOCHESS_SHOP_UPGRADE";

		// Token: 0x0400D152 RID: 53586
		[Token(Token = "0x400D152")]
		public const string ON_ACT1AUTOCHESS_SHOP_LOCK = "ON_ACT1AUTOCHESS_SHOP_LOCK";

		// Token: 0x0400D153 RID: 53587
		[Token(Token = "0x400D153")]
		public const string ON_ACT1AUTOCHESS_GETMONEY = "ON_ACT1AUTOCHESS_GETMONEY";

		// Token: 0x0400D154 RID: 53588
		[Token(Token = "0x400D154")]
		public const string ON_ACT1AUTOCHESS_BROADCASTHINT = "ON_ACT1AUTOCHESS_BROADCASTHINT";

		// Token: 0x0400D155 RID: 53589
		[Token(Token = "0x400D155")]
		public const string ON_ACT1AUTOCHESS_TARGET = "ON_ACT1AUTOCHESS_TARGET";

		// Token: 0x0400D156 RID: 53590
		[Token(Token = "0x400D156")]
		public const string ON_ACT1AUTOCHESS_REST = "ON_ACT1AUTOCHESS_REST";

		// Token: 0x0400D157 RID: 53591
		[Token(Token = "0x400D157")]
		public const string ON_ACT1AUTOCHESS_DEFENCE_START = "ON_ACT1AUTOCHESS_DEFENCE_START";

		// Token: 0x0400D158 RID: 53592
		[Token(Token = "0x400D158")]
		public const string ON_ACT1AUTOCHESS_BATTLESTART = "ON_ACT1AUTOCHESS_BATTLESTART";

		// Token: 0x0400D159 RID: 53593
		[Token(Token = "0x400D159")]
		public const string ON_ACT1AUTOCHESS_BATTLESTART_BOSS = "ON_ACT1AUTOCHESS_BATTLESTART_BOSS";

		// Token: 0x0400D15A RID: 53594
		[Token(Token = "0x400D15A")]
		public const string ON_ACT1AUTOCHESS_BOSSROUND_TEAM = "ON_ACT1AUTOCHESS_BOSSROUND_TEAM";

		// Token: 0x0400D15B RID: 53595
		[Token(Token = "0x400D15B")]
		public const string ON_ACT1AUTOCHESS_BOSSROUND_SINGLE = "ON_ACT1AUTOCHESS_BOSSROUND_SINGLE";

		// Token: 0x0400D15C RID: 53596
		[Token(Token = "0x400D15C")]
		public const string ON_ACT1AUTOCHESS_BOSSROUND_SECRET = "ON_ACT1AUTOCHESS_BOSSROUND_SECRET";

		// Token: 0x0400D15D RID: 53597
		[Token(Token = "0x400D15D")]
		public const string ON_ACT1AUTOCHESS_DEFENCE_UNITE = "ON_ACT1AUTOCHESS_DEFENCE_UNITE";

		// Token: 0x0400D15E RID: 53598
		[Token(Token = "0x400D15E")]
		public const string ON_ACT1AUTOCHESS_BATTLEOVER_REDUCE = "ON_ACT1AUTOCHESS_BATTLEOVER_REDUCE";

		// Token: 0x0400D15F RID: 53599
		[Token(Token = "0x400D15F")]
		public const string ON_ACT1AUTOCHESS_BATTLEOVER_NORMAL = "ON_ACT1AUTOCHESS_BATTLEOVER_NORMAL";

		// Token: 0x0400D160 RID: 53600
		[Token(Token = "0x400D160")]
		public const string ON_ACT1AUTOCHESS_BATTLEOVER_NOREDUCE = "ON_ACT1AUTOCHESS_BATTLEOVER_NOREDUCE";

		// Token: 0x0400D161 RID: 53601
		[Token(Token = "0x400D161")]
		public const string ON_ACT1AUTOCHESS_GOFIRST = "ON_ACT1AUTOCHESS_GOFIRST";

		// Token: 0x0400D162 RID: 53602
		[Token(Token = "0x400D162")]
		public const string ON_ACT1AUTOCHESS_ROUNDSTART = "ON_ACT1AUTOCHESS_ROUNDSTART";

		// Token: 0x0400D163 RID: 53603
		[Token(Token = "0x400D163")]
		public const string ON_ACT1AUTOCHESS_KILLBOSS_ALL = "ON_ACT1AUTOCHESS_KILLBOSS_ALL";

		// Token: 0x0400D164 RID: 53604
		[Token(Token = "0x400D164")]
		public const string ON_ACT1AUTOCHESS_KILLBOSS = "ON_ACT1AUTOCHESS_KILLBOSS";

		// Token: 0x0400D165 RID: 53605
		[Token(Token = "0x400D165")]
		public const string ON_ACT1AUTOCHESS_KILLBOSS_NORMAL = "ON_ACT1AUTOCHESS_KILLBOSS_NORMAL";

		// Token: 0x0400D166 RID: 53606
		[Token(Token = "0x400D166")]
		public const string ON_ACT1AUTOCHESS_DISCONNECT = "ON_ACT1AUTOCHESS_DISCONNECT";

		// Token: 0x0400D167 RID: 53607
		[Token(Token = "0x400D167")]
		public const string ON_ACT1AUTOCHESS_YOURTURN_CIRCLE = "ON_ACT1AUTOCHESS_YOURTURN_CIRCLE";

		// Token: 0x0400D168 RID: 53608
		[Token(Token = "0x400D168")]
		public const string ON_ACT1AUTOCHESS_EMOJIDIALOGUE = "ON_ACT1AUTOCHESS_EMOJIDIALOGUE";

		// Token: 0x0400D169 RID: 53609
		[Token(Token = "0x400D169")]
		public const string ON_MULTIV3_LOADONLINE = "ON_MULTIV3_LOADONLINE";

		// Token: 0x0400D16A RID: 53610
		[Token(Token = "0x400D16A")]
		public const string ON_MULTIV3_UNLOCKOPTION = "ON_MULTIV3_UNLOCKOPTION";

		// Token: 0x0400D16B RID: 53611
		[Token(Token = "0x400D16B")]
		public const string ON_MULTIV3_PROJECTIONCLIP = "ON_MULTIV3_PROJECTIONCLIP";

		// Token: 0x0400D16C RID: 53612
		[Token(Token = "0x400D16C")]
		public const string ON_MULTIV3_TRANSITION = "ON_MULTIV3_TRANSITION";

		// Token: 0x0400D16D RID: 53613
		[Token(Token = "0x400D16D")]
		public const string ON_MULTIV3_COUNTSCOREOL = "ON_MULTIV3_COUNTSCOREOL";

		// Token: 0x0400D16E RID: 53614
		[Token(Token = "0x400D16E")]
		public const string ON_MULTIV3_SPECIALBOSSKILL = "ON_MULTIV3_SPECIALBOSSKILL";

		// Token: 0x0400D16F RID: 53615
		[Token(Token = "0x400D16F")]
		public const string ON_MULTIV3_RCVGOODEVALUATION = "ON_MULTIV3_RCVGOODEVALUATION";

		// Token: 0x0400D170 RID: 53616
		[Token(Token = "0x400D170")]
		public const string ON_MULTIV3_GOODEVALUATION = "ON_MULTIV3_GOODEVALUATION";

		// Token: 0x0400D171 RID: 53617
		[Token(Token = "0x400D171")]
		public const string ON_MULTIV3_CONTINUETEAM = "ON_MULTIV3_CONTINUETEAM";

		// Token: 0x0400D172 RID: 53618
		[Token(Token = "0x400D172")]
		public const string ON_MULTIV3_NEWPHOTO = "ON_MULTIV3_NEWPHOTO";

		// Token: 0x0400D173 RID: 53619
		[Token(Token = "0x400D173")]
		public const string ON_MULTIV3_GETREADY = "ON_MULTIV3_GETREADY";

		// Token: 0x0400D174 RID: 53620
		[Token(Token = "0x400D174")]
		public const string ON_MULTIV3_EMOJIDIALOGUE = "ON_MULTIV3_EMOJIDIALOGUE";

		// Token: 0x0400D175 RID: 53621
		[Token(Token = "0x400D175")]
		public const string ON_MULTIV3_TEMPORARYHELP = "ON_MULTIV3_TEMPORARYHELP";

		// Token: 0x0400D176 RID: 53622
		[Token(Token = "0x400D176")]
		public const string ON_MULTIV3_PREPARECOUNTDOWN = "ON_MULTIV3_PREPARECOUNTDOWN";

		// Token: 0x0400D177 RID: 53623
		[Token(Token = "0x400D177")]
		public const string ON_MULTIV3_COUNTDOWNSTART = "ON_MULTIV3_COUNTDOWNSTART";

		// Token: 0x0400D178 RID: 53624
		[Token(Token = "0x400D178")]
		public const string ON_MULTIV3_MATCHSUCCEED = "ON_MULTIV3_MATCHSUCCEED";

		// Token: 0x0400D179 RID: 53625
		[Token(Token = "0x400D179")]
		public const string ON_MULTIV3_MATCHCANCEL = "ON_MULTIV3_MATCHCANCEL";

		// Token: 0x0400D17A RID: 53626
		[Token(Token = "0x400D17A")]
		public const string ON_MULTIV3_MATCHFAIL = "ON_MULTIV3_MATCHFAIL";

		// Token: 0x0400D17B RID: 53627
		[Token(Token = "0x400D17B")]
		public const string ON_MULTIV3_UNPICK = "ON_MULTIV3_UNPICK";

		// Token: 0x0400D17C RID: 53628
		[Token(Token = "0x400D17C")]
		public const string ON_MULTIV3_PICK = "ON_MULTIV3_PICK";

		// Token: 0x0400D17D RID: 53629
		[Token(Token = "0x400D17D")]
		public const string ON_MULTIV3_GAMEOVER = "ON_MULTIV3_GAMEOVER";

		// Token: 0x0400D17E RID: 53630
		[Token(Token = "0x400D17E")]
		public const string ON_MULTIV3_PLAYERJOINROOM = "ON_MULTIV3_PLAYERJOINROOM";

		// Token: 0x0400D17F RID: 53631
		[Token(Token = "0x400D17F")]
		public const string ON_MULTIV3_LOADED = "ON_MULTIV3_LOADED";

		// Token: 0x0400D180 RID: 53632
		[Token(Token = "0x400D180")]
		public const string ACT6FUN_WINSETTLEMENT = "ON_ACT6FUN_WINSETTLEMENT";

		// Token: 0x0400D181 RID: 53633
		[Token(Token = "0x400D181")]
		public const string ACT6FUN_LOSESETTLEMENT = "ON_ACT6FUN_LOSESETTLEMENT";

		// Token: 0x0400D182 RID: 53634
		[Token(Token = "0x400D182")]
		public const string ACT7FUN_LOAD = "ON_ACT7FUN_LOAD";

		// Token: 0x0400D183 RID: 53635
		[Token(Token = "0x400D183")]
		public const string ACT7FUN_LOSESETTLEMENT = "ON_ACT7FUN_LOSESETTLEMENT";

		// Token: 0x0400D184 RID: 53636
		[Token(Token = "0x400D184")]
		public const string ACT7FUN_WINSETTLEMENT = "ON_ACT7FUN_WINSETTLEMENT";

		// Token: 0x0400D185 RID: 53637
		[Token(Token = "0x400D185")]
		public const string ACT7FUN_NEWS = "ON_ACT7FUN_NEWS";

		// Token: 0x0400D186 RID: 53638
		[Token(Token = "0x400D186")]
		public const string ACT7FUN_BIGWIN = "ON_ACT7FUN_BIGWIN";

		// Token: 0x0400D187 RID: 53639
		[Token(Token = "0x400D187")]
		public const string ENEMYDUEL_OPNE_MAIN_WINDOW = "ON_ENEMYDUEL_DQINTERFACELOAD";

		// Token: 0x0400D188 RID: 53640
		[Token(Token = "0x400D188")]
		public const string ENEMYDUEL_ROUND_END_SKIP = "ON_ENEMYDUEL_DQONLOOKER";

		// Token: 0x0400D189 RID: 53641
		[Token(Token = "0x400D189")]
		public const string ENEMYDUEL_ROUND_END_WIN = "ON_ENEMYDUEL_DQEARNCOIN";

		// Token: 0x0400D18A RID: 53642
		[Token(Token = "0x400D18A")]
		public const string ENEMYDUEL_ROUND_END_WIN_ALLIN = "ON_ENEMYDUEL_DQEARNCOINH";

		// Token: 0x0400D18B RID: 53643
		[Token(Token = "0x400D18B")]
		public const string ENEMYDUEL_ROUND_END_LOSE = "ON_ENEMYDUEL_DQLOSECOIN";

		// Token: 0x0400D18C RID: 53644
		[Token(Token = "0x400D18C")]
		public const string ENEMYDUEL_ROUND_END_LOSE_ALLIN = "ON_ENEMYDUEL_DQLOSECOINH";

		// Token: 0x0400D18D RID: 53645
		[Token(Token = "0x400D18D")]
		public const string ENEMYDUEL_ROUND_END_LOSE_STAND = "ON_ENEMYDUEL_DQDEFEAT";

		// Token: 0x0400D18E RID: 53646
		[Token(Token = "0x400D18E")]
		public const string ENEMYDUEL_ROUND_END_SHIELD = "ON_ENEMYDUEL_DQDEFEATSHIELD";

		// Token: 0x0400D18F RID: 53647
		[Token(Token = "0x400D18F")]
		public const string ENEMYDUEL_BATTLE_FINISH_DANCE = "ON_ENEMYDUEL_DQWINSETTLEMENT";

		// Token: 0x0400D190 RID: 53648
		[Token(Token = "0x400D190")]
		public const string ENEMYDUEL_PRIVATE_BET_COUNTDOWN = "ON_ENEMYDUEL_DQCOUNTDOWN";

		// Token: 0x0400D191 RID: 53649
		[Token(Token = "0x400D191")]
		public const string ENEMYDUEL_ENTRANCE_SHOW = "ON_ENEMYDUEL_DQSTARTSIGN";

		// Token: 0x0400D192 RID: 53650
		[Token(Token = "0x400D192")]
		public const string ACT1BREAK_BTSETTLEMENT = "ON_ACT1VECBV2_BTSETTLEMENT";

		// Token: 0x0400D193 RID: 53651
		[Token(Token = "0x400D193")]
		public const string ACT1BREAK_BTSPECIALSETTLEMENT = "ON_ACT1VECBV2_BTSPECIALSETTLEMENT";

		// Token: 0x0400D194 RID: 53652
		[Token(Token = "0x400D194")]
		public const string ACT1BREAK_BTDIFFICULTSETTLEMENT = "ON_ACT1VECBV2_BTDIFFICULTSETTLEMENT";

		// Token: 0x0400D195 RID: 53653
		[Token(Token = "0x400D195")]
		public const string ACT1BREAK_BTLOAD = "ON_ACT1VECBV2_BTLOAD";

		// Token: 0x0400D196 RID: 53654
		[Token(Token = "0x400D196")]
		public const string ACT1BREAK_BTSWITCHCORE = "ON_ACT1VECBV2_BTSWITCHCORE";

		// Token: 0x0400D197 RID: 53655
		[Token(Token = "0x400D197")]
		public const string ACT1BREAK_BTSWITCHFULL = "ON_ACT1VECBV2_BTSWITCHFULL";

		// Token: 0x0400D198 RID: 53656
		[Token(Token = "0x400D198")]
		public const string GUN_TASK_GUN_UNLOCK = "ON_ACT42SIDE_UNLOCK";

		// Token: 0x0400D199 RID: 53657
		[Token(Token = "0x400D199")]
		public const string GUN_TASK_GUN_SELECT = "ON_ACT42SIDE_HAND";

		// Token: 0x0400D19A RID: 53658
		[Token(Token = "0x400D19A")]
		public const string ON_SOCHAR_GETEXPERIENCE = "ON_SOCHAR_GETEXPERIENCE";

		// Token: 0x0400D19B RID: 53659
		[Token(Token = "0x400D19B")]
		public const string ON_SOCHAR_LV_UPGRADE = "ON_SOCHAR_CHARUPGRADE";

		// Token: 0x0400D19C RID: 53660
		[Token(Token = "0x400D19C")]
		public const string ON_SOCHAR_SKILL_UPGRADE = "ON_SOCHAR_SKILLUPGRADE";

		// Token: 0x0400D19D RID: 53661
		[Token(Token = "0x400D19D")]
		public const string INFORMANT_INSIGHT_RC = "ON_ACT44SIDE_ATTRIBUTEYELLOW_VIEW";

		// Token: 0x0400D19E RID: 53662
		[Token(Token = "0x400D19E")]
		public const string INFORMANT_INSIGHT_MAX = "ON_ACT44SIDE_ATTRIBUTERED_VIEW";

		// Token: 0x0400D19F RID: 53663
		[Token(Token = "0x400D19F")]
		public const string INFORMANT_INSIGHT_MIXED = "ON_ACT44SIDE_ATTRIBUTEBOTH_VIEW";

		// Token: 0x0400D1A0 RID: 53664
		[Token(Token = "0x400D1A0")]
		public const string INFORMANT_LOAD_INFOHOUSE = "ON_ACT44SIDE_LOADINFOHOUSE";

		// Token: 0x0400D1A1 RID: 53665
		[Token(Token = "0x400D1A1")]
		public const string INFORMANT_ATTRIBUTE_CHANGE = "ON_ACT44SIDE_ATTRIBUTE_CHANGE";

		// Token: 0x0400D1A2 RID: 53666
		[Token(Token = "0x400D1A2")]
		public const string INFORMANT_PATIENCE_WARNING = "ON_ACT44SIDE_WARNING";

		// Token: 0x0400D1A3 RID: 53667
		[Token(Token = "0x400D1A3")]
		public const string INFORMANT_SETTLE_CHECK_ENTRY = "ON_ACT44SIDE_WAITRESULT";

		// Token: 0x0400D1A4 RID: 53668
		[Token(Token = "0x400D1A4")]
		public const string INFORMANT_SETTLE_CHECK_FAIL = "ON_ACT44SIDE_MAKEMONEY_SMALL";

		// Token: 0x0400D1A5 RID: 53669
		[Token(Token = "0x400D1A5")]
		public const string INFORMANT_SETTLE_CHECK_SUCCESS = "ON_ACT44SIDE_MAKEMONEY_BIG";

		// Token: 0x0400D1A6 RID: 53670
		[Token(Token = "0x400D1A6")]
		public const string INFORMANT_SETTLE_POINT_PLAY = "ON_ACT44SIDE_INCOME";

		// Token: 0x0400D1A7 RID: 53671
		[Token(Token = "0x400D1A7")]
		public const string INFORMANT_OPEN_INSIGHT = "ON_ACT44SIDE_ATTRIBUTE_VIEW";

		// Token: 0x0400D1A8 RID: 53672
		[Token(Token = "0x400D1A8")]
		public const string INFORMANT_NO_PATIENCE = "ON_ACT44SIDE_WARNINGRED";

		// Token: 0x0400D1A9 RID: 53673
		[Token(Token = "0x400D1A9")]
		public const string ACT1VHALFIDLE_DEPOT_BUFF_UPGRADE = "ON_ACT1VHALFIDLE_UPGRADE";

		// Token: 0x0400D1AA RID: 53674
		[Token(Token = "0x400D1AA")]
		public const string ACT1VHALFIDLE_HARVEST = "ON_ACT1VHALFIDLE_GETRESOURCE";

		// Token: 0x0400D1AB RID: 53675
		[Token(Token = "0x400D1AB")]
		public const string ACT1VHALFIDLE_CHAR_UPGRADE = "ON_ACT1VHALFIDLE_DEVELOPMENT_UPGRADE";

		// Token: 0x0400D1AC RID: 53676
		[Token(Token = "0x400D1AC")]
		public const string ACT1VHALFIDLE_CHAR_UPGRADE_ELITE = "ON_ACT1VHALFIDLE_DEVELOPMENT_PHASE";

		// Token: 0x0400D1AD RID: 53677
		[Token(Token = "0x400D1AD")]
		public const string ACT1VHALFIDLE_CHAR_UPGRADE_LEVEL_MAX = "ON_ACT1VHALFIDLE_DEVELOPMENT_LEVELMAX";

		// Token: 0x0400D1AE RID: 53678
		[Token(Token = "0x400D1AE")]
		public const string ACT1VHALFIDLE_CHAR_UPGRADE_SKILL_RANK_MAX = "ON_ACT1VHALFIDLE_DEVELOPMENT_RANKMAX";

		// Token: 0x0400D1AF RID: 53679
		[Token(Token = "0x400D1AF")]
		public const string ACT1VHALFIDLE_TECH_TREE_NODE_UNLOCK = "ON_ACT1VHALFIDLE_TECHTREE_ON";

		// Token: 0x0400D1B0 RID: 53680
		[Token(Token = "0x400D1B0")]
		public const string ACT1VHALFIDLE_RECRUIT_TAB_SWITCH = "ON_ACT1VHALFIDLE_INTERFACE_SWITCH";

		// Token: 0x0400D1B1 RID: 53681
		[Token(Token = "0x400D1B1")]
		public const string ACT1VHALFIDLE_BATTLE_FINISH_CHAR_UPGRADE = "ON_ACT1VHALFIDLE_CHARUPGRADE";

		// Token: 0x0400D1B2 RID: 53682
		[Token(Token = "0x400D1B2")]
		public const string ON_ACT45SIDE_LETTER = "ON_ACT45SIDE_LETTER";

		// Token: 0x0400D1B3 RID: 53683
		[Token(Token = "0x400D1B3")]
		public const string ON_ACT45SIDE_CHEERCALL = "ON_ACT45SIDE_CHEERCALL";

		// Token: 0x0400D1B4 RID: 53684
		[Token(Token = "0x400D1B4")]
		public const string ON_ACT45SIDE_SPOTLIGHT = "ON_ACT45SIDE_SPOTLIGHT";

		// Token: 0x0400D1B5 RID: 53685
		[Token(Token = "0x400D1B5")]
		public const string ON_ACT45SIDE_CARDUNLOCK = "ON_ACT45SIDE_CARDUNLOCK";

		// Token: 0x0400D1B6 RID: 53686
		[Token(Token = "0x400D1B6")]
		public const string ON_ACT45SIDE_TRANSITION = "ON_ACT45SIDE_TRANSITION";

		// Token: 0x0400D1B7 RID: 53687
		[Token(Token = "0x400D1B7")]
		public const string ON_ACT45SIDE_ENTERLIVE = "ON_ACT45SIDE_ENTERLIVE";

		// Token: 0x0400D1B8 RID: 53688
		[Token(Token = "0x400D1B8")]
		public const string ON_ACT45SIDE_LARGEGEAR = "ON_ACT45SIDE_LARGEGEAR";

		// Token: 0x0400D1B9 RID: 53689
		[Token(Token = "0x400D1B9")]
		public const string ON_ACT45SIDE_CURTAINFALL = "ON_ACT45SIDE_CURTAINFALL";

		// Token: 0x0400D1BA RID: 53690
		[Token(Token = "0x400D1BA")]
		public const string MONOPOLY_BUFF_ACTIVE = "ON_ACT46SIDE_RESOURCEBUFF";

		// Token: 0x0400D1BB RID: 53691
		[Token(Token = "0x400D1BB")]
		public const string MONOPOLY_SHOW_PREVIEW_POS = "ON_ACT46SIDE_DIRECTIONPREVIEW";

		// Token: 0x0400D1BC RID: 53692
		[Token(Token = "0x400D1BC")]
		public const string MONOPOLY_MOVE = "ON_ACT46SIDE_ARRIVE";

		// Token: 0x0400D1BD RID: 53693
		[Token(Token = "0x400D1BD")]
		public const string MONOPOLY_NODE_REFRESH = "ON_ACT46SIDE_REFRESH";

		// Token: 0x0400D1BE RID: 53694
		[Token(Token = "0x400D1BE")]
		public const string MONOPOLY_NODE_LOCK = "ON_ACT46SIDE_LOCK";

		// Token: 0x0400D1BF RID: 53695
		[Token(Token = "0x400D1BF")]
		public const string MONOPOLY_NODE_TREASURE = "ON_ACT46SIDE_TREASUREBOX";

		// Token: 0x0400D1C0 RID: 53696
		[Token(Token = "0x400D1C0")]
		public const string MONOPOLY_NODE_TREASURE_OPEN = "ON_ACT46SIDE_TREASUREBOXGET";

		// Token: 0x0400D1C1 RID: 53697
		[Token(Token = "0x400D1C1")]
		public const string MONOPOLY_MINING = "ON_ACT46SIDE_COLLECTRESOURCE";

		// Token: 0x0400D1C2 RID: 53698
		[Token(Token = "0x400D1C2")]
		public const string MONOPOLY_REMOVE_CARD = "ON_ACT46SIDE_REMOVECARD";

		// Token: 0x0400D1C3 RID: 53699
		[Token(Token = "0x400D1C3")]
		public const string MONOPOLY_HAND_OUT_CARD = "ON_ACT46SIDE_HANDOUTCARD";

		// Token: 0x0400D1C4 RID: 53700
		[Token(Token = "0x400D1C4")]
		public const string MONOPOLY_MISSION_RESOURCE_GAIN = "ON_ACT46SIDE_RESOURCEUP";

		// Token: 0x0400D1C5 RID: 53701
		[Token(Token = "0x400D1C5")]
		public const string MONOPOLY_MISSION_COMPLETE = "ON_ACT46SIDE_MISSIONCOMPLETE";

		// Token: 0x0400D1C6 RID: 53702
		[Token(Token = "0x400D1C6")]
		public const string MONOPOLY_MISSION_REFRESH = "ON_ACT46SIDE_MISSIONREFRESH";

		// Token: 0x0400D1C7 RID: 53703
		[Token(Token = "0x400D1C7")]
		public const string MONOPOLY_MISSION_COMBO = "ON_ACT46SIDE_RESOURCECOMBO";

		// Token: 0x0400D1C8 RID: 53704
		[Token(Token = "0x400D1C8")]
		public const string MONOPOLY_MISSION_STATE_NORMAL = "ON_ACT46SIDE_TARGETCOMPLETE";

		// Token: 0x0400D1C9 RID: 53705
		[Token(Token = "0x400D1C9")]
		public const string MONOPOLY_MISSION_STATE_EXCELLENT = "ON_ACT46SIDE_TARGETBEYOND";

		// Token: 0x0400D1CA RID: 53706
		[Token(Token = "0x400D1CA")]
		public const string MONOPOLY_SETTLE_FAIL = "ON_ACT46SIDE_SETTLEMENTUNFINISH";

		// Token: 0x0400D1CB RID: 53707
		[Token(Token = "0x400D1CB")]
		public const string MONOPOLY_SETTLE_NORMAL = "ON_ACT46SIDE_SETTLEMENTNORMAL";

		// Token: 0x0400D1CC RID: 53708
		[Token(Token = "0x400D1CC")]
		public const string MONOPOLY_SETTLE_EXCELLENT = "ON_ACT46SIDE_SETTLEMENTHIGH";

		// Token: 0x0400D1CD RID: 53709
		[Token(Token = "0x400D1CD")]
		public const string ART_GALLERY_ENTER = "ON_ARTGALLERY_TRANSITION";

		// Token: 0x0400D1CE RID: 53710
		[Token(Token = "0x400D1CE")]
		public const string UNI_EQUIP_UNLOCK = "ON_UNIEQUIP_UNLOCK";

		// Token: 0x0400D1CF RID: 53711
		[Token(Token = "0x400D1CF")]
		public const string CHAR_LEVEL_MAX = "ON_LEVELMAX";

		// Token: 0x0400D1D0 RID: 53712
		[Token(Token = "0x400D1D0")]
		[FieldOffset(Offset = "0x8")]
		public static Dictionary<UiInternalSoundType, string> InternalSounds;

		// Token: 0x0400D1D1 RID: 53713
		[Token(Token = "0x400D1D1")]
		[FieldOffset(Offset = "0x10")]
		public static Dictionary<UiBuildingSoundType, string> BuildingSounds;

		// Token: 0x0400D1D2 RID: 53714
		[Token(Token = "0x400D1D2")]
		[FieldOffset(Offset = "0x18")]
		public static Dictionary<UiEffectSoundType, string> UiEffectSounds;

		// Token: 0x0400D1D3 RID: 53715
		[Token(Token = "0x400D1D3")]
		public const string PERSIST_TAG_BATTLE = "TAGBAT";

		// Token: 0x0400D1D4 RID: 53716
		[Token(Token = "0x400D1D4")]
		public const string PERSIST_TAG_UI = "TAGUI";

		// Token: 0x0400D1D5 RID: 53717
		[Token(Token = "0x400D1D5")]
		public const string PERSIST_TAG_GACHA = "TAGACHA";

		// Token: 0x0400D1D6 RID: 53718
		[Token(Token = "0x400D1D6")]
		public const string PERSIST_TAG_VOICE = "TAGVOICE";

		// Token: 0x0400D1D7 RID: 53719
		[Token(Token = "0x400D1D7")]
		public const string PERSIST_TAG_VAULT = "TAGVAULT";
	}
}
