using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
	public enum ProcessingState
	{
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		Unknown,
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		InQueue,
		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		Reading,
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		Completed,
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		Failed,
		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		Canceled
	}
}
