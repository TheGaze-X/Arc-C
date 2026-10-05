using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	internal sealed class TailStream : System.IO.Stream
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x4B37E40", Offset = "0x4B36A40", VA = "0x184B37E40")]
		public TailStream(int bufferSize)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x4B244E0", Offset = "0x4B230E0", VA = "0x184B244E0")]
		public void Clear()
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x4B37AC0", Offset = "0x4B366C0", VA = "0x184B37AC0", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002B7")]
		public byte[] Buffer
		{
			[Token(Token = "0x600197A")]
			[Address(RVA = "0x4B37ED0", Offset = "0x4B36AD0", VA = "0x184B37ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x00011C10 File Offset: 0x0000FE10
		[Token(Token = "0x170002B8")]
		public override bool CanRead
		{
			[Token(Token = "0x600197B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00011C28 File Offset: 0x0000FE28
		[Token(Token = "0x170002B9")]
		public override bool CanSeek
		{
			[Token(Token = "0x600197C")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x00011C40 File Offset: 0x0000FE40
		[Token(Token = "0x170002BA")]
		public override bool CanWrite
		{
			[Token(Token = "0x600197D")]
			[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x170002BB")]
		public override long Length
		{
			[Token(Token = "0x600197E")]
			[Address(RVA = "0x4B37F50", Offset = "0x4B36B50", VA = "0x184B37F50", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x00011C70 File Offset: 0x0000FE70
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		public override long Position
		{
			[Token(Token = "0x600197F")]
			[Address(RVA = "0x4B37FC0", Offset = "0x4B36BC0", VA = "0x184B37FC0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001980")]
			[Address(RVA = "0x4B38030", Offset = "0x4B36C30", VA = "0x184B38030", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00011C88 File Offset: 0x0000FE88
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x4B37BE0", Offset = "0x4B367E0", VA = "0x184B37BE0", Slot = "30")]
		public override long Seek(long offset, System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x4B37C50", Offset = "0x4B36850", VA = "0x184B37C50", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x4B37B70", Offset = "0x4B36770", VA = "0x184B37B70", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x4B37CC0", Offset = "0x4B368C0", VA = "0x184B37CC0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _Buffer;

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x30")]
		private int _BufferSize;

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x34")]
		private int _BufferIndex;

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000DE8")]
		[FieldOffset(Offset = "0x38")]
		private bool _BufferFull;
	}
}
