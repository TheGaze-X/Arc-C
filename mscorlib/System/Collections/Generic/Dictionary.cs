using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x020005F7 RID: 1527
	[Token(Token = "0x20005F7")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Serializable]
	public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x06002E0C RID: 11788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0C")]
		public Dictionary()
		{
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0D")]
		public Dictionary(int capacity)
		{
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0E")]
		public Dictionary(IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0F")]
		public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E10")]
		public Dictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E11")]
		public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E12")]
		protected Dictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700076C")]
		public IEqualityComparer<TKey> Comparer
		{
			[Token(Token = "0x6002E13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x00019080 File Offset: 0x00017280
		[Token(Token = "0x1700076D")]
		public int Count
		{
			[Token(Token = "0x6002E14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700076E")]
		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			[Token(Token = "0x6002E15")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700076F")]
		private ICollection<TKey> Keys
		{
			[Token(Token = "0x6002E16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000770")]
		public Dictionary<TKey, TValue>.ValueCollection Values
		{
			[Token(Token = "0x6002E17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000771")]
		private ICollection<TValue> Values
		{
			[Token(Token = "0x6002E18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000772 RID: 1906
		[Token(Token = "0x17000772")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6002E19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E1A")]
			set
			{
			}
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1B")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1C")]
		private void Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00019098 File Offset: 0x00017298
		[Token(Token = "0x6002E1D")]
		private bool Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000190B0 File Offset: 0x000172B0
		[Token(Token = "0x6002E1E")]
		private bool Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1F")]
		public void Clear()
		{
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000190C8 File Offset: 0x000172C8
		[Token(Token = "0x6002E20")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000190E0 File Offset: 0x000172E0
		[Token(Token = "0x6002E21")]
		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E22")]
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x000190F8 File Offset: 0x000172F8
		[Token(Token = "0x6002E23")]
		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default(Dictionary<TKey, TValue>.Enumerator);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002E24")]
		private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E25")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00019110 File Offset: 0x00017310
		[Token(Token = "0x6002E26")]
		private int FindEntry(TKey key)
		{
			return 0;
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00019128 File Offset: 0x00017328
		[Token(Token = "0x6002E27")]
		private int Initialize(int capacity)
		{
			return 0;
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00019140 File Offset: 0x00017340
		[Token(Token = "0x6002E28")]
		private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
		{
			return default(bool);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E29")]
		public virtual void OnDeserialization(object sender)
		{
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2A")]
		private void Resize()
		{
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2B")]
		private void Resize(int newSize, bool forceNewHashCodes)
		{
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00019158 File Offset: 0x00017358
		[Token(Token = "0x6002E2C")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00019170 File Offset: 0x00017370
		[Token(Token = "0x6002E2D")]
		public bool Remove(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00019188 File Offset: 0x00017388
		[Token(Token = "0x6002E2E")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000191A0 File Offset: 0x000173A0
		[Token(Token = "0x6002E2F")]
		public bool TryAdd(TKey key, TValue value)
		{
			return default(bool);
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x000191B8 File Offset: 0x000173B8
		[Token(Token = "0x17000773")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E31")]
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E32")]
		private void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002E33")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x000191D0 File Offset: 0x000173D0
		[Token(Token = "0x17000774")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002E34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000775")]
		private object SyncRoot
		{
			[Token(Token = "0x6002E35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x000191E8 File Offset: 0x000173E8
		[Token(Token = "0x17000776")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6002E36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x00019200 File Offset: 0x00017400
		[Token(Token = "0x17000777")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002E37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000778")]
		private ICollection Keys
		{
			[Token(Token = "0x6002E38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000779")]
		private ICollection Values
		{
			[Token(Token = "0x6002E39")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002E3B RID: 11835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077A")]
		private object Item
		{
			[Token(Token = "0x6002E3A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E3B")]
			set
			{
			}
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00019218 File Offset: 0x00017418
		[Token(Token = "0x6002E3C")]
		private static bool IsCompatibleKey(object key)
		{
			return default(bool);
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E3D")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x00019230 File Offset: 0x00017430
		[Token(Token = "0x6002E3E")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002E3F")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E40")]
		private void Remove(object key)
		{
		}

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x0")]
		private int[] _buckets;

		// Token: 0x04001A26 RID: 6694
		[Token(Token = "0x4001A26")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.Entry[] _entries;

		// Token: 0x04001A27 RID: 6695
		[Token(Token = "0x4001A27")]
		[FieldOffset(Offset = "0x0")]
		private int _count;

		// Token: 0x04001A28 RID: 6696
		[Token(Token = "0x4001A28")]
		[FieldOffset(Offset = "0x0")]
		private int _freeList;

		// Token: 0x04001A29 RID: 6697
		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x0")]
		private int _freeCount;

		// Token: 0x04001A2A RID: 6698
		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04001A2B RID: 6699
		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x04001A2C RID: 6700
		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x04001A2D RID: 6701
		[Token(Token = "0x4001A2D")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x04001A2E RID: 6702
		[Token(Token = "0x4001A2E")]
		[FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		// Token: 0x04001A2F RID: 6703
		[Token(Token = "0x4001A2F")]
		private const string VersionName = "Version";

		// Token: 0x04001A30 RID: 6704
		[Token(Token = "0x4001A30")]
		private const string HashSizeName = "HashSize";

		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		private const string KeyValuePairsName = "KeyValuePairs";

		// Token: 0x04001A32 RID: 6706
		[Token(Token = "0x4001A32")]
		private const string ComparerName = "Comparer";

		// Token: 0x020005F8 RID: 1528
		[Token(Token = "0x20005F8")]
		private struct Entry
		{
			// Token: 0x04001A33 RID: 6707
			[Token(Token = "0x4001A33")]
			[FieldOffset(Offset = "0x0")]
			public int hashCode;

			// Token: 0x04001A34 RID: 6708
			[Token(Token = "0x4001A34")]
			[FieldOffset(Offset = "0x0")]
			public int next;

			// Token: 0x04001A35 RID: 6709
			[Token(Token = "0x4001A35")]
			[FieldOffset(Offset = "0x0")]
			public TKey key;

			// Token: 0x04001A36 RID: 6710
			[Token(Token = "0x4001A36")]
			[FieldOffset(Offset = "0x0")]
			public TValue value;
		}

		// Token: 0x020005F9 RID: 1529
		[Token(Token = "0x20005F9")]
		[System.Serializable]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, System.IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x06002E41 RID: 11841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E41")]
			internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
			}

			// Token: 0x06002E42 RID: 11842 RVA: 0x00019248 File Offset: 0x00017448
			[Token(Token = "0x6002E42")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00019260 File Offset: 0x00017460
			[Token(Token = "0x1700077B")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6002E43")]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			// Token: 0x06002E44 RID: 11844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E44")]
			public void Dispose()
			{
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06002E45 RID: 11845 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700077C")]
			private object Current
			{
				[Token(Token = "0x6002E45")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002E46 RID: 11846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E46")]
			private void Reset()
			{
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06002E47 RID: 11847 RVA: 0x00019278 File Offset: 0x00017478
			[Token(Token = "0x1700077D")]
			private DictionaryEntry Entry
			{
				[Token(Token = "0x6002E47")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06002E48 RID: 11848 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700077E")]
			private object Key
			{
				[Token(Token = "0x6002E48")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x06002E49 RID: 11849 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700077F")]
			private object Value
			{
				[Token(Token = "0x6002E49")]
				get
				{
					return null;
				}
			}

			// Token: 0x04001A37 RID: 6711
			[Token(Token = "0x4001A37")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			// Token: 0x04001A38 RID: 6712
			[Token(Token = "0x4001A38")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04001A39 RID: 6713
			[Token(Token = "0x4001A39")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001A3A RID: 6714
			[Token(Token = "0x4001A3A")]
			[FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> _current;

			// Token: 0x04001A3B RID: 6715
			[Token(Token = "0x4001A3B")]
			[FieldOffset(Offset = "0x0")]
			private int _getEnumeratorRetType;
		}

		// Token: 0x020005FA RID: 1530
		[Token(Token = "0x20005FA")]
		[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
		[System.Diagnostics.DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[System.Serializable]
		public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			// Token: 0x06002E4A RID: 11850 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E4A")]
			public KeyCollection(Dictionary<TKey, TValue> dictionary)
			{
			}

			// Token: 0x06002E4B RID: 11851 RVA: 0x00019290 File Offset: 0x00017490
			[Token(Token = "0x6002E4B")]
			public Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				return default(Dictionary<TKey, TValue>.KeyCollection.Enumerator);
			}

			// Token: 0x06002E4C RID: 11852 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E4C")]
			public void CopyTo(TKey[] array, int index)
			{
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000192A8 File Offset: 0x000174A8
			[Token(Token = "0x17000780")]
			public int Count
			{
				[Token(Token = "0x6002E4D")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06002E4E RID: 11854 RVA: 0x000192C0 File Offset: 0x000174C0
			[Token(Token = "0x17000781")]
			private bool IsReadOnly
			{
				[Token(Token = "0x6002E4E")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002E4F RID: 11855 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E4F")]
			private void Add(TKey item)
			{
			}

			// Token: 0x06002E50 RID: 11856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E50")]
			private void Clear()
			{
			}

			// Token: 0x06002E51 RID: 11857 RVA: 0x000192D8 File Offset: 0x000174D8
			[Token(Token = "0x6002E51")]
			private bool Contains(TKey item)
			{
				return default(bool);
			}

			// Token: 0x06002E52 RID: 11858 RVA: 0x000192F0 File Offset: 0x000174F0
			[Token(Token = "0x6002E52")]
			private bool Remove(TKey item)
			{
				return default(bool);
			}

			// Token: 0x06002E53 RID: 11859 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002E53")]
			private IEnumerator<TKey> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002E54 RID: 11860 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002E54")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002E55 RID: 11861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E55")]
			private void CopyTo(System.Array array, int index)
			{
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06002E56 RID: 11862 RVA: 0x00019308 File Offset: 0x00017508
			[Token(Token = "0x17000782")]
			private bool IsSynchronized
			{
				[Token(Token = "0x6002E56")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06002E57 RID: 11863 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000783")]
			private object SyncRoot
			{
				[Token(Token = "0x6002E57")]
				get
				{
					return null;
				}
			}

			// Token: 0x04001A3C RID: 6716
			[Token(Token = "0x4001A3C")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			// Token: 0x020005FB RID: 1531
			[Token(Token = "0x20005FB")]
			[System.Serializable]
			public struct Enumerator : IEnumerator<TKey>, System.IDisposable, IEnumerator
			{
				// Token: 0x06002E58 RID: 11864 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002E58")]
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
				}

				// Token: 0x06002E59 RID: 11865 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002E59")]
				public void Dispose()
				{
				}

				// Token: 0x06002E5A RID: 11866 RVA: 0x00019320 File Offset: 0x00017520
				[Token(Token = "0x6002E5A")]
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000784 RID: 1924
				// (get) Token: 0x06002E5B RID: 11867 RVA: 0x000020CA File Offset: 0x000002CA
				[Token(Token = "0x17000784")]
				public TKey Current
				{
					[Token(Token = "0x6002E5B")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000785 RID: 1925
				// (get) Token: 0x06002E5C RID: 11868 RVA: 0x000020CA File Offset: 0x000002CA
				[Token(Token = "0x17000785")]
				private object Current
				{
					[Token(Token = "0x6002E5C")]
					get
					{
						return null;
					}
				}

				// Token: 0x06002E5D RID: 11869 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002E5D")]
				private void Reset()
				{
				}

				// Token: 0x04001A3D RID: 6717
				[Token(Token = "0x4001A3D")]
				[FieldOffset(Offset = "0x0")]
				private Dictionary<TKey, TValue> _dictionary;

				// Token: 0x04001A3E RID: 6718
				[Token(Token = "0x4001A3E")]
				[FieldOffset(Offset = "0x0")]
				private int _index;

				// Token: 0x04001A3F RID: 6719
				[Token(Token = "0x4001A3F")]
				[FieldOffset(Offset = "0x0")]
				private int _version;

				// Token: 0x04001A40 RID: 6720
				[Token(Token = "0x4001A40")]
				[FieldOffset(Offset = "0x0")]
				private TKey _currentKey;
			}
		}

		// Token: 0x020005FC RID: 1532
		[Token(Token = "0x20005FC")]
		[System.Diagnostics.DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
		[System.Serializable]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			// Token: 0x06002E5E RID: 11870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E5E")]
			public ValueCollection(Dictionary<TKey, TValue> dictionary)
			{
			}

			// Token: 0x06002E5F RID: 11871 RVA: 0x00019338 File Offset: 0x00017538
			[Token(Token = "0x6002E5F")]
			public Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				return default(Dictionary<TKey, TValue>.ValueCollection.Enumerator);
			}

			// Token: 0x06002E60 RID: 11872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E60")]
			public void CopyTo(TValue[] array, int index)
			{
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00019350 File Offset: 0x00017550
			[Token(Token = "0x17000786")]
			public int Count
			{
				[Token(Token = "0x6002E61")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06002E62 RID: 11874 RVA: 0x00019368 File Offset: 0x00017568
			[Token(Token = "0x17000787")]
			private bool IsReadOnly
			{
				[Token(Token = "0x6002E62")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002E63 RID: 11875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E63")]
			private void Add(TValue item)
			{
			}

			// Token: 0x06002E64 RID: 11876 RVA: 0x00019380 File Offset: 0x00017580
			[Token(Token = "0x6002E64")]
			private bool Remove(TValue item)
			{
				return default(bool);
			}

			// Token: 0x06002E65 RID: 11877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E65")]
			private void Clear()
			{
			}

			// Token: 0x06002E66 RID: 11878 RVA: 0x00019398 File Offset: 0x00017598
			[Token(Token = "0x6002E66")]
			private bool Contains(TValue item)
			{
				return default(bool);
			}

			// Token: 0x06002E67 RID: 11879 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002E67")]
			private IEnumerator<TValue> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002E68 RID: 11880 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002E68")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002E69 RID: 11881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E69")]
			private void CopyTo(System.Array array, int index)
			{
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x06002E6A RID: 11882 RVA: 0x000193B0 File Offset: 0x000175B0
			[Token(Token = "0x17000788")]
			private bool IsSynchronized
			{
				[Token(Token = "0x6002E6A")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06002E6B RID: 11883 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000789")]
			private object SyncRoot
			{
				[Token(Token = "0x6002E6B")]
				get
				{
					return null;
				}
			}

			// Token: 0x04001A41 RID: 6721
			[Token(Token = "0x4001A41")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			// Token: 0x020005FD RID: 1533
			[Token(Token = "0x20005FD")]
			[System.Serializable]
			public struct Enumerator : IEnumerator<TValue>, System.IDisposable, IEnumerator
			{
				// Token: 0x06002E6C RID: 11884 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002E6C")]
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
				}

				// Token: 0x06002E6D RID: 11885 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002E6D")]
				public void Dispose()
				{
				}

				// Token: 0x06002E6E RID: 11886 RVA: 0x000193C8 File Offset: 0x000175C8
				[Token(Token = "0x6002E6E")]
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x1700078A RID: 1930
				// (get) Token: 0x06002E6F RID: 11887 RVA: 0x000020CA File Offset: 0x000002CA
				[Token(Token = "0x1700078A")]
				public TValue Current
				{
					[Token(Token = "0x6002E6F")]
					get
					{
						return null;
					}
				}

				// Token: 0x1700078B RID: 1931
				// (get) Token: 0x06002E70 RID: 11888 RVA: 0x000020CA File Offset: 0x000002CA
				[Token(Token = "0x1700078B")]
				private object Current
				{
					[Token(Token = "0x6002E70")]
					get
					{
						return null;
					}
				}

				// Token: 0x06002E71 RID: 11889 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002E71")]
				private void Reset()
				{
				}

				// Token: 0x04001A42 RID: 6722
				[Token(Token = "0x4001A42")]
				[FieldOffset(Offset = "0x0")]
				private Dictionary<TKey, TValue> _dictionary;

				// Token: 0x04001A43 RID: 6723
				[Token(Token = "0x4001A43")]
				[FieldOffset(Offset = "0x0")]
				private int _index;

				// Token: 0x04001A44 RID: 6724
				[Token(Token = "0x4001A44")]
				[FieldOffset(Offset = "0x0")]
				private int _version;

				// Token: 0x04001A45 RID: 6725
				[Token(Token = "0x4001A45")]
				[FieldOffset(Offset = "0x0")]
				private TValue _currentValue;
			}
		}
	}
}
