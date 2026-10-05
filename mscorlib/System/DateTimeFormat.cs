using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	internal static class DateTimeFormat
	{
		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x4CB7D70", Offset = "0x4CB6970", VA = "0x184CB7D70")]
		internal static void FormatDigits(System.Text.StringBuilder outputBuffer, int value, int len)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x4CB7DF0", Offset = "0x4CB69F0", VA = "0x184CB7DF0")]
		internal static void FormatDigits(System.Text.StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit)
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x4CB8A70", Offset = "0x4CB7670", VA = "0x184CB8A70")]
		private static void HebrewFormatDigits(System.Text.StringBuilder outputBuffer, int digits)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00007470 File Offset: 0x00005670
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x4CB8E70", Offset = "0x4CB7A70", VA = "0x184CB8E70")]
		internal static int ParseRepeatPattern(System.ReadOnlySpan<char> format, int pos, char patternChar)
		{
			return 0;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x4CB7D30", Offset = "0x4CB6930", VA = "0x184CB7D30")]
		private static string FormatDayOfWeek(int dayOfWeek, int repeat, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return null;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x4CB7FF0", Offset = "0x4CB6BF0", VA = "0x184CB7FF0")]
		private static string FormatMonth(int month, int repeatCount, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return null;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x4CB7EF0", Offset = "0x4CB6AF0", VA = "0x184CB7EF0")]
		private static string FormatHebrewMonthName(System.DateTime time, int month, int repeatCount, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return null;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x4CB8C80", Offset = "0x4CB7880", VA = "0x184CB8C80")]
		internal static int ParseQuoteString(System.ReadOnlySpan<char> format, int pos, System.Text.StringBuilder result)
		{
			return 0;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x4CB8C10", Offset = "0x4CB7810", VA = "0x184CB8C10")]
		internal static int ParseNextChar(System.ReadOnlySpan<char> format, int pos)
		{
			return 0;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x4CB8AE0", Offset = "0x4CB76E0", VA = "0x184CB8AE0")]
		private static bool IsUseGenitiveForm(System.ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch)
		{
			return default(bool);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x4CB6810", Offset = "0x4CB5410", VA = "0x184CB6810")]
		private static System.Text.StringBuilder FormatCustomized(System.DateTime dateTime, System.ReadOnlySpan<char> format, System.Globalization.DateTimeFormatInfo dtfi, System.TimeSpan offset, System.Text.StringBuilder result)
		{
			return null;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x4CB63A0", Offset = "0x4CB4FA0", VA = "0x184CB63A0")]
		private static void FormatCustomizedTimeZone(System.DateTime dateTime, System.TimeSpan offset, System.ReadOnlySpan<char> format, int tokenLen, bool timeOnly, System.Text.StringBuilder result)
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x4CB60A0", Offset = "0x4CB4CA0", VA = "0x184CB60A0")]
		private static void FormatCustomizedRoundripTimeZone(System.DateTime dateTime, System.TimeSpan offset, System.Text.StringBuilder result)
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x4CB5960", Offset = "0x4CB4560", VA = "0x184CB5960")]
		private static void Append2DigitNumber(System.Text.StringBuilder result, int val)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x4CB8730", Offset = "0x4CB7330", VA = "0x184CB8730")]
		internal static string GetRealFormat(System.ReadOnlySpan<char> format, System.Globalization.DateTimeFormatInfo dtfi)
		{
			return null;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x4CB59D0", Offset = "0x4CB45D0", VA = "0x184CB59D0")]
		private static string ExpandPredefinedFormat(System.ReadOnlySpan<char> format, ref System.DateTime dateTime, ref System.Globalization.DateTimeFormatInfo dtfi, ref System.TimeSpan offset)
		{
			return null;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x4CB83C0", Offset = "0x4CB6FC0", VA = "0x184CB83C0")]
		internal static string Format(System.DateTime dateTime, string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x4CB8450", Offset = "0x4CB7050", VA = "0x184CB8450")]
		internal static string Format(System.DateTime dateTime, string format, System.IFormatProvider provider, System.TimeSpan offset)
		{
			return null;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x4CB9B60", Offset = "0x4CB8760", VA = "0x184CB9B60")]
		internal static bool TryFormat(System.DateTime dateTime, System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format, System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x4CB9C20", Offset = "0x4CB8820", VA = "0x184CB9C20")]
		internal static bool TryFormat(System.DateTime dateTime, System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format, System.IFormatProvider provider, System.TimeSpan offset)
		{
			return default(bool);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x4CB8030", Offset = "0x4CB6C30", VA = "0x184CB8030")]
		private static System.Text.StringBuilder FormatStringBuilder(System.DateTime dateTime, System.ReadOnlySpan<char> format, System.Globalization.DateTimeFormatInfo dtfi, System.TimeSpan offset)
		{
			return null;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x4CB8EF0", Offset = "0x4CB7AF0", VA = "0x184CB8EF0")]
		private static bool TryFormatO(System.DateTime dateTime, System.TimeSpan offset, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x4CB96B0", Offset = "0x4CB82B0", VA = "0x184CB96B0")]
		private static bool TryFormatR(System.DateTime dateTime, System.TimeSpan offset, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x4CB9EE0", Offset = "0x4CB8AE0", VA = "0x184CB9EE0")]
		[MethodImpl(256)]
		private static void WriteTwoDecimalDigits(uint value, System.Span<char> destination, int offset)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x4CA3170", Offset = "0x4CA1D70", VA = "0x184CA3170")]
		[MethodImpl(256)]
		private static void WriteFourDecimalDigits(uint value, System.Span<char> buffer, int startingIndex = 0)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x4CB9E20", Offset = "0x4CB8A20", VA = "0x184CB9E20")]
		[MethodImpl(256)]
		private static void WriteDigits(ulong value, System.Span<char> buffer)
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal static void InvalidFormatForLocal(System.ReadOnlySpan<char> format, System.DateTime dateTime)
		{
		}

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly System.TimeSpan NullOffset;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x8")]
		internal static char[] allStandardFormats;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly System.Globalization.DateTimeFormatInfo InvariantFormatInfo;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly string[] InvariantAbbreviatedMonthNames;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly string[] InvariantAbbreviatedDayNames;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x28")]
		internal static string[] fixedNumberFormats;
	}
}
