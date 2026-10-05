using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	internal sealed class InfBlocks
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x5460000", Offset = "0x545EC00", VA = "0x185460000")]
		internal InfBlocks(ZStream z, object checkfn, int w)
		{
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x5461740", Offset = "0x5460340", VA = "0x185461740")]
		internal void reset(ZStream z, long[] c)
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x54603F0", Offset = "0x545EFF0", VA = "0x1854603F0")]
		internal int proc(ZStream z, int r)
		{
			return 0;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x54601D0", Offset = "0x545EDD0", VA = "0x1854601D0")]
		internal void free(ZStream z)
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x54617D0", Offset = "0x54603D0", VA = "0x1854617D0")]
		internal void set_dictionary(byte[] d, int start, int n)
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x53C2590", Offset = "0x53C1190", VA = "0x1853C2590")]
		internal int sync_point()
		{
			return 0;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x5460270", Offset = "0x545EE70", VA = "0x185460270")]
		internal int inflate_flush(ZStream z, int r)
		{
			return 0;
		}

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		private const int MANY = 1440;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] inflate_mask;

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] border;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		private const int Z_OK = 0;

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		private const int Z_STREAM_END = 1;

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		private const int Z_NEED_DICT = 2;

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		private const int Z_ERRNO = -1;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		private const int Z_DATA_ERROR = -3;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		private const int Z_MEM_ERROR = -4;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		private const int Z_BUF_ERROR = -5;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		private const int TYPE = 0;

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		private const int LENS = 1;

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		private const int STORED = 2;

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		private const int TABLE = 3;

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		private const int BTREE = 4;

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		private const int DTREE = 5;

		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		private const int CODES = 6;

		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		private const int DRY = 7;

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		private const int DONE = 8;

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		private const int BAD = 9;

		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x10")]
		internal int mode;

		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x40006D5")]
		[FieldOffset(Offset = "0x14")]
		internal int left;

		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x18")]
		internal int table;

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x1C")]
		internal int index;

		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		[FieldOffset(Offset = "0x20")]
		internal int[] blens;

		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		[FieldOffset(Offset = "0x28")]
		internal int[] bb;

		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x40006DA")]
		[FieldOffset(Offset = "0x30")]
		internal int[] tb;

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		[FieldOffset(Offset = "0x38")]
		internal InfCodes codes;

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		[FieldOffset(Offset = "0x40")]
		private int last;

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0x44")]
		internal int bitk;

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0x48")]
		internal int bitb;

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0x50")]
		internal int[] hufts;

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0x58")]
		internal byte[] window;

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x60")]
		internal int end;

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x64")]
		internal int read;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x68")]
		internal int write;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x70")]
		internal object checkfn;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x78")]
		internal long check;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x80")]
		internal InfTree inftree;
	}
}
