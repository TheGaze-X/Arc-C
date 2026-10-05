using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001946 RID: 6470
	[Token(Token = "0x2001946")]
	public class DIYShopGroupItemModel
	{
		// Token: 0x0600A2B2 RID: 41650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DIYShopGroupItemModel()
		{
		}

		// Token: 0x04009920 RID: 39200
		[Token(Token = "0x4009920")]
		[FieldOffset(Offset = "0x10")]
		public IFurnitureGroupData groupData;

		// Token: 0x04009921 RID: 39201
		[Token(Token = "0x4009921")]
		[FieldOffset(Offset = "0x18")]
		public Action<DIYShopItemViewData> selectCallback;
	}
}
