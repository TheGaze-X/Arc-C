using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Concurrent
{
	// Token: 0x020005EC RID: 1516
	[Token(Token = "0x20005EC")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Serializable]
	public class ConcurrentDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06002D6E RID: 11630 RVA: 0x00018BD0 File Offset: 0x00016DD0
		[Token(Token = "0x6002D6E")]
		private static bool IsValueWriteAtomic()
		{
			return default(bool);
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6F")]
		public ConcurrentDictionary()
		{
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D70")]
		public ConcurrentDictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D71")]
		private void InitializeFromCollection(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> collection)
		{
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D72")]
		internal ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00018BE8 File Offset: 0x00016DE8
		[Token(Token = "0x6002D73")]
		public bool TryAdd(TKey key, TValue value)
		{
			return default(bool);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00018C00 File Offset: 0x00016E00
		[Token(Token = "0x6002D74")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00018C18 File Offset: 0x00016E18
		[Token(Token = "0x6002D75")]
		public bool TryRemove(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x00018C30 File Offset: 0x00016E30
		[Token(Token = "0x6002D76")]
		private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			return default(bool);
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00018C48 File Offset: 0x00016E48
		[Token(Token = "0x6002D77")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00018C60 File Offset: 0x00016E60
		[Token(Token = "0x6002D78")]
		private bool TryGetValueInternal(TKey key, int hashcode, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D79")]
		public void Clear()
		{
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7A")]
		private void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D7B")]
		public System.Collections.Generic.KeyValuePair<TKey, TValue>[] ToArray()
		{
			return null;
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7C")]
		private void CopyToPairs(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7D")]
		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7E")]
		private void CopyToObjects(object[] array, int index)
		{
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D7F")]
		public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00018C78 File Offset: 0x00016E78
		[Token(Token = "0x6002D80")]
		private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			return default(bool);
		}

		// Token: 0x17000744 RID: 1860
		[Token(Token = "0x17000744")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6002D81")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D82")]
			set
			{
			}
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D83")]
		[MethodImpl(8)]
		private static void ThrowKeyNotFoundException(object key)
		{
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D84")]
		[MethodImpl(8)]
		private static void ThrowKeyNullException()
		{
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x00018C90 File Offset: 0x00016E90
		[Token(Token = "0x17000745")]
		public int Count
		{
			[Token(Token = "0x6002D85")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00018CA8 File Offset: 0x00016EA8
		[Token(Token = "0x6002D86")]
		private int GetCountInternal()
		{
			return 0;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D87")]
		public TValue GetOrAdd(TKey key, System.Func<TKey, TValue> valueFactory)
		{
			return null;
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D88")]
		public TValue GetOrAdd(TKey key, TValue value)
		{
			return null;
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D89")]
		private void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00018CC0 File Offset: 0x00016EC0
		[Token(Token = "0x6002D8A")]
		private bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000746")]
		public System.Collections.Generic.ICollection<TKey> Keys
		{
			[Token(Token = "0x6002D8B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000747")]
		public System.Collections.Generic.ICollection<TValue> Values
		{
			[Token(Token = "0x6002D8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D8D")]
		private void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x00018CD8 File Offset: 0x00016ED8
		[Token(Token = "0x6002D8E")]
		private bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x00018CF0 File Offset: 0x00016EF0
		[Token(Token = "0x17000748")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002D8F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x00018D08 File Offset: 0x00016F08
		[Token(Token = "0x6002D90")]
		private bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D91")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D92")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00018D20 File Offset: 0x00016F20
		[Token(Token = "0x6002D93")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002D94")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002D95 RID: 11669 RVA: 0x00018D38 File Offset: 0x00016F38
		[Token(Token = "0x17000749")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6002D95")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x00018D50 File Offset: 0x00016F50
		[Token(Token = "0x1700074A")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002D96")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700074B")]
		private ICollection Keys
		{
			[Token(Token = "0x6002D97")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D98")]
		private void Remove(object key)
		{
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700074C")]
		private ICollection Values
		{
			[Token(Token = "0x6002D99")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074D")]
		private object Item
		{
			[Token(Token = "0x6002D9A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D9B")]
			set
			{
			}
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9C")]
		private void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x00018D68 File Offset: 0x00016F68
		[Token(Token = "0x1700074E")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002D9D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700074F")]
		private object SyncRoot
		{
			[Token(Token = "0x6002D9E")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9F")]
		private void GrowTable(ConcurrentDictionary<TKey, TValue>.Tables tables)
		{
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00018D80 File Offset: 0x00016F80
		[Token(Token = "0x6002DA0")]
		private static int GetBucket(int hashcode, int bucketCount)
		{
			return 0;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA1")]
		private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
		{
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x00018D98 File Offset: 0x00016F98
		[Token(Token = "0x17000750")]
		private static int DefaultConcurrencyLevel
		{
			[Token(Token = "0x6002DA2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA3")]
		private void AcquireAllLocks(ref int locksAcquired)
		{
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA4")]
		private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA5")]
		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002DA6")]
		private System.Collections.ObjectModel.ReadOnlyCollection<TKey> GetKeys()
		{
			return null;
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002DA7")]
		private System.Collections.ObjectModel.ReadOnlyCollection<TValue> GetValues()
		{
			return null;
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA8")]
		[System.Runtime.Serialization.OnSerializing]
		private void OnSerializing(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA9")]
		[System.Runtime.Serialization.OnSerialized]
		private void OnSerialized(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DAA")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x0")]
		[System.NonSerialized]
		private ConcurrentDictionary<TKey, TValue>.Tables _tables;

		// Token: 0x04001A05 RID: 6661
		[Token(Token = "0x4001A05")]
		[FieldOffset(Offset = "0x0")]
		private System.Collections.Generic.IEqualityComparer<TKey> _comparer;

		// Token: 0x04001A06 RID: 6662
		[Token(Token = "0x4001A06")]
		[FieldOffset(Offset = "0x0")]
		[System.NonSerialized]
		private readonly bool _growLockArray;

		// Token: 0x04001A07 RID: 6663
		[Token(Token = "0x4001A07")]
		[FieldOffset(Offset = "0x0")]
		[System.NonSerialized]
		private int _budget;

		// Token: 0x04001A08 RID: 6664
		[Token(Token = "0x4001A08")]
		[FieldOffset(Offset = "0x0")]
		private System.Collections.Generic.KeyValuePair<TKey, TValue>[] _serializationArray;

		// Token: 0x04001A09 RID: 6665
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x0")]
		private int _serializationConcurrencyLevel;

		// Token: 0x04001A0A RID: 6666
		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x0")]
		private int _serializationCapacity;

		// Token: 0x04001A0B RID: 6667
		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool s_isValueWriteAtomic;

		// Token: 0x020005ED RID: 1517
		[Token(Token = "0x20005ED")]
		private sealed class Tables
		{
			// Token: 0x06002DAC RID: 11692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DAC")]
			internal Tables(ConcurrentDictionary<TKey, TValue>.Node[] buckets, object[] locks, int[] countPerLock)
			{
			}

			// Token: 0x04001A0C RID: 6668
			[Token(Token = "0x4001A0C")]
			[FieldOffset(Offset = "0x0")]
			internal readonly ConcurrentDictionary<TKey, TValue>.Node[] _buckets;

			// Token: 0x04001A0D RID: 6669
			[Token(Token = "0x4001A0D")]
			[FieldOffset(Offset = "0x0")]
			internal readonly object[] _locks;

			// Token: 0x04001A0E RID: 6670
			[Token(Token = "0x4001A0E")]
			[FieldOffset(Offset = "0x0")]
			internal int[] _countPerLock;
		}

		// Token: 0x020005EE RID: 1518
		[Token(Token = "0x20005EE")]
		[System.Serializable]
		private sealed class Node
		{
			// Token: 0x06002DAD RID: 11693 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DAD")]
			internal Node(TKey key, TValue value, int hashcode, ConcurrentDictionary<TKey, TValue>.Node next)
			{
			}

			// Token: 0x04001A0F RID: 6671
			[Token(Token = "0x4001A0F")]
			[FieldOffset(Offset = "0x0")]
			internal readonly TKey _key;

			// Token: 0x04001A10 RID: 6672
			[Token(Token = "0x4001A10")]
			[FieldOffset(Offset = "0x0")]
			internal TValue _value;

			// Token: 0x04001A11 RID: 6673
			[Token(Token = "0x4001A11")]
			[FieldOffset(Offset = "0x0")]
			internal ConcurrentDictionary<TKey, TValue>.Node _next;

			// Token: 0x04001A12 RID: 6674
			[Token(Token = "0x4001A12")]
			[FieldOffset(Offset = "0x0")]
			internal readonly int _hashcode;
		}

		// Token: 0x020005EF RID: 1519
		[Token(Token = "0x20005EF")]
		[System.Serializable]
		private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06002DAE RID: 11694 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DAE")]
			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
			{
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x06002DAF RID: 11695 RVA: 0x00018DB0 File Offset: 0x00016FB0
			[Token(Token = "0x17000751")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6002DAF")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000752")]
			public object Key
			{
				[Token(Token = "0x6002DB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000753")]
			public object Value
			{
				[Token(Token = "0x6002DB1")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000754")]
			public object Current
			{
				[Token(Token = "0x6002DB2")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002DB3 RID: 11699 RVA: 0x00018DC8 File Offset: 0x00016FC8
			[Token(Token = "0x6002DB3")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06002DB4 RID: 11700 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DB4")]
			public void Reset()
			{
			}

			// Token: 0x04001A13 RID: 6675
			[Token(Token = "0x4001A13")]
			[FieldOffset(Offset = "0x0")]
			private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> _enumerator;
		}
	}
}
