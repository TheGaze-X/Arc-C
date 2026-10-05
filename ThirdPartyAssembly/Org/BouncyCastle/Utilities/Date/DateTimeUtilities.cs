using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Date
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public class DateTimeUtilities
	{
		// Token: 0x060007C7 RID: 1991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private DateTimeUtilities()
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x545B320", Offset = "0x5459F20", VA = "0x18545B320")]
		public static long DateTimeToUnixMs(DateTime dateTime)
		{
			return 0L;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x545B490", Offset = "0x545A090", VA = "0x18545B490")]
		public static DateTime UnixMsToDateTime(long unixMs)
		{
			return default(DateTime);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x545B150", Offset = "0x5459D50", VA = "0x18545B150")]
		public static long CurrentUnixMs()
		{
			return 0L;
		}

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DateTime UnixEpoch;
	}
}
