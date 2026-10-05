using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	[StructLayout(0)]
	internal class CalendarData
	{
		// Token: 0x06002974 RID: 10612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002974")]
		[Address(RVA = "0x4C2C560", Offset = "0x4C2B160", VA = "0x184C2C560")]
		private CalendarData()
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x4C2BDE0", Offset = "0x4C2A9E0", VA = "0x184C2BDE0")]
		internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides)
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002977")]
		[Address(RVA = "0x4C29470", Offset = "0x4C28070", VA = "0x184C29470")]
		private void InitializeEraNames(string localeName, int calendarId)
		{
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002978")]
		[Address(RVA = "0x4C28D60", Offset = "0x4C27960", VA = "0x184C28D60")]
		private static string[] GetJapaneseEraNames()
		{
			return null;
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x4C28B40", Offset = "0x4C27740", VA = "0x184C28B40")]
		private static string[] GetJapaneseEnglishEraNames()
		{
			return null;
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x4C28F80", Offset = "0x4C27B80", VA = "0x184C28F80")]
		private void InitializeAbbreviatedEraNames(string localeName, int calendarId)
		{
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x4C28950", Offset = "0x4C27550", VA = "0x184C28950")]
		internal static CalendarData GetCalendarData(int calendarId)
		{
			return null;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x4C287C0", Offset = "0x4C273C0", VA = "0x184C287C0")]
		private static string CalendarIdToCultureName(int calendarId)
		{
			return null;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00016E00 File Offset: 0x00015000
		[Token(Token = "0x600297D")]
		[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360")]
		public static int nativeGetTwoDigitYearMax(int calID)
		{
			return 0;
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00016E18 File Offset: 0x00015018
		[Token(Token = "0x600297E")]
		[Address(RVA = "0x4C2C590", Offset = "0x4C2B190", VA = "0x184C2C590")]
		private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId)
		{
			return default(bool);
		}

		// Token: 0x0600297F RID: 10623
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x4C2C580", Offset = "0x4C2B180", VA = "0x184C2C580")]
		[MethodImpl(4096)]
		private extern bool fill_calendar_data(string localeName, int datetimeIndex);

		// Token: 0x04001817 RID: 6167
		[Token(Token = "0x4001817")]
		internal const int MAX_CALENDARS = 23;

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string sNativeName;

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string[] saShortDates;

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string[] saYearMonths;

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string[] saLongDates;

		// Token: 0x0400181C RID: 6172
		[Token(Token = "0x400181C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string sMonthDay;

		// Token: 0x0400181D RID: 6173
		[Token(Token = "0x400181D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal string[] saEraNames;

		// Token: 0x0400181E RID: 6174
		[Token(Token = "0x400181E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal string[] saAbbrevEraNames;

		// Token: 0x0400181F RID: 6175
		[Token(Token = "0x400181F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal string[] saAbbrevEnglishEraNames;

		// Token: 0x04001820 RID: 6176
		[Token(Token = "0x4001820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal string[] saDayNames;

		// Token: 0x04001821 RID: 6177
		[Token(Token = "0x4001821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal string[] saAbbrevDayNames;

		// Token: 0x04001822 RID: 6178
		[Token(Token = "0x4001822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal string[] saSuperShortDayNames;

		// Token: 0x04001823 RID: 6179
		[Token(Token = "0x4001823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal string[] saMonthNames;

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal string[] saAbbrevMonthNames;

		// Token: 0x04001825 RID: 6181
		[Token(Token = "0x4001825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal string[] saMonthGenitiveNames;

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal string[] saAbbrevMonthGenitiveNames;

		// Token: 0x04001827 RID: 6183
		[Token(Token = "0x4001827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal string[] saLeapYearMonthNames;

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal int iTwoDigitYearMax;

		// Token: 0x04001829 RID: 6185
		[Token(Token = "0x4001829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		internal int iCurrentEra;

		// Token: 0x0400182A RID: 6186
		[Token(Token = "0x400182A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal bool bUseUserOverrides;

		// Token: 0x0400182B RID: 6187
		[Token(Token = "0x400182B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static CalendarData Invariant;

		// Token: 0x0400182C RID: 6188
		[Token(Token = "0x400182C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string[] HEBREW_MONTH_NAMES;

		// Token: 0x0400182D RID: 6189
		[Token(Token = "0x400182D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string[] HEBREW_LEAP_MONTH_NAMES;
	}
}
