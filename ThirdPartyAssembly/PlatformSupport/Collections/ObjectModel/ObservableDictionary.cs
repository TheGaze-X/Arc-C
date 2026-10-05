using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using PlatformSupport.Collections.Specialized;

namespace PlatformSupport.Collections.ObjectModel
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	public class ObservableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, INotifyCollectionChanged, INotifyPropertyChanged
	{
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D2")]
		protected IDictionary<TKey, TValue> Dictionary
		{
			[Token(Token = "0x6002457")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002458")]
		public ObservableDictionary()
		{
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002459")]
		public ObservableDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245A")]
		public ObservableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245B")]
		public ObservableDictionary(int capacity)
		{
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245C")]
		public ObservableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245D")]
		public ObservableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245E")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		[Token(Token = "0x600245F")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D3")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6002460")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		[Token(Token = "0x6002461")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		[Token(Token = "0x6002462")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D4")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6002463")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D5 RID: 1237
		[Token(Token = "0x170004D5")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6002464")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002465")]
			set
			{
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002466")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002467")]
		public void Clear()
		{
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x6002468")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002469")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Token(Token = "0x170004D6")]
		public int Count
		{
			[Token(Token = "0x600246A")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x170004D7")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600246B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0000FC30 File Offset: 0x0000DE30
		[Token(Token = "0x600246C")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246D")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246E")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600246F RID: 9327 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002470 RID: 9328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000002")]
		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			[Token(Token = "0x600246F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06002471 RID: 9329 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000003")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x6002471")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002472")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002473")]
		public void AddRange(IDictionary<TKey, TValue> items)
		{
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002474")]
		private void Insert(TKey key, TValue value, bool add)
		{
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002475")]
		private void OnPropertyChanged()
		{
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002476")]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002477")]
		private void OnCollectionChanged()
		{
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002478")]
		private void OnCollectionChanged(NotifyCollectionChangedAction action, KeyValuePair<TKey, TValue> changedItem)
		{
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002479")]
		private void OnCollectionChanged(NotifyCollectionChangedAction action, KeyValuePair<TKey, TValue> newItem, KeyValuePair<TKey, TValue> oldItem)
		{
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247A")]
		private void OnCollectionChanged(NotifyCollectionChangedAction action, IList newItems)
		{
		}

		// Token: 0x0400148C RID: 5260
		[Token(Token = "0x400148C")]
		private const string CountString = "Count";

		// Token: 0x0400148D RID: 5261
		[Token(Token = "0x400148D")]
		private const string IndexerName = "Item[]";

		// Token: 0x0400148E RID: 5262
		[Token(Token = "0x400148E")]
		private const string KeysName = "Keys";

		// Token: 0x0400148F RID: 5263
		[Token(Token = "0x400148F")]
		private const string ValuesName = "Values";

		// Token: 0x04001490 RID: 5264
		[Token(Token = "0x4001490")]
		[FieldOffset(Offset = "0x0")]
		private IDictionary<TKey, TValue> _Dictionary;
	}
}
