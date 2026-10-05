using System;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C84 RID: 23684
	[Token(Token = "0x2005C84")]
	public class ClimbTowerInitGameRequest
	{
		// Token: 0x06022500 RID: 140544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022500")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerInitGameRequest()
		{
		}

		// Token: 0x0402F1C9 RID: 192969
		[Token(Token = "0x402F1C9")]
		[FieldOffset(Offset = "0x10")]
		public TowerTactical tactical;

		// Token: 0x0402F1CA RID: 192970
		[Token(Token = "0x402F1CA")]
		[FieldOffset(Offset = "0x18")]
		public TowerGameStrategy strategy;
	}
}
