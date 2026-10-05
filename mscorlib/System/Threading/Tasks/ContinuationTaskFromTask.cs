using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	internal sealed class ContinuationTaskFromTask : Task
	{
		// Token: 0x060014BF RID: 5311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x4ADB3F0", Offset = "0x4AD9FF0", VA = "0x184ADB3F0")]
		public ContinuationTaskFromTask(Task antecedent, System.Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x4ADB2E0", Offset = "0x4AD9EE0", VA = "0x184ADB2E0", Slot = "13")]
		internal override void InnerInvoke()
		{
		}

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x50")]
		private Task m_antecedent;
	}
}
