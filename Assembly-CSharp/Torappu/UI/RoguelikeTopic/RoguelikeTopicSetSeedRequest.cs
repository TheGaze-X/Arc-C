using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004557 RID: 17751
	[Token(Token = "0x2004557")]
	public class RoguelikeTopicSetSeedRequest
	{
		// Token: 0x0601B0AF RID: 110767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0AF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicSetSeedRequest()
		{
		}

		// Token: 0x04022BFA RID: 142330
		[Token(Token = "0x4022BFA")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x04022BFB RID: 142331
		[Token(Token = "0x4022BFB")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;

		// Token: 0x04022BFC RID: 142332
		[Token(Token = "0x4022BFC")]
		[FieldOffset(Offset = "0x20")]
		public string seed;
	}
}
