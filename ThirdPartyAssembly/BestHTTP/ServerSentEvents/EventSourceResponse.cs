using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.ServerSentEvents
{
	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20004C8")]
	public sealed class EventSourceResponse : HTTPResponse, IProtocol
	{
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x00011388 File Offset: 0x0000F588
		// (set) Token: 0x06002867 RID: 10343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C5")]
		public bool IsClosed
		{
			[Token(Token = "0x6002866")]
			[Address(RVA = "0x36AAB40", Offset = "0x36A9740", VA = "0x1836AAB40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002867")]
			[Address(RVA = "0x53A0CC0", Offset = "0x539F8C0", VA = "0x1853A0CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002868")]
		[Address(RVA = "0x53A0B80", Offset = "0x539F780", VA = "0x1853A0B80")]
		public EventSourceResponse(HTTPRequest request, Stream stream, bool isStreamed, bool isFromCache)
		{
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[Token(Token = "0x6002869")]
		[Address(RVA = "0x53A0A10", Offset = "0x539F610", VA = "0x1853A0A10", Slot = "5")]
		internal override bool Receive(int forceReadRawContentLength = -1, bool readPayloadData = true)
		{
			return default(bool);
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286A")]
		[Address(RVA = "0x53A0B00", Offset = "0x539F700", VA = "0x1853A0B00")]
		internal void StartReceive()
		{
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286B")]
		[Address(RVA = "0x53A0630", Offset = "0x539F230", VA = "0x1853A0630")]
		private void ReceiveThreadFunc(object param)
		{
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x53A03D0", Offset = "0x539EFD0", VA = "0x1853A03D0")]
		private new void ReadChunked(Stream stream)
		{
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x53A0560", Offset = "0x539F160", VA = "0x1853A0560")]
		private new void ReadRaw(Stream stream, long contentLength)
		{
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286E")]
		[Address(RVA = "0x539FD90", Offset = "0x539E990", VA = "0x18539FD90")]
		public void FeedData(byte[] buffer, int count)
		{
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x539FF50", Offset = "0x539EB50", VA = "0x18539FF50")]
		private void ParseLine(byte[] buffer, int count)
		{
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x539F920", Offset = "0x539E520", VA = "0x18539F920", Slot = "7")]
		private void HandleEvents()
		{
		}

		// Token: 0x04001667 RID: 5735
		[Token(Token = "0x4001667")]
		[FieldOffset(Offset = "0xE0")]
		public Action<EventSourceResponse, Message> OnMessage;

		// Token: 0x04001668 RID: 5736
		[Token(Token = "0x4001668")]
		[FieldOffset(Offset = "0xE8")]
		public Action<EventSourceResponse> OnClosed;

		// Token: 0x04001669 RID: 5737
		[Token(Token = "0x4001669")]
		[FieldOffset(Offset = "0xF0")]
		private object FrameLock;

		// Token: 0x0400166A RID: 5738
		[Token(Token = "0x400166A")]
		[FieldOffset(Offset = "0xF8")]
		private byte[] LineBuffer;

		// Token: 0x0400166B RID: 5739
		[Token(Token = "0x400166B")]
		[FieldOffset(Offset = "0x100")]
		private int LineBufferPos;

		// Token: 0x0400166C RID: 5740
		[Token(Token = "0x400166C")]
		[FieldOffset(Offset = "0x108")]
		private Message CurrentMessage;

		// Token: 0x0400166D RID: 5741
		[Token(Token = "0x400166D")]
		[FieldOffset(Offset = "0x110")]
		private List<Message> CompletedMessages;
	}
}
