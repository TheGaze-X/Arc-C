using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	[System.Serializable]
	public readonly struct TimeSpan : System.IComparable, System.IComparable<System.TimeSpan>, System.IEquatable<System.TimeSpan>, System.IFormattable, ISpanFormattable
	{
		// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public TimeSpan(long ticks)
		{
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x4D00060", Offset = "0x4CFEC60", VA = "0x184D00060")]
		public TimeSpan(int hours, int minutes, int seconds)
		{
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x4CFFFA0", Offset = "0x4CFEBA0", VA = "0x184CFFFA0")]
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[Token(Token = "0x170000B4")]
		public long Ticks
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x170000B5")]
		public int Days
		{
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x4D00150", Offset = "0x4CFED50", VA = "0x184D00150")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[Token(Token = "0x170000B6")]
		public int Hours
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x4D00170", Offset = "0x4CFED70", VA = "0x184D00170")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x170000B7")]
		public int Milliseconds
		{
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x4D001B0", Offset = "0x4CFEDB0", VA = "0x184D001B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x170000B8")]
		public int Minutes
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x4D00200", Offset = "0x4CFEE00", VA = "0x184D00200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x170000B9")]
		public int Seconds
		{
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x4D00250", Offset = "0x4CFEE50", VA = "0x184D00250")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x170000BA")]
		public double TotalDays
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x4D002A0", Offset = "0x4CFEEA0", VA = "0x184D002A0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x170000BB")]
		public double TotalHours
		{
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x4D002C0", Offset = "0x4CFEEC0", VA = "0x184D002C0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x170000BC")]
		public double TotalMilliseconds
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x4D002E0", Offset = "0x4CFEEE0", VA = "0x184D002E0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x170000BD")]
		public double TotalMinutes
		{
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x4D00310", Offset = "0x4CFEF10", VA = "0x184D00310")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x170000BE")]
		public double TotalSeconds
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x4D00330", Offset = "0x4CFEF30", VA = "0x184D00330")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x4CFF3E0", Offset = "0x4CFDFE0", VA = "0x184CFF3E0")]
		public System.TimeSpan Add(System.TimeSpan ts)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x4CFF580", Offset = "0x4CFE180", VA = "0x184CFF580")]
		public static int Compare(System.TimeSpan t1, System.TimeSpan t2)
		{
			return 0;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x4CFF490", Offset = "0x4CFE090", VA = "0x184CFF490", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x4CFF470", Offset = "0x4CFE070", VA = "0x184CFF470", Slot = "5")]
		public int CompareTo(System.TimeSpan value)
		{
			return 0;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x4CFF6E0", Offset = "0x4CFE2E0", VA = "0x184CFF6E0")]
		public static System.TimeSpan FromDays(double value)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x4CFF5A0", Offset = "0x4CFE1A0", VA = "0x184CFF5A0")]
		public System.TimeSpan Duration()
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x4CFF650", Offset = "0x4CFE250", VA = "0x184CFF650", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "6")]
		public bool Equals(System.TimeSpan obj)
		{
			return default(bool);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x4CDA0D0", Offset = "0x4CD8CD0", VA = "0x184CDA0D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x4CFF740", Offset = "0x4CFE340", VA = "0x184CFF740")]
		public static System.TimeSpan FromHours(double value)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x4CFF8C0", Offset = "0x4CFE4C0", VA = "0x184CFF8C0")]
		private static System.TimeSpan Interval(double value, int scale)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x4CFF7A0", Offset = "0x4CFE3A0", VA = "0x184CFF7A0")]
		public static System.TimeSpan FromMilliseconds(double value)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x4CFF800", Offset = "0x4CFE400", VA = "0x184CFF800")]
		public static System.TimeSpan FromMinutes(double value)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x4CFFA30", Offset = "0x4CFE630", VA = "0x184CFFA30")]
		public System.TimeSpan Negate()
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x4CFF860", Offset = "0x4CFE460", VA = "0x184CFF860")]
		public static System.TimeSpan FromSeconds(double value)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x4CFFBE0", Offset = "0x4CFE7E0", VA = "0x184CFFBE0")]
		public System.TimeSpan Subtract(System.TimeSpan ts)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static System.TimeSpan FromTicks(long value)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x4CFFC70", Offset = "0x4CFE870", VA = "0x184CFFC70")]
		internal static long TimeToTicks(int hour, int minute, int second)
		{
			return 0L;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x4CFFB60", Offset = "0x4CFE760", VA = "0x184CFFB60")]
		public static System.TimeSpan Parse(string s)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x4CFFAE0", Offset = "0x4CFE6E0", VA = "0x184CFFAE0")]
		public static System.TimeSpan Parse(string input, System.IFormatProvider formatProvider)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x4CFFE90", Offset = "0x4CFEA90", VA = "0x184CFFE90")]
		public static bool TryParse(string s, out System.TimeSpan result)
		{
			return default(bool);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x4CFFD10", Offset = "0x4CFE910", VA = "0x184CFFD10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x4CFFD70", Offset = "0x4CFE970", VA = "0x184CFFD70", Slot = "7")]
		public string ToString(string format, System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x4CFFDE0", Offset = "0x4CFE9E0", VA = "0x184CFFDE0", Slot = "8")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider formatProvider)
		{
			return default(bool);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x4D00520", Offset = "0x4CFF120", VA = "0x184D00520")]
		public static System.TimeSpan operator -(System.TimeSpan t)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x4D00460", Offset = "0x4CFF060", VA = "0x184D00460")]
		public static System.TimeSpan operator -(System.TimeSpan t1, System.TimeSpan t2)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x4D00350", Offset = "0x4CFEF50", VA = "0x184D00350")]
		public static System.TimeSpan operator +(System.TimeSpan t1, System.TimeSpan t2)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(System.TimeSpan t1, System.TimeSpan t2)
		{
			return default(bool);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(System.TimeSpan t1, System.TimeSpan t2)
		{
			return default(bool);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x4D00450", Offset = "0x4CFF050", VA = "0x184D00450")]
		public static bool operator <(System.TimeSpan t1, System.TimeSpan t2)
		{
			return default(bool);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x4D00440", Offset = "0x4CFF040", VA = "0x184D00440")]
		public static bool operator <=(System.TimeSpan t1, System.TimeSpan t2)
		{
			return default(bool);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x4D00420", Offset = "0x4CFF020", VA = "0x184D00420")]
		public static bool operator >(System.TimeSpan t1, System.TimeSpan t2)
		{
			return default(bool);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x4D00410", Offset = "0x4CFF010", VA = "0x184D00410")]
		public static bool operator >=(System.TimeSpan t1, System.TimeSpan t2)
		{
			return default(bool);
		}

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		public const long TicksPerMillisecond = 10000L;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		private const double MillisecondsPerTick = 0.0001;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		public const long TicksPerSecond = 10000000L;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		private const double SecondsPerTick = 1E-07;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		public const long TicksPerMinute = 600000000L;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		private const double MinutesPerTick = 1.6666666666666667E-09;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		public const long TicksPerHour = 36000000000L;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		private const double HoursPerTick = 2.7777777777777777E-11;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		public const long TicksPerDay = 864000000000L;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		private const double DaysPerTick = 1.1574074074074074E-12;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		private const int MillisPerSecond = 1000;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		private const int MillisPerMinute = 60000;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		private const int MillisPerHour = 3600000;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		private const int MillisPerDay = 86400000;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		internal const long MaxSeconds = 922337203685L;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		internal const long MinSeconds = -922337203685L;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		internal const long MaxMilliSeconds = 922337203685477L;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		internal const long MinMilliSeconds = -922337203685477L;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		internal const long TicksPerTenthSecond = 1000000L;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly System.TimeSpan Zero;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly System.TimeSpan MaxValue;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly System.TimeSpan MinValue;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly long _ticks;
	}
}
