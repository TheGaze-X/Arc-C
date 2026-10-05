using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public enum TaskStatus
	{
		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		Created,
		// Token: 0x04000B37 RID: 2871
		[Token(Token = "0x4000B37")]
		WaitingForActivation,
		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		WaitingToRun,
		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		Running,
		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		WaitingForChildrenToComplete,
		// Token: 0x04000B3B RID: 2875
		[Token(Token = "0x4000B3B")]
		RanToCompletion,
		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		Canceled,
		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		Faulted
	}
}
