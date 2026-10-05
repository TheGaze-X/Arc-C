using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E2C RID: 3628
	[Token(Token = "0x2000E2C")]
	public class ActivitySwitchCheckinRewardItemShowData
	{
		// Token: 0x06006B00 RID: 27392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B00")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivitySwitchCheckinRewardItemShowData()
		{
		}

		// Token: 0x04004B88 RID: 19336
		[Token(Token = "0x4004B88")]
		[FieldOffset(Offset = "0x10")]
		public ItemBundle itemBundle;

		// Token: 0x04004B89 RID: 19337
		[Token(Token = "0x4004B89")]
		[FieldOffset(Offset = "0x18")]
		public bool isMainReward;
	}
}
