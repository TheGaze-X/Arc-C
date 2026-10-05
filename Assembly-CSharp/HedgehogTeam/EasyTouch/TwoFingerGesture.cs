using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	public class TwoFingerGesture
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x3215100", Offset = "0x3213D00", VA = "0x183215100")]
		public void ClearPickedObjectData()
		{
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x3215150", Offset = "0x3213D50", VA = "0x183215150")]
		public void ClearPickedUIData()
		{
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x3215170", Offset = "0x3213D70", VA = "0x183215170")]
		public TwoFingerGesture()
		{
		}

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x10")]
		public EasyTouch.GestureType currentGesture;

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x14")]
		public EasyTouch.GestureType oldGesture;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x18")]
		public int finger0;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x1C")]
		public int finger1;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x20")]
		public float startTimeAction;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x24")]
		public float timeSinceStartAction;

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 startPosition;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 position;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 deltaPosition;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 oldStartPosition;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x48")]
		public float startDistance;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x4C")]
		public float fingerDistance;

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x50")]
		public float oldFingerDistance;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x54")]
		public bool lockPinch;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x55")]
		public bool lockTwist;

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x58")]
		public float lastPinch;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x5C")]
		public float lastTwistAngle;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x60")]
		public GameObject pickedObject;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x68")]
		public GameObject oldPickedObject;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x70")]
		public Camera pickedCamera;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x78")]
		public bool isGuiCamera;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x79")]
		public bool isOverGui;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x80")]
		public GameObject pickedUIElement;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x88")]
		public bool dragStart;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x89")]
		public bool swipeStart;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x8A")]
		public bool inSingleDoubleTaps;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x8C")]
		public float tapCurentTime;
	}
}
