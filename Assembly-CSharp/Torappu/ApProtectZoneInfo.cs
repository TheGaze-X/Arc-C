using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001367 RID: 4967
	[Token(Token = "0x2001367")]
	[Serializable]
	public class ApProtectZoneInfo
	{
		// Token: 0x06007330 RID: 29488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007330")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ApProtectZoneInfo()
		{
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007331")]
		[Address(RVA = "0x21FECC0", Offset = "0x21FD8C0", VA = "0x1821FECC0")]
		public ApProtectZoneInfo(string zoneId, long startTs, long endTs)
		{
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007332")]
		[Address(RVA = "0x21FEBD0", Offset = "0x21FD7D0", VA = "0x1821FEBD0")]
		public void AddTimeRange(long startTs, long endTs)
		{
		}

		// Token: 0x04006E2C RID: 28204
		[Token(Token = "0x4006E2C")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x04006E2D RID: 28205
		[Token(Token = "0x4006E2D")]
		[FieldOffset(Offset = "0x18")]
		public List<ApProtectZoneInfo.TimeRange> timeRanges;

		// Token: 0x02001368 RID: 4968
		[Token(Token = "0x2001368")]
		public class TimeRange : ITimeValidInfo
		{
			// Token: 0x06007333 RID: 29491 RVA: 0x00033258 File Offset: 0x00031458
			[Token(Token = "0x6007333")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			public long GetEndTs()
			{
				return 0L;
			}

			// Token: 0x06007334 RID: 29492 RVA: 0x00033270 File Offset: 0x00031470
			[Token(Token = "0x6007334")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public long GetStartTs()
			{
				return 0L;
			}

			// Token: 0x06007335 RID: 29493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007335")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TimeRange()
			{
			}

			// Token: 0x04006E2E RID: 28206
			[Token(Token = "0x4006E2E")]
			[FieldOffset(Offset = "0x10")]
			public long startTs;

			// Token: 0x04006E2F RID: 28207
			[Token(Token = "0x4006E2F")]
			[FieldOffset(Offset = "0x18")]
			public long endTs;
		}
	}
}
