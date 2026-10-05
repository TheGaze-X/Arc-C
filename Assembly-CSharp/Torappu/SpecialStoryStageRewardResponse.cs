using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008A5 RID: 2213
	[Token(Token = "0x20008A5")]
	public class SpecialStoryStageRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06006544 RID: 25924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006544")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SpecialStoryStageRewardResponse()
		{
		}

		// Token: 0x0400326C RID: 12908
		[Token(Token = "0x400326C")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> rewards;
	}
}
