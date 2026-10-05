using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000582 RID: 1410
	[Token(Token = "0x2000582")]
	[System.Serializable]
	internal class GregorianCalendarHelper
	{
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x00016FE0 File Offset: 0x000151E0
		[Token(Token = "0x1700062E")]
		internal int MaxYear
		{
			[Token(Token = "0x600299B")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299C")]
		[Address(RVA = "0x4C31380", Offset = "0x4C2FF80", VA = "0x184C31380")]
		internal GregorianCalendarHelper(Calendar cal, EraInfo[] eraInfo)
		{
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00016FF8 File Offset: 0x000151F8
		[Token(Token = "0x600299D")]
		[Address(RVA = "0x4C307F0", Offset = "0x4C2F3F0", VA = "0x184C307F0")]
		private int GetYearOffset(int year, int era, bool throwOnError)
		{
			return 0;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00017010 File Offset: 0x00015210
		[Token(Token = "0x600299E")]
		[Address(RVA = "0x4C30710", Offset = "0x4C2F310", VA = "0x184C30710")]
		internal int GetGregorianYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00017028 File Offset: 0x00015228
		[Token(Token = "0x600299F")]
		[Address(RVA = "0x4C30D60", Offset = "0x4C2F960", VA = "0x184C30D60")]
		internal bool IsValidYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00017040 File Offset: 0x00015240
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x4C30090", Offset = "0x4C2EC90", VA = "0x184C30090", Slot = "4")]
		internal virtual int GetDatePart(long ticks, int part)
		{
			return 0;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00017058 File Offset: 0x00015258
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x4C2FE90", Offset = "0x4C2EA90", VA = "0x184C2FE90")]
		internal static long GetAbsoluteDate(int year, int month, int day)
		{
			return 0L;
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00017070 File Offset: 0x00015270
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x4C2FE10", Offset = "0x4C2EA10", VA = "0x184C2FE10")]
		internal static long DateToTicks(int year, int month, int day)
		{
			return 0L;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x00017088 File Offset: 0x00015288
		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x4C30D80", Offset = "0x4C2F980", VA = "0x184C30D80")]
		internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			return 0L;
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x4C2FBE0", Offset = "0x4C2E7E0", VA = "0x184C2FBE0")]
		internal void CheckTicksRange(long ticks)
		{
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000170A0 File Offset: 0x000152A0
		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x4C30280", Offset = "0x4C2EE80", VA = "0x184C30280")]
		public int GetDayOfMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000170B8 File Offset: 0x000152B8
		[Token(Token = "0x60029A6")]
		[Address(RVA = "0x4C30310", Offset = "0x4C2EF10", VA = "0x184C30310")]
		public System.DayOfWeek GetDayOfWeek(System.DateTime time)
		{
			return System.DayOfWeek.Sunday;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000170D0 File Offset: 0x000152D0
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x4C303C0", Offset = "0x4C2EFC0", VA = "0x184C303C0")]
		public int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000170E8 File Offset: 0x000152E8
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x4C30580", Offset = "0x4C2F180", VA = "0x184C30580")]
		public int GetDaysInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00017100 File Offset: 0x00015300
		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x4C30600", Offset = "0x4C2F200", VA = "0x184C30600")]
		public int GetEra(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700062F")]
		public int[] Eras
		{
			[Token(Token = "0x60029AA")]
			[Address(RVA = "0x4C31460", Offset = "0x4C30060", VA = "0x184C31460")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00017118 File Offset: 0x00015318
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x4C30740", Offset = "0x4C2F340", VA = "0x184C30740")]
		public int GetMonth(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00017130 File Offset: 0x00015330
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0x4C307D0", Offset = "0x4C2F3D0", VA = "0x184C307D0")]
		public int GetMonthsInYear(int year, int era)
		{
			return 0;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00017148 File Offset: 0x00015348
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x4C30BA0", Offset = "0x4C2F7A0", VA = "0x184C30BA0")]
		public int GetYear(System.DateTime time)
		{
			return 0;
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00017160 File Offset: 0x00015360
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x4C30CE0", Offset = "0x4C2F8E0", VA = "0x184C30CE0")]
		public bool IsLeapYear(int year, int era)
		{
			return default(bool);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00017178 File Offset: 0x00015378
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x4C30F60", Offset = "0x4C2FB60", VA = "0x184C30F60")]
		public System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return default(System.DateTime);
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00017190 File Offset: 0x00015390
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x4C310A0", Offset = "0x4C2FCA0", VA = "0x184C310A0")]
		public int ToFourDigitYear(int year, int twoDigitYearMax)
		{
			return 0;
		}

		// Token: 0x0400183A RID: 6202
		[Token(Token = "0x400183A")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] DaysToMonth365;

		// Token: 0x0400183B RID: 6203
		[Token(Token = "0x400183B")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] DaysToMonth366;

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x10")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal int m_maxYear;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x14")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal int m_minYear;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x18")]
		internal Calendar m_Cal;

		// Token: 0x0400183F RID: 6207
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x20")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal EraInfo[] m_EraInfo;

		// Token: 0x04001840 RID: 6208
		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x28")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal int[] m_eras;

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x30")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal System.DateTime m_minDate;
	}
}
