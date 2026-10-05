using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D1F RID: 23839
	[Token(Token = "0x2005D1F")]
	public class ClimbTowerEndingTopStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06022847 RID: 141383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022847")]
		[Address(RVA = "0x1CFF680", Offset = "0x1CFE280", VA = "0x181CFF680")]
		public void LoadData(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022848 RID: 141384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022848")]
		[Address(RVA = "0x1CFF7B0", Offset = "0x1CFE3B0", VA = "0x181CFF7B0")]
		public ClimbTowerEndingTopStateBean()
		{
		}

		// Token: 0x0402F712 RID: 194322
		[Token(Token = "0x402F712")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerEndingTopViewModel viewModel;

		// Token: 0x0402F713 RID: 194323
		[Token(Token = "0x402F713")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F714 RID: 194324
		[Token(Token = "0x402F714")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
