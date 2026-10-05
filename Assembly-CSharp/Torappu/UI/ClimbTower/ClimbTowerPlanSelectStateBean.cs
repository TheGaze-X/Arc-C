using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CEE RID: 23790
	[Token(Token = "0x2005CEE")]
	public class ClimbTowerPlanSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06022716 RID: 141078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022716")]
		[Address(RVA = "0x1CD4C10", Offset = "0x1CD3810", VA = "0x181CD4C10")]
		public ClimbTowerPlanSelectStateBean()
		{
		}

		// Token: 0x0402F57F RID: 193919
		[Token(Token = "0x402F57F")]
		[FieldOffset(Offset = "0x10")]
		public BoolProperty property;

		// Token: 0x0402F580 RID: 193920
		[Token(Token = "0x402F580")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
