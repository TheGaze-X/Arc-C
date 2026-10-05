using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E30 RID: 3632
	[Token(Token = "0x2000E30")]
	public class ActMainlineBpExtraData
	{
		// Token: 0x06006B04 RID: 27396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B04")]
		[Address(RVA = "0x1FF9DD0", Offset = "0x1FF89D0", VA = "0x181FF9DD0")]
		public ActMainlineBpExtraData()
		{
		}

		// Token: 0x04004B98 RID: 19352
		[Token(Token = "0x4004B98")]
		[FieldOffset(Offset = "0x10")]
		public List<ActMainlineBpExtraData.ActMainlineBpExtraPeriodData> periodDataList;

		// Token: 0x02000E31 RID: 3633
		[Token(Token = "0x2000E31")]
		public class ActMainlineBpExtraPeriodData : IComparable
		{
			// Token: 0x06006B05 RID: 27397 RVA: 0x00031218 File Offset: 0x0002F418
			[Token(Token = "0x6006B05")]
			[Address(RVA = "0x1FF9E60", Offset = "0x1FF8A60", VA = "0x181FF9E60", Slot = "4")]
			public int CompareTo(object obj)
			{
				return 0;
			}

			// Token: 0x06006B06 RID: 27398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B06")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActMainlineBpExtraPeriodData()
			{
			}

			// Token: 0x04004B99 RID: 19353
			[Token(Token = "0x4004B99")]
			[FieldOffset(Offset = "0x10")]
			public string periodId;

			// Token: 0x04004B9A RID: 19354
			[Token(Token = "0x4004B9A")]
			[FieldOffset(Offset = "0x18")]
			public long startTs;

			// Token: 0x04004B9B RID: 19355
			[Token(Token = "0x4004B9B")]
			[FieldOffset(Offset = "0x20")]
			public long endTs;
		}
	}
}
