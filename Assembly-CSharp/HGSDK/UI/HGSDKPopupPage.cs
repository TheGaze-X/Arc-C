using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	public class HGSDKPopupPage : HGSDK.UIPage
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1ACFF00", Offset = "0x1ACEB00", VA = "0x181ACFF00")]
		public void SetInitState(HGSDKPopupPage.PopupState targetState)
		{
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1ACFCE0", Offset = "0x1ACE8E0", VA = "0x181ACFCE0")]
		public HGSDKPopupPage.PopupState GetInitTargetState()
		{
			return HGSDKPopupPage.PopupState.DEFAULT_STATE;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FF")]
		private HGSDKPopupPage.PopupState state
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1AD0880", Offset = "0x1ACF480", VA = "0x181AD0880")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1AD0900", Offset = "0x1ACF500", VA = "0x181AD0900")]
			set
			{
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x17000100")]
		protected override float fadeDuration
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x1AD0820", Offset = "0x1ACF420", VA = "0x181AD0820", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1ACFC60", Offset = "0x1ACE860", VA = "0x181ACFC60")]
		public void ClosePage()
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1ACFDD0", Offset = "0x1ACE9D0", VA = "0x181ACFDD0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1ACFD40", Offset = "0x1ACE940", VA = "0x181ACFD40", Slot = "7")]
		protected override void OnClose()
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1ACFEA0", Offset = "0x1ACEAA0", VA = "0x181ACFEA0", Slot = "6")]
		protected override void OnOpen()
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1AD05C0", Offset = "0x1ACF1C0", VA = "0x181AD05C0")]
		private void _UpdateReturnStack(HGSDKPopupPage.PopupState newState, bool pushToStack)
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1ACFF80", Offset = "0x1ACEB80", VA = "0x181ACFF80")]
		private UIStateMachine<HGSDKPopupPage.PopupState> _ConstructStateMachine()
		{
			return null;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1AD0200", Offset = "0x1ACEE00", VA = "0x181AD0200")]
		private void _OnStateTransitionStart(UIStateMachine<HGSDKPopupPage.PopupState>.IUIState rawFromState, UIStateMachine<HGSDKPopupPage.PopupState>.IUIState rawToState)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1AD0510", Offset = "0x1ACF110", VA = "0x181AD0510")]
		private void _UpdateBlurBkgStatus(bool isShow)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1AD0460", Offset = "0x1ACF060", VA = "0x181AD0460")]
		private void _StoreToState(HGSDKPopupPage.PopupState state, object param)
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1AD0170", Offset = "0x1ACED70", VA = "0x181AD0170")]
		private object _GetStoreByState(HGSDKPopupPage.PopupState state)
		{
			return null;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1AD06E0", Offset = "0x1ACF2E0", VA = "0x181AD06E0")]
		public HGSDKPopupPage()
		{
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1ACFF70", Offset = "0x1ACEB70", VA = "0x181ACFF70")]
		private float <>xLuaBaseProxy_get_fadeDuration()
		{
			return 0f;
		}

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		public const string CAPTCHA_ID_CHANGE_PWD = "change_pwd";

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		public const string CAPTCHA_ID_CHANGE_PHONE_NEW = "change_phone_new";

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		public const string CAPTCHA_ID_CHANGE_PHONE_ORI = "change_phone_ori";

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		public const string CAPTCHA_ID_UNBIND_GRAND = "unbind_grant";

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HGSDKPopupPage.UIState[] _states;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIBlurFloatPanel _blurBkg;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SDKPopupFloatV2 _floatV2;

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Fade")]
		private float _switchQuickFadeDuration;

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Group("Fade")]
		private float _appearFadeDuration;

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x58")]
		private UIStateMachine<HGSDKPopupPage.PopupState> m_stateMachine;

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x60")]
		private Stack<HGSDKPopupPage.PopupState> m_stateReturnStack;

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<HGSDKPopupPage.PopupState, object> m_stateStore;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x70")]
		private HGSDKPopupPage.PopupState m_initTargetState;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetInitState;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetInitTargetState;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_fadeDuration;

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClose;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnOpen;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateReturnStack;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ConstructStateMachine;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStateTransitionStart;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateBlurBkgStatus;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StoreToState;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetStoreByState;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020001B2 RID: 434
		[Token(Token = "0x20001B2")]
		public enum PopupState
		{
			// Token: 0x0400096B RID: 2411
			[Token(Token = "0x400096B")]
			DEFAULT_STATE,
			// Token: 0x0400096C RID: 2412
			[Token(Token = "0x400096C")]
			INIT,
			// Token: 0x0400096D RID: 2413
			[Token(Token = "0x400096D")]
			CHANGE_PHONE,
			// Token: 0x0400096E RID: 2414
			[Token(Token = "0x400096E")]
			CHANGE_PWD,
			// Token: 0x0400096F RID: 2415
			[Token(Token = "0x400096F")]
			AGREEMENT,
			// Token: 0x04000970 RID: 2416
			[Token(Token = "0x4000970")]
			UNBIND_LICENSE = 10,
			// Token: 0x04000971 RID: 2417
			[Token(Token = "0x4000971")]
			UNBIND_EDIT_INFO,
			// Token: 0x04000972 RID: 2418
			[Token(Token = "0x4000972")]
			UNBIND_CONFIRM,
			// Token: 0x04000973 RID: 2419
			[Token(Token = "0x4000973")]
			UNBIND_RESULT
		}

		// Token: 0x020001B3 RID: 435
		[Token(Token = "0x20001B3")]
		public abstract class UIState : UIStateMachine<HGSDKPopupPage.PopupState>.UIStateBehaviour, IHotfixable
		{
			// Token: 0x06000742 RID: 1858 RVA: 0x00003A80 File Offset: 0x00001C80
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x1AE7840", Offset = "0x1AE6440", VA = "0x181AE7840", Slot = "24")]
			public virtual HGSDKPopupPage.UIState.FloatV2Handler GetFloatV2Handler()
			{
				return default(HGSDKPopupPage.UIState.FloatV2Handler);
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000101")]
			protected HGSDK sdk
			{
				[Token(Token = "0x6000743")]
				[Address(RVA = "0x1AE92E0", Offset = "0x1AE7EE0", VA = "0x181AE92E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000102")]
			protected new HGSDKPopupPage page
			{
				[Token(Token = "0x6000744")]
				[Address(RVA = "0x1AE9010", Offset = "0x1AE7C10", VA = "0x181AE9010")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000745 RID: 1861 RVA: 0x00003A98 File Offset: 0x00001C98
			// (set) Token: 0x06000746 RID: 1862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000103")]
			protected HGSDKPopupPage.PopupState pageState
			{
				[Token(Token = "0x6000745")]
				[Address(RVA = "0x1AE8D40", Offset = "0x1AE7940", VA = "0x181AE8D40")]
				get
				{
					return HGSDKPopupPage.PopupState.DEFAULT_STATE;
				}
				[Token(Token = "0x6000746")]
				[Address(RVA = "0x1AE95B0", Offset = "0x1AE81B0", VA = "0x181AE95B0")]
				set
				{
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000104")]
			protected Camera sdkCamera
			{
				[Token(Token = "0x6000747")]
				[Address(RVA = "0x1AE91E0", Offset = "0x1AE7DE0", VA = "0x181AE91E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000749 RID: 1865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000105")]
			protected string cachedUsername
			{
				[Token(Token = "0x6000748")]
				[Address(RVA = "0x1AE8B30", Offset = "0x1AE7730", VA = "0x181AE8B30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000749")]
				[Address(RVA = "0x1AE9520", Offset = "0x1AE8120", VA = "0x181AE9520")]
				set
				{
				}
			}

			// Token: 0x0600074A RID: 1866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x1AE7F60", Offset = "0x1AE6B60", VA = "0x181AE7F60", Slot = "14")]
			public override void OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> stateMachine, HGSDK.UIPage page)
			{
			}

			// Token: 0x0600074B RID: 1867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1AE79F0", Offset = "0x1AE65F0", VA = "0x181AE79F0", Slot = "17")]
			public override void OnEnter(int lastState)
			{
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1AE8490", Offset = "0x1AE7090", VA = "0x181AE8490")]
			protected void SetWarningHints(IWarningHint[] warningHints)
			{
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x00003AB0 File Offset: 0x00001CB0
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x1AE8630", Offset = "0x1AE7230", VA = "0x181AE8630")]
			protected bool ValidateAndUpdateWarningHints(bool forceShowIfNotPass)
			{
				return default(bool);
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x0600074E RID: 1870 RVA: 0x00003AC8 File Offset: 0x00001CC8
			[Token(Token = "0x17000106")]
			public bool useBlurBkg
			{
				[Token(Token = "0x600074E")]
				[Address(RVA = "0x1AE94C0", Offset = "0x1AE80C0", VA = "0x181AE94C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x1AE8280", Offset = "0x1AE6E80", VA = "0x181AE8280")]
			protected void SetParamToState(HGSDKPopupPage.PopupState state, object param)
			{
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x1AE78E0", Offset = "0x1AE64E0", VA = "0x181AE78E0")]
			protected object GetStateParam()
			{
				return null;
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x1AE8A60", Offset = "0x1AE7660", VA = "0x181AE8A60")]
			protected UIState()
			{
			}

			// Token: 0x04000974 RID: 2420
			[Token(Token = "0x4000974")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private bool _pushToReturnStack;

			// Token: 0x04000975 RID: 2421
			[Token(Token = "0x4000975")]
			[FieldOffset(Offset = "0x39")]
			[SerializeField]
			private bool _useBlurBkg;

			// Token: 0x04000976 RID: 2422
			[Token(Token = "0x4000976")]
			[FieldOffset(Offset = "0x40")]
			private IWarningHint[] m_warningHints;

			// Token: 0x04000977 RID: 2423
			[Token(Token = "0x4000977")]
			[FieldOffset(Offset = "0x48")]
			private List<HGSDKPopupPage.PopupState> m_sharedStateParamList;

			// Token: 0x04000978 RID: 2424
			[Token(Token = "0x4000978")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetFloatV2Handler;

			// Token: 0x04000979 RID: 2425
			[Token(Token = "0x4000979")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_sdk;

			// Token: 0x0400097A RID: 2426
			[Token(Token = "0x400097A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_page;

			// Token: 0x0400097B RID: 2427
			[Token(Token = "0x400097B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_pageState;

			// Token: 0x0400097C RID: 2428
			[Token(Token = "0x400097C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_pageState;

			// Token: 0x0400097D RID: 2429
			[Token(Token = "0x400097D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_sdkCamera;

			// Token: 0x0400097E RID: 2430
			[Token(Token = "0x400097E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_cachedUsername;

			// Token: 0x0400097F RID: 2431
			[Token(Token = "0x400097F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_cachedUsername;

			// Token: 0x04000980 RID: 2432
			[Token(Token = "0x4000980")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnRegister;

			// Token: 0x04000981 RID: 2433
			[Token(Token = "0x4000981")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnEnter;

			// Token: 0x04000982 RID: 2434
			[Token(Token = "0x4000982")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_SetWarningHints;

			// Token: 0x04000983 RID: 2435
			[Token(Token = "0x4000983")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_ValidateAndUpdateWarningHints;

			// Token: 0x04000984 RID: 2436
			[Token(Token = "0x4000984")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_useBlurBkg;

			// Token: 0x04000985 RID: 2437
			[Token(Token = "0x4000985")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_SetParamToState;

			// Token: 0x04000986 RID: 2438
			[Token(Token = "0x4000986")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_GetStateParam;

			// Token: 0x04000987 RID: 2439
			[Token(Token = "0x4000987")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020001B4 RID: 436
			[Token(Token = "0x20001B4")]
			public struct FloatV2Handler
			{
				// Token: 0x04000988 RID: 2440
				[Token(Token = "0x4000988")]
				[FieldOffset(Offset = "0x0")]
				public bool useV2Bkg;

				// Token: 0x04000989 RID: 2441
				[Token(Token = "0x4000989")]
				[FieldOffset(Offset = "0x8")]
				public SDKPopupTitleView.Options titleOptions;
			}
		}
	}
}
