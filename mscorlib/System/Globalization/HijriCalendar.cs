using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000584 RID: 1412
	[Token(Token = "0x2000584")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class HijriCalendar : Calendar
	{
		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000171A8 File Offset: 0x000153A8
		[Token(Token = "0x17000630")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MinSupportedDateTime
		{
			[Token(Token = "0x60029B2")]
			[Address(RVA = "0x4C34F40", Offset = "0x4C33B40", VA = "0x184C34F40", Slot = "5")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x000171C0 File Offset: 0x000153C0
		[Token(Token = "0x17000631")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MaxSupportedDateTime
		{
			[Token(Token = "0x60029B3")]
			[Address(RVA = "0x4C34EF0", Offset = "0x4C33AF0", VA = "0x184C34EF0", Slot = "6")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0x4C34DE0", Offset = "0x4C339E0", VA = "0x184C34DE0")]
		public HijriCalendar()
		{
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x000171D8 File Offset: 0x000153D8
		[Token(Token = "0x17000632")]
		internal override int ID
		{
			[Token(Token = "0x60029B5")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000171F0 File Offset: 0x000153F0
		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x4C33F20", Offset = "0x4C32B20", VA = "0x184C33F20")]
		private long GetAbsoluteDateHijri(int y, int m, int d)
		{
			return 0L;
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00017208 File Offset: 0x00015408
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x4C33E50", Offset = "0x4C32A50", VA = "0x184C33E50")]
		private long DaysUpToHijriYear(int HijriYear)
		{
			return 0L;
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x00017220 File Offset: 0x00015420
		[Token(Token = "0x17000633")]
		public int HijriAdjustment
		{
			[Token(Token = "0x60029B8")]
			[Address(RVA = "0x4C34E90", Offset = "0x4C33A90", VA = "0x184C34E90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00017238 File Offset: 0x00015438
		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		private static int GetAdvanceHijriDate()
		{
			return 0;
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0x4C33860", Offset = "0x4C32460", VA = "0x184C33860")]
		internal static void CheckTicksRange(long ticks)
		{
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x4C33790", Offset = "0x4C32390", VA = "0x184C33790")]
		internal static void CheckEraRange(int era)
		{
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BC")]
		[Address(RVA = "0x4C33C50", Offset = "0x4C32850", VA = "0x184C33C50")]
		internal static void CheckYearRange(int year, int era)
		{
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x4C33A70", Offset = "0x4C32670", VA = "0x184C33A70")]
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00017250 File Offset: 0x00015450
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0x4C34030", Offset = "0x4C32C30", VA = "0x184C34030", Slot = "31")]
		internal virtual int GetDatePart(long ticks, int part)
		{
			return 0;
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00017268 File Offset: 0x00015468
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x4C34300", Offset = "0x4C32F00", VA = "0x184C34300", Slot = "11")]
		public override int GetDayOfMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00017280 File Offset: 0x00015480
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x4C34390", Offset = "0x4C32F90", VA = "0x184C34390", Slot = "12")]
		public override System.DayOfWeek GetDayOfWeek(System.DateTime time)
		{
			return System.DayOfWeek.Sunday;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00017298 File Offset: 0x00015498
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x4C34410", Offset = "0x4C33010", VA = "0x184C34410", Slot = "13")]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000172B0 File Offset: 0x000154B0
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0x4C344E0", Offset = "0x4C330E0", VA = "0x184C344E0", Slot = "14")]
		public override int GetDaysInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000172C8 File Offset: 0x000154C8
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0x4C34580", Offset = "0x4C33180", VA = "0x184C34580", Slot = "15")]
		public override int GetEra(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000634")]
		public override int[] Eras
		{
			[Token(Token = "0x60029C4")]
			[Address(RVA = "0x4C34E00", Offset = "0x4C33A00", VA = "0x184C34E00", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000172E0 File Offset: 0x000154E0
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x4C34610", Offset = "0x4C33210", VA = "0x184C34610", Slot = "17")]
		public override int GetMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000172F8 File Offset: 0x000154F8
		[Token(Token = "0x60029C6")]
		[Address(RVA = "0x4C346A0", Offset = "0x4C332A0", VA = "0x184C346A0", Slot = "18")]
		public override int GetMonthsInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00017310 File Offset: 0x00015510
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x4C34700", Offset = "0x4C33300", VA = "0x184C34700", Slot = "19")]
		public override int GetYear(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x00017328 File Offset: 0x00015528
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x4C34790", Offset = "0x4C33390", VA = "0x184C34790", Slot = "21")]
		public override bool IsLeapYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00017340 File Offset: 0x00015540
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x4C34810", Offset = "0x4C33410", VA = "0x184C34810", Slot = "23")]
		public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return default(System.DateTime);
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x00017358 File Offset: 0x00015558
		// (set) Token: 0x060029CB RID: 10699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000635")]
		public override int TwoDigitYearMax
		{
			[Token(Token = "0x60029CA")]
			[Address(RVA = "0x4C34F90", Offset = "0x4C33B90", VA = "0x184C34F90", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60029CB")]
			[Address(RVA = "0x4C35010", Offset = "0x4C33C10", VA = "0x184C35010", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00017370 File Offset: 0x00015570
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x4C34B00", Offset = "0x4C33700", VA = "0x184C34B00", Slot = "30")]
		public override int ToFourDigitYear(int year)
		{
			return 0;
		}

		// Token: 0x04001849 RID: 6217
		[Token(Token = "0x4001849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int HijriEra;

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly int[] HijriMonthDays;

		// Token: 0x0400184B RID: 6219
		[Token(Token = "0x400184B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_HijriAdvance;

		// Token: 0x0400184C RID: 6220
		[Token(Token = "0x400184C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly System.DateTime calendarMinValue;

		// Token: 0x0400184D RID: 6221
		[Token(Token = "0x400184D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly System.DateTime calendarMaxValue;
	}
}
