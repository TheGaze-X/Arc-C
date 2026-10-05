using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	[Serializable]
	public sealed class ImmutableList<TList, TElement> : IImmutableList<TElement>, IImmutableList, IList, ICollection, IEnumerable, IList<TElement>, ICollection<TElement>, IEnumerable<TElement> where TList : IList<TElement>
	{
		// Token: 0x06000326 RID: 806 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000326")]
		public ImmutableList(TList innerList)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000033A4 File Offset: 0x000015A4
		[Token(Token = "0x17000060")]
		public int Count
		{
			[Token(Token = "0x6000327")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x17000061")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000328")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000062")]
		private object SyncRoot
		{
			[Token(Token = "0x6000329")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x17000063")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600032A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000033EC File Offset: 0x000015EC
		[Token(Token = "0x17000064")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600032B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00003404 File Offset: 0x00001604
		[Token(Token = "0x17000065")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600032C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600032E RID: 814 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000066")]
		private object Item
		{
			[Token(Token = "0x600032D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032E")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000330 RID: 816 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000067")]
		private TElement Item
		{
			[Token(Token = "0x600032F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000330")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		[Token(Token = "0x17000068")]
		public TElement this[int index]
		{
			[Token(Token = "0x6000331")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x6000332")]
		public bool Contains(TElement item)
		{
			return default(bool);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000333")]
		public void CopyTo(TElement[] array, int arrayIndex)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000334")]
		public IEnumerator<TElement> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000335")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000336")]
		private void Add(TElement item)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000337")]
		private void Clear()
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x6000338")]
		private bool Remove(TElement item)
		{
			return default(bool);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000339")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x600033A")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600033B")]
		private void Clear()
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x600033C")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x600033D")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600033E")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600033F")]
		private void Remove(object value)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000340")]
		private void Insert(int index, TElement item)
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000341")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x6000342")]
		public int IndexOf(TElement item)
		{
			return 0;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000343")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x0")]
		private TList innerList;
	}
}
