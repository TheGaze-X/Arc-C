using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[Preserve]
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection
	{
		// Token: 0x06000377 RID: 887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000377")]
		public DictionaryWrapper(IDictionary dictionary)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000378")]
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000379")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x600037A")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x600037B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x600037C")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x600037D")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A5")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x600037E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A6 RID: 166
		[Token(Token = "0x170000A6")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600037F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000380")]
			set
			{
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000381")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000382")]
		public void Clear()
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x6000383")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000384")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x170000A7")]
		public int Count
		{
			[Token(Token = "0x6000385")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000386 RID: 902 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x170000A8")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000386")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x6000387")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038A")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A9")]
		private object Item
		{
			[Token(Token = "0x600038B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038C")]
			set
			{
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x600038E")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x170000AA")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600038F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		private ICollection Keys
		{
			[Token(Token = "0x6000390")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000391")]
		public void Remove(object key)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		private ICollection Values
		{
			[Token(Token = "0x6000392")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000393")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x170000AD")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000394")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AE")]
		private object SyncRoot
		{
			[Token(Token = "0x6000395")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		public object UnderlyingDictionary
		{
			[Token(Token = "0x6000396")]
			get
			{
				return null;
			}
		}

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary _dictionary;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TKey, TValue> _genericDictionary;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		// Token: 0x02000063 RID: 99
		[Token(Token = "0x2000063")]
		private struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000397")]
			public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000398 RID: 920 RVA: 0x00003558 File Offset: 0x00001758
			[Token(Token = "0x170000B0")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6000398")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B1")]
			public object Key
			{
				[Token(Token = "0x6000399")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B2")]
			public object Value
			{
				[Token(Token = "0x600039A")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000B3")]
			public object Current
			{
				[Token(Token = "0x600039B")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00003570 File Offset: 0x00001770
			[Token(Token = "0x600039C")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600039D")]
			public void Reset()
			{
			}

			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x40001E7")]
			[FieldOffset(Offset = "0x0")]
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
		}
	}
}
