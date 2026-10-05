using System;
using Il2CppDummyDll;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public class PayFinishedState : SDKPayPage.UIState
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x170000F6")]
		public override SDKPayPage.PayState myState
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1AD4390", Offset = "0x1AD2F90", VA = "0x181AD4390", Slot = "13")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x170000F7")]
		public override bool showBackPanel
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1AD43F0", Offset = "0x1AD2FF0", VA = "0x181AD43F0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x170000F8")]
		public override bool isCloseable
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1AD4330", Offset = "0x1AD2F30", VA = "0x181AD4330", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1AD4190", Offset = "0x1AD2D90", VA = "0x181AD4190", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1AD4280", Offset = "0x1AD2E80", VA = "0x181AD4280")]
		public PayFinishedState()
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1AD4220", Offset = "0x1AD2E20", VA = "0x181AD4220")]
		private bool <>xLuaBaseProxy_get_isCloseable()
		{
			return default(bool);
		}

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showBackPanel;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isCloseable;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
