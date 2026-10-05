using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EA7 RID: 3751
	[Token(Token = "0x2000EA7")]
	public class Act4funValueEffectInfoData
	{
		// Token: 0x06006B79 RID: 27513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B79")]
		[Address(RVA = "0x1FF74D0", Offset = "0x1FF60D0", VA = "0x181FF74D0")]
		public Act4funValueEffectInfoData()
		{
		}

		// Token: 0x04004F38 RID: 20280
		[Token(Token = "0x4004F38")]
		[FieldOffset(Offset = "0x10")]
		public string valueEffectId;

		// Token: 0x04004F39 RID: 20281
		[Token(Token = "0x4004F39")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> effectParams;
	}
}
