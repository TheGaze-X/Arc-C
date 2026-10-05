using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001993 RID: 6547
	[Token(Token = "0x2001993")]
	public class DIYFurnitureTitleRecycleAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x0600A433 RID: 42035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A433")]
		[Address(RVA = "0x31DE8E0", Offset = "0x31DD4E0", VA = "0x1831DE8E0")]
		public DIYFurnitureTitleRecycleAdapter(List<DIYFurnitureTitleRecycleAdapter.VirtualGroupData> viewDatas, DIYFurnitureRowView prefab, DIYFurnitureTitleView titlePrefab, DIYViewListModel.DIYViewListThemeState themeState)
		{
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A434")]
		[Address(RVA = "0x31DE440", Offset = "0x31DD040", VA = "0x1831DE440")]
		private void _BuildVirtualRowViews(List<DIYItemViewData> viewDatas, ref int startIndex, ref List<UIRecycleLayoutAdapter.IVirtualView> virtualViews)
		{
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A435")]
		[Address(RVA = "0x31DE640", Offset = "0x31DD240", VA = "0x1831DE640")]
		private void _BuildVirtualTitleRowView(string text, List<DIYItemViewData> viewDatas, ref int startIndex, ref List<UIRecycleLayoutAdapter.IVirtualView> virtualViews)
		{
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A436")]
		[Address(RVA = "0x31DE270", Offset = "0x31DCE70", VA = "0x1831DE270", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x04009B5F RID: 39775
		[Token(Token = "0x4009B5F")]
		[FieldOffset(Offset = "0x18")]
		private DIYFurnitureRowView m_prefab;

		// Token: 0x04009B60 RID: 39776
		[Token(Token = "0x4009B60")]
		[FieldOffset(Offset = "0x20")]
		private DIYFurnitureTitleView m_titlePrefab;

		// Token: 0x04009B61 RID: 39777
		[Token(Token = "0x4009B61")]
		[FieldOffset(Offset = "0x28")]
		private int m_countPerRow;

		// Token: 0x04009B62 RID: 39778
		[Token(Token = "0x4009B62")]
		[FieldOffset(Offset = "0x2C")]
		private float m_rowHeight;

		// Token: 0x04009B63 RID: 39779
		[Token(Token = "0x4009B63")]
		[FieldOffset(Offset = "0x30")]
		private List<DIYFurnitureTitleRecycleAdapter.VirtualGroupData> m_viewDatas;

		// Token: 0x04009B64 RID: 39780
		[Token(Token = "0x4009B64")]
		[FieldOffset(Offset = "0x38")]
		private DIYViewListModel.DIYViewListThemeState m_themeState;

		// Token: 0x04009B65 RID: 39781
		[Token(Token = "0x4009B65")]
		[FieldOffset(Offset = "0x40")]
		public Func<DIYItemViewData, bool> OnButtonSelected;

		// Token: 0x04009B66 RID: 39782
		[Token(Token = "0x4009B66")]
		[FieldOffset(Offset = "0x48")]
		public Func<DIYItemViewData, bool> OnButtonInfo;

		// Token: 0x04009B67 RID: 39783
		[Token(Token = "0x4009B67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04009B68 RID: 39784
		[Token(Token = "0x4009B68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BuildVirtualRowViews;

		// Token: 0x04009B69 RID: 39785
		[Token(Token = "0x4009B69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BuildVirtualTitleRowView;

		// Token: 0x04009B6A RID: 39786
		[Token(Token = "0x4009B6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x02001994 RID: 6548
		[Token(Token = "0x2001994")]
		public class VirtualGroupData
		{
			// Token: 0x170012FA RID: 4858
			// (get) Token: 0x0600A437 RID: 42039 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600A438 RID: 42040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170012FA")]
			public string groupDisplayName
			{
				[Token(Token = "0x600A437")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600A438")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170012FB RID: 4859
			// (get) Token: 0x0600A439 RID: 42041 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600A43A RID: 42042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170012FB")]
			public List<DIYItemViewData> itemDataViewDatas
			{
				[Token(Token = "0x600A439")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600A43A")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600A43B RID: 42043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A43B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VirtualGroupData()
			{
			}
		}
	}
}
