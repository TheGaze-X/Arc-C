using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D3A RID: 23866
	[Token(Token = "0x2005D3A")]
	public class ClimbTowerInitCurseDisplayState : PopupFadeState
	{
		// Token: 0x060228FB RID: 141563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228FB")]
		[Address(RVA = "0x1D18190", Offset = "0x1D16D90", VA = "0x181D18190", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060228FC RID: 141564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228FC")]
		[Address(RVA = "0x1D181F0", Offset = "0x1D16DF0", VA = "0x181D181F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060228FD RID: 141565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228FD")]
		[Address(RVA = "0x1D18740", Offset = "0x1D17340", VA = "0x181D18740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060228FE RID: 141566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228FE")]
		[Address(RVA = "0x1D18850", Offset = "0x1D17450", VA = "0x181D18850")]
		private void _SendSettleGameRequest()
		{
		}

		// Token: 0x060228FF RID: 141567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228FF")]
		[Address(RVA = "0x1D185E0", Offset = "0x1D171E0", VA = "0x181D185E0")]
		private void _NavToLayerState()
		{
		}

		// Token: 0x06022900 RID: 141568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022900")]
		[Address(RVA = "0x1D18690", Offset = "0x1D17290", VA = "0x181D18690")]
		private void _EventOnBtnNext()
		{
		}

		// Token: 0x06022901 RID: 141569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022901")]
		[Address(RVA = "0x1D17F00", Offset = "0x1D16B00", VA = "0x181D17F00")]
		public void EventOnBtnQuit()
		{
		}

		// Token: 0x06022902 RID: 141570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022902")]
		[Address(RVA = "0x1D18A60", Offset = "0x1D17660", VA = "0x181D18A60")]
		public ClimbTowerInitCurseDisplayState()
		{
		}

		// Token: 0x06022904 RID: 141572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022904")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402F815 RID: 194581
		[Token(Token = "0x402F815")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerInitCurseDisplayView _view;

		// Token: 0x0402F816 RID: 194582
		[Token(Token = "0x402F816")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerMenuButton _menuButtonPrefab;

		// Token: 0x0402F817 RID: 194583
		[Token(Token = "0x402F817")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402F818 RID: 194584
		[Token(Token = "0x402F818")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402F819 RID: 194585
		[Token(Token = "0x402F819")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerInitCurseDisplayStateBean m_stateBean;

		// Token: 0x0402F81A RID: 194586
		[Token(Token = "0x402F81A")]
		[FieldOffset(Offset = "0x98")]
		private ClimbTowerInitCurseDisplayState.MenuAdapter m_menuAdapter;

		// Token: 0x0402F81B RID: 194587
		[Token(Token = "0x402F81B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F81C RID: 194588
		[Token(Token = "0x402F81C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F81D RID: 194589
		[Token(Token = "0x402F81D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F81E RID: 194590
		[Token(Token = "0x402F81E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendSettleGameRequest;

		// Token: 0x0402F81F RID: 194591
		[Token(Token = "0x402F81F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NavToLayerState;

		// Token: 0x0402F820 RID: 194592
		[Token(Token = "0x402F820")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnBtnNext;

		// Token: 0x0402F821 RID: 194593
		[Token(Token = "0x402F821")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnQuit;

		// Token: 0x0402F822 RID: 194594
		[Token(Token = "0x402F822")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D3B RID: 23867
		[Token(Token = "0x2005D3B")]
		private class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x06022905 RID: 141573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022905")]
			[Address(RVA = "0x1D2E3E0", Offset = "0x1D2CFE0", VA = "0x181D2E3E0")]
			public MenuAdapter(ClimbTowerInitCurseDisplayState closure)
			{
			}

			// Token: 0x1700514D RID: 20813
			// (get) Token: 0x06022906 RID: 141574 RVA: 0x000BDCC0 File Offset: 0x000BBEC0
			[Token(Token = "0x1700514D")]
			public override bool showMenu
			{
				[Token(Token = "0x6022906")]
				[Address(RVA = "0x1D2EC20", Offset = "0x1D2D820", VA = "0x181D2EC20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700514E RID: 20814
			// (get) Token: 0x06022907 RID: 141575 RVA: 0x000BDCD8 File Offset: 0x000BBED8
			[Token(Token = "0x1700514E")]
			public override bool hideBuffBtnWithHolder
			{
				[Token(Token = "0x6022907")]
				[Address(RVA = "0x1D2E9F0", Offset = "0x1D2D5F0", VA = "0x181D2E9F0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700514F RID: 20815
			// (get) Token: 0x06022908 RID: 141576 RVA: 0x000BDCF0 File Offset: 0x000BBEF0
			[Token(Token = "0x1700514F")]
			public override bool showTrapBtn
			{
				[Token(Token = "0x6022908")]
				[Address(RVA = "0x1D2EE60", Offset = "0x1D2DA60", VA = "0x181D2EE60", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005150 RID: 20816
			// (get) Token: 0x06022909 RID: 141577 RVA: 0x000BDD08 File Offset: 0x000BBF08
			[Token(Token = "0x17005150")]
			public override bool showSquadBtn
			{
				[Token(Token = "0x6022909")]
				[Address(RVA = "0x1D2ED40", Offset = "0x1D2D940", VA = "0x181D2ED40", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005151 RID: 20817
			// (get) Token: 0x0602290A RID: 141578 RVA: 0x000BDD20 File Offset: 0x000BBF20
			[Token(Token = "0x17005151")]
			public override bool showProfessionBtns
			{
				[Token(Token = "0x602290A")]
				[Address(RVA = "0x1D2ECE0", Offset = "0x1D2D8E0", VA = "0x181D2ECE0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005152 RID: 20818
			// (get) Token: 0x0602290B RID: 141579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005152")]
			public override ClimbTowerMenuButton buttonPrefab
			{
				[Token(Token = "0x602290B")]
				[Address(RVA = "0x1D2E840", Offset = "0x1D2D440", VA = "0x181D2E840", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005153 RID: 20819
			// (get) Token: 0x0602290C RID: 141580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005153")]
			public override Action buttonCallback
			{
				[Token(Token = "0x602290C")]
				[Address(RVA = "0x1D2E640", Offset = "0x1D2D240", VA = "0x181D2E640", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602290D RID: 141581 RVA: 0x000BDD38 File Offset: 0x000BBF38
			[Token(Token = "0x602290D")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x0602290E RID: 141582 RVA: 0x000BDD50 File Offset: 0x000BBF50
			[Token(Token = "0x602290E")]
			[Address(RVA = "0x1D11890", Offset = "0x1D10490", VA = "0x181D11890")]
			private bool <>xLuaBaseProxy_get_hideBuffBtnWithHolder()
			{
				return default(bool);
			}

			// Token: 0x0602290F RID: 141583 RVA: 0x000BDD68 File Offset: 0x000BBF68
			[Token(Token = "0x602290F")]
			[Address(RVA = "0x1D2E2F0", Offset = "0x1D2CEF0", VA = "0x181D2E2F0")]
			private bool <>xLuaBaseProxy_get_showTrapBtn()
			{
				return default(bool);
			}

			// Token: 0x06022910 RID: 141584 RVA: 0x000BDD80 File Offset: 0x000BBF80
			[Token(Token = "0x6022910")]
			[Address(RVA = "0x1D118E0", Offset = "0x1D104E0", VA = "0x181D118E0")]
			private bool <>xLuaBaseProxy_get_showSquadBtn()
			{
				return default(bool);
			}

			// Token: 0x06022911 RID: 141585 RVA: 0x000BDD98 File Offset: 0x000BBF98
			[Token(Token = "0x6022911")]
			[Address(RVA = "0x1D118D0", Offset = "0x1D104D0", VA = "0x181D118D0")]
			private bool <>xLuaBaseProxy_get_showProfessionBtns()
			{
				return default(bool);
			}

			// Token: 0x06022912 RID: 141586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022912")]
			[Address(RVA = "0x1D11880", Offset = "0x1D10480", VA = "0x181D11880")]
			private ClimbTowerMenuButton <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x06022913 RID: 141587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022913")]
			[Address(RVA = "0x1D11860", Offset = "0x1D10460", VA = "0x181D11860")]
			private Action <>xLuaBaseProxy_get_buttonCallback()
			{
				return null;
			}

			// Token: 0x0402F823 RID: 194595
			[Token(Token = "0x402F823")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerInitCurseDisplayState m_closure;

			// Token: 0x0402F824 RID: 194596
			[Token(Token = "0x402F824")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F825 RID: 194597
			[Token(Token = "0x402F825")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402F826 RID: 194598
			[Token(Token = "0x402F826")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_hideBuffBtnWithHolder;

			// Token: 0x0402F827 RID: 194599
			[Token(Token = "0x402F827")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_showTrapBtn;

			// Token: 0x0402F828 RID: 194600
			[Token(Token = "0x402F828")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_showSquadBtn;

			// Token: 0x0402F829 RID: 194601
			[Token(Token = "0x402F829")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_showProfessionBtns;

			// Token: 0x0402F82A RID: 194602
			[Token(Token = "0x402F82A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402F82B RID: 194603
			[Token(Token = "0x402F82B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_buttonCallback;
		}
	}
}
