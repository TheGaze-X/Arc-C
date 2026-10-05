using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	public class SDKLoginRegisterState : SDKLoginPage.UIState
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x170000E2")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1ADE670", Offset = "0x1ADD270", VA = "0x181ADE670", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1ADDA40", Offset = "0x1ADC640", VA = "0x181ADDA40", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKLoginPage.LoginState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1ADD960", Offset = "0x1ADC560", VA = "0x181ADD960")]
		public void EventOnRegisterClicked()
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1ADE3E0", Offset = "0x1ADCFE0", VA = "0x181ADE3E0")]
		private void _OnRegisterSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1ADE2A0", Offset = "0x1ADCEA0", VA = "0x181ADE2A0")]
		private void _OnLoginSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1ADE230", Offset = "0x1ADCE30", VA = "0x181ADE230")]
		private void _OnAccountInvalid()
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1ADE5F0", Offset = "0x1ADD1F0", VA = "0x181ADE5F0")]
		public SDKLoginRegisterState()
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1AD91E0", Offset = "0x1AD7DE0", VA = "0x181AD91E0")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<SDKLoginPage.LoginState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InputField _phoneNumberInput;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SDKInputWarning _phoneNumberWarning;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputField _passwdInput;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SDKInputWarning _passwdInputWarn;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField _passwdAgainInput;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SDKInputWarning _passwdAgainInputWarning;

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SDKCaptchaWidget _captchaWidget;

		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Toggle _policyToggle;

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SDKToggleWarning _policyToggleWarning;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button _registerBtn;

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRegisterClicked;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnRegisterSuc;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnLoginSuc;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnAccountInvalid;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
