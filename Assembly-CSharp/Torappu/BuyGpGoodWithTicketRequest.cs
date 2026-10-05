using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000849 RID: 2121
	[Token(Token = "0x2000849")]
	public class BuyGpGoodWithTicketRequest
	{
		// Token: 0x060064E0 RID: 25824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuyGpGoodWithTicketRequest()
		{
		}

		// Token: 0x04003155 RID: 12629
		[Token(Token = "0x4003155")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003156 RID: 12630
		[Token(Token = "0x4003156")]
		[FieldOffset(Offset = "0x18")]
		public string ticketId;
	}
}
