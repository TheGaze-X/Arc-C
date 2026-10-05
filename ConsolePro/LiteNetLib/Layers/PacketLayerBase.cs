using System;
using System.Net;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Layers
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public abstract class PacketLayerBase
	{
		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		protected PacketLayerBase(int extraPacketSizeForLayer)
		{
		}

		// Token: 0x06000311 RID: 785
		[Token(Token = "0x6000311")]
		public abstract void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);

		// Token: 0x06000312 RID: 786
		[Token(Token = "0x6000312")]
		public abstract void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x10")]
		public readonly int ExtraPacketSizeForLayer;
	}
}
