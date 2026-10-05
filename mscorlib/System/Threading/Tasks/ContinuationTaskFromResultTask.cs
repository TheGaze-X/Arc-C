using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task
	{
		// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C1")]
		public ContinuationTaskFromResultTask(Task<TAntecedentResult> antecedent, System.Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C2")]
		internal override void InnerInvoke()
		{
		}

		// Token: 0x04000B9D RID: 2973
		[Token(Token = "0x4000B9D")]
		[FieldOffset(Offset = "0x0")]
		private Task<TAntecedentResult> m_antecedent;
	}
}
