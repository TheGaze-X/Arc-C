using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001249 RID: 4681
	[Token(Token = "0x2001249")]
	public class RoguelikeRollNodeData
	{
		// Token: 0x0600703D RID: 28733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600703D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeRollNodeData()
		{
		}

		// Token: 0x04006535 RID: 25909
		[Token(Token = "0x4006535")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x04006536 RID: 25910
		[Token(Token = "0x4006536")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeRollNodeGroupData> groups;
	}
}
