using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	public class SDKLoginIdentityVerifyState : SDKLoginPage.UIState
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x170000E0")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1ADA830", Offset = "0x1AD9430", VA = "0x181ADA830", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1AD9AD0", Offset = "0x1AD86D0", VA = "0x181AD9AD0", Slot = "14")]
		public override void OnRegister(UIStateMachine<SDKLoginPage.LoginState> stateMachine, HGSDK.UIPage page)
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1AD97F0", Offset = "0x1AD83F0", VA = "0x181AD97F0")]
		public void EventOnSkipClicked()
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1AD9980", Offset = "0x1AD8580", VA = "0x181AD9980")]
		public void EventOnVerifyClicked()
		{
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1ADA430", Offset = "0x1AD9030", VA = "0x181ADA430")]
		private void _DoIdentityVerify()
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1ADA560", Offset = "0x1AD9160", VA = "0x181ADA560")]
		private void _OnProceed(bool isMinor)
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1ADA690", Offset = "0x1AD9290", VA = "0x181ADA690")]
		private void _OnSkipped()
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1ADA7B0", Offset = "0x1AD93B0", VA = "0x181ADA7B0")]
		public SDKLoginIdentityVerifyState()
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1AD91E0", Offset = "0x1AD7DE0", VA = "0x181AD91E0")]
		private void <>xLuaBaseProxy_OnRegister(UIStateMachine<SDKLoginPage.LoginState> P0, HGSDK.UIPage P1)
		{
		}

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _policyTitle;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _policyText;

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputField _realNameInput;

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SDKInputWarning _realNameWarning;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField _idNumberInput;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SDKInputWarning _idNumberWarning;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _verifyBtn;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _skipBtn;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnSkipClicked;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnVerifyClicked;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoIdentityVerify;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnProceed;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSkipped;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
