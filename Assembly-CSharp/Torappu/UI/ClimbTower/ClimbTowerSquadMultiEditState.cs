using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D7C RID: 23932
	[Token(Token = "0x2005D7C")]
	public class ClimbTowerSquadMultiEditState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06022AF0 RID: 142064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022AF0")]
		[Address(RVA = "0x1D3F400", Offset = "0x1D3E000", VA = "0x181D3F400", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022AF1 RID: 142065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AF1")]
		[Address(RVA = "0x1D3F5C0", Offset = "0x1D3E1C0", VA = "0x181D3F5C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022AF2 RID: 142066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AF2")]
		[Address(RVA = "0x1D3FD00", Offset = "0x1D3E900", VA = "0x181D3FD00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022AF3 RID: 142067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022AF3")]
		[Address(RVA = "0x1D3FBA0", Offset = "0x1D3E7A0", VA = "0x181D3FBA0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06022AF4 RID: 142068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AF4")]
		[Address(RVA = "0x1D3FFD0", Offset = "0x1D3EBD0", VA = "0x181D3FFD0")]
		private void _NavToEditState(IStateBean stateBean)
		{
		}

		// Token: 0x06022AF5 RID: 142069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AF5")]
		[Address(RVA = "0x1D3F460", Offset = "0x1D3E060", VA = "0x181D3F460")]
		public void OnEditTypeSwitch()
		{
		}

		// Token: 0x06022AF6 RID: 142070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AF6")]
		[Address(RVA = "0x1D403A0", Offset = "0x1D3EFA0", VA = "0x181D403A0")]
		private void _OnProfessionClicked(ProfessionCategory profession)
		{
		}

		// Token: 0x06022AF7 RID: 142071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AF7")]
		[Address(RVA = "0x1D40120", Offset = "0x1D3ED20", VA = "0x181D40120")]
		private void _OnConfirmBtnClicked()
		{
		}

		// Token: 0x06022AF8 RID: 142072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AF8")]
		[Address(RVA = "0x1D40510", Offset = "0x1D3F110", VA = "0x181D40510")]
		private void _OnSkillSelect(int cardId, string skillId)
		{
		}

		// Token: 0x06022AF9 RID: 142073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AF9")]
		[Address(RVA = "0x1D401C0", Offset = "0x1D3EDC0", VA = "0x181D401C0")]
		private void _OnEquipSelect(int cardId, string equipId)
		{
		}

		// Token: 0x06022AFA RID: 142074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AFA")]
		[Address(RVA = "0x1D3F9F0", Offset = "0x1D3E5F0", VA = "0x181D3F9F0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06022AFB RID: 142075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AFB")]
		[Address(RVA = "0x1D406F0", Offset = "0x1D3F2F0", VA = "0x181D406F0")]
		private void _SetScrollViewDragDelegate(UIWrappedScrollRect equipScrollRect)
		{
		}

		// Token: 0x06022AFC RID: 142076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AFC")]
		[Address(RVA = "0x1D40780", Offset = "0x1D3F380", VA = "0x181D40780")]
		public ClimbTowerSquadMultiEditState()
		{
		}

		// Token: 0x06022AFD RID: 142077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AFD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022AFE RID: 142078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022AFE")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402FAF6 RID: 195318
		[Token(Token = "0x402FAF6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerSquadMultiEditView _view;

		// Token: 0x0402FAF7 RID: 195319
		[Token(Token = "0x402FAF7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerMenuButton _menuButtonPrefab;

		// Token: 0x0402FAF8 RID: 195320
		[Token(Token = "0x402FAF8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402FAF9 RID: 195321
		[Token(Token = "0x402FAF9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402FAFA RID: 195322
		[Token(Token = "0x402FAFA")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerSquadMultiEditStateBean m_stateBean;

		// Token: 0x0402FAFB RID: 195323
		[Token(Token = "0x402FAFB")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402FAFC RID: 195324
		[Token(Token = "0x402FAFC")]
		[FieldOffset(Offset = "0xA0")]
		private ClimbTowerSquadMultiEditState.MenuAdapter m_menuAdapter;

		// Token: 0x0402FAFD RID: 195325
		[Token(Token = "0x402FAFD")]
		[NonSerialized]
		public const int SET_EQUIP_SCROLL_DRAG_DELEGATE = 1;

		// Token: 0x0402FAFE RID: 195326
		[Token(Token = "0x402FAFE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402FAFF RID: 195327
		[Token(Token = "0x402FAFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402FB00 RID: 195328
		[Token(Token = "0x402FB00")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FB01 RID: 195329
		[Token(Token = "0x402FB01")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402FB02 RID: 195330
		[Token(Token = "0x402FB02")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NavToEditState;

		// Token: 0x0402FB03 RID: 195331
		[Token(Token = "0x402FB03")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEditTypeSwitch;

		// Token: 0x0402FB04 RID: 195332
		[Token(Token = "0x402FB04")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnProfessionClicked;

		// Token: 0x0402FB05 RID: 195333
		[Token(Token = "0x402FB05")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnConfirmBtnClicked;

		// Token: 0x0402FB06 RID: 195334
		[Token(Token = "0x402FB06")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnSkillSelect;

		// Token: 0x0402FB07 RID: 195335
		[Token(Token = "0x402FB07")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnEquipSelect;

		// Token: 0x0402FB08 RID: 195336
		[Token(Token = "0x402FB08")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402FB09 RID: 195337
		[Token(Token = "0x402FB09")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetScrollViewDragDelegate;

		// Token: 0x0402FB0A RID: 195338
		[Token(Token = "0x402FB0A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D7D RID: 23933
		[Token(Token = "0x2005D7D")]
		private class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x06022AFF RID: 142079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022AFF")]
			[Address(RVA = "0x1D472A0", Offset = "0x1D45EA0", VA = "0x181D472A0")]
			public MenuAdapter(ClimbTowerSquadMultiEditState closure)
			{
			}

			// Token: 0x170051CE RID: 20942
			// (get) Token: 0x06022B00 RID: 142080 RVA: 0x000BE680 File Offset: 0x000BC880
			[Token(Token = "0x170051CE")]
			public override bool showMenu
			{
				[Token(Token = "0x6022B00")]
				[Address(RVA = "0x1D47A50", Offset = "0x1D46650", VA = "0x181D47A50", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170051CF RID: 20943
			// (get) Token: 0x06022B01 RID: 142081 RVA: 0x000BE698 File Offset: 0x000BC898
			[Token(Token = "0x170051CF")]
			public override ClimbTowerTrapMenuObject.ButtonState trapBtnState
			{
				[Token(Token = "0x6022B01")]
				[Address(RVA = "0x1D47CA0", Offset = "0x1D468A0", VA = "0x181D47CA0", Slot = "9")]
				get
				{
					return ClimbTowerTrapMenuObject.ButtonState.NORMAL;
				}
			}

			// Token: 0x170051D0 RID: 20944
			// (get) Token: 0x06022B02 RID: 142082 RVA: 0x000BE6B0 File Offset: 0x000BC8B0
			[Token(Token = "0x170051D0")]
			public override ClimbTowerSquadMenuObject.ButtonState squadBtnState
			{
				[Token(Token = "0x6022B02")]
				[Address(RVA = "0x1D47C40", Offset = "0x1D46840", VA = "0x181D47C40", Slot = "10")]
				get
				{
					return ClimbTowerSquadMenuObject.ButtonState.NORMAL;
				}
			}

			// Token: 0x170051D1 RID: 20945
			// (get) Token: 0x06022B03 RID: 142083 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051D1")]
			public override ClimbTowerMenuButton buttonPrefab
			{
				[Token(Token = "0x6022B03")]
				[Address(RVA = "0x1D47760", Offset = "0x1D46360", VA = "0x181D47760", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x170051D2 RID: 20946
			// (get) Token: 0x06022B04 RID: 142084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051D2")]
			public override Action buttonCallback
			{
				[Token(Token = "0x6022B04")]
				[Address(RVA = "0x1D473A0", Offset = "0x1D45FA0", VA = "0x181D473A0", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x170051D3 RID: 20947
			// (get) Token: 0x06022B05 RID: 142085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051D3")]
			public override Action<ProfessionCategory> onProfessionClickedCallback
			{
				[Token(Token = "0x6022B05")]
				[Address(RVA = "0x1D478F0", Offset = "0x1D464F0", VA = "0x181D478F0", Slot = "13")]
				get
				{
					return null;
				}
			}

			// Token: 0x06022B06 RID: 142086 RVA: 0x000BE6C8 File Offset: 0x000BC8C8
			[Token(Token = "0x6022B06")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x06022B07 RID: 142087 RVA: 0x000BE6E0 File Offset: 0x000BC8E0
			[Token(Token = "0x6022B07")]
			[Address(RVA = "0x1D118F0", Offset = "0x1D104F0", VA = "0x181D118F0")]
			private ClimbTowerTrapMenuObject.ButtonState <>xLuaBaseProxy_get_trapBtnState()
			{
				return ClimbTowerTrapMenuObject.ButtonState.NORMAL;
			}

			// Token: 0x06022B08 RID: 142088 RVA: 0x000BE6F8 File Offset: 0x000BC8F8
			[Token(Token = "0x6022B08")]
			[Address(RVA = "0x1D47210", Offset = "0x1D45E10", VA = "0x181D47210")]
			private ClimbTowerSquadMenuObject.ButtonState <>xLuaBaseProxy_get_squadBtnState()
			{
				return ClimbTowerSquadMenuObject.ButtonState.NORMAL;
			}

			// Token: 0x06022B09 RID: 142089 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022B09")]
			[Address(RVA = "0x1D11880", Offset = "0x1D10480", VA = "0x181D11880")]
			private ClimbTowerMenuButton <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x06022B0A RID: 142090 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022B0A")]
			[Address(RVA = "0x1D11860", Offset = "0x1D10460", VA = "0x181D11860")]
			private Action <>xLuaBaseProxy_get_buttonCallback()
			{
				return null;
			}

			// Token: 0x06022B0B RID: 142091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022B0B")]
			[Address(RVA = "0x1D47200", Offset = "0x1D45E00", VA = "0x181D47200")]
			private Action<ProfessionCategory> <>xLuaBaseProxy_get_onProfessionClickedCallback()
			{
				return null;
			}

			// Token: 0x0402FB0B RID: 195339
			[Token(Token = "0x402FB0B")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerSquadMultiEditState m_closure;

			// Token: 0x0402FB0C RID: 195340
			[Token(Token = "0x402FB0C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FB0D RID: 195341
			[Token(Token = "0x402FB0D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402FB0E RID: 195342
			[Token(Token = "0x402FB0E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_trapBtnState;

			// Token: 0x0402FB0F RID: 195343
			[Token(Token = "0x402FB0F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_squadBtnState;

			// Token: 0x0402FB10 RID: 195344
			[Token(Token = "0x402FB10")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402FB11 RID: 195345
			[Token(Token = "0x402FB11")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_buttonCallback;

			// Token: 0x0402FB12 RID: 195346
			[Token(Token = "0x402FB12")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_onProfessionClickedCallback;
		}
	}
}
