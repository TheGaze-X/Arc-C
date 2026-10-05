using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public sealed class Deflate
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x5441480", Offset = "0x5440080", VA = "0x185441480")]
		internal Deflate()
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x5444410", Offset = "0x5443010", VA = "0x185444410")]
		internal void lm_init()
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x5445620", Offset = "0x5444220", VA = "0x185445620")]
		internal void tr_init()
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x5444320", Offset = "0x5442F20", VA = "0x185444320")]
		internal void init_block()
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x5444A30", Offset = "0x5443630", VA = "0x185444A30")]
		internal void pqdownheap(short[] tree, int k)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x54455A0", Offset = "0x54441A0", VA = "0x1854455A0")]
		internal static bool smaller(short[] tree, int n, int m, byte[] depth)
		{
			return default(bool);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x5444DE0", Offset = "0x54439E0", VA = "0x185444DE0")]
		internal void scan_tree(short[] tree, int max_code)
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x5442190", Offset = "0x5440D90", VA = "0x185442190")]
		internal int build_bl_tree()
		{
			return 0;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x5444FB0", Offset = "0x5443BB0", VA = "0x185444FB0")]
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5445230", Offset = "0x5443E30", VA = "0x185445230")]
		internal void send_tree(short[] tree, int max_code)
		{
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x5444CF0", Offset = "0x54438F0", VA = "0x185444CF0")]
		internal void put_byte(byte[] p, int start, int len)
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x5444D40", Offset = "0x5443940", VA = "0x185444D40")]
		internal void put_byte(byte c)
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x5444D80", Offset = "0x5443980", VA = "0x185444D80")]
		internal void put_short(int w)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x5444C90", Offset = "0x5443890", VA = "0x185444C90")]
		internal void putShortMSB(int b)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x54451E0", Offset = "0x5443DE0", VA = "0x1854451E0")]
		internal void send_code(int c, short[] tree)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x5445100", Offset = "0x5443D00", VA = "0x185445100")]
		internal void send_bits(int val, int length)
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x5441660", Offset = "0x5440260", VA = "0x185441660")]
		internal void _tr_align()
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x5441D60", Offset = "0x5440960", VA = "0x185441D60")]
		internal bool _tr_tally(int dist, int lc)
		{
			return default(bool);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x54422D0", Offset = "0x5440ED0", VA = "0x1854422D0")]
		internal void compress_block(short[] ltree, short[] dtree)
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x54454D0", Offset = "0x54440D0", VA = "0x1854454D0")]
		internal void set_data_type()
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x5442000", Offset = "0x5440C00", VA = "0x185442000")]
		internal void bi_flush()
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x54420D0", Offset = "0x5440CD0", VA = "0x1854420D0")]
		internal void bi_windup()
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x5442630", Offset = "0x5441230", VA = "0x185442630")]
		internal void copy_block(int buf, int len, bool header)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x54442C0", Offset = "0x5442EC0", VA = "0x1854442C0")]
		internal void flush_block_only(bool eof)
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x5443F10", Offset = "0x5442B10", VA = "0x185443F10")]
		internal int deflate_stored(int flush)
		{
			return 0;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x5441C40", Offset = "0x5440840", VA = "0x185441C40")]
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x54417B0", Offset = "0x54403B0", VA = "0x1854417B0")]
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x54440B0", Offset = "0x5442CB0", VA = "0x1854440B0")]
		internal void fill_window()
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x5443060", Offset = "0x5441C60", VA = "0x185443060")]
		internal int deflate_fast(int flush)
		{
			return 0;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x5443A40", Offset = "0x5442640", VA = "0x185443A40")]
		internal int deflate_slow(int flush)
		{
			return 0;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x54445E0", Offset = "0x54431E0", VA = "0x1854445E0")]
		internal int longest_match(int cur_match)
		{
			return 0;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x5442A10", Offset = "0x5441610", VA = "0x185442A10")]
		internal int deflateInit(ZStream strm, int level, int bits)
		{
			return 0;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x5442A40", Offset = "0x5441640", VA = "0x185442A40")]
		internal int deflateInit(ZStream strm, int level)
		{
			return 0;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x54427D0", Offset = "0x54413D0", VA = "0x1854427D0")]
		internal int deflateInit2(ZStream strm, int level, int method, int windowBits, int memLevel, int strategy)
		{
			return 0;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x5442CB0", Offset = "0x54418B0", VA = "0x185442CB0")]
		internal int deflateReset(ZStream strm)
		{
			return 0;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x5442750", Offset = "0x5441350", VA = "0x185442750")]
		internal int deflateEnd()
		{
			return 0;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x5442A70", Offset = "0x5441670", VA = "0x185442A70")]
		internal int deflateParams(ZStream strm, int _level, int _strategy)
		{
			return 0;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x5442E90", Offset = "0x5441A90", VA = "0x185442E90")]
		internal int deflateSetDictionary(ZStream strm, byte[] dictionary, int dictLength)
		{
			return 0;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x5443490", Offset = "0x5442090", VA = "0x185443490")]
		internal int deflate(ZStream strm, int flush)
		{
			return 0;
		}

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		private const int MAX_MEM_LEVEL = 9;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		private const int Z_DEFAULT_COMPRESSION = -1;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		private const int MAX_WBITS = 15;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		private const int DEF_MEM_LEVEL = 8;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		private const int STORED = 0;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		private const int FAST = 1;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		private const int SLOW = 2;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Deflate.Config[] config_table;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] z_errmsg;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		private const int NeedMore = 0;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		private const int BlockDone = 1;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		private const int FinishStarted = 2;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		private const int FinishDone = 3;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		private const int PRESET_DICT = 32;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		private const int Z_FILTERED = 1;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		private const int Z_HUFFMAN_ONLY = 2;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		private const int Z_DEFAULT_STRATEGY = 0;

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		private const int Z_NO_FLUSH = 0;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		private const int Z_PARTIAL_FLUSH = 1;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		private const int Z_SYNC_FLUSH = 2;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		private const int Z_FULL_FLUSH = 3;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		private const int Z_FINISH = 4;

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		private const int Z_OK = 0;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		private const int Z_STREAM_END = 1;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		private const int Z_ERRNO = -1;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		private const int Z_DATA_ERROR = -3;

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		private const int Z_MEM_ERROR = -4;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		private const int Z_BUF_ERROR = -5;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		private const int INIT_STATE = 42;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		private const int BUSY_STATE = 113;

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		private const int FINISH_STATE = 666;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		private const int Z_DEFLATED = 8;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		private const int STORED_BLOCK = 0;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		private const int STATIC_TREES = 1;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		private const int DYN_TREES = 2;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		private const int Z_BINARY = 0;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		private const int Z_ASCII = 1;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		private const int Z_UNKNOWN = 2;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		private const int Buf_size = 16;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		private const int REP_3_6 = 16;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		private const int REPZ_3_10 = 17;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		private const int REPZ_11_138 = 18;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		private const int MIN_MATCH = 3;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		private const int MAX_MATCH = 258;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		private const int MIN_LOOKAHEAD = 262;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		private const int MAX_BITS = 15;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		private const int D_CODES = 30;

		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		private const int BL_CODES = 19;

		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		private const int LENGTH_CODES = 29;

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		private const int LITERALS = 256;

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		private const int L_CODES = 286;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		private const int HEAP_SIZE = 573;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		private const int END_BLOCK = 256;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x10")]
		internal ZStream strm;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0x18")]
		internal int status;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x20")]
		internal byte[] pending_buf;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x28")]
		internal int pending_buf_size;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x2C")]
		internal int pending_out;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x30")]
		internal int pending;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x34")]
		internal int noheader;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x38")]
		internal byte data_type;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x39")]
		internal byte method;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x3C")]
		internal int last_flush;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x40")]
		internal int w_size;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x44")]
		internal int w_bits;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x48")]
		internal int w_mask;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x50")]
		internal byte[] window;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x58")]
		internal int window_size;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x60")]
		internal short[] prev;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x68")]
		internal short[] head;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x70")]
		internal int ins_h;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x74")]
		internal int hash_size;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x78")]
		internal int hash_bits;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x7C")]
		internal int hash_mask;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x80")]
		internal int hash_shift;

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[FieldOffset(Offset = "0x84")]
		internal int block_start;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x88")]
		internal int match_length;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x8C")]
		internal int prev_match;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x90")]
		internal int match_available;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x94")]
		internal int strstart;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x98")]
		internal int match_start;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x9C")]
		internal int lookahead;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0xA0")]
		internal int prev_length;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[FieldOffset(Offset = "0xA4")]
		internal int max_chain_length;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		[FieldOffset(Offset = "0xA8")]
		internal int max_lazy_match;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[FieldOffset(Offset = "0xAC")]
		internal int level;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0xB0")]
		internal int strategy;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0xB4")]
		internal int good_match;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0xB8")]
		internal int nice_match;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0xC0")]
		internal short[] dyn_ltree;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0xC8")]
		internal short[] dyn_dtree;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0xD0")]
		internal short[] bl_tree;

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0xD8")]
		internal ZTree l_desc;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0xE0")]
		internal ZTree d_desc;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0xE8")]
		internal ZTree bl_desc;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0xF0")]
		internal short[] bl_count;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0xF8")]
		internal int[] heap;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x100")]
		internal int heap_len;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x104")]
		internal int heap_max;

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0x108")]
		internal byte[] depth;

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x110")]
		internal int l_buf;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x114")]
		internal int lit_bufsize;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x118")]
		internal int last_lit;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x11C")]
		internal int d_buf;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x120")]
		internal int opt_len;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x124")]
		internal int static_len;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x128")]
		internal int matches;

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x12C")]
		internal int last_eob_len;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x130")]
		internal uint bi_buf;

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x134")]
		internal int bi_valid;

		// Token: 0x0200012E RID: 302
		[Token(Token = "0x200012E")]
		internal class Config
		{
			// Token: 0x060006DF RID: 1759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x53B6E20", Offset = "0x53B5A20", VA = "0x1853B6E20")]
			internal Config(int good_length, int max_lazy, int nice_length, int max_chain, int func)
			{
			}

			// Token: 0x040006B9 RID: 1721
			[Token(Token = "0x40006B9")]
			[FieldOffset(Offset = "0x10")]
			internal int good_length;

			// Token: 0x040006BA RID: 1722
			[Token(Token = "0x40006BA")]
			[FieldOffset(Offset = "0x14")]
			internal int max_lazy;

			// Token: 0x040006BB RID: 1723
			[Token(Token = "0x40006BB")]
			[FieldOffset(Offset = "0x18")]
			internal int nice_length;

			// Token: 0x040006BC RID: 1724
			[Token(Token = "0x40006BC")]
			[FieldOffset(Offset = "0x1C")]
			internal int max_chain;

			// Token: 0x040006BD RID: 1725
			[Token(Token = "0x40006BD")]
			[FieldOffset(Offset = "0x20")]
			internal int func;
		}
	}
}
