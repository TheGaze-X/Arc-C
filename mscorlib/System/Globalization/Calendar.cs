using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x200057E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public abstract class Calendar : System.ICloneable
	{
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x00016C80 File Offset: 0x00014E80
		[Token(Token = "0x17000621")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual System.DateTime MinSupportedDateTime
		{
			[Token(Token = "0x6002953")]
			[Address(RVA = "0x4C2D3B0", Offset = "0x4C2BFB0", VA = "0x184C2D3B0", Slot = "5")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x00016C98 File Offset: 0x00014E98
		[Token(Token = "0x17000622")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual System.DateTime MaxSupportedDateTime
		{
			[Token(Token = "0x6002954")]
			[Address(RVA = "0x4C2D360", Offset = "0x4C2BF60", VA = "0x184C2D360", Slot = "6")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x4C2D090", Offset = "0x4C2BC90", VA = "0x184C2D090")]
		protected Calendar()
		{
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x00016CB0 File Offset: 0x00014EB0
		[Token(Token = "0x17000623")]
		internal virtual int ID
		{
			[Token(Token = "0x6002956")]
			[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x00016CC8 File Offset: 0x00014EC8
		[Token(Token = "0x17000624")]
		internal virtual int BaseCalendarID
		{
			[Token(Token = "0x6002957")]
			[Address(RVA = "0x4C2D0B0", Offset = "0x4C2BCB0", VA = "0x184C2D0B0", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[Token(Token = "0x17000625")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public bool IsReadOnly
		{
			[Token(Token = "0x6002958")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x4C2C680", Offset = "0x4C2B280", VA = "0x184C2C680", Slot = "9")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600295A")]
		[Address(RVA = "0x4C2CA80", Offset = "0x4C2B680", VA = "0x184C2CA80")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public static Calendar ReadOnly(Calendar calendar)
		{
			return null;
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295B")]
		[Address(RVA = "0x4C2D010", Offset = "0x4C2BC10", VA = "0x184C2D010")]
		internal void VerifyWritable()
		{
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
		internal void SetReadOnlyState(bool readOnly)
		{
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x00016CF8 File Offset: 0x00014EF8
		[Token(Token = "0x17000626")]
		internal virtual int CurrentEraValue
		{
			[Token(Token = "0x600295D")]
			[Address(RVA = "0x4C2D0F0", Offset = "0x4C2BCF0", VA = "0x184C2D0F0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600295E RID: 10590
		[Token(Token = "0x600295E")]
		public abstract int GetDayOfMonth(System.DateTime time);

		// Token: 0x0600295F RID: 10591
		[Token(Token = "0x600295F")]
		public abstract System.DayOfWeek GetDayOfWeek(System.DateTime time);

		// Token: 0x06002960 RID: 10592
		[Token(Token = "0x6002960")]
		public abstract int GetDaysInMonth(int year, int month, int era);

		// Token: 0x06002961 RID: 10593
		[Token(Token = "0x6002961")]
		public abstract int GetDaysInYear(int year, int era);

		// Token: 0x06002962 RID: 10594
		[Token(Token = "0x6002962")]
		public abstract int GetEra(System.DateTime time);

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002963 RID: 10595
		[Token(Token = "0x17000627")]
		public abstract int[] Eras { [Token(Token = "0x6002963")] get; }

		// Token: 0x06002964 RID: 10596
		[Token(Token = "0x6002964")]
		public abstract int GetMonth(System.DateTime time);

		// Token: 0x06002965 RID: 10597
		[Token(Token = "0x6002965")]
		public abstract int GetMonthsInYear(int year, int era);

		// Token: 0x06002966 RID: 10598
		[Token(Token = "0x6002966")]
		public abstract int GetYear(System.DateTime time);

		// Token: 0x06002967 RID: 10599 RVA: 0x00016D10 File Offset: 0x00014F10
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x4C2C800", Offset = "0x4C2B400", VA = "0x184C2C800", Slot = "20")]
		public virtual bool IsLeapYear(int year)
		{
			return default(bool);
		}

		// Token: 0x06002968 RID: 10600
		[Token(Token = "0x6002968")]
		public abstract bool IsLeapYear(int year, int era);

		// Token: 0x06002969 RID: 10601 RVA: 0x00016D28 File Offset: 0x00014F28
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x4C2CD80", Offset = "0x4C2B980", VA = "0x184C2CD80", Slot = "22")]
		public virtual System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600296A RID: 10602
		[Token(Token = "0x600296A")]
		public abstract System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

		// Token: 0x0600296B RID: 10603 RVA: 0x00016D40 File Offset: 0x00014F40
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x4C2CF20", Offset = "0x4C2BB20", VA = "0x184C2CF20", Slot = "24")]
		internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out System.DateTime result)
		{
			return default(bool);
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00016D58 File Offset: 0x00014F58
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x4C2C990", Offset = "0x4C2B590", VA = "0x184C2C990", Slot = "25")]
		internal virtual bool IsValidYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00016D70 File Offset: 0x00014F70
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x4C2C900", Offset = "0x4C2B500", VA = "0x184C2C900", Slot = "26")]
		internal virtual bool IsValidMonth(int year, int month, int era)
		{
			return default(bool);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00016D88 File Offset: 0x00014F88
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x4C2C850", Offset = "0x4C2B450", VA = "0x184C2C850", Slot = "27")]
		internal virtual bool IsValidDay(int year, int month, int day, int era)
		{
			return default(bool);
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x00016DA0 File Offset: 0x00014FA0
		// (set) Token: 0x06002970 RID: 10608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000628")]
		public virtual int TwoDigitYearMax
		{
			[Token(Token = "0x600296F")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002970")]
			[Address(RVA = "0x4C2D400", Offset = "0x4C2C000", VA = "0x184C2D400", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00016DB8 File Offset: 0x00014FB8
		[Token(Token = "0x6002971")]
		[Address(RVA = "0x4C2CDE0", Offset = "0x4C2B9E0", VA = "0x184C2CDE0", Slot = "30")]
		public virtual int ToFourDigitYear(int year)
		{
			return 0;
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00016DD0 File Offset: 0x00014FD0
		[Token(Token = "0x6002972")]
		[Address(RVA = "0x4C2CBA0", Offset = "0x4C2B7A0", VA = "0x184C2CBA0")]
		internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			return 0L;
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00016DE8 File Offset: 0x00014FE8
		[Token(Token = "0x6002973")]
		[Address(RVA = "0x4C2C7B0", Offset = "0x4C2B3B0", VA = "0x184C2C7B0")]
		internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			return 0;
		}

		// Token: 0x040017ED RID: 6125
		[Token(Token = "0x40017ED")]
		internal const long TicksPerMillisecond = 10000L;

		// Token: 0x040017EE RID: 6126
		[Token(Token = "0x40017EE")]
		internal const long TicksPerSecond = 10000000L;

		// Token: 0x040017EF RID: 6127
		[Token(Token = "0x40017EF")]
		internal const long TicksPerMinute = 600000000L;

		// Token: 0x040017F0 RID: 6128
		[Token(Token = "0x40017F0")]
		internal const long TicksPerHour = 36000000000L;

		// Token: 0x040017F1 RID: 6129
		[Token(Token = "0x40017F1")]
		internal const long TicksPerDay = 864000000000L;

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		internal const int MillisPerSecond = 1000;

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		internal const int MillisPerMinute = 60000;

		// Token: 0x040017F4 RID: 6132
		[Token(Token = "0x40017F4")]
		internal const int MillisPerHour = 3600000;

		// Token: 0x040017F5 RID: 6133
		[Token(Token = "0x40017F5")]
		internal const int MillisPerDay = 86400000;

		// Token: 0x040017F6 RID: 6134
		[Token(Token = "0x40017F6")]
		internal const int DaysPerYear = 365;

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		internal const int DaysPer4Years = 1461;

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		internal const int DaysPer100Years = 36524;

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		internal const int DaysPer400Years = 146097;

		// Token: 0x040017FA RID: 6138
		[Token(Token = "0x40017FA")]
		internal const int DaysTo10000 = 3652059;

		// Token: 0x040017FB RID: 6139
		[Token(Token = "0x40017FB")]
		internal const long MaxMillis = 315537897600000L;

		// Token: 0x040017FC RID: 6140
		[Token(Token = "0x40017FC")]
		internal const int CAL_GREGORIAN = 1;

		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		internal const int CAL_GREGORIAN_US = 2;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		internal const int CAL_JAPAN = 3;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		internal const int CAL_TAIWAN = 4;

		// Token: 0x04001800 RID: 6144
		[Token(Token = "0x4001800")]
		internal const int CAL_KOREA = 5;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		internal const int CAL_HIJRI = 6;

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		internal const int CAL_THAI = 7;

		// Token: 0x04001803 RID: 6147
		[Token(Token = "0x4001803")]
		internal const int CAL_HEBREW = 8;

		// Token: 0x04001804 RID: 6148
		[Token(Token = "0x4001804")]
		internal const int CAL_GREGORIAN_ME_FRENCH = 9;

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		internal const int CAL_GREGORIAN_ARABIC = 10;

		// Token: 0x04001806 RID: 6150
		[Token(Token = "0x4001806")]
		internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;

		// Token: 0x04001807 RID: 6151
		[Token(Token = "0x4001807")]
		internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;

		// Token: 0x04001808 RID: 6152
		[Token(Token = "0x4001808")]
		internal const int CAL_JULIAN = 13;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		internal const int CAL_JAPANESELUNISOLAR = 14;

		// Token: 0x0400180A RID: 6154
		[Token(Token = "0x400180A")]
		internal const int CAL_CHINESELUNISOLAR = 15;

		// Token: 0x0400180B RID: 6155
		[Token(Token = "0x400180B")]
		internal const int CAL_SAKA = 16;

		// Token: 0x0400180C RID: 6156
		[Token(Token = "0x400180C")]
		internal const int CAL_LUNAR_ETO_CHN = 17;

		// Token: 0x0400180D RID: 6157
		[Token(Token = "0x400180D")]
		internal const int CAL_LUNAR_ETO_KOR = 18;

		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		internal const int CAL_LUNAR_ETO_ROKUYOU = 19;

		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		internal const int CAL_KOREANLUNISOLAR = 20;

		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		internal const int CAL_TAIWANLUNISOLAR = 21;

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		internal const int CAL_PERSIAN = 22;

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		internal const int CAL_UMALQURA = 23;

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int m_currentEraValue;

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		public const int CurrentEra = 0;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int twoDigitYearMax;
	}
}
