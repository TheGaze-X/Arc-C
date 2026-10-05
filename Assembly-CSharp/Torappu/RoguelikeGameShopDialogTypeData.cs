using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200120D RID: 4621
	[Token(Token = "0x200120D")]
	public class RoguelikeGameShopDialogTypeData
	{
		// Token: 0x06007009 RID: 28681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007009")]
		[Address(RVA = "0x2111DC0", Offset = "0x21109C0", VA = "0x182111DC0")]
		public RoguelikeGameShopDialogTypeData()
		{
		}

		// Token: 0x040063BE RID: 25534
		[Token(Token = "0x40063BE")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeGameShopDialogGroupData> groups;
	}
}
