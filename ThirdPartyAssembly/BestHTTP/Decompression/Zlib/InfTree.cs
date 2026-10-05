using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	internal sealed class InfTree
	{
		// Token: 0x060029E2 RID: 10722 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		[Token(Token = "0x60029E2")]
		[Address(RVA = "0x53BFC50", Offset = "0x53BE850", VA = "0x1853BFC50")]
		private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
		{
			return 0;
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		[Token(Token = "0x60029E3")]
		[Address(RVA = "0x53C0550", Offset = "0x53BF150", VA = "0x1853C0550")]
		internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00011CD0 File Offset: 0x0000FED0
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x53C06B0", Offset = "0x53BF2B0", VA = "0x1853C06B0")]
		internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x53C0A10", Offset = "0x53BF610", VA = "0x1853C0A10")]
		internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)
		{
			return 0;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E6")]
		[Address(RVA = "0x53C0B70", Offset = "0x53BF770", VA = "0x1853C0B70")]
		private void initWorkArea(int vsize)
		{
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InfTree()
		{
		}

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		private const int MANY = 1440;

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		private const int Z_OK = 0;

		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		private const int Z_STREAM_END = 1;

		// Token: 0x0400178B RID: 6027
		[Token(Token = "0x400178B")]
		private const int Z_NEED_DICT = 2;

		// Token: 0x0400178C RID: 6028
		[Token(Token = "0x400178C")]
		private const int Z_ERRNO = -1;

		// Token: 0x0400178D RID: 6029
		[Token(Token = "0x400178D")]
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x0400178E RID: 6030
		[Token(Token = "0x400178E")]
		private const int Z_DATA_ERROR = -3;

		// Token: 0x0400178F RID: 6031
		[Token(Token = "0x400178F")]
		private const int Z_MEM_ERROR = -4;

		// Token: 0x04001790 RID: 6032
		[Token(Token = "0x4001790")]
		private const int Z_BUF_ERROR = -5;

		// Token: 0x04001791 RID: 6033
		[Token(Token = "0x4001791")]
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x04001792 RID: 6034
		[Token(Token = "0x4001792")]
		internal const int fixed_bl = 9;

		// Token: 0x04001793 RID: 6035
		[Token(Token = "0x4001793")]
		internal const int fixed_bd = 5;

		// Token: 0x04001794 RID: 6036
		[Token(Token = "0x4001794")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] fixed_tl;

		// Token: 0x04001795 RID: 6037
		[Token(Token = "0x4001795")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] fixed_td;

		// Token: 0x04001796 RID: 6038
		[Token(Token = "0x4001796")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int[] cplens;

		// Token: 0x04001797 RID: 6039
		[Token(Token = "0x4001797")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[] cplext;

		// Token: 0x04001798 RID: 6040
		[Token(Token = "0x4001798")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly int[] cpdist;

		// Token: 0x04001799 RID: 6041
		[Token(Token = "0x4001799")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly int[] cpdext;

		// Token: 0x0400179A RID: 6042
		[Token(Token = "0x400179A")]
		internal const int BMAX = 15;

		// Token: 0x0400179B RID: 6043
		[Token(Token = "0x400179B")]
		[FieldOffset(Offset = "0x10")]
		internal int[] hn;

		// Token: 0x0400179C RID: 6044
		[Token(Token = "0x400179C")]
		[FieldOffset(Offset = "0x18")]
		internal int[] v;

		// Token: 0x0400179D RID: 6045
		[Token(Token = "0x400179D")]
		[FieldOffset(Offset = "0x20")]
		internal int[] c;

		// Token: 0x0400179E RID: 6046
		[Token(Token = "0x400179E")]
		[FieldOffset(Offset = "0x28")]
		internal int[] r;

		// Token: 0x0400179F RID: 6047
		[Token(Token = "0x400179F")]
		[FieldOffset(Offset = "0x30")]
		internal int[] u;

		// Token: 0x040017A0 RID: 6048
		[Token(Token = "0x40017A0")]
		[FieldOffset(Offset = "0x38")]
		internal int[] x;
	}
}
