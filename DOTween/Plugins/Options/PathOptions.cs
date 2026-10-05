using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public struct PathOptions : IPlugOptions
	{
		// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x374B480", Offset = "0x374A080", VA = "0x18374B480", Slot = "4")]
		public void Reset()
		{
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x0")]
		public PathMode mode;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x4")]
		public OrientType orientType;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x8")]
		public AxisConstraint lockPositionAxis;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0xC")]
		public AxisConstraint lockRotationAxis;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x10")]
		public bool isClosedPath;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 lookAtPosition;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x20")]
		public Transform lookAtTransform;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x28")]
		public float lookAhead;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x2C")]
		public bool hasCustomForwardDirection;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion forward;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x40")]
		public bool useLocalPosition;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x48")]
		public Transform parent;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x50")]
		public bool isRigidbody;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x51")]
		public bool isRigidbody2D;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x52")]
		public bool stableZRotation;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x54")]
		internal Quaternion startupRot;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x64")]
		internal float startupZRot;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x68")]
		internal bool addedExtraStartWp;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x69")]
		internal bool addedExtraEndWp;
	}
}
