using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C7D RID: 23677
	[Token(Token = "0x2005C7D")]
	public class ClimbTowerSeasonMissionAwardResponse : PlayerDeltaResponse
	{
		// Token: 0x060224F5 RID: 140533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224F5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ClimbTowerSeasonMissionAwardResponse()
		{
		}

		// Token: 0x0402F1C0 RID: 192960
		[Token(Token = "0x402F1C0")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> items;
	}
}
