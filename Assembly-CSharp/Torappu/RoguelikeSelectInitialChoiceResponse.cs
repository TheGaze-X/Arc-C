using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007E3 RID: 2019
	[Token(Token = "0x20007E3")]
	public class RoguelikeSelectInitialChoiceResponse : PlayerDeltaResponse
	{
		// Token: 0x0600646E RID: 25710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeSelectInitialChoiceResponse()
		{
		}

		// Token: 0x04003106 RID: 12550
		[Token(Token = "0x4003106")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikeItemBundle> items;
	}
}
