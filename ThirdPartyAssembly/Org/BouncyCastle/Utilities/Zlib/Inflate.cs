using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	internal sealed class Inflate
	{
		// Token: 0x060006EE RID: 1774 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x5464450", Offset = "0x5463050", VA = "0x185464450")]
		internal int inflateReset(ZStream z)
		{
			return 0;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x54641E0", Offset = "0x5462DE0", VA = "0x1854641E0")]
		internal int inflateEnd(ZStream z)
		{
			return 0;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x54642A0", Offset = "0x5462EA0", VA = "0x1854642A0")]
		internal int inflateInit(ZStream z, int w)
		{
			return 0;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x54648B0", Offset = "0x54634B0", VA = "0x1854648B0")]
		internal int inflate(ZStream z, int f)
		{
			return 0;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x5464530", Offset = "0x5463130", VA = "0x185464530")]
		internal int inflateSetDictionary(ZStream z, byte[] dictionary, int dictLength)
		{
			return 0;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x54646B0", Offset = "0x54632B0", VA = "0x1854646B0")]
		internal int inflateSync(ZStream z)
		{
			return 0;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x5464680", Offset = "0x5463280", VA = "0x185464680")]
		internal int inflateSyncPoint(ZStream z)
		{
			return 0;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x5464180", Offset = "0x5462D80", VA = "0x185464180")]
		public Inflate()
		{
		}

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		private const int MAX_WBITS = 15;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		private const int PRESET_DICT = 32;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		internal const int Z_NO_FLUSH = 0;

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		internal const int Z_PARTIAL_FLUSH = 1;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		internal const int Z_SYNC_FLUSH = 2;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		internal const int Z_FULL_FLUSH = 3;

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		internal const int Z_FINISH = 4;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		private const int Z_DEFLATED = 8;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		private const int Z_OK = 0;

		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		private const int Z_STREAM_END = 1;

		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		private const int Z_ERRNO = -1;

		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x4000715")]
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x4000716")]
		private const int Z_DATA_ERROR = -3;

		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x4000717")]
		private const int Z_MEM_ERROR = -4;

		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		private const int Z_BUF_ERROR = -5;

		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		private const int METHOD = 0;

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		private const int FLAG = 1;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		private const int DICT4 = 2;

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		private const int DICT3 = 3;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		private const int DICT2 = 4;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		private const int DICT1 = 5;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		private const int DICT0 = 6;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		private const int BLOCKS = 7;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		private const int CHECK4 = 8;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		private const int CHECK3 = 9;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		private const int CHECK2 = 10;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		private const int CHECK1 = 11;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		private const int DONE = 12;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		private const int BAD = 13;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x10")]
		internal int mode;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x14")]
		internal int method;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x18")]
		internal long[] was;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x20")]
		internal long need;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x28")]
		internal int marker;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x2C")]
		internal int nowrap;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x30")]
		internal int wbits;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x38")]
		internal InfBlocks blocks;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] mark;
	}
}
