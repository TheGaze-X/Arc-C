using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200113A RID: 4410
	[Token(Token = "0x200113A")]
	[Serializable]
	public class RetroTrailRuleData
	{
		// Token: 0x06006F10 RID: 28432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F10")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RetroTrailRuleData()
		{
		}

		// Token: 0x04005E86 RID: 24198
		[Token(Token = "0x4005E86")]
		[FieldOffset(Offset = "0x10")]
		public List<string> title;

		// Token: 0x04005E87 RID: 24199
		[Token(Token = "0x4005E87")]
		[FieldOffset(Offset = "0x18")]
		public List<string> desc;
	}
}
