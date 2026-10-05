using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Extension
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	public static class DictionaryExtensions
	{
		// Token: 0x06000E46 RID: 3654 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x6000E46")]
		public static bool IsNull<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
		{
			return default(bool);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x6000E47")]
		public static bool IsEmpty<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
		{
			return default(bool);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x6000E48")]
		public static bool IsNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
		{
			return default(bool);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E49")]
		public static void AddValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4A")]
		public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			return null;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E4B")]
		public static void AddDictionary<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Dictionary<TKey, TValue> otherDic)
		{
		}
	}
}
