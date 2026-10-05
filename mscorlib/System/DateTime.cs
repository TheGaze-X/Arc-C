using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	[System.Serializable]
	[StructLayout(3)]
	public readonly struct DateTime : System.IComparable, System.IFormattable, System.IConvertible, System.IComparable<System.DateTime>, System.IEquatable<System.DateTime>, System.Runtime.Serialization.ISerializable, ISpanFormattable
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x4CC1CC0", Offset = "0x4CC08C0", VA = "0x184CC1CC0")]
		public DateTime(long ticks)
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		private DateTime(ulong dateData)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x4CC2440", Offset = "0x4CC1040", VA = "0x184CC2440")]
		public DateTime(long ticks, System.DateTimeKind kind)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x4CC2020", Offset = "0x4CC0C20", VA = "0x184CC2020")]
		internal DateTime(long ticks, System.DateTimeKind kind, bool isAmbiguousDst)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x4CC20C0", Offset = "0x4CC0CC0", VA = "0x184CC20C0")]
		public DateTime(int year, int month, int day)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x4CC16B0", Offset = "0x4CC02B0", VA = "0x184CC16B0")]
		public DateTime(int year, int month, int day, int hour, int minute, int second)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x4CC2320", Offset = "0x4CC0F20", VA = "0x184CC2320")]
		public DateTime(int year, int month, int day, int hour, int minute, int second, System.DateTimeKind kind)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x4CC2140", Offset = "0x4CC0D40", VA = "0x184CC2140")]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x4CC1750", Offset = "0x4CC0350", VA = "0x184CC1750")]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.DateTimeKind kind)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x4CC1D60", Offset = "0x4CC0960", VA = "0x184CC1D60")]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x4CC19B0", Offset = "0x4CC05B0", VA = "0x184CC19B0")]
		private DateTime(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x1700006E")]
		internal long InternalTicks
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x4CC27A0", Offset = "0x4CC13A0", VA = "0x184CC27A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x1700006F")]
		private ulong InternalKind
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x4CC2780", Offset = "0x4CC1380", VA = "0x184CC2780")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x4CBE310", Offset = "0x4CBCF10", VA = "0x184CBE310")]
		public System.DateTime Add(System.TimeSpan value)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x4CBE1F0", Offset = "0x4CBCDF0", VA = "0x184CBE1F0")]
		private System.DateTime Add(double value, int scale)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x4CBDAC0", Offset = "0x4CBC6C0", VA = "0x184CBDAC0")]
		public System.DateTime AddDays(double value)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x4CBDB20", Offset = "0x4CBC720", VA = "0x184CBDB20")]
		public System.DateTime AddHours(double value)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x4CBDB80", Offset = "0x4CBC780", VA = "0x184CBDB80")]
		public System.DateTime AddMilliseconds(double value)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x4CBDBE0", Offset = "0x4CBC7E0", VA = "0x184CBDBE0")]
		public System.DateTime AddMinutes(double value)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x4CBDC40", Offset = "0x4CBC840", VA = "0x184CBDC40")]
		public System.DateTime AddMonths(int months)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x4CBDFA0", Offset = "0x4CBCBA0", VA = "0x184CBDFA0")]
		public System.DateTime AddSeconds(double value)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x4CBE000", Offset = "0x4CBCC00", VA = "0x184CBE000")]
		public System.DateTime AddTicks(long value)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x4CBE120", Offset = "0x4CBCD20", VA = "0x184CBE120")]
		public System.DateTime AddYears(int value)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x4CBE4D0", Offset = "0x4CBD0D0", VA = "0x184CBE4D0")]
		public static int Compare(System.DateTime t1, System.DateTime t2)
		{
			return 0;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x4CBE370", Offset = "0x4CBCF70", VA = "0x184CBE370", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x4CBE470", Offset = "0x4CBD070", VA = "0x184CBE470", Slot = "23")]
		public int CompareTo(System.DateTime value)
		{
			return 0;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x4CBE550", Offset = "0x4CBD150", VA = "0x184CBE550")]
		private static long DateToTicks(int year, int month, int day)
		{
			return 0L;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x4CC0540", Offset = "0x4CBF140", VA = "0x184CC0540")]
		private static long TimeToTicks(int hour, int minute, int second)
		{
			return 0L;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x4CBE730", Offset = "0x4CBD330", VA = "0x184CBE730")]
		public static int DaysInMonth(int year, int month)
		{
			return 0;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x4CBE880", Offset = "0x4CBD480", VA = "0x184CBE880", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x4CBE930", Offset = "0x4CBD530", VA = "0x184CBE930", Slot = "24")]
		public bool Equals(System.DateTime value)
		{
			return default(bool);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x4CBEA40", Offset = "0x4CBD640", VA = "0x184CBEA40")]
		public static System.DateTime FromBinary(long dateData)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x4CBE990", Offset = "0x4CBD590", VA = "0x184CBE990")]
		internal static System.DateTime FromBinaryRaw(long dateData)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x4CBEDF0", Offset = "0x4CBD9F0", VA = "0x184CBEDF0")]
		public static System.DateTime FromFileTime(long fileTime)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x4CBED30", Offset = "0x4CBD930", VA = "0x184CBED30")]
		public static System.DateTime FromFileTimeUtc(long fileTime)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x4CC0450", Offset = "0x4CBF050", VA = "0x184CC0450", Slot = "25")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x4CBFB70", Offset = "0x4CBE770", VA = "0x184CBFB70")]
		public static System.DateTime SpecifyKind(System.DateTime value, System.DateTimeKind kind)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x4CC0610", Offset = "0x4CBF210", VA = "0x184CC0610")]
		public long ToBinary()
		{
			return 0L;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x17000070")]
		public System.DateTime Date
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x4CC2540", Offset = "0x4CC1140", VA = "0x184CC2540")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x4CBEF20", Offset = "0x4CBDB20", VA = "0x184CBEF20")]
		private int GetDatePart(int part)
		{
			return 0;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x4CBF100", Offset = "0x4CBDD00", VA = "0x184CBF100")]
		internal void GetDatePart(out int year, out int month, out int day)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x17000071")]
		public int Day
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x4CC26A0", Offset = "0x4CC12A0", VA = "0x184CC26A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x17000072")]
		public System.DayOfWeek DayOfWeek
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x4CC25C0", Offset = "0x4CC11C0", VA = "0x184CC25C0")]
			get
			{
				return System.DayOfWeek.Sunday;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x17000073")]
		public int DayOfYear
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x4CC2650", Offset = "0x4CC1250", VA = "0x184CC2650")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x4CBF2E0", Offset = "0x4CBDEE0", VA = "0x184CBF2E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x17000074")]
		public int Hour
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x4CC26F0", Offset = "0x4CC12F0", VA = "0x184CC26F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x4CBF350", Offset = "0x4CBDF50", VA = "0x184CBF350")]
		internal bool IsAmbiguousDaylightSavingTime()
		{
			return default(bool);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x17000075")]
		public System.DateTimeKind Kind
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x4CC27C0", Offset = "0x4CC13C0", VA = "0x184CC27C0")]
			get
			{
				return System.DateTimeKind.Unspecified;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x17000076")]
		public int Millisecond
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x4CC2830", Offset = "0x4CC1430", VA = "0x184CC2830")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x17000077")]
		public int Minute
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x4CC28C0", Offset = "0x4CC14C0", VA = "0x184CC28C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x17000078")]
		public int Month
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x4CC2950", Offset = "0x4CC1550", VA = "0x184CC2950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x17000079")]
		public static System.DateTime Now
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x4CC29A0", Offset = "0x4CC15A0", VA = "0x184CC29A0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x1700007A")]
		public int Second
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x4CC2BA0", Offset = "0x4CC17A0", VA = "0x184CC2BA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x1700007B")]
		public long Ticks
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x4CC2C30", Offset = "0x4CC1830", VA = "0x184CC2C30")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x1700007C")]
		public System.TimeSpan TimeOfDay
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x4CC2C80", Offset = "0x4CC1880", VA = "0x184CC2C80")]
			get
			{
				return default(System.TimeSpan);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x1700007D")]
		public static System.DateTime Today
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x4CC2CF0", Offset = "0x4CC18F0", VA = "0x184CC2CF0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x1700007E")]
		public int Year
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x4CC2E00", Offset = "0x4CC1A00", VA = "0x184CC2E00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x4CBF3B0", Offset = "0x4CBDFB0", VA = "0x184CBF3B0")]
		public static bool IsLeapYear(int year)
		{
			return default(bool);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x4CBFA70", Offset = "0x4CBE670", VA = "0x184CBFA70")]
		public static System.DateTime Parse(string s, System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x4CBF930", Offset = "0x4CBE530", VA = "0x184CBF930")]
		public static System.DateTime Parse(string s, System.IFormatProvider provider, System.Globalization.DateTimeStyles styles)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x4CBF7B0", Offset = "0x4CBE3B0", VA = "0x184CBF7B0")]
		public static System.DateTime ParseExact(string s, string format, System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x4CBF4A0", Offset = "0x4CBE0A0", VA = "0x184CBF4A0")]
		public static System.DateTime ParseExact(string s, string format, System.IFormatProvider provider, System.Globalization.DateTimeStyles style)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00006A68 File Offset: 0x00004C68
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x4CBF660", Offset = "0x4CBE260", VA = "0x184CBF660")]
		public static System.DateTime ParseExact(string s, string[] formats, System.IFormatProvider provider, System.Globalization.DateTimeStyles style)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x4CBFBF0", Offset = "0x4CBE7F0", VA = "0x184CBFBF0")]
		public System.TimeSpan Subtract(System.DateTime value)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00006A98 File Offset: 0x00004C98
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x4CC08C0", Offset = "0x4CBF4C0", VA = "0x184CC08C0")]
		public long ToFileTime()
		{
			return 0L;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x4CC07A0", Offset = "0x4CBF3A0", VA = "0x184CC07A0")]
		public long ToFileTimeUtc()
		{
			return 0L;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x4CC0C10", Offset = "0x4CBF810", VA = "0x184CC0C10")]
		public System.DateTime ToLocalTime()
		{
			return default(System.DateTime);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x4CC0960", Offset = "0x4CBF560", VA = "0x184CC0960")]
		internal System.DateTime ToLocalTime(bool throwOnOverflow)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x4CC0CD0", Offset = "0x4CBF8D0", VA = "0x184CC0CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x4CC0DD0", Offset = "0x4CBF9D0", VA = "0x184CC0DD0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x4CC0D70", Offset = "0x4CBF970", VA = "0x184CC0D70", Slot = "21")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x4CC0C60", Offset = "0x4CBF860", VA = "0x184CC0C60", Slot = "5")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x4CC10A0", Offset = "0x4CBFCA0", VA = "0x184CC10A0", Slot = "26")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x4CC0E30", Offset = "0x4CBFA30", VA = "0x184CC0E30")]
		public System.DateTime ToUniversalTime()
		{
			return default(System.DateTime);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x4CC1330", Offset = "0x4CBFF30", VA = "0x184CC1330")]
		public static bool TryParse(string s, out System.DateTime result)
		{
			return default(bool);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x4CC1430", Offset = "0x4CC0030", VA = "0x184CC1430")]
		public static bool TryParse(string s, System.IFormatProvider provider, System.Globalization.DateTimeStyles styles, out System.DateTime result)
		{
			return default(bool);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x4CC1190", Offset = "0x4CBFD90", VA = "0x184CC1190")]
		public static bool TryParseExact(string s, string format, System.IFormatProvider provider, System.Globalization.DateTimeStyles style, out System.DateTime result)
		{
			return default(bool);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x4CC2E50", Offset = "0x4CC1A50", VA = "0x184CC2E50")]
		public static System.DateTime operator +(System.DateTime d, System.TimeSpan t)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x4CC31E0", Offset = "0x4CC1DE0", VA = "0x184CC31E0")]
		public static System.DateTime operator -(System.DateTime d, System.TimeSpan t)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x4CC32F0", Offset = "0x4CC1EF0", VA = "0x184CC32F0")]
		public static System.TimeSpan operator -(System.DateTime d1, System.DateTime d2)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x4CC2F60", Offset = "0x4CC1B60", VA = "0x184CC2F60")]
		public static bool operator ==(System.DateTime d1, System.DateTime d2)
		{
			return default(bool);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x4CC30A0", Offset = "0x4CC1CA0", VA = "0x184CC30A0")]
		public static bool operator !=(System.DateTime d1, System.DateTime d2)
		{
			return default(bool);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x4CC3170", Offset = "0x4CC1D70", VA = "0x184CC3170")]
		public static bool operator <(System.DateTime t1, System.DateTime t2)
		{
			return default(bool);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x4CC3100", Offset = "0x4CC1D00", VA = "0x184CC3100")]
		public static bool operator <=(System.DateTime t1, System.DateTime t2)
		{
			return default(bool);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x4CC3030", Offset = "0x4CC1C30", VA = "0x184CC3030")]
		public static bool operator >(System.DateTime t1, System.DateTime t2)
		{
			return default(bool);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00006C30 File Offset: 0x00004E30
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x4CC2FC0", Offset = "0x4CC1BC0", VA = "0x184CC2FC0")]
		public static bool operator >=(System.DateTime t1, System.DateTime t2)
		{
			return default(bool);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00006C48 File Offset: 0x00004E48
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "6")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00006C60 File Offset: 0x00004E60
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x4CBFC60", Offset = "0x4CBE860", VA = "0x184CBFC60", Slot = "7")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00006C78 File Offset: 0x00004E78
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x4CBFD80", Offset = "0x4CBE980", VA = "0x184CBFD80", Slot = "8")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x4CC00E0", Offset = "0x4CBECE0", VA = "0x184CC00E0", Slot = "9")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x4CBFCF0", Offset = "0x4CBE8F0", VA = "0x184CBFCF0", Slot = "10")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x4CBFF30", Offset = "0x4CBEB30", VA = "0x184CBFF30", Slot = "11")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x4CC02A0", Offset = "0x4CBEEA0", VA = "0x184CC02A0", Slot = "12")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x4CBFFC0", Offset = "0x4CBEBC0", VA = "0x184CBFFC0", Slot = "13")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x4CC0330", Offset = "0x4CBEF30", VA = "0x184CC0330", Slot = "14")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00006D20 File Offset: 0x00004F20
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x4CC0050", Offset = "0x4CBEC50", VA = "0x184CC0050", Slot = "15")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00006D38 File Offset: 0x00004F38
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x4CC03C0", Offset = "0x4CBEFC0", VA = "0x184CC03C0", Slot = "16")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00006D50 File Offset: 0x00004F50
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x4CC0170", Offset = "0x4CBED70", VA = "0x184CC0170", Slot = "17")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x4CBFEA0", Offset = "0x4CBEAA0", VA = "0x184CBFEA0", Slot = "18")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00006D80 File Offset: 0x00004F80
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x4CBFE10", Offset = "0x4CBEA10", VA = "0x184CBFE10", Slot = "19")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "20")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x4CC0200", Offset = "0x4CBEE00", VA = "0x184CC0200", Slot = "22")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x4CC0E90", Offset = "0x4CBFA90", VA = "0x184CC0E90")]
		internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out System.DateTime result)
		{
			return default(bool);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x1700007F")]
		public static System.DateTime UtcNow
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x4CC2DA0", Offset = "0x4CC19A0", VA = "0x184CC2DA0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x0600069E RID: 1694
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x4CBF340", Offset = "0x4CBDF40", VA = "0x184CBF340")]
		[MethodImpl(4096)]
		internal static extern long GetSystemTimeAsFileTime();

		// Token: 0x0600069F RID: 1695 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
		internal long ToBinaryRaw()
		{
			return 0L;
		}

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		private const long TicksPerMillisecond = 10000L;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		private const long TicksPerSecond = 10000000L;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		private const long TicksPerMinute = 600000000L;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		private const long TicksPerHour = 36000000000L;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		private const long TicksPerDay = 864000000000L;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		private const int MillisPerSecond = 1000;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		private const int MillisPerMinute = 60000;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		private const int MillisPerHour = 3600000;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		private const int MillisPerDay = 86400000;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		private const int DaysPerYear = 365;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		private const int DaysPer4Years = 1461;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		private const int DaysPer100Years = 36524;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		private const int DaysPer400Years = 146097;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		private const int DaysTo1601 = 584388;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		private const int DaysTo1899 = 693593;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		internal const int DaysTo1970 = 719162;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		private const int DaysTo10000 = 3652059;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		internal const long MinTicks = 0L;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		internal const long MaxTicks = 3155378975999999999L;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		private const long MaxMillis = 315537897600000L;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		internal const long UnixEpochTicks = 621355968000000000L;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		private const long FileTimeOffset = 504911232000000000L;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		private const long DoubleDateOffset = 599264352000000000L;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		private const long OADateMinAsTicks = 31241376000000000L;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		private const double OADateMinAsDouble = -657435.0;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		private const double OADateMaxAsDouble = 2958466.0;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		private const int DatePartYear = 0;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		private const int DatePartDayOfYear = 1;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		private const int DatePartMonth = 2;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		private const int DatePartDay = 3;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] s_daysToMonth365;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] s_daysToMonth366;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly System.DateTime MinValue;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly System.DateTime MaxValue;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly System.DateTime UnixEpoch;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		private const ulong TicksMask = 4611686018427387903UL;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		private const ulong FlagsMask = 13835058055282163712UL;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		private const ulong LocalMask = 9223372036854775808UL;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		private const long TicksCeiling = 4611686018427387904L;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		private const ulong KindUnspecified = 0UL;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		private const ulong KindUtc = 4611686018427387904UL;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		private const ulong KindLocal = 9223372036854775808UL;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		private const ulong KindLocalAmbiguousDst = 13835058055282163712UL;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		private const int KindShift = 62;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		private const string TicksField = "ticks";

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		private const string DateDataField = "dateData";

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ulong _dateData;
	}
}
