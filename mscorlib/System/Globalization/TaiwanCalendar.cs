using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000587 RID: 1415
	[Token(Token = "0x2000587")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class TaiwanCalendar : Calendar
	{
		// Token: 0x06002A10 RID: 10768 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x4C37F10", Offset = "0x4C36B10", VA = "0x184C37F10")]
		internal static Calendar GetDefaultInstance()
		{
			return null;
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000175E0 File Offset: 0x000157E0
		[Token(Token = "0x17000657")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MinSupportedDateTime
		{
			[Token(Token = "0x6002A11")]
			[Address(RVA = "0x4C38580", Offset = "0x4C37180", VA = "0x184C38580", Slot = "5")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x000175F8 File Offset: 0x000157F8
		[Token(Token = "0x17000658")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MaxSupportedDateTime
		{
			[Token(Token = "0x6002A12")]
			[Address(RVA = "0x4C38530", Offset = "0x4C37130", VA = "0x184C38530", Slot = "6")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x4C38390", Offset = "0x4C36F90", VA = "0x184C38390")]
		public TaiwanCalendar()
		{
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002A14 RID: 10772 RVA: 0x00017610 File Offset: 0x00015810
		[Token(Token = "0x17000659")]
		internal override int ID
		{
			[Token(Token = "0x6002A14")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00017628 File Offset: 0x00015828
		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x4C353C0", Offset = "0x4C33FC0", VA = "0x184C353C0", Slot = "13")]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00017640 File Offset: 0x00015840
		[Token(Token = "0x6002A16")]
		[Address(RVA = "0x4C353F0", Offset = "0x4C33FF0", VA = "0x184C353F0", Slot = "14")]
		public override int GetDaysInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x00017658 File Offset: 0x00015858
		[Token(Token = "0x6002A17")]
		[Address(RVA = "0x4C35380", Offset = "0x4C33F80", VA = "0x184C35380", Slot = "11")]
		public override int GetDayOfMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x00017670 File Offset: 0x00015870
		[Token(Token = "0x6002A18")]
		[Address(RVA = "0x4C353A0", Offset = "0x4C33FA0", VA = "0x184C353A0", Slot = "12")]
		public override System.DayOfWeek GetDayOfWeek(System.DateTime time)
		{
			return System.DayOfWeek.Sunday;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00017688 File Offset: 0x00015888
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x4C35B30", Offset = "0x4C34730", VA = "0x184C35B30", Slot = "18")]
		public override int GetMonthsInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000176A0 File Offset: 0x000158A0
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x4C35AF0", Offset = "0x4C346F0", VA = "0x184C35AF0", Slot = "15")]
		public override int GetEra(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000176B8 File Offset: 0x000158B8
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x4C35B10", Offset = "0x4C34710", VA = "0x184C35B10", Slot = "17")]
		public override int GetMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000176D0 File Offset: 0x000158D0
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x4C35B60", Offset = "0x4C34760", VA = "0x184C35B60", Slot = "19")]
		public override int GetYear(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000176E8 File Offset: 0x000158E8
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x4C35B80", Offset = "0x4C34780", VA = "0x184C35B80", Slot = "21")]
		public override bool IsLeapYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00017700 File Offset: 0x00015900
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x4C35BD0", Offset = "0x4C347D0", VA = "0x184C35BD0", Slot = "23")]
		public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return default(System.DateTime);
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700065A")]
		public override int[] Eras
		{
			[Token(Token = "0x6002A1F")]
			[Address(RVA = "0x4C35FA0", Offset = "0x4C34BA0", VA = "0x184C35FA0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x00017718 File Offset: 0x00015918
		// (set) Token: 0x06002A21 RID: 10785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065B")]
		public override int TwoDigitYearMax
		{
			[Token(Token = "0x6002A20")]
			[Address(RVA = "0x4C36060", Offset = "0x4C34C60", VA = "0x184C36060", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002A21")]
			[Address(RVA = "0x4C385D0", Offset = "0x4C371D0", VA = "0x184C385D0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00017730 File Offset: 0x00015930
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x4C38010", Offset = "0x4C36C10", VA = "0x184C38010", Slot = "30")]
		public override int ToFourDigitYear(int year)
		{
			return 0;
		}

		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x4001876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static EraInfo[] taiwanEraInfo;

		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static Calendar s_defaultInstance;

		// Token: 0x04001878 RID: 6264
		[Token(Token = "0x4001878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal GregorianCalendarHelper helper;

		// Token: 0x04001879 RID: 6265
		[Token(Token = "0x4001879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly System.DateTime calendarMinValue;
	}
}
