using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(SortedList.SortedListDebugView))]
	[System.Serializable]
	public class SortedList : IDictionary, ICollection, IEnumerable, System.ICloneable
	{
		// Token: 0x06002C1E RID: 11294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x4C6D210", Offset = "0x4C6BE10", VA = "0x184C6D210")]
		public SortedList()
		{
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x4C6CB20", Offset = "0x4C6B720", VA = "0x184C6CB20")]
		private void Init()
		{
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C20")]
		[Address(RVA = "0x4C6D390", Offset = "0x4C6BF90", VA = "0x184C6D390")]
		public SortedList(int initialCapacity)
		{
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C21")]
		[Address(RVA = "0x4C6D1D0", Offset = "0x4C6BDD0", VA = "0x184C6D1D0")]
		public SortedList(IComparer comparer)
		{
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x4C6C080", Offset = "0x4C6AC80", VA = "0x184C6C080", Slot = "21")]
		public virtual void Add(object key, object value)
		{
		}

		// Token: 0x170006E8 RID: 1768
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E8")]
		public virtual int Capacity
		{
			[Token(Token = "0x6002C23")]
			[Address(RVA = "0x4C6D700", Offset = "0x4C6C300", VA = "0x184C6D700", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x00018330 File Offset: 0x00016530
		[Token(Token = "0x170006E9")]
		public virtual int Count
		{
			[Token(Token = "0x6002C24")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "23")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006EA")]
		public virtual ICollection Keys
		{
			[Token(Token = "0x6002C25")]
			[Address(RVA = "0x4C6D600", Offset = "0x4C6C200", VA = "0x184C6D600", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006EB")]
		public virtual ICollection Values
		{
			[Token(Token = "0x6002C26")]
			[Address(RVA = "0x4C6D6C0", Offset = "0x4C6C2C0", VA = "0x184C6D6C0", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x00018348 File Offset: 0x00016548
		[Token(Token = "0x170006EC")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6002C27")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x00018360 File Offset: 0x00016560
		[Token(Token = "0x170006ED")]
		public virtual bool IsFixedSize
		{
			[Token(Token = "0x6002C28")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002C29 RID: 11305 RVA: 0x00018378 File Offset: 0x00016578
		[Token(Token = "0x170006EE")]
		public virtual bool IsSynchronized
		{
			[Token(Token = "0x6002C29")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006EF")]
		public virtual object SyncRoot
		{
			[Token(Token = "0x6002C2A")]
			[Address(RVA = "0x4C6D640", Offset = "0x4C6C240", VA = "0x184C6D640", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0x43F0530", Offset = "0x43EF130", VA = "0x1843F0530", Slot = "30")]
		public virtual void Clear()
		{
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x4C6C1D0", Offset = "0x4C6ADD0", VA = "0x184C6C1D0", Slot = "31")]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x00018390 File Offset: 0x00016590
		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x4C6C2F0", Offset = "0x4C6AEF0", VA = "0x184C6C2F0", Slot = "32")]
		public virtual bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000183A8 File Offset: 0x000165A8
		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x4C6C2A0", Offset = "0x4C6AEA0", VA = "0x184C6C2A0", Slot = "33")]
		public virtual bool ContainsValue(object value)
		{
			return default(bool);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x4C6C340", Offset = "0x4C6AF40", VA = "0x184C6C340", Slot = "34")]
		public virtual void CopyTo(System.Array array, int arrayIndex)
		{
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x4C6C630", Offset = "0x4C6B230", VA = "0x184C6C630")]
		private void EnsureCapacity(int min)
		{
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C31")]
		[Address(RVA = "0x4C6C6A0", Offset = "0x4C6B2A0", VA = "0x184C6C6A0", Slot = "35")]
		public virtual object GetByIndex(int index)
		{
			return null;
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x4C6D130", Offset = "0x4C6BD30", VA = "0x184C6D130", Slot = "19")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C33")]
		[Address(RVA = "0x4C6C770", Offset = "0x4C6B370", VA = "0x184C6C770", Slot = "36")]
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C34")]
		[Address(RVA = "0x4C6C8A0", Offset = "0x4C6B4A0", VA = "0x184C6C8A0", Slot = "37")]
		public virtual object GetKey(int index)
		{
			return null;
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C35")]
		[Address(RVA = "0x4C6C810", Offset = "0x4C6B410", VA = "0x184C6C810", Slot = "38")]
		public virtual IList GetKeyList()
		{
			return null;
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C36")]
		[Address(RVA = "0x4C6C970", Offset = "0x4C6B570", VA = "0x184C6C970", Slot = "39")]
		public virtual IList GetValueList()
		{
			return null;
		}

		// Token: 0x170006F0 RID: 1776
		[Token(Token = "0x170006F0")]
		public virtual object this[object key]
		{
			[Token(Token = "0x6002C37")]
			[Address(RVA = "0x4C6D580", Offset = "0x4C6C180", VA = "0x184C6D580", Slot = "40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C38")]
			[Address(RVA = "0x4C6D8E0", Offset = "0x4C6C4E0", VA = "0x184C6D8E0", Slot = "41")]
			set
			{
			}
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000183C0 File Offset: 0x000165C0
		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x4C6CA00", Offset = "0x4C6B600", VA = "0x184C6CA00", Slot = "42")]
		public virtual int IndexOfKey(object key)
		{
			return 0;
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000183D8 File Offset: 0x000165D8
		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x4C6CAC0", Offset = "0x4C6B6C0", VA = "0x184C6CAC0", Slot = "43")]
		public virtual int IndexOfValue(object value)
		{
			return 0;
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3B")]
		[Address(RVA = "0x4C6CC90", Offset = "0x4C6B890", VA = "0x184C6CC90")]
		private void Insert(int index, object key, object value)
		{
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0x4C6CE30", Offset = "0x4C6BA30", VA = "0x184C6CE30", Slot = "44")]
		public virtual void RemoveAt(int index)
		{
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x4C6CFB0", Offset = "0x4C6BBB0", VA = "0x184C6CFB0", Slot = "45")]
		public virtual void Remove(object key)
		{
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C3E")]
		[Address(RVA = "0x4C6D030", Offset = "0x4C6BC30", VA = "0x184C6D030")]
		public static SortedList Synchronized(SortedList list)
		{
			return null;
		}

		// Token: 0x0400199C RID: 6556
		[Token(Token = "0x400199C")]
		[FieldOffset(Offset = "0x10")]
		private object[] keys;

		// Token: 0x0400199D RID: 6557
		[Token(Token = "0x400199D")]
		[FieldOffset(Offset = "0x18")]
		private object[] values;

		// Token: 0x0400199E RID: 6558
		[Token(Token = "0x400199E")]
		[FieldOffset(Offset = "0x20")]
		private int _size;

		// Token: 0x0400199F RID: 6559
		[Token(Token = "0x400199F")]
		[FieldOffset(Offset = "0x24")]
		private int version;

		// Token: 0x040019A0 RID: 6560
		[Token(Token = "0x40019A0")]
		[FieldOffset(Offset = "0x28")]
		private IComparer comparer;

		// Token: 0x040019A1 RID: 6561
		[Token(Token = "0x40019A1")]
		[FieldOffset(Offset = "0x30")]
		private SortedList.KeyList keyList;

		// Token: 0x040019A2 RID: 6562
		[Token(Token = "0x40019A2")]
		[FieldOffset(Offset = "0x38")]
		private SortedList.ValueList valueList;

		// Token: 0x040019A3 RID: 6563
		[Token(Token = "0x40019A3")]
		[FieldOffset(Offset = "0x40")]
		[System.NonSerialized]
		private object _syncRoot;

		// Token: 0x020005D1 RID: 1489
		[Token(Token = "0x20005D1")]
		[System.Serializable]
		private class SyncSortedList : SortedList
		{
			// Token: 0x06002C3F RID: 11327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C3F")]
			[Address(RVA = "0x4C71CB0", Offset = "0x4C708B0", VA = "0x184C71CB0")]
			internal SyncSortedList(SortedList list)
			{
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06002C40 RID: 11328 RVA: 0x000183F0 File Offset: 0x000165F0
			[Token(Token = "0x170006F1")]
			public override int Count
			{
				[Token(Token = "0x6002C40")]
				[Address(RVA = "0x4C71D30", Offset = "0x4C70930", VA = "0x184C71D30", Slot = "23")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170006F2")]
			public override object SyncRoot
			{
				[Token(Token = "0x6002C41")]
				[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "29")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x06002C42 RID: 11330 RVA: 0x00018408 File Offset: 0x00016608
			[Token(Token = "0x170006F3")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6002C42")]
				[Address(RVA = "0x4C71E50", Offset = "0x4C70A50", VA = "0x184C71E50", Slot = "26")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x06002C43 RID: 11331 RVA: 0x00018420 File Offset: 0x00016620
			[Token(Token = "0x170006F4")]
			public override bool IsFixedSize
			{
				[Token(Token = "0x6002C43")]
				[Address(RVA = "0x4C71E00", Offset = "0x4C70A00", VA = "0x184C71E00", Slot = "27")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00018438 File Offset: 0x00016638
			[Token(Token = "0x170006F5")]
			public override bool IsSynchronized
			{
				[Token(Token = "0x6002C44")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006F6 RID: 1782
			[Token(Token = "0x170006F6")]
			public override object this[object key]
			{
				[Token(Token = "0x6002C45")]
				[Address(RVA = "0x4C71EA0", Offset = "0x4C70AA0", VA = "0x184C71EA0", Slot = "40")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002C46")]
				[Address(RVA = "0x4C71F80", Offset = "0x4C70B80", VA = "0x184C71F80", Slot = "41")]
				set
				{
				}
			}

			// Token: 0x06002C47 RID: 11335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C47")]
			[Address(RVA = "0x4C70FC0", Offset = "0x4C6FBC0", VA = "0x184C70FC0", Slot = "21")]
			public override void Add(object key, object value)
			{
			}

			// Token: 0x06002C48 RID: 11336 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C48")]
			[Address(RVA = "0x4C710A0", Offset = "0x4C6FCA0", VA = "0x184C710A0", Slot = "30")]
			public override void Clear()
			{
			}

			// Token: 0x06002C49 RID: 11337 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C49")]
			[Address(RVA = "0x4C71160", Offset = "0x4C6FD60", VA = "0x184C71160", Slot = "31")]
			public override object Clone()
			{
				return null;
			}

			// Token: 0x06002C4A RID: 11338 RVA: 0x00018450 File Offset: 0x00016650
			[Token(Token = "0x6002C4A")]
			[Address(RVA = "0x4C71310", Offset = "0x4C6FF10", VA = "0x184C71310", Slot = "32")]
			public override bool Contains(object key)
			{
				return default(bool);
			}

			// Token: 0x06002C4B RID: 11339 RVA: 0x00018468 File Offset: 0x00016668
			[Token(Token = "0x6002C4B")]
			[Address(RVA = "0x4C71230", Offset = "0x4C6FE30", VA = "0x184C71230", Slot = "33")]
			public override bool ContainsValue(object key)
			{
				return default(bool);
			}

			// Token: 0x06002C4C RID: 11340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C4C")]
			[Address(RVA = "0x4C713F0", Offset = "0x4C6FFF0", VA = "0x184C713F0", Slot = "34")]
			public override void CopyTo(System.Array array, int index)
			{
			}

			// Token: 0x06002C4D RID: 11341 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C4D")]
			[Address(RVA = "0x4C714D0", Offset = "0x4C700D0", VA = "0x184C714D0", Slot = "35")]
			public override object GetByIndex(int index)
			{
				return null;
			}

			// Token: 0x06002C4E RID: 11342 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C4E")]
			[Address(RVA = "0x4C715B0", Offset = "0x4C701B0", VA = "0x184C715B0", Slot = "36")]
			public override IDictionaryEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002C4F RID: 11343 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C4F")]
			[Address(RVA = "0x4C71750", Offset = "0x4C70350", VA = "0x184C71750", Slot = "37")]
			public override object GetKey(int index)
			{
				return null;
			}

			// Token: 0x06002C50 RID: 11344 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C50")]
			[Address(RVA = "0x4C71680", Offset = "0x4C70280", VA = "0x184C71680", Slot = "38")]
			public override IList GetKeyList()
			{
				return null;
			}

			// Token: 0x06002C51 RID: 11345 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C51")]
			[Address(RVA = "0x4C71830", Offset = "0x4C70430", VA = "0x184C71830", Slot = "39")]
			public override IList GetValueList()
			{
				return null;
			}

			// Token: 0x06002C52 RID: 11346 RVA: 0x00018480 File Offset: 0x00016680
			[Token(Token = "0x6002C52")]
			[Address(RVA = "0x4C71900", Offset = "0x4C70500", VA = "0x184C71900", Slot = "42")]
			public override int IndexOfKey(object key)
			{
				return 0;
			}

			// Token: 0x06002C53 RID: 11347 RVA: 0x00018498 File Offset: 0x00016698
			[Token(Token = "0x6002C53")]
			[Address(RVA = "0x4C71A40", Offset = "0x4C70640", VA = "0x184C71A40", Slot = "43")]
			public override int IndexOfValue(object value)
			{
				return 0;
			}

			// Token: 0x06002C54 RID: 11348 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C54")]
			[Address(RVA = "0x4C71B10", Offset = "0x4C70710", VA = "0x184C71B10", Slot = "44")]
			public override void RemoveAt(int index)
			{
			}

			// Token: 0x06002C55 RID: 11349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C55")]
			[Address(RVA = "0x4C71BE0", Offset = "0x4C707E0", VA = "0x184C71BE0", Slot = "45")]
			public override void Remove(object key)
			{
			}

			// Token: 0x040019A4 RID: 6564
			[Token(Token = "0x40019A4")]
			[FieldOffset(Offset = "0x48")]
			private SortedList _list;

			// Token: 0x040019A5 RID: 6565
			[Token(Token = "0x40019A5")]
			[FieldOffset(Offset = "0x50")]
			private object _root;
		}

		// Token: 0x020005D2 RID: 1490
		[Token(Token = "0x20005D2")]
		[System.Serializable]
		private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, System.ICloneable
		{
			// Token: 0x06002C56 RID: 11350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C56")]
			[Address(RVA = "0x4C6BC20", Offset = "0x4C6A820", VA = "0x184C6BC20")]
			internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
			{
			}

			// Token: 0x06002C57 RID: 11351 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C57")]
			[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "10")]
			public object Clone()
			{
				return null;
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06002C58 RID: 11352 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170006F7")]
			public virtual object Key
			{
				[Token(Token = "0x6002C58")]
				[Address(RVA = "0x4C6BEC0", Offset = "0x4C6AAC0", VA = "0x184C6BEC0", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002C59 RID: 11353 RVA: 0x000184B0 File Offset: 0x000166B0
			[Token(Token = "0x6002C59")]
			[Address(RVA = "0x4C6BA50", Offset = "0x4C6A650", VA = "0x184C6BA50", Slot = "12")]
			public virtual bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06002C5A RID: 11354 RVA: 0x000184C8 File Offset: 0x000166C8
			[Token(Token = "0x170006F8")]
			public virtual DictionaryEntry Entry
			{
				[Token(Token = "0x6002C5A")]
				[Address(RVA = "0x4C6BDB0", Offset = "0x4C6A9B0", VA = "0x184C6BDB0", Slot = "13")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x06002C5B RID: 11355 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170006F9")]
			public virtual object Current
			{
				[Token(Token = "0x6002C5B")]
				[Address(RVA = "0x4C6BCA0", Offset = "0x4C6A8A0", VA = "0x184C6BCA0", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x06002C5C RID: 11356 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170006FA")]
			public virtual object Value
			{
				[Token(Token = "0x6002C5C")]
				[Address(RVA = "0x4C6BFA0", Offset = "0x4C6ABA0", VA = "0x184C6BFA0", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002C5D RID: 11357 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C5D")]
			[Address(RVA = "0x4C6BB70", Offset = "0x4C6A770", VA = "0x184C6BB70", Slot = "16")]
			public virtual void Reset()
			{
			}

			// Token: 0x040019A6 RID: 6566
			[Token(Token = "0x40019A6")]
			[FieldOffset(Offset = "0x10")]
			private SortedList _sortedList;

			// Token: 0x040019A7 RID: 6567
			[Token(Token = "0x40019A7")]
			[FieldOffset(Offset = "0x18")]
			private object _key;

			// Token: 0x040019A8 RID: 6568
			[Token(Token = "0x40019A8")]
			[FieldOffset(Offset = "0x20")]
			private object _value;

			// Token: 0x040019A9 RID: 6569
			[Token(Token = "0x40019A9")]
			[FieldOffset(Offset = "0x28")]
			private int _index;

			// Token: 0x040019AA RID: 6570
			[Token(Token = "0x40019AA")]
			[FieldOffset(Offset = "0x2C")]
			private int _startIndex;

			// Token: 0x040019AB RID: 6571
			[Token(Token = "0x40019AB")]
			[FieldOffset(Offset = "0x30")]
			private int _endIndex;

			// Token: 0x040019AC RID: 6572
			[Token(Token = "0x40019AC")]
			[FieldOffset(Offset = "0x34")]
			private int _version;

			// Token: 0x040019AD RID: 6573
			[Token(Token = "0x40019AD")]
			[FieldOffset(Offset = "0x38")]
			private bool _current;

			// Token: 0x040019AE RID: 6574
			[Token(Token = "0x40019AE")]
			[FieldOffset(Offset = "0x3C")]
			private int _getObjectRetType;
		}

		// Token: 0x020005D3 RID: 1491
		[Token(Token = "0x20005D3")]
		[System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[System.Serializable]
		private class KeyList : IList, ICollection, IEnumerable
		{
			// Token: 0x06002C5E RID: 11358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C5E")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal KeyList(SortedList sortedList)
			{
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x06002C5F RID: 11359 RVA: 0x000184E0 File Offset: 0x000166E0
			[Token(Token = "0x170006FB")]
			public virtual int Count
			{
				[Token(Token = "0x6002C5F")]
				[Address(RVA = "0x319BD00", Offset = "0x319A900", VA = "0x18319BD00", Slot = "20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000184F8 File Offset: 0x000166F8
			[Token(Token = "0x170006FC")]
			public virtual bool IsReadOnly
			{
				[Token(Token = "0x6002C60")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "21")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x06002C61 RID: 11361 RVA: 0x00018510 File Offset: 0x00016710
			[Token(Token = "0x170006FD")]
			public virtual bool IsFixedSize
			{
				[Token(Token = "0x6002C61")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x06002C62 RID: 11362 RVA: 0x00018528 File Offset: 0x00016728
			[Token(Token = "0x170006FE")]
			public virtual bool IsSynchronized
			{
				[Token(Token = "0x6002C62")]
				[Address(RVA = "0x4C67920", Offset = "0x4C66520", VA = "0x184C67920", Slot = "23")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x06002C63 RID: 11363 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170006FF")]
			public virtual object SyncRoot
			{
				[Token(Token = "0x6002C63")]
				[Address(RVA = "0x4C679C0", Offset = "0x4C665C0", VA = "0x184C679C0", Slot = "24")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002C64 RID: 11364 RVA: 0x00018540 File Offset: 0x00016740
			[Token(Token = "0x6002C64")]
			[Address(RVA = "0x4C673F0", Offset = "0x4C65FF0", VA = "0x184C673F0", Slot = "25")]
			public virtual int Add(object key)
			{
				return 0;
			}

			// Token: 0x06002C65 RID: 11365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C65")]
			[Address(RVA = "0x4C67450", Offset = "0x4C66050", VA = "0x184C67450", Slot = "26")]
			public virtual void Clear()
			{
			}

			// Token: 0x06002C66 RID: 11366 RVA: 0x00018558 File Offset: 0x00016758
			[Token(Token = "0x6002C66")]
			[Address(RVA = "0x4C674B0", Offset = "0x4C660B0", VA = "0x184C674B0", Slot = "27")]
			public virtual bool Contains(object key)
			{
				return default(bool);
			}

			// Token: 0x06002C67 RID: 11367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C67")]
			[Address(RVA = "0x4C67510", Offset = "0x4C66110", VA = "0x184C67510", Slot = "28")]
			public virtual void CopyTo(System.Array array, int arrayIndex)
			{
			}

			// Token: 0x06002C68 RID: 11368 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C68")]
			[Address(RVA = "0x4C67800", Offset = "0x4C66400", VA = "0x184C67800", Slot = "29")]
			public virtual void Insert(int index, object value)
			{
			}

			// Token: 0x17000700 RID: 1792
			[Token(Token = "0x17000700")]
			public virtual object this[int index]
			{
				[Token(Token = "0x6002C69")]
				[Address(RVA = "0x4C67970", Offset = "0x4C66570", VA = "0x184C67970", Slot = "30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002C6A")]
				[Address(RVA = "0x4C67A10", Offset = "0x4C66610", VA = "0x184C67A10", Slot = "31")]
				set
				{
				}
			}

			// Token: 0x06002C6B RID: 11371 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C6B")]
			[Address(RVA = "0x4C67610", Offset = "0x4C66210", VA = "0x184C67610", Slot = "32")]
			public virtual IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002C6C RID: 11372 RVA: 0x00018570 File Offset: 0x00016770
			[Token(Token = "0x6002C6C")]
			[Address(RVA = "0x4C676E0", Offset = "0x4C662E0", VA = "0x184C676E0", Slot = "33")]
			public virtual int IndexOf(object key)
			{
				return 0;
			}

			// Token: 0x06002C6D RID: 11373 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C6D")]
			[Address(RVA = "0x4C678C0", Offset = "0x4C664C0", VA = "0x184C678C0", Slot = "34")]
			public virtual void Remove(object key)
			{
			}

			// Token: 0x06002C6E RID: 11374 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C6E")]
			[Address(RVA = "0x4C67860", Offset = "0x4C66460", VA = "0x184C67860", Slot = "35")]
			public virtual void RemoveAt(int index)
			{
			}

			// Token: 0x040019AF RID: 6575
			[Token(Token = "0x40019AF")]
			[FieldOffset(Offset = "0x10")]
			private SortedList sortedList;
		}

		// Token: 0x020005D4 RID: 1492
		[Token(Token = "0x20005D4")]
		[System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[System.Serializable]
		private class ValueList : IList, ICollection, IEnumerable
		{
			// Token: 0x06002C6F RID: 11375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C6F")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal ValueList(SortedList sortedList)
			{
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x06002C70 RID: 11376 RVA: 0x00018588 File Offset: 0x00016788
			[Token(Token = "0x17000701")]
			public virtual int Count
			{
				[Token(Token = "0x6002C70")]
				[Address(RVA = "0x319BD00", Offset = "0x319A900", VA = "0x18319BD00", Slot = "20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06002C71 RID: 11377 RVA: 0x000185A0 File Offset: 0x000167A0
			[Token(Token = "0x17000702")]
			public virtual bool IsReadOnly
			{
				[Token(Token = "0x6002C71")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "21")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06002C72 RID: 11378 RVA: 0x000185B8 File Offset: 0x000167B8
			[Token(Token = "0x17000703")]
			public virtual bool IsFixedSize
			{
				[Token(Token = "0x6002C72")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000185D0 File Offset: 0x000167D0
			[Token(Token = "0x17000704")]
			public virtual bool IsSynchronized
			{
				[Token(Token = "0x6002C73")]
				[Address(RVA = "0x4C67920", Offset = "0x4C66520", VA = "0x184C67920", Slot = "23")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06002C74 RID: 11380 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000705")]
			public virtual object SyncRoot
			{
				[Token(Token = "0x6002C74")]
				[Address(RVA = "0x4C679C0", Offset = "0x4C665C0", VA = "0x184C679C0", Slot = "24")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002C75 RID: 11381 RVA: 0x000185E8 File Offset: 0x000167E8
			[Token(Token = "0x6002C75")]
			[Address(RVA = "0x4C72450", Offset = "0x4C71050", VA = "0x184C72450", Slot = "25")]
			public virtual int Add(object key)
			{
				return 0;
			}

			// Token: 0x06002C76 RID: 11382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C76")]
			[Address(RVA = "0x4C724B0", Offset = "0x4C710B0", VA = "0x184C724B0", Slot = "26")]
			public virtual void Clear()
			{
			}

			// Token: 0x06002C77 RID: 11383 RVA: 0x00018600 File Offset: 0x00016800
			[Token(Token = "0x6002C77")]
			[Address(RVA = "0x4C5BC40", Offset = "0x4C5A840", VA = "0x184C5BC40", Slot = "27")]
			public virtual bool Contains(object value)
			{
				return default(bool);
			}

			// Token: 0x06002C78 RID: 11384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C78")]
			[Address(RVA = "0x4C72510", Offset = "0x4C71110", VA = "0x184C72510", Slot = "28")]
			public virtual void CopyTo(System.Array array, int arrayIndex)
			{
			}

			// Token: 0x06002C79 RID: 11385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C79")]
			[Address(RVA = "0x4C72780", Offset = "0x4C71380", VA = "0x184C72780", Slot = "29")]
			public virtual void Insert(int index, object value)
			{
			}

			// Token: 0x17000706 RID: 1798
			[Token(Token = "0x17000706")]
			public virtual object this[int index]
			{
				[Token(Token = "0x6002C7A")]
				[Address(RVA = "0x4C728A0", Offset = "0x4C714A0", VA = "0x184C728A0", Slot = "30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002C7B")]
				[Address(RVA = "0x4C728F0", Offset = "0x4C714F0", VA = "0x184C728F0", Slot = "31")]
				set
				{
				}
			}

			// Token: 0x06002C7C RID: 11388 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002C7C")]
			[Address(RVA = "0x4C72610", Offset = "0x4C71210", VA = "0x184C72610", Slot = "32")]
			public virtual IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002C7D RID: 11389 RVA: 0x00018618 File Offset: 0x00016818
			[Token(Token = "0x6002C7D")]
			[Address(RVA = "0x4C726E0", Offset = "0x4C712E0", VA = "0x184C726E0", Slot = "33")]
			public virtual int IndexOf(object value)
			{
				return 0;
			}

			// Token: 0x06002C7E RID: 11390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C7E")]
			[Address(RVA = "0x4C72840", Offset = "0x4C71440", VA = "0x184C72840", Slot = "34")]
			public virtual void Remove(object value)
			{
			}

			// Token: 0x06002C7F RID: 11391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C7F")]
			[Address(RVA = "0x4C727E0", Offset = "0x4C713E0", VA = "0x184C727E0", Slot = "35")]
			public virtual void RemoveAt(int index)
			{
			}

			// Token: 0x040019B0 RID: 6576
			[Token(Token = "0x40019B0")]
			[FieldOffset(Offset = "0x10")]
			private SortedList sortedList;
		}

		// Token: 0x020005D5 RID: 1493
		[Token(Token = "0x20005D5")]
		internal class SortedListDebugView
		{
		}
	}
}
