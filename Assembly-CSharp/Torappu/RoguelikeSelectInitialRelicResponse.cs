using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007E1 RID: 2017
	[Token(Token = "0x20007E1")]
	public class RoguelikeSelectInitialRelicResponse : PlayerDeltaResponse
	{
		// Token: 0x0600646C RID: 25708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeSelectInitialRelicResponse()
		{
		}

		// Token: 0x04003104 RID: 12548
		[Token(Token = "0x4003104")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikeItemBundle> items;
	}
}
