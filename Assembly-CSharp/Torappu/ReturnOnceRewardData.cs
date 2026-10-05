using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001140 RID: 4416
	[Token(Token = "0x2001140")]
	public class ReturnOnceRewardData
	{
		// Token: 0x06006F16 RID: 28438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F16")]
		[Address(RVA = "0x210FF90", Offset = "0x210EB90", VA = "0x18210FF90")]
		public ReturnOnceRewardData()
		{
		}

		// Token: 0x04005EB2 RID: 24242
		[Token(Token = "0x4005EB2")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005EB3 RID: 24243
		[Token(Token = "0x4005EB3")]
		[FieldOffset(Offset = "0x18")]
		public List<ReturnItemData> rewardList;
	}
}
