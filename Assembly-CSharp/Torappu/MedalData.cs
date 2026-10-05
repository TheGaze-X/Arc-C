using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010EE RID: 4334
	[Token(Token = "0x20010EE")]
	public class MedalData
	{
		// Token: 0x06006E99 RID: 28313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E99")]
		[Address(RVA = "0x2107980", Offset = "0x2106580", VA = "0x182107980")]
		public MedalData()
		{
		}

		// Token: 0x04005CE6 RID: 23782
		[Token(Token = "0x4005CE6")]
		[FieldOffset(Offset = "0x10")]
		public List<MedalPerData> medalList;

		// Token: 0x04005CE7 RID: 23783
		[Token(Token = "0x4005CE7")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, MedalTypeData> medalTypeData;
	}
}
