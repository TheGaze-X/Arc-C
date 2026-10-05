using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	public class SDKLoginUpdateAgreementState : SDKLoginPage.UIState, IHotfixable
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x170000E3")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1ADF630", Offset = "0x1ADE230", VA = "0x181ADF630", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1ADEBB0", Offset = "0x1ADD7B0", VA = "0x181ADEBB0", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKLoginPage.LoginState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1ADE960", Offset = "0x1ADD560", VA = "0x181ADE960", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1ADEEB0", Offset = "0x1ADDAB0", VA = "0x181ADEEB0")]
		public void OnSelectRegistrationTab()
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1ADEE50", Offset = "0x1ADDA50", VA = "0x181ADEE50")]
		public void OnSelectPrivacyTab()
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1ADE6D0", Offset = "0x1ADD2D0", VA = "0x181ADE6D0")]
		public void OnAgreementToggleAgree()
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1ADE760", Offset = "0x1ADD360", VA = "0x181ADE760")]
		public void OnAgreementToggleDisagree()
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1ADE7F0", Offset = "0x1ADD3F0", VA = "0x181ADE7F0")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1ADF000", Offset = "0x1ADDC00", VA = "0x181ADF000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1ADF320", Offset = "0x1ADDF20", VA = "0x181ADF320")]
		private void _OnSelectTab(SDKLoginUpdateAgreementState.PolicyType tabType)
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1ADF1F0", Offset = "0x1ADDDF0", VA = "0x181ADF1F0")]
		private void _OnConfirm()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1ADF5B0", Offset = "0x1ADE1B0", VA = "0x181ADF5B0")]
		public SDKLoginUpdateAgreementState()
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1AD91E0", Offset = "0x1AD7DE0", VA = "0x181AD91E0")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<SDKLoginPage.LoginState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1AD6EC0", Offset = "0x1AD5AC0", VA = "0x181AD6EC0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x40008A0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<TwoStateToggle> _tabList;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _registrationTabSelectText;

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _registrationTabUnselectText;

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _PrivacyTabSelectText;

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _PrivacyTabUnselectText;

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIUniWebView _webView;

		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TwoStateToggle _agreementToggle;

		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _toggleSelectText;

		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _toggleUnselectText;

		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TwoStateToggle _confirmBtn;

		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSelectRegistrationTab;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSelectPrivacyTab;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnAgreementToggleAgree;

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnAgreementToggleDisagree;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSelectTab;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnConfirm;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200019D RID: 413
		[Token(Token = "0x200019D")]
		public enum PolicyType
		{
			// Token: 0x040008B8 RID: 2232
			[Token(Token = "0x40008B8")]
			REGISTRATION,
			// Token: 0x040008B9 RID: 2233
			[Token(Token = "0x40008B9")]
			PRIVACY,
			// Token: 0x040008BA RID: 2234
			[Token(Token = "0x40008BA")]
			ENUM
		}
	}
}
