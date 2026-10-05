using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[Serializable]
	public class ListDict<TKey, TValue> : List<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IListDict, IHotfixable
	{
		// Token: 0x17000021 RID: 33
		[Token(Token = "0x17000021")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6000174")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000175")]
			set
			{
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x6000176")]
		public KeyValuePair<TKey, TValue> Get(int index)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000177")]
		public void Set(int index, KeyValuePair<TKey, TValue> value)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000022")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6000178")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000023")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6000179")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600017A")]
		public ListDict()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600017B")]
		public ListDict(ListDict<TKey, TValue>.Equality equals)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600017C")]
		public ListDict(ListDict<TKey, TValue> another, [Optional] ListDict<TKey, TValue>.Equality equals)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600017D")]
		public ListDict(IEnumerable<KeyValuePair<TKey, TValue>> collection, [Optional] ListDict<TKey, TValue>.Equality equals)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600017E")]
		public void Add(KeyValuePair<TKey, TValue> pair)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600017F")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x6000180")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000181")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x6000182")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x6000183")]
		public int IndexOf(TKey key)
		{
			return 0;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x6000184")]
		public bool TryGetAndRemove(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x6000185")]
		private KeyValuePair<TKey, TValue> _MakePair(TKey key, TValue value)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000186")]
		private void _SetEquals(ListDict<TKey, TValue>.Equality equals)
		{
		}

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ListDict<TKey, TValue>.Equality m_equals;

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000188 RID: 392
		[Token(Token = "0x2000077")]
		public delegate bool Equality(TKey v1, TKey v2);
	}
}
