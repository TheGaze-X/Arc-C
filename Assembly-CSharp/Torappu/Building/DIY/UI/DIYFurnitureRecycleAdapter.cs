using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200198E RID: 6542
	[Token(Token = "0x200198E")]
	public class DIYFurnitureRecycleAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x0600A41A RID: 42010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A41A")]
		[Address(RVA = "0x31DC7C0", Offset = "0x31DB3C0", VA = "0x1831DC7C0")]
		public DIYFurnitureRecycleAdapter(List<DIYItemViewData> viewDatas, DIYFurnitureRowView prefab, DIYViewListModel.DIYViewListThemeState themeState)
		{
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A41B")]
		[Address(RVA = "0x31DC5A0", Offset = "0x31DB1A0", VA = "0x1831DC5A0", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x04009B29 RID: 39721
		[Token(Token = "0x4009B29")]
		[FieldOffset(Offset = "0x18")]
		private DIYFurnitureRowView m_prefab;

		// Token: 0x04009B2A RID: 39722
		[Token(Token = "0x4009B2A")]
		[FieldOffset(Offset = "0x20")]
		private int m_countPerRow;

		// Token: 0x04009B2B RID: 39723
		[Token(Token = "0x4009B2B")]
		[FieldOffset(Offset = "0x24")]
		private float m_rowHeight;

		// Token: 0x04009B2C RID: 39724
		[Token(Token = "0x4009B2C")]
		[FieldOffset(Offset = "0x28")]
		private DIYViewListModel.DIYViewListThemeState m_themeState;

		// Token: 0x04009B2D RID: 39725
		[Token(Token = "0x4009B2D")]
		[FieldOffset(Offset = "0x30")]
		private List<DIYItemViewData> m_viewDatas;

		// Token: 0x04009B2E RID: 39726
		[Token(Token = "0x4009B2E")]
		[FieldOffset(Offset = "0x38")]
		public Func<DIYItemViewData, bool> OnButtonSelected;

		// Token: 0x04009B2F RID: 39727
		[Token(Token = "0x4009B2F")]
		[FieldOffset(Offset = "0x40")]
		public Func<DIYItemViewData, bool> OnButtonInfo;

		// Token: 0x04009B30 RID: 39728
		[Token(Token = "0x4009B30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04009B31 RID: 39729
		[Token(Token = "0x4009B31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;
	}
}
