using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	internal static class MiscHelpers
	{
		// Token: 0x06001508 RID: 5384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001508")]
		public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
		{
			return null;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001509")]
		public static IEnumerable<TValue> EveryNth<TValue>(this IEnumerable<TValue> enumerable, int n, int start = 0)
		{
			return null;
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x600150A")]
		public static int IndexOf<TValue>(this IEnumerable<TValue> enumerable, TValue value)
		{
			return 0;
		}
	}
}
