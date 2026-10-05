using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public static class SDKPromiseExtensions
	{
		// Token: 0x0600027F RID: 639 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x4A182A0", Offset = "0x4A16EA0", VA = "0x184A182A0")]
		public static void RejectWithString(this ISDKPromise promise, string errorInfo)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000280")]
		public static void FulfillWithType<T>(this SDKPromise<T> promise, T param) where T : class
		{
		}
	}
}
