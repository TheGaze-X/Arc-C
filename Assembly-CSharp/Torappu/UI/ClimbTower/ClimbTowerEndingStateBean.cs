using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D17 RID: 23831
	[Token(Token = "0x2005D17")]
	public class ClimbTowerEndingStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602282C RID: 141356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602282C")]
		[Address(RVA = "0x1CFE520", Offset = "0x1CFD120", VA = "0x181CFE520")]
		public void LoadData(bool isTutorial, List<CharacterCardViewModel> predefinedCharList, TowerCurrent playerCurrent, ClimbTowerSettleGameResponse response)
		{
		}

		// Token: 0x0602282D RID: 141357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602282D")]
		[Address(RVA = "0x1CFE5F0", Offset = "0x1CFD1F0", VA = "0x181CFE5F0")]
		public ClimbTowerEndingStateBean()
		{
		}

		// Token: 0x0402F6DC RID: 194268
		[Token(Token = "0x402F6DC")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerEndingViewModel viewModel;

		// Token: 0x0402F6DD RID: 194269
		[Token(Token = "0x402F6DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F6DE RID: 194270
		[Token(Token = "0x402F6DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
