using System;
using Il2CppDummyDll;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	public class PayProcessPaymentState : SDKPayPage.UIState
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x170000FC")]
		public override SDKPayPage.PayState myState
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1AD5D40", Offset = "0x1AD4940", VA = "0x181AD5D40", Slot = "13")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x170000FD")]
		public override bool showBackPanel
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1AD5DA0", Offset = "0x1AD49A0", VA = "0x181AD5DA0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x170000FE")]
		public override bool isCloseable
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1AD5CE0", Offset = "0x1AD48E0", VA = "0x181AD5CE0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1AD59D0", Offset = "0x1AD45D0", VA = "0x181AD59D0", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1AD5BD0", Offset = "0x1AD47D0", VA = "0x181AD5BD0")]
		private void _OnPaymentFinished()
		{
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1AD5C30", Offset = "0x1AD4830", VA = "0x181AD5C30")]
		public PayProcessPaymentState()
		{
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1AD4220", Offset = "0x1AD2E20", VA = "0x181AD4220")]
		private bool <>xLuaBaseProxy_get_isCloseable()
		{
			return default(bool);
		}

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showBackPanel;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isCloseable;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPaymentFinished;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
