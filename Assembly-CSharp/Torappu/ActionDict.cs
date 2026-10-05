using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2000484")]
	[Serializable]
	public class ActionDict<TKey, TPair> : IDictionary<TKey, ActionArray>, ICollection<KeyValuePair<TKey, ActionArray>>, IEnumerable<KeyValuePair<TKey, ActionArray>>, IEnumerable where TKey : IComparable where TPair : ActionKV<TKey>, new()
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06004C78 RID: 19576 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		[Token(Token = "0x170001D9")]
		public int Count
		{
			[Token(Token = "0x6004C78")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06004C79 RID: 19577 RVA: 0x0002D1E0 File Offset: 0x0002B3E0
		[Token(Token = "0x170001DA")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6004C79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DB RID: 475
		[Token(Token = "0x170001DB")]
		public object this[object key]
		{
			[Token(Token = "0x6004C7A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C7B")]
			set
			{
			}
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C7C")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x0002D1F8 File Offset: 0x0002B3F8
		[Token(Token = "0x170001DC")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6004C7D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DD")]
		public object SyncRoot
		{
			[Token(Token = "0x6004C7E")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x0002D210 File Offset: 0x0002B410
		[Token(Token = "0x6004C7F")]
		public bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C80")]
		public void Remove(object key)
		{
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C81")]
		public void Add(object key, object value)
		{
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06004C82 RID: 19586 RVA: 0x0002D228 File Offset: 0x0002B428
		[Token(Token = "0x170001DE")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6004C82")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DF RID: 479
		[Token(Token = "0x170001DF")]
		public ActionArray this[TKey key]
		{
			[Token(Token = "0x6004C83")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C84")]
			set
			{
			}
		}

		// Token: 0x170001E0 RID: 480
		[Token(Token = "0x170001E0")]
		public KeyValuePair<TKey, ActionArray> this[int index]
		{
			[Token(Token = "0x6004C85")]
			get
			{
				return default(KeyValuePair<TKey, ActionArray>);
			}
			[Token(Token = "0x6004C86")]
			set
			{
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E1")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6004C87")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06004C88 RID: 19592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E2")]
		public ICollection<ActionArray> Values
		{
			[Token(Token = "0x6004C88")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x0002D258 File Offset: 0x0002B458
		[Token(Token = "0x6004C89")]
		public bool Contains(KeyValuePair<TKey, ActionArray> kv)
		{
			return default(bool);
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8A")]
		public void Clear()
		{
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x0002D270 File Offset: 0x0002B470
		[Token(Token = "0x6004C8B")]
		public bool TryGetValue(TKey key, out ActionArray value)
		{
			return default(bool);
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x0002D288 File Offset: 0x0002B488
		[Token(Token = "0x6004C8C")]
		public int IndexOf(TKey key)
		{
			return 0;
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C8D")]
		private IEnumerator<KeyValuePair<TKey, ActionArray>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C8E")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8F")]
		public void CopyTo(KeyValuePair<TKey, ActionArray>[] target, int index)
		{
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C90")]
		public void Add(TKey key, ActionArray value)
		{
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C91")]
		public void Add(KeyValuePair<TKey, ActionArray> kv)
		{
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x0002D2A0 File Offset: 0x0002B4A0
		[Token(Token = "0x6004C92")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x0002D2B8 File Offset: 0x0002B4B8
		[Token(Token = "0x6004C93")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
		[Token(Token = "0x6004C94")]
		public bool Remove(KeyValuePair<TKey, ActionArray> kv)
		{
			return default(bool);
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C95")]
		public ActionDict()
		{
		}

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[JsonProperty(PropertyName = "items")]
		private List<TPair> _items;

		// Token: 0x02000485 RID: 1157
		[Token(Token = "0x2000485")]
		private class Enumerator : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable, IDictionaryEnumerator
		{
			// Token: 0x06004C96 RID: 19606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C96")]
			public Enumerator(List<TPair> items)
			{
			}

			// Token: 0x06004C97 RID: 19607 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
			[Token(Token = "0x6004C97")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06004C98 RID: 19608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C98")]
			public void Reset()
			{
			}

			// Token: 0x170001E3 RID: 483
			// (get) Token: 0x06004C99 RID: 19609 RVA: 0x0002D300 File Offset: 0x0002B500
			[Token(Token = "0x170001E3")]
			public DictionaryEntry Current
			{
				[Token(Token = "0x6004C99")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x06004C9A RID: 19610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001E4")]
			private object Current
			{
				[Token(Token = "0x6004C9A")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004C9B RID: 19611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C9B")]
			public void Dispose()
			{
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x06004C9C RID: 19612 RVA: 0x0002D318 File Offset: 0x0002B518
			[Token(Token = "0x170001E5")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6004C9C")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x06004C9D RID: 19613 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001E6")]
			public object Key
			{
				[Token(Token = "0x6004C9D")]
				get
				{
					return null;
				}
			}

			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x06004C9E RID: 19614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001E7")]
			public object Value
			{
				[Token(Token = "0x6004C9E")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400107B RID: 4219
			[Token(Token = "0x400107B")]
			[FieldOffset(Offset = "0x0")]
			private List<TPair> m_items;

			// Token: 0x0400107C RID: 4220
			[Token(Token = "0x400107C")]
			[FieldOffset(Offset = "0x0")]
			private int m_index;

			// Token: 0x0400107D RID: 4221
			[Token(Token = "0x400107D")]
			[FieldOffset(Offset = "0x0")]
			private int m_count;
		}
	}
}
