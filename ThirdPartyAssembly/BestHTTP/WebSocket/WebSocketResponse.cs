using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using BestHTTP.Extensions;
using BestHTTP.WebSocket.Frames;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket
{
	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	public sealed class WebSocketResponse : HTTPResponse, IHeartbeat, IProtocol
	{
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A8")]
		public WebSocket WebSocket
		{
			[Token(Token = "0x60027D4")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027D5")]
			[Address(RVA = "0x4D6CA00", Offset = "0x4D6B600", VA = "0x184D6CA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x00011130 File Offset: 0x0000F330
		[Token(Token = "0x170005A9")]
		public bool IsClosed
		{
			[Token(Token = "0x60027D6")]
			[Address(RVA = "0x53B40D0", Offset = "0x53B2CD0", VA = "0x1853B40D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x00011148 File Offset: 0x0000F348
		// (set) Token: 0x060027D8 RID: 10200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AA")]
		public TimeSpan PingFrequnecy
		{
			[Token(Token = "0x60027D7")]
			[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x60027D8")]
			[Address(RVA = "0x53B4110", Offset = "0x53B2D10", VA = "0x1853B4110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x00011160 File Offset: 0x0000F360
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AB")]
		public ushort MaxFragmentSize
		{
			[Token(Token = "0x60027D9")]
			[Address(RVA = "0x53B40F0", Offset = "0x53B2CF0", VA = "0x1853B40F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027DA")]
			[Address(RVA = "0x53B4100", Offset = "0x53B2D00", VA = "0x1853B4100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x00011178 File Offset: 0x0000F378
		[Token(Token = "0x170005AC")]
		public int BufferedAmount
		{
			[Token(Token = "0x60027DB")]
			[Address(RVA = "0x53B40C0", Offset = "0x53B2CC0", VA = "0x1853B40C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x53B3E50", Offset = "0x53B2A50", VA = "0x1853B3E50")]
		internal WebSocketResponse(HTTPRequest request, Stream stream, bool isStreamed, bool isFromCache)
		{
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x53B3DD0", Offset = "0x53B29D0", VA = "0x1853B3DD0")]
		internal void StartReceive()
		{
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x53B23F0", Offset = "0x53B0FF0", VA = "0x1853B23F0")]
		internal void CloseStream()
		{
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x53B3B70", Offset = "0x53B2770", VA = "0x1853B3B70")]
		public void Send(string message)
		{
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x53B36C0", Offset = "0x53B22C0", VA = "0x1853B36C0")]
		public void Send(byte[] data)
		{
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x53B38F0", Offset = "0x53B24F0", VA = "0x1853B38F0")]
		public void Send(byte[] data, ulong offset, ulong count)
		{
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x53B3440", Offset = "0x53B2040", VA = "0x1853B3440")]
		public void Send(WebSocketFrame frame)
		{
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x53B2570", Offset = "0x53B1170", VA = "0x1853B2570")]
		public void Close()
		{
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x53B2480", Offset = "0x53B1080", VA = "0x1853B2480")]
		public void Close(ushort code, string msg)
		{
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x53B3CD0", Offset = "0x53B28D0", VA = "0x1853B3CD0")]
		public void StartPinging(int frequency)
		{
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x53B2DF0", Offset = "0x53B19F0", VA = "0x1853B2DF0")]
		private void SendThreadFunc(object param)
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x53B25C0", Offset = "0x53B11C0", VA = "0x1853B25C0")]
		private void ReceiveThreadFunc(object param)
		{
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x53B1ED0", Offset = "0x53B0AD0", VA = "0x1853B1ED0", Slot = "8")]
		private void HandleEvents()
		{
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x53B1C70", Offset = "0x53B0870", VA = "0x1853B1C70", Slot = "6")]
		private void OnHeartbeatUpdate(TimeSpan dif)
		{
		}

		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		[FieldOffset(Offset = "0xE0")]
		public Action<WebSocketResponse, string> OnText;

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0xE8")]
		public Action<WebSocketResponse, byte[]> OnBinary;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[FieldOffset(Offset = "0xF0")]
		public Action<WebSocketResponse, WebSocketFrameReader> OnIncompleteFrame;

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0xF8")]
		public Action<WebSocketResponse, ushort, string> OnClosed;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x10C")]
		private int _bufferedAmount;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x110")]
		private List<WebSocketFrameReader> IncompleteFrames;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x118")]
		private List<WebSocketFrameReader> CompletedFrames;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x120")]
		private WebSocketFrameReader CloseFrame;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x128")]
		private object FrameLock;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x130")]
		private object SendLock;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x138")]
		private List<WebSocketFrame> unsentFrames;

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x140")]
		private AutoResetEvent newFrameSignal;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x148")]
		private bool sendThreadCreated;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x149")]
		private bool closeSent;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x14A")]
		private bool closed;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x150")]
		private DateTime lastPing;
	}
}
