using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000258 RID: 600
	[Token(Token = "0x2000258")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[Serializable]
	public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06001075 RID: 4213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001075")]
		public SortedDictionary()
		{
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001076")]
		public SortedDictionary(IComparer<TKey> comparer)
		{
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001077")]
		private void Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x6001078")]
		private bool Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x6001079")]
		private bool Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x17000358")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600107A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000359 RID: 857
		[Token(Token = "0x17000359")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600107B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600107C")]
			set
			{
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x1700035A")]
		public int Count
		{
			[Token(Token = "0x600107D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035B")]
		public SortedDictionary<TKey, TValue>.KeyCollection Keys
		{
			[Token(Token = "0x600107E")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035C")]
		private ICollection<TKey> Keys
		{
			[Token(Token = "0x600107F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035D")]
		public SortedDictionary<TKey, TValue>.ValueCollection Values
		{
			[Token(Token = "0x6001080")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035E")]
		private ICollection<TValue> Values
		{
			[Token(Token = "0x6001081")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001082")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001083")]
		public void Clear()
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x6001084")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x6001085")]
		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001086")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x000080A0 File Offset: 0x000062A0
		[Token(Token = "0x6001087")]
		public SortedDictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default(SortedDictionary<TKey, TValue>.Enumerator);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001088")]
		private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x6001089")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x600108A")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600108B")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x1700035F")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600108C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x17000360")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600108D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		private ICollection Keys
		{
			[Token(Token = "0x600108E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		private ICollection Values
		{
			[Token(Token = "0x600108F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001091 RID: 4241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000363")]
		private object Item
		{
			[Token(Token = "0x6001090")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001091")]
			set
			{
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001092")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x6001093")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x6001094")]
		private static bool IsCompatibleKey(object key)
		{
			return default(bool);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001095")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001096")]
		private void Remove(object key)
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x17000364")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6001097")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		private object SyncRoot
		{
			[Token(Token = "0x6001098")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001099")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private SortedDictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private SortedDictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x0")]
		private TreeSet<KeyValuePair<TKey, TValue>> _set;

		// Token: 0x02000259 RID: 601
		[Token(Token = "0x2000259")]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x0600109A RID: 4250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600109A")]
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
			}

			// Token: 0x0600109B RID: 4251 RVA: 0x00008160 File Offset: 0x00006360
			[Token(Token = "0x600109B")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600109C RID: 4252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600109C")]
			public void Dispose()
			{
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x0600109D RID: 4253 RVA: 0x00008178 File Offset: 0x00006378
			[Token(Token = "0x17000366")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x600109D")]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x0600109E RID: 4254 RVA: 0x00008190 File Offset: 0x00006390
			[Token(Token = "0x17000367")]
			internal bool NotStartedOrEnded
			{
				[Token(Token = "0x600109E")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600109F RID: 4255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600109F")]
			internal void Reset()
			{
			}

			// Token: 0x060010A0 RID: 4256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010A0")]
			private void Reset()
			{
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000368")]
			private object Current
			{
				[Token(Token = "0x60010A1")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000369")]
			private object Key
			{
				[Token(Token = "0x60010A2")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700036A")]
			private object Value
			{
				[Token(Token = "0x60010A3")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x060010A4 RID: 4260 RVA: 0x000081A8 File Offset: 0x000063A8
			[Token(Token = "0x1700036B")]
			private DictionaryEntry Entry
			{
				[Token(Token = "0x60010A4")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x0400086C RID: 2156
			[Token(Token = "0x400086C")]
			[FieldOffset(Offset = "0x0")]
			private SortedSet<KeyValuePair<TKey, TValue>>.Enumerator _treeEnum;

			// Token: 0x0400086D RID: 2157
			[Token(Token = "0x400086D")]
			[FieldOffset(Offset = "0x0")]
			private int _getEnumeratorRetType;
		}

		// Token: 0x0200025A RID: 602
		[Token(Token = "0x200025A")]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[Serializable]
		public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			// Token: 0x060010A5 RID: 4261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010A5")]
			public KeyCollection(SortedDictionary<TKey, TValue> dictionary)
			{
			}

			// Token: 0x060010A6 RID: 4262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010A6")]
			private IEnumerator<TKey> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060010A7 RID: 4263 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010A7")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x060010A8 RID: 4264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010A8")]
			public void CopyTo(TKey[] array, int index)
			{
			}

			// Token: 0x060010A9 RID: 4265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010A9")]
			private void CopyTo(Array array, int index)
			{
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x060010AA RID: 4266 RVA: 0x000081C0 File Offset: 0x000063C0
			[Token(Token = "0x1700036C")]
			public int Count
			{
				[Token(Token = "0x60010AA")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x060010AB RID: 4267 RVA: 0x000081D8 File Offset: 0x000063D8
			[Token(Token = "0x1700036D")]
			private bool IsReadOnly
			{
				[Token(Token = "0x60010AB")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060010AC RID: 4268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010AC")]
			private void Add(TKey item)
			{
			}

			// Token: 0x060010AD RID: 4269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010AD")]
			private void Clear()
			{
			}

			// Token: 0x060010AE RID: 4270 RVA: 0x000081F0 File Offset: 0x000063F0
			[Token(Token = "0x60010AE")]
			private bool Contains(TKey item)
			{
				return default(bool);
			}

			// Token: 0x060010AF RID: 4271 RVA: 0x00008208 File Offset: 0x00006408
			[Token(Token = "0x60010AF")]
			private bool Remove(TKey item)
			{
				return default(bool);
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00008220 File Offset: 0x00006420
			[Token(Token = "0x1700036E")]
			private bool IsSynchronized
			{
				[Token(Token = "0x60010B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700036F")]
			private object SyncRoot
			{
				[Token(Token = "0x60010B1")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400086E RID: 2158
			[Token(Token = "0x400086E")]
			[FieldOffset(Offset = "0x0")]
			private SortedDictionary<TKey, TValue> _dictionary;

			// Token: 0x0200025B RID: 603
			[Token(Token = "0x200025B")]
			public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
			{
				// Token: 0x060010B2 RID: 4274 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60010B2")]
				internal Enumerator(SortedDictionary<TKey, TValue> dictionary)
				{
				}

				// Token: 0x060010B3 RID: 4275 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60010B3")]
				public void Dispose()
				{
				}

				// Token: 0x060010B4 RID: 4276 RVA: 0x00008238 File Offset: 0x00006438
				[Token(Token = "0x60010B4")]
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000370 RID: 880
				// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000370")]
				public TKey Current
				{
					[Token(Token = "0x60010B5")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000371 RID: 881
				// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000371")]
				private object Current
				{
					[Token(Token = "0x60010B6")]
					get
					{
						return null;
					}
				}

				// Token: 0x060010B7 RID: 4279 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60010B7")]
				private void Reset()
				{
				}

				// Token: 0x0400086F RID: 2159
				[Token(Token = "0x400086F")]
				[FieldOffset(Offset = "0x0")]
				private SortedDictionary<TKey, TValue>.Enumerator _dictEnum;
			}
		}

		// Token: 0x0200025E RID: 606
		[Token(Token = "0x200025E")]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[Serializable]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			// Token: 0x060010BC RID: 4284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010BC")]
			public ValueCollection(SortedDictionary<TKey, TValue> dictionary)
			{
			}

			// Token: 0x060010BD RID: 4285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010BD")]
			private IEnumerator<TValue> GetEnumerator()
			{
				return null;
			}

			// Token: 0x060010BE RID: 4286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010BE")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x060010BF RID: 4287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010BF")]
			public void CopyTo(TValue[] array, int index)
			{
			}

			// Token: 0x060010C0 RID: 4288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010C0")]
			private void CopyTo(Array array, int index)
			{
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00008280 File Offset: 0x00006480
			[Token(Token = "0x17000372")]
			public int Count
			{
				[Token(Token = "0x60010C1")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00008298 File Offset: 0x00006498
			[Token(Token = "0x17000373")]
			private bool IsReadOnly
			{
				[Token(Token = "0x60010C2")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060010C3 RID: 4291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010C3")]
			private void Add(TValue item)
			{
			}

			// Token: 0x060010C4 RID: 4292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010C4")]
			private void Clear()
			{
			}

			// Token: 0x060010C5 RID: 4293 RVA: 0x000082B0 File Offset: 0x000064B0
			[Token(Token = "0x60010C5")]
			private bool Contains(TValue item)
			{
				return default(bool);
			}

			// Token: 0x060010C6 RID: 4294 RVA: 0x000082C8 File Offset: 0x000064C8
			[Token(Token = "0x60010C6")]
			private bool Remove(TValue item)
			{
				return default(bool);
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000082E0 File Offset: 0x000064E0
			[Token(Token = "0x17000374")]
			private bool IsSynchronized
			{
				[Token(Token = "0x60010C7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x060010C8 RID: 4296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000375")]
			private object SyncRoot
			{
				[Token(Token = "0x60010C8")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000874 RID: 2164
			[Token(Token = "0x4000874")]
			[FieldOffset(Offset = "0x0")]
			private SortedDictionary<TKey, TValue> _dictionary;

			// Token: 0x0200025F RID: 607
			[Token(Token = "0x200025F")]
			public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
			{
				// Token: 0x060010C9 RID: 4297 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60010C9")]
				internal Enumerator(SortedDictionary<TKey, TValue> dictionary)
				{
				}

				// Token: 0x060010CA RID: 4298 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60010CA")]
				public void Dispose()
				{
				}

				// Token: 0x060010CB RID: 4299 RVA: 0x000082F8 File Offset: 0x000064F8
				[Token(Token = "0x60010CB")]
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000376 RID: 886
				// (get) Token: 0x060010CC RID: 4300 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000376")]
				public TValue Current
				{
					[Token(Token = "0x60010CC")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000377 RID: 887
				// (get) Token: 0x060010CD RID: 4301 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000377")]
				private object Current
				{
					[Token(Token = "0x60010CD")]
					get
					{
						return null;
					}
				}

				// Token: 0x060010CE RID: 4302 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60010CE")]
				private void Reset()
				{
				}

				// Token: 0x04000875 RID: 2165
				[Token(Token = "0x4000875")]
				[FieldOffset(Offset = "0x0")]
				private SortedDictionary<TKey, TValue>.Enumerator _dictEnum;
			}
		}

		// Token: 0x02000262 RID: 610
		[Token(Token = "0x2000262")]
		[Serializable]
		internal sealed class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>>
		{
			// Token: 0x060010D3 RID: 4307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010D3")]
			public KeyValuePairComparer(IComparer<TKey> keyComparer)
			{
			}

			// Token: 0x060010D4 RID: 4308 RVA: 0x00008340 File Offset: 0x00006540
			[Token(Token = "0x60010D4")]
			public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
			{
				return 0;
			}

			// Token: 0x0400087A RID: 2170
			[Token(Token = "0x400087A")]
			[FieldOffset(Offset = "0x0")]
			internal IComparer<TKey> keyComparer;
		}
	}
}
