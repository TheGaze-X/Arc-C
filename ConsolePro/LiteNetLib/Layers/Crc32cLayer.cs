using System;
using System.Net;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Layers
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public sealed class Crc32cLayer : PacketLayerBase
	{
		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x35E4E40", Offset = "0x35E3A40", VA = "0x1835E4E40")]
		public Crc32cLayer()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x36AFD30", Offset = "0x36AE930", VA = "0x1836AFD30", Slot = "4")]
		public override void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x36AFEC0", Offset = "0x36AEAC0", VA = "0x1836AFEC0", Slot = "5")]
		public override void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}
	}
}
