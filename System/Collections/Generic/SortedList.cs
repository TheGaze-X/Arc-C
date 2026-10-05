using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[Serializable]
	public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x060010DD RID: 4317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DD")]
		public SortedList()
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DE")]
		public SortedList(IComparer<TKey> comparer)
		{
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DF")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E0")]
		private void Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x60010E1")]
		private bool Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x60010E2")]
		private bool Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		// Token: 0x17000378 RID: 888
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000378")]
		public int Capacity
		{
			[Token(Token = "0x60010E3")]
			set
			{
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000379")]
		public IComparer<TKey> Comparer
		{
			[Token(Token = "0x60010E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E5")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x1700037A")]
		public int Count
		{
			[Token(Token = "0x60010E6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037B")]
		private ICollection<TKey> Keys
		{
			[Token(Token = "0x60010E7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037C")]
		private ICollection Keys
		{
			[Token(Token = "0x60010E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037D")]
		private ICollection<TValue> Values
		{
			[Token(Token = "0x60010E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037E")]
		private ICollection Values
		{
			[Token(Token = "0x60010EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EB")]
		private SortedList<TKey, TValue>.KeyList GetKeyListHelper()
		{
			return null;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EC")]
		private SortedList<TKey, TValue>.ValueList GetValueListHelper()
		{
			return null;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x1700037F")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60010ED")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x17000380")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60010EE")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x17000381")]
		private bool IsFixedSize
		{
			[Token(Token = "0x60010EF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x17000382")]
		private bool IsSynchronized
		{
			[Token(Token = "0x60010F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000383")]
		private object SyncRoot
		{
			[Token(Token = "0x60010F1")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F2")]
		public void Clear()
		{
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x60010F3")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00008460 File Offset: 0x00006660
		[Token(Token = "0x60010F4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x60010F5")]
		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F6")]
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F7")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F8")]
		private void EnsureCapacity(int min)
		{
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F9")]
		private TValue GetByIndex(int index)
		{
			return null;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FA")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FB")]
		private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FC")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FD")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FE")]
		private TKey GetKey(int index)
		{
			return null;
		}

		// Token: 0x17000384 RID: 900
		[Token(Token = "0x17000384")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x60010FF")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001100")]
			set
			{
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000385")]
		private object Item
		{
			[Token(Token = "0x6001101")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001102")]
			set
			{
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x6001103")]
		public int IndexOfKey(TKey key)
		{
			return 0;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6001104")]
		public int IndexOfValue(TValue value)
		{
			return 0;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001105")]
		private void Insert(int index, TKey key, TValue value)
		{
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x6001106")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001107")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x6001108")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001109")]
		private void Remove(object key)
		{
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x600110A")]
		private static bool IsCompatibleKey(object key)
		{
			return default(bool);
		}

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x0")]
		private TKey[] keys;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x0")]
		private TValue[] values;

		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4000881")]
		[FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		[FieldOffset(Offset = "0x0")]
		private int version;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0x0")]
		private IComparer<TKey> comparer;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x0")]
		private SortedList<TKey, TValue>.KeyList keyList;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x0")]
		private SortedList<TKey, TValue>.ValueList valueList;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x02000267 RID: 615
		[Token(Token = "0x2000267")]
		[Serializable]
		private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x0600110B RID: 4363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600110B")]
			internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType)
			{
			}

			// Token: 0x0600110C RID: 4364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600110C")]
			public void Dispose()
			{
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x0600110D RID: 4365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000386")]
			private object Key
			{
				[Token(Token = "0x600110D")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600110E RID: 4366 RVA: 0x00008508 File Offset: 0x00006708
			[Token(Token = "0x600110E")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x0600110F RID: 4367 RVA: 0x00008520 File Offset: 0x00006720
			[Token(Token = "0x17000387")]
			private DictionaryEntry Entry
			{
				[Token(Token = "0x600110F")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x06001110 RID: 4368 RVA: 0x00008538 File Offset: 0x00006738
			[Token(Token = "0x17000388")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6001110")]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06001111 RID: 4369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000389")]
			private object Current
			{
				[Token(Token = "0x6001111")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06001112 RID: 4370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700038A")]
			private object Value
			{
				[Token(Token = "0x6001112")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001113 RID: 4371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001113")]
			private void Reset()
			{
			}

			// Token: 0x04000887 RID: 2183
			[Token(Token = "0x4000887")]
			[FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _sortedList;

			// Token: 0x04000888 RID: 2184
			[Token(Token = "0x4000888")]
			[FieldOffset(Offset = "0x0")]
			private TKey _key;

			// Token: 0x04000889 RID: 2185
			[Token(Token = "0x4000889")]
			[FieldOffset(Offset = "0x0")]
			private TValue _value;

			// Token: 0x0400088A RID: 2186
			[Token(Token = "0x400088A")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x0400088B RID: 2187
			[Token(Token = "0x400088B")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x0400088C RID: 2188
			[Token(Token = "0x400088C")]
			[FieldOffset(Offset = "0x0")]
			private int _getEnumeratorRetType;
		}

		// Token: 0x02000268 RID: 616
		[Token(Token = "0x2000268")]
		[Serializable]
		private sealed class SortedListKeyEnumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			// Token: 0x06001114 RID: 4372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001114")]
			internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList)
			{
			}

			// Token: 0x06001115 RID: 4373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001115")]
			public void Dispose()
			{
			}

			// Token: 0x06001116 RID: 4374 RVA: 0x00008550 File Offset: 0x00006750
			[Token(Token = "0x6001116")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06001117 RID: 4375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700038B")]
			public TKey Current
			{
				[Token(Token = "0x6001117")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x06001118 RID: 4376 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700038C")]
			private object Current
			{
				[Token(Token = "0x6001118")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001119 RID: 4377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001119")]
			private void Reset()
			{
			}

			// Token: 0x0400088D RID: 2189
			[Token(Token = "0x400088D")]
			[FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _sortedList;

			// Token: 0x0400088E RID: 2190
			[Token(Token = "0x400088E")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x0400088F RID: 2191
			[Token(Token = "0x400088F")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04000890 RID: 2192
			[Token(Token = "0x4000890")]
			[FieldOffset(Offset = "0x0")]
			private TKey _currentKey;
		}

		// Token: 0x02000269 RID: 617
		[Token(Token = "0x2000269")]
		[Serializable]
		private sealed class SortedListValueEnumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			// Token: 0x0600111A RID: 4378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600111A")]
			internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList)
			{
			}

			// Token: 0x0600111B RID: 4379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600111B")]
			public void Dispose()
			{
			}

			// Token: 0x0600111C RID: 4380 RVA: 0x00008568 File Offset: 0x00006768
			[Token(Token = "0x600111C")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700038D RID: 909
			// (get) Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700038D")]
			public TValue Current
			{
				[Token(Token = "0x600111D")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x0600111E RID: 4382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700038E")]
			private object Current
			{
				[Token(Token = "0x600111E")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600111F RID: 4383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600111F")]
			private void Reset()
			{
			}

			// Token: 0x04000891 RID: 2193
			[Token(Token = "0x4000891")]
			[FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _sortedList;

			// Token: 0x04000892 RID: 2194
			[Token(Token = "0x4000892")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04000893 RID: 2195
			[Token(Token = "0x4000893")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04000894 RID: 2196
			[Token(Token = "0x4000894")]
			[FieldOffset(Offset = "0x0")]
			private TValue _currentValue;
		}

		// Token: 0x0200026A RID: 618
		[Token(Token = "0x200026A")]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[Serializable]
		private sealed class KeyList : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection
		{
			// Token: 0x06001120 RID: 4384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001120")]
			internal KeyList(SortedList<TKey, TValue> dictionary)
			{
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x06001121 RID: 4385 RVA: 0x00008580 File Offset: 0x00006780
			[Token(Token = "0x1700038F")]
			public int Count
			{
				[Token(Token = "0x6001121")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x06001122 RID: 4386 RVA: 0x00008598 File Offset: 0x00006798
			[Token(Token = "0x17000390")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6001122")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000391 RID: 913
			// (get) Token: 0x06001123 RID: 4387 RVA: 0x000085B0 File Offset: 0x000067B0
			[Token(Token = "0x17000391")]
			private bool IsSynchronized
			{
				[Token(Token = "0x6001123")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000392")]
			private object SyncRoot
			{
				[Token(Token = "0x6001124")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001125 RID: 4389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001125")]
			public void Add(TKey key)
			{
			}

			// Token: 0x06001126 RID: 4390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001126")]
			public void Clear()
			{
			}

			// Token: 0x06001127 RID: 4391 RVA: 0x000085C8 File Offset: 0x000067C8
			[Token(Token = "0x6001127")]
			public bool Contains(TKey key)
			{
				return default(bool);
			}

			// Token: 0x06001128 RID: 4392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001128")]
			public void CopyTo(TKey[] array, int arrayIndex)
			{
			}

			// Token: 0x06001129 RID: 4393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001129")]
			private void CopyTo(Array array, int arrayIndex)
			{
			}

			// Token: 0x0600112A RID: 4394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600112A")]
			public void Insert(int index, TKey value)
			{
			}

			// Token: 0x17000393 RID: 915
			[Token(Token = "0x17000393")]
			public TKey this[int index]
			{
				[Token(Token = "0x600112B")]
				get
				{
					return null;
				}
				[Token(Token = "0x600112C")]
				set
				{
				}
			}

			// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600112D")]
			public IEnumerator<TKey> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600112E")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600112F RID: 4399 RVA: 0x000085E0 File Offset: 0x000067E0
			[Token(Token = "0x600112F")]
			public int IndexOf(TKey key)
			{
				return 0;
			}

			// Token: 0x06001130 RID: 4400 RVA: 0x000085F8 File Offset: 0x000067F8
			[Token(Token = "0x6001130")]
			public bool Remove(TKey key)
			{
				return default(bool);
			}

			// Token: 0x06001131 RID: 4401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001131")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x04000895 RID: 2197
			[Token(Token = "0x4000895")]
			[FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _dict;
		}

		// Token: 0x0200026B RID: 619
		[Token(Token = "0x200026B")]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		[Serializable]
		private sealed class ValueList : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection
		{
			// Token: 0x06001132 RID: 4402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001132")]
			internal ValueList(SortedList<TKey, TValue> dictionary)
			{
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06001133 RID: 4403 RVA: 0x00008610 File Offset: 0x00006810
			[Token(Token = "0x17000394")]
			public int Count
			{
				[Token(Token = "0x6001133")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06001134 RID: 4404 RVA: 0x00008628 File Offset: 0x00006828
			[Token(Token = "0x17000395")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6001134")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06001135 RID: 4405 RVA: 0x00008640 File Offset: 0x00006840
			[Token(Token = "0x17000396")]
			private bool IsSynchronized
			{
				[Token(Token = "0x6001135")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000397")]
			private object SyncRoot
			{
				[Token(Token = "0x6001136")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001137 RID: 4407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001137")]
			public void Add(TValue key)
			{
			}

			// Token: 0x06001138 RID: 4408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001138")]
			public void Clear()
			{
			}

			// Token: 0x06001139 RID: 4409 RVA: 0x00008658 File Offset: 0x00006858
			[Token(Token = "0x6001139")]
			public bool Contains(TValue value)
			{
				return default(bool);
			}

			// Token: 0x0600113A RID: 4410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600113A")]
			public void CopyTo(TValue[] array, int arrayIndex)
			{
			}

			// Token: 0x0600113B RID: 4411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600113B")]
			private void CopyTo(Array array, int index)
			{
			}

			// Token: 0x0600113C RID: 4412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600113C")]
			public void Insert(int index, TValue value)
			{
			}

			// Token: 0x17000398 RID: 920
			[Token(Token = "0x17000398")]
			public TValue this[int index]
			{
				[Token(Token = "0x600113D")]
				get
				{
					return null;
				}
				[Token(Token = "0x600113E")]
				set
				{
				}
			}

			// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600113F")]
			public IEnumerator<TValue> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001140")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06001141 RID: 4417 RVA: 0x00008670 File Offset: 0x00006870
			[Token(Token = "0x6001141")]
			public int IndexOf(TValue value)
			{
				return 0;
			}

			// Token: 0x06001142 RID: 4418 RVA: 0x00008688 File Offset: 0x00006888
			[Token(Token = "0x6001142")]
			public bool Remove(TValue value)
			{
				return default(bool);
			}

			// Token: 0x06001143 RID: 4419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001143")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x04000896 RID: 2198
			[Token(Token = "0x4000896")]
			[FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _dict;
		}
	}
}
