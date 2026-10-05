using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class TarInputStream : Stream
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4A56ED0", Offset = "0x4A55AD0", VA = "0x184A56ED0")]
		public TarInputStream(Stream inputStream)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4A57030", Offset = "0x4A55C30", VA = "0x184A57030")]
		public TarInputStream(Stream inputStream, int blockFactor)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002E38 File Offset: 0x00001038
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x4A57120", Offset = "0x4A55D20", VA = "0x184A57120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x4A571E0", Offset = "0x4A55DE0", VA = "0x184A571E0")]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x1700006E")]
		public override bool CanRead
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x4A570D0", Offset = "0x4A55CD0", VA = "0x184A570D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x1700006F")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x17000070")]
		public override bool CanWrite
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x17000071")]
		public override long Length
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x4A57140", Offset = "0x4A55D40", VA = "0x184A57140", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public override long Position
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x4A57190", Offset = "0x4A55D90", VA = "0x184A57190", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x4A57200", Offset = "0x4A55E00", VA = "0x184A57200", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4A560E0", Offset = "0x4A54CE0", VA = "0x184A560E0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4A56C00", Offset = "0x4A55800", VA = "0x184A56C00", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x4A56C60", Offset = "0x4A55860", VA = "0x184A56C60", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4A56E70", Offset = "0x4A55A70", VA = "0x184A56E70", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4A56E10", Offset = "0x4A55A10", VA = "0x184A56E10", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4A56870", Offset = "0x4A55470", VA = "0x184A56870", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4A56920", Offset = "0x4A55520", VA = "0x184A56920", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4A55FD0", Offset = "0x4A54BD0", VA = "0x184A55FD0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
		public void SetEntryFactory(TarInputStream.IEntryFactory factory)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x17000073")]
		public int RecordSize
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x4A56850", Offset = "0x4A55450", VA = "0x184A56850")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x4A56850", Offset = "0x4A55450", VA = "0x184A56850")]
		[Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return 0;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x17000074")]
		public long Available
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x4A570C0", Offset = "0x4A55CC0", VA = "0x184A570C0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4A56D70", Offset = "0x4A55970", VA = "0x184A56D70")]
		public void Skip(long skipCount)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x17000075")]
		public bool IsMarkSupported
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Mark(int markLimit)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Reset()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4A56120", Offset = "0x4A54D20", VA = "0x184A56120")]
		public TarEntry GetNextEntry()
		{
			return null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4A55FF0", Offset = "0x4A54BF0", VA = "0x184A55FF0")]
		public void CopyEntryContents(Stream outputStream)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4A56CC0", Offset = "0x4A558C0", VA = "0x184A56CC0")]
		private void SkipToNextEntry()
		{
		}

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x28")]
		protected bool hasHitEOF;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x30")]
		protected long entrySize;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x38")]
		protected long entryOffset;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x40")]
		protected byte[] readBuffer;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x48")]
		protected TarBuffer tarBuffer;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x50")]
		private TarEntry currentEntry;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x58")]
		protected TarInputStream.IEntryFactory entryFactory;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x60")]
		private readonly Stream inputStream;

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		public interface IEntryFactory
		{
			// Token: 0x06000221 RID: 545
			[Token(Token = "0x6000221")]
			TarEntry CreateEntry(string name);

			// Token: 0x06000222 RID: 546
			[Token(Token = "0x6000222")]
			TarEntry CreateEntryFromFile(string fileName);

			// Token: 0x06000223 RID: 547
			[Token(Token = "0x6000223")]
			TarEntry CreateEntry(byte[] headerBuffer);
		}

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		public class EntryFactoryAdapter : TarInputStream.IEntryFactory
		{
			// Token: 0x06000224 RID: 548 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x4A49D50", Offset = "0x4A48950", VA = "0x184A49D50", Slot = "4")]
			public TarEntry CreateEntry(string name)
			{
				return null;
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x4A49C80", Offset = "0x4A48880", VA = "0x184A49C80", Slot = "5")]
			public TarEntry CreateEntryFromFile(string fileName)
			{
				return null;
			}

			// Token: 0x06000226 RID: 550 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x4A49CF0", Offset = "0x4A488F0", VA = "0x184A49CF0", Slot = "6")]
			public TarEntry CreateEntry(byte[] headerBuffer)
			{
				return null;
			}

			// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EntryFactoryAdapter()
			{
			}
		}
	}
}
