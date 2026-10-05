using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[DebuggerDisplay("Item count = {m_Count}")]
	public struct TMP_TextProcessingStack<T>
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000606")]
		public TMP_TextProcessingStack(T[] stack)
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000607")]
		public TMP_TextProcessingStack(int capacity)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000608")]
		public TMP_TextProcessingStack(int capacity, int rolloverSize)
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x1700016E")]
		public int Count
		{
			[Token(Token = "0x6000609")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700016F")]
		public T current
		{
			[Token(Token = "0x600060A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00004608 File Offset: 0x00002808
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000170")]
		public int rolloverSize
		{
			[Token(Token = "0x600060B")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600060C")]
			set
			{
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060D")]
		internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060E")]
		public void Clear()
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060F")]
		public void SetDefault(T item)
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000610")]
		public void Add(T item)
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000611")]
		public T Remove()
		{
			return null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000612")]
		public void Push(T item)
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000613")]
		public T Pop()
		{
			return null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000614")]
		public T Peek()
		{
			return null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000615")]
		public T CurrentItem()
		{
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000616")]
		public T PreviousItem()
		{
			return null;
		}

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x0")]
		public T[] itemStack;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x0")]
		private T m_DefaultItem;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x0")]
		private int m_Capacity;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x0")]
		private int m_RolloverSize;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x0")]
		private int m_Count;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		private const int k_DefaultCapacity = 4;
	}
}
