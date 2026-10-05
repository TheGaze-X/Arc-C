using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	internal struct ExecutionContextSwitcher
	{
		// Token: 0x06001252 RID: 4690 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x4D53510", Offset = "0x4D52110", VA = "0x184D53510")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		internal bool UndoNoThrow()
		{
			return default(bool);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x4D53530", Offset = "0x4D52130", VA = "0x184D53530")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		internal void Undo()
		{
		}

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x0")]
		internal ExecutionContext.Reader outerEC;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x8")]
		internal bool outerECBelongsToScope;

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x10")]
		internal object hecsw;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x18")]
		internal Thread thread;
	}
}
