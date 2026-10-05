using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	internal sealed class ReliableChannel : BaseChannel
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x36AF420", Offset = "0x36AE020", VA = "0x1836AF420")]
		public ReliableChannel(NetPeer peer, bool ordered, byte id)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x36AE530", Offset = "0x36AD130", VA = "0x1836AE530")]
		private void ProcessAck(NetPacket packet)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x36AEF00", Offset = "0x36ADB00", VA = "0x1836AEF00", Slot = "4")]
		protected override bool SendNextPackets()
		{
			return default(bool);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x36AE8E0", Offset = "0x36AD4E0", VA = "0x1836AE8E0", Slot = "5")]
		public override bool ProcessPacket(NetPacket packet)
		{
			return default(bool);
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		private readonly NetPacket _outgoingAcks;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x30")]
		private readonly ReliableChannel.PendingPacket[] _pendingPackets;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x38")]
		private readonly NetPacket[] _receivedPackets;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x40")]
		private readonly bool[] _earlyReceived;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x48")]
		private int _localSeqence;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x4C")]
		private int _remoteSequence;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x50")]
		private int _localWindowStart;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x54")]
		private int _remoteWindowStart;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x58")]
		private bool _mustSendAcks;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x59")]
		private readonly DeliveryMethod _deliveryMethod;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x5A")]
		private readonly bool _ordered;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int _windowSize;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		private const int BitsInByte = 8;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x60")]
		private readonly byte _id;

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		private struct PendingPacket
		{
			// Token: 0x06000189 RID: 393 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x36AE420", Offset = "0x36AD020", VA = "0x1836AE420", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x36AE400", Offset = "0x36AD000", VA = "0x1836AE400")]
			public void Init(NetPacket packet)
			{
			}

			// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x36AE4C0", Offset = "0x36AD0C0", VA = "0x1836AE4C0")]
			public void TrySend(long currentTime, NetPeer peer, out bool hasPacket)
			{
			}

			// Token: 0x0600018C RID: 396 RVA: 0x000027A8 File Offset: 0x000009A8
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x36AE3B0", Offset = "0x36ACFB0", VA = "0x1836AE3B0")]
			public bool Clear(NetPeer peer)
			{
				return default(bool);
			}

			// Token: 0x04000141 RID: 321
			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x0")]
			private NetPacket _packet;

			// Token: 0x04000142 RID: 322
			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x8")]
			private long _timeStamp;

			// Token: 0x04000143 RID: 323
			[Token(Token = "0x4000143")]
			[FieldOffset(Offset = "0x10")]
			private bool _isSent;
		}
	}
}
