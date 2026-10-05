using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public sealed class NetStatistics
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x17000026")]
		public long PacketsSent
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x36ACDD0", Offset = "0x36AB9D0", VA = "0x1836ACDD0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x17000027")]
		public long PacketsReceived
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x36ACDC0", Offset = "0x36AB9C0", VA = "0x1836ACDC0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x17000028")]
		public long BytesSent
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x36ACD50", Offset = "0x36AB950", VA = "0x1836ACD50")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x17000029")]
		public long BytesReceived
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x36ACD40", Offset = "0x36AB940", VA = "0x1836ACD40")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x1700002A")]
		public long PacketLoss
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x36ACDB0", Offset = "0x36AB9B0", VA = "0x1836ACDB0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x1700002B")]
		public long PacketLossPercent
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x36ACD60", Offset = "0x36AB960", VA = "0x1836ACD60")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x36AC9B0", Offset = "0x36AB5B0", VA = "0x1836AC9B0")]
		public void Reset()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x36AC9A0", Offset = "0x36AB5A0", VA = "0x1836AC9A0")]
		public void IncrementPacketsSent()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x36AC990", Offset = "0x36AB590", VA = "0x1836AC990")]
		public void IncrementPacketsReceived()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x36AC960", Offset = "0x36AB560", VA = "0x1836AC960")]
		public void AddBytesSent(long bytesSent)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x36AC950", Offset = "0x36AB550", VA = "0x1836AC950")]
		public void AddBytesReceived(long bytesReceived)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x36AC980", Offset = "0x36AB580", VA = "0x1836AC980")]
		public void IncrementPacketLoss()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x36AC970", Offset = "0x36AB570", VA = "0x1836AC970")]
		public void AddPacketLoss(long packetLoss)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x36ACA10", Offset = "0x36AB610", VA = "0x1836ACA10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NetStatistics()
		{
		}

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x10")]
		private long _packetsSent;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18")]
		private long _packetsReceived;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		private long _bytesSent;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x28")]
		private long _bytesReceived;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x30")]
		private long _packetLoss;
	}
}
