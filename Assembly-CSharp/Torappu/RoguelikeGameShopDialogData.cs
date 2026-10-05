using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200120C RID: 4620
	[Token(Token = "0x200120C")]
	public class RoguelikeGameShopDialogData
	{
		// Token: 0x06007008 RID: 28680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007008")]
		[Address(RVA = "0x2111CA0", Offset = "0x21108A0", VA = "0x182111CA0")]
		public RoguelikeGameShopDialogData()
		{
		}

		// Token: 0x040063BD RID: 25533
		[Token(Token = "0x40063BD")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeGameShopDialogTypeData> types;
	}
}
