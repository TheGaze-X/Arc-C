using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x02000905 RID: 2309
	[Token(Token = "0x2000905")]
	public class PlayerActivity
	{
		// Token: 0x060065DC RID: 26076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DC")]
		[Address(RVA = "0x1EEFBB0", Offset = "0x1EEE7B0", VA = "0x181EEFBB0")]
		public PlayerActivity()
		{
		}

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("DEFAULT")]
		public ListDict<string, PlayerActivity.PlayerDefaultActivity> defaultActivityList;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("MISSION_ONLY")]
		public ListDict<string, PlayerActivity.PlayerMissionOnlyTypeActivity> missionOnlyActivityList;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("CHECKIN_ONLY")]
		public Dictionary<string, PlayerActivity.PlayerCheckinOnlyTypeActivity> checkinOnlyActivityList;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("CHECKIN_ALL_PLAYER")]
		public Dictionary<string, PlayerActivity.PlayerCheckinAllTypeActivity> checkinAllActivityList;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("CHECKIN_VS")]
		public Dictionary<string, PlayerActivity.PlayerCheckinVsTypeActivity> checkinVsActivityList;

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("COLLECTION")]
		public Dictionary<string, PlayerActivity.PlayerCollectionTypeActivity> collectionActivityList;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("AVG_ONLY")]
		public ListDict<string, PlayerActivity.PlayerAVGOnlyTypeActivity> avgOnlyActivityList;

		// Token: 0x040033B2 RID: 13234
		[Token(Token = "0x40033B2")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("LOGIN_ONLY")]
		public ListDict<string, PlayerActivity.PlayerLoginOnlyTypeActivity> loginOnlyActivityList;

		// Token: 0x040033B3 RID: 13235
		[Token(Token = "0x40033B3")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("MINISTORY")]
		public Dictionary<string, PlayerActivity.PlayerMiniStoryActivity> miniStoryActivityList;

		// Token: 0x040033B4 RID: 13236
		[Token(Token = "0x40033B4")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("ROGUELIKE")]
		public ListDict<string, PlayerActivity.PlayerRoguelikeActivity> roguelikeActivityList;

		// Token: 0x040033B5 RID: 13237
		[Token(Token = "0x40033B5")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("PRAY_ONLY")]
		public ListDict<string, PlayerActivity.PlayerPrayOnlyActivity> prayOnlyActivityList;

		// Token: 0x040033B6 RID: 13238
		[Token(Token = "0x40033B6")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("FLIP_ONLY")]
		public ListDict<string, PlayerActivity.PlayerFlipOnlyActivity> flipOnlyActivityList;

		// Token: 0x040033B7 RID: 13239
		[Token(Token = "0x40033B7")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("MULTIPLAY")]
		public ListDict<string, PlayerActivity.PlayerMultiplayActivity> multiplayActivityList;

		// Token: 0x040033B8 RID: 13240
		[Token(Token = "0x40033B8")]
		[FieldOffset(Offset = "0x78")]
		[JsonProperty("MULTIPLAY_VERIFY2")]
		public ListDict<string, PlayerActivity.PlayerMultiplayV2Activity> multiplayV2ActivityList;

		// Token: 0x040033B9 RID: 13241
		[Token(Token = "0x40033B9")]
		[FieldOffset(Offset = "0x80")]
		[JsonProperty("MULTIPLAY_V3")]
		public Dictionary<string, PlayerActivity.PlayerMultiV3Activity> multiV3ActivityList;

		// Token: 0x040033BA RID: 13242
		[Token(Token = "0x40033BA")]
		[FieldOffset(Offset = "0x88")]
		[JsonProperty("INTERLOCK")]
		public ListDict<string, PlayerActivity.PlayerInterlockActivity> interlockActivityList;

		// Token: 0x040033BB RID: 13243
		[Token(Token = "0x40033BB")]
		[FieldOffset(Offset = "0x90")]
		[JsonProperty("TYPE_ACT3D0")]
		public ListDict<string, PlayerActivity.PlayerAct3D0Activity> act3D0ActivityList;

		// Token: 0x040033BC RID: 13244
		[Token(Token = "0x40033BC")]
		[FieldOffset(Offset = "0x98")]
		[JsonProperty("TYPE_ACT4D0")]
		public ListDict<string, PlayerActivity.PlayerAct4D0Activity> act4D0ActivityList;

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0xA0")]
		[JsonProperty("TYPE_ACT5D0")]
		public ListDict<string, PlayerActivity.PlayerAct5D0Activity> act5D0ActivityList;

		// Token: 0x040033BE RID: 13246
		[Token(Token = "0x40033BE")]
		[FieldOffset(Offset = "0xA8")]
		[JsonProperty("TYPE_ACT5D1")]
		public ListDict<string, PlayerActivity.PlayerAct5D1Activity> act5D1ActivityList;

		// Token: 0x040033BF RID: 13247
		[Token(Token = "0x40033BF")]
		[FieldOffset(Offset = "0xB0")]
		[JsonProperty("TYPE_ACT9D0")]
		public Dictionary<string, PlayerActivity.PlayerAct9D0Activity> act9D0ActivityList;

		// Token: 0x040033C0 RID: 13248
		[Token(Token = "0x40033C0")]
		[FieldOffset(Offset = "0xB8")]
		[JsonProperty("TYPE_ACT17D7")]
		public ListDict<string, PlayerActivity.PlayerAct17D7Activity> act17D7ActivityList;

		// Token: 0x040033C1 RID: 13249
		[Token(Token = "0x40033C1")]
		[FieldOffset(Offset = "0xC0")]
		[JsonProperty("TYPE_ACT12SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct12sideActivity> act12sideActivityList;

		// Token: 0x040033C2 RID: 13250
		[Token(Token = "0x40033C2")]
		[FieldOffset(Offset = "0xC8")]
		[JsonProperty("TYPE_ACT13SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct13sideActivity> act13sideActivityList;

		// Token: 0x040033C3 RID: 13251
		[Token(Token = "0x40033C3")]
		[FieldOffset(Offset = "0xD0")]
		[JsonProperty("GRID_GACHA")]
		public ListDict<string, PlayerActivity.PlayerGridGachaActivity> gridGachaActivityList;

		// Token: 0x040033C4 RID: 13252
		[Token(Token = "0x40033C4")]
		[FieldOffset(Offset = "0xD8")]
		[JsonProperty("GRID_GACHA_V2")]
		public ListDict<string, JObject> gridGachaV2ActivityList;

		// Token: 0x040033C5 RID: 13253
		[Token(Token = "0x40033C5")]
		[FieldOffset(Offset = "0xE0")]
		[JsonProperty("APRIL_FOOL")]
		public ListDict<string, PlayerActivity.PlayerAprilFoolActivity> actFunActivityList;

		// Token: 0x040033C6 RID: 13254
		[Token(Token = "0x40033C6")]
		[FieldOffset(Offset = "0xE8")]
		[JsonProperty("TYPE_ACT17SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct17SideActivity> act17sideActivityList;

		// Token: 0x040033C7 RID: 13255
		[Token(Token = "0x40033C7")]
		[FieldOffset(Offset = "0xF0")]
		[JsonProperty("BOSS_RUSH")]
		public ListDict<string, PlayerActivity.PlayerBossRushActivity> bossRushActivityList;

		// Token: 0x040033C8 RID: 13256
		[Token(Token = "0x40033C8")]
		[FieldOffset(Offset = "0xF8")]
		[JsonProperty("ENEMY_DUEL")]
		public ListDict<string, PlayerActivity.PlayerEnemyDuelActivity> enemyDuelActivityList;

		// Token: 0x040033C9 RID: 13257
		[Token(Token = "0x40033C9")]
		[FieldOffset(Offset = "0x100")]
		[JsonProperty("VEC_BREAK_V2")]
		public ListDict<string, PlayerActivity.PlayerVecBreakV2> vecBreakV2ActivityList;

		// Token: 0x040033CA RID: 13258
		[Token(Token = "0x40033CA")]
		[FieldOffset(Offset = "0x108")]
		[JsonProperty("ARCADE")]
		public ListDict<string, PlayerActivity.PlayerArcadeActivity> arcadeActivityList;

		// Token: 0x040033CB RID: 13259
		[Token(Token = "0x40033CB")]
		[FieldOffset(Offset = "0x110")]
		[JsonProperty("TYPE_ACT20SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct20SideActivity> act20sideActivityList;

		// Token: 0x040033CC RID: 13260
		[Token(Token = "0x40033CC")]
		[FieldOffset(Offset = "0x118")]
		[JsonProperty("FLOAT_PARADE")]
		public ListDict<string, PlayerActivity.PlayerActFloatParadeActivity> floatParadeActivityList;

		// Token: 0x040033CD RID: 13261
		[Token(Token = "0x40033CD")]
		[FieldOffset(Offset = "0x120")]
		[JsonProperty("TYPE_ACT21SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct21SideActivity> act21sideActivityList;

		// Token: 0x040033CE RID: 13262
		[Token(Token = "0x40033CE")]
		[FieldOffset(Offset = "0x128")]
		[JsonProperty("MAIN_BUFF")]
		public ListDict<string, PlayerActivity.PlayerActMainlineBuff> mainlineBuffActivityList;

		// Token: 0x040033CF RID: 13263
		[Token(Token = "0x40033CF")]
		[FieldOffset(Offset = "0x130")]
		[JsonProperty("TYPE_ACT24SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct24SideActivity> act24sideActivityList;

		// Token: 0x040033D0 RID: 13264
		[Token(Token = "0x40033D0")]
		[FieldOffset(Offset = "0x138")]
		[JsonProperty("TYPE_ACT25SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct25SideActivity> act25sideActivityList;

		// Token: 0x040033D1 RID: 13265
		[Token(Token = "0x40033D1")]
		[FieldOffset(Offset = "0x140")]
		[JsonProperty("SWITCH_ONLY")]
		public ListDict<string, PlayerActivity.PlayerSwitchOnlyActivity> switchOnlyList;

		// Token: 0x040033D2 RID: 13266
		[Token(Token = "0x40033D2")]
		[FieldOffset(Offset = "0x148")]
		[JsonProperty("TYPE_ACT27SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct27SideActivity> act27sideActivityList;

		// Token: 0x040033D3 RID: 13267
		[Token(Token = "0x40033D3")]
		[FieldOffset(Offset = "0x150")]
		[JsonProperty("UNIQUE_ONLY")]
		public ListDict<string, PlayerActivity.PlayerUniqueOnlyActivity> uniqueOnlyList;

		// Token: 0x040033D4 RID: 13268
		[Token(Token = "0x40033D4")]
		[FieldOffset(Offset = "0x158")]
		[JsonProperty("MAINLINE_BP")]
		public ListDict<string, JObject> mainlineBpActivityList;

		// Token: 0x040033D5 RID: 13269
		[Token(Token = "0x40033D5")]
		[FieldOffset(Offset = "0x160")]
		[JsonProperty("TYPE_ACT42D0")]
		public ListDict<string, PlayerActivity.PlayerAct42D0Activity> act42D0ActivityList;

		// Token: 0x040033D6 RID: 13270
		[Token(Token = "0x40033D6")]
		[FieldOffset(Offset = "0x168")]
		[JsonProperty("TYPE_ACT29SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct29SideActivity> act29sideActivityList;

		// Token: 0x040033D7 RID: 13271
		[Token(Token = "0x40033D7")]
		[FieldOffset(Offset = "0x170")]
		[JsonProperty("BLESS_ONLY")]
		public ListDict<string, PlayerActivity.PlayerBlessOnlyActivity> blessOnlyList;

		// Token: 0x040033D8 RID: 13272
		[Token(Token = "0x40033D8")]
		[FieldOffset(Offset = "0x178")]
		[JsonProperty("CHECKIN_ACCESS")]
		public ListDict<string, JObject> checkinAccessList;

		// Token: 0x040033D9 RID: 13273
		[Token(Token = "0x40033D9")]
		[FieldOffset(Offset = "0x180")]
		[JsonProperty("YEAR_5_GENERAL")]
		public ListDict<string, PlayerActivity.PlayerYear5GeneralActivity> year5GeneralList;

		// Token: 0x040033DA RID: 13274
		[Token(Token = "0x40033DA")]
		[FieldOffset(Offset = "0x188")]
		[JsonProperty("TYPE_ACT35SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct35SideActivity> act35sideActivityList;

		// Token: 0x040033DB RID: 13275
		[Token(Token = "0x40033DB")]
		[FieldOffset(Offset = "0x190")]
		[JsonProperty("TYPE_ACT36SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct36SideActivity> act36sideActivityList;

		// Token: 0x040033DC RID: 13276
		[Token(Token = "0x40033DC")]
		[FieldOffset(Offset = "0x198")]
		[JsonProperty("TYPE_ACT38SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct38SideActivity> act38sideActivityList;

		// Token: 0x040033DD RID: 13277
		[Token(Token = "0x40033DD")]
		[FieldOffset(Offset = "0x1A0")]
		[JsonProperty("AUTOCHESS_VERIFY1")]
		public ListDict<string, PlayerActivity.PlayerAutoChessV1Activity> autoChessList;

		// Token: 0x040033DE RID: 13278
		[Token(Token = "0x40033DE")]
		[FieldOffset(Offset = "0x1A8")]
		[JsonProperty("CHECKIN_VIDEO")]
		public ListDict<string, JObject> checkinVideoActivityList;

		// Token: 0x040033DF RID: 13279
		[Token(Token = "0x40033DF")]
		[FieldOffset(Offset = "0x1B0")]
		[JsonProperty("TYPE_MAINSS")]
		public ListDict<string, PlayerActivity.PlayerActMainSSActivity> actMainSSActivityList;

		// Token: 0x040033E0 RID: 13280
		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x1B8")]
		[JsonProperty("TYPE_ACT42SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct42SideActivity> act42sideActivityList;

		// Token: 0x040033E1 RID: 13281
		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x1C0")]
		[JsonProperty("TYPE_ACT44SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct44SideActivity> act44sideActivityList;

		// Token: 0x040033E2 RID: 13282
		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x1C8")]
		[JsonProperty("HALFIDLE_VERIFY1")]
		public ListDict<string, PlayerActivity.PlayerAct1VHalfIdleActivity> act1vHalfIdleActivityList;

		// Token: 0x040033E3 RID: 13283
		[Token(Token = "0x40033E3")]
		[FieldOffset(Offset = "0x1D0")]
		[JsonProperty("TYPE_ACT45SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct45SideActivity> act45sideActivityList;

		// Token: 0x040033E4 RID: 13284
		[Token(Token = "0x40033E4")]
		[FieldOffset(Offset = "0x1D8")]
		[JsonProperty("TEAM_QUEST")]
		public Dictionary<string, JObject> teamQuestActivityList;

		// Token: 0x040033E5 RID: 13285
		[Token(Token = "0x40033E5")]
		[FieldOffset(Offset = "0x1E0")]
		[JsonProperty("RECRUIT_ONLY")]
		public ListDict<string, PlayerActivity.PlayerRecruitOnlyAct> recruitOnlyList;

		// Token: 0x040033E6 RID: 13286
		[Token(Token = "0x40033E6")]
		[FieldOffset(Offset = "0x1E8")]
		[JsonProperty("TYPE_ACT46SIDE")]
		public ListDict<string, PlayerActivity.PlayerAct46SideActivity> act46sideActivityList;

		// Token: 0x040033E7 RID: 13287
		[Token(Token = "0x40033E7")]
		[FieldOffset(Offset = "0x1F0")]
		[JsonProperty("AUTOCHESS_SEASON")]
		public ListDict<string, PlayerActivity.PlayerActAutoChessActivity> actAutoChessActivityList;

		// Token: 0x02000906 RID: 2310
		[Token(Token = "0x2000906")]
		public class PlayerDefaultActivity
		{
			// Token: 0x060065DD RID: 26077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065DD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerDefaultActivity()
			{
			}

			// Token: 0x040033E8 RID: 13288
			[Token(Token = "0x40033E8")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x040033E9 RID: 13289
			[Token(Token = "0x40033E9")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> shop;
		}

		// Token: 0x02000907 RID: 2311
		[Token(Token = "0x2000907")]
		public class PlayerMissionOnlyTypeActivity
		{
			// Token: 0x060065DE RID: 26078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065DE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerMissionOnlyTypeActivity()
			{
			}
		}

		// Token: 0x02000908 RID: 2312
		[Token(Token = "0x2000908")]
		public class PlayerCheckinOnlyTypeActivity
		{
			// Token: 0x060065DF RID: 26079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065DF")]
			[Address(RVA = "0x1EF3ED0", Offset = "0x1EF2AD0", VA = "0x181EF3ED0")]
			public PlayerCheckinOnlyTypeActivity()
			{
			}

			// Token: 0x040033EA RID: 13290
			[Token(Token = "0x40033EA")]
			[FieldOffset(Offset = "0x10")]
			public List<int> history;

			// Token: 0x040033EB RID: 13291
			[Token(Token = "0x40033EB")]
			[FieldOffset(Offset = "0x18")]
			public List<string> dynOpt;

			// Token: 0x040033EC RID: 13292
			[Token(Token = "0x40033EC")]
			[FieldOffset(Offset = "0x20")]
			public List<int> extraHistory;
		}

		// Token: 0x02000909 RID: 2313
		[Token(Token = "0x2000909")]
		public class PlayerCheckinVsTypeActivity
		{
			// Token: 0x060065E0 RID: 26080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerCheckinVsTypeActivity()
			{
			}

			// Token: 0x040033ED RID: 13293
			[Token(Token = "0x40033ED")]
			[FieldOffset(Offset = "0x10")]
			public int sweetVote;

			// Token: 0x040033EE RID: 13294
			[Token(Token = "0x40033EE")]
			[FieldOffset(Offset = "0x14")]
			public int saltyVote;

			// Token: 0x040033EF RID: 13295
			[Token(Token = "0x40033EF")]
			[FieldOffset(Offset = "0x18")]
			public bool canVote;

			// Token: 0x040033F0 RID: 13296
			[Token(Token = "0x40033F0")]
			[FieldOffset(Offset = "0x1C")]
			public int todayVoteState;

			// Token: 0x040033F1 RID: 13297
			[Token(Token = "0x40033F1")]
			[FieldOffset(Offset = "0x20")]
			public int voteRewardState;

			// Token: 0x040033F2 RID: 13298
			[Token(Token = "0x40033F2")]
			[FieldOffset(Offset = "0x24")]
			public int signedCnt;

			// Token: 0x040033F3 RID: 13299
			[Token(Token = "0x40033F3")]
			[FieldOffset(Offset = "0x28")]
			public int availSignCnt;

			// Token: 0x040033F4 RID: 13300
			[Token(Token = "0x40033F4")]
			[FieldOffset(Offset = "0x2C")]
			public int socialState;

			// Token: 0x040033F5 RID: 13301
			[Token(Token = "0x40033F5")]
			[FieldOffset(Offset = "0x30")]
			public int actDay;
		}

		// Token: 0x0200090A RID: 2314
		[Token(Token = "0x200090A")]
		public class PlayerCheckinAllTypeActivity
		{
			// Token: 0x060065E1 RID: 26081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E1")]
			[Address(RVA = "0x1EF3D90", Offset = "0x1EF2990", VA = "0x181EF3D90")]
			public PlayerCheckinAllTypeActivity()
			{
			}

			// Token: 0x040033F6 RID: 13302
			[Token(Token = "0x40033F6")]
			[FieldOffset(Offset = "0x10")]
			public List<int> history;

			// Token: 0x040033F7 RID: 13303
			[Token(Token = "0x40033F7")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> allRecord;

			// Token: 0x040033F8 RID: 13304
			[Token(Token = "0x40033F8")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, int> allRewardStatus;

			// Token: 0x040033F9 RID: 13305
			[Token(Token = "0x40033F9")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, int> personalRecord;
		}

		// Token: 0x0200090B RID: 2315
		[Token(Token = "0x200090B")]
		public class MilestoneInfo
		{
			// Token: 0x060065E2 RID: 26082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MilestoneInfo()
			{
			}

			// Token: 0x040033FA RID: 13306
			[Token(Token = "0x40033FA")]
			[FieldOffset(Offset = "0x10")]
			public int point;

			// Token: 0x040033FB RID: 13307
			[Token(Token = "0x40033FB")]
			[FieldOffset(Offset = "0x18")]
			public List<string> got;
		}

		// Token: 0x0200090C RID: 2316
		[Token(Token = "0x200090C")]
		public class PlayerCollectionTypeActivity
		{
			// Token: 0x060065E3 RID: 26083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E3")]
			[Address(RVA = "0x1EF40B0", Offset = "0x1EF2CB0", VA = "0x181EF40B0")]
			public PlayerCollectionTypeActivity()
			{
			}

			// Token: 0x040033FC RID: 13308
			[Token(Token = "0x40033FC")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> point;

			// Token: 0x040033FD RID: 13309
			[Token(Token = "0x40033FD")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerActivity.PlayerCollectionTypeActivity.PlayerCollectionInfo> history;

			// Token: 0x0200090D RID: 2317
			[Token(Token = "0x200090D")]
			public class PlayerCollectionInfo
			{
				// Token: 0x060065E4 RID: 26084 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065E4")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerCollectionInfo()
				{
				}

				// Token: 0x040033FE RID: 13310
				[Token(Token = "0x40033FE")]
				[FieldOffset(Offset = "0x10")]
				public string ts;
			}
		}

		// Token: 0x0200090E RID: 2318
		[Token(Token = "0x200090E")]
		public class PlayerAVGOnlyTypeActivity
		{
			// Token: 0x060065E5 RID: 26085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerAVGOnlyTypeActivity()
			{
			}

			// Token: 0x040033FF RID: 13311
			[Token(Token = "0x40033FF")]
			[FieldOffset(Offset = "0x10")]
			public bool isOpen;
		}

		// Token: 0x0200090F RID: 2319
		[Token(Token = "0x200090F")]
		public class PlayerLoginOnlyTypeActivity
		{
			// Token: 0x060065E6 RID: 26086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerLoginOnlyTypeActivity()
			{
			}

			// Token: 0x04003400 RID: 13312
			[Token(Token = "0x4003400")]
			[FieldOffset(Offset = "0x10")]
			public int reward;
		}

		// Token: 0x02000910 RID: 2320
		[Token(Token = "0x2000910")]
		public class PlayerMiniStoryActivity
		{
			// Token: 0x060065E7 RID: 26087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E7")]
			[Address(RVA = "0x1EFB4D0", Offset = "0x1EFA0D0", VA = "0x181EFB4D0")]
			public PlayerMiniStoryActivity()
			{
			}

			// Token: 0x04003401 RID: 13313
			[Token(Token = "0x4003401")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x04003402 RID: 13314
			[Token(Token = "0x4003402")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;
		}

		// Token: 0x02000911 RID: 2321
		[Token(Token = "0x2000911")]
		public class PlayerRoguelikeActivity
		{
			// Token: 0x060065E8 RID: 26088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065E8")]
			[Address(RVA = "0x1EFC760", Offset = "0x1EFB360", VA = "0x181EFC760")]
			public PlayerRoguelikeActivity()
			{
			}

			// Token: 0x04003403 RID: 13315
			[Token(Token = "0x4003403")]
			[FieldOffset(Offset = "0x10")]
			public int buffToken;

			// Token: 0x04003404 RID: 13316
			[Token(Token = "0x4003404")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerRoguelikeActivity.MileStone milestone;

			// Token: 0x04003405 RID: 13317
			[Token(Token = "0x4003405")]
			[FieldOffset(Offset = "0x20")]
			public PlayerActivity.PlayerRoguelikeActivity.GameStatus game;

			// Token: 0x02000912 RID: 2322
			[Token(Token = "0x2000912")]
			public class MileStone
			{
				// Token: 0x060065E9 RID: 26089 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065E9")]
				[Address(RVA = "0x1EEB5E0", Offset = "0x1EEA1E0", VA = "0x181EEB5E0")]
				public MileStone()
				{
				}

				// Token: 0x04003406 RID: 13318
				[Token(Token = "0x4003406")]
				[FieldOffset(Offset = "0x10")]
				public int token;

				// Token: 0x04003407 RID: 13319
				[Token(Token = "0x4003407")]
				[FieldOffset(Offset = "0x18")]
				[JsonProperty("got")]
				public Dictionary<string, long> rewards;
			}

			// Token: 0x02000913 RID: 2323
			[Token(Token = "0x2000913")]
			public class GameStatus
			{
				// Token: 0x060065EA RID: 26090 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065EA")]
				[Address(RVA = "0x1EEA3E0", Offset = "0x1EE8FE0", VA = "0x181EEA3E0")]
				public GameStatus()
				{
				}

				// Token: 0x04003408 RID: 13320
				[Token(Token = "0x4003408")]
				[FieldOffset(Offset = "0x10")]
				public long lastTs;
			}
		}

		// Token: 0x02000914 RID: 2324
		[Token(Token = "0x2000914")]
		public class PlayerPrayOnlyActivity
		{
			// Token: 0x060065EB RID: 26091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065EB")]
			[Address(RVA = "0x1EFC1D0", Offset = "0x1EFADD0", VA = "0x181EFC1D0")]
			public PlayerPrayOnlyActivity()
			{
			}

			// Token: 0x04003409 RID: 13321
			[Token(Token = "0x4003409")]
			[FieldOffset(Offset = "0x10")]
			public long lastTs;

			// Token: 0x0400340A RID: 13322
			[Token(Token = "0x400340A")]
			[FieldOffset(Offset = "0x18")]
			public int extraCount;

			// Token: 0x0400340B RID: 13323
			[Token(Token = "0x400340B")]
			[FieldOffset(Offset = "0x1C")]
			public int prayDaily;

			// Token: 0x0400340C RID: 13324
			[Token(Token = "0x400340C")]
			[FieldOffset(Offset = "0x20")]
			public int prayMaxIndex;

			// Token: 0x0400340D RID: 13325
			[Token(Token = "0x400340D")]
			[FieldOffset(Offset = "0x24")]
			public bool praying;

			// Token: 0x0400340E RID: 13326
			[Token(Token = "0x400340E")]
			[FieldOffset(Offset = "0x28")]
			public List<PlayerActivity.PlayerPrayOnlyActivity.RewardInfo> prayArray;

			// Token: 0x02000915 RID: 2325
			[Token(Token = "0x2000915")]
			public class RewardInfo
			{
				// Token: 0x060065EC RID: 26092 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065EC")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RewardInfo()
				{
				}

				// Token: 0x0400340F RID: 13327
				[Token(Token = "0x400340F")]
				[FieldOffset(Offset = "0x10")]
				public int index;

				// Token: 0x04003410 RID: 13328
				[Token(Token = "0x4003410")]
				[FieldOffset(Offset = "0x14")]
				public int count;
			}
		}

		// Token: 0x02000916 RID: 2326
		[Token(Token = "0x2000916")]
		public class PlayerSwitchOnlyActivity
		{
			// Token: 0x060065ED RID: 26093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065ED")]
			[Address(RVA = "0x1EFF630", Offset = "0x1EFE230", VA = "0x181EFF630")]
			public PlayerSwitchOnlyActivity()
			{
			}

			// Token: 0x04003411 RID: 13329
			[Token(Token = "0x4003411")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> rewards;
		}

		// Token: 0x02000917 RID: 2327
		[Token(Token = "0x2000917")]
		public class PlayerFlipOnlyActivity
		{
			// Token: 0x060065EE RID: 26094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065EE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerFlipOnlyActivity()
			{
			}

			// Token: 0x04003412 RID: 13330
			[Token(Token = "0x4003412")]
			[FieldOffset(Offset = "0x10")]
			public int raffleCount;

			// Token: 0x04003413 RID: 13331
			[Token(Token = "0x4003413")]
			[FieldOffset(Offset = "0x14")]
			public int todayRaffleCount;

			// Token: 0x04003414 RID: 13332
			[Token(Token = "0x4003414")]
			[FieldOffset(Offset = "0x18")]
			public int remainingRaffleCount;

			// Token: 0x04003415 RID: 13333
			[Token(Token = "0x4003415")]
			[FieldOffset(Offset = "0x1C")]
			public bool luckyToday;

			// Token: 0x04003416 RID: 13334
			[Token(Token = "0x4003416")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<int, PlayerActivity.PlayerFlipOnlyActivity.ActFlipItemBundle> normalRewards;

			// Token: 0x04003417 RID: 13335
			[Token(Token = "0x4003417")]
			[FieldOffset(Offset = "0x28")]
			public int grandStatus;

			// Token: 0x02000918 RID: 2328
			[Token(Token = "0x2000918")]
			public class ActFlipItemBundle
			{
				// Token: 0x060065EF RID: 26095 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065EF")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ActFlipItemBundle()
				{
				}

				// Token: 0x04003418 RID: 13336
				[Token(Token = "0x4003418")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003419 RID: 13337
				[Token(Token = "0x4003419")]
				[FieldOffset(Offset = "0x18")]
				public string type;

				// Token: 0x0400341A RID: 13338
				[Token(Token = "0x400341A")]
				[FieldOffset(Offset = "0x20")]
				public int count;

				// Token: 0x0400341B RID: 13339
				[Token(Token = "0x400341B")]
				[FieldOffset(Offset = "0x28")]
				public long ts;

				// Token: 0x0400341C RID: 13340
				[Token(Token = "0x400341C")]
				[FieldOffset(Offset = "0x30")]
				public string prizeId;
			}
		}

		// Token: 0x02000919 RID: 2329
		[Token(Token = "0x2000919")]
		public class PlayerGridGachaActivity
		{
			// Token: 0x060065F0 RID: 26096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065F0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerGridGachaActivity()
			{
			}

			// Token: 0x0400341D RID: 13341
			[Token(Token = "0x400341D")]
			[FieldOffset(Offset = "0x10")]
			public bool lastDay;

			// Token: 0x0400341E RID: 13342
			[Token(Token = "0x400341E")]
			[FieldOffset(Offset = "0x11")]
			public bool firstDay;

			// Token: 0x0400341F RID: 13343
			[Token(Token = "0x400341F")]
			[FieldOffset(Offset = "0x18")]
			public List<int> openedPosition;

			// Token: 0x04003420 RID: 13344
			[Token(Token = "0x4003420")]
			[FieldOffset(Offset = "0x20")]
			public int openedType;

			// Token: 0x04003421 RID: 13345
			[Token(Token = "0x4003421")]
			[FieldOffset(Offset = "0x24")]
			public int rewardCount;

			// Token: 0x04003422 RID: 13346
			[Token(Token = "0x4003422")]
			[FieldOffset(Offset = "0x28")]
			public List<List<int>> grandPositions;
		}

		// Token: 0x0200091A RID: 2330
		[Token(Token = "0x200091A")]
		public class PlayerMultiplayActivity
		{
			// Token: 0x060065F1 RID: 26097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065F1")]
			[Address(RVA = "0x1EFB850", Offset = "0x1EFA450", VA = "0x181EFB850")]
			public PlayerMultiplayActivity()
			{
			}

			// Token: 0x04003423 RID: 13347
			[Token(Token = "0x4003423")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, PlayerActivity.PlayerMultiplayActivity.Troop> troop;

			// Token: 0x04003424 RID: 13348
			[Token(Token = "0x4003424")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerActivity.PlayerMultiplayActivity.Stage> stages;

			// Token: 0x0200091B RID: 2331
			[Token(Token = "0x200091B")]
			public class Troop
			{
				// Token: 0x060065F2 RID: 26098 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065F2")]
				[Address(RVA = "0x1F02E80", Offset = "0x1F01A80", VA = "0x181F02E80")]
				public Troop()
				{
				}

				// Token: 0x04003425 RID: 13349
				[Token(Token = "0x4003425")]
				[FieldOffset(Offset = "0x10")]
				public int init;

				// Token: 0x04003426 RID: 13350
				[Token(Token = "0x4003426")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerSquad> squads;
			}

			// Token: 0x0200091C RID: 2332
			[Token(Token = "0x200091C")]
			public class Stage
			{
				// Token: 0x060065F3 RID: 26099 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065F3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Stage()
				{
				}

				// Token: 0x04003427 RID: 13351
				[Token(Token = "0x4003427")]
				[FieldOffset(Offset = "0x10")]
				public string stageId;

				// Token: 0x04003428 RID: 13352
				[Token(Token = "0x4003428")]
				[FieldOffset(Offset = "0x18")]
				public PlayerStageState state;

				// Token: 0x04003429 RID: 13353
				[Token(Token = "0x4003429")]
				[FieldOffset(Offset = "0x1C")]
				public int completeTimes;
			}
		}

		// Token: 0x0200091D RID: 2333
		[Token(Token = "0x200091D")]
		public class PlayerMultiplayV2Activity
		{
			// Token: 0x060065F4 RID: 26100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065F4")]
			[Address(RVA = "0x1EFB920", Offset = "0x1EFA520", VA = "0x181EFB920")]
			public PlayerMultiplayV2Activity()
			{
			}

			// Token: 0x0400342A RID: 13354
			[Token(Token = "0x400342A")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerMultiplayV2Activity.Squads squads;

			// Token: 0x0400342B RID: 13355
			[Token(Token = "0x400342B")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerMultiplayV2Activity.DailyMission dailyMission;

			// Token: 0x0400342C RID: 13356
			[Token(Token = "0x400342C")]
			[FieldOffset(Offset = "0x20")]
			public PlayerActivity.PlayerMultiplayV2Activity.MilestoneInfo milestone;

			// Token: 0x0400342D RID: 13357
			[Token(Token = "0x400342D")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty("stage")]
			public Dictionary<string, PlayerActivity.PlayerMultiplayV2Activity.StageInfo> stageInfoDict;

			// Token: 0x0400342E RID: 13358
			[Token(Token = "0x400342E")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerMultiplayV2Activity.Match match;

			// Token: 0x0400342F RID: 13359
			[Token(Token = "0x400342F")]
			[FieldOffset(Offset = "0x38")]
			public bool globalBan;

			// Token: 0x0200091E RID: 2334
			[Token(Token = "0x200091E")]
			public class PlayerMultiplayV2SquadItem : PlayerSquadMemberProto
			{
				// Token: 0x060065F5 RID: 26101 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065F5")]
				[Address(RVA = "0x1EFBB90", Offset = "0x1EFA790", VA = "0x181EFBB90")]
				public PlayerMultiplayV2SquadItem()
				{
				}

				// Token: 0x04003430 RID: 13360
				[Token(Token = "0x4003430")]
				[FieldOffset(Offset = "0x30")]
				public int instId;

				// Token: 0x04003431 RID: 13361
				[Token(Token = "0x4003431")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x0200091F RID: 2335
			[Token(Token = "0x200091F")]
			public class Squads
			{
				// Token: 0x060065F6 RID: 26102 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065F6")]
				[Address(RVA = "0x1F01E20", Offset = "0x1F00A20", VA = "0x181F01E20")]
				public Squads()
				{
				}

				// Token: 0x04003432 RID: 13362
				[Token(Token = "0x4003432")]
				[FieldOffset(Offset = "0x10")]
				public List<PlayerActivity.PlayerMultiplayV2Activity.PlayerMultiplayV2SquadItem> prefer;

				// Token: 0x04003433 RID: 13363
				[Token(Token = "0x4003433")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerActivity.PlayerMultiplayV2Activity.PlayerMultiplayV2SquadItem> backup;
			}

			// Token: 0x02000920 RID: 2336
			[Token(Token = "0x2000920")]
			public enum DailyMissionState
			{
				// Token: 0x04003435 RID: 13365
				[Token(Token = "0x4003435")]
				NOT_CLAIM,
				// Token: 0x04003436 RID: 13366
				[Token(Token = "0x4003436")]
				CLAIMED
			}

			// Token: 0x02000921 RID: 2337
			[Token(Token = "0x2000921")]
			public class DailyMission
			{
				// Token: 0x060065F7 RID: 26103 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065F7")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DailyMission()
				{
				}

				// Token: 0x04003437 RID: 13367
				[Token(Token = "0x4003437")]
				[FieldOffset(Offset = "0x10")]
				public int process;

				// Token: 0x04003438 RID: 13368
				[Token(Token = "0x4003438")]
				[FieldOffset(Offset = "0x14")]
				public PlayerActivity.PlayerMultiplayV2Activity.DailyMissionState state;
			}

			// Token: 0x02000922 RID: 2338
			[Token(Token = "0x2000922")]
			public enum StageState
			{
				// Token: 0x0400343A RID: 13370
				[Token(Token = "0x400343A")]
				LOCK,
				// Token: 0x0400343B RID: 13371
				[Token(Token = "0x400343B")]
				UNLOCKED
			}

			// Token: 0x02000923 RID: 2339
			[Token(Token = "0x2000923")]
			public class StageInfo
			{
				// Token: 0x060065F8 RID: 26104 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065F8")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public StageInfo()
				{
				}

				// Token: 0x0400343C RID: 13372
				[Token(Token = "0x400343C")]
				[FieldOffset(Offset = "0x10")]
				public string stageId;

				// Token: 0x0400343D RID: 13373
				[Token(Token = "0x400343D")]
				[FieldOffset(Offset = "0x18")]
				public int score;

				// Token: 0x0400343E RID: 13374
				[Token(Token = "0x400343E")]
				[FieldOffset(Offset = "0x1C")]
				public PlayerActivity.PlayerMultiplayV2Activity.StageState state;

				// Token: 0x0400343F RID: 13375
				[Token(Token = "0x400343F")]
				[FieldOffset(Offset = "0x20")]
				public int startTimes;

				// Token: 0x04003440 RID: 13376
				[Token(Token = "0x4003440")]
				[FieldOffset(Offset = "0x24")]
				public int completeTimes;
			}

			// Token: 0x02000924 RID: 2340
			[Token(Token = "0x2000924")]
			public class Match
			{
				// Token: 0x060065F9 RID: 26105 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065F9")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Match()
				{
				}

				// Token: 0x04003441 RID: 13377
				[Token(Token = "0x4003441")]
				[FieldOffset(Offset = "0x10")]
				public int beMentorCnt;

				// Token: 0x04003442 RID: 13378
				[Token(Token = "0x4003442")]
				[FieldOffset(Offset = "0x14")]
				public bool lockMentor;

				// Token: 0x04003443 RID: 13379
				[Token(Token = "0x4003443")]
				[FieldOffset(Offset = "0x18")]
				public long bannedUntilTs;
			}

			// Token: 0x02000925 RID: 2341
			[Token(Token = "0x2000925")]
			public class MilestoneInfo
			{
				// Token: 0x060065FA RID: 26106 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065FA")]
				[Address(RVA = "0x1EEB790", Offset = "0x1EEA390", VA = "0x181EEB790")]
				public MilestoneInfo()
				{
				}

				// Token: 0x04003444 RID: 13380
				[Token(Token = "0x4003444")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x04003445 RID: 13381
				[Token(Token = "0x4003445")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}
		}

		// Token: 0x02000926 RID: 2342
		[Token(Token = "0x2000926")]
		public class PlayerMultiV3Activity
		{
			// Token: 0x060065FB RID: 26107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065FB")]
			[Address(RVA = "0x1EFB5F0", Offset = "0x1EFA1F0", VA = "0x181EFB5F0")]
			public PlayerMultiV3Activity()
			{
			}

			// Token: 0x04003446 RID: 13382
			[Token(Token = "0x4003446")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerMultiV3Activity.Collection collection;

			// Token: 0x04003447 RID: 13383
			[Token(Token = "0x4003447")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerMultiV3Activity.Troop troop;

			// Token: 0x04003448 RID: 13384
			[Token(Token = "0x4003448")]
			[FieldOffset(Offset = "0x20")]
			public PlayerActivity.PlayerMultiV3Activity.MatchInfo match;

			// Token: 0x04003449 RID: 13385
			[Token(Token = "0x4003449")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerMultiV3Activity.Milestone milestone;

			// Token: 0x0400344A RID: 13386
			[Token(Token = "0x400344A")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerMultiV3Activity.Daily daily;

			// Token: 0x0400344B RID: 13387
			[Token(Token = "0x400344B")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, PlayerActivity.PlayerMultiV3Activity.StageInfo> stage;

			// Token: 0x0400344C RID: 13388
			[Token(Token = "0x400344C")]
			[FieldOffset(Offset = "0x40")]
			public PlayerActivity.PlayerMultiV3Activity.Scene scene;

			// Token: 0x0400344D RID: 13389
			[Token(Token = "0x400344D")]
			[FieldOffset(Offset = "0x48")]
			public bool globalBan;

			// Token: 0x02000927 RID: 2343
			[Token(Token = "0x2000927")]
			public class Collection
			{
				// Token: 0x060065FC RID: 26108 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065FC")]
				[Address(RVA = "0x1EE7B00", Offset = "0x1EE6700", VA = "0x181EE7B00")]
				public Collection()
				{
				}

				// Token: 0x0400344E RID: 13390
				[Token(Token = "0x400344E")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerMultiV3Activity.CollectionInfo info;

				// Token: 0x0400344F RID: 13391
				[Token(Token = "0x400344F")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerMultiV3Activity.Title title;

				// Token: 0x04003450 RID: 13392
				[Token(Token = "0x4003450")]
				[FieldOffset(Offset = "0x20")]
				public PlayerActivity.PlayerMultiV3Activity.Photo photo;
			}

			// Token: 0x02000928 RID: 2344
			[Token(Token = "0x2000928")]
			public class CollectionInfo
			{
				// Token: 0x060065FD RID: 26109 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065FD")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CollectionInfo()
				{
				}

				// Token: 0x04003451 RID: 13393
				[Token(Token = "0x4003451")]
				[FieldOffset(Offset = "0x10")]
				public int finishCnt;

				// Token: 0x04003452 RID: 13394
				[Token(Token = "0x4003452")]
				[FieldOffset(Offset = "0x14")]
				public int mentorCnt;

				// Token: 0x04003453 RID: 13395
				[Token(Token = "0x4003453")]
				[FieldOffset(Offset = "0x18")]
				public int likeCnt;
			}

			// Token: 0x02000929 RID: 2345
			[Token(Token = "0x2000929")]
			public class Title
			{
				// Token: 0x060065FE RID: 26110 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065FE")]
				[Address(RVA = "0x1F02770", Offset = "0x1F01370", VA = "0x181F02770")]
				public Title()
				{
				}

				// Token: 0x04003454 RID: 13396
				[Token(Token = "0x4003454")]
				[FieldOffset(Offset = "0x10")]
				public List<string> unlock;

				// Token: 0x04003455 RID: 13397
				[Token(Token = "0x4003455")]
				[FieldOffset(Offset = "0x18")]
				public List<string> select;
			}

			// Token: 0x0200092A RID: 2346
			[Token(Token = "0x200092A")]
			public class Photo
			{
				// Token: 0x060065FF RID: 26111 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60065FF")]
				[Address(RVA = "0x1EEDCD0", Offset = "0x1EEC8D0", VA = "0x181EEDCD0")]
				public Photo()
				{
				}

				// Token: 0x04003456 RID: 13398
				[Token(Token = "0x4003456")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, Dictionary<string, PlayerActivity.PlayerMultiV3Activity.PhotoInstance>> template;

				// Token: 0x04003457 RID: 13399
				[Token(Token = "0x4003457")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerActivity.PlayerMultiV3Activity.Album> album;
			}

			// Token: 0x0200092B RID: 2347
			[Token(Token = "0x200092B")]
			public class PhotoInstance
			{
				// Token: 0x06006600 RID: 26112 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006600")]
				[Address(RVA = "0x1EED840", Offset = "0x1EEC440", VA = "0x181EED840")]
				public PhotoInstance()
				{
				}

				// Token: 0x04003458 RID: 13400
				[Token(Token = "0x4003458")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerMultiV3Activity.PhotoPlayerInfo players;

				// Token: 0x04003459 RID: 13401
				[Token(Token = "0x4003459")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerActivity.PlayerMultiV3Activity.PhotoCharInfo> chars;

				// Token: 0x0400345A RID: 13402
				[Token(Token = "0x400345A")]
				[FieldOffset(Offset = "0x20")]
				public string stageId;

				// Token: 0x0400345B RID: 13403
				[Token(Token = "0x400345B")]
				[FieldOffset(Offset = "0x28")]
				public long ts;
			}

			// Token: 0x0200092C RID: 2348
			[Token(Token = "0x200092C")]
			public class PhotoPlayerInfo
			{
				// Token: 0x06006601 RID: 26113 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006601")]
				[Address(RVA = "0x1EEDA90", Offset = "0x1EEC690", VA = "0x181EEDA90")]
				public PhotoPlayerInfo()
				{
				}

				// Token: 0x0400345C RID: 13404
				[Token(Token = "0x400345C")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerMultiV3Activity.PhotoSelfInfo mine;

				// Token: 0x0400345D RID: 13405
				[Token(Token = "0x400345D")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerMultiV3Activity.PhotoAssistInfo mate;
			}

			// Token: 0x0200092D RID: 2349
			[Token(Token = "0x200092D")]
			public class PhotoSelfInfo
			{
				// Token: 0x06006602 RID: 26114 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006602")]
				[Address(RVA = "0x1EEDC40", Offset = "0x1EEC840", VA = "0x181EEDC40")]
				public PhotoSelfInfo()
				{
				}

				// Token: 0x0400345E RID: 13406
				[Token(Token = "0x400345E")]
				[FieldOffset(Offset = "0x10")]
				public List<string> title;
			}

			// Token: 0x0200092E RID: 2350
			[Token(Token = "0x200092E")]
			public class PhotoAssistInfo : IPlayerStatus, IHotfixable
			{
				// Token: 0x06006603 RID: 26115 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6006603")]
				[Address(RVA = "0x1EED670", Offset = "0x1EEC270", VA = "0x181EED670", Slot = "4")]
				public AvatarInfo GetAvatarInfo()
				{
					return null;
				}

				// Token: 0x06006604 RID: 26116 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6006604")]
				[Address(RVA = "0x1EED6D0", Offset = "0x1EEC2D0", VA = "0x181EED6D0", Slot = "5")]
				public string GetSecretarySkinId()
				{
					return null;
				}

				// Token: 0x06006605 RID: 26117 RVA: 0x000308E8 File Offset: 0x0002EAE8
				[Token(Token = "0x6006605")]
				[Address(RVA = "0x1EED730", Offset = "0x1EEC330", VA = "0x181EED730", Slot = "6")]
				public bool GetSecretarySkinSp()
				{
					return default(bool);
				}

				// Token: 0x06006606 RID: 26118 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006606")]
				[Address(RVA = "0x1EED790", Offset = "0x1EEC390", VA = "0x181EED790")]
				public PhotoAssistInfo()
				{
				}

				// Token: 0x0400345F RID: 13407
				[Token(Token = "0x400345F")]
				[FieldOffset(Offset = "0x10")]
				public string uid;

				// Token: 0x04003460 RID: 13408
				[Token(Token = "0x4003460")]
				[FieldOffset(Offset = "0x18")]
				public bool sameChannel;

				// Token: 0x04003461 RID: 13409
				[Token(Token = "0x4003461")]
				[FieldOffset(Offset = "0x20")]
				public List<string> title;

				// Token: 0x04003462 RID: 13410
				[Token(Token = "0x4003462")]
				[FieldOffset(Offset = "0x28")]
				public string nickName;

				// Token: 0x04003463 RID: 13411
				[Token(Token = "0x4003463")]
				[FieldOffset(Offset = "0x30")]
				public AvatarInfo avatar;

				// Token: 0x04003464 RID: 13412
				[Token(Token = "0x4003464")]
				[FieldOffset(Offset = "0x38")]
				public string secretary;

				// Token: 0x04003465 RID: 13413
				[Token(Token = "0x4003465")]
				[FieldOffset(Offset = "0x40")]
				public string secretarySkinId;

				// Token: 0x04003466 RID: 13414
				[Token(Token = "0x4003466")]
				[FieldOffset(Offset = "0x48")]
				public bool secretarySkinSp;

				// Token: 0x04003467 RID: 13415
				[Token(Token = "0x4003467")]
				[FieldOffset(Offset = "0x4C")]
				public int level;

				// Token: 0x04003468 RID: 13416
				[Token(Token = "0x4003468")]
				[FieldOffset(Offset = "0x50")]
				public string nameCardSkinId;

				// Token: 0x04003469 RID: 13417
				[Token(Token = "0x4003469")]
				[FieldOffset(Offset = "0x58")]
				public int nameCardSkinTmpl;

				// Token: 0x0400346A RID: 13418
				[Token(Token = "0x400346A")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_GetAvatarInfo;

				// Token: 0x0400346B RID: 13419
				[Token(Token = "0x400346B")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GetSecretarySkinId;

				// Token: 0x0400346C RID: 13420
				[Token(Token = "0x400346C")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

				// Token: 0x0400346D RID: 13421
				[Token(Token = "0x400346D")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x0200092F RID: 2351
			[Token(Token = "0x200092F")]
			public class PhotoCharInfo
			{
				// Token: 0x06006607 RID: 26119 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006607")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PhotoCharInfo()
				{
				}

				// Token: 0x0400346E RID: 13422
				[Token(Token = "0x400346E")]
				[FieldOffset(Offset = "0x10")]
				public string charId;

				// Token: 0x0400346F RID: 13423
				[Token(Token = "0x400346F")]
				[FieldOffset(Offset = "0x18")]
				public string currentTmpl;

				// Token: 0x04003470 RID: 13424
				[Token(Token = "0x4003470")]
				[FieldOffset(Offset = "0x20")]
				public string skinId;

				// Token: 0x04003471 RID: 13425
				[Token(Token = "0x4003471")]
				[FieldOffset(Offset = "0x28")]
				public int slotIdx;

				// Token: 0x04003472 RID: 13426
				[Token(Token = "0x4003472")]
				[FieldOffset(Offset = "0x2C")]
				public int frame;

				// Token: 0x04003473 RID: 13427
				[Token(Token = "0x4003473")]
				[FieldOffset(Offset = "0x30")]
				public bool flip;
			}

			// Token: 0x02000930 RID: 2352
			[Token(Token = "0x2000930")]
			public class Album
			{
				// Token: 0x06006608 RID: 26120 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006608")]
				[Address(RVA = "0x1EE64C0", Offset = "0x1EE50C0", VA = "0x181EE64C0")]
				public Album()
				{
				}

				// Token: 0x04003474 RID: 13428
				[Token(Token = "0x4003474")]
				[FieldOffset(Offset = "0x10")]
				public bool commit;

				// Token: 0x04003475 RID: 13429
				[Token(Token = "0x4003475")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, string> slot;
			}

			// Token: 0x02000931 RID: 2353
			[Token(Token = "0x2000931")]
			public class Troop
			{
				// Token: 0x06006609 RID: 26121 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006609")]
				[Address(RVA = "0x1F02F10", Offset = "0x1F01B10", VA = "0x181F02F10")]
				public Troop()
				{
				}

				// Token: 0x04003476 RID: 13430
				[Token(Token = "0x4003476")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerMultiV3Activity.TroopBuff buff;

				// Token: 0x04003477 RID: 13431
				[Token(Token = "0x4003477")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerActivity.PlayerMultiV3Activity.Squad> squads;
			}

			// Token: 0x02000932 RID: 2354
			[Token(Token = "0x2000932")]
			public class TroopBuff
			{
				// Token: 0x0600660A RID: 26122 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600660A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public TroopBuff()
				{
				}

				// Token: 0x04003478 RID: 13432
				[Token(Token = "0x4003478")]
				[FieldOffset(Offset = "0x10")]
				public List<string> unlock;

				// Token: 0x04003479 RID: 13433
				[Token(Token = "0x4003479")]
				[FieldOffset(Offset = "0x18")]
				public int coin;

				// Token: 0x0400347A RID: 13434
				[Token(Token = "0x400347A")]
				[FieldOffset(Offset = "0x1C")]
				public int star;
			}

			// Token: 0x02000933 RID: 2355
			[Token(Token = "0x2000933")]
			public class Squad
			{
				// Token: 0x0600660B RID: 26123 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600660B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Squad()
				{
				}

				// Token: 0x0400347B RID: 13435
				[Token(Token = "0x400347B")]
				[FieldOffset(Offset = "0x10")]
				public List<PlayerActivity.PlayerMultiV3Activity.SquadItem> prefer;

				// Token: 0x0400347C RID: 13436
				[Token(Token = "0x400347C")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerActivity.PlayerMultiV3Activity.SquadItem> backup;

				// Token: 0x0400347D RID: 13437
				[Token(Token = "0x400347D")]
				[FieldOffset(Offset = "0x20")]
				public string buffId;
			}

			// Token: 0x02000934 RID: 2356
			[Token(Token = "0x2000934")]
			public class SquadItem : PlayerSquadMemberProto
			{
				// Token: 0x0600660C RID: 26124 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600660C")]
				[Address(RVA = "0x1F01D80", Offset = "0x1F00980", VA = "0x181F01D80")]
				public SquadItem()
				{
				}

				// Token: 0x0400347E RID: 13438
				[Token(Token = "0x400347E")]
				[FieldOffset(Offset = "0x30")]
				public int innerInstId;

				// Token: 0x0400347F RID: 13439
				[Token(Token = "0x400347F")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x02000935 RID: 2357
			[Token(Token = "0x2000935")]
			public class StageInfo
			{
				// Token: 0x0600660D RID: 26125 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600660D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public StageInfo()
				{
				}

				// Token: 0x04003480 RID: 13440
				[Token(Token = "0x4003480")]
				[FieldOffset(Offset = "0x10")]
				public int star;

				// Token: 0x04003481 RID: 13441
				[Token(Token = "0x4003481")]
				[FieldOffset(Offset = "0x18")]
				public long exScore;

				// Token: 0x04003482 RID: 13442
				[Token(Token = "0x4003482")]
				[FieldOffset(Offset = "0x20")]
				public int matchTimes;

				// Token: 0x04003483 RID: 13443
				[Token(Token = "0x4003483")]
				[FieldOffset(Offset = "0x24")]
				public int startTimes;

				// Token: 0x04003484 RID: 13444
				[Token(Token = "0x4003484")]
				[FieldOffset(Offset = "0x28")]
				public int finishTimes;
			}

			// Token: 0x02000936 RID: 2358
			[Token(Token = "0x2000936")]
			public class MatchInfo
			{
				// Token: 0x0600660E RID: 26126 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600660E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public MatchInfo()
				{
				}

				// Token: 0x04003485 RID: 13445
				[Token(Token = "0x4003485")]
				[FieldOffset(Offset = "0x10")]
				public long bannedUntilTs;

				// Token: 0x04003486 RID: 13446
				[Token(Token = "0x4003486")]
				[FieldOffset(Offset = "0x18")]
				public List<string> lastModeList;

				// Token: 0x04003487 RID: 13447
				[Token(Token = "0x4003487")]
				[FieldOffset(Offset = "0x20")]
				public ActMultiV3MatchPosType lastMentorType;

				// Token: 0x04003488 RID: 13448
				[Token(Token = "0x4003488")]
				[FieldOffset(Offset = "0x24")]
				public int lastReverse;
			}

			// Token: 0x02000937 RID: 2359
			[Token(Token = "0x2000937")]
			public class Milestone
			{
				// Token: 0x0600660F RID: 26127 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600660F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Milestone()
				{
				}

				// Token: 0x04003489 RID: 13449
				[Token(Token = "0x4003489")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x0400348A RID: 13450
				[Token(Token = "0x400348A")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x02000938 RID: 2360
			[Token(Token = "0x2000938")]
			public class Daily
			{
				// Token: 0x06006610 RID: 26128 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006610")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Daily()
				{
				}

				// Token: 0x0400348B RID: 13451
				[Token(Token = "0x400348B")]
				[FieldOffset(Offset = "0x10")]
				public int process;

				// Token: 0x0400348C RID: 13452
				[Token(Token = "0x400348C")]
				[FieldOffset(Offset = "0x14")]
				public int state;
			}

			// Token: 0x02000939 RID: 2361
			[Token(Token = "0x2000939")]
			public class Scene
			{
				// Token: 0x06006611 RID: 26129 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006611")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Scene()
				{
				}

				// Token: 0x0400348D RID: 13453
				[Token(Token = "0x400348D")]
				[FieldOffset(Offset = "0x10")]
				public List<string> lastMate;
			}
		}

		// Token: 0x0200093A RID: 2362
		[Token(Token = "0x200093A")]
		public class PlayerInterlockActivity
		{
			// Token: 0x06006612 RID: 26130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006612")]
			[Address(RVA = "0x1EFAEE0", Offset = "0x1EF9AE0", VA = "0x181EFAEE0")]
			public PlayerInterlockActivity()
			{
			}

			// Token: 0x0400348E RID: 13454
			[Token(Token = "0x400348E")]
			[FieldOffset(Offset = "0x10")]
			public int milestoneCoin;

			// Token: 0x0400348F RID: 13455
			[Token(Token = "0x400348F")]
			[FieldOffset(Offset = "0x18")]
			public List<string> milestoneGot;

			// Token: 0x04003490 RID: 13456
			[Token(Token = "0x4003490")]
			[FieldOffset(Offset = "0x20")]
			public string specialDefendStageId;

			// Token: 0x04003491 RID: 13457
			[Token(Token = "0x4003491")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, List<PlayerActivity.PlayerInterlockActivity.DefendCharData>> defend;

			// Token: 0x04003492 RID: 13458
			[Token(Token = "0x4003492")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, PlayerSquadItem[]> squad;

			// Token: 0x0200093B RID: 2363
			[Token(Token = "0x200093B")]
			public class DefendCharData
			{
				// Token: 0x06006613 RID: 26131 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006613")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DefendCharData()
				{
				}

				// Token: 0x04003493 RID: 13459
				[Token(Token = "0x4003493")]
				[FieldOffset(Offset = "0x10")]
				public int charInstId;

				// Token: 0x04003494 RID: 13460
				[Token(Token = "0x4003494")]
				[FieldOffset(Offset = "0x18")]
				public string currentTmpl;
			}
		}

		// Token: 0x0200093C RID: 2364
		[Token(Token = "0x200093C")]
		public class PlayerAct3D0Activity
		{
			// Token: 0x06006614 RID: 26132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006614")]
			[Address(RVA = "0x1EEEF90", Offset = "0x1EEDB90", VA = "0x181EEEF90")]
			public PlayerAct3D0Activity()
			{
			}

			// Token: 0x04003495 RID: 13461
			[Token(Token = "0x4003495")]
			[FieldOffset(Offset = "0x10")]
			public string faction;

			// Token: 0x04003496 RID: 13462
			[Token(Token = "0x4003496")]
			[FieldOffset(Offset = "0x18")]
			public int gachaCoin;

			// Token: 0x04003497 RID: 13463
			[Token(Token = "0x4003497")]
			[FieldOffset(Offset = "0x1C")]
			public int ticket;

			// Token: 0x04003498 RID: 13464
			[Token(Token = "0x4003498")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, int> clue;

			// Token: 0x04003499 RID: 13465
			[Token(Token = "0x4003499")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, PlayerActivity.PlayerAct3D0Activity.BoxState> box;

			// Token: 0x0400349A RID: 13466
			[Token(Token = "0x400349A")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerAct3D0Activity.MileStone milestone;

			// Token: 0x0400349B RID: 13467
			[Token(Token = "0x400349B")]
			[FieldOffset(Offset = "0x38")]
			public List<string> favorList;

			// Token: 0x0200093D RID: 2365
			[Token(Token = "0x200093D")]
			public class BoxState
			{
				// Token: 0x06006615 RID: 26133 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006615")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BoxState()
				{
				}

				// Token: 0x0400349C RID: 13468
				[Token(Token = "0x400349C")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, int> content;
			}

			// Token: 0x0200093E RID: 2366
			[Token(Token = "0x200093E")]
			public class MileStone
			{
				// Token: 0x06006616 RID: 26134 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006616")]
				[Address(RVA = "0x1EEB550", Offset = "0x1EEA150", VA = "0x181EEB550")]
				public MileStone()
				{
				}

				// Token: 0x0400349D RID: 13469
				[Token(Token = "0x400349D")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x0400349E RID: 13470
				[Token(Token = "0x400349E")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> rewards;
			}
		}

		// Token: 0x0200093F RID: 2367
		[Token(Token = "0x200093F")]
		public class PlayerAct4D0Activity
		{
			// Token: 0x06006617 RID: 26135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006617")]
			[Address(RVA = "0x1EEF520", Offset = "0x1EEE120", VA = "0x181EEF520")]
			public PlayerAct4D0Activity()
			{
			}

			// Token: 0x0400349F RID: 13471
			[Token(Token = "0x400349F")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> story;

			// Token: 0x040034A0 RID: 13472
			[Token(Token = "0x40034A0")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerAct4D0Activity.MileStone milestone;

			// Token: 0x02000940 RID: 2368
			[Token(Token = "0x2000940")]
			public class MileStone
			{
				// Token: 0x06006618 RID: 26136 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006618")]
				[Address(RVA = "0x1EEB4C0", Offset = "0x1EEA0C0", VA = "0x181EEB4C0")]
				public MileStone()
				{
				}

				// Token: 0x040034A1 RID: 13473
				[Token(Token = "0x40034A1")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x040034A2 RID: 13474
				[Token(Token = "0x40034A2")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> rewards;
			}
		}

		// Token: 0x02000941 RID: 2369
		[Token(Token = "0x2000941")]
		public class PlayerAct5D0Activity
		{
			// Token: 0x06006619 RID: 26137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006619")]
			[Address(RVA = "0x1EEF600", Offset = "0x1EEE200", VA = "0x181EEF600")]
			public PlayerAct5D0Activity()
			{
			}

			// Token: 0x040034A3 RID: 13475
			[Token(Token = "0x40034A3")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("point_reward")]
			public MileStonePlayerInfo milestone;
		}

		// Token: 0x02000942 RID: 2370
		[Token(Token = "0x2000942")]
		public class PlayerAct5D1Activity
		{
			// Token: 0x0600661A RID: 26138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600661A")]
			[Address(RVA = "0x1EEF730", Offset = "0x1EEE330", VA = "0x181EEF730")]
			public PlayerAct5D1Activity()
			{
			}

			// Token: 0x040034A4 RID: 13476
			[Token(Token = "0x40034A4")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x040034A5 RID: 13477
			[Token(Token = "0x40034A5")]
			[FieldOffset(Offset = "0x14")]
			public int pt;

			// Token: 0x040034A6 RID: 13478
			[Token(Token = "0x40034A6")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerAct5D1Activity.PlayerAct5D1Shop shop;

			// Token: 0x040034A7 RID: 13479
			[Token(Token = "0x40034A7")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerAct5D1Activity.PlayerActRuneStage> runeStage;

			// Token: 0x040034A8 RID: 13480
			[Token(Token = "0x40034A8")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, List<string>> stageEnemy;

			// Token: 0x02000943 RID: 2371
			[Token(Token = "0x2000943")]
			public class PlayerAct5D1Shop
			{
				// Token: 0x0600661B RID: 26139 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600661B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerAct5D1Shop()
				{
				}

				// Token: 0x040034A9 RID: 13481
				[Token(Token = "0x40034A9")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, int> info;

				// Token: 0x040034AA RID: 13482
				[Token(Token = "0x40034AA")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerActivity.PlayerAct5D1Activity.PlayerAct5D1Shop.ProgressInfo> progressInfo;

				// Token: 0x02000944 RID: 2372
				[Token(Token = "0x2000944")]
				public class ProgressInfo
				{
					// Token: 0x0600661C RID: 26140 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600661C")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public ProgressInfo()
					{
					}

					// Token: 0x040034AB RID: 13483
					[Token(Token = "0x40034AB")]
					[FieldOffset(Offset = "0x10")]
					public int count;

					// Token: 0x040034AC RID: 13484
					[Token(Token = "0x40034AC")]
					[FieldOffset(Offset = "0x14")]
					public int order;
				}
			}

			// Token: 0x02000945 RID: 2373
			[Token(Token = "0x2000945")]
			public class PlayerActRuneStage
			{
				// Token: 0x0600661D RID: 26141 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600661D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerActRuneStage()
				{
				}

				// Token: 0x040034AD RID: 13485
				[Token(Token = "0x40034AD")]
				[FieldOffset(Offset = "0x10")]
				public string schedule;

				// Token: 0x040034AE RID: 13486
				[Token(Token = "0x40034AE")]
				[FieldOffset(Offset = "0x18")]
				public int available;

				// Token: 0x040034AF RID: 13487
				[Token(Token = "0x40034AF")]
				[FieldOffset(Offset = "0x1C")]
				public int scores;

				// Token: 0x040034B0 RID: 13488
				[Token(Token = "0x40034B0")]
				[FieldOffset(Offset = "0x20")]
				public Dictionary<string, int> rune;
			}
		}

		// Token: 0x02000946 RID: 2374
		[Token(Token = "0x2000946")]
		public class PlayerAct9D0Activity
		{
			// Token: 0x0600661E RID: 26142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600661E")]
			[Address(RVA = "0x1EEF800", Offset = "0x1EEE400", VA = "0x181EEF800")]
			public PlayerAct9D0Activity()
			{
			}

			// Token: 0x040034B1 RID: 13489
			[Token(Token = "0x40034B1")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x040034B2 RID: 13490
			[Token(Token = "0x40034B2")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x040034B3 RID: 13491
			[Token(Token = "0x40034B3")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, long> news;

			// Token: 0x040034B4 RID: 13492
			[Token(Token = "0x40034B4")]
			[FieldOffset(Offset = "0x28")]
			public int campaignCnt;
		}

		// Token: 0x02000947 RID: 2375
		[Token(Token = "0x2000947")]
		public class PlayerAct12sideActivity
		{
			// Token: 0x0600661F RID: 26143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600661F")]
			[Address(RVA = "0x1EEDDA0", Offset = "0x1EEC9A0", VA = "0x181EEDDA0")]
			public PlayerAct12sideActivity()
			{
			}

			// Token: 0x040034B5 RID: 13493
			[Token(Token = "0x40034B5")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x040034B6 RID: 13494
			[Token(Token = "0x40034B6")]
			[FieldOffset(Offset = "0x14")]
			public int campaignCnt;

			// Token: 0x040034B7 RID: 13495
			[Token(Token = "0x40034B7")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x040034B8 RID: 13496
			[Token(Token = "0x40034B8")]
			[FieldOffset(Offset = "0x20")]
			public PlayerActivity.PlayerAct12sideActivity.MilestoneInfo milestone;

			// Token: 0x040034B9 RID: 13497
			[Token(Token = "0x40034B9")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAct12sideActivity.CharmInfo charm;

			// Token: 0x02000948 RID: 2376
			[Token(Token = "0x2000948")]
			public class MilestoneInfo
			{
				// Token: 0x06006620 RID: 26144 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006620")]
				[Address(RVA = "0x1EEB700", Offset = "0x1EEA300", VA = "0x181EEB700")]
				public MilestoneInfo()
				{
				}

				// Token: 0x040034BA RID: 13498
				[Token(Token = "0x40034BA")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x040034BB RID: 13499
				[Token(Token = "0x40034BB")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x02000949 RID: 2377
			[Token(Token = "0x2000949")]
			public class CharmInfo
			{
				// Token: 0x06006621 RID: 26145 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006621")]
				[Address(RVA = "0x1EE7860", Offset = "0x1EE6460", VA = "0x181EE7860")]
				public CharmInfo()
				{
				}

				// Token: 0x040034BC RID: 13500
				[Token(Token = "0x40034BC")]
				[FieldOffset(Offset = "0x10")]
				public int recycleStack;

				// Token: 0x040034BD RID: 13501
				[Token(Token = "0x40034BD")]
				[FieldOffset(Offset = "0x18")]
				public List<string> firstGotReward;
			}
		}

		// Token: 0x0200094A RID: 2378
		[Token(Token = "0x200094A")]
		public class PlayerAct13sideActivity
		{
			// Token: 0x06006622 RID: 26146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006622")]
			[Address(RVA = "0x1EEDE30", Offset = "0x1EECA30", VA = "0x181EEDE30")]
			public PlayerAct13sideActivity()
			{
			}

			// Token: 0x040034BE RID: 13502
			[Token(Token = "0x40034BE")]
			[FieldOffset(Offset = "0x10")]
			public int token;

			// Token: 0x040034BF RID: 13503
			[Token(Token = "0x40034BF")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x040034C0 RID: 13504
			[Token(Token = "0x40034C0")]
			[FieldOffset(Offset = "0x20")]
			public PlayerActivity.PlayerAct13sideActivity.MilestoneInfo milestone;

			// Token: 0x040034C1 RID: 13505
			[Token(Token = "0x40034C1")]
			[FieldOffset(Offset = "0x28")]
			public int agenda;

			// Token: 0x040034C2 RID: 13506
			[Token(Token = "0x40034C2")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerAct13sideActivity.Flag flag;

			// Token: 0x040034C3 RID: 13507
			[Token(Token = "0x40034C3")]
			[FieldOffset(Offset = "0x38")]
			public PlayerActivity.PlayerAct13sideActivity.DailyMissionPoolData mission;

			// Token: 0x0200094B RID: 2379
			[Token(Token = "0x200094B")]
			public class MilestoneInfo
			{
				// Token: 0x06006623 RID: 26147 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006623")]
				[Address(RVA = "0x1EEB820", Offset = "0x1EEA420", VA = "0x181EEB820")]
				public MilestoneInfo()
				{
				}

				// Token: 0x040034C4 RID: 13508
				[Token(Token = "0x40034C4")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x040034C5 RID: 13509
				[Token(Token = "0x40034C5")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x0200094C RID: 2380
			[Token(Token = "0x200094C")]
			public class Flag
			{
				// Token: 0x06006624 RID: 26148 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006624")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Flag()
				{
				}

				// Token: 0x040034C6 RID: 13510
				[Token(Token = "0x40034C6")]
				[FieldOffset(Offset = "0x10")]
				public bool agenda;

				// Token: 0x040034C7 RID: 13511
				[Token(Token = "0x40034C7")]
				[FieldOffset(Offset = "0x11")]
				public bool mission;
			}

			// Token: 0x0200094D RID: 2381
			[Token(Token = "0x200094D")]
			public class SearchReward
			{
				// Token: 0x06006625 RID: 26149 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006625")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SearchReward()
				{
				}

				// Token: 0x040034C8 RID: 13512
				[Token(Token = "0x40034C8")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x040034C9 RID: 13513
				[Token(Token = "0x40034C9")]
				[FieldOffset(Offset = "0x18")]
				[JsonConverter(typeof(StringEnumConverter))]
				public ItemType type;
			}

			// Token: 0x0200094E RID: 2382
			[Token(Token = "0x200094E")]
			public class SearchCondition
			{
				// Token: 0x06006626 RID: 26150 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006626")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SearchCondition()
				{
				}

				// Token: 0x040034CA RID: 13514
				[Token(Token = "0x40034CA")]
				[FieldOffset(Offset = "0x10")]
				public string orgId;

				// Token: 0x040034CB RID: 13515
				[Token(Token = "0x40034CB")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct13sideActivity.SearchReward reward;
			}

			// Token: 0x0200094F RID: 2383
			[Token(Token = "0x200094F")]
			public class DailyMissionData
			{
				// Token: 0x06006627 RID: 26151 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006627")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DailyMissionData()
				{
				}

				// Token: 0x040034CC RID: 13516
				[Token(Token = "0x40034CC")]
				[FieldOffset(Offset = "0x10")]
				public string missionId;

				// Token: 0x040034CD RID: 13517
				[Token(Token = "0x40034CD")]
				[FieldOffset(Offset = "0x18")]
				public string orgId;

				// Token: 0x040034CE RID: 13518
				[Token(Token = "0x40034CE")]
				[FieldOffset(Offset = "0x20")]
				public string principalId;

				// Token: 0x040034CF RID: 13519
				[Token(Token = "0x40034CF")]
				[FieldOffset(Offset = "0x28")]
				public int principalDescIdx;

				// Token: 0x040034D0 RID: 13520
				[Token(Token = "0x40034D0")]
				[FieldOffset(Offset = "0x30")]
				public string rewardGroupId;
			}

			// Token: 0x02000950 RID: 2384
			[Token(Token = "0x2000950")]
			public class DailyMissionProgress
			{
				// Token: 0x06006628 RID: 26152 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006628")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DailyMissionProgress()
				{
				}

				// Token: 0x040034D1 RID: 13521
				[Token(Token = "0x40034D1")]
				[FieldOffset(Offset = "0x10")]
				public int target;

				// Token: 0x040034D2 RID: 13522
				[Token(Token = "0x40034D2")]
				[FieldOffset(Offset = "0x14")]
				public int value;
			}

			// Token: 0x02000951 RID: 2385
			[Token(Token = "0x2000951")]
			public class DailyMissionWithProgressData
			{
				// Token: 0x06006629 RID: 26153 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006629")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DailyMissionWithProgressData()
				{
				}

				// Token: 0x040034D3 RID: 13523
				[Token(Token = "0x40034D3")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerAct13sideActivity.DailyMissionData mission;

				// Token: 0x040034D4 RID: 13524
				[Token(Token = "0x40034D4")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct13sideActivity.DailyMissionProgress progress;
			}

			// Token: 0x02000952 RID: 2386
			[Token(Token = "0x2000952")]
			public class DailyMissionPoolData
			{
				// Token: 0x0600662A RID: 26154 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600662A")]
				[Address(RVA = "0x1EE9330", Offset = "0x1EE7F30", VA = "0x181EE9330")]
				public DailyMissionPoolData()
				{
				}

				// Token: 0x040034D5 RID: 13525
				[Token(Token = "0x40034D5")]
				[FieldOffset(Offset = "0x10")]
				public int random;

				// Token: 0x040034D6 RID: 13526
				[Token(Token = "0x40034D6")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct13sideActivity.SearchCondition condition;

				// Token: 0x040034D7 RID: 13527
				[Token(Token = "0x40034D7")]
				[FieldOffset(Offset = "0x20")]
				public List<PlayerActivity.PlayerAct13sideActivity.DailyMissionData> pool;

				// Token: 0x040034D8 RID: 13528
				[Token(Token = "0x40034D8")]
				[FieldOffset(Offset = "0x28")]
				public List<PlayerActivity.PlayerAct13sideActivity.DailyMissionWithProgressData> board;
			}
		}

		// Token: 0x02000953 RID: 2387
		[Token(Token = "0x2000953")]
		public class PlayerAct17D7Activity
		{
			// Token: 0x0600662B RID: 26155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600662B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerAct17D7Activity()
			{
			}

			// Token: 0x040034D9 RID: 13529
			[Token(Token = "0x40034D9")]
			[FieldOffset(Offset = "0x10")]
			public bool isOpen;
		}

		// Token: 0x02000954 RID: 2388
		[Token(Token = "0x2000954")]
		public class PlayerAprilFoolActivity
		{
			// Token: 0x0600662C RID: 26156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600662C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerAprilFoolActivity()
			{
			}

			// Token: 0x040034DA RID: 13530
			[Token(Token = "0x40034DA")]
			[FieldOffset(Offset = "0x10")]
			public bool isOpen;
		}

		// Token: 0x02000955 RID: 2389
		[Token(Token = "0x2000955")]
		public class PlayerAct17SideActivity
		{
			// Token: 0x0600662D RID: 26157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600662D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerAct17SideActivity()
			{
			}

			// Token: 0x040034DB RID: 13531
			[Token(Token = "0x40034DB")]
			[FieldOffset(Offset = "0x10")]
			public bool isOpen;

			// Token: 0x040034DC RID: 13532
			[Token(Token = "0x40034DC")]
			[FieldOffset(Offset = "0x14")]
			public int coin;

			// Token: 0x040034DD RID: 13533
			[Token(Token = "0x40034DD")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;
		}

		// Token: 0x02000956 RID: 2390
		[Token(Token = "0x2000956")]
		public class PlayerBossRushActivity
		{
			// Token: 0x0600662E RID: 26158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600662E")]
			[Address(RVA = "0x1EF12C0", Offset = "0x1EEFEC0", VA = "0x181EF12C0")]
			public PlayerBossRushActivity()
			{
			}

			// Token: 0x040034DE RID: 13534
			[Token(Token = "0x40034DE")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerBossRushActivity.MilestoneInfo milestone;

			// Token: 0x040034DF RID: 13535
			[Token(Token = "0x40034DF")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerBossRushActivity.RelicInfo relic;

			// Token: 0x040034E0 RID: 13536
			[Token(Token = "0x40034E0")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty("best")]
			public Dictionary<string, int> bestWaveDic;

			// Token: 0x02000957 RID: 2391
			[Token(Token = "0x2000957")]
			public class MilestoneInfo
			{
				// Token: 0x0600662F RID: 26159 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600662F")]
				[Address(RVA = "0x1EEB8B0", Offset = "0x1EEA4B0", VA = "0x181EEB8B0")]
				public MilestoneInfo()
				{
				}

				// Token: 0x040034E1 RID: 13537
				[Token(Token = "0x40034E1")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x040034E2 RID: 13538
				[Token(Token = "0x40034E2")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x02000958 RID: 2392
			[Token(Token = "0x2000958")]
			public class TokenInfo
			{
				// Token: 0x06006630 RID: 26160 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006630")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public TokenInfo()
				{
				}

				// Token: 0x040034E3 RID: 13539
				[Token(Token = "0x40034E3")]
				[FieldOffset(Offset = "0x10")]
				public int current;

				// Token: 0x040034E4 RID: 13540
				[Token(Token = "0x40034E4")]
				[FieldOffset(Offset = "0x14")]
				public int total;
			}

			// Token: 0x02000959 RID: 2393
			[Token(Token = "0x2000959")]
			public class RelicInfo
			{
				// Token: 0x06006631 RID: 26161 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006631")]
				[Address(RVA = "0x1F00630", Offset = "0x1EFF230", VA = "0x181F00630")]
				public RelicInfo()
				{
				}

				// Token: 0x040034E5 RID: 13541
				[Token(Token = "0x40034E5")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerBossRushActivity.TokenInfo token;

				// Token: 0x040034E6 RID: 13542
				[Token(Token = "0x40034E6")]
				[FieldOffset(Offset = "0x18")]
				[JsonProperty("level")]
				public Dictionary<string, int> unlockedRelicLevelDic;

				// Token: 0x040034E7 RID: 13543
				[Token(Token = "0x40034E7")]
				[FieldOffset(Offset = "0x20")]
				[JsonProperty("select")]
				public string selectingRelicId;
			}
		}

		// Token: 0x0200095A RID: 2394
		[Token(Token = "0x200095A")]
		public class PlayerEnemyDuelActivity
		{
			// Token: 0x06006632 RID: 26162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006632")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerEnemyDuelActivity()
			{
			}

			// Token: 0x040034E8 RID: 13544
			[Token(Token = "0x40034E8")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerEnemyDuelActivity.MilestoneInfo milestone;

			// Token: 0x040034E9 RID: 13545
			[Token(Token = "0x40034E9")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerEnemyDuelActivity.DailyMission dailyMission;

			// Token: 0x040034EA RID: 13546
			[Token(Token = "0x40034EA")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerEnemyDuelActivity.ModeInfo> modeInfo;

			// Token: 0x040034EB RID: 13547
			[Token(Token = "0x40034EB")]
			[FieldOffset(Offset = "0x28")]
			public bool globalBan;

			// Token: 0x0200095B RID: 2395
			[Token(Token = "0x200095B")]
			public class MilestoneInfo
			{
				// Token: 0x06006633 RID: 26163 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006633")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public MilestoneInfo()
				{
				}

				// Token: 0x040034EC RID: 13548
				[Token(Token = "0x40034EC")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x040034ED RID: 13549
				[Token(Token = "0x40034ED")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x0200095C RID: 2396
			[Token(Token = "0x200095C")]
			public enum DailyMissionState
			{
				// Token: 0x040034EF RID: 13551
				[Token(Token = "0x40034EF")]
				NOT_CLAIM,
				// Token: 0x040034F0 RID: 13552
				[Token(Token = "0x40034F0")]
				CLAIMED
			}

			// Token: 0x0200095D RID: 2397
			[Token(Token = "0x200095D")]
			public class DailyMission
			{
				// Token: 0x06006634 RID: 26164 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006634")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DailyMission()
				{
				}

				// Token: 0x040034F1 RID: 13553
				[Token(Token = "0x40034F1")]
				[FieldOffset(Offset = "0x10")]
				public int process;

				// Token: 0x040034F2 RID: 13554
				[Token(Token = "0x40034F2")]
				[FieldOffset(Offset = "0x14")]
				public PlayerActivity.PlayerEnemyDuelActivity.DailyMissionState state;
			}

			// Token: 0x0200095E RID: 2398
			[Token(Token = "0x200095E")]
			public class ModeInfo
			{
				// Token: 0x06006635 RID: 26165 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006635")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ModeInfo()
				{
				}

				// Token: 0x040034F3 RID: 13555
				[Token(Token = "0x40034F3")]
				[FieldOffset(Offset = "0x10")]
				public int highScore;

				// Token: 0x040034F4 RID: 13556
				[Token(Token = "0x40034F4")]
				[FieldOffset(Offset = "0x18")]
				public string curStage;

				// Token: 0x040034F5 RID: 13557
				[Token(Token = "0x40034F5")]
				[FieldOffset(Offset = "0x20")]
				public bool isUnlock;
			}
		}

		// Token: 0x0200095F RID: 2399
		[Token(Token = "0x200095F")]
		public class PlayerVecBreakV2
		{
			// Token: 0x06006636 RID: 26166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006636")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerVecBreakV2()
			{
			}

			// Token: 0x040034F6 RID: 13558
			[Token(Token = "0x40034F6")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.MilestoneInfo milestone;

			// Token: 0x040034F7 RID: 13559
			[Token(Token = "0x40034F7")]
			[FieldOffset(Offset = "0x18")]
			public List<string> activatedBuff;

			// Token: 0x040034F8 RID: 13560
			[Token(Token = "0x40034F8")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerVecBreakV2.DefendStageInfo> defendStages;

			// Token: 0x02000960 RID: 2400
			[Token(Token = "0x2000960")]
			public class DefendCharInfo
			{
				// Token: 0x06006637 RID: 26167 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006637")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DefendCharInfo()
				{
				}

				// Token: 0x040034F9 RID: 13561
				[Token(Token = "0x40034F9")]
				[FieldOffset(Offset = "0x10")]
				public int charInstId;

				// Token: 0x040034FA RID: 13562
				[Token(Token = "0x40034FA")]
				[FieldOffset(Offset = "0x18")]
				public string currentTmpl;
			}

			// Token: 0x02000961 RID: 2401
			[Token(Token = "0x2000961")]
			public class DefendStageInfo
			{
				// Token: 0x06006638 RID: 26168 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006638")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DefendStageInfo()
				{
				}

				// Token: 0x040034FB RID: 13563
				[Token(Token = "0x40034FB")]
				[FieldOffset(Offset = "0x10")]
				public string stageId;

				// Token: 0x040034FC RID: 13564
				[Token(Token = "0x40034FC")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerActivity.PlayerVecBreakV2.DefendCharInfo> defendSquad;

				// Token: 0x040034FD RID: 13565
				[Token(Token = "0x40034FD")]
				[FieldOffset(Offset = "0x20")]
				public bool recvTimeLimited;

				// Token: 0x040034FE RID: 13566
				[Token(Token = "0x40034FE")]
				[FieldOffset(Offset = "0x21")]
				public bool recvNormal;
			}
		}

		// Token: 0x02000962 RID: 2402
		[Token(Token = "0x2000962")]
		public class PlayerArcadeActivity
		{
			// Token: 0x06006639 RID: 26169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006639")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerArcadeActivity()
			{
			}

			// Token: 0x040034FF RID: 13567
			[Token(Token = "0x40034FF")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerArcadeActivity.MilestoneInfo milestone;

			// Token: 0x04003500 RID: 13568
			[Token(Token = "0x4003500")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerActivity.PlayerArcadeActivity.BadgeInfo> badge;

			// Token: 0x04003501 RID: 13569
			[Token(Token = "0x4003501")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, Dictionary<string, int>> score;

			// Token: 0x02000963 RID: 2403
			[Token(Token = "0x2000963")]
			public class MilestoneInfo
			{
				// Token: 0x0600663A RID: 26170 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600663A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public MilestoneInfo()
				{
				}

				// Token: 0x04003502 RID: 13570
				[Token(Token = "0x4003502")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x04003503 RID: 13571
				[Token(Token = "0x4003503")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x02000964 RID: 2404
			[Token(Token = "0x2000964")]
			public enum BadgeStatus
			{
				// Token: 0x04003505 RID: 13573
				[Token(Token = "0x4003505")]
				Error,
				// Token: 0x04003506 RID: 13574
				[Token(Token = "0x4003506")]
				InProgress,
				// Token: 0x04003507 RID: 13575
				[Token(Token = "0x4003507")]
				Unlocked
			}

			// Token: 0x02000965 RID: 2405
			[Token(Token = "0x2000965")]
			public class BadgeInfo
			{
				// Token: 0x17000CE4 RID: 3300
				// (get) Token: 0x0600663B RID: 26171 RVA: 0x00030900 File Offset: 0x0002EB00
				[Token(Token = "0x17000CE4")]
				public int missionCurProgress
				{
					[Token(Token = "0x600663B")]
					[Address(RVA = "0x1EE67D0", Offset = "0x1EE53D0", VA = "0x181EE67D0")]
					get
					{
						return 0;
					}
				}

				// Token: 0x17000CE5 RID: 3301
				// (get) Token: 0x0600663C RID: 26172 RVA: 0x00030918 File Offset: 0x0002EB18
				[Token(Token = "0x17000CE5")]
				public int missionTargetProgress
				{
					[Token(Token = "0x600663C")]
					[Address(RVA = "0x1EE6810", Offset = "0x1EE5410", VA = "0x181EE6810")]
					get
					{
						return 0;
					}
				}

				// Token: 0x0600663D RID: 26173 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600663D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BadgeInfo()
				{
				}

				// Token: 0x04003508 RID: 13576
				[Token(Token = "0x4003508")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerArcadeActivity.BadgeStatus status;

				// Token: 0x04003509 RID: 13577
				[Token(Token = "0x4003509")]
				[FieldOffset(Offset = "0x18")]
				[JsonProperty("missionProgress")]
				private int[] m_missionProgress;
			}
		}

		// Token: 0x02000966 RID: 2406
		[Token(Token = "0x2000966")]
		public class PlayerAct20SideActivity
		{
			// Token: 0x0600663E RID: 26174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600663E")]
			[Address(RVA = "0x1EEE190", Offset = "0x1EECD90", VA = "0x181EEE190")]
			public PlayerAct20SideActivity()
			{
			}

			// Token: 0x0400350A RID: 13578
			[Token(Token = "0x400350A")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerAct20SideActivity.ActBaseInfo actBase;

			// Token: 0x0400350B RID: 13579
			[Token(Token = "0x400350B")]
			[FieldOffset(Offset = "0x18")]
			public int dailyJudgeTimes;

			// Token: 0x0400350C RID: 13580
			[Token(Token = "0x400350C")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerAct20SideActivity.EntertainCompBestRecord> entertainmentCompetition;

			// Token: 0x0400350D RID: 13581
			[Token(Token = "0x400350D")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAct20SideActivity.HotValueInfo hotValue;

			// Token: 0x0400350E RID: 13582
			[Token(Token = "0x400350E")]
			[FieldOffset(Offset = "0x30")]
			public bool hasJoinedExhibition;

			// Token: 0x0400350F RID: 13583
			[Token(Token = "0x400350F")]
			[FieldOffset(Offset = "0x34")]
			public int campaignCnt;

			// Token: 0x04003510 RID: 13584
			[Token(Token = "0x4003510")]
			[FieldOffset(Offset = "0x38")]
			public List<string> favorList;

			// Token: 0x02000967 RID: 2407
			[Token(Token = "0x2000967")]
			public class ActBaseInfo
			{
				// Token: 0x0600663F RID: 26175 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600663F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ActBaseInfo()
				{
				}

				// Token: 0x04003511 RID: 13585
				[Token(Token = "0x4003511")]
				[FieldOffset(Offset = "0x10")]
				public int actCoin;

				// Token: 0x04003512 RID: 13586
				[Token(Token = "0x4003512")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct20SideActivity.MilestoneStateInfo milestone;
			}

			// Token: 0x02000968 RID: 2408
			[Token(Token = "0x2000968")]
			public class MilestoneStateInfo
			{
				// Token: 0x06006640 RID: 26176 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006640")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public MilestoneStateInfo()
				{
				}

				// Token: 0x04003513 RID: 13587
				[Token(Token = "0x4003513")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x04003514 RID: 13588
				[Token(Token = "0x4003514")]
				[FieldOffset(Offset = "0x14")]
				[JsonProperty("got")]
				public int claimedCount;
			}

			// Token: 0x02000969 RID: 2409
			[Token(Token = "0x2000969")]
			public class HotValueInfo
			{
				// Token: 0x06006641 RID: 26177 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006641")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public HotValueInfo()
				{
				}

				// Token: 0x04003515 RID: 13589
				[Token(Token = "0x4003515")]
				[FieldOffset(Offset = "0x10")]
				public int hotVal;

				// Token: 0x04003516 RID: 13590
				[Token(Token = "0x4003516")]
				[FieldOffset(Offset = "0x14")]
				public int dailyHotVal;
			}

			// Token: 0x0200096A RID: 2410
			[Token(Token = "0x200096A")]
			public class EntertainCompBestRecord
			{
				// Token: 0x06006642 RID: 26178 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006642")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public EntertainCompBestRecord()
				{
				}

				// Token: 0x04003517 RID: 13591
				[Token(Token = "0x4003517")]
				[FieldOffset(Offset = "0x10")]
				public int performance;

				// Token: 0x04003518 RID: 13592
				[Token(Token = "0x4003518")]
				[FieldOffset(Offset = "0x14")]
				public int expression;

				// Token: 0x04003519 RID: 13593
				[Token(Token = "0x4003519")]
				[FieldOffset(Offset = "0x18")]
				public int operation;

				// Token: 0x0400351A RID: 13594
				[Token(Token = "0x400351A")]
				[FieldOffset(Offset = "0x1C")]
				public CartCompetitionRank level;
			}
		}

		// Token: 0x0200096B RID: 2411
		[Token(Token = "0x200096B")]
		public class PlayerActFloatParadeActivity
		{
			// Token: 0x06006643 RID: 26179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006643")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerActFloatParadeActivity()
			{
			}

			// Token: 0x0400351B RID: 13595
			[Token(Token = "0x400351B")]
			[FieldOffset(Offset = "0x10")]
			public int day;

			// Token: 0x0400351C RID: 13596
			[Token(Token = "0x400351C")]
			[FieldOffset(Offset = "0x14")]
			public bool canRaffle;

			// Token: 0x0400351D RID: 13597
			[Token(Token = "0x400351D")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerActFloatParadeActivity.Result result;

			// Token: 0x0200096C RID: 2412
			[Token(Token = "0x200096C")]
			public class Result
			{
				// Token: 0x06006644 RID: 26180 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006644")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Result()
				{
				}

				// Token: 0x0400351E RID: 13598
				[Token(Token = "0x400351E")]
				[FieldOffset(Offset = "0x10")]
				public int strategy;

				// Token: 0x0400351F RID: 13599
				[Token(Token = "0x400351F")]
				[FieldOffset(Offset = "0x18")]
				public string eventId;
			}
		}

		// Token: 0x0200096D RID: 2413
		[Token(Token = "0x200096D")]
		public class PlayerAct21SideActivity
		{
			// Token: 0x06006645 RID: 26181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006645")]
			[Address(RVA = "0x1EEE260", Offset = "0x1EECE60", VA = "0x181EEE260")]
			public PlayerAct21SideActivity()
			{
			}

			// Token: 0x04003520 RID: 13600
			[Token(Token = "0x4003520")]
			[FieldOffset(Offset = "0x10")]
			public bool isOpen;

			// Token: 0x04003521 RID: 13601
			[Token(Token = "0x4003521")]
			[FieldOffset(Offset = "0x14")]
			public int coin;

			// Token: 0x04003522 RID: 13602
			[Token(Token = "0x4003522")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;
		}

		// Token: 0x0200096E RID: 2414
		[Token(Token = "0x200096E")]
		public class PlayerActMainlineBuff
		{
			// Token: 0x06006646 RID: 26182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006646")]
			[Address(RVA = "0x1EEFB20", Offset = "0x1EEE720", VA = "0x181EEFB20")]
			public PlayerActMainlineBuff()
			{
			}

			// Token: 0x04003523 RID: 13603
			[Token(Token = "0x4003523")]
			[FieldOffset(Offset = "0x10")]
			public List<string> favorList;
		}

		// Token: 0x0200096F RID: 2415
		[Token(Token = "0x200096F")]
		public class PlayerAct24SideActivity
		{
			// Token: 0x06006647 RID: 26183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006647")]
			[Address(RVA = "0x1EEE2F0", Offset = "0x1EECEF0", VA = "0x181EEE2F0")]
			public PlayerAct24SideActivity()
			{
			}

			// Token: 0x04003524 RID: 13604
			[Token(Token = "0x4003524")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerAct24SideActivity.Meal meal;

			// Token: 0x04003525 RID: 13605
			[Token(Token = "0x4003525")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerAct24SideActivity.Alchemy alchemy;

			// Token: 0x04003526 RID: 13606
			[Token(Token = "0x4003526")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerAct24SideActivity.ToolState> tool;

			// Token: 0x04003527 RID: 13607
			[Token(Token = "0x4003527")]
			[FieldOffset(Offset = "0x28")]
			public List<string> favorList;

			// Token: 0x04003528 RID: 13608
			[Token(Token = "0x4003528")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerAct24SideActivity.Hunt hunt;

			// Token: 0x04003529 RID: 13609
			[Token(Token = "0x4003529")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, int> unlockItemMap;

			// Token: 0x02000970 RID: 2416
			[Token(Token = "0x2000970")]
			public enum ToolState
			{
				// Token: 0x0400352B RID: 13611
				[Token(Token = "0x400352B")]
				LOCK,
				// Token: 0x0400352C RID: 13612
				[Token(Token = "0x400352C")]
				UNSELECT,
				// Token: 0x0400352D RID: 13613
				[Token(Token = "0x400352D")]
				SELECT
			}

			// Token: 0x02000971 RID: 2417
			[Token(Token = "0x2000971")]
			public class Meal
			{
				// Token: 0x06006648 RID: 26184 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006648")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Meal()
				{
				}

				// Token: 0x0400352E RID: 13614
				[Token(Token = "0x400352E")]
				[FieldOffset(Offset = "0x10")]
				public int chance;

				// Token: 0x0400352F RID: 13615
				[Token(Token = "0x400352F")]
				[FieldOffset(Offset = "0x18")]
				public string id;

				// Token: 0x04003530 RID: 13616
				[Token(Token = "0x4003530")]
				[FieldOffset(Offset = "0x20")]
				public bool digested;
			}

			// Token: 0x02000972 RID: 2418
			[Token(Token = "0x2000972")]
			public class Alchemy
			{
				// Token: 0x06006649 RID: 26185 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006649")]
				[Address(RVA = "0x1EE6550", Offset = "0x1EE5150", VA = "0x181EE6550")]
				public Alchemy()
				{
				}

				// Token: 0x04003531 RID: 13617
				[Token(Token = "0x4003531")]
				[FieldOffset(Offset = "0x10")]
				public int price;

				// Token: 0x04003532 RID: 13618
				[Token(Token = "0x4003532")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> item;

				// Token: 0x04003533 RID: 13619
				[Token(Token = "0x4003533")]
				[FieldOffset(Offset = "0x20")]
				public Dictionary<string, Dictionary<string, int>> gacha;
			}

			// Token: 0x02000973 RID: 2419
			[Token(Token = "0x2000973")]
			public class Hunt
			{
				// Token: 0x0600664A RID: 26186 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600664A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Hunt()
				{
				}

				// Token: 0x04003534 RID: 13620
				[Token(Token = "0x4003534")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, int> infoBook;

				// Token: 0x04003535 RID: 13621
				[Token(Token = "0x4003535")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> enemyKillCntStats;

				// Token: 0x04003536 RID: 13622
				[Token(Token = "0x4003536")]
				[FieldOffset(Offset = "0x20")]
				public int collectRewards;
			}
		}

		// Token: 0x02000974 RID: 2420
		[Token(Token = "0x2000974")]
		public class PlayerAct25SideActivity
		{
			// Token: 0x0600664B RID: 26187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600664B")]
			[Address(RVA = "0x1EEE580", Offset = "0x1EED180", VA = "0x181EEE580")]
			public PlayerAct25SideActivity()
			{
			}

			// Token: 0x04003537 RID: 13623
			[Token(Token = "0x4003537")]
			[FieldOffset(Offset = "0x10")]
			public int investigativeToken;

			// Token: 0x04003538 RID: 13624
			[Token(Token = "0x4003538")]
			[FieldOffset(Offset = "0x14")]
			public int actCoin;

			// Token: 0x04003539 RID: 13625
			[Token(Token = "0x4003539")]
			[FieldOffset(Offset = "0x18")]
			public bool dailyTokenRefresh;

			// Token: 0x0400353A RID: 13626
			[Token(Token = "0x400353A")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerAct25SideActivity.Area> areas;

			// Token: 0x0400353B RID: 13627
			[Token(Token = "0x400353B")]
			[FieldOffset(Offset = "0x28")]
			public List<string> favorList;

			// Token: 0x0400353C RID: 13628
			[Token(Token = "0x400353C")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerAct25SideActivity.DailyHarvest incremenalGame;

			// Token: 0x0400353D RID: 13629
			[Token(Token = "0x400353D")]
			[FieldOffset(Offset = "0x38")]
			public int tokenRecvCnt;

			// Token: 0x0400353E RID: 13630
			[Token(Token = "0x400353E")]
			[FieldOffset(Offset = "0x40")]
			public List<string> buff;

			// Token: 0x02000975 RID: 2421
			[Token(Token = "0x2000975")]
			public enum MissionState
			{
				// Token: 0x04003540 RID: 13632
				[Token(Token = "0x4003540")]
				UNFINISH,
				// Token: 0x04003541 RID: 13633
				[Token(Token = "0x4003541")]
				FINISHED,
				// Token: 0x04003542 RID: 13634
				[Token(Token = "0x4003542")]
				OBTAINED
			}

			// Token: 0x02000976 RID: 2422
			[Token(Token = "0x2000976")]
			public class MissionProgress
			{
				// Token: 0x0600664C RID: 26188 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600664C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public MissionProgress()
				{
				}

				// Token: 0x04003543 RID: 13635
				[Token(Token = "0x4003543")]
				[FieldOffset(Offset = "0x10")]
				public int target;

				// Token: 0x04003544 RID: 13636
				[Token(Token = "0x4003544")]
				[FieldOffset(Offset = "0x14")]
				public int value;
			}

			// Token: 0x02000977 RID: 2423
			[Token(Token = "0x2000977")]
			public class Mission
			{
				// Token: 0x0600664D RID: 26189 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600664D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Mission()
				{
				}

				// Token: 0x04003545 RID: 13637
				[Token(Token = "0x4003545")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerAct25SideActivity.MissionState state;

				// Token: 0x04003546 RID: 13638
				[Token(Token = "0x4003546")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct25SideActivity.MissionProgress progress;
			}

			// Token: 0x02000978 RID: 2424
			[Token(Token = "0x2000978")]
			public class Area
			{
				// Token: 0x0600664E RID: 26190 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600664E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Area()
				{
				}

				// Token: 0x04003547 RID: 13639
				[Token(Token = "0x4003547")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerActivity.PlayerAct25SideActivity.Mission> missions;

				// Token: 0x04003548 RID: 13640
				[Token(Token = "0x4003548")]
				[FieldOffset(Offset = "0x18")]
				public string missionId;

				// Token: 0x04003549 RID: 13641
				[Token(Token = "0x4003549")]
				[FieldOffset(Offset = "0x20")]
				public string lastFinMissionId;
			}

			// Token: 0x02000979 RID: 2425
			[Token(Token = "0x2000979")]
			public class DailyHarvest
			{
				// Token: 0x0600664F RID: 26191 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600664F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DailyHarvest()
				{
				}

				// Token: 0x0400354A RID: 13642
				[Token(Token = "0x400354A")]
				[FieldOffset(Offset = "0x10")]
				public long[] harvenessTimeline;

				// Token: 0x0400354B RID: 13643
				[Token(Token = "0x400354B")]
				[FieldOffset(Offset = "0x18")]
				public int additionalHarvest;

				// Token: 0x0400354C RID: 13644
				[Token(Token = "0x400354C")]
				[FieldOffset(Offset = "0x1C")]
				public int currentRate;

				// Token: 0x0400354D RID: 13645
				[Token(Token = "0x400354D")]
				[FieldOffset(Offset = "0x20")]
				public int preparedRate;

				// Token: 0x0400354E RID: 13646
				[Token(Token = "0x400354E")]
				[FieldOffset(Offset = "0x28")]
				public long lastHarvenessTs;
			}
		}

		// Token: 0x0200097A RID: 2426
		[Token(Token = "0x200097A")]
		public class PlayerAct27SideActivity
		{
			// Token: 0x06006650 RID: 26192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006650")]
			[Address(RVA = "0x1EEE640", Offset = "0x1EED240", VA = "0x181EEE640")]
			public PlayerAct27SideActivity()
			{
			}

			// Token: 0x0400354F RID: 13647
			[Token(Token = "0x400354F")]
			[FieldOffset(Offset = "0x10")]
			public int day;

			// Token: 0x04003550 RID: 13648
			[Token(Token = "0x4003550")]
			[FieldOffset(Offset = "0x14")]
			public bool signedIn;

			// Token: 0x04003551 RID: 13649
			[Token(Token = "0x4003551")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> stock;

			// Token: 0x04003552 RID: 13650
			[Token(Token = "0x4003552")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle reward;

			// Token: 0x04003553 RID: 13651
			[Token(Token = "0x4003553")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAct27SideActivity.SaleState state;

			// Token: 0x04003554 RID: 13652
			[Token(Token = "0x4003554")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerAct27SideActivity.Sale sale;

			// Token: 0x04003555 RID: 13653
			[Token(Token = "0x4003555")]
			[FieldOffset(Offset = "0x38")]
			public PlayerActivity.PlayerAct27SideActivity.MilestoneInfo milestone;

			// Token: 0x04003556 RID: 13654
			[Token(Token = "0x4003556")]
			[FieldOffset(Offset = "0x40")]
			public List<string> favorList;

			// Token: 0x04003557 RID: 13655
			[Token(Token = "0x4003557")]
			[FieldOffset(Offset = "0x48")]
			public int coin;

			// Token: 0x04003558 RID: 13656
			[Token(Token = "0x4003558")]
			[FieldOffset(Offset = "0x4C")]
			public int campaignCnt;

			// Token: 0x0200097B RID: 2427
			[Token(Token = "0x200097B")]
			public enum SaleState
			{
				// Token: 0x0400355A RID: 13658
				[Token(Token = "0x400355A")]
				BEFORE_SALE,
				// Token: 0x0400355B RID: 13659
				[Token(Token = "0x400355B")]
				PURCHASE,
				// Token: 0x0400355C RID: 13660
				[Token(Token = "0x400355C")]
				SELL,
				// Token: 0x0400355D RID: 13661
				[Token(Token = "0x400355D")]
				BEFORE_SETTLE,
				// Token: 0x0400355E RID: 13662
				[Token(Token = "0x400355E")]
				AFTER_SETTLE
			}

			// Token: 0x0200097C RID: 2428
			[Token(Token = "0x200097C")]
			public enum SellGoodState
			{
				// Token: 0x04003560 RID: 13664
				[Token(Token = "0x4003560")]
				NONE,
				// Token: 0x04003561 RID: 13665
				[Token(Token = "0x4003561")]
				DRINK,
				// Token: 0x04003562 RID: 13666
				[Token(Token = "0x4003562")]
				FOOD,
				// Token: 0x04003563 RID: 13667
				[Token(Token = "0x4003563")]
				SOUVENIR
			}

			// Token: 0x0200097D RID: 2429
			[Token(Token = "0x200097D")]
			public class InquireInfo
			{
				// Token: 0x06006651 RID: 26193 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006651")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public InquireInfo()
				{
				}

				// Token: 0x04003564 RID: 13668
				[Token(Token = "0x4003564")]
				[FieldOffset(Offset = "0x10")]
				public int cur;

				// Token: 0x04003565 RID: 13669
				[Token(Token = "0x4003565")]
				[FieldOffset(Offset = "0x14")]
				public int max;
			}

			// Token: 0x0200097E RID: 2430
			[Token(Token = "0x200097E")]
			public class PrePurchaseInfo
			{
				// Token: 0x06006652 RID: 26194 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006652")]
				[Address(RVA = "0x1EFFDE0", Offset = "0x1EFE9E0", VA = "0x181EFFDE0")]
				public PrePurchaseInfo()
				{
				}

				// Token: 0x04003566 RID: 13670
				[Token(Token = "0x4003566")]
				[FieldOffset(Offset = "0x10")]
				public int strategy;

				// Token: 0x04003567 RID: 13671
				[Token(Token = "0x4003567")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int[]> shops;
			}

			// Token: 0x0200097F RID: 2431
			[Token(Token = "0x200097F")]
			public class PurchaseInfo
			{
				// Token: 0x06006653 RID: 26195 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006653")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PurchaseInfo()
				{
				}

				// Token: 0x04003568 RID: 13672
				[Token(Token = "0x4003568")]
				[FieldOffset(Offset = "0x10")]
				public int strategy;

				// Token: 0x04003569 RID: 13673
				[Token(Token = "0x4003569")]
				[FieldOffset(Offset = "0x14")]
				public int count;
			}

			// Token: 0x02000980 RID: 2432
			[Token(Token = "0x2000980")]
			public class PreSellInfo
			{
				// Token: 0x06006654 RID: 26196 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006654")]
				[Address(RVA = "0x1EFFE70", Offset = "0x1EFEA70", VA = "0x181EFFE70")]
				public PreSellInfo()
				{
				}

				// Token: 0x0400356A RID: 13674
				[Token(Token = "0x400356A")]
				[FieldOffset(Offset = "0x10")]
				public int price;

				// Token: 0x0400356B RID: 13675
				[Token(Token = "0x400356B")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int[]> shops;
			}

			// Token: 0x02000981 RID: 2433
			[Token(Token = "0x2000981")]
			public class SellInfo
			{
				// Token: 0x06006655 RID: 26197 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006655")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SellInfo()
				{
				}

				// Token: 0x0400356C RID: 13676
				[Token(Token = "0x400356C")]
				[FieldOffset(Offset = "0x10")]
				public int price;

				// Token: 0x0400356D RID: 13677
				[Token(Token = "0x400356D")]
				[FieldOffset(Offset = "0x14")]
				public int count;

				// Token: 0x0400356E RID: 13678
				[Token(Token = "0x400356E")]
				[FieldOffset(Offset = "0x18")]
				public int bonus;
			}

			// Token: 0x02000982 RID: 2434
			[Token(Token = "0x2000982")]
			public class Sale
			{
				// Token: 0x06006656 RID: 26198 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006656")]
				[Address(RVA = "0x1F011F0", Offset = "0x1EFFDF0", VA = "0x181F011F0")]
				public Sale()
				{
				}

				// Token: 0x0400356F RID: 13679
				[Token(Token = "0x400356F")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerAct27SideActivity.SellGoodState stateSell;

				// Token: 0x04003570 RID: 13680
				[Token(Token = "0x4003570")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct27SideActivity.InquireInfo inquire;

				// Token: 0x04003571 RID: 13681
				[Token(Token = "0x4003571")]
				[FieldOffset(Offset = "0x20")]
				public string groupId;

				// Token: 0x04003572 RID: 13682
				[Token(Token = "0x4003572")]
				[FieldOffset(Offset = "0x28")]
				public Dictionary<string, int> buyers;

				// Token: 0x04003573 RID: 13683
				[Token(Token = "0x4003573")]
				[FieldOffset(Offset = "0x30")]
				public Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PrePurchaseInfo[]> purchasesTmp;

				// Token: 0x04003574 RID: 13684
				[Token(Token = "0x4003574")]
				[FieldOffset(Offset = "0x38")]
				public Dictionary<string, Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PurchaseInfo>> purchases;

				// Token: 0x04003575 RID: 13685
				[Token(Token = "0x4003575")]
				[FieldOffset(Offset = "0x40")]
				public Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PreSellInfo[]> sellsTmp;

				// Token: 0x04003576 RID: 13686
				[Token(Token = "0x4003576")]
				[FieldOffset(Offset = "0x48")]
				public Dictionary<string, Dictionary<string, PlayerActivity.PlayerAct27SideActivity.SellInfo>> sells;
			}

			// Token: 0x02000983 RID: 2435
			[Token(Token = "0x2000983")]
			public class MilestoneInfo
			{
				// Token: 0x06006657 RID: 26199 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006657")]
				[Address(RVA = "0x1EEB670", Offset = "0x1EEA270", VA = "0x181EEB670")]
				public MilestoneInfo()
				{
				}

				// Token: 0x04003577 RID: 13687
				[Token(Token = "0x4003577")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x04003578 RID: 13688
				[Token(Token = "0x4003578")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}
		}

		// Token: 0x02000984 RID: 2436
		[Token(Token = "0x2000984")]
		public class PlayerAct42D0Activity
		{
			// Token: 0x06006658 RID: 26200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006658")]
			[Address(RVA = "0x1EEF110", Offset = "0x1EEDD10", VA = "0x181EEF110")]
			public PlayerAct42D0Activity()
			{
			}

			// Token: 0x04003579 RID: 13689
			[Token(Token = "0x4003579")]
			[FieldOffset(Offset = "0x10")]
			public int milestone;

			// Token: 0x0400357A RID: 13690
			[Token(Token = "0x400357A")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerActivity.PlayerAct42D0Activity.AreaInfo> areas;

			// Token: 0x0400357B RID: 13691
			[Token(Token = "0x400357B")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerAct42D0Activity.ChallengeStageInfo> spStages;

			// Token: 0x0400357C RID: 13692
			[Token(Token = "0x400357C")]
			[FieldOffset(Offset = "0x28")]
			public List<string> milestoneRecv;

			// Token: 0x0400357D RID: 13693
			[Token(Token = "0x400357D")]
			[FieldOffset(Offset = "0x30")]
			public string theHardestStage;

			// Token: 0x02000985 RID: 2437
			[Token(Token = "0x2000985")]
			public class AreaInfo
			{
				// Token: 0x06006659 RID: 26201 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006659")]
				[Address(RVA = "0x1EE6620", Offset = "0x1EE5220", VA = "0x181EE6620")]
				public AreaInfo()
				{
				}

				// Token: 0x0400357E RID: 13694
				[Token(Token = "0x400357E")]
				[FieldOffset(Offset = "0x10")]
				public bool canUseBuff;

				// Token: 0x0400357F RID: 13695
				[Token(Token = "0x400357F")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerActivity.PlayerAct42D0Activity.NoramlStageInfo> stages;
			}

			// Token: 0x02000986 RID: 2438
			[Token(Token = "0x2000986")]
			public class NoramlStageInfo
			{
				// Token: 0x0600665A RID: 26202 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600665A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public NoramlStageInfo()
				{
				}

				// Token: 0x04003580 RID: 13696
				[Token(Token = "0x4003580")]
				[FieldOffset(Offset = "0x10")]
				public int rating;
			}

			// Token: 0x02000987 RID: 2439
			[Token(Token = "0x2000987")]
			public class ChallengeStageInfo
			{
				// Token: 0x0600665B RID: 26203 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600665B")]
				[Address(RVA = "0x1EE73B0", Offset = "0x1EE5FB0", VA = "0x181EE73B0")]
				public ChallengeStageInfo()
				{
				}

				// Token: 0x04003581 RID: 13697
				[Token(Token = "0x4003581")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerActivity.PlayerAct42D0Activity.ChallengeStageMissionInfo> missions;
			}

			// Token: 0x02000988 RID: 2440
			[Token(Token = "0x2000988")]
			public class ChallengeStageMissionInfo
			{
				// Token: 0x0600665C RID: 26204 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600665C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ChallengeStageMissionInfo()
				{
				}

				// Token: 0x04003582 RID: 13698
				[Token(Token = "0x4003582")]
				[FieldOffset(Offset = "0x10")]
				public int target;

				// Token: 0x04003583 RID: 13699
				[Token(Token = "0x4003583")]
				[FieldOffset(Offset = "0x14")]
				public int value;

				// Token: 0x04003584 RID: 13700
				[Token(Token = "0x4003584")]
				[FieldOffset(Offset = "0x18")]
				public int state;
			}
		}

		// Token: 0x02000989 RID: 2441
		[Token(Token = "0x2000989")]
		public class PlayerUniqueOnlyActivity
		{
			// Token: 0x0600665D RID: 26205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600665D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerUniqueOnlyActivity()
			{
			}

			// Token: 0x04003585 RID: 13701
			[Token(Token = "0x4003585")]
			[FieldOffset(Offset = "0x10")]
			public int reward;
		}

		// Token: 0x0200098A RID: 2442
		[Token(Token = "0x200098A")]
		public class PlayerBlessOnlyActivity
		{
			// Token: 0x0600665E RID: 26206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600665E")]
			[Address(RVA = "0x1EF1160", Offset = "0x1EEFD60", VA = "0x181EF1160")]
			public PlayerBlessOnlyActivity()
			{
			}

			// Token: 0x04003586 RID: 13702
			[Token(Token = "0x4003586")]
			[FieldOffset(Offset = "0x10")]
			public List<int> history;

			// Token: 0x04003587 RID: 13703
			[Token(Token = "0x4003587")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerActivity.PlayerBlessOnlyActivity.BlessOnlyFestival> festivalHistory;

			// Token: 0x04003588 RID: 13704
			[Token(Token = "0x4003588")]
			[FieldOffset(Offset = "0x20")]
			public long lastTs;

			// Token: 0x0200098B RID: 2443
			[Token(Token = "0x200098B")]
			public class BlessOnlyFestival
			{
				// Token: 0x0600665F RID: 26207 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600665F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BlessOnlyFestival()
				{
				}

				// Token: 0x04003589 RID: 13705
				[Token(Token = "0x4003589")]
				[FieldOffset(Offset = "0x10")]
				public int state;

				// Token: 0x0400358A RID: 13706
				[Token(Token = "0x400358A")]
				[FieldOffset(Offset = "0x18")]
				public string charId;
			}
		}

		// Token: 0x0200098C RID: 2444
		[Token(Token = "0x200098C")]
		public class PlayerRecruitOnlyAct
		{
			// Token: 0x06006660 RID: 26208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006660")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerRecruitOnlyAct()
			{
			}

			// Token: 0x0400358B RID: 13707
			[Token(Token = "0x400358B")]
			[FieldOffset(Offset = "0x10")]
			public int used;
		}

		// Token: 0x0200098D RID: 2445
		[Token(Token = "0x200098D")]
		public class PlayerAct29SideActivity
		{
			// Token: 0x06006661 RID: 26209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006661")]
			[Address(RVA = "0x1EEE990", Offset = "0x1EED590", VA = "0x181EEE990")]
			public PlayerAct29SideActivity()
			{
			}

			// Token: 0x0400358C RID: 13708
			[Token(Token = "0x400358C")]
			[FieldOffset(Offset = "0x10")]
			public int actCoin;

			// Token: 0x0400358D RID: 13709
			[Token(Token = "0x400358D")]
			[FieldOffset(Offset = "0x14")]
			public int accessToken;

			// Token: 0x0400358E RID: 13710
			[Token(Token = "0x400358E")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x0400358F RID: 13711
			[Token(Token = "0x400358F")]
			[FieldOffset(Offset = "0x20")]
			public bool rareMelodyMade;

			// Token: 0x04003590 RID: 13712
			[Token(Token = "0x4003590")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAct29SideActivity.MajorNpcInfo majorNPC;

			// Token: 0x04003591 RID: 13713
			[Token(Token = "0x4003591")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty("hidenNPC")]
			public PlayerActivity.PlayerAct29SideActivity.HiddenNpcInfo hiddenNPC;

			// Token: 0x04003592 RID: 13714
			[Token(Token = "0x4003592")]
			[FieldOffset(Offset = "0x38")]
			public PlayerActivity.PlayerAct29SideActivity.DailyNpcInfo dailyNPC;

			// Token: 0x04003593 RID: 13715
			[Token(Token = "0x4003593")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, int> fragmentBag;

			// Token: 0x04003594 RID: 13716
			[Token(Token = "0x4003594")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<string, int> melodyBag;

			// Token: 0x04003595 RID: 13717
			[Token(Token = "0x4003595")]
			[FieldOffset(Offset = "0x50")]
			public Dictionary<string, int> melodyNax;

			// Token: 0x04003596 RID: 13718
			[Token(Token = "0x4003596")]
			[FieldOffset(Offset = "0x58")]
			public Dictionary<string, int> majorFinDic;

			// Token: 0x0200098E RID: 2446
			[Token(Token = "0x200098E")]
			public class NpcInfo
			{
				// Token: 0x06006662 RID: 26210 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006662")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public NpcInfo()
				{
				}

				// Token: 0x04003597 RID: 13719
				[Token(Token = "0x4003597")]
				[FieldOffset(Offset = "0x10")]
				public string npc;

				// Token: 0x04003598 RID: 13720
				[Token(Token = "0x4003598")]
				[FieldOffset(Offset = "0x18")]
				public int tryTimes;

				// Token: 0x04003599 RID: 13721
				[Token(Token = "0x4003599")]
				[FieldOffset(Offset = "0x1C")]
				public bool hasRecv;
			}

			// Token: 0x0200098F RID: 2447
			[Token(Token = "0x200098F")]
			public class MajorNpcInfo
			{
				// Token: 0x06006663 RID: 26211 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006663")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public MajorNpcInfo()
				{
				}

				// Token: 0x0400359A RID: 13722
				[Token(Token = "0x400359A")]
				[FieldOffset(Offset = "0x10")]
				public bool isOpen;

				// Token: 0x0400359B RID: 13723
				[Token(Token = "0x400359B")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct29SideActivity.NpcInfo npc;
			}

			// Token: 0x02000990 RID: 2448
			[Token(Token = "0x2000990")]
			public class HiddenNpcInfo
			{
				// Token: 0x06006664 RID: 26212 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006664")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public HiddenNpcInfo()
				{
				}

				// Token: 0x0400359C RID: 13724
				[Token(Token = "0x400359C")]
				[FieldOffset(Offset = "0x10")]
				public bool needShow;

				// Token: 0x0400359D RID: 13725
				[Token(Token = "0x400359D")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct29SideActivity.NpcInfo npc;
			}

			// Token: 0x02000991 RID: 2449
			[Token(Token = "0x2000991")]
			public class DailyNpcInfo
			{
				// Token: 0x06006665 RID: 26213 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006665")]
				[Address(RVA = "0x1EE9440", Offset = "0x1EE8040", VA = "0x181EE9440")]
				public DailyNpcInfo()
				{
				}

				// Token: 0x0400359E RID: 13726
				[Token(Token = "0x400359E")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerActivity.PlayerAct29SideActivity.NpcInfo> slot;
			}
		}

		// Token: 0x02000992 RID: 2450
		[Token(Token = "0x2000992")]
		public class PlayerYear5GeneralActivity
		{
			// Token: 0x06006666 RID: 26214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006666")]
			[Address(RVA = "0x1EFFD50", Offset = "0x1EFE950", VA = "0x181EFFD50")]
			public PlayerYear5GeneralActivity()
			{
			}

			// Token: 0x0400359F RID: 13727
			[Token(Token = "0x400359F")]
			[FieldOffset(Offset = "0x10")]
			public int unconfirmedPoints;

			// Token: 0x040035A0 RID: 13728
			[Token(Token = "0x40035A0")]
			[FieldOffset(Offset = "0x14")]
			public int nextRewardIndex;

			// Token: 0x040035A1 RID: 13729
			[Token(Token = "0x40035A1")]
			[FieldOffset(Offset = "0x18")]
			public int coin;

			// Token: 0x040035A2 RID: 13730
			[Token(Token = "0x40035A2")]
			[FieldOffset(Offset = "0x20")]
			public List<string> favorList;
		}

		// Token: 0x02000993 RID: 2451
		[Token(Token = "0x2000993")]
		public class PlayerAct36SideActivity
		{
			// Token: 0x06006667 RID: 26215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006667")]
			[Address(RVA = "0x1EEED10", Offset = "0x1EED910", VA = "0x181EEED10")]
			public PlayerAct36SideActivity()
			{
			}

			// Token: 0x040035A3 RID: 13731
			[Token(Token = "0x40035A3")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("dexNav")]
			public PlayerActivity.PlayerAct36SideActivity.FoodHandbookInfo foodHandbookInfo;

			// Token: 0x040035A4 RID: 13732
			[Token(Token = "0x40035A4")]
			[FieldOffset(Offset = "0x18")]
			public int coin;

			// Token: 0x040035A5 RID: 13733
			[Token(Token = "0x40035A5")]
			[FieldOffset(Offset = "0x20")]
			public List<string> favorList;

			// Token: 0x02000994 RID: 2452
			[Token(Token = "0x2000994")]
			public enum RewardState
			{
				// Token: 0x040035A7 RID: 13735
				[Token(Token = "0x40035A7")]
				UNFINISH,
				// Token: 0x040035A8 RID: 13736
				[Token(Token = "0x40035A8")]
				FINISHED,
				// Token: 0x040035A9 RID: 13737
				[Token(Token = "0x40035A9")]
				CLAIMED
			}

			// Token: 0x02000995 RID: 2453
			[Token(Token = "0x2000995")]
			public class FoodHandbookInfo
			{
				// Token: 0x06006668 RID: 26216 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006668")]
				[Address(RVA = "0x1EEA270", Offset = "0x1EE8E70", VA = "0x181EEA270")]
				public FoodHandbookInfo()
				{
				}

				// Token: 0x040035AA RID: 13738
				[Token(Token = "0x40035AA")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, bool> enemySlot;

				// Token: 0x040035AB RID: 13739
				[Token(Token = "0x40035AB")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, bool> food;

				// Token: 0x040035AC RID: 13740
				[Token(Token = "0x40035AC")]
				[FieldOffset(Offset = "0x20")]
				public PlayerActivity.PlayerAct36SideActivity.RewardState rewardState;
			}
		}

		// Token: 0x02000996 RID: 2454
		[Token(Token = "0x2000996")]
		public class PlayerAct35SideActivity
		{
			// Token: 0x06006669 RID: 26217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006669")]
			[Address(RVA = "0x1EEEB00", Offset = "0x1EED700", VA = "0x181EEEB00")]
			public PlayerAct35SideActivity()
			{
			}

			// Token: 0x040035AD RID: 13741
			[Token(Token = "0x40035AD")]
			[FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerAct35SideActivity.PlayerAct35SideCarving carving;

			// Token: 0x040035AE RID: 13742
			[Token(Token = "0x40035AE")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> unlock;

			// Token: 0x040035AF RID: 13743
			[Token(Token = "0x40035AF")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, int> record;

			// Token: 0x040035B0 RID: 13744
			[Token(Token = "0x40035B0")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAct35SideActivity.MilestoneState milestone;

			// Token: 0x040035B1 RID: 13745
			[Token(Token = "0x40035B1")]
			[FieldOffset(Offset = "0x30")]
			public int coin;

			// Token: 0x040035B2 RID: 13746
			[Token(Token = "0x40035B2")]
			[FieldOffset(Offset = "0x34")]
			public int campaignCnt;

			// Token: 0x040035B3 RID: 13747
			[Token(Token = "0x40035B3")]
			[FieldOffset(Offset = "0x38")]
			public List<string> favorList;

			// Token: 0x02000997 RID: 2455
			[Token(Token = "0x2000997")]
			public enum GameState
			{
				// Token: 0x040035B5 RID: 13749
				[Token(Token = "0x40035B5")]
				NONE,
				// Token: 0x040035B6 RID: 13750
				[Token(Token = "0x40035B6")]
				BUY,
				// Token: 0x040035B7 RID: 13751
				[Token(Token = "0x40035B7")]
				PROCESS,
				// Token: 0x040035B8 RID: 13752
				[Token(Token = "0x40035B8")]
				NEXT,
				// Token: 0x040035B9 RID: 13753
				[Token(Token = "0x40035B9")]
				SETTLE,
				// Token: 0x040035BA RID: 13754
				[Token(Token = "0x40035BA")]
				INFO
			}

			// Token: 0x02000998 RID: 2456
			[Token(Token = "0x2000998")]
			public class PlayerAct35SideCarving
			{
				// Token: 0x0600666A RID: 26218 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600666A")]
				[Address(RVA = "0x1EEEC50", Offset = "0x1EED850", VA = "0x181EEEC50")]
				public PlayerAct35SideCarving()
				{
				}

				// Token: 0x040035BB RID: 13755
				[Token(Token = "0x40035BB")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x040035BC RID: 13756
				[Token(Token = "0x40035BC")]
				[FieldOffset(Offset = "0x18")]
				public int round;

				// Token: 0x040035BD RID: 13757
				[Token(Token = "0x40035BD")]
				[FieldOffset(Offset = "0x1C")]
				public int score;

				// Token: 0x040035BE RID: 13758
				[Token(Token = "0x40035BE")]
				[FieldOffset(Offset = "0x20")]
				public PlayerActivity.PlayerAct35SideActivity.GameState state;

				// Token: 0x040035BF RID: 13759
				[Token(Token = "0x40035BF")]
				[FieldOffset(Offset = "0x24")]
				public int roundCoinAdd;

				// Token: 0x040035C0 RID: 13760
				[Token(Token = "0x40035C0")]
				[FieldOffset(Offset = "0x28")]
				public Dictionary<string, int> material;

				// Token: 0x040035C1 RID: 13761
				[Token(Token = "0x40035C1")]
				[FieldOffset(Offset = "0x30")]
				public Dictionary<string, int> card;

				// Token: 0x040035C2 RID: 13762
				[Token(Token = "0x40035C2")]
				[FieldOffset(Offset = "0x38")]
				public int slotCnt;

				// Token: 0x040035C3 RID: 13763
				[Token(Token = "0x40035C3")]
				[FieldOffset(Offset = "0x40")]
				public PlayerActivity.PlayerAct35SideActivity.PlayerAct35SideCarvingShop shop;

				// Token: 0x040035C4 RID: 13764
				[Token(Token = "0x40035C4")]
				[FieldOffset(Offset = "0x48")]
				public PlayerActivity.PlayerAct35SideActivity.CarvingTask mission;
			}

			// Token: 0x02000999 RID: 2457
			[Token(Token = "0x2000999")]
			public class PlayerAct35SideCarvingShop
			{
				// Token: 0x0600666B RID: 26219 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600666B")]
				[Address(RVA = "0x1EEEBC0", Offset = "0x1EED7C0", VA = "0x181EEEBC0")]
				public PlayerAct35SideCarvingShop()
				{
				}

				// Token: 0x040035C5 RID: 13765
				[Token(Token = "0x40035C5")]
				[FieldOffset(Offset = "0x10")]
				public int coin;

				// Token: 0x040035C6 RID: 13766
				[Token(Token = "0x40035C6")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerActivity.PlayerAct35SideActivity.ShopGood> good;

				// Token: 0x040035C7 RID: 13767
				[Token(Token = "0x40035C7")]
				[FieldOffset(Offset = "0x20")]
				public int freeCardCnt;

				// Token: 0x040035C8 RID: 13768
				[Token(Token = "0x40035C8")]
				[FieldOffset(Offset = "0x24")]
				public int refreshPrice;

				// Token: 0x040035C9 RID: 13769
				[Token(Token = "0x40035C9")]
				[FieldOffset(Offset = "0x28")]
				public int slotPrice;
			}

			// Token: 0x0200099A RID: 2458
			[Token(Token = "0x200099A")]
			public class ShopGood
			{
				// Token: 0x0600666C RID: 26220 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600666C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ShopGood()
				{
				}

				// Token: 0x040035CA RID: 13770
				[Token(Token = "0x40035CA")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x040035CB RID: 13771
				[Token(Token = "0x40035CB")]
				[FieldOffset(Offset = "0x18")]
				public int price;
			}

			// Token: 0x0200099B RID: 2459
			[Token(Token = "0x200099B")]
			public class CarvingTask
			{
				// Token: 0x0600666D RID: 26221 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600666D")]
				[Address(RVA = "0x1EE7290", Offset = "0x1EE5E90", VA = "0x181EE7290")]
				public CarvingTask()
				{
				}

				// Token: 0x040035CC RID: 13772
				[Token(Token = "0x40035CC")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x040035CD RID: 13773
				[Token(Token = "0x40035CD")]
				[FieldOffset(Offset = "0x18")]
				public List<int> progress;
			}

			// Token: 0x0200099C RID: 2460
			[Token(Token = "0x200099C")]
			public class MilestoneState
			{
				// Token: 0x0600666E RID: 26222 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600666E")]
				[Address(RVA = "0x1EEB940", Offset = "0x1EEA540", VA = "0x181EEB940")]
				public MilestoneState()
				{
				}

				// Token: 0x040035CE RID: 13774
				[Token(Token = "0x40035CE")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x040035CF RID: 13775
				[Token(Token = "0x40035CF")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}
		}

		// Token: 0x0200099D RID: 2461
		[Token(Token = "0x200099D")]
		public class PlayerAct38SideActivity
		{
			// Token: 0x0600666F RID: 26223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600666F")]
			[Address(RVA = "0x1EEEE70", Offset = "0x1EEDA70", VA = "0x181EEEE70")]
			public PlayerAct38SideActivity()
			{
			}

			// Token: 0x040035D0 RID: 13776
			[Token(Token = "0x40035D0")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x040035D1 RID: 13777
			[Token(Token = "0x40035D1")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x040035D2 RID: 13778
			[Token(Token = "0x40035D2")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerAct38SideActivity.PlayerAct38SidePuzzle> fireworkPuzzleDict;

			// Token: 0x0200099E RID: 2462
			[Token(Token = "0x200099E")]
			public enum PuzzleStatus
			{
				// Token: 0x040035D4 RID: 13780
				[Token(Token = "0x40035D4")]
				LOCKED,
				// Token: 0x040035D5 RID: 13781
				[Token(Token = "0x40035D5")]
				UNLOCK,
				// Token: 0x040035D6 RID: 13782
				[Token(Token = "0x40035D6")]
				COMPLETE
			}

			// Token: 0x0200099F RID: 2463
			[Token(Token = "0x200099F")]
			public class PlayerAct38SidePuzzle
			{
				// Token: 0x06006670 RID: 26224 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006670")]
				[Address(RVA = "0x1EEEF00", Offset = "0x1EEDB00", VA = "0x181EEEF00")]
				public PlayerAct38SidePuzzle()
				{
				}

				// Token: 0x040035D7 RID: 13783
				[Token(Token = "0x40035D7")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerAct38SideActivity.PuzzleStatus puzzleStatus;

				// Token: 0x040035D8 RID: 13784
				[Token(Token = "0x40035D8")]
				[FieldOffset(Offset = "0x18")]
				public List<FireworkData.PlateSlotData> solutionList;
			}
		}

		// Token: 0x020009A0 RID: 2464
		[Token(Token = "0x20009A0")]
		public class PlayerAutoChessV1Activity
		{
			// Token: 0x06006671 RID: 26225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006671")]
			[Address(RVA = "0x1EF1010", Offset = "0x1EEFC10", VA = "0x181EF1010")]
			public PlayerAutoChessV1Activity()
			{
			}

			// Token: 0x040035D9 RID: 13785
			[Token(Token = "0x40035D9")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, PlayerActivity.PlayerAutoChessV1Activity.AutoChessCharCard> chessPool;

			// Token: 0x040035DA RID: 13786
			[Token(Token = "0x40035DA")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerAutoChessV1Activity.DailyMission dailyMission;

			// Token: 0x040035DB RID: 13787
			[Token(Token = "0x40035DB")]
			[FieldOffset(Offset = "0x20")]
			public long protectTs;

			// Token: 0x040035DC RID: 13788
			[Token(Token = "0x40035DC")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAutoChessV1Activity.Milestone milestone;

			// Token: 0x040035DD RID: 13789
			[Token(Token = "0x40035DD")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame game;

			// Token: 0x040035DE RID: 13790
			[Token(Token = "0x40035DE")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, PlayerActivity.PlayerAutoChessV1Activity.AutoChessBandUnlockInfo> band;

			// Token: 0x040035DF RID: 13791
			[Token(Token = "0x40035DF")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, PlayerActivity.PlayerAutoChessV1Activity.ModeRecord> mode;

			// Token: 0x020009A1 RID: 2465
			[Token(Token = "0x20009A1")]
			public class ModeRecord
			{
				// Token: 0x06006672 RID: 26226 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006672")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ModeRecord()
				{
				}

				// Token: 0x040035E0 RID: 13792
				[Token(Token = "0x40035E0")]
				[FieldOffset(Offset = "0x10")]
				public bool unlock;

				// Token: 0x040035E1 RID: 13793
				[Token(Token = "0x40035E1")]
				[FieldOffset(Offset = "0x14")]
				public int completeCnt;
			}

			// Token: 0x020009A2 RID: 2466
			[Token(Token = "0x20009A2")]
			public class Milestone
			{
				// Token: 0x06006673 RID: 26227 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006673")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Milestone()
				{
				}

				// Token: 0x040035E2 RID: 13794
				[Token(Token = "0x40035E2")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x040035E3 RID: 13795
				[Token(Token = "0x40035E3")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x020009A3 RID: 2467
			[Token(Token = "0x20009A3")]
			public enum AutoChessCharType
			{
				// Token: 0x040035E5 RID: 13797
				[Token(Token = "0x40035E5")]
				OWN,
				// Token: 0x040035E6 RID: 13798
				[Token(Token = "0x40035E6")]
				BACK_UP,
				// Token: 0x040035E7 RID: 13799
				[Token(Token = "0x40035E7")]
				ASSIST_BY_FRIEND,
				// Token: 0x040035E8 RID: 13800
				[Token(Token = "0x40035E8")]
				DIY
			}

			// Token: 0x020009A4 RID: 2468
			[Token(Token = "0x20009A4")]
			public class AutoChessCharCard
			{
				// Token: 0x06006674 RID: 26228 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006674")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AutoChessCharCard()
				{
				}

				// Token: 0x040035E9 RID: 13801
				[Token(Token = "0x40035E9")]
				[FieldOffset(Offset = "0x10")]
				public string chessId;

				// Token: 0x040035EA RID: 13802
				[Token(Token = "0x40035EA")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessCharType type;

				// Token: 0x040035EB RID: 13803
				[Token(Token = "0x40035EB")]
				[FieldOffset(Offset = "0x20")]
				public string diyChar;

				// Token: 0x040035EC RID: 13804
				[Token(Token = "0x40035EC")]
				[FieldOffset(Offset = "0x28")]
				public int potentialRank;

				// Token: 0x040035ED RID: 13805
				[Token(Token = "0x40035ED")]
				[FieldOffset(Offset = "0x30")]
				public string cultivateEffect;

				// Token: 0x040035EE RID: 13806
				[Token(Token = "0x40035EE")]
				[FieldOffset(Offset = "0x38")]
				public int skillIndex;

				// Token: 0x040035EF RID: 13807
				[Token(Token = "0x40035EF")]
				[FieldOffset(Offset = "0x40")]
				public string currentEquip;

				// Token: 0x040035F0 RID: 13808
				[Token(Token = "0x40035F0")]
				[FieldOffset(Offset = "0x48")]
				public string skin;

				// Token: 0x040035F1 RID: 13809
				[Token(Token = "0x40035F1")]
				[FieldOffset(Offset = "0x50")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessAssistInfo assistInfo;

				// Token: 0x040035F2 RID: 13810
				[Token(Token = "0x40035F2")]
				[FieldOffset(Offset = "0x58")]
				public string diyOrigChessId;
			}

			// Token: 0x020009A5 RID: 2469
			[Token(Token = "0x20009A5")]
			public class AutoChessAssistInfo
			{
				// Token: 0x06006675 RID: 26229 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006675")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AutoChessAssistInfo()
				{
				}

				// Token: 0x040035F3 RID: 13811
				[Token(Token = "0x40035F3")]
				[FieldOffset(Offset = "0x10")]
				public string uid;

				// Token: 0x040035F4 RID: 13812
				[Token(Token = "0x40035F4")]
				[FieldOffset(Offset = "0x18")]
				public string nickName;

				// Token: 0x040035F5 RID: 13813
				[Token(Token = "0x40035F5")]
				[FieldOffset(Offset = "0x20")]
				public string nickNumber;

				// Token: 0x040035F6 RID: 13814
				[Token(Token = "0x40035F6")]
				[FieldOffset(Offset = "0x28")]
				public string alias;
			}

			// Token: 0x020009A6 RID: 2470
			[Token(Token = "0x20009A6")]
			public class AutoChessBandUnlockInfo
			{
				// Token: 0x06006676 RID: 26230 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006676")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AutoChessBandUnlockInfo()
				{
				}

				// Token: 0x040035F7 RID: 13815
				[Token(Token = "0x40035F7")]
				[FieldOffset(Offset = "0x10")]
				public int state;

				// Token: 0x040035F8 RID: 13816
				[Token(Token = "0x40035F8")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessBandUnlockProgress progress;
			}

			// Token: 0x020009A7 RID: 2471
			[Token(Token = "0x20009A7")]
			public class AutoChessBandUnlockProgress
			{
				// Token: 0x06006677 RID: 26231 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006677")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AutoChessBandUnlockProgress()
				{
				}

				// Token: 0x040035F9 RID: 13817
				[Token(Token = "0x40035F9")]
				[FieldOffset(Offset = "0x10")]
				public int value;

				// Token: 0x040035FA RID: 13818
				[Token(Token = "0x40035FA")]
				[FieldOffset(Offset = "0x14")]
				public int target;
			}

			// Token: 0x020009A8 RID: 2472
			[Token(Token = "0x20009A8")]
			public class DailyMission
			{
				// Token: 0x06006678 RID: 26232 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006678")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DailyMission()
				{
				}

				// Token: 0x040035FB RID: 13819
				[Token(Token = "0x40035FB")]
				[FieldOffset(Offset = "0x10")]
				public int process;

				// Token: 0x040035FC RID: 13820
				[Token(Token = "0x40035FC")]
				[FieldOffset(Offset = "0x14")]
				public int state;
			}

			// Token: 0x020009A9 RID: 2473
			[Token(Token = "0x20009A9")]
			public enum AutoChessGameState
			{
				// Token: 0x040035FE RID: 13822
				[Token(Token = "0x40035FE")]
				SELECT_TEAM,
				// Token: 0x040035FF RID: 13823
				[Token(Token = "0x40035FF")]
				SHOP,
				// Token: 0x04003600 RID: 13824
				[Token(Token = "0x4003600")]
				BATTLE,
				// Token: 0x04003601 RID: 13825
				[Token(Token = "0x4003601")]
				CHOOSE_BRAND,
				// Token: 0x04003602 RID: 13826
				[Token(Token = "0x4003602")]
				TO_SETTLE
			}

			// Token: 0x020009AA RID: 2474
			[Token(Token = "0x20009AA")]
			public class AutoChessGame
			{
				// Token: 0x06006679 RID: 26233 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006679")]
				[Address(RVA = "0x1EE6740", Offset = "0x1EE5340", VA = "0x181EE6740")]
				public AutoChessGame()
				{
				}

				// Token: 0x04003603 RID: 13827
				[Token(Token = "0x4003603")]
				[FieldOffset(Offset = "0x10")]
				public string startTs;

				// Token: 0x04003604 RID: 13828
				[Token(Token = "0x4003604")]
				[FieldOffset(Offset = "0x18")]
				public int seed;

				// Token: 0x04003605 RID: 13829
				[Token(Token = "0x4003605")]
				[FieldOffset(Offset = "0x20")]
				public string mode;

				// Token: 0x04003606 RID: 13830
				[Token(Token = "0x4003606")]
				[FieldOffset(Offset = "0x28")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGameState state;

				// Token: 0x04003607 RID: 13831
				[Token(Token = "0x4003607")]
				[FieldOffset(Offset = "0x30")]
				public string bandId;

				// Token: 0x04003608 RID: 13832
				[Token(Token = "0x4003608")]
				[FieldOffset(Offset = "0x38")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Effect[] talent;

				// Token: 0x04003609 RID: 13833
				[Token(Token = "0x4003609")]
				[FieldOffset(Offset = "0x40")]
				public string[] talentChoices;

				// Token: 0x0400360A RID: 13834
				[Token(Token = "0x400360A")]
				[FieldOffset(Offset = "0x48")]
				public string currForce;

				// Token: 0x0400360B RID: 13835
				[Token(Token = "0x400360B")]
				[FieldOffset(Offset = "0x50")]
				public Dictionary<string, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessForce> allForces;

				// Token: 0x0400360C RID: 13836
				[Token(Token = "0x400360C")]
				[FieldOffset(Offset = "0x58")]
				public int rewardEnemyRound;

				// Token: 0x0400360D RID: 13837
				[Token(Token = "0x400360D")]
				[FieldOffset(Offset = "0x60")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Health health;

				// Token: 0x0400360E RID: 13838
				[Token(Token = "0x400360E")]
				[FieldOffset(Offset = "0x68")]
				public int turn;

				// Token: 0x0400360F RID: 13839
				[Token(Token = "0x400360F")]
				[FieldOffset(Offset = "0x70")]
				public string roundId;

				// Token: 0x04003610 RID: 13840
				[Token(Token = "0x4003610")]
				[FieldOffset(Offset = "0x78")]
				public string stageId;

				// Token: 0x04003611 RID: 13841
				[Token(Token = "0x4003611")]
				[FieldOffset(Offset = "0x80")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Store store;

				// Token: 0x04003612 RID: 13842
				[Token(Token = "0x4003612")]
				[FieldOffset(Offset = "0x88")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Table table;

				// Token: 0x04003613 RID: 13843
				[Token(Token = "0x4003613")]
				[FieldOffset(Offset = "0x90")]
				public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Buff buff;

				// Token: 0x020009AB RID: 2475
				[Token(Token = "0x20009AB")]
				public class Effect
				{
					// Token: 0x0600667A RID: 26234 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600667A")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Effect()
					{
					}

					// Token: 0x04003614 RID: 13844
					[Token(Token = "0x4003614")]
					[FieldOffset(Offset = "0x10")]
					public int instId;

					// Token: 0x04003615 RID: 13845
					[Token(Token = "0x4003615")]
					[FieldOffset(Offset = "0x18")]
					public string effectId;

					// Token: 0x04003616 RID: 13846
					[Token(Token = "0x4003616")]
					[FieldOffset(Offset = "0x20")]
					public long ts;

					// Token: 0x04003617 RID: 13847
					[Token(Token = "0x4003617")]
					[FieldOffset(Offset = "0x28")]
					public int startRound;
				}

				// Token: 0x020009AC RID: 2476
				[Token(Token = "0x20009AC")]
				public class Health
				{
					// Token: 0x0600667B RID: 26235 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600667B")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Health()
					{
					}

					// Token: 0x04003618 RID: 13848
					[Token(Token = "0x4003618")]
					[FieldOffset(Offset = "0x10")]
					public int hp;

					// Token: 0x04003619 RID: 13849
					[Token(Token = "0x4003619")]
					[FieldOffset(Offset = "0x14")]
					public int shield;
				}

				// Token: 0x020009AD RID: 2477
				[Token(Token = "0x20009AD")]
				public class Store
				{
					// Token: 0x0600667C RID: 26236 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600667C")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Store()
					{
					}

					// Token: 0x0400361A RID: 13850
					[Token(Token = "0x400361A")]
					[FieldOffset(Offset = "0x10")]
					public int lv;

					// Token: 0x0400361B RID: 13851
					[Token(Token = "0x400361B")]
					[FieldOffset(Offset = "0x14")]
					public int coin;

					// Token: 0x0400361C RID: 13852
					[Token(Token = "0x400361C")]
					[FieldOffset(Offset = "0x18")]
					public bool isForzen;

					// Token: 0x0400361D RID: 13853
					[Token(Token = "0x400361D")]
					[FieldOffset(Offset = "0x1C")]
					public int upgradePrice;

					// Token: 0x0400361E RID: 13854
					[Token(Token = "0x400361E")]
					[FieldOffset(Offset = "0x20")]
					public int refreshPrice;

					// Token: 0x0400361F RID: 13855
					[Token(Token = "0x400361F")]
					[FieldOffset(Offset = "0x28")]
					public Dictionary<int, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessCharGoods> charGoods;

					// Token: 0x04003620 RID: 13856
					[Token(Token = "0x4003620")]
					[FieldOffset(Offset = "0x30")]
					public Dictionary<int, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessTrapGoods> trapGoods;
				}

				// Token: 0x020009AE RID: 2478
				[Token(Token = "0x20009AE")]
				[Serializable]
				public class FillBattle
				{
					// Token: 0x0600667D RID: 26237 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600667D")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public FillBattle()
					{
					}

					// Token: 0x04003621 RID: 13857
					[Token(Token = "0x4003621")]
					[FieldOffset(Offset = "0x10")]
					public bool isValid;

					// Token: 0x04003622 RID: 13858
					[Token(Token = "0x4003622")]
					[FieldOffset(Offset = "0x18")]
					public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.FillBattle.CoopData coopData;

					// Token: 0x04003623 RID: 13859
					[Token(Token = "0x4003623")]
					[FieldOffset(Offset = "0x20")]
					public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.FillBattle.FillEnemyData[] fillEnemies;

					// Token: 0x020009AF RID: 2479
					[Token(Token = "0x20009AF")]
					[Serializable]
					public class FillEnemyData
					{
						// Token: 0x0600667E RID: 26238 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x600667E")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public FillEnemyData()
						{
						}

						// Token: 0x04003624 RID: 13860
						[Token(Token = "0x4003624")]
						[FieldOffset(Offset = "0x10")]
						public string enemyID;

						// Token: 0x04003625 RID: 13861
						[Token(Token = "0x4003625")]
						[FieldOffset(Offset = "0x18")]
						public int routeIndex;

						// Token: 0x04003626 RID: 13862
						[Token(Token = "0x4003626")]
						[FieldOffset(Offset = "0x1C")]
						public int count;
					}

					// Token: 0x020009B0 RID: 2480
					[Token(Token = "0x20009B0")]
					[Serializable]
					public class CoopData
					{
						// Token: 0x0600667F RID: 26239 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x600667F")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public CoopData()
						{
						}

						// Token: 0x04003627 RID: 13863
						[Token(Token = "0x4003627")]
						[FieldOffset(Offset = "0x10")]
						public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessGameInfo gameInfo;

						// Token: 0x04003628 RID: 13864
						[Token(Token = "0x4003628")]
						[FieldOffset(Offset = "0x18")]
						public Dictionary<string, int> garrisonStack;
					}
				}

				// Token: 0x020009B1 RID: 2481
				[Token(Token = "0x20009B1")]
				public class Table
				{
					// Token: 0x06006680 RID: 26240 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006680")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Table()
					{
					}

					// Token: 0x04003629 RID: 13865
					[Token(Token = "0x4003629")]
					[FieldOffset(Offset = "0x10")]
					public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessChar[] chars;

					// Token: 0x0400362A RID: 13866
					[Token(Token = "0x400362A")]
					[FieldOffset(Offset = "0x18")]
					public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessTrap[] trap;

					// Token: 0x0400362B RID: 13867
					[Token(Token = "0x400362B")]
					[FieldOffset(Offset = "0x20")]
					public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Table.RecruitCard recruitCard;

					// Token: 0x0400362C RID: 13868
					[Token(Token = "0x400362C")]
					[FieldOffset(Offset = "0x28")]
					public Dictionary<int, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Table.Spell> spellUsing;

					// Token: 0x0400362D RID: 13869
					[Token(Token = "0x400362D")]
					[FieldOffset(Offset = "0x30")]
					public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessGameInfo gameInfo;

					// Token: 0x020009B2 RID: 2482
					[Token(Token = "0x20009B2")]
					public class RecruitCard
					{
						// Token: 0x06006681 RID: 26241 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x6006681")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public RecruitCard()
						{
						}

						// Token: 0x0400362E RID: 13870
						[Token(Token = "0x400362E")]
						[FieldOffset(Offset = "0x10")]
						public int instId;

						// Token: 0x0400362F RID: 13871
						[Token(Token = "0x400362F")]
						[FieldOffset(Offset = "0x18")]
						public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessCharGoods[] effect;
					}

					// Token: 0x020009B3 RID: 2483
					[Token(Token = "0x20009B3")]
					public class Spell
					{
						// Token: 0x06006682 RID: 26242 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x6006682")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public Spell()
						{
						}

						// Token: 0x04003630 RID: 13872
						[Token(Token = "0x4003630")]
						[FieldOffset(Offset = "0x10")]
						public int instId;

						// Token: 0x04003631 RID: 13873
						[Token(Token = "0x4003631")]
						[FieldOffset(Offset = "0x18")]
						public string chessId;

						// Token: 0x04003632 RID: 13874
						[Token(Token = "0x4003632")]
						[FieldOffset(Offset = "0x20")]
						public int startRound;

						// Token: 0x04003633 RID: 13875
						[Token(Token = "0x4003633")]
						[FieldOffset(Offset = "0x24")]
						public bool activated;
					}
				}

				// Token: 0x020009B4 RID: 2484
				[Token(Token = "0x20009B4")]
				[Serializable]
				public class AutoChessGameInfo
				{
					// Token: 0x06006683 RID: 26243 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006683")]
					[Address(RVA = "0x1EE66B0", Offset = "0x1EE52B0", VA = "0x181EE66B0")]
					public AutoChessGameInfo()
					{
					}

					// Token: 0x04003634 RID: 13876
					[Token(Token = "0x4003634")]
					[FieldOffset(Offset = "0x10")]
					public Dictionary<int, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessGameInfo.BattleChessInstServer> chessInstMap;

					// Token: 0x020009B5 RID: 2485
					[Token(Token = "0x20009B5")]
					public class BattleChessInstServer
					{
						// Token: 0x06006684 RID: 26244 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x6006684")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public BattleChessInstServer()
						{
						}

						// Token: 0x04003635 RID: 13877
						[Token(Token = "0x4003635")]
						[FieldOffset(Offset = "0x10")]
						public int instId;

						// Token: 0x04003636 RID: 13878
						[Token(Token = "0x4003636")]
						[FieldOffset(Offset = "0x14")]
						public bool isToken;

						// Token: 0x04003637 RID: 13879
						[Token(Token = "0x4003637")]
						[FieldOffset(Offset = "0x18")]
						public SharedConsts.Direction dir;

						// Token: 0x04003638 RID: 13880
						[Token(Token = "0x4003638")]
						[FieldOffset(Offset = "0x1C")]
						public int buildSeq;
					}
				}

				// Token: 0x020009B6 RID: 2486
				[Token(Token = "0x20009B6")]
				public class AutoChessCharGoods
				{
					// Token: 0x06006685 RID: 26245 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006685")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public AutoChessCharGoods()
					{
					}

					// Token: 0x04003639 RID: 13881
					[Token(Token = "0x4003639")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x0400363A RID: 13882
					[Token(Token = "0x400363A")]
					[FieldOffset(Offset = "0x18")]
					public int price;
				}

				// Token: 0x020009B7 RID: 2487
				[Token(Token = "0x20009B7")]
				public class AutoChessTrapGoods
				{
					// Token: 0x06006686 RID: 26246 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006686")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public AutoChessTrapGoods()
					{
					}

					// Token: 0x0400363B RID: 13883
					[Token(Token = "0x400363B")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x0400363C RID: 13884
					[Token(Token = "0x400363C")]
					[FieldOffset(Offset = "0x18")]
					public int price;
				}

				// Token: 0x020009B8 RID: 2488
				[Token(Token = "0x20009B8")]
				public class AutoChessInst
				{
					// Token: 0x06006687 RID: 26247 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006687")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public AutoChessInst()
					{
					}

					// Token: 0x0400363D RID: 13885
					[Token(Token = "0x400363D")]
					[FieldOffset(Offset = "0x10")]
					public int instId;

					// Token: 0x0400363E RID: 13886
					[Token(Token = "0x400363E")]
					[FieldOffset(Offset = "0x18")]
					public string chessId;

					// Token: 0x0400363F RID: 13887
					[Token(Token = "0x400363F")]
					[FieldOffset(Offset = "0x20")]
					public string overrideChessId;
				}

				// Token: 0x020009B9 RID: 2489
				[Token(Token = "0x20009B9")]
				public class AutoChessTrap : PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessInst
				{
					// Token: 0x06006688 RID: 26248 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006688")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public AutoChessTrap()
					{
					}
				}

				// Token: 0x020009BA RID: 2490
				[Token(Token = "0x20009BA")]
				public class AutoChessChar : PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessInst
				{
					// Token: 0x06006689 RID: 26249 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006689")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public AutoChessChar()
					{
					}

					// Token: 0x04003640 RID: 13888
					[Token(Token = "0x4003640")]
					[FieldOffset(Offset = "0x28")]
					public Dictionary<int, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.AutoChessTrap> equip;

					// Token: 0x04003641 RID: 13889
					[Token(Token = "0x4003641")]
					[FieldOffset(Offset = "0x30")]
					public int damage;
				}

				// Token: 0x020009BB RID: 2491
				[Token(Token = "0x20009BB")]
				public class AutoChessForce
				{
					// Token: 0x0600668A RID: 26250 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600668A")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public AutoChessForce()
					{
					}

					// Token: 0x04003642 RID: 13890
					[Token(Token = "0x4003642")]
					[FieldOffset(Offset = "0x10")]
					public string forceId;

					// Token: 0x04003643 RID: 13891
					[Token(Token = "0x4003643")]
					[FieldOffset(Offset = "0x18")]
					public int hp;

					// Token: 0x04003644 RID: 13892
					[Token(Token = "0x4003644")]
					[FieldOffset(Offset = "0x20")]
					public List<string> extraForce;

					// Token: 0x04003645 RID: 13893
					[Token(Token = "0x4003645")]
					[FieldOffset(Offset = "0x28")]
					public List<PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Effect> effect;
				}

				// Token: 0x020009BC RID: 2492
				[Token(Token = "0x20009BC")]
				public class Buff
				{
					// Token: 0x0600668B RID: 26251 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600668B")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Buff()
					{
					}

					// Token: 0x04003646 RID: 13894
					[Token(Token = "0x4003646")]
					[FieldOffset(Offset = "0x10")]
					public Dictionary<string, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Buff.GainCoinCounter> gainCoinCounter;

					// Token: 0x04003647 RID: 13895
					[Token(Token = "0x4003647")]
					[FieldOffset(Offset = "0x18")]
					public Dictionary<string, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Buff.EnemyCounter> killEnemyCounter;

					// Token: 0x04003648 RID: 13896
					[Token(Token = "0x4003648")]
					[FieldOffset(Offset = "0x20")]
					public Dictionary<string, int> chessPurchase;

					// Token: 0x04003649 RID: 13897
					[Token(Token = "0x4003649")]
					[FieldOffset(Offset = "0x28")]
					[JsonProperty("speRefresh")]
					public PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Buff.SpecialRefresh specialRefresh;

					// Token: 0x0400364A RID: 13898
					[Token(Token = "0x400364A")]
					[FieldOffset(Offset = "0x30")]
					public Dictionary<string, List<PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Buff.BattleLayerEffect>> battleLayers;

					// Token: 0x0400364B RID: 13899
					[Token(Token = "0x400364B")]
					[FieldOffset(Offset = "0x38")]
					public Dictionary<int, int> equipCoinJar;

					// Token: 0x0400364C RID: 13900
					[Token(Token = "0x400364C")]
					[FieldOffset(Offset = "0x40")]
					public int slotAdd;

					// Token: 0x0400364D RID: 13901
					[Token(Token = "0x400364D")]
					[FieldOffset(Offset = "0x48")]
					public Dictionary<int, PlayerActivity.PlayerAutoChessV1Activity.AutoChessGame.Buff.EffectShowItem> effectShow;

					// Token: 0x020009BD RID: 2493
					[Token(Token = "0x20009BD")]
					public class SpecialRefresh
					{
						// Token: 0x0600668C RID: 26252 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x600668C")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public SpecialRefresh()
						{
						}

						// Token: 0x0400364E RID: 13902
						[Token(Token = "0x400364E")]
						[FieldOffset(Offset = "0x10")]
						public int cnt;
					}

					// Token: 0x020009BE RID: 2494
					[Token(Token = "0x20009BE")]
					public class EnemyCounter
					{
						// Token: 0x0600668D RID: 26253 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x600668D")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public EnemyCounter()
						{
						}

						// Token: 0x0400364F RID: 13903
						[Token(Token = "0x400364F")]
						[FieldOffset(Offset = "0x10")]
						[JsonProperty("base")]
						public int baseNum;

						// Token: 0x04003650 RID: 13904
						[Token(Token = "0x4003650")]
						[FieldOffset(Offset = "0x14")]
						public int process;
					}

					// Token: 0x020009BF RID: 2495
					[Token(Token = "0x20009BF")]
					public class GainCoinCounter
					{
						// Token: 0x0600668E RID: 26254 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x600668E")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public GainCoinCounter()
						{
						}

						// Token: 0x04003651 RID: 13905
						[Token(Token = "0x4003651")]
						[FieldOffset(Offset = "0x10")]
						[JsonProperty("base")]
						public int baseNum;

						// Token: 0x04003652 RID: 13906
						[Token(Token = "0x4003652")]
						[FieldOffset(Offset = "0x14")]
						public int reduce;

						// Token: 0x04003653 RID: 13907
						[Token(Token = "0x4003653")]
						[FieldOffset(Offset = "0x18")]
						public int process;
					}

					// Token: 0x020009C0 RID: 2496
					[Token(Token = "0x20009C0")]
					public class EffectShowItem
					{
						// Token: 0x0600668F RID: 26255 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x600668F")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public EffectShowItem()
						{
						}

						// Token: 0x04003654 RID: 13908
						[Token(Token = "0x4003654")]
						[FieldOffset(Offset = "0x10")]
						public int leftCnt;
					}

					// Token: 0x020009C1 RID: 2497
					[Token(Token = "0x20009C1")]
					public class BattleLayerEffect
					{
						// Token: 0x06006690 RID: 26256 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x6006690")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public BattleLayerEffect()
						{
						}

						// Token: 0x04003655 RID: 13909
						[Token(Token = "0x4003655")]
						[FieldOffset(Offset = "0x10")]
						public int effectInst;

						// Token: 0x04003656 RID: 13910
						[Token(Token = "0x4003656")]
						[FieldOffset(Offset = "0x14")]
						public int count;
					}
				}
			}
		}

		// Token: 0x020009C2 RID: 2498
		[Token(Token = "0x20009C2")]
		public class PlayerActMainSSActivity
		{
			// Token: 0x06006691 RID: 26257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006691")]
			[Address(RVA = "0x1EEFA90", Offset = "0x1EEE690", VA = "0x181EEFA90")]
			public PlayerActMainSSActivity()
			{
			}

			// Token: 0x04003657 RID: 13911
			[Token(Token = "0x4003657")]
			[FieldOffset(Offset = "0x10")]
			public List<string> favorList;

			// Token: 0x04003658 RID: 13912
			[Token(Token = "0x4003658")]
			[FieldOffset(Offset = "0x18")]
			public int coin;
		}

		// Token: 0x020009C3 RID: 2499
		[Token(Token = "0x20009C3")]
		public class PlayerAct42SideActivity
		{
			// Token: 0x06006692 RID: 26258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006692")]
			[Address(RVA = "0x1EEF230", Offset = "0x1EEDE30", VA = "0x181EEF230")]
			public PlayerAct42SideActivity()
			{
			}

			// Token: 0x04003659 RID: 13913
			[Token(Token = "0x4003659")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x0400365A RID: 13914
			[Token(Token = "0x400365A")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x0400365B RID: 13915
			[Token(Token = "0x400365B")]
			[FieldOffset(Offset = "0x20")]
			public bool outerPlayerOpen;

			// Token: 0x0400365C RID: 13916
			[Token(Token = "0x400365C")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, PlayerActivity.PlayerAct42SideActivity.PlayerAct42sideTask> taskMap;

			// Token: 0x0400365D RID: 13917
			[Token(Token = "0x400365D")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, int> gunMap;

			// Token: 0x0400365E RID: 13918
			[Token(Token = "0x400365E")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, int> fileMap;

			// Token: 0x0400365F RID: 13919
			[Token(Token = "0x400365F")]
			[FieldOffset(Offset = "0x40")]
			public PlayerActivity.PlayerAct42SideActivity.PlayerAct42sideTrustedItem trustedItem;

			// Token: 0x04003660 RID: 13920
			[Token(Token = "0x4003660")]
			[FieldOffset(Offset = "0x48")]
			public PlayerActivity.PlayerAct42SideActivity.RewardState dailyRewardState;

			// Token: 0x020009C4 RID: 2500
			[Token(Token = "0x20009C4")]
			public enum TaskState
			{
				// Token: 0x04003662 RID: 13922
				[Token(Token = "0x4003662")]
				LOCKED,
				// Token: 0x04003663 RID: 13923
				[Token(Token = "0x4003663")]
				UNLOCK,
				// Token: 0x04003664 RID: 13924
				[Token(Token = "0x4003664")]
				ACCEPTED,
				// Token: 0x04003665 RID: 13925
				[Token(Token = "0x4003665")]
				CAN_SUBMIT,
				// Token: 0x04003666 RID: 13926
				[Token(Token = "0x4003666")]
				COMPLETE
			}

			// Token: 0x020009C5 RID: 2501
			[Token(Token = "0x20009C5")]
			public enum RewardState
			{
				// Token: 0x04003668 RID: 13928
				[Token(Token = "0x4003668")]
				UNAVAILABLE,
				// Token: 0x04003669 RID: 13929
				[Token(Token = "0x4003669")]
				AVAILABLE
			}

			// Token: 0x020009C6 RID: 2502
			[Token(Token = "0x20009C6")]
			public class PlayerAct42sideTask
			{
				// Token: 0x06006693 RID: 26259 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006693")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerAct42sideTask()
				{
				}

				// Token: 0x0400366A RID: 13930
				[Token(Token = "0x400366A")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerAct42SideActivity.TaskState state;
			}

			// Token: 0x020009C7 RID: 2503
			[Token(Token = "0x20009C7")]
			public class PlayerAct42sideTrustedItem
			{
				// Token: 0x06006694 RID: 26260 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006694")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerAct42sideTrustedItem()
				{
				}

				// Token: 0x0400366B RID: 13931
				[Token(Token = "0x400366B")]
				[FieldOffset(Offset = "0x10")]
				public int has;

				// Token: 0x0400366C RID: 13932
				[Token(Token = "0x400366C")]
				[FieldOffset(Offset = "0x14")]
				public int got;

				// Token: 0x0400366D RID: 13933
				[Token(Token = "0x400366D")]
				[FieldOffset(Offset = "0x18")]
				public int dailyState;
			}
		}

		// Token: 0x020009C8 RID: 2504
		[Token(Token = "0x20009C8")]
		public class PlayerAct45SideActivity
		{
			// Token: 0x06006695 RID: 26261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006695")]
			[Address(RVA = "0x1EEF410", Offset = "0x1EEE010", VA = "0x181EEF410")]
			public PlayerAct45SideActivity()
			{
			}

			// Token: 0x0400366E RID: 13934
			[Token(Token = "0x400366E")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x0400366F RID: 13935
			[Token(Token = "0x400366F")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x04003670 RID: 13936
			[Token(Token = "0x4003670")]
			[FieldOffset(Offset = "0x20")]
			public bool platformUnlock;

			// Token: 0x04003671 RID: 13937
			[Token(Token = "0x4003671")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, PlayerActivity.PlayerAct45SideActivity.State> charState;

			// Token: 0x04003672 RID: 13938
			[Token(Token = "0x4003672")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, PlayerActivity.PlayerAct45SideActivity.State> mailState;

			// Token: 0x020009C9 RID: 2505
			[Token(Token = "0x20009C9")]
			public enum State
			{
				// Token: 0x04003674 RID: 13940
				[Token(Token = "0x4003674")]
				LOCKED,
				// Token: 0x04003675 RID: 13941
				[Token(Token = "0x4003675")]
				UNLOCK,
				// Token: 0x04003676 RID: 13942
				[Token(Token = "0x4003676")]
				ACCEPTED
			}
		}

		// Token: 0x020009CA RID: 2506
		[Token(Token = "0x20009CA")]
		public class PlayerAct44SideActivity
		{
			// Token: 0x06006696 RID: 26262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006696")]
			[Address(RVA = "0x1EEF380", Offset = "0x1EEDF80", VA = "0x181EEF380")]
			public PlayerAct44SideActivity()
			{
			}

			// Token: 0x04003677 RID: 13943
			[Token(Token = "0x4003677")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x04003678 RID: 13944
			[Token(Token = "0x4003678")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x04003679 RID: 13945
			[Token(Token = "0x4003679")]
			[FieldOffset(Offset = "0x20")]
			public int campaignCnt;

			// Token: 0x0400367A RID: 13946
			[Token(Token = "0x400367A")]
			[FieldOffset(Offset = "0x24")]
			public int informantPt;

			// Token: 0x0400367B RID: 13947
			[Token(Token = "0x400367B")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAct44SideActivity.Milestone milestone;

			// Token: 0x0400367C RID: 13948
			[Token(Token = "0x400367C")]
			[FieldOffset(Offset = "0x30")]
			public int businessDay;

			// Token: 0x0400367D RID: 13949
			[Token(Token = "0x400367D")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, int> unlockedCustomers;

			// Token: 0x0400367E RID: 13950
			[Token(Token = "0x400367E")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, int> unlockedTags;

			// Token: 0x0400367F RID: 13951
			[Token(Token = "0x400367F")]
			[FieldOffset(Offset = "0x48")]
			public bool isNew;

			// Token: 0x04003680 RID: 13952
			[Token(Token = "0x4003680")]
			[FieldOffset(Offset = "0x49")]
			public bool outerOpen;

			// Token: 0x04003681 RID: 13953
			[Token(Token = "0x4003681")]
			[FieldOffset(Offset = "0x50")]
			[JsonProperty(PropertyName = "game")]
			public PlayerActivity.PlayerAct44SideActivity.PlayerInformant informant;

			// Token: 0x020009CB RID: 2507
			[Token(Token = "0x20009CB")]
			public class Milestone
			{
				// Token: 0x06006697 RID: 26263 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006697")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Milestone()
				{
				}

				// Token: 0x04003682 RID: 13954
				[Token(Token = "0x4003682")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x04003683 RID: 13955
				[Token(Token = "0x4003683")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x020009CC RID: 2508
			[Token(Token = "0x20009CC")]
			public enum InformantState
			{
				// Token: 0x04003685 RID: 13957
				[Token(Token = "0x4003685")]
				ENTRY,
				// Token: 0x04003686 RID: 13958
				[Token(Token = "0x4003686")]
				CHOICE,
				// Token: 0x04003687 RID: 13959
				[Token(Token = "0x4003687")]
				CHOICE_END,
				// Token: 0x04003688 RID: 13960
				[Token(Token = "0x4003688")]
				BEFORE_SINGLE_RESULT,
				// Token: 0x04003689 RID: 13961
				[Token(Token = "0x4003689")]
				SINGLE_RESULT,
				// Token: 0x0400368A RID: 13962
				[Token(Token = "0x400368A")]
				RESULT
			}

			// Token: 0x020009CD RID: 2509
			[Token(Token = "0x20009CD")]
			public class PlayerInformantInsight
			{
				// Token: 0x06006698 RID: 26264 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006698")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerInformantInsight()
				{
				}

				// Token: 0x0400368B RID: 13963
				[Token(Token = "0x400368B")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty(PropertyName = "patienceRE")]
				public int patienceRecommend;

				// Token: 0x0400368C RID: 13964
				[Token(Token = "0x400368C")]
				[FieldOffset(Offset = "0x14")]
				[JsonProperty(PropertyName = "trustRE")]
				public int trustRecommend;

				// Token: 0x0400368D RID: 13965
				[Token(Token = "0x400368D")]
				[FieldOffset(Offset = "0x18")]
				[JsonProperty(PropertyName = "attentionRE")]
				public int attentionRecommend;

				// Token: 0x0400368E RID: 13966
				[Token(Token = "0x400368E")]
				[FieldOffset(Offset = "0x1C")]
				[JsonProperty(PropertyName = "patienceMAX")]
				public int patienceMax;

				// Token: 0x0400368F RID: 13967
				[Token(Token = "0x400368F")]
				[FieldOffset(Offset = "0x20")]
				[JsonProperty(PropertyName = "trustMAX")]
				public int trustMax;

				// Token: 0x04003690 RID: 13968
				[Token(Token = "0x4003690")]
				[FieldOffset(Offset = "0x24")]
				[JsonProperty(PropertyName = "attentionMAX")]
				public int attentionMax;
			}

			// Token: 0x020009CE RID: 2510
			[Token(Token = "0x20009CE")]
			public class PlayerInformantTrader
			{
				// Token: 0x06006699 RID: 26265 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006699")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerInformantTrader()
				{
				}

				// Token: 0x04003691 RID: 13969
				[Token(Token = "0x4003691")]
				[FieldOffset(Offset = "0x10")]
				public int patience;

				// Token: 0x04003692 RID: 13970
				[Token(Token = "0x4003692")]
				[FieldOffset(Offset = "0x14")]
				public int trust;

				// Token: 0x04003693 RID: 13971
				[Token(Token = "0x4003693")]
				[FieldOffset(Offset = "0x18")]
				public int attention;

				// Token: 0x04003694 RID: 13972
				[Token(Token = "0x4003694")]
				[FieldOffset(Offset = "0x20")]
				public List<string> choices;

				// Token: 0x04003695 RID: 13973
				[Token(Token = "0x4003695")]
				[FieldOffset(Offset = "0x28")]
				public string lastChoice;
			}

			// Token: 0x020009CF RID: 2511
			[Token(Token = "0x20009CF")]
			public class PlayerInformantSettle
			{
				// Token: 0x0600669A RID: 26266 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600669A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerInformantSettle()
				{
				}

				// Token: 0x04003696 RID: 13974
				[Token(Token = "0x4003696")]
				[FieldOffset(Offset = "0x10")]
				public string customerId;

				// Token: 0x04003697 RID: 13975
				[Token(Token = "0x4003697")]
				[FieldOffset(Offset = "0x18")]
				public string tagId;

				// Token: 0x04003698 RID: 13976
				[Token(Token = "0x4003698")]
				[FieldOffset(Offset = "0x20")]
				public bool success;

				// Token: 0x04003699 RID: 13977
				[Token(Token = "0x4003699")]
				[FieldOffset(Offset = "0x24")]
				public float successRate;

				// Token: 0x0400369A RID: 13978
				[Token(Token = "0x400369A")]
				[FieldOffset(Offset = "0x28")]
				public float incomeRate;

				// Token: 0x0400369B RID: 13979
				[Token(Token = "0x400369B")]
				[FieldOffset(Offset = "0x2C")]
				public int income;
			}

			// Token: 0x020009D0 RID: 2512
			[Token(Token = "0x20009D0")]
			public class PlayerInformant
			{
				// Token: 0x0600669B RID: 26267 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600669B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerInformant()
				{
				}

				// Token: 0x0400369C RID: 13980
				[Token(Token = "0x400369C")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerAct44SideActivity.InformantState state;

				// Token: 0x0400369D RID: 13981
				[Token(Token = "0x400369D")]
				[FieldOffset(Offset = "0x18")]
				public List<int> customerList;

				// Token: 0x0400369E RID: 13982
				[Token(Token = "0x400369E")]
				[FieldOffset(Offset = "0x20")]
				public int curCustomer;

				// Token: 0x0400369F RID: 13983
				[Token(Token = "0x400369F")]
				[FieldOffset(Offset = "0x28")]
				public string newsId;

				// Token: 0x040036A0 RID: 13984
				[Token(Token = "0x40036A0")]
				[FieldOffset(Offset = "0x30")]
				public string customerId;

				// Token: 0x040036A1 RID: 13985
				[Token(Token = "0x40036A1")]
				[FieldOffset(Offset = "0x38")]
				public int round;

				// Token: 0x040036A2 RID: 13986
				[Token(Token = "0x40036A2")]
				[FieldOffset(Offset = "0x3C")]
				public int basicIncome;

				// Token: 0x040036A3 RID: 13987
				[Token(Token = "0x40036A3")]
				[FieldOffset(Offset = "0x40")]
				[JsonProperty(PropertyName = "tagId")]
				public string tag;

				// Token: 0x040036A4 RID: 13988
				[Token(Token = "0x40036A4")]
				[FieldOffset(Offset = "0x48")]
				[JsonProperty(PropertyName = "customerLine")]
				public string customerDialog;

				// Token: 0x040036A5 RID: 13989
				[Token(Token = "0x40036A5")]
				[FieldOffset(Offset = "0x50")]
				[JsonProperty(PropertyName = "keeperLine")]
				public string keeperDialog;

				// Token: 0x040036A6 RID: 13990
				[Token(Token = "0x40036A6")]
				[FieldOffset(Offset = "0x58")]
				public int insightTimes;

				// Token: 0x040036A7 RID: 13991
				[Token(Token = "0x40036A7")]
				[FieldOffset(Offset = "0x5C")]
				public bool boom;

				// Token: 0x040036A8 RID: 13992
				[Token(Token = "0x40036A8")]
				[FieldOffset(Offset = "0x60")]
				public PlayerActivity.PlayerAct44SideActivity.PlayerInformantInsight insight;

				// Token: 0x040036A9 RID: 13993
				[Token(Token = "0x40036A9")]
				[FieldOffset(Offset = "0x68")]
				public PlayerActivity.PlayerAct44SideActivity.PlayerInformantTrader tradeInfo;

				// Token: 0x040036AA RID: 13994
				[Token(Token = "0x40036AA")]
				[FieldOffset(Offset = "0x70")]
				public List<PlayerActivity.PlayerAct44SideActivity.PlayerInformantSettle> settle;
			}
		}

		// Token: 0x020009D1 RID: 2513
		[Token(Token = "0x20009D1")]
		public class PlayerAct1VHalfIdleActivity
		{
			// Token: 0x0600669C RID: 26268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600669C")]
			[Address(RVA = "0x1EEE0C0", Offset = "0x1EECCC0", VA = "0x181EEE0C0")]
			public PlayerAct1VHalfIdleActivity()
			{
			}

			// Token: 0x040036AB RID: 13995
			[Token(Token = "0x40036AB")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x040036AC RID: 13996
			[Token(Token = "0x40036AC")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleTroop troop;

			// Token: 0x040036AD RID: 13997
			[Token(Token = "0x40036AD")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerAct1VHalfIdleActivity.StageInfo> stage;

			// Token: 0x040036AE RID: 13998
			[Token(Token = "0x40036AE")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAct1VHalfIdleActivity.SettleStageInfo settleInfo;

			// Token: 0x040036AF RID: 13999
			[Token(Token = "0x40036AF")]
			[FieldOffset(Offset = "0x30")]
			public PlayerActivity.PlayerAct1VHalfIdleActivity.ProductionInfo production;

			// Token: 0x040036B0 RID: 14000
			[Token(Token = "0x40036B0")]
			[FieldOffset(Offset = "0x38")]
			public PlayerActivity.PlayerAct1VHalfIdleActivity.RecruitInfo recruit;

			// Token: 0x040036B1 RID: 14001
			[Token(Token = "0x40036B1")]
			[FieldOffset(Offset = "0x40")]
			public PlayerActivity.PlayerAct1VHalfIdleActivity.Milestone milestone;

			// Token: 0x040036B2 RID: 14002
			[Token(Token = "0x40036B2")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<string, int> inventory;

			// Token: 0x040036B3 RID: 14003
			[Token(Token = "0x40036B3")]
			[FieldOffset(Offset = "0x50")]
			public PlayerActivity.PlayerAct1VHalfIdleActivity.TechTree tech;

			// Token: 0x040036B4 RID: 14004
			[Token(Token = "0x40036B4")]
			[FieldOffset(Offset = "0x58")]
			public bool globalBan;

			// Token: 0x020009D2 RID: 2514
			[Token(Token = "0x20009D2")]
			public enum BossState
			{
				// Token: 0x040036B6 RID: 14006
				[Token(Token = "0x40036B6")]
				NO_APPEAR,
				// Token: 0x040036B7 RID: 14007
				[Token(Token = "0x40036B7")]
				NO_KILL,
				// Token: 0x040036B8 RID: 14008
				[Token(Token = "0x40036B8")]
				KILL
			}

			// Token: 0x020009D3 RID: 2515
			[Token(Token = "0x20009D3")]
			public class StageInfo
			{
				// Token: 0x0600669D RID: 26269 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600669D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public StageInfo()
				{
				}

				// Token: 0x040036B9 RID: 14009
				[Token(Token = "0x40036B9")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, int> rate;

				// Token: 0x040036BA RID: 14010
				[Token(Token = "0x40036BA")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct1VHalfIdleActivity.BossState bossState;
			}

			// Token: 0x020009D4 RID: 2516
			[Token(Token = "0x20009D4")]
			public class SettleStageInfo
			{
				// Token: 0x0600669E RID: 26270 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600669E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SettleStageInfo()
				{
				}

				// Token: 0x040036BB RID: 14011
				[Token(Token = "0x40036BB")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, int> rate;

				// Token: 0x040036BC RID: 14012
				[Token(Token = "0x40036BC")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct1VHalfIdleActivity.BossState bossState;

				// Token: 0x040036BD RID: 14013
				[Token(Token = "0x40036BD")]
				[FieldOffset(Offset = "0x20")]
				public string stageId;

				// Token: 0x040036BE RID: 14014
				[Token(Token = "0x40036BE")]
				[FieldOffset(Offset = "0x28")]
				public int progress;
			}

			// Token: 0x020009D5 RID: 2517
			[Token(Token = "0x20009D5")]
			public class ProductionInfo
			{
				// Token: 0x0600669F RID: 26271 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600669F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ProductionInfo()
				{
				}

				// Token: 0x040036BF RID: 14015
				[Token(Token = "0x40036BF")]
				[FieldOffset(Offset = "0x10")]
				public ListDict<string, int> rate;

				// Token: 0x040036C0 RID: 14016
				[Token(Token = "0x40036C0")]
				[FieldOffset(Offset = "0x18")]
				public ListDict<string, int> product;

				// Token: 0x040036C1 RID: 14017
				[Token(Token = "0x40036C1")]
				[FieldOffset(Offset = "0x20")]
				public long refreshTs;

				// Token: 0x040036C2 RID: 14018
				[Token(Token = "0x40036C2")]
				[FieldOffset(Offset = "0x28")]
				public long harvestTs;
			}

			// Token: 0x020009D6 RID: 2518
			[Token(Token = "0x20009D6")]
			public class Act1VHalfIdleTroop
			{
				// Token: 0x060066A0 RID: 26272 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066A0")]
				[Address(RVA = "0x1EE6370", Offset = "0x1EE4F70", VA = "0x181EE6370")]
				public Act1VHalfIdleTroop()
				{
				}

				// Token: 0x040036C3 RID: 14019
				[Token(Token = "0x40036C3")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty("char")]
				public Dictionary<string, PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData> chars;

				// Token: 0x040036C4 RID: 14020
				[Token(Token = "0x40036C4")]
				[FieldOffset(Offset = "0x18")]
				public List<string> trap;

				// Token: 0x040036C5 RID: 14021
				[Token(Token = "0x40036C5")]
				[FieldOffset(Offset = "0x20")]
				public List<string> npc;

				// Token: 0x040036C6 RID: 14022
				[Token(Token = "0x40036C6")]
				[FieldOffset(Offset = "0x28")]
				public List<SharedCharData> assist;

				// Token: 0x040036C7 RID: 14023
				[Token(Token = "0x40036C7")]
				[FieldOffset(Offset = "0x30")]
				public bool extraAssist;
			}

			// Token: 0x020009D7 RID: 2519
			[Token(Token = "0x20009D7")]
			public class Act1VHalfIdleCharData
			{
				// Token: 0x060066A1 RID: 26273 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066A1")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Act1VHalfIdleCharData()
				{
				}

				// Token: 0x040036C8 RID: 14024
				[Token(Token = "0x40036C8")]
				[FieldOffset(Offset = "0x10")]
				public int instId;

				// Token: 0x040036C9 RID: 14025
				[Token(Token = "0x40036C9")]
				[FieldOffset(Offset = "0x18")]
				public string charId;

				// Token: 0x040036CA RID: 14026
				[Token(Token = "0x40036CA")]
				[FieldOffset(Offset = "0x20")]
				public int level;

				// Token: 0x040036CB RID: 14027
				[Token(Token = "0x40036CB")]
				[FieldOffset(Offset = "0x24")]
				[JsonProperty("skillLvl")]
				public int skillLvlWithSpec;

				// Token: 0x040036CC RID: 14028
				[Token(Token = "0x40036CC")]
				[FieldOffset(Offset = "0x28")]
				public int evolvePhase;

				// Token: 0x040036CD RID: 14029
				[Token(Token = "0x40036CD")]
				[FieldOffset(Offset = "0x2C")]
				public bool isAssist;

				// Token: 0x040036CE RID: 14030
				[Token(Token = "0x40036CE")]
				[FieldOffset(Offset = "0x30")]
				public string defaultSkillId;

				// Token: 0x040036CF RID: 14031
				[Token(Token = "0x40036CF")]
				[FieldOffset(Offset = "0x38")]
				public string defaultEquipId;
			}

			// Token: 0x020009D8 RID: 2520
			[Token(Token = "0x20009D8")]
			public class RecruitInfo
			{
				// Token: 0x060066A2 RID: 26274 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066A2")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RecruitInfo()
				{
				}

				// Token: 0x040036D0 RID: 14032
				[Token(Token = "0x40036D0")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, List<string>> poolGain;

				// Token: 0x040036D1 RID: 14033
				[Token(Token = "0x40036D1")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> poolTimes;
			}

			// Token: 0x020009D9 RID: 2521
			[Token(Token = "0x20009D9")]
			public class Milestone
			{
				// Token: 0x060066A3 RID: 26275 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066A3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Milestone()
				{
				}

				// Token: 0x040036D2 RID: 14034
				[Token(Token = "0x40036D2")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x040036D3 RID: 14035
				[Token(Token = "0x40036D3")]
				[FieldOffset(Offset = "0x18")]
				public List<string> got;
			}

			// Token: 0x020009DA RID: 2522
			[Token(Token = "0x20009DA")]
			public class TechTree
			{
				// Token: 0x060066A4 RID: 26276 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066A4")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public TechTree()
				{
				}

				// Token: 0x040036D4 RID: 14036
				[Token(Token = "0x40036D4")]
				[FieldOffset(Offset = "0x10")]
				public List<string> unlock;
			}
		}

		// Token: 0x020009DB RID: 2523
		[Token(Token = "0x20009DB")]
		public class PlayerCommonDailyMission
		{
			// Token: 0x060066A5 RID: 26277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066A5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerCommonDailyMission()
			{
			}

			// Token: 0x040036D5 RID: 14037
			[Token(Token = "0x40036D5")]
			[FieldOffset(Offset = "0x10")]
			public int process;

			// Token: 0x040036D6 RID: 14038
			[Token(Token = "0x40036D6")]
			[FieldOffset(Offset = "0x14")]
			public PlayerActivity.PlayerCommonDailyMission.DailyMissionState state;

			// Token: 0x020009DC RID: 2524
			[Token(Token = "0x20009DC")]
			public enum DailyMissionState
			{
				// Token: 0x040036D8 RID: 14040
				[Token(Token = "0x40036D8")]
				NOT_CLAIM,
				// Token: 0x040036D9 RID: 14041
				[Token(Token = "0x40036D9")]
				CLAIMED
			}
		}

		// Token: 0x020009DD RID: 2525
		[Token(Token = "0x20009DD")]
		public class PlayerActAutoChessActivity
		{
			// Token: 0x060066A6 RID: 26278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066A6")]
			[Address(RVA = "0x1EEF8D0", Offset = "0x1EEE4D0", VA = "0x181EEF8D0")]
			public PlayerActAutoChessActivity()
			{
			}

			// Token: 0x040036DA RID: 14042
			[Token(Token = "0x40036DA")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.Mode> mode;

			// Token: 0x040036DB RID: 14043
			[Token(Token = "0x40036DB")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerCommonDailyMission dailyMission;

			// Token: 0x040036DC RID: 14044
			[Token(Token = "0x40036DC")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.BandElem> band;

			// Token: 0x040036DD RID: 14045
			[Token(Token = "0x40036DD")]
			[FieldOffset(Offset = "0x28")]
			public long protectTs;

			// Token: 0x040036DE RID: 14046
			[Token(Token = "0x40036DE")]
			[FieldOffset(Offset = "0x30")]
			public int trophyNum;

			// Token: 0x040036DF RID: 14047
			[Token(Token = "0x40036DF")]
			[FieldOffset(Offset = "0x38")]
			public PlayerActivity.MilestoneInfo milestone;

			// Token: 0x040036E0 RID: 14048
			[Token(Token = "0x40036E0")]
			[FieldOffset(Offset = "0x40")]
			public PlayerActivity.PlayerActAutoChessActivity.MatchInfo match;

			// Token: 0x040036E1 RID: 14049
			[Token(Token = "0x40036E1")]
			[FieldOffset(Offset = "0x48")]
			public PlayerActivity.PlayerActAutoChessActivity.Scene scene;

			// Token: 0x040036E2 RID: 14050
			[Token(Token = "0x40036E2")]
			[FieldOffset(Offset = "0x50")]
			public bool globalBan;

			// Token: 0x040036E3 RID: 14051
			[Token(Token = "0x40036E3")]
			[FieldOffset(Offset = "0x58")]
			public Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> chessSquad;

			// Token: 0x020009DE RID: 2526
			[Token(Token = "0x20009DE")]
			public enum BandState
			{
				// Token: 0x040036E5 RID: 14053
				[Token(Token = "0x40036E5")]
				LOCK,
				// Token: 0x040036E6 RID: 14054
				[Token(Token = "0x40036E6")]
				UNLOCKED
			}

			// Token: 0x020009DF RID: 2527
			[Token(Token = "0x20009DF")]
			public enum AutoChessCharType
			{
				// Token: 0x040036E8 RID: 14056
				[Token(Token = "0x40036E8")]
				OWN,
				// Token: 0x040036E9 RID: 14057
				[Token(Token = "0x40036E9")]
				BACK_UP,
				// Token: 0x040036EA RID: 14058
				[Token(Token = "0x40036EA")]
				ASSIST_BY_FRIEND,
				// Token: 0x040036EB RID: 14059
				[Token(Token = "0x40036EB")]
				DIY,
				// Token: 0x040036EC RID: 14060
				[Token(Token = "0x40036EC")]
				PRESET
			}

			// Token: 0x020009E0 RID: 2528
			[Token(Token = "0x20009E0")]
			public class Mode
			{
				// Token: 0x060066A7 RID: 26279 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066A7")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Mode()
				{
				}

				// Token: 0x040036ED RID: 14061
				[Token(Token = "0x40036ED")]
				[FieldOffset(Offset = "0x10")]
				public bool unlock;

				// Token: 0x040036EE RID: 14062
				[Token(Token = "0x40036EE")]
				[FieldOffset(Offset = "0x14")]
				public int completeCnt;
			}

			// Token: 0x020009E1 RID: 2529
			[Token(Token = "0x20009E1")]
			public class BandUnlockProgress
			{
				// Token: 0x060066A8 RID: 26280 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066A8")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BandUnlockProgress()
				{
				}

				// Token: 0x040036EF RID: 14063
				[Token(Token = "0x40036EF")]
				[FieldOffset(Offset = "0x10")]
				public int value;

				// Token: 0x040036F0 RID: 14064
				[Token(Token = "0x40036F0")]
				[FieldOffset(Offset = "0x14")]
				public int target;
			}

			// Token: 0x020009E2 RID: 2530
			[Token(Token = "0x20009E2")]
			public class BandElem
			{
				// Token: 0x060066A9 RID: 26281 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066A9")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BandElem()
				{
				}

				// Token: 0x040036F1 RID: 14065
				[Token(Token = "0x40036F1")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerActAutoChessActivity.BandState state;

				// Token: 0x040036F2 RID: 14066
				[Token(Token = "0x40036F2")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerActAutoChessActivity.BandUnlockProgress progress;

				// Token: 0x040036F3 RID: 14067
				[Token(Token = "0x40036F3")]
				[FieldOffset(Offset = "0x20")]
				public int passCnt;
			}

			// Token: 0x020009E3 RID: 2531
			[Token(Token = "0x20009E3")]
			public class AutoChessSquadSlot
			{
				// Token: 0x060066AA RID: 26282 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066AA")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AutoChessSquadSlot()
				{
				}

				// Token: 0x040036F4 RID: 14068
				[Token(Token = "0x40036F4")]
				[FieldOffset(Offset = "0x10")]
				public string chessId;

				// Token: 0x040036F5 RID: 14069
				[Token(Token = "0x40036F5")]
				[FieldOffset(Offset = "0x18")]
				public string charId;

				// Token: 0x040036F6 RID: 14070
				[Token(Token = "0x40036F6")]
				[FieldOffset(Offset = "0x20")]
				public string tmplId;

				// Token: 0x040036F7 RID: 14071
				[Token(Token = "0x40036F7")]
				[FieldOffset(Offset = "0x28")]
				public string diyBackupChessId;

				// Token: 0x040036F8 RID: 14072
				[Token(Token = "0x40036F8")]
				[FieldOffset(Offset = "0x30")]
				public string cultivateEffect;

				// Token: 0x040036F9 RID: 14073
				[Token(Token = "0x40036F9")]
				[FieldOffset(Offset = "0x38")]
				public string currentEquip;

				// Token: 0x040036FA RID: 14074
				[Token(Token = "0x40036FA")]
				[FieldOffset(Offset = "0x40")]
				public string skin;

				// Token: 0x040036FB RID: 14075
				[Token(Token = "0x40036FB")]
				[FieldOffset(Offset = "0x48")]
				public PlayerActivity.PlayerActAutoChessActivity.AutoChessCharType type;

				// Token: 0x040036FC RID: 14076
				[Token(Token = "0x40036FC")]
				[FieldOffset(Offset = "0x4C")]
				public int potentialRank;

				// Token: 0x040036FD RID: 14077
				[Token(Token = "0x40036FD")]
				[FieldOffset(Offset = "0x50")]
				public int skillIndex;

				// Token: 0x040036FE RID: 14078
				[Token(Token = "0x40036FE")]
				[FieldOffset(Offset = "0x58")]
				public PlayerActivity.PlayerActAutoChessActivity.AutoChessAssistInfo assistInfo;
			}

			// Token: 0x020009E4 RID: 2532
			[Token(Token = "0x20009E4")]
			public class AutoChessAssistInfo
			{
				// Token: 0x060066AB RID: 26283 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066AB")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AutoChessAssistInfo()
				{
				}

				// Token: 0x040036FF RID: 14079
				[Token(Token = "0x40036FF")]
				[FieldOffset(Offset = "0x10")]
				public string uid;

				// Token: 0x04003700 RID: 14080
				[Token(Token = "0x4003700")]
				[FieldOffset(Offset = "0x18")]
				public string nickName;

				// Token: 0x04003701 RID: 14081
				[Token(Token = "0x4003701")]
				[FieldOffset(Offset = "0x20")]
				public string nickNumber;

				// Token: 0x04003702 RID: 14082
				[Token(Token = "0x4003702")]
				[FieldOffset(Offset = "0x28")]
				public string alias;
			}

			// Token: 0x020009E5 RID: 2533
			[Token(Token = "0x20009E5")]
			public class MatchInfo
			{
				// Token: 0x060066AC RID: 26284 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066AC")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public MatchInfo()
				{
				}

				// Token: 0x04003703 RID: 14083
				[Token(Token = "0x4003703")]
				[FieldOffset(Offset = "0x10")]
				public long bannedUntilTs;
			}

			// Token: 0x020009E6 RID: 2534
			[Token(Token = "0x20009E6")]
			public class Scene
			{
				// Token: 0x060066AD RID: 26285 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066AD")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Scene()
				{
				}

				// Token: 0x04003704 RID: 14084
				[Token(Token = "0x4003704")]
				[FieldOffset(Offset = "0x10")]
				public List<string> lastMate;
			}
		}

		// Token: 0x020009E7 RID: 2535
		[Token(Token = "0x20009E7")]
		public class PlayerAct46SideActivity
		{
			// Token: 0x060066AE RID: 26286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066AE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerAct46SideActivity()
			{
			}

			// Token: 0x04003705 RID: 14085
			[Token(Token = "0x4003705")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x04003706 RID: 14086
			[Token(Token = "0x4003706")]
			[FieldOffset(Offset = "0x18")]
			public List<string> favorList;

			// Token: 0x04003707 RID: 14087
			[Token(Token = "0x4003707")]
			[FieldOffset(Offset = "0x20")]
			public bool outerOpen;

			// Token: 0x04003708 RID: 14088
			[Token(Token = "0x4003708")]
			[FieldOffset(Offset = "0x28")]
			public PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyGame game;

			// Token: 0x04003709 RID: 14089
			[Token(Token = "0x4003709")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyStage> monoStages;

			// Token: 0x020009E8 RID: 2536
			[Token(Token = "0x20009E8")]
			public class PlayerMonopolyGame
			{
				// Token: 0x060066AF RID: 26287 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066AF")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerMonopolyGame()
				{
				}

				// Token: 0x0400370A RID: 14090
				[Token(Token = "0x400370A")]
				[FieldOffset(Offset = "0x10")]
				public string stageId;

				// Token: 0x0400370B RID: 14091
				[Token(Token = "0x400370B")]
				[FieldOffset(Offset = "0x18")]
				public long startTs;

				// Token: 0x0400370C RID: 14092
				[Token(Token = "0x400370C")]
				[FieldOffset(Offset = "0x20")]
				public List<PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyBuff> buff;

				// Token: 0x0400370D RID: 14093
				[Token(Token = "0x400370D")]
				[FieldOffset(Offset = "0x28")]
				[JsonProperty(PropertyName = "round")]
				public int turn;

				// Token: 0x0400370E RID: 14094
				[Token(Token = "0x400370E")]
				[FieldOffset(Offset = "0x30")]
				public List<int> cardList;

				// Token: 0x0400370F RID: 14095
				[Token(Token = "0x400370F")]
				[FieldOffset(Offset = "0x38")]
				public int lastCard;

				// Token: 0x04003710 RID: 14096
				[Token(Token = "0x4003710")]
				[FieldOffset(Offset = "0x3C")]
				public int step;

				// Token: 0x04003711 RID: 14097
				[Token(Token = "0x4003711")]
				[FieldOffset(Offset = "0x40")]
				public List<PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyStageNode> nodeList;

				// Token: 0x04003712 RID: 14098
				[Token(Token = "0x4003712")]
				[FieldOffset(Offset = "0x48")]
				public PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyTaskPanelInfo task;
			}

			// Token: 0x020009E9 RID: 2537
			[Token(Token = "0x20009E9")]
			public class PlayerMonopolyTaskItemProcess
			{
				// Token: 0x060066B0 RID: 26288 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066B0")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerMonopolyTaskItemProcess()
				{
				}

				// Token: 0x04003713 RID: 14099
				[Token(Token = "0x4003713")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty(PropertyName = "type")]
				public string requireType;

				// Token: 0x04003714 RID: 14100
				[Token(Token = "0x4003714")]
				[FieldOffset(Offset = "0x18")]
				public int value;

				// Token: 0x04003715 RID: 14101
				[Token(Token = "0x4003715")]
				[FieldOffset(Offset = "0x1C")]
				public int target;
			}

			// Token: 0x020009EA RID: 2538
			[Token(Token = "0x20009EA")]
			public class PlayerMonopolyTask
			{
				// Token: 0x060066B1 RID: 26289 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066B1")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerMonopolyTask()
				{
				}

				// Token: 0x04003716 RID: 14102
				[Token(Token = "0x4003716")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003717 RID: 14103
				[Token(Token = "0x4003717")]
				[FieldOffset(Offset = "0x18")]
				public int point;

				// Token: 0x04003718 RID: 14104
				[Token(Token = "0x4003718")]
				[FieldOffset(Offset = "0x20")]
				public List<PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyTaskItemProcess> process;
			}

			// Token: 0x020009EB RID: 2539
			[Token(Token = "0x20009EB")]
			public class PlayerMonopolyBuff
			{
				// Token: 0x060066B2 RID: 26290 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066B2")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerMonopolyBuff()
				{
				}

				// Token: 0x04003719 RID: 14105
				[Token(Token = "0x4003719")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x0400371A RID: 14106
				[Token(Token = "0x400371A")]
				[FieldOffset(Offset = "0x18")]
				public PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyBuff.BuffProcess process;

				// Token: 0x020009EC RID: 2540
				[Token(Token = "0x20009EC")]
				public class BuffProcess
				{
					// Token: 0x060066B3 RID: 26291 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60066B3")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public BuffProcess()
					{
					}

					// Token: 0x0400371B RID: 14107
					[Token(Token = "0x400371B")]
					[FieldOffset(Offset = "0x10")]
					public int value;

					// Token: 0x0400371C RID: 14108
					[Token(Token = "0x400371C")]
					[FieldOffset(Offset = "0x14")]
					public int target;
				}
			}

			// Token: 0x020009ED RID: 2541
			[Token(Token = "0x20009ED")]
			public enum MonopolyStageStatus
			{
				// Token: 0x0400371E RID: 14110
				[Token(Token = "0x400371E")]
				LOCK,
				// Token: 0x0400371F RID: 14111
				[Token(Token = "0x400371F")]
				UNLOCK,
				// Token: 0x04003720 RID: 14112
				[Token(Token = "0x4003720")]
				PASS
			}

			// Token: 0x020009EE RID: 2542
			[Token(Token = "0x20009EE")]
			public class PlayerMonopolyStage
			{
				// Token: 0x060066B4 RID: 26292 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066B4")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerMonopolyStage()
				{
				}

				// Token: 0x04003721 RID: 14113
				[Token(Token = "0x4003721")]
				[FieldOffset(Offset = "0x10")]
				public PlayerActivity.PlayerAct46SideActivity.MonopolyStageStatus state;

				// Token: 0x04003722 RID: 14114
				[Token(Token = "0x4003722")]
				[FieldOffset(Offset = "0x14")]
				public int highScore;
			}

			// Token: 0x020009EF RID: 2543
			[Token(Token = "0x20009EF")]
			public class PlayerMonopolyStageNode
			{
				// Token: 0x060066B5 RID: 26293 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066B5")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerMonopolyStageNode()
				{
				}

				// Token: 0x04003723 RID: 14115
				[Token(Token = "0x4003723")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty(PropertyName = "type")]
				public string resourceId;

				// Token: 0x04003724 RID: 14116
				[Token(Token = "0x4003724")]
				[FieldOffset(Offset = "0x18")]
				[JsonProperty(PropertyName = "resource")]
				public int resourceBasicCount;

				// Token: 0x04003725 RID: 14117
				[Token(Token = "0x4003725")]
				[FieldOffset(Offset = "0x1C")]
				public int buffRate;

				// Token: 0x04003726 RID: 14118
				[Token(Token = "0x4003726")]
				[FieldOffset(Offset = "0x20")]
				[JsonProperty(PropertyName = "lock")]
				public bool isNodeLock;

				// Token: 0x04003727 RID: 14119
				[Token(Token = "0x4003727")]
				[FieldOffset(Offset = "0x21")]
				[JsonProperty(PropertyName = "crate")]
				public bool hasChest;
			}

			// Token: 0x020009F0 RID: 2544
			[Token(Token = "0x20009F0")]
			public class PlayerMonopolyTaskPanelInfo
			{
				// Token: 0x060066B6 RID: 26294 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066B6")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PlayerMonopolyTaskPanelInfo()
				{
				}

				// Token: 0x04003728 RID: 14120
				[Token(Token = "0x4003728")]
				[FieldOffset(Offset = "0x10")]
				public List<PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyTask> shortList;

				// Token: 0x04003729 RID: 14121
				[Token(Token = "0x4003729")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyTask> longList;

				// Token: 0x0400372A RID: 14122
				[Token(Token = "0x400372A")]
				[FieldOffset(Offset = "0x20")]
				public int score;
			}
		}
	}
}
