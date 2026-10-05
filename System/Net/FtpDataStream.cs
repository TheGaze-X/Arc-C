using System;
using System.IO;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	internal class FtpDataStream : Stream, ICloseEx
	{
		// Token: 0x0600129E RID: 4766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x51A3FA0", Offset = "0x51A2BA0", VA = "0x1851A3FA0")]
		internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly)
		{
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x51A3440", Offset = "0x51A2040", VA = "0x1851A3440", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x51A3B10", Offset = "0x51A2710", VA = "0x1851A3B10", Slot = "38")]
		private void CloseEx(CloseExState closeState)
		{
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x51A33F0", Offset = "0x51A1FF0", VA = "0x1851A33F0")]
		private void CheckError()
		{
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x170003CB")]
		public override bool CanRead
		{
			[Token(Token = "0x60012A2")]
			[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x170003CC")]
		public override bool CanSeek
		{
			[Token(Token = "0x60012A3")]
			[Address(RVA = "0x4A6E4C0", Offset = "0x4A6D0C0", VA = "0x184A6E4C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x170003CD")]
		public override bool CanWrite
		{
			[Token(Token = "0x60012A4")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x170003CE")]
		public override long Length
		{
			[Token(Token = "0x60012A5")]
			[Address(RVA = "0x4A6E560", Offset = "0x4A6D160", VA = "0x184A6E560", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00009120 File Offset: 0x00007320
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CF")]
		public override long Position
		{
			[Token(Token = "0x60012A6")]
			[Address(RVA = "0x4A6E5B0", Offset = "0x4A6D1B0", VA = "0x184A6E5B0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60012A7")]
			[Address(RVA = "0x4A6E600", Offset = "0x4A6D200", VA = "0x184A6E600", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x51A39B0", Offset = "0x51A25B0", VA = "0x1851A39B0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x51A3890", Offset = "0x51A2490", VA = "0x1851A3890", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x51A3EB0", Offset = "0x51A2AB0", VA = "0x1851A3EB0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x51A2FE0", Offset = "0x51A1BE0", VA = "0x1851A2FE0")]
		private void AsyncReadCallback(IAsyncResult ar)
		{
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x51A31B0", Offset = "0x51A1DB0", VA = "0x1851A31B0", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x51A3500", Offset = "0x51A2100", VA = "0x1851A3500", Slot = "23")]
		public override int EndRead(IAsyncResult ar)
		{
			return 0;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0x51A3330", Offset = "0x51A1F30", VA = "0x1851A3330", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x51A3780", Offset = "0x51A2380", VA = "0x1851A3780", Slot = "27")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x4A6CFF0", Offset = "0x4A6BBF0", VA = "0x184A6CFF0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x4A6D540", Offset = "0x4A6C140", VA = "0x184A6D540", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x170003D0")]
		public override bool CanTimeout
		{
			[Token(Token = "0x60012B2")]
			[Address(RVA = "0x51A4100", Offset = "0x51A2D00", VA = "0x1851A4100", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00009198 File Offset: 0x00007398
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D1")]
		public override int ReadTimeout
		{
			[Token(Token = "0x60012B3")]
			[Address(RVA = "0x51A4150", Offset = "0x51A2D50", VA = "0x1851A4150", Slot = "14")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60012B4")]
			[Address(RVA = "0x51A41F0", Offset = "0x51A2DF0", VA = "0x1851A41F0", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x000091B0 File Offset: 0x000073B0
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D2")]
		public override int WriteTimeout
		{
			[Token(Token = "0x60012B5")]
			[Address(RVA = "0x51A41A0", Offset = "0x51A2DA0", VA = "0x1851A41A0", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60012B6")]
			[Address(RVA = "0x51A4240", Offset = "0x51A2E40", VA = "0x1851A4240", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x51A3A80", Offset = "0x51A2680", VA = "0x1851A3A80")]
		internal void SetSocketTimeoutOption(int timeout)
		{
		}

		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		[FieldOffset(Offset = "0x28")]
		private FtpWebRequest _request;

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x30")]
		private NetworkStream _networkStream;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x38")]
		private bool _writeable;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x39")]
		private bool _readable;

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x3A")]
		private bool _isFullyRead;

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x3B")]
		private bool _closing;
	}
}
