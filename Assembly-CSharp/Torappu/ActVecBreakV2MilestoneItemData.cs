using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E67 RID: 3687
	[Token(Token = "0x2000E67")]
	public class ActVecBreakV2MilestoneItemData
	{
		// Token: 0x06006B36 RID: 27446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B36")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2MilestoneItemData()
		{
		}

		// Token: 0x04004D2A RID: 19754
		[Token(Token = "0x4004D2A")]
		[FieldOffset(Offset = "0x10")]
		public string milestoneId;

		// Token: 0x04004D2B RID: 19755
		[Token(Token = "0x4004D2B")]
		[FieldOffset(Offset = "0x18")]
		public int orderId;

		// Token: 0x04004D2C RID: 19756
		[Token(Token = "0x4004D2C")]
		[FieldOffset(Offset = "0x1C")]
		public int tokenNum;

		// Token: 0x04004D2D RID: 19757
		[Token(Token = "0x4004D2D")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle reward;

		// Token: 0x04004D2E RID: 19758
		[Token(Token = "0x4004D2E")]
		[FieldOffset(Offset = "0x28")]
		public long availTime;
	}
}
