using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A0F RID: 14863
	[Token(Token = "0x2003A0F")]
	[Serializable]
	public struct HexPoint : IHotfixable
	{
		// Token: 0x0601774C RID: 96076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601774C")]
		[Address(RVA = "0xFC7000", Offset = "0xFC5C00", VA = "0x180FC7000")]
		public HexPoint(int u, int v)
		{
		}

		// Token: 0x0601774D RID: 96077 RVA: 0x00096840 File Offset: 0x00094A40
		[Token(Token = "0x601774D")]
		[Address(RVA = "0xFC6B10", Offset = "0xFC5710", VA = "0x180FC6B10")]
		public Vector2 ToCrossCoord()
		{
			return default(Vector2);
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0601774E RID: 96078 RVA: 0x00096858 File Offset: 0x00094A58
		[Token(Token = "0x17003832")]
		public static HexPoint zero
		{
			[Token(Token = "0x601774E")]
			[Address(RVA = "0xFC7080", Offset = "0xFC5C80", VA = "0x180FC7080")]
			get
			{
				return default(HexPoint);
			}
		}

		// Token: 0x0601774F RID: 96079 RVA: 0x00096870 File Offset: 0x00094A70
		[Token(Token = "0x601774F")]
		[Address(RVA = "0xFC6CA0", Offset = "0xFC58A0", VA = "0x180FC6CA0")]
		public static Vector2 ToHexCoord(Vector2 crossPoint)
		{
			return default(Vector2);
		}

		// Token: 0x06017750 RID: 96080 RVA: 0x00096888 File Offset: 0x00094A88
		[Token(Token = "0x6017750")]
		[Address(RVA = "0xFC6B80", Offset = "0xFC5780", VA = "0x180FC6B80")]
		public static Vector2 ToCrossCoord(Vector2 hexPoint)
		{
			return default(Vector2);
		}

		// Token: 0x06017751 RID: 96081 RVA: 0x000968A0 File Offset: 0x00094AA0
		[Token(Token = "0x6017751")]
		[Address(RVA = "0xFC7120", Offset = "0xFC5D20", VA = "0x180FC7120")]
		public static HexPoint operator +(HexPoint left, HexPoint right)
		{
			return default(HexPoint);
		}

		// Token: 0x06017752 RID: 96082 RVA: 0x000968B8 File Offset: 0x00094AB8
		[Token(Token = "0x6017752")]
		[Address(RVA = "0xFC74D0", Offset = "0xFC60D0", VA = "0x180FC74D0")]
		public static HexPoint operator -(HexPoint left, HexPoint right)
		{
			return default(HexPoint);
		}

		// Token: 0x06017753 RID: 96083 RVA: 0x000968D0 File Offset: 0x00094AD0
		[Token(Token = "0x6017753")]
		[Address(RVA = "0xFC7310", Offset = "0xFC5F10", VA = "0x180FC7310")]
		public static HexPoint operator *(HexPoint vec, int k)
		{
			return default(HexPoint);
		}

		// Token: 0x06017754 RID: 96084 RVA: 0x000968E8 File Offset: 0x00094AE8
		[Token(Token = "0x6017754")]
		[Address(RVA = "0xFC73F0", Offset = "0xFC5FF0", VA = "0x180FC73F0")]
		public static HexPoint operator *(int k, HexPoint vec)
		{
			return default(HexPoint);
		}

		// Token: 0x06017755 RID: 96085 RVA: 0x00096900 File Offset: 0x00094B00
		[Token(Token = "0x6017755")]
		[Address(RVA = "0xFC71F0", Offset = "0xFC5DF0", VA = "0x180FC71F0")]
		public static bool operator ==(HexPoint lhs, HexPoint rhs)
		{
			return default(bool);
		}

		// Token: 0x06017756 RID: 96086 RVA: 0x00096918 File Offset: 0x00094B18
		[Token(Token = "0x6017756")]
		[Address(RVA = "0xFC7280", Offset = "0xFC5E80", VA = "0x180FC7280")]
		public static bool operator !=(HexPoint lhs, HexPoint rhs)
		{
			return default(bool);
		}

		// Token: 0x06017757 RID: 96087 RVA: 0x00096930 File Offset: 0x00094B30
		[Token(Token = "0x6017757")]
		[Address(RVA = "0xFC6800", Offset = "0xFC5400", VA = "0x180FC6800", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06017758 RID: 96088 RVA: 0x00096948 File Offset: 0x00094B48
		[Token(Token = "0x6017758")]
		[Address(RVA = "0xFC68C0", Offset = "0xFC54C0", VA = "0x180FC68C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06017759 RID: 96089 RVA: 0x00096960 File Offset: 0x00094B60
		[Token(Token = "0x6017759")]
		[Address(RVA = "0xFC6C30", Offset = "0xFC5830", VA = "0x180FC6C30")]
		public Vector2 ToFloat()
		{
			return default(Vector2);
		}

		// Token: 0x0601775A RID: 96090 RVA: 0x00096978 File Offset: 0x00094B78
		[Token(Token = "0x601775A")]
		[Address(RVA = "0xFC6950", Offset = "0xFC5550", VA = "0x180FC6950")]
		public bool IsInBound(List<HexPoint> bound)
		{
			return default(bool);
		}

		// Token: 0x0601775B RID: 96091 RVA: 0x00096990 File Offset: 0x00094B90
		[Token(Token = "0x601775B")]
		[Address(RVA = "0xFC6E00", Offset = "0xFC5A00", VA = "0x180FC6E00")]
		private static HexPoint.PNPolyResult _CalcIntersectPNPoly(HexPoint line, HexPoint p1, HexPoint p2)
		{
			return default(HexPoint.PNPolyResult);
		}

		// Token: 0x0601775C RID: 96092 RVA: 0x000969A8 File Offset: 0x00094BA8
		[Token(Token = "0x601775C")]
		[Address(RVA = "0xFC6D50", Offset = "0xFC5950", VA = "0x180FC6D50")]
		private bool <>xLuaBaseProxy_Equals(object P0)
		{
			return default(bool);
		}

		// Token: 0x0601775D RID: 96093 RVA: 0x000969C0 File Offset: 0x00094BC0
		[Token(Token = "0x601775D")]
		[Address(RVA = "0xFC6DB0", Offset = "0xFC59B0", VA = "0x180FC6DB0")]
		private int <>xLuaBaseProxy_GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401C552 RID: 116050
		[Token(Token = "0x401C552")]
		[FieldOffset(Offset = "0x0")]
		public int u;

		// Token: 0x0401C553 RID: 116051
		[Token(Token = "0x401C553")]
		[FieldOffset(Offset = "0x4")]
		public int v;

		// Token: 0x0401C554 RID: 116052
		[Token(Token = "0x401C554")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C555 RID: 116053
		[Token(Token = "0x401C555")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ToCrossCoord;

		// Token: 0x0401C556 RID: 116054
		[Token(Token = "0x401C556")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zero;

		// Token: 0x0401C557 RID: 116055
		[Token(Token = "0x401C557")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToHexCoord;

		// Token: 0x0401C558 RID: 116056
		[Token(Token = "0x401C558")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_ToCrossCoord;

		// Token: 0x0401C559 RID: 116057
		[Token(Token = "0x401C559")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_op_Addition;

		// Token: 0x0401C55A RID: 116058
		[Token(Token = "0x401C55A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_op_Subtraction;

		// Token: 0x0401C55B RID: 116059
		[Token(Token = "0x401C55B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_op_Multiply;

		// Token: 0x0401C55C RID: 116060
		[Token(Token = "0x401C55C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_op_Multiply;

		// Token: 0x0401C55D RID: 116061
		[Token(Token = "0x401C55D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_op_Equality;

		// Token: 0x0401C55E RID: 116062
		[Token(Token = "0x401C55E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_op_Inequality;

		// Token: 0x0401C55F RID: 116063
		[Token(Token = "0x401C55F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Equals;

		// Token: 0x0401C560 RID: 116064
		[Token(Token = "0x401C560")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetHashCode;

		// Token: 0x0401C561 RID: 116065
		[Token(Token = "0x401C561")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ToFloat;

		// Token: 0x0401C562 RID: 116066
		[Token(Token = "0x401C562")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsInBound;

		// Token: 0x0401C563 RID: 116067
		[Token(Token = "0x401C563")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CalcIntersectPNPoly;

		// Token: 0x02003A10 RID: 14864
		[Token(Token = "0x2003A10")]
		private struct PNPolyResult
		{
			// Token: 0x0401C564 RID: 116068
			[Token(Token = "0x401C564")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HexPoint.PNPolyResult EMPTY;

			// Token: 0x0401C565 RID: 116069
			[Token(Token = "0x401C565")]
			[FieldOffset(Offset = "0x0")]
			public int above;

			// Token: 0x0401C566 RID: 116070
			[Token(Token = "0x401C566")]
			[FieldOffset(Offset = "0x4")]
			public int under;

			// Token: 0x0401C567 RID: 116071
			[Token(Token = "0x401C567")]
			[FieldOffset(Offset = "0x8")]
			public bool onTheLine;
		}
	}
}
