using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004546 RID: 17734
	[Token(Token = "0x2004546")]
	public class RoguelikeTopicBattlePassPurchaseResponse : PlayerDeltaResponse
	{
		// Token: 0x0601B09E RID: 110750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B09E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeTopicBattlePassPurchaseResponse()
		{
		}

		// Token: 0x04022BB5 RID: 142261
		[Token(Token = "0x4022BB5")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> items;
	}
}
