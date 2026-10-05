using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000766 RID: 1894
	[Token(Token = "0x2000766")]
	public class HandBookUnlockStoryCharBuildResponse : PlayerDeltaResponse
	{
		// Token: 0x060063D4 RID: 25556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D4")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public HandBookUnlockStoryCharBuildResponse()
		{
		}

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0x28")]
		public List<HandBookMissionReward> rewards;
	}
}
