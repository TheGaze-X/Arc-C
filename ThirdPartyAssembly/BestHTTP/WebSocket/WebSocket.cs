using System;
using System.Runtime.CompilerServices;
using BestHTTP.WebSocket.Extensions;
using BestHTTP.WebSocket.Frames;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket
{
	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	public sealed class WebSocket
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x000110D0 File Offset: 0x0000F2D0
		[Token(Token = "0x170005A2")]
		public bool IsOpen
		{
			[Token(Token = "0x60027B9")]
			[Address(RVA = "0x53B6390", Offset = "0x53B4F90", VA = "0x1853B6390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[Token(Token = "0x170005A3")]
		public int BufferedAmount
		{
			[Token(Token = "0x60027BA")]
			[Address(RVA = "0x53B6370", Offset = "0x53B4F70", VA = "0x1853B6370")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x00011100 File Offset: 0x0000F300
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A4")]
		public bool StartPingThread
		{
			[Token(Token = "0x60027BB")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027BC")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x00011118 File Offset: 0x0000F318
		// (set) Token: 0x060027BE RID: 10174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A5")]
		public int PingFrequency
		{
			[Token(Token = "0x60027BD")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027BE")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A6")]
		public HTTPRequest InternalRequest
		{
			[Token(Token = "0x60027BF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027C0")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A7")]
		public IExtension[] Extensions
		{
			[Token(Token = "0x60027C1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027C2")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x53B5600", Offset = "0x53B4200", VA = "0x1853B5600")]
		public WebSocket(Uri uri)
		{
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x53B57E0", Offset = "0x53B43E0", VA = "0x1853B57E0")]
		public WebSocket(Uri uri, string origin, string protocol, params IExtension[] extensions)
		{
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x53B4660", Offset = "0x53B3260", VA = "0x1853B4660")]
		private void OnInternalRequestCallback(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C6")]
		[Address(RVA = "0x53B4A30", Offset = "0x53B3630", VA = "0x1853B4A30")]
		private void OnInternalRequestUpgraded(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x53B5110", Offset = "0x53B3D10", VA = "0x1853B5110")]
		public void Open()
		{
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x53B5320", Offset = "0x53B3F20", VA = "0x1853B5320")]
		public void Send(string message)
		{
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x53B54A0", Offset = "0x53B40A0", VA = "0x1853B54A0")]
		public void Send(byte[] buffer)
		{
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x53B5500", Offset = "0x53B4100", VA = "0x1853B5500")]
		public void Send(byte[] buffer, ulong offset, ulong count)
		{
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x53B52C0", Offset = "0x53B3EC0", VA = "0x1853B52C0")]
		public void Send(WebSocketFrame frame)
		{
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x53B4120", Offset = "0x53B2D20", VA = "0x1853B4120")]
		public void Close()
		{
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x53B41A0", Offset = "0x53B2DA0", VA = "0x1853B41A0")]
		public void Close(ushort code, string message)
		{
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x53B4210", Offset = "0x53B2E10", VA = "0x1853B4210")]
		public static byte[] EncodeCloseData(ushort code, string message)
		{
			return null;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x53B44F0", Offset = "0x53B30F0", VA = "0x1853B44F0")]
		private string GetSecKey(object[] from)
		{
			return null;
		}

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[FieldOffset(Offset = "0x28")]
		public OnWebSocketOpenDelegate OnOpen;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x30")]
		public OnWebSocketMessageDelegate OnMessage;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x38")]
		public OnWebSocketBinaryDelegate OnBinary;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x40")]
		public OnWebSocketClosedDelegate OnClosed;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x48")]
		public OnWebSocketErrorDelegate OnError;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x50")]
		public OnWebSocketErrorDescriptionDelegate OnErrorDesc;

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[FieldOffset(Offset = "0x58")]
		public OnWebSocketIncompleteFrameDelegate OnIncompleteFrame;

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[FieldOffset(Offset = "0x60")]
		private bool requestSent;

		// Token: 0x040015FE RID: 5630
		[Token(Token = "0x40015FE")]
		[FieldOffset(Offset = "0x68")]
		private WebSocketResponse webSocket;
	}
}
