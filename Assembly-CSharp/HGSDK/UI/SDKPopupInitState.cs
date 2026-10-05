using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	public class SDKPopupInitState : HGSDKPopupPage.UIState
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x1700010A")]
		public override HGSDKPopupPage.PopupState myState
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1AE3870", Offset = "0x1AE2470", VA = "0x181AE3870", Slot = "13")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1AE3630", Offset = "0x1AE2230", VA = "0x181AE3630", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1AE3760", Offset = "0x1AE2360", VA = "0x181AE3760")]
		private IEnumerator _WaitForInitTargetStateCoroutine()
		{
			return null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1AE3810", Offset = "0x1AE2410", VA = "0x181AE3810")]
		public SDKPopupInitState()
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1AE0F80", Offset = "0x1ADFB80", VA = "0x181AE0F80")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__WaitForInitTargetStateCoroutine;

		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
