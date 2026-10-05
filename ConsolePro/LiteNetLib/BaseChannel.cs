using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	internal abstract class BaseChannel
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x17000001")]
		public int PacketsInQueue
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x36978B0", Offset = "0x36964B0", VA = "0x1836978B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3697810", Offset = "0x3696410", VA = "0x183697810")]
		protected BaseChannel(NetPeer peer)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x36976B0", Offset = "0x36962B0", VA = "0x1836976B0")]
		public void AddToQueue(NetPacket packet)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3697660", Offset = "0x3696260", VA = "0x183697660")]
		protected void AddToPeerChannelSendQueue()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x36977C0", Offset = "0x36963C0", VA = "0x1836977C0")]
		public bool SendAndCheckQueue()
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		protected abstract bool SendNextPackets();

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		public abstract bool ProcessPacket(NetPacket packet);

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		protected readonly NetPeer Peer;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		protected readonly Queue<NetPacket> OutgoingQueue;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x20")]
		private int _isAddedToPeerChannelSendQueue;
	}
}
