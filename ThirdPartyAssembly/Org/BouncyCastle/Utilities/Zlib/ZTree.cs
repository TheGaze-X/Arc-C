using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	internal sealed class ZTree
	{
		// Token: 0x06000730 RID: 1840 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x546CDF0", Offset = "0x546B9F0", VA = "0x18546CDF0")]
		internal static int d_code(int dist)
		{
			return 0;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x546CEB0", Offset = "0x546BAB0", VA = "0x18546CEB0")]
		internal void gen_bitlen(Deflate s)
		{
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x546C7E0", Offset = "0x546B3E0", VA = "0x18546C7E0")]
		internal void build_tree(Deflate s)
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x546D220", Offset = "0x546BE20", VA = "0x18546D220")]
		internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x53DDD70", Offset = "0x53DC970", VA = "0x1853DDD70")]
		internal static int bi_reverse(int code, int len)
		{
			return 0;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZTree()
		{
		}

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		private const int MAX_BITS = 15;

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		private const int BL_CODES = 19;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		private const int D_CODES = 30;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		private const int LITERALS = 256;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		private const int LENGTH_CODES = 29;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		private const int L_CODES = 286;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		private const int HEAP_SIZE = 573;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		internal const int MAX_BL_BITS = 7;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		internal const int END_BLOCK = 256;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		internal const int REP_3_6 = 16;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		internal const int REPZ_3_10 = 17;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		internal const int REPZ_11_138 = 18;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] extra_lbits;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] extra_dbits;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int[] extra_blbits;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly byte[] bl_order;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		internal const int Buf_size = 16;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		internal const int DIST_CODE_LEN = 512;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly byte[] _dist_code;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly byte[] _length_code;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly int[] base_length;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly int[] base_dist;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x10")]
		internal short[] dyn_tree;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x18")]
		internal int max_code;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x20")]
		internal StaticTree stat_desc;
	}
}
