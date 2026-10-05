using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010B2 RID: 4274
	[Token(Token = "0x20010B2")]
	[Serializable]
	public class FavorCharacterInfo
	{
		// Token: 0x06006E3C RID: 28220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FavorCharacterInfo()
		{
		}

		// Token: 0x04005B81 RID: 23425
		[Token(Token = "0x4005B81")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04005B82 RID: 23426
		[Token(Token = "0x4005B82")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x04005B83 RID: 23427
		[Token(Token = "0x4005B83")]
		[FieldOffset(Offset = "0x20")]
		public int favorAddAmt;
	}
}
