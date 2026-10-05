using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	public abstract class BaseOutputStream : Stream
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x170000BF")]
		public sealed override bool CanRead
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x170000C0")]
		public sealed override bool CanSeek
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x170000C1")]
		public sealed override bool CanWrite
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x3146BB0", Offset = "0x31457B0", VA = "0x183146BB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x545A320", Offset = "0x5458F20", VA = "0x18545A320", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x170000C2")]
		public sealed override long Length
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x545A820", Offset = "0x5459420", VA = "0x18545A820", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00005430 File Offset: 0x00003630
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C3")]
		public sealed override long Position
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x545A870", Offset = "0x5459470", VA = "0x18545A870", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x545A8C0", Offset = "0x54594C0", VA = "0x18545A8C0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x545A640", Offset = "0x5459240", VA = "0x18545A640", Slot = "32")]
		public sealed override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x545A690", Offset = "0x5459290", VA = "0x18545A690", Slot = "30")]
		public sealed override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x545A6E0", Offset = "0x54592E0", VA = "0x18545A6E0", Slot = "31")]
		public sealed override void SetLength(long value)
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x545A730", Offset = "0x5459330", VA = "0x18545A730", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x5267170", Offset = "0x5265D70", VA = "0x185267170", Slot = "38")]
		public virtual void Write(params byte[] buffer)
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x545A7D0", Offset = "0x54593D0", VA = "0x18545A7D0")]
		protected BaseOutputStream()
		{
		}

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x28")]
		private bool closed;
	}
}
