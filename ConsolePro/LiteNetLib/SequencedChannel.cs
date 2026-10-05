using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal sealed class SequencedChannel : BaseChannel
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x36AFC70", Offset = "0x36AE870", VA = "0x1836AFC70")]
		public SequencedChannel(NetPeer peer, bool reliable, byte id)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x36AF8E0", Offset = "0x36AE4E0", VA = "0x1836AF8E0", Slot = "4")]
		protected override bool SendNextPackets()
		{
			return default(bool);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x36AF600", Offset = "0x36AE200", VA = "0x1836AF600", Slot = "5")]
		public override bool ProcessPacket(NetPacket packet)
		{
			return default(bool);
		}

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x28")]
		private int _localSequence;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x2C")]
		private ushort _remoteSequence;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x2E")]
		private readonly bool _reliable;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x30")]
		private NetPacket _lastPacket;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x38")]
		private readonly NetPacket _ackPacket;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x40")]
		private bool _mustSendAck;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x41")]
		private readonly byte _id;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x48")]
		private long _lastPacketSendTime;
	}
}
