using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	[System.Diagnostics.DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	public class Task<TResult> : Task
	{
		// Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E8")]
		internal Task()
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E9")]
		internal Task(object state, TaskCreationOptions options)
		{
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EA")]
		internal Task(TResult result)
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EB")]
		internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EC")]
		public Task(System.Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013ED")]
		internal Task(System.Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EE")]
		internal Task(System.Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013EF")]
		internal static Task<TResult> StartNew(Task parent, System.Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013F0")]
		internal static Task<TResult> StartNew(Task parent, System.Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		[Token(Token = "0x60013F1")]
		internal bool TrySetResult(TResult result)
		{
			return default(bool);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F2")]
		internal void DangerousSetResult(TResult result)
		{
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001E4")]
		[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
		public TResult Result
		{
			[Token(Token = "0x60013F3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001E5")]
		internal TResult ResultOnSuccess
		{
			[Token(Token = "0x60013F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013F5")]
		internal TResult GetResultCore(bool waitCompletionNotification)
		{
			return null;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001E6")]
		public new static TaskFactory<TResult> Factory
		{
			[Token(Token = "0x60013F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F7")]
		internal override void InnerInvoke()
		{
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x60013F8")]
		public new System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter()
		{
			return default(System.Runtime.CompilerServices.TaskAwaiter<TResult>);
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x60013F9")]
		public new System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return default(System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013FA")]
		public Task ContinueWith(System.Action<Task<TResult>> continuationAction)
		{
			return null;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013FB")]
		public Task ContinueWith(System.Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013FC")]
		internal Task ContinueWith(System.Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013FD")]
		public Task<TNewResult> ContinueWith<TNewResult>(System.Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013FE")]
		internal Task<TNewResult> ContinueWith<TNewResult>(System.Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x0")]
		internal TResult m_result;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0x0")]
		private static TaskFactory<TResult> s_defaultFactory;
	}
}
