using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[DebuggerDisplay("Item count = {m_Count}")]
	internal struct TextProcessingStack<T>
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		public TextProcessingStack(T[] stack)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		public TextProcessingStack(int capacity)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		public void Clear()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		public void SetDefault(T item)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		public void Add(T item)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600012C")]
		public T Remove()
		{
			return null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		public void Push(T item)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600012E")]
		public T Pop()
		{
			return null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600012F")]
		public T Peek()
		{
			return null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000130")]
		public T CurrentItem()
		{
			return null;
		}

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x0")]
		public T[] itemStack;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x0")]
		private T m_DefaultItem;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x0")]
		private int m_Capacity;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x0")]
		private int m_RolloverSize;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x0")]
		private int m_Count;
	}
}
