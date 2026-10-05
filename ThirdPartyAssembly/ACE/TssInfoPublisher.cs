using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace ACE
{
	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	public class TssInfoPublisher
	{
		// Token: 0x06003120 RID: 12576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003120")]
		[Address(RVA = "0x5436CF0", Offset = "0x54358F0", VA = "0x185436CF0")]
		private TssInfoPublisher()
		{
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003121")]
		[Address(RVA = "0x5437040", Offset = "0x5435C40", VA = "0x185437040")]
		public static TssInfoPublisher getInstance()
		{
			return null;
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003122")]
		[Address(RVA = "0x54374A0", Offset = "0x54360A0", VA = "0x1854374A0")]
		public void registTssInfoReceiver(TssInfoReceiver receiver)
		{
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003123")]
		[Address(RVA = "0x5436D60", Offset = "0x5435960", VA = "0x185436D60")]
		private void broadcastInfo(int id, string info)
		{
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003124")]
		[Address(RVA = "0x54372C0", Offset = "0x5435EC0", VA = "0x1854372C0")]
		private void recvDataThread()
		{
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x5437270", Offset = "0x5435E70", VA = "0x185437270")]
		private static int openPipe()
		{
			return 0;
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x5437000", Offset = "0x5435C00", VA = "0x185437000")]
		private static void closePipe()
		{
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x5437460", Offset = "0x5436060", VA = "0x185437460")]
		private static string recvPipe()
		{
			return null;
		}

		// Token: 0x04001B1E RID: 6942
		[Token(Token = "0x4001B1E")]
		public const int TSS_INFO_TYPE_DETECT_RESULT = 1;

		// Token: 0x04001B1F RID: 6943
		[Token(Token = "0x4001B1F")]
		public const int TSS_INFO_TYPE_HEARTBEAT = 2;

		// Token: 0x04001B20 RID: 6944
		[Token(Token = "0x4001B20")]
		[FieldOffset(Offset = "0x0")]
		private static TssInfoPublisher mInstance;

		// Token: 0x04001B21 RID: 6945
		[Token(Token = "0x4001B21")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object mSingletonLock;

		// Token: 0x04001B22 RID: 6946
		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x10")]
		private readonly object padlockReceiver;

		// Token: 0x04001B23 RID: 6947
		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x10")]
		private static List<TssInfoReceiver> mReceivers;

		// Token: 0x04001B24 RID: 6948
		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x18")]
		private static Thread mTssInfoPublisherThread;

		// Token: 0x04001B25 RID: 6949
		[Token(Token = "0x4001B25")]
		[FieldOffset(Offset = "0x20")]
		private static bool mTssInfoPublisherThreadStarted;
	}
}
