using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001238 RID: 4664
	[Token(Token = "0x2001238")]
	public class RoguelikeGameTypedItem
	{
		// Token: 0x06007037 RID: 28727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007037")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameTypedItem()
		{
		}

		// Token: 0x040064A0 RID: 25760
		[Token(Token = "0x40064A0")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeGameItemType type;

		// Token: 0x040064A1 RID: 25761
		[Token(Token = "0x40064A1")]
		[FieldOffset(Offset = "0x18")]
		public string id;
	}
}
