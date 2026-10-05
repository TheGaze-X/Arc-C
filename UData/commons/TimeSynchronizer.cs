using System;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	internal class TimeSynchronizer
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000066")]
		public static TimeSynchronizer Instance
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x55CACD0", Offset = "0x55C98D0", VA = "0x1855CACD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x55CAC20", Offset = "0x55C9820", VA = "0x1855CAC20")]
		private TimeSynchronizer()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x55CA150", Offset = "0x55C8D50", VA = "0x1855CA150")]
		public TimeSynchronizer Initialize(string url)
		{
			return null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x55CA430", Offset = "0x55C9030", VA = "0x1855CA430")]
		public void SyncServerCountdown()
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x55CA260", Offset = "0x55C8E60", VA = "0x1855CA260")]
		private void ResetTimer()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x55CA2A0", Offset = "0x55C8EA0", VA = "0x1855CA2A0")]
		public void StartSyncServer(string serverTimeString)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x55CA000", Offset = "0x55C8C00", VA = "0x1855CA000")]
		public long GetSynchronizedTime()
		{
			return 0L;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x55CA5B0", Offset = "0x55C91B0", VA = "0x1855CA5B0")]
		public void SyncServerTimeAsync()
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x55CA1D0", Offset = "0x55C8DD0", VA = "0x1855CA1D0")]
		private void ResetServerTime(string serverTimeString)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x55C99D0", Offset = "0x55C85D0", VA = "0x1855C99D0")]
		public void CountDownCancel()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x55C9A00", Offset = "0x55C8600", VA = "0x1855C9A00")]
		private static long GetNetworkTime()
		{
			return 0L;
		}

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Lazy<TimeSynchronizer> m_instance;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		private Timer timer;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		private long syncTime;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		private Stopwatch stopwatch;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x28")]
		private object lockObject;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		private const int totalTime = 3600;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x30")]
		private string url;
	}
}
