using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public class Heap<T> : IEnumerable, IEnumerable<T> where T : IComparable<T>
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x000053CC File Offset: 0x000035CC
		[Token(Token = "0x17000057")]
		public int count
		{
			[Token(Token = "0x6000476")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000053E4 File Offset: 0x000035E4
		[Token(Token = "0x17000058")]
		public bool isEmpty
		{
			[Token(Token = "0x6000477")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000059 RID: 89
		[Token(Token = "0x17000059")]
		public T this[int index]
		{
			[Token(Token = "0x6000478")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000479")]
		public Heap(int capacity = 0)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600047A")]
		public void Push(T item)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047B")]
		public T Pop()
		{
			return null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047C")]
		public T Peek()
		{
			return null;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000053FC File Offset: 0x000035FC
		[Token(Token = "0x600047D")]
		public bool Update(T obj)
		{
			return default(bool);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00005414 File Offset: 0x00003614
		[Token(Token = "0x600047E")]
		public bool Remove(T obj)
		{
			return default(bool);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600047F")]
		public void Clear()
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x6000480")]
		public bool Contains(T obj)
		{
			return default(bool);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000481")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000482")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000483")]
		private void _Up(int index)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000484")]
		private void _Down(int index)
		{
		}

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x0")]
		private List<Heap<T>.InternalHeapNode> m_list;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, Heap<T>.InternalHeapNode> m_dataMap;

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		private class Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000485 RID: 1157 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700005A")]
			public T Current
			{
				[Token(Token = "0x6000485")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000486 RID: 1158 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700005B")]
			private object Current
			{
				[Token(Token = "0x6000486")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000487")]
			public Enumerator(IEnumerator<Heap<T>.InternalHeapNode> enumerator)
			{
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x00005444 File Offset: 0x00003644
			[Token(Token = "0x6000488")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000489")]
			public void Reset()
			{
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600048A")]
			public void Dispose()
			{
			}

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<Heap<T>.InternalHeapNode> m_enumerator;
		}

		// Token: 0x020000BF RID: 191
		[Token(Token = "0x20000BF")]
		private class InternalHeapNode : IComparable<Heap<T>.InternalHeapNode>
		{
			// Token: 0x0600048B RID: 1163 RVA: 0x0000545C File Offset: 0x0000365C
			[Token(Token = "0x600048B")]
			public int CompareTo(Heap<T>.InternalHeapNode other)
			{
				return 0;
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600048C")]
			public InternalHeapNode()
			{
			}

			// Token: 0x0400049F RID: 1183
			[Token(Token = "0x400049F")]
			[FieldOffset(Offset = "0x0")]
			public T data;

			// Token: 0x040004A0 RID: 1184
			[Token(Token = "0x40004A0")]
			[FieldOffset(Offset = "0x0")]
			public int index;
		}
	}
}
