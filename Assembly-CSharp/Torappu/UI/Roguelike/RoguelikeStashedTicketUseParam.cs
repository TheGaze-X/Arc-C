using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200553C RID: 21820
	[Token(Token = "0x200553C")]
	public struct RoguelikeStashedTicketUseParam
	{
		// Token: 0x0402B575 RID: 177525
		[Token(Token = "0x402B575")]
		[FieldOffset(Offset = "0x0")]
		public RoguelikeStashedTicketUseDesParam desParam;

		// Token: 0x0402B576 RID: 177526
		[Token(Token = "0x402B576")]
		[FieldOffset(Offset = "0x8")]
		public List<IRoguelikeStashedTicketItemViewModel> stashedTicketList;

		// Token: 0x0402B577 RID: 177527
		[Token(Token = "0x402B577")]
		[FieldOffset(Offset = "0x0")]
		public static RoguelikeStashedTicketUseParam EMPTY;
	}
}
