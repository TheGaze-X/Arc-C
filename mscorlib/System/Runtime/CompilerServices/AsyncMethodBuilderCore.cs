using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	internal struct AsyncMethodBuilderCore
	{
		// Token: 0x06002332 RID: 9010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002332")]
		[Address(RVA = "0x4BD0280", Offset = "0x4BCEE80", VA = "0x184BD0280")]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x4BCFC10", Offset = "0x4BCE810", VA = "0x184BCFC10")]
		internal System.Action GetCompletionAction(System.Threading.Tasks.Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize)
		{
			return null;
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x4BCFE60", Offset = "0x4BCEA60", VA = "0x184BCFE60")]
		private System.Action OutputAsyncCausalityEvents(System.Threading.Tasks.Task innerTask, System.Action continuation)
		{
			return null;
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x4BD0080", Offset = "0x4BCEC80", VA = "0x184BD0080")]
		internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, System.Threading.Tasks.Task builtTask)
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x4BD0360", Offset = "0x4BCEF60", VA = "0x184BD0360")]
		internal static void ThrowAsync(System.Exception exception, System.Threading.SynchronizationContext targetContext)
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x4BCFA90", Offset = "0x4BCE690", VA = "0x184BCFA90")]
		internal static System.Action CreateContinuationWrapper(System.Action continuation, System.Action invokeAction, [System.Runtime.InteropServices.Optional] System.Threading.Tasks.Task innerTask)
		{
			return null;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x4BD0680", Offset = "0x4BCF280", VA = "0x184BD0680")]
		internal static System.Threading.Tasks.Task TryGetContinuationTask(System.Action action)
		{
			return null;
		}

		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal IAsyncStateMachine m_stateMachine;

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal System.Action m_defaultContextAction;

		// Token: 0x020004B8 RID: 1208
		[Token(Token = "0x20004B8")]
		internal sealed class MoveNextRunner
		{
			// Token: 0x06002339 RID: 9017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002339")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			internal MoveNextRunner(System.Threading.ExecutionContext context, IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0600233A RID: 9018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600233A")]
			[Address(RVA = "0x4BDB2C0", Offset = "0x4BD9EC0", VA = "0x184BDB2C0")]
			internal void Run()
			{
			}

			// Token: 0x0600233B RID: 9019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600233B")]
			[Address(RVA = "0x4BDB220", Offset = "0x4BD9E20", VA = "0x184BDB220")]
			private static void InvokeMoveNext(object stateMachine)
			{
			}

			// Token: 0x04001401 RID: 5121
			[Token(Token = "0x4001401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly System.Threading.ExecutionContext m_context;

			// Token: 0x04001402 RID: 5122
			[Token(Token = "0x4001402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal IAsyncStateMachine m_stateMachine;

			// Token: 0x04001403 RID: 5123
			[Token(Token = "0x4001403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static System.Threading.ContextCallback s_invokeMoveNext;
		}

		// Token: 0x020004B9 RID: 1209
		[Token(Token = "0x20004B9")]
		private class ContinuationWrapper
		{
			// Token: 0x0600233C RID: 9020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600233C")]
			[Address(RVA = "0x4BD1400", Offset = "0x4BD0000", VA = "0x184BD1400")]
			internal ContinuationWrapper(System.Action continuation, System.Action invokeAction, System.Threading.Tasks.Task innerTask)
			{
			}

			// Token: 0x0600233D RID: 9021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600233D")]
			[Address(RVA = "0x11AB120", Offset = "0x11A9D20", VA = "0x1811AB120")]
			internal void Invoke()
			{
			}

			// Token: 0x04001404 RID: 5124
			[Token(Token = "0x4001404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal readonly System.Action m_continuation;

			// Token: 0x04001405 RID: 5125
			[Token(Token = "0x4001405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly System.Action m_invokeAction;

			// Token: 0x04001406 RID: 5126
			[Token(Token = "0x4001406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal readonly System.Threading.Tasks.Task m_innerTask;
		}
	}
}
