using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004B4 RID: 1204
	[Token(Token = "0x20004B4")]
	public struct AsyncTaskMethodBuilder
	{
		// Token: 0x0600231D RID: 8989 RVA: 0x000140B8 File Offset: 0x000122B8
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x15A87A0", Offset = "0x15A73A0", VA = "0x1815A87A0")]
		public static AsyncTaskMethodBuilder Create()
		{
			return default(AsyncTaskMethodBuilder);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231E")]
		[System.Diagnostics.DebuggerStepThrough]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x4BD0AF0", Offset = "0x4BCF6F0", VA = "0x184BD0AF0")]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002320")]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000488")]
		public System.Threading.Tasks.Task Task
		{
			[Token(Token = "0x6002321")]
			[Address(RVA = "0x4BD0BE0", Offset = "0x4BCF7E0", VA = "0x184BD0BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x4BD0A50", Offset = "0x4BCF650", VA = "0x184BD0A50")]
		public void SetResult()
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x4BD09E0", Offset = "0x4BCF5E0", VA = "0x184BD09E0")]
		public void SetException(System.Exception exception)
		{
		}

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.Threading.Tasks.Task<VoidTaskResult> s_cachedCompleted;

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0x0")]
		private AsyncTaskMethodBuilder<VoidTaskResult> m_builder;
	}
}
