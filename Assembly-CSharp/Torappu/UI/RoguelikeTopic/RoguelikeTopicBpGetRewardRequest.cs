using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004555 RID: 17749
	[Token(Token = "0x2004555")]
	public class RoguelikeTopicBpGetRewardRequest
	{
		// Token: 0x0601B0AD RID: 110765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0AD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicBpGetRewardRequest()
		{
		}

		// Token: 0x04022BF7 RID: 142327
		[Token(Token = "0x4022BF7")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x04022BF8 RID: 142328
		[Token(Token = "0x4022BF8")]
		[FieldOffset(Offset = "0x18")]
		public List<string> rewards;
	}
}
