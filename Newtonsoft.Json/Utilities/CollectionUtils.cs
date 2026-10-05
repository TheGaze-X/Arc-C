using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[Preserve]
	internal static class CollectionUtils
	{
		// Token: 0x060003CA RID: 970 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x60003CA")]
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return default(bool);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CB")]
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CC")]
		public static void AddRange<T>(this IList<T> initial, IEnumerable collection)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x4D7DCD0", Offset = "0x4D7C8D0", VA = "0x184D7DCD0")]
		public static bool IsDictionaryType(Type type)
		{
			return default(bool);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x4D7DFA0", Offset = "0x4D7CBA0", VA = "0x184D7DFA0")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			return null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x4D7E0E0", Offset = "0x4D7CCE0", VA = "0x184D7E0E0")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			return null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x60003D0")]
		public static bool AddDistinct<T>(this IList<T> list, T value)
		{
			return default(bool);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60003D1")]
		public static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x60003D2")]
		public static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return default(bool);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60003D3")]
		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60003D4")]
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			return 0;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x60003D5")]
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x60003D6")]
		public static int IndexOfReference<T>(this List<T> list, T item)
		{
			return 0;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x4D7D8A0", Offset = "0x4D7C4A0", VA = "0x184D7D8A0")]
		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			return null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x4D7D660", Offset = "0x4D7C260", VA = "0x184D7D660")]
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x4D7DEA0", Offset = "0x4D7CAA0", VA = "0x184D7DEA0")]
		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			return null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x4D7E360", Offset = "0x4D7CF60", VA = "0x184D7E360")]
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}
	}
}
