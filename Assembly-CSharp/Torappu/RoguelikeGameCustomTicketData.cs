using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200122C RID: 4652
	[Token(Token = "0x200122C")]
	public class RoguelikeGameCustomTicketData
	{
		// Token: 0x0600702B RID: 28715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameCustomTicketData()
		{
		}

		// Token: 0x04006478 RID: 25720
		[Token(Token = "0x4006478")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006479 RID: 25721
		[Token(Token = "0x4006479")]
		[FieldOffset(Offset = "0x18")]
		public CustomTicketType subType;

		// Token: 0x0400647A RID: 25722
		[Token(Token = "0x400647A")]
		[FieldOffset(Offset = "0x20")]
		public string discardText;
	}
}
