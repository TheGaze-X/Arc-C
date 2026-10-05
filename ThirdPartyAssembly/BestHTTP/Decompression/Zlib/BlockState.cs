using System;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Zlib
{
	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20004E6")]
	internal enum BlockState
	{
		// Token: 0x040016CE RID: 5838
		[Token(Token = "0x40016CE")]
		NeedMore,
		// Token: 0x040016CF RID: 5839
		[Token(Token = "0x40016CF")]
		BlockDone,
		// Token: 0x040016D0 RID: 5840
		[Token(Token = "0x40016D0")]
		FinishStarted,
		// Token: 0x040016D1 RID: 5841
		[Token(Token = "0x40016D1")]
		FinishDone
	}
}
