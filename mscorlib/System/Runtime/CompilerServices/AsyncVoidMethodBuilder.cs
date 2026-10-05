using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004B3 RID: 1203
	[Token(Token = "0x20004B3")]
	public struct AsyncVoidMethodBuilder
	{
		// Token: 0x06002315 RID: 8981 RVA: 0x000140A0 File Offset: 0x000122A0
		[Token(Token = "0x6002315")]
		[Address(RVA = "0x4BD0C40", Offset = "0x4BCF840", VA = "0x184BD0C40")]
		public static AsyncVoidMethodBuilder Create()
		{
			return default(AsyncVoidMethodBuilder);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002316")]
		[System.Diagnostics.DebuggerStepThrough]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002317")]
		[Address(RVA = "0x4BD0EA0", Offset = "0x4BCFAA0", VA = "0x184BD0EA0")]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002318")]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002319")]
		[Address(RVA = "0x4BD0E40", Offset = "0x4BCFA40", VA = "0x184BD0E40")]
		public void SetResult()
		{
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x4BD0D20", Offset = "0x4BCF920", VA = "0x184BD0D20")]
		public void SetException(System.Exception exception)
		{
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x4BD0CC0", Offset = "0x4BCF8C0", VA = "0x184BD0CC0")]
		private void NotifySynchronizationContextOfCompletion()
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000487")]
		internal System.Threading.Tasks.Task Task
		{
			[Token(Token = "0x600231C")]
			[Address(RVA = "0x4BD0F80", Offset = "0x4BCFB80", VA = "0x184BD0F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x0")]
		private System.Threading.SynchronizationContext m_synchronizationContext;

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x8")]
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		[FieldOffset(Offset = "0x18")]
		private System.Threading.Tasks.Task m_task;
	}
}
