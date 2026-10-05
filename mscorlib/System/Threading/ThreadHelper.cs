using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000223")]
	internal class ThreadHelper
	{
		// Token: 0x060012B5 RID: 4789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal ThreadHelper(System.Delegate start)
		{
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
		internal void SetExecutionContextHelper(ExecutionContext ec)
		{
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x4AED450", Offset = "0x4AEC050", VA = "0x184AED450")]
		private static void ThreadStart_Context(object state)
		{
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x4AED5A0", Offset = "0x4AEC1A0", VA = "0x184AED5A0")]
		internal void ThreadStart(object obj)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x4AED6C0", Offset = "0x4AEC2C0", VA = "0x184AED6C0")]
		internal void ThreadStart()
		{
		}

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x10")]
		private System.Delegate _start;

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x18")]
		private object _startArg;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x20")]
		private ExecutionContext _executionContext;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x0")]
		internal static ContextCallback _ccb;
	}
}
