using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public class DateUtils
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x5C09DE0", Offset = "0x5C089E0", VA = "0x185C09DE0")]
		public static long GetCurTimeStamp()
		{
			return 0L;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x5C0A1C0", Offset = "0x5C08DC0", VA = "0x185C0A1C0")]
		public static DateTime TimestampToDateTime(double timestamp)
		{
			return default(DateTime);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x5C09EF0", Offset = "0x5C08AF0", VA = "0x185C09EF0")]
		public static string GetLoginTime(long timeLastLogin)
		{
			return null;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DateUtils()
		{
		}

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		public const long TAG_YEAR = 31536000000L;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		public const long TAG_DAY = 86400000L;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		public const long TAG_HOUR = 3600000L;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		public const long TAG_MINUTE = 60000L;
	}
}
