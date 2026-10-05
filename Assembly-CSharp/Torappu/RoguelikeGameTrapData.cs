using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001225 RID: 4645
	[Token(Token = "0x2001225")]
	public class RoguelikeGameTrapData
	{
		// Token: 0x06007023 RID: 28707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007023")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameTrapData()
		{
		}

		// Token: 0x0400644F RID: 25679
		[Token(Token = "0x400644F")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04006450 RID: 25680
		[Token(Token = "0x4006450")]
		[FieldOffset(Offset = "0x18")]
		public string trapId;

		// Token: 0x04006451 RID: 25681
		[Token(Token = "0x4006451")]
		[FieldOffset(Offset = "0x20")]
		public string trapDesc;
	}
}
