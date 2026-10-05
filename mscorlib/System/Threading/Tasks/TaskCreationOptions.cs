using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2000262")]
	[System.Flags]
	public enum TaskCreationOptions
	{
		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		None = 0,
		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		PreferFairness = 1,
		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		LongRunning = 2,
		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		AttachedToParent = 4,
		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		DenyChildAttach = 8,
		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		HideScheduler = 16,
		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		RunContinuationsAsynchronously = 64
	}
}
