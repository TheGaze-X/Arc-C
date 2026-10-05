using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012F5 RID: 4853
	[Token(Token = "0x20012F5")]
	public class SandboxV2ChallengeModeRewardData
	{
		// Token: 0x0600726E RID: 29294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ChallengeModeRewardData()
		{
		}

		// Token: 0x04006B46 RID: 27462
		[Token(Token = "0x4006B46")]
		[FieldOffset(Offset = "0x10")]
		public string rewardId;

		// Token: 0x04006B47 RID: 27463
		[Token(Token = "0x4006B47")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04006B48 RID: 27464
		[Token(Token = "0x4006B48")]
		[FieldOffset(Offset = "0x1C")]
		public int rewardDay;

		// Token: 0x04006B49 RID: 27465
		[Token(Token = "0x4006B49")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemBundle> rewardItemList;
	}
}
