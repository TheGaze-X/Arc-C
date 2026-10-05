using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Racing
{
	// Token: 0x02002982 RID: 10626
	[Token(Token = "0x2002982")]
	public static class RacingBattleUtil
	{
		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x06011922 RID: 71970 RVA: 0x0006BF10 File Offset: 0x0006A110
		[Token(Token = "0x170026C8")]
		public static FP RACING_HP_FACTOR
		{
			[Token(Token = "0x6011922")]
			[Address(RVA = "0x95D8F0", Offset = "0x95C4F0", VA = "0x18095D8F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x06011923 RID: 71971 RVA: 0x0006BF28 File Offset: 0x0006A128
		[Token(Token = "0x170026C9")]
		public static FP RACING_SPEED_FACTOR
		{
			[Token(Token = "0x6011923")]
			[Address(RVA = "0x95D930", Offset = "0x95C530", VA = "0x18095D930")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x06011924 RID: 71972 RVA: 0x0006BF40 File Offset: 0x0006A140
		[Token(Token = "0x170026CA")]
		public static FP RACING_ACCELERATION_FACTOR
		{
			[Token(Token = "0x6011924")]
			[Address(RVA = "0x95D8B0", Offset = "0x95C4B0", VA = "0x18095D8B0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x06011925 RID: 71973 RVA: 0x0006BF58 File Offset: 0x0006A158
		[Token(Token = "0x170026CB")]
		public static FP RECOVER_MOVE_SPEED
		{
			[Token(Token = "0x6011925")]
			[Address(RVA = "0x95DA00", Offset = "0x95C600", VA = "0x18095DA00")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x06011926 RID: 71974 RVA: 0x0006BF70 File Offset: 0x0006A170
		[Token(Token = "0x170026CC")]
		public static FP RECOVER_HP_FACTOR
		{
			[Token(Token = "0x6011926")]
			[Address(RVA = "0x95D9C0", Offset = "0x95C5C0", VA = "0x18095D9C0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x06011927 RID: 71975 RVA: 0x0006BF88 File Offset: 0x0006A188
		[Token(Token = "0x170026CD")]
		public static FP BLEEDING_FACTOR
		{
			[Token(Token = "0x6011927")]
			[Address(RVA = "0x95D670", Offset = "0x95C270", VA = "0x18095D670")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x06011928 RID: 71976 RVA: 0x0006BFA0 File Offset: 0x0006A1A0
		[Token(Token = "0x170026CE")]
		public static FP MAX_STEERING_FACTOR
		{
			[Token(Token = "0x6011928")]
			[Address(RVA = "0x95D870", Offset = "0x95C470", VA = "0x18095D870")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x06011929 RID: 71977 RVA: 0x0006BFB8 File Offset: 0x0006A1B8
		[Token(Token = "0x170026CF")]
		public static FP STEERING_MASS_LEVEL_FACTOR
		{
			[Token(Token = "0x6011929")]
			[Address(RVA = "0x95DA40", Offset = "0x95C640", VA = "0x18095DA40")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x0601192A RID: 71978 RVA: 0x0006BFD0 File Offset: 0x0006A1D0
		[Token(Token = "0x170026D0")]
		public static FP STEERING_MOVE_SPEED_FACTOR
		{
			[Token(Token = "0x601192A")]
			[Address(RVA = "0x95DA80", Offset = "0x95C680", VA = "0x18095DA80")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x0601192B RID: 71979 RVA: 0x0006BFE8 File Offset: 0x0006A1E8
		[Token(Token = "0x170026D1")]
		public static float COLLISION_SAFE_ANGLE_COS
		{
			[Token(Token = "0x601192B")]
			[Address(RVA = "0x95D6B0", Offset = "0x95C2B0", VA = "0x18095D6B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x0601192C RID: 71980 RVA: 0x0006C000 File Offset: 0x0006A200
		[Token(Token = "0x170026D2")]
		public static int COLLISION_SAFE_FORCE_LEVEL
		{
			[Token(Token = "0x601192C")]
			[Address(RVA = "0x95D700", Offset = "0x95C300", VA = "0x18095D700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x0601192D RID: 71981 RVA: 0x0006C018 File Offset: 0x0006A218
		[Token(Token = "0x170026D3")]
		public static FP TILE_COLLISION_FACTOR
		{
			[Token(Token = "0x601192D")]
			[Address(RVA = "0x95DAC0", Offset = "0x95C6C0", VA = "0x18095DAC0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0601192E RID: 71982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026D4")]
		public static Dictionary<string, SandboxV2RacingItemInfo> racingItemInfos
		{
			[Token(Token = "0x601192E")]
			[Address(RVA = "0x95DB00", Offset = "0x95C700", VA = "0x18095DB00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x0601192F RID: 71983 RVA: 0x0006C030 File Offset: 0x0006A230
		[Token(Token = "0x170026D5")]
		public static FP AUTO_USE_ITEM_TIME_MIN
		{
			[Token(Token = "0x601192F")]
			[Address(RVA = "0x95D630", Offset = "0x95C230", VA = "0x18095D630")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x06011930 RID: 71984 RVA: 0x0006C048 File Offset: 0x0006A248
		[Token(Token = "0x170026D6")]
		public static FP AUTO_USE_ITEM_TIME_MAX
		{
			[Token(Token = "0x6011930")]
			[Address(RVA = "0x95D5F0", Offset = "0x95C1F0", VA = "0x18095D5F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x06011931 RID: 71985 RVA: 0x0006C060 File Offset: 0x0006A260
		[Token(Token = "0x170026D7")]
		public static FP RECOVER_ACCELERATION
		{
			[Token(Token = "0x6011931")]
			[Address(RVA = "0x95D970", Offset = "0x95C570", VA = "0x18095D970")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x06011932 RID: 71986 RVA: 0x0006C078 File Offset: 0x0006A278
		[Token(Token = "0x170026D8")]
		public static bool IsRacingMode
		{
			[Token(Token = "0x6011932")]
			[Address(RVA = "0x95D740", Offset = "0x95C340", VA = "0x18095D740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011933 RID: 71987 RVA: 0x0006C090 File Offset: 0x0006A290
		[Token(Token = "0x6011933")]
		[Address(RVA = "0x95D010", Offset = "0x95BC10", VA = "0x18095D010")]
		public static FP ConvertToRealMoveSpeed(FP racingSpeed)
		{
			return default(FP);
		}

		// Token: 0x06011934 RID: 71988 RVA: 0x0006C0A8 File Offset: 0x0006A2A8
		[Token(Token = "0x6011934")]
		[Address(RVA = "0x95D090", Offset = "0x95BC90", VA = "0x18095D090")]
		public static FP InvertToRacingMoveSpeed(FP moveSpeed)
		{
			return default(FP);
		}

		// Token: 0x06011935 RID: 71989 RVA: 0x0006C0C0 File Offset: 0x0006A2C0
		[Token(Token = "0x6011935")]
		[Address(RVA = "0x95CF40", Offset = "0x95BB40", VA = "0x18095CF40")]
		public static FP ConvertToRealHp(FP racingHp)
		{
			return default(FP);
		}

		// Token: 0x06011936 RID: 71990 RVA: 0x0006C0D8 File Offset: 0x0006A2D8
		[Token(Token = "0x6011936")]
		[Address(RVA = "0x95CEB0", Offset = "0x95BAB0", VA = "0x18095CEB0")]
		public static bool CanRacingEnemyNpcUseItem(RacingEnemy racingEnemy)
		{
			return default(bool);
		}

		// Token: 0x06011937 RID: 71991 RVA: 0x0006C0F0 File Offset: 0x0006A2F0
		[Token(Token = "0x6011937")]
		[Address(RVA = "0x95C1B0", Offset = "0x95ADB0", VA = "0x18095C1B0")]
		public static FP CalculateBleedingPerSec(RacingEnemy enemy)
		{
			return default(FP);
		}

		// Token: 0x06011938 RID: 71992 RVA: 0x0006C108 File Offset: 0x0006A308
		[Token(Token = "0x6011938")]
		[Address(RVA = "0x95CDE0", Offset = "0x95B9E0", VA = "0x18095CDE0")]
		public static FP CalculateRecoverPerSec(RacingEnemy enemy)
		{
			return default(FP);
		}

		// Token: 0x06011939 RID: 71993 RVA: 0x0006C120 File Offset: 0x0006A320
		[Token(Token = "0x6011939")]
		[Address(RVA = "0x95CBE0", Offset = "0x95B7E0", VA = "0x18095CBE0")]
		public static float CalculateRacingSteeringFactor(RacingEnemy enemy)
		{
			return 0f;
		}

		// Token: 0x0601193A RID: 71994 RVA: 0x0006C138 File Offset: 0x0006A338
		[Token(Token = "0x601193A")]
		[Address(RVA = "0x95C7A0", Offset = "0x95B3A0", VA = "0x18095C7A0")]
		public static Vector2 CalculateCollisionForce(RacingEnemy.RacingCollisionContext context)
		{
			return default(Vector2);
		}

		// Token: 0x0601193B RID: 71995 RVA: 0x0006C150 File Offset: 0x0006A350
		[Token(Token = "0x601193B")]
		[Address(RVA = "0x95C2E0", Offset = "0x95AEE0", VA = "0x18095C2E0")]
		public static Vector2 CalculateCollisionForceWithTile(RacingEnemy.RacingCollisionContext context)
		{
			return default(Vector2);
		}

		// Token: 0x0601193C RID: 71996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601193C")]
		[Address(RVA = "0x95D110", Offset = "0x95BD10", VA = "0x18095D110")]
		private static void _CalculateCollisionResult(FP collisionForce, int selfMass, int maxForceLevel, bool hitTile, out float force, out FP moveSpeedLoss, out FP hpLoss)
		{
		}

		// Token: 0x04013A59 RID: 80473
		[Token(Token = "0x4013A59")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color RACING_HP_COLOR;

		// Token: 0x04013A5A RID: 80474
		[Token(Token = "0x4013A5A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Color RECOVER_HP_COLOR;

		// Token: 0x04013A5B RID: 80475
		[Token(Token = "0x4013A5B")]
		public const string RACING_UI_PLUGIN_PATH = "UI/SandboxV2/[UC]Common/Battle/sandbox_racing_battle_ui_plugin.prefab";

		// Token: 0x04013A5C RID: 80476
		[Token(Token = "0x4013A5C")]
		public const string RACING_CAMERA_PLUGIN_PATH = "UI/SandboxV2/[UC]Common/Battle/sandbox_racing_camera_plugin.prefab";

		// Token: 0x04013A5D RID: 80477
		[Token(Token = "0x4013A5D")]
		public const string RACING_KEY_MAGNET_MOVE_SPEED = "racing_magnet_move_speed";

		// Token: 0x04013A5E RID: 80478
		[Token(Token = "0x4013A5E")]
		public const string RACING_FORCE_LEVEL_ADD = "racing_force_level_add";

		// Token: 0x04013A5F RID: 80479
		[Token(Token = "0x4013A5F")]
		public const string RACING_SPEED_LOSS_SCALER = "racing_speed_loss_scaler";

		// Token: 0x04013A60 RID: 80480
		[Token(Token = "0x4013A60")]
		public const string RACING_USE_ITEM_BUFF_KEY = "racing_mode_use_item";

		// Token: 0x04013A61 RID: 80481
		[Token(Token = "0x4013A61")]
		public const float RANKING_TICK_INTERVAL = 0.3f;

		// Token: 0x04013A62 RID: 80482
		[Token(Token = "0x4013A62")]
		public const int FINISH_GAME_COUNTDOWN = 20;

		// Token: 0x04013A63 RID: 80483
		[Token(Token = "0x4013A63")]
		public const int FINISH_GAME_COUNTDOWN_INTERVAL = 1;

		// Token: 0x04013A64 RID: 80484
		[Token(Token = "0x4013A64")]
		public const float COLLISION_PARALLEL_DOT_THRESHOLD = 0.5f;

		// Token: 0x04013A65 RID: 80485
		[Token(Token = "0x4013A65")]
		public const float MIN_STEERING_FACTOR = 0.3f;

		// Token: 0x04013A66 RID: 80486
		[Token(Token = "0x4013A66")]
		public const float RACING_ATTRIBUTE_FACTOR = 100f;
	}
}
