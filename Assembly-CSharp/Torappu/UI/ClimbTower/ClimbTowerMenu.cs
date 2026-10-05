using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CC8 RID: 23752
	[Token(Token = "0x2005CC8")]
	public class ClimbTowerMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x170050D8 RID: 20696
		// (get) Token: 0x06022632 RID: 140850 RVA: 0x000BD4B0 File Offset: 0x000BB6B0
		[Token(Token = "0x170050D8")]
		public bool canClick
		{
			[Token(Token = "0x6022632")]
			[Address(RVA = "0x1CD4660", Offset = "0x1CD3260", VA = "0x181CD4660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170050D9 RID: 20697
		// (get) Token: 0x06022633 RID: 140851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050D9")]
		public ClimbTowerController.ClimbTowerControllerBridge bindControllerBridge
		{
			[Token(Token = "0x6022633")]
			[Address(RVA = "0x1CD45A0", Offset = "0x1CD31A0", VA = "0x181CD45A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050DA RID: 20698
		// (get) Token: 0x06022634 RID: 140852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050DA")]
		public StateEngine bindStateEngine
		{
			[Token(Token = "0x6022634")]
			[Address(RVA = "0x1CD4600", Offset = "0x1CD3200", VA = "0x181CD4600")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050DB RID: 20699
		// (get) Token: 0x06022635 RID: 140853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050DB")]
		public ClimbTowerTrapMenuObject menuTrap
		{
			[Token(Token = "0x6022635")]
			[Address(RVA = "0x1CD4750", Offset = "0x1CD3350", VA = "0x181CD4750")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050DC RID: 20700
		// (get) Token: 0x06022636 RID: 140854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050DC")]
		public ClimbTowerSquadMenuObject menuSquad
		{
			[Token(Token = "0x6022636")]
			[Address(RVA = "0x1CD46F0", Offset = "0x1CD32F0", VA = "0x181CD46F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022637 RID: 140855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022637")]
		[Address(RVA = "0x1CD32D0", Offset = "0x1CD1ED0", VA = "0x181CD32D0")]
		public void RegisterMenuAdapter(Type stateType, ClimbTowerMenuAdapter adapter)
		{
		}

		// Token: 0x06022638 RID: 140856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022638")]
		[Address(RVA = "0x1CD33B0", Offset = "0x1CD1FB0", VA = "0x181CD33B0")]
		private ClimbTowerMenuAdapter _GetStateMenuAdapter(Type stateType)
		{
			return null;
		}

		// Token: 0x06022639 RID: 140857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022639")]
		[Address(RVA = "0x1CD4150", Offset = "0x1CD2D50", VA = "0x181CD4150")]
		private void _Render()
		{
		}

		// Token: 0x0602263A RID: 140858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602263A")]
		[Address(RVA = "0x1CD35E0", Offset = "0x1CD21E0", VA = "0x181CD35E0")]
		private void _OnPlayerDataChanged(object arg)
		{
		}

		// Token: 0x0602263B RID: 140859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602263B")]
		[Address(RVA = "0x1CD3950", Offset = "0x1CD2550", VA = "0x181CD3950")]
		private void _RefreshView(bool fastMode)
		{
		}

		// Token: 0x0602263C RID: 140860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602263C")]
		[Address(RVA = "0x1CD3440", Offset = "0x1CD2040", VA = "0x181CD3440")]
		private void _OnBeforeStateTransition(object arg)
		{
		}

		// Token: 0x0602263D RID: 140861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602263D")]
		[Address(RVA = "0x1CD36A0", Offset = "0x1CD22A0", VA = "0x181CD36A0")]
		private void _OnStateChanged(object arg, bool statePaused)
		{
		}

		// Token: 0x0602263E RID: 140862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602263E")]
		[Address(RVA = "0x1CD42E0", Offset = "0x1CD2EE0", VA = "0x181CD42E0")]
		private void _SetShowStatus(bool isShow, ClimbTowerMenu.TweenType showType, bool fastMode)
		{
		}

		// Token: 0x0602263F RID: 140863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602263F")]
		[Address(RVA = "0x1CD2BB0", Offset = "0x1CD17B0", VA = "0x181CD2BB0")]
		public void Init(ClimbTowerController.ClimbTowerControllerBridge bridge)
		{
		}

		// Token: 0x06022640 RID: 140864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022640")]
		public IEnumerator EnsureBottomMenu<TState>() where TState : State
		{
			return null;
		}

		// Token: 0x06022641 RID: 140865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022641")]
		[Address(RVA = "0x1CD2B40", Offset = "0x1CD1740", VA = "0x181CD2B40")]
		public void ClearTacticalBuffWindow()
		{
		}

		// Token: 0x06022642 RID: 140866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022642")]
		[Address(RVA = "0x1CD3110", Offset = "0x1CD1D10", VA = "0x181CD3110")]
		public void OnTacticalBuffWindowShowStatusUpdated(bool isShow)
		{
		}

		// Token: 0x06022643 RID: 140867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022643")]
		[Address(RVA = "0x1CD3080", Offset = "0x1CD1C80", VA = "0x181CD3080")]
		private void OnDestroy()
		{
		}

		// Token: 0x06022644 RID: 140868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022644")]
		[Address(RVA = "0x1CD4420", Offset = "0x1CD3020", VA = "0x181CD4420")]
		public ClimbTowerMenu()
		{
		}

		// Token: 0x0402F416 RID: 193558
		[Token(Token = "0x402F416")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClimbTowerTacticalBuffMenuObject _menuTacticalBuff;

		// Token: 0x0402F417 RID: 193559
		[Token(Token = "0x402F417")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasBuff;

		// Token: 0x0402F418 RID: 193560
		[Token(Token = "0x402F418")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClimbTowerTrapMenuObject _menuTrap;

		// Token: 0x0402F419 RID: 193561
		[Token(Token = "0x402F419")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClimbTowerSquadMenuObject _menuSquad;

		// Token: 0x0402F41A RID: 193562
		[Token(Token = "0x402F41A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ClimbTowerProfessionMenuObject _menuProfession;

		// Token: 0x0402F41B RID: 193563
		[Token(Token = "0x402F41B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlPlaceHolder;

		// Token: 0x0402F41C RID: 193564
		[Token(Token = "0x402F41C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClimbTowerButtonHolderMenuObject _menuButtonHolder;

		// Token: 0x0402F41D RID: 193565
		[Token(Token = "0x402F41D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<ClimbTowerMenuObject> _menuObjects;

		// Token: 0x0402F41E RID: 193566
		[Token(Token = "0x402F41E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402F41F RID: 193567
		[Token(Token = "0x402F41F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _posHandler;

		// Token: 0x0402F420 RID: 193568
		[Token(Token = "0x402F420")]
		[FieldOffset(Offset = "0x68")]
		private string m_towerId;

		// Token: 0x0402F421 RID: 193569
		[Token(Token = "0x402F421")]
		[FieldOffset(Offset = "0x70")]
		private ClimbTowerMenuViewModel m_viewModel;

		// Token: 0x0402F422 RID: 193570
		[Token(Token = "0x402F422")]
		[FieldOffset(Offset = "0x78")]
		private ClimbTowerController.ClimbTowerControllerBridge m_bindControllerBridge;

		// Token: 0x0402F423 RID: 193571
		[Token(Token = "0x402F423")]
		[FieldOffset(Offset = "0x80")]
		private StateEngine m_bindStateEngine;

		// Token: 0x0402F424 RID: 193572
		[Token(Token = "0x402F424")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerMenuAdapter m_topAdapter;

		// Token: 0x0402F425 RID: 193573
		[Token(Token = "0x402F425")]
		[FieldOffset(Offset = "0x90")]
		private Type m_topStateType;

		// Token: 0x0402F426 RID: 193574
		[Token(Token = "0x402F426")]
		[FieldOffset(Offset = "0x98")]
		private ClimbTowerMenu.ShowSwitchTween m_switchTween;

		// Token: 0x0402F427 RID: 193575
		[Token(Token = "0x402F427")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_lastShowStatus;

		// Token: 0x0402F428 RID: 193576
		[Token(Token = "0x402F428")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerMenu.StateTransitionParam m_currTransParam;

		// Token: 0x0402F429 RID: 193577
		[Token(Token = "0x402F429")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<Type, ClimbTowerMenuAdapter> m_adapters;

		// Token: 0x0402F42A RID: 193578
		[Token(Token = "0x402F42A")]
		[FieldOffset(Offset = "0xB8")]
		private UIPopupWindow.UIBlocker m_menuUIBlocker;

		// Token: 0x0402F42B RID: 193579
		[Token(Token = "0x402F42B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canClick;

		// Token: 0x0402F42C RID: 193580
		[Token(Token = "0x402F42C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_bindControllerBridge;

		// Token: 0x0402F42D RID: 193581
		[Token(Token = "0x402F42D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bindStateEngine;

		// Token: 0x0402F42E RID: 193582
		[Token(Token = "0x402F42E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_menuTrap;

		// Token: 0x0402F42F RID: 193583
		[Token(Token = "0x402F42F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_menuSquad;

		// Token: 0x0402F430 RID: 193584
		[Token(Token = "0x402F430")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterMenuAdapter;

		// Token: 0x0402F431 RID: 193585
		[Token(Token = "0x402F431")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetStateMenuAdapter;

		// Token: 0x0402F432 RID: 193586
		[Token(Token = "0x402F432")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402F433 RID: 193587
		[Token(Token = "0x402F433")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0402F434 RID: 193588
		[Token(Token = "0x402F434")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x0402F435 RID: 193589
		[Token(Token = "0x402F435")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBeforeStateTransition;

		// Token: 0x0402F436 RID: 193590
		[Token(Token = "0x402F436")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStateChanged;

		// Token: 0x0402F437 RID: 193591
		[Token(Token = "0x402F437")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetShowStatus;

		// Token: 0x0402F438 RID: 193592
		[Token(Token = "0x402F438")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402F439 RID: 193593
		[Token(Token = "0x402F439")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EnsureBottomMenu;

		// Token: 0x0402F43A RID: 193594
		[Token(Token = "0x402F43A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ClearTacticalBuffWindow;

		// Token: 0x0402F43B RID: 193595
		[Token(Token = "0x402F43B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnTacticalBuffWindowShowStatusUpdated;

		// Token: 0x0402F43C RID: 193596
		[Token(Token = "0x402F43C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402F43D RID: 193597
		[Token(Token = "0x402F43D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CC9 RID: 23753
		[Token(Token = "0x2005CC9")]
		public enum TweenType
		{
			// Token: 0x0402F43F RID: 193599
			[Token(Token = "0x402F43F")]
			NONE,
			// Token: 0x0402F440 RID: 193600
			[Token(Token = "0x402F440")]
			FADE,
			// Token: 0x0402F441 RID: 193601
			[Token(Token = "0x402F441")]
			TRANSLATE
		}

		// Token: 0x02005CCA RID: 23754
		[Token(Token = "0x2005CCA")]
		private class StateTransitionParam
		{
			// Token: 0x06022647 RID: 140871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022647")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateTransitionParam()
			{
			}

			// Token: 0x0402F442 RID: 193602
			[Token(Token = "0x402F442")]
			[FieldOffset(Offset = "0x10")]
			public bool transitionIn;

			// Token: 0x0402F443 RID: 193603
			[Token(Token = "0x402F443")]
			[FieldOffset(Offset = "0x18")]
			public Type transitionDestType;

			// Token: 0x0402F444 RID: 193604
			[Token(Token = "0x402F444")]
			[FieldOffset(Offset = "0x20")]
			public Stack<Type> transitionPredicatedStack;
		}

		// Token: 0x02005CCB RID: 23755
		[Token(Token = "0x2005CCB")]
		private class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x170050DD RID: 20701
			// (set) Token: 0x06022648 RID: 140872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170050DD")]
			public ClimbTowerMenu.TweenType preferredShowType
			{
				[Token(Token = "0x6022648")]
				[Address(RVA = "0x1CE0050", Offset = "0x1CDEC50", VA = "0x181CE0050")]
				set
				{
				}
			}

			// Token: 0x06022649 RID: 140873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022649")]
			[Address(RVA = "0x1CDFFD0", Offset = "0x1CDEBD0", VA = "0x181CDFFD0")]
			public ShowSwitchTween(ClimbTowerMenu closure)
			{
			}

			// Token: 0x0602264A RID: 140874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602264A")]
			[Address(RVA = "0x1CDF520", Offset = "0x1CDE120", VA = "0x181CDF520", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602264B RID: 140875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602264B")]
			[Address(RVA = "0x1CDF630", Offset = "0x1CDE230", VA = "0x181CDF630", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602264C RID: 140876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602264C")]
			[Address(RVA = "0x1CDEE70", Offset = "0x1CDDA70", VA = "0x181CDEE70", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0602264D RID: 140877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602264D")]
			[Address(RVA = "0x1CDED50", Offset = "0x1CDD950", VA = "0x181CDED50", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0602264E RID: 140878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602264E")]
			[Address(RVA = "0x1CDF0B0", Offset = "0x1CDDCB0", VA = "0x181CDF0B0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602264F RID: 140879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602264F")]
			[Address(RVA = "0x1CDFC10", Offset = "0x1CDE810", VA = "0x181CDFC10", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06022650 RID: 140880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022650")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x06022651 RID: 140881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022651")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06022652 RID: 140882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022652")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06022653 RID: 140883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022653")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402F445 RID: 193605
			[Token(Token = "0x402F445")]
			private const float ANIM_DURATION = 0.23f;

			// Token: 0x0402F446 RID: 193606
			[Token(Token = "0x402F446")]
			private const float SHOW_POS_Y = 0f;

			// Token: 0x0402F447 RID: 193607
			[Token(Token = "0x402F447")]
			private const float HIDE_POS_Y = -111f;

			// Token: 0x0402F448 RID: 193608
			[Token(Token = "0x402F448")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerMenu m_closure;

			// Token: 0x0402F449 RID: 193609
			[Token(Token = "0x402F449")]
			[FieldOffset(Offset = "0x50")]
			private ClimbTowerMenu.TweenType m_tweenType;

			// Token: 0x0402F44A RID: 193610
			[Token(Token = "0x402F44A")]
			[FieldOffset(Offset = "0x54")]
			private ClimbTowerMenu.TweenType m_preferredTweenType;

			// Token: 0x0402F44B RID: 193611
			[Token(Token = "0x402F44B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_preferredShowType;

			// Token: 0x0402F44C RID: 193612
			[Token(Token = "0x402F44C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F44D RID: 193613
			[Token(Token = "0x402F44D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402F44E RID: 193614
			[Token(Token = "0x402F44E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402F44F RID: 193615
			[Token(Token = "0x402F44F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402F450 RID: 193616
			[Token(Token = "0x402F450")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402F451 RID: 193617
			[Token(Token = "0x402F451")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402F452 RID: 193618
			[Token(Token = "0x402F452")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
