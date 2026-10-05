using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006DB RID: 1755
	[Token(Token = "0x20006DB")]
	public class CrisisSeasonShopItemData : CrisisCommonShopItemData
	{
		// Token: 0x0600632A RID: 25386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisSeasonShopItemData()
		{
		}

		// Token: 0x04002EE5 RID: 12005
		[Token(Token = "0x4002EE5")]
		[FieldOffset(Offset = "0x40")]
		public int slotId;

		// Token: 0x04002EE6 RID: 12006
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x48")]
		public string rarity;
	}
}
