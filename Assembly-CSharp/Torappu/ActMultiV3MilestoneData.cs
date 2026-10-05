using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E4E RID: 3662
	[Token(Token = "0x2000E4E")]
	public class ActMultiV3MilestoneData
	{
		// Token: 0x06006B1C RID: 27420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3MilestoneData()
		{
		}

		// Token: 0x04004C3D RID: 19517
		[Token(Token = "0x4004C3D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004C3E RID: 19518
		[Token(Token = "0x4004C3E")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04004C3F RID: 19519
		[Token(Token = "0x4004C3F")]
		[FieldOffset(Offset = "0x1C")]
		public int needPointCnt;

		// Token: 0x04004C40 RID: 19520
		[Token(Token = "0x4004C40")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle rewardItem;

		// Token: 0x04004C41 RID: 19521
		[Token(Token = "0x4004C41")]
		[FieldOffset(Offset = "0x28")]
		public long availTime;
	}
}
