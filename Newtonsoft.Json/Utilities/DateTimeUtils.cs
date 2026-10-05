using System;
using System.Globalization;
using System.IO;
using System.Xml;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[Preserve]
	internal static class DateTimeUtils
	{
		// Token: 0x06000356 RID: 854 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x4D83410", Offset = "0x4D82010", VA = "0x184D83410")]
		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			return default(TimeSpan);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x4D83610", Offset = "0x4D82210", VA = "0x184D83610")]
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			return XmlDateTimeSerializationMode.Local;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x4D82F70", Offset = "0x4D81B70", VA = "0x184D82F70")]
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			return default(DateTime);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x4D83470", Offset = "0x4D82070", VA = "0x184D83470")]
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			return default(DateTime);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x4D83540", Offset = "0x4D82140", VA = "0x184D83540")]
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			return default(DateTime);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x4D83830", Offset = "0x4D82430", VA = "0x184D83830")]
		private static long ToUniversalTicks(DateTime dateTime)
		{
			return 0L;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x4D836C0", Offset = "0x4D822C0", VA = "0x184D836C0")]
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			return 0L;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x4D82A20", Offset = "0x4D81620", VA = "0x184D82A20")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return 0L;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x4D82AE0", Offset = "0x4D816E0", VA = "0x184D82AE0")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return 0L;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x4D82B30", Offset = "0x4D81730", VA = "0x184D82B30")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			return 0L;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x4D856F0", Offset = "0x4D842F0", VA = "0x184D856F0")]
		private static long UniversialTicksToJavaScriptTicks(long universialTicks)
		{
			return 0L;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x4D82D10", Offset = "0x4D81910", VA = "0x184D82D10")]
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return default(DateTime);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x4D83A20", Offset = "0x4D82620", VA = "0x184D83A20")]
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x4D840F0", Offset = "0x4D82CF0", VA = "0x184D840F0")]
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x4D82E10", Offset = "0x4D81A10", VA = "0x184D82E10")]
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser)
		{
			return default(DateTime);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x4D84B10", Offset = "0x4D83710", VA = "0x184D84B10")]
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x4D84E50", Offset = "0x4D83A50", VA = "0x184D84E50")]
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x4D84500", Offset = "0x4D83100", VA = "0x184D84500")]
		internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x4D84820", Offset = "0x4D83420", VA = "0x184D84820")]
		internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x4D85120", Offset = "0x4D83D20", VA = "0x184D85120")]
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
		{
			return default(bool);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x4D83EE0", Offset = "0x4D82AE0", VA = "0x184D83EE0")]
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x4D83930", Offset = "0x4D82530", VA = "0x184D83930")]
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x4D84380", Offset = "0x4D82F80", VA = "0x184D84380")]
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x4D84040", Offset = "0x4D82C40", VA = "0x184D84040")]
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x4D85440", Offset = "0x4D84040", VA = "0x184D85440")]
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
		{
			return default(bool);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x4D85BA0", Offset = "0x4D847A0", VA = "0x184D85BA0")]
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x4D85D70", Offset = "0x4D84970", VA = "0x184D85D70")]
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			return 0;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x4D861A0", Offset = "0x4D84DA0", VA = "0x184D861A0")]
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			return 0;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x4D82D90", Offset = "0x4D81990", VA = "0x184D82D90")]
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x4D85970", Offset = "0x4D84570", VA = "0x184D85970")]
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			return 0;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x4D85760", Offset = "0x4D84360", VA = "0x184D85760")]
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x4D83230", Offset = "0x4D81E30", VA = "0x184D83230")]
		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
		}

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly long InitialJavaScriptDateTicks;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK";

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		private const int DaysPer100Years = 36524;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		private const int DaysPer400Years = 146097;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		private const int DaysPer4Years = 1461;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		private const int DaysPerYear = 365;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		private const long TicksPerDay = 864000000000L;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] DaysToMonth365;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] DaysToMonth366;
	}
}
