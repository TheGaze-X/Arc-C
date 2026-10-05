using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001178 RID: 4472
	[Token(Token = "0x2001178")]
	public class RoguelikeRelicFeature
	{
		// Token: 0x06006F66 RID: 28518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F66")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeRelicFeature()
		{
		}

		// Token: 0x04005FDB RID: 24539
		[Token(Token = "0x4005FDB")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005FDC RID: 24540
		[Token(Token = "0x4005FDC")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeBuff> buffs;
	}
}
