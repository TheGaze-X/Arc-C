using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	internal static class StringBuilderCache
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x4AFBE50", Offset = "0x4AFAA50", VA = "0x184AFBE50")]
		public static StringBuilder Acquire(int capacity = 16)
		{
			return null;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x4AFBFF0", Offset = "0x4AFABF0", VA = "0x184AFBFF0")]
		public static void Release(StringBuilder sb)
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x4AFBF40", Offset = "0x4AFAB40", VA = "0x184AFBF40")]
		public static string GetStringAndRelease(StringBuilder sb)
		{
			return null;
		}

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		[System.ThreadStatic]
		private static StringBuilder t_cachedInstance;
	}
}
