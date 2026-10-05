using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x060014D2 RID: 5330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x4AE1A20", Offset = "0x4AE0620", VA = "0x184AE1A20")]
		internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, System.Action action, bool flowExecutionContext)
		{
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x4AE38D0", Offset = "0x4AE24D0", VA = "0x184AE38D0", Slot = "4")]
		internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
		{
		}

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x20")]
		private readonly TaskScheduler m_scheduler;
	}
}
