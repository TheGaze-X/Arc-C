using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	public static class ArrayUtil
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000538")]
		public static T[] Clone<T>(T[] source)
		{
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Token(Token = "0x6000539")]
		public static bool Same<T>(T[] ary1, T[] ary2)
		{
			return default(bool);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00005ABC File Offset: 0x00003CBC
		[Token(Token = "0x600053A")]
		public static bool Same<T>(T[] ary1, T[] ary2, Func<T, T, bool> comparison)
		{
			return default(bool);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[Token(Token = "0x600053B")]
		private static bool _DefaultArrayComparison<T>(T item1, T item2)
		{
			return default(bool);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00005AEC File Offset: 0x00003CEC
		[Token(Token = "0x600053C")]
		public static bool Same<T>(List<T> list1, List<T> list2)
		{
			return default(bool);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00005B04 File Offset: 0x00003D04
		[Token(Token = "0x600053D")]
		public static bool Same<T>(List<T> list1, List<T> list2, Func<T, T, bool> comparison)
		{
			return default(bool);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600053E")]
		public static void ShallowCopyList<T>(List<T> source, ref List<T> target)
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600053F")]
		public static void DiffList<Data, Container>(List<Data> source, List<Data> filter, Func<Data, Data, bool> equals, Action<Data, Container> collect, Container container)
		{
		}
	}
}
