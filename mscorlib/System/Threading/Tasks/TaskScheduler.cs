using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	[System.Diagnostics.DebuggerDisplay("Id={Id}")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
	public abstract class TaskScheduler
	{
		// Token: 0x06001503 RID: 5379
		[Token(Token = "0x6001503")]
		protected internal abstract void QueueTask(Task task);

		// Token: 0x06001504 RID: 5380
		[Token(Token = "0x6001504")]
		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

		// Token: 0x06001505 RID: 5381 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x4AE3F10", Offset = "0x4AE2B10", VA = "0x184AE3F10")]
		internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			return default(bool);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		protected internal virtual bool TryDequeue(Task task)
		{
			return default(bool);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		internal virtual void NotifyWorkItemProgress()
		{
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0000F738 File Offset: 0x0000D938
		[Token(Token = "0x1700020B")]
		internal virtual bool RequiresAtomicStartTransition
		{
			[Token(Token = "0x6001508")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TaskScheduler()
		{
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700020C")]
		public static TaskScheduler Default
		{
			[Token(Token = "0x600150A")]
			[Address(RVA = "0x4AE43A0", Offset = "0x4AE2FA0", VA = "0x184AE43A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700020D")]
		public static TaskScheduler Current
		{
			[Token(Token = "0x600150B")]
			[Address(RVA = "0x4AE4300", Offset = "0x4AE2F00", VA = "0x184AE4300")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700020E")]
		internal static TaskScheduler InternalCurrent
		{
			[Token(Token = "0x600150C")]
			[Address(RVA = "0x4AE4490", Offset = "0x4AE3090", VA = "0x184AE4490")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x0000F750 File Offset: 0x0000D950
		[Token(Token = "0x1700020F")]
		public int Id
		{
			[Token(Token = "0x600150D")]
			[Address(RVA = "0x4AE43F0", Offset = "0x4AE2FF0", VA = "0x184AE43F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x4AE3DD0", Offset = "0x4AE29D0", VA = "0x184AE3DD0")]
		internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
		{
		}

		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		[FieldOffset(Offset = "0x0")]
		private static System.Runtime.CompilerServices.ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers;

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TaskScheduler s_defaultTaskScheduler;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x10")]
		internal static int s_taskSchedulerIdCounter;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x10")]
		private int m_taskSchedulerId;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x18")]
		private static System.EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Lock _unobservedTaskExceptionLockObject;

		// Token: 0x02000278 RID: 632
		[Token(Token = "0x2000278")]
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
		}
	}
}
