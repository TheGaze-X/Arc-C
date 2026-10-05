using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006611 RID: 26129
	[Token(Token = "0x2006611")]
	public class ArtGalleryListModeNameCardSkinItemView : ArtGalleryListModeItemViewBase
	{
		// Token: 0x170058A7 RID: 22695
		// (get) Token: 0x06025887 RID: 153735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058A7")]
		protected override IArtGalleryDisplayItemViewModel displayItemViewModel
		{
			[Token(Token = "0x6025887")]
			[Address(RVA = "0x20862C0", Offset = "0x2084EC0", VA = "0x1820862C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025888 RID: 153736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025888")]
		[Address(RVA = "0x2085DC0", Offset = "0x20849C0", VA = "0x182085DC0", Slot = "5")]
		public override void Render(IArtGalleryDisplayItemViewModel artGalleryDisplayItemViewModel)
		{
		}

		// Token: 0x06025889 RID: 153737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025889")]
		[Address(RVA = "0x2086000", Offset = "0x2084C00", VA = "0x182086000")]
		private Sprite _LoadNameCardSkin(string itemId)
		{
			return null;
		}

		// Token: 0x0602588A RID: 153738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602588A")]
		[Address(RVA = "0x2086220", Offset = "0x2084E20", VA = "0x182086220")]
		public ArtGalleryListModeNameCardSkinItemView()
		{
		}

		// Token: 0x04034B9A RID: 215962
		[Token(Token = "0x4034B9A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04034B9B RID: 215963
		[Token(Token = "0x4034B9B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x04034B9C RID: 215964
		[Token(Token = "0x4034B9C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x04034B9D RID: 215965
		[Token(Token = "0x4034B9D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelCurSelect;

		// Token: 0x04034B9E RID: 215966
		[Token(Token = "0x4034B9E")]
		[FieldOffset(Offset = "0x58")]
		private ArtGalleryDisplayNameCardSkinItemViewModel m_cachedItemViewModel;

		// Token: 0x04034B9F RID: 215967
		[Token(Token = "0x4034B9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayItemViewModel;

		// Token: 0x04034BA0 RID: 215968
		[Token(Token = "0x4034BA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034BA1 RID: 215969
		[Token(Token = "0x4034BA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadNameCardSkin;

		// Token: 0x04034BA2 RID: 215970
		[Token(Token = "0x4034BA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
