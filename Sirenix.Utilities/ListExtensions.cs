using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public static class ListExtensions
	{
		// Token: 0x06000129 RID: 297 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000129")]
		public static void SetLength<T>(ref IList<T> list, int length)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012A")]
		public static void SetLength<T>(ref IList<T> list, int length, Func<T> newElement)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012B")]
		public static void SetLength<T>(this IList<T> list, int length)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012C")]
		public static void SetLength<T>(this IList<T> list, int length, Func<T> newElement)
		{
		}
	}
}
