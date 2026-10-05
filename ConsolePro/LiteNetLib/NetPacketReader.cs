using System;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public sealed class NetPacketReader : NetDataReader
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x36A5EB0", Offset = "0x36A4AB0", VA = "0x1836A5EB0")]
		internal NetPacketReader(NetManager manager, NetEvent evt)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x36A5E50", Offset = "0x36A4A50", VA = "0x1836A5E50")]
		internal void SetSource(NetPacket packet, int headerSize)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x36A5D30", Offset = "0x36A4930", VA = "0x1836A5D30")]
		internal void RecycleInternal()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x36A5DC0", Offset = "0x36A49C0", VA = "0x1836A5DC0")]
		public void Recycle()
		{
		}

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		private NetPacket _packet;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		private readonly NetManager _manager;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x38")]
		private readonly NetEvent _evt;
	}
}
