using System;
using Il2CppDummyDll;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public class SDKLoginAuthState : SDKLoginPage.UIState
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x170000DC")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1AD80A0", Offset = "0x1AD6CA0", VA = "0x181AD80A0", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1AD8020", Offset = "0x1AD6C20", VA = "0x181AD8020")]
		public SDKLoginAuthState()
		{
		}

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
