using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x20007E7")]
	public class RoguelikeSelectInitialRecruitResponse : PlayerDeltaResponse
	{
		// Token: 0x06006472 RID: 25714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006472")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeSelectInitialRecruitResponse()
		{
		}

		// Token: 0x04003109 RID: 12553
		[Token(Token = "0x4003109")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikeItemBundle> items;
	}
}
