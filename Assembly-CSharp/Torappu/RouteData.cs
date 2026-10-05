using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x020010C0 RID: 4288
	[Token(Token = "0x20010C0")]
	[Serializable]
	public class RouteData
	{
		// Token: 0x06006E58 RID: 28248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E58")]
		[Address(RVA = "0x2114990", Offset = "0x2113590", VA = "0x182114990")]
		public RouteData Duplicate()
		{
			return null;
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E59")]
		[Address(RVA = "0x1401AE0", Offset = "0x14006E0", VA = "0x181401AE0")]
		public RouteData()
		{
		}

		// Token: 0x04005BB5 RID: 23477
		[Token(Token = "0x4005BB5")]
		[FieldOffset(Offset = "0x10")]
		public MotionMode motionMode;

		// Token: 0x04005BB6 RID: 23478
		[Token(Token = "0x4005BB6")]
		[FieldOffset(Offset = "0x14")]
		public GridPosition startPosition;

		// Token: 0x04005BB7 RID: 23479
		[Token(Token = "0x4005BB7")]
		[FieldOffset(Offset = "0x1C")]
		public GridPosition endPosition;

		// Token: 0x04005BB8 RID: 23480
		[Token(Token = "0x4005BB8")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 spawnRandomRange;

		// Token: 0x04005BB9 RID: 23481
		[Token(Token = "0x4005BB9")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 spawnOffset;

		// Token: 0x04005BBA RID: 23482
		[Token(Token = "0x4005BBA")]
		[FieldOffset(Offset = "0x38")]
		public RouteData.CheckpointData[] checkpoints;

		// Token: 0x04005BBB RID: 23483
		[Token(Token = "0x4005BBB")]
		[FieldOffset(Offset = "0x40")]
		public bool allowDiagonalMove;

		// Token: 0x04005BBC RID: 23484
		[Token(Token = "0x4005BBC")]
		[FieldOffset(Offset = "0x41")]
		public bool visitEveryTileCenter;

		// Token: 0x04005BBD RID: 23485
		[Token(Token = "0x4005BBD")]
		[FieldOffset(Offset = "0x42")]
		public bool visitEveryNodeCenter;

		// Token: 0x04005BBE RID: 23486
		[Token(Token = "0x4005BBE")]
		[FieldOffset(Offset = "0x43")]
		public bool visitEveryCheckPoint;

		// Token: 0x020010C1 RID: 4289
		[Token(Token = "0x20010C1")]
		[Serializable]
		public class CheckpointData
		{
			// Token: 0x06006E5A RID: 28250 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006E5A")]
			[Address(RVA = "0x2100180", Offset = "0x20FED80", VA = "0x182100180")]
			public RouteData.CheckpointData Duplicate()
			{
				return null;
			}

			// Token: 0x06006E5B RID: 28251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E5B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CheckpointData()
			{
			}

			// Token: 0x04005BBF RID: 23487
			[Token(Token = "0x4005BBF")]
			[FieldOffset(Offset = "0x10")]
			public CheckpointType type;

			// Token: 0x04005BC0 RID: 23488
			[Token(Token = "0x4005BC0")]
			[FieldOffset(Offset = "0x14")]
			public float time;

			// Token: 0x04005BC1 RID: 23489
			[Token(Token = "0x4005BC1")]
			[FieldOffset(Offset = "0x18")]
			public GridPosition position;

			// Token: 0x04005BC2 RID: 23490
			[Token(Token = "0x4005BC2")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 reachOffset;

			// Token: 0x04005BC3 RID: 23491
			[Token(Token = "0x4005BC3")]
			[FieldOffset(Offset = "0x28")]
			public bool randomizeReachOffset;

			// Token: 0x04005BC4 RID: 23492
			[Token(Token = "0x4005BC4")]
			[FieldOffset(Offset = "0x2C")]
			public float reachDistance;
		}
	}
}
