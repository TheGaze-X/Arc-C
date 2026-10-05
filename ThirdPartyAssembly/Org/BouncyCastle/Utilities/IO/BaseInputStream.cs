using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	public abstract class BaseInputStream : Stream
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x170000BA")]
		public sealed override bool CanRead
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x3146BB0", Offset = "0x31457B0", VA = "0x183146BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x170000BB")]
		public sealed override bool CanSeek
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x170000BC")]
		public sealed override bool CanWrite
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x545A320", Offset = "0x5458F20", VA = "0x18545A320", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public sealed override void Flush()
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x170000BD")]
		public sealed override long Length
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x545A550", Offset = "0x5459150", VA = "0x18545A550", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00005388 File Offset: 0x00003588
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BE")]
		public sealed override long Position
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x545A5A0", Offset = "0x54591A0", VA = "0x18545A5A0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x545A5F0", Offset = "0x54591F0", VA = "0x18545A5F0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x545A330", Offset = "0x5458F30", VA = "0x18545A330", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x545A410", Offset = "0x5459010", VA = "0x18545A410", Slot = "30")]
		public sealed override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x545A460", Offset = "0x5459060", VA = "0x18545A460", Slot = "31")]
		public sealed override void SetLength(long value)
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x545A4B0", Offset = "0x54590B0", VA = "0x18545A4B0", Slot = "35")]
		public sealed override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x545A500", Offset = "0x5459100", VA = "0x18545A500")]
		protected BaseInputStream()
		{
		}

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x28")]
		private bool closed;
	}
}
