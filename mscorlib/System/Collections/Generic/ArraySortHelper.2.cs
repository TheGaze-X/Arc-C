using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000625 RID: 1573
	[Token(Token = "0x2000625")]
	internal class ArraySortHelper<TKey, TValue>
	{
		// Token: 0x06002F74 RID: 12148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F74")]
		public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F75")]
		private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b)
		{
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F76")]
		private static void Swap(TKey[] keys, TValue[] values, int i, int j)
		{
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F77")]
		internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F78")]
		private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00019A28 File Offset: 0x00017C28
		[Token(Token = "0x6002F79")]
		private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
			return 0;
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7A")]
		private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7B")]
		private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7C")]
		private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007B8")]
		public static ArraySortHelper<TKey, TValue> Default
		{
			[Token(Token = "0x6002F7D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7E")]
		public ArraySortHelper()
		{
		}

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper;
	}
}
