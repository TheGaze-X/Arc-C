using System;
using System.IO;
using BestHTTP.Decompression.Crc;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x20004FE")]
	internal class ZlibBaseStream : Stream
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x00011D48 File Offset: 0x0000FF48
		[Token(Token = "0x1700060C")]
		internal int Crc32
		{
			[Token(Token = "0x60029F6")]
			[Address(RVA = "0x53E0EF0", Offset = "0x53DFAF0", VA = "0x1853E0EF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x53E01F0", Offset = "0x53DEDF0", VA = "0x1853E01F0")]
		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
		{
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x53E0220", Offset = "0x53DEE20", VA = "0x1853E0220")]
		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen, int windowBits)
		{
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x00011D60 File Offset: 0x0000FF60
		[Token(Token = "0x1700060D")]
		protected internal bool _wantCompress
		{
			[Token(Token = "0x60029F9")]
			[Address(RVA = "0x32EC380", Offset = "0x32EAF80", VA = "0x1832EC380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060E")]
		private ZlibCodec z
		{
			[Token(Token = "0x60029FA")]
			[Address(RVA = "0x53E0FB0", Offset = "0x53DFBB0", VA = "0x1853E0FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060F")]
		private byte[] workingBuffer
		{
			[Token(Token = "0x60029FB")]
			[Address(RVA = "0x53E0F50", Offset = "0x53DFB50", VA = "0x1853E0F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x53DFA30", Offset = "0x53DE630", VA = "0x1853DFA30", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FD")]
		[Address(RVA = "0x53E05B0", Offset = "0x53DF1B0", VA = "0x1853E05B0")]
		private void finish()
		{
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FE")]
		[Address(RVA = "0x53E0480", Offset = "0x53DF080", VA = "0x1853E0480")]
		private void end()
		{
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x53DE890", Offset = "0x53DD490", VA = "0x1853DE890", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A00")]
		[Address(RVA = "0x4A560E0", Offset = "0x4A54CE0", VA = "0x184A560E0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00011D78 File Offset: 0x0000FF78
		[Token(Token = "0x6002A01")]
		[Address(RVA = "0x53DF410", Offset = "0x53DE010", VA = "0x1853DF410", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x53DF460", Offset = "0x53DE060", VA = "0x1853DF460", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x53DEB30", Offset = "0x53DD730", VA = "0x1853DEB30")]
		private string ReadZeroTerminatedString()
		{
			return null;
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00011D90 File Offset: 0x0000FF90
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x53DFE10", Offset = "0x53DEA10", VA = "0x1853DFE10")]
		private int _ReadAndValidateGzipHeader()
		{
			return 0;
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x53DED80", Offset = "0x53DD980", VA = "0x1853DED80", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[Token(Token = "0x17000610")]
		public override bool CanRead
		{
			[Token(Token = "0x6002A06")]
			[Address(RVA = "0x4A570D0", Offset = "0x4A55CD0", VA = "0x184A570D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[Token(Token = "0x17000611")]
		public override bool CanSeek
		{
			[Token(Token = "0x6002A07")]
			[Address(RVA = "0x53E0E50", Offset = "0x53DFA50", VA = "0x1853E0E50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[Token(Token = "0x17000612")]
		public override bool CanWrite
		{
			[Token(Token = "0x6002A08")]
			[Address(RVA = "0x53E0EA0", Offset = "0x53DFAA0", VA = "0x1853E0EA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x00011E08 File Offset: 0x00010008
		[Token(Token = "0x17000613")]
		public override long Length
		{
			[Token(Token = "0x6002A09")]
			[Address(RVA = "0x4A57140", Offset = "0x4A55D40", VA = "0x184A57140", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x00011E20 File Offset: 0x00010020
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000614")]
		public override long Position
		{
			[Token(Token = "0x6002A0A")]
			[Address(RVA = "0x53E0F00", Offset = "0x53DFB00", VA = "0x1853E0F00", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002A0B")]
			[Address(RVA = "0x53E10B0", Offset = "0x53DFCB0", VA = "0x1853E10B0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x53DE9F0", Offset = "0x53DD5F0", VA = "0x1853DE9F0")]
		public static void CompressString(string s, Stream compressor)
		{
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x53DE8F0", Offset = "0x53DD4F0", VA = "0x1853DE8F0")]
		public static void CompressBuffer(byte[] b, Stream compressor)
		{
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x53DF740", Offset = "0x53DE340", VA = "0x1853DF740")]
		public static string UncompressString(byte[] compressed, Stream decompressor)
		{
			return null;
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x53DF4D0", Offset = "0x53DE0D0", VA = "0x1853DF4D0")]
		public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
		{
			return null;
		}

		// Token: 0x040017D7 RID: 6103
		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0x28")]
		protected internal ZlibCodec _z;

		// Token: 0x040017D8 RID: 6104
		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0x30")]
		protected internal ZlibBaseStream.StreamMode _streamMode;

		// Token: 0x040017D9 RID: 6105
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0x34")]
		protected internal FlushType _flushMode;

		// Token: 0x040017DA RID: 6106
		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0x38")]
		protected internal ZlibStreamFlavor _flavor;

		// Token: 0x040017DB RID: 6107
		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0x3C")]
		protected internal CompressionMode _compressionMode;

		// Token: 0x040017DC RID: 6108
		[Token(Token = "0x40017DC")]
		[FieldOffset(Offset = "0x40")]
		protected internal CompressionLevel _level;

		// Token: 0x040017DD RID: 6109
		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0x44")]
		protected internal bool _leaveOpen;

		// Token: 0x040017DE RID: 6110
		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0x48")]
		protected internal byte[] _workingBuffer;

		// Token: 0x040017DF RID: 6111
		[Token(Token = "0x40017DF")]
		[FieldOffset(Offset = "0x50")]
		protected internal int _bufferSize;

		// Token: 0x040017E0 RID: 6112
		[Token(Token = "0x40017E0")]
		[FieldOffset(Offset = "0x54")]
		protected internal int windowBitsMax;

		// Token: 0x040017E1 RID: 6113
		[Token(Token = "0x40017E1")]
		[FieldOffset(Offset = "0x58")]
		protected internal byte[] _buf1;

		// Token: 0x040017E2 RID: 6114
		[Token(Token = "0x40017E2")]
		[FieldOffset(Offset = "0x60")]
		protected internal Stream _stream;

		// Token: 0x040017E3 RID: 6115
		[Token(Token = "0x40017E3")]
		[FieldOffset(Offset = "0x68")]
		protected internal CompressionStrategy Strategy;

		// Token: 0x040017E4 RID: 6116
		[Token(Token = "0x40017E4")]
		[FieldOffset(Offset = "0x70")]
		private CRC32 crc;

		// Token: 0x040017E5 RID: 6117
		[Token(Token = "0x40017E5")]
		[FieldOffset(Offset = "0x78")]
		protected internal string _GzipFileName;

		// Token: 0x040017E6 RID: 6118
		[Token(Token = "0x40017E6")]
		[FieldOffset(Offset = "0x80")]
		protected internal string _GzipComment;

		// Token: 0x040017E7 RID: 6119
		[Token(Token = "0x40017E7")]
		[FieldOffset(Offset = "0x88")]
		protected internal DateTime _GzipMtime;

		// Token: 0x040017E8 RID: 6120
		[Token(Token = "0x40017E8")]
		[FieldOffset(Offset = "0x90")]
		protected internal int _gzipHeaderByteCount;

		// Token: 0x040017E9 RID: 6121
		[Token(Token = "0x40017E9")]
		[FieldOffset(Offset = "0x94")]
		private bool nomoreinput;

		// Token: 0x020004FF RID: 1279
		[Token(Token = "0x20004FF")]
		internal enum StreamMode
		{
			// Token: 0x040017EB RID: 6123
			[Token(Token = "0x40017EB")]
			Writer,
			// Token: 0x040017EC RID: 6124
			[Token(Token = "0x40017EC")]
			Reader,
			// Token: 0x040017ED RID: 6125
			[Token(Token = "0x40017ED")]
			Undefined
		}
	}
}
