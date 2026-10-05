using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public static class LinqExtensions
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000029")]
		public static IEnumerable<T> Examine<T>(this IEnumerable<T> source, Action<T> action)
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600002A")]
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600002B")]
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600002C")]
		public static IEnumerable<T> Convert<T>(this IEnumerable source, Func<object, T> converter)
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600002D")]
		public static ImmutableList<T> ToImmutableList<T>(this IEnumerable<T> source)
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600002E")]
		public static IEnumerable<T> PrependWith<T>(this IEnumerable<T> source, Func<T> prepend)
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600002F")]
		public static IEnumerable<T> PrependWith<T>(this IEnumerable<T> source, T prepend)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000030")]
		public static IEnumerable<T> PrependWith<T>(this IEnumerable<T> source, IEnumerable<T> prepend)
		{
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000031")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, bool condition, Func<T> prepend)
		{
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000032")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, bool condition, T prepend)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000033")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, bool condition, IEnumerable<T> prepend)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000034")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<bool> condition, Func<T> prepend)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000035")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<bool> condition, T prepend)
		{
			return null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000036")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<bool> condition, IEnumerable<T> prepend)
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000037")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, Func<T> prepend)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000038")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, T prepend)
		{
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000039")]
		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, IEnumerable<T> prepend)
		{
			return null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003A")]
		public static IEnumerable<T> AppendWith<T>(this IEnumerable<T> source, Func<T> append)
		{
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003B")]
		public static IEnumerable<T> AppendWith<T>(this IEnumerable<T> source, T append)
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003C")]
		public static IEnumerable<T> AppendWith<T>(this IEnumerable<T> source, IEnumerable<T> append)
		{
			return null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003D")]
		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, bool condition, Func<T> append)
		{
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003E")]
		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, bool condition, T append)
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003F")]
		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, bool condition, IEnumerable<T> append)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000040")]
		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, Func<bool> condition, Func<T> append)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000041")]
		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, Func<bool> condition, T append)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000042")]
		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, Func<bool> condition, IEnumerable<T> append)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000043")]
		public static IEnumerable<T> FilterCast<T>(this IEnumerable source)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000044")]
		public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> range)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000045")]
		public static bool IsNullOrEmpty<T>(this IList<T> list)
		{
			return default(bool);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000046")]
		public static void Populate<T>(this IList<T> list, T item)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000047")]
		public static void AddRange<T>(this IList<T> list, IEnumerable<T> collection)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000048")]
		public static void Sort<T>(this IList<T> list, Comparison<T> comparison)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000049")]
		public static void Sort<T>(this IList<T> list)
		{
		}
	}
}
