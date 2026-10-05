using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074C7 RID: 29895
	[Token(Token = "0x20074C7")]
	public class Act25sideDailyHarvestResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A299 RID: 172697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A299")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act25sideDailyHarvestResponse()
		{
		}

		// Token: 0x0403C90A RID: 248074
		[Token(Token = "0x403C90A")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;

		// Token: 0x0403C90B RID: 248075
		[Token(Token = "0x403C90B")]
		[FieldOffset(Offset = "0x30")]
		public List<RewardItemModel> additionalItems;
	}
}
