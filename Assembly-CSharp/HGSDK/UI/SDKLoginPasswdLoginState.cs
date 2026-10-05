using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public class SDKLoginPasswdLoginState : SDKLoginPage.UIState
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x170000E1")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1ADD900", Offset = "0x1ADC500", VA = "0x181ADD900", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1ADCFC0", Offset = "0x1ADBBC0", VA = "0x181ADCFC0", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKLoginPage.LoginState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1ADCEF0", Offset = "0x1ADBAF0", VA = "0x181ADCEF0", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1ADCDB0", Offset = "0x1ADB9B0", VA = "0x181ADCDB0")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1ADD6A0", Offset = "0x1ADC2A0", VA = "0x181ADD6A0")]
		private void _OnServiceSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1ADD5E0", Offset = "0x1ADC1E0", VA = "0x181ADD5E0")]
		private void _OnLoginSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1ADD880", Offset = "0x1ADC480", VA = "0x181ADD880")]
		public SDKLoginPasswdLoginState()
		{
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1AD91E0", Offset = "0x1AD7DE0", VA = "0x181AD91E0")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<SDKLoginPage.LoginState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1AD6EC0", Offset = "0x1AD5AC0", VA = "0x181AD6EC0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InputField _usernameInput;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SDKInputWarning _usernameInputWarning;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputField _passwordInput;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SDKInputWarning _passwordInputWarning;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _loginBtn;

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _loginBtnText;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnServiceSuc;

		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4000881")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnLoginSuc;

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
