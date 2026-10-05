using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	[System.Serializable]
	public class UmAlQuraCalendar : Calendar
	{
		// Token: 0x06002A5B RID: 10843 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x4C44830", Offset = "0x4C43430", VA = "0x184C44830")]
		private static UmAlQuraCalendar.DateMapping[] InitDateMapping()
		{
			return null;
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x00017A30 File Offset: 0x00015C30
		[Token(Token = "0x17000666")]
		public override System.DateTime MinSupportedDateTime
		{
			[Token(Token = "0x6002A5C")]
			[Address(RVA = "0x4C452A0", Offset = "0x4C43EA0", VA = "0x184C452A0", Slot = "5")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x00017A48 File Offset: 0x00015C48
		[Token(Token = "0x17000667")]
		public override System.DateTime MaxSupportedDateTime
		{
			[Token(Token = "0x6002A5D")]
			[Address(RVA = "0x4C45250", Offset = "0x4C43E50", VA = "0x184C45250", Slot = "6")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x4C2D090", Offset = "0x4C2BC90", VA = "0x184C2D090")]
		public UmAlQuraCalendar()
		{
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x00017A60 File Offset: 0x00015C60
		[Token(Token = "0x17000668")]
		internal override int BaseCalendarID
		{
			[Token(Token = "0x6002A5F")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x00017A78 File Offset: 0x00015C78
		[Token(Token = "0x17000669")]
		internal override int ID
		{
			[Token(Token = "0x6002A60")]
			[Address(RVA = "0x4C45240", Offset = "0x4C43E40", VA = "0x184C45240", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x4C43FE0", Offset = "0x4C42BE0", VA = "0x184C43FE0")]
		private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg)
		{
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00017A90 File Offset: 0x00015C90
		[Token(Token = "0x6002A62")]
		[Address(RVA = "0x4C44150", Offset = "0x4C42D50", VA = "0x184C44150")]
		private static long GetAbsoluteDateUmAlQura(int year, int month, int day)
		{
			return 0L;
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A63")]
		[Address(RVA = "0x4C43820", Offset = "0x4C42420", VA = "0x184C43820")]
		internal static void CheckTicksRange(long ticks)
		{
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A64")]
		[Address(RVA = "0x4C43790", Offset = "0x4C42390", VA = "0x184C43790")]
		internal static void CheckEraRange(int era)
		{
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A65")]
		[Address(RVA = "0x4C43B10", Offset = "0x4C42710", VA = "0x184C43B10")]
		internal static void CheckYearRange(int year, int era)
		{
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A66")]
		[Address(RVA = "0x4C43A30", Offset = "0x4C42630", VA = "0x184C43A30")]
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x4C43CE0", Offset = "0x4C428E0", VA = "0x184C43CE0")]
		private static void ConvertGregorianToHijri(System.DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay)
		{
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00017AA8 File Offset: 0x00015CA8
		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x4C44300", Offset = "0x4C42F00", VA = "0x184C44300", Slot = "31")]
		internal virtual int GetDatePart(System.DateTime time, int part)
		{
			return 0;
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00017AC0 File Offset: 0x00015CC0
		[Token(Token = "0x6002A69")]
		[Address(RVA = "0x4C444C0", Offset = "0x4C430C0", VA = "0x184C444C0", Slot = "11")]
		public override int GetDayOfMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00017AD8 File Offset: 0x00015CD8
		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x4C44510", Offset = "0x4C43110", VA = "0x184C44510", Slot = "12")]
		public override System.DayOfWeek GetDayOfWeek(System.DateTime time)
		{
			return System.DayOfWeek.Sunday;
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00017AF0 File Offset: 0x00015CF0
		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x4C44590", Offset = "0x4C43190", VA = "0x184C44590", Slot = "13")]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00017B08 File Offset: 0x00015D08
		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x4C44A20", Offset = "0x4C43620", VA = "0x184C44A20")]
		internal static int RealGetDaysInYear(int year)
		{
			return 0;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00017B20 File Offset: 0x00015D20
		[Token(Token = "0x6002A6D")]
		[Address(RVA = "0x4C44650", Offset = "0x4C43250", VA = "0x184C44650", Slot = "14")]
		public override int GetDaysInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00017B38 File Offset: 0x00015D38
		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0x4C446B0", Offset = "0x4C432B0", VA = "0x184C446B0", Slot = "15")]
		public override int GetEra(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700066A")]
		public override int[] Eras
		{
			[Token(Token = "0x6002A6F")]
			[Address(RVA = "0x4C451E0", Offset = "0x4C43DE0", VA = "0x184C451E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00017B50 File Offset: 0x00015D50
		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x4C44730", Offset = "0x4C43330", VA = "0x184C44730", Slot = "17")]
		public override int GetMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00017B68 File Offset: 0x00015D68
		[Token(Token = "0x6002A71")]
		[Address(RVA = "0x4C44780", Offset = "0x4C43380", VA = "0x184C44780", Slot = "18")]
		public override int GetMonthsInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00017B80 File Offset: 0x00015D80
		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x4C447E0", Offset = "0x4C433E0", VA = "0x184C447E0", Slot = "19")]
		public override int GetYear(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00017B98 File Offset: 0x00015D98
		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x4C449B0", Offset = "0x4C435B0", VA = "0x184C449B0", Slot = "21")]
		public override bool IsLeapYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00017BB0 File Offset: 0x00015DB0
		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x4C44AC0", Offset = "0x4C436C0", VA = "0x184C44AC0", Slot = "23")]
		public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return default(System.DateTime);
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x00017BC8 File Offset: 0x00015DC8
		// (set) Token: 0x06002A76 RID: 10870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066B")]
		public override int TwoDigitYearMax
		{
			[Token(Token = "0x6002A75")]
			[Address(RVA = "0x4C34F90", Offset = "0x4C33B90", VA = "0x184C34F90", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002A76")]
			[Address(RVA = "0x4C452F0", Offset = "0x4C43EF0", VA = "0x184C452F0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00017BE0 File Offset: 0x00015DE0
		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x4C44D60", Offset = "0x4C43960", VA = "0x184C44D60", Slot = "30")]
		public override int ToFourDigitYear(int year)
		{
			return 0;
		}

		// Token: 0x04001888 RID: 6280
		[Token(Token = "0x4001888")]
		[FieldOffset(Offset = "0x0")]
		private static readonly UmAlQuraCalendar.DateMapping[] HijriYearInfo;

		// Token: 0x04001889 RID: 6281
		[Token(Token = "0x4001889")]
		[FieldOffset(Offset = "0x8")]
		internal static System.DateTime minDate;

		// Token: 0x0400188A RID: 6282
		[Token(Token = "0x400188A")]
		[FieldOffset(Offset = "0x10")]
		internal static System.DateTime maxDate;

		// Token: 0x0200058B RID: 1419
		[Token(Token = "0x200058B")]
		internal struct DateMapping
		{
			// Token: 0x06002A79 RID: 10873 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002A79")]
			[Address(RVA = "0x4C2F010", Offset = "0x4C2DC10", VA = "0x184C2F010")]
			internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
			{
			}

			// Token: 0x0400188B RID: 6283
			[Token(Token = "0x400188B")]
			[FieldOffset(Offset = "0x0")]
			internal int HijriMonthsLengthFlags;

			// Token: 0x0400188C RID: 6284
			[Token(Token = "0x400188C")]
			[FieldOffset(Offset = "0x8")]
			internal System.DateTime GregorianDate;
		}
	}
}
