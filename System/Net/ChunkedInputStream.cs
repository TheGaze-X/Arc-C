using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	internal class ChunkedInputStream : RequestStream
	{
		// Token: 0x06001532 RID: 5426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x506A1B0", Offset = "0x5068DB0", VA = "0x18506A1B0")]
		public ChunkedInputStream(HttpListenerContext context, Stream stream, byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00009E88 File Offset: 0x00008088
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x506A100", Offset = "0x5068D00", VA = "0x18506A100", Slot = "32")]
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x5069750", Offset = "0x5068350", VA = "0x185069750", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			return null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x5069DE0", Offset = "0x50689E0", VA = "0x185069DE0")]
		private void OnRead(IAsyncResult base_ares)
		{
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x5069B90", Offset = "0x5068790", VA = "0x185069B90", Slot = "23")]
		public override int EndRead(IAsyncResult ares)
		{
			return 0;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x5069B70", Offset = "0x5068770", VA = "0x185069B70", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool disposed;

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MonoChunkParser decoder;

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private HttpListenerContext context;

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool no_more_data;

		// Token: 0x02000304 RID: 772
		[Token(Token = "0x2000304")]
		private class ReadBufferState
		{
			// Token: 0x06001538 RID: 5432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001538")]
			[Address(RVA = "0x50812A0", Offset = "0x507FEA0", VA = "0x1850812A0")]
			public ReadBufferState(byte[] buffer, int offset, int count, HttpStreamAsyncResult ares)
			{
			}

			// Token: 0x04000B9B RID: 2971
			[Token(Token = "0x4000B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public byte[] Buffer;

			// Token: 0x04000B9C RID: 2972
			[Token(Token = "0x4000B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Offset;

			// Token: 0x04000B9D RID: 2973
			[Token(Token = "0x4000B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int Count;

			// Token: 0x04000B9E RID: 2974
			[Token(Token = "0x4000B9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int InitialCount;

			// Token: 0x04000B9F RID: 2975
			[Token(Token = "0x4000B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HttpStreamAsyncResult Ares;
		}
	}
}
