using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	[System.Runtime.InteropServices.ComVisible(false)]
	[System.Diagnostics.DebuggerDisplay("Current Count = {m_currentCount}")]
	public class SemaphoreSlim : System.IDisposable
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x170001B3")]
		public int CurrentCount
		{
			[Token(Token = "0x6001229")]
			[Address(RVA = "0x4D5A610", Offset = "0x4D59210", VA = "0x184D5A610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x4D5A410", Offset = "0x4D59010", VA = "0x184D5A410")]
		public SemaphoreSlim(int initialCount, int maxCount)
		{
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122B")]
		[Address(RVA = "0x4D5A270", Offset = "0x4D58E70", VA = "0x184D5A270")]
		public void Wait()
		{
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x4D59B30", Offset = "0x4D58730", VA = "0x184D59B30")]
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return default(bool);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0000E808 File Offset: 0x0000CA08
		[Token(Token = "0x600122D")]
		[Address(RVA = "0x4D59A10", Offset = "0x4D58610", VA = "0x184D59A10")]
		private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			return default(bool);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x4D592F0", Offset = "0x4D57EF0", VA = "0x184D592F0")]
		public System.Threading.Tasks.Task WaitAsync()
		{
			return null;
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x4D59300", Offset = "0x4D57F00", VA = "0x184D59300")]
		public System.Threading.Tasks.Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x4D58BC0", Offset = "0x4D577C0", VA = "0x184D58BC0")]
		private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			return null;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0000E820 File Offset: 0x0000CA20
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x4D59200", Offset = "0x4D57E00", VA = "0x184D59200")]
		private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			return default(bool);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001232")]
		[Address(RVA = "0x4D598C0", Offset = "0x4D584C0", VA = "0x184D598C0")]
		private System.Threading.Tasks.Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x6001233")]
		[Address(RVA = "0x4D591F0", Offset = "0x4D57DF0", VA = "0x184D591F0")]
		public int Release()
		{
			return 0;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0000E850 File Offset: 0x0000CA50
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x4D58DE0", Offset = "0x4D579E0", VA = "0x184D58DE0")]
		public int Release(int releaseCount)
		{
			return 0;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x4D58DD0", Offset = "0x4D579D0", VA = "0x184D58DD0")]
		private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask)
		{
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x4D58C90", Offset = "0x4D57890", VA = "0x184D58C90", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x4D58D00", Offset = "0x4D57900", VA = "0x184D58D00", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001238")]
		[Address(RVA = "0x4D588E0", Offset = "0x4D574E0", VA = "0x184D588E0")]
		private static void CancellationTokenCanceledEventHandler(object obj)
		{
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x4D58B20", Offset = "0x4D57720", VA = "0x184D58B20")]
		private void CheckDispose()
		{
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x4D58DC0", Offset = "0x4D579C0", VA = "0x184D58DC0")]
		private static string GetResourceString(string str)
		{
			return null;
		}

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_currentCount;

		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly int m_maxCount;

		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_waitCount;

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object m_lockObj;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ManualResetEvent m_waitHandle;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SemaphoreSlim.TaskNode m_asyncHead;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SemaphoreSlim.TaskNode m_asyncTail;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Threading.Tasks.Task<bool> s_trueTask;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly System.Threading.Tasks.Task<bool> s_falseTask;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		private const int NO_MAXIMUM = 2147483647;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Action<object> s_cancellationTokenCanceledEventHandler;

		// Token: 0x02000211 RID: 529
		[Token(Token = "0x2000211")]
		private sealed class TaskNode : System.Threading.Tasks.Task<bool>, IThreadPoolWorkItem
		{
			// Token: 0x0600123C RID: 4668 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600123C")]
			[Address(RVA = "0x4D5BC80", Offset = "0x4D5A880", VA = "0x184D5BC80")]
			internal TaskNode()
			{
			}

			// Token: 0x0600123D RID: 4669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600123D")]
			[Address(RVA = "0x4D5BC40", Offset = "0x4D5A840", VA = "0x184D5BC40", Slot = "4")]
			private void ExecuteWorkItem()
			{
			}

			// Token: 0x0600123E RID: 4670 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600123E")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			private void MarkAborted(ThreadAbortException tae)
			{
			}

			// Token: 0x04000A54 RID: 2644
			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal SemaphoreSlim.TaskNode Prev;

			// Token: 0x04000A55 RID: 2645
			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal SemaphoreSlim.TaskNode Next;
		}
	}
}
