using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004EC RID: 1260
	[Token(Token = "0x20004EC")]
	internal class GZipStream : Stream
	{
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FF")]
		public string Comment
		{
			[Token(Token = "0x60029A8")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029A9")]
			[Address(RVA = "0x53BF190", Offset = "0x53BDD90", VA = "0x1853BF190")]
			set
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000600")]
		public string FileName
		{
			[Token(Token = "0x60029AA")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029AB")]
			[Address(RVA = "0x53BF210", Offset = "0x53BDE10", VA = "0x1853BF210")]
			set
			{
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x00011A18 File Offset: 0x0000FC18
		[Token(Token = "0x17000601")]
		public int Crc32
		{
			[Token(Token = "0x60029AC")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x53BED00", Offset = "0x53BD900", VA = "0x1853BED00")]
		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x53BED30", Offset = "0x53BD930", VA = "0x1853BED30")]
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x53BECD0", Offset = "0x53BD8D0", VA = "0x1853BECD0")]
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x53BEBF0", Offset = "0x53BD7F0", VA = "0x1853BEBF0")]
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x00011A30 File Offset: 0x0000FC30
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000602")]
		public virtual FlushType FlushMode
		{
			[Token(Token = "0x60029B1")]
			[Address(RVA = "0x53BEED0", Offset = "0x53BDAD0", VA = "0x1853BEED0", Slot = "38")]
			get
			{
				return FlushType.None;
			}
			[Token(Token = "0x60029B2")]
			[Address(RVA = "0x53BF3F0", Offset = "0x53BDFF0", VA = "0x1853BF3F0", Slot = "39")]
			set
			{
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x00011A48 File Offset: 0x0000FC48
		// (set) Token: 0x060029B4 RID: 10676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000603")]
		public int BufferSize
		{
			[Token(Token = "0x60029B3")]
			[Address(RVA = "0x53BED50", Offset = "0x53BD950", VA = "0x1853BED50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60029B4")]
			[Address(RVA = "0x53BF000", Offset = "0x53BDC00", VA = "0x1853BF000")]
			set
			{
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x00011A60 File Offset: 0x0000FC60
		[Token(Token = "0x17000604")]
		public virtual long TotalIn
		{
			[Token(Token = "0x60029B5")]
			[Address(RVA = "0x53BEFA0", Offset = "0x53BDBA0", VA = "0x1853BEFA0", Slot = "40")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x00011A78 File Offset: 0x0000FC78
		[Token(Token = "0x17000605")]
		public virtual long TotalOut
		{
			[Token(Token = "0x60029B6")]
			[Address(RVA = "0x53BEFD0", Offset = "0x53BDBD0", VA = "0x1853BEFD0", Slot = "41")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x53BDF90", Offset = "0x53BCB90", VA = "0x1853BDF90", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x00011A90 File Offset: 0x0000FC90
		[Token(Token = "0x17000606")]
		public override bool CanRead
		{
			[Token(Token = "0x60029B8")]
			[Address(RVA = "0x53BED70", Offset = "0x53BD970", VA = "0x1853BED70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		[Token(Token = "0x17000607")]
		public override bool CanSeek
		{
			[Token(Token = "0x60029B9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		[Token(Token = "0x17000608")]
		public override bool CanWrite
		{
			[Token(Token = "0x60029BA")]
			[Address(RVA = "0x53BEE20", Offset = "0x53BDA20", VA = "0x1853BEE20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x53BE4E0", Offset = "0x53BD0E0", VA = "0x1853BE4E0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[Token(Token = "0x17000609")]
		public override long Length
		{
			[Token(Token = "0x60029BC")]
			[Address(RVA = "0x53BEEF0", Offset = "0x53BDAF0", VA = "0x1853BEEF0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060A")]
		public override long Position
		{
			[Token(Token = "0x60029BD")]
			[Address(RVA = "0x53BEF40", Offset = "0x53BDB40", VA = "0x1853BEF40", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60029BE")]
			[Address(RVA = "0x53BF470", Offset = "0x53BE070", VA = "0x1853BF470", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x53BE580", Offset = "0x53BD180", VA = "0x1853BE580", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00011B20 File Offset: 0x0000FD20
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x53BE6C0", Offset = "0x53BD2C0", VA = "0x1853BE6C0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x53BE710", Offset = "0x53BD310", VA = "0x1853BE710", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0x53BEA00", Offset = "0x53BD600", VA = "0x1853BEA00", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00011B38 File Offset: 0x0000FD38
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0x53BE070", Offset = "0x53BCC70", VA = "0x1853BE070")]
		private int EmitHeader()
		{
			return 0;
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x53BDE10", Offset = "0x53BCA10", VA = "0x1853BDE10")]
		public static byte[] CompressString(string s)
		{
			return null;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x53BDC90", Offset = "0x53BC890", VA = "0x1853BDC90")]
		public static byte[] CompressBuffer(byte[] b)
		{
			return null;
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C6")]
		[Address(RVA = "0x53BE8B0", Offset = "0x53BD4B0", VA = "0x1853BE8B0")]
		public static string UncompressString(byte[] compressed)
		{
			return null;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x53BE760", Offset = "0x53BD360", VA = "0x1853BE760")]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			return null;
		}

		// Token: 0x04001729 RID: 5929
		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x28")]
		public DateTime? LastModified;

		// Token: 0x0400172A RID: 5930
		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x38")]
		private int _headerByteCount;

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x40")]
		internal ZlibBaseStream _baseStream;

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x48")]
		private bool _disposed;

		// Token: 0x0400172D RID: 5933
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x49")]
		private bool _firstReadDone;

		// Token: 0x0400172E RID: 5934
		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x50")]
		private string _FileName;

		// Token: 0x0400172F RID: 5935
		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x58")]
		private string _Comment;

		// Token: 0x04001730 RID: 5936
		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x60")]
		private int _Crc32;

		// Token: 0x04001731 RID: 5937
		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DateTime _unixEpoch;

		// Token: 0x04001732 RID: 5938
		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly Encoding iso8859dash1;
	}
}
