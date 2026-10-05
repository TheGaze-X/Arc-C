using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.GameCity
{
	// Token: 0x0200267D RID: 9853
	[Token(Token = "0x200267D")]
	public class GameCityModeBattleData : IHotfixable
	{
		// Token: 0x0601019A RID: 65946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601019A")]
		[Address(RVA = "0x7C61E0", Offset = "0x7C4DE0", VA = "0x1807C61E0")]
		public GameCityModeBattleData()
		{
		}

		// Token: 0x04011EC2 RID: 73410
		[Token(Token = "0x4011EC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200267E RID: 9854
		[Token(Token = "0x200267E")]
		public enum UIScoreType
		{
			// Token: 0x04011EC4 RID: 73412
			[Token(Token = "0x4011EC4")]
			NORMAL,
			// Token: 0x04011EC5 RID: 73413
			[Token(Token = "0x4011EC5")]
			STEAL,
			// Token: 0x04011EC6 RID: 73414
			[Token(Token = "0x4011EC6")]
			NONE
		}

		// Token: 0x0200267F RID: 9855
		[Token(Token = "0x200267F")]
		public class GameCityInput : IHotfixable
		{
			// Token: 0x0601019B RID: 65947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601019B")]
			[Address(RVA = "0x7C6180", Offset = "0x7C4D80", VA = "0x1807C6180")]
			public GameCityInput()
			{
			}

			// Token: 0x04011EC7 RID: 73415
			[Token(Token = "0x4011EC7")]
			[FieldOffset(Offset = "0x10")]
			public ActArcadeData.SubModeType subModeType;

			// Token: 0x04011EC8 RID: 73416
			[Token(Token = "0x4011EC8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002680 RID: 9856
		[Token(Token = "0x2002680")]
		[Serializable]
		public class GameCityArcgachaObjectData : IItemWithWeight
		{
			// Token: 0x1700231A RID: 8986
			// (get) Token: 0x0601019C RID: 65948 RVA: 0x00062418 File Offset: 0x00060618
			[Token(Token = "0x1700231A")]
			public float weightValue
			{
				[Token(Token = "0x601019C")]
				[Address(RVA = "0x7C6170", Offset = "0x7C4D70", VA = "0x1807C6170", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0601019D RID: 65949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601019D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GameCityArcgachaObjectData()
			{
			}

			// Token: 0x04011EC9 RID: 73417
			[Token(Token = "0x4011EC9")]
			[FieldOffset(Offset = "0x10")]
			public string tokenKey;

			// Token: 0x04011ECA RID: 73418
			[Token(Token = "0x4011ECA")]
			[FieldOffset(Offset = "0x18")]
			public int maxCnt;

			// Token: 0x04011ECB RID: 73419
			[Token(Token = "0x4011ECB")]
			[FieldOffset(Offset = "0x1C")]
			public int weight;
		}

		// Token: 0x02002681 RID: 9857
		[Token(Token = "0x2002681")]
		[Hotfix(HotfixFlag.Stateless)]
		public static class GameCityModeConsts
		{
			// Token: 0x04011ECC RID: 73420
			[Token(Token = "0x4011ECC")]
			public const string UI_SCORE_PLUGIN_ENV = "env_021_act1arcade_score";

			// Token: 0x04011ECD RID: 73421
			[Token(Token = "0x4011ECD")]
			public const string UI_SCORE_BUFF = "gamecity_score";

			// Token: 0x04011ECE RID: 73422
			[Token(Token = "0x4011ECE")]
			public const string UI_SCORE_BUFF_MINER = "gamecity_score_miner";

			// Token: 0x04011ECF RID: 73423
			[Token(Token = "0x4011ECF")]
			public const string WAVE_DURATION_KEY = "wave_time";

			// Token: 0x04011ED0 RID: 73424
			[Token(Token = "0x4011ED0")]
			public const string REST_DURATION_KEY = "rest_time";

			// Token: 0x04011ED1 RID: 73425
			[Token(Token = "0x4011ED1")]
			public const string TILE_START_EFFECT_REPLACE_KEY = "tile_grey";

			// Token: 0x04011ED2 RID: 73426
			[Token(Token = "0x4011ED2")]
			public const string ARCGACHA_OBJECT_ON_START_KEY = "trap_start";

			// Token: 0x04011ED3 RID: 73427
			[Token(Token = "0x4011ED3")]
			public const string HEAD_HUD_RAINBOW_SCORE = "rainbow_score";

			// Token: 0x04011ED4 RID: 73428
			[Token(Token = "0x4011ED4")]
			public const string BATTLE_LOG_SCORE_KEY = "gamecity_score";

			// Token: 0x04011ED5 RID: 73429
			[Token(Token = "0x4011ED5")]
			public const string BATTLE_LOG_SCORE_CHECK_TILE_KEY = "tile_score";

			// Token: 0x04011ED6 RID: 73430
			[Token(Token = "0x4011ED6")]
			public const string BATTLE_LOG_SCORE_CHECK_UNIT_FORMAT = "UNIT_SCORE.{0}";

			// Token: 0x04011ED7 RID: 73431
			[Token(Token = "0x4011ED7")]
			public const string UI_SCORE_BUFF_FALL = "gamecity_getScore_fall";

			// Token: 0x04011ED8 RID: 73432
			[Token(Token = "0x4011ED8")]
			public const int SCORE_SCALE = 1000;

			// Token: 0x04011ED9 RID: 73433
			[Token(Token = "0x4011ED9")]
			public const float ROUTE_SHOWN_INTERVAL = 1.2f;

			// Token: 0x04011EDA RID: 73434
			[Token(Token = "0x4011EDA")]
			public const int MAX_SCORE = 9999999;

			// Token: 0x04011EDB RID: 73435
			[Token(Token = "0x4011EDB")]
			public const int MAX_SINGLE_SCORE = 999999;

			// Token: 0x04011EDC RID: 73436
			[Token(Token = "0x4011EDC")]
			public const string ARCSUM_ENEMY_EFFECT = "trap_arcsum1_enemy_birth_01";
		}
	}
}
