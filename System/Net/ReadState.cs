using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	internal enum ReadState
	{
		// Token: 0x04000D4B RID: 3403
		[Token(Token = "0x4000D4B")]
		None,
		// Token: 0x04000D4C RID: 3404
		[Token(Token = "0x4000D4C")]
		Status,
		// Token: 0x04000D4D RID: 3405
		[Token(Token = "0x4000D4D")]
		Headers,
		// Token: 0x04000D4E RID: 3406
		[Token(Token = "0x4000D4E")]
		Content,
		// Token: 0x04000D4F RID: 3407
		[Token(Token = "0x4000D4F")]
		Aborted
	}
}
