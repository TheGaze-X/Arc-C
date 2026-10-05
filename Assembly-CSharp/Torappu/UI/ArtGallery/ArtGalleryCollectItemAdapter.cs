using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065E6 RID: 26086
	[Token(Token = "0x20065E6")]
	public class ArtGalleryCollectItemAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x060257E7 RID: 153575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60257E7")]
		[Address(RVA = "0x207BBD0", Offset = "0x207A7D0", VA = "0x18207BBD0", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x060257E8 RID: 153576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257E8")]
		[Address(RVA = "0x207BD00", Offset = "0x207A900", VA = "0x18207BD00")]
		public void UpdateViews()
		{
		}

		// Token: 0x060257E9 RID: 153577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257E9")]
		[Address(RVA = "0x207BEC0", Offset = "0x207AAC0", VA = "0x18207BEC0")]
		public ArtGalleryCollectItemAdapter()
		{
		}

		// Token: 0x04034A1C RID: 215580
		[Token(Token = "0x4034A1C")]
		[FieldOffset(Offset = "0x18")]
		public List<UIRecycleLayoutAdapter.IVirtualView> views;

		// Token: 0x04034A1D RID: 215581
		[Token(Token = "0x4034A1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x04034A1E RID: 215582
		[Token(Token = "0x4034A1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateViews;

		// Token: 0x04034A1F RID: 215583
		[Token(Token = "0x4034A1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
