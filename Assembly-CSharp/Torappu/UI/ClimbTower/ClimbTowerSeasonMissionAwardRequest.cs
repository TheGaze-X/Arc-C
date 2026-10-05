using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C7C RID: 23676
	[Token(Token = "0x2005C7C")]
	public class ClimbTowerSeasonMissionAwardRequest
	{
		// Token: 0x060224F4 RID: 140532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerSeasonMissionAwardRequest()
		{
		}

		// Token: 0x0402F1BF RID: 192959
		[Token(Token = "0x402F1BF")]
		[FieldOffset(Offset = "0x10")]
		public List<string> missionIds;
	}
}
