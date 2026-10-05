using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E2E RID: 3630
	[Token(Token = "0x2000E2E")]
	public class ActivityYear5GeneralUnlimitedApRewardData
	{
		// Token: 0x06006B02 RID: 27394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B02")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityYear5GeneralUnlimitedApRewardData()
		{
		}

		// Token: 0x04004B8C RID: 19340
		[Token(Token = "0x4004B8C")]
		[FieldOffset(Offset = "0x10")]
		public int rewardIndex;

		// Token: 0x04004B8D RID: 19341
		[Token(Token = "0x4004B8D")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle rewardItem;
	}
}
