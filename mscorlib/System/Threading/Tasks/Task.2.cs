using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
	[System.Diagnostics.DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	public class Task : IThreadPoolWorkItem, System.IAsyncResult, System.IDisposable
	{
		// Token: 0x06001415 RID: 5141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x4AEC7C0", Offset = "0x4AEB3C0", VA = "0x184AEC7C0")]
		internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001416")]
		[Address(RVA = "0x4AEC990", Offset = "0x4AEB590", VA = "0x184AEC990")]
		internal Task()
		{
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x4AEC9C0", Offset = "0x4AEB5C0", VA = "0x184AEC9C0")]
		internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001418")]
		[Address(RVA = "0x4AEC8A0", Offset = "0x4AEB4A0", VA = "0x184AEC8A0")]
		internal Task(System.Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x4AEAEC0", Offset = "0x4AE9AC0", VA = "0x184AEAEC0")]
		internal void TaskConstructorCore(System.Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141A")]
		[Address(RVA = "0x4AE5880", Offset = "0x4AE4480", VA = "0x184AE5880")]
		private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x4AEAD70", Offset = "0x4AE9970", VA = "0x184AEAD70")]
		private static void TaskCancelCallback(object o)
		{
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x4AEB160", Offset = "0x4AE9D60", VA = "0x184AEB160")]
		internal bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			return default(bool);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x4AEB170", Offset = "0x4AE9D70", VA = "0x184AEB170")]
		internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
		{
			return default(bool);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0000F240 File Offset: 0x0000D440
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x4AEB270", Offset = "0x4AE9E70", VA = "0x184AEB270")]
		internal bool TrySetException(object exceptionObject)
		{
			return default(bool);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0000F258 File Offset: 0x0000D458
		[Token(Token = "0x170001E7")]
		internal TaskCreationOptions Options
		{
			[Token(Token = "0x600141F")]
			[Address(RVA = "0x4AED250", Offset = "0x4AEBE50", VA = "0x184AED250")]
			get
			{
				return TaskCreationOptions.None;
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		internal static TaskCreationOptions OptionsMethod(int flags)
		{
			return TaskCreationOptions.None;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x4AE5C20", Offset = "0x4AE4820", VA = "0x184AE5C20")]
		internal bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			return default(bool);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x4AE5B60", Offset = "0x4AE4760", VA = "0x184AE5B60")]
		internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			return default(bool);
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x4AEA630", Offset = "0x4AE9230", VA = "0x184AEA630")]
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x6001424")]
		[Address(RVA = "0x4AE9620", Offset = "0x4AE8220", VA = "0x184AE9620")]
		internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			return default(bool);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x6001425")]
		[Address(RVA = "0x4AE57F0", Offset = "0x4AE43F0", VA = "0x184AE57F0")]
		internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks)
		{
			return default(bool);
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x170001E8")]
		internal bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[Token(Token = "0x6001426")]
			[Address(RVA = "0x4AED200", Offset = "0x4AEBE00", VA = "0x184AED200")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x170001E9")]
		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			[Token(Token = "0x6001427")]
			[Address(RVA = "0x4AED230", Offset = "0x4AEBE30", VA = "0x184AED230", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0000F318 File Offset: 0x0000D518
		[Token(Token = "0x170001EA")]
		internal bool IsWaitNotificationEnabled
		{
			[Token(Token = "0x6001428")]
			[Address(RVA = "0x4AED230", Offset = "0x4AEBE30", VA = "0x184AED230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x4AE9690", Offset = "0x4AE8290", VA = "0x184AE9690")]
		[MethodImpl(72)]
		private void NotifyDebuggerOfWaitCompletion()
		{
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0000F330 File Offset: 0x0000D530
		[Token(Token = "0x600142A")]
		[Address(RVA = "0x4AE9600", Offset = "0x4AE8200", VA = "0x184AE9600")]
		internal bool MarkStarted()
		{
			return default(bool);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x4AE5280", Offset = "0x4AE3E80", VA = "0x184AE5280")]
		internal void AddNewChild()
		{
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x4AE71E0", Offset = "0x4AE5DE0", VA = "0x184AE71E0")]
		internal void DisregardChild()
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x4AE8CF0", Offset = "0x4AE78F0", VA = "0x184AE8CF0")]
		internal static Task InternalStartNew(Task creatingTask, System.Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			return null;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0000F348 File Offset: 0x0000D548
		[Token(Token = "0x170001EB")]
		public int Id
		{
			[Token(Token = "0x600142E")]
			[Address(RVA = "0x4AECF50", Offset = "0x4AEBB50", VA = "0x184AECF50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001EC")]
		internal static Task InternalCurrent
		{
			[Token(Token = "0x600142F")]
			[Address(RVA = "0x4AECFF0", Offset = "0x4AEBBF0", VA = "0x184AECFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x4AE8C60", Offset = "0x4AE7860", VA = "0x184AE8C60")]
		internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			return null;
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001ED")]
		internal static StackGuard CurrentStackGuard
		{
			[Token(Token = "0x6001431")]
			[Address(RVA = "0x4AECD70", Offset = "0x4AEB970", VA = "0x184AECD70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001EE")]
		public System.AggregateException Exception
		{
			[Token(Token = "0x6001432")]
			[Address(RVA = "0x4AECEB0", Offset = "0x4AEBAB0", VA = "0x184AECEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0000F360 File Offset: 0x0000D560
		[Token(Token = "0x170001EF")]
		public TaskStatus Status
		{
			[Token(Token = "0x6001433")]
			[Address(RVA = "0x4AED2A0", Offset = "0x4AEBEA0", VA = "0x184AED2A0")]
			get
			{
				return TaskStatus.Created;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0000F378 File Offset: 0x0000D578
		[Token(Token = "0x170001F0")]
		public bool IsCanceled
		{
			[Token(Token = "0x6001434")]
			[Address(RVA = "0x4AED040", Offset = "0x4AEBC40", VA = "0x184AED040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0000F390 File Offset: 0x0000D590
		[Token(Token = "0x170001F1")]
		internal bool IsCancellationRequested
		{
			[Token(Token = "0x6001435")]
			[Address(RVA = "0x4AED090", Offset = "0x4AEBC90", VA = "0x184AED090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x4AE7310", Offset = "0x4AE5F10", VA = "0x184AE7310")]
		internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			return null;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x4AE7220", Offset = "0x4AE5E20", VA = "0x184AE7220")]
		private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			return null;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		[Token(Token = "0x170001F2")]
		internal CancellationToken CancellationToken
		{
			[Token(Token = "0x6001438")]
			[Address(RVA = "0x4AECB00", Offset = "0x4AEB700", VA = "0x184AECB00")]
			get
			{
				return default(CancellationToken);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x170001F3")]
		internal bool IsCancellationAcknowledged
		{
			[Token(Token = "0x6001439")]
			[Address(RVA = "0x4AED070", Offset = "0x4AEBC70", VA = "0x184AED070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x170001F4")]
		public bool IsCompleted
		{
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x4AED140", Offset = "0x4AEBD40", VA = "0x184AED140", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x4AE95B0", Offset = "0x4AE81B0", VA = "0x184AE95B0")]
		private static bool IsCompletedMethod(int flags)
		{
			return default(bool);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x170001F5")]
		public bool IsCompletedSuccessfully
		{
			[Token(Token = "0x600143C")]
			[Address(RVA = "0x4AED110", Offset = "0x4AEBD10", VA = "0x184AED110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x170001F6")]
		public TaskCreationOptions CreationOptions
		{
			[Token(Token = "0x600143D")]
			[Address(RVA = "0x4AECD20", Offset = "0x4AEB920", VA = "0x184AECD20")]
			get
			{
				return TaskCreationOptions.None;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001F7")]
		private WaitHandle AsyncWaitHandle
		{
			[Token(Token = "0x600143E")]
			[Address(RVA = "0x4AEABC0", Offset = "0x4AE97C0", VA = "0x184AEABC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001F8")]
		public object AsyncState
		{
			[Token(Token = "0x600143F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0000F438 File Offset: 0x0000D638
		[Token(Token = "0x170001F9")]
		private bool CompletedSynchronously
		{
			[Token(Token = "0x6001440")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001FA")]
		internal TaskScheduler ExecutingTaskScheduler
		{
			[Token(Token = "0x6001441")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001FB")]
		public static TaskFactory Factory
		{
			[Token(Token = "0x6001442")]
			[Address(RVA = "0x4AECF00", Offset = "0x4AEBB00", VA = "0x184AECF00")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001FC")]
		public static Task CompletedTask
		{
			[Token(Token = "0x6001443")]
			[Address(RVA = "0x4AECCD0", Offset = "0x4AEB8D0", VA = "0x184AECCD0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001FD")]
		internal ManualResetEventSlim CompletedEvent
		{
			[Token(Token = "0x6001444")]
			[Address(RVA = "0x4AECBA0", Offset = "0x4AEB7A0", VA = "0x184AECBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0000F450 File Offset: 0x0000D650
		[Token(Token = "0x170001FE")]
		internal bool ExceptionRecorded
		{
			[Token(Token = "0x6001445")]
			[Address(RVA = "0x4AECE40", Offset = "0x4AEBA40", VA = "0x184AECE40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0000F468 File Offset: 0x0000D668
		[Token(Token = "0x170001FF")]
		public bool IsFaulted
		{
			[Token(Token = "0x6001446")]
			[Address(RVA = "0x4AED1E0", Offset = "0x4AEBDE0", VA = "0x184AED1E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000200")]
		internal ExecutionContext CapturedContext
		{
			[Token(Token = "0x6001447")]
			[Address(RVA = "0x4AECB30", Offset = "0x4AEB730", VA = "0x184AECB30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001448")]
			[Address(RVA = "0x4AED330", Offset = "0x4AEBF30", VA = "0x184AED330")]
			set
			{
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x4AE7170", Offset = "0x4AE5D70", VA = "0x184AE7170", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x4AE6FF0", Offset = "0x4AE5BF0", VA = "0x184AE6FF0", Slot = "12")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x4AEA290", Offset = "0x4AE8E90", VA = "0x184AEA290")]
		internal void ScheduleAndStart(bool needsProtection)
		{
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x4AE4F50", Offset = "0x4AE3B50", VA = "0x184AE4F50")]
		internal void AddException(object exceptionObject)
		{
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x4AE4C70", Offset = "0x4AE3870", VA = "0x184AE4C70")]
		internal void AddException(object exceptionObject, bool representsCancellation)
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x4AE8670", Offset = "0x4AE7270", VA = "0x184AE8670")]
		private System.AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			return null;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x4AE8470", Offset = "0x4AE7070", VA = "0x184AE8470")]
		internal System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.ExceptionServices.ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			return null;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x4AE8430", Offset = "0x4AE7030", VA = "0x184AE8430")]
		internal System.Runtime.ExceptionServices.ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			return null;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x4AEB110", Offset = "0x4AE9D10", VA = "0x184AEB110")]
		internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001452")]
		[Address(RVA = "0x4AEB2E0", Offset = "0x4AE9EE0", VA = "0x184AEB2E0")]
		internal void UpdateExceptionObservedStatus()
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x17000201")]
		internal bool IsExceptionObservedByParent
		{
			[Token(Token = "0x6001453")]
			[Address(RVA = "0x4AED1C0", Offset = "0x4AEBDC0", VA = "0x184AED1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x17000202")]
		internal bool IsDelegateInvoked
		{
			[Token(Token = "0x6001454")]
			[Address(RVA = "0x4AED1A0", Offset = "0x4AEBDA0", VA = "0x184AED1A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x4AE8100", Offset = "0x4AE6D00", VA = "0x184AE8100")]
		internal void Finish(bool bUserDelegateExecuted)
		{
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x4AE7FB0", Offset = "0x4AE6BB0", VA = "0x184AE7FB0")]
		internal void FinishStageTwo()
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x4AE7F00", Offset = "0x4AE6B00", VA = "0x184AE7F00")]
		internal void FinishStageThree()
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x4AE96D0", Offset = "0x4AE82D0", VA = "0x184AE96D0")]
		internal void ProcessChildCompletion(Task childTask)
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x4AE4F60", Offset = "0x4AE3B60", VA = "0x184AE4F60")]
		internal void AddExceptionsFromChildren()
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x4AE7800", Offset = "0x4AE6400", VA = "0x184AE7800")]
		private void Execute()
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x4AEAD60", Offset = "0x4AE9960", VA = "0x184AEAD60", Slot = "4")]
		private void ExecuteWorkItem()
		{
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x4AE7420", Offset = "0x4AE6020", VA = "0x184AE7420")]
		internal bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			return default(bool);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x4AE7860", Offset = "0x4AE6460", VA = "0x184AE7860")]
		private static void ExecutionContextCallback(object obj)
		{
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x4AE89C0", Offset = "0x4AE75C0", VA = "0x184AE89C0", Slot = "13")]
		internal virtual void InnerInvoke()
		{
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x4AE8880", Offset = "0x4AE7480", VA = "0x184AE8880")]
		private void HandleException(System.Exception unhandledException)
		{
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		[Token(Token = "0x6001460")]
		[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
		public System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()
		{
			return default(System.Runtime.CompilerServices.TaskAwaiter);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x4AE5DB0", Offset = "0x4AE49B0", VA = "0x184AE5DB0")]
		public System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			return default(System.Runtime.CompilerServices.ConfiguredTaskAwaitable);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x4AEA450", Offset = "0x4AE9050", VA = "0x184AEA450")]
		internal void SetContinuationForAwait(System.Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public static System.Runtime.CompilerServices.YieldAwaitable Yield()
		{
			return default(System.Runtime.CompilerServices.YieldAwaitable);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x4AEB3F0", Offset = "0x4AE9FF0", VA = "0x184AEB3F0")]
		public void Wait()
		{
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x4AEB4F0", Offset = "0x4AEA0F0", VA = "0x184AEB4F0")]
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return default(bool);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x4AEC2B0", Offset = "0x4AEAEB0", VA = "0x184AEC2B0")]
		private bool WrappedTryRunInline()
		{
			return default(bool);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x4AE8EA0", Offset = "0x4AE7AA0", VA = "0x184AE8EA0")]
		[MethodImpl(64)]
		internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return default(bool);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0000F558 File Offset: 0x0000D758
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x4AEA700", Offset = "0x4AE9300", VA = "0x184AEA700")]
		private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return default(bool);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0000F570 File Offset: 0x0000D770
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x4AEAA60", Offset = "0x4AE9660", VA = "0x184AEAA60")]
		private bool SpinWait(int millisecondsTimeout)
		{
			return default(bool);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0000F588 File Offset: 0x0000D788
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x4AE8A50", Offset = "0x4AE7650", VA = "0x184AE8A50")]
		internal bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			return default(bool);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x4AE9A30", Offset = "0x4AE8630", VA = "0x184AE9A30")]
		internal void RecordInternalCancellationRequest()
		{
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x4AE9980", Offset = "0x4AE8580", VA = "0x184AE9980")]
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x4AE98B0", Offset = "0x4AE84B0", VA = "0x184AE98B0")]
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
		{
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146E")]
		[Address(RVA = "0x4AE5CE0", Offset = "0x4AE48E0", VA = "0x184AE5CE0")]
		internal void CancellationCleanupLogic()
		{
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x4AEA420", Offset = "0x4AE9020", VA = "0x184AEA420")]
		private void SetCancellationAcknowledged()
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x4AE7950", Offset = "0x4AE6550", VA = "0x184AE7950")]
		internal void FinishContinuations()
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x4AE95C0", Offset = "0x4AE81C0", VA = "0x184AE95C0")]
		[MethodImpl(256)]
		private void LogFinishCompletionNotification()
		{
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x4AE6070", Offset = "0x4AE4C70", VA = "0x184AE6070")]
		public Task ContinueWith(System.Action<Task> continuationAction)
		{
			return null;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x4AE63A0", Offset = "0x4AE4FA0", VA = "0x184AE63A0")]
		public Task ContinueWith(System.Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x4AE60E0", Offset = "0x4AE4CE0", VA = "0x184AE60E0")]
		private Task ContinueWith(System.Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x4AE6040", Offset = "0x4AE4C40", VA = "0x184AE6040")]
		public Task ContinueWith(System.Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x4AE6420", Offset = "0x4AE5020", VA = "0x184AE6420")]
		private Task ContinueWith(System.Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x4AE66E0", Offset = "0x4AE52E0", VA = "0x184AE66E0")]
		internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x4AE5DD0", Offset = "0x4AE49D0", VA = "0x184AE5DD0")]
		internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x4AE4B80", Offset = "0x4AE3780", VA = "0x184AE4B80")]
		internal void AddCompletionAction(ITaskCompletionAction action)
		{
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x4AE4BF0", Offset = "0x4AE37F0", VA = "0x184AE4BF0")]
		private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x4AE52F0", Offset = "0x4AE3EF0", VA = "0x184AE52F0")]
		private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
		{
			return default(bool);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x4AE55D0", Offset = "0x4AE41D0", VA = "0x184AE55D0")]
		private bool AddTaskContinuation(object tc, bool addBeforeOthers)
		{
			return default(bool);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x4AE9A60", Offset = "0x4AE8660", VA = "0x184AE9A60")]
		internal void RemoveContinuation(object continuationObject)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600147E")]
		public static Task<TResult> FromResult<TResult>(TResult result)
		{
			return null;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x4AE83D0", Offset = "0x4AE6FD0", VA = "0x184AE83D0")]
		public static Task FromException(System.Exception exception)
		{
			return null;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001480")]
		public static Task<TResult> FromException<TResult>(System.Exception exception)
		{
			return null;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x4AE82D0", Offset = "0x4AE6ED0", VA = "0x184AE82D0")]
		internal static Task FromCancellation(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x4AE8280", Offset = "0x4AE6E80", VA = "0x184AE8280")]
		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001483")]
		internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001484")]
		public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001485")]
		internal static Task<TResult> FromCancellation<TResult>(System.OperationCanceledException exception)
		{
			return null;
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x4AE9E00", Offset = "0x4AE8A00", VA = "0x184AE9E00")]
		public static Task Run(System.Action action)
		{
			return null;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001487")]
		public static Task<TResult> Run<TResult>(System.Func<TResult> function)
		{
			return null;
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x4AE9FF0", Offset = "0x4AE8BF0", VA = "0x184AE9FF0")]
		public static Task Run(System.Func<Task> function)
		{
			return null;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x4AEA040", Offset = "0x4AE8C40", VA = "0x184AEA040")]
		public static Task Run(System.Func<Task> function, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600148A")]
		public static Task<TResult> Run<TResult>(System.Func<Task<TResult>> function)
		{
			return null;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600148B")]
		public static Task<TResult> Run<TResult>(System.Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x4AE6860", Offset = "0x4AE5460", VA = "0x184AE6860")]
		public static Task Delay(System.TimeSpan delay, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x4AE6960", Offset = "0x4AE5560", VA = "0x184AE6960")]
		public static Task Delay(int millisecondsDelay)
		{
			return null;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x4AE69B0", Offset = "0x4AE55B0", VA = "0x184AE69B0")]
		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x4AEB670", Offset = "0x4AEA270", VA = "0x184AEB670")]
		public static Task WhenAll(System.Collections.Generic.IEnumerable<Task> tasks)
		{
			return null;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x4AEBB90", Offset = "0x4AEA790", VA = "0x184AEBB90")]
		public static Task WhenAll(params Task[] tasks)
		{
			return null;
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x4AE9360", Offset = "0x4AE7F60", VA = "0x184AE9360")]
		private static Task InternalWhenAll(Task[] tasks)
		{
			return null;
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x4AEC080", Offset = "0x4AEAC80", VA = "0x184AEC080")]
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			return null;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x4AEBDB0", Offset = "0x4AEA9B0", VA = "0x184AEBDB0")]
		public static Task<Task> WhenAny(System.Collections.Generic.IEnumerable<Task> tasks)
		{
			return null;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x4AE56B0", Offset = "0x4AE42B0", VA = "0x184AE56B0")]
		[FriendAccessAllowed]
		internal static bool AddToActiveTasks(Task task)
		{
			return default(bool);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x4AE9CE0", Offset = "0x4AE88E0", VA = "0x184AE9CE0")]
		[FriendAccessAllowed]
		internal static void RemoveFromActiveTasks(int taskId)
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x4AE75D0", Offset = "0x4AE61D0", VA = "0x184AE75D0")]
		private void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
		}

		// Token: 0x04000B3E RID: 2878
		[Token(Token = "0x4000B3E")]
		[FieldOffset(Offset = "0x0")]
		internal static int s_taskIdCounter;

		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x4000B3F")]
		[FieldOffset(Offset = "0x10")]
		private int m_taskId;

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x18")]
		internal System.Delegate m_action;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0x20")]
		internal object m_stateObject;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0x28")]
		internal TaskScheduler m_taskScheduler;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0x30")]
		internal readonly Task m_parent;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x38")]
		internal int m_stateFlags;

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		private const int OptionsMask = 65535;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		internal const int TASK_STATE_STARTED = 65536;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		internal const int TASK_STATE_DELEGATE_INVOKED = 131072;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		internal const int TASK_STATE_DISPOSED = 262144;

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;

		// Token: 0x04000B4A RID: 2890
		[Token(Token = "0x4000B4A")]
		internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;

		// Token: 0x04000B4B RID: 2891
		[Token(Token = "0x4000B4B")]
		internal const int TASK_STATE_FAULTED = 2097152;

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		internal const int TASK_STATE_CANCELED = 4194304;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4000B4E")]
		internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4000B50")]
		internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		private const int TASK_STATE_COMPLETED_MASK = 23068672;

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		private const int CANCELLATION_REQUESTED = 1;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x40")]
		private object m_continuationObject;

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object s_taskCompletionSentinel;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x10")]
		internal static bool s_asyncDebuggingEnabled;

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x48")]
		internal Task.ContingentProperties m_contingentProperties;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x18")]
		private static readonly System.Action<object> s_taskCancelCallback;

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		[System.ThreadStatic]
		internal static Task t_currentTask;

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[System.ThreadStatic]
		private static StackGuard t_stackGuard;

		// Token: 0x04000B5C RID: 2908
		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0x20")]
		private static readonly System.Func<Task.ContingentProperties> s_createContingentProperties;

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x38")]
		private static readonly System.Predicate<Task> s_IsExceptionObservedByParentPredicate;

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x40")]
		private static ContextCallback s_ecCallback;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x48")]
		private static readonly System.Predicate<object> s_IsTaskContinuationNullPredicate;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x50")]
		private static readonly System.Collections.Generic.Dictionary<int, Task> s_currentActiveTasks;

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x58")]
		private static readonly object s_activeTasksLock;

		// Token: 0x0200025B RID: 603
		[Token(Token = "0x200025B")]
		internal class ContingentProperties
		{
			// Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001499")]
			[Address(RVA = "0x4ADB1D0", Offset = "0x4AD9DD0", VA = "0x184ADB1D0")]
			internal void SetCompleted()
			{
			}

			// Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149A")]
			[Address(RVA = "0x4ADB200", Offset = "0x4AD9E00", VA = "0x184ADB200")]
			internal void UnregisterCancellationCallback()
			{
			}

			// Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149B")]
			[Address(RVA = "0x4ADB2B0", Offset = "0x4AD9EB0", VA = "0x184ADB2B0")]
			public ContingentProperties()
			{
			}

			// Token: 0x04000B64 RID: 2916
			[Token(Token = "0x4000B64")]
			[FieldOffset(Offset = "0x10")]
			internal ExecutionContext m_capturedContext;

			// Token: 0x04000B65 RID: 2917
			[Token(Token = "0x4000B65")]
			[FieldOffset(Offset = "0x18")]
			internal ManualResetEventSlim m_completionEvent;

			// Token: 0x04000B66 RID: 2918
			[Token(Token = "0x4000B66")]
			[FieldOffset(Offset = "0x20")]
			internal TaskExceptionHolder m_exceptionsHolder;

			// Token: 0x04000B67 RID: 2919
			[Token(Token = "0x4000B67")]
			[FieldOffset(Offset = "0x28")]
			internal CancellationToken m_cancellationToken;

			// Token: 0x04000B68 RID: 2920
			[Token(Token = "0x4000B68")]
			[FieldOffset(Offset = "0x30")]
			internal object m_cancellationRegistration;

			// Token: 0x04000B69 RID: 2921
			[Token(Token = "0x4000B69")]
			[FieldOffset(Offset = "0x38")]
			internal int m_internalCancellationRequested;

			// Token: 0x04000B6A RID: 2922
			[Token(Token = "0x4000B6A")]
			[FieldOffset(Offset = "0x3C")]
			internal int m_completionCountdown;

			// Token: 0x04000B6B RID: 2923
			[Token(Token = "0x4000B6B")]
			[FieldOffset(Offset = "0x40")]
			internal LowLevelListWithIList<Task> m_exceptionalChildren;
		}

		// Token: 0x0200025C RID: 604
		[Token(Token = "0x200025C")]
		private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
		{
			// Token: 0x0600149C RID: 5276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149C")]
			[Address(RVA = "0x4AE1310", Offset = "0x4ADFF10", VA = "0x184AE1310")]
			internal SetOnInvokeMres()
			{
			}

			// Token: 0x0600149D RID: 5277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149D")]
			[Address(RVA = "0x4AE1300", Offset = "0x4ADFF00", VA = "0x184AE1300", Slot = "6")]
			public void Invoke(Task completingTask)
			{
			}

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x0600149E RID: 5278 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
			[Token(Token = "0x17000203")]
			public bool InvokeMayRunArbitraryCode
			{
				[Token(Token = "0x600149E")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}
		}

		// Token: 0x0200025D RID: 605
		[Token(Token = "0x200025D")]
		private sealed class DelayPromise : Task<VoidTaskResult>
		{
			// Token: 0x0600149F RID: 5279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600149F")]
			[Address(RVA = "0x4ADE8C0", Offset = "0x4ADD4C0", VA = "0x184ADE8C0")]
			internal DelayPromise(CancellationToken token)
			{
			}

			// Token: 0x060014A0 RID: 5280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014A0")]
			[Address(RVA = "0x4ADE7B0", Offset = "0x4ADD3B0", VA = "0x184ADE7B0")]
			internal void Complete()
			{
			}

			// Token: 0x04000B6C RID: 2924
			[Token(Token = "0x4000B6C")]
			[FieldOffset(Offset = "0x58")]
			internal readonly CancellationToken Token;

			// Token: 0x04000B6D RID: 2925
			[Token(Token = "0x4000B6D")]
			[FieldOffset(Offset = "0x60")]
			internal CancellationTokenRegistration Registration;

			// Token: 0x04000B6E RID: 2926
			[Token(Token = "0x4000B6E")]
			[FieldOffset(Offset = "0x78")]
			internal Timer Timer;
		}

		// Token: 0x0200025E RID: 606
		[Token(Token = "0x200025E")]
		private sealed class WhenAllPromise : Task<VoidTaskResult>, ITaskCompletionAction
		{
			// Token: 0x060014A1 RID: 5281 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014A1")]
			[Address(RVA = "0x4AF4680", Offset = "0x4AF3280", VA = "0x184AF4680")]
			internal WhenAllPromise(Task[] tasks)
			{
			}

			// Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014A2")]
			[Address(RVA = "0x4AF42F0", Offset = "0x4AF2EF0", VA = "0x184AF42F0", Slot = "14")]
			public void Invoke(Task ignored)
			{
			}

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0000F600 File Offset: 0x0000D800
			[Token(Token = "0x17000204")]
			internal override bool ShouldNotifyDebuggerOfWaitCompletion
			{
				[Token(Token = "0x60014A3")]
				[Address(RVA = "0x4AF4830", Offset = "0x4AF3430", VA = "0x184AF4830", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0000F618 File Offset: 0x0000D818
			[Token(Token = "0x17000205")]
			public bool InvokeMayRunArbitraryCode
			{
				[Token(Token = "0x60014A4")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000B6F RID: 2927
			[Token(Token = "0x4000B6F")]
			[FieldOffset(Offset = "0x58")]
			private readonly Task[] m_tasks;

			// Token: 0x04000B70 RID: 2928
			[Token(Token = "0x4000B70")]
			[FieldOffset(Offset = "0x60")]
			private int m_count;
		}
	}
}
