using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D8B RID: 23947
	[Token(Token = "0x2005D8B")]
	public class ClimbTowerSquadSingleEditState : PopupFadeState
	{
		// Token: 0x06022B5F RID: 142175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B5F")]
		[Address(RVA = "0x1D454C0", Offset = "0x1D440C0", VA = "0x181D454C0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06022B60 RID: 142176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B60")]
		[Address(RVA = "0x1D45600", Offset = "0x1D44200", VA = "0x181D45600", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06022B61 RID: 142177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B61")]
		[Address(RVA = "0x1D44D30", Offset = "0x1D43930", VA = "0x181D44D30", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06022B62 RID: 142178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B62")]
		[Address(RVA = "0x1D44E70", Offset = "0x1D43A70", VA = "0x181D44E70", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06022B63 RID: 142179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B63")]
		[Address(RVA = "0x1D44CD0", Offset = "0x1D438D0", VA = "0x181D44CD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022B64 RID: 142180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B64")]
		[Address(RVA = "0x1D44F90", Offset = "0x1D43B90", VA = "0x181D44F90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022B65 RID: 142181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B65")]
		[Address(RVA = "0x1D45360", Offset = "0x1D43F60", VA = "0x181D45360", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06022B66 RID: 142182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B66")]
		[Address(RVA = "0x1D45BB0", Offset = "0x1D447B0", VA = "0x181D45BB0")]
		private void _NavToEditState(IStateBean stateBean)
		{
		}

		// Token: 0x06022B67 RID: 142183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B67")]
		[Address(RVA = "0x1D45720", Offset = "0x1D44320", VA = "0x181D45720")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022B68 RID: 142184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B68")]
		[Address(RVA = "0x1D45D20", Offset = "0x1D44920", VA = "0x181D45D20")]
		private void _OnCharSelect(int cardId)
		{
		}

		// Token: 0x06022B69 RID: 142185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B69")]
		[Address(RVA = "0x1D46010", Offset = "0x1D44C10", VA = "0x181D46010")]
		private void _OnProfessionClicked(ProfessionCategory profession)
		{
		}

		// Token: 0x06022B6A RID: 142186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B6A")]
		[Address(RVA = "0x1D45F80", Offset = "0x1D44B80", VA = "0x181D45F80")]
		private void _OnConfirmBtnClicked()
		{
		}

		// Token: 0x06022B6B RID: 142187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B6B")]
		[Address(RVA = "0x1D44A60", Offset = "0x1D43660", VA = "0x181D44A60")]
		public void EventOnAttrTabClick(CharAttrTabType tabType)
		{
		}

		// Token: 0x06022B6C RID: 142188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B6C")]
		[Address(RVA = "0x1D44C30", Offset = "0x1D43830", VA = "0x181D44C30")]
		public void EventOnSkillSelect(string skillId)
		{
		}

		// Token: 0x06022B6D RID: 142189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B6D")]
		[Address(RVA = "0x1D44B90", Offset = "0x1D43790", VA = "0x181D44B90")]
		public void EventOnBranchSelect(string equipId)
		{
		}

		// Token: 0x06022B6E RID: 142190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B6E")]
		[Address(RVA = "0x1D46100", Offset = "0x1D44D00", VA = "0x181D46100")]
		public ClimbTowerSquadSingleEditState()
		{
		}

		// Token: 0x06022B6F RID: 142191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B6F")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x06022B70 RID: 142192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B70")]
		[Address(RVA = "0x12B83C0", Offset = "0x12B6FC0", VA = "0x1812B83C0")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x06022B71 RID: 142193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B71")]
		[Address(RVA = "0x180FDD0", Offset = "0x180E9D0", VA = "0x18180FDD0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x06022B72 RID: 142194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B72")]
		[Address(RVA = "0x180FE00", Offset = "0x180EA00", VA = "0x18180FE00")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x06022B73 RID: 142195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B73")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022B74 RID: 142196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B74")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402FB8E RID: 195470
		[Token(Token = "0x402FB8E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerSquadSingleEditView _view;

		// Token: 0x0402FB8F RID: 195471
		[Token(Token = "0x402FB8F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharSelectAttrController _attrController;

		// Token: 0x0402FB90 RID: 195472
		[Token(Token = "0x402FB90")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CharSelectAttrTabItem[] _tabItems;

		// Token: 0x0402FB91 RID: 195473
		[Token(Token = "0x402FB91")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ClimbTowerMenuButton _menuButtonPrefab;

		// Token: 0x0402FB92 RID: 195474
		[Token(Token = "0x402FB92")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402FB93 RID: 195475
		[Token(Token = "0x402FB93")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _attrPanelEnterAnim;

		// Token: 0x0402FB94 RID: 195476
		[Token(Token = "0x402FB94")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerSquadSingleEditStateBean m_stateBean;

		// Token: 0x0402FB95 RID: 195477
		[Token(Token = "0x402FB95")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x0402FB96 RID: 195478
		[Token(Token = "0x402FB96")]
		[FieldOffset(Offset = "0xB8")]
		private ClimbTowerSquadSingleEditState.MenuAdapter m_menuAdapter;

		// Token: 0x0402FB97 RID: 195479
		[Token(Token = "0x402FB97")]
		[FieldOffset(Offset = "0xC0")]
		private AnimationSwitchTween m_attrEnterSwitchTween;

		// Token: 0x0402FB98 RID: 195480
		[Token(Token = "0x402FB98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402FB99 RID: 195481
		[Token(Token = "0x402FB99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0402FB9A RID: 195482
		[Token(Token = "0x402FB9A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0402FB9B RID: 195483
		[Token(Token = "0x402FB9B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0402FB9C RID: 195484
		[Token(Token = "0x402FB9C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402FB9D RID: 195485
		[Token(Token = "0x402FB9D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402FB9E RID: 195486
		[Token(Token = "0x402FB9E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402FB9F RID: 195487
		[Token(Token = "0x402FB9F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__NavToEditState;

		// Token: 0x0402FBA0 RID: 195488
		[Token(Token = "0x402FBA0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FBA1 RID: 195489
		[Token(Token = "0x402FBA1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCharSelect;

		// Token: 0x0402FBA2 RID: 195490
		[Token(Token = "0x402FBA2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnProfessionClicked;

		// Token: 0x0402FBA3 RID: 195491
		[Token(Token = "0x402FBA3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnConfirmBtnClicked;

		// Token: 0x0402FBA4 RID: 195492
		[Token(Token = "0x402FBA4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnAttrTabClick;

		// Token: 0x0402FBA5 RID: 195493
		[Token(Token = "0x402FBA5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnSkillSelect;

		// Token: 0x0402FBA6 RID: 195494
		[Token(Token = "0x402FBA6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnBranchSelect;

		// Token: 0x0402FBA7 RID: 195495
		[Token(Token = "0x402FBA7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D8C RID: 23948
		[Token(Token = "0x2005D8C")]
		private class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x06022B75 RID: 142197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022B75")]
			[Address(RVA = "0x1D47220", Offset = "0x1D45E20", VA = "0x181D47220")]
			public MenuAdapter(ClimbTowerSquadSingleEditState closure)
			{
			}

			// Token: 0x170051ED RID: 20973
			// (get) Token: 0x06022B76 RID: 142198 RVA: 0x000BE8F0 File Offset: 0x000BCAF0
			[Token(Token = "0x170051ED")]
			public override bool showMenu
			{
				[Token(Token = "0x6022B76")]
				[Address(RVA = "0x1D47AB0", Offset = "0x1D466B0", VA = "0x181D47AB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170051EE RID: 20974
			// (get) Token: 0x06022B77 RID: 142199 RVA: 0x000BE908 File Offset: 0x000BCB08
			[Token(Token = "0x170051EE")]
			public override ClimbTowerTrapMenuObject.ButtonState trapBtnState
			{
				[Token(Token = "0x6022B77")]
				[Address(RVA = "0x1D47D00", Offset = "0x1D46900", VA = "0x181D47D00", Slot = "9")]
				get
				{
					return ClimbTowerTrapMenuObject.ButtonState.NORMAL;
				}
			}

			// Token: 0x170051EF RID: 20975
			// (get) Token: 0x06022B78 RID: 142200 RVA: 0x000BE920 File Offset: 0x000BCB20
			[Token(Token = "0x170051EF")]
			public override ClimbTowerSquadMenuObject.ButtonState squadBtnState
			{
				[Token(Token = "0x6022B78")]
				[Address(RVA = "0x1D47B70", Offset = "0x1D46770", VA = "0x181D47B70", Slot = "10")]
				get
				{
					return ClimbTowerSquadMenuObject.ButtonState.NORMAL;
				}
			}

			// Token: 0x170051F0 RID: 20976
			// (get) Token: 0x06022B79 RID: 142201 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051F0")]
			public override ClimbTowerMenuButton buttonPrefab
			{
				[Token(Token = "0x6022B79")]
				[Address(RVA = "0x1D477D0", Offset = "0x1D463D0", VA = "0x181D477D0", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x170051F1 RID: 20977
			// (get) Token: 0x06022B7A RID: 142202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051F1")]
			public override Action buttonCallback
			{
				[Token(Token = "0x6022B7A")]
				[Address(RVA = "0x1D47520", Offset = "0x1D46120", VA = "0x181D47520", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x170051F2 RID: 20978
			// (get) Token: 0x06022B7B RID: 142203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051F2")]
			public override Action<ProfessionCategory> onProfessionClickedCallback
			{
				[Token(Token = "0x6022B7B")]
				[Address(RVA = "0x1D479A0", Offset = "0x1D465A0", VA = "0x181D479A0", Slot = "13")]
				get
				{
					return null;
				}
			}

			// Token: 0x06022B7C RID: 142204 RVA: 0x000BE938 File Offset: 0x000BCB38
			[Token(Token = "0x6022B7C")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x06022B7D RID: 142205 RVA: 0x000BE950 File Offset: 0x000BCB50
			[Token(Token = "0x6022B7D")]
			[Address(RVA = "0x1D118F0", Offset = "0x1D104F0", VA = "0x181D118F0")]
			private ClimbTowerTrapMenuObject.ButtonState <>xLuaBaseProxy_get_trapBtnState()
			{
				return ClimbTowerTrapMenuObject.ButtonState.NORMAL;
			}

			// Token: 0x06022B7E RID: 142206 RVA: 0x000BE968 File Offset: 0x000BCB68
			[Token(Token = "0x6022B7E")]
			[Address(RVA = "0x1D47210", Offset = "0x1D45E10", VA = "0x181D47210")]
			private ClimbTowerSquadMenuObject.ButtonState <>xLuaBaseProxy_get_squadBtnState()
			{
				return ClimbTowerSquadMenuObject.ButtonState.NORMAL;
			}

			// Token: 0x06022B7F RID: 142207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022B7F")]
			[Address(RVA = "0x1D11880", Offset = "0x1D10480", VA = "0x181D11880")]
			private ClimbTowerMenuButton <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x06022B80 RID: 142208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022B80")]
			[Address(RVA = "0x1D11860", Offset = "0x1D10460", VA = "0x181D11860")]
			private Action <>xLuaBaseProxy_get_buttonCallback()
			{
				return null;
			}

			// Token: 0x06022B81 RID: 142209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022B81")]
			[Address(RVA = "0x1D47200", Offset = "0x1D45E00", VA = "0x181D47200")]
			private Action<ProfessionCategory> <>xLuaBaseProxy_get_onProfessionClickedCallback()
			{
				return null;
			}

			// Token: 0x0402FBA8 RID: 195496
			[Token(Token = "0x402FBA8")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerSquadSingleEditState m_closure;

			// Token: 0x0402FBA9 RID: 195497
			[Token(Token = "0x402FBA9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FBAA RID: 195498
			[Token(Token = "0x402FBAA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402FBAB RID: 195499
			[Token(Token = "0x402FBAB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_trapBtnState;

			// Token: 0x0402FBAC RID: 195500
			[Token(Token = "0x402FBAC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_squadBtnState;

			// Token: 0x0402FBAD RID: 195501
			[Token(Token = "0x402FBAD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402FBAE RID: 195502
			[Token(Token = "0x402FBAE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_buttonCallback;

			// Token: 0x0402FBAF RID: 195503
			[Token(Token = "0x402FBAF")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_onProfessionClickedCallback;
		}
	}
}
