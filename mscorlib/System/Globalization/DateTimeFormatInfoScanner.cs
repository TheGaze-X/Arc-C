using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000564 RID: 1380
	[Token(Token = "0x2000564")]
	internal class DateTimeFormatInfoScanner
	{
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000612")]
		private static System.Collections.Generic.Dictionary<string, string> KnownWords
		{
			[Token(Token = "0x6002901")]
			[Address(RVA = "0x4C13A00", Offset = "0x4C12600", VA = "0x184C13A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000167E8 File Offset: 0x000149E8
		[Token(Token = "0x6002902")]
		[Address(RVA = "0x4C138A0", Offset = "0x4C124A0", VA = "0x184C138A0")]
		internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
		{
			return 0;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002903")]
		[Address(RVA = "0x4C127E0", Offset = "0x4C113E0", VA = "0x184C127E0")]
		internal void AddDateWordOrPostfix(string formatPostfix, string str)
		{
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00016800 File Offset: 0x00014A00
		[Token(Token = "0x6002904")]
		[Address(RVA = "0x4C12A10", Offset = "0x4C11610", VA = "0x184C12A10")]
		internal int AddDateWords(string pattern, int index, string formatPostfix)
		{
			return 0;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00016818 File Offset: 0x00014A18
		[Token(Token = "0x6002905")]
		[Address(RVA = "0x4C13830", Offset = "0x4C12430", VA = "0x184C13830")]
		internal static int ScanRepeatChar(string pattern, char ch, int index, out int count)
		{
			return 0;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002906")]
		[Address(RVA = "0x4C12C20", Offset = "0x4C11820", VA = "0x184C12C20")]
		internal void AddIgnorableSymbols(string text)
		{
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002907")]
		[Address(RVA = "0x4C135F0", Offset = "0x4C121F0", VA = "0x184C135F0")]
		internal void ScanDateWord(string pattern)
		{
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002908")]
		[Address(RVA = "0x4C13090", Offset = "0x4C11C90", VA = "0x184C13090")]
		internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
		{
			return null;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x00016830 File Offset: 0x00014A30
		[Token(Token = "0x6002909")]
		[Address(RVA = "0x4C133C0", Offset = "0x4C11FC0", VA = "0x184C133C0")]
		internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			return FORMATFLAGS.None;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00016848 File Offset: 0x00014A48
		[Token(Token = "0x600290A")]
		[Address(RVA = "0x4C13530", Offset = "0x4C12130", VA = "0x184C13530")]
		internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			return FORMATFLAGS.None;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00016860 File Offset: 0x00014A60
		[Token(Token = "0x600290B")]
		[Address(RVA = "0x4C134F0", Offset = "0x4C120F0", VA = "0x184C134F0")]
		internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames)
		{
			return FORMATFLAGS.None;
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00016878 File Offset: 0x00014A78
		[Token(Token = "0x600290C")]
		[Address(RVA = "0x4C134E0", Offset = "0x4C120E0", VA = "0x184C134E0")]
		internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
		{
			return FORMATFLAGS.None;
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00016890 File Offset: 0x00014A90
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x4C12FF0", Offset = "0x4C11BF0", VA = "0x184C12FF0")]
		private static bool EqualStringArrays(string[] array1, string[] array2)
		{
			return default(bool);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000168A8 File Offset: 0x00014AA8
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x4C12F30", Offset = "0x4C11B30", VA = "0x184C12F30")]
		private static bool ArrayElementsHaveSpace(string[] array)
		{
			return default(bool);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000168C0 File Offset: 0x00014AC0
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x4C12D20", Offset = "0x4C11920", VA = "0x184C12D20")]
		private static bool ArrayElementsBeginWithDigit(string[] array)
		{
			return default(bool);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002910")]
		[Address(RVA = "0x4C13970", Offset = "0x4C12570", VA = "0x184C13970")]
		public DateTimeFormatInfoScanner()
		{
		}

		// Token: 0x04001737 RID: 5943
		[Token(Token = "0x4001737")]
		[FieldOffset(Offset = "0x10")]
		internal System.Collections.Generic.List<string> m_dateWords;

		// Token: 0x04001738 RID: 5944
		[Token(Token = "0x4001738")]
		[FieldOffset(Offset = "0x0")]
		private static System.Collections.Generic.Dictionary<string, string> s_knownWords;

		// Token: 0x04001739 RID: 5945
		[Token(Token = "0x4001739")]
		[FieldOffset(Offset = "0x18")]
		private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags;

		// Token: 0x02000565 RID: 1381
		[Token(Token = "0x2000565")]
		private enum FoundDatePattern
		{
			// Token: 0x0400173B RID: 5947
			[Token(Token = "0x400173B")]
			None,
			// Token: 0x0400173C RID: 5948
			[Token(Token = "0x400173C")]
			FoundYearPatternFlag,
			// Token: 0x0400173D RID: 5949
			[Token(Token = "0x400173D")]
			FoundMonthPatternFlag,
			// Token: 0x0400173E RID: 5950
			[Token(Token = "0x400173E")]
			FoundDayPatternFlag = 4,
			// Token: 0x0400173F RID: 5951
			[Token(Token = "0x400173F")]
			FoundYMDPatternFlag = 7
		}
	}
}
