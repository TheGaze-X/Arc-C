using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000612 RID: 1554
	[Token(Token = "0x2000612")]
	internal struct ArrayBuilder<T>
	{
		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x00019728 File Offset: 0x00017928
		[Token(Token = "0x170007A3")]
		public int Capacity
		{
			[Token(Token = "0x6002EEE")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x00019740 File Offset: 0x00017940
		[Token(Token = "0x170007A4")]
		public int Count
		{
			[Token(Token = "0x6002EEF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007A5 RID: 1957
		[Token(Token = "0x170007A5")]
		public T this[int index]
		{
			[Token(Token = "0x6002EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF1")]
		public void Add(T item)
		{
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF2")]
		public void UncheckedAdd(T item)
		{
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF3")]
		private void EnsureCapacity(int minimum)
		{
		}

		// Token: 0x04001A55 RID: 6741
		[Token(Token = "0x4001A55")]
		[FieldOffset(Offset = "0x0")]
		private T[] _array;

		// Token: 0x04001A56 RID: 6742
		[Token(Token = "0x4001A56")]
		[FieldOffset(Offset = "0x0")]
		private int _count;
	}
}
