using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Extension
{
	// Token: 0x0200022D RID: 557
	[Token(Token = "0x200022D")]
	public static class CollectionExtensions
	{
		// Token: 0x06000E4D RID: 3661 RVA: 0x000042A4 File Offset: 0x000024A4
		[Token(Token = "0x6000E4D")]
		public static bool IsNullOrEmpty<T>(this List<T> list)
		{
			return default(bool);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x6000E4E")]
		public static bool IsNullOrEmpty<T>(this T[] array)
		{
			return default(bool);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000042D4 File Offset: 0x000024D4
		[Token(Token = "0x6000E4F")]
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
		{
			return default(bool);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x000042EC File Offset: 0x000024EC
		[Token(Token = "0x6000E50")]
		public static bool IsNull<T>(this List<T> list)
		{
			return default(bool);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x6000E51")]
		public static bool IsNull<T>(this T[] array)
		{
			return default(bool);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0000431C File Offset: 0x0000251C
		[Token(Token = "0x6000E52")]
		public static bool IsEmpty<T>(this List<T> list)
		{
			return default(bool);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x6000E53")]
		public static bool IsEmpty<T>(this T[] array)
		{
			return default(bool);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E54")]
		public static List<T> RemoveDuplicatesWithHashSet<T>(this List<T> source)
		{
			return null;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x5C9DE70", Offset = "0x5C9CA70", VA = "0x185C9DE70")]
		public static List<string> RemoveNullOrEmptyAndDuplicates(this List<string> source)
		{
			return null;
		}
	}
}
