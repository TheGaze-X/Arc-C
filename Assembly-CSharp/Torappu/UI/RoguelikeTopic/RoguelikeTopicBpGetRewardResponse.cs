using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004556 RID: 17750
	[Token(Token = "0x2004556")]
	public class RoguelikeTopicBpGetRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0601B0AE RID: 110766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0AE")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeTopicBpGetRewardResponse()
		{
		}

		// Token: 0x04022BF9 RID: 142329
		[Token(Token = "0x4022BF9")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> items;
	}
}
