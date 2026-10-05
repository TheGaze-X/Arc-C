using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Prime31.Reflection
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public class SafeDictionary<TKey, TValue>
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600011B")]
		public bool tryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x17000017 RID: 23
		[Token(Token = "0x17000017")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600011C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600011D")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		public void add(TKey key, TValue value)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		public SafeDictionary()
		{
		}

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _padlock;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<TKey, TValue> _dictionary;
	}
}
