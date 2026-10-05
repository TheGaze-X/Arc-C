using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006553 RID: 25939
	[Token(Token = "0x2006553")]
	public class ArtMagazineDiyLeafElementViewHolder : ArtMagazineLeafElementViewHolderBase, DragAndPinchWithTargetContext.IDragAndPinchTarget
	{
		// Token: 0x17005815 RID: 22549
		// (set) Token: 0x060254C5 RID: 152773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005815")]
		public bool isTouching
		{
			[Token(Token = "0x60254C5")]
			[Address(RVA = "0x204D340", Offset = "0x204BF40", VA = "0x18204D340")]
			set
			{
			}
		}

		// Token: 0x060254C6 RID: 152774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C6")]
		[Address(RVA = "0x204CFF0", Offset = "0x204BBF0", VA = "0x18204CFF0", Slot = "12")]
		protected override void OnLeafElementViewLoaded(ArtMagazineLeafElementViewBase leafElementView)
		{
		}

		// Token: 0x060254C7 RID: 152775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C7")]
		[Address(RVA = "0x204D0E0", Offset = "0x204BCE0", VA = "0x18204D0E0", Slot = "11")]
		public override void Render(ArtMagazineLeafElementViewModel viewModel, ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x060254C8 RID: 152776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C8")]
		[Address(RVA = "0x204D2E0", Offset = "0x204BEE0", VA = "0x18204D2E0")]
		public ArtMagazineDiyLeafElementViewHolder()
		{
		}

		// Token: 0x060254C9 RID: 152777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C9")]
		[Address(RVA = "0x204D2C0", Offset = "0x204BEC0", VA = "0x18204D2C0")]
		private void <>xLuaBaseProxy_OnLeafElementViewLoaded(ArtMagazineLeafElementViewBase P0)
		{
		}

		// Token: 0x060254CA RID: 152778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254CA")]
		[Address(RVA = "0x204D2D0", Offset = "0x204BED0", VA = "0x18204D2D0")]
		private void <>xLuaBaseProxy_Render(ArtMagazineLeafElementViewModel P0, ArtMagazineLeafViewModelBase P1)
		{
		}

		// Token: 0x04034554 RID: 214356
		[Token(Token = "0x4034554")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cachedIsTouching;

		// Token: 0x04034555 RID: 214357
		[Token(Token = "0x4034555")]
		[FieldOffset(Offset = "0x54")]
		private int m_cachedEditingUpdateSeqNum;

		// Token: 0x04034556 RID: 214358
		[Token(Token = "0x4034556")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_isTouching;

		// Token: 0x04034557 RID: 214359
		[Token(Token = "0x4034557")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLeafElementViewLoaded;

		// Token: 0x04034558 RID: 214360
		[Token(Token = "0x4034558")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034559 RID: 214361
		[Token(Token = "0x4034559")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
