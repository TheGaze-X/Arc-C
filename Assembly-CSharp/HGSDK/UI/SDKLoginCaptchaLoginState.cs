using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x02000190 RID: 400
	[Token(Token = "0x2000190")]
	public class SDKLoginCaptchaLoginState : SDKLoginPage.UIState
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x170000DE")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1AD95F0", Offset = "0x1AD81F0", VA = "0x181AD95F0", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1AD8D50", Offset = "0x1AD7950", VA = "0x181AD8D50", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKLoginPage.LoginState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1AD8C80", Offset = "0x1AD7880", VA = "0x181AD8C80", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1AD8BC0", Offset = "0x1AD77C0", VA = "0x181AD8BC0")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1AD9390", Offset = "0x1AD7F90", VA = "0x181AD9390")]
		private void _OnServiceSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1AD92D0", Offset = "0x1AD7ED0", VA = "0x181AD92D0")]
		private void _OnLoginSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1AD9200", Offset = "0x1AD7E00", VA = "0x181AD9200")]
		private void _OnInvalidAccount()
		{
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1AD9570", Offset = "0x1AD8170", VA = "0x181AD9570")]
		public SDKLoginCaptchaLoginState()
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1AD91E0", Offset = "0x1AD7DE0", VA = "0x181AD91E0")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<SDKLoginPage.LoginState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1AD6EC0", Offset = "0x1AD5AC0", VA = "0x181AD6EC0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InputField _phoneNumberInput;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SDKInputWarning _phoneNumberWarning;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SDKCaptchaWidget _captchaWidget;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _loginBtn;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _loginBtnText;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnServiceSuc;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnLoginSuc;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnInvalidAccount;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
