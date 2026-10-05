using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	public class SDKPopupChangePhoneState : HGSDKPopupPage.UIState
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x17000108")]
		public override HGSDKPopupPage.PopupState myState
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1AE2530", Offset = "0x1AE1130", VA = "0x181AE2530", Slot = "13")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1AE1370", Offset = "0x1ADFF70", VA = "0x181AE1370", Slot = "14")]
		public override void OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1AE11A0", Offset = "0x1ADFDA0", VA = "0x181AE11A0", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1AE1110", Offset = "0x1ADFD10", VA = "0x181AE1110")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1AE1060", Offset = "0x1ADFC60", VA = "0x181AE1060")]
		public void EventOnChangePhoneClicked()
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1AE2080", Offset = "0x1AE0C80", VA = "0x181AE2080")]
		private void _OnNewPhoneInvalid()
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1AE1FD0", Offset = "0x1AE0BD0", VA = "0x181AE1FD0")]
		private void _OnNewCaptchaSendSuc(long timeStamp)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1AE21A0", Offset = "0x1AE0DA0", VA = "0x181AE21A0")]
		private void _OnOriPhoneInvalid()
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1AE20F0", Offset = "0x1AE0CF0", VA = "0x181AE20F0")]
		private void _OnOriCaptchaSendSuc(long timeStamp)
		{
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1AE22E0", Offset = "0x1AE0EE0", VA = "0x181AE22E0")]
		private void _ShowRemindDialog(string token)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1AE1C80", Offset = "0x1AE0880", VA = "0x181AE1C80")]
		private void _CallChangePhone(string token)
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1AE1E60", Offset = "0x1AE0A60", VA = "0x181AE1E60")]
		private void _OnChangePhoneSuccess()
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1AE2210", Offset = "0x1AE0E10", VA = "0x181AE2210")]
		private void _ShowChangePhoneFailToast()
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1AE24D0", Offset = "0x1AE10D0", VA = "0x181AE24D0")]
		public SDKPopupChangePhoneState()
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1AE0F90", Offset = "0x1ADFB90", VA = "0x181AE0F90")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1AE0F80", Offset = "0x1ADFB80", VA = "0x181AE0F80")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField _newPhoneInput;

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SDKInputWarning _phoneInputWarning;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SDKInputWarning _phoneUsedWarning;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputField _newPhoneCaptchaInput;

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SDKCaptchaWidget _newCaptchaWidget;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField _oriPhoneCaptchaInput;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SDKCaptchaWidget _oriCaptchaWidget;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private HGSDKSettingNotifyView _notifyView;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _closeBtn;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnChangePhoneClicked;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnNewPhoneInvalid;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnNewCaptchaSendSuc;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnOriPhoneInvalid;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnOriCaptchaSendSuc;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowRemindDialog;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CallChangePhone;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnChangePhoneSuccess;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowChangePhoneFailToast;

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
