using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D35 RID: 23861
	[Token(Token = "0x2005D35")]
	public class ClimbTowerTrainPreviewStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060228DA RID: 141530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228DA")]
		[Address(RVA = "0x1D2BD60", Offset = "0x1D2A960", VA = "0x181D2BD60")]
		public ClimbTowerTrainPreviewStateBean()
		{
		}

		// Token: 0x0402F7F3 RID: 194547
		[Token(Token = "0x402F7F3")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerTrainItemViewModel selectedTowerModel;

		// Token: 0x0402F7F4 RID: 194548
		[Token(Token = "0x402F7F4")]
		[FieldOffset(Offset = "0x18")]
		public List<EnemyHandBookEverViewModel> enemyList;

		// Token: 0x0402F7F5 RID: 194549
		[Token(Token = "0x402F7F5")]
		[FieldOffset(Offset = "0x20")]
		public int enemyListIdx;

		// Token: 0x0402F7F6 RID: 194550
		[Token(Token = "0x402F7F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
