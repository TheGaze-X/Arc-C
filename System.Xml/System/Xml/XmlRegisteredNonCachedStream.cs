using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	internal class XmlRegisteredNonCachedStream : Stream
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x4FF90A0", Offset = "0x4FF7CA0", VA = "0x184FF90A0")]
		internal XmlRegisteredNonCachedStream(Stream stream, XmlDownloadManager downloadManager, string host)
		{
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x4FF8ED0", Offset = "0x4FF7AD0", VA = "0x184FF8ED0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x4FF8CF0", Offset = "0x4FF78F0", VA = "0x184FF8CF0", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x4FF8C50", Offset = "0x4FF7850", VA = "0x184FF8C50", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x4FF8CA0", Offset = "0x4FF78A0", VA = "0x184FF8CA0", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x4FF8E20", Offset = "0x4FF7A20", VA = "0x184FF8E20", Slot = "23")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x4FF8E80", Offset = "0x4FF7A80", VA = "0x184FF8E80", Slot = "27")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x4A3E4A0", Offset = "0x4A3D0A0", VA = "0x184A3E4A0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x4FF8F60", Offset = "0x4FF7B60", VA = "0x184FF8F60", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x4E63090", Offset = "0x4E61C90", VA = "0x184E63090", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x4FF8FE0", Offset = "0x4FF7BE0", VA = "0x184FF8FE0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4F51A80", Offset = "0x4F50680", VA = "0x184F51A80", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x4A5ED50", Offset = "0x4A5D950", VA = "0x184A5ED50", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x4FF9050", Offset = "0x4FF7C50", VA = "0x184FF9050", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x170001B9")]
		public override bool CanRead
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x4A3F730", Offset = "0x4A3E330", VA = "0x184A3F730", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x170001BA")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x4FF9140", Offset = "0x4FF7D40", VA = "0x184FF9140", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x170001BB")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x4A5EE40", Offset = "0x4A5DA40", VA = "0x184A5EE40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x170001BC")]
		public override long Length
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x4F52370", Offset = "0x4F50F70", VA = "0x184F52370", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00004290 File Offset: 0x00002490
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BD")]
		public override long Position
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x4A3F790", Offset = "0x4A3E390", VA = "0x184A3F790", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x4FF9190", Offset = "0x4FF7D90", VA = "0x184FF9190", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x28")]
		protected Stream stream;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x30")]
		private XmlDownloadManager downloadManager;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x38")]
		private string host;
	}
}
