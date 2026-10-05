using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200114C RID: 4428
	[Token(Token = "0x200114C")]
	public class ReturnCheckinGpRewardData
	{
		// Token: 0x06006F27 RID: 28455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F27")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReturnCheckinGpRewardData()
		{
		}

		// Token: 0x04005EE8 RID: 24296
		[Token(Token = "0x4005EE8")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005EE9 RID: 24297
		[Token(Token = "0x4005EE9")]
		[FieldOffset(Offset = "0x18")]
		public int getTime;

		// Token: 0x04005EEA RID: 24298
		[Token(Token = "0x4005EEA")]
		[FieldOffset(Offset = "0x20")]
		public string bindGPGoodId;

		// Token: 0x04005EEB RID: 24299
		[Token(Token = "0x4005EEB")]
		[FieldOffset(Offset = "0x28")]
		public int totalCheckInDay;

		// Token: 0x04005EEC RID: 24300
		[Token(Token = "0x4005EEC")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x04005EED RID: 24301
		[Token(Token = "0x4005EED")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<int, List<ReturnItemData>> rewardDict;
	}
}
