using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket.Frames
{
	// Token: 0x020004BA RID: 1210
	[Token(Token = "0x20004BA")]
	public sealed class WebSocketFrameReader
	{
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x000111F0 File Offset: 0x0000F3F0
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B2")]
		public byte Header
		{
			[Token(Token = "0x60027FB")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027FC")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x00011208 File Offset: 0x0000F408
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B3")]
		public bool IsFinal
		{
			[Token(Token = "0x60027FD")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027FE")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x00011220 File Offset: 0x0000F420
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B4")]
		public WebSocketFrameTypes Type
		{
			[Token(Token = "0x60027FF")]
			[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50")]
			[CompilerGenerated]
			get
			{
				return WebSocketFrameTypes.Continuation;
			}
			[Token(Token = "0x6002800")]
			[Address(RVA = "0x4EEBD0", Offset = "0x4ED7D0", VA = "0x1804EEBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x00011238 File Offset: 0x0000F438
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B5")]
		public bool HasMask
		{
			[Token(Token = "0x6002801")]
			[Address(RVA = "0x53B1060", Offset = "0x53AFC60", VA = "0x1853B1060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002802")]
			[Address(RVA = "0x53B1070", Offset = "0x53AFC70", VA = "0x1853B1070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x00011250 File Offset: 0x0000F450
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B6")]
		public ulong Length
		{
			[Token(Token = "0x6002803")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002804")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B7")]
		public byte[] Mask
		{
			[Token(Token = "0x6002805")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002806")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B8")]
		public byte[] Data
		{
			[Token(Token = "0x6002807")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002808")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B9")]
		public string DataAsText
		{
			[Token(Token = "0x6002809")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600280A")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x53B0B00", Offset = "0x53AF700", VA = "0x1853B0B00")]
		internal void Read(Stream stream)
		{
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00011268 File Offset: 0x0000F468
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x53B0A90", Offset = "0x53AF690", VA = "0x1853B0A90")]
		private byte ReadByte(Stream stream)
		{
			return 0;
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x53B0740", Offset = "0x53AF340", VA = "0x1853B0740")]
		public void Assemble(List<WebSocketFrameReader> fragments)
		{
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x53B0950", Offset = "0x53AF550", VA = "0x1853B0950")]
		public void DecodeWithExtensions(WebSocket webSocket)
		{
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WebSocketFrameReader()
		{
		}
	}
}
