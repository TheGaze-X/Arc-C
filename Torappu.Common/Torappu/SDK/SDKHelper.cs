using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public class SDKHelper : Singleton<SDKHelper>, IHotfixable
	{
		// Token: 0x060009FB RID: 2555 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x555ADC0", Offset = "0x55599C0", VA = "0x18555ADC0")]
		private SDKHelper()
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x555ACE0", Offset = "0x55598E0", VA = "0x18555ACE0")]
		public void MaskSdkViewState(SDKHelper.SDKViewState newState)
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x555AD50", Offset = "0x5559950", VA = "0x18555AD50")]
		public void UnmaskSdkViewState(SDKHelper.SDKViewState newState)
		{
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x555AC20", Offset = "0x5559820", VA = "0x18555AC20")]
		public void ClearSdkViewState()
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00007694 File Offset: 0x00005894
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x555AC80", Offset = "0x5559880", VA = "0x18555AC80")]
		public bool IsU8ViewOpen()
		{
			return default(bool);
		}

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x10")]
		private int m_sdkViewStateMask;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate222 __Hotfix0_MaskSdkViewState;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate222 __Hotfix0_UnmaskSdkViewState;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ClearSdkViewState;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate21 __Hotfix0_IsU8ViewOpen;

		// Token: 0x020001AF RID: 431
		[Token(Token = "0x20001AF")]
		public enum SDKViewState
		{
			// Token: 0x040009A6 RID: 2470
			[Token(Token = "0x40009A6")]
			SDK_VIEW_NONE,
			// Token: 0x040009A7 RID: 2471
			[Token(Token = "0x40009A7")]
			SDK_VIEW_LOGIN,
			// Token: 0x040009A8 RID: 2472
			[Token(Token = "0x40009A8")]
			SDK_VIEW_SCAN_LOGIN,
			// Token: 0x040009A9 RID: 2473
			[Token(Token = "0x40009A9")]
			SDK_VIEW_INIT_LICENSE = 4,
			// Token: 0x040009AA RID: 2474
			[Token(Token = "0x40009AA")]
			SDK_VIEW_ANNOUNCEMENT = 8,
			// Token: 0x040009AB RID: 2475
			[Token(Token = "0x40009AB")]
			SDK_VIEW_GAMECENTER = 16,
			// Token: 0x040009AC RID: 2476
			[Token(Token = "0x40009AC")]
			SDK_VIEW_PAY = 32,
			// Token: 0x040009AD RID: 2477
			[Token(Token = "0x40009AD")]
			SDK_VIEW_WEBVIEW = 64,
			// Token: 0x040009AE RID: 2478
			[Token(Token = "0x40009AE")]
			SDK_VIEW_MINI_WEBVIEW = 128,
			// Token: 0x040009AF RID: 2479
			[Token(Token = "0x40009AF")]
			SDK_VIEW_UNBIND_GRANT = 256
		}
	}
}
