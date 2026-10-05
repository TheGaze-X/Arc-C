using System;
using System.Runtime.ConstrainedExecution;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	internal sealed class ThreadPoolWorkQueue
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001301")]
		[Address(RVA = "0x4AEF010", Offset = "0x4AEDC10", VA = "0x184AEF010")]
		public ThreadPoolWorkQueue()
		{
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001302")]
		[Address(RVA = "0x4AEED70", Offset = "0x4AED970", VA = "0x184AEED70")]
		public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
		{
			return null;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001303")]
		[Address(RVA = "0x4AEEE20", Offset = "0x4AEDA20", VA = "0x184AEEE20")]
		internal void EnsureThreadRequested()
		{
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001304")]
		[Address(RVA = "0x4AEEF20", Offset = "0x4AEDB20", VA = "0x184AEEF20")]
		internal void MarkThreadRequestSatisfied()
		{
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x4AEEB40", Offset = "0x4AED740", VA = "0x184AEEB40")]
		public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
		{
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x6001306")]
		[Address(RVA = "0x4AEEEC0", Offset = "0x4AEDAC0", VA = "0x184AEEEC0")]
		internal bool LocalFindAndPop(IThreadPoolWorkItem callback)
		{
			return default(bool);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001307")]
		[Address(RVA = "0x4AEE310", Offset = "0x4AECF10", VA = "0x184AEE310")]
		public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal)
		{
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Token(Token = "0x6001308")]
		[Address(RVA = "0x4AEE680", Offset = "0x4AED280", VA = "0x184AEE680")]
		internal static bool Dispatch()
		{
			return default(bool);
		}

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4000AA4")]
		[FieldOffset(Offset = "0x10")]
		internal ThreadPoolWorkQueue.QueueSegment queueHead;

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x18")]
		internal ThreadPoolWorkQueue.QueueSegment queueTail;

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		[FieldOffset(Offset = "0x0")]
		internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues;

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x20")]
		private int numOutstandingThreadRequests;

		// Token: 0x0200022D RID: 557
		[Token(Token = "0x200022D")]
		internal class SparseArray<T> where T : class
		{
			// Token: 0x0600130A RID: 4874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600130A")]
			internal SparseArray(int initialSize)
			{
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x0600130B RID: 4875 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170001D2")]
			internal T[] Current
			{
				[Token(Token = "0x600130B")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600130C RID: 4876 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
			[Token(Token = "0x600130C")]
			internal int Add(T e)
			{
				return 0;
			}

			// Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600130D")]
			internal void Remove(T e)
			{
			}

			// Token: 0x04000AA8 RID: 2728
			[Token(Token = "0x4000AA8")]
			[FieldOffset(Offset = "0x0")]
			private T[] m_array;
		}

		// Token: 0x0200022E RID: 558
		[Token(Token = "0x200022E")]
		internal class WorkStealingQueue
		{
			// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600130E")]
			[Address(RVA = "0x4AF5040", Offset = "0x4AF3C40", VA = "0x184AF5040")]
			public void LocalPush(IThreadPoolWorkItem obj)
			{
			}

			// Token: 0x0600130F RID: 4879 RVA: 0x0000EC10 File Offset: 0x0000CE10
			[Token(Token = "0x600130F")]
			[Address(RVA = "0x4AF4910", Offset = "0x4AF3510", VA = "0x184AF4910")]
			public bool LocalFindAndPop(IThreadPoolWorkItem obj)
			{
				return default(bool);
			}

			// Token: 0x06001310 RID: 4880 RVA: 0x0000EC28 File Offset: 0x0000CE28
			[Token(Token = "0x6001310")]
			[Address(RVA = "0x4AF4CC0", Offset = "0x4AF38C0", VA = "0x184AF4CC0")]
			public bool LocalPop(out IThreadPoolWorkItem obj)
			{
				return default(bool);
			}

			// Token: 0x06001311 RID: 4881 RVA: 0x0000EC40 File Offset: 0x0000CE40
			[Token(Token = "0x6001311")]
			[Address(RVA = "0x4AF58A0", Offset = "0x4AF44A0", VA = "0x184AF58A0")]
			public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal)
			{
				return default(bool);
			}

			// Token: 0x06001312 RID: 4882 RVA: 0x0000EC58 File Offset: 0x0000CE58
			[Token(Token = "0x6001312")]
			[Address(RVA = "0x4AF55E0", Offset = "0x4AF41E0", VA = "0x184AF55E0")]
			private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout)
			{
				return default(bool);
			}

			// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001313")]
			[Address(RVA = "0x4AF58C0", Offset = "0x4AF44C0", VA = "0x184AF58C0")]
			public WorkStealingQueue()
			{
			}

			// Token: 0x04000AA9 RID: 2729
			[Token(Token = "0x4000AA9")]
			[FieldOffset(Offset = "0x10")]
			internal IThreadPoolWorkItem[] m_array;

			// Token: 0x04000AAA RID: 2730
			[Token(Token = "0x4000AAA")]
			[FieldOffset(Offset = "0x18")]
			private int m_mask;

			// Token: 0x04000AAB RID: 2731
			[Token(Token = "0x4000AAB")]
			[FieldOffset(Offset = "0x1C")]
			private int m_headIndex;

			// Token: 0x04000AAC RID: 2732
			[Token(Token = "0x4000AAC")]
			[FieldOffset(Offset = "0x20")]
			private int m_tailIndex;

			// Token: 0x04000AAD RID: 2733
			[Token(Token = "0x4000AAD")]
			[FieldOffset(Offset = "0x24")]
			private SpinLock m_foreignLock;
		}

		// Token: 0x0200022F RID: 559
		[Token(Token = "0x200022F")]
		internal class QueueSegment
		{
			// Token: 0x06001314 RID: 4884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001314")]
			[Address(RVA = "0x4ADF520", Offset = "0x4ADE120", VA = "0x184ADF520")]
			private void GetIndexes(out int upper, out int lower)
			{
			}

			// Token: 0x06001315 RID: 4885 RVA: 0x0000EC70 File Offset: 0x0000CE70
			[Token(Token = "0x6001315")]
			[Address(RVA = "0x4ADF4A0", Offset = "0x4ADE0A0", VA = "0x184ADF4A0")]
			private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower)
			{
				return default(bool);
			}

			// Token: 0x06001316 RID: 4886 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001316")]
			[Address(RVA = "0x4ADF7F0", Offset = "0x4ADE3F0", VA = "0x184ADF7F0")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
			public QueueSegment()
			{
			}

			// Token: 0x06001317 RID: 4887 RVA: 0x0000EC88 File Offset: 0x0000CE88
			[Token(Token = "0x6001317")]
			[Address(RVA = "0x4ADF560", Offset = "0x4ADE160", VA = "0x184ADF560")]
			public bool IsUsedUp()
			{
				return default(bool);
			}

			// Token: 0x06001318 RID: 4888 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
			[Token(Token = "0x6001318")]
			[Address(RVA = "0x4ADF720", Offset = "0x4ADE320", VA = "0x184ADF720")]
			public bool TryEnqueue(IThreadPoolWorkItem node)
			{
				return default(bool);
			}

			// Token: 0x06001319 RID: 4889 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
			[Token(Token = "0x6001319")]
			[Address(RVA = "0x4ADF5C0", Offset = "0x4ADE1C0", VA = "0x184ADF5C0")]
			public bool TryDequeue(out IThreadPoolWorkItem node)
			{
				return default(bool);
			}

			// Token: 0x04000AAE RID: 2734
			[Token(Token = "0x4000AAE")]
			[FieldOffset(Offset = "0x10")]
			internal readonly IThreadPoolWorkItem[] nodes;

			// Token: 0x04000AAF RID: 2735
			[Token(Token = "0x4000AAF")]
			[FieldOffset(Offset = "0x18")]
			private int indexes;

			// Token: 0x04000AB0 RID: 2736
			[Token(Token = "0x4000AB0")]
			[FieldOffset(Offset = "0x20")]
			public ThreadPoolWorkQueue.QueueSegment Next;
		}
	}
}
