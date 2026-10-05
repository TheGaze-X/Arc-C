using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	internal sealed class InfCodes
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal InfCodes()
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x53C3110", Offset = "0x53C1D10", VA = "0x1853C3110")]
		internal void init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, ZStream z)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x54621E0", Offset = "0x5460DE0", VA = "0x1854621E0")]
		internal int proc(InfBlocks s, ZStream z, int r)
		{
			return 0;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void free(ZStream z)
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x54618B0", Offset = "0x54604B0", VA = "0x1854618B0")]
		internal int inflate_fast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InfBlocks s, ZStream z)
		{
			return 0;
		}

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] inflate_mask;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		private const int Z_OK = 0;

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		private const int Z_STREAM_END = 1;

		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x40006EA")]
		private const int Z_NEED_DICT = 2;

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		private const int Z_ERRNO = -1;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		private const int Z_DATA_ERROR = -3;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		private const int Z_MEM_ERROR = -4;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		private const int Z_BUF_ERROR = -5;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		private const int START = 0;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		private const int LEN = 1;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		private const int LENEXT = 2;

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		private const int DIST = 3;

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		private const int DISTEXT = 4;

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		private const int COPY = 5;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		private const int LIT = 6;

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		private const int WASH = 7;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		private const int END = 8;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		private const int BADCODE = 9;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x10")]
		private int mode;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x14")]
		private int len;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x18")]
		private int[] tree;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x20")]
		private int tree_index;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x24")]
		private int need;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x28")]
		private int lit;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x2C")]
		private int get;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x30")]
		private int dist;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x34")]
		private byte lbits;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x35")]
		private byte dbits;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x38")]
		private int[] ltree;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x40")]
		private int ltree_index;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x48")]
		private int[] dtree;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x50")]
		private int dtree_index;
	}
}
