using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	internal sealed class InfTree
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x5462FB0", Offset = "0x5461BB0", VA = "0x185462FB0")]
		private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
		{
			return 0;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x54638B0", Offset = "0x54624B0", VA = "0x1854638B0")]
		internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZStream z)
		{
			return 0;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x5463A10", Offset = "0x5462610", VA = "0x185463A10")]
		internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZStream z)
		{
			return 0;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x5463D70", Offset = "0x5462970", VA = "0x185463D70")]
		internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZStream z)
		{
			return 0;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x5463ED0", Offset = "0x5462AD0", VA = "0x185463ED0")]
		private void initWorkArea(int vsize)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InfTree()
		{
		}

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		private const int MANY = 1440;

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		private const int Z_OK = 0;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		private const int Z_STREAM_END = 1;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		private const int Z_ERRNO = -1;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		private const int Z_DATA_ERROR = -3;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		private const int Z_MEM_ERROR = -4;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		private const int Z_BUF_ERROR = -5;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		private const int fixed_bl = 9;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		private const int fixed_bd = 5;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] fixed_tl;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] fixed_td;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] cplens;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] cplext;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int[] cpdist;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int[] cpdext;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		private const int BMAX = 15;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x10")]
		private int[] hn;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x18")]
		private int[] v;

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x20")]
		private int[] c;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x28")]
		private int[] r;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x30")]
		private int[] u;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x38")]
		private int[] x;
	}
}
