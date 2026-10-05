using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	public class SDKLoginPage : HGSDK.UIPage
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x000033A8 File Offset: 0x000015A8
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D3")]
		private SDKLoginPage.LoginState state
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1ADCB10", Offset = "0x1ADB710", VA = "0x181ADCB10")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1ADCB90", Offset = "0x1ADB790", VA = "0x181ADCB90")]
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x170000D4")]
		protected override float fadeDuration
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1ADCAB0", Offset = "0x1ADB6B0", VA = "0x181ADCAB0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1ADB8D0", Offset = "0x1ADA4D0", VA = "0x181ADB8D0")]
		public void SetCallbacks(Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1ADAC40", Offset = "0x1AD9840", VA = "0x181ADAC40")]
		public void DoPasswordLogin(string username, string password, Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1ADAAF0", Offset = "0x1AD96F0", VA = "0x181ADAAF0")]
		public void DoAuth(string token, Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1ADB980", Offset = "0x1ADA580", VA = "0x181ADB980")]
		public void StartLoginSucPostProcess(HGSDK.LoginResult result, bool isGuest)
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1ADA890", Offset = "0x1AD9490", VA = "0x181ADA890")]
		public void ConfirmLoginSucAfterIdentityVerify(HGSDK.LoginResult result, bool isGuest)
		{
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1ADB7F0", Offset = "0x1ADA3F0", VA = "0x181ADB7F0")]
		public void ProceedAfterAgreement()
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1ADBCC0", Offset = "0x1ADA8C0", VA = "0x181ADBCC0")]
		private void _ConfirmLoginSucWithIdentityVerify(HGSDK.LoginResult result, bool isGuest)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1ADC0C0", Offset = "0x1ADACC0", VA = "0x181ADC0C0")]
		private void _StartCloudAuthVerify(HGSDK.LoginResult result)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1ADC2A0", Offset = "0x1ADAEA0", VA = "0x181ADC2A0")]
		private void _StartUnbindGrantRelated(HGSDK.LoginResult loginResult)
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1ADB2A0", Offset = "0x1AD9EA0", VA = "0x181ADB2A0")]
		public void EventOnReturnBtnClicked()
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1ADADE0", Offset = "0x1AD99E0", VA = "0x181ADADE0")]
		public void EventOnAccountHistory()
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1ADAEA0", Offset = "0x1AD9AA0", VA = "0x181ADAEA0")]
		public void EventOnGotoAccountMenu()
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1ADAF60", Offset = "0x1AD9B60", VA = "0x181ADAF60")]
		public void EventOnGotoPasswdLogin()
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1ADAF00", Offset = "0x1AD9B00", VA = "0x181ADAF00")]
		public void EventOnGotoCaptchaLogin()
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1ADB1F0", Offset = "0x1AD9DF0", VA = "0x181ADB1F0")]
		public void EventOnOpenRegisterLicense()
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1ADB140", Offset = "0x1AD9D40", VA = "0x181ADB140")]
		public void EventOnOpenPrivacyLicense()
		{
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1ADB0E0", Offset = "0x1AD9CE0", VA = "0x181ADB0E0")]
		public void EventOnOpenPreAnnounce()
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1ADAFC0", Offset = "0x1AD9BC0", VA = "0x181ADAFC0")]
		public void EventOnOpenGameServiceLicense()
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1ADB3D0", Offset = "0x1AD9FD0", VA = "0x181ADB3D0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1ADB790", Offset = "0x1ADA390", VA = "0x181ADB790", Slot = "6")]
		protected override void OnOpen()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1ADB370", Offset = "0x1AD9F70", VA = "0x181ADB370", Slot = "7")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1ADBAE0", Offset = "0x1ADA6E0", VA = "0x181ADBAE0")]
		private void Update()
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1ADC590", Offset = "0x1ADB190", VA = "0x181ADC590")]
		private bool _TryFindClosestState(IList<SDKLoginPage.LoginState> states, out SDKLoginPage.LoginState result)
		{
			return default(bool);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1ADBBB0", Offset = "0x1ADA7B0", VA = "0x181ADBBB0")]
		private bool _CheckIfInStack(SDKLoginPage.LoginState target)
		{
			return default(bool);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1ADBFE0", Offset = "0x1ADABE0", VA = "0x181ADBFE0")]
		private void _OnLoginSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1ADC7B0", Offset = "0x1ADB3B0", VA = "0x181ADC7B0")]
		private void _UpdateReturnStack(SDKLoginPage.LoginState newState, bool pushToStack)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1ADBE70", Offset = "0x1ADAA70", VA = "0x181ADBE70")]
		private UIStateMachine<SDKLoginPage.LoginState> _ConstructStateMachine()
		{
			return null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1ADC430", Offset = "0x1ADB030", VA = "0x181ADC430")]
		private void _TestOnlyReloadDebugStates(UIStateMachine<SDKLoginPage.LoginState> stateMachine)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1ADAE40", Offset = "0x1AD9A40", VA = "0x181ADAE40")]
		public void EventOnEnableCloudAuth(GameObject tickObj)
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1ADC950", Offset = "0x1ADB550", VA = "0x181ADC950")]
		public SDKLoginPage()
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1ACFF70", Offset = "0x1ACEB70", VA = "0x181ACFF70")]
		private float <>xLuaBaseProxy_get_fadeDuration()
		{
			return 0f;
		}

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SDKLoginPage.UIState[] _states;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _returnBtn;

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LoginBottomButton[] _bottomButtons;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SDKPopupWebView _popupWebView;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Fade")]
		private float _switchSlowFadeDuration;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Group("Fade")]
		private float _switchQuickFadeDuration;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Fade")]
		private float _appearFadeDuration;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Debug")]
		private SDKLoginPage.UIState[] _debugStatePrefabs;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Debug")]
		private Transform _debugStateHolder;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Debug")]
		private GameObject _debugPanel;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x80")]
		private Action<HGSDK.LoginResult> m_onSuc;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x88")]
		private Action m_onFail;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x90")]
		private LoginBottomButtonManager m_bottomBtnManager;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x98")]
		private UIStateMachine<SDKLoginPage.LoginState> m_stateMachine;

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0xA0")]
		private Stack<SDKLoginPage.LoginState> m_stateReturnStack;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fadeDuration;

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoPasswordLogin;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoAuth;

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StartLoginSucPostProcess;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ConfirmLoginSucAfterIdentityVerify;

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ProceedAfterAgreement;

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ConfirmLoginSucWithIdentityVerify;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__StartCloudAuthVerify;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__StartUnbindGrantRelated;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnReturnBtnClicked;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnAccountHistory;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnGotoAccountMenu;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnGotoPasswdLogin;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnGotoCaptchaLogin;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnOpenRegisterLicense;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnOpenPrivacyLicense;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnOpenPreAnnounce;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnOpenGameServiceLicense;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnOpen;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnClose;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TryFindClosestState;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckIfInStack;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnLoginSuc;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__UpdateReturnStack;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ConstructStateMachine;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TestOnlyReloadDebugStates;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_EventOnEnableCloudAuth;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000182 RID: 386
		[Token(Token = "0x2000182")]
		public enum LoginState
		{
			// Token: 0x040007F5 RID: 2037
			[Token(Token = "0x40007F5")]
			DEFAULT_STATE,
			// Token: 0x040007F6 RID: 2038
			[Token(Token = "0x40007F6")]
			AWAKEN,
			// Token: 0x040007F7 RID: 2039
			[Token(Token = "0x40007F7")]
			ACCOUNT_MENU,
			// Token: 0x040007F8 RID: 2040
			[Token(Token = "0x40007F8")]
			PASSWD_LOGIN,
			// Token: 0x040007F9 RID: 2041
			[Token(Token = "0x40007F9")]
			CAPTCHA_LOGIN,
			// Token: 0x040007FA RID: 2042
			[Token(Token = "0x40007FA")]
			REGISTER,
			// Token: 0x040007FB RID: 2043
			[Token(Token = "0x40007FB")]
			IDENTITY_VERIFY,
			// Token: 0x040007FC RID: 2044
			[Token(Token = "0x40007FC")]
			GUEST_UPGRADE,
			// Token: 0x040007FD RID: 2045
			[Token(Token = "0x40007FD")]
			AUTH,
			// Token: 0x040007FE RID: 2046
			[Token(Token = "0x40007FE")]
			POLICY,
			// Token: 0x040007FF RID: 2047
			[Token(Token = "0x40007FF")]
			DEBUG_ACCOUNT_HISTORY = 1001,
			// Token: 0x04000800 RID: 2048
			[Token(Token = "0x4000800")]
			TERMINAL_STATE = -1
		}

		// Token: 0x02000183 RID: 387
		[Token(Token = "0x2000183")]
		public enum BottomButtonType
		{
			// Token: 0x04000802 RID: 2050
			[Token(Token = "0x4000802")]
			GOTO_ACCOUNT_MENU = 1,
			// Token: 0x04000803 RID: 2051
			[Token(Token = "0x4000803")]
			GOTO_PASSWD_LOGIN,
			// Token: 0x04000804 RID: 2052
			[Token(Token = "0x4000804")]
			GOTO_CAPTCHA_LOGIN = 4,
			// Token: 0x04000805 RID: 2053
			[Token(Token = "0x4000805")]
			OPEN_USER_AGREEMENT = 8,
			// Token: 0x04000806 RID: 2054
			[Token(Token = "0x4000806")]
			OPEN_PRIVACY_LICENSE = 32,
			// Token: 0x04000807 RID: 2055
			[Token(Token = "0x4000807")]
			OPEN_PRE_ANNOUNCE = 64
		}

		// Token: 0x02000184 RID: 388
		[Token(Token = "0x2000184")]
		public abstract class UIState : UIStateMachine<SDKLoginPage.LoginState>.UIStateBehaviour
		{
			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000D5")]
			protected HGSDK sdk
			{
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x1AE9350", Offset = "0x1AE7F50", VA = "0x181AE9350")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000D6")]
			protected new SDKLoginPage page
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x1AE8F00", Offset = "0x1AE7B00", VA = "0x181AE8F00")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000628 RID: 1576 RVA: 0x00003420 File Offset: 0x00001620
			// (set) Token: 0x06000629 RID: 1577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000D7")]
			protected SDKLoginPage.LoginState pageState
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x1AE8C60", Offset = "0x1AE7860", VA = "0x181AE8C60")]
				get
				{
					return SDKLoginPage.LoginState.DEFAULT_STATE;
				}
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x1AE9740", Offset = "0x1AE8340", VA = "0x181AE9740")]
				set
				{
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000D8")]
			protected Camera sdkCamera
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x1AE9250", Offset = "0x1AE7E50", VA = "0x181AE9250")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x0600062B RID: 1579 RVA: 0x00003438 File Offset: 0x00001638
			[Token(Token = "0x170000D9")]
			public SDKLoginPage.UIState.MainControllerStylePhase stylePhase
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0x1AE9450", Offset = "0x1AE8050", VA = "0x181AE9450")]
				get
				{
					return SDKLoginPage.UIState.MainControllerStylePhase.KEEP;
				}
			}

			// Token: 0x0600062C RID: 1580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x1AE8010", Offset = "0x1AE6C10", VA = "0x181AE8010", Slot = "14")]
			public override void OnRegister(UIStateMachine<SDKLoginPage.LoginState> stateMachine, HGSDK.UIPage page)
			{
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1AE7BC0", Offset = "0x1AE67C0", VA = "0x181AE7BC0", Slot = "17")]
			public override void OnEnter(int lastState)
			{
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x00003450 File Offset: 0x00001650
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1AE76D0", Offset = "0x1AE62D0", VA = "0x181AE76D0")]
			public bool CheckIsUnderGuestUpgrade()
			{
				return default(bool);
			}

			// Token: 0x0600062F RID: 1583 RVA: 0x00003468 File Offset: 0x00001668
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1AE75F0", Offset = "0x1AE61F0", VA = "0x181AE75F0")]
			public bool CheckIfGuestCanUpgradeOrAlert()
			{
				return default(bool);
			}

			// Token: 0x06000630 RID: 1584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1AE80D0", Offset = "0x1AE6CD0", VA = "0x181AE80D0")]
			public void PreventOnLoginAndRegisterActions(Action nextStep)
			{
			}

			// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1AE8400", Offset = "0x1AE7000", VA = "0x181AE8400")]
			protected void SetWarningHints(IWarningHint[] warningHints)
			{
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x00003480 File Offset: 0x00001680
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1AE8740", Offset = "0x1AE7340", VA = "0x181AE8740")]
			protected bool ValidateAndUpdateWarningHints(bool forceShowIfNotPass)
			{
				return default(bool);
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1AE8910", Offset = "0x1AE7510", VA = "0x181AE8910")]
			protected UIState()
			{
			}

			// Token: 0x04000808 RID: 2056
			[Token(Token = "0x4000808")]
			[FieldOffset(Offset = "0x0")]
			private static readonly SDKLoginPage.LoginState[] ACCOUNT_MENU_AND_GUEST_UPGRADE;

			// Token: 0x04000809 RID: 2057
			[Token(Token = "0x4000809")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private SDKLoginPage.UIState.MainControllerStylePhase _stylePhase;

			// Token: 0x0400080A RID: 2058
			[Token(Token = "0x400080A")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			[Enum(true)]
			private SDKLoginPage.BottomButtonType _bottomBtnMask;

			// Token: 0x0400080B RID: 2059
			[Token(Token = "0x400080B")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private bool _pushToReturnStack;

			// Token: 0x0400080C RID: 2060
			[Token(Token = "0x400080C")]
			[FieldOffset(Offset = "0x48")]
			private IWarningHint[] m_warningHints;

			// Token: 0x0400080D RID: 2061
			[Token(Token = "0x400080D")]
			[FieldOffset(Offset = "0x50")]
			private List<SDKLoginPage.LoginState> m_sharedStateParamList;

			// Token: 0x0400080E RID: 2062
			[Token(Token = "0x400080E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_sdk;

			// Token: 0x0400080F RID: 2063
			[Token(Token = "0x400080F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_page;

			// Token: 0x04000810 RID: 2064
			[Token(Token = "0x4000810")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_pageState;

			// Token: 0x04000811 RID: 2065
			[Token(Token = "0x4000811")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_pageState;

			// Token: 0x04000812 RID: 2066
			[Token(Token = "0x4000812")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_sdkCamera;

			// Token: 0x04000813 RID: 2067
			[Token(Token = "0x4000813")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_stylePhase;

			// Token: 0x04000814 RID: 2068
			[Token(Token = "0x4000814")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnRegister;

			// Token: 0x04000815 RID: 2069
			[Token(Token = "0x4000815")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnEnter;

			// Token: 0x04000816 RID: 2070
			[Token(Token = "0x4000816")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_CheckIsUnderGuestUpgrade;

			// Token: 0x04000817 RID: 2071
			[Token(Token = "0x4000817")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_CheckIfGuestCanUpgradeOrAlert;

			// Token: 0x04000818 RID: 2072
			[Token(Token = "0x4000818")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_PreventOnLoginAndRegisterActions;

			// Token: 0x04000819 RID: 2073
			[Token(Token = "0x4000819")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_SetWarningHints;

			// Token: 0x0400081A RID: 2074
			[Token(Token = "0x400081A")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_ValidateAndUpdateWarningHints;

			// Token: 0x0400081B RID: 2075
			[Token(Token = "0x400081B")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02000185 RID: 389
			[Token(Token = "0x2000185")]
			public enum MainControllerStylePhase
			{
				// Token: 0x0400081D RID: 2077
				[Token(Token = "0x400081D")]
				KEEP,
				// Token: 0x0400081E RID: 2078
				[Token(Token = "0x400081E")]
				SDK_PHASE_1,
				// Token: 0x0400081F RID: 2079
				[Token(Token = "0x400081F")]
				SDK_PHASE_2
			}
		}
	}
}
