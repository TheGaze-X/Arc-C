using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CF4 RID: 23796
	[Token(Token = "0x2005CF4")]
	public class ClimbTowerTrapState : PopupFadeState
	{
		// Token: 0x06022736 RID: 141110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022736")]
		[Address(RVA = "0x1D10200", Offset = "0x1D0EE00", VA = "0x181D10200", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022737 RID: 141111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022737")]
		[Address(RVA = "0x1D10620", Offset = "0x1D0F220", VA = "0x181D10620", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022738 RID: 141112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022738")]
		[Address(RVA = "0x1D106A0", Offset = "0x1D0F2A0", VA = "0x181D106A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022739 RID: 141113 RVA: 0x000BD780 File Offset: 0x000BB980
		[Token(Token = "0x6022739")]
		[Address(RVA = "0x1D10870", Offset = "0x1D0F470", VA = "0x181D10870")]
		private bool _NeedHideBuffBtnWithHolder()
		{
			return default(bool);
		}

		// Token: 0x0602273A RID: 141114 RVA: 0x000BD798 File Offset: 0x000BB998
		[Token(Token = "0x602273A")]
		[Address(RVA = "0x1D109D0", Offset = "0x1D0F5D0", VA = "0x181D109D0")]
		private bool _NeedShowSquadBtn()
		{
			return default(bool);
		}

		// Token: 0x0602273B RID: 141115 RVA: 0x000BD7B0 File Offset: 0x000BB9B0
		[Token(Token = "0x602273B")]
		[Address(RVA = "0x1D10930", Offset = "0x1D0F530", VA = "0x181D10930")]
		private bool _NeedShowProfessionBtns()
		{
			return default(bool);
		}

		// Token: 0x0602273C RID: 141116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602273C")]
		[Address(RVA = "0x1D101A0", Offset = "0x1D0EDA0", VA = "0x181D101A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602273D RID: 141117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602273D")]
		[Address(RVA = "0x1D10A70", Offset = "0x1D0F670", VA = "0x181D10A70")]
		public ClimbTowerTrapState()
		{
		}

		// Token: 0x0602273E RID: 141118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602273E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602273F RID: 141119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602273F")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402F5BB RID: 193979
		[Token(Token = "0x402F5BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _trapGroupList;

		// Token: 0x0402F5BC RID: 193980
		[Token(Token = "0x402F5BC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402F5BD RID: 193981
		[Token(Token = "0x402F5BD")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerTrapStateBean m_stateBean;

		// Token: 0x0402F5BE RID: 193982
		[Token(Token = "0x402F5BE")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402F5BF RID: 193983
		[Token(Token = "0x402F5BF")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerTrapState.Adapter m_adapter;

		// Token: 0x0402F5C0 RID: 193984
		[Token(Token = "0x402F5C0")]
		[FieldOffset(Offset = "0x98")]
		private ClimbTowerTrapState.MenuAdapter m_menuAdapter;

		// Token: 0x0402F5C1 RID: 193985
		[Token(Token = "0x402F5C1")]
		[FieldOffset(Offset = "0xA0")]
		private string m_selectedTrapId;

		// Token: 0x0402F5C2 RID: 193986
		[Token(Token = "0x402F5C2")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerTrapType m_selectCardType;

		// Token: 0x0402F5C3 RID: 193987
		[Token(Token = "0x402F5C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F5C4 RID: 193988
		[Token(Token = "0x402F5C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F5C5 RID: 193989
		[Token(Token = "0x402F5C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F5C6 RID: 193990
		[Token(Token = "0x402F5C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__NeedHideBuffBtnWithHolder;

		// Token: 0x0402F5C7 RID: 193991
		[Token(Token = "0x402F5C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NeedShowSquadBtn;

		// Token: 0x0402F5C8 RID: 193992
		[Token(Token = "0x402F5C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NeedShowProfessionBtns;

		// Token: 0x0402F5C9 RID: 193993
		[Token(Token = "0x402F5C9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F5CA RID: 193994
		[Token(Token = "0x402F5CA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CF5 RID: 23797
		[Token(Token = "0x2005CF5")]
		private class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x06022740 RID: 141120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022740")]
			[Address(RVA = "0x1D11980", Offset = "0x1D10580", VA = "0x181D11980")]
			public MenuAdapter(ClimbTowerTrapState closure)
			{
			}

			// Token: 0x17005106 RID: 20742
			// (get) Token: 0x06022741 RID: 141121 RVA: 0x000BD7C8 File Offset: 0x000BB9C8
			[Token(Token = "0x17005106")]
			public override bool showMenu
			{
				[Token(Token = "0x6022741")]
				[Address(RVA = "0x1D11EE0", Offset = "0x1D10AE0", VA = "0x181D11EE0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005107 RID: 20743
			// (get) Token: 0x06022742 RID: 141122 RVA: 0x000BD7E0 File Offset: 0x000BB9E0
			[Token(Token = "0x17005107")]
			public override bool hideBuffBtnWithHolder
			{
				[Token(Token = "0x6022742")]
				[Address(RVA = "0x1D11C90", Offset = "0x1D10890", VA = "0x181D11C90", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005108 RID: 20744
			// (get) Token: 0x06022743 RID: 141123 RVA: 0x000BD7F8 File Offset: 0x000BB9F8
			[Token(Token = "0x17005108")]
			public override bool showSquadBtn
			{
				[Token(Token = "0x6022743")]
				[Address(RVA = "0x1D12020", Offset = "0x1D10C20", VA = "0x181D12020", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005109 RID: 20745
			// (get) Token: 0x06022744 RID: 141124 RVA: 0x000BD810 File Offset: 0x000BBA10
			[Token(Token = "0x17005109")]
			public override bool showProfessionBtns
			{
				[Token(Token = "0x6022744")]
				[Address(RVA = "0x1D11F40", Offset = "0x1D10B40", VA = "0x181D11F40", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700510A RID: 20746
			// (get) Token: 0x06022745 RID: 141125 RVA: 0x000BD828 File Offset: 0x000BBA28
			[Token(Token = "0x1700510A")]
			public override ClimbTowerTrapMenuObject.ButtonState trapBtnState
			{
				[Token(Token = "0x6022745")]
				[Address(RVA = "0x1D12100", Offset = "0x1D10D00", VA = "0x181D12100", Slot = "9")]
				get
				{
					return ClimbTowerTrapMenuObject.ButtonState.NORMAL;
				}
			}

			// Token: 0x06022746 RID: 141126 RVA: 0x000BD840 File Offset: 0x000BBA40
			[Token(Token = "0x6022746")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x06022747 RID: 141127 RVA: 0x000BD858 File Offset: 0x000BBA58
			[Token(Token = "0x6022747")]
			[Address(RVA = "0x1D11890", Offset = "0x1D10490", VA = "0x181D11890")]
			private bool <>xLuaBaseProxy_get_hideBuffBtnWithHolder()
			{
				return default(bool);
			}

			// Token: 0x06022748 RID: 141128 RVA: 0x000BD870 File Offset: 0x000BBA70
			[Token(Token = "0x6022748")]
			[Address(RVA = "0x1D118E0", Offset = "0x1D104E0", VA = "0x181D118E0")]
			private bool <>xLuaBaseProxy_get_showSquadBtn()
			{
				return default(bool);
			}

			// Token: 0x06022749 RID: 141129 RVA: 0x000BD888 File Offset: 0x000BBA88
			[Token(Token = "0x6022749")]
			[Address(RVA = "0x1D118D0", Offset = "0x1D104D0", VA = "0x181D118D0")]
			private bool <>xLuaBaseProxy_get_showProfessionBtns()
			{
				return default(bool);
			}

			// Token: 0x0602274A RID: 141130 RVA: 0x000BD8A0 File Offset: 0x000BBAA0
			[Token(Token = "0x602274A")]
			[Address(RVA = "0x1D118F0", Offset = "0x1D104F0", VA = "0x181D118F0")]
			private ClimbTowerTrapMenuObject.ButtonState <>xLuaBaseProxy_get_trapBtnState()
			{
				return ClimbTowerTrapMenuObject.ButtonState.NORMAL;
			}

			// Token: 0x0402F5CB RID: 193995
			[Token(Token = "0x402F5CB")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerTrapState m_closure;

			// Token: 0x0402F5CC RID: 193996
			[Token(Token = "0x402F5CC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F5CD RID: 193997
			[Token(Token = "0x402F5CD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402F5CE RID: 193998
			[Token(Token = "0x402F5CE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_hideBuffBtnWithHolder;

			// Token: 0x0402F5CF RID: 193999
			[Token(Token = "0x402F5CF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_showSquadBtn;

			// Token: 0x0402F5D0 RID: 194000
			[Token(Token = "0x402F5D0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_showProfessionBtns;

			// Token: 0x0402F5D1 RID: 194001
			[Token(Token = "0x402F5D1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_trapBtnState;
		}

		// Token: 0x02005CF6 RID: 23798
		[Token(Token = "0x2005CF6")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602274B RID: 141131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602274B")]
			[Address(RVA = "0x1CFD900", Offset = "0x1CFC500", VA = "0x181CFD900")]
			public Adapter(ClimbTowerTrapState closure)
			{
			}

			// Token: 0x1700510B RID: 20747
			// (get) Token: 0x0602274C RID: 141132 RVA: 0x000BD8B8 File Offset: 0x000BBAB8
			[Token(Token = "0x1700510B")]
			public override int count
			{
				[Token(Token = "0x602274C")]
				[Address(RVA = "0x1CFDA10", Offset = "0x1CFC610", VA = "0x181CFDA10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602274D RID: 141133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602274D")]
			[Address(RVA = "0x1CFD650", Offset = "0x1CFC250", VA = "0x181CFD650", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F5D2 RID: 194002
			[Token(Token = "0x402F5D2")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerTrapState m_closure;

			// Token: 0x0402F5D3 RID: 194003
			[Token(Token = "0x402F5D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F5D4 RID: 194004
			[Token(Token = "0x402F5D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F5D5 RID: 194005
			[Token(Token = "0x402F5D5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
