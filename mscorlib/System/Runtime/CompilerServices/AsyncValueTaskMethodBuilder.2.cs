using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200048C RID: 1164
	[Token(Token = "0x200048C")]
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder<TResult>
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x00013F20 File Offset: 0x00012120
		[Token(Token = "0x60022B7")]
		public static AsyncValueTaskMethodBuilder<TResult> Create()
		{
			return default(AsyncValueTaskMethodBuilder<TResult>);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B8")]
		[MethodImpl(256)]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B9")]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BA")]
		public void SetResult(TResult result)
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BB")]
		public void SetException(System.Exception exception)
		{
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x00013F38 File Offset: 0x00012138
		[Token(Token = "0x17000473")]
		public System.Threading.Tasks.ValueTask<TResult> Task
		{
			[Token(Token = "0x60022BC")]
			get
			{
				return default(System.Threading.Tasks.ValueTask<TResult>);
			}
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BD")]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x040013D5 RID: 5077
		[Token(Token = "0x40013D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AsyncTaskMethodBuilder<TResult> _methodBuilder;

		// Token: 0x040013D6 RID: 5078
		[Token(Token = "0x40013D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult _result;

		// Token: 0x040013D7 RID: 5079
		[Token(Token = "0x40013D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _haveResult;

		// Token: 0x040013D8 RID: 5080
		[Token(Token = "0x40013D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _useBuilder;
	}
}
