using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	public class BaseFinger
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x251CE00", Offset = "0x251BA00", VA = "0x18251CE00")]
		public Gesture GetGesture()
		{
			return null;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BaseFinger()
		{
		}

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x10")]
		public int fingerIndex;

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x14")]
		public int touchCount;

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 startPosition;

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 position;

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 deltaPosition;

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x30")]
		public float actionTime;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x34")]
		public float deltaTime;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0x38")]
		public Camera pickedCamera;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject pickedObject;

		// Token: 0x04000B70 RID: 2928
		[Token(Token = "0x4000B70")]
		[FieldOffset(Offset = "0x48")]
		public bool isGuiCamera;

		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0x49")]
		public bool isOverGui;

		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x50")]
		public GameObject pickedUIElement;

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x58")]
		public float altitudeAngle;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x5C")]
		public float azimuthAngle;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x60")]
		public float maximumPossiblePressure;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x64")]
		public float pressure;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x68")]
		public float radius;

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x6C")]
		public float radiusVariance;

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x70")]
		public TouchType touchType;
	}
}
