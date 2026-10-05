using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	internal class CancellationCallbackInfo
	{
		// Token: 0x06001214 RID: 4628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x444A690", Offset = "0x4449290", VA = "0x18444A690")]
		internal CancellationCallbackInfo(System.Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
		{
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001215")]
		[Address(RVA = "0x4D486A0", Offset = "0x4D472A0", VA = "0x184D486A0")]
		internal void ExecuteCallback()
		{
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001216")]
		[Address(RVA = "0x4D48A80", Offset = "0x4D47680", VA = "0x184D48A80")]
		private static void ExecutionContextCallback(object obj)
		{
		}

		// Token: 0x04000A39 RID: 2617
		[Token(Token = "0x4000A39")]
		[FieldOffset(Offset = "0x10")]
		internal readonly System.Action<object> Callback;

		// Token: 0x04000A3A RID: 2618
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0x18")]
		internal readonly object StateForCallback;

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x20")]
		internal readonly ExecutionContext TargetExecutionContext;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x28")]
		internal readonly CancellationTokenSource CancellationTokenSource;

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x0")]
		private static ContextCallback s_executionContextCallback;

		// Token: 0x0200020A RID: 522
		[Token(Token = "0x200020A")]
		internal sealed class WithSyncContext : CancellationCallbackInfo
		{
			// Token: 0x06001217 RID: 4631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001217")]
			[Address(RVA = "0x4D60DC0", Offset = "0x4D5F9C0", VA = "0x184D60DC0")]
			internal WithSyncContext(System.Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext)
			{
			}

			// Token: 0x04000A3E RID: 2622
			[Token(Token = "0x4000A3E")]
			[FieldOffset(Offset = "0x30")]
			internal readonly SynchronizationContext TargetSyncContext;
		}
	}
}
