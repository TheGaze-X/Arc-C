using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000B1F RID: 2847
	[Token(Token = "0x2000B1F")]
	public class PlayerRoguelikePendingEvent
	{
		// Token: 0x060067CF RID: 26575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CF")]
		[Address(RVA = "0x1EFCDF0", Offset = "0x1EFB9F0", VA = "0x181EFCDF0")]
		public PlayerRoguelikePendingEvent()
		{
		}

		// Token: 0x04003B96 RID: 15254
		[Token(Token = "0x4003B96")]
		[FieldOffset(Offset = "0x10")]
		public PlayerRoguelikePlayerEventType type;

		// Token: 0x04003B97 RID: 15255
		[Token(Token = "0x4003B97")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRoguelikePendingEvent.Content content;

		// Token: 0x02000B20 RID: 2848
		[Token(Token = "0x2000B20")]
		public class BattleRewardContent
		{
			// Token: 0x060067D0 RID: 26576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleRewardContent()
			{
			}

			// Token: 0x04003B98 RID: 15256
			[Token(Token = "0x4003B98")]
			[FieldOffset(Offset = "0x10")]
			public List<RoguelikeReward> rewards;

			// Token: 0x04003B99 RID: 15257
			[Token(Token = "0x4003B99")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeStageEarn earn;

			// Token: 0x04003B9A RID: 15258
			[Token(Token = "0x4003B9A")]
			[FieldOffset(Offset = "0x20")]
			public string show;

			// Token: 0x04003B9B RID: 15259
			[Token(Token = "0x4003B9B")]
			[FieldOffset(Offset = "0x28")]
			public int state;

			// Token: 0x04003B9C RID: 15260
			[Token(Token = "0x4003B9C")]
			[FieldOffset(Offset = "0x2C")]
			public int isPerfect;
		}

		// Token: 0x02000B21 RID: 2849
		[Token(Token = "0x2000B21")]
		public class BattleContent
		{
			// Token: 0x060067D1 RID: 26577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleContent()
			{
			}

			// Token: 0x04003B9D RID: 15261
			[Token(Token = "0x4003B9D")]
			[FieldOffset(Offset = "0x10")]
			public int state;

			// Token: 0x04003B9E RID: 15262
			[Token(Token = "0x4003B9E")]
			[FieldOffset(Offset = "0x14")]
			public int chestCnt;

			// Token: 0x04003B9F RID: 15263
			[Token(Token = "0x4003B9F")]
			[FieldOffset(Offset = "0x18")]
			public int goldTrapCnt;

			// Token: 0x04003BA0 RID: 15264
			[Token(Token = "0x4003BA0")]
			[FieldOffset(Offset = "0x20")]
			public List<PlayerRoguelikeV2.CurrentData.Char> tmpChar;

			// Token: 0x04003BA1 RID: 15265
			[Token(Token = "0x4003BA1")]
			[FieldOffset(Offset = "0x28")]
			public List<RoguelikeBuff> unKeepBuff;

			// Token: 0x04003BA2 RID: 15266
			[Token(Token = "0x4003BA2")]
			[FieldOffset(Offset = "0x30")]
			public List<int> diceRoll;

			// Token: 0x04003BA3 RID: 15267
			[Token(Token = "0x4003BA3")]
			[FieldOffset(Offset = "0x38")]
			public int sanity;

			// Token: 0x04003BA4 RID: 15268
			[Token(Token = "0x4003BA4")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, int> boxInfo;

			// Token: 0x04003BA5 RID: 15269
			[Token(Token = "0x4003BA5")]
			[FieldOffset(Offset = "0x48")]
			public bool isFailProtect;

			// Token: 0x04003BA6 RID: 15270
			[Token(Token = "0x4003BA6")]
			[FieldOffset(Offset = "0x4C")]
			public int seed;

			// Token: 0x04003BA7 RID: 15271
			[Token(Token = "0x4003BA7")]
			[FieldOffset(Offset = "0x50")]
			public Dictionary<string, float> enemyHpInfo;

			// Token: 0x04003BA8 RID: 15272
			[Token(Token = "0x4003BA8")]
			[FieldOffset(Offset = "0x58")]
			public string battleSnapshot;

			// Token: 0x04003BA9 RID: 15273
			[Token(Token = "0x4003BA9")]
			[FieldOffset(Offset = "0x60")]
			public RoguelikeBattleFailDisplay battleFailDisplay;
		}

		// Token: 0x02000B22 RID: 2850
		[Token(Token = "0x2000B22")]
		public class InitRecruitContent
		{
			// Token: 0x060067D2 RID: 26578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InitRecruitContent()
			{
			}

			// Token: 0x04003BAA RID: 15274
			[Token(Token = "0x4003BAA")]
			[FieldOffset(Offset = "0x10")]
			public int[] step;

			// Token: 0x04003BAB RID: 15275
			[Token(Token = "0x4003BAB")]
			[FieldOffset(Offset = "0x18")]
			public string[] tickets;

			// Token: 0x04003BAC RID: 15276
			[Token(Token = "0x4003BAC")]
			[FieldOffset(Offset = "0x20")]
			public PlayerRoguelikePendingEvent.InitRecruitContent.ShowChar[] showChar;

			// Token: 0x04003BAD RID: 15277
			[Token(Token = "0x4003BAD")]
			[FieldOffset(Offset = "0x28")]
			public string team;

			// Token: 0x02000B23 RID: 2851
			[Token(Token = "0x2000B23")]
			public class ShowChar
			{
				// Token: 0x060067D3 RID: 26579 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067D3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ShowChar()
				{
				}

				// Token: 0x04003BAE RID: 15278
				[Token(Token = "0x4003BAE")]
				[FieldOffset(Offset = "0x10")]
				public string charId;

				// Token: 0x04003BAF RID: 15279
				[Token(Token = "0x4003BAF")]
				[FieldOffset(Offset = "0x18")]
				public string tmplId;

				// Token: 0x04003BB0 RID: 15280
				[Token(Token = "0x4003BB0")]
				[FieldOffset(Offset = "0x20")]
				public string uniEquipIdOfChar;

				// Token: 0x04003BB1 RID: 15281
				[Token(Token = "0x4003BB1")]
				[FieldOffset(Offset = "0x28")]
				public RoguelikeCharState type;
			}
		}

		// Token: 0x02000B24 RID: 2852
		[Token(Token = "0x2000B24")]
		public class InitRecruitSetContent
		{
			// Token: 0x060067D4 RID: 26580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InitRecruitSetContent()
			{
			}

			// Token: 0x04003BB2 RID: 15282
			[Token(Token = "0x4003BB2")]
			[FieldOffset(Offset = "0x10")]
			public int[] step;

			// Token: 0x04003BB3 RID: 15283
			[Token(Token = "0x4003BB3")]
			[FieldOffset(Offset = "0x18")]
			public string[] option;
		}

		// Token: 0x02000B25 RID: 2853
		[Token(Token = "0x2000B25")]
		public class InitRelicContent
		{
			// Token: 0x060067D5 RID: 26581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InitRelicContent()
			{
			}

			// Token: 0x04003BB4 RID: 15284
			[Token(Token = "0x4003BB4")]
			[FieldOffset(Offset = "0x10")]
			public int[] step;

			// Token: 0x04003BB5 RID: 15285
			[Token(Token = "0x4003BB5")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, RoguelikeItemBundle> items;
		}

		// Token: 0x02000B26 RID: 2854
		[Token(Token = "0x2000B26")]
		public class InitModeRelic
		{
			// Token: 0x060067D6 RID: 26582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D6")]
			[Address(RVA = "0x1EEACC0", Offset = "0x1EE98C0", VA = "0x181EEACC0")]
			public InitModeRelic()
			{
			}

			// Token: 0x04003BB6 RID: 15286
			[Token(Token = "0x4003BB6")]
			[FieldOffset(Offset = "0x10")]
			public int[] step;

			// Token: 0x04003BB7 RID: 15287
			[Token(Token = "0x4003BB7")]
			[FieldOffset(Offset = "0x18")]
			public List<string> items;
		}

		// Token: 0x02000B27 RID: 2855
		[Token(Token = "0x2000B27")]
		public class InitTeam
		{
			// Token: 0x060067D7 RID: 26583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D7")]
			[Address(RVA = "0x1EEADC0", Offset = "0x1EE99C0", VA = "0x181EEADC0")]
			public InitTeam()
			{
			}

			// Token: 0x04003BB8 RID: 15288
			[Token(Token = "0x4003BB8")]
			[FieldOffset(Offset = "0x10")]
			public int[] step;

			// Token: 0x04003BB9 RID: 15289
			[Token(Token = "0x4003BB9")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerRoguelikePendingEvent.InitTeam.Char> chars;

			// Token: 0x04003BBA RID: 15290
			[Token(Token = "0x4003BBA")]
			[FieldOffset(Offset = "0x20")]
			public string team;

			// Token: 0x02000B28 RID: 2856
			[Token(Token = "0x2000B28")]
			public class Char
			{
				// Token: 0x060067D8 RID: 26584 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067D8")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Char()
				{
				}

				// Token: 0x04003BBB RID: 15291
				[Token(Token = "0x4003BBB")]
				[FieldOffset(Offset = "0x10")]
				public string charId;

				// Token: 0x04003BBC RID: 15292
				[Token(Token = "0x4003BBC")]
				[FieldOffset(Offset = "0x18")]
				public string tmplId;

				// Token: 0x04003BBD RID: 15293
				[Token(Token = "0x4003BBD")]
				[FieldOffset(Offset = "0x20")]
				public string uniEquipIdOfChar;

				// Token: 0x04003BBE RID: 15294
				[Token(Token = "0x4003BBE")]
				[FieldOffset(Offset = "0x28")]
				public RoguelikeCharState type;
			}
		}

		// Token: 0x02000B29 RID: 2857
		[Token(Token = "0x2000B29")]
		public class InitSupport
		{
			// Token: 0x060067D9 RID: 26585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067D9")]
			[Address(RVA = "0x1EEAD50", Offset = "0x1EE9950", VA = "0x181EEAD50")]
			public InitSupport()
			{
			}

			// Token: 0x04003BBF RID: 15295
			[Token(Token = "0x4003BBF")]
			[FieldOffset(Offset = "0x10")]
			public int[] step;

			// Token: 0x04003BC0 RID: 15296
			[Token(Token = "0x4003BC0")]
			[FieldOffset(Offset = "0x18")]
			public PlayerRoguelikePendingEvent.SceneContent scene;
		}

		// Token: 0x02000B2A RID: 2858
		[Token(Token = "0x2000B2A")]
		public class InitExploreTool
		{
			// Token: 0x060067DA RID: 26586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InitExploreTool()
			{
			}

			// Token: 0x04003BC1 RID: 15297
			[Token(Token = "0x4003BC1")]
			[FieldOffset(Offset = "0x10")]
			public int[] step;

			// Token: 0x04003BC2 RID: 15298
			[Token(Token = "0x4003BC2")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, RoguelikeItemBundle> items;
		}

		// Token: 0x02000B2B RID: 2859
		[Token(Token = "0x2000B2B")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum PlayerRoguelikeChoiceRewardType
		{
			// Token: 0x04003BC4 RID: 15300
			[Token(Token = "0x4003BC4")]
			NONE,
			// Token: 0x04003BC5 RID: 15301
			[Token(Token = "0x4003BC5")]
			ITEM,
			// Token: 0x04003BC6 RID: 15302
			[Token(Token = "0x4003BC6")]
			MISSION
		}

		// Token: 0x02000B2C RID: 2860
		[Token(Token = "0x2000B2C")]
		public class ChoiceAddition
		{
			// Token: 0x060067DB RID: 26587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DB")]
			[Address(RVA = "0x1EE7A50", Offset = "0x1EE6650", VA = "0x181EE7A50")]
			public ChoiceAddition()
			{
			}

			// Token: 0x04003BC7 RID: 15303
			[Token(Token = "0x4003BC7")]
			[FieldOffset(Offset = "0x10")]
			public List<PlayerRoguelikePendingEvent.ChoiceAddition.Reward> rewards;

			// Token: 0x02000B2D RID: 2861
			[Token(Token = "0x2000B2D")]
			public class Reward
			{
				// Token: 0x060067DC RID: 26588 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067DC")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Reward()
				{
				}

				// Token: 0x04003BC8 RID: 15304
				[Token(Token = "0x4003BC8")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003BC9 RID: 15305
				[Token(Token = "0x4003BC9")]
				[FieldOffset(Offset = "0x18")]
				public PlayerRoguelikePendingEvent.PlayerRoguelikeChoiceRewardType type;
			}
		}

		// Token: 0x02000B2E RID: 2862
		[Token(Token = "0x2000B2E")]
		public class SceneContent
		{
			// Token: 0x060067DD RID: 26589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DD")]
			[Address(RVA = "0x1F013B0", Offset = "0x1EFFFB0", VA = "0x181F013B0")]
			public SceneContent()
			{
			}

			// Token: 0x04003BCA RID: 15306
			[Token(Token = "0x4003BCA")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04003BCB RID: 15307
			[Token(Token = "0x4003BCB")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, bool> choices;

			// Token: 0x04003BCC RID: 15308
			[Token(Token = "0x4003BCC")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerRoguelikePendingEvent.ChoiceAddition> choiceAdditional;
		}

		// Token: 0x02000B2F RID: 2863
		[Token(Token = "0x2000B2F")]
		public class Recruit
		{
			// Token: 0x060067DE RID: 26590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Recruit()
			{
			}

			// Token: 0x04003BCD RID: 15309
			[Token(Token = "0x4003BCD")]
			[FieldOffset(Offset = "0x10")]
			public string ticket;
		}

		// Token: 0x02000B30 RID: 2864
		[Token(Token = "0x2000B30")]
		public class Dice
		{
			// Token: 0x060067DF RID: 26591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Dice()
			{
			}

			// Token: 0x04003BCE RID: 15310
			[Token(Token = "0x4003BCE")]
			[FieldOffset(Offset = "0x10")]
			public PlayerRoguelikePendingEvent.Dice.Result result;

			// Token: 0x04003BCF RID: 15311
			[Token(Token = "0x4003BCF")]
			[FieldOffset(Offset = "0x18")]
			public int rerollCount;

			// Token: 0x02000B31 RID: 2865
			[Token(Token = "0x2000B31")]
			public class Result
			{
				// Token: 0x060067E0 RID: 26592 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067E0")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Result()
				{
				}

				// Token: 0x04003BD0 RID: 15312
				[Token(Token = "0x4003BD0")]
				[FieldOffset(Offset = "0x10")]
				public string diceEventId;

				// Token: 0x04003BD1 RID: 15313
				[Token(Token = "0x4003BD1")]
				[FieldOffset(Offset = "0x18")]
				public int diceRoll;

				// Token: 0x04003BD2 RID: 15314
				[Token(Token = "0x4003BD2")]
				[FieldOffset(Offset = "0x20")]
				public PlayerRoguelikePendingEvent.Dice.MutationResult mutation;

				// Token: 0x04003BD3 RID: 15315
				[Token(Token = "0x4003BD3")]
				[FieldOffset(Offset = "0x28")]
				public string[] virtue;
			}

			// Token: 0x02000B32 RID: 2866
			[Token(Token = "0x2000B32")]
			public class MutationResult
			{
				// Token: 0x060067E1 RID: 26593 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067E1")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public MutationResult()
				{
				}

				// Token: 0x04003BD4 RID: 15316
				[Token(Token = "0x4003BD4")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003BD5 RID: 15317
				[Token(Token = "0x4003BD5")]
				[FieldOffset(Offset = "0x18")]
				public string[] chars;
			}
		}

		// Token: 0x02000B33 RID: 2867
		[Token(Token = "0x2000B33")]
		public class ShopContent
		{
			// Token: 0x060067E2 RID: 26594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067E2")]
			[Address(RVA = "0x1F014E0", Offset = "0x1F000E0", VA = "0x181F014E0")]
			public ShopContent()
			{
			}

			// Token: 0x04003BD6 RID: 15318
			[Token(Token = "0x4003BD6")]
			[FieldOffset(Offset = "0x10")]
			public PlayerRoguelikePendingEvent.ShopContent.Bank bank;

			// Token: 0x04003BD7 RID: 15319
			[Token(Token = "0x4003BD7")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			// Token: 0x04003BD8 RID: 15320
			[Token(Token = "0x4003BD8")]
			[FieldOffset(Offset = "0x20")]
			public List<PlayerRoguelikePendingEvent.ShopContent.Goods> goods;

			// Token: 0x04003BD9 RID: 15321
			[Token(Token = "0x4003BD9")]
			[FieldOffset(Offset = "0x28")]
			public bool canBattle;

			// Token: 0x04003BDA RID: 15322
			[Token(Token = "0x4003BDA")]
			[FieldOffset(Offset = "0x29")]
			public bool hasBoss;

			// Token: 0x04003BDB RID: 15323
			[Token(Token = "0x4003BDB")]
			[FieldOffset(Offset = "0x2A")]
			public bool showRefresh;

			// Token: 0x04003BDC RID: 15324
			[Token(Token = "0x4003BDC")]
			[FieldOffset(Offset = "0x2C")]
			public int refreshCnt;

			// Token: 0x04003BDD RID: 15325
			[Token(Token = "0x4003BDD")]
			[FieldOffset(Offset = "0x30")]
			public int refreshCost;

			// Token: 0x04003BDE RID: 15326
			[Token(Token = "0x4003BDE")]
			[FieldOffset(Offset = "0x38")]
			public List<PlayerRoguelikePendingEvent.ShopContent.Goods> recycleGoods;

			// Token: 0x04003BDF RID: 15327
			[Token(Token = "0x4003BDF")]
			[FieldOffset(Offset = "0x40")]
			public int recycleCount;

			// Token: 0x02000B34 RID: 2868
			[Token(Token = "0x2000B34")]
			public class Bank
			{
				// Token: 0x060067E3 RID: 26595 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067E3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Bank()
				{
				}

				// Token: 0x04003BE0 RID: 15328
				[Token(Token = "0x4003BE0")]
				[FieldOffset(Offset = "0x10")]
				public int cost;

				// Token: 0x04003BE1 RID: 15329
				[Token(Token = "0x4003BE1")]
				[FieldOffset(Offset = "0x14")]
				public bool open;

				// Token: 0x04003BE2 RID: 15330
				[Token(Token = "0x4003BE2")]
				[FieldOffset(Offset = "0x15")]
				public bool canPut;

				// Token: 0x04003BE3 RID: 15331
				[Token(Token = "0x4003BE3")]
				[FieldOffset(Offset = "0x16")]
				public bool canWithdraw;

				// Token: 0x04003BE4 RID: 15332
				[Token(Token = "0x4003BE4")]
				[FieldOffset(Offset = "0x18")]
				public int withdraw;

				// Token: 0x04003BE5 RID: 15333
				[Token(Token = "0x4003BE5")]
				[FieldOffset(Offset = "0x1C")]
				public int withdrawLimit;
			}

			// Token: 0x02000B35 RID: 2869
			[Token(Token = "0x2000B35")]
			public class Goods
			{
				// Token: 0x060067E4 RID: 26596 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067E4")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Goods()
				{
				}

				// Token: 0x04003BE6 RID: 15334
				[Token(Token = "0x4003BE6")]
				[FieldOffset(Offset = "0x10")]
				public string index;

				// Token: 0x04003BE7 RID: 15335
				[Token(Token = "0x4003BE7")]
				[FieldOffset(Offset = "0x18")]
				public string itemId;

				// Token: 0x04003BE8 RID: 15336
				[Token(Token = "0x4003BE8")]
				[FieldOffset(Offset = "0x20")]
				public int count;

				// Token: 0x04003BE9 RID: 15337
				[Token(Token = "0x4003BE9")]
				[FieldOffset(Offset = "0x28")]
				public string priceId;

				// Token: 0x04003BEA RID: 15338
				[Token(Token = "0x4003BEA")]
				[FieldOffset(Offset = "0x30")]
				public int priceCount;

				// Token: 0x04003BEB RID: 15339
				[Token(Token = "0x4003BEB")]
				[FieldOffset(Offset = "0x34")]
				public int origCost;

				// Token: 0x04003BEC RID: 15340
				[Token(Token = "0x4003BEC")]
				[FieldOffset(Offset = "0x38")]
				public bool displayPriceChg;
			}
		}

		// Token: 0x02000B36 RID: 2870
		[Token(Token = "0x2000B36")]
		public class SacrificeContent
		{
			// Token: 0x060067E5 RID: 26597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067E5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SacrificeContent()
			{
			}

			// Token: 0x04003BED RID: 15341
			[Token(Token = "0x4003BED")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeSacrificeType type;

			// Token: 0x04003BEE RID: 15342
			[Token(Token = "0x4003BEE")]
			[FieldOffset(Offset = "0x18")]
			public string priceId;

			// Token: 0x04003BEF RID: 15343
			[Token(Token = "0x4003BEF")]
			[FieldOffset(Offset = "0x20")]
			public int cost;

			// Token: 0x04003BF0 RID: 15344
			[Token(Token = "0x4003BF0")]
			[FieldOffset(Offset = "0x28")]
			public string _choiceId;
		}

		// Token: 0x02000B37 RID: 2871
		[Token(Token = "0x2000B37")]
		public class ExpeditionContent
		{
			// Token: 0x060067E6 RID: 26598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067E6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ExpeditionContent()
			{
			}

			// Token: 0x04003BF1 RID: 15345
			[Token(Token = "0x4003BF1")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeExpeditionType type;

			// Token: 0x04003BF2 RID: 15346
			[Token(Token = "0x4003BF2")]
			[FieldOffset(Offset = "0x18")]
			public string priceId;

			// Token: 0x04003BF3 RID: 15347
			[Token(Token = "0x4003BF3")]
			[FieldOffset(Offset = "0x20")]
			public int cost;

			// Token: 0x04003BF4 RID: 15348
			[Token(Token = "0x4003BF4")]
			[FieldOffset(Offset = "0x28")]
			public string _choiceId;
		}

		// Token: 0x02000B38 RID: 2872
		[Token(Token = "0x2000B38")]
		public class EndingResult
		{
			// Token: 0x060067E7 RID: 26599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067E7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EndingResult()
			{
			}

			// Token: 0x04003BF5 RID: 15349
			[Token(Token = "0x4003BF5")]
			[FieldOffset(Offset = "0x10")]
			public PlayerRoguelikePendingEvent.EndingBrief brief;

			// Token: 0x04003BF6 RID: 15350
			[Token(Token = "0x4003BF6")]
			[FieldOffset(Offset = "0x18")]
			public PlayerRoguelikePendingEvent.EndingRecord record;
		}

		// Token: 0x02000B39 RID: 2873
		[Token(Token = "0x2000B39")]
		public class EndingBrief
		{
			// Token: 0x060067E8 RID: 26600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067E8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EndingBrief()
			{
			}

			// Token: 0x04003BF7 RID: 15351
			[Token(Token = "0x4003BF7")]
			[FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x04003BF8 RID: 15352
			[Token(Token = "0x4003BF8")]
			[FieldOffset(Offset = "0x14")]
			public int success;

			// Token: 0x04003BF9 RID: 15353
			[Token(Token = "0x4003BF9")]
			[FieldOffset(Offset = "0x18")]
			public string ending;

			// Token: 0x04003BFA RID: 15354
			[Token(Token = "0x4003BFA")]
			[FieldOffset(Offset = "0x20")]
			public string failEnding;

			// Token: 0x04003BFB RID: 15355
			[Token(Token = "0x4003BFB")]
			[FieldOffset(Offset = "0x28")]
			public string theme;

			// Token: 0x04003BFC RID: 15356
			[Token(Token = "0x4003BFC")]
			[FieldOffset(Offset = "0x30")]
			public RoguelikeTopicMode mode;

			// Token: 0x04003BFD RID: 15357
			[Token(Token = "0x4003BFD")]
			[FieldOffset(Offset = "0x38")]
			public string predefined;

			// Token: 0x04003BFE RID: 15358
			[Token(Token = "0x4003BFE")]
			[FieldOffset(Offset = "0x40")]
			public string band;

			// Token: 0x04003BFF RID: 15359
			[Token(Token = "0x4003BFF")]
			[FieldOffset(Offset = "0x48")]
			public long startTs;

			// Token: 0x04003C00 RID: 15360
			[Token(Token = "0x4003C00")]
			[FieldOffset(Offset = "0x50")]
			public long endTs;

			// Token: 0x04003C01 RID: 15361
			[Token(Token = "0x4003C01")]
			[FieldOffset(Offset = "0x58")]
			public string endZoneId;

			// Token: 0x04003C02 RID: 15362
			[Token(Token = "0x4003C02")]
			[FieldOffset(Offset = "0x60")]
			public int modeGrade;

			// Token: 0x04003C03 RID: 15363
			[Token(Token = "0x4003C03")]
			[FieldOffset(Offset = "0x68")]
			public string seed;

			// Token: 0x04003C04 RID: 15364
			[Token(Token = "0x4003C04")]
			[FieldOffset(Offset = "0x70")]
			public string activity;
		}

		// Token: 0x02000B3A RID: 2874
		[Token(Token = "0x2000B3A")]
		public class EndingRecord
		{
			// Token: 0x060067E9 RID: 26601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067E9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EndingRecord()
			{
			}

			// Token: 0x04003C05 RID: 15365
			[Token(Token = "0x4003C05")]
			[FieldOffset(Offset = "0x10")]
			public int cntZone;

			// Token: 0x04003C06 RID: 15366
			[Token(Token = "0x4003C06")]
			[FieldOffset(Offset = "0x18")]
			public List<string> relicList;

			// Token: 0x04003C07 RID: 15367
			[Token(Token = "0x4003C07")]
			[FieldOffset(Offset = "0x20")]
			public List<string> capsuleList;

			// Token: 0x04003C08 RID: 15368
			[Token(Token = "0x4003C08")]
			[FieldOffset(Offset = "0x28")]
			public List<string> activeToolList;

			// Token: 0x04003C09 RID: 15369
			[Token(Token = "0x4003C09")]
			[FieldOffset(Offset = "0x30")]
			public List<string> charBuff;

			// Token: 0x04003C0A RID: 15370
			[Token(Token = "0x4003C0A")]
			[FieldOffset(Offset = "0x38")]
			public List<string> squadBuff;

			// Token: 0x04003C0B RID: 15371
			[Token(Token = "0x4003C0B")]
			[FieldOffset(Offset = "0x40")]
			public List<string> totemList;

			// Token: 0x04003C0C RID: 15372
			[Token(Token = "0x4003C0C")]
			[FieldOffset(Offset = "0x48")]
			public List<string> exploreToolList;

			// Token: 0x04003C0D RID: 15373
			[Token(Token = "0x4003C0D")]
			[FieldOffset(Offset = "0x50")]
			public List<string> fragmentList;

			// Token: 0x04003C0E RID: 15374
			[Token(Token = "0x4003C0E")]
			[FieldOffset(Offset = "0x58")]
			public Dictionary<string, int> copperCounter;
		}

		// Token: 0x02000B3B RID: 2875
		[Token(Token = "0x2000B3B")]
		public class AlchemyContent
		{
			// Token: 0x060067EA RID: 26602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067EA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AlchemyContent()
			{
			}

			// Token: 0x04003C0F RID: 15375
			[Token(Token = "0x4003C0F")]
			[FieldOffset(Offset = "0x10")]
			public bool canAlchemy;
		}

		// Token: 0x02000B3C RID: 2876
		[Token(Token = "0x2000B3C")]
		public class UseStashedTicketContent
		{
			// Token: 0x060067EB RID: 26603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067EB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UseStashedTicketContent()
			{
			}

			// Token: 0x04003C10 RID: 15376
			[Token(Token = "0x4003C10")]
			[FieldOffset(Offset = "0x10")]
			public int count;

			// Token: 0x04003C11 RID: 15377
			[Token(Token = "0x4003C11")]
			[FieldOffset(Offset = "0x14")]
			public int recruitCostAdd;
		}

		// Token: 0x02000B3D RID: 2877
		[Token(Token = "0x2000B3D")]
		public class GildCopperContent
		{
			// Token: 0x060067EC RID: 26604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GildCopperContent()
			{
			}

			// Token: 0x04003C12 RID: 15378
			[Token(Token = "0x4003C12")]
			[FieldOffset(Offset = "0x10")]
			public string type;

			// Token: 0x04003C13 RID: 15379
			[Token(Token = "0x4003C13")]
			[FieldOffset(Offset = "0x18")]
			public int cost;

			// Token: 0x04003C14 RID: 15380
			[Token(Token = "0x4003C14")]
			[FieldOffset(Offset = "0x20")]
			public string priceId;
		}

		// Token: 0x02000B3E RID: 2878
		[Token(Token = "0x2000B3E")]
		public class AlchemyRewardContent
		{
			// Token: 0x060067ED RID: 26605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067ED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AlchemyRewardContent()
			{
			}

			// Token: 0x04003C15 RID: 15381
			[Token(Token = "0x4003C15")]
			[FieldOffset(Offset = "0x10")]
			public List<RoguelikeItemBundle> items;

			// Token: 0x04003C16 RID: 15382
			[Token(Token = "0x4003C16")]
			[FieldOffset(Offset = "0x18")]
			public bool isSSR;

			// Token: 0x04003C17 RID: 15383
			[Token(Token = "0x4003C17")]
			[FieldOffset(Offset = "0x19")]
			public bool isFail;
		}

		// Token: 0x02000B3F RID: 2879
		[Token(Token = "0x2000B3F")]
		public class SwapCopper
		{
			// Token: 0x060067EE RID: 26606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067EE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SwapCopper()
			{
			}

			// Token: 0x04003C18 RID: 15384
			[Token(Token = "0x4003C18")]
			[FieldOffset(Offset = "0x10")]
			public string newCopper;
		}

		// Token: 0x02000B40 RID: 2880
		[Token(Token = "0x2000B40")]
		public class DrawCopper
		{
			// Token: 0x060067EF RID: 26607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067EF")]
			[Address(RVA = "0x1EE9C10", Offset = "0x1EE8810", VA = "0x181EE9C10")]
			public DrawCopper()
			{
			}

			// Token: 0x04003C19 RID: 15385
			[Token(Token = "0x4003C19")]
			[FieldOffset(Offset = "0x10")]
			public List<string> copper;

			// Token: 0x04003C1A RID: 15386
			[Token(Token = "0x4003C1A")]
			[FieldOffset(Offset = "0x18")]
			public string divineEventId;

			// Token: 0x04003C1B RID: 15387
			[Token(Token = "0x4003C1B")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, int> hitReason;

			// Token: 0x04003C1C RID: 15388
			[Token(Token = "0x4003C1C")]
			[FieldOffset(Offset = "0x28")]
			public List<PlayerRoguelikePendingEvent.CopperExchangeInfo> exchangeInfo;
		}

		// Token: 0x02000B41 RID: 2881
		[Token(Token = "0x2000B41")]
		public class CopperExchangeInfo
		{
			// Token: 0x060067F0 RID: 26608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067F0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CopperExchangeInfo()
			{
			}

			// Token: 0x04003C1D RID: 15389
			[Token(Token = "0x4003C1D")]
			[FieldOffset(Offset = "0x10")]
			public string cost;

			// Token: 0x04003C1E RID: 15390
			[Token(Token = "0x4003C1E")]
			[FieldOffset(Offset = "0x18")]
			public string gain;
		}

		// Token: 0x02000B42 RID: 2882
		[Token(Token = "0x2000B42")]
		public enum DrawCopperHitReason
		{
			// Token: 0x04003C20 RID: 15392
			[Token(Token = "0x4003C20")]
			NORMAL,
			// Token: 0x04003C21 RID: 15393
			[Token(Token = "0x4003C21")]
			BUFF_EXTRA,
			// Token: 0x04003C22 RID: 15394
			[Token(Token = "0x4003C22")]
			FREEZE
		}

		// Token: 0x02000B43 RID: 2883
		[Token(Token = "0x2000B43")]
		public class Content
		{
			// Token: 0x060067F1 RID: 26609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067F1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Content()
			{
			}

			// Token: 0x04003C23 RID: 15395
			[Token(Token = "0x4003C23")]
			[FieldOffset(Offset = "0x10")]
			public PlayerRoguelikePendingEvent.SceneContent scene;

			// Token: 0x04003C24 RID: 15396
			[Token(Token = "0x4003C24")]
			[FieldOffset(Offset = "0x18")]
			public PlayerRoguelikePendingEvent.InitRecruitContent initRecruit;

			// Token: 0x04003C25 RID: 15397
			[Token(Token = "0x4003C25")]
			[FieldOffset(Offset = "0x20")]
			public PlayerRoguelikePendingEvent.BattleContent battle;

			// Token: 0x04003C26 RID: 15398
			[Token(Token = "0x4003C26")]
			[FieldOffset(Offset = "0x28")]
			public PlayerRoguelikePendingEvent.InitRelicContent initRelic;

			// Token: 0x04003C27 RID: 15399
			[Token(Token = "0x4003C27")]
			[FieldOffset(Offset = "0x30")]
			public PlayerRoguelikePendingEvent.InitRecruitSetContent initRecruitSet;

			// Token: 0x04003C28 RID: 15400
			[Token(Token = "0x4003C28")]
			[FieldOffset(Offset = "0x38")]
			public PlayerRoguelikePendingEvent.InitModeRelic initModeRelic;

			// Token: 0x04003C29 RID: 15401
			[Token(Token = "0x4003C29")]
			[FieldOffset(Offset = "0x40")]
			public PlayerRoguelikePendingEvent.InitTeam initTeam;

			// Token: 0x04003C2A RID: 15402
			[Token(Token = "0x4003C2A")]
			[FieldOffset(Offset = "0x48")]
			public PlayerRoguelikePendingEvent.InitSupport initSupport;

			// Token: 0x04003C2B RID: 15403
			[Token(Token = "0x4003C2B")]
			[FieldOffset(Offset = "0x50")]
			public PlayerRoguelikePendingEvent.InitExploreTool initExploreTool;

			// Token: 0x04003C2C RID: 15404
			[Token(Token = "0x4003C2C")]
			[FieldOffset(Offset = "0x58")]
			public PlayerRoguelikePendingEvent.BattleRewardContent battleReward;

			// Token: 0x04003C2D RID: 15405
			[Token(Token = "0x4003C2D")]
			[FieldOffset(Offset = "0x60")]
			public PlayerRoguelikePendingEvent.Recruit recruit;

			// Token: 0x04003C2E RID: 15406
			[Token(Token = "0x4003C2E")]
			[FieldOffset(Offset = "0x68")]
			public PlayerRoguelikePendingEvent.Dice dice;

			// Token: 0x04003C2F RID: 15407
			[Token(Token = "0x4003C2F")]
			[FieldOffset(Offset = "0x70")]
			public PlayerRoguelikePendingEvent.ShopContent shop;

			// Token: 0x04003C30 RID: 15408
			[Token(Token = "0x4003C30")]
			[FieldOffset(Offset = "0x78")]
			public PlayerRoguelikePendingEvent.EndingResult result;

			// Token: 0x04003C31 RID: 15409
			[Token(Token = "0x4003C31")]
			[FieldOffset(Offset = "0x80")]
			public PlayerRoguelikePendingEvent.ShopContent battleShop;

			// Token: 0x04003C32 RID: 15410
			[Token(Token = "0x4003C32")]
			[FieldOffset(Offset = "0x88")]
			public PlayerRoguelikePendingEvent.SacrificeContent sacrifice;

			// Token: 0x04003C33 RID: 15411
			[Token(Token = "0x4003C33")]
			[FieldOffset(Offset = "0x90")]
			public PlayerRoguelikePendingEvent.ExpeditionContent expedition;

			// Token: 0x04003C34 RID: 15412
			[Token(Token = "0x4003C34")]
			[FieldOffset(Offset = "0x98")]
			public string detailStr;

			// Token: 0x04003C35 RID: 15413
			[Token(Token = "0x4003C35")]
			[FieldOffset(Offset = "0xA0")]
			public bool popReport;

			// Token: 0x04003C36 RID: 15414
			[Token(Token = "0x4003C36")]
			[FieldOffset(Offset = "0xA8")]
			public PlayerRoguelikePendingEvent.AlchemyContent alchemy;

			// Token: 0x04003C37 RID: 15415
			[Token(Token = "0x4003C37")]
			[FieldOffset(Offset = "0xB0")]
			public PlayerRoguelikePendingEvent.AlchemyRewardContent alchemyReward;

			// Token: 0x04003C38 RID: 15416
			[Token(Token = "0x4003C38")]
			[FieldOffset(Offset = "0xB8")]
			public PlayerRoguelikePendingEvent.SwapCopper changeCopper;

			// Token: 0x04003C39 RID: 15417
			[Token(Token = "0x4003C39")]
			[FieldOffset(Offset = "0xC0")]
			public PlayerRoguelikePendingEvent.DrawCopper drawCopper;

			// Token: 0x04003C3A RID: 15418
			[Token(Token = "0x4003C3A")]
			[FieldOffset(Offset = "0xC8")]
			public PlayerRoguelikePendingEvent.UseStashedTicketContent useStashedTicket;

			// Token: 0x04003C3B RID: 15419
			[Token(Token = "0x4003C3B")]
			[FieldOffset(Offset = "0xD0")]
			public PlayerRoguelikePendingEvent.GildCopperContent gildCopper;

			// Token: 0x04003C3C RID: 15420
			[Token(Token = "0x4003C3C")]
			[FieldOffset(Offset = "0xD8")]
			public bool done;
		}
	}
}
