using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A65 RID: 2661
	[Token(Token = "0x2000A65")]
	public class PlayerBuildingMessageLeaveSP
	{
		// Token: 0x06006724 RID: 26404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006724")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingMessageLeaveSP()
		{
		}

		// Token: 0x04003889 RID: 14473
		[Token(Token = "0x4003889")]
		[FieldOffset(Offset = "0x10")]
		public int lastWeek;

		// Token: 0x0400388A RID: 14474
		[Token(Token = "0x400388A")]
		[FieldOffset(Offset = "0x14")]
		public int lastWeekSum;

		// Token: 0x0400388B RID: 14475
		[Token(Token = "0x400388B")]
		[FieldOffset(Offset = "0x18")]
		public int thisWeek;

		// Token: 0x0400388C RID: 14476
		[Token(Token = "0x400388C")]
		[FieldOffset(Offset = "0x1C")]
		public int thisWeekSum;
	}
}
