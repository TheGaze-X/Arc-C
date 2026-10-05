using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x02000247 RID: 583
	[Token(Token = "0x2000247")]
	public class EasyTouchInput
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x3204980", Offset = "0x3203580", VA = "0x183204980")]
		public int TouchCount()
		{
			return 0;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x3204A80", Offset = "0x3203680", VA = "0x183204A80")]
		private int getTouchCount(bool realTouch)
		{
			return 0;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x3203E00", Offset = "0x3202A00", VA = "0x183203E00")]
		public Finger GetMouseTouch(int fingerIndex, Finger myFinger)
		{
			return null;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x3204660", Offset = "0x3203260", VA = "0x183204660")]
		public Vector2 GetSecondFingerPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x3204620", Offset = "0x3203220", VA = "0x183204620")]
		private Vector2 GetPointerPosition(int index)
		{
			return default(Vector2);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x3204490", Offset = "0x3203090", VA = "0x183204490")]
		private Vector2 GetPinchTwist2Finger(bool newSim = false)
		{
			return default(Vector2);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x3203D40", Offset = "0x3202940", VA = "0x183203D40")]
		private Vector2 GetComplex2finger()
		{
			return default(Vector2);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x3204990", Offset = "0x3203590", VA = "0x183204990")]
		public EasyTouchInput()
		{
		}

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x10")]
		private Vector2[] oldMousePosition;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x18")]
		private int[] tapCount;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x20")]
		private float[] startActionTime;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x28")]
		private float[] deltaTime;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x30")]
		private float[] tapeTime;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x38")]
		private bool bComplex;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 deltaFingerPosition;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 oldFinger2Position;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 complexCenter;
	}
}
