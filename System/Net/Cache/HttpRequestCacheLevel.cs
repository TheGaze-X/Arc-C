using System;
using Il2CppDummyDll;

namespace System.Net.Cache
{
	// Token: 0x020003A3 RID: 931
	[Token(Token = "0x20003A3")]
	public enum HttpRequestCacheLevel
	{
		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		Default,
		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		BypassCache,
		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		CacheOnly,
		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		CacheIfAvailable,
		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		Revalidate,
		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		Reload,
		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		NoCacheNoStore,
		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		CacheOrNextCacheOnly,
		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		Refresh
	}
}
