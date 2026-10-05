using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x02000500 RID: 1280
	[Token(Token = "0x2000500")]
	internal sealed class ZlibCodec
	{
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x17000615")]
		public int Adler32
		{
			[Token(Token = "0x6002A10")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x53E1950", Offset = "0x53E0550", VA = "0x1853E1950")]
		public ZlibCodec()
		{
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x53E17F0", Offset = "0x53E03F0", VA = "0x1853E17F0")]
		public ZlibCodec(CompressionMode mode)
		{
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00011E50 File Offset: 0x00010050
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x53E1390", Offset = "0x53DFF90", VA = "0x1853E1390")]
		public int InitializeInflate()
		{
			return 0;
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00011E68 File Offset: 0x00010068
		[Token(Token = "0x6002A14")]
		[Address(RVA = "0x53E13B0", Offset = "0x53DFFB0", VA = "0x1853E13B0")]
		public int InitializeInflate(bool expectRfc1950Header)
		{
			return 0;
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00011E80 File Offset: 0x00010080
		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x53E13A0", Offset = "0x53DFFA0", VA = "0x1853E13A0")]
		public int InitializeInflate(int windowBits)
		{
			return 0;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x6002A16")]
		[Address(RVA = "0x53E13C0", Offset = "0x53DFFC0", VA = "0x1853E13C0")]
		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			return 0;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Token(Token = "0x6002A17")]
		[Address(RVA = "0x53E1290", Offset = "0x53DFE90", VA = "0x1853E1290")]
		public int Inflate(FlushType flush)
		{
			return 0;
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x00011EC8 File Offset: 0x000100C8
		[Token(Token = "0x6002A18")]
		[Address(RVA = "0x53E1200", Offset = "0x53DFE00", VA = "0x1853E1200")]
		public int EndInflate()
		{
			return 0;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x53E1650", Offset = "0x53E0250", VA = "0x1853E1650")]
		public int SyncInflate()
		{
			return 0;
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00011EF8 File Offset: 0x000100F8
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x53E1340", Offset = "0x53DFF40", VA = "0x1853E1340")]
		public int InitializeDeflate()
		{
			return 0;
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00011F10 File Offset: 0x00010110
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x53E1330", Offset = "0x53DFF30", VA = "0x1853E1330")]
		public int InitializeDeflate(CompressionLevel level)
		{
			return 0;
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x00011F28 File Offset: 0x00010128
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x53E1370", Offset = "0x53DFF70", VA = "0x1853E1370")]
		public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
		{
			return 0;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00011F40 File Offset: 0x00010140
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x53E1310", Offset = "0x53DFF10", VA = "0x1853E1310")]
		public int InitializeDeflate(CompressionLevel level, int bits)
		{
			return 0;
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00011F58 File Offset: 0x00010158
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x53E1350", Offset = "0x53DFF50", VA = "0x1853E1350")]
		public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			return 0;
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00011F70 File Offset: 0x00010170
		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0x53E16D0", Offset = "0x53E02D0", VA = "0x1853E16D0")]
		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			return 0;
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x00011F88 File Offset: 0x00010188
		[Token(Token = "0x6002A20")]
		[Address(RVA = "0x53E1100", Offset = "0x53DFD00", VA = "0x1853E1100")]
		public int Deflate(FlushType flush)
		{
			return 0;
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00011FA0 File Offset: 0x000101A0
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x53E1180", Offset = "0x53DFD80", VA = "0x1853E1180")]
		public int EndDeflate()
		{
			return 0;
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x53E14C0", Offset = "0x53E00C0", VA = "0x1853E14C0")]
		public void ResetDeflate()
		{
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00011FB8 File Offset: 0x000101B8
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x53E1540", Offset = "0x53E0140", VA = "0x1853E1540")]
		public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
		{
			return 0;
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00011FD0 File Offset: 0x000101D0
		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x53E15C0", Offset = "0x53E01C0", VA = "0x1853E15C0")]
		public int SetDictionary(byte[] dictionary)
		{
			return 0;
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x53E1970", Offset = "0x53E0570", VA = "0x1853E1970")]
		internal void flush_pending()
		{
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00011FE8 File Offset: 0x000101E8
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x53E1B20", Offset = "0x53E0720", VA = "0x1853E1B20")]
		internal int read_buf(byte[] buf, int start, int size)
		{
			return 0;
		}

		// Token: 0x040017EE RID: 6126
		[Token(Token = "0x40017EE")]
		[FieldOffset(Offset = "0x10")]
		public byte[] InputBuffer;

		// Token: 0x040017EF RID: 6127
		[Token(Token = "0x40017EF")]
		[FieldOffset(Offset = "0x18")]
		public int NextIn;

		// Token: 0x040017F0 RID: 6128
		[Token(Token = "0x40017F0")]
		[FieldOffset(Offset = "0x1C")]
		public int AvailableBytesIn;

		// Token: 0x040017F1 RID: 6129
		[Token(Token = "0x40017F1")]
		[FieldOffset(Offset = "0x20")]
		public long TotalBytesIn;

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		[FieldOffset(Offset = "0x28")]
		public byte[] OutputBuffer;

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		[FieldOffset(Offset = "0x30")]
		public int NextOut;

		// Token: 0x040017F4 RID: 6132
		[Token(Token = "0x40017F4")]
		[FieldOffset(Offset = "0x34")]
		public int AvailableBytesOut;

		// Token: 0x040017F5 RID: 6133
		[Token(Token = "0x40017F5")]
		[FieldOffset(Offset = "0x38")]
		public long TotalBytesOut;

		// Token: 0x040017F6 RID: 6134
		[Token(Token = "0x40017F6")]
		[FieldOffset(Offset = "0x40")]
		public string Message;

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		[FieldOffset(Offset = "0x48")]
		internal DeflateManager dstate;

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		[FieldOffset(Offset = "0x50")]
		internal InflateManager istate;

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		[FieldOffset(Offset = "0x58")]
		internal uint _Adler32;

		// Token: 0x040017FA RID: 6138
		[Token(Token = "0x40017FA")]
		[FieldOffset(Offset = "0x5C")]
		public CompressionLevel CompressLevel;

		// Token: 0x040017FB RID: 6139
		[Token(Token = "0x40017FB")]
		[FieldOffset(Offset = "0x60")]
		public int WindowBits;

		// Token: 0x040017FC RID: 6140
		[Token(Token = "0x40017FC")]
		[FieldOffset(Offset = "0x64")]
		public CompressionStrategy Strategy;
	}
}
