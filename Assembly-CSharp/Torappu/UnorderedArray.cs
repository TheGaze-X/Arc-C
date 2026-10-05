using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000591 RID: 1425
	[Token(Token = "0x2000591")]
	public class UnorderedArray<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06005C1B RID: 23579 RVA: 0x0002F178 File Offset: 0x0002D378
		// (set) Token: 0x06005C1C RID: 23580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CB7")]
		public int count
		{
			[Token(Token = "0x6005C1B")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005C1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CB8 RID: 3256
		[Token(Token = "0x17000CB8")]
		public T this[int index]
		{
			[Token(Token = "0x6005C1D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1E")]
		public UnorderedArray(int capacity)
		{
		}

		// Token: 0x06005C1F RID: 23583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1F")]
		public void Add(T item)
		{
		}

		// Token: 0x06005C20 RID: 23584 RVA: 0x0002F190 File Offset: 0x0002D390
		[Token(Token = "0x6005C20")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06005C21 RID: 23585 RVA: 0x0002F1A8 File Offset: 0x0002D3A8
		[Token(Token = "0x6005C21")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06005C22 RID: 23586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C22")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005C23 RID: 23587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C23")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040021CD RID: 8653
		[Token(Token = "0x40021CD")]
		[FieldOffset(Offset = "0x0")]
		private T[] m_items;

		// Token: 0x040021CE RID: 8654
		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, int> m_itemMap;

		// Token: 0x02000592 RID: 1426
		[Token(Token = "0x2000592")]
		private class Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x06005C24 RID: 23588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CB9")]
			public T Current
			{
				[Token(Token = "0x6005C24")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x06005C25 RID: 23589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CBA")]
			private object Current
			{
				[Token(Token = "0x6005C25")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005C26 RID: 23590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C26")]
			public Enumerator(T[] items, int count)
			{
			}

			// Token: 0x06005C27 RID: 23591 RVA: 0x0002F1C0 File Offset: 0x0002D3C0
			[Token(Token = "0x6005C27")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06005C28 RID: 23592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C28")]
			public void Reset()
			{
			}

			// Token: 0x06005C29 RID: 23593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C29")]
			public void Dispose()
			{
			}

			// Token: 0x040021D0 RID: 8656
			[Token(Token = "0x40021D0")]
			[FieldOffset(Offset = "0x0")]
			private T[] m_items;

			// Token: 0x040021D1 RID: 8657
			[Token(Token = "0x40021D1")]
			[FieldOffset(Offset = "0x0")]
			private int m_index;

			// Token: 0x040021D2 RID: 8658
			[Token(Token = "0x40021D2")]
			[FieldOffset(Offset = "0x0")]
			private int m_count;
		}
	}
}
