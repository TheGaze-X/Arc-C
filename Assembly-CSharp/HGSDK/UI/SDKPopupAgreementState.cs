using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	public class SDKPopupAgreementState : HGSDKPopupPage.UIState
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x17000107")]
		public override HGSDKPopupPage.PopupState myState
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1AE1000", Offset = "0x1ADFC00", VA = "0x181AE1000", Slot = "13")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1AE0EC0", Offset = "0x1ADFAC0", VA = "0x181AE0EC0", Slot = "14")]
		public override void OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1AE0D10", Offset = "0x1ADF910", VA = "0x181AE0D10", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1AE0C80", Offset = "0x1ADF880", VA = "0x181AE0C80")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1AE0FA0", Offset = "0x1ADFBA0", VA = "0x181AE0FA0")]
		public SDKPopupAgreementState()
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1AE0F90", Offset = "0x1ADFB90", VA = "0x181AE0F90")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<HGSDKPopupPage.PopupState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1AE0F80", Offset = "0x1ADFB80", VA = "0x181AE0F80")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIUniWebView _webView;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _closeBtn;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
