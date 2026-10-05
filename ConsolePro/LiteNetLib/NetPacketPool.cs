using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	internal sealed class NetPacketPool
	{
		// Token: 0x06000127 RID: 295 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x36A5860", Offset = "0x36A4460", VA = "0x1836A5860")]
		public NetPacket GetWithData(PacketProperty property, byte[] data, int start, int length)
		{
			return null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x36A5990", Offset = "0x36A4590", VA = "0x1836A5990")]
		public NetPacket GetWithProperty(PacketProperty property, int size)
		{
			return null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x36A5A80", Offset = "0x36A4680", VA = "0x1836A5A80")]
		public NetPacket GetWithProperty(PacketProperty property)
		{
			return null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x36A5610", Offset = "0x36A4210", VA = "0x1836A5610")]
		public NetPacket GetPacket(int size)
		{
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x36A5B60", Offset = "0x36A4760", VA = "0x1836A5B60")]
		public void Recycle(NetPacket packet)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x36A5CC0", Offset = "0x36A48C0", VA = "0x1836A5CC0")]
		public NetPacketPool()
		{
		}

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x10")]
		private NetPacket _head;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x18")]
		private int _count;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x20")]
		private readonly object _lock;
	}
}
