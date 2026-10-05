using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	[System.Serializable]
	[StructLayout(3)]
	public readonly struct DateTimeOffset : System.IComparable, System.IFormattable, System.IComparable<System.DateTimeOffset>, System.IEquatable<System.DateTimeOffset>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback, ISpanFormattable
	{
		// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x4CBC900", Offset = "0x4CBB500", VA = "0x184CBC900")]
		public DateTimeOffset(long ticks, System.TimeSpan offset)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x4CBCBF0", Offset = "0x4CBB7F0", VA = "0x184CBCBF0")]
		public DateTimeOffset(System.DateTime dateTime)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x4CBC630", Offset = "0x4CBB230", VA = "0x184CBC630")]
		public DateTimeOffset(System.DateTime dateTime, System.TimeSpan offset)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x4CBCA10", Offset = "0x4CBB610", VA = "0x184CBCA10")]
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, System.TimeSpan offset)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x4CBCD30", Offset = "0x4CBB930", VA = "0x184CBCD30")]
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, System.TimeSpan offset)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x4CBCB00", Offset = "0x4CBB700", VA = "0x184CBCB00")]
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar, System.TimeSpan offset)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x17000080")]
		public static System.DateTimeOffset UtcNow
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x4CBD870", Offset = "0x4CBC470", VA = "0x184CBD870")]
			get
			{
				return default(System.DateTimeOffset);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x17000081")]
		public System.DateTime DateTime
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x4CBCFF0", Offset = "0x4CBBBF0", VA = "0x184CBCFF0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x17000082")]
		public System.DateTime UtcDateTime
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x4CBD7D0", Offset = "0x4CBC3D0", VA = "0x184CBD7D0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x17000083")]
		public System.DateTime LocalDateTime
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x4CBD1F0", Offset = "0x4CBBDF0", VA = "0x184CBD1F0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00006E58 File Offset: 0x00005058
		[Token(Token = "0x17000084")]
		private System.DateTime ClockDateTime
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x4CBCE10", Offset = "0x4CBBA10", VA = "0x184CBCE10")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x17000085")]
		public int Day
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x4CBD040", Offset = "0x4CBBC40", VA = "0x184CBD040")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x17000086")]
		public int Hour
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x4CBD100", Offset = "0x4CBBD00", VA = "0x184CBD100")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x17000087")]
		public int Millisecond
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x4CBD2A0", Offset = "0x4CBBEA0", VA = "0x184CBD2A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x17000088")]
		public int Minute
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x4CBD390", Offset = "0x4CBBF90", VA = "0x184CBD390")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x17000089")]
		public int Month
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x4CBD480", Offset = "0x4CBC080", VA = "0x184CBD480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x1700008A")]
		public System.TimeSpan Offset
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x4CBD540", Offset = "0x4CBC140", VA = "0x184CBD540")]
			get
			{
				return default(System.TimeSpan);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x1700008B")]
		public int Second
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x4CBD570", Offset = "0x4CBC170", VA = "0x184CBD570")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x1700008C")]
		public long Ticks
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x4CBD660", Offset = "0x4CBC260", VA = "0x184CBD660")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x1700008D")]
		public System.TimeSpan TimeOfDay
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x4CBD710", Offset = "0x4CBC310", VA = "0x184CBD710")]
			get
			{
				return default(System.TimeSpan);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x1700008E")]
		public int Year
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x4CBD920", Offset = "0x4CBC520", VA = "0x184CBD920")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x4CBAF10", Offset = "0x4CB9B10", VA = "0x184CBAF10", Slot = "4")]
		private int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x4CBA450", Offset = "0x4CB9050", VA = "0x184CBA450", Slot = "6")]
		public int CompareTo(System.DateTimeOffset other)
		{
			return 0;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x4CBA580", Offset = "0x4CB9180", VA = "0x184CBA580", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x4CBA720", Offset = "0x4CB9320", VA = "0x184CBA720", Slot = "7")]
		public bool Equals(System.DateTimeOffset other)
		{
			return default(bool);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x4CBA7F0", Offset = "0x4CB93F0", VA = "0x184CBA7F0")]
		public static System.DateTimeOffset FromFileTime(long fileTime)
		{
			return default(System.DateTimeOffset);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x4CBB080", Offset = "0x4CB9C80", VA = "0x184CBB080", Slot = "9")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x4CBB1A0", Offset = "0x4CB9DA0", VA = "0x184CBB1A0", Slot = "8")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x4CBC470", Offset = "0x4CBB070", VA = "0x184CBC470")]
		private DateTimeOffset(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x4CBA970", Offset = "0x4CB9570", VA = "0x184CBA970", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x4CBAE80", Offset = "0x4CB9A80", VA = "0x184CBAE80")]
		public static System.DateTimeOffset Parse(string input, System.IFormatProvider formatProvider)
		{
			return default(System.DateTimeOffset);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x4CBACA0", Offset = "0x4CB98A0", VA = "0x184CBACA0")]
		public static System.DateTimeOffset Parse(string input, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles)
		{
			return default(System.DateTimeOffset);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x4CBAA30", Offset = "0x4CB9630", VA = "0x184CBAA30")]
		public static System.DateTimeOffset ParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles)
		{
			return default(System.DateTimeOffset);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x4CBB270", Offset = "0x4CB9E70", VA = "0x184CBB270")]
		public long ToFileTime()
		{
			return 0L;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x4CBB7E0", Offset = "0x4CBA3E0", VA = "0x184CBB7E0")]
		public long ToUnixTimeSeconds()
		{
			return 0L;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x4CBB710", Offset = "0x4CBA310", VA = "0x184CBB710")]
		public long ToUnixTimeMilliseconds()
		{
			return 0L;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x4CBB440", Offset = "0x4CBA040", VA = "0x184CBB440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x4CBB500", Offset = "0x4CBA100", VA = "0x184CBB500")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x4CBB5D0", Offset = "0x4CBA1D0", VA = "0x184CBB5D0")]
		public string ToString(System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x4CBB360", Offset = "0x4CB9F60", VA = "0x184CBB360", Slot = "5")]
		public string ToString(string format, System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x4CBB8B0", Offset = "0x4CBA4B0", VA = "0x184CBB8B0", Slot = "10")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider formatProvider)
		{
			return default(bool);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x4CBB6A0", Offset = "0x4CBA2A0", VA = "0x184CBB6A0")]
		public System.DateTimeOffset ToUniversalTime()
		{
			return default(System.DateTimeOffset);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x4CBBC20", Offset = "0x4CBA820", VA = "0x184CBBC20")]
		public static bool TryParse(string input, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result)
		{
			return default(bool);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x4CBB9C0", Offset = "0x4CBA5C0", VA = "0x184CBB9C0")]
		public static bool TryParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result)
		{
			return default(bool);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x4CBBF60", Offset = "0x4CBAB60", VA = "0x184CBBF60")]
		private static short ValidateOffset(System.TimeSpan offset)
		{
			return 0;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x4CBBE10", Offset = "0x4CBAA10", VA = "0x184CBBE10")]
		private static System.DateTime ValidateDate(System.DateTime dateTime, System.TimeSpan offset)
		{
			return default(System.DateTime);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x4CBC0E0", Offset = "0x4CBACE0", VA = "0x184CBC0E0")]
		private static System.Globalization.DateTimeStyles ValidateStyles(System.Globalization.DateTimeStyles style, string parameterName)
		{
			return System.Globalization.DateTimeStyles.None;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00007128 File Offset: 0x00005328
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x4CBDAA0", Offset = "0x4CBC6A0", VA = "0x184CBDAA0")]
		public static implicit operator System.DateTimeOffset(System.DateTime dateTime)
		{
			return default(System.DateTimeOffset);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x4CBD9D0", Offset = "0x4CBC5D0", VA = "0x184CBD9D0")]
		public static bool operator ==(System.DateTimeOffset left, System.DateTimeOffset right)
		{
			return default(bool);
		}

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly System.DateTimeOffset MinValue;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly System.DateTimeOffset MaxValue;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly System.DateTimeOffset UnixEpoch;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly System.DateTime _dateTime;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly short _offsetMinutes;
	}
}
