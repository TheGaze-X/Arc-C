using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DCE RID: 24014
	[Token(Token = "0x2005DCE")]
	public class ClimbTowerTrainViewModel : IHotfixable
	{
		// Token: 0x06022CAC RID: 142508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CAC")]
		[Address(RVA = "0x1D5B900", Offset = "0x1D5A500", VA = "0x181D5B900")]
		public void LoadData(bool resetSelectedTower = true)
		{
		}

		// Token: 0x06022CAD RID: 142509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CAD")]
		[Address(RVA = "0x1D5BEA0", Offset = "0x1D5AAA0", VA = "0x181D5BEA0")]
		public ClimbTowerTrainViewModel()
		{
		}

		// Token: 0x0402FDC3 RID: 196035
		[Token(Token = "0x402FDC3")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, ClimbTowerTrainItemViewModel> towerModel;

		// Token: 0x0402FDC4 RID: 196036
		[Token(Token = "0x402FDC4")]
		[FieldOffset(Offset = "0x18")]
		public bool isInBattle;

		// Token: 0x0402FDC5 RID: 196037
		[Token(Token = "0x402FDC5")]
		[FieldOffset(Offset = "0x20")]
		public string selectedTower;

		// Token: 0x0402FDC6 RID: 196038
		[Token(Token = "0x402FDC6")]
		[FieldOffset(Offset = "0x28")]
		public bool isAllComplete;

		// Token: 0x0402FDC7 RID: 196039
		[Token(Token = "0x402FDC7")]
		[FieldOffset(Offset = "0x29")]
		public bool isInit;

		// Token: 0x0402FDC8 RID: 196040
		[Token(Token = "0x402FDC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FDC9 RID: 196041
		[Token(Token = "0x402FDC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
