using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DA0 RID: 23968
	[Token(Token = "0x2005DA0")]
	public class ClimbTowerSquadExpansionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005211 RID: 21009
		// (get) Token: 0x06022C07 RID: 142343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005211")]
		public ClimbTowerSquadExpansionProperty property
		{
			[Token(Token = "0x6022C07")]
			[Address(RVA = "0x1D58E30", Offset = "0x1D57A30", VA = "0x181D58E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022C08 RID: 142344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C08")]
		[Address(RVA = "0x1D58D40", Offset = "0x1D57940", VA = "0x181D58D40")]
		public ClimbTowerSquadExpansionStateBean()
		{
		}

		// Token: 0x0402FC5E RID: 195678
		[Token(Token = "0x402FC5E")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerSquadExpansionProperty m_property;

		// Token: 0x0402FC5F RID: 195679
		[Token(Token = "0x402FC5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x0402FC60 RID: 195680
		[Token(Token = "0x402FC60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
