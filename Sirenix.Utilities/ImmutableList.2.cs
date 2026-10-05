using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[Serializable]
	public sealed class ImmutableList<T> : IImmutableList<T>, IImmutableList, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T>
	{
		// Token: 0x06000308 RID: 776 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000308")]
		public ImmutableList(IList<T> innerList)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x17000057")]
		public int Count
		{
			[Token(Token = "0x6000309")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x17000058")]
		private bool IsSynchronized
		{
			[Token(Token = "0x600030A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000059")]
		private object SyncRoot
		{
			[Token(Token = "0x600030B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000032CC File Offset: 0x000014CC
		[Token(Token = "0x1700005A")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600030C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x1700005B")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600030D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x1700005C")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600030E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700005D")]
		private object Item
		{
			[Token(Token = "0x600030F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000310")]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700005E")]
		private T Item
		{
			[Token(Token = "0x6000311")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000312")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		[Token(Token = "0x1700005F")]
		public T this[int index]
		{
			[Token(Token = "0x6000313")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x6000314")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000315")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000316")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000317")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000318")]
		private void Add(T item)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000319")]
		private void Clear()
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x600031A")]
		private bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600031B")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003344 File Offset: 0x00001544
		[Token(Token = "0x600031C")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600031D")]
		private void Clear()
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x600031E")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x600031F")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000320")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000321")]
		private void Remove(object value)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000322")]
		private void Insert(int index, T item)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000323")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x6000324")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000325")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private IList<T> innerList;
	}
}
