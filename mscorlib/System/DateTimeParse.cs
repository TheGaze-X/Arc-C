using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	internal static class DateTimeParse
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x4CCD7B0", Offset = "0x4CCC3B0", VA = "0x184CCD7B0")]
		internal static System.DateTime ParseExact(System.ReadOnlySpan<char> s, System.ReadOnlySpan<char> format, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles style)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x4CCD590", Offset = "0x4CCC190", VA = "0x184CCD590")]
		internal static System.DateTime ParseExact(System.ReadOnlySpan<char> s, System.ReadOnlySpan<char> format, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles style, out System.TimeSpan offset)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4CD00C0", Offset = "0x4CCECC0", VA = "0x184CD00C0")]
		internal static bool TryParseExact(System.ReadOnlySpan<char> s, System.ReadOnlySpan<char> format, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles style, out System.DateTime result)
		{
			return default(bool);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x4CD0280", Offset = "0x4CCEE80", VA = "0x184CD0280")]
		internal static bool TryParseExact(System.ReadOnlySpan<char> s, System.ReadOnlySpan<char> format, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles style, out System.DateTime result, out System.TimeSpan offset)
		{
			return default(bool);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x4CCFFC0", Offset = "0x4CCEBC0", VA = "0x184CCFFC0")]
		internal static bool TryParseExact(System.ReadOnlySpan<char> s, System.ReadOnlySpan<char> format, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles style, ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000075A8 File Offset: 0x000057A8
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x4CCD440", Offset = "0x4CCC040", VA = "0x184CCD440")]
		internal static System.DateTime ParseExactMultiple(System.ReadOnlySpan<char> s, string[] formats, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles style)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x4CCFC40", Offset = "0x4CCE840", VA = "0x184CCFC40")]
		internal static bool TryParseExactMultiple(System.ReadOnlySpan<char> s, string[] formats, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles style, ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x4CCB650", Offset = "0x4CCA250", VA = "0x184CCB650")]
		private static bool MatchWord(ref __DTString str, string target)
		{
			return default(bool);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x4CC9070", Offset = "0x4CC7C70", VA = "0x184CC9070")]
		private static bool GetTimeZoneName(ref __DTString str)
		{
			return default(bool);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x4CC9680", Offset = "0x4CC8280", VA = "0x184CC9680")]
		internal static bool IsDigit(char ch)
		{
			return default(bool);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x4CCDB20", Offset = "0x4CCC720", VA = "0x184CCDB20")]
		private static bool ParseFraction(ref __DTString str, out double result)
		{
			return default(bool);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x4CCE7C0", Offset = "0x4CCD3C0", VA = "0x184CCE7C0")]
		private static bool ParseTimeZone(ref __DTString str, ref System.TimeSpan result)
		{
			return default(bool);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x4CC94A0", Offset = "0x4CC80A0", VA = "0x184CC94A0")]
		private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x4CC9690", Offset = "0x4CC8290", VA = "0x184CC9690")]
		private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles styles)
		{
			return default(bool);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x4CC8BA0", Offset = "0x4CC77A0", VA = "0x184CC8BA0")]
		private static System.Globalization.Calendar GetJapaneseCalendarDefaultInstance()
		{
			return null;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x4CC8E20", Offset = "0x4CC7A20", VA = "0x184CC8E20")]
		internal static System.Globalization.Calendar GetTaiwanCalendarDefaultInstance()
		{
			return null;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x4CD1320", Offset = "0x4CCFF20", VA = "0x184CD1320")]
		private static bool VerifyValidPunctuation(ref __DTString str)
		{
			return default(bool);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x4CC9120", Offset = "0x4CC7D20", VA = "0x184CC9120")]
		private static bool GetYearMonthDayOrder(string datePattern, System.Globalization.DateTimeFormatInfo dtfi, out int order)
		{
			return default(bool);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x4CC9350", Offset = "0x4CC7F50", VA = "0x184CC9350")]
		private static bool GetYearMonthOrder(string pattern, System.Globalization.DateTimeFormatInfo dtfi, out int order)
		{
			return default(bool);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x4CC8C90", Offset = "0x4CC7890", VA = "0x184CC8C90")]
		private static bool GetMonthDayOrder(string pattern, System.Globalization.DateTimeFormatInfo dtfi, out int order)
		{
			return default(bool);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x4CCFBB0", Offset = "0x4CCE7B0", VA = "0x184CCFBB0")]
		private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear)
		{
			return default(bool);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x4CCFB10", Offset = "0x4CCE710", VA = "0x184CCFB10")]
		private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day)
		{
			return default(bool);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x4CCFA10", Offset = "0x4CCE610", VA = "0x184CCFA10")]
		private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year)
		{
			return default(bool);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4CCF990", Offset = "0x4CCE590", VA = "0x184CCF990")]
		private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year)
		{
			return default(bool);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x4CCFA90", Offset = "0x4CCE690", VA = "0x184CCFA90")]
		private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month)
		{
			return default(bool);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x4CC8970", Offset = "0x4CC7570", VA = "0x184CC8970")]
		private static void GetDefaultYear(ref DateTimeResult result, ref System.Globalization.DateTimeStyles styles)
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x4CC8410", Offset = "0x4CC7010", VA = "0x184CC8410")]
		private static bool GetDayOfNN(ref DateTimeResult result, ref System.Globalization.DateTimeStyles styles, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x4CC7F50", Offset = "0x4CC6B50", VA = "0x184CC7F50")]
		private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x4CC7AF0", Offset = "0x4CC66F0", VA = "0x184CC7AF0")]
		private static bool GetDayOfMN(ref DateTimeResult result, ref System.Globalization.DateTimeStyles styles, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4CC8A20", Offset = "0x4CC7620", VA = "0x184CC8A20")]
		private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x4CC7D20", Offset = "0x4CC6920", VA = "0x184CC7D20")]
		private static bool GetDayOfNM(ref DateTimeResult result, ref System.Globalization.DateTimeStyles styles, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x4CC7750", Offset = "0x4CC6350", VA = "0x184CC7750")]
		private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x4CC8740", Offset = "0x4CC7340", VA = "0x184CC8740")]
		private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x4CC8290", Offset = "0x4CC6E90", VA = "0x184CC8290")]
		private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x4CC8590", Offset = "0x4CC7190", VA = "0x184CC8590")]
		private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			return default(bool);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x4CC88A0", Offset = "0x4CC74A0", VA = "0x184CC88A0")]
		private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			return default(bool);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x4CC8670", Offset = "0x4CC7270", VA = "0x184CC8670")]
		private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			return default(bool);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x4CC5540", Offset = "0x4CC4140", VA = "0x184CC5540")]
		private static void AdjustTimeMark(System.Globalization.DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x4CC5500", Offset = "0x4CC4100", VA = "0x184CC5500")]
		private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark)
		{
			return default(bool);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x4CC9000", Offset = "0x4CC7C00", VA = "0x184CC9000")]
		private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			return default(bool);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x4CC8F90", Offset = "0x4CC7B90", VA = "0x184CC8F90")]
		private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			return default(bool);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x4CC8F10", Offset = "0x4CC7B10", VA = "0x184CC8F10")]
		private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			return default(bool);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x4CC7090", Offset = "0x4CC5C90", VA = "0x184CC7090")]
		private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			return default(bool);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x4CC7100", Offset = "0x4CC5D00", VA = "0x184CC7100")]
		private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw)
		{
			return default(bool);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000078F0 File Offset: 0x00005AF0
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x4CC71C0", Offset = "0x4CC5DC0", VA = "0x184CC71C0")]
		private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x4CCEE60", Offset = "0x4CCDA60", VA = "0x184CCEE60")]
		private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok)
		{
			return default(bool);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x4CCEF20", Offset = "0x4CCDB20", VA = "0x184CCEF20")]
		internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref System.Globalization.DateTimeStyles styles, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x4CCF420", Offset = "0x4CCE020", VA = "0x184CCF420")]
		internal static bool ProcessTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref System.Globalization.DateTimeStyles styles, ref DateTimeRawInfo raw, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x4CCED30", Offset = "0x4CCD930", VA = "0x184CCED30")]
		internal static System.DateTime Parse(System.ReadOnlySpan<char> s, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles styles)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x4CCEBE0", Offset = "0x4CCD7E0", VA = "0x184CCEBE0")]
		internal static System.DateTime Parse(System.ReadOnlySpan<char> s, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles styles, out System.TimeSpan offset)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00007980 File Offset: 0x00005B80
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x4CD0730", Offset = "0x4CCF330", VA = "0x184CD0730")]
		internal static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles styles, out System.DateTime result)
		{
			return default(bool);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x4CD0590", Offset = "0x4CCF190", VA = "0x184CD0590")]
		internal static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles styles, out System.DateTime result, out System.TimeSpan offset)
		{
			return default(bool);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x4CD0870", Offset = "0x4CCF470", VA = "0x184CD0870")]
		internal static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.DateTimeFormatInfo dtfi, System.Globalization.DateTimeStyles styles, ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x4CC5EE0", Offset = "0x4CC4AE0", VA = "0x184CC5EE0")]
		private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, System.Globalization.DateTimeStyles styles, bool bTimeOnly)
		{
			return default(bool);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x4CC5C90", Offset = "0x4CC4890", VA = "0x184CC5C90")]
		private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, System.Globalization.DateTimeStyles styles)
		{
			return default(bool);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x4CC58B0", Offset = "0x4CC44B0", VA = "0x184CC58B0")]
		private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x4CC5600", Offset = "0x4CC4200", VA = "0x184CC5600")]
		private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly)
		{
			return default(bool);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x4CCDC10", Offset = "0x4CCC810", VA = "0x184CCDC10")]
		private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, System.Globalization.DateTimeStyles styles, ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x4CCAFF0", Offset = "0x4CC9BF0", VA = "0x184CCAFF0")]
		internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number)
		{
			return default(bool);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x4CCD3B0", Offset = "0x4CCBFB0", VA = "0x184CCD3B0")]
		internal static bool ParseDigits(ref __DTString str, int digitLen, out int result)
		{
			return default(bool);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x4CCD2B0", Offset = "0x4CCBEB0", VA = "0x184CCD2B0")]
		internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result)
		{
			return default(bool);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x4CCD980", Offset = "0x4CCC580", VA = "0x184CCD980")]
		private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result)
		{
			return default(bool);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x4CCE3C0", Offset = "0x4CCCFC0", VA = "0x184CCE3C0")]
		private static bool ParseSign(ref __DTString str, ref bool result)
		{
			return default(bool);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4CCE480", Offset = "0x4CCD080", VA = "0x184CCE480")]
		private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref System.TimeSpan result)
		{
			return default(bool);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x4CCA8F0", Offset = "0x4CC94F0", VA = "0x184CCA8F0")]
		private static bool MatchAbbreviatedMonthName(ref __DTString str, System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			return default(bool);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x4CCB170", Offset = "0x4CC9D70", VA = "0x184CCB170")]
		private static bool MatchMonthName(ref __DTString str, System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			return default(bool);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00007B00 File Offset: 0x00005D00
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x4CCA790", Offset = "0x4CC9390", VA = "0x184CCA790")]
		private static bool MatchAbbreviatedDayName(ref __DTString str, System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			return default(bool);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x4CCACE0", Offset = "0x4CC98E0", VA = "0x184CCACE0")]
		private static bool MatchDayName(ref __DTString str, System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			return default(bool);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00007B30 File Offset: 0x00005D30
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x4CCAE40", Offset = "0x4CC9A40", VA = "0x184CCAE40")]
		private static bool MatchEraName(ref __DTString str, System.Globalization.DateTimeFormatInfo dtfi, ref int result)
		{
			return default(bool);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00007B48 File Offset: 0x00005D48
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x4CCB4D0", Offset = "0x4CCA0D0", VA = "0x184CCB4D0")]
		private static bool MatchTimeMark(ref __DTString str, System.Globalization.DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			return default(bool);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x4CCAB80", Offset = "0x4CC9780", VA = "0x184CCAB80")]
		private static bool MatchAbbreviatedTimeMark(ref __DTString str, System.Globalization.DateTimeFormatInfo dtfi, ref DateTimeParse.TM result)
		{
			return default(bool);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x4CC5BF0", Offset = "0x4CC47F0", VA = "0x184CC5BF0")]
		private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x4CC7420", Offset = "0x4CC6020", VA = "0x184CC7420")]
		private static System.DateTime GetDateTimeNow(ref DateTimeResult result, ref System.Globalization.DateTimeStyles styles)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x4CC59C0", Offset = "0x4CC45C0", VA = "0x184CC59C0")]
		private static bool CheckDefaultDateTime(ref DateTimeResult result, ref System.Globalization.Calendar cal, System.Globalization.DateTimeStyles styles)
		{
			return default(bool);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x4CC6C90", Offset = "0x4CC5890", VA = "0x184CC6C90")]
		private static string ExpandPredefinedFormat(System.ReadOnlySpan<char> format, ref System.Globalization.DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result)
		{
			return null;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x4CCE2B0", Offset = "0x4CCCEB0", VA = "0x184CCE2B0")]
		[MethodImpl(256)]
		private static bool ParseJapaneseEraStart(ref __DTString str, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return default(bool);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x4CCB840", Offset = "0x4CCA440", VA = "0x184CCB840")]
		private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, System.Globalization.DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x4CD0490", Offset = "0x4CCF090", VA = "0x184CD0490")]
		internal static bool TryParseQuoteString(System.ReadOnlySpan<char> format, int pos, System.Text.StringBuilder result, out int returnValue)
		{
			return default(bool);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x4CC6140", Offset = "0x4CC4D40", VA = "0x184CC6140")]
		private static bool DoStrictParse(System.ReadOnlySpan<char> s, System.ReadOnlySpan<char> formatParam, System.Globalization.DateTimeStyles styles, System.Globalization.DateTimeFormatInfo dtfi, ref DateTimeResult result)
		{
			return default(bool);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x4CC7540", Offset = "0x4CC6140", VA = "0x184CC7540")]
		private static System.Exception GetDateTimeParseException(ref DateTimeResult result)
		{
			return null;
		}

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x0")]
		internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x8")]
		private static DateTimeParse.DS[][] dateParsingStates;

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x0600078C RID: 1932
		[Token(Token = "0x20000D9")]
		internal delegate bool MatchNumberDelegate(ref __DTString str, int digitLen, out int result);

		// Token: 0x020000DA RID: 218
		[Token(Token = "0x20000DA")]
		internal enum DTT
		{
			// Token: 0x04000348 RID: 840
			[Token(Token = "0x4000348")]
			End,
			// Token: 0x04000349 RID: 841
			[Token(Token = "0x4000349")]
			NumEnd,
			// Token: 0x0400034A RID: 842
			[Token(Token = "0x400034A")]
			NumAmpm,
			// Token: 0x0400034B RID: 843
			[Token(Token = "0x400034B")]
			NumSpace,
			// Token: 0x0400034C RID: 844
			[Token(Token = "0x400034C")]
			NumDatesep,
			// Token: 0x0400034D RID: 845
			[Token(Token = "0x400034D")]
			NumTimesep,
			// Token: 0x0400034E RID: 846
			[Token(Token = "0x400034E")]
			MonthEnd,
			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			MonthSpace,
			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			MonthDatesep,
			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			NumDatesuff,
			// Token: 0x04000352 RID: 850
			[Token(Token = "0x4000352")]
			NumTimesuff,
			// Token: 0x04000353 RID: 851
			[Token(Token = "0x4000353")]
			DayOfWeek,
			// Token: 0x04000354 RID: 852
			[Token(Token = "0x4000354")]
			YearSpace,
			// Token: 0x04000355 RID: 853
			[Token(Token = "0x4000355")]
			YearDateSep,
			// Token: 0x04000356 RID: 854
			[Token(Token = "0x4000356")]
			YearEnd,
			// Token: 0x04000357 RID: 855
			[Token(Token = "0x4000357")]
			TimeZone,
			// Token: 0x04000358 RID: 856
			[Token(Token = "0x4000358")]
			Era,
			// Token: 0x04000359 RID: 857
			[Token(Token = "0x4000359")]
			NumUTCTimeMark,
			// Token: 0x0400035A RID: 858
			[Token(Token = "0x400035A")]
			Unk,
			// Token: 0x0400035B RID: 859
			[Token(Token = "0x400035B")]
			NumLocalTimeMark,
			// Token: 0x0400035C RID: 860
			[Token(Token = "0x400035C")]
			Max
		}

		// Token: 0x020000DB RID: 219
		[Token(Token = "0x20000DB")]
		internal enum TM
		{
			// Token: 0x0400035E RID: 862
			[Token(Token = "0x400035E")]
			NotSet = -1,
			// Token: 0x0400035F RID: 863
			[Token(Token = "0x400035F")]
			AM,
			// Token: 0x04000360 RID: 864
			[Token(Token = "0x4000360")]
			PM
		}

		// Token: 0x020000DC RID: 220
		[Token(Token = "0x20000DC")]
		internal enum DS
		{
			// Token: 0x04000362 RID: 866
			[Token(Token = "0x4000362")]
			BEGIN,
			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			N,
			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			NN,
			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			D_Nd,
			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			D_NN,
			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			D_NNd,
			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			D_M,
			// Token: 0x04000369 RID: 873
			[Token(Token = "0x4000369")]
			D_MN,
			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			D_NM,
			// Token: 0x0400036B RID: 875
			[Token(Token = "0x400036B")]
			D_MNd,
			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			D_NDS,
			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			D_Y,
			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			D_YN,
			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			D_YNd,
			// Token: 0x04000370 RID: 880
			[Token(Token = "0x4000370")]
			D_YM,
			// Token: 0x04000371 RID: 881
			[Token(Token = "0x4000371")]
			D_YMd,
			// Token: 0x04000372 RID: 882
			[Token(Token = "0x4000372")]
			D_S,
			// Token: 0x04000373 RID: 883
			[Token(Token = "0x4000373")]
			T_S,
			// Token: 0x04000374 RID: 884
			[Token(Token = "0x4000374")]
			T_Nt,
			// Token: 0x04000375 RID: 885
			[Token(Token = "0x4000375")]
			T_NNt,
			// Token: 0x04000376 RID: 886
			[Token(Token = "0x4000376")]
			ERROR,
			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			DX_NN,
			// Token: 0x04000378 RID: 888
			[Token(Token = "0x4000378")]
			DX_NNN,
			// Token: 0x04000379 RID: 889
			[Token(Token = "0x4000379")]
			DX_MN,
			// Token: 0x0400037A RID: 890
			[Token(Token = "0x400037A")]
			DX_NM,
			// Token: 0x0400037B RID: 891
			[Token(Token = "0x400037B")]
			DX_MNN,
			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			DX_DS,
			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			DX_DSN,
			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			DX_NDS,
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			DX_NNDS,
			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			DX_YNN,
			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			DX_YMN,
			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000382")]
			DX_YN,
			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			DX_YM,
			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			TX_N,
			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			TX_NN,
			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			TX_NNN,
			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			TX_TS,
			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			DX_NNY
		}
	}
}
