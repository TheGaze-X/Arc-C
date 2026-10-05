using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200121D RID: 4637
	[Token(Token = "0x200121D")]
	public class RoguelikePredefinedExpStyleConfigData
	{
		// Token: 0x0600701C RID: 28700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600701C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikePredefinedExpStyleConfigData()
		{
		}

		// Token: 0x04006429 RID: 25641
		[Token(Token = "0x4006429")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<RoguelikeExpStyleConfigParam, string> paramDict;
	}
}
