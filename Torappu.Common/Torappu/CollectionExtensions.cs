using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public static class CollectionExtensions
	{
		// Token: 0x06000089 RID: 137 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000089")]
		public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
		{
			return default(bool);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x600008A")]
		public static bool IsNullOrEmpty<T>(this Queue<T> collection)
		{
			return default(bool);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008B")]
		public static T[] ToArrayE<T>(this ICollection<T> collection)
		{
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008C")]
		public static List<T> ToListE<T>(this ICollection<T> collection)
		{
			return null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008D")]
		public static T FirstE<T>(this IEnumerable<T> list)
		{
			return null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008E")]
		public static T First<T>(this IList<T> list)
		{
			return null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008F")]
		public static T FirstOfDefault<T>(this IList<T> list)
		{
			return null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000090")]
		public static T Last<T>(this IList<T> list)
		{
			return null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		public static T LastOrNull<T>(this IList<T> list)
		{
			return null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x6000092")]
		public static bool ContainsItem<T>(this IList<T> list, T item)
		{
			return default(bool);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x54DB050", Offset = "0x54D9C50", VA = "0x1854DB050")]
		public static bool ContainsItem(this IList<string> list, string item, bool ignoreCase)
		{
			return default(bool);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000094")]
		public static void Resize<T>(this List<T> list, int size)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000095")]
		public static void Shrink<T>(this List<T> list, int size)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x6000096")]
		public static int IndexOf<T>(this T[] list, T item) where T : class
		{
			return 0;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x54DB110", Offset = "0x54D9D10", VA = "0x1854DB110")]
		public static int IndexOf(this IList<string> list, string item, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x6000098")]
		public static int SafeCount<T>(this IList<T> list)
		{
			return 0;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000099")]
		public static int SafeDictCount<K, V>(this IDictionary<K, V> dict)
		{
			return 0;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		public static T SafeGet<T>(this IList<T> list, int index, [Optional] T defaultVal)
		{
			return null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		public static T SafeClampGet<T>(this IList<T> list, int index, [Optional] T defaultVal)
		{
			return null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600009C")]
		public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> range)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		private static T _ClampInternal<T>(T k, T min, T max) where T : IComparable
		{
			return null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x600009E")]
		public static bool TrySafeGet<T>(this IList<T> list, int index, out T result)
		{
			return default(bool);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		public static Value GetValueOrDefault<Key, Value>(this IDictionary<Key, Value> dict, Key key, [Optional] Value defVal)
		{
			return null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		public static TValue EnumKeyGetValueOrDefault<TEnum, TValue>(this Dictionary<string, TValue> dict, TEnum key, [Optional] TValue defVal) where TEnum : struct
		{
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x60000A1")]
		public static bool TryGetValue<TEnum, TValue>(this Dictionary<string, TValue> dict, TEnum key, out TValue value) where TEnum : struct
		{
			return default(bool);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x60000A2")]
		public static bool CheckValidIndex<T>(this IList<T> list, int index)
		{
			return default(bool);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A3")]
		public static List<T> DistinctE<T>(this IList<T> list)
		{
			return null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000A4")]
		public static void RemoveDuplicationsInplace<T>(this IList<T> list)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000A5")]
		public static void ResetAllElementAsDefault<T>(this IList<T> list)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000A6")]
		public static void AddRangeE<T>(this ICollection<T> list, IList<T> add)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000A7")]
		public static void AddRangeWithoutDup<T>(this IList<T> list, IEnumerable<T> add)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000A8")]
		public static void RemoveRange<T>(this IList<T> left, IEnumerable<T> right)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x60000A9")]
		public static bool ContainsAny<T>(this IList<T> list, IEnumerable<T> right)
		{
			return default(bool);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		public static IList<T> ExceptE<T>(this IEnumerable<T> first, IEnumerable<T> second)
		{
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000AB")]
		public static void ReverseNoGCAlloc<T>(this IList<T> list)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000AC")]
		public static void StableBubbleSort<T>(this IList<T> list, Comparison<T> compare, int count = -1)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		public static T[] CreateOrReuse<T>(this T[] reuse, T singleElement)
		{
			return null;
		}
	}
}
