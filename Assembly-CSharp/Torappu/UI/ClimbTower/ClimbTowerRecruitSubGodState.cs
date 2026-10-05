using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D4F RID: 23887
	[Token(Token = "0x2005D4F")]
	public class ClimbTowerRecruitSubGodState : PopupFadeState
	{
		// Token: 0x06022976 RID: 141686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022976")]
		[Address(RVA = "0x1D1DE90", Offset = "0x1D1CA90", VA = "0x181D1DE90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022977 RID: 141687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022977")]
		[Address(RVA = "0x1D1DEF0", Offset = "0x1D1CAF0", VA = "0x181D1DEF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022978 RID: 141688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022978")]
		[Address(RVA = "0x1D1E520", Offset = "0x1D1D120", VA = "0x181D1E520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022979 RID: 141689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022979")]
		[Address(RVA = "0x1D1E6F0", Offset = "0x1D1D2F0", VA = "0x181D1E6F0")]
		private void _SelectItem(string subCardId)
		{
		}

		// Token: 0x0602297A RID: 141690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602297A")]
		[Address(RVA = "0x1D1E3C0", Offset = "0x1D1CFC0", VA = "0x181D1E3C0")]
		private void _OnConfirmCallBack()
		{
		}

		// Token: 0x0602297B RID: 141691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602297B")]
		[Address(RVA = "0x1D1DBA0", Offset = "0x1D1C7A0", VA = "0x181D1DBA0")]
		public void EventOnBtnConfirm()
		{
		}

		// Token: 0x0602297C RID: 141692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602297C")]
		[Address(RVA = "0x1D1E8A0", Offset = "0x1D1D4A0", VA = "0x181D1E8A0")]
		public ClimbTowerRecruitSubGodState()
		{
		}

		// Token: 0x0602297E RID: 141694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602297E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402F8BE RID: 194750
		[Token(Token = "0x402F8BE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgBg;

		// Token: 0x0402F8BF RID: 194751
		[Token(Token = "0x402F8BF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerRecruitSubGodView _view;

		// Token: 0x0402F8C0 RID: 194752
		[Token(Token = "0x402F8C0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402F8C1 RID: 194753
		[Token(Token = "0x402F8C1")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402F8C2 RID: 194754
		[Token(Token = "0x402F8C2")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerRecruitSubGodStateBean m_stateBean;

		// Token: 0x0402F8C3 RID: 194755
		[Token(Token = "0x402F8C3")]
		[FieldOffset(Offset = "0x98")]
		private ClimbTowerRecruitSubGodState.MenuAdapter m_menuAdapter;

		// Token: 0x0402F8C4 RID: 194756
		[Token(Token = "0x402F8C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F8C5 RID: 194757
		[Token(Token = "0x402F8C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F8C6 RID: 194758
		[Token(Token = "0x402F8C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F8C7 RID: 194759
		[Token(Token = "0x402F8C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SelectItem;

		// Token: 0x0402F8C8 RID: 194760
		[Token(Token = "0x402F8C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnConfirmCallBack;

		// Token: 0x0402F8C9 RID: 194761
		[Token(Token = "0x402F8C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBtnConfirm;

		// Token: 0x0402F8CA RID: 194762
		[Token(Token = "0x402F8CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D50 RID: 23888
		[Token(Token = "0x2005D50")]
		public class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x17005175 RID: 20853
			// (get) Token: 0x0602297F RID: 141695 RVA: 0x000BDFA8 File Offset: 0x000BC1A8
			[Token(Token = "0x17005175")]
			public override bool showMenu
			{
				[Token(Token = "0x602297F")]
				[Address(RVA = "0x1D2EB00", Offset = "0x1D2D700", VA = "0x181D2EB00", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06022980 RID: 141696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022980")]
			[Address(RVA = "0x1D2E300", Offset = "0x1D2CF00", VA = "0x181D2E300")]
			public MenuAdapter()
			{
			}

			// Token: 0x06022981 RID: 141697 RVA: 0x000BDFC0 File Offset: 0x000BC1C0
			[Token(Token = "0x6022981")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x0402F8CB RID: 194763
			[Token(Token = "0x402F8CB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402F8CC RID: 194764
			[Token(Token = "0x402F8CC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
