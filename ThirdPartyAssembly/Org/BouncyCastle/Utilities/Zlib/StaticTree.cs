using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	internal sealed class StaticTree
	{
		// Token: 0x06000700 RID: 1792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x53C5600", Offset = "0x53C4200", VA = "0x1853C5600")]
		internal StaticTree(short[] static_tree, int[] extra_bits, int extra_base, int elems, int max_length)
		{
		}

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		private const int MAX_BITS = 15;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		private const int BL_CODES = 19;

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		private const int D_CODES = 30;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		private const int LITERALS = 256;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		private const int LENGTH_CODES = 29;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		private const int L_CODES = 286;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		internal const int MAX_BL_BITS = 7;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly short[] static_ltree;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly short[] static_dtree;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly StaticTree static_l_desc;

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly StaticTree static_d_desc;

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly StaticTree static_bl_desc;

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x10")]
		internal short[] static_tree;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x18")]
		internal int[] extra_bits;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x20")]
		internal int extra_base;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x24")]
		internal int elems;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x28")]
		internal int max_length;
	}
}
