using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	public class Gesture : BaseFinger, ICloneable
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x3204D50", Offset = "0x3203950", VA = "0x183204D50")]
		public Vector3 GetTouchToWorldPoint(float z)
		{
			return default(Vector3);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x3204C40", Offset = "0x3203840", VA = "0x183204C40")]
		public Vector3 GetTouchToWorldPoint(Vector3 position3D)
		{
			return default(Vector3);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x3204BF0", Offset = "0x32037F0", VA = "0x183204BF0")]
		public float GetSwipeOrDragAngle()
		{
			return 0f;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x3204EC0", Offset = "0x3203AC0", VA = "0x183204EC0")]
		public Vector2 NormalizedPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x3204EB0", Offset = "0x3203AB0", VA = "0x183204EB0")]
		public bool IsOverUIElement()
		{
			return default(bool);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x3204DE0", Offset = "0x32039E0", VA = "0x183204DE0")]
		public bool IsOverRectTransform(RectTransform tr, [Optional] Camera camera)
		{
			return default(bool);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x3204BD0", Offset = "0x32037D0", VA = "0x183204BD0")]
		public GameObject GetCurrentFirstPickedUIElement(bool isTwoFinger = false)
		{
			return null;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x3204BE0", Offset = "0x32037E0", VA = "0x183204BE0")]
		public GameObject GetCurrentPickedObject(bool isTwoFinger = false)
		{
			return null;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Gesture()
		{
		}

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public EasyTouch.SwipeDirection swipe;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float swipeLength;

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector2 swipeVector;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float deltaPinch;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float twistAngle;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float twoFingerDistance;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public EasyTouch.EvtType type;
	}
}
