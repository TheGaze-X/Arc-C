using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI.Collections
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BE")]
		public void Add(T item)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BF")]
		public void Add(T item, bool isActive)
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x60005C0")]
		public bool AddUnique(T item, bool isActive = true)
		{
			return default(bool);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x60005C1")]
		public bool EnableItem(T item)
		{
			return default(bool);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x60005C2")]
		public bool DisableItem(T item)
		{
			return default(bool);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x60005C3")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C4")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C6")]
		public void Clear()
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60005C7")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C8")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x17000177")]
		public int Count
		{
			[Token(Token = "0x60005C9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x17000178")]
		public int Capacity
		{
			[Token(Token = "0x60005CA")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x17000179")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60005CB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60005CC")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CD")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CE")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CF")]
		private void Swap(int index1, int index2)
		{
		}

		// Token: 0x1700017A RID: 378
		[Token(Token = "0x1700017A")]
		public T this[int index]
		{
			[Token(Token = "0x60005D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D1")]
			set
			{
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D2")]
		public void RemoveAll(Predicate<T> match)
		{
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D3")]
		public void Sort(Comparison<T> sortLayoutFunction)
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D4")]
		public IndexedSet()
		{
		}

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<T> m_List;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, int> m_Dictionary;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x0")]
		private int m_EnabledObjectCount;
	}
}
