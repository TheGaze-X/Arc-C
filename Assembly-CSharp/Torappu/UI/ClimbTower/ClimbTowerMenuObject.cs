using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CCF RID: 23759
	[Token(Token = "0x2005CCF")]
	public abstract class ClimbTowerMenuObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x170050E0 RID: 20704
		// (get) Token: 0x0602265D RID: 140893 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602265E RID: 140894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050E0")]
		public ClimbTowerMenu bindMenu
		{
			[Token(Token = "0x602265D")]
			[Address(RVA = "0x1CD24A0", Offset = "0x1CD10A0", VA = "0x181CD24A0")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602265E")]
			[Address(RVA = "0x1CD2500", Offset = "0x1CD1100", VA = "0x181CD2500")]
			set
			{
			}
		}

		// Token: 0x0602265F RID: 140895
		[Token(Token = "0x602265F")]
		public abstract void Render(ClimbTowerMenuViewModel viewModel);

		// Token: 0x06022660 RID: 140896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022660")]
		[Address(RVA = "0x1CD2440", Offset = "0x1CD1040", VA = "0x181CD2440")]
		protected ClimbTowerMenuObject()
		{
		}

		// Token: 0x0402F459 RID: 193625
		[Token(Token = "0x402F459")]
		[FieldOffset(Offset = "0x18")]
		private ClimbTowerMenu m_bindMenu;

		// Token: 0x0402F45A RID: 193626
		[Token(Token = "0x402F45A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindMenu;

		// Token: 0x0402F45B RID: 193627
		[Token(Token = "0x402F45B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindMenu;

		// Token: 0x0402F45C RID: 193628
		[Token(Token = "0x402F45C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
