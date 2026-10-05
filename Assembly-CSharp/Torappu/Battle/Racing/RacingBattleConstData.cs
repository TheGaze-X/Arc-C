using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Racing
{
	// Token: 0x0200297E RID: 10622
	[Token(Token = "0x200297E")]
	public class RacingBattleConstData : SingletonInScene<RacingBattleConstData>, IDisposable
	{
		// Token: 0x0601190B RID: 71947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601190B")]
		[Address(RVA = "0x95B0D0", Offset = "0x959CD0", VA = "0x18095B0D0")]
		private RacingBattleConstData()
		{
		}

		// Token: 0x0601190C RID: 71948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601190C")]
		[Address(RVA = "0x95A5F0", Offset = "0x9591F0", VA = "0x18095A5F0")]
		public void InitData(RacingInput input)
		{
		}

		// Token: 0x0601190D RID: 71949 RVA: 0x0006BEB0 File Offset: 0x0006A0B0
		[Token(Token = "0x601190D")]
		[Address(RVA = "0x95A2F0", Offset = "0x958EF0", VA = "0x18095A2F0")]
		public int GetCollisionForceConfig(float collisionForce)
		{
			return 0;
		}

		// Token: 0x0601190E RID: 71950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601190E")]
		[Address(RVA = "0x95A420", Offset = "0x959020", VA = "0x18095A420")]
		public void GetCollisionResultConfig(int realForceIndex, bool hitTile, out FP speedLoss, out FP hpLoss)
		{
		}

		// Token: 0x0601190F RID: 71951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601190F")]
		[Address(RVA = "0x95A260", Offset = "0x958E60", VA = "0x18095A260", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04013A2B RID: 80427
		[Token(Token = "0x4013A2B")]
		public const string RACING_ENEMY_ITEM_1 = "racing_mode_item_1";

		// Token: 0x04013A2C RID: 80428
		[Token(Token = "0x4013A2C")]
		[FieldOffset(Offset = "0x18")]
		public FP RACING_HP_FACTOR;

		// Token: 0x04013A2D RID: 80429
		[Token(Token = "0x4013A2D")]
		[FieldOffset(Offset = "0x20")]
		public FP RACING_SPEED_FACTOR;

		// Token: 0x04013A2E RID: 80430
		[Token(Token = "0x4013A2E")]
		[FieldOffset(Offset = "0x28")]
		public FP RACING_ACCELERATION_FACTOR;

		// Token: 0x04013A2F RID: 80431
		[Token(Token = "0x4013A2F")]
		[FieldOffset(Offset = "0x30")]
		public FP RECOVER_MOVE_SPEED;

		// Token: 0x04013A30 RID: 80432
		[Token(Token = "0x4013A30")]
		[FieldOffset(Offset = "0x38")]
		public FP RECOVER_HP_FACTOR;

		// Token: 0x04013A31 RID: 80433
		[Token(Token = "0x4013A31")]
		[FieldOffset(Offset = "0x40")]
		public FP BLEEDING_FACTOR;

		// Token: 0x04013A32 RID: 80434
		[Token(Token = "0x4013A32")]
		[FieldOffset(Offset = "0x48")]
		public FP MAX_STEERING_FACTOR;

		// Token: 0x04013A33 RID: 80435
		[Token(Token = "0x4013A33")]
		[FieldOffset(Offset = "0x50")]
		public FP STEERING_MASS_LEVEL_FACTOR;

		// Token: 0x04013A34 RID: 80436
		[Token(Token = "0x4013A34")]
		[FieldOffset(Offset = "0x58")]
		public FP STEERING_MOVE_SPEED_FACTOR;

		// Token: 0x04013A35 RID: 80437
		[Token(Token = "0x4013A35")]
		[FieldOffset(Offset = "0x60")]
		public float COLLISION_SAFE_ANGLE_COS;

		// Token: 0x04013A36 RID: 80438
		[Token(Token = "0x4013A36")]
		[FieldOffset(Offset = "0x64")]
		public int COLLISION_SAFE_FORCE_LEVEL;

		// Token: 0x04013A37 RID: 80439
		[Token(Token = "0x4013A37")]
		[FieldOffset(Offset = "0x68")]
		public FP TILE_COLLISION_FACTOR;

		// Token: 0x04013A38 RID: 80440
		[Token(Token = "0x4013A38")]
		[FieldOffset(Offset = "0x70")]
		public FP AUTO_USE_ITEM_TIME_MIN;

		// Token: 0x04013A39 RID: 80441
		[Token(Token = "0x4013A39")]
		[FieldOffset(Offset = "0x78")]
		public FP AUTO_USE_ITEM_TIME_MAX;

		// Token: 0x04013A3A RID: 80442
		[Token(Token = "0x4013A3A")]
		[FieldOffset(Offset = "0x80")]
		public FP RECOVER_ACCELERATION;

		// Token: 0x04013A3B RID: 80443
		[Token(Token = "0x4013A3B")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, SandboxV2RacingItemInfo> racingItemInfos;

		// Token: 0x04013A3C RID: 80444
		[Token(Token = "0x4013A3C")]
		[FieldOffset(Offset = "0x90")]
		public List<RacingCollisionConfigData> collisionConfigDatas;

		// Token: 0x04013A3D RID: 80445
		[Token(Token = "0x4013A3D")]
		[FieldOffset(Offset = "0x98")]
		public List<RacingCollisionResultData> collisionResultDatas;

		// Token: 0x04013A3E RID: 80446
		[Token(Token = "0x4013A3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013A3F RID: 80447
		[Token(Token = "0x4013A3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04013A40 RID: 80448
		[Token(Token = "0x4013A40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCollisionForceConfig;

		// Token: 0x04013A41 RID: 80449
		[Token(Token = "0x4013A41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCollisionResultConfig;

		// Token: 0x04013A42 RID: 80450
		[Token(Token = "0x4013A42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
