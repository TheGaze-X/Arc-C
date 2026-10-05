using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	public class PayIdentityVerifyState : SDKPayPage.UIState
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x170000EE")]
		public override SDKPayPage.PayState myState
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1AD5040", Offset = "0x1AD3C40", VA = "0x181AD5040", Slot = "13")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x170000EF")]
		public override bool showBackPanel
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x1AD50A0", Offset = "0x1AD3CA0", VA = "0x181AD50A0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1AD45A0", Offset = "0x1AD31A0", VA = "0x181AD45A0", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKPayPage.PayState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1AD4450", Offset = "0x1AD3050", VA = "0x181AD4450")]
		public void EventOnVerifyClicked()
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1AD4E60", Offset = "0x1AD3A60", VA = "0x181AD4E60")]
		private void _DoIdentityVerify()
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1AD4F90", Offset = "0x1AD3B90", VA = "0x181AD4F90")]
		public PayIdentityVerifyState()
		{
		}

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _policyTitle;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _policyText;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InputField _realNameInput;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SDKInputWarning _realNameWarning;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputField _idNumberInput;

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SDKInputWarning _idNumberWarning;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _verifyBtn;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showBackPanel;

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnVerifyClicked;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoIdentityVerify;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
