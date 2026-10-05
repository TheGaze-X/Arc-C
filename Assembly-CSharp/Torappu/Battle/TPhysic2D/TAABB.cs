using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.TPhysic2D
{
	// Token: 0x02002697 RID: 9879
	[Token(Token = "0x2002697")]
	public struct TAABB
	{
		// Token: 0x0601022D RID: 66093 RVA: 0x00062610 File Offset: 0x00060810
		[Token(Token = "0x601022D")]
		[Address(RVA = "0x7EF5D0", Offset = "0x7EE1D0", VA = "0x1807EF5D0")]
		public static TAABB GetSquareAABB(Vector2 center, float size)
		{
			return default(TAABB);
		}

		// Token: 0x0601022E RID: 66094 RVA: 0x00062628 File Offset: 0x00060828
		[Token(Token = "0x601022E")]
		[Address(RVA = "0x7EF580", Offset = "0x7EE180", VA = "0x1807EF580")]
		public Vector2 GetCenter()
		{
			return default(Vector2);
		}

		// Token: 0x0601022F RID: 66095 RVA: 0x00062640 File Offset: 0x00060840
		[Token(Token = "0x601022F")]
		[Address(RVA = "0x7EF5B0", Offset = "0x7EE1B0", VA = "0x1807EF5B0")]
		public float GetPerimeter()
		{
			return 0f;
		}

		// Token: 0x06010230 RID: 66096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010230")]
		[Address(RVA = "0x7EF460", Offset = "0x7EE060", VA = "0x1807EF460")]
		public void Combine(ref TAABB aabb)
		{
		}

		// Token: 0x06010231 RID: 66097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010231")]
		[Address(RVA = "0x7EF380", Offset = "0x7EDF80", VA = "0x1807EF380")]
		public void Combine(ref TAABB aabb1, ref TAABB aabT)
		{
		}

		// Token: 0x06010232 RID: 66098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010232")]
		[Address(RVA = "0x7EF620", Offset = "0x7EE220", VA = "0x1807EF620")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06010233 RID: 66099 RVA: 0x00062658 File Offset: 0x00060858
		[Token(Token = "0x6010233")]
		[Address(RVA = "0x7EF530", Offset = "0x7EE130", VA = "0x1807EF530")]
		public bool Contains(ref TAABB aabb)
		{
			return default(bool);
		}

		// Token: 0x04011FC6 RID: 73670
		[Token(Token = "0x4011FC6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TAABB DEFAULT;

		// Token: 0x04011FC7 RID: 73671
		[Token(Token = "0x4011FC7")]
		[FieldOffset(Offset = "0x10")]
		public static readonly TAABB CHAR_COMMON_AABB;

		// Token: 0x04011FC8 RID: 73672
		[Token(Token = "0x4011FC8")]
		[FieldOffset(Offset = "0x20")]
		public static readonly TAABB ENEMY_COMMON_AABB;

		// Token: 0x04011FC9 RID: 73673
		[Token(Token = "0x4011FC9")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 lowerBound;

		// Token: 0x04011FCA RID: 73674
		[Token(Token = "0x4011FCA")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 upperBound;
	}
}
