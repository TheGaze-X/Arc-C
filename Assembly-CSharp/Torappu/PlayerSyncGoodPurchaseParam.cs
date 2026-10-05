using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	public class PlayerSyncGoodPurchaseParam : PlayerSyncParam
	{
		// Token: 0x060063F3 RID: 25587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSyncGoodPurchaseParam()
		{
		}

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0x10")]
		public ShopPurchaseState goodIdMap;
	}
}
