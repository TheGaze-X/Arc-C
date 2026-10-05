using System;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C7E RID: 23678
	[Token(Token = "0x2005C7E")]
	public class ClimbTowerCreateGameRequest
	{
		// Token: 0x060224F6 RID: 140534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerCreateGameRequest()
		{
		}

		// Token: 0x0402F1C1 RID: 192961
		[Token(Token = "0x402F1C1")]
		[FieldOffset(Offset = "0x10")]
		public string tower;

		// Token: 0x0402F1C2 RID: 192962
		[Token(Token = "0x402F1C2")]
		[FieldOffset(Offset = "0x18")]
		public bool isHard;
	}
}
