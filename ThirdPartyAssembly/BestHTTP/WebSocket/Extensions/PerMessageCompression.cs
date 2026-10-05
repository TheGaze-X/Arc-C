using System;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Decompression.Zlib;
using BestHTTP.WebSocket.Frames;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket.Extensions
{
	// Token: 0x020004BD RID: 1213
	[Token(Token = "0x20004BD")]
	public sealed class PerMessageCompression : IExtension
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00011280 File Offset: 0x0000F480
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BA")]
		public bool ClientNoContextTakeover
		{
			[Token(Token = "0x6002815")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002816")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x00011298 File Offset: 0x0000F498
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BB")]
		public bool ServerNoContextTakeover
		{
			[Token(Token = "0x6002817")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002818")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x000112B0 File Offset: 0x0000F4B0
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BC")]
		public int ClientMaxWindowBits
		{
			[Token(Token = "0x6002819")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600281A")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000112C8 File Offset: 0x0000F4C8
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BD")]
		public int ServerMaxWindowBits
		{
			[Token(Token = "0x600281B")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600281C")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000112E0 File Offset: 0x0000F4E0
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BE")]
		public CompressionLevel Level
		{
			[Token(Token = "0x600281D")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return CompressionLevel.None;
			}
			[Token(Token = "0x600281E")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x000112F8 File Offset: 0x0000F4F8
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BF")]
		public int MinimumDataLegthToCompress
		{
			[Token(Token = "0x600281F")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002820")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x53ADFB0", Offset = "0x53ACBB0", VA = "0x1853ADFB0")]
		public PerMessageCompression()
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x53AE030", Offset = "0x53ACC30", VA = "0x1853AE030")]
		public PerMessageCompression(CompressionLevel level, bool clientNoContextTakeover, bool serverNoContextTakeover, int desiredClientMaxWindowBits, int desiredServerMaxWindowBits, int minDatalengthToCompress)
		{
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x53AD0E0", Offset = "0x53ABCE0", VA = "0x1853AD0E0", Slot = "4")]
		public void AddNegotiation(HTTPRequest request)
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00011310 File Offset: 0x0000F510
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x53ADB80", Offset = "0x53AC780", VA = "0x1853ADB80", Slot = "5")]
		public bool ParseNegotiation(WebSocketResponse resp)
		{
			return default(bool);
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00011328 File Offset: 0x0000F528
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x53ADB40", Offset = "0x53AC740", VA = "0x1853ADB40", Slot = "6")]
		public byte GetFrameHeader(WebSocketFrame writer, byte inFlag)
		{
			return 0;
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x53ADAA0", Offset = "0x53AC6A0", VA = "0x1853ADAA0", Slot = "7")]
		public byte[] Encode(WebSocketFrame writer)
		{
			return null;
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x53AD670", Offset = "0x53AC270", VA = "0x1853AD670", Slot = "8")]
		public byte[] Decode(byte header, byte[] data)
		{
			return null;
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x53AD250", Offset = "0x53ABE50", VA = "0x1853AD250")]
		private byte[] Compress(byte[] data)
		{
			return null;
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x53AD690", Offset = "0x53AC290", VA = "0x1853AD690")]
		private byte[] Decompress(byte[] data)
		{
			return null;
		}

		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] Trailer;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[FieldOffset(Offset = "0x28")]
		private MemoryStream compressorOutputStream;

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[FieldOffset(Offset = "0x30")]
		private DeflateStream compressorDeflateStream;

		// Token: 0x0400163E RID: 5694
		[Token(Token = "0x400163E")]
		[FieldOffset(Offset = "0x38")]
		private MemoryStream decompressorInputStream;

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[FieldOffset(Offset = "0x40")]
		private MemoryStream decompressorOutputStream;

		// Token: 0x04001640 RID: 5696
		[Token(Token = "0x4001640")]
		[FieldOffset(Offset = "0x48")]
		private DeflateStream decompressorDeflateStream;

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[FieldOffset(Offset = "0x50")]
		private byte[] copyBuffer;
	}
}
