using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000580 RID: 1408
	[Token(Token = "0x2000580")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class GregorianCalendar : Calendar
	{
		// Token: 0x06002980 RID: 10624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002980")]
		[Address(RVA = "0x4C32530", Offset = "0x4C31130", VA = "0x184C32530")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x00016E30 File Offset: 0x00015030
		[Token(Token = "0x17000629")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MinSupportedDateTime
		{
			[Token(Token = "0x6002981")]
			[Address(RVA = "0x4C32CD0", Offset = "0x4C318D0", VA = "0x184C32CD0", Slot = "5")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x00016E48 File Offset: 0x00015048
		[Token(Token = "0x1700062A")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MaxSupportedDateTime
		{
			[Token(Token = "0x6002982")]
			[Address(RVA = "0x4C32C80", Offset = "0x4C31880", VA = "0x184C32C80", Slot = "6")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002983")]
		[Address(RVA = "0x4C31F70", Offset = "0x4C30B70", VA = "0x184C31F70")]
		internal static Calendar GetDefaultInstance()
		{
			return null;
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002984")]
		[Address(RVA = "0x4C32A90", Offset = "0x4C31690", VA = "0x184C32A90")]
		public GregorianCalendar()
		{
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002985")]
		[Address(RVA = "0x4C32AC0", Offset = "0x4C316C0", VA = "0x184C32AC0")]
		public GregorianCalendar(GregorianCalendarTypes type)
		{
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x00016E60 File Offset: 0x00015060
		[Token(Token = "0x1700062B")]
		internal override int ID
		{
			[Token(Token = "0x6002986")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00016E78 File Offset: 0x00015078
		[Token(Token = "0x6002987")]
		[Address(RVA = "0x4C31790", Offset = "0x4C30390", VA = "0x184C31790", Slot = "31")]
		internal virtual int GetDatePart(long ticks, int part)
		{
			return 0;
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00016E90 File Offset: 0x00015090
		[Token(Token = "0x6002988")]
		[Address(RVA = "0x4C31590", Offset = "0x4C30190", VA = "0x184C31590")]
		internal static long GetAbsoluteDate(int year, int month, int day)
		{
			return 0L;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00016EA8 File Offset: 0x000150A8
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x4C31950", Offset = "0x4C30550", VA = "0x184C31950", Slot = "11")]
		public override int GetDayOfMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00016EC0 File Offset: 0x000150C0
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x4C319E0", Offset = "0x4C305E0", VA = "0x184C319E0", Slot = "12")]
		public override System.DayOfWeek GetDayOfWeek(System.DateTime time)
		{
			return System.DayOfWeek.Sunday;
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00016ED8 File Offset: 0x000150D8
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x4C31A60", Offset = "0x4C30660", VA = "0x184C31A60", Slot = "13")]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00016EF0 File Offset: 0x000150F0
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x4C31D90", Offset = "0x4C30990", VA = "0x184C31D90", Slot = "14")]
		public override int GetDaysInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00016F08 File Offset: 0x00015108
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "15")]
		public override int GetEra(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700062C")]
		public override int[] Eras
		{
			[Token(Token = "0x600298E")]
			[Address(RVA = "0x4C32C20", Offset = "0x4C31820", VA = "0x184C32C20", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00016F20 File Offset: 0x00015120
		[Token(Token = "0x600298F")]
		[Address(RVA = "0x4C32090", Offset = "0x4C30C90", VA = "0x184C32090", Slot = "17")]
		public override int GetMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00016F38 File Offset: 0x00015138
		[Token(Token = "0x6002990")]
		[Address(RVA = "0x4C32120", Offset = "0x4C30D20", VA = "0x184C32120", Slot = "18")]
		public override int GetMonthsInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00016F50 File Offset: 0x00015150
		[Token(Token = "0x6002991")]
		[Address(RVA = "0x4C322C0", Offset = "0x4C30EC0", VA = "0x184C322C0", Slot = "19")]
		public override int GetYear(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00016F68 File Offset: 0x00015168
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x4C32350", Offset = "0x4C30F50", VA = "0x184C32350", Slot = "21")]
		public override bool IsLeapYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00016F80 File Offset: 0x00015180
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x4C32630", Offset = "0x4C31230", VA = "0x184C32630", Slot = "23")]
		public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return default(System.DateTime);
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00016F98 File Offset: 0x00015198
		[Token(Token = "0x6002994")]
		[Address(RVA = "0x4C328A0", Offset = "0x4C314A0", VA = "0x184C328A0", Slot = "24")]
		internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out System.DateTime result)
		{
			return default(bool);
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002995 RID: 10645 RVA: 0x00016FB0 File Offset: 0x000151B0
		// (set) Token: 0x06002996 RID: 10646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062D")]
		public override int TwoDigitYearMax
		{
			[Token(Token = "0x6002995")]
			[Address(RVA = "0x4C32D20", Offset = "0x4C31920", VA = "0x184C32D20", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002996")]
			[Address(RVA = "0x4C32DA0", Offset = "0x4C319A0", VA = "0x184C32DA0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00016FC8 File Offset: 0x000151C8
		[Token(Token = "0x6002997")]
		[Address(RVA = "0x4C32710", Offset = "0x4C31310", VA = "0x184C32710", Slot = "30")]
		public override int ToFourDigitYear(int year)
		{
			return 0;
		}

		// Token: 0x0400182E RID: 6190
		[Token(Token = "0x400182E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal GregorianCalendarTypes m_type;

		// Token: 0x0400182F RID: 6191
		[Token(Token = "0x400182F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly int[] DaysToMonth365;

		// Token: 0x04001830 RID: 6192
		[Token(Token = "0x4001830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly int[] DaysToMonth366;

		// Token: 0x04001831 RID: 6193
		[Token(Token = "0x4001831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Calendar s_defaultInstance;
	}
}
