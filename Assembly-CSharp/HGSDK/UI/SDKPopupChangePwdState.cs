using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	public class SDKPopupChangePwdState : HGSDKPopupPage.UIState
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x17000109")]
		public override HGSDKPopupPage.PopupState myState
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1AE35D0", Offset = "0x1AE21D0", VA = "0x181AE35D0", Slot = "13")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1AE29D0", Offset = "0x1AE15D0", VA = "0x181AE29D0", Slot = "14")]
		public override void OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1AE2850", Offset = "0x1AE1450", VA = "0x181AE2850", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1AE27C0", Offset = "0x1AE13C0", VA = "0x181AE27C0")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1AE2590", Offset = "0x1AE1190", VA = "0x181AE2590")]
		public void EventOnChangePwdClicked()
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1AE3380", Offset = "0x1AE1F80", VA = "0x181AE3380")]
		private void _OnAccountInvalid()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1AE33F0", Offset = "0x1AE1FF0", VA = "0x181AE33F0")]
		private void _OnCaptchaSendSuc(long timeStamp)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1AE30C0", Offset = "0x1AE1CC0", VA = "0x181AE30C0")]
		private void _CallChangePwd()
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1AE3290", Offset = "0x1AE1E90", VA = "0x181AE3290")]
		private void _ClearLoginInfoAndLogout()
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1AE34A0", Offset = "0x1AE20A0", VA = "0x181AE34A0")]
		private void _ShowChangePwdFailToast()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1AE3570", Offset = "0x1AE2170", VA = "0x181AE3570")]
		public SDKPopupChangePwdState()
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1AE0F90", Offset = "0x1ADFB90", VA = "0x181AE0F90")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1AE0F80", Offset = "0x1ADFB80", VA = "0x181AE0F80")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField _pwdInput;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SDKInputWarning _pwdInputWarning;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private InputField _pwdAgainInput;

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SDKInputWarning _pwdAgainInputWarning;

		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InputField _captchaInput;

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SDKCaptchaWidget _captchaWidget;

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HGSDKSettingNotifyView _notifyView;

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _closeBtn;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnChangePwdClicked;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnAccountInvalid;

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCaptchaSendSuc;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CallChangePwd;

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearLoginInfoAndLogout;

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowChangePwdFailToast;

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
