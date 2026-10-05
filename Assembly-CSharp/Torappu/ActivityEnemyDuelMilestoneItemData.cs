using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DFC RID: 3580
	[Token(Token = "0x2000DFC")]
	public class ActivityEnemyDuelMilestoneItemData
	{
		// Token: 0x06006ACD RID: 27341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelMilestoneItemData()
		{
		}

		// Token: 0x04004A3F RID: 19007
		[Token(Token = "0x4004A3F")]
		[FieldOffset(Offset = "0x10")]
		public string milestoneId;

		// Token: 0x04004A40 RID: 19008
		[Token(Token = "0x4004A40")]
		[FieldOffset(Offset = "0x18")]
		public int orderId;

		// Token: 0x04004A41 RID: 19009
		[Token(Token = "0x4004A41")]
		[FieldOffset(Offset = "0x1C")]
		public int tokenNum;

		// Token: 0x04004A42 RID: 19010
		[Token(Token = "0x4004A42")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle reward;

		// Token: 0x04004A43 RID: 19011
		[Token(Token = "0x4004A43")]
		[FieldOffset(Offset = "0x28")]
		public long availTime;
	}
}
