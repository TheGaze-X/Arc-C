using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A11 RID: 14865
	[Token(Token = "0x2003A11")]
	public struct Hexagon : IHotfixable
	{
		// Token: 0x0601775F RID: 96095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601775F")]
		[Address(RVA = "0xFC8430", Offset = "0xFC7030", VA = "0x180FC8430")]
		public Hexagon(HexPoint center, int size)
		{
		}

		// Token: 0x06017760 RID: 96096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017760")]
		[Address(RVA = "0xFC8310", Offset = "0xFC6F10", VA = "0x180FC8310")]
		public Hexagon(int u, int v, int size)
		{
		}

		// Token: 0x06017761 RID: 96097 RVA: 0x000969D8 File Offset: 0x00094BD8
		[Token(Token = "0x6017761")]
		[Address(RVA = "0xFC7C20", Offset = "0xFC6820", VA = "0x180FC7C20")]
		public bool IsPointIn(Vector2 hexCoord)
		{
			return default(bool);
		}

		// Token: 0x06017762 RID: 96098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017762")]
		[Address(RVA = "0xFC7D90", Offset = "0xFC6990", VA = "0x180FC7D90")]
		public void PopulateVertices(ref List<Vector2> vertices, float unit)
		{
		}

		// Token: 0x06017763 RID: 96099 RVA: 0x000969F0 File Offset: 0x00094BF0
		[Token(Token = "0x6017763")]
		[Address(RVA = "0xFC7A60", Offset = "0xFC6660", VA = "0x180FC7A60")]
		public static bool CheckIfHexOverlap(Hexagon lhs, Hexagon rhs)
		{
			return default(bool);
		}

		// Token: 0x06017764 RID: 96100 RVA: 0x00096A08 File Offset: 0x00094C08
		[Token(Token = "0x6017764")]
		[Address(RVA = "0xFC7850", Offset = "0xFC6450", VA = "0x180FC7850")]
		public static Hexagon.BoundCheck CheckIfHexInBound(Hexagon hex, List<HexPoint> bound)
		{
			return default(Hexagon.BoundCheck);
		}

		// Token: 0x0401C568 RID: 116072
		[Token(Token = "0x401C568")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HexPoint[] UNIT_HEX_POINTS;

		// Token: 0x0401C569 RID: 116073
		[Token(Token = "0x401C569")]
		[FieldOffset(Offset = "0x0")]
		public HexPoint center;

		// Token: 0x0401C56A RID: 116074
		[Token(Token = "0x401C56A")]
		[FieldOffset(Offset = "0x8")]
		public int size;

		// Token: 0x0401C56B RID: 116075
		[Token(Token = "0x401C56B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C56C RID: 116076
		[Token(Token = "0x401C56C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x0401C56D RID: 116077
		[Token(Token = "0x401C56D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsPointIn;

		// Token: 0x0401C56E RID: 116078
		[Token(Token = "0x401C56E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PopulateVertices;

		// Token: 0x0401C56F RID: 116079
		[Token(Token = "0x401C56F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfHexOverlap;

		// Token: 0x0401C570 RID: 116080
		[Token(Token = "0x401C570")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIfHexInBound;

		// Token: 0x02003A12 RID: 14866
		[Token(Token = "0x2003A12")]
		public struct BoundCheck
		{
			// Token: 0x0401C571 RID: 116081
			[Token(Token = "0x401C571")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Hexagon.BoundCheck EMPTY;

			// Token: 0x0401C572 RID: 116082
			[Token(Token = "0x401C572")]
			[FieldOffset(Offset = "0x0")]
			public bool allInBound;

			// Token: 0x0401C573 RID: 116083
			[Token(Token = "0x401C573")]
			[FieldOffset(Offset = "0x1")]
			public bool allOutBound;

			// Token: 0x0401C574 RID: 116084
			[Token(Token = "0x401C574")]
			[FieldOffset(Offset = "0x4")]
			public int outOfBoundVertices;
		}
	}
}
