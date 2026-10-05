using System;
using System.IO;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x2000494")]
	internal sealed class StreamList : Stream
	{
		// Token: 0x06002621 RID: 9761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x539DD80", Offset = "0x539C980", VA = "0x18539DD80")]
		public StreamList(params Stream[] streams)
		{
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000107A0 File Offset: 0x0000E9A0
		[Token(Token = "0x17000537")]
		public override bool CanRead
		{
			[Token(Token = "0x6002622")]
			[Address(RVA = "0x539DDF0", Offset = "0x539C9F0", VA = "0x18539DDF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x000107B8 File Offset: 0x0000E9B8
		[Token(Token = "0x17000538")]
		public override bool CanSeek
		{
			[Token(Token = "0x6002623")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x000107D0 File Offset: 0x0000E9D0
		[Token(Token = "0x17000539")]
		public override bool CanWrite
		{
			[Token(Token = "0x6002624")]
			[Address(RVA = "0x539DE60", Offset = "0x539CA60", VA = "0x18539DE60", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002625")]
		[Address(RVA = "0x539DA00", Offset = "0x539C600", VA = "0x18539DA00", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x000107E8 File Offset: 0x0000E9E8
		[Token(Token = "0x1700053A")]
		public override long Length
		{
			[Token(Token = "0x6002626")]
			[Address(RVA = "0x539DED0", Offset = "0x539CAD0", VA = "0x18539DED0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x6002627")]
		[Address(RVA = "0x539DAA0", Offset = "0x539C6A0", VA = "0x18539DAA0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002628")]
		[Address(RVA = "0x539DD30", Offset = "0x539C930", VA = "0x18539DD30", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x539DCB0", Offset = "0x539C8B0", VA = "0x18539DCB0")]
		public void Write(string str)
		{
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262A")]
		[Address(RVA = "0x539D8B0", Offset = "0x539C4B0", VA = "0x18539D8B0", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x00010818 File Offset: 0x0000EA18
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053B")]
		public override long Position
		{
			[Token(Token = "0x600262B")]
			[Address(RVA = "0x539DF90", Offset = "0x539CB90", VA = "0x18539DF90", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600262C")]
			[Address(RVA = "0x539DFF0", Offset = "0x539CBF0", VA = "0x18539DFF0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00010830 File Offset: 0x0000EA30
		[Token(Token = "0x600262D")]
		[Address(RVA = "0x539DBC0", Offset = "0x539C7C0", VA = "0x18539DBC0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262E")]
		[Address(RVA = "0x539DC50", Offset = "0x539C850", VA = "0x18539DC50", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0x28")]
		private Stream[] Streams;

		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		[FieldOffset(Offset = "0x30")]
		private int CurrentIdx;
	}
}
