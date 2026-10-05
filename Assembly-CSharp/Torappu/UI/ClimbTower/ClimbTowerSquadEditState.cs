using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D69 RID: 23913
	[Token(Token = "0x2005D69")]
	public class ClimbTowerSquadEditState : PopupFadeState
	{
		// Token: 0x06022A4D RID: 141901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A4D")]
		[Address(RVA = "0x1D27560", Offset = "0x1D26160", VA = "0x181D27560", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022A4E RID: 141902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A4E")]
		[Address(RVA = "0x1D27A20", Offset = "0x1D26620", VA = "0x181D27A20", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06022A4F RID: 141903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A4F")]
		[Address(RVA = "0x1D27AA0", Offset = "0x1D266A0", VA = "0x181D27AA0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022A50 RID: 141904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A50")]
		[Address(RVA = "0x1D27D00", Offset = "0x1D26900", VA = "0x181D27D00", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06022A51 RID: 141905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A51")]
		[Address(RVA = "0x1D290C0", Offset = "0x1D27CC0", VA = "0x181D290C0")]
		private void _NavToSingleEditState(IStateBean stateBean)
		{
		}

		// Token: 0x06022A52 RID: 141906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A52")]
		[Address(RVA = "0x1D28FB0", Offset = "0x1D27BB0", VA = "0x181D28FB0")]
		private void _NavToMultiEditState(IStateBean stateBean)
		{
		}

		// Token: 0x06022A53 RID: 141907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A53")]
		[Address(RVA = "0x1D273A0", Offset = "0x1D25FA0", VA = "0x181D273A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022A54 RID: 141908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A54")]
		[Address(RVA = "0x1D29300", Offset = "0x1D27F00", VA = "0x181D29300")]
		private void _OnProfessionClicked(ProfessionCategory profession)
		{
		}

		// Token: 0x06022A55 RID: 141909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A55")]
		[Address(RVA = "0x1D293E0", Offset = "0x1D27FE0", VA = "0x181D293E0")]
		private void _OnStartBtnClicked()
		{
		}

		// Token: 0x06022A56 RID: 141910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A56")]
		[Address(RVA = "0x1D274D0", Offset = "0x1D260D0", VA = "0x181D274D0")]
		public void OnBtnMultiEdit()
		{
		}

		// Token: 0x06022A57 RID: 141911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A57")]
		[Address(RVA = "0x1D27400", Offset = "0x1D26000", VA = "0x181D27400")]
		public void OnBtnBack()
		{
		}

		// Token: 0x06022A58 RID: 141912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A58")]
		[Address(RVA = "0x1D29690", Offset = "0x1D28290", VA = "0x181D29690")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x06022A59 RID: 141913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A59")]
		[Address(RVA = "0x1D295E0", Offset = "0x1D281E0", VA = "0x181D295E0")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x06022A5A RID: 141914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A5A")]
		[Address(RVA = "0x1D297C0", Offset = "0x1D283C0", VA = "0x181D297C0")]
		private IEnumerator _WaitAndRaiseAVGSignal()
		{
			return null;
		}

		// Token: 0x06022A5B RID: 141915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A5B")]
		[Address(RVA = "0x1D28BF0", Offset = "0x1D277F0", VA = "0x181D28BF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022A5C RID: 141916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A5C")]
		[Address(RVA = "0x1D291A0", Offset = "0x1D27DA0", VA = "0x181D291A0")]
		private void _OnCharEdit(int cardId)
		{
		}

		// Token: 0x06022A5D RID: 141917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A5D")]
		[Address(RVA = "0x1D28860", Offset = "0x1D27460", VA = "0x181D28860")]
		private void _DoStartBattle()
		{
		}

		// Token: 0x06022A5E RID: 141918 RVA: 0x000BE3C8 File Offset: 0x000BC5C8
		[Token(Token = "0x6022A5E")]
		[Address(RVA = "0x1D27ED0", Offset = "0x1D26AD0", VA = "0x181D27ED0")]
		private bool _CheckIfStartBattleValid()
		{
			return default(bool);
		}

		// Token: 0x06022A5F RID: 141919 RVA: 0x000BE3E0 File Offset: 0x000BC5E0
		[Token(Token = "0x6022A5F")]
		[Address(RVA = "0x1D27F60", Offset = "0x1D26B60", VA = "0x181D27F60")]
		private BattleStartController.Param _CreateParamToStartBattle()
		{
			return default(BattleStartController.Param);
		}

		// Token: 0x06022A60 RID: 141920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A60")]
		[Address(RVA = "0x1D29440", Offset = "0x1D28040", VA = "0x181D29440")]
		private static CharacterCardViewModel _PickRandomCharacter(SquadItemStruct[] squad)
		{
			return null;
		}

		// Token: 0x06022A61 RID: 141921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A61")]
		[Address(RVA = "0x1D28D70", Offset = "0x1D27970", VA = "0x181D28D70")]
		private void _InvokedStartBattle(BattleStartController.Param param)
		{
		}

		// Token: 0x06022A62 RID: 141922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A62")]
		[Address(RVA = "0x1D29380", Offset = "0x1D27F80", VA = "0x181D29380")]
		private void _OnStartBattleSuccess()
		{
		}

		// Token: 0x06022A63 RID: 141923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A63")]
		[Address(RVA = "0x1D29870", Offset = "0x1D28470", VA = "0x181D29870")]
		public ClimbTowerSquadEditState()
		{
		}

		// Token: 0x06022A64 RID: 141924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A64")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022A65 RID: 141925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A65")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x06022A66 RID: 141926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A66")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06022A67 RID: 141927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A67")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402F9E4 RID: 195044
		[Token(Token = "0x402F9E4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerSquadEditView _view;

		// Token: 0x0402F9E5 RID: 195045
		[Token(Token = "0x402F9E5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerMenuButton _menuButtonPrefab;

		// Token: 0x0402F9E6 RID: 195046
		[Token(Token = "0x402F9E6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _multiEditBtnGo;

		// Token: 0x0402F9E7 RID: 195047
		[Token(Token = "0x402F9E7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _disableEditGo;

		// Token: 0x0402F9E8 RID: 195048
		[Token(Token = "0x402F9E8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402F9E9 RID: 195049
		[Token(Token = "0x402F9E9")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402F9EA RID: 195050
		[Token(Token = "0x402F9EA")]
		[FieldOffset(Offset = "0xA0")]
		private ClimbTowerSquadEditStateBean m_stateBean;

		// Token: 0x0402F9EB RID: 195051
		[Token(Token = "0x402F9EB")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cacheCardId;

		// Token: 0x0402F9EC RID: 195052
		[Token(Token = "0x402F9EC")]
		[FieldOffset(Offset = "0xB0")]
		private ClimbTowerSquadEditState.MenuAdapter m_menuAdapter;

		// Token: 0x0402F9ED RID: 195053
		[Token(Token = "0x402F9ED")]
		[FieldOffset(Offset = "0xB8")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402F9EE RID: 195054
		[Token(Token = "0x402F9EE")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isForcedOpen;

		// Token: 0x0402F9EF RID: 195055
		[Token(Token = "0x402F9EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F9F0 RID: 195056
		[Token(Token = "0x402F9F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402F9F1 RID: 195057
		[Token(Token = "0x402F9F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F9F2 RID: 195058
		[Token(Token = "0x402F9F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F9F3 RID: 195059
		[Token(Token = "0x402F9F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NavToSingleEditState;

		// Token: 0x0402F9F4 RID: 195060
		[Token(Token = "0x402F9F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NavToMultiEditState;

		// Token: 0x0402F9F5 RID: 195061
		[Token(Token = "0x402F9F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F9F6 RID: 195062
		[Token(Token = "0x402F9F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnProfessionClicked;

		// Token: 0x0402F9F7 RID: 195063
		[Token(Token = "0x402F9F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnStartBtnClicked;

		// Token: 0x0402F9F8 RID: 195064
		[Token(Token = "0x402F9F8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBtnMultiEdit;

		// Token: 0x0402F9F9 RID: 195065
		[Token(Token = "0x402F9F9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnBack;

		// Token: 0x0402F9FA RID: 195066
		[Token(Token = "0x402F9FA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x0402F9FB RID: 195067
		[Token(Token = "0x402F9FB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402F9FC RID: 195068
		[Token(Token = "0x402F9FC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__WaitAndRaiseAVGSignal;

		// Token: 0x0402F9FD RID: 195069
		[Token(Token = "0x402F9FD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F9FE RID: 195070
		[Token(Token = "0x402F9FE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCharEdit;

		// Token: 0x0402F9FF RID: 195071
		[Token(Token = "0x402F9FF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DoStartBattle;

		// Token: 0x0402FA00 RID: 195072
		[Token(Token = "0x402FA00")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckIfStartBattleValid;

		// Token: 0x0402FA01 RID: 195073
		[Token(Token = "0x402FA01")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CreateParamToStartBattle;

		// Token: 0x0402FA02 RID: 195074
		[Token(Token = "0x402FA02")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__PickRandomCharacter;

		// Token: 0x0402FA03 RID: 195075
		[Token(Token = "0x402FA03")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InvokedStartBattle;

		// Token: 0x0402FA04 RID: 195076
		[Token(Token = "0x402FA04")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnStartBattleSuccess;

		// Token: 0x0402FA05 RID: 195077
		[Token(Token = "0x402FA05")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D6A RID: 23914
		[Token(Token = "0x2005D6A")]
		private class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x06022A68 RID: 141928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022A68")]
			[Address(RVA = "0x1D47320", Offset = "0x1D45F20", VA = "0x181D47320")]
			public MenuAdapter(ClimbTowerSquadEditState closure)
			{
			}

			// Token: 0x170051A8 RID: 20904
			// (get) Token: 0x06022A69 RID: 141929 RVA: 0x000BE3F8 File Offset: 0x000BC5F8
			[Token(Token = "0x170051A8")]
			public override bool showMenu
			{
				[Token(Token = "0x6022A69")]
				[Address(RVA = "0x1D47B10", Offset = "0x1D46710", VA = "0x181D47B10", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170051A9 RID: 20905
			// (get) Token: 0x06022A6A RID: 141930 RVA: 0x000BE410 File Offset: 0x000BC610
			[Token(Token = "0x170051A9")]
			public override ClimbTowerSquadMenuObject.ButtonState squadBtnState
			{
				[Token(Token = "0x6022A6A")]
				[Address(RVA = "0x1D47BD0", Offset = "0x1D467D0", VA = "0x181D47BD0", Slot = "10")]
				get
				{
					return ClimbTowerSquadMenuObject.ButtonState.NORMAL;
				}
			}

			// Token: 0x170051AA RID: 20906
			// (get) Token: 0x06022A6B RID: 141931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051AA")]
			public override ClimbTowerMenuButton buttonPrefab
			{
				[Token(Token = "0x6022A6B")]
				[Address(RVA = "0x1D476E0", Offset = "0x1D462E0", VA = "0x181D476E0", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x170051AB RID: 20907
			// (get) Token: 0x06022A6C RID: 141932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051AB")]
			public override IClimbTowerMenuButtonDataSource buttonDataSource
			{
				[Token(Token = "0x6022A6C")]
				[Address(RVA = "0x1D475D0", Offset = "0x1D461D0", VA = "0x181D475D0", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x170051AC RID: 20908
			// (get) Token: 0x06022A6D RID: 141933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051AC")]
			public override Action buttonCallback
			{
				[Token(Token = "0x6022A6D")]
				[Address(RVA = "0x1D47450", Offset = "0x1D46050", VA = "0x181D47450", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x170051AD RID: 20909
			// (get) Token: 0x06022A6E RID: 141934 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170051AD")]
			public override Action<ProfessionCategory> onProfessionClickedCallback
			{
				[Token(Token = "0x6022A6E")]
				[Address(RVA = "0x1D47840", Offset = "0x1D46440", VA = "0x181D47840", Slot = "13")]
				get
				{
					return null;
				}
			}

			// Token: 0x06022A6F RID: 141935 RVA: 0x000BE428 File Offset: 0x000BC628
			[Token(Token = "0x6022A6F")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x06022A70 RID: 141936 RVA: 0x000BE440 File Offset: 0x000BC640
			[Token(Token = "0x6022A70")]
			[Address(RVA = "0x1D47210", Offset = "0x1D45E10", VA = "0x181D47210")]
			private ClimbTowerSquadMenuObject.ButtonState <>xLuaBaseProxy_get_squadBtnState()
			{
				return ClimbTowerSquadMenuObject.ButtonState.NORMAL;
			}

			// Token: 0x06022A71 RID: 141937 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022A71")]
			[Address(RVA = "0x1D11880", Offset = "0x1D10480", VA = "0x181D11880")]
			private ClimbTowerMenuButton <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x06022A72 RID: 141938 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022A72")]
			[Address(RVA = "0x1D11870", Offset = "0x1D10470", VA = "0x181D11870")]
			private IClimbTowerMenuButtonDataSource <>xLuaBaseProxy_get_buttonDataSource()
			{
				return null;
			}

			// Token: 0x06022A73 RID: 141939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022A73")]
			[Address(RVA = "0x1D11860", Offset = "0x1D10460", VA = "0x181D11860")]
			private Action <>xLuaBaseProxy_get_buttonCallback()
			{
				return null;
			}

			// Token: 0x06022A74 RID: 141940 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022A74")]
			[Address(RVA = "0x1D47200", Offset = "0x1D45E00", VA = "0x181D47200")]
			private Action<ProfessionCategory> <>xLuaBaseProxy_get_onProfessionClickedCallback()
			{
				return null;
			}

			// Token: 0x0402FA06 RID: 195078
			[Token(Token = "0x402FA06")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerSquadEditState m_closure;

			// Token: 0x0402FA07 RID: 195079
			[Token(Token = "0x402FA07")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FA08 RID: 195080
			[Token(Token = "0x402FA08")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402FA09 RID: 195081
			[Token(Token = "0x402FA09")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_squadBtnState;

			// Token: 0x0402FA0A RID: 195082
			[Token(Token = "0x402FA0A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402FA0B RID: 195083
			[Token(Token = "0x402FA0B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_buttonDataSource;

			// Token: 0x0402FA0C RID: 195084
			[Token(Token = "0x402FA0C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_buttonCallback;

			// Token: 0x0402FA0D RID: 195085
			[Token(Token = "0x402FA0D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_onProfessionClickedCallback;
		}
	}
}
