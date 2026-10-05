using System;
using Il2CppDummyDll;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public class PayUpgradeMenuState : SDKPayPage.UIState
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x170000F4")]
		public override SDKPayPage.PayState myState
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1AD6CC0", Offset = "0x1AD58C0", VA = "0x181AD6CC0", Slot = "13")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x170000F5")]
		public override bool showBackPanel
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1AD6D20", Offset = "0x1AD5920", VA = "0x181AD6D20", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1AD6BB0", Offset = "0x1AD57B0", VA = "0x181AD6BB0")]
		public void EventOnRegisterClicked()
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1AD6B50", Offset = "0x1AD5750", VA = "0x181AD6B50")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1AD6C10", Offset = "0x1AD5810", VA = "0x181AD6C10")]
		public PayUpgradeMenuState()
		{
		}

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showBackPanel;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRegisterClicked;

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
