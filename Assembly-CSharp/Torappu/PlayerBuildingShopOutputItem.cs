using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A51 RID: 2641
	[Token(Token = "0x2000A51")]
	public class PlayerBuildingShopOutputItem
	{
		// Token: 0x06006710 RID: 26384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006710")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingShopOutputItem()
		{
		}

		// Token: 0x04003853 RID: 14419
		[Token(Token = "0x4003853")]
		[FieldOffset(Offset = "0x10")]
		public ItemType type;

		// Token: 0x04003854 RID: 14420
		[Token(Token = "0x4003854")]
		[FieldOffset(Offset = "0x14")]
		public int count;
	}
}
