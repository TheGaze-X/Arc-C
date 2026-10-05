using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000254 RID: 596
	[Token(Token = "0x2000254")]
	public class TaskFactory<TResult>
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013FF")]
		private TaskScheduler GetDefaultScheduler(Task currTask)
		{
			return null;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001400")]
		public TaskFactory()
		{
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001401")]
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001402")]
		public Task<TResult> StartNew(System.Func<TResult> function, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001403")]
		public Task<TResult> StartNew(System.Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001404")]
		private static void FromAsyncCoreLogic(System.IAsyncResult iar, System.Func<System.IAsyncResult, TResult> endFunction, System.Action<System.IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001405")]
		public Task<TResult> FromAsync(System.Func<System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, object state)
		{
			return null;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001406")]
		internal static Task<TResult> FromAsyncImpl(System.Func<System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endFunction, System.Action<System.IAsyncResult> endAction, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001407")]
		public Task<TResult> FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
		{
			return null;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001408")]
		internal static Task<TResult> FromAsyncImpl<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endFunction, System.Action<System.IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001409")]
		internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endFunction, System.Action<System.IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600140A")]
		internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, System.Func<TInstance, TArgs, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<TInstance, System.IAsyncResult, TResult> endMethod) where TInstance : class
		{
			return null;
		}

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0x0")]
		private CancellationToken m_defaultCancellationToken;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		[FieldOffset(Offset = "0x0")]
		private TaskScheduler m_defaultScheduler;

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4000B27")]
		[FieldOffset(Offset = "0x0")]
		private TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4000B28")]
		[FieldOffset(Offset = "0x0")]
		private TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x02000255 RID: 597
		[Token(Token = "0x2000255")]
		private sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			// Token: 0x0600140B RID: 5131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600140B")]
			internal FromAsyncTrimPromise(TInstance thisRef, System.Func<TInstance, System.IAsyncResult, TResult> endMethod)
			{
			}

			// Token: 0x0600140C RID: 5132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600140C")]
			internal static void CompleteFromAsyncResult(System.IAsyncResult asyncResult)
			{
			}

			// Token: 0x0600140D RID: 5133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600140D")]
			internal void Complete(TInstance thisRef, System.Func<TInstance, System.IAsyncResult, TResult> endMethod, System.IAsyncResult asyncResult, bool requiresSynchronization)
			{
			}

			// Token: 0x04000B29 RID: 2857
			[Token(Token = "0x4000B29")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly System.AsyncCallback s_completeFromAsyncResult;

			// Token: 0x04000B2A RID: 2858
			[Token(Token = "0x4000B2A")]
			[FieldOffset(Offset = "0x0")]
			private TInstance m_thisRef;

			// Token: 0x04000B2B RID: 2859
			[Token(Token = "0x4000B2B")]
			[FieldOffset(Offset = "0x0")]
			private System.Func<TInstance, System.IAsyncResult, TResult> m_endMethod;
		}
	}
}
