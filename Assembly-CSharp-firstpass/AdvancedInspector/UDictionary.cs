using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedInspector
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[DebuggerDisplay("Count = {Count}")]
	[ComVisible(false)]
	[Serializable]
	public class UDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, ISerializable, IDeserializationCallback, ISerializationCallbackReceiver
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		public UDictionary()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		public UDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		public UDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		public UDictionary(int capacity)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		public UDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		public UDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		public void OnDeserialization(object sender)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x17000089")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6000245")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008A")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6000246")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008B")]
		private ICollection Keys
		{
			[Token(Token = "0x6000247")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008C")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6000248")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008D")]
		private ICollection Values
		{
			[Token(Token = "0x6000249")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008E RID: 142
		[Token(Token = "0x1700008E")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600024A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024B")]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		private object Item
		{
			[Token(Token = "0x600024C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024D")]
			set
			{
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000250")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000251")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x6000252")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		private void Remove(object key)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000254")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000255")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x17000090")]
		public int Count
		{
			[Token(Token = "0x6000256")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x17000091")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000257")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x17000092")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6000258")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000093")]
		public object SyncRoot
		{
			[Token(Token = "0x6000259")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		public void Clear()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x600025C")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x600025F")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000260")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000261")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> keys;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> values;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private Dictionary<TKey, TValue> dictionary;
	}
}
