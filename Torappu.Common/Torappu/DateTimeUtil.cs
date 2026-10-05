using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public static class DateTimeUtil
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x54DE9F0", Offset = "0x54DD5F0", VA = "0x1854DE9F0")]
		public static DateTime TimeStampToDateTime(long timeStamp)
		{
			return default(DateTime);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x54DDCA0", Offset = "0x54DC8A0", VA = "0x1854DDCA0")]
		public static long DateTimeToTimeStamp(DateTime dateTime)
		{
			return 0L;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x54DE980", Offset = "0x54DD580", VA = "0x1854DE980")]
		public static void SyncTime(long serverTs)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x54DE210", Offset = "0x54DCE10", VA = "0x1854DE210")]
		public static int GetUTCBiasHours()
		{
			return 0;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x1700001D")]
		public static DateTime currentTime
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x54DEE10", Offset = "0x54DDA10", VA = "0x1854DEE10")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x1700001E")]
		public static long timeStampNow
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x54DEF80", Offset = "0x54DDB80", VA = "0x1854DEF80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x54DEB50", Offset = "0x54DD750", VA = "0x1854DEB50")]
		private static DateTime _CurrentTimeWithServerBias()
		{
			return default(DateTime);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x54DEAA0", Offset = "0x54DD6A0", VA = "0x1854DEAA0")]
		private static DateTime _CurrentTimeDeviceUTC8()
		{
			return default(DateTime);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x54DE100", Offset = "0x54DCD00", VA = "0x1854DE100")]
		public static DateTime GetCurrentDeviceTime()
		{
			return default(DateTime);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x54DE220", Offset = "0x54DCE20", VA = "0x1854DE220")]
		public static bool IsSameDay(DateTime d1, DateTime d2)
		{
			return default(bool);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x54DE560", Offset = "0x54DD160", VA = "0x1854DE560")]
		public static bool IsSameWeek(DateTime d1, DateTime d2)
		{
			return default(bool);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x54DEBF0", Offset = "0x54DD7F0", VA = "0x1854DEBF0")]
		private static bool _InternalIsSameWeek(DateTime bigDateTime, DateTime smallDateTime)
		{
			return default(bool);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x54DDA20", Offset = "0x54DC620", VA = "0x1854DDA20")]
		public static void CalcDeltaGameDay(in DateTime d1, in DateTime d2, out int deltaDay, out int deltaDayInSameYear)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x54DDD60", Offset = "0x54DC960", VA = "0x1854DDD60")]
		public static int DeltaDayInSameYear(in DateTime d1, in DateTime d2)
		{
			return 0;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x54DDDE0", Offset = "0x54DC9E0", VA = "0x1854DDDE0")]
		public static int DeltaNatureDays(DateTime lhs, DateTime rhs)
		{
			return 0;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x54DE4C0", Offset = "0x54DD0C0", VA = "0x1854DE4C0")]
		public static bool IsSameNatureDay(DateTime d1, DateTime d2)
		{
			return default(bool);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x54DE140", Offset = "0x54DCD40", VA = "0x1854DE140")]
		public static DateTime GetNextCrossDayTime(DateTime fromTime)
		{
			return default(DateTime);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x54DE000", Offset = "0x54DCC00", VA = "0x1854DE000")]
		public static DateTime GetCurrentCrossDayTime(DateTime fromTime)
		{
			return default(DateTime);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x54DE8C0", Offset = "0x54DD4C0", VA = "0x1854DE8C0")]
		public static DateTime Min(DateTime d1, DateTime d2)
		{
			return default(DateTime);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x54DE920", Offset = "0x54DD520", VA = "0x1854DE920")]
		public static void SetTimeBiasForTestEnv(long biasSeconds)
		{
		}

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DateTime EMPTY_DATETIME;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		private const int UTC_BIAS_HOURS = 8;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		private const long SECS_PER_DAY = 86400L;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x8")]
		private static readonly DateTime START_TIME;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x10")]
		private static long s_testTimeBias;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x18")]
		private static long s_serverTimeBias;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x20")]
		private static OneFrameCache<DateTime> s_curTimeCache;
	}
}
