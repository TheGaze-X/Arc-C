using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000331 RID: 817
	[Token(Token = "0x2000331")]
	internal class ResponseStream : Stream
	{
		// Token: 0x060016C9 RID: 5833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x50896D0", Offset = "0x50882D0", VA = "0x1850896D0")]
		internal ResponseStream(Stream stream, HttpListenerResponse response, bool ignore_errors)
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x170004F4")]
		public override bool CanRead
		{
			[Token(Token = "0x60016CA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x170004F5")]
		public override bool CanSeek
		{
			[Token(Token = "0x60016CB")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x170004F6")]
		public override bool CanWrite
		{
			[Token(Token = "0x60016CC")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x170004F7")]
		public override long Length
		{
			[Token(Token = "0x60016CD")]
			[Address(RVA = "0x5089770", Offset = "0x5088370", VA = "0x185089770", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0000A728 File Offset: 0x00008928
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F8")]
		public override long Position
		{
			[Token(Token = "0x60016CE")]
			[Address(RVA = "0x50897C0", Offset = "0x50883C0", VA = "0x1850897C0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60016CF")]
			[Address(RVA = "0x5089810", Offset = "0x5088410", VA = "0x185089810", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x5088B30", Offset = "0x5087730", VA = "0x185088B30", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x5089080", Offset = "0x5087C80", VA = "0x185089080")]
		private MemoryStream GetHeaders(bool closing)
		{
			return null;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x5088FA0", Offset = "0x5087BA0", VA = "0x185088FA0")]
		private static byte[] GetChunkSizeBytes(int size, bool final)
		{
			return null;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x50891E0", Offset = "0x5087DE0", VA = "0x1850891E0")]
		internal void InternalWrite(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x5089340", Offset = "0x5087F40", VA = "0x185089340", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x5088850", Offset = "0x5087450", VA = "0x185088850", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			return null;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x5088D80", Offset = "0x5087980", VA = "0x185088D80", Slot = "27")]
		public override void EndWrite(IAsyncResult ares)
		{
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x5089250", Offset = "0x5087E50", VA = "0x185089250", Slot = "32")]
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x5088800", Offset = "0x5087400", VA = "0x185088800", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			return null;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x5088D30", Offset = "0x5087930", VA = "0x185088D30", Slot = "23")]
		public override int EndRead(IAsyncResult ares)
		{
			return 0;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x50892A0", Offset = "0x5087EA0", VA = "0x1850892A0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x50892F0", Offset = "0x5087EF0", VA = "0x1850892F0", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HttpListenerResponse response;

		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool ignore_errors;

		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool disposed;

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool trailer_sent;

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Stream stream;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte[] crlf;
	}
}
