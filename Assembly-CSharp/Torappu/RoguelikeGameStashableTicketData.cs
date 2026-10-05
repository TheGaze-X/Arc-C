using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200122D RID: 4653
	[Token(Token = "0x200122D")]
	public class RoguelikeGameStashableTicketData
	{
		// Token: 0x0600702C RID: 28716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameStashableTicketData()
		{
		}

		// Token: 0x0400647B RID: 25723
		[Token(Token = "0x400647B")]
		[FieldOffset(Offset = "0x10")]
		public string ticketId;

		// Token: 0x0400647C RID: 25724
		[Token(Token = "0x400647C")]
		[FieldOffset(Offset = "0x18")]
		public string stashedTicketId;
	}
}
