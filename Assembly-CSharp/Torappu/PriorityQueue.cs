using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x2000570")]
	public class PriorityQueue<T> : IEnumerable, IEnumerable<T> where T : IComparable<T>
	{
		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06005B8D RID: 23437 RVA: 0x0002EE78 File Offset: 0x0002D078
		[Token(Token = "0x17000CB0")]
		public int count
		{
			[Token(Token = "0x6005B8D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06005B8E RID: 23438 RVA: 0x0002EE90 File Offset: 0x0002D090
		[Token(Token = "0x17000CB1")]
		public bool isEmpty
		{
			[Token(Token = "0x6005B8E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CB2 RID: 3250
		[Token(Token = "0x17000CB2")]
		public T this[int index]
		{
			[Token(Token = "0x6005B8F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B90")]
			set
			{
			}
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B91")]
		public PriorityQueue()
		{
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B92")]
		public PriorityQueue(int capacity)
		{
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B93")]
		public PriorityQueue(IList<T> items)
		{
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B94")]
		public void Add(T item)
		{
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		[Token(Token = "0x6005B95")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B96")]
		public void RemoveLast()
		{
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B97")]
		public void Clear()
		{
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B98")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B99")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04002127 RID: 8487
		[Token(Token = "0x4002127")]
		[FieldOffset(Offset = "0x0")]
		private List<T> m_list;
	}
}
