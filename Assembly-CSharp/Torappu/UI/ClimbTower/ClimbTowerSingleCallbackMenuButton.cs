using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CD4 RID: 23764
	[Token(Token = "0x2005CD4")]
	public class ClimbTowerSingleCallbackMenuButton : ClimbTowerMenuButton
	{
		// Token: 0x06022673 RID: 140915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022673")]
		[Address(RVA = "0x1CD6610", Offset = "0x1CD5210", VA = "0x181CD6610", Slot = "4")]
		public override void Render(IClimbTowerMenuButtonDataSource dataSource, bool fastMode)
		{
		}

		// Token: 0x06022674 RID: 140916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022674")]
		[Address(RVA = "0x1CD6690", Offset = "0x1CD5290", VA = "0x181CD6690")]
		public ClimbTowerSingleCallbackMenuButton()
		{
		}

		// Token: 0x0402F47B RID: 193659
		[Token(Token = "0x402F47B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F47C RID: 193660
		[Token(Token = "0x402F47C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
