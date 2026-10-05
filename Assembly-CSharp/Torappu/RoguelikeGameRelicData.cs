using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001230 RID: 4656
	[Token(Token = "0x2001230")]
	public class RoguelikeGameRelicData
	{
		// Token: 0x0600702F RID: 28719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameRelicData()
		{
		}

		// Token: 0x04006482 RID: 25730
		[Token(Token = "0x4006482")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006483 RID: 25731
		[Token(Token = "0x4006483")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeBuff> buffs;
	}
}
