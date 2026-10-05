using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	public class BuildingBuyFurnitureGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x06006269 RID: 25193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006269")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingBuyFurnitureGoodResponse()
		{
		}

		// Token: 0x04002DEE RID: 11758
		[Token(Token = "0x4002DEE")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
