using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	[System.Flags]
	internal enum InternalTaskOptions
	{
		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		None = 0,
		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		InternalOptionsMask = 65280,
		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		ContinuationTask = 512,
		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		PromiseTask = 1024,
		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		LazyCancellation = 4096,
		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		QueuedByRuntime = 8192,
		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		DoNotDispose = 16384
	}
}
