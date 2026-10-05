using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class GeometryUtils
	{
		// Token: 0x06005C88 RID: 23688 RVA: 0x0002F418 File Offset: 0x0002D618
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0x1CF6A80", Offset = "0x1CF5680", VA = "0x181CF6A80")]
		public static bool IntersectWithRect(Vector2 p1, Vector2 p2, Rect bound, out Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x0002F430 File Offset: 0x0002D630
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x1CF7590", Offset = "0x1CF6190", VA = "0x181CF7590")]
		private static bool _IsWithinLineSegment(Vector2 p1, Vector2 p2, Vector2 q)
		{
			return default(bool);
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x0002F448 File Offset: 0x0002D648
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x1CF7040", Offset = "0x1CF5C40", VA = "0x181CF7040")]
		public static bool IsPointInBounds(Vector2 point, Rect bounds)
		{
			return default(bool);
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x0002F460 File Offset: 0x0002D660
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0x1CF7120", Offset = "0x1CF5D20", VA = "0x181CF7120")]
		public static GeometryUtils.PolarLineInfo LineTo(Vector2 start, Vector2 end)
		{
			return default(GeometryUtils.PolarLineInfo);
		}

		// Token: 0x06005C8C RID: 23692 RVA: 0x0002F478 File Offset: 0x0002D678
		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0x1CF7410", Offset = "0x1CF6010", VA = "0x181CF7410")]
		public static Vector2 ScaleWithRatio(Vector2 input, Vector2 standard, Vector2 current)
		{
			return default(Vector2);
		}

		// Token: 0x04002252 RID: 8786
		[Token(Token = "0x4002252")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IntersectWithRect;

		// Token: 0x04002253 RID: 8787
		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsWithinLineSegment;

		// Token: 0x04002254 RID: 8788
		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsPointInBounds;

		// Token: 0x04002255 RID: 8789
		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LineTo;

		// Token: 0x04002256 RID: 8790
		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ScaleWithRatio;

		// Token: 0x0200059E RID: 1438
		[Token(Token = "0x200059E")]
		public struct PolarLineInfo
		{
			// Token: 0x04002257 RID: 8791
			[Token(Token = "0x4002257")]
			[FieldOffset(Offset = "0x0")]
			public float magnitude;

			// Token: 0x04002258 RID: 8792
			[Token(Token = "0x4002258")]
			[FieldOffset(Offset = "0x4")]
			public Quaternion rotation;
		}
	}
}
