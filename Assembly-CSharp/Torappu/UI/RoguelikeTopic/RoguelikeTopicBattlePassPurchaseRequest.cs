using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004545 RID: 17733
	[Token(Token = "0x2004545")]
	public class RoguelikeTopicBattlePassPurchaseRequest
	{
		// Token: 0x0601B09D RID: 110749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B09D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicBattlePassPurchaseRequest()
		{
		}

		// Token: 0x04022BB2 RID: 142258
		[Token(Token = "0x4022BB2")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x04022BB3 RID: 142259
		[Token(Token = "0x4022BB3")]
		[FieldOffset(Offset = "0x18")]
		public string reward;

		// Token: 0x04022BB4 RID: 142260
		[Token(Token = "0x4022BB4")]
		[FieldOffset(Offset = "0x20")]
		public int cost;
	}
}
