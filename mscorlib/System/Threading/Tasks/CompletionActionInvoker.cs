using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000260 RID: 608
	[Token(Token = "0x2000260")]
	internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
	{
		// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x4ADB180", Offset = "0x4AD9D80", VA = "0x184ADB180", Slot = "4")]
		private void ExecuteWorkItem()
		{
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x10")]
		private readonly ITaskCompletionAction m_action;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x18")]
		private readonly Task m_completingTask;
	}
}
