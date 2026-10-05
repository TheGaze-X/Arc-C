using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class TarOutputStream : Stream
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x4A58380", Offset = "0x4A56F80", VA = "0x184A58380")]
		public TarOutputStream(Stream outputStream)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4A58250", Offset = "0x4A56E50", VA = "0x184A58250")]
		public TarOutputStream(Stream outputStream, int blockFactor)
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002F70 File Offset: 0x00001170
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x4A585B0", Offset = "0x4A571B0", VA = "0x184A585B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x4A58670", Offset = "0x4A57270", VA = "0x184A58670")]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x17000077")]
		public override bool CanRead
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x4A584B0", Offset = "0x4A570B0", VA = "0x184A584B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x17000078")]
		public override bool CanSeek
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x4A58500", Offset = "0x4A57100", VA = "0x184A58500", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x17000079")]
		public override bool CanWrite
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x4A58550", Offset = "0x4A57150", VA = "0x184A58550", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x1700007A")]
		public override long Length
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x4A585D0", Offset = "0x4A571D0", VA = "0x184A585D0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00002FE8 File Offset: 0x000011E8
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		public override long Position
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x4A58620", Offset = "0x4A57220", VA = "0x184A58620", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x4A58690", Offset = "0x4A57290", VA = "0x184A58690", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4A57CF0", Offset = "0x4A568F0", VA = "0x184A57CF0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x4A57D60", Offset = "0x4A56960", VA = "0x184A57D60", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x4A57C20", Offset = "0x4A56820", VA = "0x184A57C20", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x4A57C70", Offset = "0x4A56870", VA = "0x184A57C70", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x4A57650", Offset = "0x4A56250", VA = "0x184A57650", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x4A57500", Offset = "0x4A56100", VA = "0x184A57500")]
		public void Finish()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x4A57380", Offset = "0x4A55F80", VA = "0x184A57380", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x1700007C")]
		public int RecordSize
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x4A57690", Offset = "0x4A56290", VA = "0x184A57690")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x4A57690", Offset = "0x4A56290", VA = "0x184A57690")]
		[Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return 0;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x1700007D")]
		private bool IsEntryOpen
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x4A585A0", Offset = "0x4A571A0", VA = "0x184A585A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x4A576B0", Offset = "0x4A562B0", VA = "0x184A576B0")]
		public void PutNextEntry(TarEntry entry)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x4A57260", Offset = "0x4A55E60", VA = "0x184A57260")]
		public void CloseEntry()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4A57DB0", Offset = "0x4A569B0", VA = "0x184A57DB0", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4A57EA0", Offset = "0x4A56AA0", VA = "0x184A57EA0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x4A57E60", Offset = "0x4A56A60", VA = "0x184A57E60")]
		private void WriteEofBlock()
		{
		}

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x28")]
		private long currBytes;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x30")]
		private int assemblyBufferLength;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x34")]
		private bool isClosed;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x38")]
		protected long currSize;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x40")]
		protected byte[] blockBuffer;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x48")]
		protected byte[] assemblyBuffer;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x50")]
		protected TarBuffer buffer;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x58")]
		protected Stream outputStream;
	}
}
