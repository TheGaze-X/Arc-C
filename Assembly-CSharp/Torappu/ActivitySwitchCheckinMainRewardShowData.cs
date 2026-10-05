using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E2B RID: 3627
	[Token(Token = "0x2000E2B")]
	public class ActivitySwitchCheckinMainRewardShowData
	{
		// Token: 0x06006AFF RID: 27391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivitySwitchCheckinMainRewardShowData()
		{
		}

		// Token: 0x04004B83 RID: 19331
		[Token(Token = "0x4004B83")]
		[FieldOffset(Offset = "0x10")]
		public string mainRewardPicId;

		// Token: 0x04004B84 RID: 19332
		[Token(Token = "0x4004B84")]
		[FieldOffset(Offset = "0x18")]
		public string mainRewardName;

		// Token: 0x04004B85 RID: 19333
		[Token(Token = "0x4004B85")]
		[FieldOffset(Offset = "0x20")]
		public int mainRewardCount;

		// Token: 0x04004B86 RID: 19334
		[Token(Token = "0x4004B86")]
		[FieldOffset(Offset = "0x24")]
		public bool hasTip;

		// Token: 0x04004B87 RID: 19335
		[Token(Token = "0x4004B87")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle tipItemBundle;
	}
}
