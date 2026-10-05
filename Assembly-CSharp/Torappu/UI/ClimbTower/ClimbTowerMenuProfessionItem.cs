using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CD0 RID: 23760
	[Token(Token = "0x2005CD0")]
	public class ClimbTowerMenuProfessionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170050E1 RID: 20705
		// (set) Token: 0x06022661 RID: 140897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050E1")]
		public ClimbTowerMenu bindMenu
		{
			[Token(Token = "0x6022661")]
			[Address(RVA = "0x1CD2860", Offset = "0x1CD1460", VA = "0x181CD2860")]
			set
			{
			}
		}

		// Token: 0x170050E2 RID: 20706
		// (get) Token: 0x06022662 RID: 140898 RVA: 0x000BD4E0 File Offset: 0x000BB6E0
		[Token(Token = "0x170050E2")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x6022662")]
			[Address(RVA = "0x1CD2800", Offset = "0x1CD1400", VA = "0x181CD2800")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x06022663 RID: 140899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022663")]
		[Address(RVA = "0x1CD2670", Offset = "0x1CD1270", VA = "0x181CD2670")]
		public void Render(int count, Action<ProfessionCategory> callback)
		{
		}

		// Token: 0x06022664 RID: 140900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022664")]
		[Address(RVA = "0x1CD2580", Offset = "0x1CD1180", VA = "0x181CD2580")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x06022665 RID: 140901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022665")]
		[Address(RVA = "0x1CD27A0", Offset = "0x1CD13A0", VA = "0x181CD27A0")]
		public ClimbTowerMenuProfessionItem()
		{
		}

		// Token: 0x0402F45D RID: 193629
		[Token(Token = "0x402F45D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ProfessionCategory _profession;

		// Token: 0x0402F45E RID: 193630
		[Token(Token = "0x402F45E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textNum;

		// Token: 0x0402F45F RID: 193631
		[Token(Token = "0x402F45F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlRaycastBlocker;

		// Token: 0x0402F460 RID: 193632
		[Token(Token = "0x402F460")]
		[FieldOffset(Offset = "0x30")]
		private Action<ProfessionCategory> m_callback;

		// Token: 0x0402F461 RID: 193633
		[Token(Token = "0x402F461")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerMenu m_bindMenu;

		// Token: 0x0402F462 RID: 193634
		[Token(Token = "0x402F462")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_bindMenu;

		// Token: 0x0402F463 RID: 193635
		[Token(Token = "0x402F463")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x0402F464 RID: 193636
		[Token(Token = "0x402F464")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F465 RID: 193637
		[Token(Token = "0x402F465")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0402F466 RID: 193638
		[Token(Token = "0x402F466")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
