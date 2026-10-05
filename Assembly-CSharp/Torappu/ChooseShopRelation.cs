using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001318 RID: 4888
	[Token(Token = "0x2001318")]
	public class ChooseShopRelation
	{
		// Token: 0x06007295 RID: 29333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007295")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChooseShopRelation()
		{
		}

		// Token: 0x04006C51 RID: 27729
		[Token(Token = "0x4006C51")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04006C52 RID: 27730
		[Token(Token = "0x4006C52")]
		[FieldOffset(Offset = "0x18")]
		public List<string> optionList;
	}
}
