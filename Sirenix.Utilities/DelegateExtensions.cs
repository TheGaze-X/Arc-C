using System;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public static class DelegateExtensions
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000009")]
		public static Func<TResult> Memoize<TResult>(this Func<TResult> getValue)
		{
			return null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000A")]
		public static Func<T, TResult> Memoize<T, TResult>(this Func<T, TResult> func)
		{
			return null;
		}
	}
}
