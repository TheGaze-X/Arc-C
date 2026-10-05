using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004541 RID: 17729
	[Token(Token = "0x2004541")]
	public class RoguelikeTopicUnlockBuffRequest
	{
		// Token: 0x0601B099 RID: 110745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B099")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicUnlockBuffRequest()
		{
		}

		// Token: 0x04022BAE RID: 142254
		[Token(Token = "0x4022BAE")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x04022BAF RID: 142255
		[Token(Token = "0x4022BAF")]
		[FieldOffset(Offset = "0x18")]
		public string buff;
	}
}
