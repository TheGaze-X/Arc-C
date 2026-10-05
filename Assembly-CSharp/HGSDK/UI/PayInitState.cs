using System;
using Il2CppDummyDll;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	public class PayInitState : SDKPayPage.UIState
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x170000F9")]
		public override SDKPayPage.PayState myState
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1AD5330", Offset = "0x1AD3F30", VA = "0x181AD5330", Slot = "13")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x170000FA")]
		public override bool showBackPanel
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1AD5390", Offset = "0x1AD3F90", VA = "0x181AD5390", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x170000FB")]
		public override bool isCloseable
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1AD52D0", Offset = "0x1AD3ED0", VA = "0x181AD52D0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1AD5100", Offset = "0x1AD3D00", VA = "0x181AD5100", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1AD5220", Offset = "0x1AD3E20", VA = "0x181AD5220")]
		public PayInitState()
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1AD4220", Offset = "0x1AD2E20", VA = "0x181AD4220")]
		private bool <>xLuaBaseProxy_get_isCloseable()
		{
			return default(bool);
		}

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showBackPanel;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isCloseable;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
