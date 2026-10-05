using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2000275")]
	public class TaskFactory
	{
		// Token: 0x060014F0 RID: 5360 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x4AE2F10", Offset = "0x4AE1B10", VA = "0x184AE2F10")]
		private TaskScheduler GetDefaultScheduler(Task currTask)
		{
			return null;
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x4AE3680", Offset = "0x4AE2280", VA = "0x184AE3680")]
		public TaskFactory()
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x4AE36D0", Offset = "0x4AE22D0", VA = "0x184AE36D0")]
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x4AE2990", Offset = "0x4AE1590", VA = "0x184AE2990")]
		internal static void CheckCreationOptions(TaskCreationOptions creationOptions)
		{
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x4AE3000", Offset = "0x4AE1C00", VA = "0x184AE3000")]
		public Task StartNew(System.Action action)
		{
			return null;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x4AE34B0", Offset = "0x4AE20B0", VA = "0x184AE34B0")]
		public Task StartNew(System.Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x4AE32D0", Offset = "0x4AE1ED0", VA = "0x184AE32D0")]
		public Task StartNew(System.Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014F7")]
		public Task<TResult> StartNew<TResult>(System.Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014F8")]
		public Task<TResult> StartNew<TResult>(System.Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014F9")]
		public Task FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, object state)
		{
			return null;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014FA")]
		public Task FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014FB")]
		public Task FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			return null;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014FC")]
		public Task FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x4AE2A00", Offset = "0x4AE1600", VA = "0x184AE2A00")]
		internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
		{
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x4AE2CA0", Offset = "0x4AE18A0", VA = "0x184AE2CA0")]
		internal static Task<Task> CommonCWAnyLogic(System.Collections.Generic.IList<Task> tasks)
		{
			return null;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x4AE2B50", Offset = "0x4AE1750", VA = "0x184AE2B50")]
		internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
		{
		}

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x10")]
		private readonly CancellationToken m_defaultCancellationToken;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x18")]
		private readonly TaskScheduler m_defaultScheduler;

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x20")]
		private readonly TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x24")]
		private readonly TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x02000276 RID: 630
		[Token(Token = "0x2000276")]
		internal sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
		{
			// Token: 0x06001500 RID: 5376 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001500")]
			[Address(RVA = "0x4ADB0E0", Offset = "0x4AD9CE0", VA = "0x184ADB0E0")]
			public CompleteOnInvokePromise(System.Collections.Generic.IList<Task> tasks)
			{
			}

			// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001501")]
			[Address(RVA = "0x4ADAEF0", Offset = "0x4AD9AF0", VA = "0x184ADAEF0", Slot = "14")]
			public void Invoke(Task completingTask)
			{
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x06001502 RID: 5378 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
			[Token(Token = "0x1700020A")]
			public bool InvokeMayRunArbitraryCode
			{
				[Token(Token = "0x6001502")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000BB5 RID: 2997
			[Token(Token = "0x4000BB5")]
			[FieldOffset(Offset = "0x58")]
			private System.Collections.Generic.IList<Task> _tasks;
		}
	}
}
