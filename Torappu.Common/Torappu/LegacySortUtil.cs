using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public static class LegacySortUtil
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000B0")]
		public static void LegacySort<T>(this List<T> list)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000B1")]
		public static void LegacySort<T>(this List<T> list, IComparer<T> comparer)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000B2")]
		public static void LegacySort<T>(this List<T> list, int index, int count, IComparer<T> comparer)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000B3")]
		public static void LegacySort<T>(this List<T> list, Comparison<T> comparison)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		private static FieldInfo internalArrayField
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x54E42B0", Offset = "0x54E2EB0", VA = "0x1854E42B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B5")]
		private static T[] _GetInternalArray<T>(this List<T> list)
		{
			return null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000B6")]
		private static void _LegacyArraySort<TKey, TValue>(IList<TKey> keys, IList<TValue> items, int index, int length, IComparer<TKey> comparer)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000B7")]
		private static void _LegacyArraySort<T>(IList<T> array, int length, Comparison<T> comparison)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000B8")]
		private static void qsort<T>(IList<T> array, int low0, int high0, Comparison<T> comparison)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000B9")]
		private static void qsort<K, V>(IList<K> keys, IList<V> items, int low0, int high0, IComparer<K> comparer)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x60000BA")]
		private static int compare<T>(T value1, T value2, IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000BB")]
		private static void swap<T>(IList<T> array, int i, int j)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000BC")]
		private static void swap<K, V>(IList<K> keys, IList<V> items, int i, int j)
		{
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x0")]
		private static FieldInfo s_internalArrayField;
	}
}
