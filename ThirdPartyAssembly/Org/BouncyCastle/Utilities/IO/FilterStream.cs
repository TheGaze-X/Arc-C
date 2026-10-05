using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	public class FilterStream : Stream
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x545DAB0", Offset = "0x545C6B0", VA = "0x18545DAB0")]
		public FilterStream(Stream s)
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x170000C4")]
		public override bool CanRead
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x4A3F730", Offset = "0x4A3E330", VA = "0x184A3F730", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x170000C5")]
		public override bool CanSeek
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x4FF9140", Offset = "0x4FF7D40", VA = "0x184FF9140", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x170000C6")]
		public override bool CanWrite
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x4A5EE40", Offset = "0x4A5DA40", VA = "0x184A5EE40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x170000C7")]
		public override long Length
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x4F52370", Offset = "0x4F50F70", VA = "0x184F52370", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x000054D8 File Offset: 0x000036D8
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C8")]
		public override long Position
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x4A3F790", Offset = "0x4A3E390", VA = "0x184A3F790", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x4FF9190", Offset = "0x4FF7D90", VA = "0x184FF9190", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x545DA50", Offset = "0x545C650", VA = "0x18545DA50", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x4A3E4A0", Offset = "0x4A3D0A0", VA = "0x184A3E4A0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x4FF8FE0", Offset = "0x4FF7BE0", VA = "0x184FF8FE0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x4F51A80", Offset = "0x4F50680", VA = "0x184F51A80", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x4FF8F60", Offset = "0x4FF7B60", VA = "0x184FF8F60", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x4E63090", Offset = "0x4E61C90", VA = "0x184E63090", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x4A5ED50", Offset = "0x4A5D950", VA = "0x184A5ED50", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x4FF9050", Offset = "0x4FF7C50", VA = "0x184FF9050", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x28")]
		protected readonly Stream s;
	}
}
