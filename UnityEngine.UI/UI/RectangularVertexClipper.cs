using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	internal class RectangularVertexClipper
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5A22A10", Offset = "0x5A21610", VA = "0x185A22A10")]
		public Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			return default(Rect);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5A22C30", Offset = "0x5A21830", VA = "0x185A22C30")]
		public RectangularVertexClipper()
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		private readonly Vector3[] m_WorldCorners;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		private readonly Vector3[] m_CanvasCorners;
	}
}
