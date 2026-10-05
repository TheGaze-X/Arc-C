using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A1C RID: 2588
	[Token(Token = "0x2000A1C")]
	public class PlayerGoodItemData
	{
		// Token: 0x060066DB RID: 26331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerGoodItemData()
		{
		}

		// Token: 0x040037BA RID: 14266
		[Token(Token = "0x40037BA")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040037BB RID: 14267
		[Token(Token = "0x40037BB")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
