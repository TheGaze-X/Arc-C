using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	internal abstract class TaskContinuation
	{
		// Token: 0x060014C5 RID: 5317
		[Token(Token = "0x60014C5")]
		internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

		// Token: 0x060014C6 RID: 5318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x4AE1B60", Offset = "0x4AE0760", VA = "0x184AE1B60")]
		protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
		{
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TaskContinuation()
		{
		}
	}
}
