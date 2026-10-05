using System;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C8F RID: 23695
	[Token(Token = "0x2005C8F")]
	public class ClimbTowerBattleStartRequest
	{
		// Token: 0x0602250B RID: 140555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602250B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerBattleStartRequest()
		{
		}

		// Token: 0x0402F1D5 RID: 192981
		[Token(Token = "0x402F1D5")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0402F1D6 RID: 192982
		[Token(Token = "0x402F1D6")]
		[FieldOffset(Offset = "0x18")]
		public CommonStartBattleRequest.SquadModel squad;
	}
}
