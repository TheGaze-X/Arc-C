using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult>
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C3")]
		public ContinuationResultTaskFromResultTask(Task<TAntecedentResult> antecedent, System.Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C4")]
		internal override void InnerInvoke()
		{
		}

		// Token: 0x04000B9E RID: 2974
		[Token(Token = "0x4000B9E")]
		[FieldOffset(Offset = "0x0")]
		private Task<TAntecedentResult> m_antecedent;
	}
}
