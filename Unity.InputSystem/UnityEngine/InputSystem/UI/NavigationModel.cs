using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	internal struct NavigationModel
	{
		// Token: 0x06000D55 RID: 3413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x56C5D00", Offset = "0x56C4900", VA = "0x1856C5D00")]
		public void Reset()
		{
		}

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 move;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x8")]
		public int consecutiveMoveCount;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0xC")]
		public MoveDirection lastMoveDirection;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x10")]
		public float lastMoveTime;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x18")]
		public AxisEventData eventData;
	}
}
