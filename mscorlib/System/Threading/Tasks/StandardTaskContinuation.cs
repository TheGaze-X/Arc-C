using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	internal class StandardTaskContinuation : TaskContinuation
	{
		// Token: 0x060014C8 RID: 5320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x4AE14D0", Offset = "0x4AE00D0", VA = "0x184AE14D0")]
		internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x4AE1390", Offset = "0x4ADFF90", VA = "0x184AE1390", Slot = "4")]
		internal override void Run(Task completedTask, bool bCanInlineContinuationTask)
		{
		}

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Task m_task;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x18")]
		internal readonly TaskContinuationOptions m_options;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x20")]
		private readonly TaskScheduler m_taskScheduler;
	}
}
