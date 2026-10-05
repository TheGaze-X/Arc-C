using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	[System.Flags]
	public enum TaskContinuationOptions
	{
		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4000B87")]
		None = 0,
		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4000B88")]
		PreferFairness = 1,
		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		LongRunning = 2,
		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		AttachedToParent = 4,
		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		DenyChildAttach = 8,
		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		HideScheduler = 16,
		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		LazyCancellation = 32,
		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4000B8E")]
		RunContinuationsAsynchronously = 64,
		// Token: 0x04000B8F RID: 2959
		[Token(Token = "0x4000B8F")]
		NotOnRanToCompletion = 65536,
		// Token: 0x04000B90 RID: 2960
		[Token(Token = "0x4000B90")]
		NotOnFaulted = 131072,
		// Token: 0x04000B91 RID: 2961
		[Token(Token = "0x4000B91")]
		NotOnCanceled = 262144,
		// Token: 0x04000B92 RID: 2962
		[Token(Token = "0x4000B92")]
		OnlyOnRanToCompletion = 393216,
		// Token: 0x04000B93 RID: 2963
		[Token(Token = "0x4000B93")]
		OnlyOnFaulted = 327680,
		// Token: 0x04000B94 RID: 2964
		[Token(Token = "0x4000B94")]
		OnlyOnCanceled = 196608,
		// Token: 0x04000B95 RID: 2965
		[Token(Token = "0x4000B95")]
		ExecuteSynchronously = 524288
	}
}
