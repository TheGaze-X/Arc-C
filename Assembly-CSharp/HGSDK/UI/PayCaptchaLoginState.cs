using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	public class PayCaptchaLoginState : SDKPayPage.UIState
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x170000EC")]
		public override SDKPayPage.PayState myState
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x1AD40D0", Offset = "0x1AD2CD0", VA = "0x181AD40D0", Slot = "13")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x170000ED")]
		public override bool showBackPanel
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x1AD4130", Offset = "0x1AD2D30", VA = "0x181AD4130", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1AD3B50", Offset = "0x1AD2750", VA = "0x181AD3B50", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKPayPage.PayState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1AD3A00", Offset = "0x1AD2600", VA = "0x181AD3A00")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1AD3F50", Offset = "0x1AD2B50", VA = "0x181AD3F50")]
		private void _OnInvalidAccount()
		{
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1AD4020", Offset = "0x1AD2C20", VA = "0x181AD4020")]
		public PayCaptchaLoginState()
		{
		}

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InputField _phoneNumberInput;

		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SDKInputWarning _phoneNumberWarning;

		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SDKCaptchaWidget _captchaWidget;

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _loginBtn;

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showBackPanel;

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnInvalidAccount;

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
