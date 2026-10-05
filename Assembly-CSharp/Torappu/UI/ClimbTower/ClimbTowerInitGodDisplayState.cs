using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D44 RID: 23876
	[Token(Token = "0x2005D44")]
	public class ClimbTowerInitGodDisplayState : PopupFadeState
	{
		// Token: 0x0602292B RID: 141611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602292B")]
		[Address(RVA = "0x1D1A870", Offset = "0x1D19470", VA = "0x181D1A870", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602292C RID: 141612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602292C")]
		[Address(RVA = "0x1D1A8D0", Offset = "0x1D194D0", VA = "0x181D1A8D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602292D RID: 141613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602292D")]
		[Address(RVA = "0x1D1B220", Offset = "0x1D19E20", VA = "0x181D1B220")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602292E RID: 141614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602292E")]
		[Address(RVA = "0x1D1B4F0", Offset = "0x1D1A0F0", VA = "0x181D1B4F0")]
		private void _OnCardClick(int index)
		{
		}

		// Token: 0x0602292F RID: 141615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602292F")]
		[Address(RVA = "0x1D1B6E0", Offset = "0x1D1A2E0", VA = "0x181D1B6E0")]
		private void _SendSettleGameRequest()
		{
		}

		// Token: 0x06022930 RID: 141616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022930")]
		[Address(RVA = "0x1D1AE20", Offset = "0x1D19A20", VA = "0x181D1AE20")]
		private void _NavToLayerState()
		{
		}

		// Token: 0x06022931 RID: 141617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022931")]
		[Address(RVA = "0x1D1AD70", Offset = "0x1D19970", VA = "0x181D1AD70")]
		private void _NavToBuffSelectState()
		{
		}

		// Token: 0x06022932 RID: 141618 RVA: 0x000BDDE0 File Offset: 0x000BBFE0
		[Token(Token = "0x6022932")]
		[Address(RVA = "0x1D1B3E0", Offset = "0x1D19FE0", VA = "0x181D1B3E0")]
		private bool _NeedShowTrapButton()
		{
			return default(bool);
		}

		// Token: 0x06022933 RID: 141619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022933")]
		[Address(RVA = "0x1D1AED0", Offset = "0x1D19AD0", VA = "0x181D1AED0")]
		private void _EventOnBtnNext()
		{
		}

		// Token: 0x06022934 RID: 141620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022934")]
		[Address(RVA = "0x1D1A5E0", Offset = "0x1D191E0", VA = "0x181D1A5E0")]
		public void EventOnBtnQuit()
		{
		}

		// Token: 0x06022935 RID: 141621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022935")]
		[Address(RVA = "0x1D1B8F0", Offset = "0x1D1A4F0", VA = "0x181D1B8F0")]
		public ClimbTowerInitGodDisplayState()
		{
		}

		// Token: 0x06022938 RID: 141624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022938")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402F854 RID: 194644
		[Token(Token = "0x402F854")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerInitGodDisplayView _view;

		// Token: 0x0402F855 RID: 194645
		[Token(Token = "0x402F855")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerMenuButton _menuButtonPrefab;

		// Token: 0x0402F856 RID: 194646
		[Token(Token = "0x402F856")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402F857 RID: 194647
		[Token(Token = "0x402F857")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerInitGodDisplayStateBean m_stateBean;

		// Token: 0x0402F858 RID: 194648
		[Token(Token = "0x402F858")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerInitGodDisplayState.MenuAdapter m_menuAdapter;

		// Token: 0x0402F859 RID: 194649
		[Token(Token = "0x402F859")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402F85A RID: 194650
		[Token(Token = "0x402F85A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F85B RID: 194651
		[Token(Token = "0x402F85B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F85C RID: 194652
		[Token(Token = "0x402F85C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F85D RID: 194653
		[Token(Token = "0x402F85D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCardClick;

		// Token: 0x0402F85E RID: 194654
		[Token(Token = "0x402F85E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendSettleGameRequest;

		// Token: 0x0402F85F RID: 194655
		[Token(Token = "0x402F85F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NavToLayerState;

		// Token: 0x0402F860 RID: 194656
		[Token(Token = "0x402F860")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__NavToBuffSelectState;

		// Token: 0x0402F861 RID: 194657
		[Token(Token = "0x402F861")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__NeedShowTrapButton;

		// Token: 0x0402F862 RID: 194658
		[Token(Token = "0x402F862")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnBtnNext;

		// Token: 0x0402F863 RID: 194659
		[Token(Token = "0x402F863")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBtnQuit;

		// Token: 0x0402F864 RID: 194660
		[Token(Token = "0x402F864")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D45 RID: 23877
		[Token(Token = "0x2005D45")]
		private class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x06022939 RID: 141625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022939")]
			[Address(RVA = "0x1D2E360", Offset = "0x1D2CF60", VA = "0x181D2E360")]
			public MenuAdapter(ClimbTowerInitGodDisplayState closure)
			{
			}

			// Token: 0x1700515B RID: 20827
			// (get) Token: 0x0602293A RID: 141626 RVA: 0x000BDDF8 File Offset: 0x000BBFF8
			[Token(Token = "0x1700515B")]
			public override bool showMenu
			{
				[Token(Token = "0x602293A")]
				[Address(RVA = "0x1D2EBC0", Offset = "0x1D2D7C0", VA = "0x181D2EBC0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700515C RID: 20828
			// (get) Token: 0x0602293B RID: 141627 RVA: 0x000BDE10 File Offset: 0x000BC010
			[Token(Token = "0x1700515C")]
			public override bool hideBuffBtnWithHolder
			{
				[Token(Token = "0x602293B")]
				[Address(RVA = "0x1D2E990", Offset = "0x1D2D590", VA = "0x181D2E990", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700515D RID: 20829
			// (get) Token: 0x0602293C RID: 141628 RVA: 0x000BDE28 File Offset: 0x000BC028
			[Token(Token = "0x1700515D")]
			public override bool showTrapBtn
			{
				[Token(Token = "0x602293C")]
				[Address(RVA = "0x1D2EEC0", Offset = "0x1D2DAC0", VA = "0x181D2EEC0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700515E RID: 20830
			// (get) Token: 0x0602293D RID: 141629 RVA: 0x000BDE40 File Offset: 0x000BC040
			[Token(Token = "0x1700515E")]
			public override bool showSquadBtn
			{
				[Token(Token = "0x602293D")]
				[Address(RVA = "0x1D2EDA0", Offset = "0x1D2D9A0", VA = "0x181D2EDA0", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700515F RID: 20831
			// (get) Token: 0x0602293E RID: 141630 RVA: 0x000BDE58 File Offset: 0x000BC058
			[Token(Token = "0x1700515F")]
			public override bool showProfessionBtns
			{
				[Token(Token = "0x602293E")]
				[Address(RVA = "0x1D2EC80", Offset = "0x1D2D880", VA = "0x181D2EC80", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005160 RID: 20832
			// (get) Token: 0x0602293F RID: 141631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005160")]
			public override ClimbTowerMenuButton buttonPrefab
			{
				[Token(Token = "0x602293F")]
				[Address(RVA = "0x1D2E8B0", Offset = "0x1D2D4B0", VA = "0x181D2E8B0", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005161 RID: 20833
			// (get) Token: 0x06022940 RID: 141632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005161")]
			public override IClimbTowerMenuButtonDataSource buttonDataSource
			{
				[Token(Token = "0x6022940")]
				[Address(RVA = "0x1D2E6F0", Offset = "0x1D2D2F0", VA = "0x181D2E6F0", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005162 RID: 20834
			// (get) Token: 0x06022941 RID: 141633 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005162")]
			public override Action buttonCallback
			{
				[Token(Token = "0x6022941")]
				[Address(RVA = "0x1D2E4E0", Offset = "0x1D2D0E0", VA = "0x181D2E4E0", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x06022942 RID: 141634 RVA: 0x000BDE70 File Offset: 0x000BC070
			[Token(Token = "0x6022942")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x06022943 RID: 141635 RVA: 0x000BDE88 File Offset: 0x000BC088
			[Token(Token = "0x6022943")]
			[Address(RVA = "0x1D11890", Offset = "0x1D10490", VA = "0x181D11890")]
			private bool <>xLuaBaseProxy_get_hideBuffBtnWithHolder()
			{
				return default(bool);
			}

			// Token: 0x06022944 RID: 141636 RVA: 0x000BDEA0 File Offset: 0x000BC0A0
			[Token(Token = "0x6022944")]
			[Address(RVA = "0x1D2E2F0", Offset = "0x1D2CEF0", VA = "0x181D2E2F0")]
			private bool <>xLuaBaseProxy_get_showTrapBtn()
			{
				return default(bool);
			}

			// Token: 0x06022945 RID: 141637 RVA: 0x000BDEB8 File Offset: 0x000BC0B8
			[Token(Token = "0x6022945")]
			[Address(RVA = "0x1D118E0", Offset = "0x1D104E0", VA = "0x181D118E0")]
			private bool <>xLuaBaseProxy_get_showSquadBtn()
			{
				return default(bool);
			}

			// Token: 0x06022946 RID: 141638 RVA: 0x000BDED0 File Offset: 0x000BC0D0
			[Token(Token = "0x6022946")]
			[Address(RVA = "0x1D118D0", Offset = "0x1D104D0", VA = "0x181D118D0")]
			private bool <>xLuaBaseProxy_get_showProfessionBtns()
			{
				return default(bool);
			}

			// Token: 0x06022947 RID: 141639 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022947")]
			[Address(RVA = "0x1D11880", Offset = "0x1D10480", VA = "0x181D11880")]
			private ClimbTowerMenuButton <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x06022948 RID: 141640 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022948")]
			[Address(RVA = "0x1D11870", Offset = "0x1D10470", VA = "0x181D11870")]
			private IClimbTowerMenuButtonDataSource <>xLuaBaseProxy_get_buttonDataSource()
			{
				return null;
			}

			// Token: 0x06022949 RID: 141641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022949")]
			[Address(RVA = "0x1D11860", Offset = "0x1D10460", VA = "0x181D11860")]
			private Action <>xLuaBaseProxy_get_buttonCallback()
			{
				return null;
			}

			// Token: 0x0402F865 RID: 194661
			[Token(Token = "0x402F865")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerInitGodDisplayState m_closure;

			// Token: 0x0402F866 RID: 194662
			[Token(Token = "0x402F866")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F867 RID: 194663
			[Token(Token = "0x402F867")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402F868 RID: 194664
			[Token(Token = "0x402F868")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_hideBuffBtnWithHolder;

			// Token: 0x0402F869 RID: 194665
			[Token(Token = "0x402F869")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_showTrapBtn;

			// Token: 0x0402F86A RID: 194666
			[Token(Token = "0x402F86A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_showSquadBtn;

			// Token: 0x0402F86B RID: 194667
			[Token(Token = "0x402F86B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_showProfessionBtns;

			// Token: 0x0402F86C RID: 194668
			[Token(Token = "0x402F86C")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402F86D RID: 194669
			[Token(Token = "0x402F86D")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_buttonDataSource;

			// Token: 0x0402F86E RID: 194670
			[Token(Token = "0x402F86E")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_buttonCallback;
		}
	}
}
