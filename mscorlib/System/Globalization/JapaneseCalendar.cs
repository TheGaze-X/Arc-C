using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000585 RID: 1413
	[Token(Token = "0x2000585")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class JapaneseCalendar : Calendar
	{
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x00017388 File Offset: 0x00015588
		[Token(Token = "0x17000636")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MinSupportedDateTime
		{
			[Token(Token = "0x60029CE")]
			[Address(RVA = "0x4C36010", Offset = "0x4C34C10", VA = "0x184C36010", Slot = "5")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x000173A0 File Offset: 0x000155A0
		[Token(Token = "0x17000637")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MaxSupportedDateTime
		{
			[Token(Token = "0x60029CF")]
			[Address(RVA = "0x4C35FC0", Offset = "0x4C34BC0", VA = "0x184C35FC0", Slot = "6")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x4C35510", Offset = "0x4C34110", VA = "0x184C35510")]
		internal static EraInfo[] GetEraInfo()
		{
			return null;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60029D1")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		private static EraInfo[] GetErasFromRegistry()
		{
			return null;
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x4C35410", Offset = "0x4C34010", VA = "0x184C35410")]
		internal static Calendar GetDefaultInstance()
		{
			return null;
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x4C35E10", Offset = "0x4C34A10", VA = "0x184C35E10")]
		public JapaneseCalendar()
		{
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x000173B8 File Offset: 0x000155B8
		[Token(Token = "0x17000638")]
		internal override int ID
		{
			[Token(Token = "0x60029D4")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000173D0 File Offset: 0x000155D0
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x4C353C0", Offset = "0x4C33FC0", VA = "0x184C353C0", Slot = "13")]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x000173E8 File Offset: 0x000155E8
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x4C353F0", Offset = "0x4C33FF0", VA = "0x184C353F0", Slot = "14")]
		public override int GetDaysInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00017400 File Offset: 0x00015600
		[Token(Token = "0x60029D7")]
		[Address(RVA = "0x4C35380", Offset = "0x4C33F80", VA = "0x184C35380", Slot = "11")]
		public override int GetDayOfMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00017418 File Offset: 0x00015618
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x4C353A0", Offset = "0x4C33FA0", VA = "0x184C353A0", Slot = "12")]
		public override System.DayOfWeek GetDayOfWeek(System.DateTime time)
		{
			return System.DayOfWeek.Sunday;
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00017430 File Offset: 0x00015630
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x4C35B30", Offset = "0x4C34730", VA = "0x184C35B30", Slot = "18")]
		public override int GetMonthsInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00017448 File Offset: 0x00015648
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x4C35AF0", Offset = "0x4C346F0", VA = "0x184C35AF0", Slot = "15")]
		public override int GetEra(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00017460 File Offset: 0x00015660
		[Token(Token = "0x60029DB")]
		[Address(RVA = "0x4C35B10", Offset = "0x4C34710", VA = "0x184C35B10", Slot = "17")]
		public override int GetMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00017478 File Offset: 0x00015678
		[Token(Token = "0x60029DC")]
		[Address(RVA = "0x4C35B60", Offset = "0x4C34760", VA = "0x184C35B60", Slot = "19")]
		public override int GetYear(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00017490 File Offset: 0x00015690
		[Token(Token = "0x60029DD")]
		[Address(RVA = "0x4C35B80", Offset = "0x4C34780", VA = "0x184C35B80", Slot = "21")]
		public override bool IsLeapYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000174A8 File Offset: 0x000156A8
		[Token(Token = "0x60029DE")]
		[Address(RVA = "0x4C35BD0", Offset = "0x4C347D0", VA = "0x184C35BD0", Slot = "23")]
		public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return default(System.DateTime);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000174C0 File Offset: 0x000156C0
		[Token(Token = "0x60029DF")]
		[Address(RVA = "0x4C35C00", Offset = "0x4C34800", VA = "0x184C35C00", Slot = "30")]
		public override int ToFourDigitYear(int year)
		{
			return 0;
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000639")]
		public override int[] Eras
		{
			[Token(Token = "0x60029E0")]
			[Address(RVA = "0x4C35FA0", Offset = "0x4C34BA0", VA = "0x184C35FA0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60029E1")]
		[Address(RVA = "0x4C35260", Offset = "0x4C33E60", VA = "0x184C35260")]
		internal static string[] EraNames()
		{
			return null;
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60029E2")]
		[Address(RVA = "0x4C35140", Offset = "0x4C33D40", VA = "0x184C35140")]
		internal static string[] EnglishEraNames()
		{
			return null;
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000174D8 File Offset: 0x000156D8
		[Token(Token = "0x60029E3")]
		[Address(RVA = "0x4C35BA0", Offset = "0x4C347A0", VA = "0x184C35BA0", Slot = "25")]
		internal override bool IsValidYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x000174F0 File Offset: 0x000156F0
		// (set) Token: 0x060029E5 RID: 10725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063A")]
		public override int TwoDigitYearMax
		{
			[Token(Token = "0x60029E4")]
			[Address(RVA = "0x4C36060", Offset = "0x4C34C60", VA = "0x184C36060", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60029E5")]
			[Address(RVA = "0x4C360E0", Offset = "0x4C34CE0", VA = "0x184C360E0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x0400184E RID: 6222
		[Token(Token = "0x400184E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly System.DateTime calendarMinValue;

		// Token: 0x0400184F RID: 6223
		[Token(Token = "0x400184F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static EraInfo[] japaneseEraInfo;

		// Token: 0x04001850 RID: 6224
		[Token(Token = "0x4001850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static Calendar s_defaultInstance;

		// Token: 0x04001851 RID: 6225
		[Token(Token = "0x4001851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal GregorianCalendarHelper helper;
	}
}
