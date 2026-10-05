using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	// Token: 0x02000269 RID: 617
	[Token(Token = "0x2000269")]
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	public enum RenderingThreadingMode
	{
		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		Direct,
		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		SingleThreaded,
		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		MultiThreaded,
		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		LegacyJobified,
		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		NativeGraphicsJobs,
		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		NativeGraphicsJobsWithoutRenderThread
	}
}
