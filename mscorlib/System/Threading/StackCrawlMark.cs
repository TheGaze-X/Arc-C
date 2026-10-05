using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	[System.Serializable]
	internal enum StackCrawlMark
	{
		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		LookForMe,
		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		LookForMyCaller,
		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		LookForMyCallersCaller,
		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		LookForThread
	}
}
