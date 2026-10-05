using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	public static class ThreadPool
	{
		// Token: 0x06001323 RID: 4899 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001323")]
		[Address(RVA = "0x4AEF600", Offset = "0x4AEE200", VA = "0x184AEF600")]
		private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			return null;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001324")]
		[Address(RVA = "0x4AEF530", Offset = "0x4AEE130", VA = "0x184AEF530")]
		[MethodImpl(8)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			return null;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001325")]
		[Address(RVA = "0x4AEF390", Offset = "0x4AEDF90", VA = "0x184AEF390")]
		[MethodImpl(8)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, System.TimeSpan timeout, bool executeOnlyOnce)
		{
			return null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[Token(Token = "0x6001326")]
		[Address(RVA = "0x4AEF360", Offset = "0x4AEDF60", VA = "0x184AEF360")]
		[MethodImpl(8)]
		public static bool QueueUserWorkItem(WaitCallback callBack, object state)
		{
			return default(bool);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0000ED00 File Offset: 0x0000CF00
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x4AEF330", Offset = "0x4AEDF30", VA = "0x184AEF330")]
		[MethodImpl(8)]
		public static bool QueueUserWorkItem(WaitCallback callBack)
		{
			return default(bool);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0000ED18 File Offset: 0x0000CF18
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x4AEFAA0", Offset = "0x4AEE6A0", VA = "0x184AEFAA0")]
		[MethodImpl(8)]
		public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
		{
			return default(bool);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[Token(Token = "0x6001329")]
		public static bool QueueUserWorkItem<TState>(System.Action<TState> callBack, TState state, bool preferLocal)
		{
			return default(bool);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0000ED48 File Offset: 0x0000CF48
		[Token(Token = "0x600132A")]
		[Address(RVA = "0x4AEF1C0", Offset = "0x4AEDDC0", VA = "0x184AEF1C0")]
		private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
		{
			return default(bool);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132B")]
		[Address(RVA = "0x4AEFA10", Offset = "0x4AEE610", VA = "0x184AEFA10")]
		internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0000ED60 File Offset: 0x0000CF60
		[Token(Token = "0x600132C")]
		[Address(RVA = "0x4AEF920", Offset = "0x4AEE520", VA = "0x184AEF920")]
		internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			return default(bool);
		}

		// Token: 0x0600132D RID: 4909
		[Token(Token = "0x600132D")]
		[Address(RVA = "0x4AEF910", Offset = "0x4AEE510", VA = "0x184AEF910")]
		[MethodImpl(4096)]
		internal static extern bool RequestWorkerThread();

		// Token: 0x0600132E RID: 4910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132E")]
		[Address(RVA = "0x4AEF0E0", Offset = "0x4AEDCE0", VA = "0x184AEF0E0")]
		private static void EnsureVMInitialized()
		{
		}

		// Token: 0x0600132F RID: 4911
		[Token(Token = "0x600132F")]
		[Address(RVA = "0x4AEF190", Offset = "0x4AEDD90", VA = "0x184AEF190")]
		[MethodImpl(4096)]
		internal static extern bool NotifyWorkItemComplete();

		// Token: 0x06001330 RID: 4912
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x4AEF900", Offset = "0x4AEE500", VA = "0x184AEF900")]
		[MethodImpl(4096)]
		internal static extern void ReportThreadStatus(bool isWorking);

		// Token: 0x06001331 RID: 4913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x4AEDA30", Offset = "0x4AEC630", VA = "0x184AEDA30")]
		internal static void NotifyWorkItemProgress()
		{
		}

		// Token: 0x06001332 RID: 4914
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x4AEF1A0", Offset = "0x4AEDDA0", VA = "0x184AEF1A0")]
		[MethodImpl(4096)]
		internal static extern void NotifyWorkItemProgressNative();

		// Token: 0x06001333 RID: 4915
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x4AEF1B0", Offset = "0x4AEDDB0", VA = "0x184AEF1B0")]
		[MethodImpl(4096)]
		internal static extern void NotifyWorkItemQueued();

		// Token: 0x06001334 RID: 4916
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x4AEF180", Offset = "0x4AEDD80", VA = "0x184AEF180")]
		[MethodImpl(4096)]
		private static extern void InitializeVMTp(ref bool enableWorkerTracking);

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[Token(Token = "0x170001D3")]
		internal static bool IsThreadPoolThread
		{
			[Token(Token = "0x6001335")]
			[Address(RVA = "0x4AEFAD0", Offset = "0x4AEE6D0", VA = "0x184AEFAD0")]
			get
			{
				return default(bool);
			}
		}
	}
}
