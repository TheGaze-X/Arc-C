using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x200058E")]
	[StructLayout(0)]
	internal class CultureData
	{
		// Token: 0x06002A8A RID: 10890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x4C2E750", Offset = "0x4C2D350", VA = "0x184C2E750")]
		private CultureData(string name)
		{
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700066E")]
		public static CultureData Invariant
		{
			[Token(Token = "0x6002A8B")]
			[Address(RVA = "0x4C2EA20", Offset = "0x4C2D620", VA = "0x184C2EA20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x4C2DB00", Offset = "0x4C2C700", VA = "0x184C2DB00")]
		public static CultureData GetCultureData(string cultureName, bool useUserOverride)
		{
			return null;
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x4C2D9E0", Offset = "0x4C2C5E0", VA = "0x184C2D9E0")]
		public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
		{
			return null;
		}

		// Token: 0x06002A8E RID: 10894
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x4C2E830", Offset = "0x4C2D430", VA = "0x184C2E830")]
		[MethodImpl(4096)]
		private extern void fill_culture_data(int datetimeIndex);

		// Token: 0x06002A8F RID: 10895 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x4C2D8A0", Offset = "0x4C2C4A0", VA = "0x184C2D8A0")]
		public CalendarData GetCalendar(int calendarId)
		{
			return null;
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700066F")]
		internal string[] LongTimes
		{
			[Token(Token = "0x6002A90")]
			[Address(RVA = "0x43FBA90", Offset = "0x43FA690", VA = "0x1843FBA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000670")]
		internal string[] ShortTimes
		{
			[Token(Token = "0x6002A91")]
			[Address(RVA = "0x4C2EF70", Offset = "0x4C2DB70", VA = "0x184C2EF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000671")]
		internal string SISO639LANGNAME
		{
			[Token(Token = "0x6002A92")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x00017C40 File Offset: 0x00015E40
		[Token(Token = "0x17000672")]
		internal int IFIRSTDAYOFWEEK
		{
			[Token(Token = "0x6002A93")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x00017C58 File Offset: 0x00015E58
		[Token(Token = "0x17000673")]
		internal int IFIRSTWEEKOFYEAR
		{
			[Token(Token = "0x6002A94")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000674")]
		internal string SAM1159
		{
			[Token(Token = "0x6002A95")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000675")]
		internal string SPM2359
		{
			[Token(Token = "0x6002A96")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000676")]
		internal string TimeSeparator
		{
			[Token(Token = "0x6002A97")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000677")]
		internal int[] CalendarIds
		{
			[Token(Token = "0x6002A98")]
			[Address(RVA = "0x4C2E850", Offset = "0x4C2D450", VA = "0x184C2E850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A99")]
		[Address(RVA = "0x4C2D610", Offset = "0x4C2C210", VA = "0x184C2D610")]
		internal CalendarId[] GetCalendarIds()
		{
			return null;
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x00017C70 File Offset: 0x00015E70
		[Token(Token = "0x17000678")]
		internal bool IsInvariantCulture
		{
			[Token(Token = "0x6002A9A")]
			[Address(RVA = "0x4C2EF30", Offset = "0x4C2DB30", VA = "0x184C2EF30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000679")]
		internal string CultureName
		{
			[Token(Token = "0x6002A9B")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700067A")]
		internal string SCOMPAREINFO
		{
			[Token(Token = "0x6002A9C")]
			[Address(RVA = "0x4C2EF40", Offset = "0x4C2DB40", VA = "0x184C2EF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700067B")]
		internal string STEXTINFO
		{
			[Token(Token = "0x6002A9D")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x00017C88 File Offset: 0x00015E88
		[Token(Token = "0x1700067C")]
		internal int IDEFAULTOEMCODEPAGE
		{
			[Token(Token = "0x6002A9E")]
			[Address(RVA = "0x4C2EA10", Offset = "0x4C2D610", VA = "0x184C2EA10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x00017CA0 File Offset: 0x00015EA0
		[Token(Token = "0x1700067D")]
		internal bool UseUserOverride
		{
			[Token(Token = "0x6002A9F")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x4C2D5D0", Offset = "0x4C2C1D0", VA = "0x184C2D5D0")]
		internal string[] EraNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x4C2D430", Offset = "0x4C2C030", VA = "0x184C2D430")]
		internal string[] AbbrevEraNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x4C2D470", Offset = "0x4C2C070", VA = "0x184C2D470")]
		internal string[] AbbreviatedEnglishEraNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x4C2E540", Offset = "0x4C2D140", VA = "0x184C2E540")]
		internal string[] ShortDates(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x4C2E4E0", Offset = "0x4C2D0E0", VA = "0x184C2E4E0")]
		internal string[] LongDates(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x4C2E730", Offset = "0x4C2D330", VA = "0x184C2E730")]
		internal string[] YearMonths(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x4C2D5B0", Offset = "0x4C2C1B0", VA = "0x184C2D5B0")]
		internal string[] DayNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x4C2D450", Offset = "0x4C2C050", VA = "0x184C2D450")]
		internal string[] AbbreviatedDayNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x4C2E520", Offset = "0x4C2D120", VA = "0x184C2E520")]
		internal string[] MonthNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x4C2D5F0", Offset = "0x4C2C1F0", VA = "0x184C2D5F0")]
		internal string[] GenitiveMonthNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x4C2D4C0", Offset = "0x4C2C0C0", VA = "0x184C2D4C0")]
		internal string[] AbbreviatedMonthNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x4C2D490", Offset = "0x4C2C090", VA = "0x184C2D490")]
		internal string[] AbbreviatedGenitiveMonthNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x4C2E4B0", Offset = "0x4C2D0B0", VA = "0x184C2E4B0")]
		internal string[] LeapYearMonthNames(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x4C2E500", Offset = "0x4C2D100", VA = "0x184C2E500")]
		internal string MonthDay(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x4C2D4E0", Offset = "0x4C2C0E0", VA = "0x184C2D4E0")]
		internal string DateSeparator(int calendarId)
		{
			return null;
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AAF")]
		[Address(RVA = "0x4C2DB80", Offset = "0x4C2C780", VA = "0x184C2DB80")]
		private static string GetDateSeparator(string format)
		{
			return null;
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AB0")]
		[Address(RVA = "0x4C2E1C0", Offset = "0x4C2CDC0", VA = "0x184C2E1C0")]
		private static string GetSeparator(string format, string timeParts)
		{
			return null;
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x00017CB8 File Offset: 0x00015EB8
		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0x4C2E3C0", Offset = "0x4C2CFC0", VA = "0x184C2E3C0")]
		private static int IndexOfTimePart(string format, int startIndex, string timeParts)
		{
			return 0;
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x4C2E560", Offset = "0x4C2D160", VA = "0x184C2E560")]
		private static string UnescapeNlsString(string str, int start, int end)
		{
			return null;
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		internal static string[] ReescapeWin32Strings(string[] array)
		{
			return null;
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		internal static string ReescapeWin32String(string str)
		{
			return null;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00017CD0 File Offset: 0x00015ED0
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x4C2EFF0", Offset = "0x4C2DBF0", VA = "0x184C2EFF0")]
		private unsafe static int strlen(byte* s)
		{
			return 0;
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x4C2EF90", Offset = "0x4C2DB90", VA = "0x184C2EF90")]
		private unsafe static string idx2string(byte* data, int idx)
		{
			return null;
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0x4C2E780", Offset = "0x4C2D380", VA = "0x184C2E780")]
		private int[] create_group_sizes_array(int gs0, int gs1)
		{
			return null;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0x4C2DBC0", Offset = "0x4C2C7C0", VA = "0x184C2DBC0")]
		internal void GetNFIValues(NumberFormatInfo nfi)
		{
		}

		// Token: 0x06002AB9 RID: 10937
		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0x4C2E840", Offset = "0x4C2D440", VA = "0x184C2E840")]
		[MethodImpl(4096)]
		private unsafe static extern byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe);

		// Token: 0x04001891 RID: 6289
		[Token(Token = "0x4001891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string sAM1159;

		// Token: 0x04001892 RID: 6290
		[Token(Token = "0x4001892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string sPM2359;

		// Token: 0x04001893 RID: 6291
		[Token(Token = "0x4001893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string sTimeSeparator;

		// Token: 0x04001894 RID: 6292
		[Token(Token = "0x4001894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] saLongTimes;

		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] saShortTimes;

		// Token: 0x04001896 RID: 6294
		[Token(Token = "0x4001896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int iFirstDayOfWeek;

		// Token: 0x04001897 RID: 6295
		[Token(Token = "0x4001897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int iFirstWeekOfYear;

		// Token: 0x04001898 RID: 6296
		[Token(Token = "0x4001898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int[] waCalendars;

		// Token: 0x04001899 RID: 6297
		[Token(Token = "0x4001899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CalendarData[] calendars;

		// Token: 0x0400189A RID: 6298
		[Token(Token = "0x400189A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string sISO639Language;

		// Token: 0x0400189B RID: 6299
		[Token(Token = "0x400189B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string sRealName;

		// Token: 0x0400189C RID: 6300
		[Token(Token = "0x400189C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool bUseOverrides;

		// Token: 0x0400189D RID: 6301
		[Token(Token = "0x400189D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int calendarId;

		// Token: 0x0400189E RID: 6302
		[Token(Token = "0x400189E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int numberIndex;

		// Token: 0x0400189F RID: 6303
		[Token(Token = "0x400189F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int iDefaultAnsiCodePage;

		// Token: 0x040018A0 RID: 6304
		[Token(Token = "0x40018A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int iDefaultOemCodePage;

		// Token: 0x040018A1 RID: 6305
		[Token(Token = "0x40018A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int iDefaultMacCodePage;

		// Token: 0x040018A2 RID: 6306
		[Token(Token = "0x40018A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int iDefaultEbcdicCodePage;

		// Token: 0x040018A3 RID: 6307
		[Token(Token = "0x40018A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool isRightToLeft;

		// Token: 0x040018A4 RID: 6308
		[Token(Token = "0x40018A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string sListSeparator;

		// Token: 0x040018A5 RID: 6309
		[Token(Token = "0x40018A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CultureData s_Invariant;

		// Token: 0x0200058F RID: 1423
		[Token(Token = "0x200058F")]
		internal struct NumberFormatEntryManaged
		{
			// Token: 0x040018A6 RID: 6310
			[Token(Token = "0x40018A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int currency_decimal_digits;

			// Token: 0x040018A7 RID: 6311
			[Token(Token = "0x40018A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal int currency_decimal_separator;

			// Token: 0x040018A8 RID: 6312
			[Token(Token = "0x40018A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int currency_group_separator;

			// Token: 0x040018A9 RID: 6313
			[Token(Token = "0x40018A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int currency_group_sizes0;

			// Token: 0x040018AA RID: 6314
			[Token(Token = "0x40018AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int currency_group_sizes1;

			// Token: 0x040018AB RID: 6315
			[Token(Token = "0x40018AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int currency_negative_pattern;

			// Token: 0x040018AC RID: 6316
			[Token(Token = "0x40018AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int currency_positive_pattern;

			// Token: 0x040018AD RID: 6317
			[Token(Token = "0x40018AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int currency_symbol;

			// Token: 0x040018AE RID: 6318
			[Token(Token = "0x40018AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int nan_symbol;

			// Token: 0x040018AF RID: 6319
			[Token(Token = "0x40018AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int negative_infinity_symbol;

			// Token: 0x040018B0 RID: 6320
			[Token(Token = "0x40018B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int negative_sign;

			// Token: 0x040018B1 RID: 6321
			[Token(Token = "0x40018B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int number_decimal_digits;

			// Token: 0x040018B2 RID: 6322
			[Token(Token = "0x40018B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int number_decimal_separator;

			// Token: 0x040018B3 RID: 6323
			[Token(Token = "0x40018B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal int number_group_separator;

			// Token: 0x040018B4 RID: 6324
			[Token(Token = "0x40018B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal int number_group_sizes0;

			// Token: 0x040018B5 RID: 6325
			[Token(Token = "0x40018B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int number_group_sizes1;

			// Token: 0x040018B6 RID: 6326
			[Token(Token = "0x40018B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int number_negative_pattern;

			// Token: 0x040018B7 RID: 6327
			[Token(Token = "0x40018B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal int per_mille_symbol;

			// Token: 0x040018B8 RID: 6328
			[Token(Token = "0x40018B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal int percent_negative_pattern;

			// Token: 0x040018B9 RID: 6329
			[Token(Token = "0x40018B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal int percent_positive_pattern;

			// Token: 0x040018BA RID: 6330
			[Token(Token = "0x40018BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal int percent_symbol;

			// Token: 0x040018BB RID: 6331
			[Token(Token = "0x40018BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal int positive_infinity_symbol;

			// Token: 0x040018BC RID: 6332
			[Token(Token = "0x40018BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int positive_sign;
		}
	}
}
