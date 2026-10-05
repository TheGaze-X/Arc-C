using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007F8 RID: 2040
	[Token(Token = "0x20007F8")]
	public class RoguelikeSelectChoiceResponse : PlayerDeltaResponse
	{
		// Token: 0x06006483 RID: 25731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006483")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeSelectChoiceResponse()
		{
		}

		// Token: 0x04003112 RID: 12562
		[Token(Token = "0x4003112")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikeItemBundle> items;
	}
}
