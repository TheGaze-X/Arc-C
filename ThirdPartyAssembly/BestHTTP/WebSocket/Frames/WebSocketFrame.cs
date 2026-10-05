using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket.Frames
{
	// Token: 0x020004B9 RID: 1209
	[Token(Token = "0x20004B9")]
	public sealed class WebSocketFrame
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x00011190 File Offset: 0x0000F390
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AD")]
		public WebSocketFrameTypes Type
		{
			[Token(Token = "0x60027EA")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return WebSocketFrameTypes.Continuation;
			}
			[Token(Token = "0x60027EB")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x000111A8 File Offset: 0x0000F3A8
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AE")]
		public bool IsFinal
		{
			[Token(Token = "0x60027EC")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027ED")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x000111C0 File Offset: 0x0000F3C0
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AF")]
		public byte Header
		{
			[Token(Token = "0x60027EE")]
			[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027EF")]
			[Address(RVA = "0x4EEBD0", Offset = "0x4ED7D0", VA = "0x1804EEBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B0")]
		public byte[] Data
		{
			[Token(Token = "0x60027F0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027F1")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x000111D8 File Offset: 0x0000F3D8
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B1")]
		public bool UseExtensions
		{
			[Token(Token = "0x60027F2")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027F3")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x53B1BA0", Offset = "0x53B07A0", VA = "0x1853B1BA0")]
		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data)
		{
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x53B1C30", Offset = "0x53B0830", VA = "0x1853B1C30")]
		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, bool useExtensions)
		{
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x53B1BE0", Offset = "0x53B07E0", VA = "0x1853B1BE0")]
		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, bool isFinal, bool useExtensions)
		{
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x53B19B0", Offset = "0x53B05B0", VA = "0x1853B19B0")]
		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, ulong pos, ulong length, bool isFinal, bool useExtensions)
		{
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x53B13D0", Offset = "0x53AFFD0", VA = "0x1853B13D0")]
		public byte[] Get()
		{
			return null;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x53B1080", Offset = "0x53AFC80", VA = "0x1853B1080")]
		public WebSocketFrame[] Fragment(ushort maxFragmentSize)
		{
			return null;
		}

		// Token: 0x04001620 RID: 5664
		[Token(Token = "0x4001620")]
		[FieldOffset(Offset = "0x0")]
		public static readonly byte[] NoData;
	}
}
