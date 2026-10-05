using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005559 RID: 21849
	[Token(Token = "0x2005559")]
	public class RoguelikeRedrawCopperResponse : PlayerDeltaResponse
	{
		// Token: 0x060201F7 RID: 131575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201F7")]
		[Address(RVA = "0x1A3A9D0", Offset = "0x1A395D0", VA = "0x181A3A9D0")]
		public RoguelikeRedrawCopperResponse()
		{
		}

		// Token: 0x0402B656 RID: 177750
		[Token(Token = "0x402B656")]
		[FieldOffset(Offset = "0x28")]
		public List<string> copper;

		// Token: 0x0402B657 RID: 177751
		[Token(Token = "0x402B657")]
		[FieldOffset(Offset = "0x30")]
		public string divineEventId;

		// Token: 0x0402B658 RID: 177752
		[Token(Token = "0x402B658")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, int> hitReason;

		// Token: 0x0402B659 RID: 177753
		[Token(Token = "0x402B659")]
		[FieldOffset(Offset = "0x40")]
		public List<PlayerRoguelikePendingEvent.CopperExchangeInfo> exchangeInfo;
	}
}
