using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F8C RID: 3980
	[Token(Token = "0x2000F8C")]
	public class MonthlyDailyBonusGroup
	{
		// Token: 0x06006CCE RID: 27854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MonthlyDailyBonusGroup()
		{
		}

		// Token: 0x0400548B RID: 21643
		[Token(Token = "0x400548B")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0400548C RID: 21644
		[Token(Token = "0x400548C")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x0400548D RID: 21645
		[Token(Token = "0x400548D")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x0400548E RID: 21646
		[Token(Token = "0x400548E")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle[] items;

		// Token: 0x0400548F RID: 21647
		[Token(Token = "0x400548F")]
		[FieldOffset(Offset = "0x30")]
		public string imgId;

		// Token: 0x04005490 RID: 21648
		[Token(Token = "0x4005490")]
		[FieldOffset(Offset = "0x38")]
		public string backId;
	}
}
