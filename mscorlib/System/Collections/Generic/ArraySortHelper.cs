using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000624 RID: 1572
	[Token(Token = "0x2000624")]
	internal class ArraySortHelper<T>
	{
		// Token: 0x06002F65 RID: 12133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F65")]
		public void Sort(T[] keys, int index, int length, IComparer<T> comparer)
		{
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x000199E0 File Offset: 0x00017BE0
		[Token(Token = "0x6002F66")]
		public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F67")]
		internal static void Sort(T[] keys, int index, int length, System.Comparison<T> comparer)
		{
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000199F8 File Offset: 0x00017BF8
		[Token(Token = "0x6002F68")]
		internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F69")]
		private static void SwapIfGreater(T[] keys, System.Comparison<T> comparer, int a, int b)
		{
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6A")]
		private static void Swap(T[] a, int i, int j)
		{
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6B")]
		internal static void IntrospectiveSort(T[] keys, int left, int length, System.Comparison<T> comparer)
		{
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6C")]
		private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, System.Comparison<T> comparer)
		{
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00019A10 File Offset: 0x00017C10
		[Token(Token = "0x6002F6D")]
		private static int PickPivotAndPartition(T[] keys, int lo, int hi, System.Comparison<T> comparer)
		{
			return 0;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6E")]
		private static void Heapsort(T[] keys, int lo, int hi, System.Comparison<T> comparer)
		{
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6F")]
		private static void DownHeap(T[] keys, int i, int n, int lo, System.Comparison<T> comparer)
		{
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F70")]
		private static void InsertionSort(T[] keys, int lo, int hi, System.Comparison<T> comparer)
		{
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007B7")]
		public static ArraySortHelper<T> Default
		{
			[Token(Token = "0x6002F71")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F72")]
		public ArraySortHelper()
		{
		}

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ArraySortHelper<T> s_defaultArraySortHelper;
	}
}
