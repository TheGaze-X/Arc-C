using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200138D RID: 5005
	[Token(Token = "0x200138D")]
	[Serializable]
	public class TrainingCampConsts
	{
		// Token: 0x0600736C RID: 29548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TrainingCampConsts()
		{
		}

		// Token: 0x04006F27 RID: 28455
		[Token(Token = "0x4006F27")]
		[FieldOffset(Offset = "0x10")]
		public string unlockStageId;

		// Token: 0x04006F28 RID: 28456
		[Token(Token = "0x4006F28")]
		[FieldOffset(Offset = "0x18")]
		public string updateDesc;

		// Token: 0x04006F29 RID: 28457
		[Token(Token = "0x4006F29")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle rewardItem;
	}
}
