using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001231 RID: 4657
	[Token(Token = "0x2001231")]
	public class RoguelikeTopicExtraBuffData
	{
		// Token: 0x06007030 RID: 28720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007030")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicExtraBuffData()
		{
		}

		// Token: 0x04006484 RID: 25732
		[Token(Token = "0x4006484")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006485 RID: 25733
		[Token(Token = "0x4006485")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeBuff> buffs;

		// Token: 0x04006486 RID: 25734
		[Token(Token = "0x4006486")]
		[FieldOffset(Offset = "0x20")]
		public int layer;
	}
}
