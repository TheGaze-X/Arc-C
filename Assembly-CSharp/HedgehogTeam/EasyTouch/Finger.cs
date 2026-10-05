using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	public class Finger : BaseFinger
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Finger()
		{
		}

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x78")]
		public float startTimeAction;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x7C")]
		public Vector2 oldPosition;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x84")]
		public int tapCount;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x88")]
		public TouchPhase phase;

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x8C")]
		public EasyTouch.GestureType gesture;

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x90")]
		public EasyTouch.SwipeDirection oldSwipeType;
	}
}
