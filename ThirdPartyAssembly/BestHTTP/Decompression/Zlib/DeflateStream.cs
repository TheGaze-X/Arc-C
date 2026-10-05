using System;
using System.IO;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004EB RID: 1259
	[Token(Token = "0x20004EB")]
	internal class DeflateStream : Stream
	{
		// Token: 0x0600298B RID: 10635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x53BD6E0", Offset = "0x53BC2E0", VA = "0x1853BD6E0")]
		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x53BD6C0", Offset = "0x53BC2C0", VA = "0x1853BD6C0")]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x53BD4A0", Offset = "0x53BC0A0", VA = "0x1853BD4A0")]
		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298E")]
		[Address(RVA = "0x53BD5D0", Offset = "0x53BC1D0", VA = "0x1853BD5D0")]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298F")]
		[Address(RVA = "0x53BD4D0", Offset = "0x53BC0D0", VA = "0x1853BD4D0")]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen, int windowBits)
		{
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000118F8 File Offset: 0x0000FAF8
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F5")]
		public virtual FlushType FlushMode
		{
			[Token(Token = "0x6002990")]
			[Address(RVA = "0x53BD870", Offset = "0x53BC470", VA = "0x1853BD870", Slot = "38")]
			get
			{
				return FlushType.None;
			}
			[Token(Token = "0x6002991")]
			[Address(RVA = "0x53BDB40", Offset = "0x53BC740", VA = "0x1853BDB40", Slot = "39")]
			set
			{
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x00011910 File Offset: 0x0000FB10
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F6")]
		public int BufferSize
		{
			[Token(Token = "0x6002992")]
			[Address(RVA = "0x13D31E0", Offset = "0x13D1DE0", VA = "0x1813D31E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002993")]
			[Address(RVA = "0x53BD9B0", Offset = "0x53BC5B0", VA = "0x1853BD9B0")]
			set
			{
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x00011928 File Offset: 0x0000FB28
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F7")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x6002994")]
			[Address(RVA = "0x53BD930", Offset = "0x53BC530", VA = "0x1853BD930")]
			get
			{
				return CompressionStrategy.Default;
			}
			[Token(Token = "0x6002995")]
			[Address(RVA = "0x53BDC10", Offset = "0x53BC810", VA = "0x1853BDC10")]
			set
			{
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x00011940 File Offset: 0x0000FB40
		[Token(Token = "0x170005F8")]
		public virtual long TotalIn
		{
			[Token(Token = "0x6002996")]
			[Address(RVA = "0x53BD950", Offset = "0x53BC550", VA = "0x1853BD950", Slot = "40")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x170005F9")]
		public virtual long TotalOut
		{
			[Token(Token = "0x6002997")]
			[Address(RVA = "0x53BD980", Offset = "0x53BC580", VA = "0x1853BD980", Slot = "41")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002998")]
		[Address(RVA = "0x53BCF40", Offset = "0x53BBB40", VA = "0x1853BCF40", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x170005FA")]
		public override bool CanRead
		{
			[Token(Token = "0x6002999")]
			[Address(RVA = "0x53BD710", Offset = "0x53BC310", VA = "0x1853BD710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x00011988 File Offset: 0x0000FB88
		[Token(Token = "0x170005FB")]
		public override bool CanSeek
		{
			[Token(Token = "0x600299A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x000119A0 File Offset: 0x0000FBA0
		[Token(Token = "0x170005FC")]
		public override bool CanWrite
		{
			[Token(Token = "0x600299B")]
			[Address(RVA = "0x53BD7C0", Offset = "0x53BC3C0", VA = "0x1853BD7C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299C")]
		[Address(RVA = "0x53BCFF0", Offset = "0x53BBBF0", VA = "0x1853BCFF0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x000119B8 File Offset: 0x0000FBB8
		[Token(Token = "0x170005FD")]
		public override long Length
		{
			[Token(Token = "0x600299D")]
			[Address(RVA = "0x53BD890", Offset = "0x53BC490", VA = "0x1853BD890", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x000119D0 File Offset: 0x0000FBD0
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FE")]
		public override long Position
		{
			[Token(Token = "0x600299E")]
			[Address(RVA = "0x53BD8E0", Offset = "0x53BC4E0", VA = "0x1853BD8E0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600299F")]
			[Address(RVA = "0x53BDBC0", Offset = "0x53BC7C0", VA = "0x1853BDBC0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000119E8 File Offset: 0x0000FBE8
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x53BD090", Offset = "0x53BBC90", VA = "0x1853BD090", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00011A00 File Offset: 0x0000FC00
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x53BD120", Offset = "0x53BBD20", VA = "0x1853BD120", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x4F51A80", Offset = "0x4F50680", VA = "0x184F51A80", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x53BD410", Offset = "0x53BC010", VA = "0x1853BD410", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x53BCDC0", Offset = "0x53BB9C0", VA = "0x1853BCDC0")]
		public static byte[] CompressString(string s)
		{
			return null;
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x53BCC40", Offset = "0x53BB840", VA = "0x1853BCC40")]
		public static byte[] CompressBuffer(byte[] b)
		{
			return null;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A6")]
		[Address(RVA = "0x53BD2C0", Offset = "0x53BBEC0", VA = "0x1853BD2C0")]
		public static string UncompressString(byte[] compressed)
		{
			return null;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x53BD170", Offset = "0x53BBD70", VA = "0x1853BD170")]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			return null;
		}

		// Token: 0x04001726 RID: 5926
		[Token(Token = "0x4001726")]
		[FieldOffset(Offset = "0x28")]
		internal ZlibBaseStream _baseStream;

		// Token: 0x04001727 RID: 5927
		[Token(Token = "0x4001727")]
		[FieldOffset(Offset = "0x30")]
		internal Stream _innerStream;

		// Token: 0x04001728 RID: 5928
		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x38")]
		private bool _disposed;
	}
}
