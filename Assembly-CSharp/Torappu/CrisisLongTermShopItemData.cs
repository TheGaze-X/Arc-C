using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006DA RID: 1754
	[Token(Token = "0x20006DA")]
	public class CrisisLongTermShopItemData : CrisisCommonShopItemData
	{
		// Token: 0x06006329 RID: 25385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006329")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisLongTermShopItemData()
		{
		}

		// Token: 0x04002EE0 RID: 12000
		[Token(Token = "0x4002EE0")]
		[FieldOffset(Offset = "0x40")]
		public int isSingle;

		// Token: 0x04002EE1 RID: 12001
		[Token(Token = "0x4002EE1")]
		[FieldOffset(Offset = "0x44")]
		public int slotId1;

		// Token: 0x04002EE2 RID: 12002
		[Token(Token = "0x4002EE2")]
		[FieldOffset(Offset = "0x48")]
		public int slotId2;

		// Token: 0x04002EE3 RID: 12003
		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x50")]
		public string seasonId;

		// Token: 0x04002EE4 RID: 12004
		[Token(Token = "0x4002EE4")]
		[FieldOffset(Offset = "0x58")]
		public CrisisShopTitleType title;
	}
}
