using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public class TarBuffer
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x1700004E")]
		public int RecordSize
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000194")]
		[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
		[Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return 0;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x1700004F")]
		public int BlockFactor
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
		[Obsolete("Use BlockFactor property instead")]
		public int GetBlockFactor()
		{
			return 0;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x4A518B0", Offset = "0x4A504B0", VA = "0x184A518B0")]
		protected TarBuffer()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4A50840", Offset = "0x4A4F440", VA = "0x184A50840")]
		public static TarBuffer CreateInputTarBuffer(Stream inputStream)
		{
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4A50940", Offset = "0x4A4F540", VA = "0x184A50940")]
		public static TarBuffer CreateInputTarBuffer(Stream inputStream, int blockFactor)
		{
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4A50AB0", Offset = "0x4A4F6B0", VA = "0x184A50AB0")]
		public static TarBuffer CreateOutputTarBuffer(Stream outputStream)
		{
			return null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4A50B30", Offset = "0x4A4F730", VA = "0x184A50B30")]
		public static TarBuffer CreateOutputTarBuffer(Stream outputStream, int blockFactor)
		{
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x4A50D00", Offset = "0x4A4F900", VA = "0x184A50D00")]
		private void Initialize(int archiveBlockFactor)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x4A50D80", Offset = "0x4A4F980", VA = "0x184A50D80")]
		[Obsolete("Use IsEndOfArchiveBlock instead")]
		public bool IsEOFBlock(byte[] block)
		{
			return default(bool);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x4A50E80", Offset = "0x4A4FA80", VA = "0x184A50E80")]
		public static bool IsEndOfArchiveBlock(byte[] block)
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4A511C0", Offset = "0x4A4FDC0", VA = "0x184A511C0")]
		public void SkipBlock()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4A50F80", Offset = "0x4A4FB80", VA = "0x184A50F80")]
		public byte[] ReadBlock()
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4A510C0", Offset = "0x4A4FCC0", VA = "0x184A510C0")]
		private bool ReadRecord()
		{
			return default(bool);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x17000050")]
		public int CurrentBlock
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			set
			{
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
		[Obsolete("Use CurrentBlock property instead")]
		public int GetCurrentBlockNum()
		{
			return 0;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x17000052")]
		public int CurrentRecord
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
		[Obsolete("Use CurrentRecord property instead")]
		public int GetCurrentRecordNum()
		{
			return 0;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4A51290", Offset = "0x4A4FE90", VA = "0x184A51290")]
		public void WriteBlock(byte[] block)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4A51460", Offset = "0x4A50060", VA = "0x184A51460")]
		public void WriteBlock(byte[] buffer, int offset)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4A517A0", Offset = "0x4A503A0", VA = "0x184A517A0")]
		private void WriteRecord()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4A516D0", Offset = "0x4A502D0", VA = "0x184A516D0")]
		private void WriteFinalRecord()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4A50730", Offset = "0x4A4F330", VA = "0x184A50730")]
		public void Close()
		{
		}

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		public const int BlockSize = 512;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		public const int DefaultBlockFactor = 20;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		public const int DefaultRecordSize = 10240;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		private Stream inputStream;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		private Stream outputStream;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		private byte[] recordBuffer;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x28")]
		private int currentBlockIndex;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x2C")]
		private int currentRecordIndex;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x30")]
		private int recordSize;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x34")]
		private int blockFactor;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x38")]
		private bool isStreamOwner_;
	}
}
