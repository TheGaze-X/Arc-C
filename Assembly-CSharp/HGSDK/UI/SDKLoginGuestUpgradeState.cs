using System;
using Il2CppDummyDll;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	public class SDKLoginGuestUpgradeState : SDKLoginPage.UIState
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x170000DF")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1AD9790", Offset = "0x1AD8390", VA = "0x181AD9790", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1AD9650", Offset = "0x1AD8250", VA = "0x181AD9650")]
		public void EventOnAccountBindingClicked()
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1AD96B0", Offset = "0x1AD82B0", VA = "0x181AD96B0")]
		public void EventOnRegisterBindingClicked()
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1AD9710", Offset = "0x1AD8310", VA = "0x181AD9710")]
		public SDKLoginGuestUpgradeState()
		{
		}

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnAccountBindingClicked;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRegisterBindingClicked;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
