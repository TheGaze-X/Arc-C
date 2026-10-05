using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class ThaiBuddhistCalendar : Calendar
	{
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000178C8 File Offset: 0x00015AC8
		[Token(Token = "0x17000661")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MinSupportedDateTime
		{
			[Token(Token = "0x6002A48")]
			[Address(RVA = "0x4C3ACC0", Offset = "0x4C398C0", VA = "0x184C3ACC0", Slot = "5")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000178E0 File Offset: 0x00015AE0
		[Token(Token = "0x17000662")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override System.DateTime MaxSupportedDateTime
		{
			[Token(Token = "0x6002A49")]
			[Address(RVA = "0x4C3AC70", Offset = "0x4C39870", VA = "0x184C3AC70", Slot = "6")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x4C3ABA0", Offset = "0x4C397A0", VA = "0x184C3ABA0")]
		public ThaiBuddhistCalendar()
		{
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000178F8 File Offset: 0x00015AF8
		[Token(Token = "0x17000663")]
		internal override int ID
		{
			[Token(Token = "0x6002A4B")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00017910 File Offset: 0x00015B10
		[Token(Token = "0x6002A4C")]
		[Address(RVA = "0x4C353C0", Offset = "0x4C33FC0", VA = "0x184C353C0", Slot = "13")]
		public override int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00017928 File Offset: 0x00015B28
		[Token(Token = "0x6002A4D")]
		[Address(RVA = "0x4C353F0", Offset = "0x4C33FF0", VA = "0x184C353F0", Slot = "14")]
		public override int GetDaysInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00017940 File Offset: 0x00015B40
		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0x4C35380", Offset = "0x4C33F80", VA = "0x184C35380", Slot = "11")]
		public override int GetDayOfMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00017958 File Offset: 0x00015B58
		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x4C353A0", Offset = "0x4C33FA0", VA = "0x184C353A0", Slot = "12")]
		public override System.DayOfWeek GetDayOfWeek(System.DateTime time)
		{
			return System.DayOfWeek.Sunday;
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00017970 File Offset: 0x00015B70
		[Token(Token = "0x6002A50")]
		[Address(RVA = "0x4C35B30", Offset = "0x4C34730", VA = "0x184C35B30", Slot = "18")]
		public override int GetMonthsInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00017988 File Offset: 0x00015B88
		[Token(Token = "0x6002A51")]
		[Address(RVA = "0x4C35AF0", Offset = "0x4C346F0", VA = "0x184C35AF0", Slot = "15")]
		public override int GetEra(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x000179A0 File Offset: 0x00015BA0
		[Token(Token = "0x6002A52")]
		[Address(RVA = "0x4C35B10", Offset = "0x4C34710", VA = "0x184C35B10", Slot = "17")]
		public override int GetMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x000179B8 File Offset: 0x00015BB8
		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x4C35B60", Offset = "0x4C34760", VA = "0x184C35B60", Slot = "19")]
		public override int GetYear(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000179D0 File Offset: 0x00015BD0
		[Token(Token = "0x6002A54")]
		[Address(RVA = "0x4C35B80", Offset = "0x4C34780", VA = "0x184C35B80", Slot = "21")]
		public override bool IsLeapYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000179E8 File Offset: 0x00015BE8
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x4C35BD0", Offset = "0x4C347D0", VA = "0x184C35BD0", Slot = "23")]
		public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return default(System.DateTime);
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000664")]
		public override int[] Eras
		{
			[Token(Token = "0x6002A56")]
			[Address(RVA = "0x4C35FA0", Offset = "0x4C34BA0", VA = "0x184C35FA0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x00017A00 File Offset: 0x00015C00
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000665")]
		public override int TwoDigitYearMax
		{
			[Token(Token = "0x6002A57")]
			[Address(RVA = "0x4C3AD10", Offset = "0x4C39910", VA = "0x184C3AD10", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002A58")]
			[Address(RVA = "0x4C3AD90", Offset = "0x4C39990", VA = "0x184C3AD90", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00017A18 File Offset: 0x00015C18
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x4C3A940", Offset = "0x4C39540", VA = "0x184C3A940", Slot = "30")]
		public override int ToFourDigitYear(int year)
		{
			return 0;
		}

		// Token: 0x04001886 RID: 6278
		[Token(Token = "0x4001886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static EraInfo[] thaiBuddhistEraInfo;

		// Token: 0x04001887 RID: 6279
		[Token(Token = "0x4001887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal GregorianCalendarHelper helper;
	}
}
