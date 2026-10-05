using System;
using Il2CppDummyDll;
using Torappu.SDK;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	public class SDKLoginAccountMenuState : SDKLoginPage.UIState
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x170000DB")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x1AD7FC0", Offset = "0x1AD6BC0", VA = "0x181AD7FC0", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1AD75E0", Offset = "0x1AD61E0", VA = "0x181AD75E0")]
		public void EventOnAccountLoginClicked()
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1AD7660", Offset = "0x1AD6260", VA = "0x181AD7660")]
		public void EventOnRegisterClicked()
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1AD76E0", Offset = "0x1AD62E0", VA = "0x181AD76E0", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1AD7E80", Offset = "0x1AD6A80", VA = "0x181AD7E80")]
		private void _OnLoginSuc(HGSDK.LoginResult loginResult)
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1AD78B0", Offset = "0x1AD64B0", VA = "0x181AD78B0")]
		[Obsolete]
		private void _LegacyDoGuestLogin(string captcha)
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1AD7750", Offset = "0x1AD6350", VA = "0x181AD7750")]
		[Obsolete]
		private void _LegacyDoGuestCaptchaProcess(HGSDK.LoginProceedInfo info)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1AD7A10", Offset = "0x1AD6610", VA = "0x181AD7A10")]
		[Obsolete]
		private void _LegacyInvokeCaptchaSDK(string initData)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1AD7B10", Offset = "0x1AD6710", VA = "0x181AD7B10")]
		[Obsolete]
		private void _LegacyOnGT3Message(SDKExtraInfoHandler.GT3Message msg)
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1AD7CE0", Offset = "0x1AD68E0", VA = "0x181AD7CE0")]
		[Obsolete]
		private void _LegacyOnGuestLoginSuccess(HGSDK.LoginResult loginResult, string message)
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1AD7F40", Offset = "0x1AD6B40", VA = "0x181AD7F40")]
		public SDKLoginAccountMenuState()
		{
		}

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInvokingCaptcha;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnAccountLoginClicked;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRegisterClicked;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnLoginSuc;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LegacyDoGuestLogin;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LegacyDoGuestCaptchaProcess;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LegacyInvokeCaptchaSDK;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LegacyOnGT3Message;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LegacyOnGuestLoginSuccess;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
