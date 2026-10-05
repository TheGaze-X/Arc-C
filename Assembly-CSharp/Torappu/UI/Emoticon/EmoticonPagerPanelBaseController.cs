using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050DD RID: 20701
	[Token(Token = "0x20050DD")]
	public abstract class EmoticonPagerPanelBaseController : EmoticonPanelBaseController<EmoticonPagerPanelModel>
	{
		// Token: 0x0601E9B8 RID: 125368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9B8")]
		[Address(RVA = "0x1839D90", Offset = "0x1838990", VA = "0x181839D90", Slot = "9")]
		protected override void _InitPagerCallBack(EmoticonPanelBaseView view)
		{
		}

		// Token: 0x0601E9B9 RID: 125369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9B9")]
		[Address(RVA = "0x183A060", Offset = "0x1838C60", VA = "0x18183A060")]
		private void _OnClickLeftButton()
		{
		}

		// Token: 0x0601E9BA RID: 125370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9BA")]
		[Address(RVA = "0x183A180", Offset = "0x1838D80", VA = "0x18183A180")]
		private void _OnClickRightButton()
		{
		}

		// Token: 0x0601E9BB RID: 125371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9BB")]
		[Address(RVA = "0x183A2A0", Offset = "0x1838EA0", VA = "0x18183A2A0", Slot = "10")]
		protected virtual void _OnClosePanel()
		{
		}

		// Token: 0x0601E9BC RID: 125372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9BC")]
		[Address(RVA = "0x183A320", Offset = "0x1838F20", VA = "0x18183A320")]
		private void _OnPagerIndexChanged(int index)
		{
		}

		// Token: 0x0601E9BD RID: 125373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9BD")]
		[Address(RVA = "0x183A450", Offset = "0x1839050", VA = "0x18183A450")]
		protected EmoticonPagerPanelBaseController()
		{
		}

		// Token: 0x04029043 RID: 168003
		[Token(Token = "0x4029043")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitPagerCallBack;

		// Token: 0x04029044 RID: 168004
		[Token(Token = "0x4029044")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnClickLeftButton;

		// Token: 0x04029045 RID: 168005
		[Token(Token = "0x4029045")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnClickRightButton;

		// Token: 0x04029046 RID: 168006
		[Token(Token = "0x4029046")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClosePanel;

		// Token: 0x04029047 RID: 168007
		[Token(Token = "0x4029047")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPagerIndexChanged;

		// Token: 0x04029048 RID: 168008
		[Token(Token = "0x4029048")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
