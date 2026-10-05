using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D46 RID: 23878
	[Token(Token = "0x2005D46")]
	public class ClimbTowerInitGodDisplayStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005163 RID: 20835
		// (get) Token: 0x0602294A RID: 141642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005163")]
		public ClimbTowerInitGodDisplayProp displayProp
		{
			[Token(Token = "0x602294A")]
			[Address(RVA = "0x1D1A580", Offset = "0x1D19180", VA = "0x181D1A580")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602294B RID: 141643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602294B")]
		[Address(RVA = "0x1D1A490", Offset = "0x1D19090", VA = "0x181D1A490")]
		public ClimbTowerInitGodDisplayStateBean()
		{
		}

		// Token: 0x0402F86F RID: 194671
		[Token(Token = "0x402F86F")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerInitGodDisplayProp m_displayProp;

		// Token: 0x0402F870 RID: 194672
		[Token(Token = "0x402F870")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayProp;

		// Token: 0x0402F871 RID: 194673
		[Token(Token = "0x402F871")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
