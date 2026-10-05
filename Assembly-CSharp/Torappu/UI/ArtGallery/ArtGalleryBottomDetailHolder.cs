using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006604 RID: 26116
	[Token(Token = "0x2006604")]
	public class ArtGalleryBottomDetailHolder : DataBinder<ArtGalleryDisplayProperty>
	{
		// Token: 0x06025852 RID: 153682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025852")]
		[Address(RVA = "0x206FF60", Offset = "0x206EB60", VA = "0x18206FF60")]
		private ArtGalleryBottomDetailViewBase _TryGetBottomDetailView(ItemType itemType)
		{
			return null;
		}

		// Token: 0x06025853 RID: 153683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025853")]
		[Address(RVA = "0x206FAE0", Offset = "0x206E6E0", VA = "0x18206FAE0", Slot = "7")]
		public override void OnValueChanged(ArtGalleryDisplayProperty property)
		{
		}

		// Token: 0x06025854 RID: 153684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025854")]
		[Address(RVA = "0x206FDE0", Offset = "0x206E9E0", VA = "0x18206FDE0")]
		private void _PlayBottomViewTween(ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam prevSelectParam, ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam newSelectParam)
		{
		}

		// Token: 0x06025855 RID: 153685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025855")]
		[Address(RVA = "0x2070120", Offset = "0x206ED20", VA = "0x182070120")]
		public ArtGalleryBottomDetailHolder()
		{
		}

		// Token: 0x04034B1B RID: 215835
		[Token(Token = "0x4034B1B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _detailRoot;

		// Token: 0x04034B1C RID: 215836
		[Token(Token = "0x4034B1C")]
		[FieldOffset(Offset = "0x28")]
		private ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam m_cachedItemSelectParam;

		// Token: 0x04034B1D RID: 215837
		[Token(Token = "0x4034B1D")]
		[FieldOffset(Offset = "0x38")]
		private EnumIntDictionary<ItemType, ArtGalleryBottomDetailViewBase> m_cachedBottomDetailViews;

		// Token: 0x04034B1E RID: 215838
		[Token(Token = "0x4034B1E")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034B1F RID: 215839
		[Token(Token = "0x4034B1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TryGetBottomDetailView;

		// Token: 0x04034B20 RID: 215840
		[Token(Token = "0x4034B20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034B21 RID: 215841
		[Token(Token = "0x4034B21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayBottomViewTween;

		// Token: 0x04034B22 RID: 215842
		[Token(Token = "0x4034B22")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
