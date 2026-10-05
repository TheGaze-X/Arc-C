using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D3C RID: 23868
	[Token(Token = "0x2005D3C")]
	public class ClimbTowerInitCurseDisplayStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005154 RID: 20820
		// (get) Token: 0x06022914 RID: 141588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005154")]
		public ClimbTowerInitCurseDisplayProp displayProp
		{
			[Token(Token = "0x6022914")]
			[Address(RVA = "0x1D17EA0", Offset = "0x1D16AA0", VA = "0x181D17EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022915 RID: 141589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022915")]
		[Address(RVA = "0x1D17DB0", Offset = "0x1D169B0", VA = "0x181D17DB0")]
		public ClimbTowerInitCurseDisplayStateBean()
		{
		}

		// Token: 0x0402F82C RID: 194604
		[Token(Token = "0x402F82C")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerInitCurseDisplayProp m_prop;

		// Token: 0x0402F82D RID: 194605
		[Token(Token = "0x402F82D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayProp;

		// Token: 0x0402F82E RID: 194606
		[Token(Token = "0x402F82E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
