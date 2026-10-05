using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	public struct AsyncTaskMethodBuilder<TResult>
	{
		// Token: 0x06002325 RID: 8997 RVA: 0x000140D0 File Offset: 0x000122D0
		[Token(Token = "0x6002325")]
		public static AsyncTaskMethodBuilder<TResult> Create()
		{
			return default(AsyncTaskMethodBuilder<TResult>);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002326")]
		[System.Diagnostics.DebuggerStepThrough]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002327")]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002328")]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000489")]
		public System.Threading.Tasks.Task<TResult> Task
		{
			[Token(Token = "0x6002329")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232A")]
		public void SetResult(TResult result)
		{
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232B")]
		internal void SetResult(System.Threading.Tasks.Task<TResult> completedTask)
		{
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232C")]
		public void SetException(System.Exception exception)
		{
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600232D")]
		internal static System.Threading.Tasks.Task<TResult> GetTaskForResult(TResult result)
		{
			return null;
		}

		// Token: 0x040013F9 RID: 5113
		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly System.Threading.Tasks.Task<TResult> s_defaultResultTask;

		// Token: 0x040013FA RID: 5114
		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0x0")]
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x040013FB RID: 5115
		[Token(Token = "0x40013FB")]
		[FieldOffset(Offset = "0x0")]
		private System.Threading.Tasks.Task<TResult> m_task;
	}
}
