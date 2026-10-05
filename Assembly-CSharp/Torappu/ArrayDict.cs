using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	[Serializable]
	public class ArrayDict<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : IComparable
	{
		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06005A1B RID: 23067 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
		[Token(Token = "0x17000C85")]
		public int Count
		{
			[Token(Token = "0x6005A1B")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06005A1C RID: 23068 RVA: 0x0002E7B8 File Offset: 0x0002C9B8
		[Token(Token = "0x17000C86")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6005A1C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C87 RID: 3207
		[Token(Token = "0x17000C87")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6005A1D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A1E")]
			set
			{
			}
		}

		// Token: 0x17000C88 RID: 3208
		[Token(Token = "0x17000C88")]
		public KeyValuePair<TKey, TValue> this[int index]
		{
			[Token(Token = "0x6005A1F")]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
			[Token(Token = "0x6005A20")]
			set
			{
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06005A21 RID: 23073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C89")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6005A21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06005A22 RID: 23074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8A")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6005A22")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x0002E7E8 File Offset: 0x0002C9E8
		[Token(Token = "0x6005A23")]
		public bool Contains(KeyValuePair<TKey, TValue> kv)
		{
			return default(bool);
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A24")]
		public void Clear()
		{
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x0002E800 File Offset: 0x0002CA00
		[Token(Token = "0x6005A25")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x0002E818 File Offset: 0x0002CA18
		[Token(Token = "0x6005A26")]
		public int IndexOf(TKey key)
		{
			return 0;
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A27")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A28")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A29")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] target, int index)
		{
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2A")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2B")]
		public void Add(KeyValuePair<TKey, TValue> kv)
		{
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x0002E830 File Offset: 0x0002CA30
		[Token(Token = "0x6005A2C")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x0002E848 File Offset: 0x0002CA48
		[Token(Token = "0x6005A2D")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x0002E860 File Offset: 0x0002CA60
		[Token(Token = "0x6005A2E")]
		public bool Remove(KeyValuePair<TKey, TValue> kv)
		{
			return default(bool);
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2F")]
		public ArrayDict()
		{
		}

		// Token: 0x04001FF7 RID: 8183
		[Token(Token = "0x4001FF7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[JsonProperty(PropertyName = "items")]
		private ArrayDict<TKey, TValue>.SerializableKV[] _items;

		// Token: 0x04001FF8 RID: 8184
		[Token(Token = "0x4001FF8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TValue[] _test;

		// Token: 0x0200053F RID: 1343
		[Token(Token = "0x200053F")]
		[Serializable]
		public class SerializableKV
		{
			// Token: 0x06005A30 RID: 23088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A30")]
			public SerializableKV()
			{
			}

			// Token: 0x06005A31 RID: 23089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A31")]
			public SerializableKV(TKey key, TValue value)
			{
			}

			// Token: 0x06005A32 RID: 23090 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A32")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06005A33 RID: 23091 RVA: 0x0002E878 File Offset: 0x0002CA78
			[Token(Token = "0x6005A33")]
			public static implicit operator KeyValuePair<TKey, TValue>(ArrayDict<TKey, TValue>.SerializableKV kv)
			{
				return default(KeyValuePair<TKey, TValue>);
			}

			// Token: 0x06005A34 RID: 23092 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A34")]
			public static implicit operator ArrayDict<TKey, TValue>.SerializableKV(KeyValuePair<TKey, TValue> kv)
			{
				return null;
			}

			// Token: 0x04001FF9 RID: 8185
			[Token(Token = "0x4001FF9")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public TKey key;

			// Token: 0x04001FFA RID: 8186
			[Token(Token = "0x4001FFA")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public TValue value;
		}
	}
}
