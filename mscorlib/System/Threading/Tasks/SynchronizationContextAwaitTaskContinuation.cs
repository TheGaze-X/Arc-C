using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x060014CA RID: 5322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x4AE1A20", Offset = "0x4AE0620", VA = "0x184AE1A20")]
		internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, System.Action action, bool flowExecutionContext)
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x4AE1760", Offset = "0x4AE0360", VA = "0x184AE1760", Slot = "4")]
		internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x4AE1690", Offset = "0x4AE0290", VA = "0x184AE1690")]
		private static void PostAction(object state)
		{
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x4AE15A0", Offset = "0x4AE01A0", VA = "0x184AE15A0")]
		[MethodImpl(256)]
		private static ContextCallback GetPostActionCallback()
		{
			return null;
		}

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SendOrPostCallback s_postCallback;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x8")]
		private static ContextCallback s_postActionCallback;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x20")]
		private readonly SynchronizationContext m_syncContext;
	}
}
