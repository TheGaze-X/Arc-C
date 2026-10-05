using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C7B RID: 23675
	[Token(Token = "0x2005C7B")]
	public class ClimbTowerLayerFirstPassRewardRequest
	{
		// Token: 0x060224F3 RID: 140531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224F3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerLayerFirstPassRewardRequest()
		{
		}

		// Token: 0x0402F1BD RID: 192957
		[Token(Token = "0x402F1BD")]
		[FieldOffset(Offset = "0x10")]
		public string tower;

		// Token: 0x0402F1BE RID: 192958
		[Token(Token = "0x402F1BE")]
		[FieldOffset(Offset = "0x18")]
		public List<int> layers;
	}
}
