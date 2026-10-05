using System;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C96 RID: 23702
	[Token(Token = "0x2005C96")]
	public class ClimbTowerBattleFinishDropInfo
	{
		// Token: 0x06022514 RID: 140564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022514")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerBattleFinishDropInfo()
		{
		}

		// Token: 0x0402F1E6 RID: 192998
		[Token(Token = "0x402F1E6")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0402F1E7 RID: 192999
		[Token(Token = "0x402F1E7")]
		[FieldOffset(Offset = "0x18")]
		public int before;

		// Token: 0x0402F1E8 RID: 193000
		[Token(Token = "0x402F1E8")]
		[FieldOffset(Offset = "0x1C")]
		public int after;

		// Token: 0x0402F1E9 RID: 193001
		[Token(Token = "0x402F1E9")]
		[FieldOffset(Offset = "0x20")]
		public bool max;
	}
}
