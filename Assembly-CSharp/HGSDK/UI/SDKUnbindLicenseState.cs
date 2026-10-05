using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	public class SDKUnbindLicenseState : HGSDKPopupPage.UIState
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x1700010F")]
		public override HGSDKPopupPage.PopupState myState
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x1AE5900", Offset = "0x1AE4500", VA = "0x181AE5900", Slot = "13")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1AE56B0", Offset = "0x1AE42B0", VA = "0x181AE56B0", Slot = "14")]
		public override void OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1AE54C0", Offset = "0x1AE40C0", VA = "0x181AE54C0", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1AE5390", Offset = "0x1AE3F90", VA = "0x181AE5390", Slot = "24")]
		public override HGSDKPopupPage.UIState.FloatV2Handler GetFloatV2Handler()
		{
			return default(HGSDKPopupPage.UIState.FloatV2Handler);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1AE5770", Offset = "0x1AE4370", VA = "0x181AE5770")]
		private void _EventOnCloseClicked()
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1AE57E0", Offset = "0x1AE43E0", VA = "0x181AE57E0")]
		private void _UpdateView()
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1AE5320", Offset = "0x1AE3F20", VA = "0x181AE5320")]
		public void EventOnToggleClicked()
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1AE5260", Offset = "0x1AE3E60", VA = "0x181AE5260")]
		public void EventOnBtnNextClicked()
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1AE58A0", Offset = "0x1AE44A0", VA = "0x181AE58A0")]
		public SDKUnbindLicenseState()
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1AE0F90", Offset = "0x1ADFB90", VA = "0x181AE0F90")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1AE0F80", Offset = "0x1ADFB80", VA = "0x181AE0F80")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1AE3D60", Offset = "0x1AE2960", VA = "0x181AE3D60")]
		private HGSDKPopupPage.UIState.FloatV2Handler <>xLuaBaseProxy_GetFloatV2Handler()
		{
			return default(HGSDKPopupPage.UIState.FloatV2Handler);
		}

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _licenseToggle;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _btnNext;

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text[] _textsConfirmLicense;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIUniWebView _webview;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		[FieldOffset(Offset = "0x70")]
		private TwoStateToggle.State m_toggleState;

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetFloatV2Handler;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnCloseClicked;

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnToggleClicked;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnNextClicked;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
