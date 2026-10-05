using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	internal struct XsdDuration
	{
		// Token: 0x06000C90 RID: 3216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x5039130", Offset = "0x5037D30", VA = "0x185039130")]
		public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
		{
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x5038DF0", Offset = "0x50379F0", VA = "0x185038DF0")]
		public XsdDuration(TimeSpan timeSpan)
		{
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x5038E00", Offset = "0x5037A00", VA = "0x185038E00")]
		public XsdDuration(TimeSpan timeSpan, XsdDuration.DurationType durationType)
		{
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x5039080", Offset = "0x5037C80", VA = "0x185039080")]
		public XsdDuration(string s, XsdDuration.DurationType durationType)
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x17000345")]
		public bool IsNegative
		{
			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x5039400", Offset = "0x5038000", VA = "0x185039400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x17000346")]
		public int Years
		{
			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x17000347")]
		public int Months
		{
			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x17000348")]
		public int Days
		{
			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x17000349")]
		public int Hours
		{
			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x1700034A")]
		public int Minutes
		{
			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x1700034B")]
		public int Seconds
		{
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x1700034C")]
		public int Nanoseconds
		{
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x5039410", Offset = "0x5038010", VA = "0x185039410")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x5037AF0", Offset = "0x50366F0", VA = "0x185037AF0")]
		public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType)
		{
			return default(TimeSpan);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x5038830", Offset = "0x5037430", VA = "0x185038830")]
		internal Exception TryToTimeSpan(out TimeSpan result)
		{
			return null;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x5038840", Offset = "0x5037440", VA = "0x185038840")]
		internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result)
		{
			return null;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x5037700", Offset = "0x5036300", VA = "0x185037700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x5037710", Offset = "0x5036310", VA = "0x185037710")]
		internal string ToString(XsdDuration.DurationType durationType)
		{
			return null;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x5037CA0", Offset = "0x50368A0", VA = "0x185037CA0")]
		internal static Exception TryParse(string s, out XsdDuration result)
		{
			return null;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x5037CB0", Offset = "0x50368B0", VA = "0x185037CB0")]
		internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result)
		{
			return null;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x5037B40", Offset = "0x5036740", VA = "0x185037B40")]
		private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits)
		{
			return null;
		}

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x0")]
		private int years;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x4")]
		private int months;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x8")]
		private int days;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0xC")]
		private int hours;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x10")]
		private int minutes;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x14")]
		private int seconds;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x18")]
		private uint nanoseconds;

		// Token: 0x0200016E RID: 366
		[Token(Token = "0x200016E")]
		private enum Parts
		{
			// Token: 0x0400067B RID: 1659
			[Token(Token = "0x400067B")]
			HasNone,
			// Token: 0x0400067C RID: 1660
			[Token(Token = "0x400067C")]
			HasYears,
			// Token: 0x0400067D RID: 1661
			[Token(Token = "0x400067D")]
			HasMonths,
			// Token: 0x0400067E RID: 1662
			[Token(Token = "0x400067E")]
			HasDays = 4,
			// Token: 0x0400067F RID: 1663
			[Token(Token = "0x400067F")]
			HasHours = 8,
			// Token: 0x04000680 RID: 1664
			[Token(Token = "0x4000680")]
			HasMinutes = 16,
			// Token: 0x04000681 RID: 1665
			[Token(Token = "0x4000681")]
			HasSeconds = 32
		}

		// Token: 0x0200016F RID: 367
		[Token(Token = "0x200016F")]
		public enum DurationType
		{
			// Token: 0x04000683 RID: 1667
			[Token(Token = "0x4000683")]
			Duration,
			// Token: 0x04000684 RID: 1668
			[Token(Token = "0x4000684")]
			YearMonthDuration,
			// Token: 0x04000685 RID: 1669
			[Token(Token = "0x4000685")]
			DayTimeDuration
		}
	}
}
