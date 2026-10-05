using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class ZipInputStream : InflaterInputStream
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x4A70030", Offset = "0x4A6EC30", VA = "0x184A70030")]
		public ZipInputStream(Stream baseInputStream)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x4A70140", Offset = "0x4A6ED40", VA = "0x184A70140")]
		public ZipInputStream(Stream baseInputStream, int bufferSize)
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000113")]
		public string Password
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			set
			{
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x17000114")]
		public bool CanDecompressEntry
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x4A70270", Offset = "0x4A6EE70", VA = "0x184A70270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x4A6F070", Offset = "0x4A6DC70", VA = "0x184A6F070")]
		public ZipEntry GetNextEntry()
		{
			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x4A6FC50", Offset = "0x4A6E850", VA = "0x184A6FC50")]
		private void ReadDataDescriptor()
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x4A6EF60", Offset = "0x4A6DB60", VA = "0x184A6EF60")]
		private void CompleteCloseEntry(bool testCrc)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x4A6EC20", Offset = "0x4A6D820", VA = "0x184A6EC20")]
		public void CloseEntry()
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x17000115")]
		public override int Available
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x4A70260", Offset = "0x4A6EE60", VA = "0x184A70260", Slot = "38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x17000116")]
		public override long Length
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x4A70290", Offset = "0x4A6EE90", VA = "0x184A70290", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x4A6FBA0", Offset = "0x4A6E7A0", VA = "0x184A6FBA0", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x4A6FF70", Offset = "0x4A6EB70", VA = "0x184A6FF70")]
		private int ReadingNotAvailable(byte[] destination, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x4A6FFD0", Offset = "0x4A6EBD0", VA = "0x184A6FFD0")]
		private int ReadingNotSupported(byte[] destination, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x4A6F710", Offset = "0x4A6E310", VA = "0x184A6F710")]
		private int InitialRead(byte[] destination, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x4A6FDA0", Offset = "0x4A6E9A0", VA = "0x184A6FDA0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x4A6E650", Offset = "0x4A6D250", VA = "0x184A6E650")]
		private int BodyRead(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x4A6EEB0", Offset = "0x4A6DAB0", VA = "0x184A6EEB0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x50")]
		private ZipInputStream.ReadDataHandler internalReader;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x58")]
		private Crc32 crc;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x60")]
		private ZipEntry entry;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x68")]
		private long size;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x70")]
		private int method;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x74")]
		private int flags;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x78")]
		private string password;

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060004CB RID: 1227
		[Token(Token = "0x200007B")]
		private delegate int ReadDataHandler(byte[] b, int offset, int length);
	}
}
