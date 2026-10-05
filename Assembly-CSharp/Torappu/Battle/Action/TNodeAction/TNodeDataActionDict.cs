using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Action.TNodeAction
{
	// Token: 0x02003200 RID: 12800
	[Token(Token = "0x2003200")]
	[Serializable]
	public class TNodeDataActionDict<TKey, TPair> : IDictionary<TKey, SerializedTNodeDataAction>, ICollection<KeyValuePair<TKey, SerializedTNodeDataAction>>, IEnumerable<KeyValuePair<TKey, SerializedTNodeDataAction>>, IEnumerable where TKey : IComparable where TPair : TNodeDataActionKV<TKey>, new()
	{
		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x060144C8 RID: 83144 RVA: 0x00086538 File Offset: 0x00084738
		[Token(Token = "0x17003005")]
		public int Count
		{
			[Token(Token = "0x60144C8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x060144C9 RID: 83145 RVA: 0x00086550 File Offset: 0x00084750
		[Token(Token = "0x17003006")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60144C9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060144CA RID: 83146 RVA: 0x00086568 File Offset: 0x00084768
		[Token(Token = "0x60144CA")]
		public static KeyValuePair<Key, Value> MakePair<Key, Value>(Key key, Value value)
		{
			return default(KeyValuePair<Key, Value>);
		}

		// Token: 0x17003007 RID: 12295
		[Token(Token = "0x17003007")]
		public SerializedTNodeDataAction this[TKey key]
		{
			[Token(Token = "0x60144CB")]
			get
			{
				return null;
			}
			[Token(Token = "0x60144CC")]
			set
			{
			}
		}

		// Token: 0x17003008 RID: 12296
		[Token(Token = "0x17003008")]
		public KeyValuePair<TKey, SerializedTNodeDataAction> this[int index]
		{
			[Token(Token = "0x60144CD")]
			get
			{
				return default(KeyValuePair<TKey, SerializedTNodeDataAction>);
			}
			[Token(Token = "0x60144CE")]
			set
			{
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x060144CF RID: 83151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003009")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x60144CF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x060144D0 RID: 83152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700300A")]
		public ICollection<SerializedTNodeDataAction> Values
		{
			[Token(Token = "0x60144D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060144D1 RID: 83153 RVA: 0x00086598 File Offset: 0x00084798
		[Token(Token = "0x60144D1")]
		public bool Contains(KeyValuePair<TKey, SerializedTNodeDataAction> kv)
		{
			return default(bool);
		}

		// Token: 0x060144D2 RID: 83154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144D2")]
		public void Clear()
		{
		}

		// Token: 0x060144D3 RID: 83155 RVA: 0x000865B0 File Offset: 0x000847B0
		[Token(Token = "0x60144D3")]
		public bool TryGetValue(TKey key, out SerializedTNodeDataAction value)
		{
			return default(bool);
		}

		// Token: 0x060144D4 RID: 83156 RVA: 0x000865C8 File Offset: 0x000847C8
		[Token(Token = "0x60144D4")]
		public int IndexOf(TKey key)
		{
			return 0;
		}

		// Token: 0x060144D5 RID: 83157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144D5")]
		public IEnumerator<KeyValuePair<TKey, SerializedTNodeDataAction>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060144D6 RID: 83158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144D6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060144D7 RID: 83159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144D7")]
		public void CopyTo(KeyValuePair<TKey, SerializedTNodeDataAction>[] target, int index)
		{
		}

		// Token: 0x060144D8 RID: 83160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144D8")]
		public void Add(TKey key, SerializedTNodeDataAction value)
		{
		}

		// Token: 0x060144D9 RID: 83161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144D9")]
		public void Add(KeyValuePair<TKey, SerializedTNodeDataAction> kv)
		{
		}

		// Token: 0x060144DA RID: 83162 RVA: 0x000865E0 File Offset: 0x000847E0
		[Token(Token = "0x60144DA")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x060144DB RID: 83163 RVA: 0x000865F8 File Offset: 0x000847F8
		[Token(Token = "0x60144DB")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x060144DC RID: 83164 RVA: 0x00086610 File Offset: 0x00084810
		[Token(Token = "0x60144DC")]
		public bool Remove(KeyValuePair<TKey, SerializedTNodeDataAction> kv)
		{
			return default(bool);
		}

		// Token: 0x060144DD RID: 83165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144DD")]
		public TNodeDataActionDict()
		{
		}

		// Token: 0x04017EF0 RID: 98032
		[Token(Token = "0x4017EF0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TPair[] _items;
	}
}
