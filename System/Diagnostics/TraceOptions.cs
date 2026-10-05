using System;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	[Flags]
	public enum TraceOptions
	{
		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		None = 0,
		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		LogicalOperationStack = 1,
		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		DateTime = 2,
		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		Timestamp = 4,
		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		ProcessId = 8,
		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		ThreadId = 16,
		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		Callstack = 32
	}
}
