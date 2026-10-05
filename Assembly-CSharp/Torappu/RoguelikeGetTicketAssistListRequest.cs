using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	public class RoguelikeGetTicketAssistListRequest
	{
		// Token: 0x0600649A RID: 25754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGetTicketAssistListRequest()
		{
		}

		// Token: 0x0400311A RID: 12570
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0x10")]
		public string ticketIndex;

		// Token: 0x0400311B RID: 12571
		[Token(Token = "0x400311B")]
		[FieldOffset(Offset = "0x18")]
		public string profession;
	}
}
