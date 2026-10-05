using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	internal class NetworkStreamWrapper : Stream
	{
		// Token: 0x06001303 RID: 4867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001303")]
		[Address(RVA = "0x51B46D0", Offset = "0x51B32D0", VA = "0x1851B46D0")]
		internal NetworkStreamWrapper(TcpClient client)
		{
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x170003F0")]
		protected bool UsingSecureStream
		{
			[Token(Token = "0x6001304")]
			[Address(RVA = "0x51B48C0", Offset = "0x51B34C0", VA = "0x1851B48C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F1")]
		internal IPAddress ServerAddress
		{
			[Token(Token = "0x6001305")]
			[Address(RVA = "0x51B4760", Offset = "0x51B3360", VA = "0x1851B4760")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F2")]
		internal Socket Socket
		{
			[Token(Token = "0x6001306")]
			[Address(RVA = "0x51B48A0", Offset = "0x51B34A0", VA = "0x1851B48A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F3")]
		internal NetworkStream NetworkStream
		{
			[Token(Token = "0x6001307")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001308")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x170003F4")]
		public override bool CanRead
		{
			[Token(Token = "0x6001309")]
			[Address(RVA = "0x4A6E470", Offset = "0x4A6D070", VA = "0x184A6E470", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x170003F5")]
		public override bool CanSeek
		{
			[Token(Token = "0x600130A")]
			[Address(RVA = "0x4A6E4C0", Offset = "0x4A6D0C0", VA = "0x184A6E4C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x170003F6")]
		public override bool CanWrite
		{
			[Token(Token = "0x600130B")]
			[Address(RVA = "0x4A6E510", Offset = "0x4A6D110", VA = "0x184A6E510", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x170003F7")]
		public override bool CanTimeout
		{
			[Token(Token = "0x600130C")]
			[Address(RVA = "0x51A4100", Offset = "0x51A2D00", VA = "0x1851A4100", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x00009408 File Offset: 0x00007608
		// (set) Token: 0x0600130E RID: 4878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F8")]
		public override int ReadTimeout
		{
			[Token(Token = "0x600130D")]
			[Address(RVA = "0x51A4150", Offset = "0x51A2D50", VA = "0x1851A4150", Slot = "14")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600130E")]
			[Address(RVA = "0x51A41F0", Offset = "0x51A2DF0", VA = "0x1851A41F0", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x00009420 File Offset: 0x00007620
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F9")]
		public override int WriteTimeout
		{
			[Token(Token = "0x600130F")]
			[Address(RVA = "0x51A41A0", Offset = "0x51A2DA0", VA = "0x1851A41A0", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001310")]
			[Address(RVA = "0x51A4240", Offset = "0x51A2E40", VA = "0x1851A4240", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x170003FA")]
		public override long Length
		{
			[Token(Token = "0x6001311")]
			[Address(RVA = "0x4A6E560", Offset = "0x4A6D160", VA = "0x184A6E560", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00009450 File Offset: 0x00007650
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FB")]
		public override long Position
		{
			[Token(Token = "0x6001312")]
			[Address(RVA = "0x4A6E5B0", Offset = "0x4A6D1B0", VA = "0x184A6E5B0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001313")]
			[Address(RVA = "0x4A6E600", Offset = "0x4A6D200", VA = "0x184A6E600", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x4A6D4D0", Offset = "0x4A6C0D0", VA = "0x184A6D4D0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6001315")]
		[Address(RVA = "0x4A6D450", Offset = "0x4A6C050", VA = "0x184A6D450", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x4A6E2C0", Offset = "0x4A6CEC0", VA = "0x184A6E2C0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001317")]
		[Address(RVA = "0x51B4470", Offset = "0x51B3070", VA = "0x1851B4470", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001318")]
		[Address(RVA = "0x51B43D0", Offset = "0x51B2FD0", VA = "0x1851B43D0")]
		internal void CloseSocket()
		{
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001319")]
		[Address(RVA = "0x51B4430", Offset = "0x51B3030", VA = "0x1851B4430")]
		public void Close(int timeout)
		{
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x51B4330", Offset = "0x51B2F30", VA = "0x1851B4330", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x51B4540", Offset = "0x51B3140", VA = "0x1851B4540", Slot = "23")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x506A550", Offset = "0x5069150", VA = "0x18506A550", Slot = "24")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131D")]
		[Address(RVA = "0x51B4380", Offset = "0x51B2F80", VA = "0x1851B4380", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x51B45A0", Offset = "0x51B31A0", VA = "0x1851B45A0", Slot = "27")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x51B4650", Offset = "0x51B3250", VA = "0x1851B4650", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001320")]
		[Address(RVA = "0x4A6CFF0", Offset = "0x4A6BBF0", VA = "0x184A6CFF0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001321")]
		[Address(RVA = "0x51B45F0", Offset = "0x51B31F0", VA = "0x1851B45F0", Slot = "21")]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x4A6D540", Offset = "0x4A6C140", VA = "0x184A6D540", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001323")]
		[Address(RVA = "0x51A3A80", Offset = "0x51A2680", VA = "0x1851A3A80")]
		internal void SetSocketTimeoutOption(int timeout)
		{
		}

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x28")]
		private TcpClient _client;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x30")]
		private NetworkStream _networkStream;
	}
}
