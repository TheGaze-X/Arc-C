using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001AA RID: 426
	[Token(Token = "0x20001AA")]
	public class PayRegisterState : SDKPayPage.UIState
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x170000F2")]
		public override SDKPayPage.PayState myState
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1AD6A90", Offset = "0x1AD5690", VA = "0x181AD6A90", Slot = "13")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x170000F3")]
		public override bool showBackPanel
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1AD6AF0", Offset = "0x1AD56F0", VA = "0x181AD6AF0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1AD5F70", Offset = "0x1AD4B70", VA = "0x181AD5F70", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKPayPage.PayState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1AD5E00", Offset = "0x1AD4A00", VA = "0x181AD5E00")]
		public void EventOnRegisterClicked()
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1AD6800", Offset = "0x1AD5400", VA = "0x181AD6800")]
		private void _OnRegisterSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1AD6720", Offset = "0x1AD5320", VA = "0x181AD6720")]
		private void _OnBindSuc(HGSDK.LoginResult result)
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1AD6650", Offset = "0x1AD5250", VA = "0x181AD6650")]
		private void _OnAccountInvalid()
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1AD69E0", Offset = "0x1AD55E0", VA = "0x181AD69E0")]
		public PayRegisterState()
		{
		}

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InputField _phoneNumberInput;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SDKInputWarning _phoneNumberWarning;

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InputField _passwdInput;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SDKInputWarning _passwdInputWarn;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputField _passwdAgainInput;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SDKInputWarning _passwdAgainInputWarning;

		// Token: 0x04000925 RID: 2341
		[Token(Token = "0x4000925")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SDKCaptchaWidget _captchaWidget;

		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Toggle _policyToggle;

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SDKToggleWarning _policyToggleWarning;

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _registerBtn;

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showBackPanel;

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnRegisterClicked;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnRegisterSuc;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBindSuc;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnAccountInvalid;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
