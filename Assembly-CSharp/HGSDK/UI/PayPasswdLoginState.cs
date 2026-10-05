using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	public class PayPasswdLoginState : SDKPayPage.UIState
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x170000F0")]
		public override SDKPayPage.PayState myState
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x1AD5910", Offset = "0x1AD4510", VA = "0x181AD5910", Slot = "13")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x170000F1")]
		public override bool showBackPanel
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1AD5970", Offset = "0x1AD4570", VA = "0x181AD5970", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1AD5530", Offset = "0x1AD4130", VA = "0x181AD5530", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKPayPage.PayState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1AD53F0", Offset = "0x1AD3FF0", VA = "0x181AD53F0")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1AD5860", Offset = "0x1AD4460", VA = "0x181AD5860")]
		public PayPasswdLoginState()
		{
		}

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InputField _usernameInput;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SDKInputWarning _usernameInputWarning;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InputField _passwordInput;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SDKInputWarning _passwordInputWarning;

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _loginBtn;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showBackPanel;

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
