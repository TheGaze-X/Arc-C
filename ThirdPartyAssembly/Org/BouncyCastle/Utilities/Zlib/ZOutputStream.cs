using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	public class ZOutputStream : Stream
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x546B030", Offset = "0x5469C30", VA = "0x18546B030")]
		private static ZStream GetDefaultZStream(bool nowrap)
		{
			return null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x546B9C0", Offset = "0x546A5C0", VA = "0x18546B9C0")]
		public ZOutputStream(Stream output)
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x546B850", Offset = "0x546A450", VA = "0x18546B850")]
		public ZOutputStream(Stream output, bool nowrap)
		{
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x546B720", Offset = "0x546A320", VA = "0x18546B720")]
		public ZOutputStream(Stream output, ZStream z)
		{
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x546B450", Offset = "0x546A050", VA = "0x18546B450")]
		public ZOutputStream(Stream output, int level)
		{
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x546B5E0", Offset = "0x546A1E0", VA = "0x18546B5E0")]
		public ZOutputStream(Stream output, int level, bool nowrap)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x170000B2")]
		public sealed override bool CanRead
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x170000B3")]
		public sealed override bool CanSeek
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x170000B4")]
		public sealed override bool CanWrite
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x546BB20", Offset = "0x546A720", VA = "0x18546BB20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x546AC30", Offset = "0x5469830", VA = "0x18546AC30", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x546AC60", Offset = "0x5469860", VA = "0x18546AC60")]
		private void DoClose()
		{
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x546AD00", Offset = "0x5469900", VA = "0x18546AD00", Slot = "38")]
		public virtual void End()
		{
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x546ADD0", Offset = "0x54699D0", VA = "0x18546ADD0", Slot = "39")]
		public virtual void Finish()
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x546AFF0", Offset = "0x5469BF0", VA = "0x18546AFF0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00004FE0 File Offset: 0x000031E0
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B5")]
		public virtual int FlushMode
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700", Slot = "40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0", Slot = "41")]
			set
			{
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x170000B6")]
		public sealed override long Length
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x546BB30", Offset = "0x546A730", VA = "0x18546BB30", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00005010 File Offset: 0x00003210
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B7")]
		public sealed override long Position
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x546BB80", Offset = "0x546A780", VA = "0x18546BB80", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x546BBD0", Offset = "0x546A7D0", VA = "0x18546BBD0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x546B0A0", Offset = "0x5469CA0", VA = "0x18546B0A0", Slot = "32")]
		public sealed override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x546B0F0", Offset = "0x5469CF0", VA = "0x18546B0F0", Slot = "30")]
		public sealed override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x546B140", Offset = "0x5469D40", VA = "0x18546B140", Slot = "31")]
		public sealed override void SetLength(long value)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x170000B8")]
		public virtual long TotalIn
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x4DF4BF0", Offset = "0x4DF37F0", VA = "0x184DF4BF0", Slot = "42")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x170000B9")]
		public virtual long TotalOut
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x4DF4C50", Offset = "0x4DF3850", VA = "0x184DF4C50", Slot = "43")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x546B210", Offset = "0x5469E10", VA = "0x18546B210", Slot = "35")]
		public override void Write(byte[] b, int off, int len)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x546B190", Offset = "0x5469D90", VA = "0x18546B190", Slot = "37")]
		public override void WriteByte(byte b)
		{
		}

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		private const int BufferSize = 512;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x28")]
		protected ZStream z;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x30")]
		protected int flushLevel;

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x38")]
		protected byte[] buf;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x40")]
		protected byte[] buf1;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x48")]
		protected bool compress;

		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x50")]
		protected Stream output;

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x58")]
		protected bool closed;
	}
}
