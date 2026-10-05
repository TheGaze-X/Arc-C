using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	public static class DatePickerUtilities
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x5C473A0", Offset = "0x5C45FA0", VA = "0x185C473A0")]
		public static string ToDateString(this DateTime date)
		{
			return null;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x5C46D60", Offset = "0x5C45960", VA = "0x185C46D60")]
		public static string[] GetAbbreviatedDayNames()
		{
			return null;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x5C470A0", Offset = "0x5C45CA0", VA = "0x185C470A0")]
		public static List<DateTime> GetDateRangeForDisplay(DateTime date)
		{
			return null;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x5C46F50", Offset = "0x5C45B50", VA = "0x185C46F50")]
		public static List<DateTime> GetCurrentMonths()
		{
			return null;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x5C472C0", Offset = "0x5C45EC0", VA = "0x185C472C0")]
		public static List<int> GetYearRange(int startYear, int endYear)
		{
			return null;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x5C46A70", Offset = "0x5C45670", VA = "0x185C46A70")]
		public static bool DateFallsWithinMonth(DateTime date, DateTime month)
		{
			return default(bool);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000745")]
		internal static T[] Shift<T>(T[] array, int positions)
		{
			return null;
		}

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x0")]
		public static string DateFormat;
	}
}
