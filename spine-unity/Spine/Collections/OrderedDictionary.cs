using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Spine.Collections
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(OrderedDictionaryDebugView<, >))]
	public sealed class OrderedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IList<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600077D")]
		public OrderedDictionary()
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600077E")]
		public OrderedDictionary(int capacity)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600077F")]
		public OrderedDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000780")]
		public OrderedDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001C9")]
		public IEqualityComparer<TKey> Comparer
		{
			[Token(Token = "0x6000781")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000782")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000783")]
		public void Insert(int index, TKey key, TValue value)
		{
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x6000784")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000785")]
		public TKey GetKey(int index)
		{
			return null;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6000786")]
		public int IndexOf(TKey key)
		{
			return 0;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001CA")]
		public OrderedDictionary<TKey, TValue>.KeyCollection Keys
		{
			[Token(Token = "0x6000787")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x6000788")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000789")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x600078A")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001CB")]
		public OrderedDictionary<TKey, TValue>.ValueCollection Values
		{
			[Token(Token = "0x600078B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CC RID: 460
		[Token(Token = "0x170001CC")]
		public TValue this[int index]
		{
			[Token(Token = "0x600078C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078D")]
			set
			{
			}
		}

		// Token: 0x170001CD RID: 461
		[Token(Token = "0x170001CD")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600078E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078F")]
			set
			{
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000790")]
		public void Clear()
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x170001CE")]
		public int Count
		{
			[Token(Token = "0x6000791")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000792")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x6000793")]
		private int IndexOf(KeyValuePair<TKey, TValue> item)
		{
			return 0;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000794")]
		private void Insert(int index, KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00004A54 File Offset: 0x00002C54
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001CF")]
		private KeyValuePair<TKey, TValue> Item
		{
			[Token(Token = "0x6000795")]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
			[Token(Token = "0x6000796")]
			set
			{
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001D0")]
		private ICollection<TKey> Keys
		{
			[Token(Token = "0x6000797")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001D1")]
		private ICollection<TValue> Values
		{
			[Token(Token = "0x6000798")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000799")]
		private void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x600079A")]
		private bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600079B")]
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x170001D2")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600079C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x600079D")]
		private bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600079E")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<TKey, int> dictionary;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<TKey> keys;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<TValue> values;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x0")]
		private int version;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		private const string CollectionModifiedMessage = "Collection was modified; enumeration operation may not execute.";

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		private const string EditReadOnlyListMessage = "An attempt was made to edit a read-only list.";

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		private const string IndexOutOfRangeMessage = "The index is negative or outside the bounds of the collection.";

		// Token: 0x020000D4 RID: 212
		[Token(Token = "0x20000D4")]
		public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable
		{
			// Token: 0x0600079F RID: 1951 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600079F")]
			internal KeyCollection(Dictionary<TKey, int> dictionary)
			{
			}

			// Token: 0x060007A0 RID: 1952 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007A0")]
			public void CopyTo(TKey[] array, int arrayIndex)
			{
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00004AB4 File Offset: 0x00002CB4
			[Token(Token = "0x170001D3")]
			public int Count
			{
				[Token(Token = "0x60007A1")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060007A2 RID: 1954 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60007A2")]
			public IEnumerator<TKey> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x00004ACC File Offset: 0x00002CCC
			[Token(Token = "0x60007A3")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private bool Contains(TKey item)
			{
				return default(bool);
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007A4")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private void Add(TKey item)
			{
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007A5")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private void Clear()
			{
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00004AE4 File Offset: 0x00002CE4
			[Token(Token = "0x170001D4")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private bool IsReadOnly
			{
				[Token(Token = "0x60007A6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060007A7 RID: 1959 RVA: 0x00004AFC File Offset: 0x00002CFC
			[Token(Token = "0x60007A7")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private bool Remove(TKey item)
			{
				return default(bool);
			}

			// Token: 0x060007A8 RID: 1960 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60007A8")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000496 RID: 1174
			[Token(Token = "0x4000496")]
			[FieldOffset(Offset = "0x0")]
			private readonly Dictionary<TKey, int> dictionary;
		}

		// Token: 0x020000D5 RID: 213
		[Token(Token = "0x20000D5")]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable
		{
			// Token: 0x060007A9 RID: 1961 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007A9")]
			internal ValueCollection(List<TValue> values)
			{
			}

			// Token: 0x060007AA RID: 1962 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007AA")]
			public void CopyTo(TValue[] array, int arrayIndex)
			{
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x060007AB RID: 1963 RVA: 0x00004B14 File Offset: 0x00002D14
			[Token(Token = "0x170001D5")]
			public int Count
			{
				[Token(Token = "0x60007AB")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060007AC RID: 1964 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60007AC")]
			public IEnumerator<TValue> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060007AD RID: 1965 RVA: 0x00004B2C File Offset: 0x00002D2C
			[Token(Token = "0x60007AD")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private bool Contains(TValue item)
			{
				return default(bool);
			}

			// Token: 0x060007AE RID: 1966 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007AE")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private void Add(TValue item)
			{
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007AF")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private void Clear()
			{
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00004B44 File Offset: 0x00002D44
			[Token(Token = "0x170001D6")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private bool IsReadOnly
			{
				[Token(Token = "0x60007B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060007B1 RID: 1969 RVA: 0x00004B5C File Offset: 0x00002D5C
			[Token(Token = "0x60007B1")]
			[EditorBrowsable(EditorBrowsableState.Never)]
			private bool Remove(TValue item)
			{
				return default(bool);
			}

			// Token: 0x060007B2 RID: 1970 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60007B2")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000497 RID: 1175
			[Token(Token = "0x4000497")]
			[FieldOffset(Offset = "0x0")]
			private readonly List<TValue> values;
		}
	}
}
