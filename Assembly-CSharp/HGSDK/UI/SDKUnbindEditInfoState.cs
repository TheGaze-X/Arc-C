using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	public class SDKUnbindEditInfoState : HGSDKPopupPage.UIState
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x1700010E")]
		public override HGSDKPopupPage.PopupState myState
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x1AE5200", Offset = "0x1AE3E00", VA = "0x181AE5200", Slot = "13")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1AE45B0", Offset = "0x1AE31B0", VA = "0x181AE45B0", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1AE4430", Offset = "0x1AE3030", VA = "0x181AE4430", Slot = "24")]
		public override HGSDKPopupPage.UIState.FloatV2Handler GetFloatV2Handler()
		{
			return default(HGSDKPopupPage.UIState.FloatV2Handler);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1AE4A00", Offset = "0x1AE3600", VA = "0x181AE4A00")]
		private void _InitViewStatus()
		{
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1AE4F70", Offset = "0x1AE3B70", VA = "0x181AE4F70")]
		private void _OnCurrentAccountInvalid()
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1AE5040", Offset = "0x1AE3C40", VA = "0x181AE5040")]
		private void _UpdateViewStatusByInput(SDKUnbindEditInfoState.InputSource source)
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1AE4830", Offset = "0x1AE3430", VA = "0x181AE4830")]
		private bool _CheckIfAllInputValid()
		{
			return default(bool);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1AE4660", Offset = "0x1AE3260", VA = "0x181AE4660")]
		private void _BindCommonInputEvent(InputField input, SDKUnbindEditInfoState.InputSource tag)
		{
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1AE4990", Offset = "0x1AE3590", VA = "0x181AE4990")]
		private void _EventOnCloseClicked()
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1AE48F0", Offset = "0x1AE34F0", VA = "0x181AE48F0")]
		private void _EventOnBackClicked()
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1AE4260", Offset = "0x1AE2E60", VA = "0x181AE4260")]
		public void EventOnNextStepClicked()
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1AE5170", Offset = "0x1AE3D70", VA = "0x181AE5170")]
		public SDKUnbindEditInfoState()
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1AE0F80", Offset = "0x1ADFB80", VA = "0x181AE0F80")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1AE3D60", Offset = "0x1AE2960", VA = "0x181AE3D60")]
		private HGSDKPopupPage.UIState.FloatV2Handler <>xLuaBaseProxy_GetFloatV2Handler()
		{
			return default(HGSDKPopupPage.UIState.FloatV2Handler);
		}

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SDKCaptchaWidget _captchaWidget;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _idNameWarning;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _captchaWarning;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputField _inputId;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InputField _inputName;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField _inputCaptcha;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _btnNextStep;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textGameAccount;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x90")]
		private string m_phoneNumber;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFloatV2Handler;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitViewStatus;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCurrentAccountInvalid;

		// Token: 0x040009E6 RID: 2534
		[Token(Token = "0x40009E6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateViewStatusByInput;

		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckIfAllInputValid;

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__BindCommonInputEvent;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnCloseClicked;

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnBackClicked;

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnNextStepClicked;

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020001C0 RID: 448
		[Token(Token = "0x20001C0")]
		public class Param
		{
			// Token: 0x060007AD RID: 1965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040009ED RID: 2541
			[Token(Token = "0x40009ED")]
			[FieldOffset(Offset = "0x10")]
			public bool isPhoneCodeInvalid;

			// Token: 0x040009EE RID: 2542
			[Token(Token = "0x40009EE")]
			[FieldOffset(Offset = "0x11")]
			public bool isIdNameInvalid;
		}

		// Token: 0x020001C1 RID: 449
		[Token(Token = "0x20001C1")]
		private enum InputSource
		{
			// Token: 0x040009F0 RID: 2544
			[Token(Token = "0x40009F0")]
			NONE,
			// Token: 0x040009F1 RID: 2545
			[Token(Token = "0x40009F1")]
			ID,
			// Token: 0x040009F2 RID: 2546
			[Token(Token = "0x40009F2")]
			NAME,
			// Token: 0x040009F3 RID: 2547
			[Token(Token = "0x40009F3")]
			CAPTCHA
		}
	}
}
