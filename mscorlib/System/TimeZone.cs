using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	[System.Obsolete("System.TimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo instead.")]
	[System.Serializable]
	public abstract class TimeZone
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000BF")]
		private static object InternalSyncObject
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x4D00B60", Offset = "0x4CFF760", VA = "0x184D00B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TimeZone()
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000C0")]
		public static System.TimeZone CurrentTimeZone
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x4D00970", Offset = "0x4CFF570", VA = "0x184D00970")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AA7 RID: 2727
		[Token(Token = "0x6000AA7")]
		public abstract System.TimeSpan GetUtcOffset(System.DateTime time);

		// Token: 0x06000AA8 RID: 2728
		[Token(Token = "0x6000AA8")]
		public abstract System.Globalization.DaylightTime GetDaylightChanges(int year);

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x4D006A0", Offset = "0x4CFF2A0", VA = "0x184D006A0")]
		internal static System.TimeSpan CalculateUtcOffset(System.DateTime time, System.Globalization.DaylightTime daylightTimes)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x0")]
		private static System.TimeZone currentTimeZone;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x8")]
		private static object s_InternalSyncObject;
	}
}
