using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	internal sealed class DeflateManager
	{
		// Token: 0x0600295B RID: 10587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295B")]
		[Address(RVA = "0x53BA010", Offset = "0x53B8C10", VA = "0x1853BA010")]
		internal DeflateManager()
		{
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x53B96D0", Offset = "0x53B82D0", VA = "0x1853B96D0")]
		private void _InitializeLazyMatch()
		{
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x53B9820", Offset = "0x53B8420", VA = "0x1853B9820")]
		private void _InitializeTreeData()
		{
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x53B9500", Offset = "0x53B8100", VA = "0x1853B9500")]
		internal void _InitializeBlocks()
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295F")]
		[Address(RVA = "0x53BBAF0", Offset = "0x53BA6F0", VA = "0x1853BBAF0")]
		internal void pqdownheap(short[] tree, int k)
		{
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x53B9980", Offset = "0x53B8580", VA = "0x1853B9980")]
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
			return default(bool);
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x53BBDA0", Offset = "0x53BA9A0", VA = "0x1853BBDA0")]
		internal void scan_tree(short[] tree, int max_code)
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00011790 File Offset: 0x0000F990
		[Token(Token = "0x6002962")]
		[Address(RVA = "0x53BB350", Offset = "0x53B9F50", VA = "0x1853BB350")]
		internal int build_bl_tree()
		{
			return 0;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002963")]
		[Address(RVA = "0x53BC020", Offset = "0x53BAC20", VA = "0x1853BC020")]
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002964")]
		[Address(RVA = "0x53BC720", Offset = "0x53BB320", VA = "0x1853BC720")]
		internal void send_tree(short[] tree, int max_code)
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x53BBD50", Offset = "0x53BA950", VA = "0x1853BBD50")]
		private void put_bytes(byte[] p, int start, int len)
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x53BC2E0", Offset = "0x53BAEE0", VA = "0x1853BC2E0")]
		internal void send_code(int c, short[] tree)
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x53BC170", Offset = "0x53BAD70", VA = "0x1853BC170")]
		internal void send_bits(int value, int length)
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002968")]
		[Address(RVA = "0x53BA560", Offset = "0x53B9160", VA = "0x1853BA560")]
		internal void _tr_align()
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x53BAEB0", Offset = "0x53B9AB0", VA = "0x1853BAEB0")]
		internal bool _tr_tally(int dist, int lc)
		{
			return default(bool);
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x53BC330", Offset = "0x53BAF30", VA = "0x1853BC330")]
		internal void send_compressed_block(short[] ltree, short[] dtree)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x53BCAB0", Offset = "0x53BB6B0", VA = "0x1853BCAB0")]
		internal void set_data_type()
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x53BB1B0", Offset = "0x53B9DB0", VA = "0x1853BB1B0")]
		internal void bi_flush()
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x53BB280", Offset = "0x53B9E80", VA = "0x1853BB280")]
		internal void bi_windup()
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x53BB4C0", Offset = "0x53BA0C0", VA = "0x1853BB4C0")]
		internal void copy_block(int buf, int len, bool header)
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x53BB5E0", Offset = "0x53BA1E0", VA = "0x1853BB5E0")]
		internal void flush_block_only(bool eof)
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x53B7450", Offset = "0x53B6050", VA = "0x1853B7450")]
		internal BlockState DeflateNone(FlushType flush)
		{
			return BlockState.NeedMore;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002971")]
		[Address(RVA = "0x53BAD30", Offset = "0x53B9930", VA = "0x1853BAD30")]
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002972")]
		[Address(RVA = "0x53BA740", Offset = "0x53B9340", VA = "0x1853BA740")]
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002973")]
		[Address(RVA = "0x53BA2A0", Offset = "0x53B8EA0", VA = "0x1853BA2A0")]
		private void _fillWindow()
		{
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x6002974")]
		[Address(RVA = "0x53B6E80", Offset = "0x53B5A80", VA = "0x1853B6E80")]
		internal BlockState DeflateFast(FlushType flush)
		{
			return BlockState.NeedMore;
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x6002975")]
		[Address(RVA = "0x53B7680", Offset = "0x53B6280", VA = "0x1853B7680")]
		internal BlockState DeflateSlow(FlushType flush)
		{
			return BlockState.NeedMore;
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x53BB640", Offset = "0x53BA240", VA = "0x1853BB640")]
		internal int longest_match(int cur_match)
		{
			return 0;
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x00011820 File Offset: 0x0000FA20
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F4")]
		internal bool WantRfc1950HeaderBytes
		{
			[Token(Token = "0x6002977")]
			[Address(RVA = "0x538F7F0", Offset = "0x538E3F0", VA = "0x18538F7F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002978")]
			[Address(RVA = "0x53BCAA0", Offset = "0x53BB6A0", VA = "0x1853BCAA0")]
			set
			{
			}
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x53B8BC0", Offset = "0x53B77C0", VA = "0x1853B8BC0")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level)
		{
			return 0;
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x53B8A80", Offset = "0x53B7680", VA = "0x1853B8A80")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
		{
			return 0;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x53B8B20", Offset = "0x53B7720", VA = "0x1853B8B20")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
		{
			return 0;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x53B8750", Offset = "0x53B7350", VA = "0x1853B8750")]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
		{
			return 0;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297D")]
		[Address(RVA = "0x53B8C50", Offset = "0x53B7850", VA = "0x1853B8C50")]
		internal void Reset()
		{
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x600297E")]
		[Address(RVA = "0x53B8620", Offset = "0x53B7220", VA = "0x1853B8620")]
		internal int End()
		{
			return 0;
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x53B8FF0", Offset = "0x53B7BF0", VA = "0x1853B8FF0")]
		private void SetDeflater()
		{
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x6002980")]
		[Address(RVA = "0x53B9410", Offset = "0x53B8010", VA = "0x1853B9410")]
		internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
		{
			return 0;
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x6002981")]
		[Address(RVA = "0x53B90F0", Offset = "0x53B7CF0", VA = "0x1853B90F0")]
		internal int SetDictionary(byte[] dictionary)
		{
			return 0;
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[Token(Token = "0x6002982")]
		[Address(RVA = "0x53B7D90", Offset = "0x53B6990", VA = "0x1853B7D90")]
		internal int Deflate(FlushType flush)
		{
			return 0;
		}

		// Token: 0x040016D6 RID: 5846
		[Token(Token = "0x40016D6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MEM_LEVEL_MAX;

		// Token: 0x040016D7 RID: 5847
		[Token(Token = "0x40016D7")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int MEM_LEVEL_DEFAULT;

		// Token: 0x040016D8 RID: 5848
		[Token(Token = "0x40016D8")]
		[FieldOffset(Offset = "0x10")]
		private DeflateManager.CompressFunc DeflateFunction;

		// Token: 0x040016D9 RID: 5849
		[Token(Token = "0x40016D9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] _ErrorMessage;

		// Token: 0x040016DA RID: 5850
		[Token(Token = "0x40016DA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int PRESET_DICT;

		// Token: 0x040016DB RID: 5851
		[Token(Token = "0x40016DB")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int INIT_STATE;

		// Token: 0x040016DC RID: 5852
		[Token(Token = "0x40016DC")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int BUSY_STATE;

		// Token: 0x040016DD RID: 5853
		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int FINISH_STATE;

		// Token: 0x040016DE RID: 5854
		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int Z_DEFLATED;

		// Token: 0x040016DF RID: 5855
		[Token(Token = "0x40016DF")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int STORED_BLOCK;

		// Token: 0x040016E0 RID: 5856
		[Token(Token = "0x40016E0")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int STATIC_TREES;

		// Token: 0x040016E1 RID: 5857
		[Token(Token = "0x40016E1")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int DYN_TREES;

		// Token: 0x040016E2 RID: 5858
		[Token(Token = "0x40016E2")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int Z_BINARY;

		// Token: 0x040016E3 RID: 5859
		[Token(Token = "0x40016E3")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int Z_ASCII;

		// Token: 0x040016E4 RID: 5860
		[Token(Token = "0x40016E4")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int Z_UNKNOWN;

		// Token: 0x040016E5 RID: 5861
		[Token(Token = "0x40016E5")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int Buf_size;

		// Token: 0x040016E6 RID: 5862
		[Token(Token = "0x40016E6")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int MIN_MATCH;

		// Token: 0x040016E7 RID: 5863
		[Token(Token = "0x40016E7")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int MAX_MATCH;

		// Token: 0x040016E8 RID: 5864
		[Token(Token = "0x40016E8")]
		[FieldOffset(Offset = "0x48")]
		private static readonly int MIN_LOOKAHEAD;

		// Token: 0x040016E9 RID: 5865
		[Token(Token = "0x40016E9")]
		[FieldOffset(Offset = "0x4C")]
		private static readonly int HEAP_SIZE;

		// Token: 0x040016EA RID: 5866
		[Token(Token = "0x40016EA")]
		[FieldOffset(Offset = "0x50")]
		private static readonly int END_BLOCK;

		// Token: 0x040016EB RID: 5867
		[Token(Token = "0x40016EB")]
		[FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		// Token: 0x040016EC RID: 5868
		[Token(Token = "0x40016EC")]
		[FieldOffset(Offset = "0x20")]
		internal int status;

		// Token: 0x040016ED RID: 5869
		[Token(Token = "0x40016ED")]
		[FieldOffset(Offset = "0x28")]
		internal byte[] pending;

		// Token: 0x040016EE RID: 5870
		[Token(Token = "0x40016EE")]
		[FieldOffset(Offset = "0x30")]
		internal int nextPending;

		// Token: 0x040016EF RID: 5871
		[Token(Token = "0x40016EF")]
		[FieldOffset(Offset = "0x34")]
		internal int pendingCount;

		// Token: 0x040016F0 RID: 5872
		[Token(Token = "0x40016F0")]
		[FieldOffset(Offset = "0x38")]
		internal sbyte data_type;

		// Token: 0x040016F1 RID: 5873
		[Token(Token = "0x40016F1")]
		[FieldOffset(Offset = "0x3C")]
		internal int last_flush;

		// Token: 0x040016F2 RID: 5874
		[Token(Token = "0x40016F2")]
		[FieldOffset(Offset = "0x40")]
		internal int w_size;

		// Token: 0x040016F3 RID: 5875
		[Token(Token = "0x40016F3")]
		[FieldOffset(Offset = "0x44")]
		internal int w_bits;

		// Token: 0x040016F4 RID: 5876
		[Token(Token = "0x40016F4")]
		[FieldOffset(Offset = "0x48")]
		internal int w_mask;

		// Token: 0x040016F5 RID: 5877
		[Token(Token = "0x40016F5")]
		[FieldOffset(Offset = "0x50")]
		internal byte[] window;

		// Token: 0x040016F6 RID: 5878
		[Token(Token = "0x40016F6")]
		[FieldOffset(Offset = "0x58")]
		internal int window_size;

		// Token: 0x040016F7 RID: 5879
		[Token(Token = "0x40016F7")]
		[FieldOffset(Offset = "0x60")]
		internal short[] prev;

		// Token: 0x040016F8 RID: 5880
		[Token(Token = "0x40016F8")]
		[FieldOffset(Offset = "0x68")]
		internal short[] head;

		// Token: 0x040016F9 RID: 5881
		[Token(Token = "0x40016F9")]
		[FieldOffset(Offset = "0x70")]
		internal int ins_h;

		// Token: 0x040016FA RID: 5882
		[Token(Token = "0x40016FA")]
		[FieldOffset(Offset = "0x74")]
		internal int hash_size;

		// Token: 0x040016FB RID: 5883
		[Token(Token = "0x40016FB")]
		[FieldOffset(Offset = "0x78")]
		internal int hash_bits;

		// Token: 0x040016FC RID: 5884
		[Token(Token = "0x40016FC")]
		[FieldOffset(Offset = "0x7C")]
		internal int hash_mask;

		// Token: 0x040016FD RID: 5885
		[Token(Token = "0x40016FD")]
		[FieldOffset(Offset = "0x80")]
		internal int hash_shift;

		// Token: 0x040016FE RID: 5886
		[Token(Token = "0x40016FE")]
		[FieldOffset(Offset = "0x84")]
		internal int block_start;

		// Token: 0x040016FF RID: 5887
		[Token(Token = "0x40016FF")]
		[FieldOffset(Offset = "0x88")]
		private DeflateManager.Config config;

		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4001700")]
		[FieldOffset(Offset = "0x90")]
		internal int match_length;

		// Token: 0x04001701 RID: 5889
		[Token(Token = "0x4001701")]
		[FieldOffset(Offset = "0x94")]
		internal int prev_match;

		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x4001702")]
		[FieldOffset(Offset = "0x98")]
		internal int match_available;

		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x4001703")]
		[FieldOffset(Offset = "0x9C")]
		internal int strstart;

		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		[FieldOffset(Offset = "0xA0")]
		internal int match_start;

		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		[FieldOffset(Offset = "0xA4")]
		internal int lookahead;

		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		[FieldOffset(Offset = "0xA8")]
		internal int prev_length;

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[FieldOffset(Offset = "0xAC")]
		internal CompressionLevel compressionLevel;

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		[FieldOffset(Offset = "0xB0")]
		internal CompressionStrategy compressionStrategy;

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		[FieldOffset(Offset = "0xB8")]
		internal short[] dyn_ltree;

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		[FieldOffset(Offset = "0xC0")]
		internal short[] dyn_dtree;

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[FieldOffset(Offset = "0xC8")]
		internal short[] bl_tree;

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		[FieldOffset(Offset = "0xD0")]
		internal ZTree treeLiterals;

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0xD8")]
		internal ZTree treeDistances;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[FieldOffset(Offset = "0xE0")]
		internal ZTree treeBitLengths;

		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x400170F")]
		[FieldOffset(Offset = "0xE8")]
		internal short[] bl_count;

		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4001710")]
		[FieldOffset(Offset = "0xF0")]
		internal int[] heap;

		// Token: 0x04001711 RID: 5905
		[Token(Token = "0x4001711")]
		[FieldOffset(Offset = "0xF8")]
		internal int heap_len;

		// Token: 0x04001712 RID: 5906
		[Token(Token = "0x4001712")]
		[FieldOffset(Offset = "0xFC")]
		internal int heap_max;

		// Token: 0x04001713 RID: 5907
		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x100")]
		internal sbyte[] depth;

		// Token: 0x04001714 RID: 5908
		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x108")]
		internal int _lengthOffset;

		// Token: 0x04001715 RID: 5909
		[Token(Token = "0x4001715")]
		[FieldOffset(Offset = "0x10C")]
		internal int lit_bufsize;

		// Token: 0x04001716 RID: 5910
		[Token(Token = "0x4001716")]
		[FieldOffset(Offset = "0x110")]
		internal int last_lit;

		// Token: 0x04001717 RID: 5911
		[Token(Token = "0x4001717")]
		[FieldOffset(Offset = "0x114")]
		internal int _distanceOffset;

		// Token: 0x04001718 RID: 5912
		[Token(Token = "0x4001718")]
		[FieldOffset(Offset = "0x118")]
		internal int opt_len;

		// Token: 0x04001719 RID: 5913
		[Token(Token = "0x4001719")]
		[FieldOffset(Offset = "0x11C")]
		internal int static_len;

		// Token: 0x0400171A RID: 5914
		[Token(Token = "0x400171A")]
		[FieldOffset(Offset = "0x120")]
		internal int matches;

		// Token: 0x0400171B RID: 5915
		[Token(Token = "0x400171B")]
		[FieldOffset(Offset = "0x124")]
		internal int last_eob_len;

		// Token: 0x0400171C RID: 5916
		[Token(Token = "0x400171C")]
		[FieldOffset(Offset = "0x128")]
		internal short bi_buf;

		// Token: 0x0400171D RID: 5917
		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x12C")]
		internal int bi_valid;

		// Token: 0x0400171E RID: 5918
		[Token(Token = "0x400171E")]
		[FieldOffset(Offset = "0x130")]
		private bool Rfc1950BytesEmitted;

		// Token: 0x0400171F RID: 5919
		[Token(Token = "0x400171F")]
		[FieldOffset(Offset = "0x131")]
		private bool _WantRfc1950HeaderBytes;

		// Token: 0x020004E9 RID: 1257
		// (Invoke) Token: 0x06002985 RID: 10629
		[Token(Token = "0x20004E9")]
		internal delegate BlockState CompressFunc(FlushType flush);

		// Token: 0x020004EA RID: 1258
		[Token(Token = "0x20004EA")]
		internal class Config
		{
			// Token: 0x06002988 RID: 10632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002988")]
			[Address(RVA = "0x53B6E20", Offset = "0x53B5A20", VA = "0x1853B6E20")]
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
			{
			}

			// Token: 0x06002989 RID: 10633 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002989")]
			[Address(RVA = "0x53B67F0", Offset = "0x53B53F0", VA = "0x1853B67F0")]
			public static DeflateManager.Config Lookup(CompressionLevel level)
			{
				return null;
			}

			// Token: 0x04001720 RID: 5920
			[Token(Token = "0x4001720")]
			[FieldOffset(Offset = "0x10")]
			internal int GoodLength;

			// Token: 0x04001721 RID: 5921
			[Token(Token = "0x4001721")]
			[FieldOffset(Offset = "0x14")]
			internal int MaxLazy;

			// Token: 0x04001722 RID: 5922
			[Token(Token = "0x4001722")]
			[FieldOffset(Offset = "0x18")]
			internal int NiceLength;

			// Token: 0x04001723 RID: 5923
			[Token(Token = "0x4001723")]
			[FieldOffset(Offset = "0x1C")]
			internal int MaxChainLength;

			// Token: 0x04001724 RID: 5924
			[Token(Token = "0x4001724")]
			[FieldOffset(Offset = "0x20")]
			internal DeflateFlavor Flavor;

			// Token: 0x04001725 RID: 5925
			[Token(Token = "0x4001725")]
			[FieldOffset(Offset = "0x0")]
			private static readonly DeflateManager.Config[] Table;
		}
	}
}
